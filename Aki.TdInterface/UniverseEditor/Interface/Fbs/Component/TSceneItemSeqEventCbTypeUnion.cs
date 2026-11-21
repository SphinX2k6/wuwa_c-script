using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062D1 RID: 25297
	public class TSceneItemSeqEventCbTypeUnion
	{
		// Token: 0x1700BBA2 RID: 48034
		// (get) Token: 0x0602AFF3 RID: 176115 RVA: 0x005DD304 File Offset: 0x005DB504
		// (set) Token: 0x0602AFF4 RID: 176116 RVA: 0x005DD30C File Offset: 0x005DB50C
		public TSceneItemSeqEventCbType Type { get; set; }

		// Token: 0x1700BBA3 RID: 48035
		// (get) Token: 0x0602AFF5 RID: 176117 RVA: 0x005DD315 File Offset: 0x005DB515
		// (set) Token: 0x0602AFF6 RID: 176118 RVA: 0x005DD31D File Offset: 0x005DB51D
		public object Value { get; set; }

		// Token: 0x0602AFF7 RID: 176119 RVA: 0x005DD326 File Offset: 0x005DB526
		public TSceneItemSeqEventCbTypeUnion()
		{
			this.Type = TSceneItemSeqEventCbType.NONE;
			this.Value = null;
		}

		// Token: 0x0602AFF8 RID: 176120 RVA: 0x005DD33C File Offset: 0x005DB53C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AFF9 RID: 176121 RVA: 0x005DD34E File Offset: 0x005DB54E
		public IAnEventT AsIAnEvent()
		{
			return this.As<IAnEventT>();
		}

		// Token: 0x0602AFFA RID: 176122 RVA: 0x005DD356 File Offset: 0x005DB556
		public static TSceneItemSeqEventCbTypeUnion FromIAnEvent(IAnEventT _ianevent)
		{
			return new TSceneItemSeqEventCbTypeUnion
			{
				Type = TSceneItemSeqEventCbType.IAnEvent,
				Value = _ianevent
			};
		}

		// Token: 0x0602AFFB RID: 176123 RVA: 0x005DD36B File Offset: 0x005DB56B
		public IAnsEventT AsIAnsEvent()
		{
			return this.As<IAnsEventT>();
		}

		// Token: 0x0602AFFC RID: 176124 RVA: 0x005DD373 File Offset: 0x005DB573
		public static TSceneItemSeqEventCbTypeUnion FromIAnsEvent(IAnsEventT _iansevent)
		{
			return new TSceneItemSeqEventCbTypeUnion
			{
				Type = TSceneItemSeqEventCbType.IAnsEvent,
				Value = _iansevent
			};
		}

		// Token: 0x0602AFFD RID: 176125 RVA: 0x005DD388 File Offset: 0x005DB588
		public static int Pack(FlatBufferBuilder builder, TSceneItemSeqEventCbTypeUnion _o)
		{
			TSceneItemSeqEventCbType type = _o.Type;
			if (type == TSceneItemSeqEventCbType.IAnEvent)
			{
				return IAnEvent.Pack(builder, _o.AsIAnEvent()).Value;
			}
			if (type != TSceneItemSeqEventCbType.IAnsEvent)
			{
				return 0;
			}
			return IAnsEvent.Pack(builder, _o.AsIAnsEvent()).Value;
		}
	}
}
