using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.EditorObject.Fb;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024EE RID: 9454
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlowInfo : IEditorObject
	{
		// Token: 0x0600D308 RID: 54024 RVA: 0x001F4BC3 File Offset: 0x001F2DC3
		public static IFlowInfo Create(IFlowInfo? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowInfo
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003AEE RID: 15086
		// (get) Token: 0x0600D309 RID: 54025 RVA: 0x001F4BE2 File Offset: 0x001F2DE2
		public new virtual string ObjType
		{
			get
			{
				return this.Instance.ObjType;
			}
		}

		// Token: 0x17003AEF RID: 15087
		// (get) Token: 0x0600D30A RID: 54026 RVA: 0x001F4BF0 File Offset: 0x001F2DF0
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

		// Token: 0x17003AF0 RID: 15088
		// (get) Token: 0x0600D30B RID: 54027 RVA: 0x001F4C68 File Offset: 0x001F2E68
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

		// Token: 0x17003AF1 RID: 15089
		// (get) Token: 0x0600D30C RID: 54028 RVA: 0x001F4CE0 File Offset: 0x001F2EE0
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

		// Token: 0x17003AF2 RID: 15090
		// (get) Token: 0x0600D30D RID: 54029 RVA: 0x001F4D55 File Offset: 0x001F2F55
		[Nullable(2)]
		public override string EdPlannedBranch
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x17003AF3 RID: 15091
		// (get) Token: 0x0600D30E RID: 54030 RVA: 0x001F4D58 File Offset: 0x001F2F58
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

		// Token: 0x17003AF4 RID: 15092
		// (get) Token: 0x0600D30F RID: 54031 RVA: 0x001F4D5B File Offset: 0x001F2F5B
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

		// Token: 0x17003AF5 RID: 15093
		// (get) Token: 0x0600D310 RID: 54032 RVA: 0x001F4D5E File Offset: 0x001F2F5E
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

		// Token: 0x17003AF6 RID: 15094
		// (get) Token: 0x0600D311 RID: 54033 RVA: 0x001F4D61 File Offset: 0x001F2F61
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17003AF7 RID: 15095
		// (get) Token: 0x0600D312 RID: 54034 RVA: 0x001F4D6E File Offset: 0x001F2F6E
		public virtual string Name
		{
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x17003AF8 RID: 15096
		// (get) Token: 0x0600D313 RID: 54035 RVA: 0x001F4D7C File Offset: 0x001F2F7C
		public virtual int? DungeonId
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new int?(this.Instance.DungeonId);
			}
		}

		// Token: 0x17003AF9 RID: 15097
		// (get) Token: 0x0600D314 RID: 54036 RVA: 0x001F4DB4 File Offset: 0x001F2FB4
		public virtual bool? _Folded
		{
			get
			{
				if ((this.Instance.NullMask & 16) == 0)
				{
					return null;
				}
				return new bool?(this.Instance._Folded);
			}
		}

		// Token: 0x17003AFA RID: 15098
		// (get) Token: 0x0600D315 RID: 54037 RVA: 0x001F4DEC File Offset: 0x001F2FEC
		public virtual int? _SelectedStateId
		{
			get
			{
				if ((this.Instance.NullMask & 32) == 0)
				{
					return null;
				}
				return new int?(this.Instance._SelectedStateId);
			}
		}

		// Token: 0x17003AFB RID: 15099
		// (get) Token: 0x0600D316 RID: 54038 RVA: 0x001F4E23 File Offset: 0x001F3023
		public virtual IVarContext VarContext
		{
			get
			{
				if (this._VarContextInited)
				{
					return this._VarContextCache;
				}
				this._VarContextInited = true;
				this._VarContextCache = ActionReadHelper.ReadIFlowInfo_VarContext(this.Instance);
				return this._VarContextCache;
			}
		}

		// Token: 0x17003AFC RID: 15100
		// (get) Token: 0x0600D317 RID: 54039 RVA: 0x001F4E54 File Offset: 0x001F3054
		public virtual List<IStateInfo> States
		{
			get
			{
				if (this._StatesInited)
				{
					return this._StatesCache;
				}
				this._StatesInited = true;
				int statesLength = this.Instance.StatesLength;
				this._StatesCache = new List<IStateInfo>(statesLength);
				for (int i = 0; i < statesLength; i++)
				{
					this._StatesCache.Add(IStateInfo.Create(this.Instance.States(i)));
				}
				return this._StatesCache;
			}
		}

		// Token: 0x17003AFD RID: 15101
		// (get) Token: 0x0600D318 RID: 54040 RVA: 0x001F4EC0 File Offset: 0x001F30C0
		public virtual bool? EdIsReserved
		{
			get
			{
				return null;
			}
		}

		// Token: 0x040073B8 RID: 29624
		private IFlowInfo Instance;

		// Token: 0x040073B9 RID: 29625
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<string> _ChildrenCache;

		// Token: 0x040073BA RID: 29626
		private bool _ChildrenInited;

		// Token: 0x040073BB RID: 29627
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<string> _ReferenceCache;

		// Token: 0x040073BC RID: 29628
		private bool _ReferenceInited;

		// Token: 0x040073BD RID: 29629
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<string> _WeakReferenceCache;

		// Token: 0x040073BE RID: 29630
		private bool _WeakReferenceInited;

		// Token: 0x040073BF RID: 29631
		private IVarContext _VarContextCache;

		// Token: 0x040073C0 RID: 29632
		private bool _VarContextInited;

		// Token: 0x040073C1 RID: 29633
		private List<IStateInfo> _StatesCache;

		// Token: 0x040073C2 RID: 29634
		private bool _StatesInited;
	}
}
