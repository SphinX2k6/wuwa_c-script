using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.QuestMultiLine.QuestMultiLineData;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuestMultiLine.View.Items
{
	// Token: 0x02003F95 RID: 16277
	[NullableContext(2)]
	[Nullable(0)]
	public class QuestMultiLineTipsPanel : UiPanelBase
	{
		// Token: 0x060292AD RID: 168621 RVA: 0x00B8F9DC File Offset: 0x00B8DBDC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUISprite)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(7, typeof(UUITexture)),
				new ValueTuple<int, Type>(8, typeof(UUISprite)),
				new ValueTuple<int, Type>(9, typeof(UUITexture))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(6, new Action(this.HideSelf))
			};
		}

		// Token: 0x060292AE RID: 168622 RVA: 0x00B8FAF4 File Offset: 0x00B8DCF4
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		}

		// Token: 0x060292AF RID: 168623 RVA: 0x00B8FB07 File Offset: 0x00B8DD07
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x060292B0 RID: 168624 RVA: 0x00B8FB24 File Offset: 0x00B8DD24
		[NullableContext(1)]
		public void RefreshTips(QuestMultiLineComponentData componentData)
		{
			this.ComponentData = componentData;
			bool flag = QuestMultiLineUtils.IsMultiPersonAvatar(this.ComponentData);
			base.GetTexture(0).SetUIActive(!flag);
			base.GetTexture(9).SetUIActive(flag);
			if (flag)
			{
				base.SetTextureByPath(QuestMultiLineUtils.GetMultiPersonAvatarTexture(this.ComponentData), base.GetTexture(9), null, null);
			}
			else
			{
				base.SetTextureByPath(QuestMultiLineUtils.GetComponentIconTexture(this.ComponentData), base.GetTexture(0), null, null);
			}
			string headIconBgInTip = this.ComponentData.HeadIconBgInTip;
			if (!string.IsNullOrEmpty(headIconBgInTip))
			{
				base.GetSprite(8).SetUIActive(true);
				this.SetSpriteByPath(headIconBgInTip, base.GetSprite(8), false, null, null);
			}
			else
			{
				base.GetSprite(8).SetUIActive(false);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), this.ComponentData.TipsTitle, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), this.ComponentData.TipsArea, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), this.ComponentData.TipsStatusDesc, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), this.ComponentData.TipsDesc, Array.Empty<object>());
			string statusIcon = QuestMultiLineConfig.GetComponentStatusConfigById(this.ComponentData.StatusType).Value.StatusIcon;
			if (!string.IsNullOrEmpty(statusIcon))
			{
				base.GetSprite(3).SetUIActive(true);
				this.SetSpriteByPath(statusIcon, base.GetSprite(3), false, null, null);
				return;
			}
			base.GetSprite(3).SetUIActive(false);
		}

		// Token: 0x060292B1 RID: 168625 RVA: 0x00B8FCD8 File Offset: 0x00B8DED8
		public void SetHideCallback(Action callback)
		{
			this.HideCallback = callback;
		}

		// Token: 0x060292B2 RID: 168626 RVA: 0x00B8FCE1 File Offset: 0x00B8DEE1
		public void SetHideSelfBtnInterceptor(Func<bool> interceptor)
		{
			this.HideSelfBtnInterceptor = interceptor;
		}

		// Token: 0x060292B3 RID: 168627 RVA: 0x00B8FCEC File Offset: 0x00B8DEEC
		public UniTask ShowAndPlayStartAsync()
		{
			QuestMultiLineTipsPanel.<ShowAndPlayStartAsync>d__10 <ShowAndPlayStartAsync>d__;
			<ShowAndPlayStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowAndPlayStartAsync>d__.<>4__this = this;
			<ShowAndPlayStartAsync>d__.<>1__state = -1;
			<ShowAndPlayStartAsync>d__.<>t__builder.Start<QuestMultiLineTipsPanel.<ShowAndPlayStartAsync>d__10>(ref <ShowAndPlayStartAsync>d__);
			return <ShowAndPlayStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060292B4 RID: 168628 RVA: 0x00B8FD30 File Offset: 0x00B8DF30
		public UniTask PlayCloseAndHideAsync()
		{
			QuestMultiLineTipsPanel.<PlayCloseAndHideAsync>d__11 <PlayCloseAndHideAsync>d__;
			<PlayCloseAndHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayCloseAndHideAsync>d__.<>4__this = this;
			<PlayCloseAndHideAsync>d__.<>1__state = -1;
			<PlayCloseAndHideAsync>d__.<>t__builder.Start<QuestMultiLineTipsPanel.<PlayCloseAndHideAsync>d__11>(ref <PlayCloseAndHideAsync>d__);
			return <PlayCloseAndHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060292B5 RID: 168629 RVA: 0x00B8FD73 File Offset: 0x00B8DF73
		private void HideSelf()
		{
			Func<bool> hideSelfBtnInterceptor = this.HideSelfBtnInterceptor;
			if (hideSelfBtnInterceptor != null && hideSelfBtnInterceptor())
			{
				return;
			}
			this.PlayCloseAndHideAsync();
			AudioSystem.Instance.PostEvent("play_ui_ia_com_close");
		}

		// Token: 0x040166B4 RID: 91828
		private QuestMultiLineComponentData ComponentData;

		// Token: 0x040166B5 RID: 91829
		private Action HideCallback;

		// Token: 0x040166B6 RID: 91830
		private Func<bool> HideSelfBtnInterceptor;

		// Token: 0x040166B7 RID: 91831
		private LevelSequencePlayer SequencePlayer;
	}
}
