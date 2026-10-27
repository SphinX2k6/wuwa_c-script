using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014AB RID: 5291
	[NullableContext(1)]
	[Nullable(0)]
	public class BeginFlowTemplate : ActionParams
	{
		// Token: 0x06007878 RID: 30840 RVA: 0x00120D3C File Offset: 0x0011EF3C
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

		// Token: 0x06007879 RID: 30841 RVA: 0x00120D74 File Offset: 0x0011EF74
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

		// Token: 0x0600787A RID: 30842 RVA: 0x00120D87 File Offset: 0x0011EF87
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

		// Token: 0x0600787B RID: 30843 RVA: 0x00120D9C File Offset: 0x0011EF9C
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

		// Token: 0x17002871 RID: 10353
		// (get) Token: 0x0600787C RID: 30844 RVA: 0x00120DF8 File Offset: 0x0011EFF8
		// (set) Token: 0x0600787D RID: 30845 RVA: 0x00120E32 File Offset: 0x0011F032
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

		// Token: 0x17002872 RID: 10354
		// (get) Token: 0x0600787E RID: 30846 RVA: 0x00120E40 File Offset: 0x0011F040
		// (set) Token: 0x0600787F RID: 30847 RVA: 0x00120ED3 File Offset: 0x0011F0D3
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

		// Token: 0x17002873 RID: 10355
		// (get) Token: 0x06007880 RID: 30848 RVA: 0x00120EE8 File Offset: 0x0011F0E8
		// (set) Token: 0x06007881 RID: 30849 RVA: 0x00120F0F File Offset: 0x0011F10F
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

		// Token: 0x17002874 RID: 10356
		// (get) Token: 0x06007882 RID: 30850 RVA: 0x00120F20 File Offset: 0x0011F120
		// (set) Token: 0x06007883 RID: 30851 RVA: 0x00120F5A File Offset: 0x0011F15A
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

		// Token: 0x17002875 RID: 10357
		// (get) Token: 0x06007884 RID: 30852 RVA: 0x00120F68 File Offset: 0x0011F168
		// (set) Token: 0x06007885 RID: 30853 RVA: 0x00120FA2 File Offset: 0x0011F1A2
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

		// Token: 0x17002876 RID: 10358
		// (get) Token: 0x06007886 RID: 30854 RVA: 0x00120FB0 File Offset: 0x0011F1B0
		// (set) Token: 0x06007887 RID: 30855 RVA: 0x00120FEA File Offset: 0x0011F1EA
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

		// Token: 0x04004603 RID: 17923
		[Nullable(2)]
		protected new BeginFlowTemplate FbInstance;

		// Token: 0x04004604 RID: 17924
		[Nullable(2)]
		protected BeginFlowTemplate_SetValue PocoInterface;

		// Token: 0x04004605 RID: 17925
		private List<IFlowActorUnit> _ActorsCache;

		// Token: 0x04004606 RID: 17926
		private bool _ActorsInited;
	}
}
