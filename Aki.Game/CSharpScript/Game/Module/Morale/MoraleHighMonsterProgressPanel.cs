using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x020053B1 RID: 21425
	public class MoraleHighMonsterProgressPanel : UiPanelBase
	{
		// Token: 0x06036C06 RID: 224262 RVA: 0x00CF5734 File Offset: 0x00CF3934
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

		// Token: 0x06036C07 RID: 224263 RVA: 0x00CF577F File Offset: 0x00CF397F
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText))
			};
		}

		// Token: 0x06036C08 RID: 224264 RVA: 0x00CF57A4 File Offset: 0x00CF39A4
		protected override UniTask OnBeforeStartAsync()
		{
			MoraleHighMonsterProgressPanel.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoraleHighMonsterProgressPanel.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036C09 RID: 224265 RVA: 0x00CF57E7 File Offset: 0x00CF39E7
		protected override void OnStart()
		{
		}

		// Token: 0x06036C0A RID: 224266 RVA: 0x00CF57E9 File Offset: 0x00CF39E9
		protected override void OnBeforeShow()
		{
		}

		// Token: 0x06036C0B RID: 224267 RVA: 0x00CF57EB File Offset: 0x00CF39EB
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x06036C0C RID: 224268 RVA: 0x00CF57F0 File Offset: 0x00CF39F0
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

		// Token: 0x0200B64B RID: 46667
		private class EChildType
		{
			// Token: 0x040373A3 RID: 226211
			public const int TextProgress = 0;
		}
	}
}
