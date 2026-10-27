using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200568C RID: 22156
	public struct INpcUiInteractType : IFlatbufferObject
	{
		// Token: 0x1700A4C6 RID: 42182
		// (get) Token: 0x06024F6F RID: 151407 RVA: 0x0051AFE0 File Offset: 0x005191E0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024F70 RID: 151408 RVA: 0x0051AFED File Offset: 0x005191ED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024F71 RID: 151409 RVA: 0x0051AFF4 File Offset: 0x005191F4
		public static INpcUiInteractType GetRootAsINpcUiInteractType(ByteBuffer _bb)
		{
			return INpcUiInteractType.GetRootAsINpcUiInteractType(_bb, default(INpcUiInteractType));
		}

		// Token: 0x06024F72 RID: 151410 RVA: 0x0051B010 File Offset: 0x00519210
		public static INpcUiInteractType GetRootAsINpcUiInteractType(ByteBuffer _bb, INpcUiInteractType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024F73 RID: 151411 RVA: 0x0051B02D File Offset: 0x0051922D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024F74 RID: 151412 RVA: 0x0051B03C File Offset: 0x0051923C
		public INpcUiInteractType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A4C7 RID: 42183
		// (get) Token: 0x06024F75 RID: 151413 RVA: 0x0051B04C File Offset: 0x0051924C
		public ENpcUiInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENpcUiInteractType.HandInItem;
				}
				return (ENpcUiInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024F76 RID: 151414 RVA: 0x0051B088 File Offset: 0x00519288
		public static Offset<INpcUiInteractType> CreateINpcUiInteractType(FlatBufferBuilder builder, ENpcUiInteractType Type = ENpcUiInteractType.HandInItem)
		{
			builder.StartTable(1);
			INpcUiInteractType.AddType(builder, Type);
			return INpcUiInteractType.EndINpcUiInteractType(builder);
		}

		// Token: 0x06024F77 RID: 151415 RVA: 0x0051B09E File Offset: 0x0051929E
		public static void StartINpcUiInteractType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06024F78 RID: 151416 RVA: 0x0051B0A7 File Offset: 0x005192A7
		public static void AddType(FlatBufferBuilder builder, ENpcUiInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024F79 RID: 151417 RVA: 0x0051B0B2 File Offset: 0x005192B2
		public static Offset<INpcUiInteractType> EndINpcUiInteractType(FlatBufferBuilder builder)
		{
			return new Offset<INpcUiInteractType>(builder.EndTable());
		}

		// Token: 0x06024F7A RID: 151418 RVA: 0x0051B0C0 File Offset: 0x005192C0
		public INpcUiInteractTypeT UnPack()
		{
			INpcUiInteractTypeT npcUiInteractTypeT = new INpcUiInteractTypeT();
			this.UnPackTo(npcUiInteractTypeT);
			return npcUiInteractTypeT;
		}

		// Token: 0x06024F7B RID: 151419 RVA: 0x0051B0DB File Offset: 0x005192DB
		public void UnPackTo(INpcUiInteractTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06024F7C RID: 151420 RVA: 0x0051B0EC File Offset: 0x005192EC
		public static Offset<INpcUiInteractType> Pack(FlatBufferBuilder builder, INpcUiInteractTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcUiInteractType>);
			}
			return INpcUiInteractType.CreateINpcUiInteractType(builder, _o.Type);
		}

		// Token: 0x0400EAA0 RID: 60064
		private Table __p;
	}
}
