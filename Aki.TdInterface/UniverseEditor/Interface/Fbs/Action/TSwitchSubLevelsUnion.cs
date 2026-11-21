using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FF2 RID: 32754
	public class TSwitchSubLevelsUnion
	{
		// Token: 0x1700F319 RID: 62233
		// (get) Token: 0x0603AF41 RID: 241473 RVA: 0x007EAF96 File Offset: 0x007E9196
		// (set) Token: 0x0603AF42 RID: 241474 RVA: 0x007EAF9E File Offset: 0x007E919E
		public TSwitchSubLevels Type { get; set; }

		// Token: 0x1700F31A RID: 62234
		// (get) Token: 0x0603AF43 RID: 241475 RVA: 0x007EAFA7 File Offset: 0x007E91A7
		// (set) Token: 0x0603AF44 RID: 241476 RVA: 0x007EAFAF File Offset: 0x007E91AF
		public object Value { get; set; }

		// Token: 0x0603AF45 RID: 241477 RVA: 0x007EAFB8 File Offset: 0x007E91B8
		public TSwitchSubLevelsUnion()
		{
			this.Type = TSwitchSubLevels.NONE;
			this.Value = null;
		}

		// Token: 0x0603AF46 RID: 241478 RVA: 0x007EAFCE File Offset: 0x007E91CE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AF47 RID: 241479 RVA: 0x007EAFE0 File Offset: 0x007E91E0
		public IPreloadSubLevelsT AsIPreloadSubLevels()
		{
			return this.As<IPreloadSubLevelsT>();
		}

		// Token: 0x0603AF48 RID: 241480 RVA: 0x007EAFE8 File Offset: 0x007E91E8
		public static TSwitchSubLevelsUnion FromIPreloadSubLevels(IPreloadSubLevelsT _ipreloadsublevels)
		{
			return new TSwitchSubLevelsUnion
			{
				Type = TSwitchSubLevels.IPreloadSubLevels,
				Value = _ipreloadsublevels
			};
		}

		// Token: 0x0603AF49 RID: 241481 RVA: 0x007EAFFD File Offset: 0x007E91FD
		public ISwitchPermissionT AsISwitchPermission()
		{
			return this.As<ISwitchPermissionT>();
		}

		// Token: 0x0603AF4A RID: 241482 RVA: 0x007EB005 File Offset: 0x007E9205
		public static TSwitchSubLevelsUnion FromISwitchPermission(ISwitchPermissionT _iswitchpermission)
		{
			return new TSwitchSubLevelsUnion
			{
				Type = TSwitchSubLevels.ISwitchPermission,
				Value = _iswitchpermission
			};
		}

		// Token: 0x0603AF4B RID: 241483 RVA: 0x007EB01A File Offset: 0x007E921A
		public ISwitchSubLevelsDirectlyT AsISwitchSubLevelsDirectly()
		{
			return this.As<ISwitchSubLevelsDirectlyT>();
		}

		// Token: 0x0603AF4C RID: 241484 RVA: 0x007EB022 File Offset: 0x007E9222
		public static TSwitchSubLevelsUnion FromISwitchSubLevelsDirectly(ISwitchSubLevelsDirectlyT _iswitchsublevelsdirectly)
		{
			return new TSwitchSubLevelsUnion
			{
				Type = TSwitchSubLevels.ISwitchSubLevelsDirectly,
				Value = _iswitchsublevelsdirectly
			};
		}

		// Token: 0x0603AF4D RID: 241485 RVA: 0x007EB038 File Offset: 0x007E9238
		public static int Pack(FlatBufferBuilder builder, TSwitchSubLevelsUnion _o)
		{
			switch (_o.Type)
			{
			case TSwitchSubLevels.IPreloadSubLevels:
				return IPreloadSubLevels.Pack(builder, _o.AsIPreloadSubLevels()).Value;
			case TSwitchSubLevels.ISwitchPermission:
				return ISwitchPermission.Pack(builder, _o.AsISwitchPermission()).Value;
			case TSwitchSubLevels.ISwitchSubLevelsDirectly:
				return ISwitchSubLevelsDirectly.Pack(builder, _o.AsISwitchSubLevelsDirectly()).Value;
			default:
				return 0;
			}
		}
	}
}
