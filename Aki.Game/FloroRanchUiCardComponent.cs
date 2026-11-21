using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02000FDA RID: 4058
[NullableContext(1)]
[Nullable(0)]
[FloroRanchEntityComponent(EFloroRanchEntityComponent.FloroRanchUiCardComponent)]
public class FloroRanchUiCardComponent : FloroRanchUiItemBaseComponent
{
	// Token: 0x0600A1E6 RID: 41446 RVA: 0x002F9128 File Offset: 0x002F7328
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	public override UniTask<FloroRanchUiItemBase> PlayShowAnim()
	{
		FloroRanchUiCardComponent.<PlayShowAnim>d__1 <PlayShowAnim>d__;
		<PlayShowAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder<FloroRanchUiItemBase>.Create();
		<PlayShowAnim>d__.<>4__this = this;
		<PlayShowAnim>d__.<>1__state = -1;
		<PlayShowAnim>d__.<>t__builder.Start<FloroRanchUiCardComponent.<PlayShowAnim>d__1>(ref <PlayShowAnim>d__);
		return <PlayShowAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600A1E7 RID: 41447 RVA: 0x002F916C File Offset: 0x002F736C
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	public override UniTask<FloroRanchUiItemBase> CreateUiItem()
	{
		FloroRanchUiCardComponent.<CreateUiItem>d__2 <CreateUiItem>d__;
		<CreateUiItem>d__.<>t__builder = AsyncUniTaskMethodBuilder<FloroRanchUiItemBase>.Create();
		<CreateUiItem>d__.<>4__this = this;
		<CreateUiItem>d__.<>1__state = -1;
		<CreateUiItem>d__.<>t__builder.Start<FloroRanchUiCardComponent.<CreateUiItem>d__2>(ref <CreateUiItem>d__);
		return <CreateUiItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600A1E8 RID: 41448 RVA: 0x002F91B0 File Offset: 0x002F73B0
	public override UniTask PlayHideAnim()
	{
		FloroRanchUiCardComponent.<PlayHideAnim>d__3 <PlayHideAnim>d__;
		<PlayHideAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayHideAnim>d__.<>4__this = this;
		<PlayHideAnim>d__.<>1__state = -1;
		<PlayHideAnim>d__.<>t__builder.Start<FloroRanchUiCardComponent.<PlayHideAnim>d__3>(ref <PlayHideAnim>d__);
		return <PlayHideAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600A1E9 RID: 41449 RVA: 0x002F91F4 File Offset: 0x002F73F4
	public override UniTask ShowUiItem()
	{
		FloroRanchUiCardComponent.<ShowUiItem>d__4 <ShowUiItem>d__;
		<ShowUiItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ShowUiItem>d__.<>4__this = this;
		<ShowUiItem>d__.<>1__state = -1;
		<ShowUiItem>d__.<>t__builder.Start<FloroRanchUiCardComponent.<ShowUiItem>d__4>(ref <ShowUiItem>d__);
		return <ShowUiItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600A1EA RID: 41450 RVA: 0x002F9238 File Offset: 0x002F7438
	public override UniTask HideUiItem()
	{
		FloroRanchUiCardComponent.<HideUiItem>d__5 <HideUiItem>d__;
		<HideUiItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<HideUiItem>d__.<>4__this = this;
		<HideUiItem>d__.<>1__state = -1;
		<HideUiItem>d__.<>t__builder.Start<FloroRanchUiCardComponent.<HideUiItem>d__5>(ref <HideUiItem>d__);
		return <HideUiItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600A1EB RID: 41451 RVA: 0x002F927C File Offset: 0x002F747C
	public override UniTask PlayNormalAnim()
	{
		FloroRanchUiCardComponent.<PlayNormalAnim>d__6 <PlayNormalAnim>d__;
		<PlayNormalAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayNormalAnim>d__.<>4__this = this;
		<PlayNormalAnim>d__.<>1__state = -1;
		<PlayNormalAnim>d__.<>t__builder.Start<FloroRanchUiCardComponent.<PlayNormalAnim>d__6>(ref <PlayNormalAnim>d__);
		return <PlayNormalAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600A1EC RID: 41452 RVA: 0x002F92BF File Offset: 0x002F74BF
	public override void Pause()
	{
		if (this.FloroRanchUiCardItem == null)
		{
			return;
		}
		this.FloroRanchUiCardItem.Pause();
	}

	// Token: 0x0600A1ED RID: 41453 RVA: 0x002F92D5 File Offset: 0x002F74D5
	public override void Resume()
	{
		if (this.FloroRanchUiCardItem == null)
		{
			return;
		}
		this.FloroRanchUiCardItem.Resume();
	}

	// Token: 0x0600A1EE RID: 41454 RVA: 0x002F92EB File Offset: 0x002F74EB
	protected override void OnExit()
	{
		if (this.FloroRanchUiCardItem != null)
		{
			this.FloroRanchUiCardItem.UnbindData();
			this.FloroRanchUiCardItem = null;
		}
	}

	// Token: 0x0600A1EF RID: 41455 RVA: 0x002F9308 File Offset: 0x002F7508
	[PreserveBaseOverrides]
	public new virtual FloroRanchUiCardItem GetUiItem()
	{
		if (this.FloroRanchUiCardItem == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanchGamePlay;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "FloroRanchUiCardComponent GetUiItem 实体不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entityId", this.OwnerEntity.EntityId);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return this.FloroRanchUiCardItem;
	}

	// Token: 0x0600A1F0 RID: 41456 RVA: 0x002F935C File Offset: 0x002F755C
	public override UniTask MoveToTarget(FloroRanchUiItemBase uiItemBase)
	{
		FloroRanchUiCardComponent.<MoveToTarget>d__11 <MoveToTarget>d__;
		<MoveToTarget>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<MoveToTarget>d__.<>4__this = this;
		<MoveToTarget>d__.uiItemBase = uiItemBase;
		<MoveToTarget>d__.<>1__state = -1;
		<MoveToTarget>d__.<>t__builder.Start<FloroRanchUiCardComponent.<MoveToTarget>d__11>(ref <MoveToTarget>d__);
		return <MoveToTarget>d__.<>t__builder.Task;
	}

	// Token: 0x0600A1F1 RID: 41457 RVA: 0x002F93A8 File Offset: 0x002F75A8
	public override UniTask MoveToOriginalPosition()
	{
		FloroRanchUiCardComponent.<MoveToOriginalPosition>d__12 <MoveToOriginalPosition>d__;
		<MoveToOriginalPosition>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<MoveToOriginalPosition>d__.<>4__this = this;
		<MoveToOriginalPosition>d__.<>1__state = -1;
		<MoveToOriginalPosition>d__.<>t__builder.Start<FloroRanchUiCardComponent.<MoveToOriginalPosition>d__12>(ref <MoveToOriginalPosition>d__);
		return <MoveToOriginalPosition>d__.<>t__builder.Task;
	}

	// Token: 0x0600A1F2 RID: 41458 RVA: 0x002F93EB File Offset: 0x002F75EB
	public void RefreshEvolveItem()
	{
		if (this.FloroRanchUiCardItem == null)
		{
			return;
		}
		this.FloroRanchUiCardItem.RefreshEvolveItem();
	}

	// Token: 0x0600A1F3 RID: 41459 RVA: 0x002F9401 File Offset: 0x002F7601
	public void RefreshRemainTimeItem()
	{
		if (this.FloroRanchUiCardItem == null)
		{
			return;
		}
		this.FloroRanchUiCardItem.RefreshRemainTimeItem();
	}

	// Token: 0x0600A1F4 RID: 41460 RVA: 0x002F9418 File Offset: 0x002F7618
	public override UniTask PlayEatAnim()
	{
		FloroRanchUiCardComponent.<PlayEatAnim>d__15 <PlayEatAnim>d__;
		<PlayEatAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayEatAnim>d__.<>4__this = this;
		<PlayEatAnim>d__.<>1__state = -1;
		<PlayEatAnim>d__.<>t__builder.Start<FloroRanchUiCardComponent.<PlayEatAnim>d__15>(ref <PlayEatAnim>d__);
		return <PlayEatAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600A1F5 RID: 41461 RVA: 0x002F945C File Offset: 0x002F765C
	public override UniTask PlayBeEatAnim()
	{
		FloroRanchUiCardComponent.<PlayBeEatAnim>d__16 <PlayBeEatAnim>d__;
		<PlayBeEatAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayBeEatAnim>d__.<>4__this = this;
		<PlayBeEatAnim>d__.<>1__state = -1;
		<PlayBeEatAnim>d__.<>t__builder.Start<FloroRanchUiCardComponent.<PlayBeEatAnim>d__16>(ref <PlayBeEatAnim>d__);
		return <PlayBeEatAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600A1F6 RID: 41462 RVA: 0x002F94A0 File Offset: 0x002F76A0
	public override UniTask PlaySacrificeAnim()
	{
		FloroRanchUiCardComponent.<PlaySacrificeAnim>d__17 <PlaySacrificeAnim>d__;
		<PlaySacrificeAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlaySacrificeAnim>d__.<>4__this = this;
		<PlaySacrificeAnim>d__.<>1__state = -1;
		<PlaySacrificeAnim>d__.<>t__builder.Start<FloroRanchUiCardComponent.<PlaySacrificeAnim>d__17>(ref <PlaySacrificeAnim>d__);
		return <PlaySacrificeAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600A1F7 RID: 41463 RVA: 0x002F94E4 File Offset: 0x002F76E4
	public override UniTask PlayFusionHideAnim()
	{
		FloroRanchUiCardComponent.<PlayFusionHideAnim>d__18 <PlayFusionHideAnim>d__;
		<PlayFusionHideAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayFusionHideAnim>d__.<>4__this = this;
		<PlayFusionHideAnim>d__.<>1__state = -1;
		<PlayFusionHideAnim>d__.<>t__builder.Start<FloroRanchUiCardComponent.<PlayFusionHideAnim>d__18>(ref <PlayFusionHideAnim>d__);
		return <PlayFusionHideAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600A1F8 RID: 41464 RVA: 0x002F9528 File Offset: 0x002F7728
	public override UniTask PlayFusionShowAnim()
	{
		FloroRanchUiCardComponent.<PlayFusionShowAnim>d__19 <PlayFusionShowAnim>d__;
		<PlayFusionShowAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayFusionShowAnim>d__.<>4__this = this;
		<PlayFusionShowAnim>d__.<>1__state = -1;
		<PlayFusionShowAnim>d__.<>t__builder.Start<FloroRanchUiCardComponent.<PlayFusionShowAnim>d__19>(ref <PlayFusionShowAnim>d__);
		return <PlayFusionShowAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600A1F9 RID: 41465 RVA: 0x002F956C File Offset: 0x002F776C
	public override UniTask PlayEvolveUpAnim()
	{
		FloroRanchUiCardComponent.<PlayEvolveUpAnim>d__20 <PlayEvolveUpAnim>d__;
		<PlayEvolveUpAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayEvolveUpAnim>d__.<>4__this = this;
		<PlayEvolveUpAnim>d__.<>1__state = -1;
		<PlayEvolveUpAnim>d__.<>t__builder.Start<FloroRanchUiCardComponent.<PlayEvolveUpAnim>d__20>(ref <PlayEvolveUpAnim>d__);
		return <PlayEvolveUpAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600A1FA RID: 41466 RVA: 0x002F95B0 File Offset: 0x002F77B0
	public override void PlayVideo()
	{
		if (this.FloroRanchUiCardItem == null)
		{
			return;
		}
		if (FloroRanchGamePlayModel.Instance.IsSkip)
		{
			return;
		}
		FloroRanchCardData cardData = this.OwnerEntity.CheckGetComponent<FloroRanchCardDataComponent>().CardData;
		AudioSystem.Instance.PostEvent(cardData.Video);
	}

	// Token: 0x04005F37 RID: 24375
	private FloroRanchUiCardItem FloroRanchUiCardItem;
}
