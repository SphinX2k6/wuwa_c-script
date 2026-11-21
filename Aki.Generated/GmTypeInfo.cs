using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DED RID: 3565
	public struct GmTypeInfo : IFlatbufferObject
	{
		// Token: 0x17001645 RID: 5701
		// (get) Token: 0x06008167 RID: 33127 RVA: 0x0026BB39 File Offset: 0x00269D39
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008168 RID: 33128 RVA: 0x0026BB46 File Offset: 0x00269D46
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008169 RID: 33129 RVA: 0x0026BB50 File Offset: 0x00269D50
		public static GmTypeInfo GetRootAsGmTypeInfo(ByteBuffer _bb)
		{
			return GmTypeInfo.GetRootAsGmTypeInfo(_bb, default(GmTypeInfo));
		}

		// Token: 0x0600816A RID: 33130 RVA: 0x0026BB6C File Offset: 0x00269D6C
		public static GmTypeInfo GetRootAsGmTypeInfo(ByteBuffer _bb, GmTypeInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600816B RID: 33131 RVA: 0x0026BB89 File Offset: 0x00269D89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600816C RID: 33132 RVA: 0x0026BB98 File Offset: 0x00269D98
		public GmTypeInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001646 RID: 5702
		// (get) Token: 0x0600816D RID: 33133 RVA: 0x0026BBA8 File Offset: 0x00269DA8
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

		// Token: 0x17001647 RID: 5703
		// (get) Token: 0x0600816E RID: 33134 RVA: 0x0026BBE4 File Offset: 0x00269DE4
		public string Name
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

		// Token: 0x0600816F RID: 33135 RVA: 0x0026BC1B File Offset: 0x00269E1B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008170 RID: 33136 RVA: 0x0026BC2A File Offset: 0x00269E2A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x06008171 RID: 33137 RVA: 0x0026BC44 File Offset: 0x00269E44
		public string KeyWords(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001648 RID: 5704
		// (get) Token: 0x06008172 RID: 33138 RVA: 0x0026BC80 File Offset: 0x00269E80
		public int KeyWordsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008173 RID: 33139 RVA: 0x0026BCAC File Offset: 0x00269EAC
		public int GmOrderConfigList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001649 RID: 5705
		// (get) Token: 0x06008174 RID: 33140 RVA: 0x0026BCEC File Offset: 0x00269EEC
		public int GmOrderConfigListLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008175 RID: 33141 RVA: 0x0026BD18 File Offset: 0x00269F18
		public Span<int> GetGmOrderConfigListBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06008176 RID: 33142 RVA: 0x0026BD28 File Offset: 0x00269F28
		public int[] GetGmOrderConfigListArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x06008177 RID: 33143 RVA: 0x0026BD40 File Offset: 0x00269F40
		[NullableContext(1)]
		public int[] GmOrderConfigList()
		{
			return this.GetGmOrderConfigListArray();
		}

		// Token: 0x06008178 RID: 33144 RVA: 0x0026BD48 File Offset: 0x00269F48
		[NullableContext(1)]
		public IEnumerable<int> GmOrderConfigListIter()
		{
			GmTypeInfo.<GmOrderConfigListIter>d__23 <GmOrderConfigListIter>d__ = new GmTypeInfo.<GmOrderConfigListIter>d__23(-2);
			<GmOrderConfigListIter>d__.<>3__<>4__this = this;
			return <GmOrderConfigListIter>d__;
		}

		// Token: 0x06008179 RID: 33145 RVA: 0x0026BD5D File Offset: 0x00269F5D
		[NullableContext(1)]
		public string[] KeyWords()
		{
			return this.KeyWordsIter().ToArray<string>();
		}

		// Token: 0x0600817A RID: 33146 RVA: 0x0026BD6A File Offset: 0x00269F6A
		[NullableContext(1)]
		public IEnumerable<string> KeyWordsIter()
		{
			GmTypeInfo.<KeyWordsIter>d__25 <KeyWordsIter>d__ = new GmTypeInfo.<KeyWordsIter>d__25(-2);
			<KeyWordsIter>d__.<>3__<>4__this = this;
			return <KeyWordsIter>d__;
		}

		// Token: 0x04005363 RID: 21347
		private Table __p;
	}
}
