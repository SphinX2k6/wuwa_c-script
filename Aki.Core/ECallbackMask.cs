using System;

// Token: 0x0200001C RID: 28
public enum ECallbackMask
{
	// Token: 0x04000097 RID: 151
	EndOfEvent = 1,
	// Token: 0x04000098 RID: 152
	Marker = 4,
	// Token: 0x04000099 RID: 153
	Duration = 8,
	// Token: 0x0400009A RID: 154
	Starvation = 32,
	// Token: 0x0400009B RID: 155
	MusicPlayStarted = 128,
	// Token: 0x0400009C RID: 156
	MusicSyncBeat = 256,
	// Token: 0x0400009D RID: 157
	MusicSyncBar = 512,
	// Token: 0x0400009E RID: 158
	MusicSyncEntry = 1024,
	// Token: 0x0400009F RID: 159
	MusicSyncExit = 2048,
	// Token: 0x040000A0 RID: 160
	MusicSyncGrid = 4096,
	// Token: 0x040000A1 RID: 161
	MusicSyncUserCue = 8192,
	// Token: 0x040000A2 RID: 162
	MusicSyncPoint = 16384,
	// Token: 0x040000A3 RID: 163
	MIDIEvent = 32768,
	// Token: 0x040000A4 RID: 164
	EnableGetSourcePlayPosition = 0
}
