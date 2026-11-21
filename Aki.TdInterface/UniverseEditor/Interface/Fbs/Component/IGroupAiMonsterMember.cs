using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058C7 RID: 22727
	public struct IGroupAiMonsterMember : IFlatbufferObject
	{
		// Token: 0x1700A4C4 RID: 42180
		// (get) Token: 0x06024E56 RID: 151126 RVA: 0x00510FDB File Offset: 0x0050F1DB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024E57 RID: 151127 RVA: 0x00510FE8 File Offset: 0x0050F1E8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024E58 RID: 151128 RVA: 0x00510FF0 File Offset: 0x0050F1F0
		public static IGroupAiMonsterMember GetRootAsIGroupAiMonsterMember(ByteBuffer _bb)
		{
			return IGroupAiMonsterMember.GetRootAsIGroupAiMonsterMember(_bb, default(IGroupAiMonsterMember));
		}

		// Token: 0x06024E59 RID: 151129 RVA: 0x0051100C File Offset: 0x0050F20C
		public static IGroupAiMonsterMember GetRootAsIGroupAiMonsterMember(ByteBuffer _bb, IGroupAiMonsterMember obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024E5A RID: 151130 RVA: 0x00511029 File Offset: 0x0050F229
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024E5B RID: 151131 RVA: 0x00511038 File Offset: 0x0050F238
		public IGroupAiMonsterMember __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A4C5 RID: 42181
		// (get) Token: 0x06024E5C RID: 151132 RVA: 0x00511048 File Offset: 0x0050F248
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

		// Token: 0x1700A4C6 RID: 42182
		// (get) Token: 0x06024E5D RID: 151133 RVA: 0x00511084 File Offset: 0x0050F284
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

		// Token: 0x1700A4C7 RID: 42183
		// (get) Token: 0x06024E5E RID: 151134 RVA: 0x005110E4 File Offset: 0x0050F2E4
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

		// Token: 0x06024E5F RID: 151135 RVA: 0x00511141 File Offset: 0x0050F341
		public static Offset<IGroupAiMonsterMember> CreateIGroupAiMonsterMember(FlatBufferBuilder builder, int EntityId = 0, Offset<IPosAndRot> RelativeTransformOffset = default(Offset<IPosAndRot>), Offset<IGroupAiMonsterMemberActionTagAttach> ActionTagAttachOffset = default(Offset<IGroupAiMonsterMemberActionTagAttach>))
		{
			builder.StartTable(3);
			IGroupAiMonsterMember.AddActionTagAttach(builder, ActionTagAttachOffset);
			IGroupAiMonsterMember.AddRelativeTransform(builder, RelativeTransformOffset);
			IGroupAiMonsterMember.AddEntityId(builder, EntityId);
			return IGroupAiMonsterMember.EndIGroupAiMonsterMember(builder);
		}

		// Token: 0x06024E60 RID: 151136 RVA: 0x00511165 File Offset: 0x0050F365
		public static void StartIGroupAiMonsterMember(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06024E61 RID: 151137 RVA: 0x0051116E File Offset: 0x0050F36E
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06024E62 RID: 151138 RVA: 0x00511179 File Offset: 0x0050F379
		public static void AddRelativeTransform(FlatBufferBuilder builder, Offset<IPosAndRot> relativeTransformOffset)
		{
			builder.AddOffset(1, relativeTransformOffset.Value, 0);
		}

		// Token: 0x06024E63 RID: 151139 RVA: 0x00511189 File Offset: 0x0050F389
		public static void AddActionTagAttach(FlatBufferBuilder builder, Offset<IGroupAiMonsterMemberActionTagAttach> actionTagAttachOffset)
		{
			builder.AddOffset(2, actionTagAttachOffset.Value, 0);
		}

		// Token: 0x06024E64 RID: 151140 RVA: 0x00511199 File Offset: 0x0050F399
		public static Offset<IGroupAiMonsterMember> EndIGroupAiMonsterMember(FlatBufferBuilder builder)
		{
			return new Offset<IGroupAiMonsterMember>(builder.EndTable());
		}

		// Token: 0x06024E65 RID: 151141 RVA: 0x005111A8 File Offset: 0x0050F3A8
		public IGroupAiMonsterMemberT UnPack()
		{
			IGroupAiMonsterMemberT groupAiMonsterMemberT = new IGroupAiMonsterMemberT();
			this.UnPackTo(groupAiMonsterMemberT);
			return groupAiMonsterMemberT;
		}

		// Token: 0x06024E66 RID: 151142 RVA: 0x005111C4 File Offset: 0x0050F3C4
		public void UnPackTo(IGroupAiMonsterMemberT _o)
		{
			_o.EntityId = this.EntityId;
			_o.RelativeTransform = ((this.RelativeTransform != null) ? this.RelativeTransform.Value.UnPack() : null);
			_o.ActionTagAttach = ((this.ActionTagAttach != null) ? this.ActionTagAttach.Value.UnPack() : null);
		}

		// Token: 0x06024E67 RID: 151143 RVA: 0x0051123C File Offset: 0x0050F43C
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

		// Token: 0x0400F13C RID: 61756
		private Table __p;
	}
}
