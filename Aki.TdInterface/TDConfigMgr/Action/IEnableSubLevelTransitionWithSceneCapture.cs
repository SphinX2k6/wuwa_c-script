using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019F4 RID: 6644
	[NullableContext(2)]
	[Nullable(0)]
	public class IEnableSubLevelTransitionWithSceneCapture : IEnableSubLevelTransitionType
	{
		// Token: 0x06008E57 RID: 36439 RVA: 0x0014D020 File Offset: 0x0014B220
		[NullableContext(1)]
		private IEnableSubLevelTransitionWithSceneCapture_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEnableSubLevelTransitionWithSceneCapture 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEnableSubLevelTransitionWithSceneCapture_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEnableSubLevelTransitionWithSceneCapture_SetValue());
			}
			return result;
		}

		// Token: 0x06008E58 RID: 36440 RVA: 0x0014D058 File Offset: 0x0014B258
		[NullableContext(1)]
		public static IEnableSubLevelTransitionWithSceneCapture Create([Nullable(2)] IEnableSubLevelTransitionWithSceneCapture instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableSubLevelTransitionWithSceneCapture
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008E59 RID: 36441 RVA: 0x0014D06B File Offset: 0x0014B26B
		[NullableContext(1)]
		public static IEnableSubLevelTransitionWithSceneCapture CreateFromSetValue([Nullable(2)] IEnableSubLevelTransitionWithSceneCapture_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEnableSubLevelTransitionWithSceneCapture
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008E5A RID: 36442 RVA: 0x0014D080 File Offset: 0x0014B280
		[NullableContext(1)]
		public new IEnableSubLevelTransitionWithSceneCapture_SetValue ToSetValue()
		{
			return new IEnableSubLevelTransitionWithSceneCapture_SetValue
			{
				Type = this.Type,
				SceneCaptureEffect = this.SceneCaptureEffect,
				ScreenEffect = this.ScreenEffect,
				ScreenEffectLoop = this.ScreenEffectLoop,
				DelayTime = this.DelayTime,
				IsAllowInput = this.IsAllowInput
			};
		}

		// Token: 0x17002D92 RID: 11666
		// (get) Token: 0x06008E5B RID: 36443 RVA: 0x0014D0DA File Offset: 0x0014B2DA
		// (set) Token: 0x06008E5C RID: 36444 RVA: 0x0014D105 File Offset: 0x0014B305
		public override EEnableSubLevelTransitionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEnableSubLevelTransitionType.SceneCapture;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002D93 RID: 11667
		// (get) Token: 0x06008E5D RID: 36445 RVA: 0x0014D113 File Offset: 0x0014B313
		// (set) Token: 0x06008E5E RID: 36446 RVA: 0x0014D13A File Offset: 0x0014B33A
		public virtual string SceneCaptureEffect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SceneCaptureEffect;
				}
				IEnableSubLevelTransitionWithSceneCapture_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SceneCaptureEffect;
			}
			set
			{
				this.GetOrCreatePoco().SceneCaptureEffect = value;
			}
		}

		// Token: 0x17002D94 RID: 11668
		// (get) Token: 0x06008E5F RID: 36447 RVA: 0x0014D148 File Offset: 0x0014B348
		// (set) Token: 0x06008E60 RID: 36448 RVA: 0x0014D16F File Offset: 0x0014B36F
		public virtual string ScreenEffect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ScreenEffect;
				}
				IEnableSubLevelTransitionWithSceneCapture_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ScreenEffect;
			}
			set
			{
				this.GetOrCreatePoco().ScreenEffect = value;
			}
		}

		// Token: 0x17002D95 RID: 11669
		// (get) Token: 0x06008E61 RID: 36449 RVA: 0x0014D17D File Offset: 0x0014B37D
		// (set) Token: 0x06008E62 RID: 36450 RVA: 0x0014D1A4 File Offset: 0x0014B3A4
		public virtual string ScreenEffectLoop
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ScreenEffectLoop;
				}
				IEnableSubLevelTransitionWithSceneCapture_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ScreenEffectLoop;
			}
			set
			{
				this.GetOrCreatePoco().ScreenEffectLoop = value;
			}
		}

		// Token: 0x17002D96 RID: 11670
		// (get) Token: 0x06008E63 RID: 36451 RVA: 0x0014D1B4 File Offset: 0x0014B3B4
		// (set) Token: 0x06008E64 RID: 36452 RVA: 0x0014D1EE File Offset: 0x0014B3EE
		public virtual float? DelayTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayTime;
				}
				IEnableSubLevelTransitionWithSceneCapture_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DelayTime;
			}
			set
			{
				this.GetOrCreatePoco().DelayTime = value;
			}
		}

		// Token: 0x17002D97 RID: 11671
		// (get) Token: 0x06008E65 RID: 36453 RVA: 0x0014D1FC File Offset: 0x0014B3FC
		// (set) Token: 0x06008E66 RID: 36454 RVA: 0x0014D236 File Offset: 0x0014B436
		public virtual bool? IsAllowInput
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsAllowInput;
				}
				IEnableSubLevelTransitionWithSceneCapture_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsAllowInput;
			}
			set
			{
				this.GetOrCreatePoco().IsAllowInput = value;
			}
		}

		// Token: 0x04005841 RID: 22593
		protected new IEnableSubLevelTransitionWithSceneCapture FbInstance;

		// Token: 0x04005842 RID: 22594
		protected new IEnableSubLevelTransitionWithSceneCapture_SetValue PocoInterface;
	}
}
