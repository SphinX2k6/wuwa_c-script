using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F91 RID: 3985
	public struct PassiveSkill : IFlatbufferObject
	{
		// Token: 0x170024EA RID: 9450
		// (get) Token: 0x0600A8B5 RID: 43189 RVA: 0x002C2B1C File Offset: 0x002C0D1C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A8B6 RID: 43190 RVA: 0x002C2B29 File Offset: 0x002C0D29
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A8B7 RID: 43191 RVA: 0x002C2B30 File Offset: 0x002C0D30
		public static PassiveSkill GetRootAsPassiveSkill(ByteBuffer _bb)
		{
			return PassiveSkill.GetRootAsPassiveSkill(_bb, default(PassiveSkill));
		}

		// Token: 0x0600A8B8 RID: 43192 RVA: 0x002C2B4C File Offset: 0x002C0D4C
		public static PassiveSkill GetRootAsPassiveSkill(ByteBuffer _bb, PassiveSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A8B9 RID: 43193 RVA: 0x002C2B69 File Offset: 0x002C0D69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A8BA RID: 43194 RVA: 0x002C2B78 File Offset: 0x002C0D78
		public PassiveSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170024EB RID: 9451
		// (get) Token: 0x0600A8BB RID: 43195 RVA: 0x002C2B88 File Offset: 0x002C0D88
		public long Id
		{
			get
			{
				int num = this.__p.__offset(4);
				return (long)((num != 0) ? this.__p.bb.GetDouble(num + this.__p.bb_pos) : 0.0);
			}
		}

		// Token: 0x170024EC RID: 9452
		// (get) Token: 0x0600A8BC RID: 43196 RVA: 0x002C2BD0 File Offset: 0x002C0DD0
		public string SkillDesc
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

		// Token: 0x0600A8BD RID: 43197 RVA: 0x002C2C07 File Offset: 0x002C0E07
		public Span<byte> GetSkillDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A8BE RID: 43198 RVA: 0x002C2C16 File Offset: 0x002C0E16
		public byte[] GetSkillDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170024ED RID: 9453
		// (get) Token: 0x0600A8BF RID: 43199 RVA: 0x002C2C30 File Offset: 0x002C0E30
		public float CDTime
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170024EE RID: 9454
		// (get) Token: 0x0600A8C0 RID: 43200 RVA: 0x002C2C70 File Offset: 0x002C0E70
		public float CdThreshold
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return -1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170024EF RID: 9455
		// (get) Token: 0x0600A8C1 RID: 43201 RVA: 0x002C2CB4 File Offset: 0x002C0EB4
		public int ShareGroupId
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

		// Token: 0x170024F0 RID: 9456
		// (get) Token: 0x0600A8C2 RID: 43202 RVA: 0x002C2CF4 File Offset: 0x002C0EF4
		public int MaxCount
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170024F1 RID: 9457
		// (get) Token: 0x0600A8C3 RID: 43203 RVA: 0x002C2D34 File Offset: 0x002C0F34
		public bool IsShareAllCdSkill
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170024F2 RID: 9458
		// (get) Token: 0x0600A8C4 RID: 43204 RVA: 0x002C2D74 File Offset: 0x002C0F74
		public bool IsDefaultActivated
		{
			get
			{
				int num = this.__p.__offset(18);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170024F3 RID: 9459
		// (get) Token: 0x0600A8C5 RID: 43205 RVA: 0x002C2DB4 File Offset: 0x002C0FB4
		public string TriggerType
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

		// Token: 0x0600A8C6 RID: 43206 RVA: 0x002C2DEC File Offset: 0x002C0FEC
		public Span<byte> GetTriggerTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600A8C7 RID: 43207 RVA: 0x002C2DFC File Offset: 0x002C0FFC
		public byte[] GetTriggerTypeArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170024F4 RID: 9460
		// (get) Token: 0x0600A8C8 RID: 43208 RVA: 0x002C2E14 File Offset: 0x002C1014
		public int ExecuteType
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

		// Token: 0x0600A8C9 RID: 43209 RVA: 0x002C2E54 File Offset: 0x002C1054
		public string TriggerPreset(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170024F5 RID: 9461
		// (get) Token: 0x0600A8CA RID: 43210 RVA: 0x002C2E90 File Offset: 0x002C1090
		public int TriggerPresetLength
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

		// Token: 0x170024F6 RID: 9462
		// (get) Token: 0x0600A8CB RID: 43211 RVA: 0x002C2EBC File Offset: 0x002C10BC
		public string TriggerParams
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A8CC RID: 43212 RVA: 0x002C2EF4 File Offset: 0x002C10F4
		public Span<byte> GetTriggerParamsBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600A8CD RID: 43213 RVA: 0x002C2F04 File Offset: 0x002C1104
		public byte[] GetTriggerParamsArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x170024F7 RID: 9463
		// (get) Token: 0x0600A8CE RID: 43214 RVA: 0x002C2F1C File Offset: 0x002C111C
		public string TriggerFormula
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

		// Token: 0x0600A8CF RID: 43215 RVA: 0x002C2F54 File Offset: 0x002C1154
		public Span<byte> GetTriggerFormulaBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600A8D0 RID: 43216 RVA: 0x002C2F64 File Offset: 0x002C1164
		public byte[] GetTriggerFormulaArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A8D1 RID: 43217 RVA: 0x002C2F7C File Offset: 0x002C117C
		public long SubSkillAction(int j)
		{
			int num = this.__p.__offset(30);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x170024F8 RID: 9464
		// (get) Token: 0x0600A8D2 RID: 43218 RVA: 0x002C2FC8 File Offset: 0x002C11C8
		public int SubSkillActionLength
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

		// Token: 0x0600A8D3 RID: 43219 RVA: 0x002C2FF4 File Offset: 0x002C11F4
		public Span<long> GetSubSkillActionBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(30, 8));
		}

		// Token: 0x0600A8D4 RID: 43220 RVA: 0x002C3009 File Offset: 0x002C1209
		public long[] GetSubSkillActionArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(30) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x170024F9 RID: 9465
		// (get) Token: 0x0600A8D5 RID: 43221 RVA: 0x002C3048 File Offset: 0x002C1248
		public string InstigatorType
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

		// Token: 0x0600A8D6 RID: 43222 RVA: 0x002C3080 File Offset: 0x002C1280
		public Span<byte> GetInstigatorTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600A8D7 RID: 43223 RVA: 0x002C3090 File Offset: 0x002C1290
		public byte[] GetInstigatorTypeArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x170024FA RID: 9466
		// (get) Token: 0x0600A8D8 RID: 43224 RVA: 0x002C30A8 File Offset: 0x002C12A8
		public int ActionBaseProbability
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170024FB RID: 9467
		// (get) Token: 0x0600A8D9 RID: 43225 RVA: 0x002C30E8 File Offset: 0x002C12E8
		public string SkillAction
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

		// Token: 0x0600A8DA RID: 43226 RVA: 0x002C3120 File Offset: 0x002C1320
		public Span<byte> GetSkillActionBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600A8DB RID: 43227 RVA: 0x002C3130 File Offset: 0x002C1330
		public byte[] GetSkillActionArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A8DC RID: 43228 RVA: 0x002C3148 File Offset: 0x002C1348
		public string SkillActionParams(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170024FC RID: 9468
		// (get) Token: 0x0600A8DD RID: 43229 RVA: 0x002C3184 File Offset: 0x002C1384
		public int SkillActionParamsLength
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

		// Token: 0x170024FD RID: 9469
		// (get) Token: 0x0600A8DE RID: 43230 RVA: 0x002C31B0 File Offset: 0x002C13B0
		public string ActionScriptParams
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A8DF RID: 43231 RVA: 0x002C31E8 File Offset: 0x002C13E8
		public Span<byte> GetActionScriptParamsBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600A8E0 RID: 43232 RVA: 0x002C31F8 File Offset: 0x002C13F8
		public byte[] GetActionScriptParamsArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x170024FE RID: 9470
		// (get) Token: 0x0600A8E1 RID: 43233 RVA: 0x002C3210 File Offset: 0x002C1410
		public string SkillActionScript
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

		// Token: 0x0600A8E2 RID: 43234 RVA: 0x002C3248 File Offset: 0x002C1448
		public Span<byte> GetSkillActionScriptBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600A8E3 RID: 43235 RVA: 0x002C3258 File Offset: 0x002C1458
		public byte[] GetSkillActionScriptArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x170024FF RID: 9471
		// (get) Token: 0x0600A8E4 RID: 43236 RVA: 0x002C3270 File Offset: 0x002C1470
		public int ActionExecuteFlag
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002500 RID: 9472
		// (get) Token: 0x0600A8E5 RID: 43237 RVA: 0x002C32B0 File Offset: 0x002C14B0
		public string CDType
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

		// Token: 0x0600A8E6 RID: 43238 RVA: 0x002C32E8 File Offset: 0x002C14E8
		public Span<byte> GetCDTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0600A8E7 RID: 43239 RVA: 0x002C32F8 File Offset: 0x002C14F8
		public byte[] GetCDTypeArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A8E8 RID: 43240 RVA: 0x002C3310 File Offset: 0x002C1510
		[NullableContext(1)]
		public string[] SkillActionParams()
		{
			return this.SkillActionParamsIter().ToArray<string>();
		}

		// Token: 0x0600A8E9 RID: 43241 RVA: 0x002C331D File Offset: 0x002C151D
		[NullableContext(1)]
		public IEnumerable<string> SkillActionParamsIter()
		{
			PassiveSkill.<SkillActionParamsIter>d__76 <SkillActionParamsIter>d__ = new PassiveSkill.<SkillActionParamsIter>d__76(-2);
			<SkillActionParamsIter>d__.<>3__<>4__this = this;
			return <SkillActionParamsIter>d__;
		}

		// Token: 0x0600A8EA RID: 43242 RVA: 0x002C3332 File Offset: 0x002C1532
		[NullableContext(1)]
		public long[] SubSkillAction()
		{
			return this.GetSubSkillActionArray();
		}

		// Token: 0x0600A8EB RID: 43243 RVA: 0x002C333A File Offset: 0x002C153A
		[NullableContext(1)]
		public IEnumerable<long> SubSkillActionIter()
		{
			PassiveSkill.<SubSkillActionIter>d__78 <SubSkillActionIter>d__ = new PassiveSkill.<SubSkillActionIter>d__78(-2);
			<SubSkillActionIter>d__.<>3__<>4__this = this;
			return <SubSkillActionIter>d__;
		}

		// Token: 0x0600A8EC RID: 43244 RVA: 0x002C334F File Offset: 0x002C154F
		[NullableContext(1)]
		public string[] TriggerPreset()
		{
			return this.TriggerPresetIter().ToArray<string>();
		}

		// Token: 0x0600A8ED RID: 43245 RVA: 0x002C335C File Offset: 0x002C155C
		[NullableContext(1)]
		public IEnumerable<string> TriggerPresetIter()
		{
			PassiveSkill.<TriggerPresetIter>d__80 <TriggerPresetIter>d__ = new PassiveSkill.<TriggerPresetIter>d__80(-2);
			<TriggerPresetIter>d__.<>3__<>4__this = this;
			return <TriggerPresetIter>d__;
		}

		// Token: 0x04005547 RID: 21831
		private Table __p;
	}
}
