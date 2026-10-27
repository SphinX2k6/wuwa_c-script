using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001001 RID: 4097
	[NullableContext(1)]
	[Nullable(0)]
	public class ILogicProgramSpecialProcess
	{
		// Token: 0x06005B7C RID: 23420 RVA: 0x000DE180 File Offset: 0x000DC380
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

		// Token: 0x06005B7D RID: 23421 RVA: 0x000DE1B8 File Offset: 0x000DC3B8
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

		// Token: 0x06005B7E RID: 23422 RVA: 0x000DE1CB File Offset: 0x000DC3CB
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

		// Token: 0x06005B7F RID: 23423 RVA: 0x000DE1DE File Offset: 0x000DC3DE
		public ILogicProgramSpecialProcess_SetValue ToSetValue()
		{
			return new ILogicProgramSpecialProcess_SetValue
			{
				SpecialProcessList = this.SpecialProcessList
			};
		}

		// Token: 0x17001E3E RID: 7742
		// (get) Token: 0x06005B80 RID: 23424 RVA: 0x000DE1F4 File Offset: 0x000DC3F4
		// (set) Token: 0x06005B81 RID: 23425 RVA: 0x000DE287 File Offset: 0x000DC487
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

		// Token: 0x04003721 RID: 14113
		[Nullable(2)]
		protected ILogicProgramSpecialProcess FbInstance;

		// Token: 0x04003722 RID: 14114
		[Nullable(2)]
		protected ILogicProgramSpecialProcess_SetValue PocoInterface;

		// Token: 0x04003723 RID: 14115
		private List<IDisableUro> _SpecialProcessListCache;

		// Token: 0x04003724 RID: 14116
		private bool _SpecialProcessListInited;
	}
}
