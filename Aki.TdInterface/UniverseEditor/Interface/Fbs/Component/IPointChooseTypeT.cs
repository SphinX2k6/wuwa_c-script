using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005752 RID: 22354
	public class IPointChooseTypeT
	{
		// Token: 0x1700A6C9 RID: 42697
		// (get) Token: 0x06025767 RID: 153447 RVA: 0x0052B456 File Offset: 0x00529656
		// (set) Token: 0x06025768 RID: 153448 RVA: 0x0052B45E File Offset: 0x0052965E
		public EPointChooseType Type { get; set; }

		// Token: 0x06025769 RID: 153449 RVA: 0x0052B467 File Offset: 0x00529667
		public IPointChooseTypeT()
		{
			this.Type = EPointChooseType.SpawnMonsterPoint;
		}
	}
}
