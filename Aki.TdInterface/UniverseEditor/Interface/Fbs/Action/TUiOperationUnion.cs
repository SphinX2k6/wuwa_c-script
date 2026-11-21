using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02008031 RID: 32817
	public class TUiOperationUnion
	{
		// Token: 0x1700F343 RID: 62275
		// (get) Token: 0x0603B0C9 RID: 241865 RVA: 0x007ED73D File Offset: 0x007EB93D
		// (set) Token: 0x0603B0CA RID: 241866 RVA: 0x007ED745 File Offset: 0x007EB945
		public TUiOperation Type { get; set; }

		// Token: 0x1700F344 RID: 62276
		// (get) Token: 0x0603B0CB RID: 241867 RVA: 0x007ED74E File Offset: 0x007EB94E
		// (set) Token: 0x0603B0CC RID: 241868 RVA: 0x007ED756 File Offset: 0x007EB956
		public object Value { get; set; }

		// Token: 0x0603B0CD RID: 241869 RVA: 0x007ED75F File Offset: 0x007EB95F
		public TUiOperationUnion()
		{
			this.Type = TUiOperation.NONE;
			this.Value = null;
		}

		// Token: 0x0603B0CE RID: 241870 RVA: 0x007ED775 File Offset: 0x007EB975
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603B0CF RID: 241871 RVA: 0x007ED787 File Offset: 0x007EB987
		public IDisableUiOperationT AsIDisableUiOperation()
		{
			return this.As<IDisableUiOperationT>();
		}

		// Token: 0x0603B0D0 RID: 241872 RVA: 0x007ED78F File Offset: 0x007EB98F
		public static TUiOperationUnion FromIDisableUiOperation(IDisableUiOperationT _idisableuioperation)
		{
			return new TUiOperationUnion
			{
				Type = TUiOperation.IDisableUiOperation,
				Value = _idisableuioperation
			};
		}

		// Token: 0x0603B0D1 RID: 241873 RVA: 0x007ED7A4 File Offset: 0x007EB9A4
		public IEnableSectionalUiT AsIEnableSectionalUi()
		{
			return this.As<IEnableSectionalUiT>();
		}

		// Token: 0x0603B0D2 RID: 241874 RVA: 0x007ED7AC File Offset: 0x007EB9AC
		public static TUiOperationUnion FromIEnableSectionalUi(IEnableSectionalUiT _ienablesectionalui)
		{
			return new TUiOperationUnion
			{
				Type = TUiOperation.IEnableSectionalUi,
				Value = _ienablesectionalui
			};
		}

		// Token: 0x0603B0D3 RID: 241875 RVA: 0x007ED7C1 File Offset: 0x007EB9C1
		public IEnableUiOperationT AsIEnableUiOperation()
		{
			return this.As<IEnableUiOperationT>();
		}

		// Token: 0x0603B0D4 RID: 241876 RVA: 0x007ED7C9 File Offset: 0x007EB9C9
		public static TUiOperationUnion FromIEnableUiOperation(IEnableUiOperationT _ienableuioperation)
		{
			return new TUiOperationUnion
			{
				Type = TUiOperation.IEnableUiOperation,
				Value = _ienableuioperation
			};
		}

		// Token: 0x0603B0D5 RID: 241877 RVA: 0x007ED7E0 File Offset: 0x007EB9E0
		public static int Pack(FlatBufferBuilder builder, TUiOperationUnion _o)
		{
			switch (_o.Type)
			{
			case TUiOperation.IDisableUiOperation:
				return IDisableUiOperation.Pack(builder, _o.AsIDisableUiOperation()).Value;
			case TUiOperation.IEnableSectionalUi:
				return IEnableSectionalUi.Pack(builder, _o.AsIEnableSectionalUi()).Value;
			case TUiOperation.IEnableUiOperation:
				return IEnableUiOperation.Pack(builder, _o.AsIEnableUiOperation()).Value;
			default:
				return 0;
			}
		}
	}
}
