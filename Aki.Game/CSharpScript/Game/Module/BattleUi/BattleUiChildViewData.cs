using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02004C4C RID: 19532
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleUiChildViewData
	{
		// Token: 0x06030BEE RID: 199662 RVA: 0x00D98697 File Offset: 0x00D96897
		public void AddBattleUiCommonChildVisibleReason(EBattleUiCommonChildVisibleReason visibleReason)
		{
			this.BattleUiCommonChildReasonSet.Add(visibleReason);
			this.SetChildrenVisible(EBattleUiVisibleReason.Default, BattleUiChildViewData.BattleUiChildren, this.BattleUiCommonChildReasonSet.Count > 0, true, 0);
		}

		// Token: 0x06030BEF RID: 199663 RVA: 0x00D986C2 File Offset: 0x00D968C2
		public void RemoveBattleUiCommonChildVisibleReason(EBattleUiCommonChildVisibleReason visibleReason)
		{
			this.BattleUiCommonChildReasonSet.Remove(visibleReason);
			this.SetChildrenVisible(EBattleUiVisibleReason.Default, BattleUiChildViewData.BattleUiChildren, this.BattleUiCommonChildReasonSet.Count > 0, true, 0);
		}

		// Token: 0x06030BF0 RID: 199664 RVA: 0x00D986F0 File Offset: 0x00D968F0
		public void Init()
		{
			this.VisibleStateList.Clear();
			this.SubVisibleStateList.Clear();
			for (int i = 0; i < 46; i++)
			{
				this.VisibleStateList.Add(1);
				int[] array = new int[21];
				array[0] = 1;
				this.SubVisibleStateList.Add(array);
			}
			this.VisibleStateList.Add(0);
			this.SubVisibleStateList.Add(new int[21]);
		}

		// Token: 0x06030BF1 RID: 199665 RVA: 0x00D98762 File Offset: 0x00D96962
		public void OnLeaveLevel()
		{
		}

		// Token: 0x06030BF2 RID: 199666 RVA: 0x00D98764 File Offset: 0x00D96964
		public void Clear()
		{
		}

		// Token: 0x06030BF3 RID: 199667 RVA: 0x00D98766 File Offset: 0x00D96966
		public bool GetChildVisible(EBattleUiChild childType)
		{
			return this.VisibleStateList[(int)childType] == 0;
		}

		// Token: 0x06030BF4 RID: 199668 RVA: 0x00D98778 File Offset: 0x00D96978
		public unsafe bool SetChildVisible(EBattleUiVisibleReason visibleReason, EBattleUiChild childType, bool bVisible, bool dispatchEvent = true, int subVisibleReason = 0)
		{
			int num = this.VisibleStateList[(int)childType];
			int num2 = VisibleStateUtil.SetVisible(this.SubVisibleStateList[(int)childType][(int)visibleReason], bVisible, subVisibleReason);
			this.SubVisibleStateList[(int)childType][(int)visibleReason] = num2;
			bool bVisible2 = num2 == 0;
			int num3 = VisibleStateUtil.SetVisible(num, bVisible2, (int)visibleReason);
			this.VisibleStateList[(int)childType] = num3;
			if (dispatchEvent && num != num3 && (num == 0 || num3 == 0))
			{
				this.HandleCallback(childType);
			}
			if (childType == EBattleUiChild.InteractionHint)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.BattleUiSet;
				ELogAuthor author = ELogAuthor.FJH;
				string message = "SetChildVisible";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("visibleReason", visibleReason);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("childType", childType);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("bVisible", bVisible);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("subVisibleReason", subVisibleReason);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			}
			return num3 == 0;
		}

		// Token: 0x06030BF5 RID: 199669 RVA: 0x00D98890 File Offset: 0x00D96A90
		public void SetChildrenVisible(EBattleUiVisibleReason visibleReason, IEnumerable<EBattleUiChild> childrenType, bool bVisible, bool dispatchEvent = true, int subVisibleReason = 0)
		{
			foreach (EBattleUiChild childType in childrenType)
			{
				this.SetChildVisible(visibleReason, childType, bVisible, dispatchEvent, subVisibleReason);
			}
		}

		// Token: 0x06030BF6 RID: 199670 RVA: 0x00D988E0 File Offset: 0x00D96AE0
		[NullableContext(2)]
		public void HideBattleView(EBattleUiVisibleReason visibleReason, IEnumerable<EBattleUiChild> excludeChildren = null, int subVisibleReason = 0)
		{
			for (int i = 0; i < 46; i++)
			{
				this.SetChildVisible(visibleReason, (EBattleUiChild)i, false, false, subVisibleReason);
			}
			if (excludeChildren != null)
			{
				foreach (EBattleUiChild childType in excludeChildren)
				{
					this.SetChildVisible(visibleReason, childType, true, false, subVisibleReason);
				}
			}
			this.HandleAllCallback();
		}

		// Token: 0x06030BF7 RID: 199671 RVA: 0x00D98950 File Offset: 0x00D96B50
		public void ShowBattleView(EBattleUiVisibleReason visibleReason, int subVisibleReason = 0)
		{
			for (int i = 0; i < 46; i++)
			{
				this.SetChildVisible(visibleReason, (EBattleUiChild)i, true, false, subVisibleReason);
			}
			this.HandleAllCallback();
		}

		// Token: 0x06030BF8 RID: 199672 RVA: 0x00D9897C File Offset: 0x00D96B7C
		public bool GetVisibleByReason(EBattleUiChild childType, EBattleUiVisibleReason reason)
		{
			return VisibleStateUtil.GetVisibleByType(this.VisibleStateList[(int)childType], (int)reason);
		}

		// Token: 0x06030BF9 RID: 199673 RVA: 0x00D98990 File Offset: 0x00D96B90
		public void AddCallback(EBattleUiChild childType, Action callback)
		{
			List<Action> list;
			if (!this.CallbackMap.TryGetValue(childType, out list))
			{
				list = new List<Action>();
				this.CallbackMap[childType] = list;
			}
			list.Add(callback);
		}

		// Token: 0x06030BFA RID: 199674 RVA: 0x00D989C8 File Offset: 0x00D96BC8
		public void RemoveCallback(EBattleUiChild childType, Action callback)
		{
			List<Action> list;
			if (!this.CallbackMap.TryGetValue(childType, out list))
			{
				return;
			}
			list.Remove(callback);
		}

		// Token: 0x06030BFB RID: 199675 RVA: 0x00D989F0 File Offset: 0x00D96BF0
		private void HandleCallback(EBattleUiChild childType)
		{
			List<Action> list;
			if (!this.CallbackMap.TryGetValue(childType, out list))
			{
				return;
			}
			foreach (Action action in list)
			{
				action();
			}
		}

		// Token: 0x06030BFC RID: 199676 RVA: 0x00D98A4C File Offset: 0x00D96C4C
		private void HandleAllCallback()
		{
			try
			{
				foreach (List<Action> list in this.CallbackMap.Values)
				{
					foreach (Action action in list)
					{
						action();
					}
				}
			}
			catch (Exception ex)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.CFT;
				string message = "childViewError";
				Exception error = ex;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("", ex.Message);
				instance.ErrorWithStack(module, author, message, error, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}

		// Token: 0x06030BFD RID: 199677 RVA: 0x00D98B14 File Offset: 0x00D96D14
		public void DebugLogAllChildState()
		{
			for (int i = 0; i < 47; i++)
			{
				if (this.VisibleStateList[i] != 0)
				{
					for (int j = 0; j < 21; j++)
					{
						if (!VisibleStateUtil.GetVisibleByType(this.VisibleStateList[i], j))
						{
							int visibleState = (i < this.SubVisibleStateList.Count) ? this.SubVisibleStateList[i][j] : 0;
							List<int> list = new List<int>();
							for (int k = 0; k < 31; k++)
							{
								if (!VisibleStateUtil.GetVisibleByType(visibleState, k))
								{
									list.Add(k);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x04019D39 RID: 105785
		private static readonly IReadOnlyList<EBattleUiChild> BattleUiChildren = new <>z__ReadOnlyArray<EBattleUiChild>(new EBattleUiChild[]
		{
			EBattleUiChild.Common,
			EBattleUiChild.HeadState,
			EBattleUiChild.PartState,
			EBattleUiChild.DamageView,
			EBattleUiChild.BattleHud,
			EBattleUiChild.BattleFloat,
			EBattleUiChild.InteractionHint,
			EBattleUiChild.PanelQTE,
			EBattleUiChild.GuideTipsView,
			EBattleUiChild.PositionOfficial,
			EBattleUiChild.MotorcycleControlTop,
			EBattleUiChild.MotorcycleMobileSkillButton,
			EBattleUiChild.MotorcycleMobileJoystick,
			EBattleUiChild.MotorcycleControlHud
		});

		// Token: 0x04019D3A RID: 105786
		private readonly List<int> VisibleStateList = new List<int>();

		// Token: 0x04019D3B RID: 105787
		private readonly List<int[]> SubVisibleStateList = new List<int[]>();

		// Token: 0x04019D3C RID: 105788
		private readonly Dictionary<EBattleUiChild, List<Action>> CallbackMap = new Dictionary<EBattleUiChild, List<Action>>();

		// Token: 0x04019D3D RID: 105789
		private readonly HashSet<EBattleUiCommonChildVisibleReason> BattleUiCommonChildReasonSet = new HashSet<EBattleUiCommonChildVisibleReason>();
	}
}
