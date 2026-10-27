using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Input
{
	// Token: 0x02006FD1 RID: 28625
	public class InputSystemComponent : IInputHandler
	{
		// Token: 0x060459F8 RID: 285176 RVA: 0x0114A6E0 File Offset: 0x011488E0
		public InputSystemComponent()
		{
			this.SetNormalAction();
		}

		// Token: 0x060459F9 RID: 285177 RVA: 0x0114A6FC File Offset: 0x011488FC
		public void ReceiveBeginPlay()
		{
			EventSystem.Instance.Add(EEventName.UnBlockCharacterAction, new Action(this.UnBlockCharacterEvent));
			EventSystem.Instance.Add(EEventName.ResetSystemAction, new Action(this.ResetSystemActionEvent));
			EventSystem.Instance.Add(EEventName.ResetNormalAction, new Action(this.ResetNormalActionEvent));
		}

		// Token: 0x060459FA RID: 285178 RVA: 0x0114A754 File Offset: 0x01148954
		public void ReceiveEndPlay()
		{
			EventSystem.Instance.Remove(EEventName.UnBlockCharacterAction, new Action(this.UnBlockCharacterEvent));
			EventSystem.Instance.Remove(EEventName.ResetSystemAction, new Action(this.ResetSystemActionEvent));
			EventSystem.Instance.Remove(EEventName.ResetNormalAction, new Action(this.ResetNormalActionEvent));
		}

		// Token: 0x060459FB RID: 285179 RVA: 0x0114A7AC File Offset: 0x011489AC
		private void UnBlockCharacterEvent()
		{
			this.InputGroup = new InputFilter(null, null, null, null);
		}

		// Token: 0x060459FC RID: 285180 RVA: 0x0114A7BD File Offset: 0x011489BD
		private void ResetSystemActionEvent()
		{
			this.SetCurrentSystemAction();
		}

		// Token: 0x060459FD RID: 285181 RVA: 0x0114A7C8 File Offset: 0x011489C8
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

		// Token: 0x060459FE RID: 285182 RVA: 0x0114A850 File Offset: 0x01148A50
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

		// Token: 0x060459FF RID: 285183 RVA: 0x0114A8FC File Offset: 0x01148AFC
		private void ResetNormalActionEvent()
		{
			this.SetNormalAction();
		}

		// Token: 0x06045A00 RID: 285184 RVA: 0x0114A904 File Offset: 0x01148B04
		protected void SetNormalAction()
		{
			HashSet<EInputAction> hashSet = new HashSet<EInputAction>();
			foreach (EInputAction item in InputFilterManager.CharacterSystemActions.Keys)
			{
				hashSet.Add(item);
			}
			this.InputGroup = new InputFilter(hashSet, null, null, null);
		}

		// Token: 0x06045A01 RID: 285185 RVA: 0x0114A974 File Offset: 0x01148B74
		public int GetPriority()
		{
			return 1;
		}

		// Token: 0x06045A02 RID: 285186 RVA: 0x0114A977 File Offset: 0x01148B77
		[NullableContext(1)]
		public InputFilter GetInputFilter()
		{
			return this.InputGroup;
		}

		// Token: 0x06045A03 RID: 285187 RVA: 0x0114A980 File Offset: 0x01148B80
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

		// Token: 0x06045A04 RID: 285188 RVA: 0x0114A9BC File Offset: 0x01148BBC
		public void HandleReleaseEvent(EInputAction action, float time)
		{
			EUiViewName euiViewName;
			if (InputFilterManager.CharacterSystemActions.TryGetValue(action, out euiViewName))
			{
				return;
			}
			EventSystem.Instance.Emit<EInputAction>(EEventName.ViewHotKeyInputRelease, action);
		}

		// Token: 0x06045A05 RID: 285189 RVA: 0x0114A9E7 File Offset: 0x01148BE7
		public void HandleHoldEvent(EInputAction action, float time)
		{
		}

		// Token: 0x06045A06 RID: 285190 RVA: 0x0114A9E9 File Offset: 0x01148BE9
		public void HandleInputAxis(EInputAxis axis, float value)
		{
		}

		// Token: 0x06045A07 RID: 285191 RVA: 0x0114A9EB File Offset: 0x01148BEB
		public void ClearInputAxis(bool nextFrame)
		{
		}

		// Token: 0x06045A08 RID: 285192 RVA: 0x0114A9ED File Offset: 0x01148BED
		public void ClearSingleAxisInput(EInputAxis axis, bool nextFrame)
		{
		}

		// Token: 0x06045A09 RID: 285193 RVA: 0x0114A9EF File Offset: 0x01148BEF
		public void PreProcessInput(float deltaTime, bool gamePaused)
		{
		}

		// Token: 0x06045A0A RID: 285194 RVA: 0x0114A9F1 File Offset: 0x01148BF1
		public void PostProcessInput(float deltaTime, bool gamePaused)
		{
		}

		// Token: 0x0402457A RID: 148858
		[Nullable(2)]
		private InputFilter InputGroup;

		// Token: 0x0402457B RID: 148859
		[Nullable(1)]
		private readonly Dictionary<EUiViewName, HashSet<EInputAction>> InputActionViewsMap = new Dictionary<EUiViewName, HashSet<EInputAction>>();
	}
}
