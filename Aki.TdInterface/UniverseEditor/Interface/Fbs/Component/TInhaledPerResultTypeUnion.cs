using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C40 RID: 23616
	public class TInhaledPerResultTypeUnion
	{
		// Token: 0x1700B208 RID: 45576
		// (get) Token: 0x060287E1 RID: 165857 RVA: 0x005921E6 File Offset: 0x005903E6
		// (set) Token: 0x060287E2 RID: 165858 RVA: 0x005921EE File Offset: 0x005903EE
		public TInhaledPerResultType Type { get; set; }

		// Token: 0x1700B209 RID: 45577
		// (get) Token: 0x060287E3 RID: 165859 RVA: 0x005921F7 File Offset: 0x005903F7
		// (set) Token: 0x060287E4 RID: 165860 RVA: 0x005921FF File Offset: 0x005903FF
		public object Value { get; set; }

		// Token: 0x060287E5 RID: 165861 RVA: 0x00592208 File Offset: 0x00590408
		public TInhaledPerResultTypeUnion()
		{
			this.Type = TInhaledPerResultType.NONE;
			this.Value = null;
		}

		// Token: 0x060287E6 RID: 165862 RVA: 0x0059221E File Offset: 0x0059041E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060287E7 RID: 165863 RVA: 0x00592230 File Offset: 0x00590430
		public IInhaledChangeSelfStateT AsIInhaledChangeSelfState()
		{
			return this.As<IInhaledChangeSelfStateT>();
		}

		// Token: 0x060287E8 RID: 165864 RVA: 0x00592238 File Offset: 0x00590438
		public static TInhaledPerResultTypeUnion FromIInhaledChangeSelfState(IInhaledChangeSelfStateT _iinhaledchangeselfstate)
		{
			return new TInhaledPerResultTypeUnion
			{
				Type = TInhaledPerResultType.IInhaledChangeSelfState,
				Value = _iinhaledchangeselfstate
			};
		}

		// Token: 0x060287E9 RID: 165865 RVA: 0x0059224D File Offset: 0x0059044D
		public IInhaledDestroySelfT AsIInhaledDestroySelf()
		{
			return this.As<IInhaledDestroySelfT>();
		}

		// Token: 0x060287EA RID: 165866 RVA: 0x00592255 File Offset: 0x00590455
		public static TInhaledPerResultTypeUnion FromIInhaledDestroySelf(IInhaledDestroySelfT _iinhaleddestroyself)
		{
			return new TInhaledPerResultTypeUnion
			{
				Type = TInhaledPerResultType.IInhaledDestroySelf,
				Value = _iinhaleddestroyself
			};
		}

		// Token: 0x060287EB RID: 165867 RVA: 0x0059226C File Offset: 0x0059046C
		public static int Pack(FlatBufferBuilder builder, TInhaledPerResultTypeUnion _o)
		{
			TInhaledPerResultType type = _o.Type;
			if (type == TInhaledPerResultType.IInhaledChangeSelfState)
			{
				return IInhaledChangeSelfState.Pack(builder, _o.AsIInhaledChangeSelfState()).Value;
			}
			if (type != TInhaledPerResultType.IInhaledDestroySelf)
			{
				return 0;
			}
			return IInhaledDestroySelf.Pack(builder, _o.AsIInhaledDestroySelf()).Value;
		}
	}
}
