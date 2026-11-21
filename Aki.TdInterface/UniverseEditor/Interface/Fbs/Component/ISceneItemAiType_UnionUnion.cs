using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EC6 RID: 24262
	public class ISceneItemAiType_UnionUnion
	{
		// Token: 0x1700B33D RID: 45885
		// (get) Token: 0x06028A7C RID: 166524 RVA: 0x0058ECA2 File Offset: 0x0058CEA2
		// (set) Token: 0x06028A7D RID: 166525 RVA: 0x0058ECAA File Offset: 0x0058CEAA
		public ISceneItemAiType_Union Type { get; set; }

		// Token: 0x1700B33E RID: 45886
		// (get) Token: 0x06028A7E RID: 166526 RVA: 0x0058ECB3 File Offset: 0x0058CEB3
		// (set) Token: 0x06028A7F RID: 166527 RVA: 0x0058ECBB File Offset: 0x0058CEBB
		public object Value { get; set; }

		// Token: 0x06028A80 RID: 166528 RVA: 0x0058ECC4 File Offset: 0x0058CEC4
		public ISceneItemAiType_UnionUnion()
		{
			this.Type = ISceneItemAiType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06028A81 RID: 166529 RVA: 0x0058ECDA File Offset: 0x0058CEDA
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028A82 RID: 166530 RVA: 0x0058ECEC File Offset: 0x0058CEEC
		public ISceneItemAiTypeT AsISceneItemAiType()
		{
			return this.As<ISceneItemAiTypeT>();
		}

		// Token: 0x06028A83 RID: 166531 RVA: 0x0058ECF4 File Offset: 0x0058CEF4
		public static ISceneItemAiType_UnionUnion FromISceneItemAiType(ISceneItemAiTypeT _isceneitemaitype)
		{
			return new ISceneItemAiType_UnionUnion
			{
				Type = ISceneItemAiType_Union.ISceneItemAiType,
				Value = _isceneitemaitype
			};
		}

		// Token: 0x06028A84 RID: 166532 RVA: 0x0058ED09 File Offset: 0x0058CF09
		public ISceneItemPatrolT AsISceneItemPatrol()
		{
			return this.As<ISceneItemPatrolT>();
		}

		// Token: 0x06028A85 RID: 166533 RVA: 0x0058ED11 File Offset: 0x0058CF11
		public static ISceneItemAiType_UnionUnion FromISceneItemPatrol(ISceneItemPatrolT _isceneitempatrol)
		{
			return new ISceneItemAiType_UnionUnion
			{
				Type = ISceneItemAiType_Union.ISceneItemPatrol,
				Value = _isceneitempatrol
			};
		}

		// Token: 0x06028A86 RID: 166534 RVA: 0x0058ED28 File Offset: 0x0058CF28
		public static int Pack(FlatBufferBuilder builder, ISceneItemAiType_UnionUnion _o)
		{
			ISceneItemAiType_Union type = _o.Type;
			if (type == ISceneItemAiType_Union.ISceneItemAiType)
			{
				return ISceneItemAiType.Pack(builder, _o.AsISceneItemAiType()).Value;
			}
			if (type != ISceneItemAiType_Union.ISceneItemPatrol)
			{
				return 0;
			}
			return ISceneItemPatrol.Pack(builder, _o.AsISceneItemPatrol()).Value;
		}
	}
}
