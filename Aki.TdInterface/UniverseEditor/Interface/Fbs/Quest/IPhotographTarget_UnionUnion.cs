using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F99 RID: 16281
	public class IPhotographTarget_UnionUnion
	{
		// Token: 0x170071A6 RID: 29094
		// (get) Token: 0x06017412 RID: 95250 RVA: 0x0035A961 File Offset: 0x00358B61
		// (set) Token: 0x06017413 RID: 95251 RVA: 0x0035A969 File Offset: 0x00358B69
		public IPhotographTarget_Union Type { get; set; }

		// Token: 0x170071A7 RID: 29095
		// (get) Token: 0x06017414 RID: 95252 RVA: 0x0035A972 File Offset: 0x00358B72
		// (set) Token: 0x06017415 RID: 95253 RVA: 0x0035A97A File Offset: 0x00358B7A
		public object Value { get; set; }

		// Token: 0x06017416 RID: 95254 RVA: 0x0035A983 File Offset: 0x00358B83
		public IPhotographTarget_UnionUnion()
		{
			this.Type = IPhotographTarget_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06017417 RID: 95255 RVA: 0x0035A999 File Offset: 0x00358B99
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06017418 RID: 95256 RVA: 0x0035A9AB File Offset: 0x00358BAB
		public IPhotographTargetT AsIPhotographTarget()
		{
			return this.As<IPhotographTargetT>();
		}

		// Token: 0x06017419 RID: 95257 RVA: 0x0035A9B3 File Offset: 0x00358BB3
		public static IPhotographTarget_UnionUnion FromIPhotographTarget(IPhotographTargetT _iphotographtarget)
		{
			return new IPhotographTarget_UnionUnion
			{
				Type = IPhotographTarget_Union.IPhotographTarget,
				Value = _iphotographtarget
			};
		}

		// Token: 0x0601741A RID: 95258 RVA: 0x0035A9C8 File Offset: 0x00358BC8
		public IPhotographTargetPlayerT AsIPhotographTargetPlayer()
		{
			return this.As<IPhotographTargetPlayerT>();
		}

		// Token: 0x0601741B RID: 95259 RVA: 0x0035A9D0 File Offset: 0x00358BD0
		public static IPhotographTarget_UnionUnion FromIPhotographTargetPlayer(IPhotographTargetPlayerT _iphotographtargetplayer)
		{
			return new IPhotographTarget_UnionUnion
			{
				Type = IPhotographTarget_Union.IPhotographTargetPlayer,
				Value = _iphotographtargetplayer
			};
		}

		// Token: 0x0601741C RID: 95260 RVA: 0x0035A9E5 File Offset: 0x00358BE5
		public IPhotographTargetRolesOnSceneT AsIPhotographTargetRolesOnScene()
		{
			return this.As<IPhotographTargetRolesOnSceneT>();
		}

		// Token: 0x0601741D RID: 95261 RVA: 0x0035A9ED File Offset: 0x00358BED
		public static IPhotographTarget_UnionUnion FromIPhotographTargetRolesOnScene(IPhotographTargetRolesOnSceneT _iphotographtargetrolesonscene)
		{
			return new IPhotographTarget_UnionUnion
			{
				Type = IPhotographTarget_Union.IPhotographTargetRolesOnScene,
				Value = _iphotographtargetrolesonscene
			};
		}

		// Token: 0x0601741E RID: 95262 RVA: 0x0035AA04 File Offset: 0x00358C04
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
