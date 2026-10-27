using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E93 RID: 20115
	public class IAkEventTypeConfig_UnionUnion
	{
		// Token: 0x17009043 RID: 36931
		// (get) Token: 0x0601FA6E RID: 129646 RVA: 0x004687C5 File Offset: 0x004669C5
		// (set) Token: 0x0601FA6F RID: 129647 RVA: 0x004687CD File Offset: 0x004669CD
		public IAkEventTypeConfig_Union Type { get; set; }

		// Token: 0x17009044 RID: 36932
		// (get) Token: 0x0601FA70 RID: 129648 RVA: 0x004687D6 File Offset: 0x004669D6
		// (set) Token: 0x0601FA71 RID: 129649 RVA: 0x004687DE File Offset: 0x004669DE
		public object Value { get; set; }

		// Token: 0x0601FA72 RID: 129650 RVA: 0x004687E7 File Offset: 0x004669E7
		public IAkEventTypeConfig_UnionUnion()
		{
			this.Type = IAkEventTypeConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601FA73 RID: 129651 RVA: 0x004687FD File Offset: 0x004669FD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601FA74 RID: 129652 RVA: 0x0046880F File Offset: 0x00466A0F
		public IAkEventTypeConfigT AsIAkEventTypeConfig()
		{
			return this.As<IAkEventTypeConfigT>();
		}

		// Token: 0x0601FA75 RID: 129653 RVA: 0x00468817 File Offset: 0x00466A17
		public static IAkEventTypeConfig_UnionUnion FromIAkEventTypeConfig(IAkEventTypeConfigT _iakeventtypeconfig)
		{
			return new IAkEventTypeConfig_UnionUnion
			{
				Type = IAkEventTypeConfig_Union.IAkEventTypeConfig,
				Value = _iakeventtypeconfig
			};
		}

		// Token: 0x0601FA76 RID: 129654 RVA: 0x0046882C File Offset: 0x00466A2C
		public IPointAkEventT AsIPointAkEvent()
		{
			return this.As<IPointAkEventT>();
		}

		// Token: 0x0601FA77 RID: 129655 RVA: 0x00468834 File Offset: 0x00466A34
		public static IAkEventTypeConfig_UnionUnion FromIPointAkEvent(IPointAkEventT _ipointakevent)
		{
			return new IAkEventTypeConfig_UnionUnion
			{
				Type = IAkEventTypeConfig_Union.IPointAkEvent,
				Value = _ipointakevent
			};
		}

		// Token: 0x0601FA78 RID: 129656 RVA: 0x00468849 File Offset: 0x00466A49
		public IBoxAkEventT AsIBoxAkEvent()
		{
			return this.As<IBoxAkEventT>();
		}

		// Token: 0x0601FA79 RID: 129657 RVA: 0x00468851 File Offset: 0x00466A51
		public static IAkEventTypeConfig_UnionUnion FromIBoxAkEvent(IBoxAkEventT _iboxakevent)
		{
			return new IAkEventTypeConfig_UnionUnion
			{
				Type = IAkEventTypeConfig_Union.IBoxAkEvent,
				Value = _iboxakevent
			};
		}

		// Token: 0x0601FA7A RID: 129658 RVA: 0x00468866 File Offset: 0x00466A66
		public IDefaultAkEventT AsIDefaultAkEvent()
		{
			return this.As<IDefaultAkEventT>();
		}

		// Token: 0x0601FA7B RID: 129659 RVA: 0x0046886E File Offset: 0x00466A6E
		public static IAkEventTypeConfig_UnionUnion FromIDefaultAkEvent(IDefaultAkEventT _idefaultakevent)
		{
			return new IAkEventTypeConfig_UnionUnion
			{
				Type = IAkEventTypeConfig_Union.IDefaultAkEvent,
				Value = _idefaultakevent
			};
		}

		// Token: 0x0601FA7C RID: 129660 RVA: 0x00468884 File Offset: 0x00466A84
		public static int Pack(FlatBufferBuilder builder, IAkEventTypeConfig_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IAkEventTypeConfig_Union.IAkEventTypeConfig:
				return IAkEventTypeConfig.Pack(builder, _o.AsIAkEventTypeConfig()).Value;
			case IAkEventTypeConfig_Union.IPointAkEvent:
				return IPointAkEvent.Pack(builder, _o.AsIPointAkEvent()).Value;
			case IAkEventTypeConfig_Union.IBoxAkEvent:
				return IBoxAkEvent.Pack(builder, _o.AsIBoxAkEvent()).Value;
			case IAkEventTypeConfig_Union.IDefaultAkEvent:
				return IDefaultAkEvent.Pack(builder, _o.AsIDefaultAkEvent()).Value;
			default:
				return 0;
			}
		}
	}
}
