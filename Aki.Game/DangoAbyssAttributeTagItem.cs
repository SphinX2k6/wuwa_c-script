using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000EE8 RID: 3816
[NullableContext(1)]
[Nullable(0)]
public class DangoAbyssAttributeTagItem : UiPanelBase
{
	// Token: 0x06009911 RID: 39185 RVA: 0x002D6078 File Offset: 0x002D4278
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x06009912 RID: 39186 RVA: 0x002D60D2 File Offset: 0x002D42D2
	public void Initialize(UUIItem uiItem)
	{
		base.CreateByActorAsync(uiItem.GetOwner(), null, false).Forget();
	}

	// Token: 0x06009913 RID: 39187 RVA: 0x002D60E7 File Offset: 0x002D42E7
	protected override void OnStart()
	{
		this.Sequence = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x06009914 RID: 39188 RVA: 0x002D60FC File Offset: 0x002D42FC
	public void Refresh(DangoAbyssDefine.EquipViewAttributeData data)
	{
		DangoAbyssDefine.DangoAbyssTagData tag = data.Tag;
		AbyssPluginPropDesc value = DangoAbyssConfig.Instance.GetDangoPluginPropDescById(tag.TagId).Value;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), value.Name, Array.Empty<object>());
		FColor color = FColor.FromHex(value.BgColor);
		base.GetSprite(0).SetColor(color);
		string formatAttributeValueByTagId = DangoAbyssModel.Instance.GetFormatAttributeValueByTagId(tag.Value, tag.TagId, null);
		base.GetText(2).SetText(formatAttributeValueByTagId, true);
		base.SetUiActive(true);
		if (data.IsChange)
		{
			this.PlaySequence("Change").Forget();
		}
	}

	// Token: 0x06009915 RID: 39189 RVA: 0x002D61B0 File Offset: 0x002D43B0
	public UniTask PlaySequence(string name)
	{
		DangoAbyssAttributeTagItem.<PlaySequence>d__6 <PlaySequence>d__;
		<PlaySequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlaySequence>d__.<>4__this = this;
		<PlaySequence>d__.name = name;
		<PlaySequence>d__.<>1__state = -1;
		<PlaySequence>d__.<>t__builder.Start<DangoAbyssAttributeTagItem.<PlaySequence>d__6>(ref <PlaySequence>d__);
		return <PlaySequence>d__.<>t__builder.Task;
	}

	// Token: 0x04005B9C RID: 23452
	[Nullable(2)]
	public LevelSequencePlayer Sequence;

	// Token: 0x020070FE RID: 28926
	[NullableContext(0)]
	private enum ETagItemComponent
	{
		// Token: 0x04024CDD RID: 150749
		SpriteBg,
		// Token: 0x04024CDE RID: 150750
		TextName,
		// Token: 0x04024CDF RID: 150751
		TextValue
	}
}
