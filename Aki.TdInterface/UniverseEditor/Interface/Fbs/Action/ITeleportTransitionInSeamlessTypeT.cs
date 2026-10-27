using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073A1 RID: 29601
	public class ITeleportTransitionInSeamlessTypeT
	{
		// Token: 0x1700E0B2 RID: 57522
		// (get) Token: 0x06035BB7 RID: 220087 RVA: 0x0075095C File Offset: 0x0074EB5C
		// (set) Token: 0x06035BB8 RID: 220088 RVA: 0x00750964 File Offset: 0x0074EB64
		public ETeleportTransitionType Type { get; set; }

		// Token: 0x1700E0B3 RID: 57523
		// (get) Token: 0x06035BB9 RID: 220089 RVA: 0x0075096D File Offset: 0x0074EB6D
		// (set) Token: 0x06035BBA RID: 220090 RVA: 0x00750975 File Offset: 0x0074EB75
		public string EffectDaPath { get; set; }

		// Token: 0x1700E0B4 RID: 57524
		// (get) Token: 0x06035BBB RID: 220091 RVA: 0x0075097E File Offset: 0x0074EB7E
		// (set) Token: 0x06035BBC RID: 220092 RVA: 0x00750986 File Offset: 0x0074EB86
		public float LeastTime { get; set; }

		// Token: 0x1700E0B5 RID: 57525
		// (get) Token: 0x06035BBD RID: 220093 RVA: 0x0075098F File Offset: 0x0074EB8F
		// (set) Token: 0x06035BBE RID: 220094 RVA: 0x00750997 File Offset: 0x0074EB97
		public float EffectExpandTime { get; set; }

		// Token: 0x1700E0B6 RID: 57526
		// (get) Token: 0x06035BBF RID: 220095 RVA: 0x007509A0 File Offset: 0x0074EBA0
		// (set) Token: 0x06035BC0 RID: 220096 RVA: 0x007509A8 File Offset: 0x0074EBA8
		public float EffectCollapseTime { get; set; }

		// Token: 0x1700E0B7 RID: 57527
		// (get) Token: 0x06035BC1 RID: 220097 RVA: 0x007509B1 File Offset: 0x0074EBB1
		// (set) Token: 0x06035BC2 RID: 220098 RVA: 0x007509B9 File Offset: 0x0074EBB9
		public string SceneEffectDaPath { get; set; }

		// Token: 0x1700E0B8 RID: 57528
		// (get) Token: 0x06035BC3 RID: 220099 RVA: 0x007509C2 File Offset: 0x0074EBC2
		// (set) Token: 0x06035BC4 RID: 220100 RVA: 0x007509CA File Offset: 0x0074EBCA
		public string TransitionWeatherDaPath { get; set; }

		// Token: 0x1700E0B9 RID: 57529
		// (get) Token: 0x06035BC5 RID: 220101 RVA: 0x007509D3 File Offset: 0x0074EBD3
		// (set) Token: 0x06035BC6 RID: 220102 RVA: 0x007509DB File Offset: 0x0074EBDB
		public IFloorSettingsT FloorSettings { get; set; }

		// Token: 0x1700E0BA RID: 57530
		// (get) Token: 0x06035BC7 RID: 220103 RVA: 0x007509E4 File Offset: 0x0074EBE4
		// (set) Token: 0x06035BC8 RID: 220104 RVA: 0x007509EC File Offset: 0x0074EBEC
		public bool IsTeleportInPlace { get; set; }

		// Token: 0x1700E0BB RID: 57531
		// (get) Token: 0x06035BC9 RID: 220105 RVA: 0x007509F5 File Offset: 0x0074EBF5
		// (set) Token: 0x06035BCA RID: 220106 RVA: 0x007509FD File Offset: 0x0074EBFD
		public List<EKeepMovementState> KeepMovementStates { get; set; }

		// Token: 0x1700E0BC RID: 57532
		// (get) Token: 0x06035BCB RID: 220107 RVA: 0x00750A06 File Offset: 0x0074EC06
		// (set) Token: 0x06035BCC RID: 220108 RVA: 0x00750A0E File Offset: 0x0074EC0E
		public ISeamlessTeleportFinishConfigT SeamlessTeleportFinishConfig { get; set; }

		// Token: 0x1700E0BD RID: 57533
		// (get) Token: 0x06035BCD RID: 220109 RVA: 0x00750A17 File Offset: 0x0074EC17
		// (set) Token: 0x06035BCE RID: 220110 RVA: 0x00750A1F File Offset: 0x0074EC1F
		public bool IsNormalStreamingLoad { get; set; }

		// Token: 0x1700E0BE RID: 57534
		// (get) Token: 0x06035BCF RID: 220111 RVA: 0x00750A28 File Offset: 0x0074EC28
		// (set) Token: 0x06035BD0 RID: 220112 RVA: 0x00750A30 File Offset: 0x0074EC30
		public byte NullMask { get; set; }

		// Token: 0x06035BD1 RID: 220113 RVA: 0x00750A3C File Offset: 0x0074EC3C
		public ITeleportTransitionInSeamlessTypeT()
		{
			this.Type = ETeleportTransitionType.PlayMp4;
			this.EffectDaPath = null;
			this.LeastTime = 0f;
			this.EffectExpandTime = 0f;
			this.EffectCollapseTime = 0f;
			this.SceneEffectDaPath = null;
			this.TransitionWeatherDaPath = null;
			this.FloorSettings = null;
			this.IsTeleportInPlace = false;
			this.KeepMovementStates = null;
			this.SeamlessTeleportFinishConfig = null;
			this.IsNormalStreamingLoad = false;
			this.NullMask = 0;
		}
	}
}
