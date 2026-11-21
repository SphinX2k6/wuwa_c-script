using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B87 RID: 7047
	[NullableContext(2)]
	[Nullable(0)]
	public class IEnableSubLevelTransitionWithSceneCapture : IEnableSubLevelTransitionType
	{
		// Token: 0x060095B9 RID: 38329 RVA: 0x0015CE90 File Offset: 0x0015B090
		[NullableContext(0)]
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

		// Token: 0x060095BA RID: 38330 RVA: 0x0015CEC8 File Offset: 0x0015B0C8
		[NullableContext(0)]
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

		// Token: 0x060095BB RID: 38331 RVA: 0x0015CEDB File Offset: 0x0015B0DB
		[NullableContext(0)]
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

		// Token: 0x060095BC RID: 38332 RVA: 0x0015CEF0 File Offset: 0x0015B0F0
		[NullableContext(0)]
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

		// Token: 0x17002F9E RID: 12190
		// (get) Token: 0x060095BD RID: 38333 RVA: 0x0015CF4A File Offset: 0x0015B14A
		// (set) Token: 0x060095BE RID: 38334 RVA: 0x0015CF75 File Offset: 0x0015B175
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

		// Token: 0x17002F9F RID: 12191
		// (get) Token: 0x060095BF RID: 38335 RVA: 0x0015CF83 File Offset: 0x0015B183
		// (set) Token: 0x060095C0 RID: 38336 RVA: 0x0015CFAA File Offset: 0x0015B1AA
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

		// Token: 0x17002FA0 RID: 12192
		// (get) Token: 0x060095C1 RID: 38337 RVA: 0x0015CFB8 File Offset: 0x0015B1B8
		// (set) Token: 0x060095C2 RID: 38338 RVA: 0x0015CFDF File Offset: 0x0015B1DF
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

		// Token: 0x17002FA1 RID: 12193
		// (get) Token: 0x060095C3 RID: 38339 RVA: 0x0015CFED File Offset: 0x0015B1ED
		// (set) Token: 0x060095C4 RID: 38340 RVA: 0x0015D014 File Offset: 0x0015B214
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

		// Token: 0x17002FA2 RID: 12194
		// (get) Token: 0x060095C5 RID: 38341 RVA: 0x0015D024 File Offset: 0x0015B224
		// (set) Token: 0x060095C6 RID: 38342 RVA: 0x0015D05E File Offset: 0x0015B25E
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

		// Token: 0x17002FA3 RID: 12195
		// (get) Token: 0x060095C7 RID: 38343 RVA: 0x0015D06C File Offset: 0x0015B26C
		// (set) Token: 0x060095C8 RID: 38344 RVA: 0x0015D0A6 File Offset: 0x0015B2A6
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

		// Token: 0x04005CA3 RID: 23715
		protected new IEnableSubLevelTransitionWithSceneCapture FbInstance;

		// Token: 0x04005CA4 RID: 23716
		protected new IEnableSubLevelTransitionWithSceneCapture_SetValue PocoInterface;
	}
}
