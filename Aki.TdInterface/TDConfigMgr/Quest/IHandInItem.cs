using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FAD RID: 4013
	[NullableContext(1)]
	[Nullable(0)]
	public class IHandInItem
	{
		// Token: 0x0600596C RID: 22892 RVA: 0x000D9DF0 File Offset: 0x000D7FF0
		private IHandInItem_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHandInItem 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHandInItem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHandInItem_SetValue());
			}
			return result;
		}

		// Token: 0x0600596D RID: 22893 RVA: 0x000D9E28 File Offset: 0x000D8028
		public static IHandInItem Create([Nullable(2)] IHandInItem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHandInItem
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600596E RID: 22894 RVA: 0x000D9E3B File Offset: 0x000D803B
		public static IHandInItem CreateFromSetValue([Nullable(2)] IHandInItem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHandInItem
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600596F RID: 22895 RVA: 0x000D9E4E File Offset: 0x000D804E
		public IHandInItem_SetValue ToSetValue()
		{
			return new IHandInItem_SetValue
			{
				HandInType = this.HandInType,
				ItemIds = this.ItemIds,
				Count = this.Count
			};
		}

		// Token: 0x17001DB4 RID: 7604
		// (get) Token: 0x06005970 RID: 22896 RVA: 0x000D9E79 File Offset: 0x000D8079
		// (set) Token: 0x06005971 RID: 22897 RVA: 0x000D9EA4 File Offset: 0x000D80A4
		public virtual EHandInItemType HandInType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HandInType;
				}
				if (this.PocoInterface == null)
				{
					return EHandInItemType.ItemIds;
				}
				return this.PocoInterface.HandInType;
			}
			set
			{
				this.GetOrCreatePoco().HandInType = value;
			}
		}

		// Token: 0x17001DB5 RID: 7605
		// (get) Token: 0x06005972 RID: 22898 RVA: 0x000D9EB2 File Offset: 0x000D80B2
		// (set) Token: 0x06005973 RID: 22899 RVA: 0x000D9ED9 File Offset: 0x000D80D9
		public virtual List<int> ItemIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ItemIds;
				}
				IHandInItem_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ItemIds;
			}
			set
			{
				this.GetOrCreatePoco().ItemIds = value;
			}
		}

		// Token: 0x17001DB6 RID: 7606
		// (get) Token: 0x06005974 RID: 22900 RVA: 0x000D9EE7 File Offset: 0x000D80E7
		// (set) Token: 0x06005975 RID: 22901 RVA: 0x000D9F12 File Offset: 0x000D8112
		public virtual int Count
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Count;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Count;
			}
			set
			{
				this.GetOrCreatePoco().Count = value;
			}
		}

		// Token: 0x040035F9 RID: 13817
		[Nullable(2)]
		protected IHandInItem FbInstance;

		// Token: 0x040035FA RID: 13818
		[Nullable(2)]
		protected IHandInItem_SetValue PocoInterface;
	}
}
