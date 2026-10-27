using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007660 RID: 30304
	public class TChangeEntityPrefabPerformanceUnion
	{
		// Token: 0x1700E5D3 RID: 58835
		// (get) Token: 0x060372A4 RID: 225956 RVA: 0x0077A95E File Offset: 0x00778B5E
		// (set) Token: 0x060372A5 RID: 225957 RVA: 0x0077A966 File Offset: 0x00778B66
		public TChangeEntityPrefabPerformance Type { get; set; }

		// Token: 0x1700E5D4 RID: 58836
		// (get) Token: 0x060372A6 RID: 225958 RVA: 0x0077A96F File Offset: 0x00778B6F
		// (set) Token: 0x060372A7 RID: 225959 RVA: 0x0077A977 File Offset: 0x00778B77
		public object Value { get; set; }

		// Token: 0x060372A8 RID: 225960 RVA: 0x0077A980 File Offset: 0x00778B80
		public TChangeEntityPrefabPerformanceUnion()
		{
			this.Type = TChangeEntityPrefabPerformance.NONE;
			this.Value = null;
		}

		// Token: 0x060372A9 RID: 225961 RVA: 0x0077A996 File Offset: 0x00778B96
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060372AA RID: 225962 RVA: 0x0077A9A8 File Offset: 0x00778BA8
		public IChangeSelfEntityPrefabPerformanceT AsIChangeSelfEntityPrefabPerformance()
		{
			return this.As<IChangeSelfEntityPrefabPerformanceT>();
		}

		// Token: 0x060372AB RID: 225963 RVA: 0x0077A9B0 File Offset: 0x00778BB0
		public static TChangeEntityPrefabPerformanceUnion FromIChangeSelfEntityPrefabPerformance(IChangeSelfEntityPrefabPerformanceT _ichangeselfentityprefabperformance)
		{
			return new TChangeEntityPrefabPerformanceUnion
			{
				Type = TChangeEntityPrefabPerformance.IChangeSelfEntityPrefabPerformance,
				Value = _ichangeselfentityprefabperformance
			};
		}

		// Token: 0x060372AC RID: 225964 RVA: 0x0077A9C5 File Offset: 0x00778BC5
		public IChangeTargetEntityPrefabPerformanceT AsIChangeTargetEntityPrefabPerformance()
		{
			return this.As<IChangeTargetEntityPrefabPerformanceT>();
		}

		// Token: 0x060372AD RID: 225965 RVA: 0x0077A9CD File Offset: 0x00778BCD
		public static TChangeEntityPrefabPerformanceUnion FromIChangeTargetEntityPrefabPerformance(IChangeTargetEntityPrefabPerformanceT _ichangetargetentityprefabperformance)
		{
			return new TChangeEntityPrefabPerformanceUnion
			{
				Type = TChangeEntityPrefabPerformance.IChangeTargetEntityPrefabPerformance,
				Value = _ichangetargetentityprefabperformance
			};
		}

		// Token: 0x060372AE RID: 225966 RVA: 0x0077A9E4 File Offset: 0x00778BE4
		public static int Pack(FlatBufferBuilder builder, TChangeEntityPrefabPerformanceUnion _o)
		{
			TChangeEntityPrefabPerformance type = _o.Type;
			if (type == TChangeEntityPrefabPerformance.IChangeSelfEntityPrefabPerformance)
			{
				return IChangeSelfEntityPrefabPerformance.Pack(builder, _o.AsIChangeSelfEntityPrefabPerformance()).Value;
			}
			if (type != TChangeEntityPrefabPerformance.IChangeTargetEntityPrefabPerformance)
			{
				return 0;
			}
			return IChangeTargetEntityPrefabPerformance.Pack(builder, _o.AsIChangeTargetEntityPrefabPerformance()).Value;
		}
	}
}
