using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004552 RID: 17746
	public class IRollBlockBase_UnionUnion
	{
		// Token: 0x17007DE0 RID: 32224
		// (get) Token: 0x0601AB49 RID: 109385 RVA: 0x003CEF26 File Offset: 0x003CD126
		// (set) Token: 0x0601AB4A RID: 109386 RVA: 0x003CEF2E File Offset: 0x003CD12E
		public IRollBlockBase_Union Type { get; set; }

		// Token: 0x17007DE1 RID: 32225
		// (get) Token: 0x0601AB4B RID: 109387 RVA: 0x003CEF37 File Offset: 0x003CD137
		// (set) Token: 0x0601AB4C RID: 109388 RVA: 0x003CEF3F File Offset: 0x003CD13F
		public object Value { get; set; }

		// Token: 0x0601AB4D RID: 109389 RVA: 0x003CEF48 File Offset: 0x003CD148
		public IRollBlockBase_UnionUnion()
		{
			this.Type = IRollBlockBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601AB4E RID: 109390 RVA: 0x003CEF5E File Offset: 0x003CD15E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AB4F RID: 109391 RVA: 0x003CEF70 File Offset: 0x003CD170
		public IRollBlockBaseT AsIRollBlockBase()
		{
			return this.As<IRollBlockBaseT>();
		}

		// Token: 0x0601AB50 RID: 109392 RVA: 0x003CEF78 File Offset: 0x003CD178
		public static IRollBlockBase_UnionUnion FromIRollBlockBase(IRollBlockBaseT _irollblockbase)
		{
			return new IRollBlockBase_UnionUnion
			{
				Type = IRollBlockBase_Union.IRollBlockBase,
				Value = _irollblockbase
			};
		}

		// Token: 0x0601AB51 RID: 109393 RVA: 0x003CEF8D File Offset: 0x003CD18D
		public IRollBlock1T AsIRollBlock1()
		{
			return this.As<IRollBlock1T>();
		}

		// Token: 0x0601AB52 RID: 109394 RVA: 0x003CEF95 File Offset: 0x003CD195
		public static IRollBlockBase_UnionUnion FromIRollBlock1(IRollBlock1T _irollblock1)
		{
			return new IRollBlockBase_UnionUnion
			{
				Type = IRollBlockBase_Union.IRollBlock1,
				Value = _irollblock1
			};
		}

		// Token: 0x0601AB53 RID: 109395 RVA: 0x003CEFAA File Offset: 0x003CD1AA
		public IRollBlock2T AsIRollBlock2()
		{
			return this.As<IRollBlock2T>();
		}

		// Token: 0x0601AB54 RID: 109396 RVA: 0x003CEFB2 File Offset: 0x003CD1B2
		public static IRollBlockBase_UnionUnion FromIRollBlock2(IRollBlock2T _irollblock2)
		{
			return new IRollBlockBase_UnionUnion
			{
				Type = IRollBlockBase_Union.IRollBlock2,
				Value = _irollblock2
			};
		}

		// Token: 0x0601AB55 RID: 109397 RVA: 0x003CEFC8 File Offset: 0x003CD1C8
		public static int Pack(FlatBufferBuilder builder, IRollBlockBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IRollBlockBase_Union.IRollBlockBase:
				return IRollBlockBase.Pack(builder, _o.AsIRollBlockBase()).Value;
			case IRollBlockBase_Union.IRollBlock1:
				return IRollBlock1.Pack(builder, _o.AsIRollBlock1()).Value;
			case IRollBlockBase_Union.IRollBlock2:
				return IRollBlock2.Pack(builder, _o.AsIRollBlock2()).Value;
			default:
				return 0;
			}
		}
	}
}
