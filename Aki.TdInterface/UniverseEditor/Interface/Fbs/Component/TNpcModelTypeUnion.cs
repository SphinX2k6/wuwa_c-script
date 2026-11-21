using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006298 RID: 25240
	public class TNpcModelTypeUnion
	{
		// Token: 0x1700BB7C RID: 47996
		// (get) Token: 0x0602AEDB RID: 175835 RVA: 0x005DB92E File Offset: 0x005D9B2E
		// (set) Token: 0x0602AEDC RID: 175836 RVA: 0x005DB936 File Offset: 0x005D9B36
		public TNpcModelType Type { get; set; }

		// Token: 0x1700BB7D RID: 47997
		// (get) Token: 0x0602AEDD RID: 175837 RVA: 0x005DB93F File Offset: 0x005D9B3F
		// (set) Token: 0x0602AEDE RID: 175838 RVA: 0x005DB947 File Offset: 0x005D9B47
		public object Value { get; set; }

		// Token: 0x0602AEDF RID: 175839 RVA: 0x005DB950 File Offset: 0x005D9B50
		public TNpcModelTypeUnion()
		{
			this.Type = TNpcModelType.NONE;
			this.Value = null;
		}

		// Token: 0x0602AEE0 RID: 175840 RVA: 0x005DB966 File Offset: 0x005D9B66
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AEE1 RID: 175841 RVA: 0x005DB978 File Offset: 0x005D9B78
		public ICombineDaNpcModelT AsICombineDaNpcModel()
		{
			return this.As<ICombineDaNpcModelT>();
		}

		// Token: 0x0602AEE2 RID: 175842 RVA: 0x005DB980 File Offset: 0x005D9B80
		public static TNpcModelTypeUnion FromICombineDaNpcModel(ICombineDaNpcModelT _icombinedanpcmodel)
		{
			return new TNpcModelTypeUnion
			{
				Type = TNpcModelType.ICombineDaNpcModel,
				Value = _icombinedanpcmodel
			};
		}

		// Token: 0x0602AEE3 RID: 175843 RVA: 0x005DB995 File Offset: 0x005D9B95
		public IDaNpcModelT AsIDaNpcModel()
		{
			return this.As<IDaNpcModelT>();
		}

		// Token: 0x0602AEE4 RID: 175844 RVA: 0x005DB99D File Offset: 0x005D9B9D
		public static TNpcModelTypeUnion FromIDaNpcModel(IDaNpcModelT _idanpcmodel)
		{
			return new TNpcModelTypeUnion
			{
				Type = TNpcModelType.IDaNpcModel,
				Value = _idanpcmodel
			};
		}

		// Token: 0x0602AEE5 RID: 175845 RVA: 0x005DB9B2 File Offset: 0x005D9BB2
		public IMeshNpcModelT AsIMeshNpcModel()
		{
			return this.As<IMeshNpcModelT>();
		}

		// Token: 0x0602AEE6 RID: 175846 RVA: 0x005DB9BA File Offset: 0x005D9BBA
		public static TNpcModelTypeUnion FromIMeshNpcModel(IMeshNpcModelT _imeshnpcmodel)
		{
			return new TNpcModelTypeUnion
			{
				Type = TNpcModelType.IMeshNpcModel,
				Value = _imeshnpcmodel
			};
		}

		// Token: 0x0602AEE7 RID: 175847 RVA: 0x005DB9D0 File Offset: 0x005D9BD0
		public static int Pack(FlatBufferBuilder builder, TNpcModelTypeUnion _o)
		{
			switch (_o.Type)
			{
			case TNpcModelType.ICombineDaNpcModel:
				return ICombineDaNpcModel.Pack(builder, _o.AsICombineDaNpcModel()).Value;
			case TNpcModelType.IDaNpcModel:
				return IDaNpcModel.Pack(builder, _o.AsIDaNpcModel()).Value;
			case TNpcModelType.IMeshNpcModel:
				return IMeshNpcModel.Pack(builder, _o.AsIMeshNpcModel()).Value;
			default:
				return 0;
			}
		}
	}
}
