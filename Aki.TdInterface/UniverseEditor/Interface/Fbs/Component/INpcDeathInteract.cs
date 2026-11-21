using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BBB RID: 23483
	public struct INpcDeathInteract : IFlatbufferObject
	{
		// Token: 0x1700ABA3 RID: 43939
		// (get) Token: 0x06026B6D RID: 158573 RVA: 0x0054C9B3 File Offset: 0x0054ABB3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026B6E RID: 158574 RVA: 0x0054C9C0 File Offset: 0x0054ABC0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026B6F RID: 158575 RVA: 0x0054C9C8 File Offset: 0x0054ABC8
		public static INpcDeathInteract GetRootAsINpcDeathInteract(ByteBuffer _bb)
		{
			return INpcDeathInteract.GetRootAsINpcDeathInteract(_bb, default(INpcDeathInteract));
		}

		// Token: 0x06026B70 RID: 158576 RVA: 0x0054C9E4 File Offset: 0x0054ABE4
		public static INpcDeathInteract GetRootAsINpcDeathInteract(ByteBuffer _bb, INpcDeathInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026B71 RID: 158577 RVA: 0x0054CA01 File Offset: 0x0054AC01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026B72 RID: 158578 RVA: 0x0054CA10 File Offset: 0x0054AC10
		public INpcDeathInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ABA4 RID: 43940
		// (get) Token: 0x06026B73 RID: 158579 RVA: 0x0054CA20 File Offset: 0x0054AC20
		public IMontageId? Montage
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

		// Token: 0x1700ABA5 RID: 43941
		// (get) Token: 0x06026B74 RID: 158580 RVA: 0x0054CA80 File Offset: 0x0054AC80
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

		// Token: 0x06026B75 RID: 158581 RVA: 0x0054CAB7 File Offset: 0x0054ACB7
		public Span<byte> GetMaterialDaBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06026B76 RID: 158582 RVA: 0x0054CAC6 File Offset: 0x0054ACC6
		public byte[] GetMaterialDaArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06026B77 RID: 158583 RVA: 0x0054CAD4 File Offset: 0x0054ACD4
		public static Offset<INpcDeathInteract> CreateINpcDeathInteract(FlatBufferBuilder builder, Offset<IMontageId> MontageOffset = default(Offset<IMontageId>), StringOffset MaterialDaOffset = default(StringOffset))
		{
			builder.StartTable(2);
			INpcDeathInteract.AddMaterialDa(builder, MaterialDaOffset);
			INpcDeathInteract.AddMontage(builder, MontageOffset);
			return INpcDeathInteract.EndINpcDeathInteract(builder);
		}

		// Token: 0x06026B78 RID: 158584 RVA: 0x0054CAF1 File Offset: 0x0054ACF1
		public static void StartINpcDeathInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06026B79 RID: 158585 RVA: 0x0054CAFA File Offset: 0x0054ACFA
		public static void AddMontage(FlatBufferBuilder builder, Offset<IMontageId> montageOffset)
		{
			builder.AddOffset(0, montageOffset.Value, 0);
		}

		// Token: 0x06026B7A RID: 158586 RVA: 0x0054CB0A File Offset: 0x0054AD0A
		public static void AddMaterialDa(FlatBufferBuilder builder, StringOffset materialDaOffset)
		{
			builder.AddOffset(1, materialDaOffset.Value, 0);
		}

		// Token: 0x06026B7B RID: 158587 RVA: 0x0054CB1A File Offset: 0x0054AD1A
		public static Offset<INpcDeathInteract> EndINpcDeathInteract(FlatBufferBuilder builder)
		{
			return new Offset<INpcDeathInteract>(builder.EndTable());
		}

		// Token: 0x06026B7C RID: 158588 RVA: 0x0054CB28 File Offset: 0x0054AD28
		public INpcDeathInteractT UnPack()
		{
			INpcDeathInteractT npcDeathInteractT = new INpcDeathInteractT();
			this.UnPackTo(npcDeathInteractT);
			return npcDeathInteractT;
		}

		// Token: 0x06026B7D RID: 158589 RVA: 0x0054CB44 File Offset: 0x0054AD44
		public void UnPackTo(INpcDeathInteractT _o)
		{
			_o.Montage = ((this.Montage != null) ? this.Montage.Value.UnPack() : null);
			_o.MaterialDa = this.MaterialDa;
		}

		// Token: 0x06026B7E RID: 158590 RVA: 0x0054CB8C File Offset: 0x0054AD8C
		public static Offset<INpcDeathInteract> Pack(FlatBufferBuilder builder, INpcDeathInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcDeathInteract>);
			}
			Offset<IMontageId> montageOffset = (_o.Montage == null) ? default(Offset<IMontageId>) : IMontageId.Pack(builder, _o.Montage);
			StringOffset materialDaOffset = (_o.MaterialDa == null) ? default(StringOffset) : builder.CreateString(_o.MaterialDa);
			return INpcDeathInteract.CreateINpcDeathInteract(builder, montageOffset, materialDaOffset);
		}

		// Token: 0x0400F603 RID: 62979
		private Table __p;
	}
}
