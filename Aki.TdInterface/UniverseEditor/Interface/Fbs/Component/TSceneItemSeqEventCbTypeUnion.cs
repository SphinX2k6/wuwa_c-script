using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CA0 RID: 23712
	public class TSceneItemSeqEventCbTypeUnion
	{
		// Token: 0x1700B248 RID: 45640
		// (get) Token: 0x060289AB RID: 166315 RVA: 0x00594B8E File Offset: 0x00592D8E
		// (set) Token: 0x060289AC RID: 166316 RVA: 0x00594B96 File Offset: 0x00592D96
		public TSceneItemSeqEventCbType Type { get; set; }

		// Token: 0x1700B249 RID: 45641
		// (get) Token: 0x060289AD RID: 166317 RVA: 0x00594B9F File Offset: 0x00592D9F
		// (set) Token: 0x060289AE RID: 166318 RVA: 0x00594BA7 File Offset: 0x00592DA7
		public object Value { get; set; }

		// Token: 0x060289AF RID: 166319 RVA: 0x00594BB0 File Offset: 0x00592DB0
		public TSceneItemSeqEventCbTypeUnion()
		{
			this.Type = TSceneItemSeqEventCbType.NONE;
			this.Value = null;
		}

		// Token: 0x060289B0 RID: 166320 RVA: 0x00594BC6 File Offset: 0x00592DC6
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060289B1 RID: 166321 RVA: 0x00594BD8 File Offset: 0x00592DD8
		public IAnEventT AsIAnEvent()
		{
			return this.As<IAnEventT>();
		}

		// Token: 0x060289B2 RID: 166322 RVA: 0x00594BE0 File Offset: 0x00592DE0
		public static TSceneItemSeqEventCbTypeUnion FromIAnEvent(IAnEventT _ianevent)
		{
			return new TSceneItemSeqEventCbTypeUnion
			{
				Type = TSceneItemSeqEventCbType.IAnEvent,
				Value = _ianevent
			};
		}

		// Token: 0x060289B3 RID: 166323 RVA: 0x00594BF5 File Offset: 0x00592DF5
		public IAnsEventT AsIAnsEvent()
		{
			return this.As<IAnsEventT>();
		}

		// Token: 0x060289B4 RID: 166324 RVA: 0x00594BFD File Offset: 0x00592DFD
		public static TSceneItemSeqEventCbTypeUnion FromIAnsEvent(IAnsEventT _iansevent)
		{
			return new TSceneItemSeqEventCbTypeUnion
			{
				Type = TSceneItemSeqEventCbType.IAnsEvent,
				Value = _iansevent
			};
		}

		// Token: 0x060289B5 RID: 166325 RVA: 0x00594C14 File Offset: 0x00592E14
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
