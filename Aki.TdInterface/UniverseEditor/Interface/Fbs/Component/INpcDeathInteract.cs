using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200561D RID: 22045
	public struct INpcDeathInteract : IFlatbufferObject
	{
		// Token: 0x1700A31B RID: 41755
		// (get) Token: 0x0602495D RID: 149853 RVA: 0x0050C39B File Offset: 0x0050A59B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602495E RID: 149854 RVA: 0x0050C3A8 File Offset: 0x0050A5A8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602495F RID: 149855 RVA: 0x0050C3B0 File Offset: 0x0050A5B0
		public static INpcDeathInteract GetRootAsINpcDeathInteract(ByteBuffer _bb)
		{
			return INpcDeathInteract.GetRootAsINpcDeathInteract(_bb, default(INpcDeathInteract));
		}

		// Token: 0x06024960 RID: 149856 RVA: 0x0050C3CC File Offset: 0x0050A5CC
		public static INpcDeathInteract GetRootAsINpcDeathInteract(ByteBuffer _bb, INpcDeathInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024961 RID: 149857 RVA: 0x0050C3E9 File Offset: 0x0050A5E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024962 RID: 149858 RVA: 0x0050C3F8 File Offset: 0x0050A5F8
		public INpcDeathInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A31C RID: 41756
		// (get) Token: 0x06024963 RID: 149859 RVA: 0x0050C408 File Offset: 0x0050A608
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

		// Token: 0x1700A31D RID: 41757
		// (get) Token: 0x06024964 RID: 149860 RVA: 0x0050C468 File Offset: 0x0050A668
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

		// Token: 0x06024965 RID: 149861 RVA: 0x0050C49F File Offset: 0x0050A69F
		public Span<byte> GetMaterialDaBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06024966 RID: 149862 RVA: 0x0050C4AE File Offset: 0x0050A6AE
		public byte[] GetMaterialDaArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06024967 RID: 149863 RVA: 0x0050C4BC File Offset: 0x0050A6BC
		public static Offset<INpcDeathInteract> CreateINpcDeathInteract(FlatBufferBuilder builder, Offset<IMontageId> MontageOffset = default(Offset<IMontageId>), StringOffset MaterialDaOffset = default(StringOffset))
		{
			builder.StartTable(2);
			INpcDeathInteract.AddMaterialDa(builder, MaterialDaOffset);
			INpcDeathInteract.AddMontage(builder, MontageOffset);
			return INpcDeathInteract.EndINpcDeathInteract(builder);
		}

		// Token: 0x06024968 RID: 149864 RVA: 0x0050C4D9 File Offset: 0x0050A6D9
		public static void StartINpcDeathInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06024969 RID: 149865 RVA: 0x0050C4E2 File Offset: 0x0050A6E2
		public static void AddMontage(FlatBufferBuilder builder, Offset<IMontageId> montageOffset)
		{
			builder.AddOffset(0, montageOffset.Value, 0);
		}

		// Token: 0x0602496A RID: 149866 RVA: 0x0050C4F2 File Offset: 0x0050A6F2
		public static void AddMaterialDa(FlatBufferBuilder builder, StringOffset materialDaOffset)
		{
			builder.AddOffset(1, materialDaOffset.Value, 0);
		}

		// Token: 0x0602496B RID: 149867 RVA: 0x0050C502 File Offset: 0x0050A702
		public static Offset<INpcDeathInteract> EndINpcDeathInteract(FlatBufferBuilder builder)
		{
			return new Offset<INpcDeathInteract>(builder.EndTable());
		}

		// Token: 0x0602496C RID: 149868 RVA: 0x0050C510 File Offset: 0x0050A710
		public INpcDeathInteractT UnPack()
		{
			INpcDeathInteractT npcDeathInteractT = new INpcDeathInteractT();
			this.UnPackTo(npcDeathInteractT);
			return npcDeathInteractT;
		}

		// Token: 0x0602496D RID: 149869 RVA: 0x0050C52C File Offset: 0x0050A72C
		public void UnPackTo(INpcDeathInteractT _o)
		{
			_o.Montage = ((this.Montage != null) ? this.Montage.Value.UnPack() : null);
			_o.MaterialDa = this.MaterialDa;
		}

		// Token: 0x0602496E RID: 149870 RVA: 0x0050C574 File Offset: 0x0050A774
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

		// Token: 0x0400E9A0 RID: 59808
		private Table __p;
	}
}
