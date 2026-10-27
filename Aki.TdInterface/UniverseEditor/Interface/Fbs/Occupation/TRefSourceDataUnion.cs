using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043D6 RID: 17366
	public class TRefSourceDataUnion
	{
		// Token: 0x17007AC5 RID: 31429
		// (get) Token: 0x06019E66 RID: 106086 RVA: 0x003B4B6E File Offset: 0x003B2D6E
		// (set) Token: 0x06019E67 RID: 106087 RVA: 0x003B4B76 File Offset: 0x003B2D76
		public TRefSourceData Type { get; set; }

		// Token: 0x17007AC6 RID: 31430
		// (get) Token: 0x06019E68 RID: 106088 RVA: 0x003B4B7F File Offset: 0x003B2D7F
		// (set) Token: 0x06019E69 RID: 106089 RVA: 0x003B4B87 File Offset: 0x003B2D87
		public object Value { get; set; }

		// Token: 0x06019E6A RID: 106090 RVA: 0x003B4B90 File Offset: 0x003B2D90
		public TRefSourceDataUnion()
		{
			this.Type = TRefSourceData.NONE;
			this.Value = null;
		}

		// Token: 0x06019E6B RID: 106091 RVA: 0x003B4BA6 File Offset: 0x003B2DA6
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06019E6C RID: 106092 RVA: 0x003B4BB8 File Offset: 0x003B2DB8
		public IAwakeEntityRefSourceT AsIAwakeEntityRefSource()
		{
			return this.As<IAwakeEntityRefSourceT>();
		}

		// Token: 0x06019E6D RID: 106093 RVA: 0x003B4BC0 File Offset: 0x003B2DC0
		public static TRefSourceDataUnion FromIAwakeEntityRefSource(IAwakeEntityRefSourceT _iawakeentityrefsource)
		{
			return new TRefSourceDataUnion
			{
				Type = TRefSourceData.IAwakeEntityRefSource,
				Value = _iawakeentityrefsource
			};
		}

		// Token: 0x06019E6E RID: 106094 RVA: 0x003B4BD5 File Offset: 0x003B2DD5
		public IDestroyEntityRefSourceT AsIDestroyEntityRefSource()
		{
			return this.As<IDestroyEntityRefSourceT>();
		}

		// Token: 0x06019E6F RID: 106095 RVA: 0x003B4BDD File Offset: 0x003B2DDD
		public static TRefSourceDataUnion FromIDestroyEntityRefSource(IDestroyEntityRefSourceT _idestroyentityrefsource)
		{
			return new TRefSourceDataUnion
			{
				Type = TRefSourceData.IDestroyEntityRefSource,
				Value = _idestroyentityrefsource
			};
		}

		// Token: 0x06019E70 RID: 106096 RVA: 0x003B4BF2 File Offset: 0x003B2DF2
		public IManualOccupationRefSourceT AsIManualOccupationRefSource()
		{
			return this.As<IManualOccupationRefSourceT>();
		}

		// Token: 0x06019E71 RID: 106097 RVA: 0x003B4BFA File Offset: 0x003B2DFA
		public static TRefSourceDataUnion FromIManualOccupationRefSource(IManualOccupationRefSourceT _imanualoccupationrefsource)
		{
			return new TRefSourceDataUnion
			{
				Type = TRefSourceData.IManualOccupationRefSource,
				Value = _imanualoccupationrefsource
			};
		}

		// Token: 0x06019E72 RID: 106098 RVA: 0x003B4C10 File Offset: 0x003B2E10
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
