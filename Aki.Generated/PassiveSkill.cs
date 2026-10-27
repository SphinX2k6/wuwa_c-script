using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EAC RID: 3756
	public struct PassiveSkill : IFlatbufferObject
	{
		// Token: 0x17002485 RID: 9349
		// (get) Token: 0x0600A295 RID: 41621 RVA: 0x002A5784 File Offset: 0x002A3984
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A296 RID: 41622 RVA: 0x002A5791 File Offset: 0x002A3991
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A297 RID: 41623 RVA: 0x002A5798 File Offset: 0x002A3998
		public static PassiveSkill GetRootAsPassiveSkill(ByteBuffer _bb)
		{
			return PassiveSkill.GetRootAsPassiveSkill(_bb, default(PassiveSkill));
		}

		// Token: 0x0600A298 RID: 41624 RVA: 0x002A57B4 File Offset: 0x002A39B4
		public static PassiveSkill GetRootAsPassiveSkill(ByteBuffer _bb, PassiveSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A299 RID: 41625 RVA: 0x002A57D1 File Offset: 0x002A39D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A29A RID: 41626 RVA: 0x002A57E0 File Offset: 0x002A39E0
		public PassiveSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002486 RID: 9350
		// (get) Token: 0x0600A29B RID: 41627 RVA: 0x002A57F0 File Offset: 0x002A39F0
		public long Id
		{
			get
			{
				int num = this.__p.__offset(4);
				return (long)((num != 0) ? this.__p.bb.GetDouble(num + this.__p.bb_pos) : 0.0);
			}
		}

		// Token: 0x17002487 RID: 9351
		// (get) Token: 0x0600A29C RID: 41628 RVA: 0x002A5838 File Offset: 0x002A3A38
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

		// Token: 0x0600A29D RID: 41629 RVA: 0x002A586F File Offset: 0x002A3A6F
		public Span<byte> GetSkillDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A29E RID: 41630 RVA: 0x002A587E File Offset: 0x002A3A7E
		public byte[] GetSkillDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002488 RID: 9352
		// (get) Token: 0x0600A29F RID: 41631 RVA: 0x002A5898 File Offset: 0x002A3A98
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

		// Token: 0x17002489 RID: 9353
		// (get) Token: 0x0600A2A0 RID: 41632 RVA: 0x002A58D8 File Offset: 0x002A3AD8
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

		// Token: 0x1700248A RID: 9354
		// (get) Token: 0x0600A2A1 RID: 41633 RVA: 0x002A591C File Offset: 0x002A3B1C
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

		// Token: 0x1700248B RID: 9355
		// (get) Token: 0x0600A2A2 RID: 41634 RVA: 0x002A595C File Offset: 0x002A3B5C
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

		// Token: 0x1700248C RID: 9356
		// (get) Token: 0x0600A2A3 RID: 41635 RVA: 0x002A599C File Offset: 0x002A3B9C
		public bool IsShareAllCdSkill
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700248D RID: 9357
		// (get) Token: 0x0600A2A4 RID: 41636 RVA: 0x002A59DC File Offset: 0x002A3BDC
		public bool IsDefaultActivated
		{
			get
			{
				int num = this.__p.__offset(18);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700248E RID: 9358
		// (get) Token: 0x0600A2A5 RID: 41637 RVA: 0x002A5A1C File Offset: 0x002A3C1C
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

		// Token: 0x0600A2A6 RID: 41638 RVA: 0x002A5A54 File Offset: 0x002A3C54
		public Span<byte> GetTriggerTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600A2A7 RID: 41639 RVA: 0x002A5A64 File Offset: 0x002A3C64
		public byte[] GetTriggerTypeArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x1700248F RID: 9359
		// (get) Token: 0x0600A2A8 RID: 41640 RVA: 0x002A5A7C File Offset: 0x002A3C7C
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

		// Token: 0x0600A2A9 RID: 41641 RVA: 0x002A5ABC File Offset: 0x002A3CBC
		public string TriggerPreset(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002490 RID: 9360
		// (get) Token: 0x0600A2AA RID: 41642 RVA: 0x002A5AF8 File Offset: 0x002A3CF8
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

		// Token: 0x17002491 RID: 9361
		// (get) Token: 0x0600A2AB RID: 41643 RVA: 0x002A5B24 File Offset: 0x002A3D24
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

		// Token: 0x0600A2AC RID: 41644 RVA: 0x002A5B5C File Offset: 0x002A3D5C
		public Span<byte> GetTriggerParamsBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600A2AD RID: 41645 RVA: 0x002A5B6C File Offset: 0x002A3D6C
		public byte[] GetTriggerParamsArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17002492 RID: 9362
		// (get) Token: 0x0600A2AE RID: 41646 RVA: 0x002A5B84 File Offset: 0x002A3D84
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

		// Token: 0x0600A2AF RID: 41647 RVA: 0x002A5BBC File Offset: 0x002A3DBC
		public Span<byte> GetTriggerFormulaBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600A2B0 RID: 41648 RVA: 0x002A5BCC File Offset: 0x002A3DCC
		public byte[] GetTriggerFormulaArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A2B1 RID: 41649 RVA: 0x002A5BE4 File Offset: 0x002A3DE4
		public long SubSkillAction(int j)
		{
			int num = this.__p.__offset(30);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17002493 RID: 9363
		// (get) Token: 0x0600A2B2 RID: 41650 RVA: 0x002A5C30 File Offset: 0x002A3E30
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

		// Token: 0x0600A2B3 RID: 41651 RVA: 0x002A5C5C File Offset: 0x002A3E5C
		public Span<long> GetSubSkillActionBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(30, 8));
		}

		// Token: 0x0600A2B4 RID: 41652 RVA: 0x002A5C71 File Offset: 0x002A3E71
		public long[] GetSubSkillActionArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(30) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x17002494 RID: 9364
		// (get) Token: 0x0600A2B5 RID: 41653 RVA: 0x002A5CB0 File Offset: 0x002A3EB0
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

		// Token: 0x0600A2B6 RID: 41654 RVA: 0x002A5CE8 File Offset: 0x002A3EE8
		public Span<byte> GetInstigatorTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600A2B7 RID: 41655 RVA: 0x002A5CF8 File Offset: 0x002A3EF8
		public byte[] GetInstigatorTypeArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17002495 RID: 9365
		// (get) Token: 0x0600A2B8 RID: 41656 RVA: 0x002A5D10 File Offset: 0x002A3F10
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

		// Token: 0x17002496 RID: 9366
		// (get) Token: 0x0600A2B9 RID: 41657 RVA: 0x002A5D50 File Offset: 0x002A3F50
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

		// Token: 0x0600A2BA RID: 41658 RVA: 0x002A5D88 File Offset: 0x002A3F88
		public Span<byte> GetSkillActionBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600A2BB RID: 41659 RVA: 0x002A5D98 File Offset: 0x002A3F98
		public byte[] GetSkillActionArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A2BC RID: 41660 RVA: 0x002A5DB0 File Offset: 0x002A3FB0
		public string SkillActionParams(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002497 RID: 9367
		// (get) Token: 0x0600A2BD RID: 41661 RVA: 0x002A5DEC File Offset: 0x002A3FEC
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

		// Token: 0x17002498 RID: 9368
		// (get) Token: 0x0600A2BE RID: 41662 RVA: 0x002A5E18 File Offset: 0x002A4018
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

		// Token: 0x0600A2BF RID: 41663 RVA: 0x002A5E50 File Offset: 0x002A4050
		public Span<byte> GetActionScriptParamsBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600A2C0 RID: 41664 RVA: 0x002A5E60 File Offset: 0x002A4060
		public byte[] GetActionScriptParamsArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17002499 RID: 9369
		// (get) Token: 0x0600A2C1 RID: 41665 RVA: 0x002A5E78 File Offset: 0x002A4078
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

		// Token: 0x0600A2C2 RID: 41666 RVA: 0x002A5EB0 File Offset: 0x002A40B0
		public Span<byte> GetSkillActionScriptBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600A2C3 RID: 41667 RVA: 0x002A5EC0 File Offset: 0x002A40C0
		public byte[] GetSkillActionScriptArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x1700249A RID: 9370
		// (get) Token: 0x0600A2C4 RID: 41668 RVA: 0x002A5ED8 File Offset: 0x002A40D8
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

		// Token: 0x1700249B RID: 9371
		// (get) Token: 0x0600A2C5 RID: 41669 RVA: 0x002A5F18 File Offset: 0x002A4118
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

		// Token: 0x0600A2C6 RID: 41670 RVA: 0x002A5F50 File Offset: 0x002A4150
		public Span<byte> GetCDTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0600A2C7 RID: 41671 RVA: 0x002A5F60 File Offset: 0x002A4160
		public byte[] GetCDTypeArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A2C8 RID: 41672 RVA: 0x002A5F78 File Offset: 0x002A4178
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SkillActionParamsIter()或GetSkillActionParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] SkillActionParams()
		{
			return this.SkillActionParamsIter().ToArray<string>();
		}

		// Token: 0x0600A2C9 RID: 41673 RVA: 0x002A5F85 File Offset: 0x002A4185
		[NullableContext(1)]
		public readonly IEnumerable<string> SkillActionParamsIter()
		{
			PassiveSkill.<SkillActionParamsIter>d__76 <SkillActionParamsIter>d__ = new PassiveSkill.<SkillActionParamsIter>d__76(-2);
			<SkillActionParamsIter>d__.<>3__<>4__this = this;
			return <SkillActionParamsIter>d__;
		}

		// Token: 0x0600A2CA RID: 41674 RVA: 0x002A5F9C File Offset: 0x002A419C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SubSkillActionIter()或GetSubSkillActionBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] SubSkillAction()
		{
			PassiveSkill passiveSkill = this;
			return passiveSkill.GetSubSkillActionArray() ?? Array.Empty<long>();
		}

		// Token: 0x0600A2CB RID: 41675 RVA: 0x002A5FC0 File Offset: 0x002A41C0
		[NullableContext(1)]
		public readonly IEnumerable<long> SubSkillActionIter()
		{
			PassiveSkill.<SubSkillActionIter>d__78 <SubSkillActionIter>d__ = new PassiveSkill.<SubSkillActionIter>d__78(-2);
			<SubSkillActionIter>d__.<>3__<>4__this = this;
			return <SubSkillActionIter>d__;
		}

		// Token: 0x0600A2CC RID: 41676 RVA: 0x002A5FD5 File Offset: 0x002A41D5
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TriggerPresetIter()或GetTriggerPresetBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] TriggerPreset()
		{
			return this.TriggerPresetIter().ToArray<string>();
		}

		// Token: 0x0600A2CD RID: 41677 RVA: 0x002A5FE2 File Offset: 0x002A41E2
		[NullableContext(1)]
		public readonly IEnumerable<string> TriggerPresetIter()
		{
			PassiveSkill.<TriggerPresetIter>d__80 <TriggerPresetIter>d__ = new PassiveSkill.<TriggerPresetIter>d__80(-2);
			<TriggerPresetIter>d__.<>3__<>4__this = this;
			return <TriggerPresetIter>d__;
		}

		// Token: 0x04004F62 RID: 20322
		private Table __p;
	}
}
