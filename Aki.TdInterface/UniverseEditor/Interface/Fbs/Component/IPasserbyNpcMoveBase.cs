using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056C5 RID: 22213
	public struct IPasserbyNpcMoveBase : IFlatbufferObject
	{
		// Token: 0x1700A552 RID: 42322
		// (get) Token: 0x060251B2 RID: 151986 RVA: 0x0051F8D4 File Offset: 0x0051DAD4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060251B3 RID: 151987 RVA: 0x0051F8E1 File Offset: 0x0051DAE1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060251B4 RID: 151988 RVA: 0x0051F8E8 File Offset: 0x0051DAE8
		public static IPasserbyNpcMoveBase GetRootAsIPasserbyNpcMoveBase(ByteBuffer _bb)
		{
			return IPasserbyNpcMoveBase.GetRootAsIPasserbyNpcMoveBase(_bb, default(IPasserbyNpcMoveBase));
		}

		// Token: 0x060251B5 RID: 151989 RVA: 0x0051F904 File Offset: 0x0051DB04
		public static IPasserbyNpcMoveBase GetRootAsIPasserbyNpcMoveBase(ByteBuffer _bb, IPasserbyNpcMoveBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060251B6 RID: 151990 RVA: 0x0051F921 File Offset: 0x0051DB21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060251B7 RID: 151991 RVA: 0x0051F930 File Offset: 0x0051DB30
		public IPasserbyNpcMoveBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A553 RID: 42323
		// (get) Token: 0x060251B8 RID: 151992 RVA: 0x0051F940 File Offset: 0x0051DB40
		public EPasserbyNpcMoveType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPasserbyNpcMoveType.Spline;
				}
				return (EPasserbyNpcMoveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060251B9 RID: 151993 RVA: 0x0051F97C File Offset: 0x0051DB7C
		public static Offset<IPasserbyNpcMoveBase> CreateIPasserbyNpcMoveBase(FlatBufferBuilder builder, EPasserbyNpcMoveType Type = EPasserbyNpcMoveType.Spline)
		{
			builder.StartTable(1);
			IPasserbyNpcMoveBase.AddType(builder, Type);
			return IPasserbyNpcMoveBase.EndIPasserbyNpcMoveBase(builder);
		}

		// Token: 0x060251BA RID: 151994 RVA: 0x0051F992 File Offset: 0x0051DB92
		public static void StartIPasserbyNpcMoveBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060251BB RID: 151995 RVA: 0x0051F99B File Offset: 0x0051DB9B
		public static void AddType(FlatBufferBuilder builder, EPasserbyNpcMoveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060251BC RID: 151996 RVA: 0x0051F9A6 File Offset: 0x0051DBA6
		public static Offset<IPasserbyNpcMoveBase> EndIPasserbyNpcMoveBase(FlatBufferBuilder builder)
		{
			return new Offset<IPasserbyNpcMoveBase>(builder.EndTable());
		}

		// Token: 0x060251BD RID: 151997 RVA: 0x0051F9B4 File Offset: 0x0051DBB4
		public IPasserbyNpcMoveBaseT UnPack()
		{
			IPasserbyNpcMoveBaseT passerbyNpcMoveBaseT = new IPasserbyNpcMoveBaseT();
			this.UnPackTo(passerbyNpcMoveBaseT);
			return passerbyNpcMoveBaseT;
		}

		// Token: 0x060251BE RID: 151998 RVA: 0x0051F9CF File Offset: 0x0051DBCF
		public void UnPackTo(IPasserbyNpcMoveBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060251BF RID: 151999 RVA: 0x0051F9E0 File Offset: 0x0051DBE0
		public static Offset<IPasserbyNpcMoveBase> Pack(FlatBufferBuilder builder, IPasserbyNpcMoveBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPasserbyNpcMoveBase>);
			}
			return IPasserbyNpcMoveBase.CreateIPasserbyNpcMoveBase(builder, _o.Type);
		}

		// Token: 0x0400EAFE RID: 60158
		private Table __p;
	}
}
