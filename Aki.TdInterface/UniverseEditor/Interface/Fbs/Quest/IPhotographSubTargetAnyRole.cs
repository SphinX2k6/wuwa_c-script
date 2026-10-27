using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F86 RID: 16262
	public struct IPhotographSubTargetAnyRole : IFlatbufferObject
	{
		// Token: 0x17007181 RID: 29057
		// (get) Token: 0x06017382 RID: 95106 RVA: 0x003599B9 File Offset: 0x00357BB9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017383 RID: 95107 RVA: 0x003599C6 File Offset: 0x00357BC6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017384 RID: 95108 RVA: 0x003599D0 File Offset: 0x00357BD0
		public static IPhotographSubTargetAnyRole GetRootAsIPhotographSubTargetAnyRole(ByteBuffer _bb)
		{
			return IPhotographSubTargetAnyRole.GetRootAsIPhotographSubTargetAnyRole(_bb, default(IPhotographSubTargetAnyRole));
		}

		// Token: 0x06017385 RID: 95109 RVA: 0x003599EC File Offset: 0x00357BEC
		public static IPhotographSubTargetAnyRole GetRootAsIPhotographSubTargetAnyRole(ByteBuffer _bb, IPhotographSubTargetAnyRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017386 RID: 95110 RVA: 0x00359A09 File Offset: 0x00357C09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017387 RID: 95111 RVA: 0x00359A18 File Offset: 0x00357C18
		public IPhotographSubTargetAnyRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007182 RID: 29058
		// (get) Token: 0x06017388 RID: 95112 RVA: 0x00359A28 File Offset: 0x00357C28
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

		// Token: 0x17007183 RID: 29059
		// (get) Token: 0x06017389 RID: 95113 RVA: 0x00359A64 File Offset: 0x00357C64
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

		// Token: 0x17007184 RID: 29060
		// (get) Token: 0x0601738A RID: 95114 RVA: 0x00359AA0 File Offset: 0x00357CA0
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

		// Token: 0x0601738B RID: 95115 RVA: 0x00359AFD File Offset: 0x00357CFD
		public static Offset<IPhotographSubTargetAnyRole> CreateIPhotographSubTargetAnyRole(FlatBufferBuilder builder, EPhotographSubTargetType Type = EPhotographSubTargetType.SpecificRole, EOnCameraCheckType OnCameraCheckType = EOnCameraCheckType.All, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>))
		{
			builder.StartTable(3);
			IPhotographSubTargetAnyRole.AddCondition(builder, ConditionOffset);
			IPhotographSubTargetAnyRole.AddOnCameraCheckType(builder, OnCameraCheckType);
			IPhotographSubTargetAnyRole.AddType(builder, Type);
			return IPhotographSubTargetAnyRole.EndIPhotographSubTargetAnyRole(builder);
		}

		// Token: 0x0601738C RID: 95116 RVA: 0x00359B21 File Offset: 0x00357D21
		public static void StartIPhotographSubTargetAnyRole(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601738D RID: 95117 RVA: 0x00359B2A File Offset: 0x00357D2A
		public static void AddType(FlatBufferBuilder builder, EPhotographSubTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601738E RID: 95118 RVA: 0x00359B35 File Offset: 0x00357D35
		public static void AddOnCameraCheckType(FlatBufferBuilder builder, EOnCameraCheckType onCameraCheckType)
		{
			builder.AddByte(1, (byte)onCameraCheckType, 0);
		}

		// Token: 0x0601738F RID: 95119 RVA: 0x00359B40 File Offset: 0x00357D40
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(2, conditionOffset.Value, 0);
		}

		// Token: 0x06017390 RID: 95120 RVA: 0x00359B50 File Offset: 0x00357D50
		public static Offset<IPhotographSubTargetAnyRole> EndIPhotographSubTargetAnyRole(FlatBufferBuilder builder)
		{
			return new Offset<IPhotographSubTargetAnyRole>(builder.EndTable());
		}

		// Token: 0x06017391 RID: 95121 RVA: 0x00359B60 File Offset: 0x00357D60
		public IPhotographSubTargetAnyRoleT UnPack()
		{
			IPhotographSubTargetAnyRoleT photographSubTargetAnyRoleT = new IPhotographSubTargetAnyRoleT();
			this.UnPackTo(photographSubTargetAnyRoleT);
			return photographSubTargetAnyRoleT;
		}

		// Token: 0x06017392 RID: 95122 RVA: 0x00359B7C File Offset: 0x00357D7C
		public void UnPackTo(IPhotographSubTargetAnyRoleT _o)
		{
			_o.Type = this.Type;
			_o.OnCameraCheckType = this.OnCameraCheckType;
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
		}

		// Token: 0x06017393 RID: 95123 RVA: 0x00359BD0 File Offset: 0x00357DD0
		public static Offset<IPhotographSubTargetAnyRole> Pack(FlatBufferBuilder builder, IPhotographSubTargetAnyRoleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhotographSubTargetAnyRole>);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			return IPhotographSubTargetAnyRole.CreateIPhotographSubTargetAnyRole(builder, _o.Type, _o.OnCameraCheckType, conditionOffset);
		}

		// Token: 0x0400B9DC RID: 47580
		private Table __p;
	}
}
