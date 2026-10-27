using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02005FFE RID: 24574
	[NullableContext(1)]
	[Nullable(0)]
	public class TetrisDragItemPanel : UiPanelBase
	{
		// Token: 0x0603E405 RID: 254981 RVA: 0x00F0777E File Offset: 0x00F0597E
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x0603E406 RID: 254982 RVA: 0x00F077B8 File Offset: 0x00F059B8
		protected override UniTask OnBeforeStartAsync()
		{
			TetrisDragItemPanel.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TetrisDragItemPanel.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E407 RID: 254983 RVA: 0x00F077FB File Offset: 0x00F059FB
		protected override void OnStart()
		{
			this.ViewSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0603E408 RID: 254984 RVA: 0x00F07810 File Offset: 0x00F05A10
		public void ResetAllItems()
		{
			foreach (TetrisGridPanel tetrisGridPanel in this.ListItems.Values)
			{
				tetrisGridPanel.SetUiActive(false);
			}
		}

		// Token: 0x0603E409 RID: 254985 RVA: 0x00F07868 File Offset: 0x00F05A68
		[NullableContext(2)]
		public void RefreshView(BlockInstance data)
		{
			if (data == null)
			{
				return;
			}
			this.ResetAllItems();
			ValueTuple<int, int> valueTuple = TetrisUtils.Instance.FindAnchorOffset(data.Offsets);
			int num = 2 - valueTuple.Item1;
			int num2 = 2 - valueTuple.Item2;
			for (int i = 0; i < data.Offsets.Count; i++)
			{
				ValueTuple<int, int> valueTuple2 = data.Offsets[i];
				EGemType gemType = EGemType.None;
				if (data.GemFill == EGemFillType.Full)
				{
					gemType = data.GemType;
				}
				else if (data.GemFill == EGemFillType.Single && i == data.GemOffSet)
				{
					gemType = data.GemType;
				}
				CellInstance data2 = new CellInstance
				{
					ColorId = data.ColorId,
					GemType = gemType
				};
				ValueTuple<int, int> valueTuple3 = new ValueTuple<int, int>(valueTuple2.Item1 + num, valueTuple2.Item2 + num2);
				int key = TetrisUtils.GenPosKey(valueTuple3.Item1, valueTuple3.Item2);
				TetrisGridPanel tetrisGridPanel;
				if (this.ListItems.TryGetValue(key, out tetrisGridPanel))
				{
					tetrisGridPanel.SetUiActive(true);
					tetrisGridPanel.Refresh(data2);
				}
			}
			this.ViewSequencePlayer.PlayLevelSequenceByName("Pick", false, null, false);
		}

		// Token: 0x0603E40A RID: 254986 RVA: 0x00F07984 File Offset: 0x00F05B84
		private UniTask CreateShape(UUIItem itemTemplate, UUIItem list, [TupleElementNames(new string[]
		{
			"Row",
			"Column"
		})] [Nullable(0)] ValueTuple<int, int> offset)
		{
			TetrisDragItemPanel.<CreateShape>d__7 <CreateShape>d__;
			<CreateShape>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateShape>d__.<>4__this = this;
			<CreateShape>d__.itemTemplate = itemTemplate;
			<CreateShape>d__.list = list;
			<CreateShape>d__.offset = offset;
			<CreateShape>d__.<>1__state = -1;
			<CreateShape>d__.<>t__builder.Start<TetrisDragItemPanel.<CreateShape>d__7>(ref <CreateShape>d__);
			return <CreateShape>d__.<>t__builder.Task;
		}

		// Token: 0x0603E40B RID: 254987 RVA: 0x00F079E0 File Offset: 0x00F05BE0
		private UniTask CreateItemTemplate(UUIItem item, TetrisGridPanel itemView)
		{
			TetrisDragItemPanel.<CreateItemTemplate>d__8 <CreateItemTemplate>d__;
			<CreateItemTemplate>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateItemTemplate>d__.<>4__this = this;
			<CreateItemTemplate>d__.item = item;
			<CreateItemTemplate>d__.itemView = itemView;
			<CreateItemTemplate>d__.<>1__state = -1;
			<CreateItemTemplate>d__.<>t__builder.Start<TetrisDragItemPanel.<CreateItemTemplate>d__8>(ref <CreateItemTemplate>d__);
			return <CreateItemTemplate>d__.<>t__builder.Task;
		}

		// Token: 0x0603E40C RID: 254988 RVA: 0x00F07A33 File Offset: 0x00F05C33
		protected override void OnBeforeDestroy()
		{
			this.ListItems.Clear();
			LevelSequencePlayer viewSequencePlayer = this.ViewSequencePlayer;
			if (viewSequencePlayer != null)
			{
				viewSequencePlayer.Clear();
			}
			this.ViewSequencePlayer = null;
		}

		// Token: 0x04020844 RID: 133188
		private readonly Dictionary<int, TetrisGridPanel> ListItems = new Dictionary<int, TetrisGridPanel>();

		// Token: 0x04020845 RID: 133189
		[Nullable(2)]
		private LevelSequencePlayer ViewSequencePlayer;
	}
}
