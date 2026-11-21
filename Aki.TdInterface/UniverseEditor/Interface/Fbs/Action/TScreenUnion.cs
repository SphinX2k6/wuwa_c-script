using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FB0 RID: 32688
	public class TScreenUnion
	{
		// Token: 0x1700F2ED RID: 62189
		// (get) Token: 0x0603AE0F RID: 241167 RVA: 0x007E9402 File Offset: 0x007E7602
		// (set) Token: 0x0603AE10 RID: 241168 RVA: 0x007E940A File Offset: 0x007E760A
		public TScreen Type { get; set; }

		// Token: 0x1700F2EE RID: 62190
		// (get) Token: 0x0603AE11 RID: 241169 RVA: 0x007E9413 File Offset: 0x007E7613
		// (set) Token: 0x0603AE12 RID: 241170 RVA: 0x007E941B File Offset: 0x007E761B
		public object Value { get; set; }

		// Token: 0x0603AE13 RID: 241171 RVA: 0x007E9424 File Offset: 0x007E7624
		public TScreenUnion()
		{
			this.Type = TScreen.NONE;
			this.Value = null;
		}

		// Token: 0x0603AE14 RID: 241172 RVA: 0x007E943A File Offset: 0x007E763A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AE15 RID: 241173 RVA: 0x007E944C File Offset: 0x007E764C
		public IMainScreenT AsIMainScreen()
		{
			return this.As<IMainScreenT>();
		}

		// Token: 0x0603AE16 RID: 241174 RVA: 0x007E9454 File Offset: 0x007E7654
		public static TScreenUnion FromIMainScreen(IMainScreenT _imainscreen)
		{
			return new TScreenUnion
			{
				Type = TScreen.IMainScreen,
				Value = _imainscreen
			};
		}

		// Token: 0x0603AE17 RID: 241175 RVA: 0x007E9469 File Offset: 0x007E7669
		public ISubScreenT AsISubScreen()
		{
			return this.As<ISubScreenT>();
		}

		// Token: 0x0603AE18 RID: 241176 RVA: 0x007E9471 File Offset: 0x007E7671
		public static TScreenUnion FromISubScreen(ISubScreenT _isubscreen)
		{
			return new TScreenUnion
			{
				Type = TScreen.ISubScreen,
				Value = _isubscreen
			};
		}

		// Token: 0x0603AE19 RID: 241177 RVA: 0x007E9488 File Offset: 0x007E7688
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
