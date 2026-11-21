using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006295 RID: 25237
	public class TNoiseRemovalBoarderUnion
	{
		// Token: 0x1700BB7A RID: 47994
		// (get) Token: 0x0602AECF RID: 175823 RVA: 0x005DB834 File Offset: 0x005D9A34
		// (set) Token: 0x0602AED0 RID: 175824 RVA: 0x005DB83C File Offset: 0x005D9A3C
		public TNoiseRemovalBoarder Type { get; set; }

		// Token: 0x1700BB7B RID: 47995
		// (get) Token: 0x0602AED1 RID: 175825 RVA: 0x005DB845 File Offset: 0x005D9A45
		// (set) Token: 0x0602AED2 RID: 175826 RVA: 0x005DB84D File Offset: 0x005D9A4D
		public object Value { get; set; }

		// Token: 0x0602AED3 RID: 175827 RVA: 0x005DB856 File Offset: 0x005D9A56
		public TNoiseRemovalBoarderUnion()
		{
			this.Type = TNoiseRemovalBoarder.NONE;
			this.Value = null;
		}

		// Token: 0x0602AED4 RID: 175828 RVA: 0x005DB86C File Offset: 0x005D9A6C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AED5 RID: 175829 RVA: 0x005DB87E File Offset: 0x005D9A7E
		public INoiseRemovalBoxBoarderT AsINoiseRemovalBoxBoarder()
		{
			return this.As<INoiseRemovalBoxBoarderT>();
		}

		// Token: 0x0602AED6 RID: 175830 RVA: 0x005DB886 File Offset: 0x005D9A86
		public static TNoiseRemovalBoarderUnion FromINoiseRemovalBoxBoarder(INoiseRemovalBoxBoarderT _inoiseremovalboxboarder)
		{
			return new TNoiseRemovalBoarderUnion
			{
				Type = TNoiseRemovalBoarder.INoiseRemovalBoxBoarder,
				Value = _inoiseremovalboxboarder
			};
		}

		// Token: 0x0602AED7 RID: 175831 RVA: 0x005DB89B File Offset: 0x005D9A9B
		public INoiseRemovalSphereBoarderT AsINoiseRemovalSphereBoarder()
		{
			return this.As<INoiseRemovalSphereBoarderT>();
		}

		// Token: 0x0602AED8 RID: 175832 RVA: 0x005DB8A3 File Offset: 0x005D9AA3
		public static TNoiseRemovalBoarderUnion FromINoiseRemovalSphereBoarder(INoiseRemovalSphereBoarderT _inoiseremovalsphereboarder)
		{
			return new TNoiseRemovalBoarderUnion
			{
				Type = TNoiseRemovalBoarder.INoiseRemovalSphereBoarder,
				Value = _inoiseremovalsphereboarder
			};
		}

		// Token: 0x0602AED9 RID: 175833 RVA: 0x005DB8B8 File Offset: 0x005D9AB8
		public static int Pack(FlatBufferBuilder builder, TNoiseRemovalBoarderUnion _o)
		{
			TNoiseRemovalBoarder type = _o.Type;
			if (type == TNoiseRemovalBoarder.INoiseRemovalBoxBoarder)
			{
				return INoiseRemovalBoxBoarder.Pack(builder, _o.AsINoiseRemovalBoxBoarder()).Value;
			}
			if (type != TNoiseRemovalBoarder.INoiseRemovalSphereBoarder)
			{
				return 0;
			}
			return INoiseRemovalSphereBoarder.Pack(builder, _o.AsINoiseRemovalSphereBoarder()).Value;
		}
	}
}
