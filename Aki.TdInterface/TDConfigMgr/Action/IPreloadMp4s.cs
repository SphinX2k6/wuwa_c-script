using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F5B RID: 8027
	public class IPreloadMp4s : IPreloadCharacterType
	{
		// Token: 0x0600AAC9 RID: 43721 RVA: 0x00183094 File Offset: 0x00181294
		private IPreloadMp4s_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPreloadMp4s 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPreloadMp4s_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPreloadMp4s_SetValue());
			}
			return result;
		}

		// Token: 0x0600AACA RID: 43722 RVA: 0x001830CC File Offset: 0x001812CC
		public static IPreloadMp4s Create([Nullable(2)] IPreloadMp4s instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPreloadMp4s
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AACB RID: 43723 RVA: 0x001830DF File Offset: 0x001812DF
		public static IPreloadMp4s CreateFromSetValue([Nullable(2)] IPreloadMp4s_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPreloadMp4s
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AACC RID: 43724 RVA: 0x001830F2 File Offset: 0x001812F2
		public new IPreloadMp4s_SetValue ToSetValue()
		{
			return new IPreloadMp4s_SetValue
			{
				Type = this.Type,
				Mp4s = this.Mp4s
			};
		}

		// Token: 0x1700346A RID: 13418
		// (get) Token: 0x0600AACD RID: 43725 RVA: 0x00183111 File Offset: 0x00181311
		// (set) Token: 0x0600AACE RID: 43726 RVA: 0x0018313C File Offset: 0x0018133C
		public override EPreloadObjectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPreloadObjectType.PreloadTrialCharacterForSkill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700346B RID: 13419
		// (get) Token: 0x0600AACF RID: 43727 RVA: 0x0018314A File Offset: 0x0018134A
		// (set) Token: 0x0600AAD0 RID: 43728 RVA: 0x00183171 File Offset: 0x00181371
		public virtual List<string> Mp4s
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Mp4s;
				}
				IPreloadMp4s_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Mp4s;
			}
			set
			{
				this.GetOrCreatePoco().Mp4s = value;
			}
		}

		// Token: 0x04006661 RID: 26209
		[Nullable(2)]
		protected new IPreloadMp4s FbInstance;

		// Token: 0x04006662 RID: 26210
		[Nullable(2)]
		protected new IPreloadMp4s_SetValue PocoInterface;
	}
}
