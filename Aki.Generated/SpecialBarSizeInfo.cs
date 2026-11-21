using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200131D RID: 4893
	public struct SpecialBarSizeInfo : IFlatbufferObject
	{
		// Token: 0x170042AE RID: 17070
		// (get) Token: 0x0600F92B RID: 63787 RVA: 0x003759D9 File Offset: 0x00373BD9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F92C RID: 63788 RVA: 0x003759E6 File Offset: 0x00373BE6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F92D RID: 63789 RVA: 0x003759F0 File Offset: 0x00373BF0
		public static SpecialBarSizeInfo GetRootAsSpecialBarSizeInfo(ByteBuffer _bb)
		{
			return SpecialBarSizeInfo.GetRootAsSpecialBarSizeInfo(_bb, default(SpecialBarSizeInfo));
		}

		// Token: 0x0600F92E RID: 63790 RVA: 0x00375A0C File Offset: 0x00373C0C
		public static SpecialBarSizeInfo GetRootAsSpecialBarSizeInfo(ByteBuffer _bb, SpecialBarSizeInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F92F RID: 63791 RVA: 0x00375A29 File Offset: 0x00373C29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F930 RID: 63792 RVA: 0x00375A38 File Offset: 0x00373C38
		public SpecialBarSizeInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170042AF RID: 17071
		// (get) Token: 0x0600F931 RID: 63793 RVA: 0x00375A48 File Offset: 0x00373C48
		public int Index
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

		// Token: 0x170042B0 RID: 17072
		// (get) Token: 0x0600F932 RID: 63794 RVA: 0x00375A84 File Offset: 0x00373C84
		public int SizeX
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

		// Token: 0x170042B1 RID: 17073
		// (get) Token: 0x0600F933 RID: 63795 RVA: 0x00375AC0 File Offset: 0x00373CC0
		public int SizeY
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

		// Token: 0x040059A3 RID: 22947
		private Table __p;
	}
}
