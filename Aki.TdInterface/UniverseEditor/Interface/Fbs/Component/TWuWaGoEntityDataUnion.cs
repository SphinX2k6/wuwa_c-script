using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006310 RID: 25360
	public class TWuWaGoEntityDataUnion
	{
		// Token: 0x1700BBCC RID: 48076
		// (get) Token: 0x0602B11F RID: 176415 RVA: 0x005DEE36 File Offset: 0x005DD036
		// (set) Token: 0x0602B120 RID: 176416 RVA: 0x005DEE3E File Offset: 0x005DD03E
		public TWuWaGoEntityData Type { get; set; }

		// Token: 0x1700BBCD RID: 48077
		// (get) Token: 0x0602B121 RID: 176417 RVA: 0x005DEE47 File Offset: 0x005DD047
		// (set) Token: 0x0602B122 RID: 176418 RVA: 0x005DEE4F File Offset: 0x005DD04F
		public object Value { get; set; }

		// Token: 0x0602B123 RID: 176419 RVA: 0x005DEE58 File Offset: 0x005DD058
		public TWuWaGoEntityDataUnion()
		{
			this.Type = TWuWaGoEntityData.NONE;
			this.Value = null;
		}

		// Token: 0x0602B124 RID: 176420 RVA: 0x005DEE6E File Offset: 0x005DD06E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B125 RID: 176421 RVA: 0x005DEE80 File Offset: 0x005DD080
		public IWuWaGoBowTrapT AsIWuWaGoBowTrap()
		{
			return this.As<IWuWaGoBowTrapT>();
		}

		// Token: 0x0602B126 RID: 176422 RVA: 0x005DEE88 File Offset: 0x005DD088
		public static TWuWaGoEntityDataUnion FromIWuWaGoBowTrap(IWuWaGoBowTrapT _iwuwagobowtrap)
		{
			return new TWuWaGoEntityDataUnion
			{
				Type = TWuWaGoEntityData.IWuWaGoBowTrap,
				Value = _iwuwagobowtrap
			};
		}

		// Token: 0x0602B127 RID: 176423 RVA: 0x005DEE9D File Offset: 0x005DD09D
		public IWuWaGoEndGridT AsIWuWaGoEndGrid()
		{
			return this.As<IWuWaGoEndGridT>();
		}

		// Token: 0x0602B128 RID: 176424 RVA: 0x005DEEA5 File Offset: 0x005DD0A5
		public static TWuWaGoEntityDataUnion FromIWuWaGoEndGrid(IWuWaGoEndGridT _iwuwagoendgrid)
		{
			return new TWuWaGoEntityDataUnion
			{
				Type = TWuWaGoEntityData.IWuWaGoEndGrid,
				Value = _iwuwagoendgrid
			};
		}

		// Token: 0x0602B129 RID: 176425 RVA: 0x005DEEBA File Offset: 0x005DD0BA
		public IWuWaGoGearT AsIWuWaGoGear()
		{
			return this.As<IWuWaGoGearT>();
		}

		// Token: 0x0602B12A RID: 176426 RVA: 0x005DEEC2 File Offset: 0x005DD0C2
		public static TWuWaGoEntityDataUnion FromIWuWaGoGear(IWuWaGoGearT _iwuwagogear)
		{
			return new TWuWaGoEntityDataUnion
			{
				Type = TWuWaGoEntityData.IWuWaGoGear,
				Value = _iwuwagogear
			};
		}

		// Token: 0x0602B12B RID: 176427 RVA: 0x005DEED7 File Offset: 0x005DD0D7
		public IWuWaGoLevelCenterT AsIWuWaGoLevelCenter()
		{
			return this.As<IWuWaGoLevelCenterT>();
		}

		// Token: 0x0602B12C RID: 176428 RVA: 0x005DEEDF File Offset: 0x005DD0DF
		public static TWuWaGoEntityDataUnion FromIWuWaGoLevelCenter(IWuWaGoLevelCenterT _iwuwagolevelcenter)
		{
			return new TWuWaGoEntityDataUnion
			{
				Type = TWuWaGoEntityData.IWuWaGoLevelCenter,
				Value = _iwuwagolevelcenter
			};
		}

		// Token: 0x0602B12D RID: 176429 RVA: 0x005DEEF4 File Offset: 0x005DD0F4
		public IWuWaGoMovableFloorT AsIWuWaGoMovableFloor()
		{
			return this.As<IWuWaGoMovableFloorT>();
		}

		// Token: 0x0602B12E RID: 176430 RVA: 0x005DEEFC File Offset: 0x005DD0FC
		public static TWuWaGoEntityDataUnion FromIWuWaGoMovableFloor(IWuWaGoMovableFloorT _iwuwagomovablefloor)
		{
			return new TWuWaGoEntityDataUnion
			{
				Type = TWuWaGoEntityData.IWuWaGoMovableFloor,
				Value = _iwuwagomovablefloor
			};
		}

		// Token: 0x0602B12F RID: 176431 RVA: 0x005DEF11 File Offset: 0x005DD111
		public IWuWaGoPressureTriggerT AsIWuWaGoPressureTrigger()
		{
			return this.As<IWuWaGoPressureTriggerT>();
		}

		// Token: 0x0602B130 RID: 176432 RVA: 0x005DEF19 File Offset: 0x005DD119
		public static TWuWaGoEntityDataUnion FromIWuWaGoPressureTrigger(IWuWaGoPressureTriggerT _iwuwagopressuretrigger)
		{
			return new TWuWaGoEntityDataUnion
			{
				Type = TWuWaGoEntityData.IWuWaGoPressureTrigger,
				Value = _iwuwagopressuretrigger
			};
		}

		// Token: 0x0602B131 RID: 176433 RVA: 0x005DEF2E File Offset: 0x005DD12E
		public IWuWaGoPullRodT AsIWuWaGoPullRod()
		{
			return this.As<IWuWaGoPullRodT>();
		}

		// Token: 0x0602B132 RID: 176434 RVA: 0x005DEF36 File Offset: 0x005DD136
		public static TWuWaGoEntityDataUnion FromIWuWaGoPullRod(IWuWaGoPullRodT _iwuwagopullrod)
		{
			return new TWuWaGoEntityDataUnion
			{
				Type = TWuWaGoEntityData.IWuWaGoPullRod,
				Value = _iwuwagopullrod
			};
		}

		// Token: 0x0602B133 RID: 176435 RVA: 0x005DEF4B File Offset: 0x005DD14B
		public IWuWaGoSaveGridT AsIWuWaGoSaveGrid()
		{
			return this.As<IWuWaGoSaveGridT>();
		}

		// Token: 0x0602B134 RID: 176436 RVA: 0x005DEF53 File Offset: 0x005DD153
		public static TWuWaGoEntityDataUnion FromIWuWaGoSaveGrid(IWuWaGoSaveGridT _iwuwagosavegrid)
		{
			return new TWuWaGoEntityDataUnion
			{
				Type = TWuWaGoEntityData.IWuWaGoSaveGrid,
				Value = _iwuwagosavegrid
			};
		}

		// Token: 0x0602B135 RID: 176437 RVA: 0x005DEF68 File Offset: 0x005DD168
		public IWuWaGoSpikeTrapT AsIWuWaGoSpikeTrap()
		{
			return this.As<IWuWaGoSpikeTrapT>();
		}

		// Token: 0x0602B136 RID: 176438 RVA: 0x005DEF70 File Offset: 0x005DD170
		public static TWuWaGoEntityDataUnion FromIWuWaGoSpikeTrap(IWuWaGoSpikeTrapT _iwuwagospiketrap)
		{
			return new TWuWaGoEntityDataUnion
			{
				Type = TWuWaGoEntityData.IWuWaGoSpikeTrap,
				Value = _iwuwagospiketrap
			};
		}

		// Token: 0x0602B137 RID: 176439 RVA: 0x005DEF86 File Offset: 0x005DD186
		public IWuWaGoStartGridT AsIWuWaGoStartGrid()
		{
			return this.As<IWuWaGoStartGridT>();
		}

		// Token: 0x0602B138 RID: 176440 RVA: 0x005DEF8E File Offset: 0x005DD18E
		public static TWuWaGoEntityDataUnion FromIWuWaGoStartGrid(IWuWaGoStartGridT _iwuwagostartgrid)
		{
			return new TWuWaGoEntityDataUnion
			{
				Type = TWuWaGoEntityData.IWuWaGoStartGrid,
				Value = _iwuwagostartgrid
			};
		}

		// Token: 0x0602B139 RID: 176441 RVA: 0x005DEFA4 File Offset: 0x005DD1A4
		public static int Pack(FlatBufferBuilder builder, TWuWaGoEntityDataUnion _o)
		{
			switch (_o.Type)
			{
			case TWuWaGoEntityData.IWuWaGoBowTrap:
				return IWuWaGoBowTrap.Pack(builder, _o.AsIWuWaGoBowTrap()).Value;
			case TWuWaGoEntityData.IWuWaGoEndGrid:
				return IWuWaGoEndGrid.Pack(builder, _o.AsIWuWaGoEndGrid()).Value;
			case TWuWaGoEntityData.IWuWaGoGear:
				return IWuWaGoGear.Pack(builder, _o.AsIWuWaGoGear()).Value;
			case TWuWaGoEntityData.IWuWaGoLevelCenter:
				return IWuWaGoLevelCenter.Pack(builder, _o.AsIWuWaGoLevelCenter()).Value;
			case TWuWaGoEntityData.IWuWaGoMovableFloor:
				return IWuWaGoMovableFloor.Pack(builder, _o.AsIWuWaGoMovableFloor()).Value;
			case TWuWaGoEntityData.IWuWaGoPressureTrigger:
				return IWuWaGoPressureTrigger.Pack(builder, _o.AsIWuWaGoPressureTrigger()).Value;
			case TWuWaGoEntityData.IWuWaGoPullRod:
				return IWuWaGoPullRod.Pack(builder, _o.AsIWuWaGoPullRod()).Value;
			case TWuWaGoEntityData.IWuWaGoSaveGrid:
				return IWuWaGoSaveGrid.Pack(builder, _o.AsIWuWaGoSaveGrid()).Value;
			case TWuWaGoEntityData.IWuWaGoSpikeTrap:
				return IWuWaGoSpikeTrap.Pack(builder, _o.AsIWuWaGoSpikeTrap()).Value;
			case TWuWaGoEntityData.IWuWaGoStartGrid:
				return IWuWaGoStartGrid.Pack(builder, _o.AsIWuWaGoStartGrid()).Value;
			default:
				return 0;
			}
		}
	}
}
