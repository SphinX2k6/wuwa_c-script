using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DC3 RID: 19907
	public class RoguelikeBossChallengeBuffDetailView : UiViewBase
	{
		// Token: 0x0603363F RID: 210495 RVA: 0x00BFF8C6 File Offset: 0x00BFDAC6
		[NullableContext(1)]
		public RoguelikeBossChallengeBuffDetailView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06033640 RID: 210496 RVA: 0x00BFF8D0 File Offset: 0x00BFDAD0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06033641 RID: 210497 RVA: 0x00BFF93C File Offset: 0x00BFDB3C
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikeBossChallengeBuffDetailView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikeBossChallengeBuffDetailView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033642 RID: 210498 RVA: 0x00BFF97F File Offset: 0x00BFDB7F
		protected override void OnStart()
		{
			this.InitBuffData();
		}

		// Token: 0x06033643 RID: 210499 RVA: 0x00BFF987 File Offset: 0x00BFDB87
		protected override void OnBeforeDestroy()
		{
			this.CaptionItem = null;
			this.DebuffListPanel = null;
		}

		// Token: 0x06033644 RID: 210500 RVA: 0x00BFF998 File Offset: 0x00BFDB98
		private void InitBuffData()
		{
			int[] array = (int[])this.OpenParam;
			int num = array[0];
			int num2 = array[1];
			if (num == 0)
			{
				return;
			}
			RoguelikeConfig instance = RoguelikeConfig.Instance;
			RogueTower? rogueTower = (instance != null) ? instance.GetRogueTowerConfig(num) : null;
			if (rogueTower == null)
			{
				return;
			}
			int[] array2 = rogueTower.Value.Buffs() ?? Array.Empty<int>();
			HashSet<int> hashSet = new HashSet<int>();
			List<RoguelikeBossChallengeBuffData> list = new List<RoguelikeBossChallengeBuffData>();
			foreach (int num3 in array2)
			{
				if (num3 != 0 && !hashSet.Contains(num3))
				{
					hashSet.Add(num3);
					list.Add(new RoguelikeBossChallengeBuffData
					{
						Id = num3,
						IsActive = (num3 == num2),
						DescMode = EDescModel.DETAIL
					});
				}
			}
			RoguelikeBossChallengeBuffListItem debuffListPanel = this.DebuffListPanel;
			if (debuffListPanel == null)
			{
				return;
			}
			debuffListPanel.RefreshBuffList(list);
		}

		// Token: 0x06033645 RID: 210501 RVA: 0x00BFFA79 File Offset: 0x00BFDC79
		private void OnCloseClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401B49A RID: 111770
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401B49B RID: 111771
		[Nullable(2)]
		private RoguelikeBossChallengeBuffListItem DebuffListPanel;

		// Token: 0x0200AF39 RID: 44857
		private class EComponents
		{
			// Token: 0x0403535B RID: 217947
			public const int ItemCaption = 0;

			// Token: 0x0403535C RID: 217948
			public const int ItemDebuffList = 1;
		}
	}
}
