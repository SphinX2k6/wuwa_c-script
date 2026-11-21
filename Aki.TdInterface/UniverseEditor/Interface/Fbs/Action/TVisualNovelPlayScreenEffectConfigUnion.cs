using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02008058 RID: 32856
	public class TVisualNovelPlayScreenEffectConfigUnion
	{
		// Token: 0x1700F35D RID: 62301
		// (get) Token: 0x0603B195 RID: 242069 RVA: 0x007EEA86 File Offset: 0x007ECC86
		// (set) Token: 0x0603B196 RID: 242070 RVA: 0x007EEA8E File Offset: 0x007ECC8E
		public TVisualNovelPlayScreenEffectConfig Type { get; set; }

		// Token: 0x1700F35E RID: 62302
		// (get) Token: 0x0603B197 RID: 242071 RVA: 0x007EEA97 File Offset: 0x007ECC97
		// (set) Token: 0x0603B198 RID: 242072 RVA: 0x007EEA9F File Offset: 0x007ECC9F
		public object Value { get; set; }

		// Token: 0x0603B199 RID: 242073 RVA: 0x007EEAA8 File Offset: 0x007ECCA8
		public TVisualNovelPlayScreenEffectConfigUnion()
		{
			this.Type = TVisualNovelPlayScreenEffectConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0603B19A RID: 242074 RVA: 0x007EEABE File Offset: 0x007ECCBE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603B19B RID: 242075 RVA: 0x007EEAD0 File Offset: 0x007ECCD0
		public IVisualNovelPlayScreenEffectCustomT AsIVisualNovelPlayScreenEffectCustom()
		{
			return this.As<IVisualNovelPlayScreenEffectCustomT>();
		}

		// Token: 0x0603B19C RID: 242076 RVA: 0x007EEAD8 File Offset: 0x007ECCD8
		public static TVisualNovelPlayScreenEffectConfigUnion FromIVisualNovelPlayScreenEffectCustom(IVisualNovelPlayScreenEffectCustomT _ivisualnovelplayscreeneffectcustom)
		{
			return new TVisualNovelPlayScreenEffectConfigUnion
			{
				Type = TVisualNovelPlayScreenEffectConfig.IVisualNovelPlayScreenEffectCustom,
				Value = _ivisualnovelplayscreeneffectcustom
			};
		}

		// Token: 0x0603B19D RID: 242077 RVA: 0x007EEAED File Offset: 0x007ECCED
		public IVisualNovelPlayScreenEffectOneShotT AsIVisualNovelPlayScreenEffectOneShot()
		{
			return this.As<IVisualNovelPlayScreenEffectOneShotT>();
		}

		// Token: 0x0603B19E RID: 242078 RVA: 0x007EEAF5 File Offset: 0x007ECCF5
		public static TVisualNovelPlayScreenEffectConfigUnion FromIVisualNovelPlayScreenEffectOneShot(IVisualNovelPlayScreenEffectOneShotT _ivisualnovelplayscreeneffectoneshot)
		{
			return new TVisualNovelPlayScreenEffectConfigUnion
			{
				Type = TVisualNovelPlayScreenEffectConfig.IVisualNovelPlayScreenEffectOneShot,
				Value = _ivisualnovelplayscreeneffectoneshot
			};
		}

		// Token: 0x0603B19F RID: 242079 RVA: 0x007EEB0A File Offset: 0x007ECD0A
		public IVisualNovelPlayScreenEffectPersistentT AsIVisualNovelPlayScreenEffectPersistent()
		{
			return this.As<IVisualNovelPlayScreenEffectPersistentT>();
		}

		// Token: 0x0603B1A0 RID: 242080 RVA: 0x007EEB12 File Offset: 0x007ECD12
		public static TVisualNovelPlayScreenEffectConfigUnion FromIVisualNovelPlayScreenEffectPersistent(IVisualNovelPlayScreenEffectPersistentT _ivisualnovelplayscreeneffectpersistent)
		{
			return new TVisualNovelPlayScreenEffectConfigUnion
			{
				Type = TVisualNovelPlayScreenEffectConfig.IVisualNovelPlayScreenEffectPersistent,
				Value = _ivisualnovelplayscreeneffectpersistent
			};
		}

		// Token: 0x0603B1A1 RID: 242081 RVA: 0x007EEB28 File Offset: 0x007ECD28
		public static int Pack(FlatBufferBuilder builder, TVisualNovelPlayScreenEffectConfigUnion _o)
		{
			switch (_o.Type)
			{
			case TVisualNovelPlayScreenEffectConfig.IVisualNovelPlayScreenEffectCustom:
				return IVisualNovelPlayScreenEffectCustom.Pack(builder, _o.AsIVisualNovelPlayScreenEffectCustom()).Value;
			case TVisualNovelPlayScreenEffectConfig.IVisualNovelPlayScreenEffectOneShot:
				return IVisualNovelPlayScreenEffectOneShot.Pack(builder, _o.AsIVisualNovelPlayScreenEffectOneShot()).Value;
			case TVisualNovelPlayScreenEffectConfig.IVisualNovelPlayScreenEffectPersistent:
				return IVisualNovelPlayScreenEffectPersistent.Pack(builder, _o.AsIVisualNovelPlayScreenEffectPersistent()).Value;
			default:
				return 0;
			}
		}
	}
}
