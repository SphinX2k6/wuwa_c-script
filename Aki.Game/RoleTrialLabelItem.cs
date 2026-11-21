using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E71 RID: 7793
public class RoleTrialLabelItem : UiPanelBase
{
	// Token: 0x06013470 RID: 78960 RVA: 0x005A2518 File Offset: 0x005A0718
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x06013471 RID: 78961 RVA: 0x005A2574 File Offset: 0x005A0774
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

	// Token: 0x0400A4F3 RID: 42227
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

	// Token: 0x02008149 RID: 33097
	private enum EComponentType
	{
		// Token: 0x04029CE2 RID: 171234
		FrameImg,
		// Token: 0x04029CE3 RID: 171235
		IconImg,
		// Token: 0x04029CE4 RID: 171236
		TrialTxt
	}
}
