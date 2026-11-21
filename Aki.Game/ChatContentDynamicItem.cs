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

// Token: 0x02000C5A RID: 3162
[NullableContext(1)]
[Nullable(0)]
public class ChatContentDynamicItem : UiPanelBase, IDynamicScrollBaseItem<IChatContentDynamicData>
{
	// Token: 0x0600842F RID: 33839 RVA: 0x002876F8 File Offset: 0x002858F8
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

	// Token: 0x06008430 RID: 33840 RVA: 0x00287744 File Offset: 0x00285944
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

	// Token: 0x06008431 RID: 33841 RVA: 0x00287874 File Offset: 0x00285A74
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

	// Token: 0x06008432 RID: 33842 RVA: 0x002879CA File Offset: 0x00285BCA
	public void ClearItem()
	{
	}

	// Token: 0x040050C1 RID: 20673
	private const int SPACING = 60;

	// Token: 0x040050C2 RID: 20674
	private const int NOTIME_SPACING = 40;
}
