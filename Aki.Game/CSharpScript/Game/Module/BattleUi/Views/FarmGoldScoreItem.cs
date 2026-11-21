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
	// Token: 0x02004D9C RID: 19868
	[NullableContext(1)]
	[Nullable(0)]
	public class FarmGoldScoreItem : BaseScoreItem
	{
		// Token: 0x06031EBB RID: 204475 RVA: 0x00DF6D14 File Offset: 0x00DF4F14
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

		// Token: 0x06031EBC RID: 204476 RVA: 0x00DF6D80 File Offset: 0x00DF4F80
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

		// Token: 0x06031EBD RID: 204477 RVA: 0x00DF6E04 File Offset: 0x00DF5004
		public override bool IsValidScore(int scoreId)
		{
			BattleScoreConf? scoreConfig = BattleScoreModel.Instance.GetScoreConfig(scoreId, false);
			return scoreConfig != null && scoreConfig.Value.Type == 0;
		}

		// Token: 0x06031EBE RID: 204478 RVA: 0x00DF6E3C File Offset: 0x00DF503C
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

		// Token: 0x06031EBF RID: 204479 RVA: 0x00DF6EC4 File Offset: 0x00DF50C4
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

		// Token: 0x06031EC0 RID: 204480 RVA: 0x00DF6F48 File Offset: 0x00DF5148
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

		// Token: 0x06031EC1 RID: 204481 RVA: 0x00DF6F94 File Offset: 0x00DF5194
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

		// Token: 0x06031EC2 RID: 204482 RVA: 0x00DF6FD4 File Offset: 0x00DF51D4
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

		// Token: 0x06031EC3 RID: 204483 RVA: 0x00DF7000 File Offset: 0x00DF5200
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

		// Token: 0x06031EC4 RID: 204484 RVA: 0x00DF7044 File Offset: 0x00DF5244
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

		// Token: 0x06031EC5 RID: 204485 RVA: 0x00DF7158 File Offset: 0x00DF5358
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

		// Token: 0x0401A6BD RID: 108221
		private bool RunState;

		// Token: 0x0401A6BE RID: 108222
		private int CounterValueIndex;

		// Token: 0x0401A6BF RID: 108223
		private List<int> CurrentScoreIndexArray = new List<int>();

		// Token: 0x0401A6C0 RID: 108224
		private readonly List<int> TargetScoreIndexArray = new List<int>();

		// Token: 0x0200AAAB RID: 43691
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04034BE6 RID: 216038
			ScoreText,
			// Token: 0x04034BE7 RID: 216039
			BociText
		}
	}
}
