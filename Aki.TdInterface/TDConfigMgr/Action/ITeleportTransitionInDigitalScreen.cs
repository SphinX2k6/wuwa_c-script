using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021E5 RID: 8677
	public class ITeleportTransitionInDigitalScreen : ITeleportTransitionType
	{
		// Token: 0x0600BD0A RID: 48394 RVA: 0x001B53CC File Offset: 0x001B35CC
		private ITeleportTransitionInDigitalScreen_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITeleportTransitionInDigitalScreen 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITeleportTransitionInDigitalScreen_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITeleportTransitionInDigitalScreen_SetValue());
			}
			return result;
		}

		// Token: 0x0600BD0B RID: 48395 RVA: 0x001B5404 File Offset: 0x001B3604
		public static ITeleportTransitionInDigitalScreen Create([Nullable(2)] ITeleportTransitionInDigitalScreen instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportTransitionInDigitalScreen
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BD0C RID: 48396 RVA: 0x001B5417 File Offset: 0x001B3617
		public static ITeleportTransitionInDigitalScreen CreateFromSetValue([Nullable(2)] ITeleportTransitionInDigitalScreen_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITeleportTransitionInDigitalScreen
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BD0D RID: 48397 RVA: 0x001B542A File Offset: 0x001B362A
		public new ITeleportTransitionInDigitalScreen_SetValue ToSetValue()
		{
			return new ITeleportTransitionInDigitalScreen_SetValue
			{
				Type = this.Type,
				ConfigId = this.ConfigId
			};
		}

		// Token: 0x170039BD RID: 14781
		// (get) Token: 0x0600BD0E RID: 48398 RVA: 0x001B5449 File Offset: 0x001B3649
		// (set) Token: 0x0600BD0F RID: 48399 RVA: 0x001B5474 File Offset: 0x001B3674
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

		// Token: 0x170039BE RID: 14782
		// (get) Token: 0x0600BD10 RID: 48400 RVA: 0x001B5482 File Offset: 0x001B3682
		// (set) Token: 0x0600BD11 RID: 48401 RVA: 0x001B54AD File Offset: 0x001B36AD
		public virtual int ConfigId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ConfigId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ConfigId;
			}
			set
			{
				this.GetOrCreatePoco().ConfigId = value;
			}
		}

		// Token: 0x04007184 RID: 29060
		[Nullable(2)]
		protected new ITeleportTransitionInDigitalScreen FbInstance;

		// Token: 0x04007185 RID: 29061
		[Nullable(2)]
		protected new ITeleportTransitionInDigitalScreen_SetValue PocoInterface;
	}
}
