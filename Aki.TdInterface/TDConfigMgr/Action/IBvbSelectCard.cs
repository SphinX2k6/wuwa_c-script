using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001834 RID: 6196
	[NullableContext(2)]
	[Nullable(0)]
	public class IBvbSelectCard : IBvbPlayerOperationType
	{
		// Token: 0x060084F7 RID: 34039 RVA: 0x0013C718 File Offset: 0x0013A918
		[NullableContext(1)]
		private IBvbSelectCard_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBvbSelectCard 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBvbSelectCard_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBvbSelectCard_SetValue());
			}
			return result;
		}

		// Token: 0x060084F8 RID: 34040 RVA: 0x0013C750 File Offset: 0x0013A950
		[NullableContext(1)]
		public static IBvbSelectCard Create([Nullable(2)] IBvbSelectCard instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBvbSelectCard
			{
				FbInstance = instance
			};
		}

		// Token: 0x060084F9 RID: 34041 RVA: 0x0013C763 File Offset: 0x0013A963
		[NullableContext(1)]
		public static IBvbSelectCard CreateFromSetValue([Nullable(2)] IBvbSelectCard_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBvbSelectCard
			{
				PocoInterface = value
			};
		}

		// Token: 0x060084FA RID: 34042 RVA: 0x0013C776 File Offset: 0x0013A976
		[NullableContext(1)]
		public new IBvbSelectCard_SetValue ToSetValue()
		{
			return new IBvbSelectCard_SetValue
			{
				Type = this.Type,
				CardIdList = this.CardIdList
			};
		}

		// Token: 0x17002B82 RID: 11138
		// (get) Token: 0x060084FB RID: 34043 RVA: 0x0013C795 File Offset: 0x0013A995
		// (set) Token: 0x060084FC RID: 34044 RVA: 0x0013C7C0 File Offset: 0x0013A9C0
		public override EBvbPlayerOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EBvbPlayerOperationType.BvbDeploy;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002B83 RID: 11139
		// (get) Token: 0x060084FD RID: 34045 RVA: 0x0013C7CE File Offset: 0x0013A9CE
		// (set) Token: 0x060084FE RID: 34046 RVA: 0x0013C7F5 File Offset: 0x0013A9F5
		public virtual List<int> CardIdList
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CardIdList;
				}
				IBvbSelectCard_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CardIdList;
			}
			set
			{
				this.GetOrCreatePoco().CardIdList = value;
			}
		}

		// Token: 0x0400540D RID: 21517
		protected new IBvbSelectCard FbInstance;

		// Token: 0x0400540E RID: 21518
		protected new IBvbSelectCard_SetValue PocoInterface;
	}
}
