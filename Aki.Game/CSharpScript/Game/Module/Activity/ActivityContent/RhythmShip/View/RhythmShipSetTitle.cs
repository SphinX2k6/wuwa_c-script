using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x02006246 RID: 25158
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RhythmShipSetTitle : SyncGridProxyAbstract<RhythmShipSetData>
	{
		// Token: 0x0603F637 RID: 259639 RVA: 0x00F531CC File Offset: 0x00F513CC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(2, new Action(this.OnClickBtn))
			};
		}

		// Token: 0x0603F638 RID: 259640 RVA: 0x00F53234 File Offset: 0x00F51434
		public override void Refresh(RhythmShipSetData data)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.Text, Array.Empty<object>());
			base.GetButton(2).RootUIComp.Get().SetUIActive(data.Type == ERhythmShipSetDataType.TitleWithBtn);
		}

		// Token: 0x0603F639 RID: 259641 RVA: 0x00F5327F File Offset: 0x00F5147F
		private void OnClickBtn()
		{
			UiManager.Instance.OpenView(EUiViewName.RhythmShipSetTipsView, null, null);
		}
	}
}
