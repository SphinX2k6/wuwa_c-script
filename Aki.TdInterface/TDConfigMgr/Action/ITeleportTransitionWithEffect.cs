using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021F3 RID: 8691
	public class ITeleportTransitionWithEffect : ITeleportTransitionType
	{
		// Token: 0x0600BD6C RID: 48492 RVA: 0x001B6050 File Offset: 0x001B4250
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

		// Token: 0x0600BD6D RID: 48493 RVA: 0x001B6088 File Offset: 0x001B4288
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

		// Token: 0x0600BD6E RID: 48494 RVA: 0x001B609B File Offset: 0x001B429B
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

		// Token: 0x0600BD6F RID: 48495 RVA: 0x001B60AE File Offset: 0x001B42AE
		public new ITeleportTransitionWithEffect_SetValue ToSetValue()
		{
			return new ITeleportTransitionWithEffect_SetValue
			{
				Type = this.Type,
				EffectDaPath = this.EffectDaPath
			};
		}

		// Token: 0x170039D9 RID: 14809
		// (get) Token: 0x0600BD70 RID: 48496 RVA: 0x001B60CD File Offset: 0x001B42CD
		// (set) Token: 0x0600BD71 RID: 48497 RVA: 0x001B60F8 File Offset: 0x001B42F8
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

		// Token: 0x170039DA RID: 14810
		// (get) Token: 0x0600BD72 RID: 48498 RVA: 0x001B6106 File Offset: 0x001B4306
		// (set) Token: 0x0600BD73 RID: 48499 RVA: 0x001B6131 File Offset: 0x001B4331
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

		// Token: 0x040071BA RID: 29114
		[Nullable(2)]
		protected new ITeleportTransitionWithEffect FbInstance;

		// Token: 0x040071BB RID: 29115
		[Nullable(2)]
		protected new ITeleportTransitionWithEffect_SetValue PocoInterface;
	}
}
