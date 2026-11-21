using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001323 RID: 4899
	public struct Vector : IFlatbufferObject
	{
		// Token: 0x170042C3 RID: 17091
		// (get) Token: 0x0600F966 RID: 63846 RVA: 0x003760F5 File Offset: 0x003742F5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F967 RID: 63847 RVA: 0x00376102 File Offset: 0x00374302
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F968 RID: 63848 RVA: 0x0037610C File Offset: 0x0037430C
		public static Vector GetRootAsVector(ByteBuffer _bb)
		{
			return Vector.GetRootAsVector(_bb, default(Vector));
		}

		// Token: 0x0600F969 RID: 63849 RVA: 0x00376128 File Offset: 0x00374328
		public static Vector GetRootAsVector(ByteBuffer _bb, Vector obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F96A RID: 63850 RVA: 0x00376145 File Offset: 0x00374345
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F96B RID: 63851 RVA: 0x00376154 File Offset: 0x00374354
		public Vector __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170042C4 RID: 17092
		// (get) Token: 0x0600F96C RID: 63852 RVA: 0x00376164 File Offset: 0x00374364
		public float X
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170042C5 RID: 17093
		// (get) Token: 0x0600F96D RID: 63853 RVA: 0x003761A4 File Offset: 0x003743A4
		public float Y
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170042C6 RID: 17094
		// (get) Token: 0x0600F96E RID: 63854 RVA: 0x003761E4 File Offset: 0x003743E4
		public float Z
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040059A9 RID: 22953
		private Table __p;
	}
}
