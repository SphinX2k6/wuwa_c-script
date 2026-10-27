using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C70 RID: 23664
	public class TNpcModelTypeUnion
	{
		// Token: 0x1700B228 RID: 45608
		// (get) Token: 0x060288BD RID: 166077 RVA: 0x0059358A File Offset: 0x0059178A
		// (set) Token: 0x060288BE RID: 166078 RVA: 0x00593592 File Offset: 0x00591792
		public TNpcModelType Type { get; set; }

		// Token: 0x1700B229 RID: 45609
		// (get) Token: 0x060288BF RID: 166079 RVA: 0x0059359B File Offset: 0x0059179B
		// (set) Token: 0x060288C0 RID: 166080 RVA: 0x005935A3 File Offset: 0x005917A3
		public object Value { get; set; }

		// Token: 0x060288C1 RID: 166081 RVA: 0x005935AC File Offset: 0x005917AC
		public TNpcModelTypeUnion()
		{
			this.Type = TNpcModelType.NONE;
			this.Value = null;
		}

		// Token: 0x060288C2 RID: 166082 RVA: 0x005935C2 File Offset: 0x005917C2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060288C3 RID: 166083 RVA: 0x005935D4 File Offset: 0x005917D4
		public IDaNpcModelT AsIDaNpcModel()
		{
			return this.As<IDaNpcModelT>();
		}

		// Token: 0x060288C4 RID: 166084 RVA: 0x005935DC File Offset: 0x005917DC
		public static TNpcModelTypeUnion FromIDaNpcModel(IDaNpcModelT _idanpcmodel)
		{
			return new TNpcModelTypeUnion
			{
				Type = TNpcModelType.IDaNpcModel,
				Value = _idanpcmodel
			};
		}

		// Token: 0x060288C5 RID: 166085 RVA: 0x005935F1 File Offset: 0x005917F1
		public IMeshNpcModelT AsIMeshNpcModel()
		{
			return this.As<IMeshNpcModelT>();
		}

		// Token: 0x060288C6 RID: 166086 RVA: 0x005935F9 File Offset: 0x005917F9
		public static TNpcModelTypeUnion FromIMeshNpcModel(IMeshNpcModelT _imeshnpcmodel)
		{
			return new TNpcModelTypeUnion
			{
				Type = TNpcModelType.IMeshNpcModel,
				Value = _imeshnpcmodel
			};
		}

		// Token: 0x060288C7 RID: 166087 RVA: 0x00593610 File Offset: 0x00591810
		public static int Pack(FlatBufferBuilder builder, TNpcModelTypeUnion _o)
		{
			TNpcModelType type = _o.Type;
			if (type == TNpcModelType.IDaNpcModel)
			{
				return IDaNpcModel.Pack(builder, _o.AsIDaNpcModel()).Value;
			}
			if (type != TNpcModelType.IMeshNpcModel)
			{
				return 0;
			}
			return IMeshNpcModel.Pack(builder, _o.AsIMeshNpcModel()).Value;
		}
	}
}
