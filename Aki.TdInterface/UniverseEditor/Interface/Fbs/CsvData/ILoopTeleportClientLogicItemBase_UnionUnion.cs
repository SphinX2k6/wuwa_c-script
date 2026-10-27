using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004903 RID: 18691
	public class ILoopTeleportClientLogicItemBase_UnionUnion
	{
		// Token: 0x17008788 RID: 34696
		// (get) Token: 0x0601D378 RID: 119672 RVA: 0x0041F4DD File Offset: 0x0041D6DD
		// (set) Token: 0x0601D379 RID: 119673 RVA: 0x0041F4E5 File Offset: 0x0041D6E5
		public ILoopTeleportClientLogicItemBase_Union Type { get; set; }

		// Token: 0x17008789 RID: 34697
		// (get) Token: 0x0601D37A RID: 119674 RVA: 0x0041F4EE File Offset: 0x0041D6EE
		// (set) Token: 0x0601D37B RID: 119675 RVA: 0x0041F4F6 File Offset: 0x0041D6F6
		public object Value { get; set; }

		// Token: 0x0601D37C RID: 119676 RVA: 0x0041F4FF File Offset: 0x0041D6FF
		public ILoopTeleportClientLogicItemBase_UnionUnion()
		{
			this.Type = ILoopTeleportClientLogicItemBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601D37D RID: 119677 RVA: 0x0041F515 File Offset: 0x0041D715
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601D37E RID: 119678 RVA: 0x0041F527 File Offset: 0x0041D727
		public ILoopTeleportClientLogicItemBaseT AsILoopTeleportClientLogicItemBase()
		{
			return this.As<ILoopTeleportClientLogicItemBaseT>();
		}

		// Token: 0x0601D37F RID: 119679 RVA: 0x0041F52F File Offset: 0x0041D72F
		public static ILoopTeleportClientLogicItemBase_UnionUnion FromILoopTeleportClientLogicItemBase(ILoopTeleportClientLogicItemBaseT _iloopteleportclientlogicitembase)
		{
			return new ILoopTeleportClientLogicItemBase_UnionUnion
			{
				Type = ILoopTeleportClientLogicItemBase_Union.ILoopTeleportClientLogicItemBase,
				Value = _iloopteleportclientlogicitembase
			};
		}

		// Token: 0x0601D380 RID: 119680 RVA: 0x0041F544 File Offset: 0x0041D744
		public ILoopTeleportClientPlayEffectLogicT AsILoopTeleportClientPlayEffectLogic()
		{
			return this.As<ILoopTeleportClientPlayEffectLogicT>();
		}

		// Token: 0x0601D381 RID: 119681 RVA: 0x0041F54C File Offset: 0x0041D74C
		public static ILoopTeleportClientLogicItemBase_UnionUnion FromILoopTeleportClientPlayEffectLogic(ILoopTeleportClientPlayEffectLogicT _iloopteleportclientplayeffectlogic)
		{
			return new ILoopTeleportClientLogicItemBase_UnionUnion
			{
				Type = ILoopTeleportClientLogicItemBase_Union.ILoopTeleportClientPlayEffectLogic,
				Value = _iloopteleportclientplayeffectlogic
			};
		}

		// Token: 0x0601D382 RID: 119682 RVA: 0x0041F564 File Offset: 0x0041D764
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
