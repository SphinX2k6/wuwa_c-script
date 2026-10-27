using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042EE RID: 17134
	public class TOperationUnion
	{
		// Token: 0x17007956 RID: 31062
		// (get) Token: 0x060196A1 RID: 104097 RVA: 0x003A4FA6 File Offset: 0x003A31A6
		// (set) Token: 0x060196A2 RID: 104098 RVA: 0x003A4FAE File Offset: 0x003A31AE
		public TOperation Type { get; set; }

		// Token: 0x17007957 RID: 31063
		// (get) Token: 0x060196A3 RID: 104099 RVA: 0x003A4FB7 File Offset: 0x003A31B7
		// (set) Token: 0x060196A4 RID: 104100 RVA: 0x003A4FBF File Offset: 0x003A31BF
		public object Value { get; set; }

		// Token: 0x060196A5 RID: 104101 RVA: 0x003A4FC8 File Offset: 0x003A31C8
		public TOperationUnion()
		{
			this.Type = TOperation.NONE;
			this.Value = null;
		}

		// Token: 0x060196A6 RID: 104102 RVA: 0x003A4FDE File Offset: 0x003A31DE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060196A7 RID: 104103 RVA: 0x003A4FF0 File Offset: 0x003A31F0
		public IAssignLoadingBackgroundT AsIAssignLoadingBackground()
		{
			return this.As<IAssignLoadingBackgroundT>();
		}

		// Token: 0x060196A8 RID: 104104 RVA: 0x003A4FF8 File Offset: 0x003A31F8
		public static TOperationUnion FromIAssignLoadingBackground(IAssignLoadingBackgroundT _iassignloadingbackground)
		{
			return new TOperationUnion
			{
				Type = TOperation.IAssignLoadingBackground,
				Value = _iassignloadingbackground
			};
		}

		// Token: 0x060196A9 RID: 104105 RVA: 0x003A500D File Offset: 0x003A320D
		public IDisableHLODT AsIDisableHLOD()
		{
			return this.As<IDisableHLODT>();
		}

		// Token: 0x060196AA RID: 104106 RVA: 0x003A5015 File Offset: 0x003A3215
		public static TOperationUnion FromIDisableHLOD(IDisableHLODT _idisablehlod)
		{
			return new TOperationUnion
			{
				Type = TOperation.IDisableHLOD,
				Value = _idisablehlod
			};
		}

		// Token: 0x060196AB RID: 104107 RVA: 0x003A502C File Offset: 0x003A322C
		public static int Pack(FlatBufferBuilder builder, TOperationUnion _o)
		{
			TOperation type = _o.Type;
			if (type == TOperation.IAssignLoadingBackground)
			{
				return IAssignLoadingBackground.Pack(builder, _o.AsIAssignLoadingBackground()).Value;
			}
			if (type != TOperation.IDisableHLOD)
			{
				return 0;
			}
			return IDisableHLOD.Pack(builder, _o.AsIDisableHLOD()).Value;
		}
	}
}
