using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A13 RID: 31251
	public struct ISunPalaceInteract : IFlatbufferObject
	{
		// Token: 0x1700E4FD RID: 58621
		// (get) Token: 0x060370F4 RID: 225524 RVA: 0x0075BBD1 File Offset: 0x00759DD1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060370F5 RID: 225525 RVA: 0x0075BBDE File Offset: 0x00759DDE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060370F6 RID: 225526 RVA: 0x0075BBE8 File Offset: 0x00759DE8
		public static ISunPalaceInteract GetRootAsISunPalaceInteract(ByteBuffer _bb)
		{
			return ISunPalaceInteract.GetRootAsISunPalaceInteract(_bb, default(ISunPalaceInteract));
		}

		// Token: 0x060370F7 RID: 225527 RVA: 0x0075BC04 File Offset: 0x00759E04
		public static ISunPalaceInteract GetRootAsISunPalaceInteract(ByteBuffer _bb, ISunPalaceInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060370F8 RID: 225528 RVA: 0x0075BC21 File Offset: 0x00759E21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060370F9 RID: 225529 RVA: 0x0075BC30 File Offset: 0x00759E30
		public ISunPalaceInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E4FE RID: 58622
		// (get) Token: 0x060370FA RID: 225530 RVA: 0x0075BC40 File Offset: 0x00759E40
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

		// Token: 0x060370FB RID: 225531 RVA: 0x0075BC7C File Offset: 0x00759E7C
		public static Offset<ISunPalaceInteract> CreateISunPalaceInteract(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			ISunPalaceInteract.AddType(builder, Type);
			return ISunPalaceInteract.EndISunPalaceInteract(builder);
		}

		// Token: 0x060370FC RID: 225532 RVA: 0x0075BC92 File Offset: 0x00759E92
		public static void StartISunPalaceInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060370FD RID: 225533 RVA: 0x0075BC9B File Offset: 0x00759E9B
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060370FE RID: 225534 RVA: 0x0075BCA6 File Offset: 0x00759EA6
		public static Offset<ISunPalaceInteract> EndISunPalaceInteract(FlatBufferBuilder builder)
		{
			return new Offset<ISunPalaceInteract>(builder.EndTable());
		}

		// Token: 0x060370FF RID: 225535 RVA: 0x0075BCB4 File Offset: 0x00759EB4
		public ISunPalaceInteractT UnPack()
		{
			ISunPalaceInteractT sunPalaceInteractT = new ISunPalaceInteractT();
			this.UnPackTo(sunPalaceInteractT);
			return sunPalaceInteractT;
		}

		// Token: 0x06037100 RID: 225536 RVA: 0x0075BCCF File Offset: 0x00759ECF
		public void UnPackTo(ISunPalaceInteractT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06037101 RID: 225537 RVA: 0x0075BCE0 File Offset: 0x00759EE0
		public static Offset<ISunPalaceInteract> Pack(FlatBufferBuilder builder, ISunPalaceInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISunPalaceInteract>);
			}
			return ISunPalaceInteract.CreateISunPalaceInteract(builder, _o.Type);
		}

		// Token: 0x04012D32 RID: 77106
		private Table __p;
	}
}
