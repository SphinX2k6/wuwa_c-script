using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D46 RID: 7494
	[NullableContext(1)]
	[Nullable(0)]
	public class IPreloadFlows : IPreloadCharacterType
	{
		// Token: 0x0600A0C9 RID: 41161 RVA: 0x0016EA30 File Offset: 0x0016CC30
		private IPreloadFlows_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPreloadFlows 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPreloadFlows_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPreloadFlows_SetValue());
			}
			return result;
		}

		// Token: 0x0600A0CA RID: 41162 RVA: 0x0016EA68 File Offset: 0x0016CC68
		public static IPreloadFlows Create([Nullable(2)] IPreloadFlows instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPreloadFlows
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A0CB RID: 41163 RVA: 0x0016EA7B File Offset: 0x0016CC7B
		public static IPreloadFlows CreateFromSetValue([Nullable(2)] IPreloadFlows_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPreloadFlows
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A0CC RID: 41164 RVA: 0x0016EA8E File Offset: 0x0016CC8E
		public new IPreloadFlows_SetValue ToSetValue()
		{
			return new IPreloadFlows_SetValue
			{
				Type = this.Type,
				FlowData = this.FlowData
			};
		}

		// Token: 0x170031D2 RID: 12754
		// (get) Token: 0x0600A0CD RID: 41165 RVA: 0x0016EAAD File Offset: 0x0016CCAD
		// (set) Token: 0x0600A0CE RID: 41166 RVA: 0x0016EAD8 File Offset: 0x0016CCD8
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

		// Token: 0x170031D3 RID: 12755
		// (get) Token: 0x0600A0CF RID: 41167 RVA: 0x0016EAE8 File Offset: 0x0016CCE8
		// (set) Token: 0x0600A0D0 RID: 41168 RVA: 0x0016EB49 File Offset: 0x0016CD49
		public virtual PlayFlow FlowData
		{
			get
			{
				if (this._FlowDataInited)
				{
					return this._FlowDataCache;
				}
				this._FlowDataInited = true;
				if (this.FbInstance != null)
				{
					this._FlowDataCache = PlayFlow.Create(this.FbInstance.FlowData);
				}
				else
				{
					IPreloadFlows_SetValue pocoInterface = this.PocoInterface;
					this._FlowDataCache = ((pocoInterface != null) ? pocoInterface.FlowData : null);
				}
				return this._FlowDataCache;
			}
			set
			{
				this.GetOrCreatePoco().FlowData = value;
				this._FlowDataInited = false;
			}
		}

		// Token: 0x040060DB RID: 24795
		[Nullable(2)]
		protected new IPreloadFlows FbInstance;

		// Token: 0x040060DC RID: 24796
		[Nullable(2)]
		protected new IPreloadFlows_SetValue PocoInterface;

		// Token: 0x040060DD RID: 24797
		private PlayFlow _FlowDataCache;

		// Token: 0x040060DE RID: 24798
		private bool _FlowDataInited;
	}
}
