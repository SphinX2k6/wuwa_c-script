using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049BA RID: 18874
	public class IRollBlockBase_UnionUnion
	{
		// Token: 0x17008421 RID: 33825
		// (get) Token: 0x0601C31E RID: 115486 RVA: 0x003FB1C2 File Offset: 0x003F93C2
		// (set) Token: 0x0601C31F RID: 115487 RVA: 0x003FB1CA File Offset: 0x003F93CA
		public IRollBlockBase_Union Type { get; set; }

		// Token: 0x17008422 RID: 33826
		// (get) Token: 0x0601C320 RID: 115488 RVA: 0x003FB1D3 File Offset: 0x003F93D3
		// (set) Token: 0x0601C321 RID: 115489 RVA: 0x003FB1DB File Offset: 0x003F93DB
		public object Value { get; set; }

		// Token: 0x0601C322 RID: 115490 RVA: 0x003FB1E4 File Offset: 0x003F93E4
		public IRollBlockBase_UnionUnion()
		{
			this.Type = IRollBlockBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601C323 RID: 115491 RVA: 0x003FB1FA File Offset: 0x003F93FA
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601C324 RID: 115492 RVA: 0x003FB20C File Offset: 0x003F940C
		public IRollBlockBaseT AsIRollBlockBase()
		{
			return this.As<IRollBlockBaseT>();
		}

		// Token: 0x0601C325 RID: 115493 RVA: 0x003FB214 File Offset: 0x003F9414
		public static IRollBlockBase_UnionUnion FromIRollBlockBase(IRollBlockBaseT _irollblockbase)
		{
			return new IRollBlockBase_UnionUnion
			{
				Type = IRollBlockBase_Union.IRollBlockBase,
				Value = _irollblockbase
			};
		}

		// Token: 0x0601C326 RID: 115494 RVA: 0x003FB229 File Offset: 0x003F9429
		public IRollBlock1T AsIRollBlock1()
		{
			return this.As<IRollBlock1T>();
		}

		// Token: 0x0601C327 RID: 115495 RVA: 0x003FB231 File Offset: 0x003F9431
		public static IRollBlockBase_UnionUnion FromIRollBlock1(IRollBlock1T _irollblock1)
		{
			return new IRollBlockBase_UnionUnion
			{
				Type = IRollBlockBase_Union.IRollBlock1,
				Value = _irollblock1
			};
		}

		// Token: 0x0601C328 RID: 115496 RVA: 0x003FB246 File Offset: 0x003F9446
		public IRollBlock2T AsIRollBlock2()
		{
			return this.As<IRollBlock2T>();
		}

		// Token: 0x0601C329 RID: 115497 RVA: 0x003FB24E File Offset: 0x003F944E
		public static IRollBlockBase_UnionUnion FromIRollBlock2(IRollBlock2T _irollblock2)
		{
			return new IRollBlockBase_UnionUnion
			{
				Type = IRollBlockBase_Union.IRollBlock2,
				Value = _irollblock2
			};
		}

		// Token: 0x0601C32A RID: 115498 RVA: 0x003FB264 File Offset: 0x003F9464
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
