using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.EditorObject;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EB7 RID: 7863
	[NullableContext(2)]
	[Nullable(0)]
	public class IStateInfo : IEditorObject
	{
		// Token: 0x0600A82A RID: 43050 RVA: 0x0017BBE0 File Offset: 0x00179DE0
		[NullableContext(1)]
		private IStateInfo_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IStateInfo 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IStateInfo_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IStateInfo_SetValue());
			}
			return result;
		}

		// Token: 0x0600A82B RID: 43051 RVA: 0x0017BC18 File Offset: 0x00179E18
		[NullableContext(1)]
		public static IStateInfo Create([Nullable(2)] IStateInfo instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStateInfo
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A82C RID: 43052 RVA: 0x0017BC2B File Offset: 0x00179E2B
		[NullableContext(1)]
		public static IStateInfo CreateFromSetValue([Nullable(2)] IStateInfo_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IStateInfo
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A82D RID: 43053 RVA: 0x0017BC40 File Offset: 0x00179E40
		[NullableContext(1)]
		public new IStateInfo_SetValue ToSetValue()
		{
			return new IStateInfo_SetValue
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
				_folded = this._Folded,
				Actions = this.Actions,
				KeepBgm = this.KeepBgm,
				OnlyPlayOnce = this.OnlyPlayOnce,
				KeepInVehicle = this.KeepInVehicle,
				AllowMultiReference = this.AllowMultiReference,
				IgnoreInPlotHandBook = this.IgnoreInPlotHandBook,
				DontInterruptMatch = this.DontInterruptMatch,
				IsPreloadFlow = this.IsPreloadFlow,
				IsClientFlow = this.IsClientFlow,
				_showImport = this._ShowImport,
				PlotPos = this.PlotPos,
				ProgramSpecialProcess = this.ProgramSpecialProcess,
				_SelectedIndexes = this._SelectedIndexes,
				EdPlotNode = this.EdPlotNode,
				EdPlotHandleJump = this.EdPlotHandleJump,
				EdPlotFileId = this.EdPlotFileId,
				EdNextPlotKeyId = this.EdNextPlotKeyId
			};
		}

		// Token: 0x1700335A RID: 13146
		// (get) Token: 0x0600A82E RID: 43054 RVA: 0x0017BDA2 File Offset: 0x00179FA2
		// (set) Token: 0x0600A82F RID: 43055 RVA: 0x0017BDCD File Offset: 0x00179FCD
		[Nullable(1)]
		public new virtual string ObjType
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				this.GetOrCreatePoco().ObjType = value;
			}
		}

		// Token: 0x1700335B RID: 13147
		// (get) Token: 0x0600A830 RID: 43056 RVA: 0x0017BDDB File Offset: 0x00179FDB
		// (set) Token: 0x0600A831 RID: 43057 RVA: 0x0017BE02 File Offset: 0x0017A002
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
				IStateInfo_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700335C RID: 13148
		// (get) Token: 0x0600A832 RID: 43058 RVA: 0x0017BE10 File Offset: 0x0017A010
		// (set) Token: 0x0600A833 RID: 43059 RVA: 0x0017BE37 File Offset: 0x0017A037
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
				IStateInfo_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700335D RID: 13149
		// (get) Token: 0x0600A834 RID: 43060 RVA: 0x0017BE45 File Offset: 0x0017A045
		// (set) Token: 0x0600A835 RID: 43061 RVA: 0x0017BE6C File Offset: 0x0017A06C
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
				IStateInfo_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700335E RID: 13150
		// (get) Token: 0x0600A836 RID: 43062 RVA: 0x0017BE7A File Offset: 0x0017A07A
		// (set) Token: 0x0600A837 RID: 43063 RVA: 0x0017BE91 File Offset: 0x0017A091
		public override string EdPlannedBranch
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdPlannedBranch;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdPlannedBranch = value;
			}
		}

		// Token: 0x1700335F RID: 13151
		// (get) Token: 0x0600A838 RID: 43064 RVA: 0x0017BE9F File Offset: 0x0017A09F
		// (set) Token: 0x0600A839 RID: 43065 RVA: 0x0017BEB6 File Offset: 0x0017A0B6
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

		// Token: 0x17003360 RID: 13152
		// (get) Token: 0x0600A83A RID: 43066 RVA: 0x0017BEC4 File Offset: 0x0017A0C4
		// (set) Token: 0x0600A83B RID: 43067 RVA: 0x0017BEDB File Offset: 0x0017A0DB
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

		// Token: 0x17003361 RID: 13153
		// (get) Token: 0x0600A83C RID: 43068 RVA: 0x0017BEE9 File Offset: 0x0017A0E9
		// (set) Token: 0x0600A83D RID: 43069 RVA: 0x0017BF00 File Offset: 0x0017A100
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

		// Token: 0x17003362 RID: 13154
		// (get) Token: 0x0600A83E RID: 43070 RVA: 0x0017BF0E File Offset: 0x0017A10E
		// (set) Token: 0x0600A83F RID: 43071 RVA: 0x0017BF39 File Offset: 0x0017A139
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

		// Token: 0x17003363 RID: 13155
		// (get) Token: 0x0600A840 RID: 43072 RVA: 0x0017BF47 File Offset: 0x0017A147
		// (set) Token: 0x0600A841 RID: 43073 RVA: 0x0017BF72 File Offset: 0x0017A172
		[Nullable(1)]
		public virtual string Name
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				this.GetOrCreatePoco().Name = value;
			}
		}

		// Token: 0x17003364 RID: 13156
		// (get) Token: 0x0600A842 RID: 43074 RVA: 0x0017BF80 File Offset: 0x0017A180
		// (set) Token: 0x0600A843 RID: 43075 RVA: 0x0017BFBA File Offset: 0x0017A1BA
		public virtual bool? _Folded
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance._Folded;
				}
				IStateInfo_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003365 RID: 13157
		// (get) Token: 0x0600A844 RID: 43076 RVA: 0x0017BFC8 File Offset: 0x0017A1C8
		// (set) Token: 0x0600A845 RID: 43077 RVA: 0x0017C05B File Offset: 0x0017A25B
		[Nullable(1)]
		public virtual List<ActionInfo> Actions
		{
			[NullableContext(1)]
			get
			{
				if (this._ActionsInited)
				{
					return this._ActionsCache;
				}
				this._ActionsInited = true;
				if (this.FbInstance != null)
				{
					List<ActionInfo> actions = this.FbInstance.Actions;
					if (actions != null)
					{
						this._ActionsCache = new List<ActionInfo>(actions.Count);
						for (int i = 0; i < actions.Count; i++)
						{
							this._ActionsCache.Add(ActionInfo.Create(actions[i]));
						}
					}
				}
				else
				{
					IStateInfo_SetValue pocoInterface = this.PocoInterface;
					this._ActionsCache = ((pocoInterface != null) ? pocoInterface.Actions : null);
				}
				return this._ActionsCache;
			}
			[NullableContext(1)]
			set
			{
				this.GetOrCreatePoco().Actions = value;
				this._ActionsInited = false;
			}
		}

		// Token: 0x17003366 RID: 13158
		// (get) Token: 0x0600A846 RID: 43078 RVA: 0x0017C070 File Offset: 0x0017A270
		// (set) Token: 0x0600A847 RID: 43079 RVA: 0x0017C0AA File Offset: 0x0017A2AA
		public virtual bool? KeepBgm
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.KeepBgm;
				}
				IStateInfo_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.KeepBgm;
			}
			set
			{
				this.GetOrCreatePoco().KeepBgm = value;
			}
		}

		// Token: 0x17003367 RID: 13159
		// (get) Token: 0x0600A848 RID: 43080 RVA: 0x0017C0B8 File Offset: 0x0017A2B8
		// (set) Token: 0x0600A849 RID: 43081 RVA: 0x0017C0F2 File Offset: 0x0017A2F2
		public virtual bool? OnlyPlayOnce
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.OnlyPlayOnce;
				}
				IStateInfo_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.OnlyPlayOnce;
			}
			set
			{
				this.GetOrCreatePoco().OnlyPlayOnce = value;
			}
		}

		// Token: 0x17003368 RID: 13160
		// (get) Token: 0x0600A84A RID: 43082 RVA: 0x0017C100 File Offset: 0x0017A300
		// (set) Token: 0x0600A84B RID: 43083 RVA: 0x0017C13A File Offset: 0x0017A33A
		public virtual bool? KeepInVehicle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.KeepInVehicle;
				}
				IStateInfo_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.KeepInVehicle;
			}
			set
			{
				this.GetOrCreatePoco().KeepInVehicle = value;
			}
		}

		// Token: 0x17003369 RID: 13161
		// (get) Token: 0x0600A84C RID: 43084 RVA: 0x0017C148 File Offset: 0x0017A348
		// (set) Token: 0x0600A84D RID: 43085 RVA: 0x0017C182 File Offset: 0x0017A382
		public virtual bool? AllowMultiReference
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AllowMultiReference;
				}
				IStateInfo_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AllowMultiReference;
			}
			set
			{
				this.GetOrCreatePoco().AllowMultiReference = value;
			}
		}

		// Token: 0x1700336A RID: 13162
		// (get) Token: 0x0600A84E RID: 43086 RVA: 0x0017C190 File Offset: 0x0017A390
		// (set) Token: 0x0600A84F RID: 43087 RVA: 0x0017C1CA File Offset: 0x0017A3CA
		public virtual bool? IgnoreInPlotHandBook
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IgnoreInPlotHandBook;
				}
				IStateInfo_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IgnoreInPlotHandBook;
			}
			set
			{
				this.GetOrCreatePoco().IgnoreInPlotHandBook = value;
			}
		}

		// Token: 0x1700336B RID: 13163
		// (get) Token: 0x0600A850 RID: 43088 RVA: 0x0017C1D8 File Offset: 0x0017A3D8
		// (set) Token: 0x0600A851 RID: 43089 RVA: 0x0017C212 File Offset: 0x0017A412
		public virtual bool? DontInterruptMatch
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DontInterruptMatch;
				}
				IStateInfo_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DontInterruptMatch;
			}
			set
			{
				this.GetOrCreatePoco().DontInterruptMatch = value;
			}
		}

		// Token: 0x1700336C RID: 13164
		// (get) Token: 0x0600A852 RID: 43090 RVA: 0x0017C220 File Offset: 0x0017A420
		// (set) Token: 0x0600A853 RID: 43091 RVA: 0x0017C25A File Offset: 0x0017A45A
		public virtual bool? IsPreloadFlow
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsPreloadFlow;
				}
				IStateInfo_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsPreloadFlow;
			}
			set
			{
				this.GetOrCreatePoco().IsPreloadFlow = value;
			}
		}

		// Token: 0x1700336D RID: 13165
		// (get) Token: 0x0600A854 RID: 43092 RVA: 0x0017C268 File Offset: 0x0017A468
		// (set) Token: 0x0600A855 RID: 43093 RVA: 0x0017C2A2 File Offset: 0x0017A4A2
		public virtual bool? IsClientFlow
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsClientFlow;
				}
				IStateInfo_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsClientFlow;
			}
			set
			{
				this.GetOrCreatePoco().IsClientFlow = value;
			}
		}

		// Token: 0x1700336E RID: 13166
		// (get) Token: 0x0600A856 RID: 43094 RVA: 0x0017C2B0 File Offset: 0x0017A4B0
		// (set) Token: 0x0600A857 RID: 43095 RVA: 0x0017C2EA File Offset: 0x0017A4EA
		public virtual bool? _ShowImport
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance._ShowImport;
				}
				IStateInfo_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface._showImport;
			}
			set
			{
				this.GetOrCreatePoco()._showImport = value;
			}
		}

		// Token: 0x1700336F RID: 13167
		// (get) Token: 0x0600A858 RID: 43096 RVA: 0x0017C2F8 File Offset: 0x0017A4F8
		// (set) Token: 0x0600A859 RID: 43097 RVA: 0x0017C359 File Offset: 0x0017A559
		public virtual PosA PlotPos
		{
			get
			{
				if (this._PlotPosInited)
				{
					return this._PlotPosCache;
				}
				this._PlotPosInited = true;
				if (this.FbInstance != null)
				{
					this._PlotPosCache = PosA.Create(this.FbInstance.PlotPos);
				}
				else
				{
					IStateInfo_SetValue pocoInterface = this.PocoInterface;
					this._PlotPosCache = ((pocoInterface != null) ? pocoInterface.PlotPos : null);
				}
				return this._PlotPosCache;
			}
			set
			{
				this.GetOrCreatePoco().PlotPos = value;
				this._PlotPosInited = false;
			}
		}

		// Token: 0x17003370 RID: 13168
		// (get) Token: 0x0600A85A RID: 43098 RVA: 0x0017C370 File Offset: 0x0017A570
		// (set) Token: 0x0600A85B RID: 43099 RVA: 0x0017C3D1 File Offset: 0x0017A5D1
		public virtual IStateProgramSpecialProcessChangeTeamOptimization ProgramSpecialProcess
		{
			get
			{
				if (this._ProgramSpecialProcessInited)
				{
					return this._ProgramSpecialProcessCache;
				}
				this._ProgramSpecialProcessInited = true;
				if (this.FbInstance != null)
				{
					this._ProgramSpecialProcessCache = IStateProgramSpecialProcessChangeTeamOptimization.Create(this.FbInstance.ProgramSpecialProcess);
				}
				else
				{
					IStateInfo_SetValue pocoInterface = this.PocoInterface;
					this._ProgramSpecialProcessCache = ((pocoInterface != null) ? pocoInterface.ProgramSpecialProcess : null);
				}
				return this._ProgramSpecialProcessCache;
			}
			set
			{
				this.GetOrCreatePoco().ProgramSpecialProcess = value;
				this._ProgramSpecialProcessInited = false;
			}
		}

		// Token: 0x17003371 RID: 13169
		// (get) Token: 0x0600A85C RID: 43100 RVA: 0x0017C3E6 File Offset: 0x0017A5E6
		// (set) Token: 0x0600A85D RID: 43101 RVA: 0x0017C40D File Offset: 0x0017A60D
		public virtual List<int> _SelectedIndexes
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance._SelectedIndexes;
				}
				IStateInfo_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface._SelectedIndexes;
			}
			set
			{
				this.GetOrCreatePoco()._SelectedIndexes = value;
			}
		}

		// Token: 0x17003372 RID: 13170
		// (get) Token: 0x0600A85E RID: 43102 RVA: 0x0017C41B File Offset: 0x0017A61B
		// (set) Token: 0x0600A85F RID: 43103 RVA: 0x0017C432 File Offset: 0x0017A632
		public virtual string EdPlotNode
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdPlotNode;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdPlotNode = value;
			}
		}

		// Token: 0x17003373 RID: 13171
		// (get) Token: 0x0600A860 RID: 43104 RVA: 0x0017C440 File Offset: 0x0017A640
		// (set) Token: 0x0600A861 RID: 43105 RVA: 0x0017C46A File Offset: 0x0017A66A
		public virtual bool? EdPlotHandleJump
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdPlotHandleJump;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdPlotHandleJump = value;
			}
		}

		// Token: 0x17003374 RID: 13172
		// (get) Token: 0x0600A862 RID: 43106 RVA: 0x0017C478 File Offset: 0x0017A678
		// (set) Token: 0x0600A863 RID: 43107 RVA: 0x0017C48F File Offset: 0x0017A68F
		public virtual string EdPlotFileId
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdPlotFileId;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdPlotFileId = value;
			}
		}

		// Token: 0x17003375 RID: 13173
		// (get) Token: 0x0600A864 RID: 43108 RVA: 0x0017C4A0 File Offset: 0x0017A6A0
		// (set) Token: 0x0600A865 RID: 43109 RVA: 0x0017C4CA File Offset: 0x0017A6CA
		public virtual int? EdNextPlotKeyId
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdNextPlotKeyId;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdNextPlotKeyId = value;
			}
		}

		// Token: 0x04006435 RID: 25653
		protected new IStateInfo FbInstance;

		// Token: 0x04006436 RID: 25654
		protected new IStateInfo_SetValue PocoInterface;

		// Token: 0x04006437 RID: 25655
		[Nullable(1)]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04006438 RID: 25656
		private bool _ActionsInited;

		// Token: 0x04006439 RID: 25657
		[Nullable(1)]
		private PosA _PlotPosCache;

		// Token: 0x0400643A RID: 25658
		private bool _PlotPosInited;

		// Token: 0x0400643B RID: 25659
		[Nullable(1)]
		private IStateProgramSpecialProcessChangeTeamOptimization _ProgramSpecialProcessCache;

		// Token: 0x0400643C RID: 25660
		private bool _ProgramSpecialProcessInited;
	}
}
