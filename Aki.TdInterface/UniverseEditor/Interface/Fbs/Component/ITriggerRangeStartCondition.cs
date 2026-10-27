using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AED RID: 23277
	public struct ITriggerRangeStartCondition : IFlatbufferObject
	{
		// Token: 0x1700AF95 RID: 44949
		// (get) Token: 0x06027BB4 RID: 162740 RVA: 0x00577358 File Offset: 0x00575558
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027BB5 RID: 162741 RVA: 0x00577365 File Offset: 0x00575565
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027BB6 RID: 162742 RVA: 0x0057736C File Offset: 0x0057556C
		public static ITriggerRangeStartCondition GetRootAsITriggerRangeStartCondition(ByteBuffer _bb)
		{
			return ITriggerRangeStartCondition.GetRootAsITriggerRangeStartCondition(_bb, default(ITriggerRangeStartCondition));
		}

		// Token: 0x06027BB7 RID: 162743 RVA: 0x00577388 File Offset: 0x00575588
		public static ITriggerRangeStartCondition GetRootAsITriggerRangeStartCondition(ByteBuffer _bb, ITriggerRangeStartCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027BB8 RID: 162744 RVA: 0x005773A5 File Offset: 0x005755A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027BB9 RID: 162745 RVA: 0x005773B4 File Offset: 0x005755B4
		public ITriggerRangeStartCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AF96 RID: 44950
		// (get) Token: 0x06027BBA RID: 162746 RVA: 0x005773C4 File Offset: 0x005755C4
		public ESpawnMonsterStartCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESpawnMonsterStartCondition.Immediate;
				}
				return (ESpawnMonsterStartCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AF97 RID: 44951
		// (get) Token: 0x06027BBB RID: 162747 RVA: 0x00577400 File Offset: 0x00575600
		public int Range
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

		// Token: 0x06027BBC RID: 162748 RVA: 0x0057743C File Offset: 0x0057563C
		public static Offset<ITriggerRangeStartCondition> CreateITriggerRangeStartCondition(FlatBufferBuilder builder, ESpawnMonsterStartCondition Type = ESpawnMonsterStartCondition.Immediate, int Range = 0)
		{
			builder.StartTable(2);
			ITriggerRangeStartCondition.AddRange(builder, Range);
			ITriggerRangeStartCondition.AddType(builder, Type);
			return ITriggerRangeStartCondition.EndITriggerRangeStartCondition(builder);
		}

		// Token: 0x06027BBD RID: 162749 RVA: 0x00577459 File Offset: 0x00575659
		public static void StartITriggerRangeStartCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06027BBE RID: 162750 RVA: 0x00577462 File Offset: 0x00575662
		public static void AddType(FlatBufferBuilder builder, ESpawnMonsterStartCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027BBF RID: 162751 RVA: 0x0057746D File Offset: 0x0057566D
		public static void AddRange(FlatBufferBuilder builder, int range)
		{
			builder.AddInt(1, range, 0);
		}

		// Token: 0x06027BC0 RID: 162752 RVA: 0x00577478 File Offset: 0x00575678
		public static Offset<ITriggerRangeStartCondition> EndITriggerRangeStartCondition(FlatBufferBuilder builder)
		{
			return new Offset<ITriggerRangeStartCondition>(builder.EndTable());
		}

		// Token: 0x06027BC1 RID: 162753 RVA: 0x00577488 File Offset: 0x00575688
		public ITriggerRangeStartConditionT UnPack()
		{
			ITriggerRangeStartConditionT triggerRangeStartConditionT = new ITriggerRangeStartConditionT();
			this.UnPackTo(triggerRangeStartConditionT);
			return triggerRangeStartConditionT;
		}

		// Token: 0x06027BC2 RID: 162754 RVA: 0x005774A3 File Offset: 0x005756A3
		public void UnPackTo(ITriggerRangeStartConditionT _o)
		{
			_o.Type = this.Type;
			_o.Range = this.Range;
		}

		// Token: 0x06027BC3 RID: 162755 RVA: 0x005774C0 File Offset: 0x005756C0
		public static Offset<ITriggerRangeStartCondition> Pack(FlatBufferBuilder builder, ITriggerRangeStartConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITriggerRangeStartCondition>);
			}
			return ITriggerRangeStartCondition.CreateITriggerRangeStartCondition(builder, _o.Type, _o.Range);
		}

		// Token: 0x0400F1E4 RID: 61924
		private Table __p;
	}
}
