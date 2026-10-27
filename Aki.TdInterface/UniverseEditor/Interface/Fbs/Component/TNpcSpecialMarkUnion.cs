using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C76 RID: 23670
	public class TNpcSpecialMarkUnion
	{
		// Token: 0x1700B22C RID: 45612
		// (get) Token: 0x060288D9 RID: 166105 RVA: 0x00593812 File Offset: 0x00591A12
		// (set) Token: 0x060288DA RID: 166106 RVA: 0x0059381A File Offset: 0x00591A1A
		public TNpcSpecialMark Type { get; set; }

		// Token: 0x1700B22D RID: 45613
		// (get) Token: 0x060288DB RID: 166107 RVA: 0x00593823 File Offset: 0x00591A23
		// (set) Token: 0x060288DC RID: 166108 RVA: 0x0059382B File Offset: 0x00591A2B
		public object Value { get; set; }

		// Token: 0x060288DD RID: 166109 RVA: 0x00593834 File Offset: 0x00591A34
		public TNpcSpecialMarkUnion()
		{
			this.Type = TNpcSpecialMark.NONE;
			this.Value = null;
		}

		// Token: 0x060288DE RID: 166110 RVA: 0x0059384A File Offset: 0x00591A4A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060288DF RID: 166111 RVA: 0x0059385C File Offset: 0x00591A5C
		public INpcSpecialMarkIgnoreCameraHideNpcT AsINpcSpecialMarkIgnoreCameraHideNpc()
		{
			return this.As<INpcSpecialMarkIgnoreCameraHideNpcT>();
		}

		// Token: 0x060288E0 RID: 166112 RVA: 0x00593864 File Offset: 0x00591A64
		public static TNpcSpecialMarkUnion FromINpcSpecialMarkIgnoreCameraHideNpc(INpcSpecialMarkIgnoreCameraHideNpcT _inpcspecialmarkignorecamerahidenpc)
		{
			return new TNpcSpecialMarkUnion
			{
				Type = TNpcSpecialMark.INpcSpecialMarkIgnoreCameraHideNpc,
				Value = _inpcspecialmarkignorecamerahidenpc
			};
		}

		// Token: 0x060288E1 RID: 166113 RVA: 0x00593879 File Offset: 0x00591A79
		public INpcSpecialMarkTrafficLightT AsINpcSpecialMarkTrafficLight()
		{
			return this.As<INpcSpecialMarkTrafficLightT>();
		}

		// Token: 0x060288E2 RID: 166114 RVA: 0x00593881 File Offset: 0x00591A81
		public static TNpcSpecialMarkUnion FromINpcSpecialMarkTrafficLight(INpcSpecialMarkTrafficLightT _inpcspecialmarktrafficlight)
		{
			return new TNpcSpecialMarkUnion
			{
				Type = TNpcSpecialMark.INpcSpecialMarkTrafficLight,
				Value = _inpcspecialmarktrafficlight
			};
		}

		// Token: 0x060288E3 RID: 166115 RVA: 0x00593898 File Offset: 0x00591A98
		public static int Pack(FlatBufferBuilder builder, TNpcSpecialMarkUnion _o)
		{
			TNpcSpecialMark type = _o.Type;
			if (type == TNpcSpecialMark.INpcSpecialMarkIgnoreCameraHideNpc)
			{
				return INpcSpecialMarkIgnoreCameraHideNpc.Pack(builder, _o.AsINpcSpecialMarkIgnoreCameraHideNpc()).Value;
			}
			if (type != TNpcSpecialMark.INpcSpecialMarkTrafficLight)
			{
				return 0;
			}
			return INpcSpecialMarkTrafficLight.Pack(builder, _o.AsINpcSpecialMarkTrafficLight()).Value;
		}
	}
}
