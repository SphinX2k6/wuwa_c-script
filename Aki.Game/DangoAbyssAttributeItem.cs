using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000EE7 RID: 3815
[NullableContext(1)]
[Nullable(0)]
public class DangoAbyssAttributeItem : UiPanelBase
{
	// Token: 0x0600990B RID: 39179 RVA: 0x002D5EF0 File Offset: 0x002D40F0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x0600990C RID: 39180 RVA: 0x002D5F4A File Offset: 0x002D414A
	public void Initialize(UUIItem uiItem)
	{
		base.CreateByActorAsync(uiItem.GetOwner(), null, false).Forget();
	}

	// Token: 0x0600990D RID: 39181 RVA: 0x002D5F5F File Offset: 0x002D415F
	protected override void OnStart()
	{
		this.Sequence = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x0600990E RID: 39182 RVA: 0x002D5F74 File Offset: 0x002D4174
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

	// Token: 0x0600990F RID: 39183 RVA: 0x002D6024 File Offset: 0x002D4224
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

	// Token: 0x04005B9B RID: 23451
	[Nullable(2)]
	public LevelSequencePlayer Sequence;

	// Token: 0x020070FC RID: 28924
	[NullableContext(0)]
	private enum EAttributeItemComponent
	{
		// Token: 0x04024CD4 RID: 150740
		AttributeIcon,
		// Token: 0x04024CD5 RID: 150741
		AttributeName,
		// Token: 0x04024CD6 RID: 150742
		AttributeValue
	}
}
