using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.WorldMap;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02004BCA RID: 19402
	public class SkipToExploreAreaPlayPoint : SkipTask
	{
		// Token: 0x06032323 RID: 205603 RVA: 0x00BAA368 File Offset: 0x00BA8568
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			string s = (string)data[0];
			string s2 = (string)data[1];
			int areaId = int.Parse(s);
			int levelOneAreaId = AreaConfig.Instance.GetLevelOneAreaId(areaId);
			if (levelOneAreaId <= 0)
			{
				base.Finish();
				return;
			}
			int num = int.Parse(s2);
			if (num == 0)
			{
				base.Finish();
				return;
			}
			WorldMapViewOpenParams data2 = new WorldMapViewOpenParams
			{
				MarkId = null,
				MarkType = EMarkType.None,
				FocusExplorePlayPoint = new int[]
				{
					levelOneAreaId,
					num
				}
			};
			WorldMapController.Instance.OpenView(EOpenMapType.Other, false, data2, null);
			base.Finish();
		}
	}
}
