using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020016C3 RID: 5827
	public class DestroyQuestItem : ActionParams
	{
		// Token: 0x0600828D RID: 33421 RVA: 0x00138E6C File Offset: 0x0013706C
		private DestroyQuestItem_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("DestroyQuestItem 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			DestroyQuestItem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new DestroyQuestItem_SetValue());
			}
			return result;
		}

		// Token: 0x0600828E RID: 33422 RVA: 0x00138EA4 File Offset: 0x001370A4
		public static DestroyQuestItem Create([Nullable(2)] DestroyQuestItem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DestroyQuestItem
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600828F RID: 33423 RVA: 0x00138EB7 File Offset: 0x001370B7
		public static DestroyQuestItem CreateFromSetValue([Nullable(2)] DestroyQuestItem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new DestroyQuestItem
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008290 RID: 33424 RVA: 0x00138ECA File Offset: 0x001370CA
		public DestroyQuestItem_SetValue ToSetValue()
		{
			return new DestroyQuestItem_SetValue
			{
				ItemId = this.ItemId,
				Count = this.Count,
				IsAll = this.IsAll
			};
		}

		// Token: 0x17002AE6 RID: 10982
		// (get) Token: 0x06008291 RID: 33425 RVA: 0x00138EF5 File Offset: 0x001370F5
		// (set) Token: 0x06008292 RID: 33426 RVA: 0x00138F20 File Offset: 0x00137120
		public virtual int ItemId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ItemId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ItemId;
			}
			set
			{
				this.GetOrCreatePoco().ItemId = value;
			}
		}

		// Token: 0x17002AE7 RID: 10983
		// (get) Token: 0x06008293 RID: 33427 RVA: 0x00138F2E File Offset: 0x0013712E
		// (set) Token: 0x06008294 RID: 33428 RVA: 0x00138F59 File Offset: 0x00137159
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

		// Token: 0x17002AE8 RID: 10984
		// (get) Token: 0x06008295 RID: 33429 RVA: 0x00138F67 File Offset: 0x00137167
		// (set) Token: 0x06008296 RID: 33430 RVA: 0x00138F92 File Offset: 0x00137192
		public virtual bool IsAll
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsAll;
				}
				return this.PocoInterface != null && this.PocoInterface.IsAll;
			}
			set
			{
				this.GetOrCreatePoco().IsAll = value;
			}
		}

		// Token: 0x04004AD6 RID: 19158
		[Nullable(2)]
		protected new DestroyQuestItem FbInstance;

		// Token: 0x04004AD7 RID: 19159
		[Nullable(2)]
		protected DestroyQuestItem_SetValue PocoInterface;
	}
}
