using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007508 RID: 29960
	public class IPreloadCharacterTypeT
	{
		// Token: 0x1700DC81 RID: 56449
		// (get) Token: 0x060348A9 RID: 215209 RVA: 0x00712896 File Offset: 0x00710A96
		// (set) Token: 0x060348AA RID: 215210 RVA: 0x0071289E File Offset: 0x00710A9E
		public EPreloadObjectType Type { get; set; }

		// Token: 0x060348AB RID: 215211 RVA: 0x007128A7 File Offset: 0x00710AA7
		public IPreloadCharacterTypeT()
		{
			this.Type = EPreloadObjectType.PreloadTrialCharacterForSkill;
		}
	}
}
