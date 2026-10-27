using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x02004760 RID: 18272
	public struct IHighPerformanceMode : IFlatbufferObject
	{
		// Token: 0x17008318 RID: 33560
		// (get) Token: 0x0601C20D RID: 115213 RVA: 0x003FC35F File Offset: 0x003FA55F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C20E RID: 115214 RVA: 0x003FC36C File Offset: 0x003FA56C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C20F RID: 115215 RVA: 0x003FC374 File Offset: 0x003FA574
		public static IHighPerformanceMode GetRootAsIHighPerformanceMode(ByteBuffer _bb)
		{
			return IHighPerformanceMode.GetRootAsIHighPerformanceMode(_bb, default(IHighPerformanceMode));
		}

		// Token: 0x0601C210 RID: 115216 RVA: 0x003FC390 File Offset: 0x003FA590
		public static IHighPerformanceMode GetRootAsIHighPerformanceMode(ByteBuffer _bb, IHighPerformanceMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C211 RID: 115217 RVA: 0x003FC3AD File Offset: 0x003FA5AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C212 RID: 115218 RVA: 0x003FC3BC File Offset: 0x003FA5BC
		public IHighPerformanceMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008319 RID: 33561
		// (get) Token: 0x0601C213 RID: 115219 RVA: 0x003FC3CC File Offset: 0x003FA5CC
		public EPerformanceMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPerformanceMode.High;
				}
				return (EPerformanceMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C214 RID: 115220 RVA: 0x003FC408 File Offset: 0x003FA608
		public static Offset<IHighPerformanceMode> CreateIHighPerformanceMode(FlatBufferBuilder builder, EPerformanceMode Type = EPerformanceMode.High)
		{
			builder.StartTable(1);
			IHighPerformanceMode.AddType(builder, Type);
			return IHighPerformanceMode.EndIHighPerformanceMode(builder);
		}

		// Token: 0x0601C215 RID: 115221 RVA: 0x003FC41E File Offset: 0x003FA61E
		public static void StartIHighPerformanceMode(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601C216 RID: 115222 RVA: 0x003FC427 File Offset: 0x003FA627
		public static void AddType(FlatBufferBuilder builder, EPerformanceMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C217 RID: 115223 RVA: 0x003FC432 File Offset: 0x003FA632
		public static Offset<IHighPerformanceMode> EndIHighPerformanceMode(FlatBufferBuilder builder)
		{
			return new Offset<IHighPerformanceMode>(builder.EndTable());
		}

		// Token: 0x0601C218 RID: 115224 RVA: 0x003FC440 File Offset: 0x003FA640
		public IHighPerformanceModeT UnPack()
		{
			IHighPerformanceModeT highPerformanceModeT = new IHighPerformanceModeT();
			this.UnPackTo(highPerformanceModeT);
			return highPerformanceModeT;
		}

		// Token: 0x0601C219 RID: 115225 RVA: 0x003FC45B File Offset: 0x003FA65B
		public void UnPackTo(IHighPerformanceModeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601C21A RID: 115226 RVA: 0x003FC46C File Offset: 0x003FA66C
		public static Offset<IHighPerformanceMode> Pack(FlatBufferBuilder builder, IHighPerformanceModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHighPerformanceMode>);
			}
			return IHighPerformanceMode.CreateIHighPerformanceMode(builder, _o.Type);
		}

		// Token: 0x0400CA60 RID: 51808
		private Table __p;
	}
}
