using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058B3 RID: 22707
	public class ISceneItemAiPatrolType_UnionUnion
	{
		// Token: 0x1700AA02 RID: 43522
		// (get) Token: 0x060264F0 RID: 156912 RVA: 0x00547C35 File Offset: 0x00545E35
		// (set) Token: 0x060264F1 RID: 156913 RVA: 0x00547C3D File Offset: 0x00545E3D
		public ISceneItemAiPatrolType_Union Type { get; set; }

		// Token: 0x1700AA03 RID: 43523
		// (get) Token: 0x060264F2 RID: 156914 RVA: 0x00547C46 File Offset: 0x00545E46
		// (set) Token: 0x060264F3 RID: 156915 RVA: 0x00547C4E File Offset: 0x00545E4E
		public object Value { get; set; }

		// Token: 0x060264F4 RID: 156916 RVA: 0x00547C57 File Offset: 0x00545E57
		public ISceneItemAiPatrolType_UnionUnion()
		{
			this.Type = ISceneItemAiPatrolType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060264F5 RID: 156917 RVA: 0x00547C6D File Offset: 0x00545E6D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060264F6 RID: 156918 RVA: 0x00547C7F File Offset: 0x00545E7F
		public ISceneItemAiPatrolTypeT AsISceneItemAiPatrolType()
		{
			return this.As<ISceneItemAiPatrolTypeT>();
		}

		// Token: 0x060264F7 RID: 156919 RVA: 0x00547C87 File Offset: 0x00545E87
		public static ISceneItemAiPatrolType_UnionUnion FromISceneItemAiPatrolType(ISceneItemAiPatrolTypeT _isceneitemaipatroltype)
		{
			return new ISceneItemAiPatrolType_UnionUnion
			{
				Type = ISceneItemAiPatrolType_Union.ISceneItemAiPatrolType,
				Value = _isceneitemaipatroltype
			};
		}

		// Token: 0x060264F8 RID: 156920 RVA: 0x00547C9C File Offset: 0x00545E9C
		public ISceneItemAiPatrolByGameTimeT AsISceneItemAiPatrolByGameTime()
		{
			return this.As<ISceneItemAiPatrolByGameTimeT>();
		}

		// Token: 0x060264F9 RID: 156921 RVA: 0x00547CA4 File Offset: 0x00545EA4
		public static ISceneItemAiPatrolType_UnionUnion FromISceneItemAiPatrolByGameTime(ISceneItemAiPatrolByGameTimeT _isceneitemaipatrolbygametime)
		{
			return new ISceneItemAiPatrolType_UnionUnion
			{
				Type = ISceneItemAiPatrolType_Union.ISceneItemAiPatrolByGameTime,
				Value = _isceneitemaipatrolbygametime
			};
		}

		// Token: 0x060264FA RID: 156922 RVA: 0x00547CBC File Offset: 0x00545EBC
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
