using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BB9 RID: 3001
	public struct DamageText : IFlatbufferObject
	{
		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x06005C0E RID: 23566 RVA: 0x002059FD File Offset: 0x00203BFD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005C0F RID: 23567 RVA: 0x00205A0A File Offset: 0x00203C0A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005C10 RID: 23568 RVA: 0x00205A14 File Offset: 0x00203C14
		public static DamageText GetRootAsDamageText(ByteBuffer _bb)
		{
			return DamageText.GetRootAsDamageText(_bb, default(DamageText));
		}

		// Token: 0x06005C11 RID: 23569 RVA: 0x00205A30 File Offset: 0x00203C30
		public static DamageText GetRootAsDamageText(ByteBuffer _bb, DamageText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005C12 RID: 23570 RVA: 0x00205A4D File Offset: 0x00203C4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005C13 RID: 23571 RVA: 0x00205A5C File Offset: 0x00203C5C
		public DamageText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x06005C14 RID: 23572 RVA: 0x00205A6C File Offset: 0x00203C6C
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

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x06005C15 RID: 23573 RVA: 0x00205AA8 File Offset: 0x00203CA8
		public string CommonIcon
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

		// Token: 0x06005C16 RID: 23574 RVA: 0x00205ADF File Offset: 0x00203CDF
		public Span<byte> GetCommonIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005C17 RID: 23575 RVA: 0x00205AEE File Offset: 0x00203CEE
		public byte[] GetCommonIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x06005C18 RID: 23576 RVA: 0x00205B08 File Offset: 0x00203D08
		public string CritIcon
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005C19 RID: 23577 RVA: 0x00205B3F File Offset: 0x00203D3F
		public Span<byte> GetCritIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005C1A RID: 23578 RVA: 0x00205B4E File Offset: 0x00203D4E
		public byte[] GetCritIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x06005C1B RID: 23579 RVA: 0x00205B68 File Offset: 0x00203D68
		public string CritNiagaraPath
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

		// Token: 0x06005C1C RID: 23580 RVA: 0x00205BA0 File Offset: 0x00203DA0
		public Span<byte> GetCritNiagaraPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005C1D RID: 23581 RVA: 0x00205BB0 File Offset: 0x00203DB0
		public byte[] GetCritNiagaraPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x06005C1E RID: 23582 RVA: 0x00205BC8 File Offset: 0x00203DC8
		public string TextColor
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

		// Token: 0x06005C1F RID: 23583 RVA: 0x00205C00 File Offset: 0x00203E00
		public Span<byte> GetTextColorBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06005C20 RID: 23584 RVA: 0x00205C10 File Offset: 0x00203E10
		public byte[] GetTextColorArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x06005C21 RID: 23585 RVA: 0x00205C28 File Offset: 0x00203E28
		public string StrokeColor
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

		// Token: 0x06005C22 RID: 23586 RVA: 0x00205C60 File Offset: 0x00203E60
		public Span<byte> GetStrokeColorBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06005C23 RID: 23587 RVA: 0x00205C70 File Offset: 0x00203E70
		public byte[] GetStrokeColorArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x06005C24 RID: 23588 RVA: 0x00205C88 File Offset: 0x00203E88
		public string CritTextColor
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

		// Token: 0x06005C25 RID: 23589 RVA: 0x00205CC0 File Offset: 0x00203EC0
		public Span<byte> GetCritTextColorBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06005C26 RID: 23590 RVA: 0x00205CD0 File Offset: 0x00203ED0
		public byte[] GetCritTextColorArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x06005C27 RID: 23591 RVA: 0x00205CE8 File Offset: 0x00203EE8
		public string CritStrokeColor
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

		// Token: 0x06005C28 RID: 23592 RVA: 0x00205D20 File Offset: 0x00203F20
		public Span<byte> GetCritStrokeColorBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06005C29 RID: 23593 RVA: 0x00205D30 File Offset: 0x00203F30
		public byte[] GetCritStrokeColorArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x06005C2A RID: 23594 RVA: 0x00205D48 File Offset: 0x00203F48
		public int MinDeviationX
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

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x06005C2B RID: 23595 RVA: 0x00205D88 File Offset: 0x00203F88
		public int MinDeviationY
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

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x06005C2C RID: 23596 RVA: 0x00205DC8 File Offset: 0x00203FC8
		public int MaxDeviationX
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x06005C2D RID: 23597 RVA: 0x00205E08 File Offset: 0x00204008
		public int MaxDeviationY
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

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x06005C2E RID: 23598 RVA: 0x00205E48 File Offset: 0x00204048
		public string OwnDamageSequence
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005C2F RID: 23599 RVA: 0x00205E80 File Offset: 0x00204080
		public Span<byte> GetOwnDamageSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06005C30 RID: 23600 RVA: 0x00205E90 File Offset: 0x00204090
		public byte[] GetOwnDamageSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x06005C31 RID: 23601 RVA: 0x00205EA8 File Offset: 0x002040A8
		public string OwnCriticalDamageSequence
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005C32 RID: 23602 RVA: 0x00205EE0 File Offset: 0x002040E0
		public Span<byte> GetOwnCriticalDamageSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06005C33 RID: 23603 RVA: 0x00205EF0 File Offset: 0x002040F0
		public byte[] GetOwnCriticalDamageSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x06005C34 RID: 23604 RVA: 0x00205F08 File Offset: 0x00204108
		public string MonsterDamageSequence
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005C35 RID: 23605 RVA: 0x00205F40 File Offset: 0x00204140
		public Span<byte> GetMonsterDamageSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06005C36 RID: 23606 RVA: 0x00205F50 File Offset: 0x00204150
		public byte[] GetMonsterDamageSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x06005C37 RID: 23607 RVA: 0x00205F68 File Offset: 0x00204168
		public string MonsterCriticalDamageSequence
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005C38 RID: 23608 RVA: 0x00205FA0 File Offset: 0x002041A0
		public Span<byte> GetMonsterCriticalDamageSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06005C39 RID: 23609 RVA: 0x00205FB0 File Offset: 0x002041B0
		public byte[] GetMonsterCriticalDamageSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x06005C3A RID: 23610 RVA: 0x00205FC8 File Offset: 0x002041C8
		public string DamageTextSequence
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005C3B RID: 23611 RVA: 0x00206000 File Offset: 0x00204200
		public Span<byte> GetDamageTextSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x06005C3C RID: 23612 RVA: 0x00206010 File Offset: 0x00204210
		public byte[] GetDamageTextSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x06005C3D RID: 23613 RVA: 0x00206028 File Offset: 0x00204228
		public bool IsPreload
		{
			get
			{
				int num = this.__p.__offset(38);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06005C3E RID: 23614 RVA: 0x00206068 File Offset: 0x00204268
		public string OwnCommonDamageCurvePath(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x06005C3F RID: 23615 RVA: 0x002060A4 File Offset: 0x002042A4
		public int OwnCommonDamageCurvePathLength
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005C40 RID: 23616 RVA: 0x002060D0 File Offset: 0x002042D0
		public string OwnCriticalDamageCurvePath(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x06005C41 RID: 23617 RVA: 0x0020610C File Offset: 0x0020430C
		public int OwnCriticalDamageCurvePathLength
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005C42 RID: 23618 RVA: 0x00206138 File Offset: 0x00204338
		public string MonsterCommonDamageCurvePath(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x06005C43 RID: 23619 RVA: 0x00206174 File Offset: 0x00204374
		public int MonsterCommonDamageCurvePathLength
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005C44 RID: 23620 RVA: 0x002061A0 File Offset: 0x002043A0
		public string MonsterCriticalDamageCurvePath(int j)
		{
			int num = this.__p.__offset(46);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x06005C45 RID: 23621 RVA: 0x002061DC File Offset: 0x002043DC
		public int MonsterCriticalDamageCurvePathLength
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x06005C46 RID: 23622 RVA: 0x00206208 File Offset: 0x00204408
		public bool UseForOptimization
		{
			get
			{
				int num = this.__p.__offset(48);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x06005C47 RID: 23623 RVA: 0x00206248 File Offset: 0x00204448
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005C48 RID: 23624 RVA: 0x00206280 File Offset: 0x00204480
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x06005C49 RID: 23625 RVA: 0x00206290 File Offset: 0x00204490
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x06005C4A RID: 23626 RVA: 0x002062A8 File Offset: 0x002044A8
		public float IconScale
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005C4B RID: 23627 RVA: 0x002062E9 File Offset: 0x002044E9
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MonsterCommonDamageCurvePathIter()或GetMonsterCommonDamageCurvePathBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] MonsterCommonDamageCurvePath()
		{
			return this.MonsterCommonDamageCurvePathIter().ToArray<string>();
		}

		// Token: 0x06005C4C RID: 23628 RVA: 0x002062F6 File Offset: 0x002044F6
		[NullableContext(1)]
		public readonly IEnumerable<string> MonsterCommonDamageCurvePathIter()
		{
			DamageText.<MonsterCommonDamageCurvePathIter>d__89 <MonsterCommonDamageCurvePathIter>d__ = new DamageText.<MonsterCommonDamageCurvePathIter>d__89(-2);
			<MonsterCommonDamageCurvePathIter>d__.<>3__<>4__this = this;
			return <MonsterCommonDamageCurvePathIter>d__;
		}

		// Token: 0x06005C4D RID: 23629 RVA: 0x0020630B File Offset: 0x0020450B
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MonsterCriticalDamageCurvePathIter()或GetMonsterCriticalDamageCurvePathBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] MonsterCriticalDamageCurvePath()
		{
			return this.MonsterCriticalDamageCurvePathIter().ToArray<string>();
		}

		// Token: 0x06005C4E RID: 23630 RVA: 0x00206318 File Offset: 0x00204518
		[NullableContext(1)]
		public readonly IEnumerable<string> MonsterCriticalDamageCurvePathIter()
		{
			DamageText.<MonsterCriticalDamageCurvePathIter>d__91 <MonsterCriticalDamageCurvePathIter>d__ = new DamageText.<MonsterCriticalDamageCurvePathIter>d__91(-2);
			<MonsterCriticalDamageCurvePathIter>d__.<>3__<>4__this = this;
			return <MonsterCriticalDamageCurvePathIter>d__;
		}

		// Token: 0x06005C4F RID: 23631 RVA: 0x0020632D File Offset: 0x0020452D
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用OwnCommonDamageCurvePathIter()或GetOwnCommonDamageCurvePathBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] OwnCommonDamageCurvePath()
		{
			return this.OwnCommonDamageCurvePathIter().ToArray<string>();
		}

		// Token: 0x06005C50 RID: 23632 RVA: 0x0020633A File Offset: 0x0020453A
		[NullableContext(1)]
		public readonly IEnumerable<string> OwnCommonDamageCurvePathIter()
		{
			DamageText.<OwnCommonDamageCurvePathIter>d__93 <OwnCommonDamageCurvePathIter>d__ = new DamageText.<OwnCommonDamageCurvePathIter>d__93(-2);
			<OwnCommonDamageCurvePathIter>d__.<>3__<>4__this = this;
			return <OwnCommonDamageCurvePathIter>d__;
		}

		// Token: 0x06005C51 RID: 23633 RVA: 0x0020634F File Offset: 0x0020454F
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用OwnCriticalDamageCurvePathIter()或GetOwnCriticalDamageCurvePathBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] OwnCriticalDamageCurvePath()
		{
			return this.OwnCriticalDamageCurvePathIter().ToArray<string>();
		}

		// Token: 0x06005C52 RID: 23634 RVA: 0x0020635C File Offset: 0x0020455C
		[NullableContext(1)]
		public readonly IEnumerable<string> OwnCriticalDamageCurvePathIter()
		{
			DamageText.<OwnCriticalDamageCurvePathIter>d__95 <OwnCriticalDamageCurvePathIter>d__ = new DamageText.<OwnCriticalDamageCurvePathIter>d__95(-2);
			<OwnCriticalDamageCurvePathIter>d__.<>3__<>4__this = this;
			return <OwnCriticalDamageCurvePathIter>d__;
		}

		// Token: 0x04004BDF RID: 19423
		private Table __p;
	}
}
