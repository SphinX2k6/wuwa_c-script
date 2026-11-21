using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007182 RID: 29058
	public class ILookAtTargetT
	{
		// Token: 0x1700D4B2 RID: 54450
		// (get) Token: 0x06032832 RID: 206898 RVA: 0x006D3967 File Offset: 0x006D1B67
		// (set) Token: 0x06032833 RID: 206899 RVA: 0x006D396F File Offset: 0x006D1B6F
		public EDefaultLookAtType Type { get; set; }

		// Token: 0x1700D4B3 RID: 54451
		// (get) Token: 0x06032834 RID: 206900 RVA: 0x006D3978 File Offset: 0x006D1B78
		// (set) Token: 0x06032835 RID: 206901 RVA: 0x006D3980 File Offset: 0x006D1B80
		public List<INpcLookAtConfigT> LookAtConfigs { get; set; }

		// Token: 0x06032836 RID: 206902 RVA: 0x006D3989 File Offset: 0x006D1B89
		public ILookAtTargetT()
		{
			this.Type = EDefaultLookAtType.LookAtBubbleEntity;
			this.LookAtConfigs = null;
		}
	}
}
