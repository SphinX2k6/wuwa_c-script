using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005617 RID: 22039
	public struct INpcAwakeShow : IFlatbufferObject
	{
		// Token: 0x1700A313 RID: 41747
		// (get) Token: 0x06024933 RID: 149811 RVA: 0x0050BEDA File Offset: 0x0050A0DA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024934 RID: 149812 RVA: 0x0050BEE7 File Offset: 0x0050A0E7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024935 RID: 149813 RVA: 0x0050BEF0 File Offset: 0x0050A0F0
		public static INpcAwakeShow GetRootAsINpcAwakeShow(ByteBuffer _bb)
		{
			return INpcAwakeShow.GetRootAsINpcAwakeShow(_bb, default(INpcAwakeShow));
		}

		// Token: 0x06024936 RID: 149814 RVA: 0x0050BF0C File Offset: 0x0050A10C
		public static INpcAwakeShow GetRootAsINpcAwakeShow(ByteBuffer _bb, INpcAwakeShow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024937 RID: 149815 RVA: 0x0050BF29 File Offset: 0x0050A129
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024938 RID: 149816 RVA: 0x0050BF38 File Offset: 0x0050A138
		public INpcAwakeShow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A314 RID: 41748
		// (get) Token: 0x06024939 RID: 149817 RVA: 0x0050BF48 File Offset: 0x0050A148
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

		// Token: 0x1700A315 RID: 41749
		// (get) Token: 0x0602493A RID: 149818 RVA: 0x0050BFA8 File Offset: 0x0050A1A8
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

		// Token: 0x0602493B RID: 149819 RVA: 0x0050BFDF File Offset: 0x0050A1DF
		public Span<byte> GetMaterialDaBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602493C RID: 149820 RVA: 0x0050BFEE File Offset: 0x0050A1EE
		public byte[] GetMaterialDaArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602493D RID: 149821 RVA: 0x0050BFFC File Offset: 0x0050A1FC
		public static Offset<INpcAwakeShow> CreateINpcAwakeShow(FlatBufferBuilder builder, Offset<IMontageId> RegisteredMontageIdOffset = default(Offset<IMontageId>), StringOffset MaterialDaOffset = default(StringOffset))
		{
			builder.StartTable(2);
			INpcAwakeShow.AddMaterialDa(builder, MaterialDaOffset);
			INpcAwakeShow.AddRegisteredMontageId(builder, RegisteredMontageIdOffset);
			return INpcAwakeShow.EndINpcAwakeShow(builder);
		}

		// Token: 0x0602493E RID: 149822 RVA: 0x0050C019 File Offset: 0x0050A219
		public static void StartINpcAwakeShow(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602493F RID: 149823 RVA: 0x0050C022 File Offset: 0x0050A222
		public static void AddRegisteredMontageId(FlatBufferBuilder builder, Offset<IMontageId> registeredMontageIdOffset)
		{
			builder.AddOffset(0, registeredMontageIdOffset.Value, 0);
		}

		// Token: 0x06024940 RID: 149824 RVA: 0x0050C032 File Offset: 0x0050A232
		public static void AddMaterialDa(FlatBufferBuilder builder, StringOffset materialDaOffset)
		{
			builder.AddOffset(1, materialDaOffset.Value, 0);
		}

		// Token: 0x06024941 RID: 149825 RVA: 0x0050C042 File Offset: 0x0050A242
		public static Offset<INpcAwakeShow> EndINpcAwakeShow(FlatBufferBuilder builder)
		{
			return new Offset<INpcAwakeShow>(builder.EndTable());
		}

		// Token: 0x06024942 RID: 149826 RVA: 0x0050C050 File Offset: 0x0050A250
		public INpcAwakeShowT UnPack()
		{
			INpcAwakeShowT npcAwakeShowT = new INpcAwakeShowT();
			this.UnPackTo(npcAwakeShowT);
			return npcAwakeShowT;
		}

		// Token: 0x06024943 RID: 149827 RVA: 0x0050C06C File Offset: 0x0050A26C
		public void UnPackTo(INpcAwakeShowT _o)
		{
			_o.RegisteredMontageId = ((this.RegisteredMontageId != null) ? this.RegisteredMontageId.Value.UnPack() : null);
			_o.MaterialDa = this.MaterialDa;
		}

		// Token: 0x06024944 RID: 149828 RVA: 0x0050C0B4 File Offset: 0x0050A2B4
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

		// Token: 0x0400E99B RID: 59803
		private Table __p;
	}
}
