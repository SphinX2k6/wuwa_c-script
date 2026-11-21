using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace System
{
	// Token: 0x02000123 RID: 291
	internal sealed class Gen2GcCallback : CriticalFinalizerObject
	{
		// Token: 0x060011AF RID: 4527 RVA: 0x00030D2C File Offset: 0x0002EF2C
		private Gen2GcCallback(Func<bool> callback)
		{
			this._callback0 = callback;
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x00030D3B File Offset: 0x0002EF3B
		private Gen2GcCallback(Func<object, bool> callback, object targetObj)
		{
			this._callback1 = callback;
			this._weakTargetObj = GCHandle.Alloc(targetObj, GCHandleType.Weak);
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x00030D57 File Offset: 0x0002EF57
		public static void Register(Func<bool> callback)
		{
			new Gen2GcCallback(callback);
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x00030D60 File Offset: 0x0002EF60
		public static void Register(Func<object, bool> callback, object targetObj)
		{
			new Gen2GcCallback(callback, targetObj);
		}

		// Token: 0x060011B3 RID: 4531 RVA: 0x00030D6C File Offset: 0x0002EF6C
		protected override void Finalize()
		{
			try
			{
				if (this._weakTargetObj.IsAllocated)
				{
					object target = this._weakTargetObj.Target;
					if (target == null)
					{
						this._weakTargetObj.Free();
						return;
					}
					try
					{
						if (!this._callback1(target))
						{
							this._weakTargetObj.Free();
							return;
						}
						goto IL_5F;
					}
					catch
					{
						goto IL_5F;
					}
				}
				try
				{
					if (!this._callback0())
					{
						return;
					}
				}
				catch
				{
				}
				IL_5F:
				GC.ReRegisterForFinalize(this);
			}
			finally
			{
				base.Finalize();
			}
		}

		// Token: 0x040003C4 RID: 964
		private readonly Func<bool> _callback0;

		// Token: 0x040003C5 RID: 965
		private readonly Func<object, bool> _callback1;

		// Token: 0x040003C6 RID: 966
		private GCHandle _weakTargetObj;
	}
}
