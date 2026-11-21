using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AA1 RID: 27297
	public struct ICloseRacingTrackMove : IFlatbufferObject
	{
		// Token: 0x1700C87E RID: 51326
		// (get) Token: 0x0602ED8F RID: 191887 RVA: 0x006622CC File Offset: 0x006604CC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602ED90 RID: 191888 RVA: 0x006622D9 File Offset: 0x006604D9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602ED91 RID: 191889 RVA: 0x006622E0 File Offset: 0x006604E0
		public static ICloseRacingTrackMove GetRootAsICloseRacingTrackMove(ByteBuffer _bb)
		{
			return ICloseRacingTrackMove.GetRootAsICloseRacingTrackMove(_bb, default(ICloseRacingTrackMove));
		}

		// Token: 0x0602ED92 RID: 191890 RVA: 0x006622FC File Offset: 0x006604FC
		public static ICloseRacingTrackMove GetRootAsICloseRacingTrackMove(ByteBuffer _bb, ICloseRacingTrackMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602ED93 RID: 191891 RVA: 0x00662319 File Offset: 0x00660519
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602ED94 RID: 191892 RVA: 0x00662328 File Offset: 0x00660528
		public ICloseRacingTrackMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C87F RID: 51327
		// (get) Token: 0x0602ED95 RID: 191893 RVA: 0x00662338 File Offset: 0x00660538
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

		// Token: 0x1700C880 RID: 51328
		// (get) Token: 0x0602ED96 RID: 191894 RVA: 0x00662374 File Offset: 0x00660574
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

		// Token: 0x1700C881 RID: 51329
		// (get) Token: 0x0602ED97 RID: 191895 RVA: 0x006623B4 File Offset: 0x006605B4
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

		// Token: 0x0602ED98 RID: 191896 RVA: 0x006623F0 File Offset: 0x006605F0
		public static Offset<ICloseRacingTrackMove> CreateICloseRacingTrackMove(FlatBufferBuilder builder, ESplineMovePattern Type = ESplineMovePattern.PathLine, float GravitySwitchAngularVelocity = 0f, byte NullMask = 0)
		{
			builder.StartTable(3);
			ICloseRacingTrackMove.AddGravitySwitchAngularVelocity(builder, GravitySwitchAngularVelocity);
			ICloseRacingTrackMove.AddNullMask(builder, NullMask);
			ICloseRacingTrackMove.AddType(builder, Type);
			return ICloseRacingTrackMove.EndICloseRacingTrackMove(builder);
		}

		// Token: 0x0602ED99 RID: 191897 RVA: 0x00662414 File Offset: 0x00660614
		public static void StartICloseRacingTrackMove(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602ED9A RID: 191898 RVA: 0x0066241D File Offset: 0x0066061D
		public static void AddType(FlatBufferBuilder builder, ESplineMovePattern type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602ED9B RID: 191899 RVA: 0x00662428 File Offset: 0x00660628
		public static void AddGravitySwitchAngularVelocity(FlatBufferBuilder builder, float gravitySwitchAngularVelocity)
		{
			builder.AddFloat(1, gravitySwitchAngularVelocity, 0.0);
		}

		// Token: 0x0602ED9C RID: 191900 RVA: 0x0066243B File Offset: 0x0066063B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602ED9D RID: 191901 RVA: 0x00662446 File Offset: 0x00660646
		public static Offset<ICloseRacingTrackMove> EndICloseRacingTrackMove(FlatBufferBuilder builder)
		{
			return new Offset<ICloseRacingTrackMove>(builder.EndTable());
		}

		// Token: 0x0602ED9E RID: 191902 RVA: 0x00662454 File Offset: 0x00660654
		public ICloseRacingTrackMoveT UnPack()
		{
			ICloseRacingTrackMoveT closeRacingTrackMoveT = new ICloseRacingTrackMoveT();
			this.UnPackTo(closeRacingTrackMoveT);
			return closeRacingTrackMoveT;
		}

		// Token: 0x0602ED9F RID: 191903 RVA: 0x0066246F File Offset: 0x0066066F
		public void UnPackTo(ICloseRacingTrackMoveT _o)
		{
			_o.Type = this.Type;
			_o.GravitySwitchAngularVelocity = this.GravitySwitchAngularVelocity;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602EDA0 RID: 191904 RVA: 0x00662498 File Offset: 0x00660698
		public static Offset<ICloseRacingTrackMove> Pack(FlatBufferBuilder builder, ICloseRacingTrackMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICloseRacingTrackMove>);
			}
			return ICloseRacingTrackMove.CreateICloseRacingTrackMove(builder, _o.Type, _o.GravitySwitchAngularVelocity, _o.NullMask);
		}

		// Token: 0x0401183A RID: 71738
		private Table __p;
	}
}
