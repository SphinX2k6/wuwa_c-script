using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DB2 RID: 3506
	public struct FormationProperty : IFlatbufferObject
	{
		// Token: 0x17001473 RID: 5235
		// (get) Token: 0x06007CAE RID: 31918 RVA: 0x00261622 File Offset: 0x0025F822
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007CAF RID: 31919 RVA: 0x0026162F File Offset: 0x0025F82F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007CB0 RID: 31920 RVA: 0x00261638 File Offset: 0x0025F838
		public static FormationProperty GetRootAsFormationProperty(ByteBuffer _bb)
		{
			return FormationProperty.GetRootAsFormationProperty(_bb, default(FormationProperty));
		}

		// Token: 0x06007CB1 RID: 31921 RVA: 0x00261654 File Offset: 0x0025F854
		public static FormationProperty GetRootAsFormationProperty(ByteBuffer _bb, FormationProperty obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007CB2 RID: 31922 RVA: 0x00261671 File Offset: 0x0025F871
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007CB3 RID: 31923 RVA: 0x00261680 File Offset: 0x0025F880
		public FormationProperty __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001474 RID: 5236
		// (get) Token: 0x06007CB4 RID: 31924 RVA: 0x00261690 File Offset: 0x0025F890
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

		// Token: 0x17001475 RID: 5237
		// (get) Token: 0x06007CB5 RID: 31925 RVA: 0x002616CC File Offset: 0x0025F8CC
		public int InitValue
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

		// Token: 0x17001476 RID: 5238
		// (get) Token: 0x06007CB6 RID: 31926 RVA: 0x00261708 File Offset: 0x0025F908
		public int InitRecoveryRate
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return -500;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001477 RID: 5239
		// (get) Token: 0x06007CB7 RID: 31927 RVA: 0x00261748 File Offset: 0x0025F948
		public int InitMax
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 10000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007CB8 RID: 31928 RVA: 0x0026178C File Offset: 0x0025F98C
		public string MarkTag(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001478 RID: 5240
		// (get) Token: 0x06007CB9 RID: 31929 RVA: 0x002617C8 File Offset: 0x0025F9C8
		public int MarkTagLength
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

		// Token: 0x06007CBA RID: 31930 RVA: 0x002617F4 File Offset: 0x0025F9F4
		public string ResistTag(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001479 RID: 5241
		// (get) Token: 0x06007CBB RID: 31931 RVA: 0x00261830 File Offset: 0x0025FA30
		public int ResistTagLength
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

		// Token: 0x1700147A RID: 5242
		// (get) Token: 0x06007CBC RID: 31932 RVA: 0x0026185C File Offset: 0x0025FA5C
		public FloatRange? TriggerRange1
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new FloatRange?(default(FloatRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700147B RID: 5243
		// (get) Token: 0x06007CBD RID: 31933 RVA: 0x002618BC File Offset: 0x0025FABC
		public int TriggerType1
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700147C RID: 5244
		// (get) Token: 0x06007CBE RID: 31934 RVA: 0x002618FC File Offset: 0x0025FAFC
		public int TriggerEffect1
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007CBF RID: 31935 RVA: 0x0026193C File Offset: 0x0025FB3C
		public long TriggerEffectParams1(int j)
		{
			int num = this.__p.__offset(22);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x1700147D RID: 5245
		// (get) Token: 0x06007CC0 RID: 31936 RVA: 0x00261988 File Offset: 0x0025FB88
		public int TriggerEffectParams1Length
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

		// Token: 0x06007CC1 RID: 31937 RVA: 0x002619B4 File Offset: 0x0025FBB4
		public Span<long> GetTriggerEffectParams1Bytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(22, 8));
		}

		// Token: 0x06007CC2 RID: 31938 RVA: 0x002619C9 File Offset: 0x0025FBC9
		public long[] GetTriggerEffectParams1Array()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(22) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x1700147E RID: 5246
		// (get) Token: 0x06007CC3 RID: 31939 RVA: 0x00261A08 File Offset: 0x0025FC08
		public FloatRange? TriggerRange2
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return new FloatRange?(default(FloatRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700147F RID: 5247
		// (get) Token: 0x06007CC4 RID: 31940 RVA: 0x00261A68 File Offset: 0x0025FC68
		public int TriggerType2
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001480 RID: 5248
		// (get) Token: 0x06007CC5 RID: 31941 RVA: 0x00261AA8 File Offset: 0x0025FCA8
		public int TriggerEffect2
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007CC6 RID: 31942 RVA: 0x00261AE8 File Offset: 0x0025FCE8
		public long TriggerEffectParams2(int j)
		{
			int num = this.__p.__offset(30);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17001481 RID: 5249
		// (get) Token: 0x06007CC7 RID: 31943 RVA: 0x00261B34 File Offset: 0x0025FD34
		public int TriggerEffectParams2Length
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007CC8 RID: 31944 RVA: 0x00261B60 File Offset: 0x0025FD60
		public Span<long> GetTriggerEffectParams2Bytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(30, 8));
		}

		// Token: 0x06007CC9 RID: 31945 RVA: 0x00261B75 File Offset: 0x0025FD75
		public long[] GetTriggerEffectParams2Array()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(30) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x17001482 RID: 5250
		// (get) Token: 0x06007CCA RID: 31946 RVA: 0x00261BB4 File Offset: 0x0025FDB4
		public FloatRange? TriggerRange3
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return new FloatRange?(default(FloatRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17001483 RID: 5251
		// (get) Token: 0x06007CCB RID: 31947 RVA: 0x00261C14 File Offset: 0x0025FE14
		public int TriggerType3
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001484 RID: 5252
		// (get) Token: 0x06007CCC RID: 31948 RVA: 0x00261C54 File Offset: 0x0025FE54
		public int TriggerEffect3
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007CCD RID: 31949 RVA: 0x00261C94 File Offset: 0x0025FE94
		public long TriggerEffectParams3(int j)
		{
			int num = this.__p.__offset(38);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17001485 RID: 5253
		// (get) Token: 0x06007CCE RID: 31950 RVA: 0x00261CE0 File Offset: 0x0025FEE0
		public int TriggerEffectParams3Length
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007CCF RID: 31951 RVA: 0x00261D0C File Offset: 0x0025FF0C
		public Span<long> GetTriggerEffectParams3Bytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(38, 8));
		}

		// Token: 0x06007CD0 RID: 31952 RVA: 0x00261D21 File Offset: 0x0025FF21
		public long[] GetTriggerEffectParams3Array()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(38) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x17001486 RID: 5254
		// (get) Token: 0x06007CD1 RID: 31953 RVA: 0x00261D60 File Offset: 0x0025FF60
		public int Condition
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001487 RID: 5255
		// (get) Token: 0x06007CD2 RID: 31954 RVA: 0x00261DA0 File Offset: 0x0025FFA0
		public string Name
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007CD3 RID: 31955 RVA: 0x00261DD8 File Offset: 0x0025FFD8
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x06007CD4 RID: 31956 RVA: 0x00261DE8 File Offset: 0x0025FFE8
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x17001488 RID: 5256
		// (get) Token: 0x06007CD5 RID: 31957 RVA: 0x00261E00 File Offset: 0x00260000
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007CD6 RID: 31958 RVA: 0x00261E38 File Offset: 0x00260038
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x06007CD7 RID: 31959 RVA: 0x00261E48 File Offset: 0x00260048
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x17001489 RID: 5257
		// (get) Token: 0x06007CD8 RID: 31960 RVA: 0x00261E60 File Offset: 0x00260060
		public string Dec
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007CD9 RID: 31961 RVA: 0x00261E98 File Offset: 0x00260098
		public Span<byte> GetDecBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x06007CDA RID: 31962 RVA: 0x00261EA8 File Offset: 0x002600A8
		public byte[] GetDecArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x1700148A RID: 5258
		// (get) Token: 0x06007CDB RID: 31963 RVA: 0x00261EC0 File Offset: 0x002600C0
		public int Priority
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007CDC RID: 31964 RVA: 0x00261EFD File Offset: 0x002600FD
		[NullableContext(1)]
		public string[] MarkTag()
		{
			return this.MarkTagIter().ToArray<string>();
		}

		// Token: 0x06007CDD RID: 31965 RVA: 0x00261F0A File Offset: 0x0026010A
		[NullableContext(1)]
		public IEnumerable<string> MarkTagIter()
		{
			FormationProperty.<MarkTagIter>d__72 <MarkTagIter>d__ = new FormationProperty.<MarkTagIter>d__72(-2);
			<MarkTagIter>d__.<>3__<>4__this = this;
			return <MarkTagIter>d__;
		}

		// Token: 0x06007CDE RID: 31966 RVA: 0x00261F1F File Offset: 0x0026011F
		[NullableContext(1)]
		public string[] ResistTag()
		{
			return this.ResistTagIter().ToArray<string>();
		}

		// Token: 0x06007CDF RID: 31967 RVA: 0x00261F2C File Offset: 0x0026012C
		[NullableContext(1)]
		public IEnumerable<string> ResistTagIter()
		{
			FormationProperty.<ResistTagIter>d__74 <ResistTagIter>d__ = new FormationProperty.<ResistTagIter>d__74(-2);
			<ResistTagIter>d__.<>3__<>4__this = this;
			return <ResistTagIter>d__;
		}

		// Token: 0x06007CE0 RID: 31968 RVA: 0x00261F41 File Offset: 0x00260141
		[NullableContext(1)]
		public long[] TriggerEffectParams1()
		{
			return this.GetTriggerEffectParams1Array();
		}

		// Token: 0x06007CE1 RID: 31969 RVA: 0x00261F49 File Offset: 0x00260149
		[NullableContext(1)]
		public IEnumerable<long> TriggerEffectParams1Iter()
		{
			FormationProperty.<TriggerEffectParams1Iter>d__76 <TriggerEffectParams1Iter>d__ = new FormationProperty.<TriggerEffectParams1Iter>d__76(-2);
			<TriggerEffectParams1Iter>d__.<>3__<>4__this = this;
			return <TriggerEffectParams1Iter>d__;
		}

		// Token: 0x06007CE2 RID: 31970 RVA: 0x00261F5E File Offset: 0x0026015E
		[NullableContext(1)]
		public long[] TriggerEffectParams2()
		{
			return this.GetTriggerEffectParams2Array();
		}

		// Token: 0x06007CE3 RID: 31971 RVA: 0x00261F66 File Offset: 0x00260166
		[NullableContext(1)]
		public IEnumerable<long> TriggerEffectParams2Iter()
		{
			FormationProperty.<TriggerEffectParams2Iter>d__78 <TriggerEffectParams2Iter>d__ = new FormationProperty.<TriggerEffectParams2Iter>d__78(-2);
			<TriggerEffectParams2Iter>d__.<>3__<>4__this = this;
			return <TriggerEffectParams2Iter>d__;
		}

		// Token: 0x06007CE4 RID: 31972 RVA: 0x00261F7B File Offset: 0x0026017B
		[NullableContext(1)]
		public long[] TriggerEffectParams3()
		{
			return this.GetTriggerEffectParams3Array();
		}

		// Token: 0x06007CE5 RID: 31973 RVA: 0x00261F83 File Offset: 0x00260183
		[NullableContext(1)]
		public IEnumerable<long> TriggerEffectParams3Iter()
		{
			FormationProperty.<TriggerEffectParams3Iter>d__80 <TriggerEffectParams3Iter>d__ = new FormationProperty.<TriggerEffectParams3Iter>d__80(-2);
			<TriggerEffectParams3Iter>d__.<>3__<>4__this = this;
			return <TriggerEffectParams3Iter>d__;
		}

		// Token: 0x04005322 RID: 21282
		private Table __p;
	}
}
