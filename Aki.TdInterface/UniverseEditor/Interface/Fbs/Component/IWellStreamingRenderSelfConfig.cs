using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B77 RID: 23415
	public struct IWellStreamingRenderSelfConfig : IFlatbufferObject
	{
		// Token: 0x1700B0F6 RID: 45302
		// (get) Token: 0x06028141 RID: 164161 RVA: 0x005827F1 File Offset: 0x005809F1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028142 RID: 164162 RVA: 0x005827FE File Offset: 0x005809FE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028143 RID: 164163 RVA: 0x00582808 File Offset: 0x00580A08
		public static IWellStreamingRenderSelfConfig GetRootAsIWellStreamingRenderSelfConfig(ByteBuffer _bb)
		{
			return IWellStreamingRenderSelfConfig.GetRootAsIWellStreamingRenderSelfConfig(_bb, default(IWellStreamingRenderSelfConfig));
		}

		// Token: 0x06028144 RID: 164164 RVA: 0x00582824 File Offset: 0x00580A24
		public static IWellStreamingRenderSelfConfig GetRootAsIWellStreamingRenderSelfConfig(ByteBuffer _bb, IWellStreamingRenderSelfConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028145 RID: 164165 RVA: 0x00582841 File Offset: 0x00580A41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028146 RID: 164166 RVA: 0x00582850 File Offset: 0x00580A50
		public IWellStreamingRenderSelfConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B0F7 RID: 45303
		// (get) Token: 0x06028147 RID: 164167 RVA: 0x00582860 File Offset: 0x00580A60
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

		// Token: 0x06028148 RID: 164168 RVA: 0x00582897 File Offset: 0x00580A97
		public Span<byte> GetRtActorRefKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06028149 RID: 164169 RVA: 0x005828A6 File Offset: 0x00580AA6
		public byte[] GetRtActorRefKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700B0F8 RID: 45304
		// (get) Token: 0x0602814A RID: 164170 RVA: 0x005828B4 File Offset: 0x00580AB4
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

		// Token: 0x0602814B RID: 164171 RVA: 0x005828EB File Offset: 0x00580AEB
		public Span<byte> GetFallbackCubeMapKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602814C RID: 164172 RVA: 0x005828FA File Offset: 0x00580AFA
		public byte[] GetFallbackCubeMapKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602814D RID: 164173 RVA: 0x00582908 File Offset: 0x00580B08
		public static Offset<IWellStreamingRenderSelfConfig> CreateIWellStreamingRenderSelfConfig(FlatBufferBuilder builder, StringOffset RtActorRefKeyOffset = default(StringOffset), StringOffset FallbackCubeMapKeyOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IWellStreamingRenderSelfConfig.AddFallbackCubeMapKey(builder, FallbackCubeMapKeyOffset);
			IWellStreamingRenderSelfConfig.AddRtActorRefKey(builder, RtActorRefKeyOffset);
			return IWellStreamingRenderSelfConfig.EndIWellStreamingRenderSelfConfig(builder);
		}

		// Token: 0x0602814E RID: 164174 RVA: 0x00582925 File Offset: 0x00580B25
		public static void StartIWellStreamingRenderSelfConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602814F RID: 164175 RVA: 0x0058292E File Offset: 0x00580B2E
		public static void AddRtActorRefKey(FlatBufferBuilder builder, StringOffset rtActorRefKeyOffset)
		{
			builder.AddOffset(0, rtActorRefKeyOffset.Value, 0);
		}

		// Token: 0x06028150 RID: 164176 RVA: 0x0058293E File Offset: 0x00580B3E
		public static void AddFallbackCubeMapKey(FlatBufferBuilder builder, StringOffset fallbackCubeMapKeyOffset)
		{
			builder.AddOffset(1, fallbackCubeMapKeyOffset.Value, 0);
		}

		// Token: 0x06028151 RID: 164177 RVA: 0x0058294E File Offset: 0x00580B4E
		public static Offset<IWellStreamingRenderSelfConfig> EndIWellStreamingRenderSelfConfig(FlatBufferBuilder builder)
		{
			return new Offset<IWellStreamingRenderSelfConfig>(builder.EndTable());
		}

		// Token: 0x06028152 RID: 164178 RVA: 0x0058295C File Offset: 0x00580B5C
		public IWellStreamingRenderSelfConfigT UnPack()
		{
			IWellStreamingRenderSelfConfigT wellStreamingRenderSelfConfigT = new IWellStreamingRenderSelfConfigT();
			this.UnPackTo(wellStreamingRenderSelfConfigT);
			return wellStreamingRenderSelfConfigT;
		}

		// Token: 0x06028153 RID: 164179 RVA: 0x00582977 File Offset: 0x00580B77
		public void UnPackTo(IWellStreamingRenderSelfConfigT _o)
		{
			_o.RtActorRefKey = this.RtActorRefKey;
			_o.FallbackCubeMapKey = this.FallbackCubeMapKey;
		}

		// Token: 0x06028154 RID: 164180 RVA: 0x00582994 File Offset: 0x00580B94
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

		// Token: 0x0400F2D0 RID: 62160
		private Table __p;
	}
}
