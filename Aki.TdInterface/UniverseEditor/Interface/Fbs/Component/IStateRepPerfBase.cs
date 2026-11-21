using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FBA RID: 24506
	public struct IStateRepPerfBase : IFlatbufferObject
	{
		// Token: 0x1700B57F RID: 46463
		// (get) Token: 0x060293B4 RID: 168884 RVA: 0x005A0D73 File Offset: 0x0059EF73
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060293B5 RID: 168885 RVA: 0x005A0D80 File Offset: 0x0059EF80
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060293B6 RID: 168886 RVA: 0x005A0D88 File Offset: 0x0059EF88
		public static IStateRepPerfBase GetRootAsIStateRepPerfBase(ByteBuffer _bb)
		{
			return IStateRepPerfBase.GetRootAsIStateRepPerfBase(_bb, default(IStateRepPerfBase));
		}

		// Token: 0x060293B7 RID: 168887 RVA: 0x005A0DA4 File Offset: 0x0059EFA4
		public static IStateRepPerfBase GetRootAsIStateRepPerfBase(ByteBuffer _bb, IStateRepPerfBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060293B8 RID: 168888 RVA: 0x005A0DC1 File Offset: 0x0059EFC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060293B9 RID: 168889 RVA: 0x005A0DD0 File Offset: 0x0059EFD0
		public IStateRepPerfBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B580 RID: 46464
		// (get) Token: 0x060293BA RID: 168890 RVA: 0x005A0DE0 File Offset: 0x0059EFE0
		public EStateRepPerfType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EStateRepPerfType.SkillId;
				}
				return (EStateRepPerfType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060293BB RID: 168891 RVA: 0x005A0E1C File Offset: 0x0059F01C
		public static Offset<IStateRepPerfBase> CreateIStateRepPerfBase(FlatBufferBuilder builder, EStateRepPerfType Type = EStateRepPerfType.SkillId)
		{
			builder.StartTable(1);
			IStateRepPerfBase.AddType(builder, Type);
			return IStateRepPerfBase.EndIStateRepPerfBase(builder);
		}

		// Token: 0x060293BC RID: 168892 RVA: 0x005A0E32 File Offset: 0x0059F032
		public static void StartIStateRepPerfBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060293BD RID: 168893 RVA: 0x005A0E3B File Offset: 0x0059F03B
		public static void AddType(FlatBufferBuilder builder, EStateRepPerfType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060293BE RID: 168894 RVA: 0x005A0E46 File Offset: 0x0059F046
		public static Offset<IStateRepPerfBase> EndIStateRepPerfBase(FlatBufferBuilder builder)
		{
			return new Offset<IStateRepPerfBase>(builder.EndTable());
		}

		// Token: 0x060293BF RID: 168895 RVA: 0x005A0E54 File Offset: 0x0059F054
		public IStateRepPerfBaseT UnPack()
		{
			IStateRepPerfBaseT stateRepPerfBaseT = new IStateRepPerfBaseT();
			this.UnPackTo(stateRepPerfBaseT);
			return stateRepPerfBaseT;
		}

		// Token: 0x060293C0 RID: 168896 RVA: 0x005A0E6F File Offset: 0x0059F06F
		public void UnPackTo(IStateRepPerfBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060293C1 RID: 168897 RVA: 0x005A0E80 File Offset: 0x0059F080
		public static Offset<IStateRepPerfBase> Pack(FlatBufferBuilder builder, IStateRepPerfBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStateRepPerfBase>);
			}
			return IStateRepPerfBase.CreateIStateRepPerfBase(builder, _o.Type);
		}

		// Token: 0x0400FCB1 RID: 64689
		private Table __p;
	}
}
