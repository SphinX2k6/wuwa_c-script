using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E10 RID: 3600
	public struct HomeBtnStyle : IFlatbufferObject
	{
		// Token: 0x17001771 RID: 6001
		// (get) Token: 0x0600849B RID: 33947 RVA: 0x002728F0 File Offset: 0x00270AF0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600849C RID: 33948 RVA: 0x002728FD File Offset: 0x00270AFD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600849D RID: 33949 RVA: 0x00272904 File Offset: 0x00270B04
		public static HomeBtnStyle GetRootAsHomeBtnStyle(ByteBuffer _bb)
		{
			return HomeBtnStyle.GetRootAsHomeBtnStyle(_bb, default(HomeBtnStyle));
		}

		// Token: 0x0600849E RID: 33950 RVA: 0x00272920 File Offset: 0x00270B20
		public static HomeBtnStyle GetRootAsHomeBtnStyle(ByteBuffer _bb, HomeBtnStyle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600849F RID: 33951 RVA: 0x0027293D File Offset: 0x00270B3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060084A0 RID: 33952 RVA: 0x0027294C File Offset: 0x00270B4C
		public HomeBtnStyle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001772 RID: 6002
		// (get) Token: 0x060084A1 RID: 33953 RVA: 0x0027295C File Offset: 0x00270B5C
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

		// Token: 0x17001773 RID: 6003
		// (get) Token: 0x060084A2 RID: 33954 RVA: 0x00272998 File Offset: 0x00270B98
		public string ResourceId
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

		// Token: 0x060084A3 RID: 33955 RVA: 0x002729CF File Offset: 0x00270BCF
		public Span<byte> GetResourceIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060084A4 RID: 33956 RVA: 0x002729DE File Offset: 0x00270BDE
		public byte[] GetResourceIdArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001774 RID: 6004
		// (get) Token: 0x060084A5 RID: 33957 RVA: 0x002729F8 File Offset: 0x00270BF8
		public string SPNormal
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

		// Token: 0x060084A6 RID: 33958 RVA: 0x00272A2F File Offset: 0x00270C2F
		public Span<byte> GetSPNormalBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060084A7 RID: 33959 RVA: 0x00272A3E File Offset: 0x00270C3E
		public byte[] GetSPNormalArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001775 RID: 6005
		// (get) Token: 0x060084A8 RID: 33960 RVA: 0x00272A58 File Offset: 0x00270C58
		public string SPHighLighted
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

		// Token: 0x060084A9 RID: 33961 RVA: 0x00272A90 File Offset: 0x00270C90
		public Span<byte> GetSPHighLightedBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060084AA RID: 33962 RVA: 0x00272AA0 File Offset: 0x00270CA0
		public byte[] GetSPHighLightedArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001776 RID: 6006
		// (get) Token: 0x060084AB RID: 33963 RVA: 0x00272AB8 File Offset: 0x00270CB8
		public string SPPressed
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

		// Token: 0x060084AC RID: 33964 RVA: 0x00272AF0 File Offset: 0x00270CF0
		public Span<byte> GetSPPressedBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060084AD RID: 33965 RVA: 0x00272B00 File Offset: 0x00270D00
		public byte[] GetSPPressedArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001777 RID: 6007
		// (get) Token: 0x060084AE RID: 33966 RVA: 0x00272B18 File Offset: 0x00270D18
		public string SPDisable
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

		// Token: 0x060084AF RID: 33967 RVA: 0x00272B50 File Offset: 0x00270D50
		public Span<byte> GetSPDisableBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060084B0 RID: 33968 RVA: 0x00272B60 File Offset: 0x00270D60
		public byte[] GetSPDisableArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04005388 RID: 21384
		private Table __p;
	}
}
