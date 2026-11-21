using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E8D RID: 28301
	public struct IFlowDefineNpcSupportedWalkingPerform : IFlatbufferObject
	{
		// Token: 0x1700CF63 RID: 53091
		// (get) Token: 0x06030E68 RID: 200296 RVA: 0x006A1FB9 File Offset: 0x006A01B9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030E69 RID: 200297 RVA: 0x006A1FC6 File Offset: 0x006A01C6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030E6A RID: 200298 RVA: 0x006A1FD0 File Offset: 0x006A01D0
		public static IFlowDefineNpcSupportedWalkingPerform GetRootAsIFlowDefineNpcSupportedWalkingPerform(ByteBuffer _bb)
		{
			return IFlowDefineNpcSupportedWalkingPerform.GetRootAsIFlowDefineNpcSupportedWalkingPerform(_bb, default(IFlowDefineNpcSupportedWalkingPerform));
		}

		// Token: 0x06030E6B RID: 200299 RVA: 0x006A1FEC File Offset: 0x006A01EC
		public static IFlowDefineNpcSupportedWalkingPerform GetRootAsIFlowDefineNpcSupportedWalkingPerform(ByteBuffer _bb, IFlowDefineNpcSupportedWalkingPerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030E6C RID: 200300 RVA: 0x006A2009 File Offset: 0x006A0209
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030E6D RID: 200301 RVA: 0x006A2018 File Offset: 0x006A0218
		public IFlowDefineNpcSupportedWalkingPerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CF64 RID: 53092
		// (get) Token: 0x06030E6E RID: 200302 RVA: 0x006A2028 File Offset: 0x006A0228
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

		// Token: 0x1700CF65 RID: 53093
		// (get) Token: 0x06030E6F RID: 200303 RVA: 0x006A2064 File Offset: 0x006A0264
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

		// Token: 0x06030E70 RID: 200304 RVA: 0x006A209B File Offset: 0x006A029B
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06030E71 RID: 200305 RVA: 0x006A20AA File Offset: 0x006A02AA
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06030E72 RID: 200306 RVA: 0x006A20B8 File Offset: 0x006A02B8
		public static Offset<IFlowDefineNpcSupportedWalkingPerform> CreateIFlowDefineNpcSupportedWalkingPerform(FlatBufferBuilder builder, ENpcGroupPerformType Type = ENpcGroupPerformType.HandInHand, StringOffset KeyOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IFlowDefineNpcSupportedWalkingPerform.AddKey(builder, KeyOffset);
			IFlowDefineNpcSupportedWalkingPerform.AddType(builder, Type);
			return IFlowDefineNpcSupportedWalkingPerform.EndIFlowDefineNpcSupportedWalkingPerform(builder);
		}

		// Token: 0x06030E73 RID: 200307 RVA: 0x006A20D5 File Offset: 0x006A02D5
		public static void StartIFlowDefineNpcSupportedWalkingPerform(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06030E74 RID: 200308 RVA: 0x006A20DE File Offset: 0x006A02DE
		public static void AddType(FlatBufferBuilder builder, ENpcGroupPerformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030E75 RID: 200309 RVA: 0x006A20E9 File Offset: 0x006A02E9
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(1, keyOffset.Value, 0);
		}

		// Token: 0x06030E76 RID: 200310 RVA: 0x006A20F9 File Offset: 0x006A02F9
		public static Offset<IFlowDefineNpcSupportedWalkingPerform> EndIFlowDefineNpcSupportedWalkingPerform(FlatBufferBuilder builder)
		{
			return new Offset<IFlowDefineNpcSupportedWalkingPerform>(builder.EndTable());
		}

		// Token: 0x06030E77 RID: 200311 RVA: 0x006A2108 File Offset: 0x006A0308
		public IFlowDefineNpcSupportedWalkingPerformT UnPack()
		{
			IFlowDefineNpcSupportedWalkingPerformT flowDefineNpcSupportedWalkingPerformT = new IFlowDefineNpcSupportedWalkingPerformT();
			this.UnPackTo(flowDefineNpcSupportedWalkingPerformT);
			return flowDefineNpcSupportedWalkingPerformT;
		}

		// Token: 0x06030E78 RID: 200312 RVA: 0x006A2123 File Offset: 0x006A0323
		public void UnPackTo(IFlowDefineNpcSupportedWalkingPerformT _o)
		{
			_o.Type = this.Type;
			_o.Key = this.Key;
		}

		// Token: 0x06030E79 RID: 200313 RVA: 0x006A2140 File Offset: 0x006A0340
		public static Offset<IFlowDefineNpcSupportedWalkingPerform> Pack(FlatBufferBuilder builder, IFlowDefineNpcSupportedWalkingPerformT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowDefineNpcSupportedWalkingPerform>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			return IFlowDefineNpcSupportedWalkingPerform.CreateIFlowDefineNpcSupportedWalkingPerform(builder, _o.Type, keyOffset);
		}

		// Token: 0x04011D63 RID: 73059
		private Table __p;
	}
}
