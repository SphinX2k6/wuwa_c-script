using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006930 RID: 26928
	public struct IHonamiStoryRoleSetting : IFlatbufferObject
	{
		// Token: 0x1700C7C6 RID: 51142
		// (get) Token: 0x0602F02A RID: 192554 RVA: 0x00668A90 File Offset: 0x00666C90
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F02B RID: 192555 RVA: 0x00668A9D File Offset: 0x00666C9D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F02C RID: 192556 RVA: 0x00668AA4 File Offset: 0x00666CA4
		public static IHonamiStoryRoleSetting GetRootAsIHonamiStoryRoleSetting(ByteBuffer _bb)
		{
			return IHonamiStoryRoleSetting.GetRootAsIHonamiStoryRoleSetting(_bb, default(IHonamiStoryRoleSetting));
		}

		// Token: 0x0602F02D RID: 192557 RVA: 0x00668AC0 File Offset: 0x00666CC0
		public static IHonamiStoryRoleSetting GetRootAsIHonamiStoryRoleSetting(ByteBuffer _bb, IHonamiStoryRoleSetting obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F02E RID: 192558 RVA: 0x00668ADD File Offset: 0x00666CDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F02F RID: 192559 RVA: 0x00668AEC File Offset: 0x00666CEC
		public IHonamiStoryRoleSetting __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C7C7 RID: 51143
		// (get) Token: 0x0602F030 RID: 192560 RVA: 0x00668AFC File Offset: 0x00666CFC
		public EHonamiStoryRoleSlot RoleSlot
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHonamiStoryRoleSlot.None;
				}
				return (EHonamiStoryRoleSlot)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C7C8 RID: 51144
		// (get) Token: 0x0602F031 RID: 192561 RVA: 0x00668B38 File Offset: 0x00666D38
		public int RoleId
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

		// Token: 0x0602F032 RID: 192562 RVA: 0x00668B74 File Offset: 0x00666D74
		public static Offset<IHonamiStoryRoleSetting> CreateIHonamiStoryRoleSetting(FlatBufferBuilder builder, EHonamiStoryRoleSlot RoleSlot = EHonamiStoryRoleSlot.None, int RoleId = 0)
		{
			builder.StartTable(2);
			IHonamiStoryRoleSetting.AddRoleId(builder, RoleId);
			IHonamiStoryRoleSetting.AddRoleSlot(builder, RoleSlot);
			return IHonamiStoryRoleSetting.EndIHonamiStoryRoleSetting(builder);
		}

		// Token: 0x0602F033 RID: 192563 RVA: 0x00668B91 File Offset: 0x00666D91
		public static void StartIHonamiStoryRoleSetting(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F034 RID: 192564 RVA: 0x00668B9A File Offset: 0x00666D9A
		public static void AddRoleSlot(FlatBufferBuilder builder, EHonamiStoryRoleSlot roleSlot)
		{
			builder.AddByte(0, (byte)roleSlot, 0);
		}

		// Token: 0x0602F035 RID: 192565 RVA: 0x00668BA5 File Offset: 0x00666DA5
		public static void AddRoleId(FlatBufferBuilder builder, int roleId)
		{
			builder.AddInt(1, roleId, 0);
		}

		// Token: 0x0602F036 RID: 192566 RVA: 0x00668BB0 File Offset: 0x00666DB0
		public static Offset<IHonamiStoryRoleSetting> EndIHonamiStoryRoleSetting(FlatBufferBuilder builder)
		{
			return new Offset<IHonamiStoryRoleSetting>(builder.EndTable());
		}

		// Token: 0x0602F037 RID: 192567 RVA: 0x00668BC0 File Offset: 0x00666DC0
		public IHonamiStoryRoleSettingT UnPack()
		{
			IHonamiStoryRoleSettingT honamiStoryRoleSettingT = new IHonamiStoryRoleSettingT();
			this.UnPackTo(honamiStoryRoleSettingT);
			return honamiStoryRoleSettingT;
		}

		// Token: 0x0602F038 RID: 192568 RVA: 0x00668BDB File Offset: 0x00666DDB
		public void UnPackTo(IHonamiStoryRoleSettingT _o)
		{
			_o.RoleSlot = this.RoleSlot;
			_o.RoleId = this.RoleId;
		}

		// Token: 0x0602F039 RID: 192569 RVA: 0x00668BF8 File Offset: 0x00666DF8
		public static Offset<IHonamiStoryRoleSetting> Pack(FlatBufferBuilder builder, IHonamiStoryRoleSettingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHonamiStoryRoleSetting>);
			}
			return IHonamiStoryRoleSetting.CreateIHonamiStoryRoleSetting(builder, _o.RoleSlot, _o.RoleId);
		}

		// Token: 0x040110AB RID: 69803
		private Table __p;
	}
}
