using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.EditorObject;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020F0 RID: 8432
	[NullableContext(2)]
	[Nullable(0)]
	public class IStateInfo : IEditorObject
	{
		// Token: 0x0600B2FA RID: 45818 RVA: 0x00191B80 File Offset: 0x0018FD80
		[NullableContext(0)]
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

		// Token: 0x0600B2FB RID: 45819 RVA: 0x00191BB8 File Offset: 0x0018FDB8
		[NullableContext(0)]
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

		// Token: 0x0600B2FC RID: 45820 RVA: 0x00191BCB File Offset: 0x0018FDCB
		[NullableContext(0)]
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

		// Token: 0x0600B2FD RID: 45821 RVA: 0x00191BE0 File Offset: 0x0018FDE0
		[NullableContext(0)]
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
				UseConditionalText = this.UseConditionalText,
				_SelectedIndexes = this._SelectedIndexes,
				EdPlotNode = this.EdPlotNode,
				EdPlotHandleJump = this.EdPlotHandleJump,
				EdPlotFileId = this.EdPlotFileId,
				EdNextPlotKeyId = this.EdNextPlotKeyId
			};
		}

		// Token: 0x17003624 RID: 13860
		// (get) Token: 0x0600B2FE RID: 45822 RVA: 0x00191D4E File Offset: 0x0018FF4E
		// (set) Token: 0x0600B2FF RID: 45823 RVA: 0x00191D79 File Offset: 0x0018FF79
		[Nullable(0)]
		public new virtual string ObjType
		{
			[NullableContext(0)]
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
			[NullableContext(0)]
			set
			{
				this.GetOrCreatePoco().ObjType = value;
			}
		}

		// Token: 0x17003625 RID: 13861
		// (get) Token: 0x0600B300 RID: 45824 RVA: 0x00191D87 File Offset: 0x0018FF87
		// (set) Token: 0x0600B301 RID: 45825 RVA: 0x00191DAE File Offset: 0x0018FFAE
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().Children = value;
			}
		}

		// Token: 0x17003626 RID: 13862
		// (get) Token: 0x0600B302 RID: 45826 RVA: 0x00191DBC File Offset: 0x0018FFBC
		// (set) Token: 0x0600B303 RID: 45827 RVA: 0x00191DE3 File Offset: 0x0018FFE3
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().Reference = value;
			}
		}

		// Token: 0x17003627 RID: 13863
		// (get) Token: 0x0600B304 RID: 45828 RVA: 0x00191DF1 File Offset: 0x0018FFF1
		// (set) Token: 0x0600B305 RID: 45829 RVA: 0x00191E18 File Offset: 0x00190018
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().WeakReference = value;
			}
		}

		// Token: 0x17003628 RID: 13864
		// (get) Token: 0x0600B306 RID: 45830 RVA: 0x00191E26 File Offset: 0x00190026
		// (set) Token: 0x0600B307 RID: 45831 RVA: 0x00191E3D File Offset: 0x0019003D
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

		// Token: 0x17003629 RID: 13865
		// (get) Token: 0x0600B308 RID: 45832 RVA: 0x00191E4B File Offset: 0x0019004B
		// (set) Token: 0x0600B309 RID: 45833 RVA: 0x00191E62 File Offset: 0x00190062
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

		// Token: 0x1700362A RID: 13866
		// (get) Token: 0x0600B30A RID: 45834 RVA: 0x00191E70 File Offset: 0x00190070
		// (set) Token: 0x0600B30B RID: 45835 RVA: 0x00191E87 File Offset: 0x00190087
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

		// Token: 0x1700362B RID: 13867
		// (get) Token: 0x0600B30C RID: 45836 RVA: 0x00191E95 File Offset: 0x00190095
		// (set) Token: 0x0600B30D RID: 45837 RVA: 0x00191EAC File Offset: 0x001900AC
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

		// Token: 0x1700362C RID: 13868
		// (get) Token: 0x0600B30E RID: 45838 RVA: 0x00191EBA File Offset: 0x001900BA
		// (set) Token: 0x0600B30F RID: 45839 RVA: 0x00191EE5 File Offset: 0x001900E5
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

		// Token: 0x1700362D RID: 13869
		// (get) Token: 0x0600B310 RID: 45840 RVA: 0x00191EF3 File Offset: 0x001900F3
		// (set) Token: 0x0600B311 RID: 45841 RVA: 0x00191F1E File Offset: 0x0019011E
		[Nullable(0)]
		public virtual string Name
		{
			[NullableContext(0)]
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
			[NullableContext(0)]
			set
			{
				this.GetOrCreatePoco().Name = value;
			}
		}

		// Token: 0x1700362E RID: 13870
		// (get) Token: 0x0600B312 RID: 45842 RVA: 0x00191F2C File Offset: 0x0019012C
		// (set) Token: 0x0600B313 RID: 45843 RVA: 0x00191F66 File Offset: 0x00190166
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

		// Token: 0x1700362F RID: 13871
		// (get) Token: 0x0600B314 RID: 45844 RVA: 0x00191F74 File Offset: 0x00190174
		// (set) Token: 0x0600B315 RID: 45845 RVA: 0x00192007 File Offset: 0x00190207
		[Nullable(0)]
		public virtual List<ActionInfo> Actions
		{
			[NullableContext(0)]
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
			[NullableContext(0)]
			set
			{
				this.GetOrCreatePoco().Actions = value;
				this._ActionsInited = false;
			}
		}

		// Token: 0x17003630 RID: 13872
		// (get) Token: 0x0600B316 RID: 45846 RVA: 0x0019201C File Offset: 0x0019021C
		// (set) Token: 0x0600B317 RID: 45847 RVA: 0x00192056 File Offset: 0x00190256
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

		// Token: 0x17003631 RID: 13873
		// (get) Token: 0x0600B318 RID: 45848 RVA: 0x00192064 File Offset: 0x00190264
		// (set) Token: 0x0600B319 RID: 45849 RVA: 0x0019209E File Offset: 0x0019029E
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

		// Token: 0x17003632 RID: 13874
		// (get) Token: 0x0600B31A RID: 45850 RVA: 0x001920AC File Offset: 0x001902AC
		// (set) Token: 0x0600B31B RID: 45851 RVA: 0x001920E6 File Offset: 0x001902E6
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

		// Token: 0x17003633 RID: 13875
		// (get) Token: 0x0600B31C RID: 45852 RVA: 0x001920F4 File Offset: 0x001902F4
		// (set) Token: 0x0600B31D RID: 45853 RVA: 0x0019212E File Offset: 0x0019032E
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

		// Token: 0x17003634 RID: 13876
		// (get) Token: 0x0600B31E RID: 45854 RVA: 0x0019213C File Offset: 0x0019033C
		// (set) Token: 0x0600B31F RID: 45855 RVA: 0x00192176 File Offset: 0x00190376
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

		// Token: 0x17003635 RID: 13877
		// (get) Token: 0x0600B320 RID: 45856 RVA: 0x00192184 File Offset: 0x00190384
		// (set) Token: 0x0600B321 RID: 45857 RVA: 0x001921BE File Offset: 0x001903BE
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

		// Token: 0x17003636 RID: 13878
		// (get) Token: 0x0600B322 RID: 45858 RVA: 0x001921CC File Offset: 0x001903CC
		// (set) Token: 0x0600B323 RID: 45859 RVA: 0x00192206 File Offset: 0x00190406
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

		// Token: 0x17003637 RID: 13879
		// (get) Token: 0x0600B324 RID: 45860 RVA: 0x00192214 File Offset: 0x00190414
		// (set) Token: 0x0600B325 RID: 45861 RVA: 0x0019224E File Offset: 0x0019044E
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

		// Token: 0x17003638 RID: 13880
		// (get) Token: 0x0600B326 RID: 45862 RVA: 0x0019225C File Offset: 0x0019045C
		// (set) Token: 0x0600B327 RID: 45863 RVA: 0x00192296 File Offset: 0x00190496
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

		// Token: 0x17003639 RID: 13881
		// (get) Token: 0x0600B328 RID: 45864 RVA: 0x001922A4 File Offset: 0x001904A4
		// (set) Token: 0x0600B329 RID: 45865 RVA: 0x00192305 File Offset: 0x00190505
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

		// Token: 0x1700363A RID: 13882
		// (get) Token: 0x0600B32A RID: 45866 RVA: 0x0019231C File Offset: 0x0019051C
		// (set) Token: 0x0600B32B RID: 45867 RVA: 0x0019237D File Offset: 0x0019057D
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

		// Token: 0x1700363B RID: 13883
		// (get) Token: 0x0600B32C RID: 45868 RVA: 0x00192394 File Offset: 0x00190594
		// (set) Token: 0x0600B32D RID: 45869 RVA: 0x001923CE File Offset: 0x001905CE
		public virtual bool? UseConditionalText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UseConditionalText;
				}
				IStateInfo_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.UseConditionalText;
			}
			set
			{
				this.GetOrCreatePoco().UseConditionalText = value;
			}
		}

		// Token: 0x1700363C RID: 13884
		// (get) Token: 0x0600B32E RID: 45870 RVA: 0x001923DC File Offset: 0x001905DC
		// (set) Token: 0x0600B32F RID: 45871 RVA: 0x00192403 File Offset: 0x00190603
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

		// Token: 0x1700363D RID: 13885
		// (get) Token: 0x0600B330 RID: 45872 RVA: 0x00192411 File Offset: 0x00190611
		// (set) Token: 0x0600B331 RID: 45873 RVA: 0x00192428 File Offset: 0x00190628
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

		// Token: 0x1700363E RID: 13886
		// (get) Token: 0x0600B332 RID: 45874 RVA: 0x00192438 File Offset: 0x00190638
		// (set) Token: 0x0600B333 RID: 45875 RVA: 0x00192462 File Offset: 0x00190662
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

		// Token: 0x1700363F RID: 13887
		// (get) Token: 0x0600B334 RID: 45876 RVA: 0x00192470 File Offset: 0x00190670
		// (set) Token: 0x0600B335 RID: 45877 RVA: 0x00192487 File Offset: 0x00190687
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

		// Token: 0x17003640 RID: 13888
		// (get) Token: 0x0600B336 RID: 45878 RVA: 0x00192498 File Offset: 0x00190698
		// (set) Token: 0x0600B337 RID: 45879 RVA: 0x001924C2 File Offset: 0x001906C2
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

		// Token: 0x04006A23 RID: 27171
		protected new IStateInfo FbInstance;

		// Token: 0x04006A24 RID: 27172
		protected new IStateInfo_SetValue PocoInterface;

		// Token: 0x04006A25 RID: 27173
		[Nullable(0)]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04006A26 RID: 27174
		private bool _ActionsInited;

		// Token: 0x04006A27 RID: 27175
		[Nullable(0)]
		private PosA _PlotPosCache;

		// Token: 0x04006A28 RID: 27176
		private bool _PlotPosInited;

		// Token: 0x04006A29 RID: 27177
		[Nullable(0)]
		private IStateProgramSpecialProcessChangeTeamOptimization _ProgramSpecialProcessCache;

		// Token: 0x04006A2A RID: 27178
		private bool _ProgramSpecialProcessInited;
	}
}
