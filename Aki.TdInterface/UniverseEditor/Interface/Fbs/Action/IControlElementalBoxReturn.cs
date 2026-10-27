using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064CE RID: 25806
	public struct IControlElementalBoxReturn : IFlatbufferObject
	{
		// Token: 0x1700C00D RID: 49165
		// (get) Token: 0x0602CC3E RID: 183358 RVA: 0x006270FD File Offset: 0x006252FD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CC3F RID: 183359 RVA: 0x0062710A File Offset: 0x0062530A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CC40 RID: 183360 RVA: 0x00627114 File Offset: 0x00625314
		public static IControlElementalBoxReturn GetRootAsIControlElementalBoxReturn(ByteBuffer _bb)
		{
			return IControlElementalBoxReturn.GetRootAsIControlElementalBoxReturn(_bb, default(IControlElementalBoxReturn));
		}

		// Token: 0x0602CC41 RID: 183361 RVA: 0x00627130 File Offset: 0x00625330
		public static IControlElementalBoxReturn GetRootAsIControlElementalBoxReturn(ByteBuffer _bb, IControlElementalBoxReturn obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CC42 RID: 183362 RVA: 0x0062714D File Offset: 0x0062534D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CC43 RID: 183363 RVA: 0x0062715C File Offset: 0x0062535C
		public IControlElementalBoxReturn __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C00E RID: 49166
		// (get) Token: 0x0602CC44 RID: 183364 RVA: 0x0062716C File Offset: 0x0062536C
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

		// Token: 0x1700C00F RID: 49167
		// (get) Token: 0x0602CC45 RID: 183365 RVA: 0x006271A8 File Offset: 0x006253A8
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

		// Token: 0x0602CC46 RID: 183366 RVA: 0x006271DF File Offset: 0x006253DF
		public Span<byte> GetReturnBeforeMoveSeqBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602CC47 RID: 183367 RVA: 0x006271EE File Offset: 0x006253EE
		public byte[] GetReturnBeforeMoveSeqArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602CC48 RID: 183368 RVA: 0x006271FC File Offset: 0x006253FC
		public static Offset<IControlElementalBoxReturn> CreateIControlElementalBoxReturn(FlatBufferBuilder builder, EControlElementalBoxType Type = EControlElementalBoxType.Capture, StringOffset ReturnBeforeMoveSeqOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IControlElementalBoxReturn.AddReturnBeforeMoveSeq(builder, ReturnBeforeMoveSeqOffset);
			IControlElementalBoxReturn.AddType(builder, Type);
			return IControlElementalBoxReturn.EndIControlElementalBoxReturn(builder);
		}

		// Token: 0x0602CC49 RID: 183369 RVA: 0x00627219 File Offset: 0x00625419
		public static void StartIControlElementalBoxReturn(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602CC4A RID: 183370 RVA: 0x00627222 File Offset: 0x00625422
		public static void AddType(FlatBufferBuilder builder, EControlElementalBoxType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CC4B RID: 183371 RVA: 0x0062722D File Offset: 0x0062542D
		public static void AddReturnBeforeMoveSeq(FlatBufferBuilder builder, StringOffset returnBeforeMoveSeqOffset)
		{
			builder.AddOffset(1, returnBeforeMoveSeqOffset.Value, 0);
		}

		// Token: 0x0602CC4C RID: 183372 RVA: 0x0062723D File Offset: 0x0062543D
		public static Offset<IControlElementalBoxReturn> EndIControlElementalBoxReturn(FlatBufferBuilder builder)
		{
			return new Offset<IControlElementalBoxReturn>(builder.EndTable());
		}

		// Token: 0x0602CC4D RID: 183373 RVA: 0x0062724C File Offset: 0x0062544C
		public IControlElementalBoxReturnT UnPack()
		{
			IControlElementalBoxReturnT controlElementalBoxReturnT = new IControlElementalBoxReturnT();
			this.UnPackTo(controlElementalBoxReturnT);
			return controlElementalBoxReturnT;
		}

		// Token: 0x0602CC4E RID: 183374 RVA: 0x00627267 File Offset: 0x00625467
		public void UnPackTo(IControlElementalBoxReturnT _o)
		{
			_o.Type = this.Type;
			_o.ReturnBeforeMoveSeq = this.ReturnBeforeMoveSeq;
		}

		// Token: 0x0602CC4F RID: 183375 RVA: 0x00627284 File Offset: 0x00625484
		public static Offset<IControlElementalBoxReturn> Pack(FlatBufferBuilder builder, IControlElementalBoxReturnT _o)
		{
			if (_o == null)
			{
				return default(Offset<IControlElementalBoxReturn>);
			}
			StringOffset returnBeforeMoveSeqOffset = (_o.ReturnBeforeMoveSeq == null) ? default(StringOffset) : builder.CreateString(_o.ReturnBeforeMoveSeq);
			return IControlElementalBoxReturn.CreateIControlElementalBoxReturn(builder, _o.Type, returnBeforeMoveSeqOffset);
		}

		// Token: 0x04010B06 RID: 68358
		private Table __p;
	}
}
