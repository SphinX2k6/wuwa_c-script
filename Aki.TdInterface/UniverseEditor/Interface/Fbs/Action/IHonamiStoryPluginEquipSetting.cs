using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200692A RID: 26922
	public struct IHonamiStoryPluginEquipSetting : IFlatbufferObject
	{
		// Token: 0x1700C7B6 RID: 51126
		// (get) Token: 0x0602EFF0 RID: 192496 RVA: 0x006684B2 File Offset: 0x006666B2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EFF1 RID: 192497 RVA: 0x006684BF File Offset: 0x006666BF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EFF2 RID: 192498 RVA: 0x006684C8 File Offset: 0x006666C8
		public static IHonamiStoryPluginEquipSetting GetRootAsIHonamiStoryPluginEquipSetting(ByteBuffer _bb)
		{
			return IHonamiStoryPluginEquipSetting.GetRootAsIHonamiStoryPluginEquipSetting(_bb, default(IHonamiStoryPluginEquipSetting));
		}

		// Token: 0x0602EFF3 RID: 192499 RVA: 0x006684E4 File Offset: 0x006666E4
		public static IHonamiStoryPluginEquipSetting GetRootAsIHonamiStoryPluginEquipSetting(ByteBuffer _bb, IHonamiStoryPluginEquipSetting obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EFF4 RID: 192500 RVA: 0x00668501 File Offset: 0x00666701
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EFF5 RID: 192501 RVA: 0x00668510 File Offset: 0x00666710
		public IHonamiStoryPluginEquipSetting __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C7B7 RID: 51127
		// (get) Token: 0x0602EFF6 RID: 192502 RVA: 0x00668520 File Offset: 0x00666720
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

		// Token: 0x1700C7B8 RID: 51128
		// (get) Token: 0x0602EFF7 RID: 192503 RVA: 0x0066855C File Offset: 0x0066675C
		public EHonamiStoryPluginSlot PluginSlot
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EHonamiStoryPluginSlot.None;
				}
				return (EHonamiStoryPluginSlot)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C7B9 RID: 51129
		// (get) Token: 0x0602EFF8 RID: 192504 RVA: 0x00668598 File Offset: 0x00666798
		public int PluginId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602EFF9 RID: 192505 RVA: 0x006685D4 File Offset: 0x006667D4
		public static Offset<IHonamiStoryPluginEquipSetting> CreateIHonamiStoryPluginEquipSetting(FlatBufferBuilder builder, EHonamiStoryRoleSlot RoleSlot = EHonamiStoryRoleSlot.None, EHonamiStoryPluginSlot PluginSlot = EHonamiStoryPluginSlot.None, int PluginId = 0)
		{
			builder.StartTable(3);
			IHonamiStoryPluginEquipSetting.AddPluginId(builder, PluginId);
			IHonamiStoryPluginEquipSetting.AddPluginSlot(builder, PluginSlot);
			IHonamiStoryPluginEquipSetting.AddRoleSlot(builder, RoleSlot);
			return IHonamiStoryPluginEquipSetting.EndIHonamiStoryPluginEquipSetting(builder);
		}

		// Token: 0x0602EFFA RID: 192506 RVA: 0x006685F8 File Offset: 0x006667F8
		public static void StartIHonamiStoryPluginEquipSetting(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602EFFB RID: 192507 RVA: 0x00668601 File Offset: 0x00666801
		public static void AddRoleSlot(FlatBufferBuilder builder, EHonamiStoryRoleSlot roleSlot)
		{
			builder.AddByte(0, (byte)roleSlot, 0);
		}

		// Token: 0x0602EFFC RID: 192508 RVA: 0x0066860C File Offset: 0x0066680C
		public static void AddPluginSlot(FlatBufferBuilder builder, EHonamiStoryPluginSlot pluginSlot)
		{
			builder.AddByte(1, (byte)pluginSlot, 0);
		}

		// Token: 0x0602EFFD RID: 192509 RVA: 0x00668617 File Offset: 0x00666817
		public static void AddPluginId(FlatBufferBuilder builder, int pluginId)
		{
			builder.AddInt(2, pluginId, 0);
		}

		// Token: 0x0602EFFE RID: 192510 RVA: 0x00668622 File Offset: 0x00666822
		public static Offset<IHonamiStoryPluginEquipSetting> EndIHonamiStoryPluginEquipSetting(FlatBufferBuilder builder)
		{
			return new Offset<IHonamiStoryPluginEquipSetting>(builder.EndTable());
		}

		// Token: 0x0602EFFF RID: 192511 RVA: 0x00668630 File Offset: 0x00666830
		public IHonamiStoryPluginEquipSettingT UnPack()
		{
			IHonamiStoryPluginEquipSettingT honamiStoryPluginEquipSettingT = new IHonamiStoryPluginEquipSettingT();
			this.UnPackTo(honamiStoryPluginEquipSettingT);
			return honamiStoryPluginEquipSettingT;
		}

		// Token: 0x0602F000 RID: 192512 RVA: 0x0066864B File Offset: 0x0066684B
		public void UnPackTo(IHonamiStoryPluginEquipSettingT _o)
		{
			_o.RoleSlot = this.RoleSlot;
			_o.PluginSlot = this.PluginSlot;
			_o.PluginId = this.PluginId;
		}

		// Token: 0x0602F001 RID: 192513 RVA: 0x00668674 File Offset: 0x00666874
		public static Offset<IHonamiStoryPluginEquipSetting> Pack(FlatBufferBuilder builder, IHonamiStoryPluginEquipSettingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHonamiStoryPluginEquipSetting>);
			}
			return IHonamiStoryPluginEquipSetting.CreateIHonamiStoryPluginEquipSetting(builder, _o.RoleSlot, _o.PluginSlot, _o.PluginId);
		}

		// Token: 0x040110A2 RID: 69794
		private Table __p;
	}
}
