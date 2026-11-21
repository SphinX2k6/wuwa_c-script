using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DC8 RID: 32200
	public class IVisualNovelPlayScreenEffectConfigBase_UnionUnion
	{
		// Token: 0x1700F139 RID: 61753
		// (get) Token: 0x0603A2FB RID: 238331 RVA: 0x007D7EBD File Offset: 0x007D60BD
		// (set) Token: 0x0603A2FC RID: 238332 RVA: 0x007D7EC5 File Offset: 0x007D60C5
		public IVisualNovelPlayScreenEffectConfigBase_Union Type { get; set; }

		// Token: 0x1700F13A RID: 61754
		// (get) Token: 0x0603A2FD RID: 238333 RVA: 0x007D7ECE File Offset: 0x007D60CE
		// (set) Token: 0x0603A2FE RID: 238334 RVA: 0x007D7ED6 File Offset: 0x007D60D6
		public object Value { get; set; }

		// Token: 0x0603A2FF RID: 238335 RVA: 0x007D7EDF File Offset: 0x007D60DF
		public IVisualNovelPlayScreenEffectConfigBase_UnionUnion()
		{
			this.Type = IVisualNovelPlayScreenEffectConfigBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0603A300 RID: 238336 RVA: 0x007D7EF5 File Offset: 0x007D60F5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A301 RID: 238337 RVA: 0x007D7F07 File Offset: 0x007D6107
		public IVisualNovelPlayScreenEffectConfigBaseT AsIVisualNovelPlayScreenEffectConfigBase()
		{
			return this.As<IVisualNovelPlayScreenEffectConfigBaseT>();
		}

		// Token: 0x0603A302 RID: 238338 RVA: 0x007D7F0F File Offset: 0x007D610F
		public static IVisualNovelPlayScreenEffectConfigBase_UnionUnion FromIVisualNovelPlayScreenEffectConfigBase(IVisualNovelPlayScreenEffectConfigBaseT _ivisualnovelplayscreeneffectconfigbase)
		{
			return new IVisualNovelPlayScreenEffectConfigBase_UnionUnion
			{
				Type = IVisualNovelPlayScreenEffectConfigBase_Union.IVisualNovelPlayScreenEffectConfigBase,
				Value = _ivisualnovelplayscreeneffectconfigbase
			};
		}

		// Token: 0x0603A303 RID: 238339 RVA: 0x007D7F24 File Offset: 0x007D6124
		public IVisualNovelPlayScreenEffectOneShotT AsIVisualNovelPlayScreenEffectOneShot()
		{
			return this.As<IVisualNovelPlayScreenEffectOneShotT>();
		}

		// Token: 0x0603A304 RID: 238340 RVA: 0x007D7F2C File Offset: 0x007D612C
		public static IVisualNovelPlayScreenEffectConfigBase_UnionUnion FromIVisualNovelPlayScreenEffectOneShot(IVisualNovelPlayScreenEffectOneShotT _ivisualnovelplayscreeneffectoneshot)
		{
			return new IVisualNovelPlayScreenEffectConfigBase_UnionUnion
			{
				Type = IVisualNovelPlayScreenEffectConfigBase_Union.IVisualNovelPlayScreenEffectOneShot,
				Value = _ivisualnovelplayscreeneffectoneshot
			};
		}

		// Token: 0x0603A305 RID: 238341 RVA: 0x007D7F41 File Offset: 0x007D6141
		public IVisualNovelPlayScreenEffectPersistentT AsIVisualNovelPlayScreenEffectPersistent()
		{
			return this.As<IVisualNovelPlayScreenEffectPersistentT>();
		}

		// Token: 0x0603A306 RID: 238342 RVA: 0x007D7F49 File Offset: 0x007D6149
		public static IVisualNovelPlayScreenEffectConfigBase_UnionUnion FromIVisualNovelPlayScreenEffectPersistent(IVisualNovelPlayScreenEffectPersistentT _ivisualnovelplayscreeneffectpersistent)
		{
			return new IVisualNovelPlayScreenEffectConfigBase_UnionUnion
			{
				Type = IVisualNovelPlayScreenEffectConfigBase_Union.IVisualNovelPlayScreenEffectPersistent,
				Value = _ivisualnovelplayscreeneffectpersistent
			};
		}

		// Token: 0x0603A307 RID: 238343 RVA: 0x007D7F5E File Offset: 0x007D615E
		public IVisualNovelPlayScreenEffectCustomT AsIVisualNovelPlayScreenEffectCustom()
		{
			return this.As<IVisualNovelPlayScreenEffectCustomT>();
		}

		// Token: 0x0603A308 RID: 238344 RVA: 0x007D7F66 File Offset: 0x007D6166
		public static IVisualNovelPlayScreenEffectConfigBase_UnionUnion FromIVisualNovelPlayScreenEffectCustom(IVisualNovelPlayScreenEffectCustomT _ivisualnovelplayscreeneffectcustom)
		{
			return new IVisualNovelPlayScreenEffectConfigBase_UnionUnion
			{
				Type = IVisualNovelPlayScreenEffectConfigBase_Union.IVisualNovelPlayScreenEffectCustom,
				Value = _ivisualnovelplayscreeneffectcustom
			};
		}

		// Token: 0x0603A309 RID: 238345 RVA: 0x007D7F7C File Offset: 0x007D617C
		public static int Pack(FlatBufferBuilder builder, IVisualNovelPlayScreenEffectConfigBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IVisualNovelPlayScreenEffectConfigBase_Union.IVisualNovelPlayScreenEffectConfigBase:
				return IVisualNovelPlayScreenEffectConfigBase.Pack(builder, _o.AsIVisualNovelPlayScreenEffectConfigBase()).Value;
			case IVisualNovelPlayScreenEffectConfigBase_Union.IVisualNovelPlayScreenEffectOneShot:
				return IVisualNovelPlayScreenEffectOneShot.Pack(builder, _o.AsIVisualNovelPlayScreenEffectOneShot()).Value;
			case IVisualNovelPlayScreenEffectConfigBase_Union.IVisualNovelPlayScreenEffectPersistent:
				return IVisualNovelPlayScreenEffectPersistent.Pack(builder, _o.AsIVisualNovelPlayScreenEffectPersistent()).Value;
			case IVisualNovelPlayScreenEffectConfigBase_Union.IVisualNovelPlayScreenEffectCustom:
				return IVisualNovelPlayScreenEffectCustom.Pack(builder, _o.AsIVisualNovelPlayScreenEffectCustom()).Value;
			default:
				return 0;
			}
		}
	}
}
