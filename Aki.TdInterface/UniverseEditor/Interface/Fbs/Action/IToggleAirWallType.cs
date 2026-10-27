using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073EE RID: 29678
	public struct IToggleAirWallType : IFlatbufferObject
	{
		// Token: 0x1700E168 RID: 57704
		// (get) Token: 0x06035E95 RID: 220821 RVA: 0x007564C7 File Offset: 0x007546C7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035E96 RID: 220822 RVA: 0x007564D4 File Offset: 0x007546D4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035E97 RID: 220823 RVA: 0x007564DC File Offset: 0x007546DC
		public static IToggleAirWallType GetRootAsIToggleAirWallType(ByteBuffer _bb)
		{
			return IToggleAirWallType.GetRootAsIToggleAirWallType(_bb, default(IToggleAirWallType));
		}

		// Token: 0x06035E98 RID: 220824 RVA: 0x007564F8 File Offset: 0x007546F8
		public static IToggleAirWallType GetRootAsIToggleAirWallType(ByteBuffer _bb, IToggleAirWallType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035E99 RID: 220825 RVA: 0x00756515 File Offset: 0x00754715
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035E9A RID: 220826 RVA: 0x00756524 File Offset: 0x00754724
		public IToggleAirWallType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E169 RID: 57705
		// (get) Token: 0x06035E9B RID: 220827 RVA: 0x00756534 File Offset: 0x00754734
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

		// Token: 0x06035E9C RID: 220828 RVA: 0x00756570 File Offset: 0x00754770
		public static Offset<IToggleAirWallType> CreateIToggleAirWallType(FlatBufferBuilder builder, EToggleAirWall Type = EToggleAirWall.Open)
		{
			builder.StartTable(1);
			IToggleAirWallType.AddType(builder, Type);
			return IToggleAirWallType.EndIToggleAirWallType(builder);
		}

		// Token: 0x06035E9D RID: 220829 RVA: 0x00756586 File Offset: 0x00754786
		public static void StartIToggleAirWallType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035E9E RID: 220830 RVA: 0x0075658F File Offset: 0x0075478F
		public static void AddType(FlatBufferBuilder builder, EToggleAirWall type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035E9F RID: 220831 RVA: 0x0075659A File Offset: 0x0075479A
		public static Offset<IToggleAirWallType> EndIToggleAirWallType(FlatBufferBuilder builder)
		{
			return new Offset<IToggleAirWallType>(builder.EndTable());
		}

		// Token: 0x06035EA0 RID: 220832 RVA: 0x007565A8 File Offset: 0x007547A8
		public IToggleAirWallTypeT UnPack()
		{
			IToggleAirWallTypeT toggleAirWallTypeT = new IToggleAirWallTypeT();
			this.UnPackTo(toggleAirWallTypeT);
			return toggleAirWallTypeT;
		}

		// Token: 0x06035EA1 RID: 220833 RVA: 0x007565C3 File Offset: 0x007547C3
		public void UnPackTo(IToggleAirWallTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06035EA2 RID: 220834 RVA: 0x007565D4 File Offset: 0x007547D4
		public static Offset<IToggleAirWallType> Pack(FlatBufferBuilder builder, IToggleAirWallTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IToggleAirWallType>);
			}
			return IToggleAirWallType.CreateIToggleAirWallType(builder, _o.Type);
		}

		// Token: 0x04012248 RID: 74312
		private Table __p;
	}
}
