using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Input;

namespace CSharpScript.Game.Module.SkillButtonUi
{
	// Token: 0x02004C18 RID: 19480
	[NullableContext(1)]
	[Nullable(0)]
	public class SkillButtonUiGamepadDataBase
	{
		// Token: 0x06032674 RID: 206452 RVA: 0x00BBD087 File Offset: 0x00BBB287
		public virtual void Init()
		{
		}

		// Token: 0x06032675 RID: 206453 RVA: 0x00BBD089 File Offset: 0x00BBB289
		public virtual void Clear()
		{
		}

		// Token: 0x06032676 RID: 206454 RVA: 0x00BBD08B File Offset: 0x00BBB28B
		public virtual IReadOnlyList<string> GetAllActionNameList()
		{
			return Array.Empty<string>();
		}

		// Token: 0x06032677 RID: 206455 RVA: 0x00BBD092 File Offset: 0x00BBB292
		public virtual IReadOnlyList<string> GetAllAxisNameList()
		{
			return Array.Empty<string>();
		}

		// Token: 0x06032678 RID: 206456 RVA: 0x00BBD099 File Offset: 0x00BBB299
		public virtual void RefreshBaseConfigByUserSetting()
		{
		}

		// Token: 0x06032679 RID: 206457 RVA: 0x00BBD09B File Offset: 0x00BBB29B
		public virtual void RefreshSwitchInteractOpen(bool isInit = false)
		{
			this.SwitchInteractData.RefreshSwitchInteractOpen(isInit);
		}

		// Token: 0x0603267A RID: 206458 RVA: 0x00BBD0A9 File Offset: 0x00BBB2A9
		public virtual bool RefreshButtonData()
		{
			return false;
		}

		// Token: 0x0603267B RID: 206459 RVA: 0x00BBD0AC File Offset: 0x00BBB2AC
		public virtual int GetButtonTypeByActionName(string actionName)
		{
			return 0;
		}

		// Token: 0x0603267C RID: 206460 RVA: 0x00BBD0AF File Offset: 0x00BBB2AF
		public virtual int GetButtonTypeByAxisName(string axisName, float value)
		{
			return 0;
		}

		// Token: 0x0603267D RID: 206461 RVA: 0x00BBD0B2 File Offset: 0x00BBB2B2
		public virtual bool IsAim()
		{
			return false;
		}

		// Token: 0x0603267E RID: 206462 RVA: 0x00BBD0B5 File Offset: 0x00BBB2B5
		public virtual void SetIsPressCombineButton(bool value)
		{
		}

		// Token: 0x0603267F RID: 206463 RVA: 0x00BBD0B7 File Offset: 0x00BBB2B7
		public virtual bool GetIsPressCombineButton()
		{
			return false;
		}

		// Token: 0x06032680 RID: 206464 RVA: 0x00BBD0BA File Offset: 0x00BBB2BA
		public virtual void RefreshSkillButtonData(ESkillButtonRefreshReason refreshReason)
		{
		}

		// Token: 0x06032681 RID: 206465 RVA: 0x00BBD0BC File Offset: 0x00BBB2BC
		public virtual bool RefreshAimState()
		{
			return false;
		}

		// Token: 0x06032682 RID: 206466 RVA: 0x00BBD0BF File Offset: 0x00BBB2BF
		public virtual void RefreshInteractBehaviorData()
		{
		}

		// Token: 0x06032683 RID: 206467 RVA: 0x00BBD0C1 File Offset: 0x00BBB2C1
		public virtual void OnActionKeyChanged(string actionName)
		{
		}

		// Token: 0x06032684 RID: 206468 RVA: 0x00BBD0C3 File Offset: 0x00BBB2C3
		public virtual void AddChangeKeyReason(EGamepadChangeKeyReason reason)
		{
		}

		// Token: 0x06032685 RID: 206469 RVA: 0x00BBD0C5 File Offset: 0x00BBB2C5
		public virtual void RemoveChangeKeyReason(EGamepadChangeKeyReason reason)
		{
		}

		// Token: 0x06032686 RID: 206470 RVA: 0x00BBD0C7 File Offset: 0x00BBB2C7
		public virtual void AddAllowChangeKeyReason(string reason)
		{
		}

		// Token: 0x06032687 RID: 206471 RVA: 0x00BBD0C9 File Offset: 0x00BBB2C9
		public virtual void RemoveAllowChangeKeyReason(string reason)
		{
		}

		// Token: 0x06032688 RID: 206472 RVA: 0x00BBD0CB File Offset: 0x00BBB2CB
		public virtual void CacheInputAxis(in EInputAxis axis, float value)
		{
		}

		// Token: 0x06032689 RID: 206473 RVA: 0x00BBD0CD File Offset: 0x00BBB2CD
		public virtual float GetInputAxis(in EInputAxis axis)
		{
			return 0f;
		}

		// Token: 0x0603268A RID: 206474 RVA: 0x00BBD0D4 File Offset: 0x00BBB2D4
		public virtual void ClearInputAxis()
		{
		}

		// Token: 0x0401AD54 RID: 109908
		public ESkillButtonGamepadDataType GamepadDataType;

		// Token: 0x0401AD55 RID: 109909
		public List<string> ButtonKeyList = new List<string>();

		// Token: 0x0401AD56 RID: 109910
		public string NoneIcon = "";

		// Token: 0x0401AD57 RID: 109911
		public List<int?> CurButtonTypeList = new List<int?>();

		// Token: 0x0401AD58 RID: 109912
		public List<int?> LastButtonTypeList = new List<int?>();

		// Token: 0x0401AD59 RID: 109913
		public string CombineButtonKey = "";

		// Token: 0x0401AD5A RID: 109914
		public int[] MainSkillButtonTypeList = Array.Empty<int>();

		// Token: 0x0401AD5B RID: 109915
		public int[] MainSkillCombineButtonTypeList = Array.Empty<int>();

		// Token: 0x0401AD5C RID: 109916
		public int[] DpadSkillButtonTypeList = Array.Empty<int>();

		// Token: 0x0401AD5D RID: 109917
		public int[] DpadSkillCombineButtonTypeList = Array.Empty<int>();

		// Token: 0x0401AD5E RID: 109918
		public int[] SubSkillButtonTypeList = Array.Empty<int>();

		// Token: 0x0401AD5F RID: 109919
		public int[] SubSkillCombineButtonTypeList = Array.Empty<int>();

		// Token: 0x0401AD60 RID: 109920
		public int[] SubAimSkillButtonTypeList = Array.Empty<int>();

		// Token: 0x0401AD61 RID: 109921
		public bool ControlCameraByMoveAxis;

		// Token: 0x0401AD62 RID: 109922
		[Nullable(2)]
		public string RouletteKey;

		// Token: 0x0401AD63 RID: 109923
		[Nullable(2)]
		public string RouletteMainKey;

		// Token: 0x0401AD64 RID: 109924
		[Nullable(2)]
		public string RouletteSecondKey;

		// Token: 0x0401AD65 RID: 109925
		public GamepadSwitchInteractData SwitchInteractData = new GamepadSwitchInteractData();
	}
}
