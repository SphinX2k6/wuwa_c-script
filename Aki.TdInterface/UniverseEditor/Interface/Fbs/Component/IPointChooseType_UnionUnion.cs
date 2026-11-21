using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D5C RID: 23900
	public class IPointChooseType_UnionUnion
	{
		// Token: 0x1700AFEE RID: 45038
		// (get) Token: 0x06027C8B RID: 162955 RVA: 0x00571625 File Offset: 0x0056F825
		// (set) Token: 0x06027C8C RID: 162956 RVA: 0x0057162D File Offset: 0x0056F82D
		public IPointChooseType_Union Type { get; set; }

		// Token: 0x1700AFEF RID: 45039
		// (get) Token: 0x06027C8D RID: 162957 RVA: 0x00571636 File Offset: 0x0056F836
		// (set) Token: 0x06027C8E RID: 162958 RVA: 0x0057163E File Offset: 0x0056F83E
		public object Value { get; set; }

		// Token: 0x06027C8F RID: 162959 RVA: 0x00571647 File Offset: 0x0056F847
		public IPointChooseType_UnionUnion()
		{
			this.Type = IPointChooseType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06027C90 RID: 162960 RVA: 0x0057165D File Offset: 0x0056F85D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06027C91 RID: 162961 RVA: 0x0057166F File Offset: 0x0056F86F
		public IPointChooseTypeT AsIPointChooseType()
		{
			return this.As<IPointChooseTypeT>();
		}

		// Token: 0x06027C92 RID: 162962 RVA: 0x00571677 File Offset: 0x0056F877
		public static IPointChooseType_UnionUnion FromIPointChooseType(IPointChooseTypeT _ipointchoosetype)
		{
			return new IPointChooseType_UnionUnion
			{
				Type = IPointChooseType_Union.IPointChooseType,
				Value = _ipointchoosetype
			};
		}

		// Token: 0x06027C93 RID: 162963 RVA: 0x0057168C File Offset: 0x0056F88C
		public ISpawnMonsterPointT AsISpawnMonsterPoint()
		{
			return this.As<ISpawnMonsterPointT>();
		}

		// Token: 0x06027C94 RID: 162964 RVA: 0x00571694 File Offset: 0x0056F894
		public static IPointChooseType_UnionUnion FromISpawnMonsterPoint(ISpawnMonsterPointT _ispawnmonsterpoint)
		{
			return new IPointChooseType_UnionUnion
			{
				Type = IPointChooseType_Union.ISpawnMonsterPoint,
				Value = _ispawnmonsterpoint
			};
		}

		// Token: 0x06027C95 RID: 162965 RVA: 0x005716AC File Offset: 0x0056F8AC
		public static int Pack(FlatBufferBuilder builder, IPointChooseType_UnionUnion _o)
		{
			IPointChooseType_Union type = _o.Type;
			if (type == IPointChooseType_Union.IPointChooseType)
			{
				return IPointChooseType.Pack(builder, _o.AsIPointChooseType()).Value;
			}
			if (type != IPointChooseType_Union.ISpawnMonsterPoint)
			{
				return 0;
			}
			return ISpawnMonsterPoint.Pack(builder, _o.AsISpawnMonsterPoint()).Value;
		}
	}
}
