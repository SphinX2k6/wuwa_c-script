using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A92 RID: 27282
	public struct ICloseAirWall : IFlatbufferObject
	{
		// Token: 0x1700C85D RID: 51293
		// (get) Token: 0x0602ED11 RID: 191761 RVA: 0x006615DC File Offset: 0x0065F7DC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602ED12 RID: 191762 RVA: 0x006615E9 File Offset: 0x0065F7E9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602ED13 RID: 191763 RVA: 0x006615F0 File Offset: 0x0065F7F0
		public static ICloseAirWall GetRootAsICloseAirWall(ByteBuffer _bb)
		{
			return ICloseAirWall.GetRootAsICloseAirWall(_bb, default(ICloseAirWall));
		}

		// Token: 0x0602ED14 RID: 191764 RVA: 0x0066160C File Offset: 0x0065F80C
		public static ICloseAirWall GetRootAsICloseAirWall(ByteBuffer _bb, ICloseAirWall obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602ED15 RID: 191765 RVA: 0x00661629 File Offset: 0x0065F829
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602ED16 RID: 191766 RVA: 0x00661638 File Offset: 0x0065F838
		public ICloseAirWall __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C85E RID: 51294
		// (get) Token: 0x0602ED17 RID: 191767 RVA: 0x00661648 File Offset: 0x0065F848
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

		// Token: 0x0602ED18 RID: 191768 RVA: 0x00661684 File Offset: 0x0065F884
		public static Offset<ICloseAirWall> CreateICloseAirWall(FlatBufferBuilder builder, EToggleAirWall Type = EToggleAirWall.Open)
		{
			builder.StartTable(1);
			ICloseAirWall.AddType(builder, Type);
			return ICloseAirWall.EndICloseAirWall(builder);
		}

		// Token: 0x0602ED19 RID: 191769 RVA: 0x0066169A File Offset: 0x0065F89A
		public static void StartICloseAirWall(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602ED1A RID: 191770 RVA: 0x006616A3 File Offset: 0x0065F8A3
		public static void AddType(FlatBufferBuilder builder, EToggleAirWall type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602ED1B RID: 191771 RVA: 0x006616AE File Offset: 0x0065F8AE
		public static Offset<ICloseAirWall> EndICloseAirWall(FlatBufferBuilder builder)
		{
			return new Offset<ICloseAirWall>(builder.EndTable());
		}

		// Token: 0x0602ED1C RID: 191772 RVA: 0x006616BC File Offset: 0x0065F8BC
		public ICloseAirWallT UnPack()
		{
			ICloseAirWallT closeAirWallT = new ICloseAirWallT();
			this.UnPackTo(closeAirWallT);
			return closeAirWallT;
		}

		// Token: 0x0602ED1D RID: 191773 RVA: 0x006616D7 File Offset: 0x0065F8D7
		public void UnPackTo(ICloseAirWallT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602ED1E RID: 191774 RVA: 0x006616E8 File Offset: 0x0065F8E8
		public static Offset<ICloseAirWall> Pack(FlatBufferBuilder builder, ICloseAirWallT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICloseAirWall>);
			}
			return ICloseAirWall.CreateICloseAirWall(builder, _o.Type);
		}

		// Token: 0x04011827 RID: 71719
		private Table __p;
	}
}
