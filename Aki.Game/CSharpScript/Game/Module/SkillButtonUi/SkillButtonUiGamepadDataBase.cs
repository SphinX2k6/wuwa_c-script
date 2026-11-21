using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Input;

namespace CSharpScript.Game.Module.SkillButtonUi
{
	// Token: 0x02003BC9 RID: 15305
	[NullableContext(1)]
	[Nullable(0)]
	public class SkillButtonUiGamepadDataBase
	{
		// Token: 0x06027424 RID: 160804 RVA: 0x00B01C17 File Offset: 0x00AFFE17
		public virtual void Init()
		{
		}

		// Token: 0x06027425 RID: 160805 RVA: 0x00B01C19 File Offset: 0x00AFFE19
		public virtual void Clear()
		{
		}

		// Token: 0x06027426 RID: 160806 RVA: 0x00B01C1B File Offset: 0x00AFFE1B
		public virtual IReadOnlyList<string> GetAllActionNameList()
		{
			return Array.Empty<string>();
		}

		// Token: 0x06027427 RID: 160807 RVA: 0x00B01C22 File Offset: 0x00AFFE22
		public virtual IReadOnlyList<string> GetAllAxisNameList()
		{
			return Array.Empty<string>();
		}

		// Token: 0x06027428 RID: 160808 RVA: 0x00B01C29 File Offset: 0x00AFFE29
		public virtual void RefreshBaseConfigByUserSetting()
		{
		}

		// Token: 0x06027429 RID: 160809 RVA: 0x00B01C2B File Offset: 0x00AFFE2B
		public virtual void RefreshSwitchInteractOpen(bool isInit = false)
		{
			this.SwitchInteractData.RefreshSwitchInteractOpen(isInit);
		}

		// Token: 0x0602742A RID: 160810 RVA: 0x00B01C39 File Offset: 0x00AFFE39
		public virtual bool RefreshButtonData()
		{
			return false;
		}

		// Token: 0x0602742B RID: 160811 RVA: 0x00B01C3C File Offset: 0x00AFFE3C
		public virtual int GetButtonTypeByActionName(string actionName)
		{
			return 0;
		}

		// Token: 0x0602742C RID: 160812 RVA: 0x00B01C3F File Offset: 0x00AFFE3F
		public virtual int GetButtonTypeByAxisName(string axisName, float value)
		{
			return 0;
		}

		// Token: 0x0602742D RID: 160813 RVA: 0x00B01C42 File Offset: 0x00AFFE42
		public virtual bool IsAim()
		{
			return false;
		}

		// Token: 0x0602742E RID: 160814 RVA: 0x00B01C45 File Offset: 0x00AFFE45
		public virtual void SetIsPressCombineButton(bool value)
		{
		}

		// Token: 0x0602742F RID: 160815 RVA: 0x00B01C47 File Offset: 0x00AFFE47
		public virtual bool GetIsPressCombineButton()
		{
			return false;
		}

		// Token: 0x06027430 RID: 160816 RVA: 0x00B01C4A File Offset: 0x00AFFE4A
		public virtual void RefreshSkillButtonData(ESkillButtonRefreshReason refreshReason)
		{
		}

		// Token: 0x06027431 RID: 160817 RVA: 0x00B01C4C File Offset: 0x00AFFE4C
		public virtual bool RefreshAimState()
		{
			return false;
		}

		// Token: 0x06027432 RID: 160818 RVA: 0x00B01C4F File Offset: 0x00AFFE4F
		public virtual void RefreshInteractBehaviorData()
		{
		}

		// Token: 0x06027433 RID: 160819 RVA: 0x00B01C51 File Offset: 0x00AFFE51
		public virtual void OnActionKeyChanged(string actionName)
		{
		}

		// Token: 0x06027434 RID: 160820 RVA: 0x00B01C53 File Offset: 0x00AFFE53
		public virtual void AddChangeKeyReason(EGamepadChangeKeyReason reason)
		{
		}

		// Token: 0x06027435 RID: 160821 RVA: 0x00B01C55 File Offset: 0x00AFFE55
		public virtual void RemoveChangeKeyReason(EGamepadChangeKeyReason reason)
		{
		}

		// Token: 0x06027436 RID: 160822 RVA: 0x00B01C57 File Offset: 0x00AFFE57
		public virtual void AddAllowChangeKeyReason(string reason)
		{
		}

		// Token: 0x06027437 RID: 160823 RVA: 0x00B01C59 File Offset: 0x00AFFE59
		public virtual void RemoveAllowChangeKeyReason(string reason)
		{
		}

		// Token: 0x06027438 RID: 160824 RVA: 0x00B01C5B File Offset: 0x00AFFE5B
		public virtual void CacheInputAxis(in EInputAxis axis, float value)
		{
		}

		// Token: 0x06027439 RID: 160825 RVA: 0x00B01C5D File Offset: 0x00AFFE5D
		public virtual float GetInputAxis(in EInputAxis axis)
		{
			return 0f;
		}

		// Token: 0x0602743A RID: 160826 RVA: 0x00B01C64 File Offset: 0x00AFFE64
		public virtual void ClearInputAxis()
		{
		}

		// Token: 0x040156B0 RID: 87728
		public ESkillButtonGamepadDataType GamepadDataType;

		// Token: 0x040156B1 RID: 87729
		public List<string> ButtonKeyList = new List<string>();

		// Token: 0x040156B2 RID: 87730
		public string NoneIcon = "";

		// Token: 0x040156B3 RID: 87731
		public List<int?> CurButtonTypeList = new List<int?>();

		// Token: 0x040156B4 RID: 87732
		public List<int?> LastButtonTypeList = new List<int?>();

		// Token: 0x040156B5 RID: 87733
		public string CombineButtonKey = "";

		// Token: 0x040156B6 RID: 87734
		public int[] MainSkillButtonTypeList = Array.Empty<int>();

		// Token: 0x040156B7 RID: 87735
		public int[] MainSkillCombineButtonTypeList = Array.Empty<int>();

		// Token: 0x040156B8 RID: 87736
		public int[] DpadSkillButtonTypeList = Array.Empty<int>();

		// Token: 0x040156B9 RID: 87737
		public int[] DpadSkillCombineButtonTypeList = Array.Empty<int>();

		// Token: 0x040156BA RID: 87738
		public int[] SubSkillButtonTypeList = Array.Empty<int>();

		// Token: 0x040156BB RID: 87739
		public int[] SubSkillCombineButtonTypeList = Array.Empty<int>();

		// Token: 0x040156BC RID: 87740
		public int[] SubAimSkillButtonTypeList = Array.Empty<int>();

		// Token: 0x040156BD RID: 87741
		public bool ControlCameraByMoveAxis;

		// Token: 0x040156BE RID: 87742
		[Nullable(2)]
		public string RouletteKey;

		// Token: 0x040156BF RID: 87743
		[Nullable(2)]
		public string RouletteMainKey;

		// Token: 0x040156C0 RID: 87744
		[Nullable(2)]
		public string RouletteSecondKey;

		// Token: 0x040156C1 RID: 87745
		public GamepadSwitchInteractData SwitchInteractData = new GamepadSwitchInteractData();
	}
}
