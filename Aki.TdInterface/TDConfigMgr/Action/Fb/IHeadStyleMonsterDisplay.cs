using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027AD RID: 10157
	public class IHeadStyleMonsterDisplay : IHeadStyle
	{
		// Token: 0x0600E0DD RID: 57565 RVA: 0x0021131E File Offset: 0x0020F51E
		public static IHeadStyleMonsterDisplay Create(IHeadStyleMonsterDisplay? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHeadStyleMonsterDisplay
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E31 RID: 15921
		// (get) Token: 0x0600E0DE RID: 57566 RVA: 0x0021133D File Offset: 0x0020F53D
		public override EHeadStyle Type
		{
			get
			{
				return (EHeadStyle)this.Instance.Type;
			}
		}

		// Token: 0x17003E32 RID: 15922
		// (get) Token: 0x0600E0DF RID: 57567 RVA: 0x0021134A File Offset: 0x0020F54A
		public virtual int MonsterDisplayId
		{
			get
			{
				return this.Instance.MonsterDisplayId;
			}
		}

		// Token: 0x04007A43 RID: 31299
		private IHeadStyleMonsterDisplay Instance;
	}
}
