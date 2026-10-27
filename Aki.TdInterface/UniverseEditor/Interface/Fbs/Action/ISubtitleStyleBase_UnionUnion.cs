using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007227 RID: 29223
	public class ISubtitleStyleBase_UnionUnion
	{
		// Token: 0x1700D8EA RID: 55530
		// (get) Token: 0x06033D62 RID: 212322 RVA: 0x006F9B99 File Offset: 0x006F7D99
		// (set) Token: 0x06033D63 RID: 212323 RVA: 0x006F9BA1 File Offset: 0x006F7DA1
		public ISubtitleStyleBase_Union Type { get; set; }

		// Token: 0x1700D8EB RID: 55531
		// (get) Token: 0x06033D64 RID: 212324 RVA: 0x006F9BAA File Offset: 0x006F7DAA
		// (set) Token: 0x06033D65 RID: 212325 RVA: 0x006F9BB2 File Offset: 0x006F7DB2
		public object Value { get; set; }

		// Token: 0x06033D66 RID: 212326 RVA: 0x006F9BBB File Offset: 0x006F7DBB
		public ISubtitleStyleBase_UnionUnion()
		{
			this.Type = ISubtitleStyleBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06033D67 RID: 212327 RVA: 0x006F9BD1 File Offset: 0x006F7DD1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06033D68 RID: 212328 RVA: 0x006F9BE3 File Offset: 0x006F7DE3
		public ISubtitleStyleBaseT AsISubtitleStyleBase()
		{
			return this.As<ISubtitleStyleBaseT>();
		}

		// Token: 0x06033D69 RID: 212329 RVA: 0x006F9BEB File Offset: 0x006F7DEB
		public static ISubtitleStyleBase_UnionUnion FromISubtitleStyleBase(ISubtitleStyleBaseT _isubtitlestylebase)
		{
			return new ISubtitleStyleBase_UnionUnion
			{
				Type = ISubtitleStyleBase_Union.ISubtitleStyleBase,
				Value = _isubtitlestylebase
			};
		}

		// Token: 0x06033D6A RID: 212330 RVA: 0x006F9C00 File Offset: 0x006F7E00
		public ISubtitleStyleLevelAT AsISubtitleStyleLevelA()
		{
			return this.As<ISubtitleStyleLevelAT>();
		}

		// Token: 0x06033D6B RID: 212331 RVA: 0x006F9C08 File Offset: 0x006F7E08
		public static ISubtitleStyleBase_UnionUnion FromISubtitleStyleLevelA(ISubtitleStyleLevelAT _isubtitlestylelevela)
		{
			return new ISubtitleStyleBase_UnionUnion
			{
				Type = ISubtitleStyleBase_Union.ISubtitleStyleLevelA,
				Value = _isubtitlestylelevela
			};
		}

		// Token: 0x06033D6C RID: 212332 RVA: 0x006F9C1D File Offset: 0x006F7E1D
		public ISubtitleStyleNewLevelBT AsISubtitleStyleNewLevelB()
		{
			return this.As<ISubtitleStyleNewLevelBT>();
		}

		// Token: 0x06033D6D RID: 212333 RVA: 0x006F9C25 File Offset: 0x006F7E25
		public static ISubtitleStyleBase_UnionUnion FromISubtitleStyleNewLevelB(ISubtitleStyleNewLevelBT _isubtitlestylenewlevelb)
		{
			return new ISubtitleStyleBase_UnionUnion
			{
				Type = ISubtitleStyleBase_Union.ISubtitleStyleNewLevelB,
				Value = _isubtitlestylenewlevelb
			};
		}

		// Token: 0x06033D6E RID: 212334 RVA: 0x006F9C3C File Offset: 0x006F7E3C
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
