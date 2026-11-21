using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.View
{
	// Token: 0x02005458 RID: 21592
	public class MatchThreeGradePopView : UiPanelBase
	{
		// Token: 0x060359A2 RID: 219554 RVA: 0x00EF9480 File Offset: 0x00EF7680
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060359A3 RID: 219555 RVA: 0x00EF94C8 File Offset: 0x00EF76C8
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
		}

		// Token: 0x060359A4 RID: 219556 RVA: 0x00EF94DC File Offset: 0x00EF76DC
		public void SetContent(ScoreComment comment)
		{
			if (string.IsNullOrEmpty(comment.Icon))
			{
				return;
			}
			base.SetTextureByPath(comment.Icon, base.GetTexture(0), null, null);
		}

		// Token: 0x060359A5 RID: 219557 RVA: 0x00EF9514 File Offset: 0x00EF7714
		protected override UniTask OnShowAsyncImplementImplement()
		{
			MatchThreeGradePopView.<OnShowAsyncImplementImplement>d__5 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<MatchThreeGradePopView.<OnShowAsyncImplementImplement>d__5>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x060359A6 RID: 219558 RVA: 0x00EF9558 File Offset: 0x00EF7758
		protected override UniTask OnBeforeHideAsync()
		{
			MatchThreeGradePopView.<OnBeforeHideAsync>d__6 <OnBeforeHideAsync>d__;
			<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideAsync>d__.<>4__this = this;
			<OnBeforeHideAsync>d__.<>1__state = -1;
			<OnBeforeHideAsync>d__.<>t__builder.Start<MatchThreeGradePopView.<OnBeforeHideAsync>d__6>(ref <OnBeforeHideAsync>d__);
			return <OnBeforeHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060359A7 RID: 219559 RVA: 0x00EF959B File Offset: 0x00EF779B
		protected override void OnBeforeDestroy()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x0401C560 RID: 116064
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0200B0EF RID: 45295
		private enum EComponent
		{
			// Token: 0x04036B74 RID: 224116
			TexGrade
		}
	}
}
