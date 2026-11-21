using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.EditorObject.Fb;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002793 RID: 10131
	public class IFlowInfo : IEditorObject
	{
		// Token: 0x0600E05E RID: 57438 RVA: 0x0021045B File Offset: 0x0020E65B
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

		// Token: 0x17003DE6 RID: 15846
		// (get) Token: 0x0600E05F RID: 57439 RVA: 0x0021047A File Offset: 0x0020E67A
		public new virtual string ObjType
		{
			get
			{
				return this.Instance.ObjType;
			}
		}

		// Token: 0x17003DE7 RID: 15847
		// (get) Token: 0x0600E060 RID: 57440 RVA: 0x00210488 File Offset: 0x0020E688
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

		// Token: 0x17003DE8 RID: 15848
		// (get) Token: 0x0600E061 RID: 57441 RVA: 0x00210500 File Offset: 0x0020E700
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

		// Token: 0x17003DE9 RID: 15849
		// (get) Token: 0x0600E062 RID: 57442 RVA: 0x00210578 File Offset: 0x0020E778
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

		// Token: 0x17003DEA RID: 15850
		// (get) Token: 0x0600E063 RID: 57443 RVA: 0x002105ED File Offset: 0x0020E7ED
		[Nullable(2)]
		public override string EdPlannedBranch
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x17003DEB RID: 15851
		// (get) Token: 0x0600E064 RID: 57444 RVA: 0x002105F0 File Offset: 0x0020E7F0
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

		// Token: 0x17003DEC RID: 15852
		// (get) Token: 0x0600E065 RID: 57445 RVA: 0x002105F3 File Offset: 0x0020E7F3
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

		// Token: 0x17003DED RID: 15853
		// (get) Token: 0x0600E066 RID: 57446 RVA: 0x002105F6 File Offset: 0x0020E7F6
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

		// Token: 0x17003DEE RID: 15854
		// (get) Token: 0x0600E067 RID: 57447 RVA: 0x002105F9 File Offset: 0x0020E7F9
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17003DEF RID: 15855
		// (get) Token: 0x0600E068 RID: 57448 RVA: 0x00210606 File Offset: 0x0020E806
		public virtual string Name
		{
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x17003DF0 RID: 15856
		// (get) Token: 0x0600E069 RID: 57449 RVA: 0x00210614 File Offset: 0x0020E814
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

		// Token: 0x17003DF1 RID: 15857
		// (get) Token: 0x0600E06A RID: 57450 RVA: 0x0021064C File Offset: 0x0020E84C
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

		// Token: 0x17003DF2 RID: 15858
		// (get) Token: 0x0600E06B RID: 57451 RVA: 0x00210684 File Offset: 0x0020E884
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

		// Token: 0x17003DF3 RID: 15859
		// (get) Token: 0x0600E06C RID: 57452 RVA: 0x002106BC File Offset: 0x0020E8BC
		[Nullable(2)]
		public virtual List<int> _SelectedStateIds
		{
			[NullableContext(2)]
			get
			{
				if (this.__SelectedStateIdsInited)
				{
					return this.__SelectedStateIdsCache;
				}
				this.__SelectedStateIdsInited = true;
				if ((this.Instance.NullMask & 64) == 0)
				{
					return null;
				}
				int selectedStateIdsLength = this.Instance._SelectedStateIdsLength;
				this.__SelectedStateIdsCache = new List<int>(selectedStateIdsLength);
				for (int i = 0; i < selectedStateIdsLength; i++)
				{
					this.__SelectedStateIdsCache.Add(this.Instance._SelectedStateIds(i));
				}
				return this.__SelectedStateIdsCache;
			}
		}

		// Token: 0x17003DF4 RID: 15860
		// (get) Token: 0x0600E06D RID: 57453 RVA: 0x00210732 File Offset: 0x0020E932
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

		// Token: 0x17003DF5 RID: 15861
		// (get) Token: 0x0600E06E RID: 57454 RVA: 0x00210764 File Offset: 0x0020E964
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

		// Token: 0x17003DF6 RID: 15862
		// (get) Token: 0x0600E06F RID: 57455 RVA: 0x002107D0 File Offset: 0x0020E9D0
		public virtual bool? EdIsReserved
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04007A05 RID: 31237
		private IFlowInfo Instance;

		// Token: 0x04007A06 RID: 31238
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<string> _ChildrenCache;

		// Token: 0x04007A07 RID: 31239
		private bool _ChildrenInited;

		// Token: 0x04007A08 RID: 31240
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<string> _ReferenceCache;

		// Token: 0x04007A09 RID: 31241
		private bool _ReferenceInited;

		// Token: 0x04007A0A RID: 31242
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<string> _WeakReferenceCache;

		// Token: 0x04007A0B RID: 31243
		private bool _WeakReferenceInited;

		// Token: 0x04007A0C RID: 31244
		[Nullable(2)]
		private List<int> __SelectedStateIdsCache;

		// Token: 0x04007A0D RID: 31245
		private bool __SelectedStateIdsInited;

		// Token: 0x04007A0E RID: 31246
		private IVarContext _VarContextCache;

		// Token: 0x04007A0F RID: 31247
		private bool _VarContextInited;

		// Token: 0x04007A10 RID: 31248
		private List<IStateInfo> _StatesCache;

		// Token: 0x04007A11 RID: 31249
		private bool _StatesInited;
	}
}
