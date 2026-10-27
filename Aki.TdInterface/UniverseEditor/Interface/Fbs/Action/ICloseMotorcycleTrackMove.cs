using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006421 RID: 25633
	public struct ICloseMotorcycleTrackMove : IFlatbufferObject
	{
		// Token: 0x1700BEDE RID: 48862
		// (get) Token: 0x0602C5AD RID: 181677 RVA: 0x00616278 File Offset: 0x00614478
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C5AE RID: 181678 RVA: 0x00616285 File Offset: 0x00614485
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C5AF RID: 181679 RVA: 0x0061628C File Offset: 0x0061448C
		public static ICloseMotorcycleTrackMove GetRootAsICloseMotorcycleTrackMove(ByteBuffer _bb)
		{
			return ICloseMotorcycleTrackMove.GetRootAsICloseMotorcycleTrackMove(_bb, default(ICloseMotorcycleTrackMove));
		}

		// Token: 0x0602C5B0 RID: 181680 RVA: 0x006162A8 File Offset: 0x006144A8
		public static ICloseMotorcycleTrackMove GetRootAsICloseMotorcycleTrackMove(ByteBuffer _bb, ICloseMotorcycleTrackMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C5B1 RID: 181681 RVA: 0x006162C5 File Offset: 0x006144C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C5B2 RID: 181682 RVA: 0x006162D4 File Offset: 0x006144D4
		public ICloseMotorcycleTrackMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BEDF RID: 48863
		// (get) Token: 0x0602C5B3 RID: 181683 RVA: 0x006162E4 File Offset: 0x006144E4
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

		// Token: 0x1700BEE0 RID: 48864
		// (get) Token: 0x0602C5B4 RID: 181684 RVA: 0x00616320 File Offset: 0x00614520
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

		// Token: 0x1700BEE1 RID: 48865
		// (get) Token: 0x0602C5B5 RID: 181685 RVA: 0x00616360 File Offset: 0x00614560
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

		// Token: 0x0602C5B6 RID: 181686 RVA: 0x0061639C File Offset: 0x0061459C
		public static Offset<ICloseMotorcycleTrackMove> CreateICloseMotorcycleTrackMove(FlatBufferBuilder builder, ESplineMovePattern Type = ESplineMovePattern.PathLine, float GravitySwitchAngularVelocity = 0f, byte NullMask = 0)
		{
			builder.StartTable(3);
			ICloseMotorcycleTrackMove.AddGravitySwitchAngularVelocity(builder, GravitySwitchAngularVelocity);
			ICloseMotorcycleTrackMove.AddNullMask(builder, NullMask);
			ICloseMotorcycleTrackMove.AddType(builder, Type);
			return ICloseMotorcycleTrackMove.EndICloseMotorcycleTrackMove(builder);
		}

		// Token: 0x0602C5B7 RID: 181687 RVA: 0x006163C0 File Offset: 0x006145C0
		public static void StartICloseMotorcycleTrackMove(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602C5B8 RID: 181688 RVA: 0x006163C9 File Offset: 0x006145C9
		public static void AddType(FlatBufferBuilder builder, ESplineMovePattern type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C5B9 RID: 181689 RVA: 0x006163D4 File Offset: 0x006145D4
		public static void AddGravitySwitchAngularVelocity(FlatBufferBuilder builder, float gravitySwitchAngularVelocity)
		{
			builder.AddFloat(1, gravitySwitchAngularVelocity, 0.0);
		}

		// Token: 0x0602C5BA RID: 181690 RVA: 0x006163E7 File Offset: 0x006145E7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602C5BB RID: 181691 RVA: 0x006163F2 File Offset: 0x006145F2
		public static Offset<ICloseMotorcycleTrackMove> EndICloseMotorcycleTrackMove(FlatBufferBuilder builder)
		{
			return new Offset<ICloseMotorcycleTrackMove>(builder.EndTable());
		}

		// Token: 0x0602C5BC RID: 181692 RVA: 0x00616400 File Offset: 0x00614600
		public ICloseMotorcycleTrackMoveT UnPack()
		{
			ICloseMotorcycleTrackMoveT closeMotorcycleTrackMoveT = new ICloseMotorcycleTrackMoveT();
			this.UnPackTo(closeMotorcycleTrackMoveT);
			return closeMotorcycleTrackMoveT;
		}

		// Token: 0x0602C5BD RID: 181693 RVA: 0x0061641B File Offset: 0x0061461B
		public void UnPackTo(ICloseMotorcycleTrackMoveT _o)
		{
			_o.Type = this.Type;
			_o.GravitySwitchAngularVelocity = this.GravitySwitchAngularVelocity;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602C5BE RID: 181694 RVA: 0x00616444 File Offset: 0x00614644
		public static Offset<ICloseMotorcycleTrackMove> Pack(FlatBufferBuilder builder, ICloseMotorcycleTrackMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICloseMotorcycleTrackMove>);
			}
			return ICloseMotorcycleTrackMove.CreateICloseMotorcycleTrackMove(builder, _o.Type, _o.GravitySwitchAngularVelocity, _o.NullMask);
		}

		// Token: 0x04010A11 RID: 68113
		private Table __p;
	}
}
