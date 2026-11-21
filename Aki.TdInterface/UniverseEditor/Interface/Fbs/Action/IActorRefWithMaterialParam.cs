using System;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006757 RID: 26455
	public struct IActorRefWithMaterialParam : IFlatbufferObject
	{
		// Token: 0x1700C05C RID: 49244
		// (get) Token: 0x0602CD53 RID: 183635 RVA: 0x00621A0B File Offset: 0x0061FC0B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CD54 RID: 183636 RVA: 0x00621A18 File Offset: 0x0061FC18
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CD55 RID: 183637 RVA: 0x00621A20 File Offset: 0x0061FC20
		public static IActorRefWithMaterialParam GetRootAsIActorRefWithMaterialParam(ByteBuffer _bb)
		{
			return IActorRefWithMaterialParam.GetRootAsIActorRefWithMaterialParam(_bb, default(IActorRefWithMaterialParam));
		}

		// Token: 0x0602CD56 RID: 183638 RVA: 0x00621A3C File Offset: 0x0061FC3C
		public static IActorRefWithMaterialParam GetRootAsIActorRefWithMaterialParam(ByteBuffer _bb, IActorRefWithMaterialParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CD57 RID: 183639 RVA: 0x00621A59 File Offset: 0x0061FC59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CD58 RID: 183640 RVA: 0x00621A68 File Offset: 0x0061FC68
		public IActorRefWithMaterialParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C05D RID: 49245
		// (get) Token: 0x0602CD59 RID: 183641 RVA: 0x00621A78 File Offset: 0x0061FC78
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

		// Token: 0x1700C05E RID: 49246
		// (get) Token: 0x0602CD5A RID: 183642 RVA: 0x00621AD8 File Offset: 0x0061FCD8
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

		// Token: 0x0602CD5B RID: 183643 RVA: 0x00621B0F File Offset: 0x0061FD0F
		public Span<byte> GetMaterialParamBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602CD5C RID: 183644 RVA: 0x00621B1E File Offset: 0x0061FD1E
		public byte[] GetMaterialParamArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602CD5D RID: 183645 RVA: 0x00621B2C File Offset: 0x0061FD2C
		public static Offset<IActorRefWithMaterialParam> CreateIActorRefWithMaterialParam(FlatBufferBuilder builder, Offset<IActorRef> ActorRefOffset = default(Offset<IActorRef>), StringOffset MaterialParamOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IActorRefWithMaterialParam.AddMaterialParam(builder, MaterialParamOffset);
			IActorRefWithMaterialParam.AddActorRef(builder, ActorRefOffset);
			return IActorRefWithMaterialParam.EndIActorRefWithMaterialParam(builder);
		}

		// Token: 0x0602CD5E RID: 183646 RVA: 0x00621B49 File Offset: 0x0061FD49
		public static void StartIActorRefWithMaterialParam(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602CD5F RID: 183647 RVA: 0x00621B52 File Offset: 0x0061FD52
		public static void AddActorRef(FlatBufferBuilder builder, Offset<IActorRef> actorRefOffset)
		{
			builder.AddOffset(0, actorRefOffset.Value, 0);
		}

		// Token: 0x0602CD60 RID: 183648 RVA: 0x00621B62 File Offset: 0x0061FD62
		public static void AddMaterialParam(FlatBufferBuilder builder, StringOffset materialParamOffset)
		{
			builder.AddOffset(1, materialParamOffset.Value, 0);
		}

		// Token: 0x0602CD61 RID: 183649 RVA: 0x00621B72 File Offset: 0x0061FD72
		public static Offset<IActorRefWithMaterialParam> EndIActorRefWithMaterialParam(FlatBufferBuilder builder)
		{
			return new Offset<IActorRefWithMaterialParam>(builder.EndTable());
		}

		// Token: 0x0602CD62 RID: 183650 RVA: 0x00621B80 File Offset: 0x0061FD80
		public IActorRefWithMaterialParamT UnPack()
		{
			IActorRefWithMaterialParamT actorRefWithMaterialParamT = new IActorRefWithMaterialParamT();
			this.UnPackTo(actorRefWithMaterialParamT);
			return actorRefWithMaterialParamT;
		}

		// Token: 0x0602CD63 RID: 183651 RVA: 0x00621B9C File Offset: 0x0061FD9C
		public void UnPackTo(IActorRefWithMaterialParamT _o)
		{
			_o.ActorRef = ((this.ActorRef != null) ? this.ActorRef.Value.UnPack() : null);
			_o.MaterialParam = this.MaterialParam;
		}

		// Token: 0x0602CD64 RID: 183652 RVA: 0x00621BE4 File Offset: 0x0061FDE4
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

		// Token: 0x040112BB RID: 70331
		private Table __p;
	}
}
