using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001BC4 RID: 7108
[NullableContext(1)]
[Nullable(0)]
public class DangoExtension : ISlotExtension
{
	// Token: 0x0600D3FB RID: 54267 RVA: 0x0030C6CC File Offset: 0x0030A8CC
	public UniTask OnAttach(ISlotMountPoint mount, int position)
	{
		DangoExtension.<OnAttach>d__6 <OnAttach>d__;
		<OnAttach>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnAttach>d__.<>4__this = this;
		<OnAttach>d__.mount = mount;
		<OnAttach>d__.position = position;
		<OnAttach>d__.<>1__state = -1;
		<OnAttach>d__.<>t__builder.Start<DangoExtension.<OnAttach>d__6>(ref <OnAttach>d__);
		return <OnAttach>d__.<>t__builder.Task;
	}

	// Token: 0x0600D3FC RID: 54268 RVA: 0x0030C71F File Offset: 0x0030A91F
	public void OnDetach()
	{
		if (this.DangoComponent == null)
		{
			return;
		}
		EventSystem.Instance.Remove(EEventName.RefreshFormationDango, new Action<IReadOnlyDictionary<int, int[]>>(this.OnSelectDango));
		this.DangoComponent = null;
		this.LikeItem = null;
		this.Mount = null;
	}

	// Token: 0x0600D3FD RID: 54269 RVA: 0x0030C75C File Offset: 0x0030A95C
	public void OnRefresh(IRoleSlotDisplayData data)
	{
		if (this.DangoComponent == null || this.Mount == null)
		{
			return;
		}
		this.CurrentConfigId = data.ConfigId;
		this.CurrentSlotPlayerId = ((data.PlayerId > 0) ? new int?(data.PlayerId) : null);
		int playerId = this.Mount.GetProvider().ResolveSafePlayerId(this.CurrentSlotPlayerId);
		this.DangoComponent.Refresh(this.Position, data.ConfigId, playerId);
		if (this.Mount.GetProvider().IsDangoInMatch())
		{
			DangoLikeItem likeItem = this.LikeItem;
			if (likeItem != null)
			{
				likeItem.SetActive(true);
			}
			DangoLikeItem likeItem2 = this.LikeItem;
			if (likeItem2 == null)
			{
				return;
			}
			likeItem2.Refresh(playerId);
		}
	}

	// Token: 0x0600D3FE RID: 54270 RVA: 0x0030C80F File Offset: 0x0030AA0F
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public UUIItem[] QueryGuideItem(string[] configParams)
	{
		if (this.DangoComponent == null)
		{
			return null;
		}
		if (configParams.Length == 0 || !configParams[0].Contains("FirstDangoSlot"))
		{
			return null;
		}
		return this.DangoComponent.GetGuideUiItemAndUiItemForShowEx(configParams);
	}

	// Token: 0x0600D3FF RID: 54271 RVA: 0x0030C83C File Offset: 0x0030AA3C
	private void OnSelectDango(IReadOnlyDictionary<int, int[]> data)
	{
		if (this.Mount == null || this.DangoComponent == null)
		{
			return;
		}
		int num = this.Mount.GetProvider().ResolveSafePlayerId(this.CurrentSlotPlayerId);
		int[] array;
		if (!data.TryGetValue(num, out array))
		{
			return;
		}
		if (Array.IndexOf<int>(array, this.CurrentConfigId) == -1)
		{
			return;
		}
		this.DangoComponent.Refresh(this.Position, this.CurrentConfigId, num);
		if (this.Mount.GetProvider().IsDangoInMatch())
		{
			DangoLikeItem likeItem = this.LikeItem;
			if (likeItem != null)
			{
				likeItem.SetActive(true);
			}
			DangoLikeItem likeItem2 = this.LikeItem;
			if (likeItem2 == null)
			{
				return;
			}
			likeItem2.Refresh(num);
		}
	}

	// Token: 0x040060EC RID: 24812
	[Nullable(2)]
	private ISlotMountPoint Mount;

	// Token: 0x040060ED RID: 24813
	private int Position;

	// Token: 0x040060EE RID: 24814
	[Nullable(2)]
	private DangoExtensionPanel DangoComponent;

	// Token: 0x040060EF RID: 24815
	[Nullable(2)]
	private DangoLikeItem LikeItem;

	// Token: 0x040060F0 RID: 24816
	private int CurrentConfigId;

	// Token: 0x040060F1 RID: 24817
	private int? CurrentSlotPlayerId;
}
