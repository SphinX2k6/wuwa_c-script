using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C9B RID: 3227
	public struct DamageText : IFlatbufferObject
	{
		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x060061E7 RID: 25063 RVA: 0x00225321 File Offset: 0x00223521
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060061E8 RID: 25064 RVA: 0x0022532E File Offset: 0x0022352E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060061E9 RID: 25065 RVA: 0x00225338 File Offset: 0x00223538
		public static DamageText GetRootAsDamageText(ByteBuffer _bb)
		{
			return DamageText.GetRootAsDamageText(_bb, default(DamageText));
		}

		// Token: 0x060061EA RID: 25066 RVA: 0x00225354 File Offset: 0x00223554
		public static DamageText GetRootAsDamageText(ByteBuffer _bb, DamageText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060061EB RID: 25067 RVA: 0x00225371 File Offset: 0x00223571
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060061EC RID: 25068 RVA: 0x00225380 File Offset: 0x00223580
		public DamageText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x060061ED RID: 25069 RVA: 0x00225390 File Offset: 0x00223590
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

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x060061EE RID: 25070 RVA: 0x002253CC File Offset: 0x002235CC
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

		// Token: 0x060061EF RID: 25071 RVA: 0x00225403 File Offset: 0x00223603
		public Span<byte> GetCommonIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060061F0 RID: 25072 RVA: 0x00225412 File Offset: 0x00223612
		public byte[] GetCommonIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x060061F1 RID: 25073 RVA: 0x0022542C File Offset: 0x0022362C
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

		// Token: 0x060061F2 RID: 25074 RVA: 0x00225463 File Offset: 0x00223663
		public Span<byte> GetCritIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060061F3 RID: 25075 RVA: 0x00225472 File Offset: 0x00223672
		public byte[] GetCritIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x060061F4 RID: 25076 RVA: 0x0022548C File Offset: 0x0022368C
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

		// Token: 0x060061F5 RID: 25077 RVA: 0x002254C4 File Offset: 0x002236C4
		public Span<byte> GetCritNiagaraPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060061F6 RID: 25078 RVA: 0x002254D4 File Offset: 0x002236D4
		public byte[] GetCritNiagaraPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x060061F7 RID: 25079 RVA: 0x002254EC File Offset: 0x002236EC
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

		// Token: 0x060061F8 RID: 25080 RVA: 0x00225524 File Offset: 0x00223724
		public Span<byte> GetTextColorBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060061F9 RID: 25081 RVA: 0x00225534 File Offset: 0x00223734
		public byte[] GetTextColorArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x060061FA RID: 25082 RVA: 0x0022554C File Offset: 0x0022374C
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

		// Token: 0x060061FB RID: 25083 RVA: 0x00225584 File Offset: 0x00223784
		public Span<byte> GetStrokeColorBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060061FC RID: 25084 RVA: 0x00225594 File Offset: 0x00223794
		public byte[] GetStrokeColorArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x060061FD RID: 25085 RVA: 0x002255AC File Offset: 0x002237AC
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

		// Token: 0x060061FE RID: 25086 RVA: 0x002255E4 File Offset: 0x002237E4
		public Span<byte> GetCritTextColorBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060061FF RID: 25087 RVA: 0x002255F4 File Offset: 0x002237F4
		public byte[] GetCritTextColorArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x06006200 RID: 25088 RVA: 0x0022560C File Offset: 0x0022380C
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

		// Token: 0x06006201 RID: 25089 RVA: 0x00225644 File Offset: 0x00223844
		public Span<byte> GetCritStrokeColorBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06006202 RID: 25090 RVA: 0x00225654 File Offset: 0x00223854
		public byte[] GetCritStrokeColorArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x06006203 RID: 25091 RVA: 0x0022566C File Offset: 0x0022386C
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

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x06006204 RID: 25092 RVA: 0x002256AC File Offset: 0x002238AC
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

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x06006205 RID: 25093 RVA: 0x002256EC File Offset: 0x002238EC
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

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x06006206 RID: 25094 RVA: 0x0022572C File Offset: 0x0022392C
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

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x06006207 RID: 25095 RVA: 0x0022576C File Offset: 0x0022396C
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

		// Token: 0x06006208 RID: 25096 RVA: 0x002257A4 File Offset: 0x002239A4
		public Span<byte> GetOwnDamageSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06006209 RID: 25097 RVA: 0x002257B4 File Offset: 0x002239B4
		public byte[] GetOwnDamageSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x0600620A RID: 25098 RVA: 0x002257CC File Offset: 0x002239CC
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

		// Token: 0x0600620B RID: 25099 RVA: 0x00225804 File Offset: 0x00223A04
		public Span<byte> GetOwnCriticalDamageSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600620C RID: 25100 RVA: 0x00225814 File Offset: 0x00223A14
		public byte[] GetOwnCriticalDamageSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x0600620D RID: 25101 RVA: 0x0022582C File Offset: 0x00223A2C
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

		// Token: 0x0600620E RID: 25102 RVA: 0x00225864 File Offset: 0x00223A64
		public Span<byte> GetMonsterDamageSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600620F RID: 25103 RVA: 0x00225874 File Offset: 0x00223A74
		public byte[] GetMonsterDamageSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x06006210 RID: 25104 RVA: 0x0022588C File Offset: 0x00223A8C
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

		// Token: 0x06006211 RID: 25105 RVA: 0x002258C4 File Offset: 0x00223AC4
		public Span<byte> GetMonsterCriticalDamageSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06006212 RID: 25106 RVA: 0x002258D4 File Offset: 0x00223AD4
		public byte[] GetMonsterCriticalDamageSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x06006213 RID: 25107 RVA: 0x002258EC File Offset: 0x00223AEC
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

		// Token: 0x06006214 RID: 25108 RVA: 0x00225924 File Offset: 0x00223B24
		public Span<byte> GetDamageTextSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x06006215 RID: 25109 RVA: 0x00225934 File Offset: 0x00223B34
		public byte[] GetDamageTextSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x06006216 RID: 25110 RVA: 0x0022594C File Offset: 0x00223B4C
		public bool IsPreload
		{
			get
			{
				int num = this.__p.__offset(38);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06006217 RID: 25111 RVA: 0x0022598C File Offset: 0x00223B8C
		public string OwnCommonDamageCurvePath(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x06006218 RID: 25112 RVA: 0x002259C8 File Offset: 0x00223BC8
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

		// Token: 0x06006219 RID: 25113 RVA: 0x002259F4 File Offset: 0x00223BF4
		public string OwnCriticalDamageCurvePath(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x0600621A RID: 25114 RVA: 0x00225A30 File Offset: 0x00223C30
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

		// Token: 0x0600621B RID: 25115 RVA: 0x00225A5C File Offset: 0x00223C5C
		public string MonsterCommonDamageCurvePath(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x0600621C RID: 25116 RVA: 0x00225A98 File Offset: 0x00223C98
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

		// Token: 0x0600621D RID: 25117 RVA: 0x00225AC4 File Offset: 0x00223CC4
		public string MonsterCriticalDamageCurvePath(int j)
		{
			int num = this.__p.__offset(46);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x0600621E RID: 25118 RVA: 0x00225B00 File Offset: 0x00223D00
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

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x0600621F RID: 25119 RVA: 0x00225B2C File Offset: 0x00223D2C
		public bool UseForOptimization
		{
			get
			{
				int num = this.__p.__offset(48);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x06006220 RID: 25120 RVA: 0x00225B6C File Offset: 0x00223D6C
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

		// Token: 0x06006221 RID: 25121 RVA: 0x00225BA4 File Offset: 0x00223DA4
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x06006222 RID: 25122 RVA: 0x00225BB4 File Offset: 0x00223DB4
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x06006223 RID: 25123 RVA: 0x00225BCC File Offset: 0x00223DCC
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

		// Token: 0x06006224 RID: 25124 RVA: 0x00225C0D File Offset: 0x00223E0D
		[NullableContext(1)]
		public string[] MonsterCommonDamageCurvePath()
		{
			return this.MonsterCommonDamageCurvePathIter().ToArray<string>();
		}

		// Token: 0x06006225 RID: 25125 RVA: 0x00225C1A File Offset: 0x00223E1A
		[NullableContext(1)]
		public IEnumerable<string> MonsterCommonDamageCurvePathIter()
		{
			DamageText.<MonsterCommonDamageCurvePathIter>d__89 <MonsterCommonDamageCurvePathIter>d__ = new DamageText.<MonsterCommonDamageCurvePathIter>d__89(-2);
			<MonsterCommonDamageCurvePathIter>d__.<>3__<>4__this = this;
			return <MonsterCommonDamageCurvePathIter>d__;
		}

		// Token: 0x06006226 RID: 25126 RVA: 0x00225C2F File Offset: 0x00223E2F
		[NullableContext(1)]
		public string[] MonsterCriticalDamageCurvePath()
		{
			return this.MonsterCriticalDamageCurvePathIter().ToArray<string>();
		}

		// Token: 0x06006227 RID: 25127 RVA: 0x00225C3C File Offset: 0x00223E3C
		[NullableContext(1)]
		public IEnumerable<string> MonsterCriticalDamageCurvePathIter()
		{
			DamageText.<MonsterCriticalDamageCurvePathIter>d__91 <MonsterCriticalDamageCurvePathIter>d__ = new DamageText.<MonsterCriticalDamageCurvePathIter>d__91(-2);
			<MonsterCriticalDamageCurvePathIter>d__.<>3__<>4__this = this;
			return <MonsterCriticalDamageCurvePathIter>d__;
		}

		// Token: 0x06006228 RID: 25128 RVA: 0x00225C51 File Offset: 0x00223E51
		[NullableContext(1)]
		public string[] OwnCommonDamageCurvePath()
		{
			return this.OwnCommonDamageCurvePathIter().ToArray<string>();
		}

		// Token: 0x06006229 RID: 25129 RVA: 0x00225C5E File Offset: 0x00223E5E
		[NullableContext(1)]
		public IEnumerable<string> OwnCommonDamageCurvePathIter()
		{
			DamageText.<OwnCommonDamageCurvePathIter>d__93 <OwnCommonDamageCurvePathIter>d__ = new DamageText.<OwnCommonDamageCurvePathIter>d__93(-2);
			<OwnCommonDamageCurvePathIter>d__.<>3__<>4__this = this;
			return <OwnCommonDamageCurvePathIter>d__;
		}

		// Token: 0x0600622A RID: 25130 RVA: 0x00225C73 File Offset: 0x00223E73
		[NullableContext(1)]
		public string[] OwnCriticalDamageCurvePath()
		{
			return this.OwnCriticalDamageCurvePathIter().ToArray<string>();
		}

		// Token: 0x0600622B RID: 25131 RVA: 0x00225C80 File Offset: 0x00223E80
		[NullableContext(1)]
		public IEnumerable<string> OwnCriticalDamageCurvePathIter()
		{
			DamageText.<OwnCriticalDamageCurvePathIter>d__95 <OwnCriticalDamageCurvePathIter>d__ = new DamageText.<OwnCriticalDamageCurvePathIter>d__95(-2);
			<OwnCriticalDamageCurvePathIter>d__.<>3__<>4__this = this;
			return <OwnCriticalDamageCurvePathIter>d__;
		}

		// Token: 0x040051C1 RID: 20929
		private Table __p;
	}
}
