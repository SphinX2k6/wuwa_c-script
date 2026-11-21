using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200474D RID: 18253
	public class TOperationUnion
	{
		// Token: 0x17007F89 RID: 32649
		// (get) Token: 0x0601AE23 RID: 110115 RVA: 0x003D08D6 File Offset: 0x003CEAD6
		// (set) Token: 0x0601AE24 RID: 110116 RVA: 0x003D08DE File Offset: 0x003CEADE
		public TOperation Type { get; set; }

		// Token: 0x17007F8A RID: 32650
		// (get) Token: 0x0601AE25 RID: 110117 RVA: 0x003D08E7 File Offset: 0x003CEAE7
		// (set) Token: 0x0601AE26 RID: 110118 RVA: 0x003D08EF File Offset: 0x003CEAEF
		public object Value { get; set; }

		// Token: 0x0601AE27 RID: 110119 RVA: 0x003D08F8 File Offset: 0x003CEAF8
		public TOperationUnion()
		{
			this.Type = TOperation.NONE;
			this.Value = null;
		}

		// Token: 0x0601AE28 RID: 110120 RVA: 0x003D090E File Offset: 0x003CEB0E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AE29 RID: 110121 RVA: 0x003D0920 File Offset: 0x003CEB20
		public IAssignLoadingBackgroundT AsIAssignLoadingBackground()
		{
			return this.As<IAssignLoadingBackgroundT>();
		}

		// Token: 0x0601AE2A RID: 110122 RVA: 0x003D0928 File Offset: 0x003CEB28
		public static TOperationUnion FromIAssignLoadingBackground(IAssignLoadingBackgroundT _iassignloadingbackground)
		{
			return new TOperationUnion
			{
				Type = TOperation.IAssignLoadingBackground,
				Value = _iassignloadingbackground
			};
		}

		// Token: 0x0601AE2B RID: 110123 RVA: 0x003D093D File Offset: 0x003CEB3D
		public IDisableHLODT AsIDisableHLOD()
		{
			return this.As<IDisableHLODT>();
		}

		// Token: 0x0601AE2C RID: 110124 RVA: 0x003D0945 File Offset: 0x003CEB45
		public static TOperationUnion FromIDisableHLOD(IDisableHLODT _idisablehlod)
		{
			return new TOperationUnion
			{
				Type = TOperation.IDisableHLOD,
				Value = _idisablehlod
			};
		}

		// Token: 0x0601AE2D RID: 110125 RVA: 0x003D095C File Offset: 0x003CEB5C
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
