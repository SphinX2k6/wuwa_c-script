using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020026B8 RID: 9912
[NullableContext(1)]
[Nullable(0)]
public class QuestTreeDetailImageItem : UiPanelBase
{
	// Token: 0x0601451D RID: 83229 RVA: 0x00523CD5 File Offset: 0x00521ED5
	public QuestTreeDetailImageItem(QuestTreeNodeData data)
	{
	}

	// Token: 0x0601451E RID: 83230 RVA: 0x00523CE4 File Offset: 0x00521EE4
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

	// Token: 0x0601451F RID: 83231 RVA: 0x00523E10 File Offset: 0x00522010
	protected override UniTask OnBeforeStartAsync()
	{
		QuestTreeDetailImageItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<QuestTreeDetailImageItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014520 RID: 83232 RVA: 0x00523E53 File Offset: 0x00522053
	protected override void OnStart()
	{
		this.RefreshBtnState();
	}

	// Token: 0x06014521 RID: 83233 RVA: 0x00523E5B File Offset: 0x0052205B
	public void RefreshInfo(QuestTreeNodeData data)
	{
		this.RefreshInfoAsync(data);
	}

	// Token: 0x06014522 RID: 83234 RVA: 0x00523E68 File Offset: 0x00522068
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

	// Token: 0x06014523 RID: 83235 RVA: 0x00523EB4 File Offset: 0x005220B4
	private void RefreshBtnState()
	{
		base.GetItem(2).SetUIActive(this.Data.State == EQuestTreeNodeState.Locked);
		base.GetItem(4).SetUIActive(this.Data.State == EQuestTreeNodeState.InProgress);
		base.GetItem(5).SetUIActive(this.Data.State >= EQuestTreeNodeState.Finished);
	}

	// Token: 0x06014524 RID: 83236 RVA: 0x00523F14 File Offset: 0x00522114
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

	// Token: 0x06014525 RID: 83237 RVA: 0x00523F80 File Offset: 0x00522180
	private void OnClickImage()
	{
		if (this.Data.State < EQuestTreeNodeState.Finished)
		{
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.QuestTreeNodeImageView, this.Data, null);
	}

	// Token: 0x040098CD RID: 39117
	private float OriginalWidth;

	// Token: 0x040098CE RID: 39118
	private float OriginalHeight;

	// Token: 0x040098CF RID: 39119
	private QuestTreeNodeData Data = data;

	// Token: 0x02008D0E RID: 36110
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402DC80 RID: 187520
		public const int ItemSelf = 0;

		// Token: 0x0402DC81 RID: 187521
		public const int TextureImage = 1;

		// Token: 0x0402DC82 RID: 187522
		public const int ItemLock = 2;

		// Token: 0x0402DC83 RID: 187523
		public const int BtnImage = 3;

		// Token: 0x0402DC84 RID: 187524
		public const int ItemInProgress = 4;

		// Token: 0x0402DC85 RID: 187525
		public const int ItemIcon = 5;
	}
}
