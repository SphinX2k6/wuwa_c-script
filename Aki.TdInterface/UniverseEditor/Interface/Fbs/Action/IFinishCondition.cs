using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067A1 RID: 26529
	public struct IFinishCondition : IFlatbufferObject
	{
		// Token: 0x1700C4F5 RID: 50421
		// (get) Token: 0x0602E2B8 RID: 189112 RVA: 0x0064E632 File Offset: 0x0064C832
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E2B9 RID: 189113 RVA: 0x0064E63F File Offset: 0x0064C83F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E2BA RID: 189114 RVA: 0x0064E648 File Offset: 0x0064C848
		public static IFinishCondition GetRootAsIFinishCondition(ByteBuffer _bb)
		{
			return IFinishCondition.GetRootAsIFinishCondition(_bb, default(IFinishCondition));
		}

		// Token: 0x0602E2BB RID: 189115 RVA: 0x0064E664 File Offset: 0x0064C864
		public static IFinishCondition GetRootAsIFinishCondition(ByteBuffer _bb, IFinishCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E2BC RID: 189116 RVA: 0x0064E681 File Offset: 0x0064C881
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E2BD RID: 189117 RVA: 0x0064E690 File Offset: 0x0064C890
		public IFinishCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602E2BE RID: 189118 RVA: 0x0064E6A0 File Offset: 0x0064C8A0
		public static void StartIFinishCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0602E2BF RID: 189119 RVA: 0x0064E6A9 File Offset: 0x0064C8A9
		public static Offset<IFinishCondition> EndIFinishCondition(FlatBufferBuilder builder)
		{
			return new Offset<IFinishCondition>(builder.EndTable());
		}

		// Token: 0x0602E2C0 RID: 189120 RVA: 0x0064E6B8 File Offset: 0x0064C8B8
		public IFinishConditionT UnPack()
		{
			IFinishConditionT finishConditionT = new IFinishConditionT();
			this.UnPackTo(finishConditionT);
			return finishConditionT;
		}

		// Token: 0x0602E2C1 RID: 189121 RVA: 0x0064E6D3 File Offset: 0x0064C8D3
		public void UnPackTo(IFinishConditionT _o)
		{
		}

		// Token: 0x0602E2C2 RID: 189122 RVA: 0x0064E6D8 File Offset: 0x0064C8D8
		public static Offset<IFinishCondition> Pack(FlatBufferBuilder builder, IFinishConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFinishCondition>);
			}
			IFinishCondition.StartIFinishCondition(builder);
			return IFinishCondition.EndIFinishCondition(builder);
		}

		// Token: 0x04010EB4 RID: 69300
		private Table __p;
	}
}
