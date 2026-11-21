using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Input
{
	// Token: 0x02006152 RID: 24914
	public class InputSystemComponent : IInputHandler
	{
		// Token: 0x0603BBA9 RID: 244649 RVA: 0x010F44D4 File Offset: 0x010F26D4
		public InputSystemComponent()
		{
			this.SetNormalAction();
		}

		// Token: 0x0603BBAA RID: 244650 RVA: 0x010F44F0 File Offset: 0x010F26F0
		public void ReceiveBeginPlay()
		{
			EventSystem.Instance.Add(EEventName.UnBlockCharacterAction, new Action(this.UnBlockCharacterEvent));
			EventSystem.Instance.Add(EEventName.ResetSystemAction, new Action(this.ResetSystemActionEvent));
			EventSystem.Instance.Add(EEventName.ResetNormalAction, new Action(this.ResetNormalActionEvent));
		}

		// Token: 0x0603BBAB RID: 244651 RVA: 0x010F4548 File Offset: 0x010F2748
		public void ReceiveEndPlay()
		{
			EventSystem.Instance.Remove(EEventName.UnBlockCharacterAction, new Action(this.UnBlockCharacterEvent));
			EventSystem.Instance.Remove(EEventName.ResetSystemAction, new Action(this.ResetSystemActionEvent));
			EventSystem.Instance.Remove(EEventName.ResetNormalAction, new Action(this.ResetNormalActionEvent));
		}

		// Token: 0x0603BBAC RID: 244652 RVA: 0x010F45A0 File Offset: 0x010F27A0
		private void UnBlockCharacterEvent()
		{
			this.InputGroup = new InputFilter(null, null, null, null);
		}

		// Token: 0x0603BBAD RID: 244653 RVA: 0x010F45B1 File Offset: 0x010F27B1
		private void ResetSystemActionEvent()
		{
			this.SetCurrentSystemAction();
		}

		// Token: 0x0603BBAE RID: 244654 RVA: 0x010F45BC File Offset: 0x010F27BC
		protected void SetInputActionList(EInputAction action, EUiViewName uiViewName)
		{
			HashSet<EInputAction> hashSet = new HashSet<EInputAction>();
			if (action != EInputAction.None)
			{
				hashSet.Add(action);
			}
			HashSet<EInputAction> hashSet2;
			if (InputFilterManager.CharacterSystemViewActions.TryGetValue(uiViewName, out hashSet2))
			{
				foreach (EInputAction item in hashSet2)
				{
					hashSet.Add(item);
				}
			}
			this.InputActionViewsMap[uiViewName] = hashSet;
		}

		// Token: 0x0603BBAF RID: 244655 RVA: 0x010F4644 File Offset: 0x010F2844
		protected void SetCurrentSystemAction()
		{
			HashSet<EInputAction> hashSet = new HashSet<EInputAction>();
			foreach (HashSet<EInputAction> hashSet2 in this.InputActionViewsMap.Values)
			{
				foreach (EInputAction item in hashSet2)
				{
					hashSet.Add(item);
				}
			}
			this.InputGroup = new InputFilter(hashSet, InputFilterManager.CharacterActions, null, InputFilterManager.CharacterAxes);
		}

		// Token: 0x0603BBB0 RID: 244656 RVA: 0x010F46F0 File Offset: 0x010F28F0
		private void ResetNormalActionEvent()
		{
			this.SetNormalAction();
		}

		// Token: 0x0603BBB1 RID: 244657 RVA: 0x010F46F8 File Offset: 0x010F28F8
		protected void SetNormalAction()
		{
			HashSet<EInputAction> hashSet = new HashSet<EInputAction>();
			foreach (EInputAction item in InputFilterManager.CharacterSystemActions.Keys)
			{
				hashSet.Add(item);
			}
			this.InputGroup = new InputFilter(hashSet, null, null, null);
		}

		// Token: 0x0603BBB2 RID: 244658 RVA: 0x010F4768 File Offset: 0x010F2968
		public int GetPriority()
		{
			return 1;
		}

		// Token: 0x0603BBB3 RID: 244659 RVA: 0x010F476B File Offset: 0x010F296B
		[NullableContext(1)]
		public InputFilter GetInputFilter()
		{
			return this.InputGroup;
		}

		// Token: 0x0603BBB4 RID: 244660 RVA: 0x010F4774 File Offset: 0x010F2974
		public void HandlePressEvent(EInputAction action, float time)
		{
			EUiViewName p;
			if (InputFilterManager.CharacterSystemActions.TryGetValue(action, out p))
			{
				EventSystem.Instance.Emit<EUiViewName>(EEventName.HotKeyInput, p);
				return;
			}
			EventSystem.Instance.Emit<EInputAction>(EEventName.ViewHotKeyInputPress, action);
		}

		// Token: 0x0603BBB5 RID: 244661 RVA: 0x010F47B0 File Offset: 0x010F29B0
		public void HandleReleaseEvent(EInputAction action, float time)
		{
			EUiViewName euiViewName;
			if (InputFilterManager.CharacterSystemActions.TryGetValue(action, out euiViewName))
			{
				return;
			}
			EventSystem.Instance.Emit<EInputAction>(EEventName.ViewHotKeyInputRelease, action);
		}

		// Token: 0x0603BBB6 RID: 244662 RVA: 0x010F47DB File Offset: 0x010F29DB
		public void HandleHoldEvent(EInputAction action, float time)
		{
		}

		// Token: 0x0603BBB7 RID: 244663 RVA: 0x010F47DD File Offset: 0x010F29DD
		public void HandleInputAxis(EInputAxis axis, float value)
		{
		}

		// Token: 0x0603BBB8 RID: 244664 RVA: 0x010F47DF File Offset: 0x010F29DF
		public void ClearInputAxis(bool nextFrame)
		{
		}

		// Token: 0x0603BBB9 RID: 244665 RVA: 0x010F47E1 File Offset: 0x010F29E1
		public void ClearSingleAxisInput(EInputAxis axis, bool nextFrame)
		{
		}

		// Token: 0x0603BBBA RID: 244666 RVA: 0x010F47E3 File Offset: 0x010F29E3
		public void PreProcessInput(float deltaTime, bool gamePaused)
		{
		}

		// Token: 0x0603BBBB RID: 244667 RVA: 0x010F47E5 File Offset: 0x010F29E5
		public void PostProcessInput(float deltaTime, bool gamePaused)
		{
		}

		// Token: 0x0401F82F RID: 129071
		[Nullable(2)]
		private InputFilter InputGroup;

		// Token: 0x0401F830 RID: 129072
		[Nullable(1)]
		private readonly Dictionary<EUiViewName, HashSet<EInputAction>> InputActionViewsMap = new Dictionary<EUiViewName, HashSet<EInputAction>>();
	}
}
