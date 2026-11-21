using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200121D RID: 4637
	public struct SpringFestivalAreaCamera : IFlatbufferObject
	{
		// Token: 0x17003B71 RID: 15217
		// (get) Token: 0x0600E5F8 RID: 58872 RVA: 0x0034B1E0 File Offset: 0x003493E0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E5F9 RID: 58873 RVA: 0x0034B1ED File Offset: 0x003493ED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E5FA RID: 58874 RVA: 0x0034B1F4 File Offset: 0x003493F4
		public static SpringFestivalAreaCamera GetRootAsSpringFestivalAreaCamera(ByteBuffer _bb)
		{
			return SpringFestivalAreaCamera.GetRootAsSpringFestivalAreaCamera(_bb, default(SpringFestivalAreaCamera));
		}

		// Token: 0x0600E5FB RID: 58875 RVA: 0x0034B210 File Offset: 0x00349410
		public static SpringFestivalAreaCamera GetRootAsSpringFestivalAreaCamera(ByteBuffer _bb, SpringFestivalAreaCamera obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E5FC RID: 58876 RVA: 0x0034B22D File Offset: 0x0034942D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E5FD RID: 58877 RVA: 0x0034B23C File Offset: 0x0034943C
		public SpringFestivalAreaCamera __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003B72 RID: 15218
		// (get) Token: 0x0600E5FE RID: 58878 RVA: 0x0034B24C File Offset: 0x0034944C
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

		// Token: 0x17003B73 RID: 15219
		// (get) Token: 0x0600E5FF RID: 58879 RVA: 0x0034B288 File Offset: 0x00349488
		public string CameraName
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

		// Token: 0x0600E600 RID: 58880 RVA: 0x0034B2BF File Offset: 0x003494BF
		public Span<byte> GetCameraNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E601 RID: 58881 RVA: 0x0034B2CE File Offset: 0x003494CE
		public byte[] GetCameraNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003B74 RID: 15220
		// (get) Token: 0x0600E602 RID: 58882 RVA: 0x0034B2E8 File Offset: 0x003494E8
		public Vector? CameraLocation
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17003B75 RID: 15221
		// (get) Token: 0x0600E603 RID: 58883 RVA: 0x0034B348 File Offset: 0x00349548
		public Vector? CameraRotator
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17003B76 RID: 15222
		// (get) Token: 0x0600E604 RID: 58884 RVA: 0x0034B3A8 File Offset: 0x003495A8
		public int CameraFov
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 90;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400585E RID: 22622
		private Table __p;
	}
}
