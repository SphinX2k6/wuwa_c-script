using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D12 RID: 27922
	public class IPlayerSplineMoveTargetT
	{
		// Token: 0x1700CFE9 RID: 53225
		// (get) Token: 0x060313CC RID: 201676 RVA: 0x006ADAD6 File Offset: 0x006ABCD6
		// (set) Token: 0x060313CD RID: 201677 RVA: 0x006ADADE File Offset: 0x006ABCDE
		public ESplineMoveTargetType Type { get; set; }

		// Token: 0x060313CE RID: 201678 RVA: 0x006ADAE7 File Offset: 0x006ABCE7
		public IPlayerSplineMoveTargetT()
		{
			this.Type = ESplineMoveTargetType.Entity;
		}
	}
}
