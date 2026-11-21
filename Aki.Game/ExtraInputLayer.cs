using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Blueprints;
using AkiClient.Game.Aki.Character.Input.Enum;
using AkiClient.Game.Aki.Character.Input.Structures;
using AkiClient.Game.Aki.Core.Fight;
using AkiClient.Game.Aki.Data.Fight.Struct;
using CSharpScript.Game.Input;
using UnrealEngine;

// Token: 0x0200261C RID: 9756
[NullableContext(1)]
[Nullable(0)]
public class ExtraInputLayer : InputLayer
{
	// Token: 0x060185C8 RID: 99784 RVA: 0x0075A074 File Offset: 0x00758274
	[return: Nullable(2)]
	public static string GetBpInputClassPath(EntityHandle entityHandle)
	{
		RolePreloadComponent component = entityHandle.Entity.GetComponent<RolePreloadComponent>();
		IReadOnlyList<ECharacterLoadType> readOnlyList = (component != null) ? component.GetCharacterLoadTypeList() : null;
		TMap<TEnumAsByte<ECharacterLoadType>, FSoftClassPath> tmap;
		if (component == null)
		{
			tmap = null;
		}
		else
		{
			SCharacterFightInfo fightInfo = component.GetFightInfo();
			tmap = ((fightInfo != null) ? fightInfo.BpInputMap : null);
		}
		TMap<TEnumAsByte<ECharacterLoadType>, FSoftClassPath> tmap2 = tmap;
		if (readOnlyList != null && tmap2 != null)
		{
			foreach (ECharacterLoadType value in readOnlyList)
			{
				FSoftClassPath fsoftClassPath;
				if (tmap2.TryGetValue(value, out fsoftClassPath))
				{
					string text = fsoftClassPath.AssetPathName.ToString();
					if (!string.IsNullOrEmpty(text) && text != "None")
					{
						return text;
					}
				}
			}
		}
		return null;
	}

	// Token: 0x060185C9 RID: 99785 RVA: 0x0075A138 File Offset: 0x00758338
	public void Init(EntityHandle entityHandle, string classPath)
	{
		WorldEntity entity = entityHandle.Entity;
		if (string.IsNullOrEmpty(classPath))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Input;
			ELogAuthor author = ELogAuthor.WWJ;
			string message = "[ExtraInputLayer]加载BpInput失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", entity.Id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		CharacterActorComponent component = entity.GetComponent<CharacterActorComponent>();
		TsBaseCharacter role = component.Actor;
		ResourceSystem.Instance.LoadAsync<UClass>(classPath, delegate([Nullable(2)] UClass inputComponentClass, string _)
		{
			this.BpInputComp = (role.AddComponentByClass(inputComponentClass, false, MathUtils.Instance.DefaultTransform, false, default(FName)) as BP_InputBase_C);
			if (this.BpInputComp != null)
			{
				this.BpInputComp.OwnerActor = role;
			}
		}, 100, "js_undefined");
		CharacterMorphComponent component2 = entity.GetComponent<CharacterMorphComponent>();
		if (component2 != null && component2.IsMorphing())
		{
			this.IsEnable = false;
			return;
		}
		this.IsEnable = true;
	}

	// Token: 0x060185CA RID: 99786 RVA: 0x0075A1EA File Offset: 0x007583EA
	public override void Clear()
	{
		this.BpInputComp = null;
		Dictionary<EInputFuncType, Dictionary<EInputState, Dictionary<CSharpScript.Game.Input.EInputAction, bool>>> hasOverrideCache = this.HasOverrideCache;
		if (hasOverrideCache == null)
		{
			return;
		}
		hasOverrideCache.Clear();
	}

	// Token: 0x060185CB RID: 99787 RVA: 0x0075A203 File Offset: 0x00758403
	public override EInputLayer GetLayerType()
	{
		return EInputLayer.Extra;
	}

