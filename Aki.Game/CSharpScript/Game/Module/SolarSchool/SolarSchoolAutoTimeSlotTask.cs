using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058E7 RID: 22759
	public class SolarSchoolAutoTimeSlotTask : SolarSchoolTaskBase
	{
		// Token: 0x060381C6 RID: 229830 RVA: 0x00FAEB91 File Offset: 0x00FACD91
		public SolarSchoolAutoTimeSlotTask([Nullable(new byte[]
		{
			2,
			1
		})] IReadOnlyList<SolarSchoolActionBase> actions = null)
		{
			if (actions != null)
			{
				this.Actions.AddRange(actions);
			}
		}

		// Token: 0x060381C7 RID: 229831 RVA: 0x00FAEBB4 File Offset: 0x00FACDB4
		protected override void OnExecute()
		{
			this.Started = true;
			foreach (SolarSchoolActionBase action in this.Actions)
			{
				base.PushAction(action);
			}
			this.Actions.Clear();
		}

		// Token: 0x060381C8 RID: 229832 RVA: 0x00FAEC1C File Offset: 0x00FACE1C
		protected override void OnTick(float deltaTime)
		{
			this.TryComplete();
		}

		// Token: 0x060381C9 RID: 229833 RVA: 0x00FAEC24 File Offset: 0x00FACE24
		private void TryComplete()
		{
			if (!this.Started)
			{
				return;
			}
			if (base.HandlerHasWork)
			{
				return;
			}
			base.Complete(null);
		}

		// Token: 0x0401D8E5 RID: 121061
		[Nullable(1)]
		private readonly List<SolarSchoolActionBase> Actions = new List<SolarSchoolActionBase>();

		// Token: 0x0401D8E6 RID: 121062
		private bool Started;
	}
}
