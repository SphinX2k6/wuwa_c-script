using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C53 RID: 31827
	public struct ITrapDefensePlayerOperationRecycleTrap : IFlatbufferObject
	{
		// Token: 0x1700EE45 RID: 60997
		// (get) Token: 0x060395ED RID: 234989 RVA: 0x007BEF95 File Offset: 0x007BD195
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060395EE RID: 234990 RVA: 0x007BEFA2 File Offset: 0x007BD1A2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060395EF RID: 234991 RVA: 0x007BEFAC File Offset: 0x007BD1AC
		public static ITrapDefensePlayerOperationRecycleTrap GetRootAsITrapDefensePlayerOperationRecycleTrap(ByteBuffer _bb)
		{
			return ITrapDefensePlayerOperationRecycleTrap.GetRootAsITrapDefensePlayerOperationRecycleTrap(_bb, default(ITrapDefensePlayerOperationRecycleTrap));
		}

		// Token: 0x060395F0 RID: 234992 RVA: 0x007BEFC8 File Offset: 0x007BD1C8
		public static ITrapDefensePlayerOperationRecycleTrap GetRootAsITrapDefensePlayerOperationRecycleTrap(ByteBuffer _bb, ITrapDefensePlayerOperationRecycleTrap obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060395F1 RID: 234993 RVA: 0x007BEFE5 File Offset: 0x007BD1E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060395F2 RID: 234994 RVA: 0x007BEFF4 File Offset: 0x007BD1F4
		public ITrapDefensePlayerOperationRecycleTrap __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EE46 RID: 60998
		// (get) Token: 0x060395F3 RID: 234995 RVA: 0x007BF004 File Offset: 0x007BD204
		public ETrapDefensePlayerOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETrapDefensePlayerOperationType.SpawnMonster;
				}
				return (ETrapDefensePlayerOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060395F4 RID: 234996 RVA: 0x007BF040 File Offset: 0x007BD240
		public static Offset<ITrapDefensePlayerOperationRecycleTrap> CreateITrapDefensePlayerOperationRecycleTrap(FlatBufferBuilder builder, ETrapDefensePlayerOperationType Type = ETrapDefensePlayerOperationType.SpawnMonster)
		{
			builder.StartTable(1);
			ITrapDefensePlayerOperationRecycleTrap.AddType(builder, Type);
			return ITrapDefensePlayerOperationRecycleTrap.EndITrapDefensePlayerOperationRecycleTrap(builder);
		}

		// Token: 0x060395F5 RID: 234997 RVA: 0x007BF056 File Offset: 0x007BD256
		public static void StartITrapDefensePlayerOperationRecycleTrap(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060395F6 RID: 234998 RVA: 0x007BF05F File Offset: 0x007BD25F
		public static void AddType(FlatBufferBuilder builder, ETrapDefensePlayerOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060395F7 RID: 234999 RVA: 0x007BF06A File Offset: 0x007BD26A
		public static Offset<ITrapDefensePlayerOperationRecycleTrap> EndITrapDefensePlayerOperationRecycleTrap(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefensePlayerOperationRecycleTrap>(builder.EndTable());
		}

		// Token: 0x060395F8 RID: 235000 RVA: 0x007BF078 File Offset: 0x007BD278
		public ITrapDefensePlayerOperationRecycleTrapT UnPack()
		{
			ITrapDefensePlayerOperationRecycleTrapT trapDefensePlayerOperationRecycleTrapT = new ITrapDefensePlayerOperationRecycleTrapT();
			this.UnPackTo(trapDefensePlayerOperationRecycleTrapT);
			return trapDefensePlayerOperationRecycleTrapT;
		}

		// Token: 0x060395F9 RID: 235001 RVA: 0x007BF093 File Offset: 0x007BD293
		public void UnPackTo(ITrapDefensePlayerOperationRecycleTrapT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060395FA RID: 235002 RVA: 0x007BF0A4 File Offset: 0x007BD2A4
		public static Offset<ITrapDefensePlayerOperationRecycleTrap> Pack(FlatBufferBuilder builder, ITrapDefensePlayerOperationRecycleTrapT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrapDefensePlayerOperationRecycleTrap>);
			}
			return ITrapDefensePlayerOperationRecycleTrap.CreateITrapDefensePlayerOperationRecycleTrap(builder, _o.Type);
		}

		// Token: 0x04013310 RID: 78608
		private Table __p;
	}
}
