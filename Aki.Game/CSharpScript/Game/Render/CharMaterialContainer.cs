using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialContainer;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Core.Common;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045AC RID: 17836
	[NullableContext(1)]
	[Nullable(0)]
	public class CharMaterialContainer : CharRenderBase
	{
		// Token: 0x0602DFF0 RID: 188400 RVA: 0x00A955D7 File Offset: 0x00A937D7
		public void MarkForceUpdateThisFrame()
		{
			this.ForceUpdateThisFrame = true;
		}

		// Token: 0x0602DFF1 RID: 188401 RVA: 0x00A955E0 File Offset: 0x00A937E0
		public int GetMaxUpdateParamsPerFrame()
		{
			if (this.MaxUpdateParamsPerFrame < 0)
			{
				this.MaxUpdateParamsPerFrame = (Info.Instance.IsGameRunning() ? (GlobalData.IsEs3 ? 16 : 32) : 9999);
			}
			return this.MaxUpdateParamsPerFrame;
		}

		// Token: 0x0602DFF2 RID: 188402 RVA: 0x00A95618 File Offset: 0x00A93818
		public unsafe override void Awake(CharRenderingComponent renderComponent)
		{
			base.Awake(renderComponent);
			AActor owner = this.RenderComponent.GetOwner();
			if (owner == null || !owner.IsValid())
			{
				Log.Instance.Error(ELogModule.RenderCharacter, ELogAuthor.MY, "Actor 为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.OwnerActorName = owner.GetName();
			this.AllBodyInfoList = new Dictionary<string, CharBodyInfo>();
			TArray<UActorComponent> tarray = owner.K2_GetComponentsByClass(USkeletalMeshComponent.StaticClass());
			int num = tarray.Num();
			bool flag = false;
			bool flag2 = false;
			List<USkeletalMeshComponent> list = new List<USkeletalMeshComponent>();
			for (int i = 0; i < num; i++)
			{
				USkeletalMeshComponent uskeletalMeshComponent = tarray.Get(i) as USkeletalMeshComponent;
				if (uskeletalMeshComponent == null || !uskeletalMeshComponent.IsValid())
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.RenderCharacter;
					ELogAuthor author = ELogAuthor.ZJF;
					string message = "材质容器初始化失败，组件不可用";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Actor", this.OwnerActorName);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					string name = uskeletalMeshComponent.GetName();
					if (uskeletalMeshComponent.SkeletalMesh == null || !uskeletalMeshComponent.SkeletalMesh.IsValid())
					{
						Log instance2 = Log.Instance;
						ELogModule module2 = ELogModule.RenderCharacter;
						ELogAuthor author2 = ELogAuthor.ZJF;
						string message2 = "资产的SkeletalMeshComponent的SkeletalMesh为空";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Actor", this.OwnerActorName);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SkeletalName", name);
						instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					}
					else
					{
						if (RenderConfig.GetBodyTypeByName(name) == ECharacterBodyType.Body)
						{
							flag2 = true;
						}
						flag = (flag || this.AddSkeletalComponent(uskeletalMeshComponent, name, false));
					}
				}
			}
			if (!flag2 && list.Count > 0)
			{
				flag = (flag || this.AddSkeletalComponent(list[0], RenderConfig.MaterialControlBodyCaseArray[0], false));
				list.RemoveAt(0);
			}
			foreach (USkeletalMeshComponent uskeletalMeshComponent2 in list)
			{
				flag = (flag || this.AddSkeletalComponent(uskeletalMeshComponent2, uskeletalMeshComponent2.GetName(), false));
			}
			if (!flag)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.RenderCharacter;
				ELogAuthor author3 = ELogAuthor.MY;
				string message3 = "无Mesh类型材质控制器初始化";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Actor", this.OwnerActorName);
				instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			}
			base.OnInitSuccess();
			string name2 = "Render_CharMaterialContainer_" + this.OwnerActorName;
			this.StatTick = Stat.CreateNoFlameGraph(name2, "", "");
		}

		// Token: 0x0602DFF3 RID: 188403 RVA: 0x00A95884 File Offset: 0x00A93A84
		public unsafe bool AddSkeletalComponent(USkeletalMeshComponent skeletalComp, string skelName, bool useEmptyMaterial = false)
		{
			if (string.IsNullOrEmpty(skelName))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RenderCharacter;
				ELogAuthor author = ELogAuthor.MY;
				string message = "角色骨骼名称错误";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Actor", this.OwnerActorName);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			if (skeletalComp == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.RenderCharacter;
				ELogAuthor author2 = ELogAuthor.MY;
				string message2 = "外部传入了空的SkeletalMeshComponent";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Actor", this.OwnerActorName);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return false;
			}
			if (skeletalComp.GetOwner() == null)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.RenderCharacter;
				ELogAuthor author3 = ELogAuthor.ZJF;
				string message3 = "外部传入的SkeletalMeshComponent的Owner为空";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("Actor", this.OwnerActorName);
				instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				return false;
			}
			if (skeletalComp.SkeletalMesh == null)
			{
				Log instance4 = Log.Instance;
				ELogModule module4 = ELogModule.RenderCharacter;
				ELogAuthor author4 = ELogAuthor.MY;
				string message4 = "外部传入的SkeletalMeshComponent的SkeletalMesh为空";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Actor", this.OwnerActorName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SkeletalName", skelName);
				instance4.Error(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			bool bHiddenInGame = skeletalComp.bHiddenInGame;
			if (bHiddenInGame)
			{
				skeletalComp.SetHiddenInGame(false, false);
			}
			CharBodyInfo charBodyInfo = new CharBodyInfo();
			charBodyInfo.Init(this.OwnerActorName, skelName, skeletalComp, this, useEmptyMaterial);
			this.AllBodyInfoList.Add(skelName, charBodyInfo);
			if (bHiddenInGame)
			{
				skeletalComp.SetHiddenInGame(true, false);
			}
			return true;
		}

		// Token: 0x0602DFF4 RID: 188404 RVA: 0x00A959CF File Offset: 0x00A93BCF
		public bool RemoveSkeletalComponent(string bodyName)
		{
			if (this.AllBodyInfoList.ContainsKey(bodyName))
			{
				this.AllBodyInfoList.Remove(bodyName);
				return true;
			}
			return false;
		}

		// Token: 0x0602DFF5 RID: 188405 RVA: 0x00A959F0 File Offset: 0x00A93BF0
		public void ResetAllState()
		{
			foreach (CharBodyInfo charBodyInfo in this.AllBodyInfoList.Values)
			{
				charBodyInfo.ResetAllState();
			}
		}

		// Token: 0x0602DFF6 RID: 188406 RVA: 0x00A95A48 File Offset: 0x00A93C48
		public void UseAlphaTestCommon()
		{
			foreach (CharBodyInfo charBodyInfo in this.AllBodyInfoList.Values)
			{
				charBodyInfo.UseAlphaTestCommon();
			}
		}

		// Token: 0x0602DFF7 RID: 188407 RVA: 0x00A95AA0 File Offset: 0x00A93CA0
		public void RevertAlphaTestCommon()
		{
			foreach (CharBodyInfo charBodyInfo in this.AllBodyInfoList.Values)
			{
				charBodyInfo.RevertAlphaTestCommon();
			}
		}

		// Token: 0x0602DFF8 RID: 188408 RVA: 0x00A95AF8 File Offset: 0x00A93CF8
		public void SetColor(FName? propertyName, FLinearColor color, ECharacterBodySpecifiedType specifiedBodyType = ECharacterBodySpecifiedType.All, ECharacterSlotSpecifiedType specifiedSlotType = ECharacterSlotSpecifiedType.All)
		{
			if (FNameUtil.IsEmpty(propertyName))
			{
				return;
			}
			foreach (string key in RenderConfig.GetBodyNamesByBodyType(specifiedBodyType))
			{
				CharBodyInfo charBodyInfo;
				if (this.AllBodyInfoList.TryGetValue(key, out charBodyInfo) && charBodyInfo != null)
				{
					charBodyInfo.SetColor(propertyName.Value, color, specifiedSlotType);
				}
			}
		}

		// Token: 0x0602DFF9 RID: 188409 RVA: 0x00A95B4C File Offset: 0x00A93D4C
		public void RevertColor(FName propertyName, ECharacterBodySpecifiedType specifiedBodyType = ECharacterBodySpecifiedType.All, ECharacterSlotSpecifiedType specifiedSlotType = ECharacterSlotSpecifiedType.All)
		{
			if (FNameUtil.IsEmpty(new FName?(propertyName)))
			{
				return;
			}
			foreach (string key in RenderConfig.GetBodyNamesByBodyType(specifiedBodyType))
			{
				CharBodyInfo charBodyInfo;
				if (this.AllBodyInfoList.TryGetValue(key, out charBodyInfo) && charBodyInfo != null)
				{
					charBodyInfo.RevertColor(propertyName, specifiedSlotType);
				}
			}
		}

		// Token: 0x0602DFFA RID: 188410 RVA: 0x00A95B9C File Offset: 0x00A93D9C
		public void SetFloat(FName? propertyName, float value, ECharacterBodySpecifiedType specifiedBodyType = ECharacterBodySpecifiedType.All, ECharacterSlotSpecifiedType specifiedSlotType = ECharacterSlotSpecifiedType.All)
		{
			if (FNameUtil.IsEmpty(propertyName))
			{
				return;
			}
			foreach (string key in RenderConfig.GetBodyNamesByBodyType(specifiedBodyType))
			{
				CharBodyInfo charBodyInfo;
				if (this.AllBodyInfoList.TryGetValue(key, out charBodyInfo) && charBodyInfo != null)
				{
					charBodyInfo.SetFloat(propertyName.Value, value, specifiedSlotType);
				}
			}
		}

		// Token: 0x0602DFFB RID: 188411 RVA: 0x00A95BF0 File Offset: 0x00A93DF0
		public void RevertFloat(FName propertyName, ECharacterBodySpecifiedType specifiedBodyType = ECharacterBodySpecifiedType.All, ECharacterSlotSpecifiedType specifiedSlotType = ECharacterSlotSpecifiedType.All)
		{
			if (FNameUtil.IsEmpty(new FName?(propertyName)))
			{
				return;
			}
			foreach (string key in RenderConfig.GetBodyNamesByBodyType(specifiedBodyType))
			{
				CharBodyInfo charBodyInfo;
				if (this.AllBodyInfoList.TryGetValue(key, out charBodyInfo) && charBodyInfo != null)
				{
					charBodyInfo.RevertFloat(propertyName, specifiedSlotType);
				}
			}
		}

		// Token: 0x0602DFFC RID: 188412 RVA: 0x00A95C40 File Offset: 0x00A93E40
		[NullableContext(2)]
		public void SetTexture(FName propertyName, UTexture texture, ECharacterBodySpecifiedType specifiedBodyType = ECharacterBodySpecifiedType.All, ECharacterSlotSpecifiedType specifiedSlotType = ECharacterSlotSpecifiedType.All)
		{
			if (FNameUtil.IsEmpty(new FName?(propertyName)))
			{
				return;
			}
			if (texture == null)
			{
				return;
			}
			foreach (string key in RenderConfig.GetBodyNamesByBodyType(specifiedBodyType))
			{
				CharBodyInfo charBodyInfo;
				if (this.AllBodyInfoList.TryGetValue(key, out charBodyInfo) && charBodyInfo != null)
				{
					charBodyInfo.SetTexture(propertyName, texture, specifiedSlotType);
				}
			}
		}

		// Token: 0x0602DFFD RID: 188413 RVA: 0x00A95C98 File Offset: 0x00A93E98
		public void RevertTexture(FName propertyName, ECharacterBodySpecifiedType specifiedBodyType = ECharacterBodySpecifiedType.All, int sectionIndex = -1, ECharacterSlotSpecifiedType specifiedSlotType = ECharacterSlotSpecifiedType.All)
		{
			if (FNameUtil.IsEmpty(new FName?(propertyName)))
			{
				return;
			}
			if (sectionIndex >= 0)
			{
				Log.Instance.Error(ELogModule.RenderCharacter, ELogAuthor.ZJF, "SetColor: 不支持指定SectionIndex", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			foreach (string key in RenderConfig.GetBodyNamesByBodyType(specifiedBodyType))
			{
				CharBodyInfo charBodyInfo;
				if (this.AllBodyInfoList.TryGetValue(key, out charBodyInfo) && charBodyInfo != null)
				{
					charBodyInfo.RevertTexture(propertyName, specifiedSlotType);
				}
			}
		}

		// Token: 0x0602DFFE RID: 188414 RVA: 0x00A95D0C File Offset: 0x00A93F0C
		public void SetStarScarEnergy(float value)
		{
			foreach (CharBodyInfo charBodyInfo in this.AllBodyInfoList.Values)
			{
				charBodyInfo.SetStarScarEnergy(value);
			}
		}

		// Token: 0x0602DFFF RID: 188415 RVA: 0x00A95D64 File Offset: 0x00A93F64
		public void SetNoWater(bool value)
		{
			foreach (CharBodyInfo charBodyInfo in this.AllBodyInfoList.Values)
			{
				charBodyInfo.SetNoWater(value);
			}
		}

		// Token: 0x0602E000 RID: 188416 RVA: 0x00A95DBC File Offset: 0x00A93FBC
		public override void LateUpdate()
		{
			this.UpdateCounter++;
			AActor cachedOwner = base.GetRenderingComponent().GetCachedOwner();
			EMaterialShadingRate? meshShadingRate = null;
			ACharacter acharacter = cachedOwner as ACharacter;
			if (acharacter != null && acharacter != Global.BaseCharacter)
			{
				double num = acharacter.D_GetVelocity().SizeSquared();
				int[] motionVelocitySquared = CharRenderingComponent.MotionVelocitySquared;
				meshShadingRate = new EMaterialShadingRate?(EMaterialShadingRate.MSR_1x1);
				for (int i = motionVelocitySquared.Length - 1; i >= 0; i--)
				{
					if (num > (double)motionVelocitySquared[i])
					{
						meshShadingRate = new EMaterialShadingRate?(CharRenderingComponent.MotionMeshShadingRate[i]);
						break;
					}
				}
			}
			List<CharBodyInfo> list = new List<CharBodyInfo>();
			foreach (CharBodyInfo charBodyInfo in this.AllBodyInfoList.Values)
			{
				bool flag = false;
				for (int j = 0; j < list.Count; j++)
				{
					if (list[j].LastUpdateCounter > charBodyInfo.LastUpdateCounter)
					{
						list.Insert(j, charBodyInfo);
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					list.Add(charBodyInfo);
				}
			}
			int num2 = this.ForceUpdateThisFrame ? 9999 : this.GetMaxUpdateParamsPerFrame();
			this.ForceUpdateThisFrame = false;
			int num3 = 0;
			foreach (CharBodyInfo charBodyInfo2 in list)
			{
				num3 += charBodyInfo2.Update(meshShadingRate);
				charBodyInfo2.LastUpdateCounter = this.UpdateCounter;
				if (num3 > num2)
				{
					break;
				}
			}
		}

		// Token: 0x0602E001 RID: 188417 RVA: 0x00A95F5C File Offset: 0x00A9415C
		public override void Destroy()
		{
			foreach (CharBodyInfo charBodyInfo in this.AllBodyInfoList.Values)
			{
				if (charBodyInfo.SkeletalComp != null && charBodyInfo.SkeletalComp.IsValid())
				{
					charBodyInfo.Update(null);
				}
			}
			this.AllBodyInfoList.Clear();
		}

		// Token: 0x0602E002 RID: 188418 RVA: 0x00A95FE0 File Offset: 0x00A941E0
		public override int GetComponentId()
		{
			return 1;
		}

		// Token: 0x0602E003 RID: 188419 RVA: 0x00A95FE3 File Offset: 0x00A941E3
		public override string GetStatName()
		{
			return "CharMaterialContainer";
		}

		// Token: 0x0602E004 RID: 188420 RVA: 0x00A95FEC File Offset: 0x00A941EC
		public void StateEnter(CharMaterialControlRuntimeData runtimeData)
		{
			CharMaterialControlDataCache dataCache = runtimeData.DataCache;
			runtimeData.HasReverted = false;
			ECharacterControllerApplyType? materialModifyType = dataCache.MaterialModifyType;
			ECharacterControllerApplyType echaracterControllerApplyType = ECharacterControllerApplyType.ModifyProperty;
			if (materialModifyType.GetValueOrDefault() == echaracterControllerApplyType & materialModifyType != null)
			{
				if (dataCache.UseRim)
				{
					this.StartRim(runtimeData);
				}
				if (dataCache.UseDissolve)
				{
					this.OnStartDissolve(runtimeData);
				}
				if (dataCache.UseOutline)
				{
					this.OnStartOutline(runtimeData);
				}
				if (dataCache.UseColor)
				{
					this.StartColor(runtimeData);
				}
				if (dataCache.UseTextureSample)
				{
					this.StartSampleTexture(runtimeData);
				}
				if (dataCache.UseMotionOffset)
				{
					this.OnStartMotionOffset(runtimeData);
				}
				if (dataCache.UseDitherEffect)
				{
					this.OnStartDither(runtimeData);
					return;
				}
			}
			else
			{
				materialModifyType = dataCache.MaterialModifyType;
				echaracterControllerApplyType = ECharacterControllerApplyType.ReplaceMaterial;
				if (materialModifyType.GetValueOrDefault() == echaracterControllerApplyType & materialModifyType != null)
				{
					this.OnStartMaterialReplace(runtimeData);
				}
			}
		}

		// Token: 0x0602E005 RID: 188421 RVA: 0x00A960B4 File Offset: 0x00A942B4
		public void StateUpdate(CharMaterialControlRuntimeData runtimeData)
		{
			CharMaterialControlDataCache dataCache = runtimeData.DataCache;
			ECharacterControllerApplyType? materialModifyType = dataCache.MaterialModifyType;
			ECharacterControllerApplyType echaracterControllerApplyType = ECharacterControllerApplyType.ModifyProperty;
			if (materialModifyType.GetValueOrDefault() == echaracterControllerApplyType & materialModifyType != null)
			{
				if (dataCache.UseRim)
				{
					this.OnUpdateRim(runtimeData);
				}
				if (dataCache.UseDissolve)
				{
					this.OnUpdateDissolve(runtimeData);
				}
				if (dataCache.UseOutline)
				{
					this.OnUpdateOutline(runtimeData);
				}
				if (dataCache.UseColor)
				{
					this.OnUpdateColor(runtimeData);
				}
				if (dataCache.UseTextureSample)
				{
					this.OnUpdateSampleTexture(runtimeData);
				}
				if (dataCache.UseMotionOffset)
				{
					this.OnUpdateMotionOffset(runtimeData);
				}
				if (dataCache.UseDitherEffect)
				{
					this.OnUpdateDither(runtimeData);
				}
				if (dataCache.UseCustomMaterialEffect)
				{
					this.OnUpdateCustomMaterialEffect(runtimeData);
					return;
				}
			}
			else
			{
				materialModifyType = dataCache.MaterialModifyType;
				echaracterControllerApplyType = ECharacterControllerApplyType.ReplaceMaterial;
				if (materialModifyType.GetValueOrDefault() == echaracterControllerApplyType & materialModifyType != null)
				{
					this.OnUpdateMaterialReplace(runtimeData);
				}
			}
		}

		// Token: 0x0602E006 RID: 188422 RVA: 0x00A96184 File Offset: 0x00A94384
		public unsafe void StateRevert(CharMaterialControlRuntimeData runtimeData)
		{
			CharMaterialControlDataCache dataCache = runtimeData.DataCache;
			if (runtimeData.HasReverted)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RenderCharacter;
				ELogAuthor author = ELogAuthor.MY;
				string message = "已经执行过Revert逻辑";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Actor", this.OwnerActorName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("DataAsset", dataCache.DataName);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			runtimeData.HasReverted = true;
			ECharacterControllerApplyType? materialModifyType = dataCache.MaterialModifyType;
			ECharacterControllerApplyType echaracterControllerApplyType = ECharacterControllerApplyType.ModifyProperty;
			if (materialModifyType.GetValueOrDefault() == echaracterControllerApplyType & materialModifyType != null)
			{
				if (dataCache.UseRim)
				{
					this.OnRevertRim(runtimeData);
				}
				if (dataCache.UseDissolve)
				{
					this.OnRevertDissolve(runtimeData);
				}
				if (dataCache.UseOutline)
				{
					this.OnRevertOutline(runtimeData);
				}
				if (dataCache.UseColor)
				{
					this.OnRevertColor(runtimeData);
				}
				if (dataCache.UseTextureSample)
				{
					this.OnRevertSampleTexture(runtimeData);
				}
				if (dataCache.UseMotionOffset)
				{
					this.OnRevertMotionOffset(runtimeData);
				}
				if (dataCache.UseDitherEffect)
				{
					this.OnRevertDither(runtimeData);
				}
				if (dataCache.UseCustomMaterialEffect)
				{
					this.OnRevertCustomMaterialEffect(runtimeData);
				}
			}
			else
			{
				materialModifyType = dataCache.MaterialModifyType;
				echaracterControllerApplyType = ECharacterControllerApplyType.ReplaceMaterial;
				if (materialModifyType.GetValueOrDefault() == echaracterControllerApplyType & materialModifyType != null)
				{
					this.OnRevertMaterialReplace(runtimeData);
				}
			}
			if (dataCache.HiddenAfterEffect)
			{
				foreach (string key in runtimeData.SpecifiedMaterialIndexMap.Keys)
				{
					CharBodyInfo valueOrDefault = this.AllBodyInfoList.GetValueOrDefault(key);
					if (valueOrDefault.SkeletalComp != null && valueOrDefault.SkeletalComp.IsValid())
					{
						valueOrDefault.SkeletalComp.SetHiddenInGame(true, false);
					}
				}
			}
		}

		// Token: 0x0602E007 RID: 188423 RVA: 0x00A96344 File Offset: 0x00A94544
		private void OnStartMaterialReplace(CharMaterialControlRuntimeData runtimeData)
		{
			CharMaterialControlDataCache dataCache = runtimeData.DataCache;
			if (dataCache.ReplaceMaterialInterface == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RenderCharacter;
				ELogAuthor author = ELogAuthor.MY;
				string message = "材质替换失败，不存在替换材质";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("替换材质名称", dataCache.DataName);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			runtimeData.ReplaceMaterial = UKismetMaterialLibrary.CreateDynamicMaterialInstance(base.GetRenderingComponent(), dataCache.ReplaceMaterialInterface, default(FName), EMIDCreationFlags.None);
			if (runtimeData.ReplaceMaterial == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.RenderCharacter;
				ELogAuthor author2 = ELogAuthor.MY;
				string message2 = "材质替换失败，不存在替换材质:";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("替换材质名称", dataCache.DataName);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			this.TempReplaceMaterialBodies.Clear();
			foreach (KeyValuePair<string, List<int>> keyValuePair in runtimeData.SpecifiedMaterialIndexMap)
			{
				string key = keyValuePair.Key;
				List<int> value = keyValuePair.Value;
				CharBodyInfo valueOrDefault = this.AllBodyInfoList.GetValueOrDefault(key);
				this.TempReplaceMaterialBodies.Add(key);
				for (int i = 0; i < value.Count; i++)
				{
					CharMaterialSlot charMaterialSlot = valueOrDefault.MaterialSlotList[value[i]];
					if (dataCache.RevertMaterial)
					{
						charMaterialSlot.SetReplaceMaterial(runtimeData.ReplaceMaterial);
					}
					else
					{
						charMaterialSlot.SetDynamicMaterial(runtimeData.ReplaceMaterial);
					}
				}
			}
		}

		// Token: 0x0602E008 RID: 188424 RVA: 0x00A964B0 File Offset: 0x00A946B0
		private void OnUpdateMaterialReplace(CharMaterialControlRuntimeData runtimeData)
		{
			CharMaterialControlDataCache dataCache = runtimeData.DataCache;
			if (!dataCache.UseParameterModify)
			{
				return;
			}
			UMaterialInstanceDynamic replaceMaterial = runtimeData.ReplaceMaterial;
			InterpolateFactor interpolateFactor = runtimeData.InterpolateFactor;
			if (dataCache.FloatParameterNames != null)
			{
				for (int i = 0; i < dataCache.FloatParameterNames.Length; i++)
				{
					float floatFromGroup = RenderUtil.GetFloatFromGroup(dataCache.FloatParameterValues[i], interpolateFactor);
					replaceMaterial.SetScalarParameterValue(dataCache.FloatParameterNames[i], floatFromGroup);
				}
			}
			if (dataCache.ColorParameterNames != null)
			{
				for (int j = 0; j < dataCache.ColorParameterNames.Length; j++)
				{
					FLinearColor colorFromGroup = RenderUtil.GetColorFromGroup(dataCache.ColorParameterValues[j], interpolateFactor);
					replaceMaterial.SetVectorParameterValue(dataCache.ColorParameterNames[j], colorFromGroup);
				}
			}
		}

		// Token: 0x0602E009 RID: 188425 RVA: 0x00A96560 File Offset: 0x00A94760
		private void OnRevertMaterialReplace(CharMaterialControlRuntimeData runtimeData)
		{
			if (!runtimeData.DataCache.RevertMaterial)
			{
				return;
			}
			foreach (KeyValuePair<string, List<int>> keyValuePair in runtimeData.SpecifiedMaterialIndexMap)
			{
				string key = keyValuePair.Key;
				List<int> value = keyValuePair.Value;
				CharBodyInfo valueOrDefault = this.AllBodyInfoList.GetValueOrDefault(key);
				for (int i = 0; i < value.Count; i++)
				{
					valueOrDefault.MaterialSlotList[value[i]].RevertReplaceMaterial(runtimeData.ReplaceMaterial);
				}
			}
			runtimeData.ReplaceMaterial = null;
		}

		// Token: 0x0602E00A RID: 188426 RVA: 0x00A96610 File Offset: 0x00A94810
		private void StartRim(CharMaterialControlRuntimeData runtimeData)
		{
			bool selectedAllParts = runtimeData.SelectedAllParts;
			foreach (KeyValuePair<string, List<int>> keyValuePair in runtimeData.SpecifiedMaterialIndexMap)
			{
				string key = keyValuePair.Key;
				List<int> value = keyValuePair.Value;
				CharBodyInfo valueOrDefault = this.AllBodyInfoList.GetValueOrDefault(key);
				if (selectedAllParts)
				{
					valueOrDefault.UseBattleCommon();
				}
				else
				{
					for (int i = 0; i < value.Count; i++)
					{
						CharMaterialSlot charMaterialSlot = valueOrDefault.MaterialSlotList[value[i]];
						if (charMaterialSlot.SectionIndex != 99999)
						{
							valueOrDefault.UseBattle(charMaterialSlot.SectionIndex);
						}
					}
				}
			}
		}

		// Token: 0x0602E00B RID: 188427 RVA: 0x00A966D8 File Offset: 0x00A948D8
		private void OnUpdateRim(CharMaterialControlRuntimeData runtimeData)
		{
			CharMaterialControlDataCache dataCache = runtimeData.DataCache;
			InterpolateFactor interpolateFactor = runtimeData.InterpolateFactor;
			float floatFromGroup = RenderUtil.GetFloatFromGroup(dataCache.RimRange, interpolateFactor);
			FLinearColor colorFromGroup = RenderUtil.GetColorFromGroup(dataCache.RimColor, interpolateFactor);
			float floatFromGroup2 = RenderUtil.GetFloatFromGroup(dataCache.RimIntensity, interpolateFactor);
			foreach (KeyValuePair<string, List<int>> keyValuePair in runtimeData.SpecifiedMaterialIndexMap)
			{
				string key = keyValuePair.Key;
				List<int> value = keyValuePair.Value;
				CharBodyInfo valueOrDefault = this.AllBodyInfoList.GetValueOrDefault(key);
				for (int i = 0; i < value.Count; i++)
				{
					CharMaterialSlot charMaterialSlot = valueOrDefault.MaterialSlotList[value[i]];
					charMaterialSlot.SetFloat(RenderConfig.UseRim, 1f);
					charMaterialSlot.SetFloat(RenderConfig.RimUseTex, (float)dataCache.RimUseTex);
					charMaterialSlot.SetColor(RenderConfig.RimChannel, dataCache.RimChannel.Value);
					charMaterialSlot.SetFloat(RenderConfig.RimRange, floatFromGroup);
					charMaterialSlot.SetColor(RenderConfig.RimColor, colorFromGroup);
					charMaterialSlot.SetFloat(RenderConfig.RimIntensity, floatFromGroup2);
				}
			}
		}

		// Token: 0x0602E00C RID: 188428 RVA: 0x00A96808 File Offset: 0x00A94A08
		private void OnRevertRim(CharMaterialControlRuntimeData runtimeData)
		{
			bool selectedAllParts = runtimeData.SelectedAllParts;
			foreach (KeyValuePair<string, List<int>> keyValuePair in runtimeData.SpecifiedMaterialIndexMap)
			{
				string key = keyValuePair.Key;
				List<int> value = keyValuePair.Value;
				CharBodyInfo valueOrDefault = this.AllBodyInfoList.GetValueOrDefault(key);
				if (selectedAllParts)
				{
					valueOrDefault.RevertBattleCommon();
				}
				for (int i = 0; i < value.Count; i++)
				{
					CharMaterialSlot charMaterialSlot = valueOrDefault.MaterialSlotList[value[i]];
					charMaterialSlot.RevertProperty(RenderConfig.UseRim);
					charMaterialSlot.RevertProperty(RenderConfig.RimUseTex);
					charMaterialSlot.RevertProperty(RenderConfig.RimChannel);
					charMaterialSlot.RevertProperty(RenderConfig.RimRange);
					charMaterialSlot.RevertProperty(RenderConfig.RimColor);
					charMaterialSlot.RevertProperty(RenderConfig.RimIntensity);
					if (!selectedAllParts && charMaterialSlot.SectionIndex != 99999)
					{
						valueOrDefault.RevertBattle(charMaterialSlot.SectionIndex);
					}
				}
			}
		}

		// Token: 0x0602E00D RID: 188429 RVA: 0x00A96920 File Offset: 0x00A94B20
		private void OnStartDissolve(CharMaterialControlRuntimeData runtimeData)
		{
			bool selectedAllParts = runtimeData.SelectedAllParts;
			foreach (KeyValuePair<string, List<int>> keyValuePair in runtimeData.SpecifiedMaterialIndexMap)
			{
				string key = keyValuePair.Key;
				List<int> value = keyValuePair.Value;
				CharBodyInfo valueOrDefault = this.AllBodyInfoList.GetValueOrDefault(key);
				if (selectedAllParts)
				{
					valueOrDefault.UseBattleMaskCommon();
				}
				else
				{
					for (int i = 0; i < value.Count; i++)
					{
						CharMaterialSlot charMaterialSlot = valueOrDefault.MaterialSlotList[value[i]];
						if (charMaterialSlot.SectionIndex != 99999)
						{
							valueOrDefault.UseBattleMask(charMaterialSlot.SectionIndex);
						}
					}
				}
			}
		}

		// Token: 0x0602E00E RID: 188430 RVA: 0x00A969E8 File Offset: 0x00A94BE8
		private void OnUpdateDissolve(CharMaterialControlRuntimeData runtimeData)
		{
			CharMaterialControlDataCache dataCache = runtimeData.DataCache;
			InterpolateFactor interpolateFactor = runtimeData.InterpolateFactor;
			float floatFromGroup = RenderUtil.GetFloatFromGroup(dataCache.DissolveProgress, interpolateFactor);
			float floatFromGroup2 = RenderUtil.GetFloatFromGroup(dataCache.DissolveSmooth, interpolateFactor);
			float floatFromGroup3 = RenderUtil.GetFloatFromGroup(dataCache.DissolveColorIntensity, interpolateFactor);
			FLinearColor colorFromGroup = RenderUtil.GetColorFromGroup(dataCache.DissolveColor, interpolateFactor);
			foreach (KeyValuePair<string, List<int>> keyValuePair in runtimeData.SpecifiedMaterialIndexMap)
			{
				string key = keyValuePair.Key;
				List<int> value = keyValuePair.Value;
				CharBodyInfo valueOrDefault = this.AllBodyInfoList.GetValueOrDefault(key);
				for (int i = 0; i < value.Count; i++)
				{
					CharMaterialSlot charMaterialSlot = valueOrDefault.MaterialSlotList[value[i]];
					charMaterialSlot.SetFloat(RenderConfig.UseDissolve, 1f);
					charMaterialSlot.SetColor(RenderConfig.DissolveChannelSwitch, dataCache.DissolveChannel.Value);
					charMaterialSlot.SetFloat(RenderConfig.DissolveProgress, floatFromGroup);
					charMaterialSlot.SetFloat(RenderConfig.DissolveSmooth, floatFromGroup2);
					charMaterialSlot.SetFloat(RenderConfig.DissolveMulti, floatFromGroup3);
					charMaterialSlot.SetColor(RenderConfig.DissolveEmission, colorFromGroup);
				}
			}
		}

		// Token: 0x0602E00F RID: 188431 RVA: 0x00A96B20 File Offset: 0x00A94D20
		private void OnRevertDissolve(CharMaterialControlRuntimeData runtimeData)
		{
			bool selectedAllParts = runtimeData.SelectedAllParts;
			foreach (KeyValuePair<string, List<int>> keyValuePair in runtimeData.SpecifiedMaterialIndexMap)
			{
				string key = keyValuePair.Key;
				List<int> value = keyValuePair.Value;
				CharBodyInfo valueOrDefault = this.AllBodyInfoList.GetValueOrDefault(key);
				if (selectedAllParts)
				{
					valueOrDefault.RevertBattleMaskCommon();
				}
				for (int i = 0; i < value.Count; i++)
				{
					CharMaterialSlot charMaterialSlot = valueOrDefault.MaterialSlotList[value[i]];
					charMaterialSlot.RevertProperty(RenderConfig.UseDissolve);
					charMaterialSlot.RevertProperty(RenderConfig.DissolveChannelSwitch);
					charMaterialSlot.RevertProperty(RenderConfig.DissolveProgress);
					charMaterialSlot.RevertProperty(RenderConfig.DissolveSmooth);
					charMaterialSlot.RevertProperty(RenderConfig.DissolveMulti);
					charMaterialSlot.RevertProperty(RenderConfig.DissolveEmission);
					if (!selectedAllParts && charMaterialSlot.SectionIndex != 99999)
					{
						valueOrDefault.RevertBattleMask(charMaterialSlot.SectionIndex);
					}
				}
			}
		}

		// Token: 0x0602E010 RID: 188432 RVA: 0x00A96C38 File Offset: 0x00A94E38
		private void OnStartOutline(CharMaterialControlRuntimeData runtimeData)
		{
			if (!runtimeData.DataCache.UseOuterOutlineEffect)
			{
				return;
			}
			bool selectedAllParts = runtimeData.SelectedAllParts;
			foreach (KeyValuePair<string, List<int>> keyValuePair in runtimeData.SpecifiedMaterialIndexMap)
			{
				string key = keyValuePair.Key;
				List<int> value = keyValuePair.Value;
				CharBodyInfo valueOrDefault = this.AllBodyInfoList.GetValueOrDefault(key);
				if (selectedAllParts)
				{
					valueOrDefault.UseOutlineStencilTestCommon();
				}
				else
				{
					for (int i = 0; i < value.Count; i++)
					{
						CharMaterialSlot charMaterialSlot = valueOrDefault.MaterialSlotList[value[i]];
						if (charMaterialSlot.SectionIndex != 99999)
						{
							valueOrDefault.UseOutlineStencilTest(charMaterialSlot.SectionIndex);
						}
					}
				}
			}
		}

		// Token: 0x0602E011 RID: 188433 RVA: 0x00A96D0C File Offset: 0x00A94F0C
		private void OnUpdateOutline(CharMaterialControlRuntimeData runtimeData)
		{
			CharMaterialControlDataCache dataCache = runtimeData.DataCache;
			InterpolateFactor interpolateFactor = runtimeData.InterpolateFactor;
			float floatFromGroup = RenderUtil.GetFloatFromGroup(dataCache.OutlineWidth, interpolateFactor);
			FLinearColor colorFromGroup = RenderUtil.GetColorFromGroup(dataCache.OutlineColor, interpolateFactor);
			float floatFromGroup2 = RenderUtil.GetFloatFromGroup(dataCache.OutlineIntensity, interpolateFactor);
			foreach (KeyValuePair<string, List<int>> keyValuePair in runtimeData.SpecifiedMaterialIndexMap)
			{
				string key = keyValuePair.Key;
				List<int> value = keyValuePair.Value;
				CharBodyInfo valueOrDefault = this.AllBodyInfoList.GetValueOrDefault(key);
				for (int i = 0; i < value.Count; i++)
				{
					CharMaterialSlot charMaterialSlot = valueOrDefault.MaterialSlotList[value[i]];
					charMaterialSlot.SetFloat(RenderConfig.OutlineUseTex, dataCache.OutlineUseTex);
					charMaterialSlot.SetFloat(RenderConfig.OutlineWidth, floatFromGroup);
					charMaterialSlot.SetColor(RenderConfig.OutlineColor, colorFromGroup);
					charMaterialSlot.SetFloat(RenderConfig.OutlineColorIntensity, floatFromGroup2);
				}
			}
		}

		// Token: 0x0602E012 RID: 188434 RVA: 0x00A96E14 File Offset: 0x00A95014
		private void OnRevertOutline(CharMaterialControlRuntimeData runtimeData)
		{
			bool selectedAllParts = runtimeData.SelectedAllParts;
			foreach (KeyValuePair<string, List<int>> keyValuePair in runtimeData.SpecifiedMaterialIndexMap)
			{
				string key = keyValuePair.Key;
				List<int> value = keyValuePair.Value;
				CharBodyInfo valueOrDefault = this.AllBodyInfoList.GetValueOrDefault(key);
				if (selectedAllParts)
				{
					valueOrDefault.RevertOutlineStencilTestCommon();
				}
				for (int i = 0; i < value.Count; i++)
				{
					CharMaterialSlot charMaterialSlot = valueOrDefault.MaterialSlotList[value[i]];
					charMaterialSlot.RevertProperty(RenderConfig.OutlineUseTex);
					charMaterialSlot.RevertProperty(RenderConfig.OutlineWidth);
					charMaterialSlot.RevertProperty(RenderConfig.OutlineColor);
					charMaterialSlot.RevertProperty(RenderConfig.OutlineColorIntensity);
					if (!selectedAllParts && charMaterialSlot.SectionIndex != 99999)
					{
						valueOrDefault.RevertOutlineStencilTest(charMaterialSlot.SectionIndex);
					}
				}
			}
		}

		// Token: 0x0602E013 RID: 188435 RVA: 0x00A96F10 File Offset: 0x00A95110
		private void StartColor(CharMaterialControlRuntimeData runtimeData)
		{
			bool selectedAllParts = runtimeData.SelectedAllParts;
			foreach (KeyValuePair<string, List<int>> keyValuePair in runtimeData.SpecifiedMaterialIndexMap)
			{
				string key = keyValuePair.Key;
				List<int> value = keyValuePair.Value;
				CharBodyInfo valueOrDefault = this.AllBodyInfoList.GetValueOrDefault(key);
				if (selectedAllParts)
				{
					valueOrDefault.UseBattleCommon();
				}
				else
				{
					for (int i = 0; i < value.Count; i++)
					{
						CharMaterialSlot charMaterialSlot = valueOrDefault.MaterialSlotList[value[i]];
						if (charMaterialSlot.SectionIndex != 99999)
						{
							valueOrDefault.UseBattle(charMaterialSlot.SectionIndex);
						}
					}
				}
			}
		}

		// Token: 0x0602E014 RID: 188436 RVA: 0x00A96FD8 File Offset: 0x00A951D8
		private void OnUpdateColor(CharMaterialControlRuntimeData runtimeData)
		{
			CharMaterialControlDataCache dataCache = runtimeData.DataCache;
			if (!dataCache.UseColor)
			{
				return;
			}
			InterpolateFactor interpolateFactor = runtimeData.InterpolateFactor;
			FLinearColor colorFromGroup = RenderUtil.GetColorFromGroup(dataCache.BaseColor, interpolateFactor);
			FLinearColor colorFromGroup2 = RenderUtil.GetColorFromGroup(dataCache.EmissionColor, interpolateFactor);
			float floatFromGroup = RenderUtil.GetFloatFromGroup(dataCache.EmissionIntensity, interpolateFactor);
			float floatFromGroup2 = RenderUtil.GetFloatFromGroup(dataCache.BaseColorIntensity, interpolateFactor);
			foreach (KeyValuePair<string, List<int>> keyValuePair in runtimeData.SpecifiedMaterialIndexMap)
			{
				string key = keyValuePair.Key;
				List<int> value = keyValuePair.Value;
				CharBodyInfo valueOrDefault = this.AllBodyInfoList.GetValueOrDefault(key);
				for (int i = 0; i < value.Count; i++)
				{
					CharMaterialSlot charMaterialSlot = valueOrDefault.MaterialSlotList[value[i]];
					charMaterialSlot.SetFloat(RenderConfig.BaseUseTex, dataCache.BaseUseTex);
					charMaterialSlot.SetColor(RenderConfig.BaseColor, colorFromGroup);
					charMaterialSlot.SetFloat(RenderConfig.BaseColorIntensity, floatFromGroup2);
					charMaterialSlot.SetFloat(RenderConfig.EmissionUseTex, dataCache.EmissionUseTex);
					charMaterialSlot.SetColor(RenderConfig.EmissionColor, colorFromGroup2);
					charMaterialSlot.SetFloat(RenderConfig.EmissionIntensity, floatFromGroup);
				}
			}
		}

		// Token: 0x0602E015 RID: 188437 RVA: 0x00A97114 File Offset: 0x00A95314
		private void OnRevertColor(CharMaterialControlRuntimeData runtimeData)
		{
			bool selectedAllParts = runtimeData.SelectedAllParts;
			foreach (KeyValuePair<string, List<int>> keyValuePair in runtimeData.SpecifiedMaterialIndexMap)
			{
				string key = keyValuePair.Key;
				List<int> value = keyValuePair.Value;
				CharBodyInfo valueOrDefault = this.AllBodyInfoList.GetValueOrDefault(key);
				if (selectedAllParts)
				{
					valueOrDefault.RevertBattleCommon();
				}
				for (int i = 0; i < value.Count; i++)
				{
					CharMaterialSlot charMaterialSlot = valueOrDefault.MaterialSlotList[value[i]];
					charMaterialSlot.RevertProperty(RenderConfig.BaseUseTex);
					charMaterialSlot.RevertProperty(RenderConfig.BaseColor);
					charMaterialSlot.RevertProperty(RenderConfig.BaseColorIntensity);
					charMaterialSlot.RevertProperty(RenderConfig.EmissionUseTex);
					charMaterialSlot.RevertProperty(RenderConfig.EmissionColor);
					charMaterialSlot.RevertProperty(RenderConfig.EmissionIntensity);
					if (!selectedAllParts && charMaterialSlot.SectionIndex != 99999)
					{
						valueOrDefault.RevertBattle(charMaterialSlot.SectionIndex);
					}
				}
			}
		}

		// Token: 0x0602E016 RID: 188438 RVA: 0x00A9722C File Offset: 0x00A9542C
		private void StartSampleTexture(CharMaterialControlRuntimeData runtimeData)
		{
			bool selectedAllParts = runtimeData.SelectedAllParts;
			foreach (KeyValuePair<string, List<int>> keyValuePair in runtimeData.SpecifiedMaterialIndexMap)
			{
				string key = keyValuePair.Key;
				List<int> value = keyValuePair.Value;
				CharBodyInfo valueOrDefault = this.AllBodyInfoList.GetValueOrDefault(key);
				if (selectedAllParts)
				{
					valueOrDefault.UseBattleCommon();
				}
				else
				{
					for (int i = 0; i < value.Count; i++)
					{
						CharMaterialSlot charMaterialSlot = valueOrDefault.MaterialSlotList[value[i]];
						if (charMaterialSlot.SectionIndex != 99999)
						{
							valueOrDefault.UseBattle(charMaterialSlot.SectionIndex);
						}
					}
				}
			}
		}

		// Token: 0x0602E017 RID: 188439 RVA: 0x00A972F4 File Offset: 0x00A954F4
		private void OnUpdateSampleTexture(CharMaterialControlRuntimeData runtimeData)
		{
			CharMaterialControlDataCache dataCache = runtimeData.DataCache;
			InterpolateFactor interpolateFactor = runtimeData.InterpolateFactor;
			FLinearColor colorFromGroup = RenderUtil.GetColorFromGroup(dataCache.TextureScaleAndOffset, interpolateFactor);
			FLinearColor colorFromGroup2 = RenderUtil.GetColorFromGroup(dataCache.TextureSpeed, interpolateFactor);
			FLinearColor colorFromGroup3 = RenderUtil.GetColorFromGroup(dataCache.TextureColorTint, interpolateFactor);
			float floatFromGroup = RenderUtil.GetFloatFromGroup(dataCache.Rotation, interpolateFactor);
			float floatFromGroup2 = RenderUtil.GetFloatFromGroup(dataCache.TextureMaskRange, interpolateFactor);
			UTexture2D maskTexture = dataCache.MaskTexture;
			foreach (KeyValuePair<string, List<int>> keyValuePair in runtimeData.SpecifiedMaterialIndexMap)
			{
				string key = keyValuePair.Key;
				List<int> value = keyValuePair.Value;
				CharBodyInfo valueOrDefault = this.AllBodyInfoList.GetValueOrDefault(key);
				for (int i = 0; i < value.Count; i++)
				{
					CharMaterialSlot charMaterialSlot = valueOrDefault.MaterialSlotList[value[i]];
					charMaterialSlot.SetFloat(RenderConfig.UseTexture, 1f);
					charMaterialSlot.SetFloat(RenderConfig.TextureUseMask, dataCache.UseAlphaToMask);
					charMaterialSlot.SetFloat(RenderConfig.TextureMaskRange, floatFromGroup2);
					charMaterialSlot.SetColor(RenderConfig.TextureScaleAndOffset, colorFromGroup);
					charMaterialSlot.SetColor(RenderConfig.TextureSpeed, colorFromGroup2);
					charMaterialSlot.SetColor(RenderConfig.TextureColor, colorFromGroup3);
					charMaterialSlot.SetFloat(RenderConfig.TextureRotation, floatFromGroup);
					charMaterialSlot.SetFloat(RenderConfig.TextureUseScreenUv, dataCache.UseScreenUv);
					if (maskTexture != null)
					{
						charMaterialSlot.SetTexture(RenderConfig.NoiseTexture, maskTexture);
					}
					charMaterialSlot.SetColor(RenderConfig.TextureUvSwitch, dataCache.UvSelection.Value);
				}
			}
		}

		// Token: 0x0602E018 RID: 188440 RVA: 0x00A974A0 File Offset: 0x00A956A0
		private void OnRevertSampleTexture(CharMaterialControlRuntimeData runtimeData)
		{
			bool selectedAllParts = runtimeData.SelectedAllParts;
			foreach (KeyValuePair<string, List<int>> keyValuePair in runtimeData.SpecifiedMaterialIndexMap)
			{
				string key = keyValuePair.Key;
				List<int> value = keyValuePair.Value;
				CharBodyInfo valueOrDefault = this.AllBodyInfoList.GetValueOrDefault(key);
				if (selectedAllParts)
				{
					valueOrDefault.RevertBattleCommon();
				}
				for (int i = 0; i < value.Count; i++)
				{
					CharMaterialSlot charMaterialSlot = valueOrDefault.MaterialSlotList[value[i]];
					charMaterialSlot.RevertProperty(RenderConfig.UseTexture);
					charMaterialSlot.RevertProperty(RenderConfig.TextureUseScreenUv);
					charMaterialSlot.RevertProperty(RenderConfig.TextureUseMask);
					charMaterialSlot.RevertProperty(RenderConfig.TextureMaskRange);
					charMaterialSlot.RevertProperty(RenderConfig.TextureUvSwitch);
					charMaterialSlot.RevertProperty(RenderConfig.TextureScaleAndOffset);
					charMaterialSlot.RevertProperty(RenderConfig.TextureSpeed);
					charMaterialSlot.RevertProperty(RenderConfig.TextureColor);
					charMaterialSlot.RevertProperty(RenderConfig.TextureRotation);
					charMaterialSlot.RevertProperty(RenderConfig.NoiseTexture);
					if (!selectedAllParts && charMaterialSlot.SectionIndex != 99999)
					{
						valueOrDefault.RevertBattle(charMaterialSlot.SectionIndex);
					}
				}
			}
		}

		// Token: 0x0602E019 RID: 188441 RVA: 0x00A975F4 File Offset: 0x00A957F4
		private void OnStartMotionOffset(CharMaterialControlRuntimeData runtimeData)
		{
			foreach (KeyValuePair<string, List<int>> keyValuePair in runtimeData.SpecifiedMaterialIndexMap)
			{
				string key = keyValuePair.Key;
				CharBodyInfo valueOrDefault = this.AllBodyInfoList.GetValueOrDefault(key);
				if (valueOrDefault.SkeletalComp != null && valueOrDefault.SkeletalComp.IsValid())
				{
					runtimeData.TargetSkeletalMesh = valueOrDefault.SkeletalComp;
					runtimeData.MotionStartLocation = new FVectorDouble?(runtimeData.TargetSkeletalMesh.D_GetSocketLocation(RenderConfig.RootName));
					if (runtimeData.MotionEndLocation == null)
					{
						runtimeData.MotionEndLocation = new List<double>
						{
							0.0,
							0.0,
							0.0
						};
						break;
					}
					break;
				}
			}
		}

		// Token: 0x0602E01A RID: 188442 RVA: 0x00A976DC File Offset: 0x00A958DC
		private void OnUpdateMotionOffset(CharMaterialControlRuntimeData runtimeData)
		{
			CharMaterialControlDataCache dataCache = runtimeData.DataCache;
			if (runtimeData.TargetSkeletalMesh == null)
			{
				return;
			}
			InterpolateFactor interpolateFactor = runtimeData.InterpolateFactor;
			double alpha = Math.Pow((double)interpolateFactor.Factor, (double)dataCache.MotionOffsetLength);
			FVectorDouble fvectorDouble = runtimeData.TargetSkeletalMesh.D_GetSocketLocation(RenderConfig.RootName);
			RenderUtil.LerpVector(runtimeData.MotionStartLocation.Value, fvectorDouble, alpha, runtimeData.MotionEndLocation.ToArray());
			double num = runtimeData.MotionEndLocation[0] - fvectorDouble.X;
			double num2 = runtimeData.MotionEndLocation[1] - fvectorDouble.Y;
			double num3 = runtimeData.MotionEndLocation[2] - fvectorDouble.Z;
			float num4 = (float)Math.Sqrt(num * num + num2 * num2 + num3 * num3);
			FLinearColor value;
			if (num4 < 100f)
			{
				value = new FLinearColor((float)num, (float)num2, (float)num3, num4);
			}
			else
			{
				value = new FLinearColor(0f, 0f, 0f, 0f);
			}
			float value2 = (num4 < 100f) ? RenderUtil.GetFloatFromGroup(dataCache.MotionNoiseSpeed, interpolateFactor) : 0f;
			foreach (KeyValuePair<string, List<int>> keyValuePair in runtimeData.SpecifiedMaterialIndexMap)
			{
				string key = keyValuePair.Key;
				List<int> value3 = keyValuePair.Value;
				CharBodyInfo valueOrDefault = this.AllBodyInfoList.GetValueOrDefault(key);
				for (int i = 0; i < value3.Count; i++)
				{
					CharMaterialSlot charMaterialSlot = valueOrDefault.MaterialSlotList[value3[i]];
					charMaterialSlot.SetFloat(RenderConfig.MotionRange, dataCache.MotionAffectVertexRange);
					charMaterialSlot.SetColor(RenderConfig.MotionOffset, value);
					charMaterialSlot.SetFloat(RenderConfig.MotionNoiseSpeed, value2);
				}
			}
		}

		// Token: 0x0602E01B RID: 188443 RVA: 0x00A978A8 File Offset: 0x00A95AA8
		private void OnRevertMotionOffset(CharMaterialControlRuntimeData runtimeData)
		{
			foreach (KeyValuePair<string, List<int>> keyValuePair in runtimeData.SpecifiedMaterialIndexMap)
			{
				string key = keyValuePair.Key;
				List<int> value = keyValuePair.Value;
				CharBodyInfo valueOrDefault = this.AllBodyInfoList.GetValueOrDefault(key);
				for (int i = 0; i < value.Count; i++)
				{
					CharMaterialSlot charMaterialSlot = valueOrDefault.MaterialSlotList[value[i]];
					charMaterialSlot.RevertProperty(RenderConfig.MotionRange);
					charMaterialSlot.RevertProperty(RenderConfig.MotionOffset);
					charMaterialSlot.RevertProperty(RenderConfig.MotionNoiseSpeed);
				}
			}
		}

		// Token: 0x0602E01C RID: 188444 RVA: 0x00A97958 File Offset: 0x00A95B58
		private void OnStartDither(CharMaterialControlRuntimeData runtimeData)
		{
			bool selectedAllParts = runtimeData.SelectedAllParts;
			foreach (KeyValuePair<string, List<int>> keyValuePair in runtimeData.SpecifiedMaterialIndexMap)
			{
				string key = keyValuePair.Key;
				List<int> value = keyValuePair.Value;
				CharBodyInfo valueOrDefault = this.AllBodyInfoList.GetValueOrDefault(key);
				if (selectedAllParts)
				{
					valueOrDefault.UseAlphaTestCommon();
				}
				else
				{
					for (int i = 0; i < value.Count; i++)
					{
						CharMaterialSlot charMaterialSlot = valueOrDefault.MaterialSlotList[value[i]];
						if (charMaterialSlot.SectionIndex != 99999)
						{
							valueOrDefault.UseAlphaTest(charMaterialSlot.SectionIndex);
						}
					}
				}
			}
		}

		// Token: 0x0602E01D RID: 188445 RVA: 0x00A97A20 File Offset: 0x00A95C20
		private void OnUpdateDither(CharMaterialControlRuntimeData runtimeData)
		{
			CharMaterialControlDataCache dataCache = runtimeData.DataCache;
			InterpolateFactor interpolateFactor = runtimeData.InterpolateFactor;
			float floatFromGroup = RenderUtil.GetFloatFromGroup(dataCache.DitherValue, interpolateFactor);
			foreach (KeyValuePair<string, List<int>> keyValuePair in runtimeData.SpecifiedMaterialIndexMap)
			{
				string key = keyValuePair.Key;
				List<int> value = keyValuePair.Value;
				CharBodyInfo valueOrDefault = this.AllBodyInfoList.GetValueOrDefault(key);
				for (int i = 0; i < value.Count; i++)
				{
					CharMaterialSlot charMaterialSlot = valueOrDefault.MaterialSlotList[value[i]];
					charMaterialSlot.SetFloat(RenderConfig.UseDitherEffect2, 1f);
					charMaterialSlot.SetFloat(RenderConfig.DitherValue2, floatFromGroup);
				}
			}
		}

		// Token: 0x0602E01E RID: 188446 RVA: 0x00A97AE8 File Offset: 0x00A95CE8
		private void OnRevertDither(CharMaterialControlRuntimeData runtimeData)
		{
			bool selectedAllParts = runtimeData.SelectedAllParts;
			foreach (KeyValuePair<string, List<int>> keyValuePair in runtimeData.SpecifiedMaterialIndexMap)
			{
				string key = keyValuePair.Key;
				List<int> value = keyValuePair.Value;
				CharBodyInfo valueOrDefault = this.AllBodyInfoList.GetValueOrDefault(key);
				if (selectedAllParts)
				{
					valueOrDefault.RevertAlphaTestCommon();
				}
				for (int i = 0; i < value.Count; i++)
				{
					CharMaterialSlot charMaterialSlot = valueOrDefault.MaterialSlotList[value[i]];
					charMaterialSlot.RevertProperty(RenderConfig.DitherValue2);
					charMaterialSlot.RevertProperty(RenderConfig.UseDitherEffect2);
					if (!selectedAllParts && charMaterialSlot.SectionIndex != 99999)
					{
						valueOrDefault.RevertAlphaTest(charMaterialSlot.SectionIndex);
					}
				}
			}
		}

		// Token: 0x0602E01F RID: 188447 RVA: 0x00A97BCC File Offset: 0x00A95DCC
		private void OnUpdateCustomMaterialEffect(CharMaterialControlRuntimeData runtimeData)
		{
			CharMaterialControlDataCache dataCache = runtimeData.DataCache;
			InterpolateFactor interpolateFactor = runtimeData.InterpolateFactor;
			foreach (KeyValuePair<string, List<int>> keyValuePair in runtimeData.SpecifiedMaterialIndexMap)
			{
				string key = keyValuePair.Key;
				List<int> value = keyValuePair.Value;
				CharBodyInfo valueOrDefault = this.AllBodyInfoList.GetValueOrDefault(key);
				for (int i = 0; i < value.Count; i++)
				{
					CharMaterialSlot charMaterialSlot = valueOrDefault.MaterialSlotList[value[i]];
					if (dataCache.CustomTextureParameterNames != null)
					{
						for (int j = 0; j < dataCache.CustomTextureParameterNames.Length; j++)
						{
							UTexture2D textureFromGroup = RenderUtil.GetTextureFromGroup(dataCache.CustomTextureParameterValues[j], interpolateFactor);
							if (textureFromGroup != null)
							{
								charMaterialSlot.SetTexture(dataCache.CustomTextureParameterNames[j], textureFromGroup);
							}
						}
					}
					if (dataCache.CustomFloatParameterNames != null)
					{
						for (int k = 0; k < dataCache.CustomFloatParameterNames.Length; k++)
						{
							float floatFromGroup = RenderUtil.GetFloatFromGroup(dataCache.CustomFloatParameterValues[k], interpolateFactor);
							charMaterialSlot.SetFloat(dataCache.CustomFloatParameterNames[k], floatFromGroup);
						}
					}
					if (dataCache.CustomColorParameterNames != null)
					{
						for (int l = 0; l < dataCache.CustomColorParameterNames.Length; l++)
						{
							FLinearColor colorFromGroup = RenderUtil.GetColorFromGroup(dataCache.CustomColorParameterValues[l], interpolateFactor);
							charMaterialSlot.SetColor(dataCache.CustomColorParameterNames[l], colorFromGroup);
						}
					}
				}
			}
		}

		// Token: 0x0602E020 RID: 188448 RVA: 0x00A97D60 File Offset: 0x00A95F60
		private void OnRevertCustomMaterialEffect(CharMaterialControlRuntimeData runtimeData)
		{
			CharMaterialControlDataCache dataCache = runtimeData.DataCache;
			foreach (KeyValuePair<string, List<int>> keyValuePair in runtimeData.SpecifiedMaterialIndexMap)
			{
				string key = keyValuePair.Key;
				List<int> value = keyValuePair.Value;
				CharBodyInfo valueOrDefault = this.AllBodyInfoList.GetValueOrDefault(key);
				for (int i = 0; i < value.Count; i++)
				{
					CharMaterialSlot charMaterialSlot = valueOrDefault.MaterialSlotList[value[i]];
					if (dataCache.CustomTextureParameterNames != null)
					{
						for (int j = 0; j < dataCache.CustomTextureParameterNames.Length; j++)
						{
							charMaterialSlot.RevertProperty(dataCache.CustomTextureParameterNames[j]);
						}
					}
					if (dataCache.CustomFloatParameterNames != null)
					{
						for (int k = 0; k < dataCache.CustomFloatParameterNames.Length; k++)
						{
							charMaterialSlot.RevertProperty(dataCache.CustomFloatParameterNames[k]);
						}
					}
					if (dataCache.CustomColorParameterNames != null)
					{
						for (int l = 0; l < dataCache.CustomColorParameterNames.Length; l++)
						{
							charMaterialSlot.RevertProperty(dataCache.CustomColorParameterNames[l]);
						}
					}
				}
			}
		}

		// Token: 0x040188E9 RID: 100585
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Dictionary<string, CharBodyInfo> AllBodyInfoList;

		// Token: 0x040188EA RID: 100586
		private string OwnerActorName = string.Empty;

		// Token: 0x040188EB RID: 100587
		private readonly List<string> TempReplaceMaterialBodies = new List<string>();

		// Token: 0x040188EC RID: 100588
		[Nullable(2)]
		private Stat StatTick;

		// Token: 0x040188ED RID: 100589
		private int UpdateCounter;

		// Token: 0x040188EE RID: 100590
		private bool ForceUpdateThisFrame;

		// Token: 0x040188EF RID: 100591
		private int MaxUpdateParamsPerFrame = -1;
	}
}
