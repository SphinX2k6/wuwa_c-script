using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FE3 RID: 28643
	public struct IHonamiStoryRoleSetting : IFlatbufferObject
	{
		// Token: 0x1700D1C9 RID: 53705
		// (get) Token: 0x060319FA RID: 203258 RVA: 0x006B8F78 File Offset: 0x006B7178
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060319FB RID: 203259 RVA: 0x006B8F85 File Offset: 0x006B7185
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060319FC RID: 203260 RVA: 0x006B8F8C File Offset: 0x006B718C
		public static IHonamiStoryRoleSetting GetRootAsIHonamiStoryRoleSetting(ByteBuffer _bb)
		{
			return IHonamiStoryRoleSetting.GetRootAsIHonamiStoryRoleSetting(_bb, default(IHonamiStoryRoleSetting));
		}

		// Token: 0x060319FD RID: 203261 RVA: 0x006B8FA8 File Offset: 0x006B71A8
		public static IHonamiStoryRoleSetting GetRootAsIHonamiStoryRoleSetting(ByteBuffer _bb, IHonamiStoryRoleSetting obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060319FE RID: 203262 RVA: 0x006B8FC5 File Offset: 0x006B71C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060319FF RID: 203263 RVA: 0x006B8FD4 File Offset: 0x006B71D4
		public IHonamiStoryRoleSetting __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D1CA RID: 53706
		// (get) Token: 0x06031A00 RID: 203264 RVA: 0x006B8FE4 File Offset: 0x006B71E4
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

		// Token: 0x1700D1CB RID: 53707
		// (get) Token: 0x06031A01 RID: 203265 RVA: 0x006B9020 File Offset: 0x006B7220
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

		// Token: 0x06031A02 RID: 203266 RVA: 0x006B905C File Offset: 0x006B725C
		public static Offset<IHonamiStoryRoleSetting> CreateIHonamiStoryRoleSetting(FlatBufferBuilder builder, EHonamiStoryRoleSlot RoleSlot = EHonamiStoryRoleSlot.None, int RoleId = 0)
		{
			builder.StartTable(2);
			IHonamiStoryRoleSetting.AddRoleId(builder, RoleId);
			IHonamiStoryRoleSetting.AddRoleSlot(builder, RoleSlot);
			return IHonamiStoryRoleSetting.EndIHonamiStoryRoleSetting(builder);
		}

		// Token: 0x06031A03 RID: 203267 RVA: 0x006B9079 File Offset: 0x006B7279
		public static void StartIHonamiStoryRoleSetting(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031A04 RID: 203268 RVA: 0x006B9082 File Offset: 0x006B7282
		public static void AddRoleSlot(FlatBufferBuilder builder, EHonamiStoryRoleSlot roleSlot)
		{
			builder.AddByte(0, (byte)roleSlot, 0);
		}

		// Token: 0x06031A05 RID: 203269 RVA: 0x006B908D File Offset: 0x006B728D
		public static void AddRoleId(FlatBufferBuilder builder, int roleId)
		{
			builder.AddInt(1, roleId, 0);
		}

		// Token: 0x06031A06 RID: 203270 RVA: 0x006B9098 File Offset: 0x006B7298
		public static Offset<IHonamiStoryRoleSetting> EndIHonamiStoryRoleSetting(FlatBufferBuilder builder)
		{
			return new Offset<IHonamiStoryRoleSetting>(builder.EndTable());
		}

		// Token: 0x06031A07 RID: 203271 RVA: 0x006B90A8 File Offset: 0x006B72A8
		public IHonamiStoryRoleSettingT UnPack()
		{
			IHonamiStoryRoleSettingT honamiStoryRoleSettingT = new IHonamiStoryRoleSettingT();
			this.UnPackTo(honamiStoryRoleSettingT);
			return honamiStoryRoleSettingT;
		}

		// Token: 0x06031A08 RID: 203272 RVA: 0x006B90C3 File Offset: 0x006B72C3
		public void UnPackTo(IHonamiStoryRoleSettingT _o)
		{
			_o.RoleSlot = this.RoleSlot;
			_o.RoleId = this.RoleId;
		}

		// Token: 0x06031A09 RID: 203273 RVA: 0x006B90E0 File Offset: 0x006B72E0
		public static Offset<IHonamiStoryRoleSetting> Pack(FlatBufferBuilder builder, IHonamiStoryRoleSettingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHonamiStoryRoleSetting>);
			}
			return IHonamiStoryRoleSetting.CreateIHonamiStoryRoleSetting(builder, _o.RoleSlot, _o.RoleId);
		}

		// Token: 0x04011F17 RID: 73495
		private Table __p;
	}
}
