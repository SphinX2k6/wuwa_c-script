using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200766C RID: 30316
	public class TCheckFlowLookAtTargetUnion
	{
		// Token: 0x1700E5DB RID: 58843
		// (get) Token: 0x060372DE RID: 226014 RVA: 0x0077AEBC File Offset: 0x007790BC
		// (set) Token: 0x060372DF RID: 226015 RVA: 0x0077AEC4 File Offset: 0x007790C4
		public TCheckFlowLookAtTarget Type { get; set; }

		// Token: 0x1700E5DC RID: 58844
		// (get) Token: 0x060372E0 RID: 226016 RVA: 0x0077AECD File Offset: 0x007790CD
		// (set) Token: 0x060372E1 RID: 226017 RVA: 0x0077AED5 File Offset: 0x007790D5
		public object Value { get; set; }

		// Token: 0x060372E2 RID: 226018 RVA: 0x0077AEDE File Offset: 0x007790DE
		public TCheckFlowLookAtTargetUnion()
		{
			this.Type = TCheckFlowLookAtTarget.NONE;
			this.Value = null;
		}

		// Token: 0x060372E3 RID: 226019 RVA: 0x0077AEF4 File Offset: 0x007790F4
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060372E4 RID: 226020 RVA: 0x0077AF06 File Offset: 0x00779106
		public ICheckFlowLookAtEntityT AsICheckFlowLookAtEntity()
		{
			return this.As<ICheckFlowLookAtEntityT>();
		}

		// Token: 0x060372E5 RID: 226021 RVA: 0x0077AF0E File Offset: 0x0077910E
		public static TCheckFlowLookAtTargetUnion FromICheckFlowLookAtEntity(ICheckFlowLookAtEntityT _icheckflowlookatentity)
		{
			return new TCheckFlowLookAtTargetUnion
			{
				Type = TCheckFlowLookAtTarget.ICheckFlowLookAtEntity,
				Value = _icheckflowlookatentity
			};
		}

		// Token: 0x060372E6 RID: 226022 RVA: 0x0077AF23 File Offset: 0x00779123
		public ICheckFlowLookAtPlayerT AsICheckFlowLookAtPlayer()
		{
			return this.As<ICheckFlowLookAtPlayerT>();
		}

		// Token: 0x060372E7 RID: 226023 RVA: 0x0077AF2B File Offset: 0x0077912B
		public static TCheckFlowLookAtTargetUnion FromICheckFlowLookAtPlayer(ICheckFlowLookAtPlayerT _icheckflowlookatplayer)
		{
			return new TCheckFlowLookAtTargetUnion
			{
				Type = TCheckFlowLookAtTarget.ICheckFlowLookAtPlayer,
				Value = _icheckflowlookatplayer
			};
		}

		// Token: 0x060372E8 RID: 226024 RVA: 0x0077AF40 File Offset: 0x00779140
		public static int Pack(FlatBufferBuilder builder, TCheckFlowLookAtTargetUnion _o)
		{
			TCheckFlowLookAtTarget type = _o.Type;
			if (type == TCheckFlowLookAtTarget.ICheckFlowLookAtEntity)
			{
				return ICheckFlowLookAtEntity.Pack(builder, _o.AsICheckFlowLookAtEntity()).Value;
			}
			if (type != TCheckFlowLookAtTarget.ICheckFlowLookAtPlayer)
			{
				return 0;
			}
			return ICheckFlowLookAtPlayer.Pack(builder, _o.AsICheckFlowLookAtPlayer()).Value;
		}
	}
}
