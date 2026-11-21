using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x0200483B RID: 18491
	public class TRefSourceDataUnion
	{
		// Token: 0x170080FF RID: 33023
		// (get) Token: 0x0601B615 RID: 112149 RVA: 0x003E09BC File Offset: 0x003DEBBC
		// (set) Token: 0x0601B616 RID: 112150 RVA: 0x003E09C4 File Offset: 0x003DEBC4
		public TRefSourceData Type { get; set; }

		// Token: 0x17008100 RID: 33024
		// (get) Token: 0x0601B617 RID: 112151 RVA: 0x003E09CD File Offset: 0x003DEBCD
		// (set) Token: 0x0601B618 RID: 112152 RVA: 0x003E09D5 File Offset: 0x003DEBD5
		public object Value { get; set; }

		// Token: 0x0601B619 RID: 112153 RVA: 0x003E09DE File Offset: 0x003DEBDE
		public TRefSourceDataUnion()
		{
			this.Type = TRefSourceData.NONE;
			this.Value = null;
		}

		// Token: 0x0601B61A RID: 112154 RVA: 0x003E09F4 File Offset: 0x003DEBF4
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601B61B RID: 112155 RVA: 0x003E0A06 File Offset: 0x003DEC06
		public IAwakeEntityRefSourceT AsIAwakeEntityRefSource()
		{
			return this.As<IAwakeEntityRefSourceT>();
		}

		// Token: 0x0601B61C RID: 112156 RVA: 0x003E0A0E File Offset: 0x003DEC0E
		public static TRefSourceDataUnion FromIAwakeEntityRefSource(IAwakeEntityRefSourceT _iawakeentityrefsource)
		{
			return new TRefSourceDataUnion
			{
				Type = TRefSourceData.IAwakeEntityRefSource,
				Value = _iawakeentityrefsource
			};
		}

		// Token: 0x0601B61D RID: 112157 RVA: 0x003E0A23 File Offset: 0x003DEC23
		public IDestroyEntityRefSourceT AsIDestroyEntityRefSource()
		{
			return this.As<IDestroyEntityRefSourceT>();
		}

		// Token: 0x0601B61E RID: 112158 RVA: 0x003E0A2B File Offset: 0x003DEC2B
		public static TRefSourceDataUnion FromIDestroyEntityRefSource(IDestroyEntityRefSourceT _idestroyentityrefsource)
		{
			return new TRefSourceDataUnion
			{
				Type = TRefSourceData.IDestroyEntityRefSource,
				Value = _idestroyentityrefsource
			};
		}

		// Token: 0x0601B61F RID: 112159 RVA: 0x003E0A40 File Offset: 0x003DEC40
		public IManualOccupationRefSourceT AsIManualOccupationRefSource()
		{
			return this.As<IManualOccupationRefSourceT>();
		}

		// Token: 0x0601B620 RID: 112160 RVA: 0x003E0A48 File Offset: 0x003DEC48
		public static TRefSourceDataUnion FromIManualOccupationRefSource(IManualOccupationRefSourceT _imanualoccupationrefsource)
		{
			return new TRefSourceDataUnion
			{
				Type = TRefSourceData.IManualOccupationRefSource,
				Value = _imanualoccupationrefsource
			};
		}

		// Token: 0x0601B621 RID: 112161 RVA: 0x003E0A60 File Offset: 0x003DEC60
		public static int Pack(FlatBufferBuilder builder, TRefSourceDataUnion _o)
		{
			switch (_o.Type)
			{
			case TRefSourceData.IAwakeEntityRefSource:
				return IAwakeEntityRefSource.Pack(builder, _o.AsIAwakeEntityRefSource()).Value;
			case TRefSourceData.IDestroyEntityRefSource:
				return IDestroyEntityRefSource.Pack(builder, _o.AsIDestroyEntityRefSource()).Value;
			case TRefSourceData.IManualOccupationRefSource:
				return IManualOccupationRefSource.Pack(builder, _o.AsIManualOccupationRefSource()).Value;
			default:
				return 0;
			}
		}
	}
}
