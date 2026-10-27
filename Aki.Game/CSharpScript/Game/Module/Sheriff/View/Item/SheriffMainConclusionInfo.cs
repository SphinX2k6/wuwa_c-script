using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Sheriff.View.Item
{
	// Token: 0x02004C6C RID: 19564
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffMainConclusionInfo : GridProxyAbstract<int>
	{
		// Token: 0x06032929 RID: 207145 RVA: 0x00BC97A0 File Offset: 0x00BC79A0
		public SheriffMainConclusionInfo(SheriffMainProxy proxy)
		{
			this.Proxy = proxy;
		}

		// Token: 0x0603292A RID: 207146 RVA: 0x00BC97B0 File Offset: 0x00BC79B0
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
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603292B RID: 207147 RVA: 0x00BC985B File Offset: 0x00BC7A5B
		protected override void OnStart()
		{
			this.ClueLayout = new GenericLayout<SheriffConclusionClueInfo, int>(base.GetHorizontalLayout(2), new Func<SheriffConclusionClueInfo>(this.CreateClueInfoItem), null, false, true);
		}

		// Token: 0x0603292C RID: 207148 RVA: 0x00BC9880 File Offset: 0x00BC7A80
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			SheriffQuestionCsv value = SheriffConfig.Instance.GetQuestionById(data).Value;
			string conclusionKey = this.Proxy.GetConclusionKey(data);
			PublicUtil instance = PublicUtil.Instance;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 1);
			defaultInterpolatedStringHandler.AppendLiteral("ReasoningQuestion_");
			defaultInterpolatedStringHandler.AppendFormatted<int>(value.Id);
			defaultInterpolatedStringHandler.AppendLiteral("_QuestionDesc");
			string configTextByKey = instance.GetConfigTextByKey(defaultInterpolatedStringHandler.ToStringAndClear());
			int num = this.Proxy.GetQuestionList().IndexOf(data);
			LguiUtil instance2 = LguiUtil.Instance;
			UUIText text = base.GetText(0);
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Inference_Desc_");
			defaultInterpolatedStringHandler.AppendFormatted<int>(27 + num);
			instance2.SetLocalTextNew(text, defaultInterpolatedStringHandler.ToStringAndClear(), new <>z__ReadOnlySingleElementList<object>(configTextByKey));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), conclusionKey, Array.Empty<object>());
			List<int> clueRecords = this.Proxy.GetClueRecords(num);
			this.ClueLayout.RefreshByData(clueRecords, null, true);
		}

		// Token: 0x0603292D RID: 207149 RVA: 0x00BC9976 File Offset: 0x00BC7B76
		private SheriffConclusionClueInfo CreateClueInfoItem()
		{
			return new SheriffConclusionClueInfo();
		}

		// Token: 0x0401AE96 RID: 110230
		protected SheriffMainProxy Proxy;

		// Token: 0x0401AE97 RID: 110231
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<SheriffConclusionClueInfo, int> ClueLayout;

		// Token: 0x0200AE1F RID: 44575
		[NullableContext(0)]
		private static class EDefine
		{
			// Token: 0x04034E1E RID: 216606
			public const int TxtTitle = 0;

			// Token: 0x04034E1F RID: 216607
			public const int TxtInfo = 1;

			// Token: 0x04034E20 RID: 216608
			public const int PanelHorizontal = 2;

			// Token: 0x04034E21 RID: 216609
			public const int ClueItem = 3;
		}
	}
}
