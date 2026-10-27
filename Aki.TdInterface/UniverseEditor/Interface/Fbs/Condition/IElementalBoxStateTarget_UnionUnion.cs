using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C0E RID: 19470
	public class IElementalBoxStateTarget_UnionUnion
	{
		// Token: 0x17008D6B RID: 36203
		// (get) Token: 0x0601ED55 RID: 126293 RVA: 0x00451395 File Offset: 0x0044F595
		// (set) Token: 0x0601ED56 RID: 126294 RVA: 0x0045139D File Offset: 0x0044F59D
		public IElementalBoxStateTarget_Union Type { get; set; }

		// Token: 0x17008D6C RID: 36204
		// (get) Token: 0x0601ED57 RID: 126295 RVA: 0x004513A6 File Offset: 0x0044F5A6
		// (set) Token: 0x0601ED58 RID: 126296 RVA: 0x004513AE File Offset: 0x0044F5AE
		public object Value { get; set; }

		// Token: 0x0601ED59 RID: 126297 RVA: 0x004513B7 File Offset: 0x0044F5B7
		public IElementalBoxStateTarget_UnionUnion()
		{
			this.Type = IElementalBoxStateTarget_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601ED5A RID: 126298 RVA: 0x004513CD File Offset: 0x0044F5CD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601ED5B RID: 126299 RVA: 0x004513DF File Offset: 0x0044F5DF
		public IElementalBoxStateTargetT AsIElementalBoxStateTarget()
		{
			return this.As<IElementalBoxStateTargetT>();
		}

		// Token: 0x0601ED5C RID: 126300 RVA: 0x004513E7 File Offset: 0x0044F5E7
		public static IElementalBoxStateTarget_UnionUnion FromIElementalBoxStateTarget(IElementalBoxStateTargetT _ielementalboxstatetarget)
		{
			return new IElementalBoxStateTarget_UnionUnion
			{
				Type = IElementalBoxStateTarget_Union.IElementalBoxStateTarget,
				Value = _ielementalboxstatetarget
			};
		}

		// Token: 0x0601ED5D RID: 126301 RVA: 0x004513FC File Offset: 0x0044F5FC
		public IElementalBoxStatePlayerTargetT AsIElementalBoxStatePlayerTarget()
		{
			return this.As<IElementalBoxStatePlayerTargetT>();
		}

		// Token: 0x0601ED5E RID: 126302 RVA: 0x00451404 File Offset: 0x0044F604
		public static IElementalBoxStateTarget_UnionUnion FromIElementalBoxStatePlayerTarget(IElementalBoxStatePlayerTargetT _ielementalboxstateplayertarget)
		{
			return new IElementalBoxStateTarget_UnionUnion
			{
				Type = IElementalBoxStateTarget_Union.IElementalBoxStatePlayerTarget,
				Value = _ielementalboxstateplayertarget
			};
		}

		// Token: 0x0601ED5F RID: 126303 RVA: 0x00451419 File Offset: 0x0044F619
		public IElementalBoxStateFoundationTargetT AsIElementalBoxStateFoundationTarget()
		{
			return this.As<IElementalBoxStateFoundationTargetT>();
		}

		// Token: 0x0601ED60 RID: 126304 RVA: 0x00451421 File Offset: 0x0044F621
		public static IElementalBoxStateTarget_UnionUnion FromIElementalBoxStateFoundationTarget(IElementalBoxStateFoundationTargetT _ielementalboxstatefoundationtarget)
		{
			return new IElementalBoxStateTarget_UnionUnion
			{
				Type = IElementalBoxStateTarget_Union.IElementalBoxStateFoundationTarget,
				Value = _ielementalboxstatefoundationtarget
			};
		}

		// Token: 0x0601ED61 RID: 126305 RVA: 0x00451436 File Offset: 0x0044F636
		public IElementalBoxStateFoundationSelfTargetT AsIElementalBoxStateFoundationSelfTarget()
		{
			return this.As<IElementalBoxStateFoundationSelfTargetT>();
		}

		// Token: 0x0601ED62 RID: 126306 RVA: 0x0045143E File Offset: 0x0044F63E
		public static IElementalBoxStateTarget_UnionUnion FromIElementalBoxStateFoundationSelfTarget(IElementalBoxStateFoundationSelfTargetT _ielementalboxstatefoundationselftarget)
		{
			return new IElementalBoxStateTarget_UnionUnion
			{
				Type = IElementalBoxStateTarget_Union.IElementalBoxStateFoundationSelfTarget,
				Value = _ielementalboxstatefoundationselftarget
			};
		}

		// Token: 0x0601ED63 RID: 126307 RVA: 0x00451453 File Offset: 0x0044F653
		public IElementalBoxStateSpecifiedTargetT AsIElementalBoxStateSpecifiedTarget()
		{
			return this.As<IElementalBoxStateSpecifiedTargetT>();
		}

		// Token: 0x0601ED64 RID: 126308 RVA: 0x0045145B File Offset: 0x0044F65B
		public static IElementalBoxStateTarget_UnionUnion FromIElementalBoxStateSpecifiedTarget(IElementalBoxStateSpecifiedTargetT _ielementalboxstatespecifiedtarget)
		{
			return new IElementalBoxStateTarget_UnionUnion
			{
				Type = IElementalBoxStateTarget_Union.IElementalBoxStateSpecifiedTarget,
				Value = _ielementalboxstatespecifiedtarget
			};
		}

		// Token: 0x0601ED65 RID: 126309 RVA: 0x00451470 File Offset: 0x0044F670
		public static int Pack(FlatBufferBuilder builder, IElementalBoxStateTarget_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IElementalBoxStateTarget_Union.IElementalBoxStateTarget:
				return IElementalBoxStateTarget.Pack(builder, _o.AsIElementalBoxStateTarget()).Value;
			case IElementalBoxStateTarget_Union.IElementalBoxStatePlayerTarget:
				return IElementalBoxStatePlayerTarget.Pack(builder, _o.AsIElementalBoxStatePlayerTarget()).Value;
			case IElementalBoxStateTarget_Union.IElementalBoxStateFoundationTarget:
				return IElementalBoxStateFoundationTarget.Pack(builder, _o.AsIElementalBoxStateFoundationTarget()).Value;
			case IElementalBoxStateTarget_Union.IElementalBoxStateFoundationSelfTarget:
				return IElementalBoxStateFoundationSelfTarget.Pack(builder, _o.AsIElementalBoxStateFoundationSelfTarget()).Value;
			case IElementalBoxStateTarget_Union.IElementalBoxStateSpecifiedTarget:
				return IElementalBoxStateSpecifiedTarget.Pack(builder, _o.AsIElementalBoxStateSpecifiedTarget()).Value;
			default:
				return 0;
			}
		}
	}
}
