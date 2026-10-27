using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004318 RID: 17176
	public class TSpecialGamePlayConfigUnion
	{
		// Token: 0x17007972 RID: 31090
		// (get) Token: 0x0601978F RID: 104335 RVA: 0x003A66B3 File Offset: 0x003A48B3
		// (set) Token: 0x06019790 RID: 104336 RVA: 0x003A66BB File Offset: 0x003A48BB
		public TSpecialGamePlayConfig Type { get; set; }

		// Token: 0x17007973 RID: 31091
		// (get) Token: 0x06019791 RID: 104337 RVA: 0x003A66C4 File Offset: 0x003A48C4
		// (set) Token: 0x06019792 RID: 104338 RVA: 0x003A66CC File Offset: 0x003A48CC
		public object Value { get; set; }

		// Token: 0x06019793 RID: 104339 RVA: 0x003A66D5 File Offset: 0x003A48D5
		public TSpecialGamePlayConfigUnion()
		{
			this.Type = TSpecialGamePlayConfig.NONE;
			this.Value = null;
		}

		// Token: 0x06019794 RID: 104340 RVA: 0x003A66EB File Offset: 0x003A48EB
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06019795 RID: 104341 RVA: 0x003A66FD File Offset: 0x003A48FD
		public IEavesdropGamePlayConfigT AsIEavesdropGamePlayConfig()
		{
			return this.As<IEavesdropGamePlayConfigT>();
		}

		// Token: 0x06019796 RID: 104342 RVA: 0x003A6705 File Offset: 0x003A4905
		public static TSpecialGamePlayConfigUnion FromIEavesdropGamePlayConfig(IEavesdropGamePlayConfigT _ieavesdropgameplayconfig)
		{
			return new TSpecialGamePlayConfigUnion
			{
				Type = TSpecialGamePlayConfig.IEavesdropGamePlayConfig,
				Value = _ieavesdropgameplayconfig
			};
		}

		// Token: 0x06019797 RID: 104343 RVA: 0x003A671A File Offset: 0x003A491A
		public IFirstPersonTurretGamePlayConfigT AsIFirstPersonTurretGamePlayConfig()
		{
			return this.As<IFirstPersonTurretGamePlayConfigT>();
		}

		// Token: 0x06019798 RID: 104344 RVA: 0x003A6722 File Offset: 0x003A4922
		public static TSpecialGamePlayConfigUnion FromIFirstPersonTurretGamePlayConfig(IFirstPersonTurretGamePlayConfigT _ifirstpersonturretgameplayconfig)
		{
			return new TSpecialGamePlayConfigUnion
			{
				Type = TSpecialGamePlayConfig.IFirstPersonTurretGamePlayConfig,
				Value = _ifirstpersonturretgameplayconfig
			};
		}

		// Token: 0x06019799 RID: 104345 RVA: 0x003A6737 File Offset: 0x003A4937
		public IFreezeOnSightGamePlayConfigT AsIFreezeOnSightGamePlayConfig()
		{
			return this.As<IFreezeOnSightGamePlayConfigT>();
		}

		// Token: 0x0601979A RID: 104346 RVA: 0x003A673F File Offset: 0x003A493F
		public static TSpecialGamePlayConfigUnion FromIFreezeOnSightGamePlayConfig(IFreezeOnSightGamePlayConfigT _ifreezeonsightgameplayconfig)
		{
			return new TSpecialGamePlayConfigUnion
			{
				Type = TSpecialGamePlayConfig.IFreezeOnSightGamePlayConfig,
				Value = _ifreezeonsightgameplayconfig
			};
		}

		// Token: 0x0601979B RID: 104347 RVA: 0x003A6754 File Offset: 0x003A4954
		public IStalkingGamePlayConfigT AsIStalkingGamePlayConfig()
		{
			return this.As<IStalkingGamePlayConfigT>();
		}

		// Token: 0x0601979C RID: 104348 RVA: 0x003A675C File Offset: 0x003A495C
		public static TSpecialGamePlayConfigUnion FromIStalkingGamePlayConfig(IStalkingGamePlayConfigT _istalkinggameplayconfig)
		{
			return new TSpecialGamePlayConfigUnion
			{
				Type = TSpecialGamePlayConfig.IStalkingGamePlayConfig,
				Value = _istalkinggameplayconfig
			};
		}

		// Token: 0x0601979D RID: 104349 RVA: 0x003A6774 File Offset: 0x003A4974
		public static int Pack(FlatBufferBuilder builder, TSpecialGamePlayConfigUnion _o)
		{
			switch (_o.Type)
			{
			case TSpecialGamePlayConfig.IEavesdropGamePlayConfig:
				return IEavesdropGamePlayConfig.Pack(builder, _o.AsIEavesdropGamePlayConfig()).Value;
			case TSpecialGamePlayConfig.IFirstPersonTurretGamePlayConfig:
				return IFirstPersonTurretGamePlayConfig.Pack(builder, _o.AsIFirstPersonTurretGamePlayConfig()).Value;
			case TSpecialGamePlayConfig.IFreezeOnSightGamePlayConfig:
				return IFreezeOnSightGamePlayConfig.Pack(builder, _o.AsIFreezeOnSightGamePlayConfig()).Value;
			case TSpecialGamePlayConfig.IStalkingGamePlayConfig:
				return IStalkingGamePlayConfig.Pack(builder, _o.AsIStalkingGamePlayConfig()).Value;
			default:
				return 0;
			}
		}
	}
}
