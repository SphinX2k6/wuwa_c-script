using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Model
{
	// Token: 0x0200473A RID: 18234
	[NullableContext(1)]
	[Nullable(0)]
	public class WuWaGoRollbackPreStates : IStaticVariableResetter
	{
		// Token: 0x0602FA86 RID: 195206 RVA: 0x00B0C011 File Offset: 0x00B0A211
		static WuWaGoRollbackPreStates()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(WuWaGoRollbackPreStates.CreateStaticDefaultValue), new Action(WuWaGoRollbackPreStates.ResetStaticDefaultValue));
		}

		// Token: 0x0602FA87 RID: 195207 RVA: 0x00B0C030 File Offset: 0x00B0A230
		public static void CreateStaticDefaultValue()
		{
			WuWaGoRollbackPreStates._activeInstance = null;
		}

		// Token: 0x0602FA88 RID: 195208 RVA: 0x00B0C038 File Offset: 0x00B0A238
		public static void ResetStaticDefaultValue()
		{
			WuWaGoRollbackPreStates._activeInstance = null;
		}

		// Token: 0x0602FA89 RID: 195209 RVA: 0x00B0C040 File Offset: 0x00B0A240
		[NullableContext(2)]
		public static void Activate(WuWaGoRollbackPreStates instance)
		{
			WuWaGoRollbackPreStates._activeInstance = instance;
		}

		// Token: 0x0602FA8A RID: 195210 RVA: 0x00B0C048 File Offset: 0x00B0A248
		public static void MarkDirty(WuWaGoBaseUnit unit)
		{
			WuWaGoRollbackPreStates activeInstance = WuWaGoRollbackPreStates._activeInstance;
			if (activeInstance == null)
			{
				return;
			}
			activeInstance.MarkDirtyInner(unit);
		}

		// Token: 0x0602FA8B RID: 195211 RVA: 0x00B0C05A File Offset: 0x00B0A25A
		public static bool IsSuppressed()
		{
			WuWaGoRollbackPreStates activeInstance = WuWaGoRollbackPreStates._activeInstance;
			return activeInstance != null && activeInstance.Suppressed;
		}

		// Token: 0x0602FA8C RID: 195212 RVA: 0x00B0C06C File Offset: 0x00B0A26C
		public void RegisterCommitHandler(Action<Dictionary<int, IRollbackCapture>> handler)
		{
			this.CommitHandler = handler;
		}

		// Token: 0x0602FA8D RID: 195213 RVA: 0x00B0C075 File Offset: 0x00B0A275
		public void Begin()
		{
			this.FlushPendingCommit();
			this.Captures.Clear();
			this.Active = true;
		}

		// Token: 0x0602FA8E RID: 195214 RVA: 0x00B0C090 File Offset: 0x00B0A290
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

		// Token: 0x0602FA8F RID: 195215 RVA: 0x00B0C0D4 File Offset: 0x00B0A2D4
		public void ResetCaptures()
		{
			this.Captures.Clear();
		}

		// Token: 0x0602FA90 RID: 195216 RVA: 0x00B0C0E1 File Offset: 0x00B0A2E1
		public void Discard()
		{
			this.Active = false;
			this.Captures.Clear();
		}

		// Token: 0x0602FA91 RID: 195217 RVA: 0x00B0C0F8 File Offset: 0x00B0A2F8
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

		// Token: 0x0602FA92 RID: 195218 RVA: 0x00B0C138 File Offset: 0x00B0A338
		public void SetSuppressed(bool suppressed)
		{
			this.Suppressed = suppressed;
		}

		// Token: 0x0602FA93 RID: 195219 RVA: 0x00B0C144 File Offset: 0x00B0A344
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

		// Token: 0x04019BC0 RID: 105408
		[Nullable(2)]
		private static WuWaGoRollbackPreStates _activeInstance;

		// Token: 0x04019BC1 RID: 105409
		private bool Active;

		// Token: 0x04019BC2 RID: 105410
		private bool Suppressed;

		// Token: 0x04019BC3 RID: 105411
		private readonly Dictionary<int, IRollbackCapture> Captures = new Dictionary<int, IRollbackCapture>();

		// Token: 0x04019BC4 RID: 105412
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Action<Dictionary<int, IRollbackCapture>> CommitHandler;
	}
}
