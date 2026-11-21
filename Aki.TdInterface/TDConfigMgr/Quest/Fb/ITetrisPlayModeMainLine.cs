using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020015C3 RID: 5571
	public class ITetrisPlayModeMainLine : ITetrisPlayModeBase
	{
		// Token: 0x06007DB8 RID: 32184 RVA: 0x0012B02A File Offset: 0x0012922A
		public static ITetrisPlayModeMainLine Create(ITetrisPlayModeMainLine? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITetrisPlayModeMainLine
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170029D4 RID: 10708
		// (get) Token: 0x06007DB9 RID: 32185 RVA: 0x0012B049 File Offset: 0x00129249
		public override ETetrisPlayMode Type
		{
			get
			{
				return (ETetrisPlayMode)this.Instance.Type;
			}
		}

		// Token: 0x170029D5 RID: 10709
		// (get) Token: 0x06007DBA RID: 32186 RVA: 0x0012B056 File Offset: 0x00129256
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x170029D6 RID: 10710
		// (get) Token: 0x06007DBB RID: 32187 RVA: 0x0012B063 File Offset: 0x00129263
		public virtual string EntityState
		{
			get
			{
				return this.Instance.EntityState;
			}
		}

		// Token: 0x170029D7 RID: 10711
		// (get) Token: 0x06007DBC RID: 32188 RVA: 0x0012B070 File Offset: 0x00129270
		public virtual int? FieldHeight
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.FieldHeight);
			}
		}

		// Token: 0x040048BB RID: 18619
		private ITetrisPlayModeMainLine Instance;
	}
}
