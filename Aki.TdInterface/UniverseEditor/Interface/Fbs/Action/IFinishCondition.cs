using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E21 RID: 28193
	public struct IFinishCondition : IFlatbufferObject
	{
		// Token: 0x1700CEAB RID: 52907
		// (get) Token: 0x06030AFE RID: 199422 RVA: 0x0069BD76 File Offset: 0x00699F76
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030AFF RID: 199423 RVA: 0x0069BD83 File Offset: 0x00699F83
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030B00 RID: 199424 RVA: 0x0069BD8C File Offset: 0x00699F8C
		public static IFinishCondition GetRootAsIFinishCondition(ByteBuffer _bb)
		{
			return IFinishCondition.GetRootAsIFinishCondition(_bb, default(IFinishCondition));
		}

		// Token: 0x06030B01 RID: 199425 RVA: 0x0069BDA8 File Offset: 0x00699FA8
		public static IFinishCondition GetRootAsIFinishCondition(ByteBuffer _bb, IFinishCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030B02 RID: 199426 RVA: 0x0069BDC5 File Offset: 0x00699FC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030B03 RID: 199427 RVA: 0x0069BDD4 File Offset: 0x00699FD4
		public IFinishCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06030B04 RID: 199428 RVA: 0x0069BDE4 File Offset: 0x00699FE4
		public static void StartIFinishCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x06030B05 RID: 199429 RVA: 0x0069BDED File Offset: 0x00699FED
		public static Offset<IFinishCondition> EndIFinishCondition(FlatBufferBuilder builder)
		{
			return new Offset<IFinishCondition>(builder.EndTable());
		}

		// Token: 0x06030B06 RID: 199430 RVA: 0x0069BDFC File Offset: 0x00699FFC
		public IFinishConditionT UnPack()
		{
			IFinishConditionT finishConditionT = new IFinishConditionT();
			this.UnPackTo(finishConditionT);
			return finishConditionT;
		}

		// Token: 0x06030B07 RID: 199431 RVA: 0x0069BE17 File Offset: 0x0069A017
		public void UnPackTo(IFinishConditionT _o)
		{
		}

		// Token: 0x06030B08 RID: 199432 RVA: 0x0069BE1C File Offset: 0x0069A01C
		public static Offset<IFinishCondition> Pack(FlatBufferBuilder builder, IFinishConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFinishCondition>);
			}
			IFinishCondition.StartIFinishCondition(builder);
			return IFinishCondition.EndIFinishCondition(builder);
		}

		// Token: 0x04011CE6 RID: 72934
		private Table __p;
	}
}
