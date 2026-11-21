using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006779 RID: 26489
	public class IActorVisibilityEffectTypeT
	{
		// Token: 0x1700C098 RID: 49304
		// (get) Token: 0x0602CE66 RID: 183910 RVA: 0x006237C2 File Offset: 0x006219C2
		// (set) Token: 0x0602CE67 RID: 183911 RVA: 0x006237CA File Offset: 0x006219CA
		public EActorVisibilityEffectType Type { get; set; }

		// Token: 0x0602CE68 RID: 183912 RVA: 0x006237D3 File Offset: 0x006219D3
		public IActorVisibilityEffectTypeT()
		{
			this.Type = EActorVisibilityEffectType.Default;
		}
	}
}
