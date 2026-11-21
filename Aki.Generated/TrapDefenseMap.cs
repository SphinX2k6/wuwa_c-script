using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200129B RID: 4763
	public struct TrapDefenseMap : IFlatbufferObject
	{
		// Token: 0x17003FA4 RID: 16292
		// (get) Token: 0x0600F143 RID: 61763 RVA: 0x00364355 File Offset: 0x00362555
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F144 RID: 61764 RVA: 0x00364362 File Offset: 0x00362562
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F145 RID: 61765 RVA: 0x0036436C File Offset: 0x0036256C
		public static TrapDefenseMap GetRootAsTrapDefenseMap(ByteBuffer _bb)
		{
			return TrapDefenseMap.GetRootAsTrapDefenseMap(_bb, default(TrapDefenseMap));
		}

		// Token: 0x0600F146 RID: 61766 RVA: 0x00364388 File Offset: 0x00362588
		public static TrapDefenseMap GetRootAsTrapDefenseMap(ByteBuffer _bb, TrapDefenseMap obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F147 RID: 61767 RVA: 0x003643A5 File Offset: 0x003625A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F148 RID: 61768 RVA: 0x003643B4 File Offset: 0x003625B4
		public TrapDefenseMap __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003FA5 RID: 16293
		// (get) Token: 0x0600F149 RID: 61769 RVA: 0x003643C4 File Offset: 0x003625C4
		public int MapId
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

		// Token: 0x0600F14A RID: 61770 RVA: 0x00364400 File Offset: 0x00362600
		public float CenterOffset(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003FA6 RID: 16294
		// (get) Token: 0x0600F14B RID: 61771 RVA: 0x00364444 File Offset: 0x00362644
		public int CenterOffsetLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600F14C RID: 61772 RVA: 0x0036446F File Offset: 0x0036266F
		public Span<float> GetCenterOffsetBytes()
		{
			return this.__p.__vector_as_span<float>(6, 4);
		}

		// Token: 0x0600F14D RID: 61773 RVA: 0x0036447E File Offset: 0x0036267E
		public float[] GetCenterOffsetArray()
		{
			return this.__p.__vector_as_array<float>(6) ?? Array.Empty<float>();
		}

		// Token: 0x0600F14E RID: 61774 RVA: 0x00364498 File Offset: 0x00362698
		public float UiOffset(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003FA7 RID: 16295
		// (get) Token: 0x0600F14F RID: 61775 RVA: 0x003644DC File Offset: 0x003626DC
		public int UiOffsetLength
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

		// Token: 0x0600F150 RID: 61776 RVA: 0x00364507 File Offset: 0x00362707
		public Span<float> GetUiOffsetBytes()
		{
			return this.__p.__vector_as_span<float>(8, 4);
		}

		// Token: 0x0600F151 RID: 61777 RVA: 0x00364516 File Offset: 0x00362716
		public float[] GetUiOffsetArray()
		{
			return this.__p.__vector_as_array<float>(8) ?? Array.Empty<float>();
		}

		// Token: 0x0600F152 RID: 61778 RVA: 0x00364530 File Offset: 0x00362730
		public float BigMapUiOffset(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003FA8 RID: 16296
		// (get) Token: 0x0600F153 RID: 61779 RVA: 0x00364574 File Offset: 0x00362774
		public int BigMapUiOffsetLength
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

		// Token: 0x0600F154 RID: 61780 RVA: 0x003645A0 File Offset: 0x003627A0
		public Span<float> GetBigMapUiOffsetBytes()
		{
			return this.__p.__vector_as_span<float>(10, 4);
		}

		// Token: 0x0600F155 RID: 61781 RVA: 0x003645B0 File Offset: 0x003627B0
		public float[] GetBigMapUiOffsetArray()
		{
			return this.__p.__vector_as_array<float>(10) ?? Array.Empty<float>();
		}

		// Token: 0x17003FA9 RID: 16297
		// (get) Token: 0x0600F156 RID: 61782 RVA: 0x003645C8 File Offset: 0x003627C8
		public float MiniMapScale
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003FAA RID: 16298
		// (get) Token: 0x0600F157 RID: 61783 RVA: 0x0036460C File Offset: 0x0036280C
		public float MapScale
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003FAB RID: 16299
		// (get) Token: 0x0600F158 RID: 61784 RVA: 0x00364650 File Offset: 0x00362850
		public string MiniMapResourcePath
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

		// Token: 0x0600F159 RID: 61785 RVA: 0x00364688 File Offset: 0x00362888
		public Span<byte> GetMiniMapResourcePathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600F15A RID: 61786 RVA: 0x00364698 File Offset: 0x00362898
		public byte[] GetMiniMapResourcePathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003FAC RID: 16300
		// (get) Token: 0x0600F15B RID: 61787 RVA: 0x003646B0 File Offset: 0x003628B0
		public string MiniMapLightResourcePath
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

		// Token: 0x0600F15C RID: 61788 RVA: 0x003646E8 File Offset: 0x003628E8
		public Span<byte> GetMiniMapLightResourcePathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600F15D RID: 61789 RVA: 0x003646F8 File Offset: 0x003628F8
		public byte[] GetMiniMapLightResourcePathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17003FAD RID: 16301
		// (get) Token: 0x0600F15E RID: 61790 RVA: 0x00364710 File Offset: 0x00362910
		public string MapResourcePath
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600F15F RID: 61791 RVA: 0x00364748 File Offset: 0x00362948
		public Span<byte> GetMapResourcePathBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600F160 RID: 61792 RVA: 0x00364758 File Offset: 0x00362958
		public byte[] GetMapResourcePathArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x0600F161 RID: 61793 RVA: 0x00364770 File Offset: 0x00362970
		[NullableContext(1)]
		public float[] BigMapUiOffset()
		{
			return this.GetBigMapUiOffsetArray();
		}

		// Token: 0x0600F162 RID: 61794 RVA: 0x00364778 File Offset: 0x00362978
		[NullableContext(1)]
		public IEnumerable<float> BigMapUiOffsetIter()
		{
			TrapDefenseMap.<BigMapUiOffsetIter>d__42 <BigMapUiOffsetIter>d__ = new TrapDefenseMap.<BigMapUiOffsetIter>d__42(-2);
			<BigMapUiOffsetIter>d__.<>3__<>4__this = this;
			return <BigMapUiOffsetIter>d__;
		}

		// Token: 0x0600F163 RID: 61795 RVA: 0x0036478D File Offset: 0x0036298D
		[NullableContext(1)]
		public float[] CenterOffset()
		{
			return this.GetCenterOffsetArray();
		}

		// Token: 0x0600F164 RID: 61796 RVA: 0x00364795 File Offset: 0x00362995
		[NullableContext(1)]
		public IEnumerable<float> CenterOffsetIter()
		{
			TrapDefenseMap.<CenterOffsetIter>d__44 <CenterOffsetIter>d__ = new TrapDefenseMap.<CenterOffsetIter>d__44(-2);
			<CenterOffsetIter>d__.<>3__<>4__this = this;
			return <CenterOffsetIter>d__;
		}

		// Token: 0x0600F165 RID: 61797 RVA: 0x003647AA File Offset: 0x003629AA
		[NullableContext(1)]
		public float[] UiOffset()
		{
			return this.GetUiOffsetArray();
		}

		// Token: 0x0600F166 RID: 61798 RVA: 0x003647B2 File Offset: 0x003629B2
		[NullableContext(1)]
		public IEnumerable<float> UiOffsetIter()
		{
			TrapDefenseMap.<UiOffsetIter>d__46 <UiOffsetIter>d__ = new TrapDefenseMap.<UiOffsetIter>d__46(-2);
			<UiOffsetIter>d__.<>3__<>4__this = this;
			return <UiOffsetIter>d__;
		}

		// Token: 0x040058EE RID: 22766
		private Table __p;
	}
}
