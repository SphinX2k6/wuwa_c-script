using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076FA RID: 30458
	public class ISceneUiSubtitleTextBase_UnionUnion
	{
		// Token: 0x1700DF67 RID: 57191
		// (get) Token: 0x0603570D RID: 218893 RVA: 0x0072ABB5 File Offset: 0x00728DB5
		// (set) Token: 0x0603570E RID: 218894 RVA: 0x0072ABBD File Offset: 0x00728DBD
		public ISceneUiSubtitleTextBase_Union Type { get; set; }

		// Token: 0x1700DF68 RID: 57192
		// (get) Token: 0x0603570F RID: 218895 RVA: 0x0072ABC6 File Offset: 0x00728DC6
		// (set) Token: 0x06035710 RID: 218896 RVA: 0x0072ABCE File Offset: 0x00728DCE
		public object Value { get; set; }

		// Token: 0x06035711 RID: 218897 RVA: 0x0072ABD7 File Offset: 0x00728DD7
		public ISceneUiSubtitleTextBase_UnionUnion()
		{
			this.Type = ISceneUiSubtitleTextBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06035712 RID: 218898 RVA: 0x0072ABED File Offset: 0x00728DED
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06035713 RID: 218899 RVA: 0x0072ABFF File Offset: 0x00728DFF
		public ISceneUiSubtitleTextBaseT AsISceneUiSubtitleTextBase()
		{
			return this.As<ISceneUiSubtitleTextBaseT>();
		}

		// Token: 0x06035714 RID: 218900 RVA: 0x0072AC07 File Offset: 0x00728E07
		public static ISceneUiSubtitleTextBase_UnionUnion FromISceneUiSubtitleTextBase(ISceneUiSubtitleTextBaseT _isceneuisubtitletextbase)
		{
			return new ISceneUiSubtitleTextBase_UnionUnion
			{
				Type = ISceneUiSubtitleTextBase_Union.ISceneUiSubtitleTextBase,
				Value = _isceneuisubtitletextbase
			};
		}

		// Token: 0x06035715 RID: 218901 RVA: 0x0072AC1C File Offset: 0x00728E1C
		public ISceneUiSubtitleTextFlowT AsISceneUiSubtitleTextFlow()
		{
			return this.As<ISceneUiSubtitleTextFlowT>();
		}

		// Token: 0x06035716 RID: 218902 RVA: 0x0072AC24 File Offset: 0x00728E24
		public static ISceneUiSubtitleTextBase_UnionUnion FromISceneUiSubtitleTextFlow(ISceneUiSubtitleTextFlowT _isceneuisubtitletextflow)
		{
			return new ISceneUiSubtitleTextBase_UnionUnion
			{
				Type = ISceneUiSubtitleTextBase_Union.ISceneUiSubtitleTextFlow,
				Value = _isceneuisubtitletextflow
			};
		}

		// Token: 0x06035717 RID: 218903 RVA: 0x0072AC39 File Offset: 0x00728E39
		public ISceneUiSubtitleTextKeyT AsISceneUiSubtitleTextKey()
		{
			return this.As<ISceneUiSubtitleTextKeyT>();
		}

		// Token: 0x06035718 RID: 218904 RVA: 0x0072AC41 File Offset: 0x00728E41
		public static ISceneUiSubtitleTextBase_UnionUnion FromISceneUiSubtitleTextKey(ISceneUiSubtitleTextKeyT _isceneuisubtitletextkey)
		{
			return new ISceneUiSubtitleTextBase_UnionUnion
			{
				Type = ISceneUiSubtitleTextBase_Union.ISceneUiSubtitleTextKey,
				Value = _isceneuisubtitletextkey
			};
		}

		// Token: 0x06035719 RID: 218905 RVA: 0x0072AC58 File Offset: 0x00728E58
		public static int Pack(FlatBufferBuilder builder, ISceneUiSubtitleTextBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISceneUiSubtitleTextBase_Union.ISceneUiSubtitleTextBase:
				return ISceneUiSubtitleTextBase.Pack(builder, _o.AsISceneUiSubtitleTextBase()).Value;
			case ISceneUiSubtitleTextBase_Union.ISceneUiSubtitleTextFlow:
				return ISceneUiSubtitleTextFlow.Pack(builder, _o.AsISceneUiSubtitleTextFlow()).Value;
			case ISceneUiSubtitleTextBase_Union.ISceneUiSubtitleTextKey:
				return ISceneUiSubtitleTextKey.Pack(builder, _o.AsISceneUiSubtitleTextKey()).Value;
			default:
				return 0;
			}
		}
	}
}
