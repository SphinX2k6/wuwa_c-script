using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056F8 RID: 22264
	public class IEntityMatchAllCharacterT
	{
		// Token: 0x1700A087 RID: 41095
		// (get) Token: 0x06023BE3 RID: 146403 RVA: 0x004E9ECE File Offset: 0x004E80CE
		// (set) Token: 0x06023BE4 RID: 146404 RVA: 0x004E9ED6 File Offset: 0x004E80D6
		public EEntityMatchType Type { get; set; }

		// Token: 0x06023BE5 RID: 146405 RVA: 0x004E9EDF File Offset: 0x004E80DF
		public IEntityMatchAllCharacterT()
		{
			this.Type = EEntityMatchType.Player;
		}
	}
}
