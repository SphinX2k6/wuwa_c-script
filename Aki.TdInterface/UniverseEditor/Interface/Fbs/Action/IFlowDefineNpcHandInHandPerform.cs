using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E87 RID: 28295
	public struct IFlowDefineNpcHandInHandPerform : IFlatbufferObject
	{
		// Token: 0x1700CF59 RID: 53081
		// (get) Token: 0x06030E38 RID: 200248 RVA: 0x006A1B52 File Offset: 0x0069FD52
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030E39 RID: 200249 RVA: 0x006A1B5F File Offset: 0x0069FD5F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030E3A RID: 200250 RVA: 0x006A1B68 File Offset: 0x0069FD68
		public static IFlowDefineNpcHandInHandPerform GetRootAsIFlowDefineNpcHandInHandPerform(ByteBuffer _bb)
		{
			return IFlowDefineNpcHandInHandPerform.GetRootAsIFlowDefineNpcHandInHandPerform(_bb, default(IFlowDefineNpcHandInHandPerform));
		}

		// Token: 0x06030E3B RID: 200251 RVA: 0x006A1B84 File Offset: 0x0069FD84
		public static IFlowDefineNpcHandInHandPerform GetRootAsIFlowDefineNpcHandInHandPerform(ByteBuffer _bb, IFlowDefineNpcHandInHandPerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030E3C RID: 200252 RVA: 0x006A1BA1 File Offset: 0x0069FDA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030E3D RID: 200253 RVA: 0x006A1BB0 File Offset: 0x0069FDB0
		public IFlowDefineNpcHandInHandPerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CF5A RID: 53082
		// (get) Token: 0x06030E3E RID: 200254 RVA: 0x006A1BC0 File Offset: 0x0069FDC0
		public ENpcGroupPerformType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENpcGroupPerformType.HandInHand;
				}
				return (ENpcGroupPerformType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CF5B RID: 53083
		// (get) Token: 0x06030E3F RID: 200255 RVA: 0x006A1BFC File Offset: 0x0069FDFC
		public string Key
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

		// Token: 0x06030E40 RID: 200256 RVA: 0x006A1C33 File Offset: 0x0069FE33
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06030E41 RID: 200257 RVA: 0x006A1C42 File Offset: 0x0069FE42
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06030E42 RID: 200258 RVA: 0x006A1C50 File Offset: 0x0069FE50
		public static Offset<IFlowDefineNpcHandInHandPerform> CreateIFlowDefineNpcHandInHandPerform(FlatBufferBuilder builder, ENpcGroupPerformType Type = ENpcGroupPerformType.HandInHand, StringOffset KeyOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IFlowDefineNpcHandInHandPerform.AddKey(builder, KeyOffset);
			IFlowDefineNpcHandInHandPerform.AddType(builder, Type);
			return IFlowDefineNpcHandInHandPerform.EndIFlowDefineNpcHandInHandPerform(builder);
		}

		// Token: 0x06030E43 RID: 200259 RVA: 0x006A1C6D File Offset: 0x0069FE6D
		public static void StartIFlowDefineNpcHandInHandPerform(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06030E44 RID: 200260 RVA: 0x006A1C76 File Offset: 0x0069FE76
		public static void AddType(FlatBufferBuilder builder, ENpcGroupPerformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030E45 RID: 200261 RVA: 0x006A1C81 File Offset: 0x0069FE81
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(1, keyOffset.Value, 0);
		}

		// Token: 0x06030E46 RID: 200262 RVA: 0x006A1C91 File Offset: 0x0069FE91
		public static Offset<IFlowDefineNpcHandInHandPerform> EndIFlowDefineNpcHandInHandPerform(FlatBufferBuilder builder)
		{
			return new Offset<IFlowDefineNpcHandInHandPerform>(builder.EndTable());
		}

		// Token: 0x06030E47 RID: 200263 RVA: 0x006A1CA0 File Offset: 0x0069FEA0
		public IFlowDefineNpcHandInHandPerformT UnPack()
		{
			IFlowDefineNpcHandInHandPerformT flowDefineNpcHandInHandPerformT = new IFlowDefineNpcHandInHandPerformT();
			this.UnPackTo(flowDefineNpcHandInHandPerformT);
			return flowDefineNpcHandInHandPerformT;
		}

		// Token: 0x06030E48 RID: 200264 RVA: 0x006A1CBB File Offset: 0x0069FEBB
		public void UnPackTo(IFlowDefineNpcHandInHandPerformT _o)
		{
			_o.Type = this.Type;
			_o.Key = this.Key;
		}

		// Token: 0x06030E49 RID: 200265 RVA: 0x006A1CD8 File Offset: 0x0069FED8
		public static Offset<IFlowDefineNpcHandInHandPerform> Pack(FlatBufferBuilder builder, IFlowDefineNpcHandInHandPerformT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowDefineNpcHandInHandPerform>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			return IFlowDefineNpcHandInHandPerform.CreateIFlowDefineNpcHandInHandPerform(builder, _o.Type, keyOffset);
		}

		// Token: 0x04011D5D RID: 73053
		private Table __p;
	}
}
