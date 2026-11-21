using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200496E RID: 18798
	public struct ILevelPlayMark : IFlatbufferObject
	{
		// Token: 0x17008387 RID: 33671
		// (get) Token: 0x0601C084 RID: 114820 RVA: 0x003F6925 File Offset: 0x003F4B25
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C085 RID: 114821 RVA: 0x003F6932 File Offset: 0x003F4B32
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C086 RID: 114822 RVA: 0x003F693C File Offset: 0x003F4B3C
		public static ILevelPlayMark GetRootAsILevelPlayMark(ByteBuffer _bb)
		{
			return ILevelPlayMark.GetRootAsILevelPlayMark(_bb, default(ILevelPlayMark));
		}

		// Token: 0x0601C087 RID: 114823 RVA: 0x003F6958 File Offset: 0x003F4B58
		public static ILevelPlayMark GetRootAsILevelPlayMark(ByteBuffer _bb, ILevelPlayMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C088 RID: 114824 RVA: 0x003F6975 File Offset: 0x003F4B75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C089 RID: 114825 RVA: 0x003F6984 File Offset: 0x003F4B84
		public ILevelPlayMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008388 RID: 33672
		// (get) Token: 0x0601C08A RID: 114826 RVA: 0x003F6994 File Offset: 0x003F4B94
		public int MarkId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008389 RID: 33673
		// (get) Token: 0x0601C08B RID: 114827 RVA: 0x003F69D0 File Offset: 0x003F4BD0
		public string MapBgPath
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C08C RID: 114828 RVA: 0x003F6A07 File Offset: 0x003F4C07
		public Span<byte> GetMapBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601C08D RID: 114829 RVA: 0x003F6A16 File Offset: 0x003F4C16
		public byte[] GetMapBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601C08E RID: 114830 RVA: 0x003F6A24 File Offset: 0x003F4C24
		public static Offset<ILevelPlayMark> CreateILevelPlayMark(FlatBufferBuilder builder, int MarkId = 0, StringOffset MapBgPathOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ILevelPlayMark.AddMapBgPath(builder, MapBgPathOffset);
			ILevelPlayMark.AddMarkId(builder, MarkId);
			return ILevelPlayMark.EndILevelPlayMark(builder);
		}

		// Token: 0x0601C08F RID: 114831 RVA: 0x003F6A41 File Offset: 0x003F4C41
		public static void StartILevelPlayMark(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601C090 RID: 114832 RVA: 0x003F6A4A File Offset: 0x003F4C4A
		public static void AddMarkId(FlatBufferBuilder builder, int markId)
		{
			builder.AddInt(0, markId, 0);
		}

		// Token: 0x0601C091 RID: 114833 RVA: 0x003F6A55 File Offset: 0x003F4C55
		public static void AddMapBgPath(FlatBufferBuilder builder, StringOffset mapBgPathOffset)
		{
			builder.AddOffset(1, mapBgPathOffset.Value, 0);
		}

		// Token: 0x0601C092 RID: 114834 RVA: 0x003F6A65 File Offset: 0x003F4C65
		public static Offset<ILevelPlayMark> EndILevelPlayMark(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayMark>(builder.EndTable());
		}

		// Token: 0x0601C093 RID: 114835 RVA: 0x003F6A74 File Offset: 0x003F4C74
		public ILevelPlayMarkT UnPack()
		{
			ILevelPlayMarkT levelPlayMarkT = new ILevelPlayMarkT();
			this.UnPackTo(levelPlayMarkT);
			return levelPlayMarkT;
		}

		// Token: 0x0601C094 RID: 114836 RVA: 0x003F6A8F File Offset: 0x003F4C8F
		public void UnPackTo(ILevelPlayMarkT _o)
		{
			_o.MarkId = this.MarkId;
			_o.MapBgPath = this.MapBgPath;
		}

		// Token: 0x0601C095 RID: 114837 RVA: 0x003F6AAC File Offset: 0x003F4CAC
		public static Offset<ILevelPlayMark> Pack(FlatBufferBuilder builder, ILevelPlayMarkT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPlayMark>);
			}
			StringOffset mapBgPathOffset = (_o.MapBgPath == null) ? default(StringOffset) : builder.CreateString(_o.MapBgPath);
			return ILevelPlayMark.CreateILevelPlayMark(builder, _o.MarkId, mapBgPathOffset);
		}

		// Token: 0x0400CF9E RID: 53150
		private Table __p;
	}
}
