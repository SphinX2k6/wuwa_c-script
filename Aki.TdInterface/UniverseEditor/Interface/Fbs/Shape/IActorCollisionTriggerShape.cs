using System;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003FEF RID: 16367
	public struct IActorCollisionTriggerShape : IFlatbufferObject
	{
		// Token: 0x17006ED5 RID: 28373
		// (get) Token: 0x0601662D RID: 91693 RVA: 0x00334BC2 File Offset: 0x00332DC2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601662E RID: 91694 RVA: 0x00334BCF File Offset: 0x00332DCF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601662F RID: 91695 RVA: 0x00334BD8 File Offset: 0x00332DD8
		public static IActorCollisionTriggerShape GetRootAsIActorCollisionTriggerShape(ByteBuffer _bb)
		{
			return IActorCollisionTriggerShape.GetRootAsIActorCollisionTriggerShape(_bb, default(IActorCollisionTriggerShape));
		}

		// Token: 0x06016630 RID: 91696 RVA: 0x00334BF4 File Offset: 0x00332DF4
		public static IActorCollisionTriggerShape GetRootAsIActorCollisionTriggerShape(ByteBuffer _bb, IActorCollisionTriggerShape obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016631 RID: 91697 RVA: 0x00334C11 File Offset: 0x00332E11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016632 RID: 91698 RVA: 0x00334C20 File Offset: 0x00332E20
		public IActorCollisionTriggerShape __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006ED6 RID: 28374
		// (get) Token: 0x06016633 RID: 91699 RVA: 0x00334C30 File Offset: 0x00332E30
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

		// Token: 0x17006ED7 RID: 28375
		// (get) Token: 0x06016634 RID: 91700 RVA: 0x00334C6C File Offset: 0x00332E6C
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

		// Token: 0x06016635 RID: 91701 RVA: 0x00334CC9 File Offset: 0x00332EC9
		public static Offset<IActorCollisionTriggerShape> CreateIActorCollisionTriggerShape(FlatBufferBuilder builder, ETriggerShape Type = ETriggerShape.Box, Offset<IActorRef> ActorRefOffset = default(Offset<IActorRef>))
		{
			builder.StartTable(2);
			IActorCollisionTriggerShape.AddActorRef(builder, ActorRefOffset);
			IActorCollisionTriggerShape.AddType(builder, Type);
			return IActorCollisionTriggerShape.EndIActorCollisionTriggerShape(builder);
		}

		// Token: 0x06016636 RID: 91702 RVA: 0x00334CE6 File Offset: 0x00332EE6
		public static void StartIActorCollisionTriggerShape(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06016637 RID: 91703 RVA: 0x00334CEF File Offset: 0x00332EEF
		public static void AddType(FlatBufferBuilder builder, ETriggerShape type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016638 RID: 91704 RVA: 0x00334CFA File Offset: 0x00332EFA
		public static void AddActorRef(FlatBufferBuilder builder, Offset<IActorRef> actorRefOffset)
		{
			builder.AddOffset(1, actorRefOffset.Value, 0);
		}

		// Token: 0x06016639 RID: 91705 RVA: 0x00334D0A File Offset: 0x00332F0A
		public static Offset<IActorCollisionTriggerShape> EndIActorCollisionTriggerShape(FlatBufferBuilder builder)
		{
			return new Offset<IActorCollisionTriggerShape>(builder.EndTable());
		}

		// Token: 0x0601663A RID: 91706 RVA: 0x00334D18 File Offset: 0x00332F18
		public IActorCollisionTriggerShapeT UnPack()
		{
			IActorCollisionTriggerShapeT actorCollisionTriggerShapeT = new IActorCollisionTriggerShapeT();
			this.UnPackTo(actorCollisionTriggerShapeT);
			return actorCollisionTriggerShapeT;
		}

		// Token: 0x0601663B RID: 91707 RVA: 0x00334D34 File Offset: 0x00332F34
		public void UnPackTo(IActorCollisionTriggerShapeT _o)
		{
			_o.Type = this.Type;
			_o.ActorRef = ((this.ActorRef != null) ? this.ActorRef.Value.UnPack() : null);
		}

		// Token: 0x0601663C RID: 91708 RVA: 0x00334D7C File Offset: 0x00332F7C
		public static Offset<IActorCollisionTriggerShape> Pack(FlatBufferBuilder builder, IActorCollisionTriggerShapeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorCollisionTriggerShape>);
			}
			Offset<IActorRef> actorRefOffset = (_o.ActorRef == null) ? default(Offset<IActorRef>) : IActorRef.Pack(builder, _o.ActorRef);
			return IActorCollisionTriggerShape.CreateIActorCollisionTriggerShape(builder, _o.Type, actorRefOffset);
		}

		// Token: 0x0400BB31 RID: 47921
		private Table __p;
	}
}
