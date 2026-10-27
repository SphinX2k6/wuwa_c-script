using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D94 RID: 3476
	public struct KujiQuest : IFlatbufferObject
	{
		// Token: 0x17001B07 RID: 6919
		// (get) Token: 0x0600886C RID: 34924 RVA: 0x0026B369 File Offset: 0x00269569
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600886D RID: 34925 RVA: 0x0026B376 File Offset: 0x00269576
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600886E RID: 34926 RVA: 0x0026B380 File Offset: 0x00269580
		public static KujiQuest GetRootAsKujiQuest(ByteBuffer _bb)
		{
			return KujiQuest.GetRootAsKujiQuest(_bb, default(KujiQuest));
		}

		// Token: 0x0600886F RID: 34927 RVA: 0x0026B39C File Offset: 0x0026959C
		public static KujiQuest GetRootAsKujiQuest(ByteBuffer _bb, KujiQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008870 RID: 34928 RVA: 0x0026B3B9 File Offset: 0x002695B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008871 RID: 34929 RVA: 0x0026B3C8 File Offset: 0x002695C8
		public KujiQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001B08 RID: 6920
		// (get) Token: 0x06008872 RID: 34930 RVA: 0x0026B3D8 File Offset: 0x002695D8
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

		// Token: 0x17001B09 RID: 6921
		// (get) Token: 0x06008873 RID: 34931 RVA: 0x0026B414 File Offset: 0x00269614
		public int KujiId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001B0A RID: 6922
		// (get) Token: 0x06008874 RID: 34932 RVA: 0x0026B450 File Offset: 0x00269650
		public int CoinQuestId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001B0B RID: 6923
		// (get) Token: 0x06008875 RID: 34933 RVA: 0x0026B48C File Offset: 0x0026968C
		public string QuestDesc
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008876 RID: 34934 RVA: 0x0026B4C4 File Offset: 0x002696C4
		public Span<byte> GetQuestDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008877 RID: 34935 RVA: 0x0026B4D4 File Offset: 0x002696D4
		public byte[] GetQuestDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04004E21 RID: 20001
		private Table __p;
	}
}
