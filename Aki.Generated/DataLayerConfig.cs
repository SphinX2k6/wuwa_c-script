using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CC4 RID: 3268
	public struct DataLayerConfig : IFlatbufferObject
	{
		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x060066F0 RID: 26352 RVA: 0x002305DD File Offset: 0x0022E7DD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060066F1 RID: 26353 RVA: 0x002305EA File Offset: 0x0022E7EA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060066F2 RID: 26354 RVA: 0x002305F4 File Offset: 0x0022E7F4
		public static DataLayerConfig GetRootAsDataLayerConfig(ByteBuffer _bb)
		{
			return DataLayerConfig.GetRootAsDataLayerConfig(_bb, default(DataLayerConfig));
		}

		// Token: 0x060066F3 RID: 26355 RVA: 0x00230610 File Offset: 0x0022E810
		public static DataLayerConfig GetRootAsDataLayerConfig(ByteBuffer _bb, DataLayerConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060066F4 RID: 26356 RVA: 0x0023062D File Offset: 0x0022E82D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060066F5 RID: 26357 RVA: 0x0023063C File Offset: 0x0022E83C
		public DataLayerConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000C78 RID: 3192
		// (get) Token: 0x060066F6 RID: 26358 RVA: 0x0023064C File Offset: 0x0022E84C
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

		// Token: 0x17000C79 RID: 3193
		// (get) Token: 0x060066F7 RID: 26359 RVA: 0x00230688 File Offset: 0x0022E888
		public string DataLayer
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

		// Token: 0x060066F8 RID: 26360 RVA: 0x002306BF File Offset: 0x0022E8BF
		public Span<byte> GetDataLayerBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060066F9 RID: 26361 RVA: 0x002306CE File Offset: 0x0022E8CE
		public byte[] GetDataLayerArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C7A RID: 3194
		// (get) Token: 0x060066FA RID: 26362 RVA: 0x002306E8 File Offset: 0x0022E8E8
		public string CnName
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060066FB RID: 26363 RVA: 0x0023071F File Offset: 0x0022E91F
		public Span<byte> GetCnNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060066FC RID: 26364 RVA: 0x0023072E File Offset: 0x0022E92E
		public byte[] GetCnNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C7B RID: 3195
		// (get) Token: 0x060066FD RID: 26365 RVA: 0x00230748 File Offset: 0x0022E948
		public int LevelId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000C7C RID: 3196
		// (get) Token: 0x060066FE RID: 26366 RVA: 0x00230788 File Offset: 0x0022E988
		public bool InitLoad
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000C7D RID: 3197
		// (get) Token: 0x060066FF RID: 26367 RVA: 0x002307C8 File Offset: 0x0022E9C8
		public bool OnlyActor
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000C7E RID: 3198
		// (get) Token: 0x06006700 RID: 26368 RVA: 0x00230808 File Offset: 0x0022EA08
		public bool EnableSwitchNavMesh
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x040051F1 RID: 20977
		private Table __p;
	}
}
