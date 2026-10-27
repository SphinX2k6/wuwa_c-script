using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020023D7 RID: 9175
public class PersonalOptionItem : GridProxyAbstract<int>
{
	// Token: 0x06012572 RID: 75122 RVA: 0x0048487E File Offset: 0x00482A7E
	[NullableContext(1)]
	public PersonalOptionItem(UUIItem item)
	{
		if (item != null)
		{
			this.CreateThenShowByActor(item.GetOwner());
		}
	}

	// Token: 0x06012573 RID: 75123 RVA: 0x00484898 File Offset: 0x00482A98
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISpriteTransition));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickItem));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06012574 RID: 75124 RVA: 0x00484980 File Offset: 0x00482B80
	public override void Refresh(int optionId, bool isSelected, int gridIndex)
	{
		this.OptionId = optionId;
		PersonalTips? config = ConfigPersonalTipsById.GetConfig(this.OptionId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Role;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "个性化弹窗配置找不到,id为";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("config!.Id", config.Value.Id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		base.GetText(1).ShowTextNew(config.Value.Description);
		UUISpriteTransition transition = base.GetUiSpriteTransition(2);
		ResourceSystem.Instance.LoadAsync<ULGUISpriteData_BaseObject>(config.Value.IconPath, delegate([Nullable(2)] ULGUISpriteData_BaseObject sprite, string path)
		{
			if (sprite.IsValid() && transition.IsValid())
			{
				transition.SetAllTransitionSprite(sprite);
			}
		}, 100, "js_undefined");
		if (config.Value.RedDotName != "")
		{
			RedDotController.Instance.BindRedDot(Enum.Parse<ERedDotName>(config.Value.RedDotName), base.GetItem(3), null, 0);
		}
	}

	// Token: 0x06012575 RID: 75125 RVA: 0x00484A82 File Offset: 0x00482C82
	private void OnClickItem()
	{
		this.ClickFunction = PersonalOptionController.Instance.GetOptionFunc((EPersonalOptionDefine)this.OptionId);
		this.ClickFunction();
	}

	// Token: 0x06012576 RID: 75126 RVA: 0x00484AA8 File Offset: 0x00482CA8
	protected override void OnBeforeDestroy()
	{
		PersonalTips? config = ConfigPersonalTipsById.GetConfig(this.OptionId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Role;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "个性化弹窗配置找不到,id为";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("config!.Id", config.Value.Id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		if (config.Value.RedDotName != "")
		{
			RedDotController.Instance.UnBindGivenUi(Enum.Parse<ERedDotName>(config.Value.RedDotName), base.GetItem(3), 0);
		}
	}

	// Token: 0x04008AAF RID: 35503
	private int OptionId;

	// Token: 0x04008AB0 RID: 35504
	[Nullable(2)]
	private Action ClickFunction;

	// Token: 0x02008978 RID: 35192
	private class EPersonalOptionItemDefine
	{
		// Token: 0x0402CAC2 RID: 182978
		public const int Button = 0;

		// Token: 0x0402CAC3 RID: 182979
		public const int Description = 1;

		// Token: 0x0402CAC4 RID: 182980
		public const int Icon = 2;

		// Token: 0x0402CAC5 RID: 182981
		public const int RedDot = 3;
	}
}
