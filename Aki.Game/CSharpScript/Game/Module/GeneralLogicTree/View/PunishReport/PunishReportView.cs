using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.GeneralLogicTree.View.PunishReport
{
	// Token: 0x02004997 RID: 18839
	public class PunishReportView : UiViewBase
	{
		// Token: 0x0602F2FF RID: 193279 RVA: 0x00D26B44 File Offset: 0x00D24D44
		[NullableContext(1)]
		public PunishReportView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602F300 RID: 193280 RVA: 0x00D26B50 File Offset: 0x00D24D50
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602F301 RID: 193281 RVA: 0x00D26BFC File Offset: 0x00D24DFC
		protected override void OnStart()
		{
			this.UiViewSequence.AddSequenceFinishEvent(this.UiViewSequence.StartSequenceName, new Action<string>(this.OnStartSequenceEnd), false);
			IPunishReport punishReport = this.OpenParam as IPunishReport;
			if (punishReport == null)
			{
				return;
			}
			if (!string.IsNullOrEmpty(punishReport.MainText))
			{
				string configTextByKey = PublicUtil.Instance.GetConfigTextByKey(punishReport.MainText);
				UUIText text = base.GetText(0);
				if (text != null)
				{
					text.SetText(configTextByKey, true);
				}
			}
			if (!string.IsNullOrEmpty(punishReport.SubText))
			{
				string configTextByKey2 = PublicUtil.Instance.GetConfigTextByKey(punishReport.SubText);
				UUIText text2 = base.GetText(1);
				if (text2 != null)
				{
					text2.SetText(configTextByKey2, true);
				}
			}
			if (!(punishReport.ShowType != EPunishReportShowType.Storm))
			{
				string resourcePath = UiResourceConfig.Instance.GetResourcePath("T_TipsIconXuZhiCiBao1");
				base.SetTextureByPath(resourcePath, base.GetTexture(2), null, null);
				string resourcePath2 = UiResourceConfig.Instance.GetResourcePath("T_TipsIconXuZhiCiBao2");
				base.SetTextureByPath(resourcePath2, base.GetTexture(3), null, null);
			}
		}

		// Token: 0x0602F302 RID: 193282 RVA: 0x00D26D10 File Offset: 0x00D24F10
		[NullableContext(1)]
		private void OnStartSequenceEnd(string _)
		{
			this.UiViewSequence.RemoveSequenceFinishEvent(this.UiViewSequence.StartSequenceName, new Action<string>(this.OnStartSequenceEnd));
			base.CloseMe(null);
		}

		// Token: 0x0200A631 RID: 42545
		private enum EViewComponent
		{
			// Token: 0x04033654 RID: 210516
			TitleText,
			// Token: 0x04033655 RID: 210517
			DescribeText,
			// Token: 0x04033656 RID: 210518
			Texture1,
			// Token: 0x04033657 RID: 210519
			Texture2
		}
	}
}
