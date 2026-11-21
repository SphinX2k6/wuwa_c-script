using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043C7 RID: 17351
	public struct IPhotographSubTargetAnyRole : IFlatbufferObject
	{
		// Token: 0x1700777F RID: 30591
		// (get) Token: 0x06018A11 RID: 100881 RVA: 0x003835D1 File Offset: 0x003817D1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018A12 RID: 100882 RVA: 0x003835DE File Offset: 0x003817DE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018A13 RID: 100883 RVA: 0x003835E8 File Offset: 0x003817E8
		public static IPhotographSubTargetAnyRole GetRootAsIPhotographSubTargetAnyRole(ByteBuffer _bb)
		{
			return IPhotographSubTargetAnyRole.GetRootAsIPhotographSubTargetAnyRole(_bb, default(IPhotographSubTargetAnyRole));
		}

		// Token: 0x06018A14 RID: 100884 RVA: 0x00383604 File Offset: 0x00381804
		public static IPhotographSubTargetAnyRole GetRootAsIPhotographSubTargetAnyRole(ByteBuffer _bb, IPhotographSubTargetAnyRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018A15 RID: 100885 RVA: 0x00383621 File Offset: 0x00381821
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018A16 RID: 100886 RVA: 0x00383630 File Offset: 0x00381830
		public IPhotographSubTargetAnyRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007780 RID: 30592
		// (get) Token: 0x06018A17 RID: 100887 RVA: 0x00383640 File Offset: 0x00381840
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

		// Token: 0x17007781 RID: 30593
		// (get) Token: 0x06018A18 RID: 100888 RVA: 0x0038367C File Offset: 0x0038187C
		public EOnCameraCheckType OnCameraCheckType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EOnCameraCheckType.All;
				}
				return (EOnCameraCheckType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007782 RID: 30594
		// (get) Token: 0x06018A19 RID: 100889 RVA: 0x003836B8 File Offset: 0x003818B8
		public IConditionGroup? Condition
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06018A1A RID: 100890 RVA: 0x00383715 File Offset: 0x00381915
		public static Offset<IPhotographSubTargetAnyRole> CreateIPhotographSubTargetAnyRole(FlatBufferBuilder builder, EPhotographSubTargetType Type = EPhotographSubTargetType.SpecificRole, EOnCameraCheckType OnCameraCheckType = EOnCameraCheckType.All, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>))
		{
			builder.StartTable(3);
			IPhotographSubTargetAnyRole.AddCondition(builder, ConditionOffset);
			IPhotographSubTargetAnyRole.AddOnCameraCheckType(builder, OnCameraCheckType);
			IPhotographSubTargetAnyRole.AddType(builder, Type);
			return IPhotographSubTargetAnyRole.EndIPhotographSubTargetAnyRole(builder);
		}

		// Token: 0x06018A1B RID: 100891 RVA: 0x00383739 File Offset: 0x00381939
		public static void StartIPhotographSubTargetAnyRole(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06018A1C RID: 100892 RVA: 0x00383742 File Offset: 0x00381942
		public static void AddType(FlatBufferBuilder builder, EPhotographSubTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018A1D RID: 100893 RVA: 0x0038374D File Offset: 0x0038194D
		public static void AddOnCameraCheckType(FlatBufferBuilder builder, EOnCameraCheckType onCameraCheckType)
		{
			builder.AddByte(1, (byte)onCameraCheckType, 0);
		}

		// Token: 0x06018A1E RID: 100894 RVA: 0x00383758 File Offset: 0x00381958
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(2, conditionOffset.Value, 0);
		}

		// Token: 0x06018A1F RID: 100895 RVA: 0x00383768 File Offset: 0x00381968
		public static Offset<IPhotographSubTargetAnyRole> EndIPhotographSubTargetAnyRole(FlatBufferBuilder builder)
		{
			return new Offset<IPhotographSubTargetAnyRole>(builder.EndTable());
		}

		// Token: 0x06018A20 RID: 100896 RVA: 0x00383778 File Offset: 0x00381978
		public IPhotographSubTargetAnyRoleT UnPack()
		{
			IPhotographSubTargetAnyRoleT photographSubTargetAnyRoleT = new IPhotographSubTargetAnyRoleT();
			this.UnPackTo(photographSubTargetAnyRoleT);
			return photographSubTargetAnyRoleT;
		}

		// Token: 0x06018A21 RID: 100897 RVA: 0x00383794 File Offset: 0x00381994
		public void UnPackTo(IPhotographSubTargetAnyRoleT _o)
		{
			_o.Type = this.Type;
			_o.OnCameraCheckType = this.OnCameraCheckType;
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
		}

		// Token: 0x06018A22 RID: 100898 RVA: 0x003837E8 File Offset: 0x003819E8
		public static Offset<IPhotographSubTargetAnyRole> Pack(FlatBufferBuilder builder, IPhotographSubTargetAnyRoleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhotographSubTargetAnyRole>);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			return IPhotographSubTargetAnyRole.CreateIPhotographSubTargetAnyRole(builder, _o.Type, _o.OnCameraCheckType, conditionOffset);
		}

		// Token: 0x0400C3C1 RID: 50113
		private Table __p;
	}
}
