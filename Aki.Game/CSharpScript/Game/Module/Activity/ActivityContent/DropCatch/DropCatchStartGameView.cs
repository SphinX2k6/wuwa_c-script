using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x020066C3 RID: 26307
	[NullableContext(1)]
	[Nullable(0)]
	public class DropCatchStartGameView : UiViewBase
	{
		// Token: 0x17009644 RID: 38468
		// (get) Token: 0x06041CB8 RID: 269496 RVA: 0x00FF51B4 File Offset: 0x00FF33B4
		public new IDropCatchGameplayStartViewParams OpenParam
		{
			get
			{
				return this.OpenParam as IDropCatchGameplayStartViewParams;
			}
		}

		// Token: 0x06041CB9 RID: 269497 RVA: 0x00FF51C1 File Offset: 0x00FF33C1
		public DropCatchStartGameView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06041CBA RID: 269498 RVA: 0x00FF51CC File Offset: 0x00FF33CC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIArtText)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(USpineSkeletonAnimationComponent)),
				new ValueTuple<int, Type>(6, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(2, new Action(this.OnClickStart))
			};
		}

		// Token: 0x06041CBB RID: 269499 RVA: 0x00FF52A4 File Offset: 0x00FF34A4
		protected override UniTask OnBeforeStartAsync()
		{
			DropCatchStartGameView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DropCatchStartGameView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06041CBC RID: 269500 RVA: 0x00FF52E8 File Offset: 0x00FF34E8
		private UniTask InitCaption()
		{
			DropCatchStartGameView.<InitCaption>d__7 <InitCaption>d__;
			<InitCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCaption>d__.<>4__this = this;
			<InitCaption>d__.<>1__state = -1;
			<InitCaption>d__.<>t__builder.Start<DropCatchStartGameView.<InitCaption>d__7>(ref <InitCaption>d__);
			return <InitCaption>d__.<>t__builder.Task;
		}

		// Token: 0x06041CBD RID: 269501 RVA: 0x00FF532C File Offset: 0x00FF352C
		private UniTask InitRoleView()
		{
			DropCatchStartGameView.<InitRoleView>d__8 <InitRoleView>d__;
			<InitRoleView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRoleView>d__.<>4__this = this;
			<InitRoleView>d__.<>1__state = -1;
			<InitRoleView>d__.<>t__builder.Start<DropCatchStartGameView.<InitRoleView>d__8>(ref <InitRoleView>d__);
			return <InitRoleView>d__.<>t__builder.Task;
		}

		// Token: 0x06041CBE RID: 269502 RVA: 0x00FF5370 File Offset: 0x00FF3570
		protected override void OnStart()
		{
			DropCatchGameplay? dropCatchGameplayById = DropCatchConfig.Instance.GetDropCatchGameplayById(this.OpenParam.GameplayId);
			if (dropCatchGameplayById == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DropCatch;
				ELogAuthor author = ELogAuthor.CB;
				string message = "DropCatchStartGameView Gameplay config not found";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("GameplayId", this.OpenParam.GameplayId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(0), dropCatchGameplayById.Value.Desc, Array.Empty<object>());
			if (this.OpenParam.HistoryScore > 0f)
			{
				UUIArtText artText = base.GetArtText(3);
				if (artText != null)
				{
					artText.SetUIActive(true);
				}
				UUIText text = base.GetText(4);
				if (text != null)
				{
					text.SetUIActive(false);
				}
				UUIArtText artText2 = base.GetArtText(3);
				if (artText2 != null)
				{
					artText2.SetText(this.OpenParam.HistoryScore.ToString());
				}
			}
			else
			{
				UUIArtText artText3 = base.GetArtText(3);
				if (artText3 != null)
				{
					artText3.SetUIActive(false);
				}
				UUIText text2 = base.GetText(4);
				if (text2 != null)
				{
					text2.SetUIActive(true);
				}
			}
			USpineSkeletonAnimationComponent spine = base.GetSpine(5);
			if (spine == null)
			{
				return;
			}
			spine.SetAnimation(0, EDropCatchRobotAnimState.HappyLeft.ToEnumString(), true);
		}

		// Token: 0x06041CBF RID: 269503 RVA: 0x00FF5497 File Offset: 0x00FF3697
		private void OnClickStart()
		{
			DropCatchGameplayController.Instance.StartGameplay(this.OpenParam.GameplayId);
			base.CloseMe(null);
		}

		// Token: 0x04022470 RID: 140400
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04022471 RID: 140401
		[Nullable(2)]
		private DropCatchGameplayRoleView RoleView;
	}
}
