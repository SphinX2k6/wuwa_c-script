using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x02004394 RID: 17300
	public class MoraleHighMonsterProgressPanel : UiPanelBase
	{
		// Token: 0x0602BB4C RID: 179020 RVA: 0x00C447DC File Offset: 0x00C429DC
		[NullableContext(1)]
		public UniTask Init(UUIItem item)
		{
			MoraleHighMonsterProgressPanel.<Init>d__1 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.item = item;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<MoraleHighMonsterProgressPanel.<Init>d__1>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0602BB4D RID: 179021 RVA: 0x00C44827 File Offset: 0x00C42A27
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText))
			};
		}

		// Token: 0x0602BB4E RID: 179022 RVA: 0x00C4484C File Offset: 0x00C42A4C
		protected override UniTask OnBeforeStartAsync()
		{
			MoraleHighMonsterProgressPanel.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoraleHighMonsterProgressPanel.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602BB4F RID: 179023 RVA: 0x00C4488F File Offset: 0x00C42A8F
		protected override void OnStart()
		{
		}

		// Token: 0x0602BB50 RID: 179024 RVA: 0x00C44891 File Offset: 0x00C42A91
		protected override void OnBeforeShow()
		{
		}

		// Token: 0x0602BB51 RID: 179025 RVA: 0x00C44893 File Offset: 0x00C42A93
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x0602BB52 RID: 179026 RVA: 0x00C44898 File Offset: 0x00C42A98
		public void UpdateProgress(int? val = null)
		{
			int value = val ?? MoraleModel.Instance.GetAllHighMonsterProgress();
			int allHighMonsterTotal = MoraleModel.Instance.GetAllHighMonsterTotal();
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(allHighMonsterTotal);
			string newText = defaultInterpolatedStringHandler.ToStringAndClear();
			UUIText text = base.GetText(0);
			if (text == null)
			{
				return;
			}
			text.SetText(newText, true);
		}

		// Token: 0x0200A083 RID: 41091
		private class EChildType
		{
			// Token: 0x04031DF8 RID: 204280
			public const int TextProgress = 0;
		}
	}
}
