using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C06 RID: 31750
	public class IToggleRideFlyingCarUiGameplayConfig_UnionUnion
	{
		// Token: 0x1700EDC6 RID: 60870
		// (get) Token: 0x06039398 RID: 234392 RVA: 0x007BAF29 File Offset: 0x007B9129
		// (set) Token: 0x06039399 RID: 234393 RVA: 0x007BAF31 File Offset: 0x007B9131
		public IToggleRideFlyingCarUiGameplayConfig_Union Type { get; set; }

		// Token: 0x1700EDC7 RID: 60871
		// (get) Token: 0x0603939A RID: 234394 RVA: 0x007BAF3A File Offset: 0x007B913A
		// (set) Token: 0x0603939B RID: 234395 RVA: 0x007BAF42 File Offset: 0x007B9142
		public object Value { get; set; }

		// Token: 0x0603939C RID: 234396 RVA: 0x007BAF4B File Offset: 0x007B914B
		public IToggleRideFlyingCarUiGameplayConfig_UnionUnion()
		{
			this.Type = IToggleRideFlyingCarUiGameplayConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0603939D RID: 234397 RVA: 0x007BAF61 File Offset: 0x007B9161
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603939E RID: 234398 RVA: 0x007BAF73 File Offset: 0x007B9173
		public IToggleRideFlyingCarUiGameplayConfigT AsIToggleRideFlyingCarUiGameplayConfig()
		{
			return this.As<IToggleRideFlyingCarUiGameplayConfigT>();
		}

		// Token: 0x0603939F RID: 234399 RVA: 0x007BAF7B File Offset: 0x007B917B
		public static IToggleRideFlyingCarUiGameplayConfig_UnionUnion FromIToggleRideFlyingCarUiGameplayConfig(IToggleRideFlyingCarUiGameplayConfigT _itogglerideflyingcaruigameplayconfig)
		{
			return new IToggleRideFlyingCarUiGameplayConfig_UnionUnion
			{
				Type = IToggleRideFlyingCarUiGameplayConfig_Union.IToggleRideFlyingCarUiGameplayConfig,
				Value = _itogglerideflyingcaruigameplayconfig
			};
		}

		// Token: 0x060393A0 RID: 234400 RVA: 0x007BAF90 File Offset: 0x007B9190
		public IEnableRideFlyingCarUiGameplayT AsIEnableRideFlyingCarUiGameplay()
		{
			return this.As<IEnableRideFlyingCarUiGameplayT>();
		}

		// Token: 0x060393A1 RID: 234401 RVA: 0x007BAF98 File Offset: 0x007B9198
		public static IToggleRideFlyingCarUiGameplayConfig_UnionUnion FromIEnableRideFlyingCarUiGameplay(IEnableRideFlyingCarUiGameplayT _ienablerideflyingcaruigameplay)
		{
			return new IToggleRideFlyingCarUiGameplayConfig_UnionUnion
			{
				Type = IToggleRideFlyingCarUiGameplayConfig_Union.IEnableRideFlyingCarUiGameplay,
				Value = _ienablerideflyingcaruigameplay
			};
		}

		// Token: 0x060393A2 RID: 234402 RVA: 0x007BAFAD File Offset: 0x007B91AD
		public IDisableRideFlyingCarUiGameplayT AsIDisableRideFlyingCarUiGameplay()
		{
			return this.As<IDisableRideFlyingCarUiGameplayT>();
		}

		// Token: 0x060393A3 RID: 234403 RVA: 0x007BAFB5 File Offset: 0x007B91B5
		public static IToggleRideFlyingCarUiGameplayConfig_UnionUnion FromIDisableRideFlyingCarUiGameplay(IDisableRideFlyingCarUiGameplayT _idisablerideflyingcaruigameplay)
		{
			return new IToggleRideFlyingCarUiGameplayConfig_UnionUnion
			{
				Type = IToggleRideFlyingCarUiGameplayConfig_Union.IDisableRideFlyingCarUiGameplay,
				Value = _idisablerideflyingcaruigameplay
			};
		}

		// Token: 0x060393A4 RID: 234404 RVA: 0x007BAFCC File Offset: 0x007B91CC
		public static int Pack(FlatBufferBuilder builder, IToggleRideFlyingCarUiGameplayConfig_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IToggleRideFlyingCarUiGameplayConfig_Union.IToggleRideFlyingCarUiGameplayConfig:
				return IToggleRideFlyingCarUiGameplayConfig.Pack(builder, _o.AsIToggleRideFlyingCarUiGameplayConfig()).Value;
			case IToggleRideFlyingCarUiGameplayConfig_Union.IEnableRideFlyingCarUiGameplay:
				return IEnableRideFlyingCarUiGameplay.Pack(builder, _o.AsIEnableRideFlyingCarUiGameplay()).Value;
			case IToggleRideFlyingCarUiGameplayConfig_Union.IDisableRideFlyingCarUiGameplay:
				return IDisableRideFlyingCarUiGameplay.Pack(builder, _o.AsIDisableRideFlyingCarUiGameplay()).Value;
			default:
				return 0;
			}
		}
	}
}
