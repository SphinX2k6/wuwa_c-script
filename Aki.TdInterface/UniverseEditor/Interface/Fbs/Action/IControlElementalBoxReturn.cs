using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B39 RID: 27449
	public struct IControlElementalBoxReturn : IFlatbufferObject
	{
		// Token: 0x1700C99A RID: 51610
		// (get) Token: 0x0602F3C2 RID: 193474 RVA: 0x00673225 File Offset: 0x00671425
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F3C3 RID: 193475 RVA: 0x00673232 File Offset: 0x00671432
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F3C4 RID: 193476 RVA: 0x0067323C File Offset: 0x0067143C
		public static IControlElementalBoxReturn GetRootAsIControlElementalBoxReturn(ByteBuffer _bb)
		{
			return IControlElementalBoxReturn.GetRootAsIControlElementalBoxReturn(_bb, default(IControlElementalBoxReturn));
		}

		// Token: 0x0602F3C5 RID: 193477 RVA: 0x00673258 File Offset: 0x00671458
		public static IControlElementalBoxReturn GetRootAsIControlElementalBoxReturn(ByteBuffer _bb, IControlElementalBoxReturn obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F3C6 RID: 193478 RVA: 0x00673275 File Offset: 0x00671475
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F3C7 RID: 193479 RVA: 0x00673284 File Offset: 0x00671484
		public IControlElementalBoxReturn __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C99B RID: 51611
		// (get) Token: 0x0602F3C8 RID: 193480 RVA: 0x00673294 File Offset: 0x00671494
		public EControlElementalBoxType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EControlElementalBoxType.Capture;
				}
				return (EControlElementalBoxType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C99C RID: 51612
		// (get) Token: 0x0602F3C9 RID: 193481 RVA: 0x006732D0 File Offset: 0x006714D0
		public string ReturnBeforeMoveSeq
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F3CA RID: 193482 RVA: 0x00673307 File Offset: 0x00671507
		public Span<byte> GetReturnBeforeMoveSeqBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602F3CB RID: 193483 RVA: 0x00673316 File Offset: 0x00671516
		public byte[] GetReturnBeforeMoveSeqArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602F3CC RID: 193484 RVA: 0x00673324 File Offset: 0x00671524
		public static Offset<IControlElementalBoxReturn> CreateIControlElementalBoxReturn(FlatBufferBuilder builder, EControlElementalBoxType Type = EControlElementalBoxType.Capture, StringOffset ReturnBeforeMoveSeqOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IControlElementalBoxReturn.AddReturnBeforeMoveSeq(builder, ReturnBeforeMoveSeqOffset);
			IControlElementalBoxReturn.AddType(builder, Type);
			return IControlElementalBoxReturn.EndIControlElementalBoxReturn(builder);
		}

		// Token: 0x0602F3CD RID: 193485 RVA: 0x00673341 File Offset: 0x00671541
		public static void StartIControlElementalBoxReturn(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F3CE RID: 193486 RVA: 0x0067334A File Offset: 0x0067154A
		public static void AddType(FlatBufferBuilder builder, EControlElementalBoxType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F3CF RID: 193487 RVA: 0x00673355 File Offset: 0x00671555
		public static void AddReturnBeforeMoveSeq(FlatBufferBuilder builder, StringOffset returnBeforeMoveSeqOffset)
		{
			builder.AddOffset(1, returnBeforeMoveSeqOffset.Value, 0);
		}

		// Token: 0x0602F3D0 RID: 193488 RVA: 0x00673365 File Offset: 0x00671565
		public static Offset<IControlElementalBoxReturn> EndIControlElementalBoxReturn(FlatBufferBuilder builder)
		{
			return new Offset<IControlElementalBoxReturn>(builder.EndTable());
		}

		// Token: 0x0602F3D1 RID: 193489 RVA: 0x00673374 File Offset: 0x00671574
		public IControlElementalBoxReturnT UnPack()
		{
			IControlElementalBoxReturnT controlElementalBoxReturnT = new IControlElementalBoxReturnT();
			this.UnPackTo(controlElementalBoxReturnT);
			return controlElementalBoxReturnT;
		}

		// Token: 0x0602F3D2 RID: 193490 RVA: 0x0067338F File Offset: 0x0067158F
		public void UnPackTo(IControlElementalBoxReturnT _o)
		{
			_o.Type = this.Type;
			_o.ReturnBeforeMoveSeq = this.ReturnBeforeMoveSeq;
		}

		// Token: 0x0602F3D3 RID: 193491 RVA: 0x006733AC File Offset: 0x006715AC
		public static Offset<IControlElementalBoxReturn> Pack(FlatBufferBuilder builder, IControlElementalBoxReturnT _o)
		{
			if (_o == null)
			{
				return default(Offset<IControlElementalBoxReturn>);
			}
			StringOffset returnBeforeMoveSeqOffset = (_o.ReturnBeforeMoveSeq == null) ? default(StringOffset) : builder.CreateString(_o.ReturnBeforeMoveSeq);
			return IControlElementalBoxReturn.CreateIControlElementalBoxReturn(builder, _o.Type, returnBeforeMoveSeqOffset);
		}

		// Token: 0x0401191C RID: 71964
		private Table __p;
	}
}
