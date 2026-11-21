using System;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006754 RID: 26452
	public struct IActorRefWithActionContext : IFlatbufferObject
	{
		// Token: 0x1700C057 RID: 49239
		// (get) Token: 0x0602CD3D RID: 183613 RVA: 0x006216FD File Offset: 0x0061F8FD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CD3E RID: 183614 RVA: 0x0062170A File Offset: 0x0061F90A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CD3F RID: 183615 RVA: 0x00621714 File Offset: 0x0061F914
		public static IActorRefWithActionContext GetRootAsIActorRefWithActionContext(ByteBuffer _bb)
		{
			return IActorRefWithActionContext.GetRootAsIActorRefWithActionContext(_bb, default(IActorRefWithActionContext));
		}

		// Token: 0x0602CD40 RID: 183616 RVA: 0x00621730 File Offset: 0x0061F930
		public static IActorRefWithActionContext GetRootAsIActorRefWithActionContext(ByteBuffer _bb, IActorRefWithActionContext obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CD41 RID: 183617 RVA: 0x0062174D File Offset: 0x0061F94D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CD42 RID: 183618 RVA: 0x0062175C File Offset: 0x0061F95C
		public IActorRefWithActionContext __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C058 RID: 49240
		// (get) Token: 0x0602CD43 RID: 183619 RVA: 0x0062176C File Offset: 0x0061F96C
		public IActionInfo? ContextAction
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C059 RID: 49241
		// (get) Token: 0x0602CD44 RID: 183620 RVA: 0x006217CC File Offset: 0x0061F9CC
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

		// Token: 0x0602CD45 RID: 183621 RVA: 0x00621829 File Offset: 0x0061FA29
		public static Offset<IActorRefWithActionContext> CreateIActorRefWithActionContext(FlatBufferBuilder builder, Offset<IActionInfo> ContextActionOffset = default(Offset<IActionInfo>), Offset<IActorRef> ActorRefOffset = default(Offset<IActorRef>))
		{
			builder.StartTable(2);
			IActorRefWithActionContext.AddActorRef(builder, ActorRefOffset);
			IActorRefWithActionContext.AddContextAction(builder, ContextActionOffset);
			return IActorRefWithActionContext.EndIActorRefWithActionContext(builder);
		}

		// Token: 0x0602CD46 RID: 183622 RVA: 0x00621846 File Offset: 0x0061FA46
		public static void StartIActorRefWithActionContext(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602CD47 RID: 183623 RVA: 0x0062184F File Offset: 0x0061FA4F
		public static void AddContextAction(FlatBufferBuilder builder, Offset<IActionInfo> contextActionOffset)
		{
			builder.AddOffset(0, contextActionOffset.Value, 0);
		}

		// Token: 0x0602CD48 RID: 183624 RVA: 0x0062185F File Offset: 0x0061FA5F
		public static void AddActorRef(FlatBufferBuilder builder, Offset<IActorRef> actorRefOffset)
		{
			builder.AddOffset(1, actorRefOffset.Value, 0);
		}

		// Token: 0x0602CD49 RID: 183625 RVA: 0x0062186F File Offset: 0x0061FA6F
		public static Offset<IActorRefWithActionContext> EndIActorRefWithActionContext(FlatBufferBuilder builder)
		{
			return new Offset<IActorRefWithActionContext>(builder.EndTable());
		}

		// Token: 0x0602CD4A RID: 183626 RVA: 0x0062187C File Offset: 0x0061FA7C
		public IActorRefWithActionContextT UnPack()
		{
			IActorRefWithActionContextT actorRefWithActionContextT = new IActorRefWithActionContextT();
			this.UnPackTo(actorRefWithActionContextT);
			return actorRefWithActionContextT;
		}

		// Token: 0x0602CD4B RID: 183627 RVA: 0x00621898 File Offset: 0x0061FA98
		public void UnPackTo(IActorRefWithActionContextT _o)
		{
			_o.ContextAction = ((this.ContextAction != null) ? this.ContextAction.Value.UnPack() : null);
			_o.ActorRef = ((this.ActorRef != null) ? this.ActorRef.Value.UnPack() : null);
		}

		// Token: 0x0602CD4C RID: 183628 RVA: 0x00621904 File Offset: 0x0061FB04
		public static Offset<IActorRefWithActionContext> Pack(FlatBufferBuilder builder, IActorRefWithActionContextT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorRefWithActionContext>);
			}
			Offset<IActionInfo> contextActionOffset = (_o.ContextAction == null) ? default(Offset<IActionInfo>) : IActionInfo.Pack(builder, _o.ContextAction);
			Offset<IActorRef> actorRefOffset = (_o.ActorRef == null) ? default(Offset<IActorRef>) : IActorRef.Pack(builder, _o.ActorRef);
			return IActorRefWithActionContext.CreateIActorRefWithActionContext(builder, contextActionOffset, actorRefOffset);
		}

		// Token: 0x040112B8 RID: 70328
		private Table __p;
	}
}
