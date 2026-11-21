using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x020051C4 RID: 20932
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RhythmShipSetTitle : SyncGridProxyAbstract<RhythmShipSetData>
	{
		// Token: 0x060342F8 RID: 213752 RVA: 0x00E9A128 File Offset: 0x00E98328
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

		// Token: 0x060342F9 RID: 213753 RVA: 0x00E9A190 File Offset: 0x00E98390
		public override void Refresh(RhythmShipSetData data)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.Text, Array.Empty<object>());
			base.GetButton(2).RootUIComp.Get().SetUIActive(data.Type == ERhythmShipSetDataType.TitleWithBtn);
		}

		// Token: 0x060342FA RID: 213754 RVA: 0x00E9A1DB File Offset: 0x00E983DB
		private void OnClickBtn()
		{
			UiManager.Instance.OpenView(EUiViewName.RhythmShipSetTipsView, null, null);
		}
	}
}
