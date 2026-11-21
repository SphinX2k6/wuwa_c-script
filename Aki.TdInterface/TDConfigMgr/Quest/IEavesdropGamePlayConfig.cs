using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001078 RID: 4216
	public class IEavesdropGamePlayConfig : ISpecialGamePlayConfig
	{
		// Token: 0x06005CE2 RID: 23778 RVA: 0x000E1B28 File Offset: 0x000DFD28
		private IEavesdropGamePlayConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEavesdropGamePlayConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEavesdropGamePlayConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEavesdropGamePlayConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06005CE3 RID: 23779 RVA: 0x000E1B60 File Offset: 0x000DFD60
		public static IEavesdropGamePlayConfig Create([Nullable(2)] IEavesdropGamePlayConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEavesdropGamePlayConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005CE4 RID: 23780 RVA: 0x000E1B73 File Offset: 0x000DFD73
		public static IEavesdropGamePlayConfig CreateFromSetValue([Nullable(2)] IEavesdropGamePlayConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEavesdropGamePlayConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005CE5 RID: 23781 RVA: 0x000E1B88 File Offset: 0x000DFD88
		public new IEavesdropGamePlayConfig_SetValue ToSetValue()
		{
			return new IEavesdropGamePlayConfig_SetValue
			{
				Type = this.Type,
				EavesdropEntityId = this.EavesdropEntityId,
				HintRangeEntityId = this.HintRangeEntityId,
				ListenableRangeEntityId = this.ListenableRangeEntityId,
				TooCloseRangeEntityId = this.TooCloseRangeEntityId,
				HintTag = this.HintTag,
				ListenableTag = this.ListenableTag,
				TooCloseTag = this.TooCloseTag,
				ListenedTag = this.ListenedTag,
				EavesdroppingTag = this.EavesdroppingTag,
				BlockInteractOnListen = this.BlockInteractOnListen
			};
		}

		// Token: 0x17001EB9 RID: 7865
		// (get) Token: 0x06005CE6 RID: 23782 RVA: 0x000E1C1E File Offset: 0x000DFE1E
		// (set) Token: 0x06005CE7 RID: 23783 RVA: 0x000E1C49 File Offset: 0x000DFE49
		public override ESpecialGamePlayConfigType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESpecialGamePlayConfigType.Stalking;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17001EBA RID: 7866
		// (get) Token: 0x06005CE8 RID: 23784 RVA: 0x000E1C57 File Offset: 0x000DFE57
		// (set) Token: 0x06005CE9 RID: 23785 RVA: 0x000E1C82 File Offset: 0x000DFE82
		public virtual int EavesdropEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EavesdropEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EavesdropEntityId;
			}
			set
			{
				this.GetOrCreatePoco().EavesdropEntityId = value;
			}
		}

		// Token: 0x17001EBB RID: 7867
		// (get) Token: 0x06005CEA RID: 23786 RVA: 0x000E1C90 File Offset: 0x000DFE90
		// (set) Token: 0x06005CEB RID: 23787 RVA: 0x000E1CBB File Offset: 0x000DFEBB
		public virtual int HintRangeEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HintRangeEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.HintRangeEntityId;
			}
			set
			{
				this.GetOrCreatePoco().HintRangeEntityId = value;
			}
		}

		// Token: 0x17001EBC RID: 7868
		// (get) Token: 0x06005CEC RID: 23788 RVA: 0x000E1CC9 File Offset: 0x000DFEC9
		// (set) Token: 0x06005CED RID: 23789 RVA: 0x000E1CF4 File Offset: 0x000DFEF4
		public virtual int ListenableRangeEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ListenableRangeEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ListenableRangeEntityId;
			}
			set
			{
				this.GetOrCreatePoco().ListenableRangeEntityId = value;
			}
		}

		// Token: 0x17001EBD RID: 7869
		// (get) Token: 0x06005CEE RID: 23790 RVA: 0x000E1D02 File Offset: 0x000DFF02
		// (set) Token: 0x06005CEF RID: 23791 RVA: 0x000E1D2D File Offset: 0x000DFF2D
		public virtual int TooCloseRangeEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TooCloseRangeEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TooCloseRangeEntityId;
			}
			set
			{
				this.GetOrCreatePoco().TooCloseRangeEntityId = value;
			}
		}

		// Token: 0x17001EBE RID: 7870
		// (get) Token: 0x06005CF0 RID: 23792 RVA: 0x000E1D3B File Offset: 0x000DFF3B
		// (set) Token: 0x06005CF1 RID: 23793 RVA: 0x000E1D66 File Offset: 0x000DFF66
		public virtual int HintTag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HintTag;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.HintTag;
			}
			set
			{
				this.GetOrCreatePoco().HintTag = value;
			}
		}

		// Token: 0x17001EBF RID: 7871
		// (get) Token: 0x06005CF2 RID: 23794 RVA: 0x000E1D74 File Offset: 0x000DFF74
		// (set) Token: 0x06005CF3 RID: 23795 RVA: 0x000E1D9F File Offset: 0x000DFF9F
		public virtual int ListenableTag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ListenableTag;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ListenableTag;
			}
			set
			{
				this.GetOrCreatePoco().ListenableTag = value;
			}
		}

		// Token: 0x17001EC0 RID: 7872
		// (get) Token: 0x06005CF4 RID: 23796 RVA: 0x000E1DAD File Offset: 0x000DFFAD
		// (set) Token: 0x06005CF5 RID: 23797 RVA: 0x000E1DD8 File Offset: 0x000DFFD8
		public virtual int TooCloseTag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TooCloseTag;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TooCloseTag;
			}
			set
			{
				this.GetOrCreatePoco().TooCloseTag = value;
			}
		}

		// Token: 0x17001EC1 RID: 7873
		// (get) Token: 0x06005CF6 RID: 23798 RVA: 0x000E1DE6 File Offset: 0x000DFFE6
		// (set) Token: 0x06005CF7 RID: 23799 RVA: 0x000E1E11 File Offset: 0x000E0011
		public virtual int ListenedTag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ListenedTag;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ListenedTag;
			}
			set
			{
				this.GetOrCreatePoco().ListenedTag = value;
			}
		}

		// Token: 0x17001EC2 RID: 7874
		// (get) Token: 0x06005CF8 RID: 23800 RVA: 0x000E1E20 File Offset: 0x000E0020
		// (set) Token: 0x06005CF9 RID: 23801 RVA: 0x000E1E5A File Offset: 0x000E005A
		public virtual int? EavesdroppingTag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EavesdroppingTag;
				}
				IEavesdropGamePlayConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EavesdroppingTag;
			}
			set
			{
				this.GetOrCreatePoco().EavesdroppingTag = value;
			}
		}

		// Token: 0x17001EC3 RID: 7875
		// (get) Token: 0x06005CFA RID: 23802 RVA: 0x000E1E68 File Offset: 0x000E0068
		// (set) Token: 0x06005CFB RID: 23803 RVA: 0x000E1EA2 File Offset: 0x000E00A2
		public virtual bool? BlockInteractOnListen
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BlockInteractOnListen;
				}
				IEavesdropGamePlayConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.BlockInteractOnListen;
			}
			set
			{
				this.GetOrCreatePoco().BlockInteractOnListen = value;
			}
		}

		// Token: 0x040037E9 RID: 14313
		[Nullable(2)]
		protected new IEavesdropGamePlayConfig FbInstance;

		// Token: 0x040037EA RID: 14314
		[Nullable(2)]
		protected new IEavesdropGamePlayConfig_SetValue PocoInterface;
	}
}
