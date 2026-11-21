using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001AA5 RID: 6821
public class FightPhotoOptionItem : GridProxyAbstract<FightPhotoOption>
{
	// Token: 0x06010E27 RID: 69159 RVA: 0x004F3BBC File Offset: 0x004F1DBC
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

	// Token: 0x06010E28 RID: 69160 RVA: 0x004F3C50 File Offset: 0x004F1E50
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

	// Token: 0x06010E29 RID: 69161 RVA: 0x004F3CD2 File Offset: 0x004F1ED2
	public override void OnSelected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x06010E2A RID: 69162 RVA: 0x004F3CE9 File Offset: 0x004F1EE9
	public override void OnDeselected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06010E2B RID: 69163 RVA: 0x004F3D00 File Offset: 0x004F1F00
	[NullableContext(1)]
	public override object GetKey(FightPhotoOption data, int displayIndex)
	{
		return data.Id;
	}

	// Token: 0x06010E2C RID: 69164 RVA: 0x004F3D0E File Offset: 0x004F1F0E
	private void OnClickToggle(EToggleState state)
	{
		this.OnToggleClick(this.Data.Value);
	}

	// Token: 0x0400951B RID: 38171
	private FightPhotoOption? Data;

	// Token: 0x0400951C RID: 38172
	[Nullable(1)]
	public Action<FightPhotoOption> OnToggleClick = delegate(FightPhotoOption data)
	{
	};

	// Token: 0x02007D4D RID: 32077
	private enum EComponents
	{
		// Token: 0x040288EA RID: 166122
		ToggleRoot,
		// Token: 0x040288EB RID: 166123
		TextureBg,
		// Token: 0x040288EC RID: 166124
		TextName,
		// Token: 0x040288ED RID: 166125
		SpriteRecommend
	}
}
