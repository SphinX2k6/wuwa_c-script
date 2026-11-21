using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BB5 RID: 23477
	public struct INpcAwakeShow : IFlatbufferObject
	{
		// Token: 0x1700AB9B RID: 43931
		// (get) Token: 0x06026B43 RID: 158531 RVA: 0x0054C4F2 File Offset: 0x0054A6F2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026B44 RID: 158532 RVA: 0x0054C4FF File Offset: 0x0054A6FF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026B45 RID: 158533 RVA: 0x0054C508 File Offset: 0x0054A708
		public static INpcAwakeShow GetRootAsINpcAwakeShow(ByteBuffer _bb)
		{
			return INpcAwakeShow.GetRootAsINpcAwakeShow(_bb, default(INpcAwakeShow));
		}

		// Token: 0x06026B46 RID: 158534 RVA: 0x0054C524 File Offset: 0x0054A724
		public static INpcAwakeShow GetRootAsINpcAwakeShow(ByteBuffer _bb, INpcAwakeShow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026B47 RID: 158535 RVA: 0x0054C541 File Offset: 0x0054A741
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026B48 RID: 158536 RVA: 0x0054C550 File Offset: 0x0054A750
		public INpcAwakeShow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AB9C RID: 43932
		// (get) Token: 0x06026B49 RID: 158537 RVA: 0x0054C560 File Offset: 0x0054A760
		public IMontageId? RegisteredMontageId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IMontageId?(default(IMontageId).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AB9D RID: 43933
		// (get) Token: 0x06026B4A RID: 158538 RVA: 0x0054C5C0 File Offset: 0x0054A7C0
		public string MaterialDa
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

		// Token: 0x06026B4B RID: 158539 RVA: 0x0054C5F7 File Offset: 0x0054A7F7
		public Span<byte> GetMaterialDaBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06026B4C RID: 158540 RVA: 0x0054C606 File Offset: 0x0054A806
		public byte[] GetMaterialDaArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06026B4D RID: 158541 RVA: 0x0054C614 File Offset: 0x0054A814
		public static Offset<INpcAwakeShow> CreateINpcAwakeShow(FlatBufferBuilder builder, Offset<IMontageId> RegisteredMontageIdOffset = default(Offset<IMontageId>), StringOffset MaterialDaOffset = default(StringOffset))
		{
			builder.StartTable(2);
			INpcAwakeShow.AddMaterialDa(builder, MaterialDaOffset);
			INpcAwakeShow.AddRegisteredMontageId(builder, RegisteredMontageIdOffset);
			return INpcAwakeShow.EndINpcAwakeShow(builder);
		}

		// Token: 0x06026B4E RID: 158542 RVA: 0x0054C631 File Offset: 0x0054A831
		public static void StartINpcAwakeShow(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06026B4F RID: 158543 RVA: 0x0054C63A File Offset: 0x0054A83A
		public static void AddRegisteredMontageId(FlatBufferBuilder builder, Offset<IMontageId> registeredMontageIdOffset)
		{
			builder.AddOffset(0, registeredMontageIdOffset.Value, 0);
		}

		// Token: 0x06026B50 RID: 158544 RVA: 0x0054C64A File Offset: 0x0054A84A
		public static void AddMaterialDa(FlatBufferBuilder builder, StringOffset materialDaOffset)
		{
			builder.AddOffset(1, materialDaOffset.Value, 0);
		}

		// Token: 0x06026B51 RID: 158545 RVA: 0x0054C65A File Offset: 0x0054A85A
		public static Offset<INpcAwakeShow> EndINpcAwakeShow(FlatBufferBuilder builder)
		{
			return new Offset<INpcAwakeShow>(builder.EndTable());
		}

		// Token: 0x06026B52 RID: 158546 RVA: 0x0054C668 File Offset: 0x0054A868
		public INpcAwakeShowT UnPack()
		{
			INpcAwakeShowT npcAwakeShowT = new INpcAwakeShowT();
			this.UnPackTo(npcAwakeShowT);
			return npcAwakeShowT;
		}

		// Token: 0x06026B53 RID: 158547 RVA: 0x0054C684 File Offset: 0x0054A884
		public void UnPackTo(INpcAwakeShowT _o)
		{
			_o.RegisteredMontageId = ((this.RegisteredMontageId != null) ? this.RegisteredMontageId.Value.UnPack() : null);
			_o.MaterialDa = this.MaterialDa;
		}

		// Token: 0x06026B54 RID: 158548 RVA: 0x0054C6CC File Offset: 0x0054A8CC
		public static Offset<INpcAwakeShow> Pack(FlatBufferBuilder builder, INpcAwakeShowT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcAwakeShow>);
			}
			Offset<IMontageId> registeredMontageIdOffset = (_o.RegisteredMontageId == null) ? default(Offset<IMontageId>) : IMontageId.Pack(builder, _o.RegisteredMontageId);
			StringOffset materialDaOffset = (_o.MaterialDa == null) ? default(StringOffset) : builder.CreateString(_o.MaterialDa);
			return INpcAwakeShow.CreateINpcAwakeShow(builder, registeredMontageIdOffset, materialDaOffset);
		}

		// Token: 0x0400F5FE RID: 62974
		private Table __p;
	}
}
