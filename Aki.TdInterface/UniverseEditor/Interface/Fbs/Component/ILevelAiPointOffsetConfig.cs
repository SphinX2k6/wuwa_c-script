using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A59 RID: 23129
	public struct ILevelAiPointOffsetConfig : IFlatbufferObject
	{
		// Token: 0x1700A839 RID: 43065
		// (get) Token: 0x06025D48 RID: 154952 RVA: 0x0052F656 File Offset: 0x0052D856
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025D49 RID: 154953 RVA: 0x0052F663 File Offset: 0x0052D863
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025D4A RID: 154954 RVA: 0x0052F66C File Offset: 0x0052D86C
		public static ILevelAiPointOffsetConfig GetRootAsILevelAiPointOffsetConfig(ByteBuffer _bb)
		{
			return ILevelAiPointOffsetConfig.GetRootAsILevelAiPointOffsetConfig(_bb, default(ILevelAiPointOffsetConfig));
		}

		// Token: 0x06025D4B RID: 154955 RVA: 0x0052F688 File Offset: 0x0052D888
		public static ILevelAiPointOffsetConfig GetRootAsILevelAiPointOffsetConfig(ByteBuffer _bb, ILevelAiPointOffsetConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025D4C RID: 154956 RVA: 0x0052F6A5 File Offset: 0x0052D8A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025D4D RID: 154957 RVA: 0x0052F6B4 File Offset: 0x0052D8B4
		public ILevelAiPointOffsetConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A83A RID: 43066
		// (get) Token: 0x06025D4E RID: 154958 RVA: 0x0052F6C4 File Offset: 0x0052D8C4
		public float Radius
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

		// Token: 0x1700A83B RID: 43067
		// (get) Token: 0x06025D4F RID: 154959 RVA: 0x0052F704 File Offset: 0x0052D904
		public IVectorInfo? Normal
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06025D50 RID: 154960 RVA: 0x0052F761 File Offset: 0x0052D961
		public static Offset<ILevelAiPointOffsetConfig> CreateILevelAiPointOffsetConfig(FlatBufferBuilder builder, float Radius = 0f, Offset<IVectorInfo> NormalOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			ILevelAiPointOffsetConfig.AddNormal(builder, NormalOffset);
			ILevelAiPointOffsetConfig.AddRadius(builder, Radius);
			return ILevelAiPointOffsetConfig.EndILevelAiPointOffsetConfig(builder);
		}

		// Token: 0x06025D51 RID: 154961 RVA: 0x0052F77E File Offset: 0x0052D97E
		public static void StartILevelAiPointOffsetConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06025D52 RID: 154962 RVA: 0x0052F787 File Offset: 0x0052D987
		public static void AddRadius(FlatBufferBuilder builder, float radius)
		{
			builder.AddFloat(0, radius, 0.0);
		}

		// Token: 0x06025D53 RID: 154963 RVA: 0x0052F79A File Offset: 0x0052D99A
		public static void AddNormal(FlatBufferBuilder builder, Offset<IVectorInfo> normalOffset)
		{
			builder.AddOffset(1, normalOffset.Value, 0);
		}

		// Token: 0x06025D54 RID: 154964 RVA: 0x0052F7AA File Offset: 0x0052D9AA
		public static Offset<ILevelAiPointOffsetConfig> EndILevelAiPointOffsetConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILevelAiPointOffsetConfig>(builder.EndTable());
		}

		// Token: 0x06025D55 RID: 154965 RVA: 0x0052F7B8 File Offset: 0x0052D9B8
		public ILevelAiPointOffsetConfigT UnPack()
		{
			ILevelAiPointOffsetConfigT levelAiPointOffsetConfigT = new ILevelAiPointOffsetConfigT();
			this.UnPackTo(levelAiPointOffsetConfigT);
			return levelAiPointOffsetConfigT;
		}

		// Token: 0x06025D56 RID: 154966 RVA: 0x0052F7D4 File Offset: 0x0052D9D4
		public void UnPackTo(ILevelAiPointOffsetConfigT _o)
		{
			_o.Radius = this.Radius;
			_o.Normal = ((this.Normal != null) ? this.Normal.Value.UnPack() : null);
		}

		// Token: 0x06025D57 RID: 154967 RVA: 0x0052F81C File Offset: 0x0052DA1C
		public static Offset<ILevelAiPointOffsetConfig> Pack(FlatBufferBuilder builder, ILevelAiPointOffsetConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelAiPointOffsetConfig>);
			}
			Offset<IVectorInfo> normalOffset = (_o.Normal == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Normal);
			return ILevelAiPointOffsetConfig.CreateILevelAiPointOffsetConfig(builder, _o.Radius, normalOffset);
		}

		// Token: 0x0400F3C4 RID: 62404
		private Table __p;
	}
}
