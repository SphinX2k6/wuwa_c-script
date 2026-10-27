using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069A2 RID: 27042
	public struct IInteractPointInteraction : IFlatbufferObject
	{
		// Token: 0x1700C8A0 RID: 51360
		// (get) Token: 0x0602F3FB RID: 193531 RVA: 0x0066FB16 File Offset: 0x0066DD16
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F3FC RID: 193532 RVA: 0x0066FB23 File Offset: 0x0066DD23
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F3FD RID: 193533 RVA: 0x0066FB2C File Offset: 0x0066DD2C
		public static IInteractPointInteraction GetRootAsIInteractPointInteraction(ByteBuffer _bb)
		{
			return IInteractPointInteraction.GetRootAsIInteractPointInteraction(_bb, default(IInteractPointInteraction));
		}

		// Token: 0x0602F3FE RID: 193534 RVA: 0x0066FB48 File Offset: 0x0066DD48
		public static IInteractPointInteraction GetRootAsIInteractPointInteraction(ByteBuffer _bb, IInteractPointInteraction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F3FF RID: 193535 RVA: 0x0066FB65 File Offset: 0x0066DD65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F400 RID: 193536 RVA: 0x0066FB74 File Offset: 0x0066DD74
		public IInteractPointInteraction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C8A1 RID: 51361
		// (get) Token: 0x0602F401 RID: 193537 RVA: 0x0066FB84 File Offset: 0x0066DD84
		public EInteractPointInteractionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInteractPointInteractionType.Drag;
				}
				return (EInteractPointInteractionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F402 RID: 193538 RVA: 0x0066FBC0 File Offset: 0x0066DDC0
		public static Offset<IInteractPointInteraction> CreateIInteractPointInteraction(FlatBufferBuilder builder, EInteractPointInteractionType Type = EInteractPointInteractionType.Drag)
		{
			builder.StartTable(1);
			IInteractPointInteraction.AddType(builder, Type);
			return IInteractPointInteraction.EndIInteractPointInteraction(builder);
		}

		// Token: 0x0602F403 RID: 193539 RVA: 0x0066FBD6 File Offset: 0x0066DDD6
		public static void StartIInteractPointInteraction(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F404 RID: 193540 RVA: 0x0066FBDF File Offset: 0x0066DDDF
		public static void AddType(FlatBufferBuilder builder, EInteractPointInteractionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F405 RID: 193541 RVA: 0x0066FBEA File Offset: 0x0066DDEA
		public static Offset<IInteractPointInteraction> EndIInteractPointInteraction(FlatBufferBuilder builder)
		{
			return new Offset<IInteractPointInteraction>(builder.EndTable());
		}

		// Token: 0x0602F406 RID: 193542 RVA: 0x0066FBF8 File Offset: 0x0066DDF8
		public IInteractPointInteractionT UnPack()
		{
			IInteractPointInteractionT interactPointInteractionT = new IInteractPointInteractionT();
			this.UnPackTo(interactPointInteractionT);
			return interactPointInteractionT;
		}

		// Token: 0x0602F407 RID: 193543 RVA: 0x0066FC13 File Offset: 0x0066DE13
		public void UnPackTo(IInteractPointInteractionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602F408 RID: 193544 RVA: 0x0066FC24 File Offset: 0x0066DE24
		public static Offset<IInteractPointInteraction> Pack(FlatBufferBuilder builder, IInteractPointInteractionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractPointInteraction>);
			}
			return IInteractPointInteraction.CreateIInteractPointInteraction(builder, _o.Type);
		}

		// Token: 0x04011148 RID: 69960
		private Table __p;
	}
}
