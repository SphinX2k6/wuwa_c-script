using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A86 RID: 27270
	public struct IClientTpToStreamingTargetSuccessEffect : IFlatbufferObject
	{
		// Token: 0x1700C84B RID: 51275
		// (get) Token: 0x0602ECB7 RID: 191671 RVA: 0x00660C9E File Offset: 0x0065EE9E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602ECB8 RID: 191672 RVA: 0x00660CAB File Offset: 0x0065EEAB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602ECB9 RID: 191673 RVA: 0x00660CB4 File Offset: 0x0065EEB4
		public static IClientTpToStreamingTargetSuccessEffect GetRootAsIClientTpToStreamingTargetSuccessEffect(ByteBuffer _bb)
		{
			return IClientTpToStreamingTargetSuccessEffect.GetRootAsIClientTpToStreamingTargetSuccessEffect(_bb, default(IClientTpToStreamingTargetSuccessEffect));
		}

		// Token: 0x0602ECBA RID: 191674 RVA: 0x00660CD0 File Offset: 0x0065EED0
		public static IClientTpToStreamingTargetSuccessEffect GetRootAsIClientTpToStreamingTargetSuccessEffect(ByteBuffer _bb, IClientTpToStreamingTargetSuccessEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602ECBB RID: 191675 RVA: 0x00660CED File Offset: 0x0065EEED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602ECBC RID: 191676 RVA: 0x00660CFC File Offset: 0x0065EEFC
		public IClientTpToStreamingTargetSuccessEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C84C RID: 51276
		// (get) Token: 0x0602ECBD RID: 191677 RVA: 0x00660D0C File Offset: 0x0065EF0C
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

		// Token: 0x0602ECBE RID: 191678 RVA: 0x00660D43 File Offset: 0x0065EF43
		public Span<byte> GetSceneEffectDaPathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602ECBF RID: 191679 RVA: 0x00660D52 File Offset: 0x0065EF52
		public byte[] GetSceneEffectDaPathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0602ECC0 RID: 191680 RVA: 0x00660D60 File Offset: 0x0065EF60
		public static Offset<IClientTpToStreamingTargetSuccessEffect> CreateIClientTpToStreamingTargetSuccessEffect(FlatBufferBuilder builder, StringOffset SceneEffectDaPathOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IClientTpToStreamingTargetSuccessEffect.AddSceneEffectDaPath(builder, SceneEffectDaPathOffset);
			return IClientTpToStreamingTargetSuccessEffect.EndIClientTpToStreamingTargetSuccessEffect(builder);
		}

		// Token: 0x0602ECC1 RID: 191681 RVA: 0x00660D76 File Offset: 0x0065EF76
		public static void StartIClientTpToStreamingTargetSuccessEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602ECC2 RID: 191682 RVA: 0x00660D7F File Offset: 0x0065EF7F
		public static void AddSceneEffectDaPath(FlatBufferBuilder builder, StringOffset sceneEffectDaPathOffset)
		{
			builder.AddOffset(0, sceneEffectDaPathOffset.Value, 0);
		}

		// Token: 0x0602ECC3 RID: 191683 RVA: 0x00660D8F File Offset: 0x0065EF8F
		public static Offset<IClientTpToStreamingTargetSuccessEffect> EndIClientTpToStreamingTargetSuccessEffect(FlatBufferBuilder builder)
		{
			return new Offset<IClientTpToStreamingTargetSuccessEffect>(builder.EndTable());
		}

		// Token: 0x0602ECC4 RID: 191684 RVA: 0x00660D9C File Offset: 0x0065EF9C
		public IClientTpToStreamingTargetSuccessEffectT UnPack()
		{
			IClientTpToStreamingTargetSuccessEffectT clientTpToStreamingTargetSuccessEffectT = new IClientTpToStreamingTargetSuccessEffectT();
			this.UnPackTo(clientTpToStreamingTargetSuccessEffectT);
			return clientTpToStreamingTargetSuccessEffectT;
		}

		// Token: 0x0602ECC5 RID: 191685 RVA: 0x00660DB7 File Offset: 0x0065EFB7
		public void UnPackTo(IClientTpToStreamingTargetSuccessEffectT _o)
		{
			_o.SceneEffectDaPath = this.SceneEffectDaPath;
		}

		// Token: 0x0602ECC6 RID: 191686 RVA: 0x00660DC8 File Offset: 0x0065EFC8
		public static Offset<IClientTpToStreamingTargetSuccessEffect> Pack(FlatBufferBuilder builder, IClientTpToStreamingTargetSuccessEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientTpToStreamingTargetSuccessEffect>);
			}
			StringOffset sceneEffectDaPathOffset = (_o.SceneEffectDaPath == null) ? default(StringOffset) : builder.CreateString(_o.SceneEffectDaPath);
			return IClientTpToStreamingTargetSuccessEffect.CreateIClientTpToStreamingTargetSuccessEffect(builder, sceneEffectDaPathOffset);
		}

		// Token: 0x0401181C RID: 71708
		private Table __p;
	}
}
