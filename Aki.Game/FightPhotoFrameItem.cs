using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020025B7 RID: 9655
public class FightPhotoFrameItem : GridProxyAbstract<FightPhotoFrameStyle>
{
	// Token: 0x06013933 RID: 80179 RVA: 0x004E4B84 File Offset: 0x004E2D84
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

	// Token: 0x06013934 RID: 80180 RVA: 0x004E4C18 File Offset: 0x004E2E18
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

	// Token: 0x06013935 RID: 80181 RVA: 0x004E4C95 File Offset: 0x004E2E95
	public override void OnSelected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x06013936 RID: 80182 RVA: 0x004E4CAC File Offset: 0x004E2EAC
	public override void OnDeselected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06013937 RID: 80183 RVA: 0x004E4CC3 File Offset: 0x004E2EC3
	[NullableContext(1)]
	public override object GetKey(FightPhotoFrameStyle data, int displayIndex)
	{
		return data.Id;
	}

	// Token: 0x06013938 RID: 80184 RVA: 0x004E4CD1 File Offset: 0x004E2ED1
	private void OnClickToggle(EToggleState state)
	{
		this.OnToggleClick(this.Data);
	}

	// Token: 0x040093C0 RID: 37824
	private FightPhotoFrameStyle Data;

	// Token: 0x040093C1 RID: 37825
	[Nullable(1)]
	public Action<FightPhotoFrameStyle> OnToggleClick = delegate(FightPhotoFrameStyle data)
	{
	};

	// Token: 0x02008BBE RID: 35774
	private enum EFrameItemComponents
	{
		// Token: 0x0402D5B9 RID: 185785
		TogRoot,
		// Token: 0x0402D5BA RID: 185786
		TexPreview,
		// Token: 0x0402D5BB RID: 185787
		TextName,
		// Token: 0x0402D5BC RID: 185788
		SpriteRecommend
	}
}
