using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200618D RID: 24973
	public struct IWellStreamingRenderSelfConfig : IFlatbufferObject
	{
		// Token: 0x1700BA3E RID: 47678
		// (get) Token: 0x0602A705 RID: 173829 RVA: 0x005CA281 File Offset: 0x005C8481
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A706 RID: 173830 RVA: 0x005CA28E File Offset: 0x005C848E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A707 RID: 173831 RVA: 0x005CA298 File Offset: 0x005C8498
		public static IWellStreamingRenderSelfConfig GetRootAsIWellStreamingRenderSelfConfig(ByteBuffer _bb)
		{
			return IWellStreamingRenderSelfConfig.GetRootAsIWellStreamingRenderSelfConfig(_bb, default(IWellStreamingRenderSelfConfig));
		}

		// Token: 0x0602A708 RID: 173832 RVA: 0x005CA2B4 File Offset: 0x005C84B4
		public static IWellStreamingRenderSelfConfig GetRootAsIWellStreamingRenderSelfConfig(ByteBuffer _bb, IWellStreamingRenderSelfConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A709 RID: 173833 RVA: 0x005CA2D1 File Offset: 0x005C84D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A70A RID: 173834 RVA: 0x005CA2E0 File Offset: 0x005C84E0
		public IWellStreamingRenderSelfConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BA3F RID: 47679
		// (get) Token: 0x0602A70B RID: 173835 RVA: 0x005CA2F0 File Offset: 0x005C84F0
		public string RtActorRefKey
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

		// Token: 0x0602A70C RID: 173836 RVA: 0x005CA327 File Offset: 0x005C8527
		public Span<byte> GetRtActorRefKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602A70D RID: 173837 RVA: 0x005CA336 File Offset: 0x005C8536
		public byte[] GetRtActorRefKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700BA40 RID: 47680
		// (get) Token: 0x0602A70E RID: 173838 RVA: 0x005CA344 File Offset: 0x005C8544
		public string FallbackCubeMapKey
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A70F RID: 173839 RVA: 0x005CA37B File Offset: 0x005C857B
		public Span<byte> GetFallbackCubeMapKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602A710 RID: 173840 RVA: 0x005CA38A File Offset: 0x005C858A
		public byte[] GetFallbackCubeMapKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602A711 RID: 173841 RVA: 0x005CA398 File Offset: 0x005C8598
		public static Offset<IWellStreamingRenderSelfConfig> CreateIWellStreamingRenderSelfConfig(FlatBufferBuilder builder, StringOffset RtActorRefKeyOffset = default(StringOffset), StringOffset FallbackCubeMapKeyOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IWellStreamingRenderSelfConfig.AddFallbackCubeMapKey(builder, FallbackCubeMapKeyOffset);
			IWellStreamingRenderSelfConfig.AddRtActorRefKey(builder, RtActorRefKeyOffset);
			return IWellStreamingRenderSelfConfig.EndIWellStreamingRenderSelfConfig(builder);
		}

		// Token: 0x0602A712 RID: 173842 RVA: 0x005CA3B5 File Offset: 0x005C85B5
		public static void StartIWellStreamingRenderSelfConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602A713 RID: 173843 RVA: 0x005CA3BE File Offset: 0x005C85BE
		public static void AddRtActorRefKey(FlatBufferBuilder builder, StringOffset rtActorRefKeyOffset)
		{
			builder.AddOffset(0, rtActorRefKeyOffset.Value, 0);
		}

		// Token: 0x0602A714 RID: 173844 RVA: 0x005CA3CE File Offset: 0x005C85CE
		public static void AddFallbackCubeMapKey(FlatBufferBuilder builder, StringOffset fallbackCubeMapKeyOffset)
		{
			builder.AddOffset(1, fallbackCubeMapKeyOffset.Value, 0);
		}

		// Token: 0x0602A715 RID: 173845 RVA: 0x005CA3DE File Offset: 0x005C85DE
		public static Offset<IWellStreamingRenderSelfConfig> EndIWellStreamingRenderSelfConfig(FlatBufferBuilder builder)
		{
			return new Offset<IWellStreamingRenderSelfConfig>(builder.EndTable());
		}

		// Token: 0x0602A716 RID: 173846 RVA: 0x005CA3EC File Offset: 0x005C85EC
		public IWellStreamingRenderSelfConfigT UnPack()
		{
			IWellStreamingRenderSelfConfigT wellStreamingRenderSelfConfigT = new IWellStreamingRenderSelfConfigT();
			this.UnPackTo(wellStreamingRenderSelfConfigT);
			return wellStreamingRenderSelfConfigT;
		}

		// Token: 0x0602A717 RID: 173847 RVA: 0x005CA407 File Offset: 0x005C8607
		public void UnPackTo(IWellStreamingRenderSelfConfigT _o)
		{
			_o.RtActorRefKey = this.RtActorRefKey;
			_o.FallbackCubeMapKey = this.FallbackCubeMapKey;
		}

		// Token: 0x0602A718 RID: 173848 RVA: 0x005CA424 File Offset: 0x005C8624
		public static Offset<IWellStreamingRenderSelfConfig> Pack(FlatBufferBuilder builder, IWellStreamingRenderSelfConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWellStreamingRenderSelfConfig>);
			}
			StringOffset rtActorRefKeyOffset = (_o.RtActorRefKey == null) ? default(StringOffset) : builder.CreateString(_o.RtActorRefKey);
			StringOffset fallbackCubeMapKeyOffset = (_o.FallbackCubeMapKey == null) ? default(StringOffset) : builder.CreateString(_o.FallbackCubeMapKey);
			return IWellStreamingRenderSelfConfig.CreateIWellStreamingRenderSelfConfig(builder, rtActorRefKeyOffset, fallbackCubeMapKeyOffset);
		}

		// Token: 0x0400FFD6 RID: 65494
		private Table __p;
	}
}
