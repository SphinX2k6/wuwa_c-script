using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AE3 RID: 19171
	public struct IOpenFunc : IFlatbufferObject
	{
		// Token: 0x17008661 RID: 34401
		// (get) Token: 0x0601CE16 RID: 118294 RVA: 0x00410C36 File Offset: 0x0040EE36
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CE17 RID: 118295 RVA: 0x00410C43 File Offset: 0x0040EE43
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CE18 RID: 118296 RVA: 0x00410C4C File Offset: 0x0040EE4C
		public static IOpenFunc GetRootAsIOpenFunc(ByteBuffer _bb)
		{
			return IOpenFunc.GetRootAsIOpenFunc(_bb, default(IOpenFunc));
		}

		// Token: 0x0601CE19 RID: 118297 RVA: 0x00410C68 File Offset: 0x0040EE68
		public static IOpenFunc GetRootAsIOpenFunc(ByteBuffer _bb, IOpenFunc obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CE1A RID: 118298 RVA: 0x00410C85 File Offset: 0x0040EE85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CE1B RID: 118299 RVA: 0x00410C94 File Offset: 0x0040EE94
		public IOpenFunc __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008662 RID: 34402
		// (get) Token: 0x0601CE1C RID: 118300 RVA: 0x00410CA4 File Offset: 0x0040EEA4
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

		// Token: 0x17008663 RID: 34403
		// (get) Token: 0x0601CE1D RID: 118301 RVA: 0x00410CE0 File Offset: 0x0040EEE0
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

		// Token: 0x0601CE1E RID: 118302 RVA: 0x00410D1C File Offset: 0x0040EF1C
		public static Offset<IOpenFunc> CreateIOpenFunc(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, int FuncId = 0)
		{
			builder.StartTable(2);
			IOpenFunc.AddFuncId(builder, FuncId);
			IOpenFunc.AddType(builder, Type);
			return IOpenFunc.EndIOpenFunc(builder);
		}

		// Token: 0x0601CE1F RID: 118303 RVA: 0x00410D39 File Offset: 0x0040EF39
		public static void StartIOpenFunc(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601CE20 RID: 118304 RVA: 0x00410D42 File Offset: 0x0040EF42
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CE21 RID: 118305 RVA: 0x00410D4D File Offset: 0x0040EF4D
		public static void AddFuncId(FlatBufferBuilder builder, int funcId)
		{
			builder.AddInt(1, funcId, 0);
		}

		// Token: 0x0601CE22 RID: 118306 RVA: 0x00410D58 File Offset: 0x0040EF58
		public static Offset<IOpenFunc> EndIOpenFunc(FlatBufferBuilder builder)
		{
			return new Offset<IOpenFunc>(builder.EndTable());
		}

		// Token: 0x0601CE23 RID: 118307 RVA: 0x00410D68 File Offset: 0x0040EF68
		public IOpenFuncT UnPack()
		{
			IOpenFuncT openFuncT = new IOpenFuncT();
			this.UnPackTo(openFuncT);
			return openFuncT;
		}

		// Token: 0x0601CE24 RID: 118308 RVA: 0x00410D83 File Offset: 0x0040EF83
		public void UnPackTo(IOpenFuncT _o)
		{
			_o.Type = this.Type;
			_o.FuncId = this.FuncId;
		}

		// Token: 0x0601CE25 RID: 118309 RVA: 0x00410DA0 File Offset: 0x0040EFA0
		public static Offset<IOpenFunc> Pack(FlatBufferBuilder builder, IOpenFuncT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenFunc>);
			}
			return IOpenFunc.CreateIOpenFunc(builder, _o.Type, _o.FuncId);
		}

		// Token: 0x0400D26D RID: 53869
		private Table __p;
	}
}
