using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E70 RID: 3696
	public struct MotorTechTree : IFlatbufferObject
	{
		// Token: 0x17002274 RID: 8820
		// (get) Token: 0x06009CE2 RID: 40162 RVA: 0x00298F2C File Offset: 0x0029712C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009CE3 RID: 40163 RVA: 0x00298F39 File Offset: 0x00297139
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009CE4 RID: 40164 RVA: 0x00298F40 File Offset: 0x00297140
		public static MotorTechTree GetRootAsMotorTechTree(ByteBuffer _bb)
		{
			return MotorTechTree.GetRootAsMotorTechTree(_bb, default(MotorTechTree));
		}

		// Token: 0x06009CE5 RID: 40165 RVA: 0x00298F5C File Offset: 0x0029715C
		public static MotorTechTree GetRootAsMotorTechTree(ByteBuffer _bb, MotorTechTree obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009CE6 RID: 40166 RVA: 0x00298F79 File Offset: 0x00297179
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009CE7 RID: 40167 RVA: 0x00298F88 File Offset: 0x00297188
		public MotorTechTree __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002275 RID: 8821
		// (get) Token: 0x06009CE8 RID: 40168 RVA: 0x00298F98 File Offset: 0x00297198
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

		// Token: 0x17002276 RID: 8822
		// (get) Token: 0x06009CE9 RID: 40169 RVA: 0x00298FD4 File Offset: 0x002971D4
		public int UnlockCondition
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

		// Token: 0x17002277 RID: 8823
		// (get) Token: 0x06009CEA RID: 40170 RVA: 0x00299010 File Offset: 0x00297210
		public int Order
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

		// Token: 0x17002278 RID: 8824
		// (get) Token: 0x06009CEB RID: 40171 RVA: 0x0029904C File Offset: 0x0029724C
		public int TpItemId
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

		// Token: 0x17002279 RID: 8825
		// (get) Token: 0x06009CEC RID: 40172 RVA: 0x0029908C File Offset: 0x0029728C
		public int TaskLimitPointNum
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700227A RID: 8826
		// (get) Token: 0x06009CED RID: 40173 RVA: 0x002990CC File Offset: 0x002972CC
		public string Name
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009CEE RID: 40174 RVA: 0x00299104 File Offset: 0x00297304
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06009CEF RID: 40175 RVA: 0x00299114 File Offset: 0x00297314
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700227B RID: 8827
		// (get) Token: 0x06009CF0 RID: 40176 RVA: 0x0029912C File Offset: 0x0029732C
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009CF1 RID: 40177 RVA: 0x00299164 File Offset: 0x00297364
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06009CF2 RID: 40178 RVA: 0x00299174 File Offset: 0x00297374
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700227C RID: 8828
		// (get) Token: 0x06009CF3 RID: 40179 RVA: 0x0029918C File Offset: 0x0029738C
		public string Icon512
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009CF4 RID: 40180 RVA: 0x002991C4 File Offset: 0x002973C4
		public Span<byte> GetIcon512Bytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06009CF5 RID: 40181 RVA: 0x002991D4 File Offset: 0x002973D4
		public byte[] GetIcon512Array()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700227D RID: 8829
		// (get) Token: 0x06009CF6 RID: 40182 RVA: 0x002991EC File Offset: 0x002973EC
		public int ComUiType
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004F1E RID: 20254
		private Table __p;
	}
}
