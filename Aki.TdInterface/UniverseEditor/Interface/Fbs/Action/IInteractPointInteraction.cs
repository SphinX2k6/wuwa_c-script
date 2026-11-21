using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007055 RID: 28757
	public struct IInteractPointInteraction : IFlatbufferObject
	{
		// Token: 0x1700D2A5 RID: 53925
		// (get) Token: 0x06031DD7 RID: 204247 RVA: 0x006C021A File Offset: 0x006BE41A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031DD8 RID: 204248 RVA: 0x006C0227 File Offset: 0x006BE427
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031DD9 RID: 204249 RVA: 0x006C0230 File Offset: 0x006BE430
		public static IInteractPointInteraction GetRootAsIInteractPointInteraction(ByteBuffer _bb)
		{
			return IInteractPointInteraction.GetRootAsIInteractPointInteraction(_bb, default(IInteractPointInteraction));
		}

		// Token: 0x06031DDA RID: 204250 RVA: 0x006C024C File Offset: 0x006BE44C
		public static IInteractPointInteraction GetRootAsIInteractPointInteraction(ByteBuffer _bb, IInteractPointInteraction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031DDB RID: 204251 RVA: 0x006C0269 File Offset: 0x006BE469
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031DDC RID: 204252 RVA: 0x006C0278 File Offset: 0x006BE478
		public IInteractPointInteraction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D2A6 RID: 53926
		// (get) Token: 0x06031DDD RID: 204253 RVA: 0x006C0288 File Offset: 0x006BE488
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

		// Token: 0x06031DDE RID: 204254 RVA: 0x006C02C4 File Offset: 0x006BE4C4
		public static Offset<IInteractPointInteraction> CreateIInteractPointInteraction(FlatBufferBuilder builder, EInteractPointInteractionType Type = EInteractPointInteractionType.Drag)
		{
			builder.StartTable(1);
			IInteractPointInteraction.AddType(builder, Type);
			return IInteractPointInteraction.EndIInteractPointInteraction(builder);
		}

		// Token: 0x06031DDF RID: 204255 RVA: 0x006C02DA File Offset: 0x006BE4DA
		public static void StartIInteractPointInteraction(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031DE0 RID: 204256 RVA: 0x006C02E3 File Offset: 0x006BE4E3
		public static void AddType(FlatBufferBuilder builder, EInteractPointInteractionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031DE1 RID: 204257 RVA: 0x006C02EE File Offset: 0x006BE4EE
		public static Offset<IInteractPointInteraction> EndIInteractPointInteraction(FlatBufferBuilder builder)
		{
			return new Offset<IInteractPointInteraction>(builder.EndTable());
		}

		// Token: 0x06031DE2 RID: 204258 RVA: 0x006C02FC File Offset: 0x006BE4FC
		public IInteractPointInteractionT UnPack()
		{
			IInteractPointInteractionT interactPointInteractionT = new IInteractPointInteractionT();
			this.UnPackTo(interactPointInteractionT);
			return interactPointInteractionT;
		}

		// Token: 0x06031DE3 RID: 204259 RVA: 0x006C0317 File Offset: 0x006BE517
		public void UnPackTo(IInteractPointInteractionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06031DE4 RID: 204260 RVA: 0x006C0328 File Offset: 0x006BE528
		public static Offset<IInteractPointInteraction> Pack(FlatBufferBuilder builder, IInteractPointInteractionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractPointInteraction>);
			}
			return IInteractPointInteraction.CreateIInteractPointInteraction(builder, _o.Type);
		}

		// Token: 0x04011FB5 RID: 73653
		private Table __p;
	}
}
