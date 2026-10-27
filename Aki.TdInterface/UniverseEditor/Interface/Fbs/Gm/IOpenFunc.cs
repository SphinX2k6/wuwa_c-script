using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x0200467B RID: 18043
	public struct IOpenFunc : IFlatbufferObject
	{
		// Token: 0x17008020 RID: 32800
		// (get) Token: 0x0601B641 RID: 112193 RVA: 0x003E499A File Offset: 0x003E2B9A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B642 RID: 112194 RVA: 0x003E49A7 File Offset: 0x003E2BA7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B643 RID: 112195 RVA: 0x003E49B0 File Offset: 0x003E2BB0
		public static IOpenFunc GetRootAsIOpenFunc(ByteBuffer _bb)
		{
			return IOpenFunc.GetRootAsIOpenFunc(_bb, default(IOpenFunc));
		}

		// Token: 0x0601B644 RID: 112196 RVA: 0x003E49CC File Offset: 0x003E2BCC
		public static IOpenFunc GetRootAsIOpenFunc(ByteBuffer _bb, IOpenFunc obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B645 RID: 112197 RVA: 0x003E49E9 File Offset: 0x003E2BE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B646 RID: 112198 RVA: 0x003E49F8 File Offset: 0x003E2BF8
		public IOpenFunc __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008021 RID: 32801
		// (get) Token: 0x0601B647 RID: 112199 RVA: 0x003E4A08 File Offset: 0x003E2C08
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008022 RID: 32802
		// (get) Token: 0x0601B648 RID: 112200 RVA: 0x003E4A44 File Offset: 0x003E2C44
		public int FuncId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B649 RID: 112201 RVA: 0x003E4A80 File Offset: 0x003E2C80
		public static Offset<IOpenFunc> CreateIOpenFunc(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, int FuncId = 0)
		{
			builder.StartTable(2);
			IOpenFunc.AddFuncId(builder, FuncId);
			IOpenFunc.AddType(builder, Type);
			return IOpenFunc.EndIOpenFunc(builder);
		}

		// Token: 0x0601B64A RID: 112202 RVA: 0x003E4A9D File Offset: 0x003E2C9D
		public static void StartIOpenFunc(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601B64B RID: 112203 RVA: 0x003E4AA6 File Offset: 0x003E2CA6
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B64C RID: 112204 RVA: 0x003E4AB1 File Offset: 0x003E2CB1
		public static void AddFuncId(FlatBufferBuilder builder, int funcId)
		{
			builder.AddInt(1, funcId, 0);
		}

		// Token: 0x0601B64D RID: 112205 RVA: 0x003E4ABC File Offset: 0x003E2CBC
		public static Offset<IOpenFunc> EndIOpenFunc(FlatBufferBuilder builder)
		{
			return new Offset<IOpenFunc>(builder.EndTable());
		}

		// Token: 0x0601B64E RID: 112206 RVA: 0x003E4ACC File Offset: 0x003E2CCC
		public IOpenFuncT UnPack()
		{
			IOpenFuncT openFuncT = new IOpenFuncT();
			this.UnPackTo(openFuncT);
			return openFuncT;
		}

		// Token: 0x0601B64F RID: 112207 RVA: 0x003E4AE7 File Offset: 0x003E2CE7
		public void UnPackTo(IOpenFuncT _o)
		{
			_o.Type = this.Type;
			_o.FuncId = this.FuncId;
		}

		// Token: 0x0601B650 RID: 112208 RVA: 0x003E4B04 File Offset: 0x003E2D04
		public static Offset<IOpenFunc> Pack(FlatBufferBuilder builder, IOpenFuncT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenFunc>);
			}
			return IOpenFunc.CreateIOpenFunc(builder, _o.Type, _o.FuncId);
		}

		// Token: 0x0400C83E RID: 51262
		private Table __p;
	}
}
