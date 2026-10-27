using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Blueprints;
using AkiClient.Game.Aki.Character.Input.Structures;
using CSharpScript.Game.Input;
using UnrealEngine;

// Token: 0x020030C3 RID: 12483
[NullableContext(2)]
[Nullable(0)]
public class CharacterInputLayer : InputLayer
{
	// Token: 0x0601ABA6 RID: 109478 RVA: 0x00733E28 File Offset: 0x00732028
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

	// Token: 0x0601ABA7 RID: 109479 RVA: 0x00733EF2 File Offset: 0x007320F2
	public override void Clear()
	{
		this.BpInputComp = null;
		this.BpInputCompOrigin = null;
	}

	// Token: 0x0601ABA8 RID: 109480 RVA: 0x00733F02 File Offset: 0x00732102
	public override EInputLayer GetLayerType()
	{
		return EInputLayer.Character;
	}

	// Token: 0x0601ABA9 RID: 109481 RVA: 0x00733F08 File Offset: 0x00732108
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

	// Token: 0x0601ABAA RID: 109482 RVA: 0x00734068 File Offset: 0x00732268
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

	// Token: 0x0601ABAB RID: 109483 RVA: 0x007341B8 File Offset: 0x007323B8
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

	// Token: 0x0601ABAC RID: 109484 RVA: 0x007342E8 File Offset: 0x007324E8
	public override void DispatchPressEvent(EInputAction action, float time)
	{
		if (this.BpInputComp == null)
		{
			return;
		}
		switch (action)
		{
		case 1:
			this.BpInputComp.跳跃按下事件(time);
			return;
		case 2:
			this.BpInputComp.攀爬按下事件(time);
			return;
		case 3:
			this.BpInputComp.走跑切换按下事件(time);
			return;
		case 4:
			this.BpInputComp.攻击按下事件(time);
			return;
		case 5:
			this.BpInputComp.闪避按下事件(time);
			return;
		case 6:
			this.BpInputComp.技能1按下事件(time);
			return;
		case 7:
			this.BpInputComp.幻象1按下事件(time);
			return;
		case 8:
			this.BpInputComp.大招按下事件(time);
			return;
		case 9:
			this.BpInputComp.幻象2按下事件(time);
			return;
		case 10:
			this.BpInputComp.切换角色1按下事件(time);
			return;
		case 11:
			this.BpInputComp.切换角色2按下事件(time);
			return;
		case 12:
			this.BpInputComp.切换角色3按下事件(time);
			return;
		case 13:
			this.BpInputComp.锁定目标按下事件(time);
			return;
		case 14:
			this.BpInputComp.瞄准按下事件(time);
			return;
		case 15:
			break;
		case 16:
			this.BpInputComp.下降按下事件(time);
			break;
		default:
			return;
		}
	}

	// Token: 0x0601ABAD RID: 109485 RVA: 0x00734410 File Offset: 0x00732610
	public override void DispatchReleaseEvent(EInputAction action, float time)
	{
		if (this.BpInputComp == null)
		{
			return;
		}
		switch (action)
		{
		case 1:
			this.BpInputComp.跳跃抬起事件(time);
			return;
		case 2:
			this.BpInputComp.攀爬抬起事件(time);
			return;
		case 3:
			this.BpInputComp.走跑切换抬起事件(time);
			return;
		case 4:
			this.BpInputComp.攻击抬起事件(time);
			return;
		case 5:
			this.BpInputComp.闪避抬起事件(time);
			return;
		case 6:
			this.BpInputComp.技能1抬起事件(time);
			return;
		case 7:
			this.BpInputComp.幻象1抬起事件(time);
			return;
		case 8:
			this.BpInputComp.大招抬起事件(time);
			return;
		case 9:
			this.BpInputComp.幻象2抬起事件(time);
			return;
		case 10:
			this.BpInputComp.切换角色1抬起事件(time);
			return;
		case 11:
			this.BpInputComp.切换角色2抬起事件(time);
			return;
		case 12:
			this.BpInputComp.切换角色3抬起事件(time);
			return;
		case 13:
			this.BpInputComp.锁定目标抬起事件(time);
			return;
		case 14:
			this.BpInputComp.瞄准抬起事件(time);
			return;
		case 15:
			break;
		case 16:
			this.BpInputComp.下降抬起事件(time);
			break;
		default:
			return;
		}
	}

	// Token: 0x0601ABAE RID: 109486 RVA: 0x00734538 File Offset: 0x00732738
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

	// Token: 0x0601ABAF RID: 109487 RVA: 0x00734567 File Offset: 0x00732767
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

	// Token: 0x0601ABB0 RID: 109488 RVA: 0x00734596 File Offset: 0x00732796
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

	// Token: 0x0601ABB1 RID: 109489 RVA: 0x007345C5 File Offset: 0x007327C5
	public override void DispatchPressEventEx(EInputAction action, float time, float moveInputYaw = 0f)
	{
		if (this.BpInputComp == null)
		{
			return;
		}
		if (action == EInputAction.移动输入按键事件)
		{
			this.BpInputComp.移动输入按下事件(time, moveInputYaw);
			return;
		}
		this.DispatchPressEvent(action, time);
	}

	// Token: 0x0601ABB2 RID: 109490 RVA: 0x007345F3 File Offset: 0x007327F3
	public override void DispatchReleaseEventEx(EInputAction action, float time, float moveInputYaw = 0f)
	{
		if (this.BpInputComp == null)
		{
			return;
		}
		if (action == EInputAction.移动输入按键事件)
		{
			this.BpInputComp.移动输入抬起事件(time, moveInputYaw);
			return;
		}
		this.DispatchReleaseEvent(action, time);
	}

	// Token: 0x0601ABB3 RID: 109491 RVA: 0x00734621 File Offset: 0x00732821
	public override BP_InputBase_C GetBpInputComp()
	{
		return this.BpInputComp;
	}

	// Token: 0x0601ABB4 RID: 109492 RVA: 0x00734629 File Offset: 0x00732829
	public void SetBpInputComp(BP_InputBase_C bpInputComp)
	{
		this.BpInputComp = bpInputComp;
	}

	// Token: 0x0601ABB5 RID: 109493 RVA: 0x00734632 File Offset: 0x00732832
	public void ResetBpInputComp()
	{
		this.BpInputComp = this.BpInputCompOrigin;
	}

	// Token: 0x0400CE64 RID: 52836
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Stat HandlePressStat = Stat.Create("CharacterInputLayer.HandlePress", "", "");

	// Token: 0x0400CE65 RID: 52837
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Stat HandleReleaseStat = Stat.Create("CharacterInputLayer.HandleRelease", "", "");

	// Token: 0x0400CE66 RID: 52838
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Stat HandlePressExStat = Stat.Create("CharacterInputLayer.HandlePressEx", "", "");

	// Token: 0x0400CE67 RID: 52839
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Stat HandleReleaseExStat = Stat.Create("CharacterInputLayer.HandleReleaseEx", "", "");

	// Token: 0x0400CE68 RID: 52840
	private BP_InputBase_C BpInputComp;

	// Token: 0x0400CE69 RID: 52841
	private BP_InputBase_C BpInputCompOrigin;
}
