using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CA9 RID: 3241
	public struct DangoBrawlObjectTemplate : IFlatbufferObject
	{
		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x0600640C RID: 25612 RVA: 0x0022A33D File Offset: 0x0022853D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600640D RID: 25613 RVA: 0x0022A34A File Offset: 0x0022854A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600640E RID: 25614 RVA: 0x0022A354 File Offset: 0x00228554
		public static DangoBrawlObjectTemplate GetRootAsDangoBrawlObjectTemplate(ByteBuffer _bb)
		{
			return DangoBrawlObjectTemplate.GetRootAsDangoBrawlObjectTemplate(_bb, default(DangoBrawlObjectTemplate));
		}

		// Token: 0x0600640F RID: 25615 RVA: 0x0022A370 File Offset: 0x00228570
		public static DangoBrawlObjectTemplate GetRootAsDangoBrawlObjectTemplate(ByteBuffer _bb, DangoBrawlObjectTemplate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006410 RID: 25616 RVA: 0x0022A38D File Offset: 0x0022858D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006411 RID: 25617 RVA: 0x0022A39C File Offset: 0x0022859C
		public DangoBrawlObjectTemplate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x06006412 RID: 25618 RVA: 0x0022A3AC File Offset: 0x002285AC
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

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x06006413 RID: 25619 RVA: 0x0022A3E8 File Offset: 0x002285E8
		public string SubType
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

		// Token: 0x06006414 RID: 25620 RVA: 0x0022A41F File Offset: 0x0022861F
		public Span<byte> GetSubTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006415 RID: 25621 RVA: 0x0022A42E File Offset: 0x0022862E
		public byte[] GetSubTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x06006416 RID: 25622 RVA: 0x0022A448 File Offset: 0x00228648
		public int DataId
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

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x06006417 RID: 25623 RVA: 0x0022A484 File Offset: 0x00228684
		public string LinkCenterOffset
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

		// Token: 0x06006418 RID: 25624 RVA: 0x0022A4BC File Offset: 0x002286BC
		public Span<byte> GetLinkCenterOffsetBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006419 RID: 25625 RVA: 0x0022A4CC File Offset: 0x002286CC
		public byte[] GetLinkCenterOffsetArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x0600641A RID: 25626 RVA: 0x0022A4E4 File Offset: 0x002286E4
		public string ShapeCells
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

		// Token: 0x0600641B RID: 25627 RVA: 0x0022A51C File Offset: 0x0022871C
		public Span<byte> GetShapeCellsBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600641C RID: 25628 RVA: 0x0022A52C File Offset: 0x0022872C
		public byte[] GetShapeCellsArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x0600641D RID: 25629 RVA: 0x0022A544 File Offset: 0x00228744
		public string StarCells
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

		// Token: 0x0600641E RID: 25630 RVA: 0x0022A57C File Offset: 0x0022877C
		public Span<byte> GetStarCellsBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600641F RID: 25631 RVA: 0x0022A58C File Offset: 0x0022878C
		public byte[] GetStarCellsArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x040051D2 RID: 20946
		private Table __p;
	}
}
