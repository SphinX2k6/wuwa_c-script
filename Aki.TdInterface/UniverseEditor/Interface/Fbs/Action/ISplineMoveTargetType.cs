using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007190 RID: 29072
	public struct ISplineMoveTargetType : IFlatbufferObject
	{
		// Token: 0x1700D7F2 RID: 55282
		// (get) Token: 0x060338B8 RID: 211128 RVA: 0x006F1554 File Offset: 0x006EF754
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060338B9 RID: 211129 RVA: 0x006F1561 File Offset: 0x006EF761
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060338BA RID: 211130 RVA: 0x006F1568 File Offset: 0x006EF768
		public static ISplineMoveTargetType GetRootAsISplineMoveTargetType(ByteBuffer _bb)
		{
			return ISplineMoveTargetType.GetRootAsISplineMoveTargetType(_bb, default(ISplineMoveTargetType));
		}

		// Token: 0x060338BB RID: 211131 RVA: 0x006F1584 File Offset: 0x006EF784
		public static ISplineMoveTargetType GetRootAsISplineMoveTargetType(ByteBuffer _bb, ISplineMoveTargetType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060338BC RID: 211132 RVA: 0x006F15A1 File Offset: 0x006EF7A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060338BD RID: 211133 RVA: 0x006F15B0 File Offset: 0x006EF7B0
		public ISplineMoveTargetType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D7F3 RID: 55283
		// (get) Token: 0x060338BE RID: 211134 RVA: 0x006F15C0 File Offset: 0x006EF7C0
		public ESplineMoveTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESplineMoveTargetType.Entity;
				}
				return (ESplineMoveTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060338BF RID: 211135 RVA: 0x006F15FC File Offset: 0x006EF7FC
		public static Offset<ISplineMoveTargetType> CreateISplineMoveTargetType(FlatBufferBuilder builder, ESplineMoveTargetType Type = ESplineMoveTargetType.Entity)
		{
			builder.StartTable(1);
			ISplineMoveTargetType.AddType(builder, Type);
			return ISplineMoveTargetType.EndISplineMoveTargetType(builder);
		}

		// Token: 0x060338C0 RID: 211136 RVA: 0x006F1612 File Offset: 0x006EF812
		public static void StartISplineMoveTargetType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060338C1 RID: 211137 RVA: 0x006F161B File Offset: 0x006EF81B
		public static void AddType(FlatBufferBuilder builder, ESplineMoveTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060338C2 RID: 211138 RVA: 0x006F1626 File Offset: 0x006EF826
		public static Offset<ISplineMoveTargetType> EndISplineMoveTargetType(FlatBufferBuilder builder)
		{
			return new Offset<ISplineMoveTargetType>(builder.EndTable());
		}

		// Token: 0x060338C3 RID: 211139 RVA: 0x006F1634 File Offset: 0x006EF834
		public ISplineMoveTargetTypeT UnPack()
		{
			ISplineMoveTargetTypeT splineMoveTargetTypeT = new ISplineMoveTargetTypeT();
			this.UnPackTo(splineMoveTargetTypeT);
			return splineMoveTargetTypeT;
		}

		// Token: 0x060338C4 RID: 211140 RVA: 0x006F164F File Offset: 0x006EF84F
		public void UnPackTo(ISplineMoveTargetTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060338C5 RID: 211141 RVA: 0x006F1660 File Offset: 0x006EF860
		public static Offset<ISplineMoveTargetType> Pack(FlatBufferBuilder builder, ISplineMoveTargetTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISplineMoveTargetType>);
			}
			return ISplineMoveTargetType.CreateISplineMoveTargetType(builder, _o.Type);
		}

		// Token: 0x04011C4F RID: 72783
		private Table __p;
	}
}
