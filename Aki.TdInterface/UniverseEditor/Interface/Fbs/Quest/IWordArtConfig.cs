using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200429E RID: 17054
	public struct IWordArtConfig : IFlatbufferObject
	{
		// Token: 0x17007910 RID: 30992
		// (get) Token: 0x06019447 RID: 103495 RVA: 0x003A0F91 File Offset: 0x0039F191
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019448 RID: 103496 RVA: 0x003A0F9E File Offset: 0x0039F19E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019449 RID: 103497 RVA: 0x003A0FA8 File Offset: 0x0039F1A8
		public static IWordArtConfig GetRootAsIWordArtConfig(ByteBuffer _bb)
		{
			return IWordArtConfig.GetRootAsIWordArtConfig(_bb, default(IWordArtConfig));
		}

		// Token: 0x0601944A RID: 103498 RVA: 0x003A0FC4 File Offset: 0x0039F1C4
		public static IWordArtConfig GetRootAsIWordArtConfig(ByteBuffer _bb, IWordArtConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601944B RID: 103499 RVA: 0x003A0FE1 File Offset: 0x0039F1E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601944C RID: 103500 RVA: 0x003A0FF0 File Offset: 0x0039F1F0
		public IWordArtConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007911 RID: 30993
		// (get) Token: 0x0601944D RID: 103501 RVA: 0x003A1000 File Offset: 0x0039F200
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

		// Token: 0x17007912 RID: 30994
		// (get) Token: 0x0601944E RID: 103502 RVA: 0x003A1060 File Offset: 0x0039F260
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

		// Token: 0x0601944F RID: 103503 RVA: 0x003A10BD File Offset: 0x0039F2BD
		public static Offset<IWordArtConfig> CreateIWordArtConfig(FlatBufferBuilder builder, Offset<INumberWordArtEffectiveTargetType> EffectiveTargetOffset = default(Offset<INumberWordArtEffectiveTargetType>), Offset<IWordArtDefaultResourceType> ResourceOffset = default(Offset<IWordArtDefaultResourceType>))
		{
			builder.StartTable(2);
			IWordArtConfig.AddResource(builder, ResourceOffset);
			IWordArtConfig.AddEffectiveTarget(builder, EffectiveTargetOffset);
			return IWordArtConfig.EndIWordArtConfig(builder);
		}

		// Token: 0x06019450 RID: 103504 RVA: 0x003A10DA File Offset: 0x0039F2DA
		public static void StartIWordArtConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06019451 RID: 103505 RVA: 0x003A10E3 File Offset: 0x0039F2E3
		public static void AddEffectiveTarget(FlatBufferBuilder builder, Offset<INumberWordArtEffectiveTargetType> effectiveTargetOffset)
		{
			builder.AddOffset(0, effectiveTargetOffset.Value, 0);
		}

		// Token: 0x06019452 RID: 103506 RVA: 0x003A10F3 File Offset: 0x0039F2F3
		public static void AddResource(FlatBufferBuilder builder, Offset<IWordArtDefaultResourceType> resourceOffset)
		{
			builder.AddOffset(1, resourceOffset.Value, 0);
		}

		// Token: 0x06019453 RID: 103507 RVA: 0x003A1103 File Offset: 0x0039F303
		public static Offset<IWordArtConfig> EndIWordArtConfig(FlatBufferBuilder builder)
		{
			return new Offset<IWordArtConfig>(builder.EndTable());
		}

		// Token: 0x06019454 RID: 103508 RVA: 0x003A1110 File Offset: 0x0039F310
		public IWordArtConfigT UnPack()
		{
			IWordArtConfigT wordArtConfigT = new IWordArtConfigT();
			this.UnPackTo(wordArtConfigT);
			return wordArtConfigT;
		}

		// Token: 0x06019455 RID: 103509 RVA: 0x003A112C File Offset: 0x0039F32C
		public void UnPackTo(IWordArtConfigT _o)
		{
			_o.EffectiveTarget = ((this.EffectiveTarget != null) ? this.EffectiveTarget.Value.UnPack() : null);
			_o.Resource = ((this.Resource != null) ? this.Resource.Value.UnPack() : null);
		}

		// Token: 0x06019456 RID: 103510 RVA: 0x003A1198 File Offset: 0x0039F398
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

		// Token: 0x0400BF3F RID: 48959
		private Table __p;
	}
}
