using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C60 RID: 7264
	public class IFrequencyDetect : IUiGame
	{
		// Token: 0x06009A7C RID: 39548 RVA: 0x00165800 File Offset: 0x00163A00
		private IFrequencyDetect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFrequencyDetect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFrequencyDetect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFrequencyDetect_SetValue());
			}
			return result;
		}

		// Token: 0x06009A7D RID: 39549 RVA: 0x00165838 File Offset: 0x00163A38
		public static IFrequencyDetect Create([Nullable(2)] IFrequencyDetect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFrequencyDetect
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009A7E RID: 39550 RVA: 0x0016584B File Offset: 0x00163A4B
		public static IFrequencyDetect CreateFromSetValue([Nullable(2)] IFrequencyDetect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFrequencyDetect
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009A7F RID: 39551 RVA: 0x0016585E File Offset: 0x00163A5E
		public new IFrequencyDetect_SetValue ToSetValue()
		{
			return new IFrequencyDetect_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x170030BB RID: 12475
		// (get) Token: 0x06009A80 RID: 39552 RVA: 0x0016587D File Offset: 0x00163A7D
		// (set) Token: 0x06009A81 RID: 39553 RVA: 0x001658A8 File Offset: 0x00163AA8
		public override ESimpleGameplayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESimpleGameplayType.Cipher;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170030BC RID: 12476
		// (get) Token: 0x06009A82 RID: 39554 RVA: 0x001658B6 File Offset: 0x00163AB6
		// (set) Token: 0x06009A83 RID: 39555 RVA: 0x001658E1 File Offset: 0x00163AE1
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x04005ED8 RID: 24280
		[Nullable(2)]
		protected new IFrequencyDetect FbInstance;

		// Token: 0x04005ED9 RID: 24281
		[Nullable(2)]
		protected new IFrequencyDetect_SetValue PocoInterface;
	}
}
