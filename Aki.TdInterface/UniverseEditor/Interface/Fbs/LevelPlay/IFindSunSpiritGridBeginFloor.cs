using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044B5 RID: 17589
	public struct IFindSunSpiritGridBeginFloor : IFlatbufferObject
	{
		// Token: 0x17007C20 RID: 31776
		// (get) Token: 0x0601A45C RID: 107612 RVA: 0x003C09F2 File Offset: 0x003BEBF2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A45D RID: 107613 RVA: 0x003C09FF File Offset: 0x003BEBFF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A45E RID: 107614 RVA: 0x003C0A08 File Offset: 0x003BEC08
		public static IFindSunSpiritGridBeginFloor GetRootAsIFindSunSpiritGridBeginFloor(ByteBuffer _bb)
		{
			return IFindSunSpiritGridBeginFloor.GetRootAsIFindSunSpiritGridBeginFloor(_bb, default(IFindSunSpiritGridBeginFloor));
		}

		// Token: 0x0601A45F RID: 107615 RVA: 0x003C0A24 File Offset: 0x003BEC24
		public static IFindSunSpiritGridBeginFloor GetRootAsIFindSunSpiritGridBeginFloor(ByteBuffer _bb, IFindSunSpiritGridBeginFloor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A460 RID: 107616 RVA: 0x003C0A41 File Offset: 0x003BEC41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A461 RID: 107617 RVA: 0x003C0A50 File Offset: 0x003BEC50
		public IFindSunSpiritGridBeginFloor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007C21 RID: 31777
		// (get) Token: 0x0601A462 RID: 107618 RVA: 0x003C0A60 File Offset: 0x003BEC60
		public EFindSunSpiritGridType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFindSunSpiritGridType.Empty;
				}
				return (EFindSunSpiritGridType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A463 RID: 107619 RVA: 0x003C0A9C File Offset: 0x003BEC9C
		public static Offset<IFindSunSpiritGridBeginFloor> CreateIFindSunSpiritGridBeginFloor(FlatBufferBuilder builder, EFindSunSpiritGridType Type = EFindSunSpiritGridType.Empty)
		{
			builder.StartTable(1);
			IFindSunSpiritGridBeginFloor.AddType(builder, Type);
			return IFindSunSpiritGridBeginFloor.EndIFindSunSpiritGridBeginFloor(builder);
		}

		// Token: 0x0601A464 RID: 107620 RVA: 0x003C0AB2 File Offset: 0x003BECB2
		public static void StartIFindSunSpiritGridBeginFloor(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601A465 RID: 107621 RVA: 0x003C0ABB File Offset: 0x003BECBB
		public static void AddType(FlatBufferBuilder builder, EFindSunSpiritGridType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A466 RID: 107622 RVA: 0x003C0AC6 File Offset: 0x003BECC6
		public static Offset<IFindSunSpiritGridBeginFloor> EndIFindSunSpiritGridBeginFloor(FlatBufferBuilder builder)
		{
			return new Offset<IFindSunSpiritGridBeginFloor>(builder.EndTable());
		}

		// Token: 0x0601A467 RID: 107623 RVA: 0x003C0AD4 File Offset: 0x003BECD4
		public IFindSunSpiritGridBeginFloorT UnPack()
		{
			IFindSunSpiritGridBeginFloorT findSunSpiritGridBeginFloorT = new IFindSunSpiritGridBeginFloorT();
			this.UnPackTo(findSunSpiritGridBeginFloorT);
			return findSunSpiritGridBeginFloorT;
		}

		// Token: 0x0601A468 RID: 107624 RVA: 0x003C0AEF File Offset: 0x003BECEF
		public void UnPackTo(IFindSunSpiritGridBeginFloorT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601A469 RID: 107625 RVA: 0x003C0B00 File Offset: 0x003BED00
		public static Offset<IFindSunSpiritGridBeginFloor> Pack(FlatBufferBuilder builder, IFindSunSpiritGridBeginFloorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFindSunSpiritGridBeginFloor>);
			}
			return IFindSunSpiritGridBeginFloor.CreateIFindSunSpiritGridBeginFloor(builder, _o.Type);
		}

		// Token: 0x0400C4C9 RID: 50377
		private Table __p;
	}
}
