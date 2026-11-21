using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005AB0 RID: 23216
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventLockInputState : Singleton
	{
		// Token: 0x17006CE6 RID: 27878
		// (get) Token: 0x06039324 RID: 234276 RVA: 0x01005ED7 File Offset: 0x010040D7
		public bool RealLockInput
		{
			get
			{
				return this.InnerLockInput;
			}
		}

		// Token: 0x06039325 RID: 234277 RVA: 0x01005EDF File Offset: 0x010040DF
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

		// Token: 0x06039326 RID: 234278 RVA: 0x01005F0B File Offset: 0x0100410B
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

		// Token: 0x06039327 RID: 234279 RVA: 0x01005F3F File Offset: 0x0100413F
		public bool IsLockInput()
		{
			return !this.GmViewOpening && this.InnerLockInput;
		}

		// Token: 0x17006CE7 RID: 27879
		// (get) Token: 0x06039328 RID: 234280 RVA: 0x01005F51 File Offset: 0x01004151
		public bool IsInputTagHasUiInputRoot
		{
			get
			{
				return this.InputTagNames != null && this.InputTagNames.Count != 0 && this.InputTagNames.Contains("UiInputRoot");
			}
		}

		// Token: 0x17006CE8 RID: 27880
		// (get) Token: 0x06039329 RID: 234281 RVA: 0x01005F7A File Offset: 0x0100417A
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

		// Token: 0x0603932A RID: 234282 RVA: 0x01005F9D File Offset: 0x0100419D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603932B RID: 234283 RVA: 0x01005F9F File Offset: 0x0100419F
		public static void ResetStaticDefaultValue()
		{
			LevelEventLockInputState instance = LevelEventLockInputState._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			LevelEventLockInputState._instance = null;
		}

		// Token: 0x0603932C RID: 234284 RVA: 0x01005FB8 File Offset: 0x010041B8
		static LevelEventLockInputState()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelEventLockInputState.CreateStaticDefaultValue), new Action(LevelEventLockInputState.ResetStaticDefaultValue));
		}

		// Token: 0x0401E1A6 RID: 123302
		private bool InnerLockInput;

		// Token: 0x0401E1A7 RID: 123303
		public bool GmViewOpening;

		// Token: 0x0401E1A8 RID: 123304
		public List<string> InputTagNames = new List<string>();

		// Token: 0x0401E1A9 RID: 123305
		public List<EUiViewName> InputLimitView = new List<EUiViewName>();

		// Token: 0x0401E1AA RID: 123306
		public bool InputLimitEsc;

		// Token: 0x0401E1AB RID: 123307
		[Nullable(2)]
		private static LevelEventLockInputState _instance;
	}
}
