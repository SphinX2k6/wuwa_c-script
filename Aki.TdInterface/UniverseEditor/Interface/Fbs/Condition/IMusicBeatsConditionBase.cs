using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005151 RID: 20817
	public struct IMusicBeatsConditionBase : IFlatbufferObject
	{
		// Token: 0x1700952E RID: 38190
		// (get) Token: 0x06020BF7 RID: 134135 RVA: 0x00489432 File Offset: 0x00487632
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020BF8 RID: 134136 RVA: 0x0048943F File Offset: 0x0048763F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020BF9 RID: 134137 RVA: 0x00489448 File Offset: 0x00487648
		public static IMusicBeatsConditionBase GetRootAsIMusicBeatsConditionBase(ByteBuffer _bb)
		{
			return IMusicBeatsConditionBase.GetRootAsIMusicBeatsConditionBase(_bb, default(IMusicBeatsConditionBase));
		}

		// Token: 0x06020BFA RID: 134138 RVA: 0x00489464 File Offset: 0x00487664
		public static IMusicBeatsConditionBase GetRootAsIMusicBeatsConditionBase(ByteBuffer _bb, IMusicBeatsConditionBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020BFB RID: 134139 RVA: 0x00489481 File Offset: 0x00487681
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020BFC RID: 134140 RVA: 0x00489490 File Offset: 0x00487690
		public IMusicBeatsConditionBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700952F RID: 38191
		// (get) Token: 0x06020BFD RID: 134141 RVA: 0x004894A0 File Offset: 0x004876A0
		public EMusicEventType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMusicEventType.HcMusicBattle;
				}
				return (EMusicEventType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020BFE RID: 134142 RVA: 0x004894DC File Offset: 0x004876DC
		public static Offset<IMusicBeatsConditionBase> CreateIMusicBeatsConditionBase(FlatBufferBuilder builder, EMusicEventType Type = EMusicEventType.HcMusicBattle)
		{
			builder.StartTable(1);
			IMusicBeatsConditionBase.AddType(builder, Type);
			return IMusicBeatsConditionBase.EndIMusicBeatsConditionBase(builder);
		}

		// Token: 0x06020BFF RID: 134143 RVA: 0x004894F2 File Offset: 0x004876F2
		public static void StartIMusicBeatsConditionBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06020C00 RID: 134144 RVA: 0x004894FB File Offset: 0x004876FB
		public static void AddType(FlatBufferBuilder builder, EMusicEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020C01 RID: 134145 RVA: 0x00489506 File Offset: 0x00487706
		public static Offset<IMusicBeatsConditionBase> EndIMusicBeatsConditionBase(FlatBufferBuilder builder)
		{
			return new Offset<IMusicBeatsConditionBase>(builder.EndTable());
		}

		// Token: 0x06020C02 RID: 134146 RVA: 0x00489514 File Offset: 0x00487714
		public IMusicBeatsConditionBaseT UnPack()
		{
			IMusicBeatsConditionBaseT musicBeatsConditionBaseT = new IMusicBeatsConditionBaseT();
			this.UnPackTo(musicBeatsConditionBaseT);
			return musicBeatsConditionBaseT;
		}

		// Token: 0x06020C03 RID: 134147 RVA: 0x0048952F File Offset: 0x0048772F
		public void UnPackTo(IMusicBeatsConditionBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06020C04 RID: 134148 RVA: 0x00489540 File Offset: 0x00487740
		public static Offset<IMusicBeatsConditionBase> Pack(FlatBufferBuilder builder, IMusicBeatsConditionBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMusicBeatsConditionBase>);
			}
			return IMusicBeatsConditionBase.CreateIMusicBeatsConditionBase(builder, _o.Type);
		}

		// Token: 0x0400E129 RID: 57641
		private Table __p;
	}
}
