using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006228 RID: 25128
	public class IBrokenRockT
	{
		// Token: 0x1700BB3D RID: 47933
		// (get) Token: 0x0602B508 RID: 177416 RVA: 0x005F6F5C File Offset: 0x005F515C
		// (set) Token: 0x0602B509 RID: 177417 RVA: 0x005F6F64 File Offset: 0x005F5164
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700BB3E RID: 47934
		// (get) Token: 0x0602B50A RID: 177418 RVA: 0x005F6F6D File Offset: 0x005F516D
		// (set) Token: 0x0602B50B RID: 177419 RVA: 0x005F6F75 File Offset: 0x005F5175
		public int Id { get; set; }

		// Token: 0x0602B50C RID: 177420 RVA: 0x005F6F7E File Offset: 0x005F517E
		public IBrokenRockT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.Id = 0;
		}
	}
}
