using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Blueprints;
using AkiClient.Game.Aki.Character.Input.Structures;
using CSharpScript.Game.Input;
using UnrealEngine;

// Token: 0x0200261B RID: 9755
[NullableContext(2)]
[Nullable(0)]
public class CharacterInputLayer : InputLayer
{
	// Token: 0x060185B5 RID: 99765 RVA: 0x00759790 File Offset: 0x00757990
	[NullableContext(1)]
	public void Init(EntityHandle entityHandle)
	{
		CharacterActorComponent component = entityHandle.Entity.GetComponent<CharacterActorComponent>();
		TsBaseCharacter role = component.Actor;
		this.ResetBpInputComp();
		if (this.BpInputComp != null)
		{
			return;
		}
		FSoftClassPath inputComponentClass2 = role.InputComponentClass;
		string text = ((inputComponentClass2 != null) ? inputComponentClass2.AssetPathName.ToString() : null) ?? "";
		if (text != "")
		{
			ResourceSystem.Instance.LoadAsync<UBlueprintGeneratedClass>(text, delegate([Nullable(2)] UBlueprintGeneratedClass inputComponentClass, string _)
			{
				this.BpInputComp = (role.AddComponentByClass(inputComponentClass, false, MathUtils.Instance.DefaultTransform, false, default(FName)) as BP_InputBase_C);
				this.BpInputComp.OwnerActor = role;
				this.BpInputCompOrigin = this.BpInputComp;
			}, 100, "js_undefined");
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Input;
		ELogAuthor author = ELogAuthor.WWJ;
		string message = "[CharacterInputLayer]加载BpInput失败";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Role", role);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x060185B6 RID: 99766 RVA: 0x0075985A File Offset: 0x00757A5A
	public override void Clear()
	{
		this.BpInputComp = null;
		this.BpInputCompOrigin = null;
	}

	// Token: 0x060185B7 RID: 99767 RVA: 0x0075986A File Offset: 0x00757A6A
	public override EInputLayer GetLayerType()
	{
		return EInputLayer.Character;
	}

	// Token: 0x060185B8 RID: 99768 RVA: 0x00759870 File Offset: 0x00757A70
	public override SInputCommand HandlePress(EInputAction action, float time)
	{
		if (this.BpInputComp == null)
		{
			return null;
		}
		SInputCommand result = null;
		switch (action)
		{
		case 1:
			result = this.BpInputComp.跳跃按下(time);
			break;
		case 2:
			result = this.BpInputComp.攀爬按下(time);
			break;
		case 3:
			result = this.BpInputComp.走跑切换按下(time);
			break;
		case 4:
			result = this.BpInputComp.攻击按下(time);
			break;
		case 5:
			result = this.BpInputComp.闪避按下(time);
			break;
		case 6:
			result = this.BpInputComp.技能1按下(time);
			break;
		case 7:
			result = this.BpInputComp.幻象1按下(time);
			break;
		case 8:
			result = this.BpInputComp.大招按下(time);
			break;
		case 9:
			result = this.BpInputComp.幻象2按下(time);
			break;
		case 10:
			result = this.BpInputComp.切换角色1按下(time);
			break;
		case 11:
			result = this.BpInputComp.切换角色2按下(time);
			break;
		case 12:
			result = this.BpInputComp.切换角色3按下(time);
			break;
		case 14:
			result = this.BpInputComp.瞄准按下(time);
			break;
		case 15:
			result = this.BpInputComp.通用交互按下(time);
			break;
		case 16:
			result = this.BpInputComp.下降按下(time);
			break;
		}
		return result;
	}

	// Token: 0x060185B9 RID: 99769 RVA: 0x007599D0 File Offset: 0x00757BD0
	public override SInputCommand HandleRelease(EInputAction action, float time)
	{
		if (this.BpInputComp == null)
		{
			return null;
		}
		SInputCommand result = null;
		switch (action)
		{
		case 1:
			result = this.BpInputComp.跳跃抬起(time);
			break;
		case 2:
			result = this.BpInputComp.攀爬抬起(time);
			break;
		case 3:
			result = this.BpInputComp.走跑切换抬起(time);
			break;
		case 4:
			result = this.BpInputComp.攻击抬起(time);
			break;
		case 5:
			result = this.BpInputComp.闪避抬起(time);
			break;
		case 6:
			result = this.BpInputComp.技能1抬起(time);
			break;
		case 7:
			result = this.BpInputComp.幻象1抬起(time);
			break;
		case 8:
			result = this.BpInputComp.大招抬起(time);
			break;
		case 9:
			result = this.BpInputComp.幻象2抬起(time);
			break;
		case 10:
			result = this.BpInputComp.切换角色1抬起(time);
			break;
		case 11:
			result = this.BpInputComp.切换角色2抬起(time);
			break;
		case 12:
			result = this.BpInputComp.切换角色3抬起(time);
			break;
		case 14:
			result = this.BpInputComp.瞄准抬起(time);
			break;
		case 16:
			result = this.BpInputComp.下降抬起(time);
			break;
		}
		return result;
	}

	// Token: 0x060185BA RID: 99770 RVA: 0x00759B20 File Offset: 0x00757D20
	public override SInputCommand HandleHold(EInputAction action, float time)
	{
		if (this.BpInputComp == null)
		{
			return null;
		}
		switch (action)
		{
		case 1:
			return this.BpInputComp.跳跃长按(time);
		case 2:
			return this.BpInputComp.攀爬长按(time);
		case 3:
			return this.BpInputComp.走跑切换长按(time);
		case 4:
			return this.BpInputComp.攻击长按(time);
		case 5:
			return this.BpInputComp.闪避长按(time);
		case 6:
			return this.BpInputComp.技能1长按(time);
		case 7:
			return this.BpInputComp.幻象1长按(time);
		case 8:
			return this.BpInputComp.大招长按(time);
		case 9:
			return this.BpInputComp.幻象2长按(time);
		case 10:
			return this.BpInputComp.切换角色1长按(time);
		case 11:
			return this.BpInputComp.切换角色2长按(time);
		case 12:
			return this.BpInputComp.切换角色3长按(time);
		case 13:
			return this.BpInputComp.锁定目标长按(time);
		case 14:
			return this.BpInputComp.瞄准长按(time);
		case 16:
			return this.BpInputComp.下降长按(time);
		}
		return null;
	}

	// Token: 0x060185BB RID: 99771 RVA: 0x00759C50 File Offset: 0x00757E50
	public override bool DispatchPressEvent(EInputAction action, float time)
	{
		if (this.BpInputComp == null)
		{
			return false;
		}
		switch (action)
		{
		case 1:
			this.BpInputComp.跳跃按下事件(time);
			break;
		case 2:
			this.BpInputComp.攀爬按下事件(time);
			break;
		case 3:
			this.BpInputComp.走跑切换按下事件(time);
			break;
		case 4:
			this.BpInputComp.攻击按下事件(time);
			break;
		case 5:
			this.BpInputComp.闪避按下事件(time);
			break;
		case 6:
			this.BpInputComp.技能1按下事件(time);
			break;
		case 7:
			this.BpInputComp.幻象1按下事件(time);
			break;
		case 8:
			this.BpInputComp.大招按下事件(time);
			break;
		case 9:
			this.BpInputComp.幻象2按下事件(time);
			break;
		case 10:
			this.BpInputComp.切换角色1按下事件(time);
			break;
		case 11:
			this.BpInputComp.切换角色2按下事件(time);
			break;
		case 12:
			this.BpInputComp.切换角色3按下事件(time);
			break;
		case 13:
			this.BpInputComp.锁定目标按下事件(time);
			break;
		case 14:
			this.BpInputComp.瞄准按下事件(time);
			break;
		case 16:
			this.BpInputComp.下降按下事件(time);
			break;
		}
		return true;
	}

	// Token: 0x060185BC RID: 99772 RVA: 0x00759D9C File Offset: 0x00757F9C
	public override bool DispatchReleaseEvent(EInputAction action, float time)
	{
		if (this.BpInputComp == null)
		{
			return false;
		}
		switch (action)
		{
		case 1:
			this.BpInputComp.跳跃抬起事件(time);
			break;
		case 2:
			this.BpInputComp.攀爬抬起事件(time);
			break;
		case 3:
			this.BpInputComp.走跑切换抬起事件(time);
			break;
		case 4:
			this.BpInputComp.攻击抬起事件(time);
			break;
		case 5:
			this.BpInputComp.闪避抬起事件(time);
			break;
		case 6:
			this.BpInputComp.技能1抬起事件(time);
			break;
		case 7:
			this.BpInputComp.幻象1抬起事件(time);
			break;
		case 8:
			this.BpInputComp.大招抬起事件(time);
			break;
		case 9:
			this.BpInputComp.幻象2抬起事件(time);
			break;
		case 10:
			this.BpInputComp.切换角色1抬起事件(time);
			break;
		case 11:
			this.BpInputComp.切换角色2抬起事件(time);
			break;
		case 12:
			this.BpInputComp.切换角色3抬起事件(time);
			break;
		case 13:
			this.BpInputComp.锁定目标抬起事件(time);
			break;
		case 14:
			this.BpInputComp.瞄准抬起事件(time);
			break;
		case 16:
			this.BpInputComp.下降抬起事件(time);
			break;
		}
		return true;
	}

	// Token: 0x060185BD RID: 99773 RVA: 0x00759EE7 File Offset: 0x007580E7
	public override SInputCommand HandlePressEx(EInputAction action, float time, float moveInputYaw = 0f)
	{
		if (this.BpInputComp == null)
		{
			return null;
		}
		if (action == EInputAction.移动输入按键事件)
		{
			return this.BpInputComp.移动输入按下(time, moveInputYaw);
		}
		return this.HandlePress(action, time);
	}

	// Token: 0x060185BE RID: 99774 RVA: 0x00759F16 File Offset: 0x00758116
	public override SInputCommand HandleReleaseEx(EInputAction action, float time, float moveInputYaw = 0f)
	{
		if (this.BpInputComp == null)
		{
			return null;
		}
		if (action == EInputAction.移动输入按键事件)
		{
			return this.BpInputComp.移动输入抬起(time, moveInputYaw);
		}
		return this.HandleRelease(action, time);
	}

	// Token: 0x060185BF RID: 99775 RVA: 0x00759F45 File Offset: 0x00758145
	public override SInputCommand HandleHoldEx(EInputAction action, float time, float moveInputYaw = 0f)
	{
		if (this.BpInputComp == null)
		{
			return null;
		}
		if (action == EInputAction.移动输入按键事件)
		{
			return this.BpInputComp.移动输入长按(time, moveInputYaw);
		}
		return this.HandleHold(action, time);
	}

	// Token: 0x060185C0 RID: 99776 RVA: 0x00759F74 File Offset: 0x00758174
	public override bool DispatchPressEventEx(EInputAction action, float time, float moveInputYaw = 0f)
	{
		if (this.BpInputComp == null)
		{
			return false;
		}
		if (action == EInputAction.移动输入按键事件)
		{
			this.BpInputComp.移动输入按下事件(time, moveInputYaw);
			return true;
		}
		return this.DispatchPressEvent(action, time);
	}

	// Token: 0x060185C1 RID: 99777 RVA: 0x00759FA4 File Offset: 0x007581A4
	public override bool DispatchReleaseEventEx(EInputAction action, float time, float moveInputYaw = 0f)
	{
		if (this.BpInputComp == null)
		{
			return false;
		}
		if (action == EInputAction.移动输入按键事件)
		{
			this.BpInputComp.移动输入抬起事件(time, moveInputYaw);
			return true;
		}
		return this.DispatchReleaseEvent(action, time);
	}

	// Token: 0x060185C2 RID: 99778 RVA: 0x00759FD4 File Offset: 0x007581D4
	public override BP_InputBase_C GetBpInputComp()
	{
		return this.BpInputComp;
	}

	// Token: 0x060185C3 RID: 99779 RVA: 0x00759FDC File Offset: 0x007581DC
	public void SetBpInputComp(BP_InputBase_C bpInputComp)
	{
		this.BpInputComp = bpInputComp;
	}

	// Token: 0x060185C4 RID: 99780 RVA: 0x00759FE5 File Offset: 0x007581E5
	public void ResetBpInputComp()
	{
		this.BpInputComp = this.BpInputCompOrigin;
	}

	// Token: 0x060185C5 RID: 99781 RVA: 0x00759FF3 File Offset: 0x007581F3
	public override bool IsCheckHoldConfigTime(EInputAction action)
	{
		return false;
	}

	// Token: 0x0400D250 RID: 53840
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Stat HandlePressStat = Stat.Create("CharacterInputLayer.HandlePress", "", "");

	// Token: 0x0400D251 RID: 53841
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Stat HandleReleaseStat = Stat.Create("CharacterInputLayer.HandleRelease", "", "");

	// Token: 0x0400D252 RID: 53842
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Stat HandlePressExStat = Stat.Create("CharacterInputLayer.HandlePressEx", "", "");

	// Token: 0x0400D253 RID: 53843
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Stat HandleReleaseExStat = Stat.Create("CharacterInputLayer.HandleReleaseEx", "", "");

	// Token: 0x0400D254 RID: 53844
	private BP_InputBase_C BpInputComp;

	// Token: 0x0400D255 RID: 53845
	private BP_InputBase_C BpInputCompOrigin;
}
