using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DFD RID: 7677
	public class IMorseCode : IUiGame
	{
		// Token: 0x0600A327 RID: 41767 RVA: 0x00175330 File Offset: 0x00173530
		private IMorseCode_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMorseCode 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMorseCode_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMorseCode_SetValue());
			}
			return result;
		}

		// Token: 0x0600A328 RID: 41768 RVA: 0x00175368 File Offset: 0x00173568
		public static IMorseCode Create([Nullable(2)] IMorseCode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMorseCode
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A329 RID: 41769 RVA: 0x0017537B File Offset: 0x0017357B
		public static IMorseCode CreateFromSetValue([Nullable(2)] IMorseCode_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMorseCode
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A32A RID: 41770 RVA: 0x0017538E File Offset: 0x0017358E
		public new IMorseCode_SetValue ToSetValue()
		{
			return new IMorseCode_SetValue
			{
				Type = this.Type,
				MorseCodeId = this.MorseCodeId
			};
		}

		// Token: 0x170032A6 RID: 12966
		// (get) Token: 0x0600A32B RID: 41771 RVA: 0x001753AD File Offset: 0x001735AD
		// (set) Token: 0x0600A32C RID: 41772 RVA: 0x001753D8 File Offset: 0x001735D8
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

		// Token: 0x170032A7 RID: 12967
		// (get) Token: 0x0600A32D RID: 41773 RVA: 0x001753E6 File Offset: 0x001735E6
		// (set) Token: 0x0600A32E RID: 41774 RVA: 0x00175411 File Offset: 0x00173611
		public virtual string MorseCodeId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MorseCodeId;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.MorseCodeId;
			}
			set
			{
				this.GetOrCreatePoco().MorseCodeId = value;
			}
		}

		// Token: 0x040062D9 RID: 25305
		[Nullable(2)]
		protected new IMorseCode FbInstance;

		// Token: 0x040062DA RID: 25306
		[Nullable(2)]
		protected new IMorseCode_SetValue PocoInterface;
	}
}
