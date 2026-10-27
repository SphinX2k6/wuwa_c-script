using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042F4 RID: 17140
	public class TPhotographTargetUnion
	{
		// Token: 0x1700795A RID: 31066
		// (get) Token: 0x060196B9 RID: 104121 RVA: 0x003A519E File Offset: 0x003A339E
		// (set) Token: 0x060196BA RID: 104122 RVA: 0x003A51A6 File Offset: 0x003A33A6
		public TPhotographTarget Type { get; set; }

		// Token: 0x1700795B RID: 31067
		// (get) Token: 0x060196BB RID: 104123 RVA: 0x003A51AF File Offset: 0x003A33AF
		// (set) Token: 0x060196BC RID: 104124 RVA: 0x003A51B7 File Offset: 0x003A33B7
		public object Value { get; set; }

		// Token: 0x060196BD RID: 104125 RVA: 0x003A51C0 File Offset: 0x003A33C0
		public TPhotographTargetUnion()
		{
			this.Type = TPhotographTarget.NONE;
			this.Value = null;
		}

		// Token: 0x060196BE RID: 104126 RVA: 0x003A51D6 File Offset: 0x003A33D6
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060196BF RID: 104127 RVA: 0x003A51E8 File Offset: 0x003A33E8
		public IPhotographTargetPlayerT AsIPhotographTargetPlayer()
		{
			return this.As<IPhotographTargetPlayerT>();
		}

		// Token: 0x060196C0 RID: 104128 RVA: 0x003A51F0 File Offset: 0x003A33F0
		public static TPhotographTargetUnion FromIPhotographTargetPlayer(IPhotographTargetPlayerT _iphotographtargetplayer)
		{
			return new TPhotographTargetUnion
			{
				Type = TPhotographTarget.IPhotographTargetPlayer,
				Value = _iphotographtargetplayer
			};
		}

		// Token: 0x060196C1 RID: 104129 RVA: 0x003A5205 File Offset: 0x003A3405
		public IPhotographTargetRolesOnSceneT AsIPhotographTargetRolesOnScene()
		{
			return this.As<IPhotographTargetRolesOnSceneT>();
		}

		// Token: 0x060196C2 RID: 104130 RVA: 0x003A520D File Offset: 0x003A340D
		public static TPhotographTargetUnion FromIPhotographTargetRolesOnScene(IPhotographTargetRolesOnSceneT _iphotographtargetrolesonscene)
		{
			return new TPhotographTargetUnion
			{
				Type = TPhotographTarget.IPhotographTargetRolesOnScene,
				Value = _iphotographtargetrolesonscene
			};
		}

		// Token: 0x060196C3 RID: 104131 RVA: 0x003A5224 File Offset: 0x003A3424
		public static int Pack(FlatBufferBuilder builder, TPhotographTargetUnion _o)
		{
			TPhotographTarget type = _o.Type;
			if (type == TPhotographTarget.IPhotographTargetPlayer)
			{
				return IPhotographTargetPlayer.Pack(builder, _o.AsIPhotographTargetPlayer()).Value;
			}
			if (type != TPhotographTarget.IPhotographTargetRolesOnScene)
			{
				return 0;
			}
			return IPhotographTargetRolesOnScene.Pack(builder, _o.AsIPhotographTargetRolesOnScene()).Value;
		}
	}
}
