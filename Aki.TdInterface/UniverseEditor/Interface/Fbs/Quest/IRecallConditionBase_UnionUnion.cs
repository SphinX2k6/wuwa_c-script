using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044B8 RID: 17592
	public class IRecallConditionBase_UnionUnion
	{
		// Token: 0x17007A74 RID: 31348
		// (get) Token: 0x0601966A RID: 104042 RVA: 0x003A011A File Offset: 0x0039E31A
		// (set) Token: 0x0601966B RID: 104043 RVA: 0x003A0122 File Offset: 0x0039E322
		public IRecallConditionBase_Union Type { get; set; }

		// Token: 0x17007A75 RID: 31349
		// (get) Token: 0x0601966C RID: 104044 RVA: 0x003A012B File Offset: 0x0039E32B
		// (set) Token: 0x0601966D RID: 104045 RVA: 0x003A0133 File Offset: 0x0039E333
		public object Value { get; set; }

		// Token: 0x0601966E RID: 104046 RVA: 0x003A013C File Offset: 0x0039E33C
		public IRecallConditionBase_UnionUnion()
		{
			this.Type = IRecallConditionBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601966F RID: 104047 RVA: 0x003A0152 File Offset: 0x0039E352
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06019670 RID: 104048 RVA: 0x003A0164 File Offset: 0x0039E364
		public IRecallConditionBaseT AsIRecallConditionBase()
		{
			return this.As<IRecallConditionBaseT>();
		}

		// Token: 0x06019671 RID: 104049 RVA: 0x003A016C File Offset: 0x0039E36C
		public static IRecallConditionBase_UnionUnion FromIRecallConditionBase(IRecallConditionBaseT _irecallconditionbase)
		{
			return new IRecallConditionBase_UnionUnion
			{
				Type = IRecallConditionBase_Union.IRecallConditionBase,
				Value = _irecallconditionbase
			};
		}

		// Token: 0x06019672 RID: 104050 RVA: 0x003A0181 File Offset: 0x0039E381
		public IRecallConditionByEntityTypeT AsIRecallConditionByEntityType()
		{
			return this.As<IRecallConditionByEntityTypeT>();
		}

		// Token: 0x06019673 RID: 104051 RVA: 0x003A0189 File Offset: 0x0039E389
		public static IRecallConditionBase_UnionUnion FromIRecallConditionByEntityType(IRecallConditionByEntityTypeT _irecallconditionbyentitytype)
		{
			return new IRecallConditionBase_UnionUnion
			{
				Type = IRecallConditionBase_Union.IRecallConditionByEntityType,
				Value = _irecallconditionbyentitytype
			};
		}

		// Token: 0x06019674 RID: 104052 RVA: 0x003A019E File Offset: 0x0039E39E
		public IRecallConditionByTemplateT AsIRecallConditionByTemplate()
		{
			return this.As<IRecallConditionByTemplateT>();
		}

		// Token: 0x06019675 RID: 104053 RVA: 0x003A01A6 File Offset: 0x0039E3A6
		public static IRecallConditionBase_UnionUnion FromIRecallConditionByTemplate(IRecallConditionByTemplateT _irecallconditionbytemplate)
		{
			return new IRecallConditionBase_UnionUnion
			{
				Type = IRecallConditionBase_Union.IRecallConditionByTemplate,
				Value = _irecallconditionbytemplate
			};
		}

		// Token: 0x06019676 RID: 104054 RVA: 0x003A01BB File Offset: 0x0039E3BB
		public IRecallConditionByGroupT AsIRecallConditionByGroup()
		{
			return this.As<IRecallConditionByGroupT>();
		}

		// Token: 0x06019677 RID: 104055 RVA: 0x003A01C3 File Offset: 0x0039E3C3
		public static IRecallConditionBase_UnionUnion FromIRecallConditionByGroup(IRecallConditionByGroupT _irecallconditionbygroup)
		{
			return new IRecallConditionBase_UnionUnion
			{
				Type = IRecallConditionBase_Union.IRecallConditionByGroup,
				Value = _irecallconditionbygroup
			};
		}

		// Token: 0x06019678 RID: 104056 RVA: 0x003A01D8 File Offset: 0x0039E3D8
		public static int Pack(FlatBufferBuilder builder, IRecallConditionBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IRecallConditionBase_Union.IRecallConditionBase:
				return IRecallConditionBase.Pack(builder, _o.AsIRecallConditionBase()).Value;
			case IRecallConditionBase_Union.IRecallConditionByEntityType:
				return IRecallConditionByEntityType.Pack(builder, _o.AsIRecallConditionByEntityType()).Value;
			case IRecallConditionBase_Union.IRecallConditionByTemplate:
				return IRecallConditionByTemplate.Pack(builder, _o.AsIRecallConditionByTemplate()).Value;
			case IRecallConditionBase_Union.IRecallConditionByGroup:
				return IRecallConditionByGroup.Pack(builder, _o.AsIRecallConditionByGroup()).Value;
			default:
				return 0;
			}
		}
	}
}
