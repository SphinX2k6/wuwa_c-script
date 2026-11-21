using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079FC RID: 31228
	public class ISubtitleStyleBase_UnionUnion
	{
		// Token: 0x1700E4E3 RID: 58595
		// (get) Token: 0x06037064 RID: 225380 RVA: 0x0075AEF9 File Offset: 0x007590F9
		// (set) Token: 0x06037065 RID: 225381 RVA: 0x0075AF01 File Offset: 0x00759101
		public ISubtitleStyleBase_Union Type { get; set; }

		// Token: 0x1700E4E4 RID: 58596
		// (get) Token: 0x06037066 RID: 225382 RVA: 0x0075AF0A File Offset: 0x0075910A
		// (set) Token: 0x06037067 RID: 225383 RVA: 0x0075AF12 File Offset: 0x00759112
		public object Value { get; set; }

		// Token: 0x06037068 RID: 225384 RVA: 0x0075AF1B File Offset: 0x0075911B
		public ISubtitleStyleBase_UnionUnion()
		{
			this.Type = ISubtitleStyleBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06037069 RID: 225385 RVA: 0x0075AF31 File Offset: 0x00759131
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603706A RID: 225386 RVA: 0x0075AF43 File Offset: 0x00759143
		public ISubtitleStyleBaseT AsISubtitleStyleBase()
		{
			return this.As<ISubtitleStyleBaseT>();
		}

		// Token: 0x0603706B RID: 225387 RVA: 0x0075AF4B File Offset: 0x0075914B
		public static ISubtitleStyleBase_UnionUnion FromISubtitleStyleBase(ISubtitleStyleBaseT _isubtitlestylebase)
		{
			return new ISubtitleStyleBase_UnionUnion
			{
				Type = ISubtitleStyleBase_Union.ISubtitleStyleBase,
				Value = _isubtitlestylebase
			};
		}

		// Token: 0x0603706C RID: 225388 RVA: 0x0075AF60 File Offset: 0x00759160
		public ISubtitleStyleLevelAT AsISubtitleStyleLevelA()
		{
			return this.As<ISubtitleStyleLevelAT>();
		}

		// Token: 0x0603706D RID: 225389 RVA: 0x0075AF68 File Offset: 0x00759168
		public static ISubtitleStyleBase_UnionUnion FromISubtitleStyleLevelA(ISubtitleStyleLevelAT _isubtitlestylelevela)
		{
			return new ISubtitleStyleBase_UnionUnion
			{
				Type = ISubtitleStyleBase_Union.ISubtitleStyleLevelA,
				Value = _isubtitlestylelevela
			};
		}

		// Token: 0x0603706E RID: 225390 RVA: 0x0075AF7D File Offset: 0x0075917D
		public ISubtitleStyleNewLevelBT AsISubtitleStyleNewLevelB()
		{
			return this.As<ISubtitleStyleNewLevelBT>();
		}

		// Token: 0x0603706F RID: 225391 RVA: 0x0075AF85 File Offset: 0x00759185
		public static ISubtitleStyleBase_UnionUnion FromISubtitleStyleNewLevelB(ISubtitleStyleNewLevelBT _isubtitlestylenewlevelb)
		{
			return new ISubtitleStyleBase_UnionUnion
			{
				Type = ISubtitleStyleBase_Union.ISubtitleStyleNewLevelB,
				Value = _isubtitlestylenewlevelb
			};
		}

		// Token: 0x06037070 RID: 225392 RVA: 0x0075AF9C File Offset: 0x0075919C
		public static int Pack(FlatBufferBuilder builder, ISubtitleStyleBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISubtitleStyleBase_Union.ISubtitleStyleBase:
				return ISubtitleStyleBase.Pack(builder, _o.AsISubtitleStyleBase()).Value;
			case ISubtitleStyleBase_Union.ISubtitleStyleLevelA:
				return ISubtitleStyleLevelA.Pack(builder, _o.AsISubtitleStyleLevelA()).Value;
			case ISubtitleStyleBase_Union.ISubtitleStyleNewLevelB:
				return ISubtitleStyleNewLevelB.Pack(builder, _o.AsISubtitleStyleNewLevelB()).Value;
			default:
				return 0;
			}
		}
	}
}
