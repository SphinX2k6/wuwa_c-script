using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B9E RID: 23454
	public class INoiseRemovalBoarderBase_UnionUnion
	{
		// Token: 0x1700AB6D RID: 43885
		// (get) Token: 0x06026A81 RID: 158337 RVA: 0x0054ADB5 File Offset: 0x00548FB5
		// (set) Token: 0x06026A82 RID: 158338 RVA: 0x0054ADBD File Offset: 0x00548FBD
		public INoiseRemovalBoarderBase_Union Type { get; set; }

		// Token: 0x1700AB6E RID: 43886
		// (get) Token: 0x06026A83 RID: 158339 RVA: 0x0054ADC6 File Offset: 0x00548FC6
		// (set) Token: 0x06026A84 RID: 158340 RVA: 0x0054ADCE File Offset: 0x00548FCE
		public object Value { get; set; }

		// Token: 0x06026A85 RID: 158341 RVA: 0x0054ADD7 File Offset: 0x00548FD7
		public INoiseRemovalBoarderBase_UnionUnion()
		{
			this.Type = INoiseRemovalBoarderBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06026A86 RID: 158342 RVA: 0x0054ADED File Offset: 0x00548FED
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06026A87 RID: 158343 RVA: 0x0054ADFF File Offset: 0x00548FFF
		public INoiseRemovalBoarderBaseT AsINoiseRemovalBoarderBase()
		{
			return this.As<INoiseRemovalBoarderBaseT>();
		}

		// Token: 0x06026A88 RID: 158344 RVA: 0x0054AE07 File Offset: 0x00549007
		public static INoiseRemovalBoarderBase_UnionUnion FromINoiseRemovalBoarderBase(INoiseRemovalBoarderBaseT _inoiseremovalboarderbase)
		{
			return new INoiseRemovalBoarderBase_UnionUnion
			{
				Type = INoiseRemovalBoarderBase_Union.INoiseRemovalBoarderBase,
				Value = _inoiseremovalboarderbase
			};
		}

		// Token: 0x06026A89 RID: 158345 RVA: 0x0054AE1C File Offset: 0x0054901C
		public INoiseRemovalBoxBoarderT AsINoiseRemovalBoxBoarder()
		{
			return this.As<INoiseRemovalBoxBoarderT>();
		}

		// Token: 0x06026A8A RID: 158346 RVA: 0x0054AE24 File Offset: 0x00549024
		public static INoiseRemovalBoarderBase_UnionUnion FromINoiseRemovalBoxBoarder(INoiseRemovalBoxBoarderT _inoiseremovalboxboarder)
		{
			return new INoiseRemovalBoarderBase_UnionUnion
			{
				Type = INoiseRemovalBoarderBase_Union.INoiseRemovalBoxBoarder,
				Value = _inoiseremovalboxboarder
			};
		}

		// Token: 0x06026A8B RID: 158347 RVA: 0x0054AE39 File Offset: 0x00549039
		public INoiseRemovalSphereBoarderT AsINoiseRemovalSphereBoarder()
		{
			return this.As<INoiseRemovalSphereBoarderT>();
		}

		// Token: 0x06026A8C RID: 158348 RVA: 0x0054AE41 File Offset: 0x00549041
		public static INoiseRemovalBoarderBase_UnionUnion FromINoiseRemovalSphereBoarder(INoiseRemovalSphereBoarderT _inoiseremovalsphereboarder)
		{
			return new INoiseRemovalBoarderBase_UnionUnion
			{
				Type = INoiseRemovalBoarderBase_Union.INoiseRemovalSphereBoarder,
				Value = _inoiseremovalsphereboarder
			};
		}

		// Token: 0x06026A8D RID: 158349 RVA: 0x0054AE58 File Offset: 0x00549058
		public static int Pack(FlatBufferBuilder builder, INoiseRemovalBoarderBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case INoiseRemovalBoarderBase_Union.INoiseRemovalBoarderBase:
				return INoiseRemovalBoarderBase.Pack(builder, _o.AsINoiseRemovalBoarderBase()).Value;
			case INoiseRemovalBoarderBase_Union.INoiseRemovalBoxBoarder:
				return INoiseRemovalBoxBoarder.Pack(builder, _o.AsINoiseRemovalBoxBoarder()).Value;
			case INoiseRemovalBoarderBase_Union.INoiseRemovalSphereBoarder:
				return INoiseRemovalSphereBoarder.Pack(builder, _o.AsINoiseRemovalSphereBoarder()).Value;
			default:
				return 0;
			}
		}
	}
}
