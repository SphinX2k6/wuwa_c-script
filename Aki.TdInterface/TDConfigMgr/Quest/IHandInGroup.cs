using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010D5 RID: 4309
	public class IHandInGroup : IHandInItem
	{
		// Token: 0x06005F32 RID: 24370 RVA: 0x000E6698 File Offset: 0x000E4898
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

		// Token: 0x06005F33 RID: 24371 RVA: 0x000E66D0 File Offset: 0x000E48D0
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

		// Token: 0x06005F34 RID: 24372 RVA: 0x000E66E3 File Offset: 0x000E48E3
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

		// Token: 0x06005F35 RID: 24373 RVA: 0x000E66F8 File Offset: 0x000E48F8
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

		// Token: 0x17001F56 RID: 8022
		// (get) Token: 0x06005F36 RID: 24374 RVA: 0x000E6746 File Offset: 0x000E4946
		// (set) Token: 0x06005F37 RID: 24375 RVA: 0x000E6771 File Offset: 0x000E4971
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

		// Token: 0x17001F57 RID: 8023
		// (get) Token: 0x06005F38 RID: 24376 RVA: 0x000E677F File Offset: 0x000E497F
		// (set) Token: 0x06005F39 RID: 24377 RVA: 0x000E67A6 File Offset: 0x000E49A6
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

		// Token: 0x17001F58 RID: 8024
		// (get) Token: 0x06005F3A RID: 24378 RVA: 0x000E67B4 File Offset: 0x000E49B4
		// (set) Token: 0x06005F3B RID: 24379 RVA: 0x000E67DF File Offset: 0x000E49DF
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

		// Token: 0x17001F59 RID: 8025
		// (get) Token: 0x06005F3C RID: 24380 RVA: 0x000E67ED File Offset: 0x000E49ED
		// (set) Token: 0x06005F3D RID: 24381 RVA: 0x000E6818 File Offset: 0x000E4A18
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

		// Token: 0x17001F5A RID: 8026
		// (get) Token: 0x06005F3E RID: 24382 RVA: 0x000E6828 File Offset: 0x000E4A28
		// (set) Token: 0x06005F3F RID: 24383 RVA: 0x000E6889 File Offset: 0x000E4A89
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

		// Token: 0x04003922 RID: 14626
		[Nullable(2)]
		protected new IHandInGroup FbInstance;

		// Token: 0x04003923 RID: 14627
		[Nullable(2)]
		protected new IHandInGroup_SetValue PocoInterface;

		// Token: 0x04003924 RID: 14628
		private IHandInItemRange _ChoiceRangeCache;

		// Token: 0x04003925 RID: 14629
		private bool _ChoiceRangeInited;
	}
}
