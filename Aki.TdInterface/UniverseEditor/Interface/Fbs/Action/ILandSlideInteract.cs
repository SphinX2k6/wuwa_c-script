using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200708E RID: 28814
	public struct ILandSlideInteract : IFlatbufferObject
	{
		// Token: 0x1700D318 RID: 54040
		// (get) Token: 0x06031FC5 RID: 204741 RVA: 0x006C3AFD File Offset: 0x006C1CFD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031FC6 RID: 204742 RVA: 0x006C3B0A File Offset: 0x006C1D0A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031FC7 RID: 204743 RVA: 0x006C3B14 File Offset: 0x006C1D14
		public static ILandSlideInteract GetRootAsILandSlideInteract(ByteBuffer _bb)
		{
			return ILandSlideInteract.GetRootAsILandSlideInteract(_bb, default(ILandSlideInteract));
		}

		// Token: 0x06031FC8 RID: 204744 RVA: 0x006C3B30 File Offset: 0x006C1D30
		public static ILandSlideInteract GetRootAsILandSlideInteract(ByteBuffer _bb, ILandSlideInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031FC9 RID: 204745 RVA: 0x006C3B4D File Offset: 0x006C1D4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031FCA RID: 204746 RVA: 0x006C3B5C File Offset: 0x006C1D5C
		public ILandSlideInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D319 RID: 54041
		// (get) Token: 0x06031FCB RID: 204747 RVA: 0x006C3B6C File Offset: 0x006C1D6C
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

		// Token: 0x06031FCC RID: 204748 RVA: 0x006C3BA8 File Offset: 0x006C1DA8
		public static Offset<ILandSlideInteract> CreateILandSlideInteract(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			ILandSlideInteract.AddType(builder, Type);
			return ILandSlideInteract.EndILandSlideInteract(builder);
		}

		// Token: 0x06031FCD RID: 204749 RVA: 0x006C3BBE File Offset: 0x006C1DBE
		public static void StartILandSlideInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031FCE RID: 204750 RVA: 0x006C3BC7 File Offset: 0x006C1DC7
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031FCF RID: 204751 RVA: 0x006C3BD2 File Offset: 0x006C1DD2
		public static Offset<ILandSlideInteract> EndILandSlideInteract(FlatBufferBuilder builder)
		{
			return new Offset<ILandSlideInteract>(builder.EndTable());
		}

		// Token: 0x06031FD0 RID: 204752 RVA: 0x006C3BE0 File Offset: 0x006C1DE0
		public ILandSlideInteractT UnPack()
		{
			ILandSlideInteractT landSlideInteractT = new ILandSlideInteractT();
			this.UnPackTo(landSlideInteractT);
			return landSlideInteractT;
		}

		// Token: 0x06031FD1 RID: 204753 RVA: 0x006C3BFB File Offset: 0x006C1DFB
		public void UnPackTo(ILandSlideInteractT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06031FD2 RID: 204754 RVA: 0x006C3C0C File Offset: 0x006C1E0C
		public static Offset<ILandSlideInteract> Pack(FlatBufferBuilder builder, ILandSlideInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILandSlideInteract>);
			}
			return ILandSlideInteract.CreateILandSlideInteract(builder, _o.Type);
		}

		// Token: 0x04012006 RID: 73734
		private Table __p;
	}
}
