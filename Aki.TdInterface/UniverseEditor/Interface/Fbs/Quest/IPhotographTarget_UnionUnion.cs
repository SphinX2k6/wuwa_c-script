using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043DA RID: 17370
	public class IPhotographTarget_UnionUnion
	{
		// Token: 0x170077A4 RID: 30628
		// (get) Token: 0x06018AA1 RID: 101025 RVA: 0x00384579 File Offset: 0x00382779
		// (set) Token: 0x06018AA2 RID: 101026 RVA: 0x00384581 File Offset: 0x00382781
		public IPhotographTarget_Union Type { get; set; }

		// Token: 0x170077A5 RID: 30629
		// (get) Token: 0x06018AA3 RID: 101027 RVA: 0x0038458A File Offset: 0x0038278A
		// (set) Token: 0x06018AA4 RID: 101028 RVA: 0x00384592 File Offset: 0x00382792
		public object Value { get; set; }

		// Token: 0x06018AA5 RID: 101029 RVA: 0x0038459B File Offset: 0x0038279B
		public IPhotographTarget_UnionUnion()
		{
			this.Type = IPhotographTarget_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06018AA6 RID: 101030 RVA: 0x003845B1 File Offset: 0x003827B1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06018AA7 RID: 101031 RVA: 0x003845C3 File Offset: 0x003827C3
		public IPhotographTargetT AsIPhotographTarget()
		{
			return this.As<IPhotographTargetT>();
		}

		// Token: 0x06018AA8 RID: 101032 RVA: 0x003845CB File Offset: 0x003827CB
		public static IPhotographTarget_UnionUnion FromIPhotographTarget(IPhotographTargetT _iphotographtarget)
		{
			return new IPhotographTarget_UnionUnion
			{
				Type = IPhotographTarget_Union.IPhotographTarget,
				Value = _iphotographtarget
			};
		}

		// Token: 0x06018AA9 RID: 101033 RVA: 0x003845E0 File Offset: 0x003827E0
		public IPhotographTargetPlayerT AsIPhotographTargetPlayer()
		{
			return this.As<IPhotographTargetPlayerT>();
		}

		// Token: 0x06018AAA RID: 101034 RVA: 0x003845E8 File Offset: 0x003827E8
		public static IPhotographTarget_UnionUnion FromIPhotographTargetPlayer(IPhotographTargetPlayerT _iphotographtargetplayer)
		{
			return new IPhotographTarget_UnionUnion
			{
				Type = IPhotographTarget_Union.IPhotographTargetPlayer,
				Value = _iphotographtargetplayer
			};
		}

		// Token: 0x06018AAB RID: 101035 RVA: 0x003845FD File Offset: 0x003827FD
		public IPhotographTargetRolesOnSceneT AsIPhotographTargetRolesOnScene()
		{
			return this.As<IPhotographTargetRolesOnSceneT>();
		}

		// Token: 0x06018AAC RID: 101036 RVA: 0x00384605 File Offset: 0x00382805
		public static IPhotographTarget_UnionUnion FromIPhotographTargetRolesOnScene(IPhotographTargetRolesOnSceneT _iphotographtargetrolesonscene)
		{
			return new IPhotographTarget_UnionUnion
			{
				Type = IPhotographTarget_Union.IPhotographTargetRolesOnScene,
				Value = _iphotographtargetrolesonscene
			};
		}

		// Token: 0x06018AAD RID: 101037 RVA: 0x0038461C File Offset: 0x0038281C
		public static int Pack(FlatBufferBuilder builder, IPhotographTarget_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IPhotographTarget_Union.IPhotographTarget:
				return IPhotographTarget.Pack(builder, _o.AsIPhotographTarget()).Value;
			case IPhotographTarget_Union.IPhotographTargetPlayer:
				return IPhotographTargetPlayer.Pack(builder, _o.AsIPhotographTargetPlayer()).Value;
			case IPhotographTarget_Union.IPhotographTargetRolesOnScene:
				return IPhotographTargetRolesOnScene.Pack(builder, _o.AsIPhotographTargetRolesOnScene()).Value;
			default:
				return 0;
			}
		}
	}
}
