using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Module.InstanceDungeon;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DB8 RID: 23992
	[NullableContext(1)]
	[Nullable(0)]
	public class FarmGoldScoreItem : BaseScoreItem
	{
		// Token: 0x0603CF44 RID: 249668 RVA: 0x00EA5E38 File Offset: 0x00EA4038
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603CF45 RID: 249669 RVA: 0x00EA5EA4 File Offset: 0x00EA40A4
		protected override void OnStart()
		{
			base.OnStart();
			this.ShowCurrentTextByIndexArray(this.CurrentScoreIndexArray);
			foreach (KeyValuePair<int, int> keyValuePair in BattleScoreModel.Instance.GetScoreMap())
			{
				int num;
				int num2;
				keyValuePair.Deconstruct(out num, out num2);
				int scoreId = num;
				int num3 = num2;
				if (num3 > 0 && this.IsValidScore(scoreId))
				{
					this.OnBattleScoreChanged(scoreId, num3);
				}
			}
		}

		// Token: 0x0603CF46 RID: 249670 RVA: 0x00EA5F28 File Offset: 0x00EA4128
		public override bool IsValidScore(int scoreId)
		{
			BattleScoreConf? scoreConfig = BattleScoreModel.Instance.GetScoreConfig(scoreId, false);
			return scoreConfig != null && scoreConfig.Value.Type == 0;
		}

		// Token: 0x0603CF47 RID: 249671 RVA: 0x00EA5F60 File Offset: 0x00EA4160
		public override void OnTick(float delta)
		{
			this.RefreshTreeBociText();
			if (!this.RunState)
			{
				return;
			}
			this.RefreshLowerIndexScoreText(this.CounterValueIndex, this.CurrentScoreIndexArray);
			this.RefreshHigherIndexScoreText(this.CounterValueIndex, this.CurrentScoreIndexArray);
			this.RunState = !this.CheckCounterValueIndexIfSame(this.CounterValueIndex, this.CurrentScoreIndexArray, this.TargetScoreIndexArray);
			if (!this.RunState)
			{
				this.CurrentScoreIndexArray = new List<int>(this.TargetScoreIndexArray);
			}
			this.ShowCurrentTextByIndexArray(this.CurrentScoreIndexArray);
		}

		// Token: 0x0603CF48 RID: 249672 RVA: 0x00EA5FE8 File Offset: 0x00EA41E8
		private void ShowCurrentTextByIndexArray(List<int> indexArray)
		{
			string text = string.Empty;
			foreach (int num in indexArray)
			{
				text += num.ToString();
			}
			text = ((text == string.Empty) ? "0" : text);
			UUIArtText artText = base.GetArtText(0);
			if (artText == null)
			{
				return;
			}
			artText.SetText(text);
		}

		// Token: 0x0603CF49 RID: 249673 RVA: 0x00EA606C File Offset: 0x00EA426C
		private void RefreshLowerIndexScoreText(int counterIndex, List<int> currentIndexArray)
		{
			int count = currentIndexArray.Count;
			for (int i = counterIndex + 1; i < count; i++)
			{
				int index = i;
				currentIndexArray[index]++;
				if (currentIndexArray[i] > 9)
				{
					currentIndexArray[i] = 0;
				}
			}
		}

		// Token: 0x0603CF4A RID: 249674 RVA: 0x00EA60B8 File Offset: 0x00EA42B8
		private void RefreshHigherIndexScoreText(int counterIndex, List<int> currentIndexArray)
		{
			for (int i = counterIndex; i >= 0; i--)
			{
				int index = i;
				currentIndexArray[index]++;
				if (currentIndexArray[i] <= 9)
				{
					break;
				}
				currentIndexArray[i] = 0;
			}
		}

		// Token: 0x0603CF4B RID: 249675 RVA: 0x00EA60F8 File Offset: 0x00EA42F8
		private bool CheckCounterValueIndexIfSame(int counterIndex, List<int> currentIndexArray, List<int> targetIndexArray)
		{
			for (int i = 0; i <= counterIndex; i++)
			{
				if (currentIndexArray[i] != targetIndexArray[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0603CF4C RID: 249676 RVA: 0x00EA6124 File Offset: 0x00EA4324
		private int GetNumValueByIndexArray(List<int> indexArray)
		{
			int count = indexArray.Count;
			int num = 0;
			for (int i = 0; i < count; i++)
			{
				num += indexArray[i] * (int)Math.Pow(10.0, (double)(count - i - 1));
			}
			return num;
		}

		// Token: 0x0603CF4D RID: 249677 RVA: 0x00EA6168 File Offset: 0x00EA4368
		protected override void OnBattleScoreChanged(int scoreId, int score)
		{
			List<int> list = new List<int>(this.TargetScoreIndexArray);
			string text = score.ToString();
			int length = text.Length;
			this.TargetScoreIndexArray.Clear();
			for (int i = 0; i < length; i++)
			{
				this.TargetScoreIndexArray.Add(int.Parse(text[i].ToString()));
			}
			int numValueByIndexArray = this.GetNumValueByIndexArray(this.CurrentScoreIndexArray);
			this.CurrentScoreIndexArray.Clear();
			if (score < numValueByIndexArray)
			{
				this.CurrentScoreIndexArray = new List<int>(this.TargetScoreIndexArray);
				this.RunState = false;
				this.ShowCurrentTextByIndexArray(this.CurrentScoreIndexArray);
				return;
			}
			this.CurrentScoreIndexArray = new List<int>(list);
			for (int j = 0; j < length - list.Count; j++)
			{
				this.CurrentScoreIndexArray.Insert(0, 0);
			}
			this.CounterValueIndex = ((length - 2 >= 0) ? (length - 2) : 0);
			this.RunState = !this.CheckCounterValueIndexIfSame(this.CounterValueIndex, this.CurrentScoreIndexArray, this.TargetScoreIndexArray);
			this.ShowCurrentTextByIndexArray(this.CurrentScoreIndexArray);
		}

		// Token: 0x0603CF4E RID: 249678 RVA: 0x00EA627C File Offset: 0x00EA447C
		public void RefreshTreeBociText()
		{
			string newText = "";
			InstanceDungeonInfo instanceDungeonInfo = InstanceDungeonModel.Instance.GetInstanceDungeonInfo();
			if (((instanceDungeonInfo != null) ? instanceDungeonInfo.Tree : null) != null)
			{
				BaseBehaviorTree tree = instanceDungeonInfo.Tree;
				BehaviorTreeViewShowData behaviorTreeViewShowData;
				if (tree == null)
				{
					behaviorTreeViewShowData = null;
				}
				else
				{
					Blackboard blackBoard = tree.GetBlackBoard();
					behaviorTreeViewShowData = ((blackBoard != null) ? blackBoard.CreateShowData(true) : null);
				}
				BehaviorTreeViewShowData behaviorTreeViewShowData2 = behaviorTreeViewShowData;
				if (((behaviorTreeViewShowData2 != null) ? behaviorTreeViewShowData2.SubStepInfos : null) != null)
				{
					newText = MissionViewStepTextUtil.GetStepTextByConfig(behaviorTreeViewShowData2.Id, behaviorTreeViewShowData2.SubStepInfos[0]);
				}
			}
			base.GetText(1).SetText(newText, true);
		}

		// Token: 0x0401FC00 RID: 130048
		private bool RunState;

		// Token: 0x0401FC01 RID: 130049
		private int CounterValueIndex;

		// Token: 0x0401FC02 RID: 130050
		private List<int> CurrentScoreIndexArray = new List<int>();

		// Token: 0x0401FC03 RID: 130051
		private readonly List<int> TargetScoreIndexArray = new List<int>();

		// Token: 0x0200C0A2 RID: 49314
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403A214 RID: 238100
			ScoreText,
			// Token: 0x0403A215 RID: 238101
			BociText
		}
	}
}
