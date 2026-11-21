using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x020037F2 RID: 14322
	public class VillageInfrBuildFinishTipView : UiViewBase
	{
		// Token: 0x060253F3 RID: 152563 RVA: 0x00A81315 File Offset: 0x00A7F515
		[NullableContext(1)]
		public VillageInfrBuildFinishTipView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060253F4 RID: 152564 RVA: 0x00A81320 File Offset: 0x00A7F520
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(3, new Action(this.OnClickMask))
			};
		}

		// Token: 0x060253F5 RID: 152565 RVA: 0x00A813B3 File Offset: 0x00A7F5B3
		private void OnClickMask()
		{
			base.CloseMe(null);
		}

		// Token: 0x060253F6 RID: 152566 RVA: 0x00A813BC File Offset: 0x00A7F5BC
		protected override void OnStart()
		{
			IVillageInfrBuildFinishTipParam villageInfrBuildFinishTipParam = this.OpenParam as IVillageInfrBuildFinishTipParam;
			if (villageInfrBuildFinishTipParam.SelectType == EVillageInfrSelectType.Tree)
			{
				InfrV2TreeBuild? infrTreeBuild = VillageInfrConfig.Instance.GetInfrTreeBuild(villageInfrBuildFinishTipParam.SelectId);
				base.GetText(0).ShowTextNew("VillageInfr_TreeTips_Finish1");
				base.GetText(1).ShowTextNew(infrTreeBuild.Value.Name);
				base.GetText(2).ShowTextNew("VillageInfr_TreeTips_Finish2");
				return;
			}
			int selectId = villageInfrBuildFinishTipParam.SelectId;
			InfrV2Level? infrLevel = VillageInfrConfig.Instance.GetInfrLevel(selectId);
			base.GetText(0).ShowTextNew("VillageInfr_VillageTips_Upgrade");
			base.GetText(1).ShowTextNew(infrLevel.Value.Name);
			if (selectId >= VillageInfrConfig.Instance.GetInfrMaxLevel())
			{
				base.GetText(2).ShowTextNew("VillageInfr_VillageTips_Highest");
				UUIItem text = base.GetText(2);
				bool bUseChangeColor = true;
				FColor? fcolor = new FColor?(base.GetText(2).changeColor);
				text.SetChangeColor(bUseChangeColor, fcolor);
				return;
			}
			base.GetText(2).ShowTextNew("VillageInfr_VillageTips_Continue");
		}
	}
}
