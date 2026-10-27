using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007778 RID: 30584
	public class TScreenUnion
	{
		// Token: 0x1700E693 RID: 59027
		// (get) Token: 0x06037896 RID: 227478 RVA: 0x00783F42 File Offset: 0x00782142
		// (set) Token: 0x06037897 RID: 227479 RVA: 0x00783F4A File Offset: 0x0078214A
		public TScreen Type { get; set; }

		// Token: 0x1700E694 RID: 59028
		// (get) Token: 0x06037898 RID: 227480 RVA: 0x00783F53 File Offset: 0x00782153
		// (set) Token: 0x06037899 RID: 227481 RVA: 0x00783F5B File Offset: 0x0078215B
		public object Value { get; set; }

		// Token: 0x0603789A RID: 227482 RVA: 0x00783F64 File Offset: 0x00782164
		public TScreenUnion()
		{
			this.Type = TScreen.NONE;
			this.Value = null;
		}

		// Token: 0x0603789B RID: 227483 RVA: 0x00783F7A File Offset: 0x0078217A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603789C RID: 227484 RVA: 0x00783F8C File Offset: 0x0078218C
		public IMainScreenT AsIMainScreen()
		{
			return this.As<IMainScreenT>();
		}

		// Token: 0x0603789D RID: 227485 RVA: 0x00783F94 File Offset: 0x00782194
		public static TScreenUnion FromIMainScreen(IMainScreenT _imainscreen)
		{
			return new TScreenUnion
			{
				Type = TScreen.IMainScreen,
				Value = _imainscreen
			};
		}

		// Token: 0x0603789E RID: 227486 RVA: 0x00783FA9 File Offset: 0x007821A9
		public ISubScreenT AsISubScreen()
		{
			return this.As<ISubScreenT>();
		}

		// Token: 0x0603789F RID: 227487 RVA: 0x00783FB1 File Offset: 0x007821B1
		public static TScreenUnion FromISubScreen(ISubScreenT _isubscreen)
		{
			return new TScreenUnion
			{
				Type = TScreen.ISubScreen,
				Value = _isubscreen
			};
		}

		// Token: 0x060378A0 RID: 227488 RVA: 0x00783FC8 File Offset: 0x007821C8
		public static int Pack(FlatBufferBuilder builder, TScreenUnion _o)
		{
			TScreen type = _o.Type;
			if (type == TScreen.IMainScreen)
			{
				return IMainScreen.Pack(builder, _o.AsIMainScreen()).Value;
			}
			if (type != TScreen.ISubScreen)
			{
				return 0;
			}
			return ISubScreen.Pack(builder, _o.AsISubScreen()).Value;
		}
	}
}
