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
	// Token: 0x02003D8C RID: 15756
	public class RoguelikeBossChallengeBuffDetailView : UiViewBase
	{
		// Token: 0x060284AC RID: 165036 RVA: 0x00B48E06 File Offset: 0x00B47006
		[NullableContext(1)]
		public RoguelikeBossChallengeBuffDetailView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060284AD RID: 165037 RVA: 0x00B48E10 File Offset: 0x00B47010
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

		// Token: 0x060284AE RID: 165038 RVA: 0x00B48E7C File Offset: 0x00B4707C
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikeBossChallengeBuffDetailView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikeBossChallengeBuffDetailView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060284AF RID: 165039 RVA: 0x00B48EBF File Offset: 0x00B470BF
		protected override void OnStart()
		{
			this.InitBuffData();
		}

		// Token: 0x060284B0 RID: 165040 RVA: 0x00B48EC7 File Offset: 0x00B470C7
		protected override void OnBeforeDestroy()
		{
			this.CaptionItem = null;
			this.DebuffListPanel = null;
		}

		// Token: 0x060284B1 RID: 165041 RVA: 0x00B48ED8 File Offset: 0x00B470D8
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

		// Token: 0x060284B2 RID: 165042 RVA: 0x00B48FB9 File Offset: 0x00B471B9
		private void OnCloseClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x04015E6D RID: 89709
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04015E6E RID: 89710
		[Nullable(2)]
		private RoguelikeBossChallengeBuffListItem DebuffListPanel;

		// Token: 0x0200996E RID: 39278
		private class EComponents
		{
			// Token: 0x0402FD90 RID: 195984
			public const int ItemCaption = 0;

			// Token: 0x0402FD91 RID: 195985
			public const int ItemDebuffList = 1;
		}
	}
}
