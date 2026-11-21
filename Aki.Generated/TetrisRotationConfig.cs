using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001322 RID: 4898
	public struct TetrisRotationConfig : IFlatbufferObject
	{
		// Token: 0x170042BF RID: 17087
		// (get) Token: 0x0600F95D RID: 63837 RVA: 0x00375F90 File Offset: 0x00374190
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F95E RID: 63838 RVA: 0x00375F9D File Offset: 0x0037419D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F95F RID: 63839 RVA: 0x00375FA4 File Offset: 0x003741A4
		public static TetrisRotationConfig GetRootAsTetrisRotationConfig(ByteBuffer _bb)
		{
			return TetrisRotationConfig.GetRootAsTetrisRotationConfig(_bb, default(TetrisRotationConfig));
		}

		// Token: 0x0600F960 RID: 63840 RVA: 0x00375FC0 File Offset: 0x003741C0
		public static TetrisRotationConfig GetRootAsTetrisRotationConfig(ByteBuffer _bb, TetrisRotationConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F961 RID: 63841 RVA: 0x00375FDD File Offset: 0x003741DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F962 RID: 63842 RVA: 0x00375FEC File Offset: 0x003741EC
		public TetrisRotationConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170042C0 RID: 17088
		// (get) Token: 0x0600F963 RID: 63843 RVA: 0x00375FFC File Offset: 0x003741FC
		public int Probability
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

		// Token: 0x170042C1 RID: 17089
		// (get) Token: 0x0600F964 RID: 63844 RVA: 0x00376038 File Offset: 0x00374238
		public IntRange? ObjectCount
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IntRange?(default(IntRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170042C2 RID: 17090
		// (get) Token: 0x0600F965 RID: 63845 RVA: 0x00376098 File Offset: 0x00374298
		public IntRange? RotationCount
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IntRange?(default(IntRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x040059A8 RID: 22952
		private Table __p;
	}
}
