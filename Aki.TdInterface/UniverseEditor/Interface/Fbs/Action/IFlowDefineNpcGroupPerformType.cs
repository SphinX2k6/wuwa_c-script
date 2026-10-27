using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006801 RID: 26625
	public struct IFlowDefineNpcGroupPerformType : IFlatbufferObject
	{
		// Token: 0x1700C59E RID: 50590
		// (get) Token: 0x0602E5CC RID: 189900 RVA: 0x00654085 File Offset: 0x00652285
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E5CD RID: 189901 RVA: 0x00654092 File Offset: 0x00652292
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E5CE RID: 189902 RVA: 0x0065409C File Offset: 0x0065229C
		public static IFlowDefineNpcGroupPerformType GetRootAsIFlowDefineNpcGroupPerformType(ByteBuffer _bb)
		{
			return IFlowDefineNpcGroupPerformType.GetRootAsIFlowDefineNpcGroupPerformType(_bb, default(IFlowDefineNpcGroupPerformType));
		}

		// Token: 0x0602E5CF RID: 189903 RVA: 0x006540B8 File Offset: 0x006522B8
		public static IFlowDefineNpcGroupPerformType GetRootAsIFlowDefineNpcGroupPerformType(ByteBuffer _bb, IFlowDefineNpcGroupPerformType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E5D0 RID: 189904 RVA: 0x006540D5 File Offset: 0x006522D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E5D1 RID: 189905 RVA: 0x006540E4 File Offset: 0x006522E4
		public IFlowDefineNpcGroupPerformType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C59F RID: 50591
		// (get) Token: 0x0602E5D2 RID: 189906 RVA: 0x006540F4 File Offset: 0x006522F4
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

		// Token: 0x0602E5D3 RID: 189907 RVA: 0x00654130 File Offset: 0x00652330
		public static Offset<IFlowDefineNpcGroupPerformType> CreateIFlowDefineNpcGroupPerformType(FlatBufferBuilder builder, ENpcGroupPerformType Type = ENpcGroupPerformType.HandInHand)
		{
			builder.StartTable(1);
			IFlowDefineNpcGroupPerformType.AddType(builder, Type);
			return IFlowDefineNpcGroupPerformType.EndIFlowDefineNpcGroupPerformType(builder);
		}

		// Token: 0x0602E5D4 RID: 189908 RVA: 0x00654146 File Offset: 0x00652346
		public static void StartIFlowDefineNpcGroupPerformType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E5D5 RID: 189909 RVA: 0x0065414F File Offset: 0x0065234F
		public static void AddType(FlatBufferBuilder builder, ENpcGroupPerformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E5D6 RID: 189910 RVA: 0x0065415A File Offset: 0x0065235A
		public static Offset<IFlowDefineNpcGroupPerformType> EndIFlowDefineNpcGroupPerformType(FlatBufferBuilder builder)
		{
			return new Offset<IFlowDefineNpcGroupPerformType>(builder.EndTable());
		}

		// Token: 0x0602E5D7 RID: 189911 RVA: 0x00654168 File Offset: 0x00652368
		public IFlowDefineNpcGroupPerformTypeT UnPack()
		{
			IFlowDefineNpcGroupPerformTypeT flowDefineNpcGroupPerformTypeT = new IFlowDefineNpcGroupPerformTypeT();
			this.UnPackTo(flowDefineNpcGroupPerformTypeT);
			return flowDefineNpcGroupPerformTypeT;
		}

		// Token: 0x0602E5D8 RID: 189912 RVA: 0x00654183 File Offset: 0x00652383
		public void UnPackTo(IFlowDefineNpcGroupPerformTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602E5D9 RID: 189913 RVA: 0x00654194 File Offset: 0x00652394
		public static Offset<IFlowDefineNpcGroupPerformType> Pack(FlatBufferBuilder builder, IFlowDefineNpcGroupPerformTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowDefineNpcGroupPerformType>);
			}
			return IFlowDefineNpcGroupPerformType.CreateIFlowDefineNpcGroupPerformType(builder, _o.Type);
		}

		// Token: 0x04010F1F RID: 69407
		private Table __p;
	}
}
