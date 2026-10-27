using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003BCB RID: 15307
	public struct IShowTimelineSwitchRole : IFlatbufferObject
	{
		// Token: 0x1700690F RID: 26895
		// (get) Token: 0x060150AB RID: 86187 RVA: 0x0030CF8D File Offset: 0x0030B18D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060150AC RID: 86188 RVA: 0x0030CF9A File Offset: 0x0030B19A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060150AD RID: 86189 RVA: 0x0030CFA4 File Offset: 0x0030B1A4
		public static IShowTimelineSwitchRole GetRootAsIShowTimelineSwitchRole(ByteBuffer _bb)
		{
			return IShowTimelineSwitchRole.GetRootAsIShowTimelineSwitchRole(_bb, default(IShowTimelineSwitchRole));
		}

		// Token: 0x060150AE RID: 86190 RVA: 0x0030CFC0 File Offset: 0x0030B1C0
		public static IShowTimelineSwitchRole GetRootAsIShowTimelineSwitchRole(ByteBuffer _bb, IShowTimelineSwitchRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060150AF RID: 86191 RVA: 0x0030CFDD File Offset: 0x0030B1DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060150B0 RID: 86192 RVA: 0x0030CFEC File Offset: 0x0030B1EC
		public IShowTimelineSwitchRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006910 RID: 26896
		// (get) Token: 0x060150B1 RID: 86193 RVA: 0x0030CFFC File Offset: 0x0030B1FC
		public EShowTimelineActionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EShowTimelineActionType.Skill;
				}
				return (EShowTimelineActionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006911 RID: 26897
		// (get) Token: 0x060150B2 RID: 86194 RVA: 0x0030D038 File Offset: 0x0030B238
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

		// Token: 0x060150B3 RID: 86195 RVA: 0x0030D074 File Offset: 0x0030B274
		public static Offset<IShowTimelineSwitchRole> CreateIShowTimelineSwitchRole(FlatBufferBuilder builder, EShowTimelineActionType Type = EShowTimelineActionType.Skill, int RoleId = 0)
		{
			builder.StartTable(2);
			IShowTimelineSwitchRole.AddRoleId(builder, RoleId);
			IShowTimelineSwitchRole.AddType(builder, Type);
			return IShowTimelineSwitchRole.EndIShowTimelineSwitchRole(builder);
		}

		// Token: 0x060150B4 RID: 86196 RVA: 0x0030D091 File Offset: 0x0030B291
		public static void StartIShowTimelineSwitchRole(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060150B5 RID: 86197 RVA: 0x0030D09A File Offset: 0x0030B29A
		public static void AddType(FlatBufferBuilder builder, EShowTimelineActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060150B6 RID: 86198 RVA: 0x0030D0A5 File Offset: 0x0030B2A5
		public static void AddRoleId(FlatBufferBuilder builder, int roleId)
		{
			builder.AddInt(1, roleId, 0);
		}

		// Token: 0x060150B7 RID: 86199 RVA: 0x0030D0B0 File Offset: 0x0030B2B0
		public static Offset<IShowTimelineSwitchRole> EndIShowTimelineSwitchRole(FlatBufferBuilder builder)
		{
			return new Offset<IShowTimelineSwitchRole>(builder.EndTable());
		}

		// Token: 0x060150B8 RID: 86200 RVA: 0x0030D0C0 File Offset: 0x0030B2C0
		public IShowTimelineSwitchRoleT UnPack()
		{
			IShowTimelineSwitchRoleT showTimelineSwitchRoleT = new IShowTimelineSwitchRoleT();
			this.UnPackTo(showTimelineSwitchRoleT);
			return showTimelineSwitchRoleT;
		}

		// Token: 0x060150B9 RID: 86201 RVA: 0x0030D0DB File Offset: 0x0030B2DB
		public void UnPackTo(IShowTimelineSwitchRoleT _o)
		{
			_o.Type = this.Type;
			_o.RoleId = this.RoleId;
		}

		// Token: 0x060150BA RID: 86202 RVA: 0x0030D0F8 File Offset: 0x0030B2F8
		public static Offset<IShowTimelineSwitchRole> Pack(FlatBufferBuilder builder, IShowTimelineSwitchRoleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowTimelineSwitchRole>);
			}
			return IShowTimelineSwitchRole.CreateIShowTimelineSwitchRole(builder, _o.Type, _o.RoleId);
		}

		// Token: 0x0400B15C RID: 45404
		private Table __p;
	}
}
