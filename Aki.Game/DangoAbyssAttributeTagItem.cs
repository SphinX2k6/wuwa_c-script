using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A29 RID: 6697
[NullableContext(1)]
[Nullable(0)]
public class DangoAbyssAttributeTagItem : UiPanelBase
{
	// Token: 0x0600C501 RID: 50433 RVA: 0x002CAF58 File Offset: 0x002C9158
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x0600C502 RID: 50434 RVA: 0x002CAFB2 File Offset: 0x002C91B2
	public void Initialize(UUIItem uiItem)
	{
		base.CreateByActorAsync(uiItem.GetOwner(), null, false).Forget();
	}

	// Token: 0x0600C503 RID: 50435 RVA: 0x002CAFC7 File Offset: 0x002C91C7
	protected override void OnStart()
	{
		this.Sequence = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x0600C504 RID: 50436 RVA: 0x002CAFDC File Offset: 0x002C91DC
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

	// Token: 0x0600C505 RID: 50437 RVA: 0x002CB090 File Offset: 0x002C9290
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

	// Token: 0x04005ACD RID: 23245
	[Nullable(2)]
	public LevelSequencePlayer Sequence;

	// Token: 0x02007F6F RID: 32623
	[NullableContext(0)]
	private enum ETagItemComponent
	{
		// Token: 0x040299A0 RID: 170400
		SpriteBg,
		// Token: 0x040299A1 RID: 170401
		TextName,
		// Token: 0x040299A2 RID: 170402
		TextValue
	}
}
