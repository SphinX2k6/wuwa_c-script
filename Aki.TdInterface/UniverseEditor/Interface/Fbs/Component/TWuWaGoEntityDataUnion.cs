using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CDC RID: 23772
	public class TWuWaGoEntityDataUnion
	{
		// Token: 0x1700B270 RID: 45680
		// (get) Token: 0x06028ACB RID: 166603 RVA: 0x005965C6 File Offset: 0x005947C6
		// (set) Token: 0x06028ACC RID: 166604 RVA: 0x005965CE File Offset: 0x005947CE
		public TWuWaGoEntityData Type { get; set; }

		// Token: 0x1700B271 RID: 45681
		// (get) Token: 0x06028ACD RID: 166605 RVA: 0x005965D7 File Offset: 0x005947D7
		// (set) Token: 0x06028ACE RID: 166606 RVA: 0x005965DF File Offset: 0x005947DF
		public object Value { get; set; }

		// Token: 0x06028ACF RID: 166607 RVA: 0x005965E8 File Offset: 0x005947E8
		public TWuWaGoEntityDataUnion()
		{
			this.Type = TWuWaGoEntityData.NONE;
			this.Value = null;
		}

		// Token: 0x06028AD0 RID: 166608 RVA: 0x005965FE File Offset: 0x005947FE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028AD1 RID: 166609 RVA: 0x00596610 File Offset: 0x00594810
		public IWuWaGoBowTrapT AsIWuWaGoBowTrap()
		{
			return this.As<IWuWaGoBowTrapT>();
		}

		// Token: 0x06028AD2 RID: 166610 RVA: 0x00596618 File Offset: 0x00594818
		public static TWuWaGoEntityDataUnion FromIWuWaGoBowTrap(IWuWaGoBowTrapT _iwuwagobowtrap)
		{
			return new TWuWaGoEntityDataUnion
			{
				Type = TWuWaGoEntityData.IWuWaGoBowTrap,
				Value = _iwuwagobowtrap
			};
		}

		// Token: 0x06028AD3 RID: 166611 RVA: 0x0059662D File Offset: 0x0059482D
		public IWuWaGoEndGridT AsIWuWaGoEndGrid()
		{
			return this.As<IWuWaGoEndGridT>();
		}

		// Token: 0x06028AD4 RID: 166612 RVA: 0x00596635 File Offset: 0x00594835
		public static TWuWaGoEntityDataUnion FromIWuWaGoEndGrid(IWuWaGoEndGridT _iwuwagoendgrid)
		{
			return new TWuWaGoEntityDataUnion
			{
				Type = TWuWaGoEntityData.IWuWaGoEndGrid,
				Value = _iwuwagoendgrid
			};
		}

		// Token: 0x06028AD5 RID: 166613 RVA: 0x0059664A File Offset: 0x0059484A
		public IWuWaGoGearT AsIWuWaGoGear()
		{
			return this.As<IWuWaGoGearT>();
		}

		// Token: 0x06028AD6 RID: 166614 RVA: 0x00596652 File Offset: 0x00594852
		public static TWuWaGoEntityDataUnion FromIWuWaGoGear(IWuWaGoGearT _iwuwagogear)
		{
			return new TWuWaGoEntityDataUnion
			{
				Type = TWuWaGoEntityData.IWuWaGoGear,
				Value = _iwuwagogear
			};
		}

		// Token: 0x06028AD7 RID: 166615 RVA: 0x00596667 File Offset: 0x00594867
		public IWuWaGoLevelCenterT AsIWuWaGoLevelCenter()
		{
			return this.As<IWuWaGoLevelCenterT>();
		}

		// Token: 0x06028AD8 RID: 166616 RVA: 0x0059666F File Offset: 0x0059486F
		public static TWuWaGoEntityDataUnion FromIWuWaGoLevelCenter(IWuWaGoLevelCenterT _iwuwagolevelcenter)
		{
			return new TWuWaGoEntityDataUnion
			{
				Type = TWuWaGoEntityData.IWuWaGoLevelCenter,
				Value = _iwuwagolevelcenter
			};
		}

		// Token: 0x06028AD9 RID: 166617 RVA: 0x00596684 File Offset: 0x00594884
		public IWuWaGoMovableFloorT AsIWuWaGoMovableFloor()
		{
			return this.As<IWuWaGoMovableFloorT>();
		}

		// Token: 0x06028ADA RID: 166618 RVA: 0x0059668C File Offset: 0x0059488C
		public static TWuWaGoEntityDataUnion FromIWuWaGoMovableFloor(IWuWaGoMovableFloorT _iwuwagomovablefloor)
		{
			return new TWuWaGoEntityDataUnion
			{
				Type = TWuWaGoEntityData.IWuWaGoMovableFloor,
				Value = _iwuwagomovablefloor
			};
		}

		// Token: 0x06028ADB RID: 166619 RVA: 0x005966A1 File Offset: 0x005948A1
		public IWuWaGoPressureTriggerT AsIWuWaGoPressureTrigger()
		{
			return this.As<IWuWaGoPressureTriggerT>();
		}

		// Token: 0x06028ADC RID: 166620 RVA: 0x005966A9 File Offset: 0x005948A9
		public static TWuWaGoEntityDataUnion FromIWuWaGoPressureTrigger(IWuWaGoPressureTriggerT _iwuwagopressuretrigger)
		{
			return new TWuWaGoEntityDataUnion
			{
				Type = TWuWaGoEntityData.IWuWaGoPressureTrigger,
				Value = _iwuwagopressuretrigger
			};
		}

		// Token: 0x06028ADD RID: 166621 RVA: 0x005966BE File Offset: 0x005948BE
		public IWuWaGoPullRodT AsIWuWaGoPullRod()
		{
			return this.As<IWuWaGoPullRodT>();
		}

		// Token: 0x06028ADE RID: 166622 RVA: 0x005966C6 File Offset: 0x005948C6
		public static TWuWaGoEntityDataUnion FromIWuWaGoPullRod(IWuWaGoPullRodT _iwuwagopullrod)
		{
			return new TWuWaGoEntityDataUnion
			{
				Type = TWuWaGoEntityData.IWuWaGoPullRod,
				Value = _iwuwagopullrod
			};
		}

		// Token: 0x06028ADF RID: 166623 RVA: 0x005966DB File Offset: 0x005948DB
		public IWuWaGoSaveGridT AsIWuWaGoSaveGrid()
		{
			return this.As<IWuWaGoSaveGridT>();
		}

		// Token: 0x06028AE0 RID: 166624 RVA: 0x005966E3 File Offset: 0x005948E3
		public static TWuWaGoEntityDataUnion FromIWuWaGoSaveGrid(IWuWaGoSaveGridT _iwuwagosavegrid)
		{
			return new TWuWaGoEntityDataUnion
			{
				Type = TWuWaGoEntityData.IWuWaGoSaveGrid,
				Value = _iwuwagosavegrid
			};
		}

		// Token: 0x06028AE1 RID: 166625 RVA: 0x005966F8 File Offset: 0x005948F8
		public IWuWaGoSpikeTrapT AsIWuWaGoSpikeTrap()
		{
			return this.As<IWuWaGoSpikeTrapT>();
		}

		// Token: 0x06028AE2 RID: 166626 RVA: 0x00596700 File Offset: 0x00594900
		public static TWuWaGoEntityDataUnion FromIWuWaGoSpikeTrap(IWuWaGoSpikeTrapT _iwuwagospiketrap)
		{
			return new TWuWaGoEntityDataUnion
			{
				Type = TWuWaGoEntityData.IWuWaGoSpikeTrap,
				Value = _iwuwagospiketrap
			};
		}

		// Token: 0x06028AE3 RID: 166627 RVA: 0x00596716 File Offset: 0x00594916
		public IWuWaGoStartGridT AsIWuWaGoStartGrid()
		{
			return this.As<IWuWaGoStartGridT>();
		}

		// Token: 0x06028AE4 RID: 166628 RVA: 0x0059671E File Offset: 0x0059491E
		public static TWuWaGoEntityDataUnion FromIWuWaGoStartGrid(IWuWaGoStartGridT _iwuwagostartgrid)
		{
			return new TWuWaGoEntityDataUnion
			{
				Type = TWuWaGoEntityData.IWuWaGoStartGrid,
				Value = _iwuwagostartgrid
			};
		}

		// Token: 0x06028AE5 RID: 166629 RVA: 0x00596734 File Offset: 0x00594934
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
