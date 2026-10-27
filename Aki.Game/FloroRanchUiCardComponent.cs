using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001B1B RID: 6939
[NullableContext(1)]
[Nullable(0)]
[FloroRanchEntityComponent(EFloroRanchEntityComponent.FloroRanchUiCardComponent)]
public class FloroRanchUiCardComponent : FloroRanchUiItemBaseComponent
{
	// Token: 0x0600CDD5 RID: 52693 RVA: 0x002EE048 File Offset: 0x002EC248
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

	// Token: 0x0600CDD6 RID: 52694 RVA: 0x002EE08C File Offset: 0x002EC28C
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

	// Token: 0x0600CDD7 RID: 52695 RVA: 0x002EE0D0 File Offset: 0x002EC2D0
	public override UniTask PlayHideAnim()
	{
		FloroRanchUiCardComponent.<PlayHideAnim>d__3 <PlayHideAnim>d__;
		<PlayHideAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayHideAnim>d__.<>4__this = this;
		<PlayHideAnim>d__.<>1__state = -1;
		<PlayHideAnim>d__.<>t__builder.Start<FloroRanchUiCardComponent.<PlayHideAnim>d__3>(ref <PlayHideAnim>d__);
		return <PlayHideAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600CDD8 RID: 52696 RVA: 0x002EE114 File Offset: 0x002EC314
	public override UniTask ShowUiItem()
	{
		FloroRanchUiCardComponent.<ShowUiItem>d__4 <ShowUiItem>d__;
		<ShowUiItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ShowUiItem>d__.<>4__this = this;
		<ShowUiItem>d__.<>1__state = -1;
		<ShowUiItem>d__.<>t__builder.Start<FloroRanchUiCardComponent.<ShowUiItem>d__4>(ref <ShowUiItem>d__);
		return <ShowUiItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600CDD9 RID: 52697 RVA: 0x002EE158 File Offset: 0x002EC358
	public override UniTask HideUiItem()
	{
		FloroRanchUiCardComponent.<HideUiItem>d__5 <HideUiItem>d__;
		<HideUiItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<HideUiItem>d__.<>4__this = this;
		<HideUiItem>d__.<>1__state = -1;
		<HideUiItem>d__.<>t__builder.Start<FloroRanchUiCardComponent.<HideUiItem>d__5>(ref <HideUiItem>d__);
		return <HideUiItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600CDDA RID: 52698 RVA: 0x002EE19C File Offset: 0x002EC39C
	public override UniTask PlayNormalAnim()
	{
		FloroRanchUiCardComponent.<PlayNormalAnim>d__6 <PlayNormalAnim>d__;
		<PlayNormalAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayNormalAnim>d__.<>4__this = this;
		<PlayNormalAnim>d__.<>1__state = -1;
		<PlayNormalAnim>d__.<>t__builder.Start<FloroRanchUiCardComponent.<PlayNormalAnim>d__6>(ref <PlayNormalAnim>d__);
		return <PlayNormalAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600CDDB RID: 52699 RVA: 0x002EE1DF File Offset: 0x002EC3DF
	public override void Pause()
	{
		if (this.FloroRanchUiCardItem == null)
		{
			return;
		}
		this.FloroRanchUiCardItem.Pause();
	}

	// Token: 0x0600CDDC RID: 52700 RVA: 0x002EE1F5 File Offset: 0x002EC3F5
	public override void Resume()
	{
		if (this.FloroRanchUiCardItem == null)
		{
			return;
		}
		this.FloroRanchUiCardItem.Resume();
	}

	// Token: 0x0600CDDD RID: 52701 RVA: 0x002EE20B File Offset: 0x002EC40B
	protected override void OnExit()
	{
		if (this.FloroRanchUiCardItem != null)
		{
			this.FloroRanchUiCardItem.UnbindData();
			this.FloroRanchUiCardItem = null;
		}
	}

	// Token: 0x0600CDDE RID: 52702 RVA: 0x002EE228 File Offset: 0x002EC428
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

	// Token: 0x0600CDDF RID: 52703 RVA: 0x002EE27C File Offset: 0x002EC47C
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

	// Token: 0x0600CDE0 RID: 52704 RVA: 0x002EE2C8 File Offset: 0x002EC4C8
	public override UniTask MoveToOriginalPosition()
	{
		FloroRanchUiCardComponent.<MoveToOriginalPosition>d__12 <MoveToOriginalPosition>d__;
		<MoveToOriginalPosition>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<MoveToOriginalPosition>d__.<>4__this = this;
		<MoveToOriginalPosition>d__.<>1__state = -1;
		<MoveToOriginalPosition>d__.<>t__builder.Start<FloroRanchUiCardComponent.<MoveToOriginalPosition>d__12>(ref <MoveToOriginalPosition>d__);
		return <MoveToOriginalPosition>d__.<>t__builder.Task;
	}

	// Token: 0x0600CDE1 RID: 52705 RVA: 0x002EE30B File Offset: 0x002EC50B
	public void RefreshEvolveItem()
	{
		if (this.FloroRanchUiCardItem == null)
		{
			return;
		}
		this.FloroRanchUiCardItem.RefreshEvolveItem();
	}

	// Token: 0x0600CDE2 RID: 52706 RVA: 0x002EE321 File Offset: 0x002EC521
	public void RefreshRemainTimeItem()
	{
		if (this.FloroRanchUiCardItem == null)
		{
			return;
		}
		this.FloroRanchUiCardItem.RefreshRemainTimeItem();
	}

	// Token: 0x0600CDE3 RID: 52707 RVA: 0x002EE338 File Offset: 0x002EC538
	public override UniTask PlayEatAnim()
	{
		FloroRanchUiCardComponent.<PlayEatAnim>d__15 <PlayEatAnim>d__;
		<PlayEatAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayEatAnim>d__.<>4__this = this;
		<PlayEatAnim>d__.<>1__state = -1;
		<PlayEatAnim>d__.<>t__builder.Start<FloroRanchUiCardComponent.<PlayEatAnim>d__15>(ref <PlayEatAnim>d__);
		return <PlayEatAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600CDE4 RID: 52708 RVA: 0x002EE37C File Offset: 0x002EC57C
	public override UniTask PlayBeEatAnim()
	{
		FloroRanchUiCardComponent.<PlayBeEatAnim>d__16 <PlayBeEatAnim>d__;
		<PlayBeEatAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayBeEatAnim>d__.<>4__this = this;
		<PlayBeEatAnim>d__.<>1__state = -1;
		<PlayBeEatAnim>d__.<>t__builder.Start<FloroRanchUiCardComponent.<PlayBeEatAnim>d__16>(ref <PlayBeEatAnim>d__);
		return <PlayBeEatAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600CDE5 RID: 52709 RVA: 0x002EE3C0 File Offset: 0x002EC5C0
	public override UniTask PlaySacrificeAnim()
	{
		FloroRanchUiCardComponent.<PlaySacrificeAnim>d__17 <PlaySacrificeAnim>d__;
		<PlaySacrificeAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlaySacrificeAnim>d__.<>4__this = this;
		<PlaySacrificeAnim>d__.<>1__state = -1;
		<PlaySacrificeAnim>d__.<>t__builder.Start<FloroRanchUiCardComponent.<PlaySacrificeAnim>d__17>(ref <PlaySacrificeAnim>d__);
		return <PlaySacrificeAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600CDE6 RID: 52710 RVA: 0x002EE404 File Offset: 0x002EC604
	public override UniTask PlayFusionHideAnim()
	{
		FloroRanchUiCardComponent.<PlayFusionHideAnim>d__18 <PlayFusionHideAnim>d__;
		<PlayFusionHideAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayFusionHideAnim>d__.<>4__this = this;
		<PlayFusionHideAnim>d__.<>1__state = -1;
		<PlayFusionHideAnim>d__.<>t__builder.Start<FloroRanchUiCardComponent.<PlayFusionHideAnim>d__18>(ref <PlayFusionHideAnim>d__);
		return <PlayFusionHideAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600CDE7 RID: 52711 RVA: 0x002EE448 File Offset: 0x002EC648
	public override UniTask PlayFusionShowAnim()
	{
		FloroRanchUiCardComponent.<PlayFusionShowAnim>d__19 <PlayFusionShowAnim>d__;
		<PlayFusionShowAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayFusionShowAnim>d__.<>4__this = this;
		<PlayFusionShowAnim>d__.<>1__state = -1;
		<PlayFusionShowAnim>d__.<>t__builder.Start<FloroRanchUiCardComponent.<PlayFusionShowAnim>d__19>(ref <PlayFusionShowAnim>d__);
		return <PlayFusionShowAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600CDE8 RID: 52712 RVA: 0x002EE48C File Offset: 0x002EC68C
	public override UniTask PlayEvolveUpAnim()
	{
		FloroRanchUiCardComponent.<PlayEvolveUpAnim>d__20 <PlayEvolveUpAnim>d__;
		<PlayEvolveUpAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayEvolveUpAnim>d__.<>4__this = this;
		<PlayEvolveUpAnim>d__.<>1__state = -1;
		<PlayEvolveUpAnim>d__.<>t__builder.Start<FloroRanchUiCardComponent.<PlayEvolveUpAnim>d__20>(ref <PlayEvolveUpAnim>d__);
		return <PlayEvolveUpAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600CDE9 RID: 52713 RVA: 0x002EE4D0 File Offset: 0x002EC6D0
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

	// Token: 0x04005E68 RID: 24168
	private FloroRanchUiCardItem FloroRanchUiCardItem;
}
