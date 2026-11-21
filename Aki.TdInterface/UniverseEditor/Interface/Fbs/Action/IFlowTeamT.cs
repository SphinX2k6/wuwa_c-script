using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EA6 RID: 28326
	public class IFlowTeamT
	{
		// Token: 0x1700CFC7 RID: 53191
		// (get) Token: 0x06031006 RID: 200710 RVA: 0x006A57CE File Offset: 0x006A39CE
		// (set) Token: 0x06031007 RID: 200711 RVA: 0x006A57D6 File Offset: 0x006A39D6
		public ETeamType Type { get; set; }

		// Token: 0x06031008 RID: 200712 RVA: 0x006A57DF File Offset: 0x006A39DF
		public IFlowTeamT()
		{
			this.Type = ETeamType.Current;
		}
	}
}
