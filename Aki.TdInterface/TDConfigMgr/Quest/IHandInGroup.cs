using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FAB RID: 4011
	[NullableContext(1)]
	[Nullable(0)]
	public class IHandInGroup : IHandInItem
	{
		// Token: 0x0600595C RID: 22876 RVA: 0x000D9BD8 File Offset: 0x000D7DD8
		private IHandInGroup_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHandInGroup 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHandInGroup_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHandInGroup_SetValue());
			}
			return result;
		}

		// Token: 0x0600595D RID: 22877 RVA: 0x000D9C10 File Offset: 0x000D7E10
		public static IHandInGroup Create([Nullable(2)] IHandInGroup instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHandInGroup
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600595E RID: 22878 RVA: 0x000D9C23 File Offset: 0x000D7E23
		public static IHandInGroup CreateFromSetValue([Nullable(2)] IHandInGroup_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHandInGroup
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600595F RID: 22879 RVA: 0x000D9C38 File Offset: 0x000D7E38
		public new IHandInGroup_SetValue ToSetValue()
		{
			return new IHandInGroup_SetValue
			{
				HandInType = this.HandInType,
				ItemIds = this.ItemIds,
				Count = this.Count,
				Slot = this.Slot,
				ChoiceRange = this.ChoiceRange
			};
		}

		// Token: 0x17001DAF RID: 7599
		// (get) Token: 0x06005960 RID: 22880 RVA: 0x000D9C86 File Offset: 0x000D7E86
		// (set) Token: 0x06005961 RID: 22881 RVA: 0x000D9CB1 File Offset: 0x000D7EB1
		public override EHandInItemType HandInType
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

		// Token: 0x17001DB0 RID: 7600
		// (get) Token: 0x06005962 RID: 22882 RVA: 0x000D9CBF File Offset: 0x000D7EBF
		// (set) Token: 0x06005963 RID: 22883 RVA: 0x000D9CE6 File Offset: 0x000D7EE6
		public override List<int> ItemIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ItemIds;
				}
				IHandInGroup_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17001DB1 RID: 7601
		// (get) Token: 0x06005964 RID: 22884 RVA: 0x000D9CF4 File Offset: 0x000D7EF4
		// (set) Token: 0x06005965 RID: 22885 RVA: 0x000D9D1F File Offset: 0x000D7F1F
		public override int Count
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

		// Token: 0x17001DB2 RID: 7602
		// (get) Token: 0x06005966 RID: 22886 RVA: 0x000D9D2D File Offset: 0x000D7F2D
		// (set) Token: 0x06005967 RID: 22887 RVA: 0x000D9D58 File Offset: 0x000D7F58
		public virtual int Slot
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Slot;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Slot;
			}
			set
			{
				this.GetOrCreatePoco().Slot = value;
			}
		}

		// Token: 0x17001DB3 RID: 7603
		// (get) Token: 0x06005968 RID: 22888 RVA: 0x000D9D68 File Offset: 0x000D7F68
		// (set) Token: 0x06005969 RID: 22889 RVA: 0x000D9DC9 File Offset: 0x000D7FC9
		[Nullable(2)]
		public virtual IHandInItemRange ChoiceRange
		{
			[NullableContext(2)]
			get
			{
				if (this._ChoiceRangeInited)
				{
					return this._ChoiceRangeCache;
				}
				this._ChoiceRangeInited = true;
				if (this.FbInstance != null)
				{
					this._ChoiceRangeCache = IHandInItemRange.Create(this.FbInstance.ChoiceRange);
				}
				else
				{
					IHandInGroup_SetValue pocoInterface = this.PocoInterface;
					this._ChoiceRangeCache = ((pocoInterface != null) ? pocoInterface.ChoiceRange : null);
				}
				return this._ChoiceRangeCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().ChoiceRange = value;
				this._ChoiceRangeInited = false;
			}
		}

		// Token: 0x040035F0 RID: 13808
		[Nullable(2)]
		protected new IHandInGroup FbInstance;

		// Token: 0x040035F1 RID: 13809
		[Nullable(2)]
		protected new IHandInGroup_SetValue PocoInterface;

		// Token: 0x040035F2 RID: 13810
		private IHandInItemRange _ChoiceRangeCache;

		// Token: 0x040035F3 RID: 13811
		private bool _ChoiceRangeInited;
	}
}
