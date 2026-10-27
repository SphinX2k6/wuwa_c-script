using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020028F6 RID: 10486
public class RoleTrialLabelItem : UiPanelBase
{
	// Token: 0x06015A6C RID: 88684 RVA: 0x0057764C File Offset: 0x0057584C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x06015A6D RID: 88685 RVA: 0x005776A8 File Offset: 0x005758A8
	public void Refresh(int roleId)
	{
		if (!RoleUtils.IsTrialRole(roleId))
		{
			return;
		}
		ETrialRoleType trialRoleType = RoleUtils.GetTrialRoleType(roleId);
		if (trialRoleType == ETrialRoleType.None)
		{
			return;
		}
		string text;
		FColor color = FColor.FromHex(this.trialRoleHexColor.TryGetValue((int)trialRoleType, out text) ? text : this.trialRoleHexColor[1]);
		UUISprite sprite = base.GetSprite(0);
		if (sprite != null)
		{
			sprite.SetColor(color);
		}
		UUIText text2 = base.GetText(2);
		if (text2 != null)
		{
			text2.SetColor(color);
		}
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(RoleUtils.GetTrialRoleLabelIconByType(trialRoleType));
		this.SetSpriteByPath(resourcePath, base.GetSprite(1), false, null, null);
	}

	// Token: 0x0400A108 RID: 41224
	[Nullable(1)]
	private readonly Dictionary<int, string> trialRoleHexColor = new Dictionary<int, string>
	{
		{
			1,
			"ffffff"
		},
		{
			2,
			"fffca0"
		},
		{
			3,
			"bcf3ff"
		}
	};

	// Token: 0x02008F01 RID: 36609
	private enum EComponentType
	{
		// Token: 0x0402E5E7 RID: 189927
		FrameImg,
		// Token: 0x0402E5E8 RID: 189928
		IconImg,
		// Token: 0x0402E5E9 RID: 189929
		TrialTxt
	}
}
