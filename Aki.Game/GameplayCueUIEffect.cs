using System;
using Aki.Config;
using CSharpScript.Game.Common.Event;

// Token: 0x02002FD7 RID: 12247
public class GameplayCueUIEffect : GameplayCueBase
{
	// Token: 0x06019F6A RID: 106346 RVA: 0x006CB980 File Offset: 0x006C9B80
	protected override void OnCreate()
	{
		this.SendGameplayCueUIEvent(true);
	}

	// Token: 0x06019F6B RID: 106347 RVA: 0x006CB989 File Offset: 0x006C9B89
	protected override void OnDestroy()
	{
		this.SendGameplayCueUIEvent(false);
	}

	// Token: 0x06019F6C RID: 106348 RVA: 0x006CB994 File Offset: 0x006C9B94
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

	// Token: 0x06019F6D RID: 106349 RVA: 0x006CBB1C File Offset: 0x006C9D1C
	private bool HasEntityBuffAuthority()
	{
		WorldEntity entity = this.EntityHandle.Entity;
		BaseBuffComponent baseBuffComponent = (entity != null) ? entity.GetComponent<BaseBuffComponent>() : null;
		return baseBuffComponent != null && baseBuffComponent.HasBuffAuthority();
	}

	// Token: 0x06019F6E RID: 106350 RVA: 0x006CBB4C File Offset: 0x006C9D4C
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

	// Token: 0x06019F6F RID: 106351 RVA: 0x006CBBF3 File Offset: 0x006C9DF3
	public new static bool IsSingleInstance()
	{
		return false;
	}
}
