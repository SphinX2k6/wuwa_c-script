using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004506 RID: 17670
	public struct ILevelPlayMark : IFlatbufferObject
	{
		// Token: 0x17007D46 RID: 32070
		// (get) Token: 0x0601A8AF RID: 108719 RVA: 0x003CA689 File Offset: 0x003C8889
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A8B0 RID: 108720 RVA: 0x003CA696 File Offset: 0x003C8896
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A8B1 RID: 108721 RVA: 0x003CA6A0 File Offset: 0x003C88A0
		public static ILevelPlayMark GetRootAsILevelPlayMark(ByteBuffer _bb)
		{
			return ILevelPlayMark.GetRootAsILevelPlayMark(_bb, default(ILevelPlayMark));
		}

		// Token: 0x0601A8B2 RID: 108722 RVA: 0x003CA6BC File Offset: 0x003C88BC
		public static ILevelPlayMark GetRootAsILevelPlayMark(ByteBuffer _bb, ILevelPlayMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A8B3 RID: 108723 RVA: 0x003CA6D9 File Offset: 0x003C88D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A8B4 RID: 108724 RVA: 0x003CA6E8 File Offset: 0x003C88E8
		public ILevelPlayMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007D47 RID: 32071
		// (get) Token: 0x0601A8B5 RID: 108725 RVA: 0x003CA6F8 File Offset: 0x003C88F8
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

		// Token: 0x17007D48 RID: 32072
		// (get) Token: 0x0601A8B6 RID: 108726 RVA: 0x003CA734 File Offset: 0x003C8934
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

		// Token: 0x0601A8B7 RID: 108727 RVA: 0x003CA76B File Offset: 0x003C896B
		public Span<byte> GetMapBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601A8B8 RID: 108728 RVA: 0x003CA77A File Offset: 0x003C897A
		public byte[] GetMapBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601A8B9 RID: 108729 RVA: 0x003CA788 File Offset: 0x003C8988
		public static Offset<ILevelPlayMark> CreateILevelPlayMark(FlatBufferBuilder builder, int MarkId = 0, StringOffset MapBgPathOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ILevelPlayMark.AddMapBgPath(builder, MapBgPathOffset);
			ILevelPlayMark.AddMarkId(builder, MarkId);
			return ILevelPlayMark.EndILevelPlayMark(builder);
		}

		// Token: 0x0601A8BA RID: 108730 RVA: 0x003CA7A5 File Offset: 0x003C89A5
		public static void StartILevelPlayMark(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601A8BB RID: 108731 RVA: 0x003CA7AE File Offset: 0x003C89AE
		public static void AddMarkId(FlatBufferBuilder builder, int markId)
		{
			builder.AddInt(0, markId, 0);
		}

		// Token: 0x0601A8BC RID: 108732 RVA: 0x003CA7B9 File Offset: 0x003C89B9
		public static void AddMapBgPath(FlatBufferBuilder builder, StringOffset mapBgPathOffset)
		{
			builder.AddOffset(1, mapBgPathOffset.Value, 0);
		}

		// Token: 0x0601A8BD RID: 108733 RVA: 0x003CA7C9 File Offset: 0x003C89C9
		public static Offset<ILevelPlayMark> EndILevelPlayMark(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayMark>(builder.EndTable());
		}

		// Token: 0x0601A8BE RID: 108734 RVA: 0x003CA7D8 File Offset: 0x003C89D8
		public ILevelPlayMarkT UnPack()
		{
			ILevelPlayMarkT levelPlayMarkT = new ILevelPlayMarkT();
			this.UnPackTo(levelPlayMarkT);
			return levelPlayMarkT;
		}

		// Token: 0x0601A8BF RID: 108735 RVA: 0x003CA7F3 File Offset: 0x003C89F3
		public void UnPackTo(ILevelPlayMarkT _o)
		{
			_o.MarkId = this.MarkId;
			_o.MapBgPath = this.MapBgPath;
		}

		// Token: 0x0601A8C0 RID: 108736 RVA: 0x003CA810 File Offset: 0x003C8A10
		public static Offset<ILevelPlayMark> Pack(FlatBufferBuilder builder, ILevelPlayMarkT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPlayMark>);
			}
			StringOffset mapBgPathOffset = (_o.MapBgPath == null) ? default(StringOffset) : builder.CreateString(_o.MapBgPath);
			return ILevelPlayMark.CreateILevelPlayMark(builder, _o.MarkId, mapBgPathOffset);
		}

		// Token: 0x0400C56F RID: 50543
		private Table __p;
	}
}
