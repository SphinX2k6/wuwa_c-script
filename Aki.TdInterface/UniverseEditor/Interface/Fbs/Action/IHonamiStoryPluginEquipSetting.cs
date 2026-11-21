using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FDD RID: 28637
	public struct IHonamiStoryPluginEquipSetting : IFlatbufferObject
	{
		// Token: 0x1700D1B9 RID: 53689
		// (get) Token: 0x060319C0 RID: 203200 RVA: 0x006B899A File Offset: 0x006B6B9A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060319C1 RID: 203201 RVA: 0x006B89A7 File Offset: 0x006B6BA7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060319C2 RID: 203202 RVA: 0x006B89B0 File Offset: 0x006B6BB0
		public static IHonamiStoryPluginEquipSetting GetRootAsIHonamiStoryPluginEquipSetting(ByteBuffer _bb)
		{
			return IHonamiStoryPluginEquipSetting.GetRootAsIHonamiStoryPluginEquipSetting(_bb, default(IHonamiStoryPluginEquipSetting));
		}

		// Token: 0x060319C3 RID: 203203 RVA: 0x006B89CC File Offset: 0x006B6BCC
		public static IHonamiStoryPluginEquipSetting GetRootAsIHonamiStoryPluginEquipSetting(ByteBuffer _bb, IHonamiStoryPluginEquipSetting obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060319C4 RID: 203204 RVA: 0x006B89E9 File Offset: 0x006B6BE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060319C5 RID: 203205 RVA: 0x006B89F8 File Offset: 0x006B6BF8
		public IHonamiStoryPluginEquipSetting __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D1BA RID: 53690
		// (get) Token: 0x060319C6 RID: 203206 RVA: 0x006B8A08 File Offset: 0x006B6C08
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

		// Token: 0x1700D1BB RID: 53691
		// (get) Token: 0x060319C7 RID: 203207 RVA: 0x006B8A44 File Offset: 0x006B6C44
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

		// Token: 0x1700D1BC RID: 53692
		// (get) Token: 0x060319C8 RID: 203208 RVA: 0x006B8A80 File Offset: 0x006B6C80
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

		// Token: 0x060319C9 RID: 203209 RVA: 0x006B8ABC File Offset: 0x006B6CBC
		public static Offset<IHonamiStoryPluginEquipSetting> CreateIHonamiStoryPluginEquipSetting(FlatBufferBuilder builder, EHonamiStoryRoleSlot RoleSlot = EHonamiStoryRoleSlot.None, EHonamiStoryPluginSlot PluginSlot = EHonamiStoryPluginSlot.None, int PluginId = 0)
		{
			builder.StartTable(3);
			IHonamiStoryPluginEquipSetting.AddPluginId(builder, PluginId);
			IHonamiStoryPluginEquipSetting.AddPluginSlot(builder, PluginSlot);
			IHonamiStoryPluginEquipSetting.AddRoleSlot(builder, RoleSlot);
			return IHonamiStoryPluginEquipSetting.EndIHonamiStoryPluginEquipSetting(builder);
		}

		// Token: 0x060319CA RID: 203210 RVA: 0x006B8AE0 File Offset: 0x006B6CE0
		public static void StartIHonamiStoryPluginEquipSetting(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060319CB RID: 203211 RVA: 0x006B8AE9 File Offset: 0x006B6CE9
		public static void AddRoleSlot(FlatBufferBuilder builder, EHonamiStoryRoleSlot roleSlot)
		{
			builder.AddByte(0, (byte)roleSlot, 0);
		}

		// Token: 0x060319CC RID: 203212 RVA: 0x006B8AF4 File Offset: 0x006B6CF4
		public static void AddPluginSlot(FlatBufferBuilder builder, EHonamiStoryPluginSlot pluginSlot)
		{
			builder.AddByte(1, (byte)pluginSlot, 0);
		}

		// Token: 0x060319CD RID: 203213 RVA: 0x006B8AFF File Offset: 0x006B6CFF
		public static void AddPluginId(FlatBufferBuilder builder, int pluginId)
		{
			builder.AddInt(2, pluginId, 0);
		}

		// Token: 0x060319CE RID: 203214 RVA: 0x006B8B0A File Offset: 0x006B6D0A
		public static Offset<IHonamiStoryPluginEquipSetting> EndIHonamiStoryPluginEquipSetting(FlatBufferBuilder builder)
		{
			return new Offset<IHonamiStoryPluginEquipSetting>(builder.EndTable());
		}

		// Token: 0x060319CF RID: 203215 RVA: 0x006B8B18 File Offset: 0x006B6D18
		public IHonamiStoryPluginEquipSettingT UnPack()
		{
			IHonamiStoryPluginEquipSettingT honamiStoryPluginEquipSettingT = new IHonamiStoryPluginEquipSettingT();
			this.UnPackTo(honamiStoryPluginEquipSettingT);
			return honamiStoryPluginEquipSettingT;
		}

		// Token: 0x060319D0 RID: 203216 RVA: 0x006B8B33 File Offset: 0x006B6D33
		public void UnPackTo(IHonamiStoryPluginEquipSettingT _o)
		{
			_o.RoleSlot = this.RoleSlot;
			_o.PluginSlot = this.PluginSlot;
			_o.PluginId = this.PluginId;
		}

		// Token: 0x060319D1 RID: 203217 RVA: 0x006B8B5C File Offset: 0x006B6D5C
		public static Offset<IHonamiStoryPluginEquipSetting> Pack(FlatBufferBuilder builder, IHonamiStoryPluginEquipSettingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHonamiStoryPluginEquipSetting>);
			}
			return IHonamiStoryPluginEquipSetting.CreateIHonamiStoryPluginEquipSetting(builder, _o.RoleSlot, _o.PluginSlot, _o.PluginId);
		}

		// Token: 0x04011F0E RID: 73486
		private Table __p;
	}
}
