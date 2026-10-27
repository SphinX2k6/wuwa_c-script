using System;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003BE3 RID: 15331
	public struct IActorCollisionTriggerShape : IFlatbufferObject
	{
		// Token: 0x1700692D RID: 26925
		// (get) Token: 0x06015137 RID: 86327 RVA: 0x0030E03A File Offset: 0x0030C23A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015138 RID: 86328 RVA: 0x0030E047 File Offset: 0x0030C247
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015139 RID: 86329 RVA: 0x0030E050 File Offset: 0x0030C250
		public static IActorCollisionTriggerShape GetRootAsIActorCollisionTriggerShape(ByteBuffer _bb)
		{
			return IActorCollisionTriggerShape.GetRootAsIActorCollisionTriggerShape(_bb, default(IActorCollisionTriggerShape));
		}

		// Token: 0x0601513A RID: 86330 RVA: 0x0030E06C File Offset: 0x0030C26C
		public static IActorCollisionTriggerShape GetRootAsIActorCollisionTriggerShape(ByteBuffer _bb, IActorCollisionTriggerShape obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601513B RID: 86331 RVA: 0x0030E089 File Offset: 0x0030C289
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601513C RID: 86332 RVA: 0x0030E098 File Offset: 0x0030C298
		public IActorCollisionTriggerShape __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700692E RID: 26926
		// (get) Token: 0x0601513D RID: 86333 RVA: 0x0030E0A8 File Offset: 0x0030C2A8
		public ETriggerShape Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETriggerShape.Box;
				}
				return (ETriggerShape)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700692F RID: 26927
		// (get) Token: 0x0601513E RID: 86334 RVA: 0x0030E0E4 File Offset: 0x0030C2E4
		public IActorRef? ActorRef
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IActorRef?(default(IActorRef).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601513F RID: 86335 RVA: 0x0030E141 File Offset: 0x0030C341
		public static Offset<IActorCollisionTriggerShape> CreateIActorCollisionTriggerShape(FlatBufferBuilder builder, ETriggerShape Type = ETriggerShape.Box, Offset<IActorRef> ActorRefOffset = default(Offset<IActorRef>))
		{
			builder.StartTable(2);
			IActorCollisionTriggerShape.AddActorRef(builder, ActorRefOffset);
			IActorCollisionTriggerShape.AddType(builder, Type);
			return IActorCollisionTriggerShape.EndIActorCollisionTriggerShape(builder);
		}

		// Token: 0x06015140 RID: 86336 RVA: 0x0030E15E File Offset: 0x0030C35E
		public static void StartIActorCollisionTriggerShape(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06015141 RID: 86337 RVA: 0x0030E167 File Offset: 0x0030C367
		public static void AddType(FlatBufferBuilder builder, ETriggerShape type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015142 RID: 86338 RVA: 0x0030E172 File Offset: 0x0030C372
		public static void AddActorRef(FlatBufferBuilder builder, Offset<IActorRef> actorRefOffset)
		{
			builder.AddOffset(1, actorRefOffset.Value, 0);
		}

		// Token: 0x06015143 RID: 86339 RVA: 0x0030E182 File Offset: 0x0030C382
		public static Offset<IActorCollisionTriggerShape> EndIActorCollisionTriggerShape(FlatBufferBuilder builder)
		{
			return new Offset<IActorCollisionTriggerShape>(builder.EndTable());
		}

		// Token: 0x06015144 RID: 86340 RVA: 0x0030E190 File Offset: 0x0030C390
		public IActorCollisionTriggerShapeT UnPack()
		{
			IActorCollisionTriggerShapeT actorCollisionTriggerShapeT = new IActorCollisionTriggerShapeT();
			this.UnPackTo(actorCollisionTriggerShapeT);
			return actorCollisionTriggerShapeT;
		}

		// Token: 0x06015145 RID: 86341 RVA: 0x0030E1AC File Offset: 0x0030C3AC
		public void UnPackTo(IActorCollisionTriggerShapeT _o)
		{
			_o.Type = this.Type;
			_o.ActorRef = ((this.ActorRef != null) ? this.ActorRef.Value.UnPack() : null);
		}

		// Token: 0x06015146 RID: 86342 RVA: 0x0030E1F4 File Offset: 0x0030C3F4
		public static Offset<IActorCollisionTriggerShape> Pack(FlatBufferBuilder builder, IActorCollisionTriggerShapeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorCollisionTriggerShape>);
			}
			Offset<IActorRef> actorRefOffset = (_o.ActorRef == null) ? default(Offset<IActorRef>) : IActorRef.Pack(builder, _o.ActorRef);
			return IActorCollisionTriggerShape.CreateIActorCollisionTriggerShape(builder, _o.Type, actorRefOffset);
		}

		// Token: 0x0400B1A6 RID: 45478
		private Table __p;
	}
}
