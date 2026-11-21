using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C44 RID: 27716
	public struct IDisableCharacterSectionalSkillOption : IFlatbufferObject
	{
		// Token: 0x1700CB13 RID: 51987
		// (get) Token: 0x0602FB1C RID: 195356 RVA: 0x0067EEB5 File Offset: 0x0067D0B5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FB1D RID: 195357 RVA: 0x0067EEC2 File Offset: 0x0067D0C2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FB1E RID: 195358 RVA: 0x0067EECC File Offset: 0x0067D0CC
		public static IDisableCharacterSectionalSkillOption GetRootAsIDisableCharacterSectionalSkillOption(ByteBuffer _bb)
		{
			return IDisableCharacterSectionalSkillOption.GetRootAsIDisableCharacterSectionalSkillOption(_bb, default(IDisableCharacterSectionalSkillOption));
		}

		// Token: 0x0602FB1F RID: 195359 RVA: 0x0067EEE8 File Offset: 0x0067D0E8
		public static IDisableCharacterSectionalSkillOption GetRootAsIDisableCharacterSectionalSkillOption(ByteBuffer _bb, IDisableCharacterSectionalSkillOption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FB20 RID: 195360 RVA: 0x0067EF05 File Offset: 0x0067D105
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FB21 RID: 195361 RVA: 0x0067EF14 File Offset: 0x0067D114
		public IDisableCharacterSectionalSkillOption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CB14 RID: 51988
		// (get) Token: 0x0602FB22 RID: 195362 RVA: 0x0067EF24 File Offset: 0x0067D124
		public bool DisableJump
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CB15 RID: 51989
		// (get) Token: 0x0602FB23 RID: 195363 RVA: 0x0067EF64 File Offset: 0x0067D164
		public bool DisableShowClimb
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CB16 RID: 51990
		// (get) Token: 0x0602FB24 RID: 195364 RVA: 0x0067EFA4 File Offset: 0x0067D1A4
		public bool DisableAttack
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CB17 RID: 51991
		// (get) Token: 0x0602FB25 RID: 195365 RVA: 0x0067EFE4 File Offset: 0x0067D1E4
		public bool DisableDodge
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CB18 RID: 51992
		// (get) Token: 0x0602FB26 RID: 195366 RVA: 0x0067F024 File Offset: 0x0067D224
		public bool DisableSkill1
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CB19 RID: 51993
		// (get) Token: 0x0602FB27 RID: 195367 RVA: 0x0067F064 File Offset: 0x0067D264
		public bool DisableUltimateSkill
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CB1A RID: 51994
		// (get) Token: 0x0602FB28 RID: 195368 RVA: 0x0067F0A4 File Offset: 0x0067D2A4
		public bool DisableExploreInput
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CB1B RID: 51995
		// (get) Token: 0x0602FB29 RID: 195369 RVA: 0x0067F0E4 File Offset: 0x0067D2E4
		public bool DisableSwitchRole1
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CB1C RID: 51996
		// (get) Token: 0x0602FB2A RID: 195370 RVA: 0x0067F124 File Offset: 0x0067D324
		public bool DisableSwitchRole2
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CB1D RID: 51997
		// (get) Token: 0x0602FB2B RID: 195371 RVA: 0x0067F164 File Offset: 0x0067D364
		public bool DisableSwitchRole3
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CB1E RID: 51998
		// (get) Token: 0x0602FB2C RID: 195372 RVA: 0x0067F1A4 File Offset: 0x0067D3A4
		public bool DisableLock
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CB1F RID: 51999
		// (get) Token: 0x0602FB2D RID: 195373 RVA: 0x0067F1E4 File Offset: 0x0067D3E4
		public bool DisableAim
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CB20 RID: 52000
		// (get) Token: 0x0602FB2E RID: 195374 RVA: 0x0067F224 File Offset: 0x0067D424
		public ushort NullMask
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetUshort(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FB2F RID: 195375 RVA: 0x0067F264 File Offset: 0x0067D464
		public static Offset<IDisableCharacterSectionalSkillOption> CreateIDisableCharacterSectionalSkillOption(FlatBufferBuilder builder, bool DisableJump = false, bool DisableShowClimb = false, bool DisableAttack = false, bool DisableDodge = false, bool DisableSkill1 = false, bool DisableUltimateSkill = false, bool DisableExploreInput = false, bool DisableSwitchRole1 = false, bool DisableSwitchRole2 = false, bool DisableSwitchRole3 = false, bool DisableLock = false, bool DisableAim = false, ushort NullMask = 0)
		{
			builder.StartTable(13);
			IDisableCharacterSectionalSkillOption.AddNullMask(builder, NullMask);
			IDisableCharacterSectionalSkillOption.AddDisableAim(builder, DisableAim);
			IDisableCharacterSectionalSkillOption.AddDisableLock(builder, DisableLock);
			IDisableCharacterSectionalSkillOption.AddDisableSwitchRole3(builder, DisableSwitchRole3);
			IDisableCharacterSectionalSkillOption.AddDisableSwitchRole2(builder, DisableSwitchRole2);
			IDisableCharacterSectionalSkillOption.AddDisableSwitchRole1(builder, DisableSwitchRole1);
			IDisableCharacterSectionalSkillOption.AddDisableExploreInput(builder, DisableExploreInput);
			IDisableCharacterSectionalSkillOption.AddDisableUltimateSkill(builder, DisableUltimateSkill);
			IDisableCharacterSectionalSkillOption.AddDisableSkill1(builder, DisableSkill1);
			IDisableCharacterSectionalSkillOption.AddDisableDodge(builder, DisableDodge);
			IDisableCharacterSectionalSkillOption.AddDisableAttack(builder, DisableAttack);
			IDisableCharacterSectionalSkillOption.AddDisableShowClimb(builder, DisableShowClimb);
			IDisableCharacterSectionalSkillOption.AddDisableJump(builder, DisableJump);
			return IDisableCharacterSectionalSkillOption.EndIDisableCharacterSectionalSkillOption(builder);
		}

		// Token: 0x0602FB30 RID: 195376 RVA: 0x0067F2E4 File Offset: 0x0067D4E4
		public static void StartIDisableCharacterSectionalSkillOption(FlatBufferBuilder builder)
		{
			builder.StartTable(13);
		}

		// Token: 0x0602FB31 RID: 195377 RVA: 0x0067F2EE File Offset: 0x0067D4EE
		public static void AddDisableJump(FlatBufferBuilder builder, bool disableJump)
		{
			builder.AddBool(0, disableJump, false);
		}

		// Token: 0x0602FB32 RID: 195378 RVA: 0x0067F2F9 File Offset: 0x0067D4F9
		public static void AddDisableShowClimb(FlatBufferBuilder builder, bool disableShowClimb)
		{
			builder.AddBool(1, disableShowClimb, false);
		}

		// Token: 0x0602FB33 RID: 195379 RVA: 0x0067F304 File Offset: 0x0067D504
		public static void AddDisableAttack(FlatBufferBuilder builder, bool disableAttack)
		{
			builder.AddBool(2, disableAttack, false);
		}

		// Token: 0x0602FB34 RID: 195380 RVA: 0x0067F30F File Offset: 0x0067D50F
		public static void AddDisableDodge(FlatBufferBuilder builder, bool disableDodge)
		{
			builder.AddBool(3, disableDodge, false);
		}

		// Token: 0x0602FB35 RID: 195381 RVA: 0x0067F31A File Offset: 0x0067D51A
		public static void AddDisableSkill1(FlatBufferBuilder builder, bool disableSkill1)
		{
			builder.AddBool(4, disableSkill1, false);
		}

		// Token: 0x0602FB36 RID: 195382 RVA: 0x0067F325 File Offset: 0x0067D525
		public static void AddDisableUltimateSkill(FlatBufferBuilder builder, bool disableUltimateSkill)
		{
			builder.AddBool(5, disableUltimateSkill, false);
		}

		// Token: 0x0602FB37 RID: 195383 RVA: 0x0067F330 File Offset: 0x0067D530
		public static void AddDisableExploreInput(FlatBufferBuilder builder, bool disableExploreInput)
		{
			builder.AddBool(6, disableExploreInput, false);
		}

		// Token: 0x0602FB38 RID: 195384 RVA: 0x0067F33B File Offset: 0x0067D53B
		public static void AddDisableSwitchRole1(FlatBufferBuilder builder, bool disableSwitchRole1)
		{
			builder.AddBool(7, disableSwitchRole1, false);
		}

		// Token: 0x0602FB39 RID: 195385 RVA: 0x0067F346 File Offset: 0x0067D546
		public static void AddDisableSwitchRole2(FlatBufferBuilder builder, bool disableSwitchRole2)
		{
			builder.AddBool(8, disableSwitchRole2, false);
		}

		// Token: 0x0602FB3A RID: 195386 RVA: 0x0067F351 File Offset: 0x0067D551
		public static void AddDisableSwitchRole3(FlatBufferBuilder builder, bool disableSwitchRole3)
		{
			builder.AddBool(9, disableSwitchRole3, false);
		}

		// Token: 0x0602FB3B RID: 195387 RVA: 0x0067F35D File Offset: 0x0067D55D
		public static void AddDisableLock(FlatBufferBuilder builder, bool disableLock)
		{
			builder.AddBool(10, disableLock, false);
		}

		// Token: 0x0602FB3C RID: 195388 RVA: 0x0067F369 File Offset: 0x0067D569
		public static void AddDisableAim(FlatBufferBuilder builder, bool disableAim)
		{
			builder.AddBool(11, disableAim, false);
		}

		// Token: 0x0602FB3D RID: 195389 RVA: 0x0067F375 File Offset: 0x0067D575
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(12, nullMask, 0);
		}

		// Token: 0x0602FB3E RID: 195390 RVA: 0x0067F381 File Offset: 0x0067D581
		public static Offset<IDisableCharacterSectionalSkillOption> EndIDisableCharacterSectionalSkillOption(FlatBufferBuilder builder)
		{
			return new Offset<IDisableCharacterSectionalSkillOption>(builder.EndTable());
		}

		// Token: 0x0602FB3F RID: 195391 RVA: 0x0067F390 File Offset: 0x0067D590
		public IDisableCharacterSectionalSkillOptionT UnPack()
		{
			IDisableCharacterSectionalSkillOptionT disableCharacterSectionalSkillOptionT = new IDisableCharacterSectionalSkillOptionT();
			this.UnPackTo(disableCharacterSectionalSkillOptionT);
			return disableCharacterSectionalSkillOptionT;
		}

		// Token: 0x0602FB40 RID: 195392 RVA: 0x0067F3AC File Offset: 0x0067D5AC
		public void UnPackTo(IDisableCharacterSectionalSkillOptionT _o)
		{
			_o.DisableJump = this.DisableJump;
			_o.DisableShowClimb = this.DisableShowClimb;
			_o.DisableAttack = this.DisableAttack;
			_o.DisableDodge = this.DisableDodge;
			_o.DisableSkill1 = this.DisableSkill1;
			_o.DisableUltimateSkill = this.DisableUltimateSkill;
			_o.DisableExploreInput = this.DisableExploreInput;
			_o.DisableSwitchRole1 = this.DisableSwitchRole1;
			_o.DisableSwitchRole2 = this.DisableSwitchRole2;
			_o.DisableSwitchRole3 = this.DisableSwitchRole3;
			_o.DisableLock = this.DisableLock;
			_o.DisableAim = this.DisableAim;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602FB41 RID: 195393 RVA: 0x0067F458 File Offset: 0x0067D658
		public static Offset<IDisableCharacterSectionalSkillOption> Pack(FlatBufferBuilder builder, IDisableCharacterSectionalSkillOptionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDisableCharacterSectionalSkillOption>);
			}
			return IDisableCharacterSectionalSkillOption.CreateIDisableCharacterSectionalSkillOption(builder, _o.DisableJump, _o.DisableShowClimb, _o.DisableAttack, _o.DisableDodge, _o.DisableSkill1, _o.DisableUltimateSkill, _o.DisableExploreInput, _o.DisableSwitchRole1, _o.DisableSwitchRole2, _o.DisableSwitchRole3, _o.DisableLock, _o.DisableAim, _o.NullMask);
		}

		// Token: 0x04011A51 RID: 72273
		private Table __p;
	}
}
