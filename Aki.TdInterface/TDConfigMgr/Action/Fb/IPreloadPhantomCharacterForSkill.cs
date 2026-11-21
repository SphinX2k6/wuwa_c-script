using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CCD RID: 11469
	public class IPreloadPhantomCharacterForSkill : IPreloadCharacterType
	{
		// Token: 0x0600FB65 RID: 64357 RVA: 0x00246A55 File Offset: 0x00244C55
		public static IPreloadPhantomCharacterForSkill Create(IPreloadPhantomCharacterForSkill? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPreloadPhantomCharacterForSkill
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E79 RID: 20089
		// (get) Token: 0x0600FB66 RID: 64358 RVA: 0x00246A74 File Offset: 0x00244C74
		public override EPreloadObjectType Type
		{
			get
			{
				return (EPreloadObjectType)this.Instance.Type;
			}
		}

		// Token: 0x17004E7A RID: 20090
		// (get) Token: 0x0600FB67 RID: 64359 RVA: 0x00246A81 File Offset: 0x00244C81
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x0400895B RID: 35163
		private IPreloadPhantomCharacterForSkill Instance;
	}
}
