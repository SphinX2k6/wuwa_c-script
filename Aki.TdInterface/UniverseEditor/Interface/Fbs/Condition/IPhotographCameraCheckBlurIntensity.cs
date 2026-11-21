using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200516C RID: 20844
	public struct IPhotographCameraCheckBlurIntensity : IFlatbufferObject
	{
		// Token: 0x17009553 RID: 38227
		// (get) Token: 0x06020CAD RID: 134317 RVA: 0x0048A5BE File Offset: 0x004887BE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020CAE RID: 134318 RVA: 0x0048A5CB File Offset: 0x004887CB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020CAF RID: 134319 RVA: 0x0048A5D4 File Offset: 0x004887D4
		public static IPhotographCameraCheckBlurIntensity GetRootAsIPhotographCameraCheckBlurIntensity(ByteBuffer _bb)
		{
			return IPhotographCameraCheckBlurIntensity.GetRootAsIPhotographCameraCheckBlurIntensity(_bb, default(IPhotographCameraCheckBlurIntensity));
		}

		// Token: 0x06020CB0 RID: 134320 RVA: 0x0048A5F0 File Offset: 0x004887F0
		public static IPhotographCameraCheckBlurIntensity GetRootAsIPhotographCameraCheckBlurIntensity(ByteBuffer _bb, IPhotographCameraCheckBlurIntensity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020CB1 RID: 134321 RVA: 0x0048A60D File Offset: 0x0048880D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020CB2 RID: 134322 RVA: 0x0048A61C File Offset: 0x0048881C
		public IPhotographCameraCheckBlurIntensity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009554 RID: 38228
		// (get) Token: 0x06020CB3 RID: 134323 RVA: 0x0048A62C File Offset: 0x0048882C
		public EPhotographCameraCheckType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPhotographCameraCheckType.CameraTemplate;
				}
				return (EPhotographCameraCheckType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009555 RID: 38229
		// (get) Token: 0x06020CB4 RID: 134324 RVA: 0x0048A668 File Offset: 0x00488868
		public int MinBlurIntensity
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009556 RID: 38230
		// (get) Token: 0x06020CB5 RID: 134325 RVA: 0x0048A6A4 File Offset: 0x004888A4
		public int MaxBlurIntensity
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020CB6 RID: 134326 RVA: 0x0048A6E0 File Offset: 0x004888E0
		public static Offset<IPhotographCameraCheckBlurIntensity> CreateIPhotographCameraCheckBlurIntensity(FlatBufferBuilder builder, EPhotographCameraCheckType Type = EPhotographCameraCheckType.CameraTemplate, int MinBlurIntensity = 0, int MaxBlurIntensity = 0)
		{
			builder.StartTable(3);
			IPhotographCameraCheckBlurIntensity.AddMaxBlurIntensity(builder, MaxBlurIntensity);
			IPhotographCameraCheckBlurIntensity.AddMinBlurIntensity(builder, MinBlurIntensity);
			IPhotographCameraCheckBlurIntensity.AddType(builder, Type);
			return IPhotographCameraCheckBlurIntensity.EndIPhotographCameraCheckBlurIntensity(builder);
		}

		// Token: 0x06020CB7 RID: 134327 RVA: 0x0048A704 File Offset: 0x00488904
		public static void StartIPhotographCameraCheckBlurIntensity(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06020CB8 RID: 134328 RVA: 0x0048A70D File Offset: 0x0048890D
		public static void AddType(FlatBufferBuilder builder, EPhotographCameraCheckType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020CB9 RID: 134329 RVA: 0x0048A718 File Offset: 0x00488918
		public static void AddMinBlurIntensity(FlatBufferBuilder builder, int minBlurIntensity)
		{
			builder.AddInt(1, minBlurIntensity, 0);
		}

		// Token: 0x06020CBA RID: 134330 RVA: 0x0048A723 File Offset: 0x00488923
		public static void AddMaxBlurIntensity(FlatBufferBuilder builder, int maxBlurIntensity)
		{
			builder.AddInt(2, maxBlurIntensity, 0);
		}

		// Token: 0x06020CBB RID: 134331 RVA: 0x0048A72E File Offset: 0x0048892E
		public static Offset<IPhotographCameraCheckBlurIntensity> EndIPhotographCameraCheckBlurIntensity(FlatBufferBuilder builder)
		{
			return new Offset<IPhotographCameraCheckBlurIntensity>(builder.EndTable());
		}

		// Token: 0x06020CBC RID: 134332 RVA: 0x0048A73C File Offset: 0x0048893C
		public IPhotographCameraCheckBlurIntensityT UnPack()
		{
			IPhotographCameraCheckBlurIntensityT photographCameraCheckBlurIntensityT = new IPhotographCameraCheckBlurIntensityT();
			this.UnPackTo(photographCameraCheckBlurIntensityT);
			return photographCameraCheckBlurIntensityT;
		}

		// Token: 0x06020CBD RID: 134333 RVA: 0x0048A757 File Offset: 0x00488957
		public void UnPackTo(IPhotographCameraCheckBlurIntensityT _o)
		{
			_o.Type = this.Type;
			_o.MinBlurIntensity = this.MinBlurIntensity;
			_o.MaxBlurIntensity = this.MaxBlurIntensity;
		}

		// Token: 0x06020CBE RID: 134334 RVA: 0x0048A780 File Offset: 0x00488980
		public static Offset<IPhotographCameraCheckBlurIntensity> Pack(FlatBufferBuilder builder, IPhotographCameraCheckBlurIntensityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhotographCameraCheckBlurIntensity>);
			}
			return IPhotographCameraCheckBlurIntensity.CreateIPhotographCameraCheckBlurIntensity(builder, _o.Type, _o.MinBlurIntensity, _o.MaxBlurIntensity);
		}

		// Token: 0x0400E14B RID: 57675
		private Table __p;
	}
}
