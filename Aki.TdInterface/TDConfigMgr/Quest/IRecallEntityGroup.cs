using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001212 RID: 4626
	public class IRecallEntityGroup
	{
		// Token: 0x060067C1 RID: 26561 RVA: 0x000F8FE8 File Offset: 0x000F71E8
		private IRecallEntityGroup_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRecallEntityGroup 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRecallEntityGroup_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRecallEntityGroup_SetValue());
			}
			return result;
		}

		// Token: 0x060067C2 RID: 26562 RVA: 0x000F9020 File Offset: 0x000F7220
		public static IRecallEntityGroup Create([Nullable(2)] IRecallEntityGroup instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRecallEntityGroup
			{
				FbInstance = instance
			};
		}

		// Token: 0x060067C3 RID: 26563 RVA: 0x000F9033 File Offset: 0x000F7233
		public static IRecallEntityGroup CreateFromSetValue([Nullable(2)] IRecallEntityGroup_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRecallEntityGroup
			{
				PocoInterface = value
			};
		}

		// Token: 0x060067C4 RID: 26564 RVA: 0x000F9046 File Offset: 0x000F7246
		public IRecallEntityGroup_SetValue ToSetValue()
		{
			return new IRecallEntityGroup_SetValue
			{
				Index = this.Index,
				Source = this.Source,
				LevelId = this.LevelId,
				Entities = this.Entities
			};
		}

		// Token: 0x170021C4 RID: 8644
		// (get) Token: 0x060067C5 RID: 26565 RVA: 0x000F907D File Offset: 0x000F727D
		// (set) Token: 0x060067C6 RID: 26566 RVA: 0x000F90A8 File Offset: 0x000F72A8
		public virtual int Index
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Index;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Index;
			}
			set
			{
				this.GetOrCreatePoco().Index = value;
			}
		}

		// Token: 0x170021C5 RID: 8645
		// (get) Token: 0x060067C7 RID: 26567 RVA: 0x000F90B6 File Offset: 0x000F72B6
		// (set) Token: 0x060067C8 RID: 26568 RVA: 0x000F90E1 File Offset: 0x000F72E1
		public virtual string Source
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Source;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Source;
			}
			set
			{
				this.GetOrCreatePoco().Source = value;
			}
		}

		// Token: 0x170021C6 RID: 8646
		// (get) Token: 0x060067C9 RID: 26569 RVA: 0x000F90EF File Offset: 0x000F72EF
		// (set) Token: 0x060067CA RID: 26570 RVA: 0x000F911A File Offset: 0x000F731A
		public virtual int LevelId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LevelId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.LevelId;
			}
			set
			{
				this.GetOrCreatePoco().LevelId = value;
			}
		}

		// Token: 0x170021C7 RID: 8647
		// (get) Token: 0x060067CB RID: 26571 RVA: 0x000F9128 File Offset: 0x000F7328
		// (set) Token: 0x060067CC RID: 26572 RVA: 0x000F914F File Offset: 0x000F734F
		public virtual List<int> Entities
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Entities;
				}
				IRecallEntityGroup_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Entities;
			}
			set
			{
				this.GetOrCreatePoco().Entities = value;
			}
		}

		// Token: 0x04003E1E RID: 15902
		[Nullable(2)]
		protected IRecallEntityGroup FbInstance;

		// Token: 0x04003E1F RID: 15903
		[Nullable(2)]
		protected IRecallEntityGroup_SetValue PocoInterface;
	}
}
