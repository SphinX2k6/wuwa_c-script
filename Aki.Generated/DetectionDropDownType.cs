using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BE7 RID: 3047
	public struct DetectionDropDownType : IFlatbufferObject
	{
		// Token: 0x17000C4E RID: 3150
		// (get) Token: 0x06006166 RID: 24934 RVA: 0x00211995 File Offset: 0x0020FB95
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006167 RID: 24935 RVA: 0x002119A2 File Offset: 0x0020FBA2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006168 RID: 24936 RVA: 0x002119AC File Offset: 0x0020FBAC
		public static DetectionDropDownType GetRootAsDetectionDropDownType(ByteBuffer _bb)
		{
			return DetectionDropDownType.GetRootAsDetectionDropDownType(_bb, default(DetectionDropDownType));
		}

		// Token: 0x06006169 RID: 24937 RVA: 0x002119C8 File Offset: 0x0020FBC8
		public static DetectionDropDownType GetRootAsDetectionDropDownType(ByteBuffer _bb, DetectionDropDownType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600616A RID: 24938 RVA: 0x002119E5 File Offset: 0x0020FBE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600616B RID: 24939 RVA: 0x002119F4 File Offset: 0x0020FBF4
		public DetectionDropDownType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000C4F RID: 3151
		// (get) Token: 0x0600616C RID: 24940 RVA: 0x00211A04 File Offset: 0x0020FC04
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

		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x0600616D RID: 24941 RVA: 0x00211A40 File Offset: 0x0020FC40
		public string Text
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

		// Token: 0x0600616E RID: 24942 RVA: 0x00211A77 File Offset: 0x0020FC77
		public Span<byte> GetTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600616F RID: 24943 RVA: 0x00211A86 File Offset: 0x0020FC86
		public byte[] GetTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004C14 RID: 19476
		private Table __p;
	}
}
