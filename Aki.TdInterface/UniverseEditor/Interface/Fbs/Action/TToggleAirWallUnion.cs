using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077DB RID: 30683
	public class TToggleAirWallUnion
	{
		// Token: 0x1700E6D5 RID: 59093
		// (get) Token: 0x06037A82 RID: 227970 RVA: 0x00786CFC File Offset: 0x00784EFC
		// (set) Token: 0x06037A83 RID: 227971 RVA: 0x00786D04 File Offset: 0x00784F04
		public TToggleAirWall Type { get; set; }

		// Token: 0x1700E6D6 RID: 59094
		// (get) Token: 0x06037A84 RID: 227972 RVA: 0x00786D0D File Offset: 0x00784F0D
		// (set) Token: 0x06037A85 RID: 227973 RVA: 0x00786D15 File Offset: 0x00784F15
		public object Value { get; set; }

		// Token: 0x06037A86 RID: 227974 RVA: 0x00786D1E File Offset: 0x00784F1E
		public TToggleAirWallUnion()
		{
			this.Type = TToggleAirWall.NONE;
			this.Value = null;
		}

		// Token: 0x06037A87 RID: 227975 RVA: 0x00786D34 File Offset: 0x00784F34
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037A88 RID: 227976 RVA: 0x00786D46 File Offset: 0x00784F46
		public ICloseAirWallT AsICloseAirWall()
		{
			return this.As<ICloseAirWallT>();
		}

		// Token: 0x06037A89 RID: 227977 RVA: 0x00786D4E File Offset: 0x00784F4E
		public static TToggleAirWallUnion FromICloseAirWall(ICloseAirWallT _icloseairwall)
		{
			return new TToggleAirWallUnion
			{
				Type = TToggleAirWall.ICloseAirWall,
				Value = _icloseairwall
			};
		}

		// Token: 0x06037A8A RID: 227978 RVA: 0x00786D63 File Offset: 0x00784F63
		public IOpenAirWallT AsIOpenAirWall()
		{
			return this.As<IOpenAirWallT>();
		}

		// Token: 0x06037A8B RID: 227979 RVA: 0x00786D6B File Offset: 0x00784F6B
		public static TToggleAirWallUnion FromIOpenAirWall(IOpenAirWallT _iopenairwall)
		{
			return new TToggleAirWallUnion
			{
				Type = TToggleAirWall.IOpenAirWall,
				Value = _iopenairwall
			};
		}

		// Token: 0x06037A8C RID: 227980 RVA: 0x00786D80 File Offset: 0x00784F80
		public static int Pack(FlatBufferBuilder builder, TToggleAirWallUnion _o)
		{
			TToggleAirWall type = _o.Type;
			if (type == TToggleAirWall.ICloseAirWall)
			{
				return ICloseAirWall.Pack(builder, _o.AsICloseAirWall()).Value;
			}
			if (type != TToggleAirWall.IOpenAirWall)
			{
				return 0;
			}
			return IOpenAirWall.Pack(builder, _o.AsIOpenAirWall()).Value;
		}
	}
}
