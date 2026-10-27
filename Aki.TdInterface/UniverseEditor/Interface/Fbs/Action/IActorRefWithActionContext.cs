using System;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060F2 RID: 24818
	public struct IActorRefWithActionContext : IFlatbufferObject
	{
		// Token: 0x1700B6EC RID: 46828
		// (get) Token: 0x0602A65C RID: 173660 RVA: 0x005D7755 File Offset: 0x005D5955
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A65D RID: 173661 RVA: 0x005D7762 File Offset: 0x005D5962
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A65E RID: 173662 RVA: 0x005D776C File Offset: 0x005D596C
		public static IActorRefWithActionContext GetRootAsIActorRefWithActionContext(ByteBuffer _bb)
		{
			return IActorRefWithActionContext.GetRootAsIActorRefWithActionContext(_bb, default(IActorRefWithActionContext));
		}

		// Token: 0x0602A65F RID: 173663 RVA: 0x005D7788 File Offset: 0x005D5988
		public static IActorRefWithActionContext GetRootAsIActorRefWithActionContext(ByteBuffer _bb, IActorRefWithActionContext obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A660 RID: 173664 RVA: 0x005D77A5 File Offset: 0x005D59A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A661 RID: 173665 RVA: 0x005D77B4 File Offset: 0x005D59B4
		public IActorRefWithActionContext __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B6ED RID: 46829
		// (get) Token: 0x0602A662 RID: 173666 RVA: 0x005D77C4 File Offset: 0x005D59C4
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

		// Token: 0x1700B6EE RID: 46830
		// (get) Token: 0x0602A663 RID: 173667 RVA: 0x005D7824 File Offset: 0x005D5A24
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

		// Token: 0x0602A664 RID: 173668 RVA: 0x005D7881 File Offset: 0x005D5A81
		public static Offset<IActorRefWithActionContext> CreateIActorRefWithActionContext(FlatBufferBuilder builder, Offset<IActionInfo> ContextActionOffset = default(Offset<IActionInfo>), Offset<IActorRef> ActorRefOffset = default(Offset<IActorRef>))
		{
			builder.StartTable(2);
			IActorRefWithActionContext.AddActorRef(builder, ActorRefOffset);
			IActorRefWithActionContext.AddContextAction(builder, ContextActionOffset);
			return IActorRefWithActionContext.EndIActorRefWithActionContext(builder);
		}

		// Token: 0x0602A665 RID: 173669 RVA: 0x005D789E File Offset: 0x005D5A9E
		public static void StartIActorRefWithActionContext(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602A666 RID: 173670 RVA: 0x005D78A7 File Offset: 0x005D5AA7
		public static void AddContextAction(FlatBufferBuilder builder, Offset<IActionInfo> contextActionOffset)
		{
			builder.AddOffset(0, contextActionOffset.Value, 0);
		}

		// Token: 0x0602A667 RID: 173671 RVA: 0x005D78B7 File Offset: 0x005D5AB7
		public static void AddActorRef(FlatBufferBuilder builder, Offset<IActorRef> actorRefOffset)
		{
			builder.AddOffset(1, actorRefOffset.Value, 0);
		}

		// Token: 0x0602A668 RID: 173672 RVA: 0x005D78C7 File Offset: 0x005D5AC7
		public static Offset<IActorRefWithActionContext> EndIActorRefWithActionContext(FlatBufferBuilder builder)
		{
			return new Offset<IActorRefWithActionContext>(builder.EndTable());
		}

		// Token: 0x0602A669 RID: 173673 RVA: 0x005D78D4 File Offset: 0x005D5AD4
		public IActorRefWithActionContextT UnPack()
		{
			IActorRefWithActionContextT actorRefWithActionContextT = new IActorRefWithActionContextT();
			this.UnPackTo(actorRefWithActionContextT);
			return actorRefWithActionContextT;
		}

		// Token: 0x0602A66A RID: 173674 RVA: 0x005D78F0 File Offset: 0x005D5AF0
		public void UnPackTo(IActorRefWithActionContextT _o)
		{
			_o.ContextAction = ((this.ContextAction != null) ? this.ContextAction.Value.UnPack() : null);
			_o.ActorRef = ((this.ActorRef != null) ? this.ActorRef.Value.UnPack() : null);
		}

		// Token: 0x0602A66B RID: 173675 RVA: 0x005D795C File Offset: 0x005D5B5C
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

		// Token: 0x040104B4 RID: 66740
		private Table __p;
	}
}
