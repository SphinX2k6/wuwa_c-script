using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076E8 RID: 30440
	public class ISceneUiSubtitlePositionBase_UnionUnion
	{
		// Token: 0x1700DF41 RID: 57153
		// (get) Token: 0x06035675 RID: 218741 RVA: 0x0072991D File Offset: 0x00727B1D
		// (set) Token: 0x06035676 RID: 218742 RVA: 0x00729925 File Offset: 0x00727B25
		public ISceneUiSubtitlePositionBase_Union Type { get; set; }

		// Token: 0x1700DF42 RID: 57154
		// (get) Token: 0x06035677 RID: 218743 RVA: 0x0072992E File Offset: 0x00727B2E
		// (set) Token: 0x06035678 RID: 218744 RVA: 0x00729936 File Offset: 0x00727B36
		public object Value { get; set; }

		// Token: 0x06035679 RID: 218745 RVA: 0x0072993F File Offset: 0x00727B3F
		public ISceneUiSubtitlePositionBase_UnionUnion()
		{
			this.Type = ISceneUiSubtitlePositionBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0603567A RID: 218746 RVA: 0x00729955 File Offset: 0x00727B55
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603567B RID: 218747 RVA: 0x00729967 File Offset: 0x00727B67
		public ISceneUiSubtitlePositionBaseT AsISceneUiSubtitlePositionBase()
		{
			return this.As<ISceneUiSubtitlePositionBaseT>();
		}

		// Token: 0x0603567C RID: 218748 RVA: 0x0072996F File Offset: 0x00727B6F
		public static ISceneUiSubtitlePositionBase_UnionUnion FromISceneUiSubtitlePositionBase(ISceneUiSubtitlePositionBaseT _isceneuisubtitlepositionbase)
		{
			return new ISceneUiSubtitlePositionBase_UnionUnion
			{
				Type = ISceneUiSubtitlePositionBase_Union.ISceneUiSubtitlePositionBase,
				Value = _isceneuisubtitlepositionbase
			};
		}

		// Token: 0x0603567D RID: 218749 RVA: 0x00729984 File Offset: 0x00727B84
		public ISceneUiSubtitlePositionT AsISceneUiSubtitlePosition()
		{
			return this.As<ISceneUiSubtitlePositionT>();
		}

		// Token: 0x0603567E RID: 218750 RVA: 0x0072998C File Offset: 0x00727B8C
		public static ISceneUiSubtitlePositionBase_UnionUnion FromISceneUiSubtitlePosition(ISceneUiSubtitlePositionT _isceneuisubtitleposition)
		{
			return new ISceneUiSubtitlePositionBase_UnionUnion
			{
				Type = ISceneUiSubtitlePositionBase_Union.ISceneUiSubtitlePosition,
				Value = _isceneuisubtitleposition
			};
		}

		// Token: 0x0603567F RID: 218751 RVA: 0x007299A1 File Offset: 0x00727BA1
		public ISceneUiSubtitlePositionEntityT AsISceneUiSubtitlePositionEntity()
		{
			return this.As<ISceneUiSubtitlePositionEntityT>();
		}

		// Token: 0x06035680 RID: 218752 RVA: 0x007299A9 File Offset: 0x00727BA9
		public static ISceneUiSubtitlePositionBase_UnionUnion FromISceneUiSubtitlePositionEntity(ISceneUiSubtitlePositionEntityT _isceneuisubtitlepositionentity)
		{
			return new ISceneUiSubtitlePositionBase_UnionUnion
			{
				Type = ISceneUiSubtitlePositionBase_Union.ISceneUiSubtitlePositionEntity,
				Value = _isceneuisubtitlepositionentity
			};
		}

		// Token: 0x06035681 RID: 218753 RVA: 0x007299C0 File Offset: 0x00727BC0
		public static int Pack(FlatBufferBuilder builder, ISceneUiSubtitlePositionBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISceneUiSubtitlePositionBase_Union.ISceneUiSubtitlePositionBase:
				return ISceneUiSubtitlePositionBase.Pack(builder, _o.AsISceneUiSubtitlePositionBase()).Value;
			case ISceneUiSubtitlePositionBase_Union.ISceneUiSubtitlePosition:
				return ISceneUiSubtitlePosition.Pack(builder, _o.AsISceneUiSubtitlePosition()).Value;
			case ISceneUiSubtitlePositionBase_Union.ISceneUiSubtitlePositionEntity:
				return ISceneUiSubtitlePositionEntity.Pack(builder, _o.AsISceneUiSubtitlePositionEntity()).Value;
			default:
				return 0;
			}
		}
	}
}
