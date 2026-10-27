using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02006955 RID: 26965
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventLockInputState : Singleton
	{
		// Token: 0x17009806 RID: 38918
		// (get) Token: 0x060432ED RID: 275181 RVA: 0x01061C77 File Offset: 0x0105FE77
		public bool RealLockInput
		{
			get
			{
				return this.InnerLockInput;
			}
		}

		// Token: 0x060432EE RID: 275182 RVA: 0x01061C7F File Offset: 0x0105FE7F
		public void Lock(List<string> tagNames)
		{
			bool flag = !this.InnerLockInput;
			this.InnerLockInput = true;
			this.InputTagNames = tagNames;
			if (flag)
			{
				EventSystem.Instance.Emit<bool>(EEventName.OnLevelInputLockChanged, true);
			}
		}

		// Token: 0x060432EF RID: 275183 RVA: 0x01061CAB File Offset: 0x0105FEAB
		public void Unlock()
		{
			bool innerLockInput = this.InnerLockInput;
			this.InnerLockInput = false;
			this.InputLimitEsc = false;
			this.InputTagNames.Clear();
			if (innerLockInput)
			{
				EventSystem.Instance.Emit<bool>(EEventName.OnLevelInputLockChanged, false);
			}
		}

		// Token: 0x060432F0 RID: 275184 RVA: 0x01061CDF File Offset: 0x0105FEDF
		public bool IsLockInput()
		{
			return !this.GmViewOpening && this.InnerLockInput;
		}

		// Token: 0x17009807 RID: 38919
		// (get) Token: 0x060432F1 RID: 275185 RVA: 0x01061CF1 File Offset: 0x0105FEF1
		public bool IsInputTagHasUiInputRoot
		{
			get
			{
				return this.InputTagNames != null && this.InputTagNames.Count != 0 && this.InputTagNames.Contains("UiInputRoot");
			}
		}

		// Token: 0x17009808 RID: 38920
		// (get) Token: 0x060432F2 RID: 275186 RVA: 0x01061D1A File Offset: 0x0105FF1A
		public static LevelEventLockInputState Instance
		{
			get
			{
				if (LevelEventLockInputState._instance == null)
				{
					LevelEventLockInputState._instance = new LevelEventLockInputState();
					LevelEventLockInputState._instance.OnInit();
				}
				return LevelEventLockInputState._instance;
			}
		}

		// Token: 0x060432F3 RID: 275187 RVA: 0x01061D3D File Offset: 0x0105FF3D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060432F4 RID: 275188 RVA: 0x01061D3F File Offset: 0x0105FF3F
		public static void ResetStaticDefaultValue()
		{
			LevelEventLockInputState instance = LevelEventLockInputState._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			LevelEventLockInputState._instance = null;
		}

		// Token: 0x060432F5 RID: 275189 RVA: 0x01061D58 File Offset: 0x0105FF58
		static LevelEventLockInputState()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelEventLockInputState.CreateStaticDefaultValue), new Action(LevelEventLockInputState.ResetStaticDefaultValue));
		}

		// Token: 0x04022FBC RID: 143292
		private bool InnerLockInput;

		// Token: 0x04022FBD RID: 143293
		public bool GmViewOpening;

		// Token: 0x04022FBE RID: 143294
		public List<string> InputTagNames = new List<string>();

		// Token: 0x04022FBF RID: 143295
		public List<EUiViewName> InputLimitView = new List<EUiViewName>();

		// Token: 0x04022FC0 RID: 143296
		public bool InputLimitEsc;

		// Token: 0x04022FC1 RID: 143297
		[Nullable(2)]
		private static LevelEventLockInputState _instance;
	}
}
