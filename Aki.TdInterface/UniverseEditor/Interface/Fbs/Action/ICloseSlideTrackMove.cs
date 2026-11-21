using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AA7 RID: 27303
	public struct ICloseSlideTrackMove : IFlatbufferObject
	{
		// Token: 0x1700C88A RID: 51338
		// (get) Token: 0x0602EDC6 RID: 191942 RVA: 0x006629F8 File Offset: 0x00660BF8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EDC7 RID: 191943 RVA: 0x00662A05 File Offset: 0x00660C05
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EDC8 RID: 191944 RVA: 0x00662A0C File Offset: 0x00660C0C
		public static ICloseSlideTrackMove GetRootAsICloseSlideTrackMove(ByteBuffer _bb)
		{
			return ICloseSlideTrackMove.GetRootAsICloseSlideTrackMove(_bb, default(ICloseSlideTrackMove));
		}

		// Token: 0x0602EDC9 RID: 191945 RVA: 0x00662A28 File Offset: 0x00660C28
		public static ICloseSlideTrackMove GetRootAsICloseSlideTrackMove(ByteBuffer _bb, ICloseSlideTrackMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EDCA RID: 191946 RVA: 0x00662A45 File Offset: 0x00660C45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EDCB RID: 191947 RVA: 0x00662A54 File Offset: 0x00660C54
		public ICloseSlideTrackMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C88B RID: 51339
		// (get) Token: 0x0602EDCC RID: 191948 RVA: 0x00662A64 File Offset: 0x00660C64
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

		// Token: 0x1700C88C RID: 51340
		// (get) Token: 0x0602EDCD RID: 191949 RVA: 0x00662AA0 File Offset: 0x00660CA0
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

		// Token: 0x1700C88D RID: 51341
		// (get) Token: 0x0602EDCE RID: 191950 RVA: 0x00662AE0 File Offset: 0x00660CE0
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

		// Token: 0x0602EDCF RID: 191951 RVA: 0x00662B1C File Offset: 0x00660D1C
		public static Offset<ICloseSlideTrackMove> CreateICloseSlideTrackMove(FlatBufferBuilder builder, ESplineMovePattern Type = ESplineMovePattern.PathLine, float GravitySwitchAngularVelocity = 0f, byte NullMask = 0)
		{
			builder.StartTable(3);
			ICloseSlideTrackMove.AddGravitySwitchAngularVelocity(builder, GravitySwitchAngularVelocity);
			ICloseSlideTrackMove.AddNullMask(builder, NullMask);
			ICloseSlideTrackMove.AddType(builder, Type);
			return ICloseSlideTrackMove.EndICloseSlideTrackMove(builder);
		}

		// Token: 0x0602EDD0 RID: 191952 RVA: 0x00662B40 File Offset: 0x00660D40
		public static void StartICloseSlideTrackMove(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602EDD1 RID: 191953 RVA: 0x00662B49 File Offset: 0x00660D49
		public static void AddType(FlatBufferBuilder builder, ESplineMovePattern type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EDD2 RID: 191954 RVA: 0x00662B54 File Offset: 0x00660D54
		public static void AddGravitySwitchAngularVelocity(FlatBufferBuilder builder, float gravitySwitchAngularVelocity)
		{
			builder.AddFloat(1, gravitySwitchAngularVelocity, 0.0);
		}

		// Token: 0x0602EDD3 RID: 191955 RVA: 0x00662B67 File Offset: 0x00660D67
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602EDD4 RID: 191956 RVA: 0x00662B72 File Offset: 0x00660D72
		public static Offset<ICloseSlideTrackMove> EndICloseSlideTrackMove(FlatBufferBuilder builder)
		{
			return new Offset<ICloseSlideTrackMove>(builder.EndTable());
		}

		// Token: 0x0602EDD5 RID: 191957 RVA: 0x00662B80 File Offset: 0x00660D80
		public ICloseSlideTrackMoveT UnPack()
		{
			ICloseSlideTrackMoveT closeSlideTrackMoveT = new ICloseSlideTrackMoveT();
			this.UnPackTo(closeSlideTrackMoveT);
			return closeSlideTrackMoveT;
		}

		// Token: 0x0602EDD6 RID: 191958 RVA: 0x00662B9B File Offset: 0x00660D9B
		public void UnPackTo(ICloseSlideTrackMoveT _o)
		{
			_o.Type = this.Type;
			_o.GravitySwitchAngularVelocity = this.GravitySwitchAngularVelocity;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602EDD7 RID: 191959 RVA: 0x00662BC4 File Offset: 0x00660DC4
		public static Offset<ICloseSlideTrackMove> Pack(FlatBufferBuilder builder, ICloseSlideTrackMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICloseSlideTrackMove>);
			}
			return ICloseSlideTrackMove.CreateICloseSlideTrackMove(builder, _o.Type, _o.GravitySwitchAngularVelocity, _o.NullMask);
		}

		// Token: 0x04011841 RID: 71745
		private Table __p;
	}
}
