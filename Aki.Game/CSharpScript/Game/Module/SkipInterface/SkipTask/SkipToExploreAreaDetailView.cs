using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.WorldMap;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02004BC9 RID: 19401
	public class SkipToExploreAreaDetailView : SkipTask
	{
		// Token: 0x06032321 RID: 205601 RVA: 0x00BAA2E8 File Offset: 0x00BA84E8
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			string s = (string)data[0];
			string text = (data.Length > 1) ? ((string)data[1]) : null;
			int areaId = int.Parse(s);
			int levelOneAreaId = AreaConfig.Instance.GetLevelOneAreaId(areaId);
			if (levelOneAreaId <= 0)
			{
				base.Finish();
				return;
			}
			EExploreType? exploreType = (!string.IsNullOrEmpty(text)) ? new EExploreType?((EExploreType)int.Parse(text)) : null;
			WorldMapController.Instance.SkipToExploreAreaDetailView(levelOneAreaId, exploreType);
			base.Finish();
		}
	}
}
