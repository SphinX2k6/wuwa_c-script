using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006406 RID: 25606
	public struct IClientTpToStreamingTargetSuccessEffect : IFlatbufferObject
	{
		// Token: 0x1700BEB1 RID: 48817
		// (get) Token: 0x0602C4E1 RID: 181473 RVA: 0x00614E12 File Offset: 0x00613012
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C4E2 RID: 181474 RVA: 0x00614E1F File Offset: 0x0061301F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C4E3 RID: 181475 RVA: 0x00614E28 File Offset: 0x00613028
		public static IClientTpToStreamingTargetSuccessEffect GetRootAsIClientTpToStreamingTargetSuccessEffect(ByteBuffer _bb)
		{
			return IClientTpToStreamingTargetSuccessEffect.GetRootAsIClientTpToStreamingTargetSuccessEffect(_bb, default(IClientTpToStreamingTargetSuccessEffect));
		}

		// Token: 0x0602C4E4 RID: 181476 RVA: 0x00614E44 File Offset: 0x00613044
		public static IClientTpToStreamingTargetSuccessEffect GetRootAsIClientTpToStreamingTargetSuccessEffect(ByteBuffer _bb, IClientTpToStreamingTargetSuccessEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C4E5 RID: 181477 RVA: 0x00614E61 File Offset: 0x00613061
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C4E6 RID: 181478 RVA: 0x00614E70 File Offset: 0x00613070
		public IClientTpToStreamingTargetSuccessEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BEB2 RID: 48818
		// (get) Token: 0x0602C4E7 RID: 181479 RVA: 0x00614E80 File Offset: 0x00613080
		public string SceneEffectDaPath
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

		// Token: 0x0602C4E8 RID: 181480 RVA: 0x00614EB7 File Offset: 0x006130B7
		public Span<byte> GetSceneEffectDaPathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602C4E9 RID: 181481 RVA: 0x00614EC6 File Offset: 0x006130C6
		public byte[] GetSceneEffectDaPathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0602C4EA RID: 181482 RVA: 0x00614ED4 File Offset: 0x006130D4
		public static Offset<IClientTpToStreamingTargetSuccessEffect> CreateIClientTpToStreamingTargetSuccessEffect(FlatBufferBuilder builder, StringOffset SceneEffectDaPathOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IClientTpToStreamingTargetSuccessEffect.AddSceneEffectDaPath(builder, SceneEffectDaPathOffset);
			return IClientTpToStreamingTargetSuccessEffect.EndIClientTpToStreamingTargetSuccessEffect(builder);
		}

		// Token: 0x0602C4EB RID: 181483 RVA: 0x00614EEA File Offset: 0x006130EA
		public static void StartIClientTpToStreamingTargetSuccessEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602C4EC RID: 181484 RVA: 0x00614EF3 File Offset: 0x006130F3
		public static void AddSceneEffectDaPath(FlatBufferBuilder builder, StringOffset sceneEffectDaPathOffset)
		{
			builder.AddOffset(0, sceneEffectDaPathOffset.Value, 0);
		}

		// Token: 0x0602C4ED RID: 181485 RVA: 0x00614F03 File Offset: 0x00613103
		public static Offset<IClientTpToStreamingTargetSuccessEffect> EndIClientTpToStreamingTargetSuccessEffect(FlatBufferBuilder builder)
		{
			return new Offset<IClientTpToStreamingTargetSuccessEffect>(builder.EndTable());
		}

		// Token: 0x0602C4EE RID: 181486 RVA: 0x00614F10 File Offset: 0x00613110
		public IClientTpToStreamingTargetSuccessEffectT UnPack()
		{
			IClientTpToStreamingTargetSuccessEffectT clientTpToStreamingTargetSuccessEffectT = new IClientTpToStreamingTargetSuccessEffectT();
			this.UnPackTo(clientTpToStreamingTargetSuccessEffectT);
			return clientTpToStreamingTargetSuccessEffectT;
		}

		// Token: 0x0602C4EF RID: 181487 RVA: 0x00614F2B File Offset: 0x0061312B
		public void UnPackTo(IClientTpToStreamingTargetSuccessEffectT _o)
		{
			_o.SceneEffectDaPath = this.SceneEffectDaPath;
		}

		// Token: 0x0602C4F0 RID: 181488 RVA: 0x00614F3C File Offset: 0x0061313C
		public static Offset<IClientTpToStreamingTargetSuccessEffect> Pack(FlatBufferBuilder builder, IClientTpToStreamingTargetSuccessEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientTpToStreamingTargetSuccessEffect>);
			}
			StringOffset sceneEffectDaPathOffset = (_o.SceneEffectDaPath == null) ? default(StringOffset) : builder.CreateString(_o.SceneEffectDaPath);
			return IClientTpToStreamingTargetSuccessEffect.CreateIClientTpToStreamingTargetSuccessEffect(builder, sceneEffectDaPathOffset);
		}

		// Token: 0x040109F6 RID: 68086
		private Table __p;
	}
}
