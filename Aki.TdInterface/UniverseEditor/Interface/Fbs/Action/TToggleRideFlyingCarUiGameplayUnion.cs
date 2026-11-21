using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200801F RID: 32799
	public class TToggleRideFlyingCarUiGameplayUnion
	{
		// Token: 0x1700F337 RID: 62263
		// (get) Token: 0x0603B03B RID: 241723 RVA: 0x007EC7EC File Offset: 0x007EA9EC
		// (set) Token: 0x0603B03C RID: 241724 RVA: 0x007EC7F4 File Offset: 0x007EA9F4
		public TToggleRideFlyingCarUiGameplay Type { get; set; }

		// Token: 0x1700F338 RID: 62264
		// (get) Token: 0x0603B03D RID: 241725 RVA: 0x007EC7FD File Offset: 0x007EA9FD
		// (set) Token: 0x0603B03E RID: 241726 RVA: 0x007EC805 File Offset: 0x007EAA05
		public object Value { get; set; }

		// Token: 0x0603B03F RID: 241727 RVA: 0x007EC80E File Offset: 0x007EAA0E
		public TToggleRideFlyingCarUiGameplayUnion()
		{
			this.Type = TToggleRideFlyingCarUiGameplay.NONE;
			this.Value = null;
		}

		// Token: 0x0603B040 RID: 241728 RVA: 0x007EC824 File Offset: 0x007EAA24
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603B041 RID: 241729 RVA: 0x007EC836 File Offset: 0x007EAA36
		public IDisableRideFlyingCarUiGameplayT AsIDisableRideFlyingCarUiGameplay()
		{
			return this.As<IDisableRideFlyingCarUiGameplayT>();
		}

		// Token: 0x0603B042 RID: 241730 RVA: 0x007EC83E File Offset: 0x007EAA3E
		public static TToggleRideFlyingCarUiGameplayUnion FromIDisableRideFlyingCarUiGameplay(IDisableRideFlyingCarUiGameplayT _idisablerideflyingcaruigameplay)
		{
			return new TToggleRideFlyingCarUiGameplayUnion
			{
				Type = TToggleRideFlyingCarUiGameplay.IDisableRideFlyingCarUiGameplay,
				Value = _idisablerideflyingcaruigameplay
			};
		}

		// Token: 0x0603B043 RID: 241731 RVA: 0x007EC853 File Offset: 0x007EAA53
		public IEnableRideFlyingCarUiGameplayT AsIEnableRideFlyingCarUiGameplay()
		{
			return this.As<IEnableRideFlyingCarUiGameplayT>();
		}

		// Token: 0x0603B044 RID: 241732 RVA: 0x007EC85B File Offset: 0x007EAA5B
		public static TToggleRideFlyingCarUiGameplayUnion FromIEnableRideFlyingCarUiGameplay(IEnableRideFlyingCarUiGameplayT _ienablerideflyingcaruigameplay)
		{
			return new TToggleRideFlyingCarUiGameplayUnion
			{
				Type = TToggleRideFlyingCarUiGameplay.IEnableRideFlyingCarUiGameplay,
				Value = _ienablerideflyingcaruigameplay
			};
		}

		// Token: 0x0603B045 RID: 241733 RVA: 0x007EC870 File Offset: 0x007EAA70
		public static int Pack(FlatBufferBuilder builder, TToggleRideFlyingCarUiGameplayUnion _o)
		{
			TToggleRideFlyingCarUiGameplay type = _o.Type;
			if (type == TToggleRideFlyingCarUiGameplay.IDisableRideFlyingCarUiGameplay)
			{
				return IDisableRideFlyingCarUiGameplay.Pack(builder, _o.AsIDisableRideFlyingCarUiGameplay()).Value;
			}
			if (type != TToggleRideFlyingCarUiGameplay.IEnableRideFlyingCarUiGameplay)
			{
				return 0;
			}
			return IEnableRideFlyingCarUiGameplay.Pack(builder, _o.AsIEnableRideFlyingCarUiGameplay()).Value;
		}
	}
}
