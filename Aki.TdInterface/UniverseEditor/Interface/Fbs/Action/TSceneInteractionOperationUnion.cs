using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FA1 RID: 32673
	public class TSceneInteractionOperationUnion
	{
		// Token: 0x1700F2E3 RID: 62179
		// (get) Token: 0x0603ADD3 RID: 241107 RVA: 0x007E8F18 File Offset: 0x007E7118
		// (set) Token: 0x0603ADD4 RID: 241108 RVA: 0x007E8F20 File Offset: 0x007E7120
		public TSceneInteractionOperation Type { get; set; }

		// Token: 0x1700F2E4 RID: 62180
		// (get) Token: 0x0603ADD5 RID: 241109 RVA: 0x007E8F29 File Offset: 0x007E7129
		// (set) Token: 0x0603ADD6 RID: 241110 RVA: 0x007E8F31 File Offset: 0x007E7131
		public object Value { get; set; }

		// Token: 0x0603ADD7 RID: 241111 RVA: 0x007E8F3A File Offset: 0x007E713A
		public TSceneInteractionOperationUnion()
		{
			this.Type = TSceneInteractionOperation.NONE;
			this.Value = null;
		}

		// Token: 0x0603ADD8 RID: 241112 RVA: 0x007E8F50 File Offset: 0x007E7150
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603ADD9 RID: 241113 RVA: 0x007E8F62 File Offset: 0x007E7162
		public IDisableSceneInteractionOperationT AsIDisableSceneInteractionOperation()
		{
			return this.As<IDisableSceneInteractionOperationT>();
		}

		// Token: 0x0603ADDA RID: 241114 RVA: 0x007E8F6A File Offset: 0x007E716A
		public static TSceneInteractionOperationUnion FromIDisableSceneInteractionOperation(IDisableSceneInteractionOperationT _idisablesceneinteractionoperation)
		{
			return new TSceneInteractionOperationUnion
			{
				Type = TSceneInteractionOperation.IDisableSceneInteractionOperation,
				Value = _idisablesceneinteractionoperation
			};
		}

		// Token: 0x0603ADDB RID: 241115 RVA: 0x007E8F7F File Offset: 0x007E717F
		public IEnableSceneInteractionOperationT AsIEnableSceneInteractionOperation()
		{
			return this.As<IEnableSceneInteractionOperationT>();
		}

		// Token: 0x0603ADDC RID: 241116 RVA: 0x007E8F87 File Offset: 0x007E7187
		public static TSceneInteractionOperationUnion FromIEnableSceneInteractionOperation(IEnableSceneInteractionOperationT _ienablesceneinteractionoperation)
		{
			return new TSceneInteractionOperationUnion
			{
				Type = TSceneInteractionOperation.IEnableSceneInteractionOperation,
				Value = _ienablesceneinteractionoperation
			};
		}

		// Token: 0x0603ADDD RID: 241117 RVA: 0x007E8F9C File Offset: 0x007E719C
		public static int Pack(FlatBufferBuilder builder, TSceneInteractionOperationUnion _o)
		{
			TSceneInteractionOperation type = _o.Type;
			if (type == TSceneInteractionOperation.IDisableSceneInteractionOperation)
			{
				return IDisableSceneInteractionOperation.Pack(builder, _o.AsIDisableSceneInteractionOperation()).Value;
			}
			if (type != TSceneInteractionOperation.IEnableSceneInteractionOperation)
			{
				return 0;
			}
			return IEnableSceneInteractionOperation.Pack(builder, _o.AsIEnableSceneInteractionOperation()).Value;
		}
	}
}
