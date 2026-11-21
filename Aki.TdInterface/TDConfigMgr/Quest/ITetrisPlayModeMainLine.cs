using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012D0 RID: 4816
	public class ITetrisPlayModeMainLine : ITetrisPlayModeBase
	{
		// Token: 0x06006C6F RID: 27759 RVA: 0x001028E4 File Offset: 0x00100AE4
		private ITetrisPlayModeMainLine_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITetrisPlayModeMainLine 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITetrisPlayModeMainLine_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITetrisPlayModeMainLine_SetValue());
			}
			return result;
		}

		// Token: 0x06006C70 RID: 27760 RVA: 0x0010291C File Offset: 0x00100B1C
		public static ITetrisPlayModeMainLine Create([Nullable(2)] ITetrisPlayModeMainLine instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITetrisPlayModeMainLine
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006C71 RID: 27761 RVA: 0x0010292F File Offset: 0x00100B2F
		public static ITetrisPlayModeMainLine CreateFromSetValue([Nullable(2)] ITetrisPlayModeMainLine_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITetrisPlayModeMainLine
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006C72 RID: 27762 RVA: 0x00102942 File Offset: 0x00100B42
		public new ITetrisPlayModeMainLine_SetValue ToSetValue()
		{
			return new ITetrisPlayModeMainLine_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId,
				EntityState = this.EntityState,
				FieldHeight = this.FieldHeight
			};
		}

		// Token: 0x170022FF RID: 8959
		// (get) Token: 0x06006C73 RID: 27763 RVA: 0x00102979 File Offset: 0x00100B79
		// (set) Token: 0x06006C74 RID: 27764 RVA: 0x001029A4 File Offset: 0x00100BA4
		public override ETetrisPlayMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETetrisPlayMode.Normal;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002300 RID: 8960
		// (get) Token: 0x06006C75 RID: 27765 RVA: 0x001029B2 File Offset: 0x00100BB2
		// (set) Token: 0x06006C76 RID: 27766 RVA: 0x001029DD File Offset: 0x00100BDD
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

		// Token: 0x17002301 RID: 8961
		// (get) Token: 0x06006C77 RID: 27767 RVA: 0x001029EB File Offset: 0x00100BEB
		// (set) Token: 0x06006C78 RID: 27768 RVA: 0x00102A16 File Offset: 0x00100C16
		public virtual string EntityState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityState;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.EntityState;
			}
			set
			{
				this.GetOrCreatePoco().EntityState = value;
			}
		}

		// Token: 0x17002302 RID: 8962
		// (get) Token: 0x06006C79 RID: 27769 RVA: 0x00102A24 File Offset: 0x00100C24
		// (set) Token: 0x06006C7A RID: 27770 RVA: 0x00102A5E File Offset: 0x00100C5E
		public virtual int? FieldHeight
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FieldHeight;
				}
				ITetrisPlayModeMainLine_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FieldHeight;
			}
			set
			{
				this.GetOrCreatePoco().FieldHeight = value;
			}
		}

		// Token: 0x040040C1 RID: 16577
		[Nullable(2)]
		protected new ITetrisPlayModeMainLine FbInstance;

		// Token: 0x040040C2 RID: 16578
		[Nullable(2)]
		protected new ITetrisPlayModeMainLine_SetValue PocoInterface;
	}
}
