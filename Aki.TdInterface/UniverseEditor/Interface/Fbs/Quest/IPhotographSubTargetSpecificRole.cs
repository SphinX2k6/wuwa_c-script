using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043CA RID: 17354
	public struct IPhotographSubTargetSpecificRole : IFlatbufferObject
	{
		// Token: 0x17007786 RID: 30598
		// (get) Token: 0x06018A2B RID: 100907 RVA: 0x003838EB File Offset: 0x00381AEB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018A2C RID: 100908 RVA: 0x003838F8 File Offset: 0x00381AF8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018A2D RID: 100909 RVA: 0x00383900 File Offset: 0x00381B00
		public static IPhotographSubTargetSpecificRole GetRootAsIPhotographSubTargetSpecificRole(ByteBuffer _bb)
		{
			return IPhotographSubTargetSpecificRole.GetRootAsIPhotographSubTargetSpecificRole(_bb, default(IPhotographSubTargetSpecificRole));
		}

		// Token: 0x06018A2E RID: 100910 RVA: 0x0038391C File Offset: 0x00381B1C
		public static IPhotographSubTargetSpecificRole GetRootAsIPhotographSubTargetSpecificRole(ByteBuffer _bb, IPhotographSubTargetSpecificRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018A2F RID: 100911 RVA: 0x00383939 File Offset: 0x00381B39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018A30 RID: 100912 RVA: 0x00383948 File Offset: 0x00381B48
		public IPhotographSubTargetSpecificRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007787 RID: 30599
		// (get) Token: 0x06018A31 RID: 100913 RVA: 0x00383958 File Offset: 0x00381B58
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

		// Token: 0x17007788 RID: 30600
		// (get) Token: 0x06018A32 RID: 100914 RVA: 0x00383994 File Offset: 0x00381B94
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

		// Token: 0x17007789 RID: 30601
		// (get) Token: 0x06018A33 RID: 100915 RVA: 0x003839D0 File Offset: 0x00381BD0
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

		// Token: 0x1700778A RID: 30602
		// (get) Token: 0x06018A34 RID: 100916 RVA: 0x00383A0C File Offset: 0x00381C0C
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

		// Token: 0x1700778B RID: 30603
		// (get) Token: 0x06018A35 RID: 100917 RVA: 0x00383A6C File Offset: 0x00381C6C
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

		// Token: 0x06018A36 RID: 100918 RVA: 0x00383AA9 File Offset: 0x00381CA9
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

		// Token: 0x06018A37 RID: 100919 RVA: 0x00383ADD File Offset: 0x00381CDD
		public static void StartIPhotographSubTargetSpecificRole(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06018A38 RID: 100920 RVA: 0x00383AE6 File Offset: 0x00381CE6
		public static void AddType(FlatBufferBuilder builder, EPhotographSubTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018A39 RID: 100921 RVA: 0x00383AF1 File Offset: 0x00381CF1
		public static void AddRoleId(FlatBufferBuilder builder, int roleId)
		{
			builder.AddInt(1, roleId, 0);
		}

		// Token: 0x06018A3A RID: 100922 RVA: 0x00383AFC File Offset: 0x00381CFC
		public static void AddOnCameraCheckType(FlatBufferBuilder builder, EOnCameraCheckType onCameraCheckType)
		{
			builder.AddByte(2, (byte)onCameraCheckType, 0);
		}

		// Token: 0x06018A3B RID: 100923 RVA: 0x00383B07 File Offset: 0x00381D07
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(3, conditionOffset.Value, 0);
		}

		// Token: 0x06018A3C RID: 100924 RVA: 0x00383B17 File Offset: 0x00381D17
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06018A3D RID: 100925 RVA: 0x00383B22 File Offset: 0x00381D22
		public static Offset<IPhotographSubTargetSpecificRole> EndIPhotographSubTargetSpecificRole(FlatBufferBuilder builder)
		{
			return new Offset<IPhotographSubTargetSpecificRole>(builder.EndTable());
		}

		// Token: 0x06018A3E RID: 100926 RVA: 0x00383B30 File Offset: 0x00381D30
		public IPhotographSubTargetSpecificRoleT UnPack()
		{
			IPhotographSubTargetSpecificRoleT photographSubTargetSpecificRoleT = new IPhotographSubTargetSpecificRoleT();
			this.UnPackTo(photographSubTargetSpecificRoleT);
			return photographSubTargetSpecificRoleT;
		}

		// Token: 0x06018A3F RID: 100927 RVA: 0x00383B4C File Offset: 0x00381D4C
		public void UnPackTo(IPhotographSubTargetSpecificRoleT _o)
		{
			_o.Type = this.Type;
			_o.RoleId = this.RoleId;
			_o.OnCameraCheckType = this.OnCameraCheckType;
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06018A40 RID: 100928 RVA: 0x00383BB8 File Offset: 0x00381DB8
		public static Offset<IPhotographSubTargetSpecificRole> Pack(FlatBufferBuilder builder, IPhotographSubTargetSpecificRoleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhotographSubTargetSpecificRole>);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			return IPhotographSubTargetSpecificRole.CreateIPhotographSubTargetSpecificRole(builder, _o.Type, _o.RoleId, _o.OnCameraCheckType, conditionOffset, _o.NullMask);
		}

		// Token: 0x0400C3C5 RID: 50117
		private Table __p;
	}
}
