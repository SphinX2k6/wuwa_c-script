using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065D6 RID: 26070
	public struct IDisableBattleSkillOptions : IFlatbufferObject
	{
		// Token: 0x1700C178 RID: 49528
		// (get) Token: 0x0602D368 RID: 185192 RVA: 0x006327D4 File Offset: 0x006309D4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D369 RID: 185193 RVA: 0x006327E1 File Offset: 0x006309E1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D36A RID: 185194 RVA: 0x006327E8 File Offset: 0x006309E8
		public static IDisableBattleSkillOptions GetRootAsIDisableBattleSkillOptions(ByteBuffer _bb)
		{
			return IDisableBattleSkillOptions.GetRootAsIDisableBattleSkillOptions(_bb, default(IDisableBattleSkillOptions));
		}

		// Token: 0x0602D36B RID: 185195 RVA: 0x00632804 File Offset: 0x00630A04
		public static IDisableBattleSkillOptions GetRootAsIDisableBattleSkillOptions(ByteBuffer _bb, IDisableBattleSkillOptions obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D36C RID: 185196 RVA: 0x00632821 File Offset: 0x00630A21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D36D RID: 185197 RVA: 0x00632830 File Offset: 0x00630A30
		public IDisableBattleSkillOptions __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C179 RID: 49529
		// (get) Token: 0x0602D36E RID: 185198 RVA: 0x00632840 File Offset: 0x00630A40
		public bool IsDisablePhantomSkill
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C17A RID: 49530
		// (get) Token: 0x0602D36F RID: 185199 RVA: 0x00632880 File Offset: 0x00630A80
		public bool IsDisableCharacterSkill
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C17B RID: 49531
		// (get) Token: 0x0602D370 RID: 185200 RVA: 0x006328C0 File Offset: 0x00630AC0
		public IDisableCharacterSectionalSkillOption? IsDisableCharacterSectionalSkill
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IDisableCharacterSectionalSkillOption?(default(IDisableCharacterSectionalSkillOption).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C17C RID: 49532
		// (get) Token: 0x0602D371 RID: 185201 RVA: 0x00632920 File Offset: 0x00630B20
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D372 RID: 185202 RVA: 0x0063295D File Offset: 0x00630B5D
		public static Offset<IDisableBattleSkillOptions> CreateIDisableBattleSkillOptions(FlatBufferBuilder builder, bool IsDisablePhantomSkill = false, bool IsDisableCharacterSkill = false, Offset<IDisableCharacterSectionalSkillOption> IsDisableCharacterSectionalSkillOffset = default(Offset<IDisableCharacterSectionalSkillOption>), byte NullMask = 0)
		{
			builder.StartTable(4);
			IDisableBattleSkillOptions.AddIsDisableCharacterSectionalSkill(builder, IsDisableCharacterSectionalSkillOffset);
			IDisableBattleSkillOptions.AddNullMask(builder, NullMask);
			IDisableBattleSkillOptions.AddIsDisableCharacterSkill(builder, IsDisableCharacterSkill);
			IDisableBattleSkillOptions.AddIsDisablePhantomSkill(builder, IsDisablePhantomSkill);
			return IDisableBattleSkillOptions.EndIDisableBattleSkillOptions(builder);
		}

		// Token: 0x0602D373 RID: 185203 RVA: 0x00632989 File Offset: 0x00630B89
		public static void StartIDisableBattleSkillOptions(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602D374 RID: 185204 RVA: 0x00632992 File Offset: 0x00630B92
		public static void AddIsDisablePhantomSkill(FlatBufferBuilder builder, bool isDisablePhantomSkill)
		{
			builder.AddBool(0, isDisablePhantomSkill, false);
		}

		// Token: 0x0602D375 RID: 185205 RVA: 0x0063299D File Offset: 0x00630B9D
		public static void AddIsDisableCharacterSkill(FlatBufferBuilder builder, bool isDisableCharacterSkill)
		{
			builder.AddBool(1, isDisableCharacterSkill, false);
		}

		// Token: 0x0602D376 RID: 185206 RVA: 0x006329A8 File Offset: 0x00630BA8
		public static void AddIsDisableCharacterSectionalSkill(FlatBufferBuilder builder, Offset<IDisableCharacterSectionalSkillOption> isDisableCharacterSectionalSkillOffset)
		{
			builder.AddOffset(2, isDisableCharacterSectionalSkillOffset.Value, 0);
		}

		// Token: 0x0602D377 RID: 185207 RVA: 0x006329B8 File Offset: 0x00630BB8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602D378 RID: 185208 RVA: 0x006329C3 File Offset: 0x00630BC3
		public static Offset<IDisableBattleSkillOptions> EndIDisableBattleSkillOptions(FlatBufferBuilder builder)
		{
			return new Offset<IDisableBattleSkillOptions>(builder.EndTable());
		}

		// Token: 0x0602D379 RID: 185209 RVA: 0x006329D0 File Offset: 0x00630BD0
		public IDisableBattleSkillOptionsT UnPack()
		{
			IDisableBattleSkillOptionsT disableBattleSkillOptionsT = new IDisableBattleSkillOptionsT();
			this.UnPackTo(disableBattleSkillOptionsT);
			return disableBattleSkillOptionsT;
		}

		// Token: 0x0602D37A RID: 185210 RVA: 0x006329EC File Offset: 0x00630BEC
		public void UnPackTo(IDisableBattleSkillOptionsT _o)
		{
			_o.IsDisablePhantomSkill = this.IsDisablePhantomSkill;
			_o.IsDisableCharacterSkill = this.IsDisableCharacterSkill;
			_o.IsDisableCharacterSectionalSkill = ((this.IsDisableCharacterSectionalSkill != null) ? this.IsDisableCharacterSectionalSkill.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602D37B RID: 185211 RVA: 0x00632A4C File Offset: 0x00630C4C
		public static Offset<IDisableBattleSkillOptions> Pack(FlatBufferBuilder builder, IDisableBattleSkillOptionsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDisableBattleSkillOptions>);
			}
			Offset<IDisableCharacterSectionalSkillOption> isDisableCharacterSectionalSkillOffset = (_o.IsDisableCharacterSectionalSkill == null) ? default(Offset<IDisableCharacterSectionalSkillOption>) : IDisableCharacterSectionalSkillOption.Pack(builder, _o.IsDisableCharacterSectionalSkill);
			return IDisableBattleSkillOptions.CreateIDisableBattleSkillOptions(builder, _o.IsDisablePhantomSkill, _o.IsDisableCharacterSkill, isDisableCharacterSectionalSkillOffset, _o.NullMask);
		}

		// Token: 0x04010C38 RID: 68664
		private Table __p;
	}
}
