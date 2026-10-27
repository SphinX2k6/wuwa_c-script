using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BA8 RID: 23464
	public class IWuWaGoEntityBase_UnionUnion
	{
		// Token: 0x1700B14C RID: 45388
		// (get) Token: 0x060282CB RID: 164555 RVA: 0x00585671 File Offset: 0x00583871
		// (set) Token: 0x060282CC RID: 164556 RVA: 0x00585679 File Offset: 0x00583879
		public IWuWaGoEntityBase_Union Type { get; set; }

		// Token: 0x1700B14D RID: 45389
		// (get) Token: 0x060282CD RID: 164557 RVA: 0x00585682 File Offset: 0x00583882
		// (set) Token: 0x060282CE RID: 164558 RVA: 0x0058568A File Offset: 0x0058388A
		public object Value { get; set; }

		// Token: 0x060282CF RID: 164559 RVA: 0x00585693 File Offset: 0x00583893
		public IWuWaGoEntityBase_UnionUnion()
		{
			this.Type = IWuWaGoEntityBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060282D0 RID: 164560 RVA: 0x005856A9 File Offset: 0x005838A9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060282D1 RID: 164561 RVA: 0x005856BB File Offset: 0x005838BB
		public IWuWaGoEntityBaseT AsIWuWaGoEntityBase()
		{
			return this.As<IWuWaGoEntityBaseT>();
		}

		// Token: 0x060282D2 RID: 164562 RVA: 0x005856C3 File Offset: 0x005838C3
		public static IWuWaGoEntityBase_UnionUnion FromIWuWaGoEntityBase(IWuWaGoEntityBaseT _iwuwagoentitybase)
		{
			return new IWuWaGoEntityBase_UnionUnion
			{
				Type = IWuWaGoEntityBase_Union.IWuWaGoEntityBase,
				Value = _iwuwagoentitybase
			};
		}

		// Token: 0x060282D3 RID: 164563 RVA: 0x005856D8 File Offset: 0x005838D8
		public IWuWaGoLevelCenterT AsIWuWaGoLevelCenter()
		{
			return this.As<IWuWaGoLevelCenterT>();
		}

		// Token: 0x060282D4 RID: 164564 RVA: 0x005856E0 File Offset: 0x005838E0
		public static IWuWaGoEntityBase_UnionUnion FromIWuWaGoLevelCenter(IWuWaGoLevelCenterT _iwuwagolevelcenter)
		{
			return new IWuWaGoEntityBase_UnionUnion
			{
				Type = IWuWaGoEntityBase_Union.IWuWaGoLevelCenter,
				Value = _iwuwagolevelcenter
			};
		}

		// Token: 0x060282D5 RID: 164565 RVA: 0x005856F5 File Offset: 0x005838F5
		public IWuWaGoMovableFloorT AsIWuWaGoMovableFloor()
		{
			return this.As<IWuWaGoMovableFloorT>();
		}

		// Token: 0x060282D6 RID: 164566 RVA: 0x005856FD File Offset: 0x005838FD
		public static IWuWaGoEntityBase_UnionUnion FromIWuWaGoMovableFloor(IWuWaGoMovableFloorT _iwuwagomovablefloor)
		{
			return new IWuWaGoEntityBase_UnionUnion
			{
				Type = IWuWaGoEntityBase_Union.IWuWaGoMovableFloor,
				Value = _iwuwagomovablefloor
			};
		}

		// Token: 0x060282D7 RID: 164567 RVA: 0x00585712 File Offset: 0x00583912
		public IWuWaGoPullRodT AsIWuWaGoPullRod()
		{
			return this.As<IWuWaGoPullRodT>();
		}

		// Token: 0x060282D8 RID: 164568 RVA: 0x0058571A File Offset: 0x0058391A
		public static IWuWaGoEntityBase_UnionUnion FromIWuWaGoPullRod(IWuWaGoPullRodT _iwuwagopullrod)
		{
			return new IWuWaGoEntityBase_UnionUnion
			{
				Type = IWuWaGoEntityBase_Union.IWuWaGoPullRod,
				Value = _iwuwagopullrod
			};
		}

		// Token: 0x060282D9 RID: 164569 RVA: 0x0058572F File Offset: 0x0058392F
		public IWuWaGoPressureTriggerT AsIWuWaGoPressureTrigger()
		{
			return this.As<IWuWaGoPressureTriggerT>();
		}

		// Token: 0x060282DA RID: 164570 RVA: 0x00585737 File Offset: 0x00583937
		public static IWuWaGoEntityBase_UnionUnion FromIWuWaGoPressureTrigger(IWuWaGoPressureTriggerT _iwuwagopressuretrigger)
		{
			return new IWuWaGoEntityBase_UnionUnion
			{
				Type = IWuWaGoEntityBase_Union.IWuWaGoPressureTrigger,
				Value = _iwuwagopressuretrigger
			};
		}

		// Token: 0x060282DB RID: 164571 RVA: 0x0058574C File Offset: 0x0058394C
		public IWuWaGoGearT AsIWuWaGoGear()
		{
			return this.As<IWuWaGoGearT>();
		}

		// Token: 0x060282DC RID: 164572 RVA: 0x00585754 File Offset: 0x00583954
		public static IWuWaGoEntityBase_UnionUnion FromIWuWaGoGear(IWuWaGoGearT _iwuwagogear)
		{
			return new IWuWaGoEntityBase_UnionUnion
			{
				Type = IWuWaGoEntityBase_Union.IWuWaGoGear,
				Value = _iwuwagogear
			};
		}

		// Token: 0x060282DD RID: 164573 RVA: 0x00585769 File Offset: 0x00583969
		public IWuWaGoSpikeTrapT AsIWuWaGoSpikeTrap()
		{
			return this.As<IWuWaGoSpikeTrapT>();
		}

		// Token: 0x060282DE RID: 164574 RVA: 0x00585771 File Offset: 0x00583971
		public static IWuWaGoEntityBase_UnionUnion FromIWuWaGoSpikeTrap(IWuWaGoSpikeTrapT _iwuwagospiketrap)
		{
			return new IWuWaGoEntityBase_UnionUnion
			{
				Type = IWuWaGoEntityBase_Union.IWuWaGoSpikeTrap,
				Value = _iwuwagospiketrap
			};
		}

		// Token: 0x060282DF RID: 164575 RVA: 0x00585786 File Offset: 0x00583986
		public IWuWaGoBowTrapT AsIWuWaGoBowTrap()
		{
			return this.As<IWuWaGoBowTrapT>();
		}

		// Token: 0x060282E0 RID: 164576 RVA: 0x0058578E File Offset: 0x0058398E
		public static IWuWaGoEntityBase_UnionUnion FromIWuWaGoBowTrap(IWuWaGoBowTrapT _iwuwagobowtrap)
		{
			return new IWuWaGoEntityBase_UnionUnion
			{
				Type = IWuWaGoEntityBase_Union.IWuWaGoBowTrap,
				Value = _iwuwagobowtrap
			};
		}

		// Token: 0x060282E1 RID: 164577 RVA: 0x005857A3 File Offset: 0x005839A3
		public IWuWaGoSaveGridT AsIWuWaGoSaveGrid()
		{
			return this.As<IWuWaGoSaveGridT>();
		}

		// Token: 0x060282E2 RID: 164578 RVA: 0x005857AB File Offset: 0x005839AB
		public static IWuWaGoEntityBase_UnionUnion FromIWuWaGoSaveGrid(IWuWaGoSaveGridT _iwuwagosavegrid)
		{
			return new IWuWaGoEntityBase_UnionUnion
			{
				Type = IWuWaGoEntityBase_Union.IWuWaGoSaveGrid,
				Value = _iwuwagosavegrid
			};
		}

		// Token: 0x060282E3 RID: 164579 RVA: 0x005857C1 File Offset: 0x005839C1
		public IWuWaGoEndGridT AsIWuWaGoEndGrid()
		{
			return this.As<IWuWaGoEndGridT>();
		}

		// Token: 0x060282E4 RID: 164580 RVA: 0x005857C9 File Offset: 0x005839C9
		public static IWuWaGoEntityBase_UnionUnion FromIWuWaGoEndGrid(IWuWaGoEndGridT _iwuwagoendgrid)
		{
			return new IWuWaGoEntityBase_UnionUnion
			{
				Type = IWuWaGoEntityBase_Union.IWuWaGoEndGrid,
				Value = _iwuwagoendgrid
			};
		}

		// Token: 0x060282E5 RID: 164581 RVA: 0x005857DF File Offset: 0x005839DF
		public IWuWaGoStartGridT AsIWuWaGoStartGrid()
		{
			return this.As<IWuWaGoStartGridT>();
		}

		// Token: 0x060282E6 RID: 164582 RVA: 0x005857E7 File Offset: 0x005839E7
		public static IWuWaGoEntityBase_UnionUnion FromIWuWaGoStartGrid(IWuWaGoStartGridT _iwuwagostartgrid)
		{
			return new IWuWaGoEntityBase_UnionUnion
			{
				Type = IWuWaGoEntityBase_Union.IWuWaGoStartGrid,
				Value = _iwuwagostartgrid
			};
		}

		// Token: 0x060282E7 RID: 164583 RVA: 0x00585800 File Offset: 0x00583A00
		public static int Pack(FlatBufferBuilder builder, IWuWaGoEntityBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IWuWaGoEntityBase_Union.IWuWaGoEntityBase:
				return IWuWaGoEntityBase.Pack(builder, _o.AsIWuWaGoEntityBase()).Value;
			case IWuWaGoEntityBase_Union.IWuWaGoLevelCenter:
				return IWuWaGoLevelCenter.Pack(builder, _o.AsIWuWaGoLevelCenter()).Value;
			case IWuWaGoEntityBase_Union.IWuWaGoMovableFloor:
				return IWuWaGoMovableFloor.Pack(builder, _o.AsIWuWaGoMovableFloor()).Value;
			case IWuWaGoEntityBase_Union.IWuWaGoPullRod:
				return IWuWaGoPullRod.Pack(builder, _o.AsIWuWaGoPullRod()).Value;
			case IWuWaGoEntityBase_Union.IWuWaGoPressureTrigger:
				return IWuWaGoPressureTrigger.Pack(builder, _o.AsIWuWaGoPressureTrigger()).Value;
			case IWuWaGoEntityBase_Union.IWuWaGoGear:
				return IWuWaGoGear.Pack(builder, _o.AsIWuWaGoGear()).Value;
			case IWuWaGoEntityBase_Union.IWuWaGoSpikeTrap:
				return IWuWaGoSpikeTrap.Pack(builder, _o.AsIWuWaGoSpikeTrap()).Value;
			case IWuWaGoEntityBase_Union.IWuWaGoBowTrap:
				return IWuWaGoBowTrap.Pack(builder, _o.AsIWuWaGoBowTrap()).Value;
			case IWuWaGoEntityBase_Union.IWuWaGoSaveGrid:
				return IWuWaGoSaveGrid.Pack(builder, _o.AsIWuWaGoSaveGrid()).Value;
			case IWuWaGoEntityBase_Union.IWuWaGoEndGrid:
				return IWuWaGoEndGrid.Pack(builder, _o.AsIWuWaGoEndGrid()).Value;
			case IWuWaGoEntityBase_Union.IWuWaGoStartGrid:
				return IWuWaGoStartGrid.Pack(builder, _o.AsIWuWaGoStartGrid()).Value;
			default:
				return 0;
			}
		}
	}
}
