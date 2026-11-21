using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004E27 RID: 20007
	public class TopBuffItem : UiPanelBase
	{
		// Token: 0x06032545 RID: 206149 RVA: 0x00E1C144 File Offset: 0x00E1A344
		public override void SetActive(bool visibility)
		{
			if (this.GetVisible() != visibility)
			{
				Log.Instance.Error(ELogModule.Battle, ELogAuthor.CFT, "不要直接调用SetActive, 请调用SetVisible", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			base.SetActive(visibility);
		}

		// Token: 0x06032546 RID: 206150 RVA: 0x00E1C180 File Offset: 0x00E1A380
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

		// Token: 0x06032547 RID: 206151 RVA: 0x00E1C1AD File Offset: 0x00E1A3AD
		private void SetVisibleInner(int visibleReason, bool bVisible)
		{
			this.InnerVisibleState = VisibleStateUtil.SetVisible(this.InnerVisibleState, bVisible, visibleReason);
		}

		// Token: 0x06032548 RID: 206152 RVA: 0x00E1C1C2 File Offset: 0x00E1A3C2
		public bool GetVisible()
		{
			return this.InnerVisibleState == 0;
		}

		// Token: 0x06032549 RID: 206153 RVA: 0x00E1C1CD File Offset: 0x00E1A3CD
		protected void InitTweenAnim(int componentType)
		{
			if (this.TweenAnimPlayer == null)
			{
				this.TweenAnimPlayer = new BattleUiTweenAnimPlayer();
			}
			this.TweenAnimPlayer.InitTweenAnim(componentType, base.GetItem(componentType), false);
		}

		// Token: 0x0603254A RID: 206154 RVA: 0x00E1C1F6 File Offset: 0x00E1A3F6
		protected void PlayTweenAnim(int componentType)
		{
			BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
			if (tweenAnimPlayer == null)
			{
				return;
			}
			tweenAnimPlayer.PlayTweenAnim(componentType);
		}

		// Token: 0x0603254B RID: 206155 RVA: 0x00E1C209 File Offset: 0x00E1A409
		protected void StopTweenAnim(int componentType)
		{
			BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
			if (tweenAnimPlayer == null)
			{
				return;
			}
			tweenAnimPlayer.StopTweenAnim(componentType);
		}

		// Token: 0x0603254C RID: 206156 RVA: 0x00E1C21C File Offset: 0x00E1A41C
		protected void ClearAllTweenAnim()
		{
			BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
			if (tweenAnimPlayer == null)
			{
				return;
			}
			tweenAnimPlayer.Clear(false);
		}

		// Token: 0x0603254D RID: 206157 RVA: 0x00E1C22F File Offset: 0x00E1A42F
		protected void SetTweenTimeScale(int componentType, float timeScale)
		{
			BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
			if (tweenAnimPlayer == null)
			{
				return;
			}
			tweenAnimPlayer.SetTweenTimeScale(componentType, timeScale);
		}

		// Token: 0x0401AAD4 RID: 109268
		protected int InnerVisibleState = 1;

		// Token: 0x0401AAD5 RID: 109269
		[Nullable(2)]
		protected BattleUiTweenAnimPlayer TweenAnimPlayer;
	}
}
