using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200723E RID: 29246
	public struct ISunPalaceInteract : IFlatbufferObject
	{
		// Token: 0x1700D904 RID: 55556
		// (get) Token: 0x06033DF2 RID: 212466 RVA: 0x006FA871 File Offset: 0x006F8A71
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033DF3 RID: 212467 RVA: 0x006FA87E File Offset: 0x006F8A7E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033DF4 RID: 212468 RVA: 0x006FA888 File Offset: 0x006F8A88
		public static ISunPalaceInteract GetRootAsISunPalaceInteract(ByteBuffer _bb)
		{
			return ISunPalaceInteract.GetRootAsISunPalaceInteract(_bb, default(ISunPalaceInteract));
		}

		// Token: 0x06033DF5 RID: 212469 RVA: 0x006FA8A4 File Offset: 0x006F8AA4
		public static ISunPalaceInteract GetRootAsISunPalaceInteract(ByteBuffer _bb, ISunPalaceInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033DF6 RID: 212470 RVA: 0x006FA8C1 File Offset: 0x006F8AC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033DF7 RID: 212471 RVA: 0x006FA8D0 File Offset: 0x006F8AD0
		public ISunPalaceInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D905 RID: 55557
		// (get) Token: 0x06033DF8 RID: 212472 RVA: 0x006FA8E0 File Offset: 0x006F8AE0
		public ELeisureInteract Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELeisureInteract.CustomSkill;
				}
				return (ELeisureInteract)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033DF9 RID: 212473 RVA: 0x006FA91C File Offset: 0x006F8B1C
		public static Offset<ISunPalaceInteract> CreateISunPalaceInteract(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			ISunPalaceInteract.AddType(builder, Type);
			return ISunPalaceInteract.EndISunPalaceInteract(builder);
		}

		// Token: 0x06033DFA RID: 212474 RVA: 0x006FA932 File Offset: 0x006F8B32
		public static void StartISunPalaceInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033DFB RID: 212475 RVA: 0x006FA93B File Offset: 0x006F8B3B
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033DFC RID: 212476 RVA: 0x006FA946 File Offset: 0x006F8B46
		public static Offset<ISunPalaceInteract> EndISunPalaceInteract(FlatBufferBuilder builder)
		{
			return new Offset<ISunPalaceInteract>(builder.EndTable());
		}

		// Token: 0x06033DFD RID: 212477 RVA: 0x006FA954 File Offset: 0x006F8B54
		public ISunPalaceInteractT UnPack()
		{
			ISunPalaceInteractT sunPalaceInteractT = new ISunPalaceInteractT();
			this.UnPackTo(sunPalaceInteractT);
			return sunPalaceInteractT;
		}

		// Token: 0x06033DFE RID: 212478 RVA: 0x006FA96F File Offset: 0x006F8B6F
		public void UnPackTo(ISunPalaceInteractT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033DFF RID: 212479 RVA: 0x006FA980 File Offset: 0x006F8B80
		public static Offset<ISunPalaceInteract> Pack(FlatBufferBuilder builder, ISunPalaceInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISunPalaceInteract>);
			}
			return ISunPalaceInteract.CreateISunPalaceInteract(builder, _o.Type);
		}

		// Token: 0x04011D30 RID: 73008
		private Table __p;
	}
}
