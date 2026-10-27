using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AE4 RID: 23268
	public struct ITriggeredConfig : IFlatbufferObject
	{
		// Token: 0x1700AF72 RID: 44914
		// (get) Token: 0x06027B38 RID: 162616 RVA: 0x0057611E File Offset: 0x0057431E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027B39 RID: 162617 RVA: 0x0057612B File Offset: 0x0057432B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027B3A RID: 162618 RVA: 0x00576134 File Offset: 0x00574334
		public static ITriggeredConfig GetRootAsITriggeredConfig(ByteBuffer _bb)
		{
			return ITriggeredConfig.GetRootAsITriggeredConfig(_bb, default(ITriggeredConfig));
		}

		// Token: 0x06027B3B RID: 162619 RVA: 0x00576150 File Offset: 0x00574350
		public static ITriggeredConfig GetRootAsITriggeredConfig(ByteBuffer _bb, ITriggeredConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027B3C RID: 162620 RVA: 0x0057616D File Offset: 0x0057436D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027B3D RID: 162621 RVA: 0x0057617C File Offset: 0x0057437C
		public ITriggeredConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AF73 RID: 44915
		// (get) Token: 0x06027B3E RID: 162622 RVA: 0x0057618C File Offset: 0x0057438C
		public IConditionGroup? Condition
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AF74 RID: 44916
		// (get) Token: 0x06027B3F RID: 162623 RVA: 0x005761EC File Offset: 0x005743EC
		public int MaxTriggerTimes
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027B40 RID: 162624 RVA: 0x00576228 File Offset: 0x00574428
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AF75 RID: 44917
		// (get) Token: 0x06027B41 RID: 162625 RVA: 0x00576288 File Offset: 0x00574488
		public int ActionsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700AF76 RID: 44918
		// (get) Token: 0x06027B42 RID: 162626 RVA: 0x005762B4 File Offset: 0x005744B4
		public bool OnlineDisableTip
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AF77 RID: 44919
		// (get) Token: 0x06027B43 RID: 162627 RVA: 0x005762F4 File Offset: 0x005744F4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027B44 RID: 162628 RVA: 0x00576331 File Offset: 0x00574531
		public static Offset<ITriggeredConfig> CreateITriggeredConfig(FlatBufferBuilder builder, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), int MaxTriggerTimes = 0, VectorOffset ActionsOffset = default(VectorOffset), bool OnlineDisableTip = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			ITriggeredConfig.AddActions(builder, ActionsOffset);
			ITriggeredConfig.AddMaxTriggerTimes(builder, MaxTriggerTimes);
			ITriggeredConfig.AddCondition(builder, ConditionOffset);
			ITriggeredConfig.AddNullMask(builder, NullMask);
			ITriggeredConfig.AddOnlineDisableTip(builder, OnlineDisableTip);
			return ITriggeredConfig.EndITriggeredConfig(builder);
		}

		// Token: 0x06027B45 RID: 162629 RVA: 0x00576365 File Offset: 0x00574565
		public static void StartITriggeredConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06027B46 RID: 162630 RVA: 0x0057636E File Offset: 0x0057456E
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(0, conditionOffset.Value, 0);
		}

		// Token: 0x06027B47 RID: 162631 RVA: 0x0057637E File Offset: 0x0057457E
		public static void AddMaxTriggerTimes(FlatBufferBuilder builder, int maxTriggerTimes)
		{
			builder.AddInt(1, maxTriggerTimes, 0);
		}

		// Token: 0x06027B48 RID: 162632 RVA: 0x00576389 File Offset: 0x00574589
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(2, actionsOffset.Value, 0);
		}

		// Token: 0x06027B49 RID: 162633 RVA: 0x0057639C File Offset: 0x0057459C
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027B4A RID: 162634 RVA: 0x005763DC File Offset: 0x005745DC
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027B4B RID: 162635 RVA: 0x005763F6 File Offset: 0x005745F6
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027B4C RID: 162636 RVA: 0x00576414 File Offset: 0x00574614
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027B4D RID: 162637 RVA: 0x0057642D File Offset: 0x0057462D
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027B4E RID: 162638 RVA: 0x00576438 File Offset: 0x00574638
		public static void AddOnlineDisableTip(FlatBufferBuilder builder, bool onlineDisableTip)
		{
			builder.AddBool(3, onlineDisableTip, false);
		}

		// Token: 0x06027B4F RID: 162639 RVA: 0x00576443 File Offset: 0x00574643
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06027B50 RID: 162640 RVA: 0x0057644E File Offset: 0x0057464E
		public static Offset<ITriggeredConfig> EndITriggeredConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITriggeredConfig>(builder.EndTable());
		}

		// Token: 0x06027B51 RID: 162641 RVA: 0x0057645C File Offset: 0x0057465C
		public ITriggeredConfigT UnPack()
		{
			ITriggeredConfigT triggeredConfigT = new ITriggeredConfigT();
			this.UnPackTo(triggeredConfigT);
			return triggeredConfigT;
		}

		// Token: 0x06027B52 RID: 162642 RVA: 0x00576478 File Offset: 0x00574678
		public void UnPackTo(ITriggeredConfigT _o)
		{
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.MaxTriggerTimes = this.MaxTriggerTimes;
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
			_o.OnlineDisableTip = this.OnlineDisableTip;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06027B53 RID: 162643 RVA: 0x0057652C File Offset: 0x0057472C
		public static Offset<ITriggeredConfig> Pack(FlatBufferBuilder builder, ITriggeredConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITriggeredConfig>);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			VectorOffset actionsOffset = default(VectorOffset);
			if (_o.Actions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.Actions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.Actions[i]);
				}
				actionsOffset = ITriggeredConfig.CreateActionsVector(builder, array);
			}
			return ITriggeredConfig.CreateITriggeredConfig(builder, conditionOffset, _o.MaxTriggerTimes, actionsOffset, _o.OnlineDisableTip, _o.NullMask);
		}

		// Token: 0x0400F1D1 RID: 61905
		private Table __p;
	}
}
