using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006427 RID: 25639
	public struct ICloseRacingTrackMove : IFlatbufferObject
	{
		// Token: 0x1700BEEC RID: 48876
		// (get) Token: 0x0602C5E1 RID: 181729 RVA: 0x006167B8 File Offset: 0x006149B8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C5E2 RID: 181730 RVA: 0x006167C5 File Offset: 0x006149C5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C5E3 RID: 181731 RVA: 0x006167CC File Offset: 0x006149CC
		public static ICloseRacingTrackMove GetRootAsICloseRacingTrackMove(ByteBuffer _bb)
		{
			return ICloseRacingTrackMove.GetRootAsICloseRacingTrackMove(_bb, default(ICloseRacingTrackMove));
		}

		// Token: 0x0602C5E4 RID: 181732 RVA: 0x006167E8 File Offset: 0x006149E8
		public static ICloseRacingTrackMove GetRootAsICloseRacingTrackMove(ByteBuffer _bb, ICloseRacingTrackMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C5E5 RID: 181733 RVA: 0x00616805 File Offset: 0x00614A05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C5E6 RID: 181734 RVA: 0x00616814 File Offset: 0x00614A14
		public ICloseRacingTrackMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BEED RID: 48877
		// (get) Token: 0x0602C5E7 RID: 181735 RVA: 0x00616824 File Offset: 0x00614A24
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

		// Token: 0x1700BEEE RID: 48878
		// (get) Token: 0x0602C5E8 RID: 181736 RVA: 0x00616860 File Offset: 0x00614A60
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

		// Token: 0x1700BEEF RID: 48879
		// (get) Token: 0x0602C5E9 RID: 181737 RVA: 0x006168A0 File Offset: 0x00614AA0
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

		// Token: 0x0602C5EA RID: 181738 RVA: 0x006168DC File Offset: 0x00614ADC
		public static Offset<ICloseRacingTrackMove> CreateICloseRacingTrackMove(FlatBufferBuilder builder, ESplineMovePattern Type = ESplineMovePattern.PathLine, float GravitySwitchAngularVelocity = 0f, byte NullMask = 0)
		{
			builder.StartTable(3);
			ICloseRacingTrackMove.AddGravitySwitchAngularVelocity(builder, GravitySwitchAngularVelocity);
			ICloseRacingTrackMove.AddNullMask(builder, NullMask);
			ICloseRacingTrackMove.AddType(builder, Type);
			return ICloseRacingTrackMove.EndICloseRacingTrackMove(builder);
		}

		// Token: 0x0602C5EB RID: 181739 RVA: 0x00616900 File Offset: 0x00614B00
		public static void StartICloseRacingTrackMove(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602C5EC RID: 181740 RVA: 0x00616909 File Offset: 0x00614B09
		public static void AddType(FlatBufferBuilder builder, ESplineMovePattern type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C5ED RID: 181741 RVA: 0x00616914 File Offset: 0x00614B14
		public static void AddGravitySwitchAngularVelocity(FlatBufferBuilder builder, float gravitySwitchAngularVelocity)
		{
			builder.AddFloat(1, gravitySwitchAngularVelocity, 0.0);
		}

		// Token: 0x0602C5EE RID: 181742 RVA: 0x00616927 File Offset: 0x00614B27
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602C5EF RID: 181743 RVA: 0x00616932 File Offset: 0x00614B32
		public static Offset<ICloseRacingTrackMove> EndICloseRacingTrackMove(FlatBufferBuilder builder)
		{
			return new Offset<ICloseRacingTrackMove>(builder.EndTable());
		}

		// Token: 0x0602C5F0 RID: 181744 RVA: 0x00616940 File Offset: 0x00614B40
		public ICloseRacingTrackMoveT UnPack()
		{
			ICloseRacingTrackMoveT closeRacingTrackMoveT = new ICloseRacingTrackMoveT();
			this.UnPackTo(closeRacingTrackMoveT);
			return closeRacingTrackMoveT;
		}

		// Token: 0x0602C5F1 RID: 181745 RVA: 0x0061695B File Offset: 0x00614B5B
		public void UnPackTo(ICloseRacingTrackMoveT _o)
		{
			_o.Type = this.Type;
			_o.GravitySwitchAngularVelocity = this.GravitySwitchAngularVelocity;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602C5F2 RID: 181746 RVA: 0x00616984 File Offset: 0x00614B84
		public static Offset<ICloseRacingTrackMove> Pack(FlatBufferBuilder builder, ICloseRacingTrackMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICloseRacingTrackMove>);
			}
			return ICloseRacingTrackMove.CreateICloseRacingTrackMove(builder, _o.Type, _o.GravitySwitchAngularVelocity, _o.NullMask);
		}

		// Token: 0x04010A19 RID: 68121
		private Table __p;
	}
}
