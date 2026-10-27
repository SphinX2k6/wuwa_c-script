using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02006022 RID: 24610
	[NullableContext(1)]
	[Nullable(0)]
	public class TetrisTipsTargetView : TetrisTipsBaseView
	{
		// Token: 0x0603E4D0 RID: 255184 RVA: 0x00F0C245 File Offset: 0x00F0A445
		public TetrisTipsTargetView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603E4D1 RID: 255185 RVA: 0x00F0C24E File Offset: 0x00F0A44E
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x0603E4D2 RID: 255186 RVA: 0x00F0C287 File Offset: 0x00F0A487
		protected override void OnStart()
		{
			base.OnStart();
			this.Param = (this.OpenParam as Dictionary<int, int>);
			this.TargetsList = new GenericLayout<TetrisTipsTargetGrid, ITetrisTargetData>(base.GetHorizontalLayout(0), new Func<TetrisTipsTargetGrid>(this.UpdateItem), null, false, true);
		}

		// Token: 0x0603E4D3 RID: 255187 RVA: 0x00F0C2C1 File Offset: 0x00F0A4C1
		protected override void OnBeforeShow()
		{
			this.Refresh();
		}

		// Token: 0x0603E4D4 RID: 255188 RVA: 0x00F0C2CC File Offset: 0x00F0A4CC
		private void Refresh()
		{
			List<ITetrisTargetData> list = new List<ITetrisTargetData>();
			foreach (KeyValuePair<int, int> keyValuePair in this.Param)
			{
				list.Add(new TetrisTargetData
				{
					Icon = ActivityTetrisConfig.Instance.GetGemConfig(keyValuePair.Key).Value.TargetIconPath,
					Num = keyValuePair.Value,
					Tip = ((keyValuePair.Key == 0) ? "Tetristext_09" : "Tetristext_10")
				});
			}
			this.TargetsList.RefreshByData(list, null, false);
		}

		// Token: 0x0603E4D5 RID: 255189 RVA: 0x00F0C388 File Offset: 0x00F0A588
		private TetrisTipsTargetGrid UpdateItem()
		{
			return new TetrisTipsTargetGrid();
		}

		// Token: 0x04020903 RID: 133379
		[Nullable(2)]
		private Dictionary<int, int> Param;

		// Token: 0x04020904 RID: 133380
		private GenericLayout<TetrisTipsTargetGrid, ITetrisTargetData> TargetsList;
	}
}
