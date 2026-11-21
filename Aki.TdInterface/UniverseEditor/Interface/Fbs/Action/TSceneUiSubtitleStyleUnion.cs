using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FAA RID: 32682
	public class TSceneUiSubtitleStyleUnion
	{
		// Token: 0x1700F2E9 RID: 62185
		// (get) Token: 0x0603ADF7 RID: 241143 RVA: 0x007E920A File Offset: 0x007E740A
		// (set) Token: 0x0603ADF8 RID: 241144 RVA: 0x007E9212 File Offset: 0x007E7412
		public TSceneUiSubtitleStyle Type { get; set; }

		// Token: 0x1700F2EA RID: 62186
		// (get) Token: 0x0603ADF9 RID: 241145 RVA: 0x007E921B File Offset: 0x007E741B
		// (set) Token: 0x0603ADFA RID: 241146 RVA: 0x007E9223 File Offset: 0x007E7423
		public object Value { get; set; }

		// Token: 0x0603ADFB RID: 241147 RVA: 0x007E922C File Offset: 0x007E742C
		public TSceneUiSubtitleStyleUnion()
		{
			this.Type = TSceneUiSubtitleStyle.NONE;
			this.Value = null;
		}

		// Token: 0x0603ADFC RID: 241148 RVA: 0x007E9242 File Offset: 0x007E7442
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603ADFD RID: 241149 RVA: 0x007E9254 File Offset: 0x007E7454
		public ISceneUiSubtitleAppearT AsISceneUiSubtitleAppear()
		{
			return this.As<ISceneUiSubtitleAppearT>();
		}

		// Token: 0x0603ADFE RID: 241150 RVA: 0x007E925C File Offset: 0x007E745C
		public static TSceneUiSubtitleStyleUnion FromISceneUiSubtitleAppear(ISceneUiSubtitleAppearT _isceneuisubtitleappear)
		{
			return new TSceneUiSubtitleStyleUnion
			{
				Type = TSceneUiSubtitleStyle.ISceneUiSubtitleAppear,
				Value = _isceneuisubtitleappear
			};
		}

		// Token: 0x0603ADFF RID: 241151 RVA: 0x007E9271 File Offset: 0x007E7471
		public ISceneUiSubtitleScatterT AsISceneUiSubtitleScatter()
		{
			return this.As<ISceneUiSubtitleScatterT>();
		}

		// Token: 0x0603AE00 RID: 241152 RVA: 0x007E9279 File Offset: 0x007E7479
		public static TSceneUiSubtitleStyleUnion FromISceneUiSubtitleScatter(ISceneUiSubtitleScatterT _isceneuisubtitlescatter)
		{
			return new TSceneUiSubtitleStyleUnion
			{
				Type = TSceneUiSubtitleStyle.ISceneUiSubtitleScatter,
				Value = _isceneuisubtitlescatter
			};
		}

		// Token: 0x0603AE01 RID: 241153 RVA: 0x007E9290 File Offset: 0x007E7490
		public static int Pack(FlatBufferBuilder builder, TSceneUiSubtitleStyleUnion _o)
		{
			TSceneUiSubtitleStyle type = _o.Type;
			if (type == TSceneUiSubtitleStyle.ISceneUiSubtitleAppear)
			{
				return ISceneUiSubtitleAppear.Pack(builder, _o.AsISceneUiSubtitleAppear()).Value;
			}
			if (type != TSceneUiSubtitleStyle.ISceneUiSubtitleScatter)
			{
				return 0;
			}
			return ISceneUiSubtitleScatter.Pack(builder, _o.AsISceneUiSubtitleScatter()).Value;
		}
	}
}