	// Token: 0x060185CC RID: 99788 RVA: 0x0075A208 File Offset: 0x00758408
	[NullableContext(2)]
	public override SInputCommand HandlePress(CSharpScript.Game.Input.EInputAction action, float time)
	{
		if (this.BpInputComp == null || !this.IsEnable)
		{
			return null;
		}
		SInputCommand sinputCommand = null;
		switch (action)
		{
		case 1:
			sinputCommand = this.BpInputComp.跳跃按下(time);
			break;
		case 2:
			sinputCommand = this.BpInputComp.攀爬按下(time);
			break;
		case 3:
			sinputCommand = this.BpInputComp.走跑切换按下(time);
			break;
		case 4:
			sinputCommand = this.BpInputComp.攻击按下(time);
			break;
		case 5:
			sinputCommand = this.BpInputComp.闪避按下(time);
			break;
		case 6:
			sinputCommand = this.BpInputComp.技能1按下(time);
			break;
		case 7:
			sinputCommand = this.BpInputComp.幻象1按下(time);
			break;
		case 8:
			sinputCommand = this.BpInputComp.大招按下(time);
			break;
		case 9:
			sinputCommand = this.BpInputComp.幻象2按下(time);
			break;
		case 10:
			sinputCommand = this.BpInputComp.切换角色1按下(time);
			break;
		case 11:
			sinputCommand = this.BpInputComp.切换角色2按下(time);
			break;
		case 12:
			sinputCommand = this.BpInputComp.切换角色3按下(time);
			break;
		case 14:
			sinputCommand = this.BpInputComp.瞄准按下(time);
			break;
		case 15:
			sinputCommand = this.BpInputComp.通用交互按下(time);
			break;
		}
		if ((sinputCommand == null || sinputCommand.CommandType == ECommandType.None) && this.IsBpInputCompSwallowCommand(action, EInputState.Press, EInputFuncType.HandleAction))
		{
			return InputLayer.GetSwallowCommand();
		}
		return sinputCommand;
	}

	// Token: 0x060185CD RID: 99789 RVA: 0x0075A388 File Offset: 0x00758588
	[NullableContext(2)]
	public override SInputCommand HandleRelease(CSharpScript.Game.Input.EInputAction action, float time)
	{
		if (this.BpInputComp == null || !this.IsEnable)
		{
			return null;
		}
		SInputCommand sinputCommand = null;
		switch (action)
		{
		case 1:
			sinputCommand = this.BpInputComp.跳跃抬起(time);
			break;
		case 2:
			sinputCommand = this.BpInputComp.攀爬抬起(time);
			break;
		case 3:
			sinputCommand = this.BpInputComp.走跑切换抬起(time);
			break;
		case 4:
			sinputCommand = this.BpInputComp.攻击抬起(time);
			break;
		case 5:
			sinputCommand = this.BpInputComp.闪避抬起(time);
			break;
		case 6:
			sinputCommand = this.BpInputComp.技能1抬起(time);
			break;
		case 7:
			sinputCommand = this.BpInputComp.幻象1抬起(time);
			break;
		case 8:
			sinputCommand = this.BpInputComp.大招抬起(time);
			break;
		case 9:
			sinputCommand = this.BpInputComp.幻象2抬起(time);
			break;
		case 10:
			sinputCommand = this.BpInputComp.切换角色1抬起(time);
			break;
		case 11:
			sinputCommand = this.BpInputComp.切换角色2抬起(time);
			break;
		case 12:
			sinputCommand = this.BpInputComp.切换角色3抬起(time);
			break;
		case 14:
			sinputCommand = this.BpInputComp.瞄准抬起(time);
			break;
		}
		if ((sinputCommand == null || sinputCommand.CommandType == ECommandType.None) && this.IsBpInputCompSwallowCommand(action, EInputState.Release, EInputFuncType.HandleAction))
		{
			return InputLayer.GetSwallowCommand();
		}
		return sinputCommand;
	}

