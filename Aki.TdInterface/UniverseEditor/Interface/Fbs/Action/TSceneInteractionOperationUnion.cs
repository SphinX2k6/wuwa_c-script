using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007775 RID: 30581
	public class TSceneInteractionOperationUnion
	{
		// Token: 0x1700E691 RID: 59025
		// (get) Token: 0x0603788A RID: 227466 RVA: 0x00783E48 File Offset: 0x00782048
		// (set) Token: 0x0603788B RID: 227467 RVA: 0x00783E50 File Offset: 0x00782050
		public TSceneInteractionOperation Type { get; set; }

		// Token: 0x1700E692 RID: 59026
		// (get) Token: 0x0603788C RID: 227468 RVA: 0x00783E59 File Offset: 0x00782059
		// (set) Token: 0x0603788D RID: 227469 RVA: 0x00783E61 File Offset: 0x00782061
		public object Value { get; set; }

		// Token: 0x0603788E RID: 227470 RVA: 0x00783E6A File Offset: 0x0078206A
		public TSceneInteractionOperationUnion()
		{
			this.Type = TSceneInteractionOperation.NONE;
			this.Value = null;
		}

		// Token: 0x0603788F RID: 227471 RVA: 0x00783E80 File Offset: 0x00782080
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037890 RID: 227472 RVA: 0x00783E92 File Offset: 0x00782092
		public IDisableSceneInteractionOperationT AsIDisableSceneInteractionOperation()
		{
			return this.As<IDisableSceneInteractionOperationT>();
		}

		// Token: 0x06037891 RID: 227473 RVA: 0x00783E9A File Offset: 0x0078209A
		public static TSceneInteractionOperationUnion FromIDisableSceneInteractionOperation(IDisableSceneInteractionOperationT _idisablesceneinteractionoperation)
		{
			return new TSceneInteractionOperationUnion
			{
				Type = TSceneInteractionOperation.IDisableSceneInteractionOperation,
				Value = _idisablesceneinteractionoperation
			};
		}

		// Token: 0x06037892 RID: 227474 RVA: 0x00783EAF File Offset: 0x007820AF
		public IEnableSceneInteractionOperationT AsIEnableSceneInteractionOperation()
		{
			return this.As<IEnableSceneInteractionOperationT>();
		}

		// Token: 0x06037893 RID: 227475 RVA: 0x00783EB7 File Offset: 0x007820B7
		public static TSceneInteractionOperationUnion FromIEnableSceneInteractionOperation(IEnableSceneInteractionOperationT _ienablesceneinteractionoperation)
		{
			return new TSceneInteractionOperationUnion
			{
				Type = TSceneInteractionOperation.IEnableSceneInteractionOperation,
				Value = _ienablesceneinteractionoperation
			};
		}

		// Token: 0x06037894 RID: 227476 RVA: 0x00783ECC File Offset: 0x007820CC
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
