using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069DB RID: 27099
	public struct ILandSlideEndInteract : IFlatbufferObject
	{
		// Token: 0x1700C915 RID: 51477
		// (get) Token: 0x0602F5F3 RID: 194035 RVA: 0x0067362E File Offset: 0x0067182E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F5F4 RID: 194036 RVA: 0x0067363B File Offset: 0x0067183B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F5F5 RID: 194037 RVA: 0x00673644 File Offset: 0x00671844
		public static ILandSlideEndInteract GetRootAsILandSlideEndInteract(ByteBuffer _bb)
		{
			return ILandSlideEndInteract.GetRootAsILandSlideEndInteract(_bb, default(ILandSlideEndInteract));
		}

		// Token: 0x0602F5F6 RID: 194038 RVA: 0x00673660 File Offset: 0x00671860
		public static ILandSlideEndInteract GetRootAsILandSlideEndInteract(ByteBuffer _bb, ILandSlideEndInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F5F7 RID: 194039 RVA: 0x0067367D File Offset: 0x0067187D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F5F8 RID: 194040 RVA: 0x0067368C File Offset: 0x0067188C
		public ILandSlideEndInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C916 RID: 51478
		// (get) Token: 0x0602F5F9 RID: 194041 RVA: 0x0067369C File Offset: 0x0067189C
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

		// Token: 0x0602F5FA RID: 194042 RVA: 0x006736D8 File Offset: 0x006718D8
		public static Offset<ILandSlideEndInteract> CreateILandSlideEndInteract(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			ILandSlideEndInteract.AddType(builder, Type);
			return ILandSlideEndInteract.EndILandSlideEndInteract(builder);
		}

		// Token: 0x0602F5FB RID: 194043 RVA: 0x006736EE File Offset: 0x006718EE
		public static void StartILandSlideEndInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F5FC RID: 194044 RVA: 0x006736F7 File Offset: 0x006718F7
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F5FD RID: 194045 RVA: 0x00673702 File Offset: 0x00671902
		public static Offset<ILandSlideEndInteract> EndILandSlideEndInteract(FlatBufferBuilder builder)
		{
			return new Offset<ILandSlideEndInteract>(builder.EndTable());
		}

		// Token: 0x0602F5FE RID: 194046 RVA: 0x00673710 File Offset: 0x00671910
		public ILandSlideEndInteractT UnPack()
		{
			ILandSlideEndInteractT landSlideEndInteractT = new ILandSlideEndInteractT();
			this.UnPackTo(landSlideEndInteractT);
			return landSlideEndInteractT;
		}

		// Token: 0x0602F5FF RID: 194047 RVA: 0x0067372B File Offset: 0x0067192B
		public void UnPackTo(ILandSlideEndInteractT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602F600 RID: 194048 RVA: 0x0067373C File Offset: 0x0067193C
		public static Offset<ILandSlideEndInteract> Pack(FlatBufferBuilder builder, ILandSlideEndInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILandSlideEndInteract>);
			}
			return ILandSlideEndInteract.CreateILandSlideEndInteract(builder, _o.Type);
		}

		// Token: 0x0401119A RID: 70042
		private Table __p;
	}
}
