using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005910 RID: 22800
	public sealed class SolarSchoolForumGameplay : SolarSchoolGameplayBase, ISolarSchoolForumViewHandler
	{
		// Token: 0x0603835F RID: 230239 RVA: 0x00FB728C File Offset: 0x00FB548C
		protected override void OnGameplayStart()
		{
			if (SolarSchoolConfig.Instance.GetForum(base.GameplayId) == null)
			{
				base.MarkFailed();
				return;
			}
			base.AddState("OpenView", new Action(this.EnterOpenView));
			base.AddState("ShowPost", new Action(this.EnterShowPost));
		}

		// Token: 0x06038360 RID: 230240 RVA: 0x00FB72E8 File Offset: 0x00FB54E8
		protected override void OnGameplayEnd()
		{
			this.CloseView();
		}

		// Token: 0x06038361 RID: 230241 RVA: 0x00FB72F0 File Offset: 0x00FB54F0
		private void EnterOpenView()
		{
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolForumView, this, null);
		}

		// Token: 0x06038362 RID: 230242 RVA: 0x00FB7304 File Offset: 0x00FB5504
		private unsafe void EnterShowPost()
		{
			SolarSchoolForum? forum = SolarSchoolConfig.Instance.GetForum(base.GameplayId);
			if (forum == null)
			{
				return;
			}
			int[] postListArray = forum.Value.GetPostListArray();
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "[SolarSchool][Forum] 展示论坛帖子";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("configId", base.GameplayId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("posts", postListArray);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			SolarSchoolForumView view = this.View;
			if (view == null)
			{
				return;
			}
			view.ShowForum(forum.Value.Title, postListArray);
		}

		// Token: 0x06038363 RID: 230243 RVA: 0x00FB73BC File Offset: 0x00FB55BC
		[NullableContext(1)]
		public void OnViewReady(SolarSchoolForumView view)
		{
			this.View = view;
			base.GotoState("ShowPost");
		}

		// Token: 0x06038364 RID: 230244 RVA: 0x00FB73D0 File Offset: 0x00FB55D0
		public void OnLikeSelected()
		{
			SolarSchoolForum? forum = SolarSchoolConfig.Instance.GetForum(base.GameplayId);
			if (forum == null)
			{
				return;
			}
			int likeReward = forum.Value.LikeReward;
			SolarSchoolRewardCenter.Instance.TryGiveReward(likeReward);
		}

		// Token: 0x06038365 RID: 230245 RVA: 0x00FB7414 File Offset: 0x00FB5614
		public void OnContinueClicked()
		{
			this.CloseView();
			base.FinishGameplay();
		}

		// Token: 0x06038366 RID: 230246 RVA: 0x00FB7422 File Offset: 0x00FB5622
		public void OnViewClosed()
		{
			this.View = null;
		}

		// Token: 0x06038367 RID: 230247 RVA: 0x00FB742B File Offset: 0x00FB562B
		private void CloseView()
		{
			if (this.View == null)
			{
				base.CloseOpeningView(EUiViewName.SolarSchoolForumView);
				return;
			}
			UiViewBase view = this.View;
			this.View = null;
			view.CloseMe(null);
		}

		// Token: 0x0401D97A RID: 121210
		[Nullable(2)]
		private SolarSchoolForumView View;

		// Token: 0x0200B4D4 RID: 46292
		[NullableContext(1)]
		[Nullable(0)]
		private static class GameplayState
		{
			// Token: 0x04037E95 RID: 229013
			public const string OpenView = "OpenView";

			// Token: 0x04037E96 RID: 229014
			public const string ShowPost = "ShowPost";
		}
	}
}
