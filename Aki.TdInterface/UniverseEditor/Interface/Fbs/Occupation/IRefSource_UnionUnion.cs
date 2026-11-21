using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x02004825 RID: 18469
	public class IRefSource_UnionUnion
	{
		// Token: 0x170080E2 RID: 32994
		// (get) Token: 0x0601B56B RID: 111979 RVA: 0x003DF861 File Offset: 0x003DDA61
		// (set) Token: 0x0601B56C RID: 111980 RVA: 0x003DF869 File Offset: 0x003DDA69
		public IRefSource_Union Type { get; set; }

		// Token: 0x170080E3 RID: 32995
		// (get) Token: 0x0601B56D RID: 111981 RVA: 0x003DF872 File Offset: 0x003DDA72
		// (set) Token: 0x0601B56E RID: 111982 RVA: 0x003DF87A File Offset: 0x003DDA7A
		public object Value { get; set; }

		// Token: 0x0601B56F RID: 111983 RVA: 0x003DF883 File Offset: 0x003DDA83
		public IRefSource_UnionUnion()
		{
			this.Type = IRefSource_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601B570 RID: 111984 RVA: 0x003DF899 File Offset: 0x003DDA99
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601B571 RID: 111985 RVA: 0x003DF8AB File Offset: 0x003DDAAB
		public IRefSourceT AsIRefSource()
		{
			return this.As<IRefSourceT>();
		}

		// Token: 0x0601B572 RID: 111986 RVA: 0x003DF8B3 File Offset: 0x003DDAB3
		public static IRefSource_UnionUnion FromIRefSource(IRefSourceT _irefsource)
		{
			return new IRefSource_UnionUnion
			{
				Type = IRefSource_Union.IRefSource,
				Value = _irefsource
			};
		}

		// Token: 0x0601B573 RID: 111987 RVA: 0x003DF8C8 File Offset: 0x003DDAC8
		public IAwakeEntityRefSourceT AsIAwakeEntityRefSource()
		{
			return this.As<IAwakeEntityRefSourceT>();
		}

		// Token: 0x0601B574 RID: 111988 RVA: 0x003DF8D0 File Offset: 0x003DDAD0
		public static IRefSource_UnionUnion FromIAwakeEntityRefSource(IAwakeEntityRefSourceT _iawakeentityrefsource)
		{
			return new IRefSource_UnionUnion
			{
				Type = IRefSource_Union.IAwakeEntityRefSource,
				Value = _iawakeentityrefsource
			};
		}

		// Token: 0x0601B575 RID: 111989 RVA: 0x003DF8E5 File Offset: 0x003DDAE5
		public IDestroyEntityRefSourceT AsIDestroyEntityRefSource()
		{
			return this.As<IDestroyEntityRefSourceT>();
		}

		// Token: 0x0601B576 RID: 111990 RVA: 0x003DF8ED File Offset: 0x003DDAED
		public static IRefSource_UnionUnion FromIDestroyEntityRefSource(IDestroyEntityRefSourceT _idestroyentityrefsource)
		{
			return new IRefSource_UnionUnion
			{
				Type = IRefSource_Union.IDestroyEntityRefSource,
				Value = _idestroyentityrefsource
			};
		}

		// Token: 0x0601B577 RID: 111991 RVA: 0x003DF902 File Offset: 0x003DDB02
		public IManualOccupationRefSourceT AsIManualOccupationRefSource()
		{
			return this.As<IManualOccupationRefSourceT>();
		}

		// Token: 0x0601B578 RID: 111992 RVA: 0x003DF90A File Offset: 0x003DDB0A
		public static IRefSource_UnionUnion FromIManualOccupationRefSource(IManualOccupationRefSourceT _imanualoccupationrefsource)
		{
			return new IRefSource_UnionUnion
			{
				Type = IRefSource_Union.IManualOccupationRefSource,
				Value = _imanualoccupationrefsource
			};
		}

		// Token: 0x0601B579 RID: 111993 RVA: 0x003DF920 File Offset: 0x003DDB20
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
