using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006706 RID: 26374
	public class IExecClientBattleActionT
	{
		// Token: 0x1700C3F5 RID: 50165
		// (get) Token: 0x0602DDF9 RID: 187897 RVA: 0x00645FF5 File Offset: 0x006441F5
		// (set) Token: 0x0602DDFA RID: 187898 RVA: 0x00645FFD File Offset: 0x006441FD
		public TExecClientBattleOptionUnion ClientBattleOption { get; set; }

		// Token: 0x0602DDFB RID: 187899 RVA: 0x00646006 File Offset: 0x00644206
		public IExecClientBattleActionT()
		{
			this.ClientBattleOption = null;
		}
	}
}
