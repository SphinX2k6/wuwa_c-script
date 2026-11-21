using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CA1 RID: 3233
	public struct DangoBrawlDamageShow : IFlatbufferObject
	{
		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x0600633C RID: 25404 RVA: 0x00228602 File Offset: 0x00226802
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600633D RID: 25405 RVA: 0x0022860F File Offset: 0x0022680F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600633E RID: 25406 RVA: 0x00228618 File Offset: 0x00226818
		public static DangoBrawlDamageShow GetRootAsDangoBrawlDamageShow(ByteBuffer _bb)
		{
			return DangoBrawlDamageShow.GetRootAsDangoBrawlDamageShow(_bb, default(DangoBrawlDamageShow));
		}

		// Token: 0x0600633F RID: 25407 RVA: 0x00228634 File Offset: 0x00226834
		public static DangoBrawlDamageShow GetRootAsDangoBrawlDamageShow(ByteBuffer _bb, DangoBrawlDamageShow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006340 RID: 25408 RVA: 0x00228651 File Offset: 0x00226851
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006341 RID: 25409 RVA: 0x00228660 File Offset: 0x00226860
		public DangoBrawlDamageShow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x06006342 RID: 25410 RVA: 0x00228670 File Offset: 0x00226870
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

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x06006343 RID: 25411 RVA: 0x002286AC File Offset: 0x002268AC
		public int SceneDamageConfig
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

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x06006344 RID: 25412 RVA: 0x002286E8 File Offset: 0x002268E8
		public int UIDamageConfig
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

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x06006345 RID: 25413 RVA: 0x00228724 File Offset: 0x00226924
		public string TargetDA
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

		// Token: 0x06006346 RID: 25414 RVA: 0x0022875C File Offset: 0x0022695C
		public Span<byte> GetTargetDABytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006347 RID: 25415 RVA: 0x0022876C File Offset: 0x0022696C
		public byte[] GetTargetDAArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x06006348 RID: 25416 RVA: 0x00228784 File Offset: 0x00226984
		public string OppositeDA
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

		// Token: 0x06006349 RID: 25417 RVA: 0x002287BC File Offset: 0x002269BC
		public Span<byte> GetOppositeDABytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600634A RID: 25418 RVA: 0x002287CC File Offset: 0x002269CC
		public byte[] GetOppositeDAArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x0600634B RID: 25419 RVA: 0x002287E4 File Offset: 0x002269E4
		public int DAInternal
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

		// Token: 0x040051CA RID: 20938
		private Table __p;
	}
}
