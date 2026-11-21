using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200687E RID: 26750
	public class IBlendAnimTypeBaseT
	{
		// Token: 0x1700C49D RID: 50333
		// (get) Token: 0x0602DBAA RID: 187306 RVA: 0x006409C6 File Offset: 0x0063EBC6
		// (set) Token: 0x0602DBAB RID: 187307 RVA: 0x006409CE File Offset: 0x0063EBCE
		public EBlendAnimType Type { get; set; }

		// Token: 0x0602DBAC RID: 187308 RVA: 0x006409D7 File Offset: 0x0063EBD7
		public IBlendAnimTypeBaseT()
		{
			this.Type = EBlendAnimType.StateMachine;
		}
	}
}
