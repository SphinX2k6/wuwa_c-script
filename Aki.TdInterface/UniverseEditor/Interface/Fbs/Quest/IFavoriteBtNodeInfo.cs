using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004265 RID: 16997
	public struct IFavoriteBtNodeInfo : IFlatbufferObject
	{
		// Token: 0x170073ED RID: 29677
		// (get) Token: 0x06017AF8 RID: 97016 RVA: 0x00360FD8 File Offset: 0x0035F1D8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017AF9 RID: 97017 RVA: 0x00360FE5 File Offset: 0x0035F1E5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017AFA RID: 97018 RVA: 0x00360FEC File Offset: 0x0035F1EC
		public static IFavoriteBtNodeInfo GetRootAsIFavoriteBtNodeInfo(ByteBuffer _bb)
		{
			return IFavoriteBtNodeInfo.GetRootAsIFavoriteBtNodeInfo(_bb, default(IFavoriteBtNodeInfo));
		}

		// Token: 0x06017AFB RID: 97019 RVA: 0x00361008 File Offset: 0x0035F208
		public static IFavoriteBtNodeInfo GetRootAsIFavoriteBtNodeInfo(ByteBuffer _bb, IFavoriteBtNodeInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017AFC RID: 97020 RVA: 0x00361025 File Offset: 0x0035F225
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017AFD RID: 97021 RVA: 0x00361034 File Offset: 0x0035F234
		public IFavoriteBtNodeInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170073EE RID: 29678
		// (get) Token: 0x06017AFE RID: 97022 RVA: 0x00361044 File Offset: 0x0035F244
		public int Id
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

		// Token: 0x170073EF RID: 29679
		// (get) Token: 0x06017AFF RID: 97023 RVA: 0x00361080 File Offset: 0x0035F280
		public string Desc
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

		// Token: 0x06017B00 RID: 97024 RVA: 0x003610B7 File Offset: 0x0035F2B7
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06017B01 RID: 97025 RVA: 0x003610C6 File Offset: 0x0035F2C6
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06017B02 RID: 97026 RVA: 0x003610D4 File Offset: 0x0035F2D4
		public static Offset<IFavoriteBtNodeInfo> CreateIFavoriteBtNodeInfo(FlatBufferBuilder builder, int Id = 0, StringOffset DescOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IFavoriteBtNodeInfo.AddDesc(builder, DescOffset);
			IFavoriteBtNodeInfo.AddId(builder, Id);
			return IFavoriteBtNodeInfo.EndIFavoriteBtNodeInfo(builder);
		}

		// Token: 0x06017B03 RID: 97027 RVA: 0x003610F1 File Offset: 0x0035F2F1
		public static void StartIFavoriteBtNodeInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06017B04 RID: 97028 RVA: 0x003610FA File Offset: 0x0035F2FA
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x06017B05 RID: 97029 RVA: 0x00361105 File Offset: 0x0035F305
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(1, descOffset.Value, 0);
		}

		// Token: 0x06017B06 RID: 97030 RVA: 0x00361115 File Offset: 0x0035F315
		public static Offset<IFavoriteBtNodeInfo> EndIFavoriteBtNodeInfo(FlatBufferBuilder builder)
		{
			return new Offset<IFavoriteBtNodeInfo>(builder.EndTable());
		}

		// Token: 0x06017B07 RID: 97031 RVA: 0x00361124 File Offset: 0x0035F324
		public IFavoriteBtNodeInfoT UnPack()
		{
			IFavoriteBtNodeInfoT favoriteBtNodeInfoT = new IFavoriteBtNodeInfoT();
			this.UnPackTo(favoriteBtNodeInfoT);
			return favoriteBtNodeInfoT;
		}

		// Token: 0x06017B08 RID: 97032 RVA: 0x0036113F File Offset: 0x0035F33F
		public void UnPackTo(IFavoriteBtNodeInfoT _o)
		{
			_o.Id = this.Id;
			_o.Desc = this.Desc;
		}

		// Token: 0x06017B09 RID: 97033 RVA: 0x0036115C File Offset: 0x0035F35C
		public static Offset<IFavoriteBtNodeInfo> Pack(FlatBufferBuilder builder, IFavoriteBtNodeInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFavoriteBtNodeInfo>);
			}
			StringOffset descOffset = (_o.Desc == null) ? default(StringOffset) : builder.CreateString(_o.Desc);
			return IFavoriteBtNodeInfo.CreateIFavoriteBtNodeInfo(builder, _o.Id, descOffset);
		}

		// Token: 0x0400C186 RID: 49542
		private Table __p;
	}
}
