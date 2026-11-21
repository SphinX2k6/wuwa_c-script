using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C3E RID: 27710
	public struct IDisableBattleSkillOptions : IFlatbufferObject
	{
		// Token: 0x1700CB07 RID: 51975
		// (get) Token: 0x0602FAEC RID: 195308 RVA: 0x0067E998 File Offset: 0x0067CB98
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FAED RID: 195309 RVA: 0x0067E9A5 File Offset: 0x0067CBA5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FAEE RID: 195310 RVA: 0x0067E9AC File Offset: 0x0067CBAC
		public static IDisableBattleSkillOptions GetRootAsIDisableBattleSkillOptions(ByteBuffer _bb)
		{
			return IDisableBattleSkillOptions.GetRootAsIDisableBattleSkillOptions(_bb, default(IDisableBattleSkillOptions));
		}

		// Token: 0x0602FAEF RID: 195311 RVA: 0x0067E9C8 File Offset: 0x0067CBC8
		public static IDisableBattleSkillOptions GetRootAsIDisableBattleSkillOptions(ByteBuffer _bb, IDisableBattleSkillOptions obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FAF0 RID: 195312 RVA: 0x0067E9E5 File Offset: 0x0067CBE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FAF1 RID: 195313 RVA: 0x0067E9F4 File Offset: 0x0067CBF4
		public IDisableBattleSkillOptions __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CB08 RID: 51976
		// (get) Token: 0x0602FAF2 RID: 195314 RVA: 0x0067EA04 File Offset: 0x0067CC04
		public bool IsDisablePhantomSkill
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CB09 RID: 51977
		// (get) Token: 0x0602FAF3 RID: 195315 RVA: 0x0067EA44 File Offset: 0x0067CC44
		public bool IsDisableCharacterSkill
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CB0A RID: 51978
		// (get) Token: 0x0602FAF4 RID: 195316 RVA: 0x0067EA84 File Offset: 0x0067CC84
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

		// Token: 0x1700CB0B RID: 51979
		// (get) Token: 0x0602FAF5 RID: 195317 RVA: 0x0067EAE4 File Offset: 0x0067CCE4
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

		// Token: 0x0602FAF6 RID: 195318 RVA: 0x0067EB21 File Offset: 0x0067CD21
		public static Offset<IDisableBattleSkillOptions> CreateIDisableBattleSkillOptions(FlatBufferBuilder builder, bool IsDisablePhantomSkill = false, bool IsDisableCharacterSkill = false, Offset<IDisableCharacterSectionalSkillOption> IsDisableCharacterSectionalSkillOffset = default(Offset<IDisableCharacterSectionalSkillOption>), byte NullMask = 0)
		{
			builder.StartTable(4);
			IDisableBattleSkillOptions.AddIsDisableCharacterSectionalSkill(builder, IsDisableCharacterSectionalSkillOffset);
			IDisableBattleSkillOptions.AddNullMask(builder, NullMask);
			IDisableBattleSkillOptions.AddIsDisableCharacterSkill(builder, IsDisableCharacterSkill);
			IDisableBattleSkillOptions.AddIsDisablePhantomSkill(builder, IsDisablePhantomSkill);
			return IDisableBattleSkillOptions.EndIDisableBattleSkillOptions(builder);
		}

		// Token: 0x0602FAF7 RID: 195319 RVA: 0x0067EB4D File Offset: 0x0067CD4D
		public static void StartIDisableBattleSkillOptions(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602FAF8 RID: 195320 RVA: 0x0067EB56 File Offset: 0x0067CD56
		public static void AddIsDisablePhantomSkill(FlatBufferBuilder builder, bool isDisablePhantomSkill)
		{
			builder.AddBool(0, isDisablePhantomSkill, false);
		}

		// Token: 0x0602FAF9 RID: 195321 RVA: 0x0067EB61 File Offset: 0x0067CD61
		public static void AddIsDisableCharacterSkill(FlatBufferBuilder builder, bool isDisableCharacterSkill)
		{
			builder.AddBool(1, isDisableCharacterSkill, false);
		}

		// Token: 0x0602FAFA RID: 195322 RVA: 0x0067EB6C File Offset: 0x0067CD6C
		public static void AddIsDisableCharacterSectionalSkill(FlatBufferBuilder builder, Offset<IDisableCharacterSectionalSkillOption> isDisableCharacterSectionalSkillOffset)
		{
			builder.AddOffset(2, isDisableCharacterSectionalSkillOffset.Value, 0);
		}

		// Token: 0x0602FAFB RID: 195323 RVA: 0x0067EB7C File Offset: 0x0067CD7C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602FAFC RID: 195324 RVA: 0x0067EB87 File Offset: 0x0067CD87
		public static Offset<IDisableBattleSkillOptions> EndIDisableBattleSkillOptions(FlatBufferBuilder builder)
		{
			return new Offset<IDisableBattleSkillOptions>(builder.EndTable());
		}

		// Token: 0x0602FAFD RID: 195325 RVA: 0x0067EB94 File Offset: 0x0067CD94
		public IDisableBattleSkillOptionsT UnPack()
		{
			IDisableBattleSkillOptionsT disableBattleSkillOptionsT = new IDisableBattleSkillOptionsT();
			this.UnPackTo(disableBattleSkillOptionsT);
			return disableBattleSkillOptionsT;
		}

		// Token: 0x0602FAFE RID: 195326 RVA: 0x0067EBB0 File Offset: 0x0067CDB0
		public void UnPackTo(IDisableBattleSkillOptionsT _o)
		{
			_o.IsDisablePhantomSkill = this.IsDisablePhantomSkill;
			_o.IsDisableCharacterSkill = this.IsDisableCharacterSkill;
			_o.IsDisableCharacterSectionalSkill = ((this.IsDisableCharacterSectionalSkill != null) ? this.IsDisableCharacterSectionalSkill.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602FAFF RID: 195327 RVA: 0x0067EC10 File Offset: 0x0067CE10
		public static Offset<IDisableBattleSkillOptions> Pack(FlatBufferBuilder builder, IDisableBattleSkillOptionsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDisableBattleSkillOptions>);
			}
			Offset<IDisableCharacterSectionalSkillOption> isDisableCharacterSectionalSkillOffset = (_o.IsDisableCharacterSectionalSkill == null) ? default(Offset<IDisableCharacterSectionalSkillOption>) : IDisableCharacterSectionalSkillOption.Pack(builder, _o.IsDisableCharacterSectionalSkill);
			return IDisableBattleSkillOptions.CreateIDisableBattleSkillOptions(builder, _o.IsDisablePhantomSkill, _o.IsDisableCharacterSkill, isDisableCharacterSectionalSkillOffset, _o.NullMask);
		}

		// Token: 0x04011A4A RID: 72266
		private Table __p;
	}
}
