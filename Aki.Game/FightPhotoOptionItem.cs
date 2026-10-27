using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020025BA RID: 9658
public class FightPhotoOptionItem : GridProxyAbstract<FightPhotoOption>
{
	// Token: 0x06013947 RID: 80199 RVA: 0x004E4FBC File Offset: 0x004E31BC
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

	// Token: 0x06013948 RID: 80200 RVA: 0x004E5050 File Offset: 0x004E3250
	public override void Refresh(FightPhotoOption data, bool isSelected, int gridIndex)
	{
		this.Data = new FightPhotoOption?(data);
		base.SetTextureByPath(data.Picture, base.GetTexture(1), null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), data.Name, Array.Empty<object>());
		ICameraConditionRecommend cameraConditionRecommend = FightPhotoModel.Instance.GetCameraConditionRecommend();
		UUISprite sprite = base.GetSprite(3);
		if (sprite == null)
		{
			return;
		}
		sprite.SetUIActive(cameraConditionRecommend.FilterIds.Contains(data.Id));
	}

	// Token: 0x06013949 RID: 80201 RVA: 0x004E50D2 File Offset: 0x004E32D2
	public override void OnSelected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x0601394A RID: 80202 RVA: 0x004E50E9 File Offset: 0x004E32E9
	public override void OnDeselected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0601394B RID: 80203 RVA: 0x004E5100 File Offset: 0x004E3300
	[NullableContext(1)]
	public override object GetKey(FightPhotoOption data, int displayIndex)
	{
		return data.Id;
	}

	// Token: 0x0601394C RID: 80204 RVA: 0x004E510E File Offset: 0x004E330E
	private void OnClickToggle(EToggleState state)
	{
		this.OnToggleClick(this.Data.Value);
	}

	// Token: 0x040093C5 RID: 37829
	private FightPhotoOption? Data;

	// Token: 0x040093C6 RID: 37830
	[Nullable(1)]
	public Action<FightPhotoOption> OnToggleClick = delegate(FightPhotoOption data)
	{
	};

	// Token: 0x02008BC5 RID: 35781
	private enum EComponents
	{
		// Token: 0x0402D5D5 RID: 185813
		ToggleRoot,
		// Token: 0x0402D5D6 RID: 185814
		TextureBg,
		// Token: 0x0402D5D7 RID: 185815
		TextName,
		// Token: 0x0402D5D8 RID: 185816
		SpriteRecommend
	}
}
