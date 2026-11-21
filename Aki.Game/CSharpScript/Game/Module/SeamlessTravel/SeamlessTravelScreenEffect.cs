using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect;
using AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect.Data;
using CSharpScript.Game.Render.Effect.ScreenEffectSystem;
using UnrealEngine;

namespace CSharpScript.Game.Module.SeamlessTravel
{
	// Token: 0x02003C40 RID: 15424
	[NullableContext(1)]
	[Nullable(0)]
	public class SeamlessTravelScreenEffect
	{
		// Token: 0x170050AA RID: 20650
		// (get) Token: 0x06027832 RID: 161842 RVA: 0x00B1539D File Offset: 0x00B1359D
		public bool IsInit
		{
			get
			{
				return this.IsInitInternal;
			}
		}

		// Token: 0x06027833 RID: 161843 RVA: 0x00B153A8 File Offset: 0x00B135A8
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

		// Token: 0x06027834 RID: 161844 RVA: 0x00B15408 File Offset: 0x00B13608
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

		// Token: 0x06027835 RID: 161845 RVA: 0x00B15495 File Offset: 0x00B13695
		public void Tick(float delta)
		{
		}

		// Token: 0x06027836 RID: 161846 RVA: 0x00B15498 File Offset: 0x00B13698
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

		// Token: 0x06027837 RID: 161847 RVA: 0x00B15524 File Offset: 0x00B13724
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

		// Token: 0x06027838 RID: 161848 RVA: 0x00B155F0 File Offset: 0x00B137F0
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

		// Token: 0x06027839 RID: 161849 RVA: 0x00B15714 File Offset: 0x00B13914
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

		// Token: 0x0602783A RID: 161850 RVA: 0x00B1576B File Offset: 0x00B1396B
		public static void SetNeedRenderKuroToonDepth()
		{
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.kuro.NeedRenderKuroToonDepth 1", null);
		}

		// Token: 0x0602783B RID: 161851 RVA: 0x00B1577D File Offset: 0x00B1397D
		public static void UnsetNeedRenderKuroToonDepth()
		{
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.kuro.NeedRenderKuroToonDepth 0", null);
		}

		// Token: 0x040158BD RID: 88253
		[Nullable(2)]
		private SeamlessTravelContext Context;

		// Token: 0x040158BE RID: 88254
		[Nullable(2)]
		private string EffectPath;

		// Token: 0x040158BF RID: 88255
		[Nullable(2)]
		private EffectScreenPlayData_C EffectData;

		// Token: 0x040158C0 RID: 88256
		[Nullable(2)]
		private BP_ScreenEffectSystem_C EffectSystemInst;

		// Token: 0x040158C1 RID: 88257
		private bool IsInitInternal;

		// Token: 0x040158C2 RID: 88258
		private float EffectStartTimeMs;

		// Token: 0x040158C3 RID: 88259
		private float EffectEndTimeMs;
	}
}
