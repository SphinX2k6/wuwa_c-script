using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FB6 RID: 32694
	public class TSetAreaTimeTypeUnion
	{
		// Token: 0x1700F2F1 RID: 62193
		// (get) Token: 0x0603AE2B RID: 241195 RVA: 0x007E968A File Offset: 0x007E788A
		// (set) Token: 0x0603AE2C RID: 241196 RVA: 0x007E9692 File Offset: 0x007E7892
		public TSetAreaTimeType Type { get; set; }

		// Token: 0x1700F2F2 RID: 62194
		// (get) Token: 0x0603AE2D RID: 241197 RVA: 0x007E969B File Offset: 0x007E789B
		// (set) Token: 0x0603AE2E RID: 241198 RVA: 0x007E96A3 File Offset: 0x007E78A3
		public object Value { get; set; }

		// Token: 0x0603AE2F RID: 241199 RVA: 0x007E96AC File Offset: 0x007E78AC
		public TSetAreaTimeTypeUnion()
		{
			this.Type = TSetAreaTimeType.NONE;
			this.Value = null;
		}

		// Token: 0x0603AE30 RID: 241200 RVA: 0x007E96C2 File Offset: 0x007E78C2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AE31 RID: 241201 RVA: 0x007E96D4 File Offset: 0x007E78D4
		public ISetAreaTimeLockT AsISetAreaTimeLock()
		{
			return this.As<ISetAreaTimeLockT>();
		}

		// Token: 0x0603AE32 RID: 241202 RVA: 0x007E96DC File Offset: 0x007E78DC
		public static TSetAreaTimeTypeUnion FromISetAreaTimeLock(ISetAreaTimeLockT _isetareatimelock)
		{
			return new TSetAreaTimeTypeUnion
			{
				Type = TSetAreaTimeType.ISetAreaTimeLock,
				Value = _isetareatimelock
			};
		}

		// Token: 0x0603AE33 RID: 241203 RVA: 0x007E96F1 File Offset: 0x007E78F1
		public ISetAreaTimeUnLockT AsISetAreaTimeUnLock()
		{
			return this.As<ISetAreaTimeUnLockT>();
		}

		// Token: 0x0603AE34 RID: 241204 RVA: 0x007E96F9 File Offset: 0x007E78F9
		public static TSetAreaTimeTypeUnion FromISetAreaTimeUnLock(ISetAreaTimeUnLockT _isetareatimeunlock)
		{
			return new TSetAreaTimeTypeUnion
			{
				Type = TSetAreaTimeType.ISetAreaTimeUnLock,
				Value = _isetareatimeunlock
			};
		}

		// Token: 0x0603AE35 RID: 241205 RVA: 0x007E9710 File Offset: 0x007E7910
		public static int Pack(FlatBufferBuilder builder, TSetAreaTimeTypeUnion _o)
		{
			TSetAreaTimeType type = _o.Type;
			if (type == TSetAreaTimeType.ISetAreaTimeLock)
			{
				return ISetAreaTimeLock.Pack(builder, _o.AsISetAreaTimeLock()).Value;
			}
			if (type != TSetAreaTimeType.ISetAreaTimeUnLock)
			{
				return 0;
			}
			return ISetAreaTimeUnLock.Pack(builder, _o.AsISetAreaTimeUnLock()).Value;
		}
	}
}
