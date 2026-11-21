using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062FE RID: 25342
	public class TTriggerModeUnion
	{
		// Token: 0x1700BBC0 RID: 48064
		// (get) Token: 0x0602B0CF RID: 176335 RVA: 0x005DE73A File Offset: 0x005DC93A
		// (set) Token: 0x0602B0D0 RID: 176336 RVA: 0x005DE742 File Offset: 0x005DC942
		public TTriggerMode Type { get; set; }

		// Token: 0x1700BBC1 RID: 48065
		// (get) Token: 0x0602B0D1 RID: 176337 RVA: 0x005DE74B File Offset: 0x005DC94B
		// (set) Token: 0x0602B0D2 RID: 176338 RVA: 0x005DE753 File Offset: 0x005DC953
		public object Value { get; set; }

		// Token: 0x0602B0D3 RID: 176339 RVA: 0x005DE75C File Offset: 0x005DC95C
		public TTriggerModeUnion()
		{
			this.Type = TTriggerMode.NONE;
			this.Value = null;
		}

		// Token: 0x0602B0D4 RID: 176340 RVA: 0x005DE772 File Offset: 0x005DC972
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B0D5 RID: 176341 RVA: 0x005DE784 File Offset: 0x005DC984
		public ISkyboxDistanceTriggerT AsISkyboxDistanceTrigger()
		{
			return this.As<ISkyboxDistanceTriggerT>();
		}

		// Token: 0x0602B0D6 RID: 176342 RVA: 0x005DE78C File Offset: 0x005DC98C
		public static TTriggerModeUnion FromISkyboxDistanceTrigger(ISkyboxDistanceTriggerT _iskyboxdistancetrigger)
		{
			return new TTriggerModeUnion
			{
				Type = TTriggerMode.ISkyboxDistanceTrigger,
				Value = _iskyboxdistancetrigger
			};
		}

		// Token: 0x0602B0D7 RID: 176343 RVA: 0x005DE7A1 File Offset: 0x005DC9A1
		public ISkyboxGlobalTriggerT AsISkyboxGlobalTrigger()
		{
			return this.As<ISkyboxGlobalTriggerT>();
		}

		// Token: 0x0602B0D8 RID: 176344 RVA: 0x005DE7A9 File Offset: 0x005DC9A9
		public static TTriggerModeUnion FromISkyboxGlobalTrigger(ISkyboxGlobalTriggerT _iskyboxglobaltrigger)
		{
			return new TTriggerModeUnion
			{
				Type = TTriggerMode.ISkyboxGlobalTrigger,
				Value = _iskyboxglobaltrigger
			};
		}

		// Token: 0x0602B0D9 RID: 176345 RVA: 0x005DE7C0 File Offset: 0x005DC9C0
		public static int Pack(FlatBufferBuilder builder, TTriggerModeUnion _o)
		{
			TTriggerMode type = _o.Type;
			if (type == TTriggerMode.ISkyboxDistanceTrigger)
			{
				return ISkyboxDistanceTrigger.Pack(builder, _o.AsISkyboxDistanceTrigger()).Value;
			}
			if (type != TTriggerMode.ISkyboxGlobalTrigger)
			{
				return 0;
			}
			return ISkyboxGlobalTrigger.Pack(builder, _o.AsISkyboxGlobalTrigger()).Value;
		}
	}
}
