using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.EditorObject.Fb;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024E6 RID: 9446
	[NullableContext(2)]
	[Nullable(0)]
	public class IStateInfo : IEditorObject
	{
		// Token: 0x0600D2CE RID: 53966 RVA: 0x001F4446 File Offset: 0x001F2646
		[NullableContext(1)]
		public static IStateInfo Create(IStateInfo? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStateInfo
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003AC4 RID: 15044
		// (get) Token: 0x0600D2CF RID: 53967 RVA: 0x001F4465 File Offset: 0x001F2665
		[Nullable(1)]
		public new virtual string ObjType
		{
			[NullableContext(1)]
			get
			{
				return this.Instance.ObjType;
			}
		}

		// Token: 0x17003AC5 RID: 15045
		// (get) Token: 0x0600D2D0 RID: 53968 RVA: 0x001F4474 File Offset: 0x001F2674
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
				if (this._ChildrenInited)
				{
					return this._ChildrenCache;
				}
				this._ChildrenInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int childrenLength = this.Instance.ChildrenLength;
				this._ChildrenCache = new List<string>(childrenLength);
				for (int i = 0; i < childrenLength; i++)
				{
					this._ChildrenCache.Add(this.Instance.Children(i));
				}
				return this._ChildrenCache;
			}
		}

		// Token: 0x17003AC6 RID: 15046
		// (get) Token: 0x0600D2D1 RID: 53969 RVA: 0x001F44EC File Offset: 0x001F26EC
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
				if (this._ReferenceInited)
				{
					return this._ReferenceCache;
				}
				this._ReferenceInited = true;
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int referenceLength = this.Instance.ReferenceLength;
				this._ReferenceCache = new List<string>(referenceLength);
				for (int i = 0; i < referenceLength; i++)
				{
					this._ReferenceCache.Add(this.Instance.Reference(i));
				}
				return this._ReferenceCache;
			}
		}

		// Token: 0x17003AC7 RID: 15047
		// (get) Token: 0x0600D2D2 RID: 53970 RVA: 0x001F4564 File Offset: 0x001F2764
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
				if (this._WeakReferenceInited)
				{
					return this._WeakReferenceCache;
				}
				this._WeakReferenceInited = true;
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				int weakReferenceLength = this.Instance.WeakReferenceLength;
				this._WeakReferenceCache = new List<string>(weakReferenceLength);
				for (int i = 0; i < weakReferenceLength; i++)
				{
					this._WeakReferenceCache.Add(this.Instance.WeakReference(i));
				}
				return this._WeakReferenceCache;
			}
		}

		// Token: 0x17003AC8 RID: 15048
		// (get) Token: 0x0600D2D3 RID: 53971 RVA: 0x001F45D9 File Offset: 0x001F27D9
		public override string EdPlannedBranch
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003AC9 RID: 15049
		// (get) Token: 0x0600D2D4 RID: 53972 RVA: 0x001F45DC File Offset: 0x001F27DC
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
				return null;
			}
		}

		// Token: 0x17003ACA RID: 15050
		// (get) Token: 0x0600D2D5 RID: 53973 RVA: 0x001F45DF File Offset: 0x001F27DF
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
				return null;
			}
		}

		// Token: 0x17003ACB RID: 15051
		// (get) Token: 0x0600D2D6 RID: 53974 RVA: 0x001F45E2 File Offset: 0x001F27E2
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
				return null;
			}
		}

		// Token: 0x17003ACC RID: 15052
		// (get) Token: 0x0600D2D7 RID: 53975 RVA: 0x001F45E5 File Offset: 0x001F27E5
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17003ACD RID: 15053
		// (get) Token: 0x0600D2D8 RID: 53976 RVA: 0x001F45F2 File Offset: 0x001F27F2
		[Nullable(1)]
		public virtual string Name
		{
			[NullableContext(1)]
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x17003ACE RID: 15054
		// (get) Token: 0x0600D2D9 RID: 53977 RVA: 0x001F4600 File Offset: 0x001F2800
		public virtual bool? _Folded
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new bool?(this.Instance._Folded);
			}
		}

		// Token: 0x17003ACF RID: 15055
		// (get) Token: 0x0600D2DA RID: 53978 RVA: 0x001F4638 File Offset: 0x001F2838
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
				int actionsLength = this.Instance.ActionsLength;
				this._ActionsCache = new List<ActionInfo>(actionsLength);
				for (int i = 0; i < actionsLength; i++)
				{
					this._ActionsCache.Add(ActionInfo.Create(this.Instance.Actions(i)));
				}
				return this._ActionsCache;
			}
		}

		// Token: 0x17003AD0 RID: 15056
		// (get) Token: 0x0600D2DB RID: 53979 RVA: 0x001F46A4 File Offset: 0x001F28A4
		public virtual bool? KeepBgm
		{
			get
			{
				if ((this.Instance.NullMask & 16) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.KeepBgm);
			}
		}

		// Token: 0x17003AD1 RID: 15057
		// (get) Token: 0x0600D2DC RID: 53980 RVA: 0x001F46DC File Offset: 0x001F28DC
		public virtual bool? OnlyPlayOnce
		{
			get
			{
				if ((this.Instance.NullMask & 32) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.OnlyPlayOnce);
			}
		}

		// Token: 0x17003AD2 RID: 15058
		// (get) Token: 0x0600D2DD RID: 53981 RVA: 0x001F4714 File Offset: 0x001F2914
		public virtual bool? KeepInVehicle
		{
			get
			{
				if ((this.Instance.NullMask & 64) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.KeepInVehicle);
			}
		}

		// Token: 0x17003AD3 RID: 15059
		// (get) Token: 0x0600D2DE RID: 53982 RVA: 0x001F474C File Offset: 0x001F294C
		public virtual bool? AllowMultiReference
		{
			get
			{
				if ((this.Instance.NullMask & 128) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.AllowMultiReference);
			}
		}

		// Token: 0x17003AD4 RID: 15060
		// (get) Token: 0x0600D2DF RID: 53983 RVA: 0x001F4788 File Offset: 0x001F2988
		public virtual bool? IgnoreInPlotHandBook
		{
			get
			{
				if ((this.Instance.NullMask & 256) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IgnoreInPlotHandBook);
			}
		}

		// Token: 0x17003AD5 RID: 15061
		// (get) Token: 0x0600D2E0 RID: 53984 RVA: 0x001F47C4 File Offset: 0x001F29C4
		public virtual bool? DontInterruptMatch
		{
			get
			{
				if ((this.Instance.NullMask & 512) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.DontInterruptMatch);
			}
		}

		// Token: 0x17003AD6 RID: 15062
		// (get) Token: 0x0600D2E1 RID: 53985 RVA: 0x001F4800 File Offset: 0x001F2A00
		public virtual bool? IsPreloadFlow
		{
			get
			{
				if ((this.Instance.NullMask & 1024) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsPreloadFlow);
			}
		}

		// Token: 0x17003AD7 RID: 15063
		// (get) Token: 0x0600D2E2 RID: 53986 RVA: 0x001F483C File Offset: 0x001F2A3C
		public virtual bool? IsClientFlow
		{
			get
			{
				if ((this.Instance.NullMask & 2048) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsClientFlow);
			}
		}

		// Token: 0x17003AD8 RID: 15064
		// (get) Token: 0x0600D2E3 RID: 53987 RVA: 0x001F4878 File Offset: 0x001F2A78
		public virtual bool? _ShowImport
		{
			get
			{
				if ((this.Instance.NullMask & 4096) == 0)
				{
					return null;
				}
				return new bool?(this.Instance._ShowImport);
			}
		}

		// Token: 0x17003AD9 RID: 15065
		// (get) Token: 0x0600D2E4 RID: 53988 RVA: 0x001F48B2 File Offset: 0x001F2AB2
		public virtual PosA PlotPos
		{
			get
			{
				if (this._PlotPosInited)
				{
					return this._PlotPosCache;
				}
				this._PlotPosInited = true;
				this._PlotPosCache = PosA.Create(this.Instance.PlotPos);
				return this._PlotPosCache;
			}
		}

		// Token: 0x17003ADA RID: 15066
		// (get) Token: 0x0600D2E5 RID: 53989 RVA: 0x001F48E6 File Offset: 0x001F2AE6
		public virtual IStateProgramSpecialProcessChangeTeamOptimization ProgramSpecialProcess
		{
			get
			{
				if (this._ProgramSpecialProcessInited)
				{
					return this._ProgramSpecialProcessCache;
				}
				this._ProgramSpecialProcessInited = true;
				this._ProgramSpecialProcessCache = IStateProgramSpecialProcessChangeTeamOptimization.Create(this.Instance.ProgramSpecialProcess);
				return this._ProgramSpecialProcessCache;
			}
		}

		// Token: 0x17003ADB RID: 15067
		// (get) Token: 0x0600D2E6 RID: 53990 RVA: 0x001F491C File Offset: 0x001F2B1C
		public virtual List<int> _SelectedIndexes
		{
			get
			{
				if (this.__SelectedIndexesInited)
				{
					return this.__SelectedIndexesCache;
				}
				this.__SelectedIndexesInited = true;
				if ((this.Instance.NullMask & 8192) == 0)
				{
					return null;
				}
				int selectedIndexesLength = this.Instance._SelectedIndexesLength;
				this.__SelectedIndexesCache = new List<int>(selectedIndexesLength);
				for (int i = 0; i < selectedIndexesLength; i++)
				{
					this.__SelectedIndexesCache.Add(this.Instance._SelectedIndexes(i));
				}
				return this.__SelectedIndexesCache;
			}
		}

		// Token: 0x17003ADC RID: 15068
		// (get) Token: 0x0600D2E7 RID: 53991 RVA: 0x001F4995 File Offset: 0x001F2B95
		public virtual string EdPlotNode
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003ADD RID: 15069
		// (get) Token: 0x0600D2E8 RID: 53992 RVA: 0x001F4998 File Offset: 0x001F2B98
		public virtual bool? EdPlotHandleJump
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003ADE RID: 15070
		// (get) Token: 0x0600D2E9 RID: 53993 RVA: 0x001F49AE File Offset: 0x001F2BAE
		public virtual string EdPlotFileId
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003ADF RID: 15071
		// (get) Token: 0x0600D2EA RID: 53994 RVA: 0x001F49B4 File Offset: 0x001F2BB4
		public virtual int? EdNextPlotKeyId
		{
			get
			{
				return null;
			}
		}

		// Token: 0x040073A2 RID: 29602
		private IStateInfo Instance;

		// Token: 0x040073A3 RID: 29603
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<string> _ChildrenCache;

		// Token: 0x040073A4 RID: 29604
		private bool _ChildrenInited;

		// Token: 0x040073A5 RID: 29605
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<string> _ReferenceCache;

		// Token: 0x040073A6 RID: 29606
		private bool _ReferenceInited;

		// Token: 0x040073A7 RID: 29607
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<string> _WeakReferenceCache;

		// Token: 0x040073A8 RID: 29608
		private bool _WeakReferenceInited;

		// Token: 0x040073A9 RID: 29609
		[Nullable(1)]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x040073AA RID: 29610
		private bool _ActionsInited;

		// Token: 0x040073AB RID: 29611
		private PosA _PlotPosCache;

		// Token: 0x040073AC RID: 29612
		private bool _PlotPosInited;

		// Token: 0x040073AD RID: 29613
		private IStateProgramSpecialProcessChangeTeamOptimization _ProgramSpecialProcessCache;

		// Token: 0x040073AE RID: 29614
		private bool _ProgramSpecialProcessInited;

		// Token: 0x040073AF RID: 29615
		private List<int> __SelectedIndexesCache;

		// Token: 0x040073B0 RID: 29616
		private bool __SelectedIndexesInited;
	}
}
