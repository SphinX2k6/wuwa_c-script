using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02008016 RID: 32790
	public class TToggleAirWallUnion
	{
		// Token: 0x1700F331 RID: 62257
		// (get) Token: 0x0603B015 RID: 241685 RVA: 0x007EC4AC File Offset: 0x007EA6AC
		// (set) Token: 0x0603B016 RID: 241686 RVA: 0x007EC4B4 File Offset: 0x007EA6B4
		public TToggleAirWall Type { get; set; }

		// Token: 0x1700F332 RID: 62258
		// (get) Token: 0x0603B017 RID: 241687 RVA: 0x007EC4BD File Offset: 0x007EA6BD
		// (set) Token: 0x0603B018 RID: 241688 RVA: 0x007EC4C5 File Offset: 0x007EA6C5
		public object Value { get; set; }

		// Token: 0x0603B019 RID: 241689 RVA: 0x007EC4CE File Offset: 0x007EA6CE
		public TToggleAirWallUnion()
		{
			this.Type = TToggleAirWall.NONE;
			this.Value = null;
		}

		// Token: 0x0603B01A RID: 241690 RVA: 0x007EC4E4 File Offset: 0x007EA6E4
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603B01B RID: 241691 RVA: 0x007EC4F6 File Offset: 0x007EA6F6
		public ICloseAirWallT AsICloseAirWall()
		{
			return this.As<ICloseAirWallT>();
		}

		// Token: 0x0603B01C RID: 241692 RVA: 0x007EC4FE File Offset: 0x007EA6FE
		public static TToggleAirWallUnion FromICloseAirWall(ICloseAirWallT _icloseairwall)
		{
			return new TToggleAirWallUnion
			{
				Type = TToggleAirWall.ICloseAirWall,
				Value = _icloseairwall
			};
		}

		// Token: 0x0603B01D RID: 241693 RVA: 0x007EC513 File Offset: 0x007EA713
		public IOpenAirWallT AsIOpenAirWall()
		{
			return this.As<IOpenAirWallT>();
		}

		// Token: 0x0603B01E RID: 241694 RVA: 0x007EC51B File Offset: 0x007EA71B
		public static TToggleAirWallUnion FromIOpenAirWall(IOpenAirWallT _iopenairwall)
		{
			return new TToggleAirWallUnion
			{
				Type = TToggleAirWall.IOpenAirWall,
				Value = _iopenairwall
			};
		}

		// Token: 0x0603B01F RID: 241695 RVA: 0x007EC530 File Offset: 0x007EA730
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
