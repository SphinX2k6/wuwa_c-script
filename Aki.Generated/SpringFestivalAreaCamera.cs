using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010E7 RID: 4327
	public struct SpringFestivalAreaCamera : IFlatbufferObject
	{
		// Token: 0x1700381B RID: 14363
		// (get) Token: 0x0600D8AD RID: 55469 RVA: 0x0031FC40 File Offset: 0x0031DE40
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D8AE RID: 55470 RVA: 0x0031FC4D File Offset: 0x0031DE4D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D8AF RID: 55471 RVA: 0x0031FC54 File Offset: 0x0031DE54
		public static SpringFestivalAreaCamera GetRootAsSpringFestivalAreaCamera(ByteBuffer _bb)
		{
			return SpringFestivalAreaCamera.GetRootAsSpringFestivalAreaCamera(_bb, default(SpringFestivalAreaCamera));
		}

		// Token: 0x0600D8B0 RID: 55472 RVA: 0x0031FC70 File Offset: 0x0031DE70
		public static SpringFestivalAreaCamera GetRootAsSpringFestivalAreaCamera(ByteBuffer _bb, SpringFestivalAreaCamera obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D8B1 RID: 55473 RVA: 0x0031FC8D File Offset: 0x0031DE8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D8B2 RID: 55474 RVA: 0x0031FC9C File Offset: 0x0031DE9C
		public SpringFestivalAreaCamera __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700381C RID: 14364
		// (get) Token: 0x0600D8B3 RID: 55475 RVA: 0x0031FCAC File Offset: 0x0031DEAC
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

		// Token: 0x1700381D RID: 14365
		// (get) Token: 0x0600D8B4 RID: 55476 RVA: 0x0031FCE8 File Offset: 0x0031DEE8
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

		// Token: 0x0600D8B5 RID: 55477 RVA: 0x0031FD1F File Offset: 0x0031DF1F
		public Span<byte> GetCameraNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D8B6 RID: 55478 RVA: 0x0031FD2E File Offset: 0x0031DF2E
		public byte[] GetCameraNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700381E RID: 14366
		// (get) Token: 0x0600D8B7 RID: 55479 RVA: 0x0031FD48 File Offset: 0x0031DF48
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

		// Token: 0x1700381F RID: 14367
		// (get) Token: 0x0600D8B8 RID: 55480 RVA: 0x0031FDA8 File Offset: 0x0031DFA8
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

		// Token: 0x17003820 RID: 14368
		// (get) Token: 0x0600D8B9 RID: 55481 RVA: 0x0031FE08 File Offset: 0x0031E008
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

		// Token: 0x0400521B RID: 21019
		private Table __p;
	}
}
