using System;

// Token: 0x0200001C RID: 28
public enum ECallbackMask
{
	// Token: 0x04000098 RID: 152
	EndOfEvent = 1,
	// Token: 0x04000099 RID: 153
	Marker = 4,
	// Token: 0x0400009A RID: 154
	Duration = 8,
	// Token: 0x0400009B RID: 155
	Starvation = 32,
	// Token: 0x0400009C RID: 156
	MusicPlayStarted = 128,
	// Token: 0x0400009D RID: 157
	MusicSyncBeat = 256,
	// Token: 0x0400009E RID: 158
	MusicSyncBar = 512,
	// Token: 0x0400009F RID: 159
	MusicSyncEntry = 1024,
	// Token: 0x040000A0 RID: 160
	MusicSyncExit = 2048,
	// Token: 0x040000A1 RID: 161
	MusicSyncGrid = 4096,
	// Token: 0x040000A2 RID: 162
	MusicSyncUserCue = 8192,
	// Token: 0x040000A3 RID: 163
	MusicSyncPoint = 16384,
	// Token: 0x040000A4 RID: 164
	MIDIEvent = 32768,
	// Token: 0x040000A5 RID: 165
	EnableGetSourcePlayPosition = 0
}
