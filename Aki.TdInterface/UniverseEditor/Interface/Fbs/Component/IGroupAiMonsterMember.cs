using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005341 RID: 21313
	public struct IGroupAiMonsterMember : IFlatbufferObject
	{
		// Token: 0x17009C8C RID: 40076
		// (get) Token: 0x06022DA2 RID: 142754 RVA: 0x004D4107 File Offset: 0x004D2307
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022DA3 RID: 142755 RVA: 0x004D4114 File Offset: 0x004D2314
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022DA4 RID: 142756 RVA: 0x004D411C File Offset: 0x004D231C
		public static IGroupAiMonsterMember GetRootAsIGroupAiMonsterMember(ByteBuffer _bb)
		{
			return IGroupAiMonsterMember.GetRootAsIGroupAiMonsterMember(_bb, default(IGroupAiMonsterMember));
		}

		// Token: 0x06022DA5 RID: 142757 RVA: 0x004D4138 File Offset: 0x004D2338
		public static IGroupAiMonsterMember GetRootAsIGroupAiMonsterMember(ByteBuffer _bb, IGroupAiMonsterMember obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022DA6 RID: 142758 RVA: 0x004D4155 File Offset: 0x004D2355
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022DA7 RID: 142759 RVA: 0x004D4164 File Offset: 0x004D2364
		public IGroupAiMonsterMember __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009C8D RID: 40077
		// (get) Token: 0x06022DA8 RID: 142760 RVA: 0x004D4174 File Offset: 0x004D2374
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009C8E RID: 40078
		// (get) Token: 0x06022DA9 RID: 142761 RVA: 0x004D41B0 File Offset: 0x004D23B0
		public IPosAndRot? RelativeTransform
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPosAndRot?(default(IPosAndRot).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009C8F RID: 40079
		// (get) Token: 0x06022DAA RID: 142762 RVA: 0x004D4210 File Offset: 0x004D2410
		public IGroupAiMonsterMemberActionTagAttach? ActionTagAttach
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IGroupAiMonsterMemberActionTagAttach?(default(IGroupAiMonsterMemberActionTagAttach).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06022DAB RID: 142763 RVA: 0x004D426D File Offset: 0x004D246D
		public static Offset<IGroupAiMonsterMember> CreateIGroupAiMonsterMember(FlatBufferBuilder builder, int EntityId = 0, Offset<IPosAndRot> RelativeTransformOffset = default(Offset<IPosAndRot>), Offset<IGroupAiMonsterMemberActionTagAttach> ActionTagAttachOffset = default(Offset<IGroupAiMonsterMemberActionTagAttach>))
		{
			builder.StartTable(3);
			IGroupAiMonsterMember.AddActionTagAttach(builder, ActionTagAttachOffset);
			IGroupAiMonsterMember.AddRelativeTransform(builder, RelativeTransformOffset);
			IGroupAiMonsterMember.AddEntityId(builder, EntityId);
			return IGroupAiMonsterMember.EndIGroupAiMonsterMember(builder);
		}

		// Token: 0x06022DAC RID: 142764 RVA: 0x004D4291 File Offset: 0x004D2491
		public static void StartIGroupAiMonsterMember(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06022DAD RID: 142765 RVA: 0x004D429A File Offset: 0x004D249A
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06022DAE RID: 142766 RVA: 0x004D42A5 File Offset: 0x004D24A5
		public static void AddRelativeTransform(FlatBufferBuilder builder, Offset<IPosAndRot> relativeTransformOffset)
		{
			builder.AddOffset(1, relativeTransformOffset.Value, 0);
		}

		// Token: 0x06022DAF RID: 142767 RVA: 0x004D42B5 File Offset: 0x004D24B5
		public static void AddActionTagAttach(FlatBufferBuilder builder, Offset<IGroupAiMonsterMemberActionTagAttach> actionTagAttachOffset)
		{
			builder.AddOffset(2, actionTagAttachOffset.Value, 0);
		}

		// Token: 0x06022DB0 RID: 142768 RVA: 0x004D42C5 File Offset: 0x004D24C5
		public static Offset<IGroupAiMonsterMember> EndIGroupAiMonsterMember(FlatBufferBuilder builder)
		{
			return new Offset<IGroupAiMonsterMember>(builder.EndTable());
		}

		// Token: 0x06022DB1 RID: 142769 RVA: 0x004D42D4 File Offset: 0x004D24D4
		public IGroupAiMonsterMemberT UnPack()
		{
			IGroupAiMonsterMemberT groupAiMonsterMemberT = new IGroupAiMonsterMemberT();
			this.UnPackTo(groupAiMonsterMemberT);
			return groupAiMonsterMemberT;
		}

		// Token: 0x06022DB2 RID: 142770 RVA: 0x004D42F0 File Offset: 0x004D24F0
		public void UnPackTo(IGroupAiMonsterMemberT _o)
		{
			_o.EntityId = this.EntityId;
			_o.RelativeTransform = ((this.RelativeTransform != null) ? this.RelativeTransform.Value.UnPack() : null);
			_o.ActionTagAttach = ((this.ActionTagAttach != null) ? this.ActionTagAttach.Value.UnPack() : null);
		}

		// Token: 0x06022DB3 RID: 142771 RVA: 0x004D4368 File Offset: 0x004D2568
		public static Offset<IGroupAiMonsterMember> Pack(FlatBufferBuilder builder, IGroupAiMonsterMemberT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGroupAiMonsterMember>);
			}
			Offset<IPosAndRot> relativeTransformOffset = (_o.RelativeTransform == null) ? default(Offset<IPosAndRot>) : IPosAndRot.Pack(builder, _o.RelativeTransform);
			Offset<IGroupAiMonsterMemberActionTagAttach> actionTagAttachOffset = (_o.ActionTagAttach == null) ? default(Offset<IGroupAiMonsterMemberActionTagAttach>) : IGroupAiMonsterMemberActionTagAttach.Pack(builder, _o.ActionTagAttach);
			return IGroupAiMonsterMember.CreateIGroupAiMonsterMember(builder, _o.EntityId, relativeTransformOffset, actionTagAttachOffset);
		}

		// Token: 0x0400E50C RID: 58636
		private Table __p;
	}
}
