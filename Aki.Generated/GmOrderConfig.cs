using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DEB RID: 3563
	public struct GmOrderConfig : IFlatbufferObject
	{
		// Token: 0x17001639 RID: 5689
		// (get) Token: 0x06008144 RID: 33092 RVA: 0x0026B6FD File Offset: 0x002698FD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008145 RID: 33093 RVA: 0x0026B70A File Offset: 0x0026990A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008146 RID: 33094 RVA: 0x0026B714 File Offset: 0x00269914
		public static GmOrderConfig GetRootAsGmOrderConfig(ByteBuffer _bb)
		{
			return GmOrderConfig.GetRootAsGmOrderConfig(_bb, default(GmOrderConfig));
		}

		// Token: 0x06008147 RID: 33095 RVA: 0x0026B730 File Offset: 0x00269930
		public static GmOrderConfig GetRootAsGmOrderConfig(ByteBuffer _bb, GmOrderConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008148 RID: 33096 RVA: 0x0026B74D File Offset: 0x0026994D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008149 RID: 33097 RVA: 0x0026B75C File Offset: 0x0026995C
		public GmOrderConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700163A RID: 5690
		// (get) Token: 0x0600814A RID: 33098 RVA: 0x0026B76C File Offset: 0x0026996C
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

		// Token: 0x1700163B RID: 5691
		// (get) Token: 0x0600814B RID: 33099 RVA: 0x0026B7A8 File Offset: 0x002699A8
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

		// Token: 0x0600814C RID: 33100 RVA: 0x0026B7DF File Offset: 0x002699DF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600814D RID: 33101 RVA: 0x0026B7EE File Offset: 0x002699EE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700163C RID: 5692
		// (get) Token: 0x0600814E RID: 33102 RVA: 0x0026B808 File Offset: 0x00269A08
		public string NameOverride
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

		// Token: 0x0600814F RID: 33103 RVA: 0x0026B83F File Offset: 0x00269A3F
		public Span<byte> GetNameOverrideBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008150 RID: 33104 RVA: 0x0026B84E File Offset: 0x00269A4E
		public byte[] GetNameOverrideArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700163D RID: 5693
		// (get) Token: 0x06008151 RID: 33105 RVA: 0x0026B868 File Offset: 0x00269A68
		public string Code
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

		// Token: 0x06008152 RID: 33106 RVA: 0x0026B8A0 File Offset: 0x00269AA0
		public Span<byte> GetCodeBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008153 RID: 33107 RVA: 0x0026B8B0 File Offset: 0x00269AB0
		public byte[] GetCodeArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700163E RID: 5694
		// (get) Token: 0x06008154 RID: 33108 RVA: 0x0026B8C8 File Offset: 0x00269AC8
		public string CodeOverride
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008155 RID: 33109 RVA: 0x0026B900 File Offset: 0x00269B00
		public Span<byte> GetCodeOverrideBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06008156 RID: 33110 RVA: 0x0026B910 File Offset: 0x00269B10
		public byte[] GetCodeOverrideArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700163F RID: 5695
		// (get) Token: 0x06008157 RID: 33111 RVA: 0x0026B928 File Offset: 0x00269B28
		public int Sort
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001640 RID: 5696
		// (get) Token: 0x06008158 RID: 33112 RVA: 0x0026B968 File Offset: 0x00269B68
		public bool Visible
		{
			get
			{
				int num = this.__p.__offset(16);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04005361 RID: 21345
		private Table __p;
	}
}
