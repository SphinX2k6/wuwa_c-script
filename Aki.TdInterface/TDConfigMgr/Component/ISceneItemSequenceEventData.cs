using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200074B RID: 1867
	public class ISceneItemSequenceEventData
	{
		// Token: 0x060027AE RID: 10158 RVA: 0x0006A03C File Offset: 0x0006823C
		private ISceneItemSequenceEventData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISceneItemSequenceEventData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISceneItemSequenceEventData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISceneItemSequenceEventData_SetValue());
			}
			return result;
		}

		// Token: 0x060027AF RID: 10159 RVA: 0x0006A074 File Offset: 0x00068274
		public static ISceneItemSequenceEventData Create([Nullable(2)] ISceneItemSequenceEventData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneItemSequenceEventData
			{
				FbInstance = instance
			};
		}

		// Token: 0x060027B0 RID: 10160 RVA: 0x0006A087 File Offset: 0x00068287
		public static ISceneItemSequenceEventData CreateFromSetValue([Nullable(2)] ISceneItemSequenceEventData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISceneItemSequenceEventData
			{
				PocoInterface = value
			};
		}

		// Token: 0x060027B1 RID: 10161 RVA: 0x0006A09A File Offset: 0x0006829A
		public ISceneItemSequenceEventData_SetValue ToSetValue()
		{
			return new ISceneItemSequenceEventData_SetValue
			{
				SeqGuid = this.SeqGuid,
				SeqPath = this.SeqPath,
				EventCallbacks = this.EventCallbacks
			};
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x060027B2 RID: 10162 RVA: 0x0006A0C5 File Offset: 0x000682C5
		// (set) Token: 0x060027B3 RID: 10163 RVA: 0x0006A0F0 File Offset: 0x000682F0
		public virtual string SeqGuid
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SeqGuid;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.SeqGuid;
			}
			set
			{
				this.GetOrCreatePoco().SeqGuid = value;
			}
		}

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x060027B4 RID: 10164 RVA: 0x0006A0FE File Offset: 0x000682FE
		// (set) Token: 0x060027B5 RID: 10165 RVA: 0x0006A129 File Offset: 0x00068329
		public virtual string SeqPath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SeqPath;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.SeqPath;
			}
			set
			{
				this.GetOrCreatePoco().SeqPath = value;
			}
		}

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x060027B6 RID: 10166 RVA: 0x0006A137 File Offset: 0x00068337
		// (set) Token: 0x060027B7 RID: 10167 RVA: 0x0006A15E File Offset: 0x0006835E
		public virtual List<ISceneItemSeqEventCbType> EventCallbacks
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EventCallbacks;
				}
				ISceneItemSequenceEventData_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EventCallbacks;
			}
			set
			{
				this.GetOrCreatePoco().EventCallbacks = value;
			}
		}

		// Token: 0x04001B16 RID: 6934
		[Nullable(2)]
		protected ISceneItemSequenceEventData FbInstance;

		// Token: 0x04001B17 RID: 6935
		[Nullable(2)]
		protected ISceneItemSequenceEventData_SetValue PocoInterface;
	}
}
