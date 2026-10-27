using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006412 RID: 25618
	public struct ICloseAirWall : IFlatbufferObject
	{
		// Token: 0x1700BEC3 RID: 48835
		// (get) Token: 0x0602C53B RID: 181563 RVA: 0x00615750 File Offset: 0x00613950
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C53C RID: 181564 RVA: 0x0061575D File Offset: 0x0061395D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C53D RID: 181565 RVA: 0x00615764 File Offset: 0x00613964
		public static ICloseAirWall GetRootAsICloseAirWall(ByteBuffer _bb)
		{
			return ICloseAirWall.GetRootAsICloseAirWall(_bb, default(ICloseAirWall));
		}

		// Token: 0x0602C53E RID: 181566 RVA: 0x00615780 File Offset: 0x00613980
		public static ICloseAirWall GetRootAsICloseAirWall(ByteBuffer _bb, ICloseAirWall obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C53F RID: 181567 RVA: 0x0061579D File Offset: 0x0061399D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C540 RID: 181568 RVA: 0x006157AC File Offset: 0x006139AC
		public ICloseAirWall __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BEC4 RID: 48836
		// (get) Token: 0x0602C541 RID: 181569 RVA: 0x006157BC File Offset: 0x006139BC
		public EToggleAirWall Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EToggleAirWall.Open;
				}
				return (EToggleAirWall)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C542 RID: 181570 RVA: 0x006157F8 File Offset: 0x006139F8
		public static Offset<ICloseAirWall> CreateICloseAirWall(FlatBufferBuilder builder, EToggleAirWall Type = EToggleAirWall.Open)
		{
			builder.StartTable(1);
			ICloseAirWall.AddType(builder, Type);
			return ICloseAirWall.EndICloseAirWall(builder);
		}

		// Token: 0x0602C543 RID: 181571 RVA: 0x0061580E File Offset: 0x00613A0E
		public static void StartICloseAirWall(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602C544 RID: 181572 RVA: 0x00615817 File Offset: 0x00613A17
		public static void AddType(FlatBufferBuilder builder, EToggleAirWall type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C545 RID: 181573 RVA: 0x00615822 File Offset: 0x00613A22
		public static Offset<ICloseAirWall> EndICloseAirWall(FlatBufferBuilder builder)
		{
			return new Offset<ICloseAirWall>(builder.EndTable());
		}

		// Token: 0x0602C546 RID: 181574 RVA: 0x00615830 File Offset: 0x00613A30
		public ICloseAirWallT UnPack()
		{
			ICloseAirWallT closeAirWallT = new ICloseAirWallT();
			this.UnPackTo(closeAirWallT);
			return closeAirWallT;
		}

		// Token: 0x0602C547 RID: 181575 RVA: 0x0061584B File Offset: 0x00613A4B
		public void UnPackTo(ICloseAirWallT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602C548 RID: 181576 RVA: 0x0061585C File Offset: 0x00613A5C
		public static Offset<ICloseAirWall> Pack(FlatBufferBuilder builder, ICloseAirWallT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICloseAirWall>);
			}
			return ICloseAirWall.CreateICloseAirWall(builder, _o.Type);
		}

		// Token: 0x04010A01 RID: 68097
		private Table __p;
	}
}
