using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200131C RID: 4892
	public struct SpecialBarOffsetInfo : IFlatbufferObject
	{
		// Token: 0x170042A7 RID: 17063
		// (get) Token: 0x0600F91F RID: 63775 RVA: 0x003757F9 File Offset: 0x003739F9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F920 RID: 63776 RVA: 0x00375806 File Offset: 0x00373A06
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F921 RID: 63777 RVA: 0x00375810 File Offset: 0x00373A10
		public static SpecialBarOffsetInfo GetRootAsSpecialBarOffsetInfo(ByteBuffer _bb)
		{
			return SpecialBarOffsetInfo.GetRootAsSpecialBarOffsetInfo(_bb, default(SpecialBarOffsetInfo));
		}

		// Token: 0x0600F922 RID: 63778 RVA: 0x0037582C File Offset: 0x00373A2C
		public static SpecialBarOffsetInfo GetRootAsSpecialBarOffsetInfo(ByteBuffer _bb, SpecialBarOffsetInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F923 RID: 63779 RVA: 0x00375849 File Offset: 0x00373A49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F924 RID: 63780 RVA: 0x00375858 File Offset: 0x00373A58
		public SpecialBarOffsetInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170042A8 RID: 17064
		// (get) Token: 0x0600F925 RID: 63781 RVA: 0x00375868 File Offset: 0x00373A68
		public int MinPercent
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

		// Token: 0x170042A9 RID: 17065
		// (get) Token: 0x0600F926 RID: 63782 RVA: 0x003758A4 File Offset: 0x00373AA4
		public int MaxPercent
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

		// Token: 0x170042AA RID: 17066
		// (get) Token: 0x0600F927 RID: 63783 RVA: 0x003758E0 File Offset: 0x00373AE0
		public int MinOffsetX
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

		// Token: 0x170042AB RID: 17067
		// (get) Token: 0x0600F928 RID: 63784 RVA: 0x0037591C File Offset: 0x00373B1C
		public int MinOffsetY
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

		// Token: 0x170042AC RID: 17068
		// (get) Token: 0x0600F929 RID: 63785 RVA: 0x0037595C File Offset: 0x00373B5C
		public int MaxOffsetX
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

		// Token: 0x170042AD RID: 17069
		// (get) Token: 0x0600F92A RID: 63786 RVA: 0x0037599C File Offset: 0x00373B9C
		public int MaxOffsetY
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

		// Token: 0x040059A2 RID: 22946
		private Table __p;
	}
}
