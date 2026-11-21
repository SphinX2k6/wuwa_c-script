using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D9E RID: 19870
	public class ILoopTeleportClientLogicItemBase_UnionUnion
	{
		// Token: 0x17008E2B RID: 36395
		// (get) Token: 0x0601ED11 RID: 126225 RVA: 0x0044EC3D File Offset: 0x0044CE3D
		// (set) Token: 0x0601ED12 RID: 126226 RVA: 0x0044EC45 File Offset: 0x0044CE45
		public ILoopTeleportClientLogicItemBase_Union Type { get; set; }

		// Token: 0x17008E2C RID: 36396
		// (get) Token: 0x0601ED13 RID: 126227 RVA: 0x0044EC4E File Offset: 0x0044CE4E
		// (set) Token: 0x0601ED14 RID: 126228 RVA: 0x0044EC56 File Offset: 0x0044CE56
		public object Value { get; set; }

		// Token: 0x0601ED15 RID: 126229 RVA: 0x0044EC5F File Offset: 0x0044CE5F
		public ILoopTeleportClientLogicItemBase_UnionUnion()
		{
			this.Type = ILoopTeleportClientLogicItemBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601ED16 RID: 126230 RVA: 0x0044EC75 File Offset: 0x0044CE75
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601ED17 RID: 126231 RVA: 0x0044EC87 File Offset: 0x0044CE87
		public ILoopTeleportClientLogicItemBaseT AsILoopTeleportClientLogicItemBase()
		{
			return this.As<ILoopTeleportClientLogicItemBaseT>();
		}

		// Token: 0x0601ED18 RID: 126232 RVA: 0x0044EC8F File Offset: 0x0044CE8F
		public static ILoopTeleportClientLogicItemBase_UnionUnion FromILoopTeleportClientLogicItemBase(ILoopTeleportClientLogicItemBaseT _iloopteleportclientlogicitembase)
		{
			return new ILoopTeleportClientLogicItemBase_UnionUnion
			{
				Type = ILoopTeleportClientLogicItemBase_Union.ILoopTeleportClientLogicItemBase,
				Value = _iloopteleportclientlogicitembase
			};
		}

		// Token: 0x0601ED19 RID: 126233 RVA: 0x0044ECA4 File Offset: 0x0044CEA4
		public ILoopTeleportClientPlayEffectLogicT AsILoopTeleportClientPlayEffectLogic()
		{
			return this.As<ILoopTeleportClientPlayEffectLogicT>();
		}

		// Token: 0x0601ED1A RID: 126234 RVA: 0x0044ECAC File Offset: 0x0044CEAC
		public static ILoopTeleportClientLogicItemBase_UnionUnion FromILoopTeleportClientPlayEffectLogic(ILoopTeleportClientPlayEffectLogicT _iloopteleportclientplayeffectlogic)
		{
			return new ILoopTeleportClientLogicItemBase_UnionUnion
			{
				Type = ILoopTeleportClientLogicItemBase_Union.ILoopTeleportClientPlayEffectLogic,
				Value = _iloopteleportclientplayeffectlogic
			};
		}

		// Token: 0x0601ED1B RID: 126235 RVA: 0x0044ECC4 File Offset: 0x0044CEC4
		public static int Pack(FlatBufferBuilder builder, ILoopTeleportClientLogicItemBase_UnionUnion _o)
		{
			ILoopTeleportClientLogicItemBase_Union type = _o.Type;
			if (type == ILoopTeleportClientLogicItemBase_Union.ILoopTeleportClientLogicItemBase)
			{
				return ILoopTeleportClientLogicItemBase.Pack(builder, _o.AsILoopTeleportClientLogicItemBase()).Value;
			}
			if (type != ILoopTeleportClientLogicItemBase_Union.ILoopTeleportClientPlayEffectLogic)
			{
				return 0;
			}
			return ILoopTeleportClientPlayEffectLogic.Pack(builder, _o.AsILoopTeleportClientPlayEffectLogic()).Value;
		}
	}
}
