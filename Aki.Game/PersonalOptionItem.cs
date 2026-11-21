using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020018BC RID: 6332
public class PersonalOptionItem : GridProxyAbstract<int>
{
	// Token: 0x0600FA24 RID: 64036 RVA: 0x00491D8A File Offset: 0x0048FF8A
	[NullableContext(1)]
	public PersonalOptionItem(UUIItem item)
	{
		if (item != null)
		{
			this.CreateThenShowByActor(item.GetOwner());
		}
	}

	// Token: 0x0600FA25 RID: 64037 RVA: 0x00491DA4 File Offset: 0x0048FFA4
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

	// Token: 0x0600FA26 RID: 64038 RVA: 0x00491E8C File Offset: 0x0049008C
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

	// Token: 0x0600FA27 RID: 64039 RVA: 0x00491F8E File Offset: 0x0049018E
	private void OnClickItem()
	{
		this.ClickFunction = PersonalOptionController.Instance.GetOptionFunc((EPersonalOptionDefine)this.OptionId);
		this.ClickFunction();
	}

	// Token: 0x0600FA28 RID: 64040 RVA: 0x00491FB4 File Offset: 0x004901B4
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

	// Token: 0x04008BF6 RID: 35830
	private int OptionId;

	// Token: 0x04008BF7 RID: 35831
	[Nullable(2)]
	private Action ClickFunction;

	// Token: 0x02007B01 RID: 31489
	private class EPersonalOptionItemDefine
	{
		// Token: 0x04027DDD RID: 163293
		public const int Button = 0;

		// Token: 0x04027DDE RID: 163294
		public const int Description = 1;

		// Token: 0x04027DDF RID: 163295
		public const int Icon = 2;

		// Token: 0x04027DE0 RID: 163296
		public const int RedDot = 3;
	}
}
