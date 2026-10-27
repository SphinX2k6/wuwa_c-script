using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006083 RID: 24707
	public struct IActionParams : IFlatbufferObject
	{
		// Token: 0x1700B621 RID: 46625
		// (get) Token: 0x06029DA4 RID: 171428 RVA: 0x005BDBA5 File Offset: 0x005BBDA5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029DA5 RID: 171429 RVA: 0x005BDBB2 File Offset: 0x005BBDB2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029DA6 RID: 171430 RVA: 0x005BDBBC File Offset: 0x005BBDBC
		public static IActionParams GetRootAsIActionParams(ByteBuffer _bb)
		{
			return IActionParams.GetRootAsIActionParams(_bb, default(IActionParams));
		}

		// Token: 0x06029DA7 RID: 171431 RVA: 0x005BDBD8 File Offset: 0x005BBDD8
		public static IActionParams GetRootAsIActionParams(ByteBuffer _bb, IActionParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029DA8 RID: 171432 RVA: 0x005BDBF5 File Offset: 0x005BBDF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029DA9 RID: 171433 RVA: 0x005BDC04 File Offset: 0x005BBE04
		public IActionParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06029DAA RID: 171434 RVA: 0x005BDC14 File Offset: 0x005BBE14
		public static void StartIActionParams(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x06029DAB RID: 171435 RVA: 0x005BDC1D File Offset: 0x005BBE1D
		public static Offset<IActionParams> EndIActionParams(FlatBufferBuilder builder)
		{
			return new Offset<IActionParams>(builder.EndTable());
		}

		// Token: 0x06029DAC RID: 171436 RVA: 0x005BDC2C File Offset: 0x005BBE2C
		public IActionParamsT UnPack()
		{
			IActionParamsT actionParamsT = new IActionParamsT();
			this.UnPackTo(actionParamsT);
			return actionParamsT;
		}

		// Token: 0x06029DAD RID: 171437 RVA: 0x005BDC47 File Offset: 0x005BBE47
		public void UnPackTo(IActionParamsT _o)
		{
		}

		// Token: 0x06029DAE RID: 171438 RVA: 0x005BDC4C File Offset: 0x005BBE4C
		public static Offset<IActionParams> Pack(FlatBufferBuilder builder, IActionParamsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActionParams>);
			}
			IActionParams.StartIActionParams(builder);
			return IActionParams.EndIActionParams(builder);
		}

		// Token: 0x0401025D RID: 66141
		private Table __p;
	}
}
