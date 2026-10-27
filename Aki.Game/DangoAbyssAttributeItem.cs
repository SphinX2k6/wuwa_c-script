using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A28 RID: 6696
[NullableContext(1)]
[Nullable(0)]
public class DangoAbyssAttributeItem : UiPanelBase
{
	// Token: 0x0600C4FB RID: 50427 RVA: 0x002CADD0 File Offset: 0x002C8FD0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x0600C4FC RID: 50428 RVA: 0x002CAE2A File Offset: 0x002C902A
	public void Initialize(UUIItem uiItem)
	{
		base.CreateByActorAsync(uiItem.GetOwner(), null, false).Forget();
	}

	// Token: 0x0600C4FD RID: 50429 RVA: 0x002CAE3F File Offset: 0x002C903F
	protected override void OnStart()
	{
		this.Sequence = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x0600C4FE RID: 50430 RVA: 0x002CAE54 File Offset: 0x002C9054
	public void Refresh(DangoAbyssDefine.EquipViewAttributeData data)
	{
		AttrListScrollData attribute = data.Attribute;
		PropertyIndex value = PropertyIndexConfig.Instance.GetPropertyIndexInfo(attribute.Id).Value;
		base.GetText(1).ShowTextNew(value.Name);
		base.SetTextureShowUntilLoaded(value.Icon, base.GetTexture(0), null);
		double propRatioValue = TipsDataTool.GetPropRatioValue(attribute.AddValue, attribute.IsRatio);
		string formatAttributeValueString = AttributeModel.Instance.GetFormatAttributeValueString(attribute.Id, propRatioValue, attribute.IsRatio);
		base.GetText(2).SetText(formatAttributeValueString, true);
		base.SetUiActive(true);
		if (data.IsChange)
		{
			this.PlaySequence("Change").Forget();
		}
	}

	// Token: 0x0600C4FF RID: 50431 RVA: 0x002CAF04 File Offset: 0x002C9104
	public UniTask PlaySequence(string name)
	{
		DangoAbyssAttributeItem.<PlaySequence>d__6 <PlaySequence>d__;
		<PlaySequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlaySequence>d__.<>4__this = this;
		<PlaySequence>d__.name = name;
		<PlaySequence>d__.<>1__state = -1;
		<PlaySequence>d__.<>t__builder.Start<DangoAbyssAttributeItem.<PlaySequence>d__6>(ref <PlaySequence>d__);
		return <PlaySequence>d__.<>t__builder.Task;
	}

	// Token: 0x04005ACC RID: 23244
	[Nullable(2)]
	public LevelSequencePlayer Sequence;

	// Token: 0x02007F6D RID: 32621
	[NullableContext(0)]
	private enum EAttributeItemComponent
	{
		// Token: 0x04029997 RID: 170391
		AttributeIcon,
		// Token: 0x04029998 RID: 170392
		AttributeName,
		// Token: 0x04029999 RID: 170393
		AttributeValue
	}
}
