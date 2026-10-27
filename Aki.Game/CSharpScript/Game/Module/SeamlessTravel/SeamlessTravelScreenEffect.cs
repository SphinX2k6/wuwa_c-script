using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect;
using AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect.Data;
using CSharpScript.Game.Render.Effect.ScreenEffectSystem;
using UnrealEngine;

namespace CSharpScript.Game.Module.SeamlessTravel
{
	// Token: 0x02004C8F RID: 19599
	[NullableContext(1)]
	[Nullable(0)]
	public class SeamlessTravelScreenEffect
	{
		// Token: 0x17007D00 RID: 32000
		// (get) Token: 0x06032A7F RID: 207487 RVA: 0x00BD0739 File Offset: 0x00BCE939
		public bool IsInit
		{
			get
			{
				return this.IsInitInternal;
			}
		}

		// Token: 0x06032A80 RID: 207488 RVA: 0x00BD0744 File Offset: 0x00BCE944
		public void Init(SeamlessTravelContext config, Action<bool> callback)
		{
			this.Context = config;
			if (this.IsInit)
			{
				callback(true);
				return;
			}
			this.EffectPath = this.Context.EffectPath;
			this.LoadEffectAsset(delegate(bool result)
			{
				this.IsInitInternal = true;
				callback(result);
			});
		}

		// Token: 0x06032A81 RID: 207489 RVA: 0x00BD07A4 File Offset: 0x00BCE9A4
		private unsafe void LoadEffectAsset(Action<bool> callback)
		{
			string effectPath = this.EffectPath;
			bool flag = (((effectPath != null) ? new int?(effectPath.Length) : null) ?? 0) == 0;
			if (flag)
			{
				callback(true);
				return;
			}
			ResourceSystem.Instance.LoadAsync<EffectScreenPlayData_C>(this.EffectPath, delegate([Nullable(2)] EffectScreenPlayData_C effectData, string path)
			{
				if (effectData == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SeamlessTravel;
					ELogAuthor author = ELogAuthor.ZYL;
					string message = "[SeamlessTravelScreenEffect] 加载DA失败";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("path", path);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ActorName", Global.BaseCharacter);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					callback(false);
					return;
				}
				this.EffectData = effectData;
				this.EffectSystemInst = ScreenEffectSystem.GetInstance();
				float num = Math.Max(this.Context.EffectExpandTime, this.EffectData.Start);
				SeamlessTravelContext context = this.Context;
				bool flag2;
				if (context == null)
				{
					flag2 = false;
				}
				else
				{
					SeamlessTravelFinishParams finishParams = context.FinishParams;
					flag2 = ((finishParams != null) ? new bool?(finishParams.NotStopScreenEffect) : null).GetValueOrDefault();
				}
				float num2 = flag2 ? this.Context.EffectCollapseTime : Math.Max(this.Context.EffectCollapseTime, this.EffectData.End);
				this.EffectStartTimeMs = num * 1000f;
				this.EffectEndTimeMs = num2 * 1000f;
				callback(true);
			}, ResourceSystem.EResourceLoadPriority.Ui, "SeamlessTravel.ScreenEffect");
		}

		// Token: 0x06032A82 RID: 207490 RVA: 0x00BD0831 File Offset: 0x00BCEA31
		public void Tick(float delta)
		{
		}

		// Token: 0x06032A83 RID: 207491 RVA: 0x00BD0834 File Offset: 0x00BCEA34
		public void Destroy()
		{
			SeamlessTravelContext context = this.Context;
			bool flag;
			if (context == null)
			{
				flag = true;
			}
			else
			{
				SeamlessTravelFinishParams finishParams = context.FinishParams;
				flag = !((finishParams != null) ? new bool?(finishParams.NotStopScreenEffect) : null).GetValueOrDefault();
			}
			if (flag)
			{
				BP_ScreenEffectSystem_C effectSystemInst = this.EffectSystemInst;
				if (effectSystemInst != null && effectSystemInst.IsValid())
				{
					EffectScreenPlayData_C effectData = this.EffectData;
					if (effectData != null && effectData.IsValid())
					{
						this.EffectSystemInst.DestroyScreenEffect(this.EffectData);
					}
				}
			}
			this.EffectSystemInst = null;
			this.EffectData = null;
		}

