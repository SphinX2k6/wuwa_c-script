using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E1C RID: 7708
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetEntityTag
	{
		// Token: 0x0600A4DF RID: 42207 RVA: 0x00175BD0 File Offset: 0x00173DD0
		private ISetEntityTag_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetEntityTag 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetEntityTag_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetEntityTag_SetValue());
			}
			return result;
		}

		// Token: 0x0600A4E0 RID: 42208 RVA: 0x00175C08 File Offset: 0x00173E08
		public static ISetEntityTag Create([Nullable(2)] ISetEntityTag instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetEntityTag
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A4E1 RID: 42209 RVA: 0x00175C1B File Offset: 0x00173E1B
		public static ISetEntityTag CreateFromSetValue([Nullable(2)] ISetEntityTag_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetEntityTag
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A4E2 RID: 42210 RVA: 0x00175C30 File Offset: 0x00173E30
		public ISetEntityTag_SetValue ToSetValue()
		{
			return new ISetEntityTag_SetValue
			{
				EntityId = this.EntityId,
				GameplayTag = this.GameplayTag,
				SetType = this.SetType,
				DelayTime = this.DelayTime,
				BeforeHide = this.BeforeHide
			};
		}

		// Token: 0x1700329C RID: 12956
		// (get) Token: 0x0600A4E3 RID: 42211 RVA: 0x00175C7E File Offset: 0x00173E7E
		// (set) Token: 0x0600A4E4 RID: 42212 RVA: 0x00175CA9 File Offset: 0x00173EA9
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x1700329D RID: 12957
		// (get) Token: 0x0600A4E5 RID: 42213 RVA: 0x00175CB7 File Offset: 0x00173EB7
		// (set) Token: 0x0600A4E6 RID: 42214 RVA: 0x00175CE2 File Offset: 0x00173EE2
		public virtual string GameplayTag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GameplayTag;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.GameplayTag;
			}
			set
			{
				this.GetOrCreatePoco().GameplayTag = value;
			}
		}

		// Token: 0x1700329E RID: 12958
		// (get) Token: 0x0600A4E7 RID: 42215 RVA: 0x00175CF0 File Offset: 0x00173EF0
		// (set) Token: 0x0600A4E8 RID: 42216 RVA: 0x00175D1B File Offset: 0x00173F1B
		public virtual ESetEntityTagType SetType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SetType;
				}
				if (this.PocoInterface == null)
				{
					return ESetEntityTagType.Add;
				}
				return this.PocoInterface.SetType;
			}
			set
			{
				this.GetOrCreatePoco().SetType = value;
			}
		}

		// Token: 0x1700329F RID: 12959
		// (get) Token: 0x0600A4E9 RID: 42217 RVA: 0x00175D2C File Offset: 0x00173F2C
		// (set) Token: 0x0600A4EA RID: 42218 RVA: 0x00175D66 File Offset: 0x00173F66
		public virtual float? DelayTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayTime;
				}
				ISetEntityTag_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170032A0 RID: 12960
		// (get) Token: 0x0600A4EB RID: 42219 RVA: 0x00175D74 File Offset: 0x00173F74
		// (set) Token: 0x0600A4EC RID: 42220 RVA: 0x00175DAE File Offset: 0x00173FAE
		public virtual bool? BeforeHide
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BeforeHide;
				}
				ISetEntityTag_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.BeforeHide;
			}
			set
			{
				this.GetOrCreatePoco().BeforeHide = value;
			}
		}

		// Token: 0x040062AB RID: 25259
		[Nullable(2)]
		protected ISetEntityTag FbInstance;

		// Token: 0x040062AC RID: 25260
		[Nullable(2)]
		protected ISetEntityTag_SetValue PocoInterface;
	}
}
