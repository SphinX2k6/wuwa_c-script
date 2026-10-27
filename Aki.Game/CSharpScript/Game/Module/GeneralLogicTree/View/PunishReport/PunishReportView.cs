using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.GeneralLogicTree.View.PunishReport
{
	// Token: 0x020059BE RID: 22974
	public class PunishReportView : UiViewBase
	{
		// Token: 0x0603A3D8 RID: 238552 RVA: 0x00DD766C File Offset: 0x00DD586C
		[NullableContext(1)]
		public PunishReportView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603A3D9 RID: 238553 RVA: 0x00DD7678 File Offset: 0x00DD5878
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

		// Token: 0x0603A3DA RID: 238554 RVA: 0x00DD7724 File Offset: 0x00DD5924
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

		// Token: 0x0603A3DB RID: 238555 RVA: 0x00DD7838 File Offset: 0x00DD5A38
		[NullableContext(1)]
		private void OnStartSequenceEnd(string _)
		{
			this.UiViewSequence.RemoveSequenceFinishEvent(this.UiViewSequence.StartSequenceName, new Action<string>(this.OnStartSequenceEnd));
			base.CloseMe(null);
		}

		// Token: 0x0200BC26 RID: 48166
		private enum EViewComponent
		{
			// Token: 0x04038C85 RID: 232581
			TitleText,
			// Token: 0x04038C86 RID: 232582
			DescribeText,
			// Token: 0x04038C87 RID: 232583
			Texture1,
			// Token: 0x04038C88 RID: 232584
			Texture2
		}
	}
}
