using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FE9 RID: 28649
	public struct IHonamiStoryWeaponEquipSetting : IFlatbufferObject
	{
		// Token: 0x1700D1D9 RID: 53721
		// (get) Token: 0x06031A44 RID: 203332 RVA: 0x006B9A27 File Offset: 0x006B7C27
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031A45 RID: 203333 RVA: 0x006B9A34 File Offset: 0x006B7C34
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031A46 RID: 203334 RVA: 0x006B9A3C File Offset: 0x006B7C3C
		public static IHonamiStoryWeaponEquipSetting GetRootAsIHonamiStoryWeaponEquipSetting(ByteBuffer _bb)
		{
			return IHonamiStoryWeaponEquipSetting.GetRootAsIHonamiStoryWeaponEquipSetting(_bb, default(IHonamiStoryWeaponEquipSetting));
		}

		// Token: 0x06031A47 RID: 203335 RVA: 0x006B9A58 File Offset: 0x006B7C58
		public static IHonamiStoryWeaponEquipSetting GetRootAsIHonamiStoryWeaponEquipSetting(ByteBuffer _bb, IHonamiStoryWeaponEquipSetting obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031A48 RID: 203336 RVA: 0x006B9A75 File Offset: 0x006B7C75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031A49 RID: 203337 RVA: 0x006B9A84 File Offset: 0x006B7C84
		public IHonamiStoryWeaponEquipSetting __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D1DA RID: 53722
		// (get) Token: 0x06031A4A RID: 203338 RVA: 0x006B9A94 File Offset: 0x006B7C94
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

		// Token: 0x1700D1DB RID: 53723
		// (get) Token: 0x06031A4B RID: 203339 RVA: 0x006B9AD0 File Offset: 0x006B7CD0
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

		// Token: 0x06031A4C RID: 203340 RVA: 0x006B9B0C File Offset: 0x006B7D0C
		public static Offset<IHonamiStoryWeaponEquipSetting> CreateIHonamiStoryWeaponEquipSetting(FlatBufferBuilder builder, EHonamiStoryRoleSlot RoleSlot = EHonamiStoryRoleSlot.None, int WeaponId = 0)
		{
			builder.StartTable(2);
			IHonamiStoryWeaponEquipSetting.AddWeaponId(builder, WeaponId);
			IHonamiStoryWeaponEquipSetting.AddRoleSlot(builder, RoleSlot);
			return IHonamiStoryWeaponEquipSetting.EndIHonamiStoryWeaponEquipSetting(builder);
		}

		// Token: 0x06031A4D RID: 203341 RVA: 0x006B9B29 File Offset: 0x006B7D29
		public static void StartIHonamiStoryWeaponEquipSetting(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031A4E RID: 203342 RVA: 0x006B9B32 File Offset: 0x006B7D32
		public static void AddRoleSlot(FlatBufferBuilder builder, EHonamiStoryRoleSlot roleSlot)
		{
			builder.AddByte(0, (byte)roleSlot, 0);
		}

		// Token: 0x06031A4F RID: 203343 RVA: 0x006B9B3D File Offset: 0x006B7D3D
		public static void AddWeaponId(FlatBufferBuilder builder, int weaponId)
		{
			builder.AddInt(1, weaponId, 0);
		}

		// Token: 0x06031A50 RID: 203344 RVA: 0x006B9B48 File Offset: 0x006B7D48
		public static Offset<IHonamiStoryWeaponEquipSetting> EndIHonamiStoryWeaponEquipSetting(FlatBufferBuilder builder)
		{
			return new Offset<IHonamiStoryWeaponEquipSetting>(builder.EndTable());
		}

		// Token: 0x06031A51 RID: 203345 RVA: 0x006B9B58 File Offset: 0x006B7D58
		public IHonamiStoryWeaponEquipSettingT UnPack()
		{
			IHonamiStoryWeaponEquipSettingT honamiStoryWeaponEquipSettingT = new IHonamiStoryWeaponEquipSettingT();
			this.UnPackTo(honamiStoryWeaponEquipSettingT);
			return honamiStoryWeaponEquipSettingT;
		}

		// Token: 0x06031A52 RID: 203346 RVA: 0x006B9B73 File Offset: 0x006B7D73
		public void UnPackTo(IHonamiStoryWeaponEquipSettingT _o)
		{
			_o.RoleSlot = this.RoleSlot;
			_o.WeaponId = this.WeaponId;
		}

		// Token: 0x06031A53 RID: 203347 RVA: 0x006B9B90 File Offset: 0x006B7D90
		public static Offset<IHonamiStoryWeaponEquipSetting> Pack(FlatBufferBuilder builder, IHonamiStoryWeaponEquipSettingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHonamiStoryWeaponEquipSetting>);
			}
			return IHonamiStoryWeaponEquipSetting.CreateIHonamiStoryWeaponEquipSetting(builder, _o.RoleSlot, _o.WeaponId);
		}

		// Token: 0x04011F20 RID: 73504
		private Table __p;
	}
}
