using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070F4 RID: 28916
	public struct ILiveForceDanmakuParam : IFlatbufferObject
	{
		// Token: 0x1700D3C1 RID: 54209
		// (get) Token: 0x06032376 RID: 205686 RVA: 0x006CAD06 File Offset: 0x006C8F06
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032377 RID: 205687 RVA: 0x006CAD13 File Offset: 0x006C8F13
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032378 RID: 205688 RVA: 0x006CAD1C File Offset: 0x006C8F1C
		public static ILiveForceDanmakuParam GetRootAsILiveForceDanmakuParam(ByteBuffer _bb)
		{
			return ILiveForceDanmakuParam.GetRootAsILiveForceDanmakuParam(_bb, default(ILiveForceDanmakuParam));
		}

		// Token: 0x06032379 RID: 205689 RVA: 0x006CAD38 File Offset: 0x006C8F38
		public static ILiveForceDanmakuParam GetRootAsILiveForceDanmakuParam(ByteBuffer _bb, ILiveForceDanmakuParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603237A RID: 205690 RVA: 0x006CAD55 File Offset: 0x006C8F55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603237B RID: 205691 RVA: 0x006CAD64 File Offset: 0x006C8F64
		public ILiveForceDanmakuParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D3C2 RID: 54210
		// (get) Token: 0x0603237C RID: 205692 RVA: 0x006CAD74 File Offset: 0x006C8F74
		public ELiveParamType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELiveParamType.Heat;
				}
				return (ELiveParamType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D3C3 RID: 54211
		// (get) Token: 0x0603237D RID: 205693 RVA: 0x006CADB0 File Offset: 0x006C8FB0
		public ELiveForceDanmakuState State
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ELiveForceDanmakuState.Force;
				}
				return (ELiveForceDanmakuState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603237E RID: 205694 RVA: 0x006CADEC File Offset: 0x006C8FEC
		public static Offset<ILiveForceDanmakuParam> CreateILiveForceDanmakuParam(FlatBufferBuilder builder, ELiveParamType Type = ELiveParamType.Heat, ELiveForceDanmakuState State = ELiveForceDanmakuState.Force)
		{
			builder.StartTable(2);
			ILiveForceDanmakuParam.AddState(builder, State);
			ILiveForceDanmakuParam.AddType(builder, Type);
			return ILiveForceDanmakuParam.EndILiveForceDanmakuParam(builder);
		}

		// Token: 0x0603237F RID: 205695 RVA: 0x006CAE09 File Offset: 0x006C9009
		public static void StartILiveForceDanmakuParam(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06032380 RID: 205696 RVA: 0x006CAE12 File Offset: 0x006C9012
		public static void AddType(FlatBufferBuilder builder, ELiveParamType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032381 RID: 205697 RVA: 0x006CAE1D File Offset: 0x006C901D
		public static void AddState(FlatBufferBuilder builder, ELiveForceDanmakuState state)
		{
			builder.AddByte(1, (byte)state, 0);
		}

		// Token: 0x06032382 RID: 205698 RVA: 0x006CAE28 File Offset: 0x006C9028
		public static Offset<ILiveForceDanmakuParam> EndILiveForceDanmakuParam(FlatBufferBuilder builder)
		{
			return new Offset<ILiveForceDanmakuParam>(builder.EndTable());
		}

		// Token: 0x06032383 RID: 205699 RVA: 0x006CAE38 File Offset: 0x006C9038
		public ILiveForceDanmakuParamT UnPack()
		{
			ILiveForceDanmakuParamT liveForceDanmakuParamT = new ILiveForceDanmakuParamT();
			this.UnPackTo(liveForceDanmakuParamT);
			return liveForceDanmakuParamT;
		}

		// Token: 0x06032384 RID: 205700 RVA: 0x006CAE53 File Offset: 0x006C9053
		public void UnPackTo(ILiveForceDanmakuParamT _o)
		{
			_o.Type = this.Type;
			_o.State = this.State;
		}

		// Token: 0x06032385 RID: 205701 RVA: 0x006CAE70 File Offset: 0x006C9070
		public static Offset<ILiveForceDanmakuParam> Pack(FlatBufferBuilder builder, ILiveForceDanmakuParamT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiveForceDanmakuParam>);
			}
			return ILiveForceDanmakuParam.CreateILiveForceDanmakuParam(builder, _o.Type, _o.State);
		}

		// Token: 0x040120C4 RID: 73924
		private Table __p;
	}
}
