using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.RoleUi.RoleDevelop.Data;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02003CF6 RID: 15606
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleDevelopHotRoleGridItem : LoopScrollMediumItemGrid<RoleDevelopData>
	{
		// Token: 0x06027F2B RID: 163627 RVA: 0x00B2CA24 File Offset: 0x00B2AC24
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelected(true, true);
		}

		// Token: 0x06027F2C RID: 163628 RVA: 0x00B2CA2E File Offset: 0x00B2AC2E
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false, true);
		}

		// Token: 0x06027F2D RID: 163629 RVA: 0x00B2CA38 File Offset: 0x00B2AC38
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

		// Token: 0x06027F2E RID: 163630 RVA: 0x00B2CA90 File Offset: 0x00B2AC90
		public override object GetKey(RoleDevelopData data, int gridIndex)
		{
			return data.GetId();
		}
	}
}
