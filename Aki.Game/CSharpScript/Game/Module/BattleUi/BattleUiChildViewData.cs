using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02005C6C RID: 23660
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleUiChildViewData
	{
		// Token: 0x0603BCA3 RID: 244899 RVA: 0x00E482B7 File Offset: 0x00E464B7
		public void AddBattleUiCommonChildVisibleReason(EBattleUiCommonChildVisibleReason visibleReason)
		{
			this.BattleUiCommonChildReasonSet.Add(visibleReason);
			this.SetChildrenVisible(EBattleUiVisibleReason.Default, BattleUiChildViewData.BattleUiChildren, this.BattleUiCommonChildReasonSet.Count > 0, true, 0);
		}

		// Token: 0x0603BCA4 RID: 244900 RVA: 0x00E482E2 File Offset: 0x00E464E2
		public void RemoveBattleUiCommonChildVisibleReason(EBattleUiCommonChildVisibleReason visibleReason)
		{
			this.BattleUiCommonChildReasonSet.Remove(visibleReason);
			this.SetChildrenVisible(EBattleUiVisibleReason.Default, BattleUiChildViewData.BattleUiChildren, this.BattleUiCommonChildReasonSet.Count > 0, true, 0);
		}

		// Token: 0x0603BCA5 RID: 244901 RVA: 0x00E48310 File Offset: 0x00E46510
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

		// Token: 0x0603BCA6 RID: 244902 RVA: 0x00E48382 File Offset: 0x00E46582
		public void OnLeaveLevel()
		{
		}

		// Token: 0x0603BCA7 RID: 244903 RVA: 0x00E48384 File Offset: 0x00E46584
		public void Clear()
		{
		}

		// Token: 0x0603BCA8 RID: 244904 RVA: 0x00E48386 File Offset: 0x00E46586
		public bool GetChildVisible(EBattleUiChild childType)
		{
			return this.VisibleStateList[(int)childType] == 0;
		}

		// Token: 0x0603BCA9 RID: 244905 RVA: 0x00E48398 File Offset: 0x00E46598
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

		// Token: 0x0603BCAA RID: 244906 RVA: 0x00E484B0 File Offset: 0x00E466B0
		public void SetChildrenVisible(EBattleUiVisibleReason visibleReason, IEnumerable<EBattleUiChild> childrenType, bool bVisible, bool dispatchEvent = true, int subVisibleReason = 0)
		{
			foreach (EBattleUiChild childType in childrenType)
			{
				this.SetChildVisible(visibleReason, childType, bVisible, dispatchEvent, subVisibleReason);
			}
		}

		// Token: 0x0603BCAB RID: 244907 RVA: 0x00E48500 File Offset: 0x00E46700
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

		// Token: 0x0603BCAC RID: 244908 RVA: 0x00E48570 File Offset: 0x00E46770
		public void ShowBattleView(EBattleUiVisibleReason visibleReason, int subVisibleReason = 0)
		{
			for (int i = 0; i < 46; i++)
			{
				this.SetChildVisible(visibleReason, (EBattleUiChild)i, true, false, subVisibleReason);
			}
			this.HandleAllCallback();
		}

		// Token: 0x0603BCAD RID: 244909 RVA: 0x00E4859C File Offset: 0x00E4679C
		public bool GetVisibleByReason(EBattleUiChild childType, EBattleUiVisibleReason reason)
		{
			return VisibleStateUtil.GetVisibleByType(this.VisibleStateList[(int)childType], (int)reason);
		}

		// Token: 0x0603BCAE RID: 244910 RVA: 0x00E485B0 File Offset: 0x00E467B0
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

		// Token: 0x0603BCAF RID: 244911 RVA: 0x00E485E8 File Offset: 0x00E467E8
		public void RemoveCallback(EBattleUiChild childType, Action callback)
		{
			List<Action> list;
			if (!this.CallbackMap.TryGetValue(childType, out list))
			{
				return;
			}
			list.Remove(callback);
		}

		// Token: 0x0603BCB0 RID: 244912 RVA: 0x00E48610 File Offset: 0x00E46810
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

		// Token: 0x0603BCB1 RID: 244913 RVA: 0x00E4866C File Offset: 0x00E4686C
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

		// Token: 0x0603BCB2 RID: 244914 RVA: 0x00E48734 File Offset: 0x00E46934
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

		// Token: 0x0401F287 RID: 127623
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

		// Token: 0x0401F288 RID: 127624
		private readonly List<int> VisibleStateList = new List<int>();

		// Token: 0x0401F289 RID: 127625
		private readonly List<int[]> SubVisibleStateList = new List<int[]>();

		// Token: 0x0401F28A RID: 127626
		private readonly Dictionary<EBattleUiChild, List<Action>> CallbackMap = new Dictionary<EBattleUiChild, List<Action>>();

		// Token: 0x0401F28B RID: 127627
		private readonly HashSet<EBattleUiCommonChildVisibleReason> BattleUiCommonChildReasonSet = new HashSet<EBattleUiCommonChildVisibleReason>();
	}
}
