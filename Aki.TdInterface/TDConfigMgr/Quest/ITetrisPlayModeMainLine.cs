using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001196 RID: 4502
	[NullableContext(1)]
	[Nullable(0)]
	public class ITetrisPlayModeMainLine : ITetrisPlayModeBase
	{
		// Token: 0x06006638 RID: 26168 RVA: 0x000F5118 File Offset: 0x000F3318
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

		// Token: 0x06006639 RID: 26169 RVA: 0x000F5150 File Offset: 0x000F3350
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

		// Token: 0x0600663A RID: 26170 RVA: 0x000F5163 File Offset: 0x000F3363
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

		// Token: 0x0600663B RID: 26171 RVA: 0x000F5176 File Offset: 0x000F3376
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

		// Token: 0x17002140 RID: 8512
		// (get) Token: 0x0600663C RID: 26172 RVA: 0x000F51AD File Offset: 0x000F33AD
		// (set) Token: 0x0600663D RID: 26173 RVA: 0x000F51D8 File Offset: 0x000F33D8
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

		// Token: 0x17002141 RID: 8513
		// (get) Token: 0x0600663E RID: 26174 RVA: 0x000F51E6 File Offset: 0x000F33E6
		// (set) Token: 0x0600663F RID: 26175 RVA: 0x000F5211 File Offset: 0x000F3411
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

		// Token: 0x17002142 RID: 8514
		// (get) Token: 0x06006640 RID: 26176 RVA: 0x000F521F File Offset: 0x000F341F
		// (set) Token: 0x06006641 RID: 26177 RVA: 0x000F524A File Offset: 0x000F344A
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

		// Token: 0x17002143 RID: 8515
		// (get) Token: 0x06006642 RID: 26178 RVA: 0x000F5258 File Offset: 0x000F3458
		// (set) Token: 0x06006643 RID: 26179 RVA: 0x000F5292 File Offset: 0x000F3492
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

		// Token: 0x04003D59 RID: 15705
		[Nullable(2)]
		protected new ITetrisPlayModeMainLine FbInstance;

		// Token: 0x04003D5A RID: 15706
		[Nullable(2)]
		protected new ITetrisPlayModeMainLine_SetValue PocoInterface;
	}
}
