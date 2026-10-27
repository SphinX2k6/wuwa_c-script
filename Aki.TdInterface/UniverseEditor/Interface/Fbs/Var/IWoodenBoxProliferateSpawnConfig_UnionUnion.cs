using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B39 RID: 15161
	public class IWoodenBoxProliferateSpawnConfig_UnionUnion
	{
		// Token: 0x17006808 RID: 26632
		// (get) Token: 0x06014B85 RID: 84869 RVA: 0x003035A5 File Offset: 0x003017A5
		// (set) Token: 0x06014B86 RID: 84870 RVA: 0x003035AD File Offset: 0x003017AD
		public IWoodenBoxProliferateSpawnConfig_Union Type { get; set; }

		// Token: 0x17006809 RID: 26633
		// (get) Token: 0x06014B87 RID: 84871 RVA: 0x003035B6 File Offset: 0x003017B6
		// (set) Token: 0x06014B88 RID: 84872 RVA: 0x003035BE File Offset: 0x003017BE
		public object Value { get; set; }

		// Token: 0x06014B89 RID: 84873 RVA: 0x003035C7 File Offset: 0x003017C7
		public IWoodenBoxProliferateSpawnConfig_UnionUnion()
		{
			this.Type = IWoodenBoxProliferateSpawnConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06014B8A RID: 84874 RVA: 0x003035DD File Offset: 0x003017DD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06014B8B RID: 84875 RVA: 0x003035EF File Offset: 0x003017EF
		public IWoodenBoxProliferateSpawnConfigT AsIWoodenBoxProliferateSpawnConfig()
		{
			return this.As<IWoodenBoxProliferateSpawnConfigT>();
		}

		// Token: 0x06014B8C RID: 84876 RVA: 0x003035F7 File Offset: 0x003017F7
		public static IWoodenBoxProliferateSpawnConfig_UnionUnion FromIWoodenBoxProliferateSpawnConfig(IWoodenBoxProliferateSpawnConfigT _iwoodenboxproliferatespawnconfig)
		{
			return new IWoodenBoxProliferateSpawnConfig_UnionUnion
			{
				Type = IWoodenBoxProliferateSpawnConfig_Union.IWoodenBoxProliferateSpawnConfig,
				Value = _iwoodenboxproliferatespawnconfig
			};
		}

		// Token: 0x06014B8D RID: 84877 RVA: 0x0030360C File Offset: 0x0030180C
		public IWoodenBoxProliferateRandomInRangeT AsIWoodenBoxProliferateRandomInRange()
		{
			return this.As<IWoodenBoxProliferateRandomInRangeT>();
		}

		// Token: 0x06014B8E RID: 84878 RVA: 0x00303614 File Offset: 0x00301814
		public static IWoodenBoxProliferateSpawnConfig_UnionUnion FromIWoodenBoxProliferateRandomInRange(IWoodenBoxProliferateRandomInRangeT _iwoodenboxproliferaterandominrange)
		{
			return new IWoodenBoxProliferateSpawnConfig_UnionUnion
			{
				Type = IWoodenBoxProliferateSpawnConfig_Union.IWoodenBoxProliferateRandomInRange,
				Value = _iwoodenboxproliferaterandominrange
			};
		}

		// Token: 0x06014B8F RID: 84879 RVA: 0x00303629 File Offset: 0x00301829
		public IWoodenBoxProliferatePositionListT AsIWoodenBoxProliferatePositionList()
		{
			return this.As<IWoodenBoxProliferatePositionListT>();
		}

		// Token: 0x06014B90 RID: 84880 RVA: 0x00303631 File Offset: 0x00301831
		public static IWoodenBoxProliferateSpawnConfig_UnionUnion FromIWoodenBoxProliferatePositionList(IWoodenBoxProliferatePositionListT _iwoodenboxproliferatepositionlist)
		{
			return new IWoodenBoxProliferateSpawnConfig_UnionUnion
			{
				Type = IWoodenBoxProliferateSpawnConfig_Union.IWoodenBoxProliferatePositionList,
				Value = _iwoodenboxproliferatepositionlist
			};
		}

		// Token: 0x06014B91 RID: 84881 RVA: 0x00303648 File Offset: 0x00301848
		public static int Pack(FlatBufferBuilder builder, IWoodenBoxProliferateSpawnConfig_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IWoodenBoxProliferateSpawnConfig_Union.IWoodenBoxProliferateSpawnConfig:
				return IWoodenBoxProliferateSpawnConfig.Pack(builder, _o.AsIWoodenBoxProliferateSpawnConfig()).Value;
			case IWoodenBoxProliferateSpawnConfig_Union.IWoodenBoxProliferateRandomInRange:
				return IWoodenBoxProliferateRandomInRange.Pack(builder, _o.AsIWoodenBoxProliferateRandomInRange()).Value;
			case IWoodenBoxProliferateSpawnConfig_Union.IWoodenBoxProliferatePositionList:
				return IWoodenBoxProliferatePositionList.Pack(builder, _o.AsIWoodenBoxProliferatePositionList()).Value;
			default:
				return 0;
			}
		}
	}
}
