using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.EditorObject;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A93 RID: 6803
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlowInfo : IEditorObject
	{
		// Token: 0x060091B4 RID: 37300 RVA: 0x00152FB8 File Offset: 0x001511B8
		private IFlowInfo_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFlowInfo 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFlowInfo_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFlowInfo_SetValue());
			}
			return result;
		}

		// Token: 0x060091B5 RID: 37301 RVA: 0x00152FF0 File Offset: 0x001511F0
		public static IFlowInfo Create([Nullable(2)] IFlowInfo instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowInfo
			{
				FbInstance = instance
			};
		}

		// Token: 0x060091B6 RID: 37302 RVA: 0x00153003 File Offset: 0x00151203
		public static IFlowInfo CreateFromSetValue([Nullable(2)] IFlowInfo_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFlowInfo
			{
				PocoInterface = value
			};
		}

		// Token: 0x060091B7 RID: 37303 RVA: 0x00153018 File Offset: 0x00151218
		public new IFlowInfo_SetValue ToSetValue()
		{
			return new IFlowInfo_SetValue
			{
				ObjType = this.ObjType,
				Children = this.Children,
				Reference = this.Reference,
				WeakReference = this.WeakReference,
				EdPlannedBranch = this.EdPlannedBranch,
				EdTextRef = this.EdTextRef,
				_children = this._children,
				_reference = this._reference,
				Id = this.Id,
				Name = this.Name,
				DungeonId = this.DungeonId,
				_folded = this._Folded,
				_selectedStateId = this._SelectedStateId,
				VarContext = this.VarContext,
				States = this.States,
				EdIsReserved = this.EdIsReserved
			};
		}

		// Token: 0x17002E53 RID: 11859
		// (get) Token: 0x060091B8 RID: 37304 RVA: 0x001530EA File Offset: 0x001512EA
		// (set) Token: 0x060091B9 RID: 37305 RVA: 0x00153115 File Offset: 0x00151315
		public new virtual string ObjType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ObjType;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.ObjType;
			}
			set
			{
				this.GetOrCreatePoco().ObjType = value;
			}
		}

		// Token: 0x17002E54 RID: 11860
		// (get) Token: 0x060091BA RID: 37306 RVA: 0x00153123 File Offset: 0x00151323
		// (set) Token: 0x060091BB RID: 37307 RVA: 0x0015314A File Offset: 0x0015134A
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<string> Children
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Children;
				}
				IFlowInfo_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Children;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().Children = value;
			}
		}

		// Token: 0x17002E55 RID: 11861
		// (get) Token: 0x060091BC RID: 37308 RVA: 0x00153158 File Offset: 0x00151358
		// (set) Token: 0x060091BD RID: 37309 RVA: 0x0015317F File Offset: 0x0015137F
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<string> Reference
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Reference;
				}
				IFlowInfo_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Reference;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().Reference = value;
			}
		}

		// Token: 0x17002E56 RID: 11862
		// (get) Token: 0x060091BE RID: 37310 RVA: 0x0015318D File Offset: 0x0015138D
		// (set) Token: 0x060091BF RID: 37311 RVA: 0x001531B4 File Offset: 0x001513B4
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<string> WeakReference
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.WeakReference;
				}
				IFlowInfo_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.WeakReference;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().WeakReference = value;
			}
		}

		// Token: 0x17002E57 RID: 11863
		// (get) Token: 0x060091C0 RID: 37312 RVA: 0x001531C2 File Offset: 0x001513C2
		// (set) Token: 0x060091C1 RID: 37313 RVA: 0x001531D9 File Offset: 0x001513D9
		[Nullable(2)]
		public override string EdPlannedBranch
		{
			[NullableContext(2)]
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdPlannedBranch;
				}
				return null;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EdPlannedBranch = value;
			}
		}

		// Token: 0x17002E58 RID: 11864
		// (get) Token: 0x060091C2 RID: 37314 RVA: 0x001531E7 File Offset: 0x001513E7
		// (set) Token: 0x060091C3 RID: 37315 RVA: 0x001531FE File Offset: 0x001513FE
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<string> EdTextRef
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTextRef;
				}
				return null;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().EdTextRef = value;
			}
		}

		// Token: 0x17002E59 RID: 11865
		// (get) Token: 0x060091C4 RID: 37316 RVA: 0x0015320C File Offset: 0x0015140C
		// (set) Token: 0x060091C5 RID: 37317 RVA: 0x00153223 File Offset: 0x00151423
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<string> _children
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface._children;
				}
				return null;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco()._children = value;
			}
		}

		// Token: 0x17002E5A RID: 11866
		// (get) Token: 0x060091C6 RID: 37318 RVA: 0x00153231 File Offset: 0x00151431
		// (set) Token: 0x060091C7 RID: 37319 RVA: 0x00153248 File Offset: 0x00151448
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<string> _reference
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface._reference;
				}
				return null;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco()._reference = value;
			}
		}

		// Token: 0x17002E5B RID: 11867
		// (get) Token: 0x060091C8 RID: 37320 RVA: 0x00153256 File Offset: 0x00151456
		// (set) Token: 0x060091C9 RID: 37321 RVA: 0x00153281 File Offset: 0x00151481
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

		// Token: 0x17002E5C RID: 11868
		// (get) Token: 0x060091CA RID: 37322 RVA: 0x0015328F File Offset: 0x0015148F
		// (set) Token: 0x060091CB RID: 37323 RVA: 0x001532BA File Offset: 0x001514BA
		public virtual string Name
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Name;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Name;
			}
			set
			{
				this.GetOrCreatePoco().Name = value;
			}
		}

		// Token: 0x17002E5D RID: 11869
		// (get) Token: 0x060091CC RID: 37324 RVA: 0x001532C8 File Offset: 0x001514C8
		// (set) Token: 0x060091CD RID: 37325 RVA: 0x00153302 File Offset: 0x00151502
		public virtual int? DungeonId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DungeonId;
				}
				IFlowInfo_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DungeonId;
			}
			set
			{
				this.GetOrCreatePoco().DungeonId = value;
			}
		}

		// Token: 0x17002E5E RID: 11870
		// (get) Token: 0x060091CE RID: 37326 RVA: 0x00153310 File Offset: 0x00151510
		// (set) Token: 0x060091CF RID: 37327 RVA: 0x0015334A File Offset: 0x0015154A
		public virtual bool? _Folded
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance._Folded;
				}
				IFlowInfo_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface._folded;
			}
			set
			{
				this.GetOrCreatePoco()._folded = value;
			}
		}

		// Token: 0x17002E5F RID: 11871
		// (get) Token: 0x060091D0 RID: 37328 RVA: 0x00153358 File Offset: 0x00151558
		// (set) Token: 0x060091D1 RID: 37329 RVA: 0x00153392 File Offset: 0x00151592
		public virtual int? _SelectedStateId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance._SelectedStateId;
				}
				IFlowInfo_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface._selectedStateId;
			}
			set
			{
				this.GetOrCreatePoco()._selectedStateId = value;
			}
		}

		// Token: 0x17002E60 RID: 11872
		// (get) Token: 0x060091D2 RID: 37330 RVA: 0x001533A0 File Offset: 0x001515A0
		// (set) Token: 0x060091D3 RID: 37331 RVA: 0x001533C7 File Offset: 0x001515C7
		[Nullable(2)]
		public virtual IVarContext VarContext
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.VarContext;
				}
				IFlowInfo_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.VarContext;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().VarContext = value;
			}
		}

		// Token: 0x17002E61 RID: 11873
		// (get) Token: 0x060091D4 RID: 37332 RVA: 0x001533D8 File Offset: 0x001515D8
		// (set) Token: 0x060091D5 RID: 37333 RVA: 0x0015346B File Offset: 0x0015166B
		public virtual List<IStateInfo> States
		{
			get
			{
				if (this._StatesInited)
				{
					return this._StatesCache;
				}
				this._StatesInited = true;
				if (this.FbInstance != null)
				{
					List<IStateInfo> states = this.FbInstance.States;
					if (states != null)
					{
						this._StatesCache = new List<IStateInfo>(states.Count);
						for (int i = 0; i < states.Count; i++)
						{
							this._StatesCache.Add(IStateInfo.Create(states[i]));
						}
					}
				}
				else
				{
					IFlowInfo_SetValue pocoInterface = this.PocoInterface;
					this._StatesCache = ((pocoInterface != null) ? pocoInterface.States : null);
				}
				return this._StatesCache;
			}
			set
			{
				this.GetOrCreatePoco().States = value;
				this._StatesInited = false;
			}
		}

		// Token: 0x17002E62 RID: 11874
		// (get) Token: 0x060091D6 RID: 37334 RVA: 0x00153480 File Offset: 0x00151680
		// (set) Token: 0x060091D7 RID: 37335 RVA: 0x001534AA File Offset: 0x001516AA
		public virtual bool? EdIsReserved
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsReserved;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsReserved = value;
			}
		}

		// Token: 0x040059CC RID: 22988
		[Nullable(2)]
		protected new IFlowInfo FbInstance;

		// Token: 0x040059CD RID: 22989
		[Nullable(2)]
		protected new IFlowInfo_SetValue PocoInterface;

		// Token: 0x040059CE RID: 22990
		private List<IStateInfo> _StatesCache;

		// Token: 0x040059CF RID: 22991
		private bool _StatesInited;
	}
}
