using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Model
{
	// Token: 0x0200366B RID: 13931
	[NullableContext(1)]
	[Nullable(0)]
	public class WuWaGoRollbackPreStates : IStaticVariableResetter
	{
		// Token: 0x06024250 RID: 148048 RVA: 0x00A3BFDD File Offset: 0x00A3A1DD
		static WuWaGoRollbackPreStates()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(WuWaGoRollbackPreStates.CreateStaticDefaultValue), new Action(WuWaGoRollbackPreStates.ResetStaticDefaultValue));
		}

		// Token: 0x06024251 RID: 148049 RVA: 0x00A3BFFC File Offset: 0x00A3A1FC
		public static void CreateStaticDefaultValue()
		{
			WuWaGoRollbackPreStates._activeInstance = null;
		}

		// Token: 0x06024252 RID: 148050 RVA: 0x00A3C004 File Offset: 0x00A3A204
		public static void ResetStaticDefaultValue()
		{
			WuWaGoRollbackPreStates._activeInstance = null;
		}

		// Token: 0x06024253 RID: 148051 RVA: 0x00A3C00C File Offset: 0x00A3A20C
		[NullableContext(2)]
		public static void Activate(WuWaGoRollbackPreStates instance)
		{
			WuWaGoRollbackPreStates._activeInstance = instance;
		}

		// Token: 0x06024254 RID: 148052 RVA: 0x00A3C014 File Offset: 0x00A3A214
		public static void MarkDirty(WuWaGoBaseUnit unit)
		{
			WuWaGoRollbackPreStates activeInstance = WuWaGoRollbackPreStates._activeInstance;
			if (activeInstance == null)
			{
				return;
			}
			activeInstance.MarkDirtyInner(unit);
		}

		// Token: 0x06024255 RID: 148053 RVA: 0x00A3C026 File Offset: 0x00A3A226
		public static bool IsSuppressed()
		{
			WuWaGoRollbackPreStates activeInstance = WuWaGoRollbackPreStates._activeInstance;
			return activeInstance != null && activeInstance.Suppressed;
		}

		// Token: 0x06024256 RID: 148054 RVA: 0x00A3C038 File Offset: 0x00A3A238
		public void RegisterCommitHandler(Action<Dictionary<int, IRollbackCapture>> handler)
		{
			this.CommitHandler = handler;
		}

		// Token: 0x06024257 RID: 148055 RVA: 0x00A3C041 File Offset: 0x00A3A241
		public void Begin()
		{
			this.FlushPendingCommit();
			this.Captures.Clear();
			this.Active = true;
		}

		// Token: 0x06024258 RID: 148056 RVA: 0x00A3C05C File Offset: 0x00A3A25C
		public void FlushPendingCommit()
		{
			if (this.Captures.Count == 0)
			{
				return;
			}
			Action<Dictionary<int, IRollbackCapture>> commitHandler = this.CommitHandler;
			if (commitHandler == null)
			{
				return;
			}
			Dictionary<int, IRollbackCapture> obj = new Dictionary<int, IRollbackCapture>(this.Captures);
			this.Captures.Clear();
			commitHandler(obj);
		}

		// Token: 0x06024259 RID: 148057 RVA: 0x00A3C0A0 File Offset: 0x00A3A2A0
		public void ResetCaptures()
		{
			this.Captures.Clear();
		}

		// Token: 0x0602425A RID: 148058 RVA: 0x00A3C0AD File Offset: 0x00A3A2AD
		public void Discard()
		{
			this.Active = false;
			this.Captures.Clear();
		}

		// Token: 0x0602425B RID: 148059 RVA: 0x00A3C0C4 File Offset: 0x00A3A2C4
		public T WithSuppressed<[Nullable(2)] T>(Func<T> fn)
		{
			bool suppressed = this.Suppressed;
			this.Suppressed = true;
			T result;
			try
			{
				result = fn();
			}
			finally
			{
				this.Suppressed = suppressed;
			}
			return result;
		}

		// Token: 0x0602425C RID: 148060 RVA: 0x00A3C104 File Offset: 0x00A3A304
		public void SetSuppressed(bool suppressed)
		{
			this.Suppressed = suppressed;
		}

		// Token: 0x0602425D RID: 148061 RVA: 0x00A3C110 File Offset: 0x00A3A310
		private void MarkDirtyInner(WuWaGoBaseUnit unit)
		{
			if (!this.Active || this.Suppressed)
			{
				return;
			}
			if (this.Captures.ContainsKey(unit.Id))
			{
				return;
			}
			IRollbackCapture rollbackCapture = unit.CaptureRollback();
			if (rollbackCapture == null)
			{
				return;
			}
			this.Captures[unit.Id] = rollbackCapture;
		}

		// Token: 0x04014270 RID: 82544
		[Nullable(2)]
		private static WuWaGoRollbackPreStates _activeInstance;

		// Token: 0x04014271 RID: 82545
		private bool Active;

		// Token: 0x04014272 RID: 82546
		private bool Suppressed;

		// Token: 0x04014273 RID: 82547
		private readonly Dictionary<int, IRollbackCapture> Captures = new Dictionary<int, IRollbackCapture>();

		// Token: 0x04014274 RID: 82548
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Action<Dictionary<int, IRollbackCapture>> CommitHandler;
	}
}