		// Token: 0x06032A84 RID: 207492 RVA: 0x00BD08C0 File Offset: 0x00BCEAC0
		public void AppearEffect(Action<bool> callback)
		{
			if (!this.IsInit)
			{
				callback(false);
				return;
			}
			BP_ScreenEffectSystem_C effectSystemInst = this.EffectSystemInst;
			if (effectSystemInst != null && effectSystemInst.IsValid())
			{
				EffectScreenPlayData_C effectData = this.EffectData;
				if (effectData != null && effectData.IsValid())
				{
					SeamlessTravelScreenEffect.SetNeedRenderKuroToonDepth();
					ScreenEffectModel instance = ScreenEffectModel.Instance;
					if (instance != null)
					{
						instance.PlayScreenEffect(this.EffectPath, null, null);
					}
					if (this.EffectStartTimeMs >= 20f)
					{
						TimerSystem.Instance.Delay(delegate(float _)
						{
							Action<bool> callback3 = callback;
							if (callback3 == null)
							{
								return;
							}
							callback3(true);
						}, this.EffectStartTimeMs, null, null, true, 1f);
						return;
					}
					Action<bool> callback2 = callback;
					if (callback2 == null)
					{
						return;
					}
					callback2(true);
					return;
				}
			}
			callback(false);
		}

		// Token: 0x06032A85 RID: 207493 RVA: 0x00BD098C File Offset: 0x00BCEB8C
		public void DisappearEffect(Action<bool> callback)
		{
			if (!this.IsInit)
			{
				callback(false);
				return;
			}
			BP_ScreenEffectSystem_C effectSystemInst = this.EffectSystemInst;
			if (effectSystemInst != null && effectSystemInst.IsValid())
			{
				EffectScreenPlayData_C effectData = this.EffectData;
				if (effectData != null && effectData.IsValid())
				{
					SeamlessTravelContext context = this.Context;
					bool flag;
					if (context == null)
					{
						flag = false;
					}
					else
					{
						SeamlessTravelFinishParams finishParams = context.FinishParams;
						flag = ((finishParams != null) ? new bool?(finishParams.NotStopScreenEffect) : null).GetValueOrDefault();
					}
					if (flag)
					{
						this.EffectSystemInst.SetEffectExtraState(this.EffectData, this.Context.FinishParams.ScreenEffectExtraState);
					}
					else
					{
						ScreenEffectModel instance = ScreenEffectModel.Instance;
						if (instance != null)
						{
							instance.EndScreenEffectByPath(this.EffectPath);
						}
					}
					if (this.EffectEndTimeMs >= 20f)
					{
						TimerSystem.Instance.Delay(delegate(float _)
						{
							SeamlessTravelScreenEffect.UnsetNeedRenderKuroToonDepth();
							Action<bool> callback3 = callback;
							if (callback3 == null)
							{
								return;
							}
							callback3(true);
						}, this.EffectEndTimeMs, null, null, true, 1f);
						return;
					}
					SeamlessTravelScreenEffect.UnsetNeedRenderKuroToonDepth();
					Action<bool> callback2 = callback;
					if (callback2 == null)
					{
						return;
					}
					callback2(true);
					return;
				}
			}
			callback(false);
		}

		// Token: 0x06032A86 RID: 207494 RVA: 0x00BD0AB0 File Offset: 0x00BCECB0
		public List<AActor> GetSeamlessTravelActors(ref List<AActor> arr)
		{
			BP_ScreenEffectSystem_C effectSystemInst = this.EffectSystemInst;
			if (effectSystemInst != null && effectSystemInst.IsValid())
			{
				arr.Add(this.EffectSystemInst);
				AUIContainerActor auicontainerActor = null;
				BP_ScreenEffectSystem_C effectSystemInst2 = this.EffectSystemInst;
				if (effectSystemInst2 != null)
				{
					effectSystemInst2.GetScreenEffectGeneralRoot(ref auicontainerActor);
				}
				AUIContainerActor auicontainerActor2 = auicontainerActor;
				if (auicontainerActor2.IsValid())
				{
					arr.Add(auicontainerActor2);
				}
			}
			return arr;
		}

		// Token: 0x06032A87 RID: 207495 RVA: 0x00BD0B07 File Offset: 0x00BCED07
		public static void SetNeedRenderKuroToonDepth()
		{
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.kuro.NeedRenderKuroToonDepth 1", null);
		}

		// Token: 0x06032A88 RID: 207496 RVA: 0x00BD0B19 File Offset: 0x00BCED19
		public static void UnsetNeedRenderKuroToonDepth()
		{
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.kuro.NeedRenderKuroToonDepth 0", null);
		}

		// Token: 0x0401AF60 RID: 110432
		[Nullable(2)]
		private SeamlessTravelContext Context;

		// Token: 0x0401AF61 RID: 110433
		[Nullable(2)]
		private string EffectPath;

		// Token: 0x0401AF62 RID: 110434
		[Nullable(2)]
		private EffectScreenPlayData_C EffectData;

		// Token: 0x0401AF63 RID: 110435
		[Nullable(2)]
		private BP_ScreenEffectSystem_C EffectSystemInst;

		// Token: 0x0401AF64 RID: 110436
		private bool IsInitInternal;

		// Token: 0x0401AF65 RID: 110437
		private float EffectStartTimeMs;

		// Token: 0x0401AF66 RID: 110438
		private float EffectEndTimeMs;
	}
}
