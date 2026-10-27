using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054D3 RID: 21715
	public struct ILevelAiPointOffsetConfig : IFlatbufferObject
	{
		// Token: 0x17009FFF RID: 40959
		// (get) Token: 0x06023C90 RID: 146576 RVA: 0x004F25E2 File Offset: 0x004F07E2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023C91 RID: 146577 RVA: 0x004F25EF File Offset: 0x004F07EF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023C92 RID: 146578 RVA: 0x004F25F8 File Offset: 0x004F07F8
		public static ILevelAiPointOffsetConfig GetRootAsILevelAiPointOffsetConfig(ByteBuffer _bb)
		{
			return ILevelAiPointOffsetConfig.GetRootAsILevelAiPointOffsetConfig(_bb, default(ILevelAiPointOffsetConfig));
		}

		// Token: 0x06023C93 RID: 146579 RVA: 0x004F2614 File Offset: 0x004F0814
		public static ILevelAiPointOffsetConfig GetRootAsILevelAiPointOffsetConfig(ByteBuffer _bb, ILevelAiPointOffsetConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023C94 RID: 146580 RVA: 0x004F2631 File Offset: 0x004F0831
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023C95 RID: 146581 RVA: 0x004F2640 File Offset: 0x004F0840
		public ILevelAiPointOffsetConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A000 RID: 40960
		// (get) Token: 0x06023C96 RID: 146582 RVA: 0x004F2650 File Offset: 0x004F0850
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

		// Token: 0x1700A001 RID: 40961
		// (get) Token: 0x06023C97 RID: 146583 RVA: 0x004F2690 File Offset: 0x004F0890
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

		// Token: 0x06023C98 RID: 146584 RVA: 0x004F26ED File Offset: 0x004F08ED
		public static Offset<ILevelAiPointOffsetConfig> CreateILevelAiPointOffsetConfig(FlatBufferBuilder builder, float Radius = 0f, Offset<IVectorInfo> NormalOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			ILevelAiPointOffsetConfig.AddNormal(builder, NormalOffset);
			ILevelAiPointOffsetConfig.AddRadius(builder, Radius);
			return ILevelAiPointOffsetConfig.EndILevelAiPointOffsetConfig(builder);
		}

		// Token: 0x06023C99 RID: 146585 RVA: 0x004F270A File Offset: 0x004F090A
		public static void StartILevelAiPointOffsetConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06023C9A RID: 146586 RVA: 0x004F2713 File Offset: 0x004F0913
		public static void AddRadius(FlatBufferBuilder builder, float radius)
		{
			builder.AddFloat(0, radius, 0.0);
		}

		// Token: 0x06023C9B RID: 146587 RVA: 0x004F2726 File Offset: 0x004F0926
		public static void AddNormal(FlatBufferBuilder builder, Offset<IVectorInfo> normalOffset)
		{
			builder.AddOffset(1, normalOffset.Value, 0);
		}

		// Token: 0x06023C9C RID: 146588 RVA: 0x004F2736 File Offset: 0x004F0936
		public static Offset<ILevelAiPointOffsetConfig> EndILevelAiPointOffsetConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILevelAiPointOffsetConfig>(builder.EndTable());
		}

		// Token: 0x06023C9D RID: 146589 RVA: 0x004F2744 File Offset: 0x004F0944
		public ILevelAiPointOffsetConfigT UnPack()
		{
			ILevelAiPointOffsetConfigT levelAiPointOffsetConfigT = new ILevelAiPointOffsetConfigT();
			this.UnPackTo(levelAiPointOffsetConfigT);
			return levelAiPointOffsetConfigT;
		}

		// Token: 0x06023C9E RID: 146590 RVA: 0x004F2760 File Offset: 0x004F0960
		public void UnPackTo(ILevelAiPointOffsetConfigT _o)
		{
			_o.Radius = this.Radius;
			_o.Normal = ((this.Normal != null) ? this.Normal.Value.UnPack() : null);
		}

		// Token: 0x06023C9F RID: 146591 RVA: 0x004F27A8 File Offset: 0x004F09A8
		public static Offset<ILevelAiPointOffsetConfig> Pack(FlatBufferBuilder builder, ILevelAiPointOffsetConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelAiPointOffsetConfig>);
			}
			Offset<IVectorInfo> normalOffset = (_o.Normal == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Normal);
			return ILevelAiPointOffsetConfig.CreateILevelAiPointOffsetConfig(builder, _o.Radius, normalOffset);
		}

		// Token: 0x0400E793 RID: 59283
		private Table __p;
	}
}
