using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CA8 RID: 7336
	public class IHideGroupType
	{
		// Token: 0x06009BCC RID: 39884 RVA: 0x00167A14 File Offset: 0x00165C14
		private IHideGroupType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHideGroupType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHideGroupType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHideGroupType_SetValue());
			}
			return result;
		}

		// Token: 0x06009BCD RID: 39885 RVA: 0x00167A4C File Offset: 0x00165C4C
		public static IHideGroupType Create([Nullable(2)] IHideGroupType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHideGroupType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009BCE RID: 39886 RVA: 0x00167A5F File Offset: 0x00165C5F
		public static IHideGroupType CreateFromSetValue([Nullable(2)] IHideGroupType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHideGroupType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009BCF RID: 39887 RVA: 0x00167A72 File Offset: 0x00165C72
		public IHideGroupType_SetValue ToSetValue()
		{
			return new IHideGroupType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170030F7 RID: 12535
		// (get) Token: 0x06009BD0 RID: 39888 RVA: 0x00167A85 File Offset: 0x00165C85
		// (set) Token: 0x06009BD1 RID: 39889 RVA: 0x00167AB0 File Offset: 0x00165CB0
		public virtual EHideType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EHideType.WorldMonsterAndMonsterTreasure;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005F64 RID: 24420
		[Nullable(2)]
		protected IHideGroupType FbInstance;

		// Token: 0x04005F65 RID: 24421
		[Nullable(2)]
		protected IHideGroupType_SetValue PocoInterface;
	}
}
