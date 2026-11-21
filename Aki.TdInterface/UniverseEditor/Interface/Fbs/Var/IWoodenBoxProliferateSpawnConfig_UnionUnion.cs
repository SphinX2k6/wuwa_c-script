using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F3B RID: 16187
	public class IWoodenBoxProliferateSpawnConfig_UnionUnion
	{
		// Token: 0x17006DA3 RID: 28067
		// (get) Token: 0x0601602F RID: 90159 RVA: 0x00329835 File Offset: 0x00327A35
		// (set) Token: 0x06016030 RID: 90160 RVA: 0x0032983D File Offset: 0x00327A3D
		public IWoodenBoxProliferateSpawnConfig_Union Type { get; set; }

		// Token: 0x17006DA4 RID: 28068
		// (get) Token: 0x06016031 RID: 90161 RVA: 0x00329846 File Offset: 0x00327A46
		// (set) Token: 0x06016032 RID: 90162 RVA: 0x0032984E File Offset: 0x00327A4E
		public object Value { get; set; }

		// Token: 0x06016033 RID: 90163 RVA: 0x00329857 File Offset: 0x00327A57
		public IWoodenBoxProliferateSpawnConfig_UnionUnion()
		{
			this.Type = IWoodenBoxProliferateSpawnConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06016034 RID: 90164 RVA: 0x0032986D File Offset: 0x00327A6D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06016035 RID: 90165 RVA: 0x0032987F File Offset: 0x00327A7F
		public IWoodenBoxProliferateSpawnConfigT AsIWoodenBoxProliferateSpawnConfig()
		{
			return this.As<IWoodenBoxProliferateSpawnConfigT>();
		}

		// Token: 0x06016036 RID: 90166 RVA: 0x00329887 File Offset: 0x00327A87
		public static IWoodenBoxProliferateSpawnConfig_UnionUnion FromIWoodenBoxProliferateSpawnConfig(IWoodenBoxProliferateSpawnConfigT _iwoodenboxproliferatespawnconfig)
		{
			return new IWoodenBoxProliferateSpawnConfig_UnionUnion
			{
				Type = IWoodenBoxProliferateSpawnConfig_Union.IWoodenBoxProliferateSpawnConfig,
				Value = _iwoodenboxproliferatespawnconfig
			};
		}

		// Token: 0x06016037 RID: 90167 RVA: 0x0032989C File Offset: 0x00327A9C
		public IWoodenBoxProliferateRandomInRangeT AsIWoodenBoxProliferateRandomInRange()
		{
			return this.As<IWoodenBoxProliferateRandomInRangeT>();
		}

		// Token: 0x06016038 RID: 90168 RVA: 0x003298A4 File Offset: 0x00327AA4
		public static IWoodenBoxProliferateSpawnConfig_UnionUnion FromIWoodenBoxProliferateRandomInRange(IWoodenBoxProliferateRandomInRangeT _iwoodenboxproliferaterandominrange)
		{
			return new IWoodenBoxProliferateSpawnConfig_UnionUnion
			{
				Type = IWoodenBoxProliferateSpawnConfig_Union.IWoodenBoxProliferateRandomInRange,
				Value = _iwoodenboxproliferaterandominrange
			};
		}

		// Token: 0x06016039 RID: 90169 RVA: 0x003298B9 File Offset: 0x00327AB9
		public IWoodenBoxProliferatePositionListT AsIWoodenBoxProliferatePositionList()
		{
			return this.As<IWoodenBoxProliferatePositionListT>();
		}

		// Token: 0x0601603A RID: 90170 RVA: 0x003298C1 File Offset: 0x00327AC1
		public static IWoodenBoxProliferateSpawnConfig_UnionUnion FromIWoodenBoxProliferatePositionList(IWoodenBoxProliferatePositionListT _iwoodenboxproliferatepositionlist)
		{
			return new IWoodenBoxProliferateSpawnConfig_UnionUnion
			{
				Type = IWoodenBoxProliferateSpawnConfig_Union.IWoodenBoxProliferatePositionList,
				Value = _iwoodenboxproliferatepositionlist
			};
		}

		// Token: 0x0601603B RID: 90171 RVA: 0x003298D8 File Offset: 0x00327AD8
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
