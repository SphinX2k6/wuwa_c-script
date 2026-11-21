using System;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x0200453D RID: 17725
	public interface IWorldMapNavigate
	{
		// Token: 0x170059AF RID: 22959
		// (get) Token: 0x0602CAE3 RID: 183011
		int AreaId { get; }

		// Token: 0x170059B0 RID: 22960
		// (get) Token: 0x0602CAE4 RID: 183012
		int? StateId { get; }

		// Token: 0x170059B1 RID: 22961
		// (get) Token: 0x0602CAE5 RID: 183013
		int SortIndex { get; }

		// Token: 0x170059B2 RID: 22962
		// (get) Token: 0x0602CAE6 RID: 183014
		int CountryId { get; }

		// Token: 0x170059B3 RID: 22963
		// (get) Token: 0x0602CAE7 RID: 183015
		int MarkId { get; }

		// Token: 0x170059B4 RID: 22964
		// (get) Token: 0x0602CAE8 RID: 183016
		EMarkType MarkType { get; }

		// Token: 0x170059B5 RID: 22965
		// (get) Token: 0x0602CAE9 RID: 183017
		int MapConfigId { get; }
	}
}
