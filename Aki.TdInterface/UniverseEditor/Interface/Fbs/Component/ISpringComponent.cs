using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F9C RID: 24476
	public struct ISpringComponent : IFlatbufferObject
	{
		// Token: 0x1700B540 RID: 46400
		// (get) Token: 0x060292A4 RID: 168612 RVA: 0x0059EE04 File Offset: 0x0059D004
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060292A5 RID: 168613 RVA: 0x0059EE11 File Offset: 0x0059D011
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060292A6 RID: 168614 RVA: 0x0059EE18 File Offset: 0x0059D018
		public static ISpringComponent GetRootAsISpringComponent(ByteBuffer _bb)
		{
			return ISpringComponent.GetRootAsISpringComponent(_bb, default(ISpringComponent));
		}

		// Token: 0x060292A7 RID: 168615 RVA: 0x0059EE34 File Offset: 0x0059D034
		public static ISpringComponent GetRootAsISpringComponent(ByteBuffer _bb, ISpringComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060292A8 RID: 168616 RVA: 0x0059EE51 File Offset: 0x0059D051
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060292A9 RID: 168617 RVA: 0x0059EE60 File Offset: 0x0059D060
		public ISpringComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B541 RID: 46401
		// (get) Token: 0x060292AA RID: 168618 RVA: 0x0059EE70 File Offset: 0x0059D070
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B542 RID: 46402
		// (get) Token: 0x060292AB RID: 168619 RVA: 0x0059EEB0 File Offset: 0x0059D0B0
		public bool IsNormalSpring
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B543 RID: 46403
		// (get) Token: 0x060292AC RID: 168620 RVA: 0x0059EEF0 File Offset: 0x0059D0F0
		public bool IsHitNormalSpring
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B544 RID: 46404
		// (get) Token: 0x060292AD RID: 168621 RVA: 0x0059EF30 File Offset: 0x0059D130
		public ISettingSpringDir? SettingDir
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new ISettingSpringDir?(default(ISettingSpringDir).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B545 RID: 46405
		// (get) Token: 0x060292AE RID: 168622 RVA: 0x0059EF90 File Offset: 0x0059D190
		public int SpringPow
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

		// Token: 0x1700B546 RID: 46406
		// (get) Token: 0x060292AF RID: 168623 RVA: 0x0059EFD0 File Offset: 0x0059D1D0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060292B0 RID: 168624 RVA: 0x0059F00D File Offset: 0x0059D20D
		public static Offset<ISpringComponent> CreateISpringComponent(FlatBufferBuilder builder, bool Disabled = false, bool IsNormalSpring = false, bool IsHitNormalSpring = false, Offset<ISettingSpringDir> SettingDirOffset = default(Offset<ISettingSpringDir>), int SpringPow = 0, byte NullMask = 0)
		{
			builder.StartTable(6);
			ISpringComponent.AddSpringPow(builder, SpringPow);
			ISpringComponent.AddSettingDir(builder, SettingDirOffset);
			ISpringComponent.AddNullMask(builder, NullMask);
			ISpringComponent.AddIsHitNormalSpring(builder, IsHitNormalSpring);
			ISpringComponent.AddIsNormalSpring(builder, IsNormalSpring);
			ISpringComponent.AddDisabled(builder, Disabled);
			return ISpringComponent.EndISpringComponent(builder);
		}

		// Token: 0x060292B1 RID: 168625 RVA: 0x0059F049 File Offset: 0x0059D249
		public static void StartISpringComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060292B2 RID: 168626 RVA: 0x0059F052 File Offset: 0x0059D252
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060292B3 RID: 168627 RVA: 0x0059F05D File Offset: 0x0059D25D
		public static void AddIsNormalSpring(FlatBufferBuilder builder, bool isNormalSpring)
		{
			builder.AddBool(1, isNormalSpring, false);
		}

		// Token: 0x060292B4 RID: 168628 RVA: 0x0059F068 File Offset: 0x0059D268
		public static void AddIsHitNormalSpring(FlatBufferBuilder builder, bool isHitNormalSpring)
		{
			builder.AddBool(2, isHitNormalSpring, false);
		}

		// Token: 0x060292B5 RID: 168629 RVA: 0x0059F073 File Offset: 0x0059D273
		public static void AddSettingDir(FlatBufferBuilder builder, Offset<ISettingSpringDir> settingDirOffset)
		{
			builder.AddOffset(3, settingDirOffset.Value, 0);
		}

		// Token: 0x060292B6 RID: 168630 RVA: 0x0059F083 File Offset: 0x0059D283
		public static void AddSpringPow(FlatBufferBuilder builder, int springPow)
		{
			builder.AddInt(4, springPow, 0);
		}

		// Token: 0x060292B7 RID: 168631 RVA: 0x0059F08E File Offset: 0x0059D28E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060292B8 RID: 168632 RVA: 0x0059F099 File Offset: 0x0059D299
		public static Offset<ISpringComponent> EndISpringComponent(FlatBufferBuilder builder)
		{
			return new Offset<ISpringComponent>(builder.EndTable());
		}

		// Token: 0x060292B9 RID: 168633 RVA: 0x0059F0A8 File Offset: 0x0059D2A8
		public ISpringComponentT UnPack()
		{
			ISpringComponentT springComponentT = new ISpringComponentT();
			this.UnPackTo(springComponentT);
			return springComponentT;
		}

		// Token: 0x060292BA RID: 168634 RVA: 0x0059F0C4 File Offset: 0x0059D2C4
		public void UnPackTo(ISpringComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.IsNormalSpring = this.IsNormalSpring;
			_o.IsHitNormalSpring = this.IsHitNormalSpring;
			_o.SettingDir = ((this.SettingDir != null) ? this.SettingDir.Value.UnPack() : null);
			_o.SpringPow = this.SpringPow;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060292BB RID: 168635 RVA: 0x0059F13C File Offset: 0x0059D33C
		public static Offset<ISpringComponent> Pack(FlatBufferBuilder builder, ISpringComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpringComponent>);
			}
			Offset<ISettingSpringDir> settingDirOffset = (_o.SettingDir == null) ? default(Offset<ISettingSpringDir>) : ISettingSpringDir.Pack(builder, _o.SettingDir);
			return ISpringComponent.CreateISpringComponent(builder, _o.Disabled, _o.IsNormalSpring, _o.IsHitNormalSpring, settingDirOffset, _o.SpringPow, _o.NullMask);
		}

		// Token: 0x0400FC88 RID: 64648
		private Table __p;
	}
}
