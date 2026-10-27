using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067FB RID: 26619
	public struct IFlowDefineNpcCancelSupportedWalkingPerform : IFlatbufferObject
	{
		// Token: 0x1700C596 RID: 50582
		// (get) Token: 0x0602E59B RID: 189851 RVA: 0x00653A49 File Offset: 0x00651C49
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E59C RID: 189852 RVA: 0x00653A56 File Offset: 0x00651C56
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E59D RID: 189853 RVA: 0x00653A60 File Offset: 0x00651C60
		public static IFlowDefineNpcCancelSupportedWalkingPerform GetRootAsIFlowDefineNpcCancelSupportedWalkingPerform(ByteBuffer _bb)
		{
			return IFlowDefineNpcCancelSupportedWalkingPerform.GetRootAsIFlowDefineNpcCancelSupportedWalkingPerform(_bb, default(IFlowDefineNpcCancelSupportedWalkingPerform));
		}

		// Token: 0x0602E59E RID: 189854 RVA: 0x00653A7C File Offset: 0x00651C7C
		public static IFlowDefineNpcCancelSupportedWalkingPerform GetRootAsIFlowDefineNpcCancelSupportedWalkingPerform(ByteBuffer _bb, IFlowDefineNpcCancelSupportedWalkingPerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E59F RID: 189855 RVA: 0x00653A99 File Offset: 0x00651C99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E5A0 RID: 189856 RVA: 0x00653AA8 File Offset: 0x00651CA8
		public IFlowDefineNpcCancelSupportedWalkingPerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C597 RID: 50583
		// (get) Token: 0x0602E5A1 RID: 189857 RVA: 0x00653AB8 File Offset: 0x00651CB8
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

		// Token: 0x1700C598 RID: 50584
		// (get) Token: 0x0602E5A2 RID: 189858 RVA: 0x00653AF4 File Offset: 0x00651CF4
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

		// Token: 0x0602E5A3 RID: 189859 RVA: 0x00653B2B File Offset: 0x00651D2B
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602E5A4 RID: 189860 RVA: 0x00653B3A File Offset: 0x00651D3A
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602E5A5 RID: 189861 RVA: 0x00653B48 File Offset: 0x00651D48
		public static Offset<IFlowDefineNpcCancelSupportedWalkingPerform> CreateIFlowDefineNpcCancelSupportedWalkingPerform(FlatBufferBuilder builder, ENpcGroupPerformType Type = ENpcGroupPerformType.HandInHand, StringOffset KeyOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IFlowDefineNpcCancelSupportedWalkingPerform.AddKey(builder, KeyOffset);
			IFlowDefineNpcCancelSupportedWalkingPerform.AddType(builder, Type);
			return IFlowDefineNpcCancelSupportedWalkingPerform.EndIFlowDefineNpcCancelSupportedWalkingPerform(builder);
		}

		// Token: 0x0602E5A6 RID: 189862 RVA: 0x00653B65 File Offset: 0x00651D65
		public static void StartIFlowDefineNpcCancelSupportedWalkingPerform(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E5A7 RID: 189863 RVA: 0x00653B6E File Offset: 0x00651D6E
		public static void AddType(FlatBufferBuilder builder, ENpcGroupPerformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E5A8 RID: 189864 RVA: 0x00653B79 File Offset: 0x00651D79
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(1, keyOffset.Value, 0);
		}

		// Token: 0x0602E5A9 RID: 189865 RVA: 0x00653B89 File Offset: 0x00651D89
		public static Offset<IFlowDefineNpcCancelSupportedWalkingPerform> EndIFlowDefineNpcCancelSupportedWalkingPerform(FlatBufferBuilder builder)
		{
			return new Offset<IFlowDefineNpcCancelSupportedWalkingPerform>(builder.EndTable());
		}

		// Token: 0x0602E5AA RID: 189866 RVA: 0x00653B98 File Offset: 0x00651D98
		public IFlowDefineNpcCancelSupportedWalkingPerformT UnPack()
		{
			IFlowDefineNpcCancelSupportedWalkingPerformT flowDefineNpcCancelSupportedWalkingPerformT = new IFlowDefineNpcCancelSupportedWalkingPerformT();
			this.UnPackTo(flowDefineNpcCancelSupportedWalkingPerformT);
			return flowDefineNpcCancelSupportedWalkingPerformT;
		}

		// Token: 0x0602E5AB RID: 189867 RVA: 0x00653BB3 File Offset: 0x00651DB3
		public void UnPackTo(IFlowDefineNpcCancelSupportedWalkingPerformT _o)
		{
			_o.Type = this.Type;
			_o.Key = this.Key;
		}

		// Token: 0x0602E5AC RID: 189868 RVA: 0x00653BD0 File Offset: 0x00651DD0
		public static Offset<IFlowDefineNpcCancelSupportedWalkingPerform> Pack(FlatBufferBuilder builder, IFlowDefineNpcCancelSupportedWalkingPerformT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowDefineNpcCancelSupportedWalkingPerform>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			return IFlowDefineNpcCancelSupportedWalkingPerform.CreateIFlowDefineNpcCancelSupportedWalkingPerform(builder, _o.Type, keyOffset);
		}

		// Token: 0x04010F1A RID: 69402
		private Table __p;
	}
}
