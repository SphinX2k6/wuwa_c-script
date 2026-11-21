using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200708B RID: 28811
	public struct ILandSlideEndInteract : IFlatbufferObject
	{
		// Token: 0x1700D315 RID: 54037
		// (get) Token: 0x06031FB3 RID: 204723 RVA: 0x006C3986 File Offset: 0x006C1B86
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031FB4 RID: 204724 RVA: 0x006C3993 File Offset: 0x006C1B93
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031FB5 RID: 204725 RVA: 0x006C399C File Offset: 0x006C1B9C
		public static ILandSlideEndInteract GetRootAsILandSlideEndInteract(ByteBuffer _bb)
		{
			return ILandSlideEndInteract.GetRootAsILandSlideEndInteract(_bb, default(ILandSlideEndInteract));
		}

		// Token: 0x06031FB6 RID: 204726 RVA: 0x006C39B8 File Offset: 0x006C1BB8
		public static ILandSlideEndInteract GetRootAsILandSlideEndInteract(ByteBuffer _bb, ILandSlideEndInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031FB7 RID: 204727 RVA: 0x006C39D5 File Offset: 0x006C1BD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031FB8 RID: 204728 RVA: 0x006C39E4 File Offset: 0x006C1BE4
		public ILandSlideEndInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D316 RID: 54038
		// (get) Token: 0x06031FB9 RID: 204729 RVA: 0x006C39F4 File Offset: 0x006C1BF4
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

		// Token: 0x06031FBA RID: 204730 RVA: 0x006C3A30 File Offset: 0x006C1C30
		public static Offset<ILandSlideEndInteract> CreateILandSlideEndInteract(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			ILandSlideEndInteract.AddType(builder, Type);
			return ILandSlideEndInteract.EndILandSlideEndInteract(builder);
		}

		// Token: 0x06031FBB RID: 204731 RVA: 0x006C3A46 File Offset: 0x006C1C46
		public static void StartILandSlideEndInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031FBC RID: 204732 RVA: 0x006C3A4F File Offset: 0x006C1C4F
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031FBD RID: 204733 RVA: 0x006C3A5A File Offset: 0x006C1C5A
		public static Offset<ILandSlideEndInteract> EndILandSlideEndInteract(FlatBufferBuilder builder)
		{
			return new Offset<ILandSlideEndInteract>(builder.EndTable());
		}

		// Token: 0x06031FBE RID: 204734 RVA: 0x006C3A68 File Offset: 0x006C1C68
		public ILandSlideEndInteractT UnPack()
		{
			ILandSlideEndInteractT landSlideEndInteractT = new ILandSlideEndInteractT();
			this.UnPackTo(landSlideEndInteractT);
			return landSlideEndInteractT;
		}

		// Token: 0x06031FBF RID: 204735 RVA: 0x006C3A83 File Offset: 0x006C1C83
		public void UnPackTo(ILandSlideEndInteractT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06031FC0 RID: 204736 RVA: 0x006C3A94 File Offset: 0x006C1C94
		public static Offset<ILandSlideEndInteract> Pack(FlatBufferBuilder builder, ILandSlideEndInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILandSlideEndInteract>);
			}
			return ILandSlideEndInteract.CreateILandSlideEndInteract(builder, _o.Type);
		}

		// Token: 0x04012004 RID: 73732
		private Table __p;
	}
}
