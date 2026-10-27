using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200590E RID: 22798
	public struct IShowcaseFullViewCameraConfig : IFlatbufferObject
	{
		// Token: 0x1700AAE2 RID: 43746
		// (get) Token: 0x06026876 RID: 157814 RVA: 0x0054EC66 File Offset: 0x0054CE66
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026877 RID: 157815 RVA: 0x0054EC73 File Offset: 0x0054CE73
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026878 RID: 157816 RVA: 0x0054EC7C File Offset: 0x0054CE7C
		public static IShowcaseFullViewCameraConfig GetRootAsIShowcaseFullViewCameraConfig(ByteBuffer _bb)
		{
			return IShowcaseFullViewCameraConfig.GetRootAsIShowcaseFullViewCameraConfig(_bb, default(IShowcaseFullViewCameraConfig));
		}

		// Token: 0x06026879 RID: 157817 RVA: 0x0054EC98 File Offset: 0x0054CE98
		public static IShowcaseFullViewCameraConfig GetRootAsIShowcaseFullViewCameraConfig(ByteBuffer _bb, IShowcaseFullViewCameraConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602687A RID: 157818 RVA: 0x0054ECB5 File Offset: 0x0054CEB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602687B RID: 157819 RVA: 0x0054ECC4 File Offset: 0x0054CEC4
		public IShowcaseFullViewCameraConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AAE3 RID: 43747
		// (get) Token: 0x0602687C RID: 157820 RVA: 0x0054ECD4 File Offset: 0x0054CED4
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

		// Token: 0x1700AAE4 RID: 43748
		// (get) Token: 0x0602687D RID: 157821 RVA: 0x0054ED14 File Offset: 0x0054CF14
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

		// Token: 0x0602687E RID: 157822 RVA: 0x0054ED71 File Offset: 0x0054CF71
		public static Offset<IShowcaseFullViewCameraConfig> CreateIShowcaseFullViewCameraConfig(FlatBufferBuilder builder, float Fov = 0f, Offset<IPosAndRot> PosAndRotOffset = default(Offset<IPosAndRot>))
		{
			builder.StartTable(2);
			IShowcaseFullViewCameraConfig.AddPosAndRot(builder, PosAndRotOffset);
			IShowcaseFullViewCameraConfig.AddFov(builder, Fov);
			return IShowcaseFullViewCameraConfig.EndIShowcaseFullViewCameraConfig(builder);
		}

		// Token: 0x0602687F RID: 157823 RVA: 0x0054ED8E File Offset: 0x0054CF8E
		public static void StartIShowcaseFullViewCameraConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06026880 RID: 157824 RVA: 0x0054ED97 File Offset: 0x0054CF97
		public static void AddFov(FlatBufferBuilder builder, float fov)
		{
			builder.AddFloat(0, fov, 0.0);
		}

		// Token: 0x06026881 RID: 157825 RVA: 0x0054EDAA File Offset: 0x0054CFAA
		public static void AddPosAndRot(FlatBufferBuilder builder, Offset<IPosAndRot> posAndRotOffset)
		{
			builder.AddOffset(1, posAndRotOffset.Value, 0);
		}

		// Token: 0x06026882 RID: 157826 RVA: 0x0054EDBA File Offset: 0x0054CFBA
		public static Offset<IShowcaseFullViewCameraConfig> EndIShowcaseFullViewCameraConfig(FlatBufferBuilder builder)
		{
			return new Offset<IShowcaseFullViewCameraConfig>(builder.EndTable());
		}

		// Token: 0x06026883 RID: 157827 RVA: 0x0054EDC8 File Offset: 0x0054CFC8
		public IShowcaseFullViewCameraConfigT UnPack()
		{
			IShowcaseFullViewCameraConfigT showcaseFullViewCameraConfigT = new IShowcaseFullViewCameraConfigT();
			this.UnPackTo(showcaseFullViewCameraConfigT);
			return showcaseFullViewCameraConfigT;
		}

		// Token: 0x06026884 RID: 157828 RVA: 0x0054EDE4 File Offset: 0x0054CFE4
		public void UnPackTo(IShowcaseFullViewCameraConfigT _o)
		{
			_o.Fov = this.Fov;
			_o.PosAndRot = ((this.PosAndRot != null) ? this.PosAndRot.Value.UnPack() : null);
		}

		// Token: 0x06026885 RID: 157829 RVA: 0x0054EE2C File Offset: 0x0054D02C
		public static Offset<IShowcaseFullViewCameraConfig> Pack(FlatBufferBuilder builder, IShowcaseFullViewCameraConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowcaseFullViewCameraConfig>);
			}
			Offset<IPosAndRot> posAndRotOffset = (_o.PosAndRot == null) ? default(Offset<IPosAndRot>) : IPosAndRot.Pack(builder, _o.PosAndRot);
			return IShowcaseFullViewCameraConfig.CreateIShowcaseFullViewCameraConfig(builder, _o.Fov, posAndRotOffset);
		}

		// Token: 0x0400EEB0 RID: 61104
		private Table __p;
	}
}
