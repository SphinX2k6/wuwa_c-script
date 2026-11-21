using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F7F RID: 32639
	public class TPlayerAiControlUnion
	{
		// Token: 0x1700F2CD RID: 62157
		// (get) Token: 0x0603AD2D RID: 240941 RVA: 0x007E7F8C File Offset: 0x007E618C
		// (set) Token: 0x0603AD2E RID: 240942 RVA: 0x007E7F94 File Offset: 0x007E6194
		public TPlayerAiControl Type { get; set; }

		// Token: 0x1700F2CE RID: 62158
		// (get) Token: 0x0603AD2F RID: 240943 RVA: 0x007E7F9D File Offset: 0x007E619D
		// (set) Token: 0x0603AD30 RID: 240944 RVA: 0x007E7FA5 File Offset: 0x007E61A5
		public object Value { get; set; }

		// Token: 0x0603AD31 RID: 240945 RVA: 0x007E7FAE File Offset: 0x007E61AE
		public TPlayerAiControlUnion()
		{
			this.Type = TPlayerAiControl.NONE;
			this.Value = null;
		}

		// Token: 0x0603AD32 RID: 240946 RVA: 0x007E7FC4 File Offset: 0x007E61C4
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AD33 RID: 240947 RVA: 0x007E7FD6 File Offset: 0x007E61D6
		public IDisablePlayerAiControlT AsIDisablePlayerAiControl()
		{
			return this.As<IDisablePlayerAiControlT>();
		}

		// Token: 0x0603AD34 RID: 240948 RVA: 0x007E7FDE File Offset: 0x007E61DE
		public static TPlayerAiControlUnion FromIDisablePlayerAiControl(IDisablePlayerAiControlT _idisableplayeraicontrol)
		{
			return new TPlayerAiControlUnion
			{
				Type = TPlayerAiControl.IDisablePlayerAiControl,
				Value = _idisableplayeraicontrol
			};
		}

		// Token: 0x0603AD35 RID: 240949 RVA: 0x007E7FF3 File Offset: 0x007E61F3
		public IEnablePlayerAiControlT AsIEnablePlayerAiControl()
		{
			return this.As<IEnablePlayerAiControlT>();
		}

		// Token: 0x0603AD36 RID: 240950 RVA: 0x007E7FFB File Offset: 0x007E61FB
		public static TPlayerAiControlUnion FromIEnablePlayerAiControl(IEnablePlayerAiControlT _ienableplayeraicontrol)
		{
			return new TPlayerAiControlUnion
			{
				Type = TPlayerAiControl.IEnablePlayerAiControl,
				Value = _ienableplayeraicontrol
			};
		}

		// Token: 0x0603AD37 RID: 240951 RVA: 0x007E8010 File Offset: 0x007E6210
		public static int Pack(FlatBufferBuilder builder, TPlayerAiControlUnion _o)
		{
			TPlayerAiControl type = _o.Type;
			if (type == TPlayerAiControl.IDisablePlayerAiControl)
			{
				return IDisablePlayerAiControl.Pack(builder, _o.AsIDisablePlayerAiControl()).Value;
			}
			if (type != TPlayerAiControl.IEnablePlayerAiControl)
			{
				return 0;
			}
			return IEnablePlayerAiControl.Pack(builder, _o.AsIEnablePlayerAiControl()).Value;
		}
	}
}
