using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006192 RID: 24978
	public class IAlertValueSpeedChangeType_UnionUnion
	{
		// Token: 0x1700BA33 RID: 47667
		// (get) Token: 0x0602B056 RID: 176214 RVA: 0x005EF2ED File Offset: 0x005ED4ED
		// (set) Token: 0x0602B057 RID: 176215 RVA: 0x005EF2F5 File Offset: 0x005ED4F5
		public IAlertValueSpeedChangeType_Union Type { get; set; }

		// Token: 0x1700BA34 RID: 47668
		// (get) Token: 0x0602B058 RID: 176216 RVA: 0x005EF2FE File Offset: 0x005ED4FE
		// (set) Token: 0x0602B059 RID: 176217 RVA: 0x005EF306 File Offset: 0x005ED506
		public object Value { get; set; }

		// Token: 0x0602B05A RID: 176218 RVA: 0x005EF30F File Offset: 0x005ED50F
		public IAlertValueSpeedChangeType_UnionUnion()
		{
			this.Type = IAlertValueSpeedChangeType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602B05B RID: 176219 RVA: 0x005EF325 File Offset: 0x005ED525
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B05C RID: 176220 RVA: 0x005EF337 File Offset: 0x005ED537
		public IAlertValueSpeedChangeTypeT AsIAlertValueSpeedChangeType()
		{
			return this.As<IAlertValueSpeedChangeTypeT>();
		}

		// Token: 0x0602B05D RID: 176221 RVA: 0x005EF33F File Offset: 0x005ED53F
		public static IAlertValueSpeedChangeType_UnionUnion FromIAlertValueSpeedChangeType(IAlertValueSpeedChangeTypeT _ialertvaluespeedchangetype)
		{
			return new IAlertValueSpeedChangeType_UnionUnion
			{
				Type = IAlertValueSpeedChangeType_Union.IAlertValueSpeedChangeType,
				Value = _ialertvaluespeedchangetype
			};
		}

		// Token: 0x0602B05E RID: 176222 RVA: 0x005EF354 File Offset: 0x005ED554
		public IAddOrSubAlertValueChangeSpeedT AsIAddOrSubAlertValueChangeSpeed()
		{
			return this.As<IAddOrSubAlertValueChangeSpeedT>();
		}

		// Token: 0x0602B05F RID: 176223 RVA: 0x005EF35C File Offset: 0x005ED55C
		public static IAlertValueSpeedChangeType_UnionUnion FromIAddOrSubAlertValueChangeSpeed(IAddOrSubAlertValueChangeSpeedT _iaddorsubalertvaluechangespeed)
		{
			return new IAlertValueSpeedChangeType_UnionUnion
			{
				Type = IAlertValueSpeedChangeType_Union.IAddOrSubAlertValueChangeSpeed,
				Value = _iaddorsubalertvaluechangespeed
			};
		}

		// Token: 0x0602B060 RID: 176224 RVA: 0x005EF371 File Offset: 0x005ED571
		public ICustomAlertValueChangeSpeedT AsICustomAlertValueChangeSpeed()
		{
			return this.As<ICustomAlertValueChangeSpeedT>();
		}

		// Token: 0x0602B061 RID: 176225 RVA: 0x005EF379 File Offset: 0x005ED579
		public static IAlertValueSpeedChangeType_UnionUnion FromICustomAlertValueChangeSpeed(ICustomAlertValueChangeSpeedT _icustomalertvaluechangespeed)
		{
			return new IAlertValueSpeedChangeType_UnionUnion
			{
				Type = IAlertValueSpeedChangeType_Union.ICustomAlertValueChangeSpeed,
				Value = _icustomalertvaluechangespeed
			};
		}

		// Token: 0x0602B062 RID: 176226 RVA: 0x005EF390 File Offset: 0x005ED590
		public static int Pack(FlatBufferBuilder builder, IAlertValueSpeedChangeType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IAlertValueSpeedChangeType_Union.IAlertValueSpeedChangeType:
				return IAlertValueSpeedChangeType.Pack(builder, _o.AsIAlertValueSpeedChangeType()).Value;
			case IAlertValueSpeedChangeType_Union.IAddOrSubAlertValueChangeSpeed:
				return IAddOrSubAlertValueChangeSpeed.Pack(builder, _o.AsIAddOrSubAlertValueChangeSpeed()).Value;
			case IAlertValueSpeedChangeType_Union.ICustomAlertValueChangeSpeed:
				return ICustomAlertValueChangeSpeed.Pack(builder, _o.AsICustomAlertValueChangeSpeed()).Value;
			default:
				return 0;
			}
		}
	}
}
