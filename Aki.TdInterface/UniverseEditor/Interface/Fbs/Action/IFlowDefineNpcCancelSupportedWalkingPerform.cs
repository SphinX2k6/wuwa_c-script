using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E7B RID: 28283
	public struct IFlowDefineNpcCancelSupportedWalkingPerform : IFlatbufferObject
	{
		// Token: 0x1700CF4C RID: 53068
		// (get) Token: 0x06030DE1 RID: 200161 RVA: 0x006A118D File Offset: 0x0069F38D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030DE2 RID: 200162 RVA: 0x006A119A File Offset: 0x0069F39A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030DE3 RID: 200163 RVA: 0x006A11A4 File Offset: 0x0069F3A4
		public static IFlowDefineNpcCancelSupportedWalkingPerform GetRootAsIFlowDefineNpcCancelSupportedWalkingPerform(ByteBuffer _bb)
		{
			return IFlowDefineNpcCancelSupportedWalkingPerform.GetRootAsIFlowDefineNpcCancelSupportedWalkingPerform(_bb, default(IFlowDefineNpcCancelSupportedWalkingPerform));
		}

		// Token: 0x06030DE4 RID: 200164 RVA: 0x006A11C0 File Offset: 0x0069F3C0
		public static IFlowDefineNpcCancelSupportedWalkingPerform GetRootAsIFlowDefineNpcCancelSupportedWalkingPerform(ByteBuffer _bb, IFlowDefineNpcCancelSupportedWalkingPerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030DE5 RID: 200165 RVA: 0x006A11DD File Offset: 0x0069F3DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030DE6 RID: 200166 RVA: 0x006A11EC File Offset: 0x0069F3EC
		public IFlowDefineNpcCancelSupportedWalkingPerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CF4D RID: 53069
		// (get) Token: 0x06030DE7 RID: 200167 RVA: 0x006A11FC File Offset: 0x0069F3FC
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

		// Token: 0x1700CF4E RID: 53070
		// (get) Token: 0x06030DE8 RID: 200168 RVA: 0x006A1238 File Offset: 0x0069F438
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

		// Token: 0x06030DE9 RID: 200169 RVA: 0x006A126F File Offset: 0x0069F46F
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06030DEA RID: 200170 RVA: 0x006A127E File Offset: 0x0069F47E
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06030DEB RID: 200171 RVA: 0x006A128C File Offset: 0x0069F48C
		public static Offset<IFlowDefineNpcCancelSupportedWalkingPerform> CreateIFlowDefineNpcCancelSupportedWalkingPerform(FlatBufferBuilder builder, ENpcGroupPerformType Type = ENpcGroupPerformType.HandInHand, StringOffset KeyOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IFlowDefineNpcCancelSupportedWalkingPerform.AddKey(builder, KeyOffset);
			IFlowDefineNpcCancelSupportedWalkingPerform.AddType(builder, Type);
			return IFlowDefineNpcCancelSupportedWalkingPerform.EndIFlowDefineNpcCancelSupportedWalkingPerform(builder);
		}

		// Token: 0x06030DEC RID: 200172 RVA: 0x006A12A9 File Offset: 0x0069F4A9
		public static void StartIFlowDefineNpcCancelSupportedWalkingPerform(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06030DED RID: 200173 RVA: 0x006A12B2 File Offset: 0x0069F4B2
		public static void AddType(FlatBufferBuilder builder, ENpcGroupPerformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030DEE RID: 200174 RVA: 0x006A12BD File Offset: 0x0069F4BD
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(1, keyOffset.Value, 0);
		}

		// Token: 0x06030DEF RID: 200175 RVA: 0x006A12CD File Offset: 0x0069F4CD
		public static Offset<IFlowDefineNpcCancelSupportedWalkingPerform> EndIFlowDefineNpcCancelSupportedWalkingPerform(FlatBufferBuilder builder)
		{
			return new Offset<IFlowDefineNpcCancelSupportedWalkingPerform>(builder.EndTable());
		}

		// Token: 0x06030DF0 RID: 200176 RVA: 0x006A12DC File Offset: 0x0069F4DC
		public IFlowDefineNpcCancelSupportedWalkingPerformT UnPack()
		{
			IFlowDefineNpcCancelSupportedWalkingPerformT flowDefineNpcCancelSupportedWalkingPerformT = new IFlowDefineNpcCancelSupportedWalkingPerformT();
			this.UnPackTo(flowDefineNpcCancelSupportedWalkingPerformT);
			return flowDefineNpcCancelSupportedWalkingPerformT;
		}

		// Token: 0x06030DF1 RID: 200177 RVA: 0x006A12F7 File Offset: 0x0069F4F7
		public void UnPackTo(IFlowDefineNpcCancelSupportedWalkingPerformT _o)
		{
			_o.Type = this.Type;
			_o.Key = this.Key;
		}

		// Token: 0x06030DF2 RID: 200178 RVA: 0x006A1314 File Offset: 0x0069F514
		public static Offset<IFlowDefineNpcCancelSupportedWalkingPerform> Pack(FlatBufferBuilder builder, IFlowDefineNpcCancelSupportedWalkingPerformT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowDefineNpcCancelSupportedWalkingPerform>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			return IFlowDefineNpcCancelSupportedWalkingPerform.CreateIFlowDefineNpcCancelSupportedWalkingPerform(builder, _o.Type, keyOffset);
		}

		// Token: 0x04011D4C RID: 73036
		private Table __p;
	}
}
