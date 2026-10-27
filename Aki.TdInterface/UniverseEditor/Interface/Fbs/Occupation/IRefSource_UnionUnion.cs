using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043C3 RID: 17347
	public class IRefSource_UnionUnion
	{
		// Token: 0x17007AAB RID: 31403
		// (get) Token: 0x06019DD0 RID: 105936 RVA: 0x003B3BC9 File Offset: 0x003B1DC9
		// (set) Token: 0x06019DD1 RID: 105937 RVA: 0x003B3BD1 File Offset: 0x003B1DD1
		public IRefSource_Union Type { get; set; }

		// Token: 0x17007AAC RID: 31404
		// (get) Token: 0x06019DD2 RID: 105938 RVA: 0x003B3BDA File Offset: 0x003B1DDA
		// (set) Token: 0x06019DD3 RID: 105939 RVA: 0x003B3BE2 File Offset: 0x003B1DE2
		public object Value { get; set; }

		// Token: 0x06019DD4 RID: 105940 RVA: 0x003B3BEB File Offset: 0x003B1DEB
		public IRefSource_UnionUnion()
		{
			this.Type = IRefSource_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06019DD5 RID: 105941 RVA: 0x003B3C01 File Offset: 0x003B1E01
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06019DD6 RID: 105942 RVA: 0x003B3C13 File Offset: 0x003B1E13
		public IRefSourceT AsIRefSource()
		{
			return this.As<IRefSourceT>();
		}

		// Token: 0x06019DD7 RID: 105943 RVA: 0x003B3C1B File Offset: 0x003B1E1B
		public static IRefSource_UnionUnion FromIRefSource(IRefSourceT _irefsource)
		{
			return new IRefSource_UnionUnion
			{
				Type = IRefSource_Union.IRefSource,
				Value = _irefsource
			};
		}

		// Token: 0x06019DD8 RID: 105944 RVA: 0x003B3C30 File Offset: 0x003B1E30
		public IAwakeEntityRefSourceT AsIAwakeEntityRefSource()
		{
			return this.As<IAwakeEntityRefSourceT>();
		}

		// Token: 0x06019DD9 RID: 105945 RVA: 0x003B3C38 File Offset: 0x003B1E38
		public static IRefSource_UnionUnion FromIAwakeEntityRefSource(IAwakeEntityRefSourceT _iawakeentityrefsource)
		{
			return new IRefSource_UnionUnion
			{
				Type = IRefSource_Union.IAwakeEntityRefSource,
				Value = _iawakeentityrefsource
			};
		}

		// Token: 0x06019DDA RID: 105946 RVA: 0x003B3C4D File Offset: 0x003B1E4D
		public IDestroyEntityRefSourceT AsIDestroyEntityRefSource()
		{
			return this.As<IDestroyEntityRefSourceT>();
		}

		// Token: 0x06019DDB RID: 105947 RVA: 0x003B3C55 File Offset: 0x003B1E55
		public static IRefSource_UnionUnion FromIDestroyEntityRefSource(IDestroyEntityRefSourceT _idestroyentityrefsource)
		{
			return new IRefSource_UnionUnion
			{
				Type = IRefSource_Union.IDestroyEntityRefSource,
				Value = _idestroyentityrefsource
			};
		}

		// Token: 0x06019DDC RID: 105948 RVA: 0x003B3C6A File Offset: 0x003B1E6A
		public IManualOccupationRefSourceT AsIManualOccupationRefSource()
		{
			return this.As<IManualOccupationRefSourceT>();
		}

		// Token: 0x06019DDD RID: 105949 RVA: 0x003B3C72 File Offset: 0x003B1E72
		public static IRefSource_UnionUnion FromIManualOccupationRefSource(IManualOccupationRefSourceT _imanualoccupationrefsource)
		{
			return new IRefSource_UnionUnion
			{
				Type = IRefSource_Union.IManualOccupationRefSource,
				Value = _imanualoccupationrefsource
			};
		}

		// Token: 0x06019DDE RID: 105950 RVA: 0x003B3C88 File Offset: 0x003B1E88
		public static int Pack(FlatBufferBuilder builder, IRefSource_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IRefSource_Union.IRefSource:
				return IRefSource.Pack(builder, _o.AsIRefSource()).Value;
			case IRefSource_Union.IAwakeEntityRefSource:
				return IAwakeEntityRefSource.Pack(builder, _o.AsIAwakeEntityRefSource()).Value;
			case IRefSource_Union.IDestroyEntityRefSource:
				return IDestroyEntityRefSource.Pack(builder, _o.AsIDestroyEntityRefSource()).Value;
			case IRefSource_Union.IManualOccupationRefSource:
				return IManualOccupationRefSource.Pack(builder, _o.AsIManualOccupationRefSource()).Value;
			default:
				return 0;
			}
		}
	}
}
