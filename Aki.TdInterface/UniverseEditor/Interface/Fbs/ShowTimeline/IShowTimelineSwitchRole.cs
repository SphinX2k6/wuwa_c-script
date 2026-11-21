using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FD6 RID: 16342
	public struct IShowTimelineSwitchRole : IFlatbufferObject
	{
		// Token: 0x17006EB7 RID: 28343
		// (get) Token: 0x060165A1 RID: 91553 RVA: 0x00333B15 File Offset: 0x00331D15
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060165A2 RID: 91554 RVA: 0x00333B22 File Offset: 0x00331D22
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060165A3 RID: 91555 RVA: 0x00333B2C File Offset: 0x00331D2C
		public static IShowTimelineSwitchRole GetRootAsIShowTimelineSwitchRole(ByteBuffer _bb)
		{
			return IShowTimelineSwitchRole.GetRootAsIShowTimelineSwitchRole(_bb, default(IShowTimelineSwitchRole));
		}

		// Token: 0x060165A4 RID: 91556 RVA: 0x00333B48 File Offset: 0x00331D48
		public static IShowTimelineSwitchRole GetRootAsIShowTimelineSwitchRole(ByteBuffer _bb, IShowTimelineSwitchRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060165A5 RID: 91557 RVA: 0x00333B65 File Offset: 0x00331D65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060165A6 RID: 91558 RVA: 0x00333B74 File Offset: 0x00331D74
		public IShowTimelineSwitchRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006EB8 RID: 28344
		// (get) Token: 0x060165A7 RID: 91559 RVA: 0x00333B84 File Offset: 0x00331D84
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

		// Token: 0x17006EB9 RID: 28345
		// (get) Token: 0x060165A8 RID: 91560 RVA: 0x00333BC0 File Offset: 0x00331DC0
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

		// Token: 0x060165A9 RID: 91561 RVA: 0x00333BFC File Offset: 0x00331DFC
		public static Offset<IShowTimelineSwitchRole> CreateIShowTimelineSwitchRole(FlatBufferBuilder builder, EShowTimelineActionType Type = EShowTimelineActionType.Skill, int RoleId = 0)
		{
			builder.StartTable(2);
			IShowTimelineSwitchRole.AddRoleId(builder, RoleId);
			IShowTimelineSwitchRole.AddType(builder, Type);
			return IShowTimelineSwitchRole.EndIShowTimelineSwitchRole(builder);
		}

		// Token: 0x060165AA RID: 91562 RVA: 0x00333C19 File Offset: 0x00331E19
		public static void StartIShowTimelineSwitchRole(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060165AB RID: 91563 RVA: 0x00333C22 File Offset: 0x00331E22
		public static void AddType(FlatBufferBuilder builder, EShowTimelineActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060165AC RID: 91564 RVA: 0x00333C2D File Offset: 0x00331E2D
		public static void AddRoleId(FlatBufferBuilder builder, int roleId)
		{
			builder.AddInt(1, roleId, 0);
		}

		// Token: 0x060165AD RID: 91565 RVA: 0x00333C38 File Offset: 0x00331E38
		public static Offset<IShowTimelineSwitchRole> EndIShowTimelineSwitchRole(FlatBufferBuilder builder)
		{
			return new Offset<IShowTimelineSwitchRole>(builder.EndTable());
		}

		// Token: 0x060165AE RID: 91566 RVA: 0x00333C48 File Offset: 0x00331E48
		public IShowTimelineSwitchRoleT UnPack()
		{
			IShowTimelineSwitchRoleT showTimelineSwitchRoleT = new IShowTimelineSwitchRoleT();
			this.UnPackTo(showTimelineSwitchRoleT);
			return showTimelineSwitchRoleT;
		}

		// Token: 0x060165AF RID: 91567 RVA: 0x00333C63 File Offset: 0x00331E63
		public void UnPackTo(IShowTimelineSwitchRoleT _o)
		{
			_o.Type = this.Type;
			_o.RoleId = this.RoleId;
		}

		// Token: 0x060165B0 RID: 91568 RVA: 0x00333C80 File Offset: 0x00331E80
		public static Offset<IShowTimelineSwitchRole> Pack(FlatBufferBuilder builder, IShowTimelineSwitchRoleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowTimelineSwitchRole>);
			}
			return IShowTimelineSwitchRole.CreateIShowTimelineSwitchRole(builder, _o.Type, _o.RoleId);
		}

		// Token: 0x0400BADE RID: 47838
		private Table __p;
	}
}
