using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200141F RID: 5151
	public class IEavesdropGamePlayConfig : ISpecialGamePlayConfig
	{
		// Token: 0x060074C1 RID: 29889 RVA: 0x00118C36 File Offset: 0x00116E36
		public static IEavesdropGamePlayConfig Create(IEavesdropGamePlayConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEavesdropGamePlayConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002425 RID: 9253
		// (get) Token: 0x060074C2 RID: 29890 RVA: 0x00118C55 File Offset: 0x00116E55
		public override ESpecialGamePlayConfigType Type
		{
			get
			{
				return (ESpecialGamePlayConfigType)this.Instance.Type;
			}
		}

		// Token: 0x17002426 RID: 9254
		// (get) Token: 0x060074C3 RID: 29891 RVA: 0x00118C62 File Offset: 0x00116E62
		public virtual int EavesdropEntityId
		{
			get
			{
				return this.Instance.EavesdropEntityId;
			}
		}

		// Token: 0x17002427 RID: 9255
		// (get) Token: 0x060074C4 RID: 29892 RVA: 0x00118C6F File Offset: 0x00116E6F
		public virtual int HintRangeEntityId
		{
			get
			{
				return this.Instance.HintRangeEntityId;
			}
		}

		// Token: 0x17002428 RID: 9256
		// (get) Token: 0x060074C5 RID: 29893 RVA: 0x00118C7C File Offset: 0x00116E7C
		public virtual int ListenableRangeEntityId
		{
			get
			{
				return this.Instance.ListenableRangeEntityId;
			}
		}

		// Token: 0x17002429 RID: 9257
		// (get) Token: 0x060074C6 RID: 29894 RVA: 0x00118C89 File Offset: 0x00116E89
		public virtual int TooCloseRangeEntityId
		{
			get
			{
				return this.Instance.TooCloseRangeEntityId;
			}
		}

		// Token: 0x1700242A RID: 9258
		// (get) Token: 0x060074C7 RID: 29895 RVA: 0x00118C96 File Offset: 0x00116E96
		public virtual int HintTag
		{
			get
			{
				return this.Instance.HintTag;
			}
		}

		// Token: 0x1700242B RID: 9259
		// (get) Token: 0x060074C8 RID: 29896 RVA: 0x00118CA3 File Offset: 0x00116EA3
		public virtual int ListenableTag
		{
			get
			{
				return this.Instance.ListenableTag;
			}
		}

		// Token: 0x1700242C RID: 9260
		// (get) Token: 0x060074C9 RID: 29897 RVA: 0x00118CB0 File Offset: 0x00116EB0
		public virtual int TooCloseTag
		{
			get
			{
				return this.Instance.TooCloseTag;
			}
		}

		// Token: 0x1700242D RID: 9261
		// (get) Token: 0x060074CA RID: 29898 RVA: 0x00118CBD File Offset: 0x00116EBD
		public virtual int ListenedTag
		{
			get
			{
				return this.Instance.ListenedTag;
			}
		}

		// Token: 0x1700242E RID: 9262
		// (get) Token: 0x060074CB RID: 29899 RVA: 0x00118CCC File Offset: 0x00116ECC
		public virtual int? EavesdroppingTag
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.EavesdroppingTag);
			}
		}

		// Token: 0x1700242F RID: 9263
		// (get) Token: 0x060074CC RID: 29900 RVA: 0x00118D04 File Offset: 0x00116F04
		public virtual bool? BlockInteractOnListen
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.BlockInteractOnListen);
			}
		}

		// Token: 0x0400429D RID: 17053
		private IEavesdropGamePlayConfig Instance;
	}
}
