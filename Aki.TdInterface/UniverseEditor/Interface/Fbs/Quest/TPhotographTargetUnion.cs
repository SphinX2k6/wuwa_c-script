using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004753 RID: 18259
	public class TPhotographTargetUnion
	{
		// Token: 0x17007F8D RID: 32653
		// (get) Token: 0x0601AE3B RID: 110139 RVA: 0x003D0ACE File Offset: 0x003CECCE
		// (set) Token: 0x0601AE3C RID: 110140 RVA: 0x003D0AD6 File Offset: 0x003CECD6
		public TPhotographTarget Type { get; set; }

		// Token: 0x17007F8E RID: 32654
		// (get) Token: 0x0601AE3D RID: 110141 RVA: 0x003D0ADF File Offset: 0x003CECDF
		// (set) Token: 0x0601AE3E RID: 110142 RVA: 0x003D0AE7 File Offset: 0x003CECE7
		public object Value { get; set; }

		// Token: 0x0601AE3F RID: 110143 RVA: 0x003D0AF0 File Offset: 0x003CECF0
		public TPhotographTargetUnion()
		{
			this.Type = TPhotographTarget.NONE;
			this.Value = null;
		}

		// Token: 0x0601AE40 RID: 110144 RVA: 0x003D0B06 File Offset: 0x003CED06
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AE41 RID: 110145 RVA: 0x003D0B18 File Offset: 0x003CED18
		public IPhotographTargetPlayerT AsIPhotographTargetPlayer()
		{
			return this.As<IPhotographTargetPlayerT>();
		}

		// Token: 0x0601AE42 RID: 110146 RVA: 0x003D0B20 File Offset: 0x003CED20
		public static TPhotographTargetUnion FromIPhotographTargetPlayer(IPhotographTargetPlayerT _iphotographtargetplayer)
		{
			return new TPhotographTargetUnion
			{
				Type = TPhotographTarget.IPhotographTargetPlayer,
				Value = _iphotographtargetplayer
			};
		}

		// Token: 0x0601AE43 RID: 110147 RVA: 0x003D0B35 File Offset: 0x003CED35
		public IPhotographTargetRolesOnSceneT AsIPhotographTargetRolesOnScene()
		{
			return this.As<IPhotographTargetRolesOnSceneT>();
		}

		// Token: 0x0601AE44 RID: 110148 RVA: 0x003D0B3D File Offset: 0x003CED3D
		public static TPhotographTargetUnion FromIPhotographTargetRolesOnScene(IPhotographTargetRolesOnSceneT _iphotographtargetrolesonscene)
		{
			return new TPhotographTargetUnion
			{
				Type = TPhotographTarget.IPhotographTargetRolesOnScene,
				Value = _iphotographtargetrolesonscene
			};
		}

		// Token: 0x0601AE45 RID: 110149 RVA: 0x003D0B54 File Offset: 0x003CED54
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
