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
	// Token: 0x02004FCC RID: 20428
	[NullableContext(2)]
	[Nullable(0)]
	public class QuestMultiLineTipsPanel : UiPanelBase
	{
		// Token: 0x0603443F RID: 214079 RVA: 0x00C46224 File Offset: 0x00C44424
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

		// Token: 0x06034440 RID: 214080 RVA: 0x00C4633C File Offset: 0x00C4453C
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		}

		// Token: 0x06034441 RID: 214081 RVA: 0x00C4634F File Offset: 0x00C4454F
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x06034442 RID: 214082 RVA: 0x00C4636C File Offset: 0x00C4456C
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

		// Token: 0x06034443 RID: 214083 RVA: 0x00C46520 File Offset: 0x00C44720
		public void SetHideCallback(Action callback)
		{
			this.HideCallback = callback;
		}

		// Token: 0x06034444 RID: 214084 RVA: 0x00C46529 File Offset: 0x00C44729
		public void SetHideSelfBtnInterceptor(Func<bool> interceptor)
		{
			this.HideSelfBtnInterceptor = interceptor;
		}

		// Token: 0x06034445 RID: 214085 RVA: 0x00C46534 File Offset: 0x00C44734
		public UniTask ShowAndPlayStartAsync()
		{
			QuestMultiLineTipsPanel.<ShowAndPlayStartAsync>d__10 <ShowAndPlayStartAsync>d__;
			<ShowAndPlayStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowAndPlayStartAsync>d__.<>4__this = this;
			<ShowAndPlayStartAsync>d__.<>1__state = -1;
			<ShowAndPlayStartAsync>d__.<>t__builder.Start<QuestMultiLineTipsPanel.<ShowAndPlayStartAsync>d__10>(ref <ShowAndPlayStartAsync>d__);
			return <ShowAndPlayStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034446 RID: 214086 RVA: 0x00C46578 File Offset: 0x00C44778
		public UniTask PlayCloseAndHideAsync()
		{
			QuestMultiLineTipsPanel.<PlayCloseAndHideAsync>d__11 <PlayCloseAndHideAsync>d__;
			<PlayCloseAndHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayCloseAndHideAsync>d__.<>4__this = this;
			<PlayCloseAndHideAsync>d__.<>1__state = -1;
			<PlayCloseAndHideAsync>d__.<>t__builder.Start<QuestMultiLineTipsPanel.<PlayCloseAndHideAsync>d__11>(ref <PlayCloseAndHideAsync>d__);
			return <PlayCloseAndHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034447 RID: 214087 RVA: 0x00C465BB File Offset: 0x00C447BB
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

		// Token: 0x0401BCDF RID: 113887
		private QuestMultiLineComponentData ComponentData;

		// Token: 0x0401BCE0 RID: 113888
		private Action HideCallback;

		// Token: 0x0401BCE1 RID: 113889
		private Func<bool> HideSelfBtnInterceptor;

		// Token: 0x0401BCE2 RID: 113890
		private LevelSequencePlayer SequencePlayer;
	}
}
