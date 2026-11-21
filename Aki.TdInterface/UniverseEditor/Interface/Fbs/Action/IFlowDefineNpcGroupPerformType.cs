using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E81 RID: 28289
	public struct IFlowDefineNpcGroupPerformType : IFlatbufferObject
	{
		// Token: 0x1700CF54 RID: 53076
		// (get) Token: 0x06030E12 RID: 200210 RVA: 0x006A17C9 File Offset: 0x0069F9C9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030E13 RID: 200211 RVA: 0x006A17D6 File Offset: 0x0069F9D6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030E14 RID: 200212 RVA: 0x006A17E0 File Offset: 0x0069F9E0
		public static IFlowDefineNpcGroupPerformType GetRootAsIFlowDefineNpcGroupPerformType(ByteBuffer _bb)
		{
			return IFlowDefineNpcGroupPerformType.GetRootAsIFlowDefineNpcGroupPerformType(_bb, default(IFlowDefineNpcGroupPerformType));
		}

		// Token: 0x06030E15 RID: 200213 RVA: 0x006A17FC File Offset: 0x0069F9FC
		public static IFlowDefineNpcGroupPerformType GetRootAsIFlowDefineNpcGroupPerformType(ByteBuffer _bb, IFlowDefineNpcGroupPerformType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030E16 RID: 200214 RVA: 0x006A1819 File Offset: 0x0069FA19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030E17 RID: 200215 RVA: 0x006A1828 File Offset: 0x0069FA28
		public IFlowDefineNpcGroupPerformType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CF55 RID: 53077
		// (get) Token: 0x06030E18 RID: 200216 RVA: 0x006A1838 File Offset: 0x0069FA38
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

		// Token: 0x06030E19 RID: 200217 RVA: 0x006A1874 File Offset: 0x0069FA74
		public static Offset<IFlowDefineNpcGroupPerformType> CreateIFlowDefineNpcGroupPerformType(FlatBufferBuilder builder, ENpcGroupPerformType Type = ENpcGroupPerformType.HandInHand)
		{
			builder.StartTable(1);
			IFlowDefineNpcGroupPerformType.AddType(builder, Type);
			return IFlowDefineNpcGroupPerformType.EndIFlowDefineNpcGroupPerformType(builder);
		}

		// Token: 0x06030E1A RID: 200218 RVA: 0x006A188A File Offset: 0x0069FA8A
		public static void StartIFlowDefineNpcGroupPerformType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06030E1B RID: 200219 RVA: 0x006A1893 File Offset: 0x0069FA93
		public static void AddType(FlatBufferBuilder builder, ENpcGroupPerformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030E1C RID: 200220 RVA: 0x006A189E File Offset: 0x0069FA9E
		public static Offset<IFlowDefineNpcGroupPerformType> EndIFlowDefineNpcGroupPerformType(FlatBufferBuilder builder)
		{
			return new Offset<IFlowDefineNpcGroupPerformType>(builder.EndTable());
		}

		// Token: 0x06030E1D RID: 200221 RVA: 0x006A18AC File Offset: 0x0069FAAC
		public IFlowDefineNpcGroupPerformTypeT UnPack()
		{
			IFlowDefineNpcGroupPerformTypeT flowDefineNpcGroupPerformTypeT = new IFlowDefineNpcGroupPerformTypeT();
			this.UnPackTo(flowDefineNpcGroupPerformTypeT);
			return flowDefineNpcGroupPerformTypeT;
		}

		// Token: 0x06030E1E RID: 200222 RVA: 0x006A18C7 File Offset: 0x0069FAC7
		public void UnPackTo(IFlowDefineNpcGroupPerformTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06030E1F RID: 200223 RVA: 0x006A18D8 File Offset: 0x0069FAD8
		public static Offset<IFlowDefineNpcGroupPerformType> Pack(FlatBufferBuilder builder, IFlowDefineNpcGroupPerformTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowDefineNpcGroupPerformType>);
			}
			return IFlowDefineNpcGroupPerformType.CreateIFlowDefineNpcGroupPerformType(builder, _o.Type);
		}

		// Token: 0x04011D51 RID: 73041
		private Table __p;
	}
}
