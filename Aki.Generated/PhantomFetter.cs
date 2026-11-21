using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FCA RID: 4042
	public struct PhantomFetter : IFlatbufferObject
	{
		// Token: 0x1700271E RID: 10014
		// (get) Token: 0x0600AE85 RID: 44677 RVA: 0x002CFC4C File Offset: 0x002CDE4C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AE86 RID: 44678 RVA: 0x002CFC59 File Offset: 0x002CDE59
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AE87 RID: 44679 RVA: 0x002CFC60 File Offset: 0x002CDE60
		public static PhantomFetter GetRootAsPhantomFetter(ByteBuffer _bb)
		{
			return PhantomFetter.GetRootAsPhantomFetter(_bb, default(PhantomFetter));
		}

		// Token: 0x0600AE88 RID: 44680 RVA: 0x002CFC7C File Offset: 0x002CDE7C
		public static PhantomFetter GetRootAsPhantomFetter(ByteBuffer _bb, PhantomFetter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AE89 RID: 44681 RVA: 0x002CFC99 File Offset: 0x002CDE99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AE8A RID: 44682 RVA: 0x002CFCA8 File Offset: 0x002CDEA8
		public PhantomFetter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700271F RID: 10015
		// (get) Token: 0x0600AE8B RID: 44683 RVA: 0x002CFCB8 File Offset: 0x002CDEB8
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

		// Token: 0x17002720 RID: 10016
		// (get) Token: 0x0600AE8C RID: 44684 RVA: 0x002CFCF4 File Offset: 0x002CDEF4
		public string Name
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

		// Token: 0x0600AE8D RID: 44685 RVA: 0x002CFD2B File Offset: 0x002CDF2B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600AE8E RID: 44686 RVA: 0x002CFD3A File Offset: 0x002CDF3A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600AE8F RID: 44687 RVA: 0x002CFD54 File Offset: 0x002CDF54
		public long BuffIds(int j)
		{
			int num = this.__p.__offset(8);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17002721 RID: 10017
		// (get) Token: 0x0600AE90 RID: 44688 RVA: 0x002CFDA0 File Offset: 0x002CDFA0
		public int BuffIdsLength
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

		// Token: 0x0600AE91 RID: 44689 RVA: 0x002CFDCB File Offset: 0x002CDFCB
		public Span<long> GetBuffIdsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(8, 8));
		}

		// Token: 0x0600AE92 RID: 44690 RVA: 0x002CFDDF File Offset: 0x002CDFDF
		public long[] GetBuffIdsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(8) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x0600AE93 RID: 44691 RVA: 0x002CFE1C File Offset: 0x002CE01C
		public ConfigPropValue? AddProp(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new ConfigPropValue?(default(ConfigPropValue).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002722 RID: 10018
		// (get) Token: 0x0600AE94 RID: 44692 RVA: 0x002CFE80 File Offset: 0x002CE080
		public int AddPropLength
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

		// Token: 0x17002723 RID: 10019
		// (get) Token: 0x0600AE95 RID: 44693 RVA: 0x002CFEAC File Offset: 0x002CE0AC
		public string EffectDescription
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

		// Token: 0x0600AE96 RID: 44694 RVA: 0x002CFEE4 File Offset: 0x002CE0E4
		public Span<byte> GetEffectDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600AE97 RID: 44695 RVA: 0x002CFEF4 File Offset: 0x002CE0F4
		public byte[] GetEffectDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002724 RID: 10020
		// (get) Token: 0x0600AE98 RID: 44696 RVA: 0x002CFF0C File Offset: 0x002CE10C
		public string FetterIcon
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

		// Token: 0x0600AE99 RID: 44697 RVA: 0x002CFF44 File Offset: 0x002CE144
		public Span<byte> GetFetterIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600AE9A RID: 44698 RVA: 0x002CFF54 File Offset: 0x002CE154
		public byte[] GetFetterIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002725 RID: 10021
		// (get) Token: 0x0600AE9B RID: 44699 RVA: 0x002CFF6C File Offset: 0x002CE16C
		public string SimplyEffectDesc
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

		// Token: 0x0600AE9C RID: 44700 RVA: 0x002CFFA4 File Offset: 0x002CE1A4
		public Span<byte> GetSimplyEffectDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600AE9D RID: 44701 RVA: 0x002CFFB4 File Offset: 0x002CE1B4
		public byte[] GetSimplyEffectDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0600AE9E RID: 44702 RVA: 0x002CFFCC File Offset: 0x002CE1CC
		public string EffectDescriptionParam(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002726 RID: 10022
		// (get) Token: 0x0600AE9F RID: 44703 RVA: 0x002D0008 File Offset: 0x002CE208
		public int EffectDescriptionParamLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17002727 RID: 10023
		// (get) Token: 0x0600AEA0 RID: 44704 RVA: 0x002D0034 File Offset: 0x002CE234
		public string EffectDefineDescription
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

		// Token: 0x0600AEA1 RID: 44705 RVA: 0x002D006C File Offset: 0x002CE26C
		public Span<byte> GetEffectDefineDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600AEA2 RID: 44706 RVA: 0x002D007C File Offset: 0x002CE27C
		public byte[] GetEffectDefineDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002728 RID: 10024
		// (get) Token: 0x0600AEA3 RID: 44707 RVA: 0x002D0094 File Offset: 0x002CE294
		public int Priority
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AEA4 RID: 44708 RVA: 0x002D00D1 File Offset: 0x002CE2D1
		[NullableContext(1)]
		public ConfigPropValue[] AddProp()
		{
			return this.AddPropIter().ToArray<ConfigPropValue>();
		}

		// Token: 0x0600AEA5 RID: 44709 RVA: 0x002D00DE File Offset: 0x002CE2DE
		[NullableContext(1)]
		public IEnumerable<ConfigPropValue> AddPropIter()
		{
			PhantomFetter.<AddPropIter>d__44 <AddPropIter>d__ = new PhantomFetter.<AddPropIter>d__44(-2);
			<AddPropIter>d__.<>3__<>4__this = this;
			return <AddPropIter>d__;
		}

		// Token: 0x0600AEA6 RID: 44710 RVA: 0x002D00F3 File Offset: 0x002CE2F3
		[NullableContext(1)]
		public long[] BuffIds()
		{
			return this.GetBuffIdsArray();
		}

		// Token: 0x0600AEA7 RID: 44711 RVA: 0x002D00FB File Offset: 0x002CE2FB
		[NullableContext(1)]
		public IEnumerable<long> BuffIdsIter()
		{
			PhantomFetter.<BuffIdsIter>d__46 <BuffIdsIter>d__ = new PhantomFetter.<BuffIdsIter>d__46(-2);
			<BuffIdsIter>d__.<>3__<>4__this = this;
			return <BuffIdsIter>d__;
		}

		// Token: 0x0600AEA8 RID: 44712 RVA: 0x002D0110 File Offset: 0x002CE310
		[NullableContext(1)]
		public string[] EffectDescriptionParam()
		{
			return this.EffectDescriptionParamIter().ToArray<string>();
		}

		// Token: 0x0600AEA9 RID: 44713 RVA: 0x002D011D File Offset: 0x002CE31D
		[NullableContext(1)]
		public IEnumerable<string> EffectDescriptionParamIter()
		{
			PhantomFetter.<EffectDescriptionParamIter>d__48 <EffectDescriptionParamIter>d__ = new PhantomFetter.<EffectDescriptionParamIter>d__48(-2);
			<EffectDescriptionParamIter>d__.<>3__<>4__this = this;
			return <EffectDescriptionParamIter>d__;
		}

		// Token: 0x0400558B RID: 21899
		private Table __p;
	}
}
