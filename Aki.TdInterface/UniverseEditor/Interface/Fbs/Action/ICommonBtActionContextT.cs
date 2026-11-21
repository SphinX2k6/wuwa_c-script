using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AC5 RID: 27333
	public class ICommonBtActionContextT
	{
		// Token: 0x1700C8B9 RID: 51385
		// (get) Token: 0x0602EEAD RID: 192173 RVA: 0x006641D5 File Offset: 0x006623D5
		// (set) Token: 0x0602EEAE RID: 192174 RVA: 0x006641DD File Offset: 0x006623DD
		public string Type { get; set; }

		// Token: 0x0602EEAF RID: 192175 RVA: 0x006641E6 File Offset: 0x006623E6
		public ICommonBtActionContextT()
		{
			this.Type = null;
		}
	}
}
