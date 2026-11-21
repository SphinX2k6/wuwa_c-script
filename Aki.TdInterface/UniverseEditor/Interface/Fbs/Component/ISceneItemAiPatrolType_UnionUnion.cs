using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EC0 RID: 24256
	public class ISceneItemAiPatrolType_UnionUnion
	{
		// Token: 0x1700B332 RID: 45874
		// (get) Token: 0x06028A52 RID: 166482 RVA: 0x0058E781 File Offset: 0x0058C981
		// (set) Token: 0x06028A53 RID: 166483 RVA: 0x0058E789 File Offset: 0x0058C989
		public ISceneItemAiPatrolType_Union Type { get; set; }

		// Token: 0x1700B333 RID: 45875
		// (get) Token: 0x06028A54 RID: 166484 RVA: 0x0058E792 File Offset: 0x0058C992
		// (set) Token: 0x06028A55 RID: 166485 RVA: 0x0058E79A File Offset: 0x0058C99A
		public object Value { get; set; }

		// Token: 0x06028A56 RID: 166486 RVA: 0x0058E7A3 File Offset: 0x0058C9A3
		public ISceneItemAiPatrolType_UnionUnion()
		{
			this.Type = ISceneItemAiPatrolType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06028A57 RID: 166487 RVA: 0x0058E7B9 File Offset: 0x0058C9B9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028A58 RID: 166488 RVA: 0x0058E7CB File Offset: 0x0058C9CB
		public ISceneItemAiPatrolTypeT AsISceneItemAiPatrolType()
		{
			return this.As<ISceneItemAiPatrolTypeT>();
		}

		// Token: 0x06028A59 RID: 166489 RVA: 0x0058E7D3 File Offset: 0x0058C9D3
		public static ISceneItemAiPatrolType_UnionUnion FromISceneItemAiPatrolType(ISceneItemAiPatrolTypeT _isceneitemaipatroltype)
		{
			return new ISceneItemAiPatrolType_UnionUnion
			{
				Type = ISceneItemAiPatrolType_Union.ISceneItemAiPatrolType,
				Value = _isceneitemaipatroltype
			};
		}

		// Token: 0x06028A5A RID: 166490 RVA: 0x0058E7E8 File Offset: 0x0058C9E8
		public ISceneItemAiPatrolByGameTimeT AsISceneItemAiPatrolByGameTime()
		{
			return this.As<ISceneItemAiPatrolByGameTimeT>();
		}

		// Token: 0x06028A5B RID: 166491 RVA: 0x0058E7F0 File Offset: 0x0058C9F0
		public static ISceneItemAiPatrolType_UnionUnion FromISceneItemAiPatrolByGameTime(ISceneItemAiPatrolByGameTimeT _isceneitemaipatrolbygametime)
		{
			return new ISceneItemAiPatrolType_UnionUnion
			{
				Type = ISceneItemAiPatrolType_Union.ISceneItemAiPatrolByGameTime,
				Value = _isceneitemaipatrolbygametime
			};
		}

		// Token: 0x06028A5C RID: 166492 RVA: 0x0058E808 File Offset: 0x0058CA08
		public static int Pack(FlatBufferBuilder builder, ISceneItemAiPatrolType_UnionUnion _o)
		{
			ISceneItemAiPatrolType_Union type = _o.Type;
			if (type == ISceneItemAiPatrolType_Union.ISceneItemAiPatrolType)
			{
				return ISceneItemAiPatrolType.Pack(builder, _o.AsISceneItemAiPatrolType()).Value;
			}
			if (type != ISceneItemAiPatrolType_Union.ISceneItemAiPatrolByGameTime)
			{
				return 0;
			}
			return ISceneItemAiPatrolByGameTime.Pack(builder, _o.AsISceneItemAiPatrolByGameTime()).Value;
		}
	}
}
