using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FAF RID: 4015
	[NullableContext(1)]
	[Nullable(0)]
	public class IHandInItemRange
	{
		// Token: 0x06005978 RID: 22904 RVA: 0x000D9F30 File Offset: 0x000D8130
		private IHandInItemRange_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHandInItemRange 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHandInItemRange_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHandInItemRange_SetValue());
			}
			return result;
		}

		// Token: 0x06005979 RID: 22905 RVA: 0x000D9F68 File Offset: 0x000D8168
		public static IHandInItemRange Create([Nullable(2)] IHandInItemRange instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHandInItemRange
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600597A RID: 22906 RVA: 0x000D9F7B File Offset: 0x000D817B
		public static IHandInItemRange CreateFromSetValue([Nullable(2)] IHandInItemRange_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHandInItemRange
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600597B RID: 22907 RVA: 0x000D9F8E File Offset: 0x000D818E
		public IHandInItemRange_SetValue ToSetValue()
		{
			return new IHandInItemRange_SetValue
			{
				HandInType = this.HandInType,
				ItemIds = this.ItemIds
			};
		}

		// Token: 0x17001DB7 RID: 7607
		// (get) Token: 0x0600597C RID: 22908 RVA: 0x000D9FAD File Offset: 0x000D81AD
		// (set) Token: 0x0600597D RID: 22909 RVA: 0x000D9FD8 File Offset: 0x000D81D8
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

		// Token: 0x17001DB8 RID: 7608
		// (get) Token: 0x0600597E RID: 22910 RVA: 0x000D9FE6 File Offset: 0x000D81E6
		// (set) Token: 0x0600597F RID: 22911 RVA: 0x000DA00D File Offset: 0x000D820D
		public virtual List<int> ItemIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ItemIds;
				}
				IHandInItemRange_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x040035FE RID: 13822
		[Nullable(2)]
		protected IHandInItemRange FbInstance;

		// Token: 0x040035FF RID: 13823
		[Nullable(2)]
		protected IHandInItemRange_SetValue PocoInterface;
	}
}
