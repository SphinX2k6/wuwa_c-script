using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021D6 RID: 8662
	[NullableContext(1)]
	[Nullable(0)]
	public class SetReviveRegion : ActionParams
	{
		// Token: 0x0600BE59 RID: 48729 RVA: 0x001B64A0 File Offset: 0x001B46A0
		private SetReviveRegion_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetReviveRegion 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetReviveRegion_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetReviveRegion_SetValue());
			}
			return result;
		}

		// Token: 0x0600BE5A RID: 48730 RVA: 0x001B64D8 File Offset: 0x001B46D8
		public static SetReviveRegion Create([Nullable(2)] SetReviveRegion instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetReviveRegion
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BE5B RID: 48731 RVA: 0x001B64EB File Offset: 0x001B46EB
		public static SetReviveRegion CreateFromSetValue([Nullable(2)] SetReviveRegion_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetReviveRegion
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BE5C RID: 48732 RVA: 0x001B64FE File Offset: 0x001B46FE
		public SetReviveRegion_SetValue ToSetValue()
		{
			return new SetReviveRegion_SetValue
			{
				SetReviveType = this.SetReviveType,
				ReviveId = this.ReviveId
			};
		}

		// Token: 0x170039CD RID: 14797
		// (get) Token: 0x0600BE5D RID: 48733 RVA: 0x001B651D File Offset: 0x001B471D
		// (set) Token: 0x0600BE5E RID: 48734 RVA: 0x001B6548 File Offset: 0x001B4748
		public virtual ESetReviveType SetReviveType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SetReviveType;
				}
				if (this.PocoInterface == null)
				{
					return ESetReviveType.Add;
				}
				return this.PocoInterface.SetReviveType;
			}
			set
			{
				this.GetOrCreatePoco().SetReviveType = value;
			}
		}

		// Token: 0x170039CE RID: 14798
		// (get) Token: 0x0600BE5F RID: 48735 RVA: 0x001B6556 File Offset: 0x001B4756
		// (set) Token: 0x0600BE60 RID: 48736 RVA: 0x001B6581 File Offset: 0x001B4781
		public virtual int ReviveId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ReviveId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ReviveId;
			}
			set
			{
				this.GetOrCreatePoco().ReviveId = value;
			}
		}

		// Token: 0x0400719B RID: 29083
		[Nullable(2)]
		protected new SetReviveRegion FbInstance;

		// Token: 0x0400719C RID: 29084
		[Nullable(2)]
		protected SetReviveRegion_SetValue PocoInterface;
	}
}
