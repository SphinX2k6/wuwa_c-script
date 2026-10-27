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
	// Token: 0x020064DA RID: 25818
	public class MatchThreeGradePopView : UiPanelBase
	{
		// Token: 0x06040CDE RID: 265438 RVA: 0x00FB2450 File Offset: 0x00FB0650
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

		// Token: 0x06040CDF RID: 265439 RVA: 0x00FB2498 File Offset: 0x00FB0698
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
		}

		// Token: 0x06040CE0 RID: 265440 RVA: 0x00FB24AC File Offset: 0x00FB06AC
		public void SetContent(ScoreComment comment)
		{
			if (string.IsNullOrEmpty(comment.Icon))
			{
				return;
			}
			base.SetTextureByPath(comment.Icon, base.GetTexture(0), null, null);
		}

		// Token: 0x06040CE1 RID: 265441 RVA: 0x00FB24E4 File Offset: 0x00FB06E4
		protected override UniTask OnShowAsyncImplementImplement()
		{
			MatchThreeGradePopView.<OnShowAsyncImplementImplement>d__5 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<MatchThreeGradePopView.<OnShowAsyncImplementImplement>d__5>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06040CE2 RID: 265442 RVA: 0x00FB2528 File Offset: 0x00FB0728
		protected override UniTask OnBeforeHideAsync()
		{
			MatchThreeGradePopView.<OnBeforeHideAsync>d__6 <OnBeforeHideAsync>d__;
			<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideAsync>d__.<>4__this = this;
			<OnBeforeHideAsync>d__.<>1__state = -1;
			<OnBeforeHideAsync>d__.<>t__builder.Start<MatchThreeGradePopView.<OnBeforeHideAsync>d__6>(ref <OnBeforeHideAsync>d__);
			return <OnBeforeHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040CE3 RID: 265443 RVA: 0x00FB256B File Offset: 0x00FB076B
		protected override void OnBeforeDestroy()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x04021C2F RID: 138287
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0200C709 RID: 50953
		private enum EComponent
		{
			// Token: 0x0403C219 RID: 246297
			TexGrade
		}
	}
}
