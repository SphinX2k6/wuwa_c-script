using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046FA RID: 18170
	public struct IWordArtConfig : IFlatbufferObject
	{
		// Token: 0x17007F41 RID: 32577
		// (get) Token: 0x0601ABB3 RID: 109491 RVA: 0x003CC669 File Offset: 0x003CA869
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601ABB4 RID: 109492 RVA: 0x003CC676 File Offset: 0x003CA876
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601ABB5 RID: 109493 RVA: 0x003CC680 File Offset: 0x003CA880
		public static IWordArtConfig GetRootAsIWordArtConfig(ByteBuffer _bb)
		{
			return IWordArtConfig.GetRootAsIWordArtConfig(_bb, default(IWordArtConfig));
		}

		// Token: 0x0601ABB6 RID: 109494 RVA: 0x003CC69C File Offset: 0x003CA89C
		public static IWordArtConfig GetRootAsIWordArtConfig(ByteBuffer _bb, IWordArtConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601ABB7 RID: 109495 RVA: 0x003CC6B9 File Offset: 0x003CA8B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601ABB8 RID: 109496 RVA: 0x003CC6C8 File Offset: 0x003CA8C8
		public IWordArtConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007F42 RID: 32578
		// (get) Token: 0x0601ABB9 RID: 109497 RVA: 0x003CC6D8 File Offset: 0x003CA8D8
		public INumberWordArtEffectiveTargetType? EffectiveTarget
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new INumberWordArtEffectiveTargetType?(default(INumberWordArtEffectiveTargetType).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007F43 RID: 32579
		// (get) Token: 0x0601ABBA RID: 109498 RVA: 0x003CC738 File Offset: 0x003CA938
		public IWordArtDefaultResourceType? Resource
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IWordArtDefaultResourceType?(default(IWordArtDefaultResourceType).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601ABBB RID: 109499 RVA: 0x003CC795 File Offset: 0x003CA995
		public static Offset<IWordArtConfig> CreateIWordArtConfig(FlatBufferBuilder builder, Offset<INumberWordArtEffectiveTargetType> EffectiveTargetOffset = default(Offset<INumberWordArtEffectiveTargetType>), Offset<IWordArtDefaultResourceType> ResourceOffset = default(Offset<IWordArtDefaultResourceType>))
		{
			builder.StartTable(2);
			IWordArtConfig.AddResource(builder, ResourceOffset);
			IWordArtConfig.AddEffectiveTarget(builder, EffectiveTargetOffset);
			return IWordArtConfig.EndIWordArtConfig(builder);
		}

		// Token: 0x0601ABBC RID: 109500 RVA: 0x003CC7B2 File Offset: 0x003CA9B2
		public static void StartIWordArtConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601ABBD RID: 109501 RVA: 0x003CC7BB File Offset: 0x003CA9BB
		public static void AddEffectiveTarget(FlatBufferBuilder builder, Offset<INumberWordArtEffectiveTargetType> effectiveTargetOffset)
		{
			builder.AddOffset(0, effectiveTargetOffset.Value, 0);
		}

		// Token: 0x0601ABBE RID: 109502 RVA: 0x003CC7CB File Offset: 0x003CA9CB
		public static void AddResource(FlatBufferBuilder builder, Offset<IWordArtDefaultResourceType> resourceOffset)
		{
			builder.AddOffset(1, resourceOffset.Value, 0);
		}

		// Token: 0x0601ABBF RID: 109503 RVA: 0x003CC7DB File Offset: 0x003CA9DB
		public static Offset<IWordArtConfig> EndIWordArtConfig(FlatBufferBuilder builder)
		{
			return new Offset<IWordArtConfig>(builder.EndTable());
		}

		// Token: 0x0601ABC0 RID: 109504 RVA: 0x003CC7E8 File Offset: 0x003CA9E8
		public IWordArtConfigT UnPack()
		{
			IWordArtConfigT wordArtConfigT = new IWordArtConfigT();
			this.UnPackTo(wordArtConfigT);
			return wordArtConfigT;
		}

		// Token: 0x0601ABC1 RID: 109505 RVA: 0x003CC804 File Offset: 0x003CAA04
		public void UnPackTo(IWordArtConfigT _o)
		{
			_o.EffectiveTarget = ((this.EffectiveTarget != null) ? this.EffectiveTarget.Value.UnPack() : null);
			_o.Resource = ((this.Resource != null) ? this.Resource.Value.UnPack() : null);
		}

		// Token: 0x0601ABC2 RID: 109506 RVA: 0x003CC870 File Offset: 0x003CAA70
		public static Offset<IWordArtConfig> Pack(FlatBufferBuilder builder, IWordArtConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWordArtConfig>);
			}
			Offset<INumberWordArtEffectiveTargetType> effectiveTargetOffset = (_o.EffectiveTarget == null) ? default(Offset<INumberWordArtEffectiveTargetType>) : INumberWordArtEffectiveTargetType.Pack(builder, _o.EffectiveTarget);
			Offset<IWordArtDefaultResourceType> resourceOffset = (_o.Resource == null) ? default(Offset<IWordArtDefaultResourceType>) : IWordArtDefaultResourceType.Pack(builder, _o.Resource);
			return IWordArtConfig.CreateIWordArtConfig(builder, effectiveTargetOffset, resourceOffset);
		}

		// Token: 0x0400C94C RID: 51532
		private Table __p;
	}
}
