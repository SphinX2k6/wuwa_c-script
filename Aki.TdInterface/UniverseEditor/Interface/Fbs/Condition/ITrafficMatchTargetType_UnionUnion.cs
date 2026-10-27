using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D04 RID: 19716
	public class ITrafficMatchTargetType_UnionUnion
	{
		// Token: 0x17008F09 RID: 36617
		// (get) Token: 0x0601F4B4 RID: 128180 RVA: 0x0045D901 File Offset: 0x0045BB01
		// (set) Token: 0x0601F4B5 RID: 128181 RVA: 0x0045D909 File Offset: 0x0045BB09
		public ITrafficMatchTargetType_Union Type { get; set; }

		// Token: 0x17008F0A RID: 36618
		// (get) Token: 0x0601F4B6 RID: 128182 RVA: 0x0045D912 File Offset: 0x0045BB12
		// (set) Token: 0x0601F4B7 RID: 128183 RVA: 0x0045D91A File Offset: 0x0045BB1A
		public object Value { get; set; }

		// Token: 0x0601F4B8 RID: 128184 RVA: 0x0045D923 File Offset: 0x0045BB23
		public ITrafficMatchTargetType_UnionUnion()
		{
			this.Type = ITrafficMatchTargetType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601F4B9 RID: 128185 RVA: 0x0045D939 File Offset: 0x0045BB39
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601F4BA RID: 128186 RVA: 0x0045D94B File Offset: 0x0045BB4B
		public ITrafficMatchTargetTypeT AsITrafficMatchTargetType()
		{
			return this.As<ITrafficMatchTargetTypeT>();
		}

		// Token: 0x0601F4BB RID: 128187 RVA: 0x0045D953 File Offset: 0x0045BB53
		public static ITrafficMatchTargetType_UnionUnion FromITrafficMatchTargetType(ITrafficMatchTargetTypeT _itrafficmatchtargettype)
		{
			return new ITrafficMatchTargetType_UnionUnion
			{
				Type = ITrafficMatchTargetType_Union.ITrafficMatchTargetType,
				Value = _itrafficmatchtargettype
			};
		}

		// Token: 0x0601F4BC RID: 128188 RVA: 0x0045D968 File Offset: 0x0045BB68
		public ITrafficMatchTargetByEntityLogicT AsITrafficMatchTargetByEntityLogic()
		{
			return this.As<ITrafficMatchTargetByEntityLogicT>();
		}

		// Token: 0x0601F4BD RID: 128189 RVA: 0x0045D970 File Offset: 0x0045BB70
		public static ITrafficMatchTargetType_UnionUnion FromITrafficMatchTargetByEntityLogic(ITrafficMatchTargetByEntityLogicT _itrafficmatchtargetbyentitylogic)
		{
			return new ITrafficMatchTargetType_UnionUnion
			{
				Type = ITrafficMatchTargetType_Union.ITrafficMatchTargetByEntityLogic,
				Value = _itrafficmatchtargetbyentitylogic
			};
		}

		// Token: 0x0601F4BE RID: 128190 RVA: 0x0045D988 File Offset: 0x0045BB88
		public static int Pack(FlatBufferBuilder builder, ITrafficMatchTargetType_UnionUnion _o)
		{
			ITrafficMatchTargetType_Union type = _o.Type;
			if (type == ITrafficMatchTargetType_Union.ITrafficMatchTargetType)
			{
				return ITrafficMatchTargetType.Pack(builder, _o.AsITrafficMatchTargetType()).Value;
			}
			if (type != ITrafficMatchTargetType_Union.ITrafficMatchTargetByEntityLogic)
			{
				return 0;
			}
			return ITrafficMatchTargetByEntityLogic.Pack(builder, _o.AsITrafficMatchTargetByEntityLogic()).Value;
		}
	}
}
