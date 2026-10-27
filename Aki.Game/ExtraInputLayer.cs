using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Blueprints;
using AkiClient.Game.Aki.Character.Input.Structures;
using AkiClient.Game.Aki.Core.Fight;
using AkiClient.Game.Aki.Data.Fight.Struct;
using CSharpScript.Game.Input;
using UnrealEngine;

// Token: 0x020030C4 RID: 12484
[NullableContext(2)]
[Nullable(0)]
public class ExtraInputLayer : InputLayer
{
	// Token: 0x0601ABB8 RID: 109496 RVA: 0x007346BC File Offset: 0x007328BC
	[NullableContext(1)]
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

	// Token: 0x0601ABB9 RID: 109497 RVA: 0x00734780 File Offset: 0x00732980
	[NullableContext(1)]
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

	// Token: 0x0601ABBA RID: 109498 RVA: 0x00734832 File Offset: 0x00732A32
	public override void Clear()
	{
		this.BpInputComp = null;
	}

	// Token: 0x0601ABBB RID: 109499 RVA: 0x0073483B File Offset: 0x00732A3B
	public override EInputLayer GetLayerType()
	{
		return EInputLayer.Extra;
	}

	// Token: 0x0601ABBC RID: 109500 RVA: 0x00734840 File Offset: 0x00732A40
	public override SInputCommand HandlePress(EInputAction action, float time)
	{
		if (this.BpInputComp == null || !this.IsEnable)
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
		}
		return result;
	}

	// Token: 0x0601ABBD RID: 109501 RVA: 0x00734994 File Offset: 0x00732B94
	public override SInputCommand HandleRelease(EInputAction action, float time)
	{
		if (this.BpInputComp == null || !this.IsEnable)
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
		}
		return result;
	}

	// Token: 0x0601ABBE RID: 109502 RVA: 0x00734AD0 File Offset: 0x00732CD0
	public override SInputCommand HandleHold(EInputAction action, float time)
	{
		if (this.BpInputComp == null || !this.IsEnable)
		{
			return null;
		}
		SInputCommand result = null;
		switch (action)
		{
		case 1:
			result = this.BpInputComp.跳跃长按(time);
			break;
		case 2:
			result = this.BpInputComp.攀爬长按(time);
			break;
		case 3:
			result = this.BpInputComp.走跑切换长按(time);
			break;
		case 4:
			result = this.BpInputComp.攻击长按(time);
			break;
		case 5:
			result = this.BpInputComp.闪避长按(time);
			break;
		case 6:
			result = this.BpInputComp.技能1长按(time);
			break;
		case 7:
			result = this.BpInputComp.幻象1长按(time);
			break;
		case 8:
			result = this.BpInputComp.大招长按(time);
			break;
		case 9:
			result = this.BpInputComp.幻象2长按(time);
			break;
		case 10:
			result = this.BpInputComp.切换角色1长按(time);
			break;
		case 11:
			result = this.BpInputComp.切换角色2长按(time);
			break;
		case 12:
			result = this.BpInputComp.切换角色3长按(time);
			break;
		case 13:
			result = this.BpInputComp.锁定目标长按(time);
			break;
		case 14:
			result = this.BpInputComp.瞄准长按(time);
			break;
		}
		return result;
	}

	// Token: 0x0601ABBF RID: 109503 RVA: 0x00734C20 File Offset: 0x00732E20
	public override void DispatchPressEvent(EInputAction action, float time)
	{
		if (this.BpInputComp == null || !this.IsEnable)
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
		default:
			return;
		}
	}

	// Token: 0x0601ABC0 RID: 109504 RVA: 0x00734D3C File Offset: 0x00732F3C
	public override void DispatchReleaseEvent(EInputAction action, float time)
	{
		if (this.BpInputComp == null || !this.IsEnable)
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
		default:
			return;
		}
	}

	// Token: 0x0601ABC1 RID: 109505 RVA: 0x00734E57 File Offset: 0x00733057
	public void SetEnable(bool enable)
	{
		this.IsEnable = enable;
	}

	// Token: 0x0601ABC2 RID: 109506 RVA: 0x00734E60 File Offset: 0x00733060
	public override BP_InputBase_C GetBpInputComp()
	{
		if (this.BpInputComp == null || !this.IsEnable)
		{
			return null;
		}
		return this.BpInputComp;
	}

	// Token: 0x0400CE6A RID: 52842
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Stat HandlePressStat = Stat.Create("ExtraInputLayer.HandlePress", "", "");

	// Token: 0x0400CE6B RID: 52843
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Stat HandleReleaseStat = Stat.Create("ExtraInputLayer.HandleRelease", "", "");

	// Token: 0x0400CE6C RID: 52844
	private BP_InputBase_C BpInputComp;

	// Token: 0x0400CE6D RID: 52845
	private bool IsEnable = true;
}
