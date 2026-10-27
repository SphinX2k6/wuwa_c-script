using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010D8 RID: 4312
	public struct SoundAreaPlayInfo : IFlatbufferObject
	{
		// Token: 0x1700379B RID: 14235
		// (get) Token: 0x0600D761 RID: 55137 RVA: 0x0031CE09 File Offset: 0x0031B009
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D762 RID: 55138 RVA: 0x0031CE16 File Offset: 0x0031B016
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D763 RID: 55139 RVA: 0x0031CE20 File Offset: 0x0031B020
		public static SoundAreaPlayInfo GetRootAsSoundAreaPlayInfo(ByteBuffer _bb)
		{
			return SoundAreaPlayInfo.GetRootAsSoundAreaPlayInfo(_bb, default(SoundAreaPlayInfo));
		}

		// Token: 0x0600D764 RID: 55140 RVA: 0x0031CE3C File Offset: 0x0031B03C
		public static SoundAreaPlayInfo GetRootAsSoundAreaPlayInfo(ByteBuffer _bb, SoundAreaPlayInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D765 RID: 55141 RVA: 0x0031CE59 File Offset: 0x0031B059
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D766 RID: 55142 RVA: 0x0031CE68 File Offset: 0x0031B068
		public SoundAreaPlayInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700379C RID: 14236
		// (get) Token: 0x0600D767 RID: 55143 RVA: 0x0031CE78 File Offset: 0x0031B078
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

		// Token: 0x1700379D RID: 14237
		// (get) Token: 0x0600D768 RID: 55144 RVA: 0x0031CEB4 File Offset: 0x0031B0B4
		public string BuffTitle
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

		// Token: 0x0600D769 RID: 55145 RVA: 0x0031CEEB File Offset: 0x0031B0EB
		public Span<byte> GetBuffTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D76A RID: 55146 RVA: 0x0031CEFA File Offset: 0x0031B0FA
		public byte[] GetBuffTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700379E RID: 14238
		// (get) Token: 0x0600D76B RID: 55147 RVA: 0x0031CF14 File Offset: 0x0031B114
		public int MaxCountType
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

		// Token: 0x1700379F RID: 14239
		// (get) Token: 0x0600D76C RID: 55148 RVA: 0x0031CF50 File Offset: 0x0031B150
		public string BuffDescription
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

		// Token: 0x0600D76D RID: 55149 RVA: 0x0031CF88 File Offset: 0x0031B188
		public Span<byte> GetBuffDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D76E RID: 55150 RVA: 0x0031CF98 File Offset: 0x0031B198
		public byte[] GetBuffDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170037A0 RID: 14240
		// (get) Token: 0x0600D76F RID: 55151 RVA: 0x0031CFB0 File Offset: 0x0031B1B0
		public bool ShowTitle
		{
			get
			{
				int num = this.__p.__offset(12);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170037A1 RID: 14241
		// (get) Token: 0x0600D770 RID: 55152 RVA: 0x0031CFF0 File Offset: 0x0031B1F0
		public int Time
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 3;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170037A2 RID: 14242
		// (get) Token: 0x0600D771 RID: 55153 RVA: 0x0031D030 File Offset: 0x0031B230
		public int MaxCount
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400520B RID: 21003
		private Table __p;
	}
}
