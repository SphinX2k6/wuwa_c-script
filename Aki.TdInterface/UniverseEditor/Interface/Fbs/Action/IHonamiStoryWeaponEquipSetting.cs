using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006936 RID: 26934
	public struct IHonamiStoryWeaponEquipSetting : IFlatbufferObject
	{
		// Token: 0x1700C7D6 RID: 51158
		// (get) Token: 0x0602F074 RID: 192628 RVA: 0x0066953F File Offset: 0x0066773F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F075 RID: 192629 RVA: 0x0066954C File Offset: 0x0066774C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F076 RID: 192630 RVA: 0x00669554 File Offset: 0x00667754
		public static IHonamiStoryWeaponEquipSetting GetRootAsIHonamiStoryWeaponEquipSetting(ByteBuffer _bb)
		{
			return IHonamiStoryWeaponEquipSetting.GetRootAsIHonamiStoryWeaponEquipSetting(_bb, default(IHonamiStoryWeaponEquipSetting));
		}

		// Token: 0x0602F077 RID: 192631 RVA: 0x00669570 File Offset: 0x00667770
		public static IHonamiStoryWeaponEquipSetting GetRootAsIHonamiStoryWeaponEquipSetting(ByteBuffer _bb, IHonamiStoryWeaponEquipSetting obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F078 RID: 192632 RVA: 0x0066958D File Offset: 0x0066778D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F079 RID: 192633 RVA: 0x0066959C File Offset: 0x0066779C
		public IHonamiStoryWeaponEquipSetting __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C7D7 RID: 51159
		// (get) Token: 0x0602F07A RID: 192634 RVA: 0x006695AC File Offset: 0x006677AC
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

		// Token: 0x1700C7D8 RID: 51160
		// (get) Token: 0x0602F07B RID: 192635 RVA: 0x006695E8 File Offset: 0x006677E8
		public int WeaponId
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

		// Token: 0x0602F07C RID: 192636 RVA: 0x00669624 File Offset: 0x00667824
		public static Offset<IHonamiStoryWeaponEquipSetting> CreateIHonamiStoryWeaponEquipSetting(FlatBufferBuilder builder, EHonamiStoryRoleSlot RoleSlot = EHonamiStoryRoleSlot.None, int WeaponId = 0)
		{
			builder.StartTable(2);
			IHonamiStoryWeaponEquipSetting.AddWeaponId(builder, WeaponId);
			IHonamiStoryWeaponEquipSetting.AddRoleSlot(builder, RoleSlot);
			return IHonamiStoryWeaponEquipSetting.EndIHonamiStoryWeaponEquipSetting(builder);
		}

		// Token: 0x0602F07D RID: 192637 RVA: 0x00669641 File Offset: 0x00667841
		public static void StartIHonamiStoryWeaponEquipSetting(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F07E RID: 192638 RVA: 0x0066964A File Offset: 0x0066784A
		public static void AddRoleSlot(FlatBufferBuilder builder, EHonamiStoryRoleSlot roleSlot)
		{
			builder.AddByte(0, (byte)roleSlot, 0);
		}

		// Token: 0x0602F07F RID: 192639 RVA: 0x00669655 File Offset: 0x00667855
		public static void AddWeaponId(FlatBufferBuilder builder, int weaponId)
		{
			builder.AddInt(1, weaponId, 0);
		}

		// Token: 0x0602F080 RID: 192640 RVA: 0x00669660 File Offset: 0x00667860
		public static Offset<IHonamiStoryWeaponEquipSetting> EndIHonamiStoryWeaponEquipSetting(FlatBufferBuilder builder)
		{
			return new Offset<IHonamiStoryWeaponEquipSetting>(builder.EndTable());
		}

		// Token: 0x0602F081 RID: 192641 RVA: 0x00669670 File Offset: 0x00667870
		public IHonamiStoryWeaponEquipSettingT UnPack()
		{
			IHonamiStoryWeaponEquipSettingT honamiStoryWeaponEquipSettingT = new IHonamiStoryWeaponEquipSettingT();
			this.UnPackTo(honamiStoryWeaponEquipSettingT);
			return honamiStoryWeaponEquipSettingT;
		}

		// Token: 0x0602F082 RID: 192642 RVA: 0x0066968B File Offset: 0x0066788B
		public void UnPackTo(IHonamiStoryWeaponEquipSettingT _o)
		{
			_o.RoleSlot = this.RoleSlot;
			_o.WeaponId = this.WeaponId;
		}

		// Token: 0x0602F083 RID: 192643 RVA: 0x006696A8 File Offset: 0x006678A8
		public static Offset<IHonamiStoryWeaponEquipSetting> Pack(FlatBufferBuilder builder, IHonamiStoryWeaponEquipSettingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHonamiStoryWeaponEquipSetting>);
			}
			return IHonamiStoryWeaponEquipSetting.CreateIHonamiStoryWeaponEquipSetting(builder, _o.RoleSlot, _o.WeaponId);
		}

		// Token: 0x040110B4 RID: 69812
		private Table __p;
	}
}
