using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.MusicalInstrument
{
	// Token: 0x0200537A RID: 21370
	public abstract class MusicalInstrumentSubController
	{
		// Token: 0x0603696E RID: 223598
		public new abstract EInstrumentType GetType();

		// Token: 0x0603696F RID: 223599
		public abstract UniTask<bool> OnEnter([Nullable(1)] MusicalInstrumentEnterParam param);

		// Token: 0x06036970 RID: 223600
		public abstract UniTask<bool> OnExit([Nullable(1)] MusicalInstrumentExitParam param);

		// Token: 0x06036971 RID: 223601 RVA: 0x00CECE29 File Offset: 0x00CEB029
		public virtual void CancelEnter()
		{
		}

		// Token: 0x06036972 RID: 223602 RVA: 0x00CECE2B File Offset: 0x00CEB02B
		[NullableContext(2)]
		protected MusicalInstrumentSubModel GetSubModel()
		{
			return MusicalInstrumentModel.Instance.GetSubModel(this.GetType());
		}

		// Token: 0x06036973 RID: 223603 RVA: 0x00CECE3D File Offset: 0x00CEB03D
		public virtual void OnQteCompleted()
		{
		}
	}
}
