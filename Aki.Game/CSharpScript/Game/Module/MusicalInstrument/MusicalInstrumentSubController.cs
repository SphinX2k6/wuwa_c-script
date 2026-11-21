using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.MusicalInstrument
{
	// Token: 0x0200435D RID: 17245
	public abstract class MusicalInstrumentSubController
	{
		// Token: 0x0602B8B4 RID: 178356
		public new abstract EInstrumentType GetType();

		// Token: 0x0602B8B5 RID: 178357
		public abstract UniTask<bool> OnEnter([Nullable(1)] MusicalInstrumentEnterParam param);

		// Token: 0x0602B8B6 RID: 178358
		public abstract UniTask<bool> OnExit([Nullable(1)] MusicalInstrumentExitParam param);

		// Token: 0x0602B8B7 RID: 178359 RVA: 0x00C3BD21 File Offset: 0x00C39F21
		public virtual void CancelEnter()
		{
		}

		// Token: 0x0602B8B8 RID: 178360 RVA: 0x00C3BD23 File Offset: 0x00C39F23
		[NullableContext(2)]
		protected MusicalInstrumentSubModel GetSubModel()
		{
			return MusicalInstrumentModel.Instance.GetSubModel(this.GetType());
		}

		// Token: 0x0602B8B9 RID: 178361 RVA: 0x00C3BD35 File Offset: 0x00C39F35
		public virtual void OnQteCompleted()
		{
		}
	}
}
