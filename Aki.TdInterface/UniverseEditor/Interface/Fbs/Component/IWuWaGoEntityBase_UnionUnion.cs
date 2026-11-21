using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061BE RID: 25022
	public class IWuWaGoEntityBase_UnionUnion
	{
		// Token: 0x1700BA94 RID: 47764
		// (get) Token: 0x0602A88F RID: 174223 RVA: 0x005CD101 File Offset: 0x005CB301
		// (set) Token: 0x0602A890 RID: 174224 RVA: 0x005CD109 File Offset: 0x005CB309
		public IWuWaGoEntityBase_Union Type { get; set; }

		// Token: 0x1700BA95 RID: 47765
		// (get) Token: 0x0602A891 RID: 174225 RVA: 0x005CD112 File Offset: 0x005CB312
		// (set) Token: 0x0602A892 RID: 174226 RVA: 0x005CD11A File Offset: 0x005CB31A
		public object Value { get; set; }

		// Token: 0x0602A893 RID: 174227 RVA: 0x005CD123 File Offset: 0x005CB323
		public IWuWaGoEntityBase_UnionUnion()
		{
			this.Type = IWuWaGoEntityBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602A894 RID: 174228 RVA: 0x005CD139 File Offset: 0x005CB339
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602A895 RID: 174229 RVA: 0x005CD14B File Offset: 0x005CB34B
		public IWuWaGoEntityBaseT AsIWuWaGoEntityBase()
		{
			return this.As<IWuWaGoEntityBaseT>();
		}

		// Token: 0x0602A896 RID: 174230 RVA: 0x005CD153 File Offset: 0x005CB353
		public static IWuWaGoEntityBase_UnionUnion FromIWuWaGoEntityBase(IWuWaGoEntityBaseT _iwuwagoentitybase)
		{
			return new IWuWaGoEntityBase_UnionUnion
			{
				Type = IWuWaGoEntityBase_Union.IWuWaGoEntityBase,
				Value = _iwuwagoentitybase
			};
		}

		// Token: 0x0602A897 RID: 174231 RVA: 0x005CD168 File Offset: 0x005CB368
		public IWuWaGoLevelCenterT AsIWuWaGoLevelCenter()
		{
			return this.As<IWuWaGoLevelCenterT>();
		}

		// Token: 0x0602A898 RID: 174232 RVA: 0x005CD170 File Offset: 0x005CB370
		public static IWuWaGoEntityBase_UnionUnion FromIWuWaGoLevelCenter(IWuWaGoLevelCenterT _iwuwagolevelcenter)
		{
			return new IWuWaGoEntityBase_UnionUnion
			{
				Type = IWuWaGoEntityBase_Union.IWuWaGoLevelCenter,
				Value = _iwuwagolevelcenter
			};
		}

		// Token: 0x0602A899 RID: 174233 RVA: 0x005CD185 File Offset: 0x005CB385
		public IWuWaGoMovableFloorT AsIWuWaGoMovableFloor()
		{
			return this.As<IWuWaGoMovableFloorT>();
		}

		// Token: 0x0602A89A RID: 174234 RVA: 0x005CD18D File Offset: 0x005CB38D
		public static IWuWaGoEntityBase_UnionUnion FromIWuWaGoMovableFloor(IWuWaGoMovableFloorT _iwuwagomovablefloor)
		{
			return new IWuWaGoEntityBase_UnionUnion
			{
				Type = IWuWaGoEntityBase_Union.IWuWaGoMovableFloor,
				Value = _iwuwagomovablefloor
			};
		}

		// Token: 0x0602A89B RID: 174235 RVA: 0x005CD1A2 File Offset: 0x005CB3A2
		public IWuWaGoPullRodT AsIWuWaGoPullRod()
		{
			return this.As<IWuWaGoPullRodT>();
		}

		// Token: 0x0602A89C RID: 174236 RVA: 0x005CD1AA File Offset: 0x005CB3AA
		public static IWuWaGoEntityBase_UnionUnion FromIWuWaGoPullRod(IWuWaGoPullRodT _iwuwagopullrod)
		{
			return new IWuWaGoEntityBase_UnionUnion
			{
				Type = IWuWaGoEntityBase_Union.IWuWaGoPullRod,
				Value = _iwuwagopullrod
			};
		}

		// Token: 0x0602A89D RID: 174237 RVA: 0x005CD1BF File Offset: 0x005CB3BF
		public IWuWaGoPressureTriggerT AsIWuWaGoPressureTrigger()
		{
			return this.As<IWuWaGoPressureTriggerT>();
		}

		// Token: 0x0602A89E RID: 174238 RVA: 0x005CD1C7 File Offset: 0x005CB3C7
		public static IWuWaGoEntityBase_UnionUnion FromIWuWaGoPressureTrigger(IWuWaGoPressureTriggerT _iwuwagopressuretrigger)
		{
			return new IWuWaGoEntityBase_UnionUnion
			{
				Type = IWuWaGoEntityBase_Union.IWuWaGoPressureTrigger,
				Value = _iwuwagopressuretrigger
			};
		}

		// Token: 0x0602A89F RID: 174239 RVA: 0x005CD1DC File Offset: 0x005CB3DC
		public IWuWaGoGearT AsIWuWaGoGear()
		{
			return this.As<IWuWaGoGearT>();
		}

		// Token: 0x0602A8A0 RID: 174240 RVA: 0x005CD1E4 File Offset: 0x005CB3E4
		public static IWuWaGoEntityBase_UnionUnion FromIWuWaGoGear(IWuWaGoGearT _iwuwagogear)
		{
			return new IWuWaGoEntityBase_UnionUnion
			{
				Type = IWuWaGoEntityBase_Union.IWuWaGoGear,
				Value = _iwuwagogear
			};
		}

		// Token: 0x0602A8A1 RID: 174241 RVA: 0x005CD1F9 File Offset: 0x005CB3F9
		public IWuWaGoSpikeTrapT AsIWuWaGoSpikeTrap()
		{
			return this.As<IWuWaGoSpikeTrapT>();
		}

		// Token: 0x0602A8A2 RID: 174242 RVA: 0x005CD201 File Offset: 0x005CB401
		public static IWuWaGoEntityBase_UnionUnion FromIWuWaGoSpikeTrap(IWuWaGoSpikeTrapT _iwuwagospiketrap)
		{
			return new IWuWaGoEntityBase_UnionUnion
			{
				Type = IWuWaGoEntityBase_Union.IWuWaGoSpikeTrap,
				Value = _iwuwagospiketrap
			};
		}

		// Token: 0x0602A8A3 RID: 174243 RVA: 0x005CD216 File Offset: 0x005CB416
		public IWuWaGoBowTrapT AsIWuWaGoBowTrap()
		{
			return this.As<IWuWaGoBowTrapT>();
		}

		// Token: 0x0602A8A4 RID: 174244 RVA: 0x005CD21E File Offset: 0x005CB41E
		public static IWuWaGoEntityBase_UnionUnion FromIWuWaGoBowTrap(IWuWaGoBowTrapT _iwuwagobowtrap)
		{
			return new IWuWaGoEntityBase_UnionUnion
			{
				Type = IWuWaGoEntityBase_Union.IWuWaGoBowTrap,
				Value = _iwuwagobowtrap
			};
		}

		// Token: 0x0602A8A5 RID: 174245 RVA: 0x005CD233 File Offset: 0x005CB433
		public IWuWaGoSaveGridT AsIWuWaGoSaveGrid()
		{
			return this.As<IWuWaGoSaveGridT>();
		}

		// Token: 0x0602A8A6 RID: 174246 RVA: 0x005CD23B File Offset: 0x005CB43B
		public static IWuWaGoEntityBase_UnionUnion FromIWuWaGoSaveGrid(IWuWaGoSaveGridT _iwuwagosavegrid)
		{
			return new IWuWaGoEntityBase_UnionUnion
			{
				Type = IWuWaGoEntityBase_Union.IWuWaGoSaveGrid,
				Value = _iwuwagosavegrid
			};
		}

		// Token: 0x0602A8A7 RID: 174247 RVA: 0x005CD251 File Offset: 0x005CB451
		public IWuWaGoEndGridT AsIWuWaGoEndGrid()
		{
			return this.As<IWuWaGoEndGridT>();
		}

		// Token: 0x0602A8A8 RID: 174248 RVA: 0x005CD259 File Offset: 0x005CB459
		public static IWuWaGoEntityBase_UnionUnion FromIWuWaGoEndGrid(IWuWaGoEndGridT _iwuwagoendgrid)
		{
			return new IWuWaGoEntityBase_UnionUnion
			{
				Type = IWuWaGoEntityBase_Union.IWuWaGoEndGrid,
				Value = _iwuwagoendgrid
			};
		}

		// Token: 0x0602A8A9 RID: 174249 RVA: 0x005CD26F File Offset: 0x005CB46F
		public IWuWaGoStartGridT AsIWuWaGoStartGrid()
		{
			return this.As<IWuWaGoStartGridT>();
		}

		// Token: 0x0602A8AA RID: 174250 RVA: 0x005CD277 File Offset: 0x005CB477
		public static IWuWaGoEntityBase_UnionUnion FromIWuWaGoStartGrid(IWuWaGoStartGridT _iwuwagostartgrid)
		{
			return new IWuWaGoEntityBase_UnionUnion
			{
				Type = IWuWaGoEntityBase_Union.IWuWaGoStartGrid,
				Value = _iwuwagostartgrid
			};
		}

		// Token: 0x0602A8AB RID: 174251 RVA: 0x005CD290 File Offset: 0x005CB490
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
