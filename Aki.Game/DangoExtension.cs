using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001083 RID: 4227
[NullableContext(1)]
[Nullable(0)]
public class DangoExtension : ISlotExtension
{
	// Token: 0x0600A80D RID: 43021 RVA: 0x00317840 File Offset: 0x00315A40
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

	// Token: 0x0600A80E RID: 43022 RVA: 0x00317893 File Offset: 0x00315A93
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

	// Token: 0x0600A80F RID: 43023 RVA: 0x003178D0 File Offset: 0x00315AD0
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

	// Token: 0x0600A810 RID: 43024 RVA: 0x00317983 File Offset: 0x00315B83
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

	// Token: 0x0600A811 RID: 43025 RVA: 0x003179B0 File Offset: 0x00315BB0
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

	// Token: 0x040061BB RID: 25019
	[Nullable(2)]
	private ISlotMountPoint Mount;

	// Token: 0x040061BC RID: 25020
	private int Position;

	// Token: 0x040061BD RID: 25021
	[Nullable(2)]
	private DangoExtensionPanel DangoComponent;

	// Token: 0x040061BE RID: 25022
	[Nullable(2)]
	private DangoLikeItem LikeItem;

	// Token: 0x040061BF RID: 25023
	private int CurrentConfigId;

	// Token: 0x040061C0 RID: 25024
	private int? CurrentSlotPlayerId;
}
