using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FB0 RID: 8112
	[NullableContext(1)]
	[Nullable(0)]
	public class ITeleportTransitionWithEffect : ITeleportTransitionType
	{
		// Token: 0x0600B268 RID: 45672 RVA: 0x0019FCA0 File Offset: 0x0019DEA0
		private ITeleportTransitionWithEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITeleportTransitionWithEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITeleportTransitionWithEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITeleportTransitionWithEffect_SetValue());
			}
			return result;
		}

		// Token: 0x0600B269 RID: 45673 RVA: 0x0019FCD8 File Offset: 0x0019DED8
		public static ITeleportTransitionWithEffect Create([Nullable(2)] ITeleportTransitionWithEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportTransitionWithEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B26A RID: 45674 RVA: 0x0019FCEB File Offset: 0x0019DEEB
		public static ITeleportTransitionWithEffect CreateFromSetValue([Nullable(2)] ITeleportTransitionWithEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITeleportTransitionWithEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B26B RID: 45675 RVA: 0x0019FCFE File Offset: 0x0019DEFE
		public new ITeleportTransitionWithEffect_SetValue ToSetValue()
		{
			return new ITeleportTransitionWithEffect_SetValue
			{
				Type = this.Type,
				EffectDaPath = this.EffectDaPath
			};
		}

		// Token: 0x17003704 RID: 14084
		// (get) Token: 0x0600B26C RID: 45676 RVA: 0x0019FD1D File Offset: 0x0019DF1D
		// (set) Token: 0x0600B26D RID: 45677 RVA: 0x0019FD48 File Offset: 0x0019DF48
		public override ETeleportTransitionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETeleportTransitionType.PlayMp4;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003705 RID: 14085
		// (get) Token: 0x0600B26E RID: 45678 RVA: 0x0019FD56 File Offset: 0x0019DF56
		// (set) Token: 0x0600B26F RID: 45679 RVA: 0x0019FD81 File Offset: 0x0019DF81
		public virtual string EffectDaPath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EffectDaPath;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.EffectDaPath;
			}
			set
			{
				this.GetOrCreatePoco().EffectDaPath = value;
			}
		}

		// Token: 0x04006BBF RID: 27583
		[Nullable(2)]
		protected new ITeleportTransitionWithEffect FbInstance;

		// Token: 0x04006BC0 RID: 27584
		[Nullable(2)]
		protected new ITeleportTransitionWithEffect_SetValue PocoInterface;
	}
}
