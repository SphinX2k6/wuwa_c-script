using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C6A RID: 3178
	public struct ComboTeaching : IFlatbufferObject
	{
		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x06005CAA RID: 23722 RVA: 0x00219568 File Offset: 0x00217768
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005CAB RID: 23723 RVA: 0x00219575 File Offset: 0x00217775
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005CAC RID: 23724 RVA: 0x0021957C File Offset: 0x0021777C
		public static ComboTeaching GetRootAsComboTeaching(ByteBuffer _bb)
		{
			return ComboTeaching.GetRootAsComboTeaching(_bb, default(ComboTeaching));
		}

		// Token: 0x06005CAD RID: 23725 RVA: 0x00219598 File Offset: 0x00217798
		public static ComboTeaching GetRootAsComboTeaching(ByteBuffer _bb, ComboTeaching obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005CAE RID: 23726 RVA: 0x002195B5 File Offset: 0x002177B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005CAF RID: 23727 RVA: 0x002195C4 File Offset: 0x002177C4
		public ComboTeaching __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x06005CB0 RID: 23728 RVA: 0x002195D4 File Offset: 0x002177D4
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

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x06005CB1 RID: 23729 RVA: 0x00219610 File Offset: 0x00217810
		public int NextRoleGuideID
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

		// Token: 0x06005CB2 RID: 23730 RVA: 0x0021964C File Offset: 0x0021784C
		public string KeyID(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x06005CB3 RID: 23731 RVA: 0x00219688 File Offset: 0x00217888
		public int KeyIDLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005CB4 RID: 23732 RVA: 0x002196B4 File Offset: 0x002178B4
		public string SpecialIconID(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x06005CB5 RID: 23733 RVA: 0x002196F0 File Offset: 0x002178F0
		public int SpecialIconIDLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005CB6 RID: 23734 RVA: 0x0021971C File Offset: 0x0021791C
		public string IconText(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06005CB7 RID: 23735 RVA: 0x00219758 File Offset: 0x00217958
		public int IconTextLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005CB8 RID: 23736 RVA: 0x00219784 File Offset: 0x00217984
		public string IconTagText(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06005CB9 RID: 23737 RVA: 0x002197C0 File Offset: 0x002179C0
		public int IconTagTextLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06005CBA RID: 23738 RVA: 0x002197EC File Offset: 0x002179EC
		public string DescriptionTitle
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005CBB RID: 23739 RVA: 0x00219824 File Offset: 0x00217A24
		public Span<byte> GetDescriptionTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06005CBC RID: 23740 RVA: 0x00219834 File Offset: 0x00217A34
		public byte[] GetDescriptionTitleArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06005CBD RID: 23741 RVA: 0x0021984C File Offset: 0x00217A4C
		public string DescriptionContent
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005CBE RID: 23742 RVA: 0x00219884 File Offset: 0x00217A84
		public Span<byte> GetDescriptionContentBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06005CBF RID: 23743 RVA: 0x00219894 File Offset: 0x00217A94
		public byte[] GetDescriptionContentArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x06005CC0 RID: 23744 RVA: 0x002198AC File Offset: 0x00217AAC
		public int CommandID(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x06005CC1 RID: 23745 RVA: 0x002198EC File Offset: 0x00217AEC
		public int CommandIDLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005CC2 RID: 23746 RVA: 0x00219918 File Offset: 0x00217B18
		public Span<int> GetCommandIDBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x06005CC3 RID: 23747 RVA: 0x00219928 File Offset: 0x00217B28
		public int[] GetCommandIDArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x06005CC4 RID: 23748 RVA: 0x00219940 File Offset: 0x00217B40
		public int GuideID(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x06005CC5 RID: 23749 RVA: 0x00219980 File Offset: 0x00217B80
		public int GuideIDLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005CC6 RID: 23750 RVA: 0x002199AC File Offset: 0x00217BAC
		public Span<int> GetGuideIDBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x06005CC7 RID: 23751 RVA: 0x002199BC File Offset: 0x00217BBC
		public int[] GetGuideIDArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x06005CC8 RID: 23752 RVA: 0x002199D4 File Offset: 0x00217BD4
		public string InputEnums(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x06005CC9 RID: 23753 RVA: 0x00219A10 File Offset: 0x00217C10
		public int InputEnumsLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005CCA RID: 23754 RVA: 0x00219A3C File Offset: 0x00217C3C
		public long AddBuffID(int j)
		{
			int num = this.__p.__offset(26);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x06005CCB RID: 23755 RVA: 0x00219A88 File Offset: 0x00217C88
		public int AddBuffIDLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005CCC RID: 23756 RVA: 0x00219AB4 File Offset: 0x00217CB4
		public Span<long> GetAddBuffIDBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(26, 8));
		}

		// Token: 0x06005CCD RID: 23757 RVA: 0x00219AC9 File Offset: 0x00217CC9
		public long[] GetAddBuffIDArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(26) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x06005CCE RID: 23758 RVA: 0x00219B05 File Offset: 0x00217D05
		[NullableContext(1)]
		public long[] AddBuffID()
		{
			return this.GetAddBuffIDArray();
		}

		// Token: 0x06005CCF RID: 23759 RVA: 0x00219B0D File Offset: 0x00217D0D
		[NullableContext(1)]
		public IEnumerable<long> AddBuffIDIter()
		{
			ComboTeaching.<AddBuffIDIter>d__51 <AddBuffIDIter>d__ = new ComboTeaching.<AddBuffIDIter>d__51(-2);
			<AddBuffIDIter>d__.<>3__<>4__this = this;
			return <AddBuffIDIter>d__;
		}

		// Token: 0x06005CD0 RID: 23760 RVA: 0x00219B22 File Offset: 0x00217D22
		[NullableContext(1)]
		public int[] CommandID()
		{
			return this.GetCommandIDArray();
		}

		// Token: 0x06005CD1 RID: 23761 RVA: 0x00219B2A File Offset: 0x00217D2A
		[NullableContext(1)]
		public IEnumerable<int> CommandIDIter()
		{
			ComboTeaching.<CommandIDIter>d__53 <CommandIDIter>d__ = new ComboTeaching.<CommandIDIter>d__53(-2);
			<CommandIDIter>d__.<>3__<>4__this = this;
			return <CommandIDIter>d__;
		}

		// Token: 0x06005CD2 RID: 23762 RVA: 0x00219B3F File Offset: 0x00217D3F
		[NullableContext(1)]
		public int[] GuideID()
		{
			return this.GetGuideIDArray();
		}

		// Token: 0x06005CD3 RID: 23763 RVA: 0x00219B47 File Offset: 0x00217D47
		[NullableContext(1)]
		public IEnumerable<int> GuideIDIter()
		{
			ComboTeaching.<GuideIDIter>d__55 <GuideIDIter>d__ = new ComboTeaching.<GuideIDIter>d__55(-2);
			<GuideIDIter>d__.<>3__<>4__this = this;
			return <GuideIDIter>d__;
		}

		// Token: 0x06005CD4 RID: 23764 RVA: 0x00219B5C File Offset: 0x00217D5C
		[NullableContext(1)]
		public string[] IconTagText()
		{
			return this.IconTagTextIter().ToArray<string>();
		}

		// Token: 0x06005CD5 RID: 23765 RVA: 0x00219B69 File Offset: 0x00217D69
		[NullableContext(1)]
		public IEnumerable<string> IconTagTextIter()
		{
			ComboTeaching.<IconTagTextIter>d__57 <IconTagTextIter>d__ = new ComboTeaching.<IconTagTextIter>d__57(-2);
			<IconTagTextIter>d__.<>3__<>4__this = this;
			return <IconTagTextIter>d__;
		}

		// Token: 0x06005CD6 RID: 23766 RVA: 0x00219B7E File Offset: 0x00217D7E
		[NullableContext(1)]
		public string[] IconText()
		{
			return this.IconTextIter().ToArray<string>();
		}

		// Token: 0x06005CD7 RID: 23767 RVA: 0x00219B8B File Offset: 0x00217D8B
		[NullableContext(1)]
		public IEnumerable<string> IconTextIter()
		{
			ComboTeaching.<IconTextIter>d__59 <IconTextIter>d__ = new ComboTeaching.<IconTextIter>d__59(-2);
			<IconTextIter>d__.<>3__<>4__this = this;
			return <IconTextIter>d__;
		}

		// Token: 0x06005CD8 RID: 23768 RVA: 0x00219BA0 File Offset: 0x00217DA0
		[NullableContext(1)]
		public string[] InputEnums()
		{
			return this.InputEnumsIter().ToArray<string>();
		}

		// Token: 0x06005CD9 RID: 23769 RVA: 0x00219BAD File Offset: 0x00217DAD
		[NullableContext(1)]
		public IEnumerable<string> InputEnumsIter()
		{
			ComboTeaching.<InputEnumsIter>d__61 <InputEnumsIter>d__ = new ComboTeaching.<InputEnumsIter>d__61(-2);
			<InputEnumsIter>d__.<>3__<>4__this = this;
			return <InputEnumsIter>d__;
		}

		// Token: 0x06005CDA RID: 23770 RVA: 0x00219BC2 File Offset: 0x00217DC2
		[NullableContext(1)]
		public string[] KeyID()
		{
			return this.KeyIDIter().ToArray<string>();
		}

		// Token: 0x06005CDB RID: 23771 RVA: 0x00219BCF File Offset: 0x00217DCF
		[NullableContext(1)]
		public IEnumerable<string> KeyIDIter()
		{
			ComboTeaching.<KeyIDIter>d__63 <KeyIDIter>d__ = new ComboTeaching.<KeyIDIter>d__63(-2);
			<KeyIDIter>d__.<>3__<>4__this = this;
			return <KeyIDIter>d__;
		}

		// Token: 0x06005CDC RID: 23772 RVA: 0x00219BE4 File Offset: 0x00217DE4
		[NullableContext(1)]
		public string[] SpecialIconID()
		{
			return this.SpecialIconIDIter().ToArray<string>();
		}

		// Token: 0x06005CDD RID: 23773 RVA: 0x00219BF1 File Offset: 0x00217DF1
		[NullableContext(1)]
		public IEnumerable<string> SpecialIconIDIter()
		{
			ComboTeaching.<SpecialIconIDIter>d__65 <SpecialIconIDIter>d__ = new ComboTeaching.<SpecialIconIDIter>d__65(-2);
			<SpecialIconIDIter>d__.<>3__<>4__this = this;
			return <SpecialIconIDIter>d__;
		}

		// Token: 0x04005179 RID: 20857
		private Table __p;
	}
}
