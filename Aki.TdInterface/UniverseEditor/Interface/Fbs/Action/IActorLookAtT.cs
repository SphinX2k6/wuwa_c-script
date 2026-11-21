using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006734 RID: 26420
	public class IActorLookAtT
	{
		// Token: 0x1700C013 RID: 49171
		// (get) Token: 0x0602CC31 RID: 183345 RVA: 0x0061FBF5 File Offset: 0x0061DDF5
		// (set) Token: 0x0602CC32 RID: 183346 RVA: 0x0061FBFD File Offset: 0x0061DDFD
		public int ActorIndex { get; set; }

		// Token: 0x1700C014 RID: 49172
		// (get) Token: 0x0602CC33 RID: 183347 RVA: 0x0061FC06 File Offset: 0x0061DE06
		// (set) Token: 0x0602CC34 RID: 183348 RVA: 0x0061FC0E File Offset: 0x0061DE0E
		public TActorLookAtDataUnion Target { get; set; }

		// Token: 0x1700C015 RID: 49173
		// (get) Token: 0x0602CC35 RID: 183349 RVA: 0x0061FC17 File Offset: 0x0061DE17
		// (set) Token: 0x0602CC36 RID: 183350 RVA: 0x0061FC1F File Offset: 0x0061DE1F
		public float DelayTime { get; set; }

		// Token: 0x1700C016 RID: 49174
		// (get) Token: 0x0602CC37 RID: 183351 RVA: 0x0061FC28 File Offset: 0x0061DE28
		// (set) Token: 0x0602CC38 RID: 183352 RVA: 0x0061FC30 File Offset: 0x0061DE30
		public float LookAtSpeedRate { get; set; }

		// Token: 0x1700C017 RID: 49175
		// (get) Token: 0x0602CC39 RID: 183353 RVA: 0x0061FC39 File Offset: 0x0061DE39
		// (set) Token: 0x0602CC3A RID: 183354 RVA: 0x0061FC41 File Offset: 0x0061DE41
		public byte NullMask { get; set; }

		// Token: 0x0602CC3B RID: 183355 RVA: 0x0061FC4A File Offset: 0x0061DE4A
		public IActorLookAtT()
		{
			this.ActorIndex = 0;
			this.Target = null;
			this.DelayTime = 0f;
			this.LookAtSpeedRate = 0f;
			this.NullMask = 0;
		}
	}
}
