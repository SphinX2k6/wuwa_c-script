using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200112D RID: 4397
	public class ILogicProgramSpecialProcess
	{
		// Token: 0x0600615C RID: 24924 RVA: 0x000EADC0 File Offset: 0x000E8FC0
		private ILogicProgramSpecialProcess_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILogicProgramSpecialProcess 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILogicProgramSpecialProcess_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILogicProgramSpecialProcess_SetValue());
			}
			return result;
		}

		// Token: 0x0600615D RID: 24925 RVA: 0x000EADF8 File Offset: 0x000E8FF8
		public static ILogicProgramSpecialProcess Create([Nullable(2)] ILogicProgramSpecialProcess instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILogicProgramSpecialProcess
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600615E RID: 24926 RVA: 0x000EAE0B File Offset: 0x000E900B
		public static ILogicProgramSpecialProcess CreateFromSetValue([Nullable(2)] ILogicProgramSpecialProcess_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILogicProgramSpecialProcess
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600615F RID: 24927 RVA: 0x000EAE1E File Offset: 0x000E901E
		public ILogicProgramSpecialProcess_SetValue ToSetValue()
		{
			return new ILogicProgramSpecialProcess_SetValue
			{
				SpecialProcessList = this.SpecialProcessList
			};
		}

		// Token: 0x17001FE7 RID: 8167
		// (get) Token: 0x06006160 RID: 24928 RVA: 0x000EAE34 File Offset: 0x000E9034
		// (set) Token: 0x06006161 RID: 24929 RVA: 0x000EAEC7 File Offset: 0x000E90C7
		public virtual List<IDisableUro> SpecialProcessList
		{
			get
			{
				if (this._SpecialProcessListInited)
				{
					return this._SpecialProcessListCache;
				}
				this._SpecialProcessListInited = true;
				if (this.FbInstance != null)
				{
					List<IDisableUro> specialProcessList = this.FbInstance.SpecialProcessList;
					if (specialProcessList != null)
					{
						this._SpecialProcessListCache = new List<IDisableUro>(specialProcessList.Count);
						for (int i = 0; i < specialProcessList.Count; i++)
						{
							this._SpecialProcessListCache.Add(IDisableUro.Create(specialProcessList[i]));
						}
					}
				}
				else
				{
					ILogicProgramSpecialProcess_SetValue pocoInterface = this.PocoInterface;
					this._SpecialProcessListCache = ((pocoInterface != null) ? pocoInterface.SpecialProcessList : null);
				}
				return this._SpecialProcessListCache;
			}
			set
			{
				this.GetOrCreatePoco().SpecialProcessList = value;
				this._SpecialProcessListInited = false;
			}
		}

		// Token: 0x04003A59 RID: 14937
		[Nullable(2)]
		protected ILogicProgramSpecialProcess FbInstance;

		// Token: 0x04003A5A RID: 14938
		[Nullable(2)]
		protected ILogicProgramSpecialProcess_SetValue PocoInterface;

		// Token: 0x04003A5B RID: 14939
		private List<IDisableUro> _SpecialProcessListCache;

		// Token: 0x04003A5C RID: 14940
		private bool _SpecialProcessListInited;
	}
}
