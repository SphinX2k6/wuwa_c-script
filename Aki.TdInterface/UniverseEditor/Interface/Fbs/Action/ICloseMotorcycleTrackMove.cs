using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A9B RID: 27291
	public struct ICloseMotorcycleTrackMove : IFlatbufferObject
	{
		// Token: 0x1700C870 RID: 51312
		// (get) Token: 0x0602ED5B RID: 191835 RVA: 0x00661D8C File Offset: 0x0065FF8C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602ED5C RID: 191836 RVA: 0x00661D99 File Offset: 0x0065FF99
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602ED5D RID: 191837 RVA: 0x00661DA0 File Offset: 0x0065FFA0
		public static ICloseMotorcycleTrackMove GetRootAsICloseMotorcycleTrackMove(ByteBuffer _bb)
		{
			return ICloseMotorcycleTrackMove.GetRootAsICloseMotorcycleTrackMove(_bb, default(ICloseMotorcycleTrackMove));
		}

		// Token: 0x0602ED5E RID: 191838 RVA: 0x00661DBC File Offset: 0x0065FFBC
		public static ICloseMotorcycleTrackMove GetRootAsICloseMotorcycleTrackMove(ByteBuffer _bb, ICloseMotorcycleTrackMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602ED5F RID: 191839 RVA: 0x00661DD9 File Offset: 0x0065FFD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602ED60 RID: 191840 RVA: 0x00661DE8 File Offset: 0x0065FFE8
		public ICloseMotorcycleTrackMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C871 RID: 51313
		// (get) Token: 0x0602ED61 RID: 191841 RVA: 0x00661DF8 File Offset: 0x0065FFF8
		public ESplineMovePattern Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESplineMovePattern.PathLine;
				}
				return (ESplineMovePattern)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C872 RID: 51314
		// (get) Token: 0x0602ED62 RID: 191842 RVA: 0x00661E34 File Offset: 0x00660034
		public float GravitySwitchAngularVelocity
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C873 RID: 51315
		// (get) Token: 0x0602ED63 RID: 191843 RVA: 0x00661E74 File Offset: 0x00660074
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602ED64 RID: 191844 RVA: 0x00661EB0 File Offset: 0x006600B0
		public static Offset<ICloseMotorcycleTrackMove> CreateICloseMotorcycleTrackMove(FlatBufferBuilder builder, ESplineMovePattern Type = ESplineMovePattern.PathLine, float GravitySwitchAngularVelocity = 0f, byte NullMask = 0)
		{
			builder.StartTable(3);
			ICloseMotorcycleTrackMove.AddGravitySwitchAngularVelocity(builder, GravitySwitchAngularVelocity);
			ICloseMotorcycleTrackMove.AddNullMask(builder, NullMask);
			ICloseMotorcycleTrackMove.AddType(builder, Type);
			return ICloseMotorcycleTrackMove.EndICloseMotorcycleTrackMove(builder);
		}

		// Token: 0x0602ED65 RID: 191845 RVA: 0x00661ED4 File Offset: 0x006600D4
		public static void StartICloseMotorcycleTrackMove(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602ED66 RID: 191846 RVA: 0x00661EDD File Offset: 0x006600DD
		public static void AddType(FlatBufferBuilder builder, ESplineMovePattern type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602ED67 RID: 191847 RVA: 0x00661EE8 File Offset: 0x006600E8
		public static void AddGravitySwitchAngularVelocity(FlatBufferBuilder builder, float gravitySwitchAngularVelocity)
		{
			builder.AddFloat(1, gravitySwitchAngularVelocity, 0.0);
		}

		// Token: 0x0602ED68 RID: 191848 RVA: 0x00661EFB File Offset: 0x006600FB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602ED69 RID: 191849 RVA: 0x00661F06 File Offset: 0x00660106
		public static Offset<ICloseMotorcycleTrackMove> EndICloseMotorcycleTrackMove(FlatBufferBuilder builder)
		{
			return new Offset<ICloseMotorcycleTrackMove>(builder.EndTable());
		}

		// Token: 0x0602ED6A RID: 191850 RVA: 0x00661F14 File Offset: 0x00660114
		public ICloseMotorcycleTrackMoveT UnPack()
		{
			ICloseMotorcycleTrackMoveT closeMotorcycleTrackMoveT = new ICloseMotorcycleTrackMoveT();
			this.UnPackTo(closeMotorcycleTrackMoveT);
			return closeMotorcycleTrackMoveT;
		}

		// Token: 0x0602ED6B RID: 191851 RVA: 0x00661F2F File Offset: 0x0066012F
		public void UnPackTo(ICloseMotorcycleTrackMoveT _o)
		{
			_o.Type = this.Type;
			_o.GravitySwitchAngularVelocity = this.GravitySwitchAngularVelocity;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602ED6C RID: 191852 RVA: 0x00661F58 File Offset: 0x00660158
		public static Offset<ICloseMotorcycleTrackMove> Pack(FlatBufferBuilder builder, ICloseMotorcycleTrackMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICloseMotorcycleTrackMove>);
			}
			return ICloseMotorcycleTrackMove.CreateICloseMotorcycleTrackMove(builder, _o.Type, _o.GravitySwitchAngularVelocity, _o.NullMask);
		}

		// Token: 0x04011832 RID: 71730
		private Table __p;
	}
}
