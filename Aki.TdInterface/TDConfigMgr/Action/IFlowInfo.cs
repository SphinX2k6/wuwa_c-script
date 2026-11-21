using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.EditorObject;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C28 RID: 7208
	public class IFlowInfo : IEditorObject
	{
		// Token: 0x0600991E RID: 39198 RVA: 0x00162EE4 File Offset: 0x001610E4
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

		// Token: 0x0600991F RID: 39199 RVA: 0x00162F1C File Offset: 0x0016111C
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

		// Token: 0x06009920 RID: 39200 RVA: 0x00162F2F File Offset: 0x0016112F
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

		// Token: 0x06009921 RID: 39201 RVA: 0x00162F44 File Offset: 0x00161144
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
				_selectedStateIds = this._SelectedStateIds,
				VarContext = this.VarContext,
				States = this.States,
				EdIsReserved = this.EdIsReserved
			};
		}

		// Token: 0x17003060 RID: 12384
		// (get) Token: 0x06009922 RID: 39202 RVA: 0x00163022 File Offset: 0x00161222
		// (set) Token: 0x06009923 RID: 39203 RVA: 0x0016304D File Offset: 0x0016124D
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

		// Token: 0x17003061 RID: 12385
		// (get) Token: 0x06009924 RID: 39204 RVA: 0x0016305B File Offset: 0x0016125B
		// (set) Token: 0x06009925 RID: 39205 RVA: 0x00163082 File Offset: 0x00161282
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public override List<string> Children
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().Children = value;
			}
		}

		// Token: 0x17003062 RID: 12386
		// (get) Token: 0x06009926 RID: 39206 RVA: 0x00163090 File Offset: 0x00161290
		// (set) Token: 0x06009927 RID: 39207 RVA: 0x001630B7 File Offset: 0x001612B7
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public override List<string> Reference
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().Reference = value;
			}
		}

		// Token: 0x17003063 RID: 12387
		// (get) Token: 0x06009928 RID: 39208 RVA: 0x001630C5 File Offset: 0x001612C5
		// (set) Token: 0x06009929 RID: 39209 RVA: 0x001630EC File Offset: 0x001612EC
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public override List<string> WeakReference
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().WeakReference = value;
			}
		}

		// Token: 0x17003064 RID: 12388
		// (get) Token: 0x0600992A RID: 39210 RVA: 0x001630FA File Offset: 0x001612FA
		// (set) Token: 0x0600992B RID: 39211 RVA: 0x00163111 File Offset: 0x00161311
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

		// Token: 0x17003065 RID: 12389
		// (get) Token: 0x0600992C RID: 39212 RVA: 0x0016311F File Offset: 0x0016131F
		// (set) Token: 0x0600992D RID: 39213 RVA: 0x00163136 File Offset: 0x00161336
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public override List<string> EdTextRef
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().EdTextRef = value;
			}
		}

		// Token: 0x17003066 RID: 12390
		// (get) Token: 0x0600992E RID: 39214 RVA: 0x00163144 File Offset: 0x00161344
		// (set) Token: 0x0600992F RID: 39215 RVA: 0x0016315B File Offset: 0x0016135B
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public override List<string> _children
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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
				0
			})]
			set
			{
				this.GetOrCreatePoco()._children = value;
			}
		}

		// Token: 0x17003067 RID: 12391
		// (get) Token: 0x06009930 RID: 39216 RVA: 0x00163169 File Offset: 0x00161369
		// (set) Token: 0x06009931 RID: 39217 RVA: 0x00163180 File Offset: 0x00161380
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public override List<string> _reference
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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
				0
			})]
			set
			{
				this.GetOrCreatePoco()._reference = value;
			}
		}

		// Token: 0x17003068 RID: 12392
		// (get) Token: 0x06009932 RID: 39218 RVA: 0x0016318E File Offset: 0x0016138E
		// (set) Token: 0x06009933 RID: 39219 RVA: 0x001631B9 File Offset: 0x001613B9
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

		// Token: 0x17003069 RID: 12393
		// (get) Token: 0x06009934 RID: 39220 RVA: 0x001631C7 File Offset: 0x001613C7
		// (set) Token: 0x06009935 RID: 39221 RVA: 0x001631F2 File Offset: 0x001613F2
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

		// Token: 0x1700306A RID: 12394
		// (get) Token: 0x06009936 RID: 39222 RVA: 0x00163200 File Offset: 0x00161400
		// (set) Token: 0x06009937 RID: 39223 RVA: 0x0016323A File Offset: 0x0016143A
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

		// Token: 0x1700306B RID: 12395
		// (get) Token: 0x06009938 RID: 39224 RVA: 0x00163248 File Offset: 0x00161448
		// (set) Token: 0x06009939 RID: 39225 RVA: 0x00163282 File Offset: 0x00161482
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

		// Token: 0x1700306C RID: 12396
		// (get) Token: 0x0600993A RID: 39226 RVA: 0x00163290 File Offset: 0x00161490
		// (set) Token: 0x0600993B RID: 39227 RVA: 0x001632CA File Offset: 0x001614CA
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

		// Token: 0x1700306D RID: 12397
		// (get) Token: 0x0600993C RID: 39228 RVA: 0x001632D8 File Offset: 0x001614D8
		// (set) Token: 0x0600993D RID: 39229 RVA: 0x001632FF File Offset: 0x001614FF
		[Nullable(2)]
		public virtual List<int> _SelectedStateIds
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance._SelectedStateIds;
				}
				IFlowInfo_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface._selectedStateIds;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco()._selectedStateIds = value;
			}
		}

		// Token: 0x1700306E RID: 12398
		// (get) Token: 0x0600993E RID: 39230 RVA: 0x0016330D File Offset: 0x0016150D
		// (set) Token: 0x0600993F RID: 39231 RVA: 0x00163334 File Offset: 0x00161534
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

		// Token: 0x1700306F RID: 12399
		// (get) Token: 0x06009940 RID: 39232 RVA: 0x00163344 File Offset: 0x00161544
		// (set) Token: 0x06009941 RID: 39233 RVA: 0x001633D7 File Offset: 0x001615D7
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

		// Token: 0x17003070 RID: 12400
		// (get) Token: 0x06009942 RID: 39234 RVA: 0x001633EC File Offset: 0x001615EC
		// (set) Token: 0x06009943 RID: 39235 RVA: 0x00163416 File Offset: 0x00161616
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

		// Token: 0x04005E31 RID: 24113
		[Nullable(2)]
		protected new IFlowInfo FbInstance;

		// Token: 0x04005E32 RID: 24114
		[Nullable(2)]
		protected new IFlowInfo_SetValue PocoInterface;

		// Token: 0x04005E33 RID: 24115
		private List<IStateInfo> _StatesCache;

		// Token: 0x04005E34 RID: 24116
		private bool _StatesInited;
	}
}
