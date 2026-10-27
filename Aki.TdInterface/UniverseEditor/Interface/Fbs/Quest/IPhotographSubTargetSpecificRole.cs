using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F89 RID: 16265
	public struct IPhotographSubTargetSpecificRole : IFlatbufferObject
	{
		// Token: 0x17007188 RID: 29064
		// (get) Token: 0x0601739C RID: 95132 RVA: 0x00359CD3 File Offset: 0x00357ED3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601739D RID: 95133 RVA: 0x00359CE0 File Offset: 0x00357EE0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601739E RID: 95134 RVA: 0x00359CE8 File Offset: 0x00357EE8
		public static IPhotographSubTargetSpecificRole GetRootAsIPhotographSubTargetSpecificRole(ByteBuffer _bb)
		{
			return IPhotographSubTargetSpecificRole.GetRootAsIPhotographSubTargetSpecificRole(_bb, default(IPhotographSubTargetSpecificRole));
		}

		// Token: 0x0601739F RID: 95135 RVA: 0x00359D04 File Offset: 0x00357F04
		public static IPhotographSubTargetSpecificRole GetRootAsIPhotographSubTargetSpecificRole(ByteBuffer _bb, IPhotographSubTargetSpecificRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060173A0 RID: 95136 RVA: 0x00359D21 File Offset: 0x00357F21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060173A1 RID: 95137 RVA: 0x00359D30 File Offset: 0x00357F30
		public IPhotographSubTargetSpecificRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007189 RID: 29065
		// (get) Token: 0x060173A2 RID: 95138 RVA: 0x00359D40 File Offset: 0x00357F40
		public EPhotographSubTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPhotographSubTargetType.SpecificRole;
				}
				return (EPhotographSubTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700718A RID: 29066
		// (get) Token: 0x060173A3 RID: 95139 RVA: 0x00359D7C File Offset: 0x00357F7C
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

		// Token: 0x1700718B RID: 29067
		// (get) Token: 0x060173A4 RID: 95140 RVA: 0x00359DB8 File Offset: 0x00357FB8
		public EOnCameraCheckType OnCameraCheckType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EOnCameraCheckType.All;
				}
				return (EOnCameraCheckType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700718C RID: 29068
		// (get) Token: 0x060173A5 RID: 95141 RVA: 0x00359DF4 File Offset: 0x00357FF4
		public IConditionGroup? Condition
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700718D RID: 29069
		// (get) Token: 0x060173A6 RID: 95142 RVA: 0x00359E54 File Offset: 0x00358054
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060173A7 RID: 95143 RVA: 0x00359E91 File Offset: 0x00358091
		public static Offset<IPhotographSubTargetSpecificRole> CreateIPhotographSubTargetSpecificRole(FlatBufferBuilder builder, EPhotographSubTargetType Type = EPhotographSubTargetType.SpecificRole, int RoleId = 0, EOnCameraCheckType OnCameraCheckType = EOnCameraCheckType.All, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), byte NullMask = 0)
		{
			builder.StartTable(5);
			IPhotographSubTargetSpecificRole.AddCondition(builder, ConditionOffset);
			IPhotographSubTargetSpecificRole.AddRoleId(builder, RoleId);
			IPhotographSubTargetSpecificRole.AddNullMask(builder, NullMask);
			IPhotographSubTargetSpecificRole.AddOnCameraCheckType(builder, OnCameraCheckType);
			IPhotographSubTargetSpecificRole.AddType(builder, Type);
			return IPhotographSubTargetSpecificRole.EndIPhotographSubTargetSpecificRole(builder);
		}

		// Token: 0x060173A8 RID: 95144 RVA: 0x00359EC5 File Offset: 0x003580C5
		public static void StartIPhotographSubTargetSpecificRole(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060173A9 RID: 95145 RVA: 0x00359ECE File Offset: 0x003580CE
		public static void AddType(FlatBufferBuilder builder, EPhotographSubTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060173AA RID: 95146 RVA: 0x00359ED9 File Offset: 0x003580D9
		public static void AddRoleId(FlatBufferBuilder builder, int roleId)
		{
			builder.AddInt(1, roleId, 0);
		}

		// Token: 0x060173AB RID: 95147 RVA: 0x00359EE4 File Offset: 0x003580E4
		public static void AddOnCameraCheckType(FlatBufferBuilder builder, EOnCameraCheckType onCameraCheckType)
		{
			builder.AddByte(2, (byte)onCameraCheckType, 0);
		}

		// Token: 0x060173AC RID: 95148 RVA: 0x00359EEF File Offset: 0x003580EF
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(3, conditionOffset.Value, 0);
		}

		// Token: 0x060173AD RID: 95149 RVA: 0x00359EFF File Offset: 0x003580FF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060173AE RID: 95150 RVA: 0x00359F0A File Offset: 0x0035810A
		public static Offset<IPhotographSubTargetSpecificRole> EndIPhotographSubTargetSpecificRole(FlatBufferBuilder builder)
		{
			return new Offset<IPhotographSubTargetSpecificRole>(builder.EndTable());
		}

		// Token: 0x060173AF RID: 95151 RVA: 0x00359F18 File Offset: 0x00358118
		public IPhotographSubTargetSpecificRoleT UnPack()
		{
			IPhotographSubTargetSpecificRoleT photographSubTargetSpecificRoleT = new IPhotographSubTargetSpecificRoleT();
			this.UnPackTo(photographSubTargetSpecificRoleT);
			return photographSubTargetSpecificRoleT;
		}

		// Token: 0x060173B0 RID: 95152 RVA: 0x00359F34 File Offset: 0x00358134
		public void UnPackTo(IPhotographSubTargetSpecificRoleT _o)
		{
			_o.Type = this.Type;
			_o.RoleId = this.RoleId;
			_o.OnCameraCheckType = this.OnCameraCheckType;
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060173B1 RID: 95153 RVA: 0x00359FA0 File Offset: 0x003581A0
		public static Offset<IPhotographSubTargetSpecificRole> Pack(FlatBufferBuilder builder, IPhotographSubTargetSpecificRoleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhotographSubTargetSpecificRole>);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			return IPhotographSubTargetSpecificRole.CreateIPhotographSubTargetSpecificRole(builder, _o.Type, _o.RoleId, _o.OnCameraCheckType, conditionOffset, _o.NullMask);
		}

		// Token: 0x0400B9E0 RID: 47584
		private Table __p;
	}
}
