using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AEB RID: 15083
	public class ITargetType_UnionUnion
	{
		// Token: 0x17006773 RID: 26483
		// (get) Token: 0x060148C6 RID: 84166 RVA: 0x002FE09D File Offset: 0x002FC29D
		// (set) Token: 0x060148C7 RID: 84167 RVA: 0x002FE0A5 File Offset: 0x002FC2A5
		public ITargetType_Union Type { get; set; }

		// Token: 0x17006774 RID: 26484
		// (get) Token: 0x060148C8 RID: 84168 RVA: 0x002FE0AE File Offset: 0x002FC2AE
		// (set) Token: 0x060148C9 RID: 84169 RVA: 0x002FE0B6 File Offset: 0x002FC2B6
		public object Value { get; set; }

		// Token: 0x060148CA RID: 84170 RVA: 0x002FE0BF File Offset: 0x002FC2BF
		public ITargetType_UnionUnion()
		{
			this.Type = ITargetType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060148CB RID: 84171 RVA: 0x002FE0D5 File Offset: 0x002FC2D5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060148CC RID: 84172 RVA: 0x002FE0E7 File Offset: 0x002FC2E7
		public ITargetTypeT AsITargetType()
		{
			return this.As<ITargetTypeT>();
		}

		// Token: 0x060148CD RID: 84173 RVA: 0x002FE0EF File Offset: 0x002FC2EF
		public static ITargetType_UnionUnion FromITargetType(ITargetTypeT _itargettype)
		{
			return new ITargetType_UnionUnion
			{
				Type = ITargetType_Union.ITargetType,
				Value = _itargettype
			};
		}

		// Token: 0x060148CE RID: 84174 RVA: 0x002FE104 File Offset: 0x002FC304
		public ITargetPlayT AsITargetPlay()
		{
			return this.As<ITargetPlayT>();
		}

		// Token: 0x060148CF RID: 84175 RVA: 0x002FE10C File Offset: 0x002FC30C
		public static ITargetType_UnionUnion FromITargetPlay(ITargetPlayT _itargetplay)
		{
			return new ITargetType_UnionUnion
			{
				Type = ITargetType_Union.ITargetPlay,
				Value = _itargetplay
			};
		}

		// Token: 0x060148D0 RID: 84176 RVA: 0x002FE121 File Offset: 0x002FC321
		public ITargetLevelEntityT AsITargetLevelEntity()
		{
			return this.As<ITargetLevelEntityT>();
		}

		// Token: 0x060148D1 RID: 84177 RVA: 0x002FE129 File Offset: 0x002FC329
		public static ITargetType_UnionUnion FromITargetLevelEntity(ITargetLevelEntityT _itargetlevelentity)
		{
			return new ITargetType_UnionUnion
			{
				Type = ITargetType_Union.ITargetLevelEntity,
				Value = _itargetlevelentity
			};
		}

		// Token: 0x060148D2 RID: 84178 RVA: 0x002FE140 File Offset: 0x002FC340
		public static int Pack(FlatBufferBuilder builder, ITargetType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ITargetType_Union.ITargetType:
				return ITargetType.Pack(builder, _o.AsITargetType()).Value;
			case ITargetType_Union.ITargetPlay:
				return ITargetPlay.Pack(builder, _o.AsITargetPlay()).Value;
			case ITargetType_Union.ITargetLevelEntity:
				return ITargetLevelEntity.Pack(builder, _o.AsITargetLevelEntity()).Value;
			default:
				return 0;
			}
		}
	}
}
