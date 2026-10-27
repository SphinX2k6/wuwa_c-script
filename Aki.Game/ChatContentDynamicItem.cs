using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020017A1 RID: 6049
[NullableContext(1)]
[Nullable(0)]
public class ChatContentDynamicItem : UiPanelBase, IDynamicScrollBaseItem<IChatContentDynamicData>
{
	// Token: 0x0600B047 RID: 45127 RVA: 0x0027D160 File Offset: 0x0027B360
	public UniTask Init(UUIItem actor)
	{
		ChatContentDynamicItem.<Init>d__3 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.actor = actor;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<ChatContentDynamicItem.<Init>d__3>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x0600B048 RID: 45128 RVA: 0x0027D1AC File Offset: 0x0027B3AC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600B049 RID: 45129 RVA: 0x0027D2DC File Offset: 0x0027B4DC
	public FVector2D GetItemSize(IChatContentDynamicData data)
	{
		EChatContentType type = data.Type;
		if (type > EChatContentType.Right)
		{
			if (type != EChatContentType.Tips)
			{
				return new FVector2D(0f, 0f);
			}
			UUIItem item = base.GetItem(0);
			return new FVector2D(item.GetWidth(), item.GetHeight());
		}
		else
		{
			float height = base.GetItem(6).GetHeight();
			double timeStamp = data.ChatContentData.TimeStamp;
			double lastTimeStamp = data.ChatContentData.LastTimeStamp;
			float num;
			if (timeStamp - lastTimeStamp < (double)ChatModel.Instance.ShowTimeDifferent && lastTimeStamp != 0.0)
			{
				num = 0f;
			}
			else
			{
				num = base.GetItem(5).GetHeight();
			}
			if (data.ChatContentData.ContentType == ChatContentType.Emoji)
			{
				float height2 = base.GetItem(4).GetHeight();
				return new FVector2D(base.GetItem(1).GetWidth(), height + ((num > 0f) ? (num + 60f) : 40f) + height2);
			}
			UUIText text = base.GetText(7);
			text.SetText(data.ChatContentData.Content, true);
			float y = text.GetTextRenderSize().Y;
			float height3 = base.GetItem(3).GetHeight();
			return new FVector2D(base.GetItem(1).GetWidth(), height + ((num > 0f) ? (num + 60f) : 40f) + y + height3);
		}
	}

	// Token: 0x0600B04A RID: 45130 RVA: 0x0027D432 File Offset: 0x0027B632
	public void ClearItem()
	{
	}

	// Token: 0x04005017 RID: 20503
	private const int SPACING = 60;

	// Token: 0x04005018 RID: 20504
	private const int NOTIME_SPACING = 40;
}
