using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065DC RID: 26076
	public struct IDisableCharacterSectionalSkillOption : IFlatbufferObject
	{
		// Token: 0x1700C184 RID: 49540
		// (get) Token: 0x0602D398 RID: 185240 RVA: 0x00632CF1 File Offset: 0x00630EF1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D399 RID: 185241 RVA: 0x00632CFE File Offset: 0x00630EFE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D39A RID: 185242 RVA: 0x00632D08 File Offset: 0x00630F08
		public static IDisableCharacterSectionalSkillOption GetRootAsIDisableCharacterSectionalSkillOption(ByteBuffer _bb)
		{
			return IDisableCharacterSectionalSkillOption.GetRootAsIDisableCharacterSectionalSkillOption(_bb, default(IDisableCharacterSectionalSkillOption));
		}

		// Token: 0x0602D39B RID: 185243 RVA: 0x00632D24 File Offset: 0x00630F24
		public static IDisableCharacterSectionalSkillOption GetRootAsIDisableCharacterSectionalSkillOption(ByteBuffer _bb, IDisableCharacterSectionalSkillOption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D39C RID: 185244 RVA: 0x00632D41 File Offset: 0x00630F41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D39D RID: 185245 RVA: 0x00632D50 File Offset: 0x00630F50
		public IDisableCharacterSectionalSkillOption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C185 RID: 49541
		// (get) Token: 0x0602D39E RID: 185246 RVA: 0x00632D60 File Offset: 0x00630F60
		public bool DisableJump
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C186 RID: 49542
		// (get) Token: 0x0602D39F RID: 185247 RVA: 0x00632DA0 File Offset: 0x00630FA0
		public bool DisableShowClimb
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C187 RID: 49543
		// (get) Token: 0x0602D3A0 RID: 185248 RVA: 0x00632DE0 File Offset: 0x00630FE0
		public bool DisableAttack
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C188 RID: 49544
		// (get) Token: 0x0602D3A1 RID: 185249 RVA: 0x00632E20 File Offset: 0x00631020
		public bool DisableDodge
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C189 RID: 49545
		// (get) Token: 0x0602D3A2 RID: 185250 RVA: 0x00632E60 File Offset: 0x00631060
		public bool DisableSkill1
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C18A RID: 49546
		// (get) Token: 0x0602D3A3 RID: 185251 RVA: 0x00632EA0 File Offset: 0x006310A0
		public bool DisableUltimateSkill
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C18B RID: 49547
		// (get) Token: 0x0602D3A4 RID: 185252 RVA: 0x00632EE0 File Offset: 0x006310E0
		public bool DisableExploreInput
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C18C RID: 49548
		// (get) Token: 0x0602D3A5 RID: 185253 RVA: 0x00632F20 File Offset: 0x00631120
		public bool DisableSwitchRole1
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C18D RID: 49549
		// (get) Token: 0x0602D3A6 RID: 185254 RVA: 0x00632F60 File Offset: 0x00631160
		public bool DisableSwitchRole2
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C18E RID: 49550
		// (get) Token: 0x0602D3A7 RID: 185255 RVA: 0x00632FA0 File Offset: 0x006311A0
		public bool DisableSwitchRole3
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C18F RID: 49551
		// (get) Token: 0x0602D3A8 RID: 185256 RVA: 0x00632FE0 File Offset: 0x006311E0
		public bool DisableLock
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C190 RID: 49552
		// (get) Token: 0x0602D3A9 RID: 185257 RVA: 0x00633020 File Offset: 0x00631220
		public bool DisableAim
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C191 RID: 49553
		// (get) Token: 0x0602D3AA RID: 185258 RVA: 0x00633060 File Offset: 0x00631260
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

		// Token: 0x0602D3AB RID: 185259 RVA: 0x006330A0 File Offset: 0x006312A0
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

		// Token: 0x0602D3AC RID: 185260 RVA: 0x00633120 File Offset: 0x00631320
		public static void StartIDisableCharacterSectionalSkillOption(FlatBufferBuilder builder)
		{
			builder.StartTable(13);
		}

		// Token: 0x0602D3AD RID: 185261 RVA: 0x0063312A File Offset: 0x0063132A
		public static void AddDisableJump(FlatBufferBuilder builder, bool disableJump)
		{
			builder.AddBool(0, disableJump, false);
		}

		// Token: 0x0602D3AE RID: 185262 RVA: 0x00633135 File Offset: 0x00631335
		public static void AddDisableShowClimb(FlatBufferBuilder builder, bool disableShowClimb)
		{
			builder.AddBool(1, disableShowClimb, false);
		}

		// Token: 0x0602D3AF RID: 185263 RVA: 0x00633140 File Offset: 0x00631340
		public static void AddDisableAttack(FlatBufferBuilder builder, bool disableAttack)
		{
			builder.AddBool(2, disableAttack, false);
		}

		// Token: 0x0602D3B0 RID: 185264 RVA: 0x0063314B File Offset: 0x0063134B
		public static void AddDisableDodge(FlatBufferBuilder builder, bool disableDodge)
		{
			builder.AddBool(3, disableDodge, false);
		}

		// Token: 0x0602D3B1 RID: 185265 RVA: 0x00633156 File Offset: 0x00631356
		public static void AddDisableSkill1(FlatBufferBuilder builder, bool disableSkill1)
		{
			builder.AddBool(4, disableSkill1, false);
		}

		// Token: 0x0602D3B2 RID: 185266 RVA: 0x00633161 File Offset: 0x00631361
		public static void AddDisableUltimateSkill(FlatBufferBuilder builder, bool disableUltimateSkill)
		{
			builder.AddBool(5, disableUltimateSkill, false);
		}

		// Token: 0x0602D3B3 RID: 185267 RVA: 0x0063316C File Offset: 0x0063136C
		public static void AddDisableExploreInput(FlatBufferBuilder builder, bool disableExploreInput)
		{
			builder.AddBool(6, disableExploreInput, false);
		}

		// Token: 0x0602D3B4 RID: 185268 RVA: 0x00633177 File Offset: 0x00631377
		public static void AddDisableSwitchRole1(FlatBufferBuilder builder, bool disableSwitchRole1)
		{
			builder.AddBool(7, disableSwitchRole1, false);
		}

		// Token: 0x0602D3B5 RID: 185269 RVA: 0x00633182 File Offset: 0x00631382
		public static void AddDisableSwitchRole2(FlatBufferBuilder builder, bool disableSwitchRole2)
		{
			builder.AddBool(8, disableSwitchRole2, false);
		}

		// Token: 0x0602D3B6 RID: 185270 RVA: 0x0063318D File Offset: 0x0063138D
		public static void AddDisableSwitchRole3(FlatBufferBuilder builder, bool disableSwitchRole3)
		{
			builder.AddBool(9, disableSwitchRole3, false);
		}

		// Token: 0x0602D3B7 RID: 185271 RVA: 0x00633199 File Offset: 0x00631399
		public static void AddDisableLock(FlatBufferBuilder builder, bool disableLock)
		{
			builder.AddBool(10, disableLock, false);
		}

		// Token: 0x0602D3B8 RID: 185272 RVA: 0x006331A5 File Offset: 0x006313A5
		public static void AddDisableAim(FlatBufferBuilder builder, bool disableAim)
		{
			builder.AddBool(11, disableAim, false);
		}

		// Token: 0x0602D3B9 RID: 185273 RVA: 0x006331B1 File Offset: 0x006313B1
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(12, nullMask, 0);
		}

		// Token: 0x0602D3BA RID: 185274 RVA: 0x006331BD File Offset: 0x006313BD
		public static Offset<IDisableCharacterSectionalSkillOption> EndIDisableCharacterSectionalSkillOption(FlatBufferBuilder builder)
		{
			return new Offset<IDisableCharacterSectionalSkillOption>(builder.EndTable());
		}

		// Token: 0x0602D3BB RID: 185275 RVA: 0x006331CC File Offset: 0x006313CC
		public IDisableCharacterSectionalSkillOptionT UnPack()
		{
			IDisableCharacterSectionalSkillOptionT disableCharacterSectionalSkillOptionT = new IDisableCharacterSectionalSkillOptionT();
			this.UnPackTo(disableCharacterSectionalSkillOptionT);
			return disableCharacterSectionalSkillOptionT;
		}

		// Token: 0x0602D3BC RID: 185276 RVA: 0x006331E8 File Offset: 0x006313E8
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

		// Token: 0x0602D3BD RID: 185277 RVA: 0x00633294 File Offset: 0x00631494
		public static Offset<IDisableCharacterSectionalSkillOption> Pack(FlatBufferBuilder builder, IDisableCharacterSectionalSkillOptionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDisableCharacterSectionalSkillOption>);
			}
			return IDisableCharacterSectionalSkillOption.CreateIDisableCharacterSectionalSkillOption(builder, _o.DisableJump, _o.DisableShowClimb, _o.DisableAttack, _o.DisableDodge, _o.DisableSkill1, _o.DisableUltimateSkill, _o.DisableExploreInput, _o.DisableSwitchRole1, _o.DisableSwitchRole2, _o.DisableSwitchRole3, _o.DisableLock, _o.DisableAim, _o.NullMask);
		}

		// Token: 0x04010C3F RID: 68671
		private Table __p;
	}
}
