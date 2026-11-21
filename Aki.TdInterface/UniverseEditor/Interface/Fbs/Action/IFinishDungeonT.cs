using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E28 RID: 28200
	public class IFinishDungeonT
	{
		// Token: 0x1700CEAF RID: 52911
		// (get) Token: 0x06030B26 RID: 199462 RVA: 0x0069C07E File Offset: 0x0069A27E
		// (set) Token: 0x06030B27 RID: 199463 RVA: 0x0069C086 File Offset: 0x0069A286
		public bool IsSuccess { get; set; }

		// Token: 0x06030B28 RID: 199464 RVA: 0x0069C08F File Offset: 0x0069A28F
		public IFinishDungeonT()
		{
			this.IsSuccess = false;
		}
	}
}
