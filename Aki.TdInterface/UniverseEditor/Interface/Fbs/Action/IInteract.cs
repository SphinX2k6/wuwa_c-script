using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200697B RID: 27003
	public struct IInteract : IFlatbufferObject
	{
		// Token: 0x1700C845 RID: 51269
		// (get) Token: 0x0602F280 RID: 193152 RVA: 0x0066C940 File Offset: 0x0066AB40
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F281 RID: 193153 RVA: 0x0066C94D File Offset: 0x0066AB4D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F282 RID: 193154 RVA: 0x0066C954 File Offset: 0x0066AB54
		public static IInteract GetRootAsIInteract(ByteBuffer _bb)
		{
			return IInteract.GetRootAsIInteract(_bb, default(IInteract));
		}

		// Token: 0x0602F283 RID: 193155 RVA: 0x0066C970 File Offset: 0x0066AB70
		public static IInteract GetRootAsIInteract(ByteBuffer _bb, IInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F284 RID: 193156 RVA: 0x0066C98D File Offset: 0x0066AB8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F285 RID: 193157 RVA: 0x0066C99C File Offset: 0x0066AB9C
		public IInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C846 RID: 51270
		// (get) Token: 0x0602F286 RID: 193158 RVA: 0x0066C9AC File Offset: 0x0066ABAC
		public int Who
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C847 RID: 51271
		// (get) Token: 0x0602F287 RID: 193159 RVA: 0x0066C9E8 File Offset: 0x0066ABE8
		public string Param
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

		// Token: 0x0602F288 RID: 193160 RVA: 0x0066CA1F File Offset: 0x0066AC1F
		public Span<byte> GetParamBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602F289 RID: 193161 RVA: 0x0066CA2E File Offset: 0x0066AC2E
		public byte[] GetParamArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602F28A RID: 193162 RVA: 0x0066CA3C File Offset: 0x0066AC3C
		public static Offset<IInteract> CreateIInteract(FlatBufferBuilder builder, int Who = 0, StringOffset ParamOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IInteract.AddParam(builder, ParamOffset);
			IInteract.AddWho(builder, Who);
			return IInteract.EndIInteract(builder);
		}

		// Token: 0x0602F28B RID: 193163 RVA: 0x0066CA59 File Offset: 0x0066AC59
		public static void StartIInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F28C RID: 193164 RVA: 0x0066CA62 File Offset: 0x0066AC62
		public static void AddWho(FlatBufferBuilder builder, int who)
		{
			builder.AddInt(0, who, 0);
		}

		// Token: 0x0602F28D RID: 193165 RVA: 0x0066CA6D File Offset: 0x0066AC6D
		public static void AddParam(FlatBufferBuilder builder, StringOffset paramOffset)
		{
			builder.AddOffset(1, paramOffset.Value, 0);
		}

		// Token: 0x0602F28E RID: 193166 RVA: 0x0066CA7D File Offset: 0x0066AC7D
		public static Offset<IInteract> EndIInteract(FlatBufferBuilder builder)
		{
			return new Offset<IInteract>(builder.EndTable());
		}

		// Token: 0x0602F28F RID: 193167 RVA: 0x0066CA8C File Offset: 0x0066AC8C
		public IInteractT UnPack()
		{
			IInteractT interactT = new IInteractT();
			this.UnPackTo(interactT);
			return interactT;
		}

		// Token: 0x0602F290 RID: 193168 RVA: 0x0066CAA7 File Offset: 0x0066ACA7
		public void UnPackTo(IInteractT _o)
		{
			_o.Who = this.Who;
			_o.Param = this.Param;
		}

		// Token: 0x0602F291 RID: 193169 RVA: 0x0066CAC4 File Offset: 0x0066ACC4
		public static Offset<IInteract> Pack(FlatBufferBuilder builder, IInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteract>);
			}
			StringOffset paramOffset = (_o.Param == null) ? default(StringOffset) : builder.CreateString(_o.Param);
			return IInteract.CreateIInteract(builder, _o.Who, paramOffset);
		}

		// Token: 0x04011102 RID: 69890
		private Table __p;
	}
}
