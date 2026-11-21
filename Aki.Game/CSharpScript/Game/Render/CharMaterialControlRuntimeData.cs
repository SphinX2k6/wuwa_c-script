using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialContainer;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034E1 RID: 13537
	[NullableContext(2)]
	[Nullable(0)]
	public class CharMaterialControlRuntimeData
	{
		// Token: 0x06022746 RID: 141126 RVA: 0x009C675C File Offset: 0x009C495C
		[NullableContext(1)]
		public void Init(int id, PD_CharacterControllerData_C data, [Nullable(2)] UObject userData)
		{
			this.Id = id;
			this.DataCache = CharMaterialControlDataCacheMgr.Instance.GetOrCreateDataCache(data);
			this.CurrentTimeCounter = 0.0;
			this.WholeLoopTimeCounter = 0.0;
			this.LoopTimeCounter = 0.0;
			this.UserData = userData;
			this.InterpolateFactor = new InterpolateFactor();
			this.InterpolateFactor.Type = EInterpolateRangeType.Start;
			this.InterpolateFactor.Factor = 0f;
			this.HasReverted = false;
			this.IsDead = false;
			this.ReadyToDie = false;
			this.HasUpdated = !data.UpdateAtLeastOneFrame;
			this.SelectedAllParts = false;
			this.SpecifiedMaterialIndexMap = new Dictionary<string, List<int>>();
			this.ReplaceMaterial = null;
			this.DestroyCallbackSet = null;
			this.DestroyCallbackStat = Stat.CreateNoFlameGraph("[CharMaterialControlRuntimeData.Destroy] Path:" + this.DataCache.DataName, "", "");
			this.LastUpdateTime = Time.Instance.NowSeconds;
		}

		// Token: 0x06022747 RID: 141127 RVA: 0x009C685C File Offset: 0x009C4A5C
		public void Destroy()
		{
			CharMaterialControlDataCacheMgr.Instance.RecycleDataCache(this.DataCache.DataName);
			this.DataCache = null;
			if (this.DestroyCallbackSet == null)
			{
				return;
			}
			if (this.DestroyCallbackSet != null)
			{
				foreach (Action<int> action in this.DestroyCallbackSet)
				{
					action(this.Id);
				}
				this.ClearDestroyCallback();
			}
		}

		// Token: 0x06022748 RID: 141128 RVA: 0x009C68E8 File Offset: 0x009C4AE8
		public void ClearDestroyCallback()
		{
			this.DestroyCallbackSet = null;
		}

		// Token: 0x06022749 RID: 141129 RVA: 0x009C68F1 File Offset: 0x009C4AF1
		[NullableContext(1)]
		public bool AddDestroyCallback(Action<int> callback)
		{
			if (callback == null)
			{
				return false;
			}
			if (this.DestroyCallbackSet == null)
			{
				this.DestroyCallbackSet = new HashSet<Action<int>>();
			}
			if (this.DestroyCallbackSet.Contains(callback))
			{
				return false;
			}
			this.DestroyCallbackSet.Add(callback);
			return true;
		}

		// Token: 0x0602274A RID: 141130 RVA: 0x009C6929 File Offset: 0x009C4B29
		[NullableContext(1)]
		public bool RemoveDestroyCallback(Action<int> callback)
		{
			return callback != null && this.DestroyCallbackSet != null && this.DestroyCallbackSet.Remove(callback);
		}

		// Token: 0x0602274B RID: 141131 RVA: 0x009C6948 File Offset: 0x009C4B48
		[NullableContext(1)]
		public void SetSpecifiedMaterialIndex(CharMaterialContainer materialContainer)
		{
			ECharacterSlotSpecifiedType? specifiedSlotType = this.DataCache.SpecifiedSlotType;
			ECharacterSlotSpecifiedType echaracterSlotSpecifiedType = ECharacterSlotSpecifiedType.All;
			this.SelectedAllParts = ((specifiedSlotType.GetValueOrDefault() == echaracterSlotSpecifiedType & specifiedSlotType != null) && this.DataCache.SpecifiedParts == null && this.DataCache.CustomPartNames == null && this.DataCache.CustomExcludePartNames == null);
			List<string> list = null;
			ECharacterBodySpecifiedType? specifiedBodyType = this.DataCache.SpecifiedBodyType;
			ECharacterBodySpecifiedType echaracterBodySpecifiedType = ECharacterBodySpecifiedType.All;
			if (specifiedBodyType.GetValueOrDefault() == echaracterBodySpecifiedType & specifiedBodyType != null)
			{
				list = new List<string>();
				using (Dictionary<string, CharBodyInfo>.KeyCollection.Enumerator enumerator = materialContainer.AllBodyInfoList.Keys.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						string item = enumerator.Current;
						list.Add(item);
					}
					goto IL_E3;
				}
			}
			string[] bodyNamesByBodyType = RenderConfig.GetBodyNamesByBodyType(this.DataCache.SpecifiedBodyType.Value);
			list = ((bodyNamesByBodyType == null) ? null : new List<string>(bodyNamesByBodyType));
			IL_E3:
			if (list == null || list.Count == 0)
			{
				return;
			}
			for (int i = 0; i < list.Count; i++)
			{
				string text = list[i];
				CharBodyInfo charBodyInfo;
				if (materialContainer.AllBodyInfoList.TryGetValue(text, out charBodyInfo))
				{
					ECharacterBodyType? bodyType = charBodyInfo.BodyType;
					ECharacterBodyType? echaracterBodyType = bodyType;
					ECharacterBodyType echaracterBodyType2 = ECharacterBodyType.Weapon;
					if (!(echaracterBodyType.GetValueOrDefault() == echaracterBodyType2 & echaracterBodyType != null) || this.DataCache.WeaponCases == null || this.DataCache.WeaponCases.Contains(text))
					{
						echaracterBodyType = bodyType;
						echaracterBodyType2 = ECharacterBodyType.Other;
						if (!(echaracterBodyType.GetValueOrDefault() == echaracterBodyType2 & echaracterBodyType != null) || this.DataCache.OtherCases == null || this.DataCache.OtherCases.Contains(text))
						{
							int[] array = charBodyInfo.SpecifiedSlotList[(int)this.DataCache.SpecifiedSlotType.Value];
							List<int> list2 = new List<int>();
							foreach (int num in array)
							{
								CharMaterialSlot charMaterialSlot = charBodyInfo.MaterialSlotList[num];
								bool flag = false;
								bool flag2 = true;
								ECharacterMeshPart[] specifiedParts = this.DataCache.SpecifiedParts;
								if (specifiedParts != null)
								{
									int num2 = specifiedParts.Length;
									if (num2 > 0)
									{
										flag2 = false;
										for (int k = 0; k < num2; k++)
										{
											if (charMaterialSlot.MaterialPartType == specifiedParts[k])
											{
												flag = true;
												break;
											}
										}
									}
								}
								string[] customPartNames = this.DataCache.CustomPartNames;
								if (customPartNames != null)
								{
									int num3 = customPartNames.Length;
									if (num3 > 0)
									{
										flag2 = false;
										for (int l = 0; l < num3; l++)
										{
											if (charMaterialSlot.SlotName.Contains(customPartNames[l]))
											{
												flag = true;
												break;
											}
										}
									}
								}
								if (flag || flag2)
								{
									flag = true;
									string[] customExcludePartNames = this.DataCache.CustomExcludePartNames;
									if (customExcludePartNames != null)
									{
										int num4 = customExcludePartNames.Length;
										if (num4 > 0)
										{
											for (int m = 0; m < num4; m++)
											{
												if (charMaterialSlot.SlotName.Contains(customExcludePartNames[m]))
												{
													flag = false;
													break;
												}
											}
										}
									}
									if (flag)
									{
										list2.Add(num);
									}
								}
							}
							this.SpecifiedMaterialIndexMap[text] = list2;
						}
					}
				}
			}
		}

		// Token: 0x0602274C RID: 141132 RVA: 0x009C6C60 File Offset: 0x009C4E60
		public unsafe void UpdateState(double delta, float timeDilation)
		{
			if (this.IsDead)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RenderCharacter;
				ELogAuthor author = ELogAuthor.ZJF;
				string message = "RuntimeData UpdateState: 已经结束的效果，还在更新";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("id", this.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("updated", this.HasUpdated);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("data", this.DataCache.DataName);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return;
			}
			ECharacterControllerType? dataType = this.DataCache.DataType;
			ECharacterControllerType echaracterControllerType = ECharacterControllerType.Manual;
			if (dataType.GetValueOrDefault() == echaracterControllerType & dataType != null)
			{
				return;
			}
			if (this.DataCache.WholeLoopTime <= 0f)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.RenderCharacter;
				ELogAuthor author2 = ELogAuthor.ZJF;
				string message2 = "材质控制器的总时长需大于0";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("data", this.DataCache.DataName);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.IsDead = true;
				return;
			}
			dataType = this.DataCache.DataType;
			echaracterControllerType = ECharacterControllerType.Runtime;
			if ((dataType.GetValueOrDefault() == echaracterControllerType & dataType != null) && this.DataCache.DataLoopTime <= 0f)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.RenderCharacter;
				ELogAuthor author3 = ELogAuthor.ZJF;
				string message3 = "Runtime类型材质控制器的Loop时长需大于0";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("data", this.DataCache.DataName);
				instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				this.IsDead = true;
				return;
			}
			if (!this.DataCache.IgnoreTimeDilation && RenderModuleController.Instance.IsGamePaused)
			{
				return;
			}
			double num = delta;
			if (!this.DataCache.IgnoreTimeDilation)
			{
				num = delta * (double)timeDilation;
			}
			this.InitInterpolateType(num);
			this.CurrentTimeCounter += num;
			this.WholeLoopTimeCounter += num;
			this.LoopTimeCounter += num;
			float specifiedLoopTime = this.GetSpecifiedLoopTime(this.InterpolateFactor.Type);
			this.LoopTimeCounter %= (double)specifiedLoopTime;
			this.InterpolateFactor.Factor = (float)RenderUtil.Clamp(this.LoopTimeCounter / (double)specifiedLoopTime, 0.0, 1.0);
			dataType = this.DataCache.DataType;
			echaracterControllerType = ECharacterControllerType.Timeline;
			if ((dataType.GetValueOrDefault() == echaracterControllerType & dataType != null) && this.CurrentTimeCounter >= (double)this.DataCache.WholeLoopTime - num && this.HasUpdated)
			{
				this.IsDead = true;
			}
			this.HasUpdated = true;
			if (this.ReadyToDie && this.CurrentTimeCounter >= (double)this.DataCache.DataLoopEnd)
			{
				this.IsDead = true;
			}
		}

		// Token: 0x0602274D RID: 141133 RVA: 0x009C6F03 File Offset: 0x009C5103
		public void RequestEffectStateEnter()
		{
			if (this.EffectState == EMaterialControllerEffectState.Reverted)
			{
				this.EffectState = EMaterialControllerEffectState.PendingEnter;
				return;
			}
			if (this.EffectState == EMaterialControllerEffectState.PendingRevert)
			{
				this.EffectState = EMaterialControllerEffectState.Entered;
			}
		}

		// Token: 0x0602274E RID: 141134 RVA: 0x009C6F26 File Offset: 0x009C5126
		public void RequestEffectStateRevert()
		{
			if (this.EffectState == EMaterialControllerEffectState.Entered)
			{
				this.EffectState = EMaterialControllerEffectState.PendingRevert;
				return;
			}
			if (this.EffectState == EMaterialControllerEffectState.PendingEnter)
			{
				this.EffectState = EMaterialControllerEffectState.Reverted;
			}
		}

		// Token: 0x0602274F RID: 141135 RVA: 0x009C6F48 File Offset: 0x009C5148
		[NullableContext(1)]
		public void UpdateEffect(CharMaterialContainer materialContainer)
		{
			if (this.IsDead)
			{
				this.RequestEffectStateRevert();
			}
			if (this.EffectState == EMaterialControllerEffectState.Reverted)
			{
				return;
			}
			if (this.EffectState == EMaterialControllerEffectState.PendingEnter)
			{
				materialContainer.StateEnter(this);
				this.EffectState = EMaterialControllerEffectState.Entered;
				materialContainer.StateUpdate(this);
				return;
			}
			if (this.EffectState == EMaterialControllerEffectState.PendingRevert)
			{
				materialContainer.StateRevert(this);
				this.EffectState = EMaterialControllerEffectState.Reverted;
				return;
			}
			materialContainer.StateUpdate(this);
		}

		// Token: 0x06022750 RID: 141136 RVA: 0x009C6FAC File Offset: 0x009C51AC
		private void InitInterpolateType(double delta)
		{
			float dataLoopStart = this.DataCache.DataLoopStart;
			float dataLoopTime = this.DataCache.DataLoopTime;
			if (!this.ReadyToDie && this.WholeLoopTimeCounter <= (double)dataLoopStart - delta)
			{
				if (this.InterpolateFactor.Type != EInterpolateRangeType.Start)
				{
					this.LoopTimeCounter = 0.0;
				}
				this.InterpolateFactor.Type = EInterpolateRangeType.Start;
				return;
			}
			if (!this.ReadyToDie && this.WholeLoopTimeCounter <= (double)(dataLoopStart + dataLoopTime) - delta)
			{
				if (this.InterpolateFactor.Type != EInterpolateRangeType.Loop)
				{
					this.LoopTimeCounter = 0.0;
				}
				this.InterpolateFactor.Type = EInterpolateRangeType.Loop;
				return;
			}
			if (this.WholeLoopTimeCounter <= (double)this.DataCache.WholeLoopTime)
			{
				if (this.InterpolateFactor.Type != EInterpolateRangeType.End)
				{
					this.LoopTimeCounter = 0.0;
				}
				if (!this.ReadyToDie)
				{
					ECharacterControllerType? dataType = this.DataCache.DataType;
					ECharacterControllerType echaracterControllerType = ECharacterControllerType.Runtime;
					if (dataType.GetValueOrDefault() == echaracterControllerType & dataType != null)
					{
						this.InterpolateFactor.Type = EInterpolateRangeType.Loop;
						this.WholeLoopTimeCounter -= (double)dataLoopTime;
						return;
					}
				}
				this.InterpolateFactor.Type = EInterpolateRangeType.End;
			}
		}

		// Token: 0x06022751 RID: 141137 RVA: 0x009C70D4 File Offset: 0x009C52D4
		public unsafe void SetReadyToDie()
		{
			this.ReadyToDie = true;
			if (this.InterpolateFactor.Type == EInterpolateRangeType.End)
			{
				double num = (double)this.DataCache.WholeLoopTime - this.WholeLoopTimeCounter;
				if (num < (double)this.DataCache.DataLoopEnd)
				{
					this.CurrentTimeCounter = (double)this.DataCache.DataLoopEnd - num;
					return;
				}
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RenderCharacter;
				ELogAuthor author = ELogAuthor.ZJF;
				string message = "SetReadyToDie: End阶段的剩余时间小于End时间";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("leftTime", num);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("WholeLoopTimeCounter", this.WholeLoopTimeCounter);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("WholeLoopTime", this.DataCache.WholeLoopTime);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("DataLoopEnd", this.DataCache.DataLoopEnd);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			}
			this.CurrentTimeCounter = 0.0;
		}

		// Token: 0x06022752 RID: 141138 RVA: 0x009C71F0 File Offset: 0x009C53F0
		public void SetProgress(float progress)
		{
			ECharacterControllerType? dataType = this.DataCache.DataType;
			ECharacterControllerType echaracterControllerType = ECharacterControllerType.Manual;
			if (!(dataType.GetValueOrDefault() == echaracterControllerType & dataType != null))
			{
				return;
			}
			float num = MathUtils.Instance.Clamp(progress, 0f, 1f);
			float progress2 = this.DataCache.WholeLoopTime * num;
			this.InitInterpolateTypeManual(progress2);
		}

		// Token: 0x06022753 RID: 141139 RVA: 0x009C724C File Offset: 0x009C544C
		private void InitInterpolateTypeManual(float progress)
		{
			float dataLoopStart = this.DataCache.DataLoopStart;
			float dataLoopTime = this.DataCache.DataLoopTime;
			if (progress <= dataLoopStart)
			{
				this.InterpolateFactor.Type = EInterpolateRangeType.Start;
				this.InterpolateFactor.Factor = (float)MathUtils.Instance.SafeDivide((double)progress, (double)dataLoopStart);
			}
			else if (progress <= dataLoopStart + dataLoopTime)
			{
				this.InterpolateFactor.Type = EInterpolateRangeType.Loop;
				this.InterpolateFactor.Factor = (float)MathUtils.Instance.SafeDivide((double)(progress - dataLoopStart), (double)dataLoopTime);
			}
			else if (progress <= this.DataCache.WholeLoopTime)
			{
				this.InterpolateFactor.Type = EInterpolateRangeType.End;
				this.InterpolateFactor.Factor = (float)MathUtils.Instance.SafeDivide((double)(progress - dataLoopStart - dataLoopTime), (double)this.DataCache.DataLoopEnd);
			}
			this.InterpolateFactor.Factor = MathUtils.Instance.Clamp(this.InterpolateFactor.Factor, 0f, 1f);
		}

		// Token: 0x06022754 RID: 141140 RVA: 0x009C7339 File Offset: 0x009C5539
		public float GetSpecifiedLoopTime(EInterpolateRangeType interpolateType)
		{
			switch (interpolateType)
			{
			case EInterpolateRangeType.Start:
				return this.DataCache.DataLoopStart;
			case EInterpolateRangeType.Loop:
				return this.DataCache.DataLoopTime;
			case EInterpolateRangeType.End:
				return this.DataCache.DataLoopEnd;
			default:
				return 0f;
			}
		}

		// Token: 0x04012FCE RID: 77774
		public int Id;

		// Token: 0x04012FCF RID: 77775
		public CharMaterialControlDataCache DataCache;

		// Token: 0x04012FD0 RID: 77776
		public UObject UserData;

		// Token: 0x04012FD1 RID: 77777
		public double CurrentTimeCounter;

		// Token: 0x04012FD2 RID: 77778
		public double WholeLoopTimeCounter;

		// Token: 0x04012FD3 RID: 77779
		public InterpolateFactor InterpolateFactor;

		// Token: 0x04012FD4 RID: 77780
		public double LoopTimeCounter;

		// Token: 0x04012FD5 RID: 77781
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Dictionary<string, List<int>> SpecifiedMaterialIndexMap;

		// Token: 0x04012FD6 RID: 77782
		public bool SelectedAllParts;

		// Token: 0x04012FD7 RID: 77783
		public bool ReadyToDie;

		// Token: 0x04012FD8 RID: 77784
		public bool IsDead;

		// Token: 0x04012FD9 RID: 77785
		public EMaterialControllerEffectState EffectState;

		// Token: 0x04012FDA RID: 77786
		public bool HasReverted;

		// Token: 0x04012FDB RID: 77787
		private bool HasUpdated;

		// Token: 0x04012FDC RID: 77788
		public UMaterialInstanceDynamic ReplaceMaterial;

		// Token: 0x04012FDD RID: 77789
		public FVectorDouble? MotionStartLocation;

		// Token: 0x04012FDE RID: 77790
		public USkeletalMeshComponent TargetSkeletalMesh;

		// Token: 0x04012FDF RID: 77791
		public List<double> MotionEndLocation;

		// Token: 0x04012FE0 RID: 77792
		private Stat DestroyCallbackStat;

		// Token: 0x04012FE1 RID: 77793
		public double LastUpdateTime;

		// Token: 0x04012FE2 RID: 77794
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private HashSet<Action<int>> DestroyCallbackSet;
	}
}
