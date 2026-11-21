using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CA8 RID: 27816
	public class IElementalBoxTargetPrefabPosT
	{
		// Token: 0x1700CC02 RID: 52226
		// (get) Token: 0x0602FEE2 RID: 196322 RVA: 0x006863A7 File Offset: 0x006845A7
		// (set) Token: 0x0602FEE3 RID: 196323 RVA: 0x006863AF File Offset: 0x006845AF
		public EElementalBoxTargetPosType Type { get; set; }

		// Token: 0x1700CC03 RID: 52227
		// (get) Token: 0x0602FEE4 RID: 196324 RVA: 0x006863B8 File Offset: 0x006845B8
		// (set) Token: 0x0602FEE5 RID: 196325 RVA: 0x006863C0 File Offset: 0x006845C0
		public string TargetKey { get; set; }

		// Token: 0x0602FEE6 RID: 196326 RVA: 0x006863C9 File Offset: 0x006845C9
		public IElementalBoxTargetPrefabPosT()
		{
			this.Type = EElementalBoxTargetPosType.PrefabElementalBoxTargetPos;
			this.TargetKey = null;
		}
	}
}
