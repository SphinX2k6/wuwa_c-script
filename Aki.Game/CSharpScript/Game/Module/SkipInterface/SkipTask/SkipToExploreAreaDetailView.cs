using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.WorldMap;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02003B73 RID: 15219
	public class SkipToExploreAreaDetailView : SkipTask
	{
		// Token: 0x060270B2 RID: 159922 RVA: 0x00AEE5A0 File Offset: 0x00AEC7A0
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
