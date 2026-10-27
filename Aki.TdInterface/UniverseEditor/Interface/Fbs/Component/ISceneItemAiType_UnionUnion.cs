using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058B9 RID: 22713
	public class ISceneItemAiType_UnionUnion
	{
		// Token: 0x1700AA0D RID: 43533
		// (get) Token: 0x0602651A RID: 156954 RVA: 0x00548156 File Offset: 0x00546356
		// (set) Token: 0x0602651B RID: 156955 RVA: 0x0054815E File Offset: 0x0054635E
		public ISceneItemAiType_Union Type { get; set; }

		// Token: 0x1700AA0E RID: 43534
		// (get) Token: 0x0602651C RID: 156956 RVA: 0x00548167 File Offset: 0x00546367
		// (set) Token: 0x0602651D RID: 156957 RVA: 0x0054816F File Offset: 0x0054636F
		public object Value { get; set; }

		// Token: 0x0602651E RID: 156958 RVA: 0x00548178 File Offset: 0x00546378
		public ISceneItemAiType_UnionUnion()
		{
			this.Type = ISceneItemAiType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602651F RID: 156959 RVA: 0x0054818E File Offset: 0x0054638E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06026520 RID: 156960 RVA: 0x005481A0 File Offset: 0x005463A0
		public ISceneItemAiTypeT AsISceneItemAiType()
		{
			return this.As<ISceneItemAiTypeT>();
		}

		// Token: 0x06026521 RID: 156961 RVA: 0x005481A8 File Offset: 0x005463A8
		public static ISceneItemAiType_UnionUnion FromISceneItemAiType(ISceneItemAiTypeT _isceneitemaitype)
		{
			return new ISceneItemAiType_UnionUnion
			{
				Type = ISceneItemAiType_Union.ISceneItemAiType,
				Value = _isceneitemaitype
			};
		}

		// Token: 0x06026522 RID: 156962 RVA: 0x005481BD File Offset: 0x005463BD
		public ISceneItemPatrolT AsISceneItemPatrol()
		{
			return this.As<ISceneItemPatrolT>();
		}

		// Token: 0x06026523 RID: 156963 RVA: 0x005481C5 File Offset: 0x005463C5
		public static ISceneItemAiType_UnionUnion FromISceneItemPatrol(ISceneItemPatrolT _isceneitempatrol)
		{
			return new ISceneItemAiType_UnionUnion
			{
				Type = ISceneItemAiType_Union.ISceneItemPatrol,
				Value = _isceneitempatrol
			};
		}

		// Token: 0x06026524 RID: 156964 RVA: 0x005481DC File Offset: 0x005463DC
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