	// Token: 0x060185CE RID: 99790 RVA: 0x0075A4F0 File Offset: 0x007586F0
	[NullableContext(2)]
	public override SInputCommand HandleHold(CSharpScript.Game.Input.EInputAction action, float time)
	{
		if (this.BpInputComp == null || !this.IsEnable)
		{
			return null;
		}
		SInputCommand sinputCommand = null;
		switch (action)
		{
		case 1:
			sinputCommand = this.BpInputComp.跳跃长按(time);
			break;
		case 2:
			sinputCommand = this.BpInputComp.攀爬长按(time);
			break;
		case 3:
			sinputCommand = this.BpInputComp.走跑切换长按(time);
			break;
		case 4:
			sinputCommand = this.BpInputComp.攻击长按(time);
			break;
		case 5:
			sinputCommand = this.BpInputComp.闪避长按(time);
			break;
		case 6:
			sinputCommand = this.BpInputComp.技能1长按(time);
			break;
		case 7:
			sinputCommand = this.BpInputComp.幻象1长按(time);
			break;
		case 8:
			sinputCommand = this.BpInputComp.大招长按(time);
			break;
		case 9:
			sinputCommand = this.BpInputComp.幻象2长按(time);
			break;
		case 10:
			sinputCommand = this.BpInputComp.切换角色1长按(time);
			break;
		case 11:
			sinputCommand = this.BpInputComp.切换角色2长按(time);
			break;
		case 12:
			sinputCommand = this.BpInputComp.切换角色3长按(time);
			break;
		case 13:
			sinputCommand = this.BpInputComp.锁定目标长按(time);
			break;
		case 14:
			sinputCommand = this.BpInputComp.瞄准长按(time);
			break;
		}
		if ((sinputCommand == null || sinputCommand.CommandType == ECommandType.None) && this.IsBpInputCompSwallowCommand(action, EInputState.Hold, EInputFuncType.HandleAction))
		{
			return InputLayer.GetSwallowCommand();
		}
		return sinputCommand;
	}

