using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001BA3 RID: 7075
[NullableContext(1)]
[Nullable(0)]
public class QuestTreeDetailImageItem : UiPanelBase
{
	// Token: 0x060119FF RID: 72191 RVA: 0x00532A0D File Offset: 0x00530C0D
	public QuestTreeDetailImageItem(QuestTreeNodeData data)
	{
	}

	// Token: 0x06011A00 RID: 72192 RVA: 0x00532A1C File Offset: 0x00530C1C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickImage));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06011A01 RID: 72193 RVA: 0x00532B48 File Offset: 0x00530D48
	protected override UniTask OnBeforeStartAsync()
	{
		QuestTreeDetailImageItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<QuestTreeDetailImageItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011A02 RID: 72194 RVA: 0x00532B8B File Offset: 0x00530D8B
	protected override void OnStart()
	{
		this.RefreshBtnState();
	}

	// Token: 0x06011A03 RID: 72195 RVA: 0x00532B93 File Offset: 0x00530D93
	public void RefreshInfo(QuestTreeNodeData data)
	{
		this.RefreshInfoAsync(data);
	}

	// Token: 0x06011A04 RID: 72196 RVA: 0x00532BA0 File Offset: 0x00530DA0
	public UniTask RefreshInfoAsync(QuestTreeNodeData data)
	{
		QuestTreeDetailImageItem.<RefreshInfoAsync>d__9 <RefreshInfoAsync>d__;
		<RefreshInfoAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshInfoAsync>d__.<>4__this = this;
		<RefreshInfoAsync>d__.data = data;
		<RefreshInfoAsync>d__.<>1__state = -1;
		<RefreshInfoAsync>d__.<>t__builder.Start<QuestTreeDetailImageItem.<RefreshInfoAsync>d__9>(ref <RefreshInfoAsync>d__);
		return <RefreshInfoAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011A05 RID: 72197 RVA: 0x00532BEC File Offset: 0x00530DEC
	private void RefreshBtnState()
	{
		base.GetItem(2).SetUIActive(this.Data.State == EQuestTreeNodeState.Locked);
		base.GetItem(4).SetUIActive(this.Data.State == EQuestTreeNodeState.InProgress);
		base.GetItem(5).SetUIActive(this.Data.State >= EQuestTreeNodeState.Finished);
	}

	// Token: 0x06011A06 RID: 72198 RVA: 0x00532C4C File Offset: 0x00530E4C
	private void FixTextureSize()
	{
		UUITexture texture = base.GetTexture(1);
		UTexture2D utexture2D = texture.GetTexture() as UTexture2D;
		if (utexture2D != null)
		{
			float originalWidth = this.OriginalWidth;
			float originalHeight = this.OriginalHeight;
			int num = utexture2D.Blueprint_GetSizeX();
			int num2 = utexture2D.Blueprint_GetSizeY();
			float val = originalWidth / (float)num;
			float val2 = originalHeight / (float)num2;
			float num3 = Math.Max(val, val2);
			texture.SetWidth((float)num * num3);
			texture.SetHeight((float)num2 * num3);
		}
	}

	// Token: 0x06011A07 RID: 72199 RVA: 0x00532CB8 File Offset: 0x00530EB8
	private void OnClickImage()
	{
		if (this.Data.State < EQuestTreeNodeState.Finished)
		{
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.QuestTreeNodeImageView, this.Data, null);
	}

	// Token: 0x04009A25 RID: 39461
	private float OriginalWidth;

	// Token: 0x04009A26 RID: 39462
	private float OriginalHeight;

	// Token: 0x04009A27 RID: 39463
	private QuestTreeNodeData Data = data;

	// Token: 0x02007E97 RID: 32407
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04028F97 RID: 167831
		public const int ItemSelf = 0;

		// Token: 0x04028F98 RID: 167832
		public const int TextureImage = 1;

		// Token: 0x04028F99 RID: 167833
		public const int ItemLock = 2;

		// Token: 0x04028F9A RID: 167834
		public const int BtnImage = 3;

		// Token: 0x04028F9B RID: 167835
		public const int ItemInProgress = 4;

		// Token: 0x04028F9C RID: 167836
		public const int ItemIcon = 5;
	}
}
