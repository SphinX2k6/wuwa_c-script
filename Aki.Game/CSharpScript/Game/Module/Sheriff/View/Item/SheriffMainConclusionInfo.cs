using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Sheriff.View.Item
{
	// Token: 0x02003C1D RID: 15389
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffMainConclusionInfo : GridProxyAbstract<int>
	{
		// Token: 0x060276DC RID: 161500 RVA: 0x00B0E404 File Offset: 0x00B0C604
		public SheriffMainConclusionInfo(SheriffMainProxy proxy)
		{
			this.Proxy = proxy;
		}

		// Token: 0x060276DD RID: 161501 RVA: 0x00B0E414 File Offset: 0x00B0C614
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

		// Token: 0x060276DE RID: 161502 RVA: 0x00B0E4BF File Offset: 0x00B0C6BF
		protected override void OnStart()
		{
			this.ClueLayout = new GenericLayout<SheriffConclusionClueInfo, int>(base.GetHorizontalLayout(2), new Func<SheriffConclusionClueInfo>(this.CreateClueInfoItem), null, false, true);
		}

		// Token: 0x060276DF RID: 161503 RVA: 0x00B0E4E4 File Offset: 0x00B0C6E4
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

		// Token: 0x060276E0 RID: 161504 RVA: 0x00B0E5DA File Offset: 0x00B0C7DA
		private SheriffConclusionClueInfo CreateClueInfoItem()
		{
			return new SheriffConclusionClueInfo();
		}

		// Token: 0x040157F3 RID: 88051
		protected SheriffMainProxy Proxy;

		// Token: 0x040157F4 RID: 88052
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<SheriffConclusionClueInfo, int> ClueLayout;

		// Token: 0x0200983D RID: 38973
		[NullableContext(0)]
		private static class EDefine
		{
			// Token: 0x0402F7C3 RID: 194499
			public const int TxtTitle = 0;

			// Token: 0x0402F7C4 RID: 194500
			public const int TxtInfo = 1;

			// Token: 0x0402F7C5 RID: 194501
			public const int PanelHorizontal = 2;

			// Token: 0x0402F7C6 RID: 194502
			public const int ClueItem = 3;
		}
	}
}
