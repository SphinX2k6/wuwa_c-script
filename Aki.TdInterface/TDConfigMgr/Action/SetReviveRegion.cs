using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002441 RID: 9281
	public class SetReviveRegion : ActionParams
	{
		// Token: 0x0600CA15 RID: 51733 RVA: 0x001CDB2C File Offset: 0x001CBD2C
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

		// Token: 0x0600CA16 RID: 51734 RVA: 0x001CDB64 File Offset: 0x001CBD64
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

		// Token: 0x0600CA17 RID: 51735 RVA: 0x001CDB77 File Offset: 0x001CBD77
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

		// Token: 0x0600CA18 RID: 51736 RVA: 0x001CDB8A File Offset: 0x001CBD8A
		public SetReviveRegion_SetValue ToSetValue()
		{
			return new SetReviveRegion_SetValue
			{
				SetReviveType = this.SetReviveType,
				ReviveId = this.ReviveId
			};
		}

		// Token: 0x17003CC2 RID: 15554
		// (get) Token: 0x0600CA19 RID: 51737 RVA: 0x001CDBA9 File Offset: 0x001CBDA9
		// (set) Token: 0x0600CA1A RID: 51738 RVA: 0x001CDBD4 File Offset: 0x001CBDD4
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

		// Token: 0x17003CC3 RID: 15555
		// (get) Token: 0x0600CA1B RID: 51739 RVA: 0x001CDBE2 File Offset: 0x001CBDE2
		// (set) Token: 0x0600CA1C RID: 51740 RVA: 0x001CDC0D File Offset: 0x001CBE0D
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

		// Token: 0x040077E4 RID: 30692
		[Nullable(2)]
		protected new SetReviveRegion FbInstance;

		// Token: 0x040077E5 RID: 30693
		[Nullable(2)]
		protected SetReviveRegion_SetValue PocoInterface;
	}
}
