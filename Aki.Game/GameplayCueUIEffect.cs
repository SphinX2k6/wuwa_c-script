using System;
using Aki.Config;
using CSharpScript.Game.Common.Event;

// Token: 0x0200252C RID: 9516
public class GameplayCueUIEffect : GameplayCueBase
{
	// Token: 0x0601789D RID: 96413 RVA: 0x006F37C0 File Offset: 0x006F19C0
	protected override void OnCreate()
	{
		this.SendGameplayCueUIEvent(true);
	}

	// Token: 0x0601789E RID: 96414 RVA: 0x006F37C9 File Offset: 0x006F19C9
	protected override void OnDestroy()
	{
		this.SendGameplayCueUIEvent(false);
	}

	// Token: 0x0601789F RID: 96415 RVA: 0x006F37D4 File Offset: 0x006F19D4
	private unsafe void SendGameplayCueUIEvent(bool isAdd)
	{
		if (this.CueConfig.CueType == 38)
		{
			bool flag = this.HasEntityBuffAuthority();
			if (!flag)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.GHY;
				string message = "[BossBuffNum] 非本端主控实体，拦截UI事件收发";
				<>y__InlineArray7<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray7<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("isAdd(添加/移除)", isAdd);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CueId", this.CueConfig.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("CueType", this.CueConfig.CueType);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("BuffId", this.BuffId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("BuffHandleId", this.BuffHandleId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("EntityId", this.EntityHandle.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("HasBuffAuthority", flag);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 7));
				return;
			}
		}
		EEventName? eventName = this.GetEventName((ECueType)this.CueConfig.CueType);
		if (eventName != null)
		{
			EventSystem.Instance.Emit<int, GameplayCue, bool, int>(eventName.Value, this.EntityHandle.Id, this.CueConfig, isAdd, this.BuffHandleId);
		}
	}

	// Token: 0x060178A0 RID: 96416 RVA: 0x006F395C File Offset: 0x006F1B5C
	private bool HasEntityBuffAuthority()
	{
		WorldEntity entity = this.EntityHandle.Entity;
		BaseBuffComponent baseBuffComponent = (entity != null) ? entity.GetComponent<BaseBuffComponent>() : null;
		return baseBuffComponent != null && baseBuffComponent.HasBuffAuthority();
	}

	// Token: 0x060178A1 RID: 96417 RVA: 0x006F398C File Offset: 0x006F1B8C
	private EEventName? GetEventName(ECueType type)
	{
		if (type <= ECueType.StateUITexture)
		{
			switch (type)
			{
			case ECueType.UITexture:
				break;
			case ECueType.MoveSpline:
				goto IL_91;
			case ECueType.UIPrefab:
				return new EEventName?(EEventName.CharOnBuffAddUIPrefab);
			case ECueType.UIDamage:
				return new EEventName?(EEventName.CharOnBuffAddUIDamage);
			default:
				if (type != ECueType.StateUITexture)
				{
					goto IL_91;
				}
				break;
			}
		}
		else
		{
			switch (type)
			{
			case ECueType.RoleSideEnergyBar:
				return new EEventName?(EEventName.CharOnBuffAddRoleSideEnergyBar);
			case ECueType.AudioEvent:
			case ECueType.EffectNiagara:
				goto IL_91;
			case ECueType.MoraleBuffTips:
				return new EEventName?(EEventName.CharOnBuffAddShowMoraleBuffTips);
			case ECueType.RoleUITexture:
				break;
			default:
				if (type - ECueType.CustomStyleUITexture > 1)
				{
					if (type != ECueType.RoverlikeQSkill)
					{
						goto IL_91;
					}
					return new EEventName?(EEventName.OnRoverlikeQSkillBuff);
				}
				break;
			}
		}
		return new EEventName?(EEventName.CharOnBuffAddUITexture);
		IL_91:
		return null;
	}

	// Token: 0x060178A2 RID: 96418 RVA: 0x006F3A33 File Offset: 0x006F1C33
	public new static bool IsSingleInstance()
	{
		return false;
	}
}
