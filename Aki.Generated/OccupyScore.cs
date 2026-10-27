using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EA0 RID: 3744
	public struct OccupyScore : IFlatbufferObject
	{
		// Token: 0x170023F8 RID: 9208
		// (get) Token: 0x0600A120 RID: 41248 RVA: 0x002A2200 File Offset: 0x002A0400
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A121 RID: 41249 RVA: 0x002A220D File Offset: 0x002A040D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A122 RID: 41250 RVA: 0x002A2214 File Offset: 0x002A0414
		public static OccupyScore GetRootAsOccupyScore(ByteBuffer _bb)
		{
			return OccupyScore.GetRootAsOccupyScore(_bb, default(OccupyScore));
		}

		// Token: 0x0600A123 RID: 41251 RVA: 0x002A2230 File Offset: 0x002A0430
		public static OccupyScore GetRootAsOccupyScore(ByteBuffer _bb, OccupyScore obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A124 RID: 41252 RVA: 0x002A224D File Offset: 0x002A044D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A125 RID: 41253 RVA: 0x002A225C File Offset: 0x002A045C
		public OccupyScore __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170023F9 RID: 9209
		// (get) Token: 0x0600A126 RID: 41254 RVA: 0x002A226C File Offset: 0x002A046C
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

		// Token: 0x170023FA RID: 9210
		// (get) Token: 0x0600A127 RID: 41255 RVA: 0x002A22A8 File Offset: 0x002A04A8
		public int NeedScore
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

		// Token: 0x170023FB RID: 9211
		// (get) Token: 0x0600A128 RID: 41256 RVA: 0x002A22E4 File Offset: 0x002A04E4
		public int ScoreReward
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

		// Token: 0x04004F54 RID: 20308
		private Table __p;
	}
}
