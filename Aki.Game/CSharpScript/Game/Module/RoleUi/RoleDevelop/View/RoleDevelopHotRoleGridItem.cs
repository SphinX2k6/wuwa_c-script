using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.RoleUi.RoleDevelop.Data;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02004D37 RID: 19767
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleDevelopHotRoleGridItem : LoopScrollMediumItemGrid<RoleDevelopData>
	{
		// Token: 0x06033130 RID: 209200 RVA: 0x00BE67E8 File Offset: 0x00BE49E8
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelected(true, true);
		}

		// Token: 0x06033131 RID: 209201 RVA: 0x00BE67F2 File Offset: 0x00BE49F2
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false, true);
		}

		// Token: 0x06033132 RID: 209202 RVA: 0x00BE67FC File Offset: 0x00BE49FC
		protected override void OnRefresh(RoleDevelopData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			RoleDevelopRoleBaseData developRoleData = data.GetDevelopRoleData();
			ForecastCharacterMediumItemGrid parameters = new ForecastCharacterMediumItemGrid
			{
				Data = data,
				IconPath = developRoleData.GetRoleIconPath(),
				BottomText = developRoleData.GetName(),
				RoleDevTag = new ERoleDevelopHotRoleTag?(data.GetHotRoleTag())
			};
			base.Apply<ForecastCharacterMediumItemGrid>(parameters);
		}

		// Token: 0x06033133 RID: 209203 RVA: 0x00BE6854 File Offset: 0x00BE4A54
		public override object GetKey(RoleDevelopData data, int gridIndex)
		{
			return data.GetId();
		}
	}
}
