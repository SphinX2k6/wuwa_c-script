using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001AA2 RID: 6818
public class FightPhotoFrameItem : GridProxyAbstract<FightPhotoFrameStyle>
{
	// Token: 0x06010E13 RID: 69139 RVA: 0x004F3784 File Offset: 0x004F1984
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUISprite))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle))
		};
	}

	// Token: 0x06010E14 RID: 69140 RVA: 0x004F3818 File Offset: 0x004F1A18
	public override void Refresh(FightPhotoFrameStyle data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		base.SetTextureByPath(data.Picture, base.GetTexture(1), null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), data.Name, Array.Empty<object>());
		ICameraConditionRecommend cameraConditionRecommend = FightPhotoModel.Instance.GetCameraConditionRecommend();
		UUISprite sprite = base.GetSprite(3);
		if (sprite == null)
		{
			return;
		}
		sprite.SetUIActive(cameraConditionRecommend.FrameIds.Contains(data.Id));
	}

	// Token: 0x06010E15 RID: 69141 RVA: 0x004F3895 File Offset: 0x004F1A95
	public override void OnSelected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x06010E16 RID: 69142 RVA: 0x004F38AC File Offset: 0x004F1AAC
	public override void OnDeselected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06010E17 RID: 69143 RVA: 0x004F38C3 File Offset: 0x004F1AC3
	[NullableContext(1)]
	public override object GetKey(FightPhotoFrameStyle data, int displayIndex)
	{
		return data.Id;
	}

	// Token: 0x06010E18 RID: 69144 RVA: 0x004F38D1 File Offset: 0x004F1AD1
	private void OnClickToggle(EToggleState state)
	{
		this.OnToggleClick(this.Data);
	}

	// Token: 0x04009516 RID: 38166
	private FightPhotoFrameStyle Data;

	// Token: 0x04009517 RID: 38167
	[Nullable(1)]
	public Action<FightPhotoFrameStyle> OnToggleClick = delegate(FightPhotoFrameStyle data)
	{
	};

	// Token: 0x02007D46 RID: 32070
	private enum EFrameItemComponents
	{
		// Token: 0x040288CE RID: 166094
		TogRoot,
		// Token: 0x040288CF RID: 166095
		TexPreview,
		// Token: 0x040288D0 RID: 166096
		TextName,
		// Token: 0x040288D1 RID: 166097
		SpriteRecommend
	}
}
