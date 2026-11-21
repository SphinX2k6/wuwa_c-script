using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001604 RID: 5636
	public class BeginFlowTemplate : ActionParams
	{
		// Token: 0x06007F45 RID: 32581 RVA: 0x0012F988 File Offset: 0x0012DB88
		private BeginFlowTemplate_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("BeginFlowTemplate 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			BeginFlowTemplate_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new BeginFlowTemplate_SetValue());
			}
			return result;
		}

		// Token: 0x06007F46 RID: 32582 RVA: 0x0012F9C0 File Offset: 0x0012DBC0
		public static BeginFlowTemplate Create([Nullable(2)] BeginFlowTemplate instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new BeginFlowTemplate
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007F47 RID: 32583 RVA: 0x0012F9D3 File Offset: 0x0012DBD3
		public static BeginFlowTemplate CreateFromSetValue([Nullable(2)] BeginFlowTemplate_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new BeginFlowTemplate
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007F48 RID: 32584 RVA: 0x0012F9E8 File Offset: 0x0012DBE8
		public BeginFlowTemplate_SetValue ToSetValue()
		{
			return new BeginFlowTemplate_SetValue
			{
				_Folded = this._Folded,
				Actors = this.Actors,
				MontageIds = this.MontageIds,
				UseFreeCamera = this.UseFreeCamera,
				IsSwitchMainRole = this.IsSwitchMainRole,
				IsUseSeqFace = this.IsUseSeqFace
			};
		}

		// Token: 0x17002A5B RID: 10843
		// (get) Token: 0x06007F49 RID: 32585 RVA: 0x0012FA44 File Offset: 0x0012DC44
		// (set) Token: 0x06007F4A RID: 32586 RVA: 0x0012FA7E File Offset: 0x0012DC7E
		public virtual bool? _Folded
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance._Folded;
				}
				BeginFlowTemplate_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface._Folded;
			}
			set
			{
				this.GetOrCreatePoco()._Folded = value;
			}
		}

		// Token: 0x17002A5C RID: 10844
		// (get) Token: 0x06007F4B RID: 32587 RVA: 0x0012FA8C File Offset: 0x0012DC8C
		// (set) Token: 0x06007F4C RID: 32588 RVA: 0x0012FB1F File Offset: 0x0012DD1F
		public virtual List<IFlowActorUnit> Actors
		{
			get
			{
				if (this._ActorsInited)
				{
					return this._ActorsCache;
				}
				this._ActorsInited = true;
				if (this.FbInstance != null)
				{
					List<IFlowActorUnit> actors = this.FbInstance.Actors;
					if (actors != null)
					{
						this._ActorsCache = new List<IFlowActorUnit>(actors.Count);
						for (int i = 0; i < actors.Count; i++)
						{
							this._ActorsCache.Add(IFlowActorUnit.Create(actors[i]));
						}
					}
				}
				else
				{
					BeginFlowTemplate_SetValue pocoInterface = this.PocoInterface;
					this._ActorsCache = ((pocoInterface != null) ? pocoInterface.Actors : null);
				}
				return this._ActorsCache;
			}
			set
			{
				this.GetOrCreatePoco().Actors = value;
				this._ActorsInited = false;
			}
		}

		// Token: 0x17002A5D RID: 10845
		// (get) Token: 0x06007F4D RID: 32589 RVA: 0x0012FB34 File Offset: 0x0012DD34
		// (set) Token: 0x06007F4E RID: 32590 RVA: 0x0012FB5B File Offset: 0x0012DD5B
		[Nullable(2)]
		public virtual List<int> MontageIds
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MontageIds;
				}
				BeginFlowTemplate_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MontageIds;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().MontageIds = value;
			}
		}

		// Token: 0x17002A5E RID: 10846
		// (get) Token: 0x06007F4F RID: 32591 RVA: 0x0012FB6C File Offset: 0x0012DD6C
		// (set) Token: 0x06007F50 RID: 32592 RVA: 0x0012FBA6 File Offset: 0x0012DDA6
		public virtual bool? UseFreeCamera
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UseFreeCamera;
				}
				BeginFlowTemplate_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.UseFreeCamera;
			}
			set
			{
				this.GetOrCreatePoco().UseFreeCamera = value;
			}
		}

		// Token: 0x17002A5F RID: 10847
		// (get) Token: 0x06007F51 RID: 32593 RVA: 0x0012FBB4 File Offset: 0x0012DDB4
		// (set) Token: 0x06007F52 RID: 32594 RVA: 0x0012FBEE File Offset: 0x0012DDEE
		public virtual bool? IsSwitchMainRole
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsSwitchMainRole;
				}
				BeginFlowTemplate_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsSwitchMainRole;
			}
			set
			{
				this.GetOrCreatePoco().IsSwitchMainRole = value;
			}
		}

		// Token: 0x17002A60 RID: 10848
		// (get) Token: 0x06007F53 RID: 32595 RVA: 0x0012FBFC File Offset: 0x0012DDFC
		// (set) Token: 0x06007F54 RID: 32596 RVA: 0x0012FC36 File Offset: 0x0012DE36
		public virtual bool? IsUseSeqFace
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsUseSeqFace;
				}
				BeginFlowTemplate_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsUseSeqFace;
			}
			set
			{
				this.GetOrCreatePoco().IsUseSeqFace = value;
			}
		}

		// Token: 0x0400499E RID: 18846
		[Nullable(2)]
		protected new BeginFlowTemplate FbInstance;

		// Token: 0x0400499F RID: 18847
		[Nullable(2)]
		protected BeginFlowTemplate_SetValue PocoInterface;

		// Token: 0x040049A0 RID: 18848
		private List<IFlowActorUnit> _ActorsCache;

		// Token: 0x040049A1 RID: 18849
		private bool _ActorsInited;
	}
}