	// Token: 0x060185CF RID: 99791 RVA: 0x0075A66C File Offset: 0x0075886C
	public override bool DispatchPressEvent(CSharpScript.Game.Input.EInputAction action, float time)
	{
		if (this.BpInputComp == null || !this.IsEnable)
		{
			return false;
		}
		if (!this.IsBpInputCompSwallowCommand(action, EInputState.Press, EInputFuncType.DispatchEvent))
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
		}
		return true;
	}

	// Token: 0x060185D0 RID: 99792 RVA: 0x0075A7B4 File Offset: 0x007589B4
	public override bool DispatchReleaseEvent(CSharpScript.Game.Input.EInputAction action, float time)
	{
		if (this.BpInputComp == null || !this.IsEnable)
		{
			return false;
		}
		if (!this.IsBpInputCompSwallowCommand(action, EInputState.Release, EInputFuncType.DispatchEvent))
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
		}
		return true;
	}

	// Token: 0x060185D1 RID: 99793 RVA: 0x0075A8FB File Offset: 0x00758AFB
	public void SetEnable(bool enable)
	{
		this.IsEnable = enable;
	}

	// Token: 0x060185D2 RID: 99794 RVA: 0x0075A904 File Offset: 0x00758B04
	[NullableContext(2)]
	public override BP_InputBase_C GetBpInputComp()
	{
		if (this.BpInputComp == null || !this.IsEnable)
		{
			return null;
		}
		return this.BpInputComp;
	}

	// Token: 0x060185D3 RID: 99795 RVA: 0x0075A91E File Offset: 0x00758B1E
	public EInputCompSwallowMode GetBpInputCompSwallowMode()
	{
		if (this.BpInputComp == null || !this.IsEnable)
		{
			return EInputCompSwallowMode.None;
		}
		return this.BpInputComp.输入蓝图覆盖模式;
	}

	// Token: 0x060185D4 RID: 99796 RVA: 0x0075A944 File Offset: 0x00758B44
	public bool IsBpInputCompSwallowCommand(CSharpScript.Game.Input.EInputAction action, EInputState state, EInputFuncType funcType)
	{
		EInputCompSwallowMode bpInputCompSwallowMode = this.GetBpInputCompSwallowMode();
		if (bpInputCompSwallowMode == EInputCompSwallowMode.Override || funcType == EInputFuncType.DispatchEvent)
		{
			return this.IsSwallowByOverride(action, state, funcType);
		}
		return bpInputCompSwallowMode == EInputCompSwallowMode.All;
	}

	// Token: 0x060185D5 RID: 99797 RVA: 0x0075A970 File Offset: 0x00758B70
	private bool IsSwallowByOverride(CSharpScript.Game.Input.EInputAction action, EInputState state, EInputFuncType funcType)
	{
		if (this.BpInputComp == null || !this.IsEnable)
		{
			return false;
		}
		if (this.HasOverrideCache == null)
		{
			this.HasOverrideCache = new Dictionary<EInputFuncType, Dictionary<EInputState, Dictionary<CSharpScript.Game.Input.EInputAction, bool>>>();
		}
		Dictionary<EInputState, Dictionary<CSharpScript.Game.Input.EInputAction, bool>> dictionary;
		if (!this.HasOverrideCache.TryGetValue(funcType, out dictionary))
		{
			dictionary = new Dictionary<EInputState, Dictionary<CSharpScript.Game.Input.EInputAction, bool>>();
			this.HasOverrideCache[funcType] = dictionary;
		}
		Dictionary<CSharpScript.Game.Input.EInputAction, bool> dictionary2;
		bool result;
		if (!dictionary.TryGetValue(state, out dictionary2))
		{
			dictionary2 = new Dictionary<CSharpScript.Game.Input.EInputAction, bool>();
			dictionary[state] = dictionary2;
		}
		else if (dictionary2.TryGetValue(action, out result))
		{
			return result;
		}
		string text = null;
		if (funcType == EInputFuncType.HandleAction)
		{
			if (state == EInputState.Press)
			{
				InputDefine.InputPressFunctionNames.TryGetValue(action, out text);
			}
			else if (state == EInputState.Release)
			{
				InputDefine.InputReleaseFunctionNames.TryGetValue(action, out text);
			}
			else if (state == EInputState.Hold)
			{
				InputDefine.InputHoldFunctionNames.TryGetValue(action, out text);
			}
		}
		else if (funcType == EInputFuncType.DispatchEvent)
		{
			if (state == EInputState.Press)
			{
				InputDefine.InputPressEventFunctionNames.TryGetValue(action, out text);
			}
			else if (state == EInputState.Release)
			{
				InputDefine.InputReleaseEventFunctionNames.TryGetValue(action, out text);
			}
		}
		if (string.IsNullOrEmpty(text))
		{
			dictionary2[action] = false;
			return false;
		}
		bool flag = UKuroStaticLibrary.HasBlueprintOverrideFunction(this.BpInputComp.GetClass(), text);
		dictionary2[action] = flag;
		return flag;
	}

	// Token: 0x0400D256 RID: 53846
	[StaticVariableRuleIgnore]
	private static readonly Stat HandlePressStat = Stat.Create("ExtraInputLayer.HandlePress", "", "");

	// Token: 0x0400D257 RID: 53847
	[StaticVariableRuleIgnore]
	private static readonly Stat HandleReleaseStat = Stat.Create("ExtraInputLayer.HandleRelease", "", "");

	// Token: 0x0400D258 RID: 53848
	[StaticVariableRuleIgnore]
	private static readonly Stat OverrideQueryStat = Stat.Create("ExtraInputLayer.OverrideQueryStat", "", "");

	// Token: 0x0400D259 RID: 53849
	[Nullable(2)]
	private BP_InputBase_C BpInputComp;

	// Token: 0x0400D25A RID: 53850
	private bool IsEnable = true;

	// Token: 0x0400D25B RID: 53851
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<EInputFuncType, Dictionary<EInputState, Dictionary<CSharpScript.Game.Input.EInputAction, bool>>> HasOverrideCache;
}
