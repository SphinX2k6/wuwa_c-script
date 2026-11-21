using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A9E RID: 27294
	public struct IClosePathLineMove : IFlatbufferObject
	{
		// Token: 0x1700C877 RID: 51319
		// (get) Token: 0x0602ED75 RID: 191861 RVA: 0x0066202C File Offset: 0x0066022C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602ED76 RID: 191862 RVA: 0x00662039 File Offset: 0x00660239
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602ED77 RID: 191863 RVA: 0x00662040 File Offset: 0x00660240
		public static IClosePathLineMove GetRootAsIClosePathLineMove(ByteBuffer _bb)
		{
			return IClosePathLineMove.GetRootAsIClosePathLineMove(_bb, default(IClosePathLineMove));
		}

		// Token: 0x0602ED78 RID: 191864 RVA: 0x0066205C File Offset: 0x0066025C
		public static IClosePathLineMove GetRootAsIClosePathLineMove(ByteBuffer _bb, IClosePathLineMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602ED79 RID: 191865 RVA: 0x00662079 File Offset: 0x00660279
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602ED7A RID: 191866 RVA: 0x00662088 File Offset: 0x00660288
		public IClosePathLineMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C878 RID: 51320
		// (get) Token: 0x0602ED7B RID: 191867 RVA: 0x00662098 File Offset: 0x00660298
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

		// Token: 0x1700C879 RID: 51321
		// (get) Token: 0x0602ED7C RID: 191868 RVA: 0x006620D4 File Offset: 0x006602D4
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

		// Token: 0x1700C87A RID: 51322
		// (get) Token: 0x0602ED7D RID: 191869 RVA: 0x00662114 File Offset: 0x00660314
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

		// Token: 0x0602ED7E RID: 191870 RVA: 0x00662150 File Offset: 0x00660350
		public static Offset<IClosePathLineMove> CreateIClosePathLineMove(FlatBufferBuilder builder, ESplineMovePattern Type = ESplineMovePattern.PathLine, float GravitySwitchAngularVelocity = 0f, byte NullMask = 0)
		{
			builder.StartTable(3);
			IClosePathLineMove.AddGravitySwitchAngularVelocity(builder, GravitySwitchAngularVelocity);
			IClosePathLineMove.AddNullMask(builder, NullMask);
			IClosePathLineMove.AddType(builder, Type);
			return IClosePathLineMove.EndIClosePathLineMove(builder);
		}

		// Token: 0x0602ED7F RID: 191871 RVA: 0x00662174 File Offset: 0x00660374
		public static void StartIClosePathLineMove(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602ED80 RID: 191872 RVA: 0x0066217D File Offset: 0x0066037D
		public static void AddType(FlatBufferBuilder builder, ESplineMovePattern type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602ED81 RID: 191873 RVA: 0x00662188 File Offset: 0x00660388
		public static void AddGravitySwitchAngularVelocity(FlatBufferBuilder builder, float gravitySwitchAngularVelocity)
		{
			builder.AddFloat(1, gravitySwitchAngularVelocity, 0.0);
		}

		// Token: 0x0602ED82 RID: 191874 RVA: 0x0066219B File Offset: 0x0066039B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602ED83 RID: 191875 RVA: 0x006621A6 File Offset: 0x006603A6
		public static Offset<IClosePathLineMove> EndIClosePathLineMove(FlatBufferBuilder builder)
		{
			return new Offset<IClosePathLineMove>(builder.EndTable());
		}

		// Token: 0x0602ED84 RID: 191876 RVA: 0x006621B4 File Offset: 0x006603B4
		public IClosePathLineMoveT UnPack()
		{
			IClosePathLineMoveT closePathLineMoveT = new IClosePathLineMoveT();
			this.UnPackTo(closePathLineMoveT);
			return closePathLineMoveT;
		}

		// Token: 0x0602ED85 RID: 191877 RVA: 0x006621CF File Offset: 0x006603CF
		public void UnPackTo(IClosePathLineMoveT _o)
		{
			_o.Type = this.Type;
			_o.GravitySwitchAngularVelocity = this.GravitySwitchAngularVelocity;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602ED86 RID: 191878 RVA: 0x006621F8 File Offset: 0x006603F8
		public static Offset<IClosePathLineMove> Pack(FlatBufferBuilder builder, IClosePathLineMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClosePathLineMove>);
			}
			return IClosePathLineMove.CreateIClosePathLineMove(builder, _o.Type, _o.GravitySwitchAngularVelocity, _o.NullMask);
		}

		// Token: 0x04011836 RID: 71734
		private Table __p;
	}
}
