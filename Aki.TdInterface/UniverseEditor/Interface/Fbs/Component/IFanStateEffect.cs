using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057A5 RID: 22437
	public struct IFanStateEffect : IFlatbufferObject
	{
		// Token: 0x1700A237 RID: 41527
		// (get) Token: 0x0602436D RID: 148333 RVA: 0x004FA7B0 File Offset: 0x004F89B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602436E RID: 148334 RVA: 0x004FA7BD File Offset: 0x004F89BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602436F RID: 148335 RVA: 0x004FA7C4 File Offset: 0x004F89C4
		public static IFanStateEffect GetRootAsIFanStateEffect(ByteBuffer _bb)
		{
			return IFanStateEffect.GetRootAsIFanStateEffect(_bb, default(IFanStateEffect));
		}

		// Token: 0x06024370 RID: 148336 RVA: 0x004FA7E0 File Offset: 0x004F89E0
		public static IFanStateEffect GetRootAsIFanStateEffect(ByteBuffer _bb, IFanStateEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024371 RID: 148337 RVA: 0x004FA7FD File Offset: 0x004F89FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024372 RID: 148338 RVA: 0x004FA80C File Offset: 0x004F8A0C
		public IFanStateEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A238 RID: 41528
		// (get) Token: 0x06024373 RID: 148339 RVA: 0x004FA81C File Offset: 0x004F8A1C
		public string EntityState
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024374 RID: 148340 RVA: 0x004FA853 File Offset: 0x004F8A53
		public Span<byte> GetEntityStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06024375 RID: 148341 RVA: 0x004FA862 File Offset: 0x004F8A62
		public byte[] GetEntityStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700A239 RID: 41529
		// (get) Token: 0x06024376 RID: 148342 RVA: 0x004FA870 File Offset: 0x004F8A70
		public IFanEffectConfig? EffectConfig
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IFanEffectConfig?(default(IFanEffectConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06024377 RID: 148343 RVA: 0x004FA8CD File Offset: 0x004F8ACD
		public static Offset<IFanStateEffect> CreateIFanStateEffect(FlatBufferBuilder builder, StringOffset EntityStateOffset = default(StringOffset), Offset<IFanEffectConfig> EffectConfigOffset = default(Offset<IFanEffectConfig>))
		{
			builder.StartTable(2);
			IFanStateEffect.AddEffectConfig(builder, EffectConfigOffset);
			IFanStateEffect.AddEntityState(builder, EntityStateOffset);
			return IFanStateEffect.EndIFanStateEffect(builder);
		}

		// Token: 0x06024378 RID: 148344 RVA: 0x004FA8EA File Offset: 0x004F8AEA
		public static void StartIFanStateEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06024379 RID: 148345 RVA: 0x004FA8F3 File Offset: 0x004F8AF3
		public static void AddEntityState(FlatBufferBuilder builder, StringOffset entityStateOffset)
		{
			builder.AddOffset(0, entityStateOffset.Value, 0);
		}

		// Token: 0x0602437A RID: 148346 RVA: 0x004FA903 File Offset: 0x004F8B03
		public static void AddEffectConfig(FlatBufferBuilder builder, Offset<IFanEffectConfig> effectConfigOffset)
		{
			builder.AddOffset(1, effectConfigOffset.Value, 0);
		}

		// Token: 0x0602437B RID: 148347 RVA: 0x004FA913 File Offset: 0x004F8B13
		public static Offset<IFanStateEffect> EndIFanStateEffect(FlatBufferBuilder builder)
		{
			return new Offset<IFanStateEffect>(builder.EndTable());
		}

		// Token: 0x0602437C RID: 148348 RVA: 0x004FA920 File Offset: 0x004F8B20
		public IFanStateEffectT UnPack()
		{
			IFanStateEffectT fanStateEffectT = new IFanStateEffectT();
			this.UnPackTo(fanStateEffectT);
			return fanStateEffectT;
		}

		// Token: 0x0602437D RID: 148349 RVA: 0x004FA93C File Offset: 0x004F8B3C
		public void UnPackTo(IFanStateEffectT _o)
		{
			_o.EntityState = this.EntityState;
			_o.EffectConfig = ((this.EffectConfig != null) ? this.EffectConfig.Value.UnPack() : null);
		}

		// Token: 0x0602437E RID: 148350 RVA: 0x004FA984 File Offset: 0x004F8B84
		public static Offset<IFanStateEffect> Pack(FlatBufferBuilder builder, IFanStateEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFanStateEffect>);
			}
			StringOffset entityStateOffset = (_o.EntityState == null) ? default(StringOffset) : builder.CreateString(_o.EntityState);
			Offset<IFanEffectConfig> effectConfigOffset = (_o.EffectConfig == null) ? default(Offset<IFanEffectConfig>) : IFanEffectConfig.Pack(builder, _o.EffectConfig);
			return IFanStateEffect.CreateIFanStateEffect(builder, entityStateOffset, effectConfigOffset);
		}

		// Token: 0x0400EF8B RID: 61323
		private Table __p;
	}
}
