using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076DF RID: 30431
	public class ISceneUiSubtitleOperationBase_UnionUnion
	{
		// Token: 0x1700DF37 RID: 57143
		// (get) Token: 0x0603563F RID: 218687 RVA: 0x007293D1 File Offset: 0x007275D1
		// (set) Token: 0x06035640 RID: 218688 RVA: 0x007293D9 File Offset: 0x007275D9
		public ISceneUiSubtitleOperationBase_Union Type { get; set; }

		// Token: 0x1700DF38 RID: 57144
		// (get) Token: 0x06035641 RID: 218689 RVA: 0x007293E2 File Offset: 0x007275E2
		// (set) Token: 0x06035642 RID: 218690 RVA: 0x007293EA File Offset: 0x007275EA
		public object Value { get; set; }

		// Token: 0x06035643 RID: 218691 RVA: 0x007293F3 File Offset: 0x007275F3
		public ISceneUiSubtitleOperationBase_UnionUnion()
		{
			this.Type = ISceneUiSubtitleOperationBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06035644 RID: 218692 RVA: 0x00729409 File Offset: 0x00727609
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06035645 RID: 218693 RVA: 0x0072941B File Offset: 0x0072761B
		public ISceneUiSubtitleOperationBaseT AsISceneUiSubtitleOperationBase()
		{
			return this.As<ISceneUiSubtitleOperationBaseT>();
		}

		// Token: 0x06035646 RID: 218694 RVA: 0x00729423 File Offset: 0x00727623
		public static ISceneUiSubtitleOperationBase_UnionUnion FromISceneUiSubtitleOperationBase(ISceneUiSubtitleOperationBaseT _isceneuisubtitleoperationbase)
		{
			return new ISceneUiSubtitleOperationBase_UnionUnion
			{
				Type = ISceneUiSubtitleOperationBase_Union.ISceneUiSubtitleOperationBase,
				Value = _isceneuisubtitleoperationbase
			};
		}

		// Token: 0x06035647 RID: 218695 RVA: 0x00729438 File Offset: 0x00727638
		public ISpawnSceneUiSubtitleT AsISpawnSceneUiSubtitle()
		{
			return this.As<ISpawnSceneUiSubtitleT>();
		}

		// Token: 0x06035648 RID: 218696 RVA: 0x00729440 File Offset: 0x00727640
		public static ISceneUiSubtitleOperationBase_UnionUnion FromISpawnSceneUiSubtitle(ISpawnSceneUiSubtitleT _ispawnsceneuisubtitle)
		{
			return new ISceneUiSubtitleOperationBase_UnionUnion
			{
				Type = ISceneUiSubtitleOperationBase_Union.ISpawnSceneUiSubtitle,
				Value = _ispawnsceneuisubtitle
			};
		}

		// Token: 0x06035649 RID: 218697 RVA: 0x00729455 File Offset: 0x00727655
		public IRemoveSceneUiSubtitleT AsIRemoveSceneUiSubtitle()
		{
			return this.As<IRemoveSceneUiSubtitleT>();
		}

		// Token: 0x0603564A RID: 218698 RVA: 0x0072945D File Offset: 0x0072765D
		public static ISceneUiSubtitleOperationBase_UnionUnion FromIRemoveSceneUiSubtitle(IRemoveSceneUiSubtitleT _iremovesceneuisubtitle)
		{
			return new ISceneUiSubtitleOperationBase_UnionUnion
			{
				Type = ISceneUiSubtitleOperationBase_Union.IRemoveSceneUiSubtitle,
				Value = _iremovesceneuisubtitle
			};
		}

		// Token: 0x0603564B RID: 218699 RVA: 0x00729474 File Offset: 0x00727674
		public static int Pack(FlatBufferBuilder builder, ISceneUiSubtitleOperationBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISceneUiSubtitleOperationBase_Union.ISceneUiSubtitleOperationBase:
				return ISceneUiSubtitleOperationBase.Pack(builder, _o.AsISceneUiSubtitleOperationBase()).Value;
			case ISceneUiSubtitleOperationBase_Union.ISpawnSceneUiSubtitle:
				return ISpawnSceneUiSubtitle.Pack(builder, _o.AsISpawnSceneUiSubtitle()).Value;
			case ISceneUiSubtitleOperationBase_Union.IRemoveSceneUiSubtitle:
				return IRemoveSceneUiSubtitle.Pack(builder, _o.AsIRemoveSceneUiSubtitle()).Value;
			default:
				return 0;
			}
		}
	}
}
