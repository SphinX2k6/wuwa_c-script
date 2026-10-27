using System;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060F5 RID: 24821
	public struct IActorRefWithMaterialParam : IFlatbufferObject
	{
		// Token: 0x1700B6F1 RID: 46833
		// (get) Token: 0x0602A672 RID: 173682 RVA: 0x005D7A63 File Offset: 0x005D5C63
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A673 RID: 173683 RVA: 0x005D7A70 File Offset: 0x005D5C70
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A674 RID: 173684 RVA: 0x005D7A78 File Offset: 0x005D5C78
		public static IActorRefWithMaterialParam GetRootAsIActorRefWithMaterialParam(ByteBuffer _bb)
		{
			return IActorRefWithMaterialParam.GetRootAsIActorRefWithMaterialParam(_bb, default(IActorRefWithMaterialParam));
		}

		// Token: 0x0602A675 RID: 173685 RVA: 0x005D7A94 File Offset: 0x005D5C94
		public static IActorRefWithMaterialParam GetRootAsIActorRefWithMaterialParam(ByteBuffer _bb, IActorRefWithMaterialParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A676 RID: 173686 RVA: 0x005D7AB1 File Offset: 0x005D5CB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A677 RID: 173687 RVA: 0x005D7AC0 File Offset: 0x005D5CC0
		public IActorRefWithMaterialParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B6F2 RID: 46834
		// (get) Token: 0x0602A678 RID: 173688 RVA: 0x005D7AD0 File Offset: 0x005D5CD0
		public IActorRef? ActorRef
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IActorRef?(default(IActorRef).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B6F3 RID: 46835
		// (get) Token: 0x0602A679 RID: 173689 RVA: 0x005D7B30 File Offset: 0x005D5D30
		public string MaterialParam
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A67A RID: 173690 RVA: 0x005D7B67 File Offset: 0x005D5D67
		public Span<byte> GetMaterialParamBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602A67B RID: 173691 RVA: 0x005D7B76 File Offset: 0x005D5D76
		public byte[] GetMaterialParamArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602A67C RID: 173692 RVA: 0x005D7B84 File Offset: 0x005D5D84
		public static Offset<IActorRefWithMaterialParam> CreateIActorRefWithMaterialParam(FlatBufferBuilder builder, Offset<IActorRef> ActorRefOffset = default(Offset<IActorRef>), StringOffset MaterialParamOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IActorRefWithMaterialParam.AddMaterialParam(builder, MaterialParamOffset);
			IActorRefWithMaterialParam.AddActorRef(builder, ActorRefOffset);
			return IActorRefWithMaterialParam.EndIActorRefWithMaterialParam(builder);
		}

		// Token: 0x0602A67D RID: 173693 RVA: 0x005D7BA1 File Offset: 0x005D5DA1
		public static void StartIActorRefWithMaterialParam(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602A67E RID: 173694 RVA: 0x005D7BAA File Offset: 0x005D5DAA
		public static void AddActorRef(FlatBufferBuilder builder, Offset<IActorRef> actorRefOffset)
		{
			builder.AddOffset(0, actorRefOffset.Value, 0);
		}

		// Token: 0x0602A67F RID: 173695 RVA: 0x005D7BBA File Offset: 0x005D5DBA
		public static void AddMaterialParam(FlatBufferBuilder builder, StringOffset materialParamOffset)
		{
			builder.AddOffset(1, materialParamOffset.Value, 0);
		}

		// Token: 0x0602A680 RID: 173696 RVA: 0x005D7BCA File Offset: 0x005D5DCA
		public static Offset<IActorRefWithMaterialParam> EndIActorRefWithMaterialParam(FlatBufferBuilder builder)
		{
			return new Offset<IActorRefWithMaterialParam>(builder.EndTable());
		}

		// Token: 0x0602A681 RID: 173697 RVA: 0x005D7BD8 File Offset: 0x005D5DD8
		public IActorRefWithMaterialParamT UnPack()
		{
			IActorRefWithMaterialParamT actorRefWithMaterialParamT = new IActorRefWithMaterialParamT();
			this.UnPackTo(actorRefWithMaterialParamT);
			return actorRefWithMaterialParamT;
		}

		// Token: 0x0602A682 RID: 173698 RVA: 0x005D7BF4 File Offset: 0x005D5DF4
		public void UnPackTo(IActorRefWithMaterialParamT _o)
		{
			_o.ActorRef = ((this.ActorRef != null) ? this.ActorRef.Value.UnPack() : null);
			_o.MaterialParam = this.MaterialParam;
		}

		// Token: 0x0602A683 RID: 173699 RVA: 0x005D7C3C File Offset: 0x005D5E3C
		public static Offset<IActorRefWithMaterialParam> Pack(FlatBufferBuilder builder, IActorRefWithMaterialParamT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorRefWithMaterialParam>);
			}
			Offset<IActorRef> actorRefOffset = (_o.ActorRef == null) ? default(Offset<IActorRef>) : IActorRef.Pack(builder, _o.ActorRef);
			StringOffset materialParamOffset = (_o.MaterialParam == null) ? default(StringOffset) : builder.CreateString(_o.MaterialParam);
			return IActorRefWithMaterialParam.CreateIActorRefWithMaterialParam(builder, actorRefOffset, materialParamOffset);
		}

		// Token: 0x040104B7 RID: 66743
		private Table __p;
	}
}
