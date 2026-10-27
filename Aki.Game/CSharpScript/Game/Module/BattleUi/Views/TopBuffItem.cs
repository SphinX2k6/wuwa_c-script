using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E42 RID: 24130
	public class TopBuffItem : UiPanelBase
	{
		// Token: 0x0603D5B5 RID: 251317 RVA: 0x00ECABD8 File Offset: 0x00EC8DD8
		public override void SetActive(bool visibility)
		{
			if (this.GetVisible() != visibility)
			{
				Log.Instance.Error(ELogModule.Battle, ELogAuthor.CFT, "不要直接调用SetActive, 请调用SetVisible", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			base.SetActive(visibility);
		}

		// Token: 0x0603D5B6 RID: 251318 RVA: 0x00ECAC14 File Offset: 0x00EC8E14
		public void SetVisible(int visibleReason, bool bVisible)
		{
			bool visible = this.GetVisible();
			this.SetVisibleInner(visibleReason, bVisible);
			bool visible2 = this.GetVisible();
			if (visible == visible2)
			{
				return;
			}
			this.SetActive(visible2);
		}

		// Token: 0x0603D5B7 RID: 251319 RVA: 0x00ECAC41 File Offset: 0x00EC8E41
		private void SetVisibleInner(int visibleReason, bool bVisible)
		{
			this.InnerVisibleState = VisibleStateUtil.SetVisible(this.InnerVisibleState, bVisible, visibleReason);
		}

		// Token: 0x0603D5B8 RID: 251320 RVA: 0x00ECAC56 File Offset: 0x00EC8E56
		public bool GetVisible()
		{
			return this.InnerVisibleState == 0;
		}

		// Token: 0x0603D5B9 RID: 251321 RVA: 0x00ECAC61 File Offset: 0x00EC8E61
		protected void InitTweenAnim(int componentType)
		{
			if (this.TweenAnimPlayer == null)
			{
				this.TweenAnimPlayer = new BattleUiTweenAnimPlayer();
			}
			this.TweenAnimPlayer.InitTweenAnim(componentType, base.GetItem(componentType), false);
		}

		// Token: 0x0603D5BA RID: 251322 RVA: 0x00ECAC8A File Offset: 0x00EC8E8A
		protected void PlayTweenAnim(int componentType)
		{
			BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
			if (tweenAnimPlayer == null)
			{
				return;
			}
			tweenAnimPlayer.PlayTweenAnim(componentType);
		}

		// Token: 0x0603D5BB RID: 251323 RVA: 0x00ECAC9D File Offset: 0x00EC8E9D
		protected void StopTweenAnim(int componentType)
		{
			BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
			if (tweenAnimPlayer == null)
			{
				return;
			}
			tweenAnimPlayer.StopTweenAnim(componentType);
		}

		// Token: 0x0603D5BC RID: 251324 RVA: 0x00ECACB0 File Offset: 0x00EC8EB0
		protected void ClearAllTweenAnim()
		{
			BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
			if (tweenAnimPlayer == null)
			{
				return;
			}
			tweenAnimPlayer.Clear(false);
		}

		// Token: 0x0603D5BD RID: 251325 RVA: 0x00ECACC3 File Offset: 0x00EC8EC3
		protected void SetTweenTimeScale(int componentType, float timeScale)
		{
			BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
			if (tweenAnimPlayer == null)
			{
				return;
			}
			tweenAnimPlayer.SetTweenTimeScale(componentType, timeScale);
		}

		// Token: 0x0402000D RID: 131085
		protected int InnerVisibleState = 1;

		// Token: 0x0402000E RID: 131086
		[Nullable(2)]
		protected BattleUiTweenAnimPlayer TweenAnimPlayer;
	}
}
