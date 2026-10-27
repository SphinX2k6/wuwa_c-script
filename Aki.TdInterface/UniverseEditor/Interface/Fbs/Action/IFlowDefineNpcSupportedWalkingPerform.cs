using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200680D RID: 26637
	public struct IFlowDefineNpcSupportedWalkingPerform : IFlatbufferObject
	{
		// Token: 0x1700C5AD RID: 50605
		// (get) Token: 0x0602E622 RID: 189986 RVA: 0x00654875 File Offset: 0x00652A75
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E623 RID: 189987 RVA: 0x00654882 File Offset: 0x00652A82
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E624 RID: 189988 RVA: 0x0065488C File Offset: 0x00652A8C
		public static IFlowDefineNpcSupportedWalkingPerform GetRootAsIFlowDefineNpcSupportedWalkingPerform(ByteBuffer _bb)
		{
			return IFlowDefineNpcSupportedWalkingPerform.GetRootAsIFlowDefineNpcSupportedWalkingPerform(_bb, default(IFlowDefineNpcSupportedWalkingPerform));
		}

		// Token: 0x0602E625 RID: 189989 RVA: 0x006548A8 File Offset: 0x00652AA8
		public static IFlowDefineNpcSupportedWalkingPerform GetRootAsIFlowDefineNpcSupportedWalkingPerform(ByteBuffer _bb, IFlowDefineNpcSupportedWalkingPerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E626 RID: 189990 RVA: 0x006548C5 File Offset: 0x00652AC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E627 RID: 189991 RVA: 0x006548D4 File Offset: 0x00652AD4
		public IFlowDefineNpcSupportedWalkingPerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C5AE RID: 50606
		// (get) Token: 0x0602E628 RID: 189992 RVA: 0x006548E4 File Offset: 0x00652AE4
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

		// Token: 0x1700C5AF RID: 50607
		// (get) Token: 0x0602E629 RID: 189993 RVA: 0x00654920 File Offset: 0x00652B20
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

		// Token: 0x0602E62A RID: 189994 RVA: 0x00654957 File Offset: 0x00652B57
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602E62B RID: 189995 RVA: 0x00654966 File Offset: 0x00652B66
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602E62C RID: 189996 RVA: 0x00654974 File Offset: 0x00652B74
		public static Offset<IFlowDefineNpcSupportedWalkingPerform> CreateIFlowDefineNpcSupportedWalkingPerform(FlatBufferBuilder builder, ENpcGroupPerformType Type = ENpcGroupPerformType.HandInHand, StringOffset KeyOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IFlowDefineNpcSupportedWalkingPerform.AddKey(builder, KeyOffset);
			IFlowDefineNpcSupportedWalkingPerform.AddType(builder, Type);
			return IFlowDefineNpcSupportedWalkingPerform.EndIFlowDefineNpcSupportedWalkingPerform(builder);
		}

		// Token: 0x0602E62D RID: 189997 RVA: 0x00654991 File Offset: 0x00652B91
		public static void StartIFlowDefineNpcSupportedWalkingPerform(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E62E RID: 189998 RVA: 0x0065499A File Offset: 0x00652B9A
		public static void AddType(FlatBufferBuilder builder, ENpcGroupPerformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E62F RID: 189999 RVA: 0x006549A5 File Offset: 0x00652BA5
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(1, keyOffset.Value, 0);
		}

		// Token: 0x0602E630 RID: 190000 RVA: 0x006549B5 File Offset: 0x00652BB5
		public static Offset<IFlowDefineNpcSupportedWalkingPerform> EndIFlowDefineNpcSupportedWalkingPerform(FlatBufferBuilder builder)
		{
			return new Offset<IFlowDefineNpcSupportedWalkingPerform>(builder.EndTable());
		}

		// Token: 0x0602E631 RID: 190001 RVA: 0x006549C4 File Offset: 0x00652BC4
		public IFlowDefineNpcSupportedWalkingPerformT UnPack()
		{
			IFlowDefineNpcSupportedWalkingPerformT flowDefineNpcSupportedWalkingPerformT = new IFlowDefineNpcSupportedWalkingPerformT();
			this.UnPackTo(flowDefineNpcSupportedWalkingPerformT);
			return flowDefineNpcSupportedWalkingPerformT;
		}

		// Token: 0x0602E632 RID: 190002 RVA: 0x006549DF File Offset: 0x00652BDF
		public void UnPackTo(IFlowDefineNpcSupportedWalkingPerformT _o)
		{
			_o.Type = this.Type;
			_o.Key = this.Key;
		}

		// Token: 0x0602E633 RID: 190003 RVA: 0x006549FC File Offset: 0x00652BFC
		public static Offset<IFlowDefineNpcSupportedWalkingPerform> Pack(FlatBufferBuilder builder, IFlowDefineNpcSupportedWalkingPerformT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowDefineNpcSupportedWalkingPerform>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			return IFlowDefineNpcSupportedWalkingPerform.CreateIFlowDefineNpcSupportedWalkingPerform(builder, _o.Type, keyOffset);
		}

		// Token: 0x04010F31 RID: 69425
		private Table __p;
	}
}
