using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F1B RID: 24347
	public struct IShowcaseFullViewCameraConfig : IFlatbufferObject
	{
		// Token: 0x1700B416 RID: 46102
		// (get) Token: 0x06028DE0 RID: 167392 RVA: 0x005958D2 File Offset: 0x00593AD2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028DE1 RID: 167393 RVA: 0x005958DF File Offset: 0x00593ADF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028DE2 RID: 167394 RVA: 0x005958E8 File Offset: 0x00593AE8
		public static IShowcaseFullViewCameraConfig GetRootAsIShowcaseFullViewCameraConfig(ByteBuffer _bb)
		{
			return IShowcaseFullViewCameraConfig.GetRootAsIShowcaseFullViewCameraConfig(_bb, default(IShowcaseFullViewCameraConfig));
		}

		// Token: 0x06028DE3 RID: 167395 RVA: 0x00595904 File Offset: 0x00593B04
		public static IShowcaseFullViewCameraConfig GetRootAsIShowcaseFullViewCameraConfig(ByteBuffer _bb, IShowcaseFullViewCameraConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028DE4 RID: 167396 RVA: 0x00595921 File Offset: 0x00593B21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028DE5 RID: 167397 RVA: 0x00595930 File Offset: 0x00593B30
		public IShowcaseFullViewCameraConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B417 RID: 46103
		// (get) Token: 0x06028DE6 RID: 167398 RVA: 0x00595940 File Offset: 0x00593B40
		public float Fov
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B418 RID: 46104
		// (get) Token: 0x06028DE7 RID: 167399 RVA: 0x00595980 File Offset: 0x00593B80
		public IPosAndRot? PosAndRot
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPosAndRot?(default(IPosAndRot).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06028DE8 RID: 167400 RVA: 0x005959DD File Offset: 0x00593BDD
		public static Offset<IShowcaseFullViewCameraConfig> CreateIShowcaseFullViewCameraConfig(FlatBufferBuilder builder, float Fov = 0f, Offset<IPosAndRot> PosAndRotOffset = default(Offset<IPosAndRot>))
		{
			builder.StartTable(2);
			IShowcaseFullViewCameraConfig.AddPosAndRot(builder, PosAndRotOffset);
			IShowcaseFullViewCameraConfig.AddFov(builder, Fov);
			return IShowcaseFullViewCameraConfig.EndIShowcaseFullViewCameraConfig(builder);
		}

		// Token: 0x06028DE9 RID: 167401 RVA: 0x005959FA File Offset: 0x00593BFA
		public static void StartIShowcaseFullViewCameraConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06028DEA RID: 167402 RVA: 0x00595A03 File Offset: 0x00593C03
		public static void AddFov(FlatBufferBuilder builder, float fov)
		{
			builder.AddFloat(0, fov, 0.0);
		}

		// Token: 0x06028DEB RID: 167403 RVA: 0x00595A16 File Offset: 0x00593C16
		public static void AddPosAndRot(FlatBufferBuilder builder, Offset<IPosAndRot> posAndRotOffset)
		{
			builder.AddOffset(1, posAndRotOffset.Value, 0);
		}

		// Token: 0x06028DEC RID: 167404 RVA: 0x00595A26 File Offset: 0x00593C26
		public static Offset<IShowcaseFullViewCameraConfig> EndIShowcaseFullViewCameraConfig(FlatBufferBuilder builder)
		{
			return new Offset<IShowcaseFullViewCameraConfig>(builder.EndTable());
		}

		// Token: 0x06028DED RID: 167405 RVA: 0x00595A34 File Offset: 0x00593C34
		public IShowcaseFullViewCameraConfigT UnPack()
		{
			IShowcaseFullViewCameraConfigT showcaseFullViewCameraConfigT = new IShowcaseFullViewCameraConfigT();
			this.UnPackTo(showcaseFullViewCameraConfigT);
			return showcaseFullViewCameraConfigT;
		}

		// Token: 0x06028DEE RID: 167406 RVA: 0x00595A50 File Offset: 0x00593C50
		public void UnPackTo(IShowcaseFullViewCameraConfigT _o)
		{
			_o.Fov = this.Fov;
			_o.PosAndRot = ((this.PosAndRot != null) ? this.PosAndRot.Value.UnPack() : null);
		}

		// Token: 0x06028DEF RID: 167407 RVA: 0x00595A98 File Offset: 0x00593C98
		public static Offset<IShowcaseFullViewCameraConfig> Pack(FlatBufferBuilder builder, IShowcaseFullViewCameraConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowcaseFullViewCameraConfig>);
			}
			Offset<IPosAndRot> posAndRotOffset = (_o.PosAndRot == null) ? default(Offset<IPosAndRot>) : IPosAndRot.Pack(builder, _o.PosAndRot);
			return IShowcaseFullViewCameraConfig.CreateIShowcaseFullViewCameraConfig(builder, _o.Fov, posAndRotOffset);
		}

		// Token: 0x0400FBA5 RID: 64421
		private Table __p;
	}
}
