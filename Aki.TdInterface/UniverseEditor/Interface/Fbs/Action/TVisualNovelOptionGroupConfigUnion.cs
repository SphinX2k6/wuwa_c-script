using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02008052 RID: 32850
	public class TVisualNovelOptionGroupConfigUnion
	{
		// Token: 0x1700F359 RID: 62297
		// (get) Token: 0x0603B161 RID: 242017 RVA: 0x007EE4E0 File Offset: 0x007EC6E0
		// (set) Token: 0x0603B162 RID: 242018 RVA: 0x007EE4E8 File Offset: 0x007EC6E8
		public TVisualNovelOptionGroupConfig Type { get; set; }

		// Token: 0x1700F35A RID: 62298
		// (get) Token: 0x0603B163 RID: 242019 RVA: 0x007EE4F1 File Offset: 0x007EC6F1
		// (set) Token: 0x0603B164 RID: 242020 RVA: 0x007EE4F9 File Offset: 0x007EC6F9
		public object Value { get; set; }

		// Token: 0x0603B165 RID: 242021 RVA: 0x007EE502 File Offset: 0x007EC702
		public TVisualNovelOptionGroupConfigUnion()
		{
			this.Type = TVisualNovelOptionGroupConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0603B166 RID: 242022 RVA: 0x007EE518 File Offset: 0x007EC718
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603B167 RID: 242023 RVA: 0x007EE52A File Offset: 0x007EC72A
		public IVisualNovelOptionGroupFullScreenT AsIVisualNovelOptionGroupFullScreen()
		{
			return this.As<IVisualNovelOptionGroupFullScreenT>();
		}

		// Token: 0x0603B168 RID: 242024 RVA: 0x007EE532 File Offset: 0x007EC732
		public static TVisualNovelOptionGroupConfigUnion FromIVisualNovelOptionGroupFullScreen(IVisualNovelOptionGroupFullScreenT _ivisualnoveloptiongroupfullscreen)
		{
			return new TVisualNovelOptionGroupConfigUnion
			{
				Type = TVisualNovelOptionGroupConfig.IVisualNovelOptionGroupFullScreen,
				Value = _ivisualnoveloptiongroupfullscreen
			};
		}

		// Token: 0x0603B169 RID: 242025 RVA: 0x007EE547 File Offset: 0x007EC747
		public IVisualNovelOptionGroupNormalT AsIVisualNovelOptionGroupNormal()
		{
			return this.As<IVisualNovelOptionGroupNormalT>();
		}

		// Token: 0x0603B16A RID: 242026 RVA: 0x007EE54F File Offset: 0x007EC74F
		public static TVisualNovelOptionGroupConfigUnion FromIVisualNovelOptionGroupNormal(IVisualNovelOptionGroupNormalT _ivisualnoveloptiongroupnormal)
		{
			return new TVisualNovelOptionGroupConfigUnion
			{
				Type = TVisualNovelOptionGroupConfig.IVisualNovelOptionGroupNormal,
				Value = _ivisualnoveloptiongroupnormal
			};
		}

		// Token: 0x0603B16B RID: 242027 RVA: 0x007EE564 File Offset: 0x007EC764
		public static int Pack(FlatBufferBuilder builder, TVisualNovelOptionGroupConfigUnion _o)
		{
			TVisualNovelOptionGroupConfig type = _o.Type;
			if (type == TVisualNovelOptionGroupConfig.IVisualNovelOptionGroupFullScreen)
			{
				return IVisualNovelOptionGroupFullScreen.Pack(builder, _o.AsIVisualNovelOptionGroupFullScreen()).Value;
			}
			if (type != TVisualNovelOptionGroupConfig.IVisualNovelOptionGroupNormal)
			{
				return 0;
			}
			return IVisualNovelOptionGroupNormal.Pack(builder, _o.AsIVisualNovelOptionGroupNormal()).Value;
		}
	}
}
