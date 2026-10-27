using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002202 RID: 8706
	[NullableContext(1)]
	[Nullable(0)]
	public class ShowHidedGroup : ActionParams
	{
		// Token: 0x0600BF31 RID: 48945 RVA: 0x001B7B44 File Offset: 0x001B5D44
		private ShowHidedGroup_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ShowHidedGroup 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ShowHidedGroup_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ShowHidedGroup_SetValue());
			}
			return result;
		}

		// Token: 0x0600BF32 RID: 48946 RVA: 0x001B7B7C File Offset: 0x001B5D7C
		public static ShowHidedGroup Create([Nullable(2)] ShowHidedGroup instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ShowHidedGroup
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BF33 RID: 48947 RVA: 0x001B7B8F File Offset: 0x001B5D8F
		public static ShowHidedGroup CreateFromSetValue([Nullable(2)] ShowHidedGroup_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ShowHidedGroup
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BF34 RID: 48948 RVA: 0x001B7BA2 File Offset: 0x001B5DA2
		public ShowHidedGroup_SetValue ToSetValue()
		{
			return new ShowHidedGroup_SetValue
			{
				GroupKey = this.GroupKey,
				DelayShow = this.DelayShow
			};
		}

		// Token: 0x170039F8 RID: 14840
		// (get) Token: 0x0600BF35 RID: 48949 RVA: 0x001B7BC1 File Offset: 0x001B5DC1
		// (set) Token: 0x0600BF36 RID: 48950 RVA: 0x001B7BEC File Offset: 0x001B5DEC
		public virtual string GroupKey
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GroupKey;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.GroupKey;
			}
			set
			{
				this.GetOrCreatePoco().GroupKey = value;
			}
		}

		// Token: 0x170039F9 RID: 14841
		// (get) Token: 0x0600BF37 RID: 48951 RVA: 0x001B7BFA File Offset: 0x001B5DFA
		// (set) Token: 0x0600BF38 RID: 48952 RVA: 0x001B7C25 File Offset: 0x001B5E25
		public virtual bool DelayShow
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayShow;
				}
				return this.PocoInterface != null && this.PocoInterface.DelayShow;
			}
			set
			{
				this.GetOrCreatePoco().DelayShow = value;
			}
		}

		// Token: 0x040071FA RID: 29178
		[Nullable(2)]
		protected new ShowHidedGroup FbInstance;

		// Token: 0x040071FB RID: 29179
		[Nullable(2)]
		protected ShowHidedGroup_SetValue PocoInterface;
	}
}
