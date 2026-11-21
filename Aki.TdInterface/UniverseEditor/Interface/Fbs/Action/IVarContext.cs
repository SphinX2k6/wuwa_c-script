using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CE6 RID: 31974
	public struct IVarContext : IFlatbufferObject
	{
		// Token: 0x1700EF54 RID: 61268
		// (get) Token: 0x06039B0A RID: 236298 RVA: 0x007C876E File Offset: 0x007C696E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039B0B RID: 236299 RVA: 0x007C877B File Offset: 0x007C697B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039B0C RID: 236300 RVA: 0x007C8784 File Offset: 0x007C6984
		public static IVarContext GetRootAsIVarContext(ByteBuffer _bb)
		{
			return IVarContext.GetRootAsIVarContext(_bb, default(IVarContext));
		}

		// Token: 0x06039B0D RID: 236301 RVA: 0x007C87A0 File Offset: 0x007C69A0
		public static IVarContext GetRootAsIVarContext(ByteBuffer _bb, IVarContext obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039B0E RID: 236302 RVA: 0x007C87BD File Offset: 0x007C69BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039B0F RID: 236303 RVA: 0x007C87CC File Offset: 0x007C69CC
		public IVarContext __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EF55 RID: 61269
		// (get) Token: 0x06039B10 RID: 236304 RVA: 0x007C87DC File Offset: 0x007C69DC
		public EVarContext Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVarContext.None;
				}
				return (EVarContext)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06039B11 RID: 236305 RVA: 0x007C8818 File Offset: 0x007C6A18
		public static Offset<IVarContext> CreateIVarContext(FlatBufferBuilder builder, EVarContext Type = EVarContext.None)
		{
			builder.StartTable(1);
			IVarContext.AddType(builder, Type);
			return IVarContext.EndIVarContext(builder);
		}

		// Token: 0x06039B12 RID: 236306 RVA: 0x007C882E File Offset: 0x007C6A2E
		public static void StartIVarContext(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06039B13 RID: 236307 RVA: 0x007C8837 File Offset: 0x007C6A37
		public static void AddType(FlatBufferBuilder builder, EVarContext type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039B14 RID: 236308 RVA: 0x007C8842 File Offset: 0x007C6A42
		public static Offset<IVarContext> EndIVarContext(FlatBufferBuilder builder)
		{
			return new Offset<IVarContext>(builder.EndTable());
		}

		// Token: 0x06039B15 RID: 236309 RVA: 0x007C8850 File Offset: 0x007C6A50
		public IVarContextT UnPack()
		{
			IVarContextT varContextT = new IVarContextT();
			this.UnPackTo(varContextT);
			return varContextT;
		}

		// Token: 0x06039B16 RID: 236310 RVA: 0x007C886B File Offset: 0x007C6A6B
		public void UnPackTo(IVarContextT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06039B17 RID: 236311 RVA: 0x007C887C File Offset: 0x007C6A7C
		public static Offset<IVarContext> Pack(FlatBufferBuilder builder, IVarContextT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVarContext>);
			}
			return IVarContext.CreateIVarContext(builder, _o.Type);
		}

		// Token: 0x040133F6 RID: 78838
		private Table __p;
	}
}
