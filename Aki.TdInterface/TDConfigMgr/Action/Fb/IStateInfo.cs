using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.EditorObject.Fb;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200278B RID: 10123
	[NullableContext(2)]
	[Nullable(0)]
	public class IStateInfo : IEditorObject
	{
		// Token: 0x0600E023 RID: 57379 RVA: 0x0020FCA2 File Offset: 0x0020DEA2
		[NullableContext(0)]
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

		// Token: 0x17003DBB RID: 15803
		// (get) Token: 0x0600E024 RID: 57380 RVA: 0x0020FCC1 File Offset: 0x0020DEC1
		[Nullable(0)]
		public new virtual string ObjType
		{
			[NullableContext(0)]
			get
			{
				return this.Instance.ObjType;
			}
		}

		// Token: 0x17003DBC RID: 15804
		// (get) Token: 0x0600E025 RID: 57381 RVA: 0x0020FCD0 File Offset: 0x0020DED0
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

		// Token: 0x17003DBD RID: 15805
		// (get) Token: 0x0600E026 RID: 57382 RVA: 0x0020FD48 File Offset: 0x0020DF48
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

		// Token: 0x17003DBE RID: 15806
		// (get) Token: 0x0600E027 RID: 57383 RVA: 0x0020FDC0 File Offset: 0x0020DFC0
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

		// Token: 0x17003DBF RID: 15807
		// (get) Token: 0x0600E028 RID: 57384 RVA: 0x0020FE35 File Offset: 0x0020E035
		public override string EdPlannedBranch
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003DC0 RID: 15808
		// (get) Token: 0x0600E029 RID: 57385 RVA: 0x0020FE38 File Offset: 0x0020E038
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
				return null;
			}
		}

		// Token: 0x17003DC1 RID: 15809
		// (get) Token: 0x0600E02A RID: 57386 RVA: 0x0020FE3B File Offset: 0x0020E03B
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
				return null;
			}
		}

		// Token: 0x17003DC2 RID: 15810
		// (get) Token: 0x0600E02B RID: 57387 RVA: 0x0020FE3E File Offset: 0x0020E03E
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
				return null;
			}
		}

		// Token: 0x17003DC3 RID: 15811
		// (get) Token: 0x0600E02C RID: 57388 RVA: 0x0020FE41 File Offset: 0x0020E041
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17003DC4 RID: 15812
		// (get) Token: 0x0600E02D RID: 57389 RVA: 0x0020FE4E File Offset: 0x0020E04E
		[Nullable(0)]
		public virtual string Name
		{
			[NullableContext(0)]
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x17003DC5 RID: 15813
		// (get) Token: 0x0600E02E RID: 57390 RVA: 0x0020FE5C File Offset: 0x0020E05C
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

		// Token: 0x17003DC6 RID: 15814
		// (get) Token: 0x0600E02F RID: 57391 RVA: 0x0020FE94 File Offset: 0x0020E094
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
				int actionsLength = this.Instance.ActionsLength;
				this._ActionsCache = new List<ActionInfo>(actionsLength);
				for (int i = 0; i < actionsLength; i++)
				{
					this._ActionsCache.Add(ActionInfo.Create(this.Instance.Actions(i)));
				}
				return this._ActionsCache;
			}
		}

		// Token: 0x17003DC7 RID: 15815
		// (get) Token: 0x0600E030 RID: 57392 RVA: 0x0020FF00 File Offset: 0x0020E100
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

		// Token: 0x17003DC8 RID: 15816
		// (get) Token: 0x0600E031 RID: 57393 RVA: 0x0020FF38 File Offset: 0x0020E138
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

		// Token: 0x17003DC9 RID: 15817
		// (get) Token: 0x0600E032 RID: 57394 RVA: 0x0020FF70 File Offset: 0x0020E170
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

		// Token: 0x17003DCA RID: 15818
		// (get) Token: 0x0600E033 RID: 57395 RVA: 0x0020FFA8 File Offset: 0x0020E1A8
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

		// Token: 0x17003DCB RID: 15819
		// (get) Token: 0x0600E034 RID: 57396 RVA: 0x0020FFE4 File Offset: 0x0020E1E4
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

		// Token: 0x17003DCC RID: 15820
		// (get) Token: 0x0600E035 RID: 57397 RVA: 0x00210020 File Offset: 0x0020E220
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

		// Token: 0x17003DCD RID: 15821
		// (get) Token: 0x0600E036 RID: 57398 RVA: 0x0021005C File Offset: 0x0020E25C
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

		// Token: 0x17003DCE RID: 15822
		// (get) Token: 0x0600E037 RID: 57399 RVA: 0x00210098 File Offset: 0x0020E298
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

		// Token: 0x17003DCF RID: 15823
		// (get) Token: 0x0600E038 RID: 57400 RVA: 0x002100D4 File Offset: 0x0020E2D4
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

		// Token: 0x17003DD0 RID: 15824
		// (get) Token: 0x0600E039 RID: 57401 RVA: 0x0021010E File Offset: 0x0020E30E
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

		// Token: 0x17003DD1 RID: 15825
		// (get) Token: 0x0600E03A RID: 57402 RVA: 0x00210142 File Offset: 0x0020E342
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

		// Token: 0x17003DD2 RID: 15826
		// (get) Token: 0x0600E03B RID: 57403 RVA: 0x00210178 File Offset: 0x0020E378
		public virtual bool? UseConditionalText
		{
			get
			{
				if ((this.Instance.NullMask & 8192) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.UseConditionalText);
			}
		}

		// Token: 0x17003DD3 RID: 15827
		// (get) Token: 0x0600E03C RID: 57404 RVA: 0x002101B4 File Offset: 0x0020E3B4
		public virtual List<int> _SelectedIndexes
		{
			get
			{
				if (this.__SelectedIndexesInited)
				{
					return this.__SelectedIndexesCache;
				}
				this.__SelectedIndexesInited = true;
				if ((this.Instance.NullMask & 16384) == 0)
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

		// Token: 0x17003DD4 RID: 15828
		// (get) Token: 0x0600E03D RID: 57405 RVA: 0x0021022D File Offset: 0x0020E42D
		public virtual string EdPlotNode
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003DD5 RID: 15829
		// (get) Token: 0x0600E03E RID: 57406 RVA: 0x00210230 File Offset: 0x0020E430
		public virtual bool? EdPlotHandleJump
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003DD6 RID: 15830
		// (get) Token: 0x0600E03F RID: 57407 RVA: 0x00210246 File Offset: 0x0020E446
		public virtual string EdPlotFileId
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003DD7 RID: 15831
		// (get) Token: 0x0600E040 RID: 57408 RVA: 0x0021024C File Offset: 0x0020E44C
		public virtual int? EdNextPlotKeyId
		{
			get
			{
				return null;
			}
		}

		// Token: 0x040079EF RID: 31215
		private IStateInfo Instance;

		// Token: 0x040079F0 RID: 31216
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<string> _ChildrenCache;

		// Token: 0x040079F1 RID: 31217
		private bool _ChildrenInited;

		// Token: 0x040079F2 RID: 31218
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<string> _ReferenceCache;

		// Token: 0x040079F3 RID: 31219
		private bool _ReferenceInited;

		// Token: 0x040079F4 RID: 31220
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<string> _WeakReferenceCache;

		// Token: 0x040079F5 RID: 31221
		private bool _WeakReferenceInited;

		// Token: 0x040079F6 RID: 31222
		[Nullable(0)]
		private List<ActionInfo> _ActionsCache;

		// Token: 0x040079F7 RID: 31223
		private bool _ActionsInited;

		// Token: 0x040079F8 RID: 31224
		private PosA _PlotPosCache;

		// Token: 0x040079F9 RID: 31225
		private bool _PlotPosInited;

		// Token: 0x040079FA RID: 31226
		private IStateProgramSpecialProcessChangeTeamOptimization _ProgramSpecialProcessCache;

		// Token: 0x040079FB RID: 31227
		private bool _ProgramSpecialProcessInited;

		// Token: 0x040079FC RID: 31228
		private List<int> __SelectedIndexesCache;

		// Token: 0x040079FD RID: 31229
		private bool __SelectedIndexesInited;
	}
}
