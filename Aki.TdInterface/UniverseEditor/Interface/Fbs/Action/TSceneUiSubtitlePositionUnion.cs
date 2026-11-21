using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FA7 RID: 32679
	public class TSceneUiSubtitlePositionUnion
	{
		// Token: 0x1700F2E7 RID: 62183
		// (get) Token: 0x0603ADEB RID: 241131 RVA: 0x007E910E File Offset: 0x007E730E
		// (set) Token: 0x0603ADEC RID: 241132 RVA: 0x007E9116 File Offset: 0x007E7316
		public TSceneUiSubtitlePosition Type { get; set; }

		// Token: 0x1700F2E8 RID: 62184
		// (get) Token: 0x0603ADED RID: 241133 RVA: 0x007E911F File Offset: 0x007E731F
		// (set) Token: 0x0603ADEE RID: 241134 RVA: 0x007E9127 File Offset: 0x007E7327
		public object Value { get; set; }

		// Token: 0x0603ADEF RID: 241135 RVA: 0x007E9130 File Offset: 0x007E7330
		public TSceneUiSubtitlePositionUnion()
		{
			this.Type = TSceneUiSubtitlePosition.NONE;
			this.Value = null;
		}

		// Token: 0x0603ADF0 RID: 241136 RVA: 0x007E9146 File Offset: 0x007E7346
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603ADF1 RID: 241137 RVA: 0x007E9158 File Offset: 0x007E7358
		public ISceneUiSubtitlePositionT AsISceneUiSubtitlePosition()
		{
			return this.As<ISceneUiSubtitlePositionT>();
		}

		// Token: 0x0603ADF2 RID: 241138 RVA: 0x007E9160 File Offset: 0x007E7360
		public static TSceneUiSubtitlePositionUnion FromISceneUiSubtitlePosition(ISceneUiSubtitlePositionT _isceneuisubtitleposition)
		{
			return new TSceneUiSubtitlePositionUnion
			{
				Type = TSceneUiSubtitlePosition.ISceneUiSubtitlePosition,
				Value = _isceneuisubtitleposition
			};
		}

		// Token: 0x0603ADF3 RID: 241139 RVA: 0x007E9175 File Offset: 0x007E7375
		public ISceneUiSubtitlePositionEntityT AsISceneUiSubtitlePositionEntity()
		{
			return this.As<ISceneUiSubtitlePositionEntityT>();
		}

		// Token: 0x0603ADF4 RID: 241140 RVA: 0x007E917D File Offset: 0x007E737D
		public static TSceneUiSubtitlePositionUnion FromISceneUiSubtitlePositionEntity(ISceneUiSubtitlePositionEntityT _isceneuisubtitlepositionentity)
		{
			return new TSceneUiSubtitlePositionUnion
			{
				Type = TSceneUiSubtitlePosition.ISceneUiSubtitlePositionEntity,
				Value = _isceneuisubtitlepositionentity
			};
		}

		// Token: 0x0603ADF5 RID: 241141 RVA: 0x007E9194 File Offset: 0x007E7394
		public static int Pack(FlatBufferBuilder builder, TSceneUiSubtitlePositionUnion _o)
		{
			TSceneUiSubtitlePosition type = _o.Type;
			if (type == TSceneUiSubtitlePosition.ISceneUiSubtitlePosition)
			{
				return ISceneUiSubtitlePosition.Pack(builder, _o.AsISceneUiSubtitlePosition()).Value;
			}
			if (type != TSceneUiSubtitlePosition.ISceneUiSubtitlePositionEntity)
			{
				return 0;
			}
			return ISceneUiSubtitlePositionEntity.Pack(builder, _o.AsISceneUiSubtitlePositionEntity()).Value;
		}
	}
}
