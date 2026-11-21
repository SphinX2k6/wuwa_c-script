using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200141E RID: 5150
	public class IFirstPersonTurretGamePlayConfig : ISpecialGamePlayConfig
	{
		// Token: 0x060074BE RID: 29886 RVA: 0x00118C02 File Offset: 0x00116E02
		public static IFirstPersonTurretGamePlayConfig Create(IFirstPersonTurretGamePlayConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFirstPersonTurretGamePlayConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002424 RID: 9252
		// (get) Token: 0x060074BF RID: 29887 RVA: 0x00118C21 File Offset: 0x00116E21
		public override ESpecialGamePlayConfigType Type
		{
			get
			{
				return (ESpecialGamePlayConfigType)this.Instance.Type;
			}
		}

		// Token: 0x0400429C RID: 17052
		private IFirstPersonTurretGamePlayConfig Instance;
	}
}
