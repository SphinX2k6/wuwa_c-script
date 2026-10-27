using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D04 RID: 23812
	[NullableContext(2)]
	[Nullable(0)]
	public class BossBuffNumItem : BattleVisibleChildView
	{
		// Token: 0x0603C4E1 RID: 247009 RVA: 0x00E71858 File Offset: 0x00E6FA58
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603C4E2 RID: 247010 RVA: 0x00E718A0 File Offset: 0x00E6FAA0
		protected override void OnStart()
		{
			base.InitChildType(EBattleUiChild.RoleState);
			this.NumText = base.GetText(0);
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0603C4E3 RID: 247011 RVA: 0x00E718C8 File Offset: 0x00E6FAC8
		protected override void OnBeforeDestroy()
		{
			this.Buff = null;
			this.PresenceCue = null;
			this.StackCue = null;
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
			base.OnBeforeDestroy();
		}

		// Token: 0x0603C4E4 RID: 247012 RVA: 0x00E71908 File Offset: 0x00E6FB08
		public override void Reset()
		{
			this.Buff = null;
			this.CurrentNum = 0;
			this.CurrentStatusPanel = EStatusPanel.None;
			this.Mode = EBossBuffNumMode.StackMode;
			this.BuffFinder = null;
			this.PresenceCue = null;
			this.StackCue = null;
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
			base.Reset();
		}

		// Token: 0x0603C4E5 RID: 247013 RVA: 0x00E7196E File Offset: 0x00E6FB6E
		public void SetBuffFinder([Nullable(new byte[]
		{
			1,
			2
		})] Func<int, int, IActiveBuff> finder)
		{
			this.BuffFinder = finder;
		}

		// Token: 0x0603C4E6 RID: 247014 RVA: 0x00E71977 File Offset: 0x00E6FB77
		public void OnCueChanged(int handleId, int entityId, EBossBuffNumMode mode, bool isAdd)
		{
			if (isAdd)
			{
				this.AddCue(handleId, entityId, mode);
			}
			else
			{
				this.RemoveCue(handleId, mode);
			}
			this.RefreshDisplay();
		}

		// Token: 0x0603C4E7 RID: 247015 RVA: 0x00E71996 File Offset: 0x00E6FB96
		public void Tick(float delta)
		{
			if (this.Buff == null)
			{
				this.TryResolvePendingBuff();
				return;
			}
			if (this.Mode == EBossBuffNumMode.PresenceMode)
			{
				return;
			}
			this.RefreshStackCount();
		}

		// Token: 0x0603C4E8 RID: 247016 RVA: 0x00E719B8 File Offset: 0x00E6FBB8
		private void AddCue(int handleId, int entityId, EBossBuffNumMode mode)
		{
			if (mode == EBossBuffNumMode.PresenceMode)
			{
				if (this.PresenceCue != null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Battle;
					ELogAuthor author = ELogAuthor.GHY;
					string message = "BossBuffNumItem.AddCue: PresenceMode 重复添加!";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
					string item = "existingHandleId";
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
					defaultInterpolatedStringHandler.AppendFormatted<int>(this.PresenceCue.Value.HandleId);
					ptr = new ValueTuple<string, object>(item, defaultInterpolatedStringHandler.ToStringAndClear());
					ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
					string item2 = "newHandleId";
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
					defaultInterpolatedStringHandler.AppendFormatted<int>(handleId);
					ptr2 = new ValueTuple<string, object>(item2, defaultInterpolatedStringHandler.ToStringAndClear());
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					return;
				}
				this.PresenceCue = new BossBuffNumItem.CueInfo?(new BossBuffNumItem.CueInfo(entityId, handleId));
				return;
			}
			else
			{
				if (this.PresenceCue == null)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.Battle;
					ELogAuthor author2 = ELogAuthor.GHY;
					string message2 = "BossBuffNumItem.AddCue: 添加 StackMode 前必须先有 PresenceMode 实例!";
					string item3 = "handleId";
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
					defaultInterpolatedStringHandler.AppendFormatted<int>(handleId);
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item3, defaultInterpolatedStringHandler.ToStringAndClear());
					instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				if (this.StackCue != null)
				{
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.Battle;
					ELogAuthor author3 = ELogAuthor.GHY;
					string message3 = "BossBuffNumItem.AddCue: StackMode 重复添加!";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					ref ValueTuple<string, object> ptr3 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0);
					string item4 = "existingHandleId";
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
					defaultInterpolatedStringHandler.AppendFormatted<int>(this.StackCue.Value.HandleId);
					ptr3 = new ValueTuple<string, object>(item4, defaultInterpolatedStringHandler.ToStringAndClear());
					ref ValueTuple<string, object> ptr4 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1);
					string item5 = "newHandleId";
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
					defaultInterpolatedStringHandler.AppendFormatted<int>(handleId);
					ptr4 = new ValueTuple<string, object>(item5, defaultInterpolatedStringHandler.ToStringAndClear());
					instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
					return;
				}
				this.StackCue = new BossBuffNumItem.CueInfo?(new BossBuffNumItem.CueInfo(entityId, handleId));
				return;
			}
		}

		// Token: 0x0603C4E9 RID: 247017 RVA: 0x00E71B80 File Offset: 0x00E6FD80
		private void RemoveCue(int handleId, EBossBuffNumMode mode)
		{
			if (mode == EBossBuffNumMode.PresenceMode)
			{
				if (this.PresenceCue == null || this.PresenceCue.Value.HandleId != handleId)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Battle;
					ELogAuthor author = ELogAuthor.GHY;
					string message = "BossBuffNumItem.RemoveCue: PresenceMode handleId 不匹配";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
					string item = "expected";
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
					defaultInterpolatedStringHandler.AppendFormatted<int?>((this.PresenceCue != null) ? new int?(this.PresenceCue.GetValueOrDefault().HandleId) : null);
					ptr = new ValueTuple<string, object>(item, defaultInterpolatedStringHandler.ToStringAndClear());
					ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
					string item2 = "actual";
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
					defaultInterpolatedStringHandler.AppendFormatted<int>(handleId);
					ptr2 = new ValueTuple<string, object>(item2, defaultInterpolatedStringHandler.ToStringAndClear());
					instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					return;
				}
				if (this.StackCue != null)
				{
					this.StackCue = null;
				}
				this.PresenceCue = null;
				return;
			}
			else
			{
				if (this.StackCue == null || this.StackCue.Value.HandleId != handleId)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.Battle;
					ELogAuthor author2 = ELogAuthor.GHY;
					string message2 = "BossBuffNumItem.RemoveCue: StackMode handleId 不匹配";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					ref ValueTuple<string, object> ptr3 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0);
					string item3 = "expected";
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
					defaultInterpolatedStringHandler.AppendFormatted<int?>((this.StackCue != null) ? new int?(this.StackCue.GetValueOrDefault().HandleId) : null);
					ptr3 = new ValueTuple<string, object>(item3, defaultInterpolatedStringHandler.ToStringAndClear());
					ref ValueTuple<string, object> ptr4 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1);
					string item4 = "actual";
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
					defaultInterpolatedStringHandler.AppendFormatted<int>(handleId);
					ptr4 = new ValueTuple<string, object>(item4, defaultInterpolatedStringHandler.ToStringAndClear());
					instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
					return;
				}
				this.StackCue = null;
				return;
			}
		}

		// Token: 0x0603C4EA RID: 247018 RVA: 0x00E71D60 File Offset: 0x00E6FF60
		private void RefreshDisplay()
		{
			BossBuffNumItem.CueInfo? stackCue = this.StackCue;
			BossBuffNumItem.CueInfo? cueInfo = (stackCue != null) ? stackCue : this.PresenceCue;
			if (cueInfo == null)
			{
				this.Deactivate();
				return;
			}
			BossBuffNumItem.CueInfo value = cueInfo.Value;
			EBossBuffNumMode mode = (this.StackCue != null) ? EBossBuffNumMode.StackMode : EBossBuffNumMode.PresenceMode;
			Func<int, int, IActiveBuff> buffFinder = this.BuffFinder;
			IActiveBuff activeBuff = (buffFinder != null) ? buffFinder(value.EntityId, value.HandleId) : null;
			this.Mode = mode;
			this.Buff = activeBuff;
			if (activeBuff != null)
			{
				this.ApplyBuffDisplay(activeBuff);
				return;
			}
			this.ShowBattleVisibleChildView(false);
			this.PlaySequence("Start");
		}

		// Token: 0x0603C4EB RID: 247019 RVA: 0x00E71E00 File Offset: 0x00E70000
		private void TryResolvePendingBuff()
		{
			BossBuffNumItem.CueInfo? stackCue = this.StackCue;
			BossBuffNumItem.CueInfo? cueInfo = (stackCue != null) ? stackCue : this.PresenceCue;
			if (cueInfo == null || this.BuffFinder == null)
			{
				return;
			}
			BossBuffNumItem.CueInfo value = cueInfo.Value;
			IActiveBuff activeBuff = this.BuffFinder(value.EntityId, value.HandleId);
			if (activeBuff != null)
			{
				this.Mode = ((this.StackCue != null) ? EBossBuffNumMode.StackMode : EBossBuffNumMode.PresenceMode);
				this.Buff = activeBuff;
				this.ApplyBuffDisplay(activeBuff);
			}
		}

		// Token: 0x0603C4EC RID: 247020 RVA: 0x00E71E84 File Offset: 0x00E70084
		[NullableContext(1)]
		private void ApplyBuffDisplay(IActiveBuff buff)
		{
			bool flag = this.CurrentStatusPanel == EStatusPanel.None;
			int num = (this.Mode == EBossBuffNumMode.PresenceMode) ? 0 : buff.StackCount;
			if (flag)
			{
				this.SetNumText(num);
				this.CurrentNum = num;
				this.CurrentStatusPanel = EStatusPanel.Inactive;
				this.ShowBattleVisibleChildView(false);
				this.PlaySequence("Start");
				if (num > 0)
				{
					this.ApplyNumChange(0, num);
				}
				return;
			}
			this.ApplyNumChange(this.CurrentNum, num);
			this.ShowBattleVisibleChildView(false);
		}

		// Token: 0x0603C4ED RID: 247021 RVA: 0x00E71EF7 File Offset: 0x00E700F7
		private void Deactivate()
		{
			this.Buff = null;
			if (this.CurrentStatusPanel != EStatusPanel.None)
			{
				this.PlaySequence("Close");
			}
			this.CurrentNum = 0;
			this.CurrentStatusPanel = EStatusPanel.None;
			this.HideBattleVisibleChildView();
		}

		// Token: 0x0603C4EE RID: 247022 RVA: 0x00E71F28 File Offset: 0x00E70128
		private void SetNumText(int num)
		{
			if (this.NumText != null)
			{
				this.NumText.SetText((num <= 0) ? "0" : num.ToString(), true);
			}
		}

		// Token: 0x0603C4EF RID: 247023 RVA: 0x00E71F50 File Offset: 0x00E70150
		private void RefreshStackCount()
		{
			if (this.Buff == null)
			{
				return;
			}
			int stackCount = this.Buff.StackCount;
			if (stackCount != this.CurrentNum)
			{
				this.ApplyNumChange(this.CurrentNum, stackCount);
			}
		}

		// Token: 0x0603C4F0 RID: 247024 RVA: 0x00E71F88 File Offset: 0x00E70188
		private void ApplyNumChange(int oldNum, int newNum)
		{
			this.SetNumText(newNum);
			this.CurrentNum = newNum;
			if (newNum > oldNum && oldNum >= 0)
			{
				this.PlaySequence("LvUp");
			}
			IActiveBuff buff = this.Buff;
			int? num;
			if (buff == null)
			{
				num = null;
			}
			else
			{
				BuffDefinition config = buff.Config;
				num = ((config != null) ? new int?(config.StackLimitCount) : null);
			}
			int? num2 = num;
			int valueOrDefault = num2.GetValueOrDefault(1);
			EStatusPanel estatusPanel = BossBuffNumItem.CalculateStatusPanel(oldNum, valueOrDefault);
			EStatusPanel estatusPanel2 = BossBuffNumItem.CalculateStatusPanel(newNum, valueOrDefault);
			if (estatusPanel != estatusPanel2)
			{
				this.PlayStatusTransition(estatusPanel, estatusPanel2);
			}
		}

		// Token: 0x0603C4F1 RID: 247025 RVA: 0x00E72010 File Offset: 0x00E70210
		private void PlayStatusTransition(EStatusPanel from, EStatusPanel to)
		{
			string statusTransitionSequence = BossBuffNumItem.GetStatusTransitionSequence(from, to);
			if (statusTransitionSequence == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.GHY;
				string message = "BossBuffNumItem.PlayStatusTransition: 非法状态转换!";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
				string item = "from";
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<EStatusPanel>(from);
				ptr = new ValueTuple<string, object>(item, defaultInterpolatedStringHandler.ToStringAndClear());
				ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
				string item2 = "to";
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<EStatusPanel>(to);
				ptr2 = new ValueTuple<string, object>(item2, defaultInterpolatedStringHandler.ToStringAndClear());
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			if (this.LastStatusSequence != null)
			{
				LevelSequencePlayer sequencePlayer = this.SequencePlayer;
				if (sequencePlayer != null)
				{
					sequencePlayer.StopSequenceByKey(this.LastStatusSequence, false, true);
				}
			}
			this.CurrentStatusPanel = to;
			this.LastStatusSequence = statusTransitionSequence;
			this.PlaySequence(statusTransitionSequence);
		}

		// Token: 0x0603C4F2 RID: 247026 RVA: 0x00E720E3 File Offset: 0x00E702E3
		private static string GetStatusTransitionSequence(EStatusPanel from, EStatusPanel to)
		{
			if (from == EStatusPanel.Inactive && to == EStatusPanel.Active)
			{
				return "Status1to2";
			}
			if (from == EStatusPanel.Active && to == EStatusPanel.Max)
			{
				return "Status2to3";
			}
			if (from == EStatusPanel.Max && to == EStatusPanel.Inactive)
			{
				return "Status3to1";
			}
			return null;
		}

		// Token: 0x0603C4F3 RID: 247027 RVA: 0x00E7210E File Offset: 0x00E7030E
		private static EStatusPanel CalculateStatusPanel(int num, int maxStack)
		{
			if (num >= maxStack && maxStack > 0)
			{
				return EStatusPanel.Max;
			}
			if (num >= 1)
			{
				return EStatusPanel.Active;
			}
			return EStatusPanel.Inactive;
		}

		// Token: 0x0603C4F4 RID: 247028 RVA: 0x00E72124 File Offset: 0x00E70324
		[NullableContext(1)]
		private void PlaySequence(string sequenceName)
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayLevelSequenceByName(sequenceName, false, null, false);
		}

		// Token: 0x0401F6BA RID: 128698
		private UUIText NumText;

		// Token: 0x0401F6BB RID: 128699
		private IActiveBuff Buff;

		// Token: 0x0401F6BC RID: 128700
		private int CurrentNum;

		// Token: 0x0401F6BD RID: 128701
		private EStatusPanel CurrentStatusPanel = EStatusPanel.None;

		// Token: 0x0401F6BE RID: 128702
		private EBossBuffNumMode Mode;

		// Token: 0x0401F6BF RID: 128703
		private Func<int, int, IActiveBuff> BuffFinder;

		// Token: 0x0401F6C0 RID: 128704
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0401F6C1 RID: 128705
		private string LastStatusSequence;

		// Token: 0x0401F6C2 RID: 128706
		private BossBuffNumItem.CueInfo? PresenceCue;

		// Token: 0x0401F6C3 RID: 128707
		private BossBuffNumItem.CueInfo? StackCue;

		// Token: 0x0200BF77 RID: 49015
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04039BD3 RID: 236499
			NumText
		}

		// Token: 0x0200BF78 RID: 49016
		[NullableContext(0)]
		private readonly struct CueInfo
		{
			// Token: 0x060501E3 RID: 328163 RVA: 0x0157E65E File Offset: 0x0157C85E
			public CueInfo(int entityId, int handleId)
			{
				this.EntityId = entityId;
				this.HandleId = handleId;
			}

			// Token: 0x04039BD4 RID: 236500
			public readonly int EntityId;

			// Token: 0x04039BD5 RID: 236501
			public readonly int HandleId;
		}
	}
}
