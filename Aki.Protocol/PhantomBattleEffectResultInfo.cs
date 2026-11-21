using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C71 RID: 3185
	public sealed class PhantomBattleEffectResultInfo : IMessage<PhantomBattleEffectResultInfo>, IMessage, IEquatable<PhantomBattleEffectResultInfo>, IDeepCloneable<PhantomBattleEffectResultInfo>, IBufferMessage
	{
		// Token: 0x06011490 RID: 70800 RVA: 0x00288515 File Offset: 0x00286715
		[NullableContext(1)]
		public static PhantomBattleEffectResultInfo Create()
		{
			return new PhantomBattleEffectResultInfo();
		}

		// Token: 0x17003931 RID: 14641
		// (get) Token: 0x06011491 RID: 70801 RVA: 0x0028851C File Offset: 0x0028671C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003932 RID: 14642
		// (get) Token: 0x06011492 RID: 70802 RVA: 0x0028851F File Offset: 0x0028671F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleEffectResultInfo.Descriptor;
			}
		}

		// Token: 0x06011493 RID: 70803 RVA: 0x00288526 File Offset: 0x00286726
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleEffectResultInfo()
		{
		}

		// Token: 0x06011494 RID: 70804 RVA: 0x00288530 File Offset: 0x00286730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleEffectResultInfo(PhantomBattleEffectResultInfo other) : this()
		{
			this.result_ = other.result_;
			switch (other.PhantomBattleResultCtxCase)
			{
			case PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleDealEffectCtx:
				this.PhantomBattleDealEffectCtx = other.PhantomBattleDealEffectCtx.Clone();
				break;
			case PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.NpcPhantomBattleDealEffectCtx:
				this.NpcPhantomBattleDealEffectCtx = other.NpcPhantomBattleDealEffectCtx.Clone();
				break;
			case PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleAddBuffEffectCtx:
				this.PhantomBattleAddBuffEffectCtx = other.PhantomBattleAddBuffEffectCtx.Clone();
				break;
			case PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleCardSelectEffectCtx:
				this.PhantomBattleCardSelectEffectCtx = other.PhantomBattleCardSelectEffectCtx.Clone();
				break;
			case PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.NpcPhantomBattleCardSelectEffectCtx:
				this.NpcPhantomBattleCardSelectEffectCtx = other.NpcPhantomBattleCardSelectEffectCtx.Clone();
				break;
			case PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.NpcPhantomBattleAreaLockEffectCtx:
				this.NpcPhantomBattleAreaLockEffectCtx = other.NpcPhantomBattleAreaLockEffectCtx.Clone();
				break;
			case PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleCopyCardEffectCtx:
				this.PhantomBattleCopyCardEffectCtx = other.PhantomBattleCopyCardEffectCtx.Clone();
				break;
			case PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleDestroyCardEffectCtx:
				this.PhantomBattleDestroyCardEffectCtx = other.PhantomBattleDestroyCardEffectCtx.Clone();
				break;
			case PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleTakeTargetAttrEffectCtx:
				this.PhantomBattleTakeTargetAttrEffectCtx = other.PhantomBattleTakeTargetAttrEffectCtx.Clone();
				break;
			case PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleFactorsEffectCtx:
				this.PhantomBattleFactorsEffectCtx = other.PhantomBattleFactorsEffectCtx.Clone();
				break;
			case PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleCallCardEffectCtx:
				this.PhantomBattleCallCardEffectCtx = other.PhantomBattleCallCardEffectCtx.Clone();
				break;
			case PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleDirectDamage:
				this.PhantomBattleDirectDamage = other.PhantomBattleDirectDamage.Clone();
				break;
			case PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleReconstruct:
				this.PhantomBattleReconstruct = other.PhantomBattleReconstruct.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011495 RID: 70805 RVA: 0x002886B7 File Offset: 0x002868B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleEffectResultInfo Clone()
		{
			return new PhantomBattleEffectResultInfo(this);
		}

		// Token: 0x17003933 RID: 14643
		// (get) Token: 0x06011496 RID: 70806 RVA: 0x002886BF File Offset: 0x002868BF
		// (set) Token: 0x06011497 RID: 70807 RVA: 0x002886C7 File Offset: 0x002868C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Result
		{
			get
			{
				return this.result_;
			}
			set
			{
				this.result_ = value;
			}
		}

		// Token: 0x17003934 RID: 14644
		// (get) Token: 0x06011498 RID: 70808 RVA: 0x002886D0 File Offset: 0x002868D0
		// (set) Token: 0x06011499 RID: 70809 RVA: 0x002886E8 File Offset: 0x002868E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDealEffectCtx PhantomBattleDealEffectCtx
		{
			get
			{
				if (this.phantomBattleResultCtxCase_ != PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleDealEffectCtx)
				{
					return null;
				}
				return (PhantomBattleDealEffectCtx)this.phantomBattleResultCtx_;
			}
			set
			{
				this.phantomBattleResultCtx_ = value;
				this.phantomBattleResultCtxCase_ = ((value == null) ? PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.None : PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleDealEffectCtx);
			}
		}

		// Token: 0x17003935 RID: 14645
		// (get) Token: 0x0601149A RID: 70810 RVA: 0x002886FE File Offset: 0x002868FE
		// (set) Token: 0x0601149B RID: 70811 RVA: 0x00288716 File Offset: 0x00286916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleDealEffectCtx NpcPhantomBattleDealEffectCtx
		{
			get
			{
				if (this.phantomBattleResultCtxCase_ != PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.NpcPhantomBattleDealEffectCtx)
				{
					return null;
				}
				return (NpcPhantomBattleDealEffectCtx)this.phantomBattleResultCtx_;
			}
			set
			{
				this.phantomBattleResultCtx_ = value;
				this.phantomBattleResultCtxCase_ = ((value == null) ? PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.None : PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.NpcPhantomBattleDealEffectCtx);
			}
		}

		// Token: 0x17003936 RID: 14646
		// (get) Token: 0x0601149C RID: 70812 RVA: 0x0028872C File Offset: 0x0028692C
		// (set) Token: 0x0601149D RID: 70813 RVA: 0x00288744 File Offset: 0x00286944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleAddBuffEffectCtx PhantomBattleAddBuffEffectCtx
		{
			get
			{
				if (this.phantomBattleResultCtxCase_ != PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleAddBuffEffectCtx)
				{
					return null;
				}
				return (PhantomBattleAddBuffEffectCtx)this.phantomBattleResultCtx_;
			}
			set
			{
				this.phantomBattleResultCtx_ = value;
				this.phantomBattleResultCtxCase_ = ((value == null) ? PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.None : PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleAddBuffEffectCtx);
			}
		}

		// Token: 0x17003937 RID: 14647
		// (get) Token: 0x0601149E RID: 70814 RVA: 0x0028875A File Offset: 0x0028695A
		// (set) Token: 0x0601149F RID: 70815 RVA: 0x00288772 File Offset: 0x00286972
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardSelectEffectCtx PhantomBattleCardSelectEffectCtx
		{
			get
			{
				if (this.phantomBattleResultCtxCase_ != PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleCardSelectEffectCtx)
				{
					return null;
				}
				return (PhantomBattleCardSelectEffectCtx)this.phantomBattleResultCtx_;
			}
			set
			{
				this.phantomBattleResultCtx_ = value;
				this.phantomBattleResultCtxCase_ = ((value == null) ? PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.None : PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleCardSelectEffectCtx);
			}
		}

		// Token: 0x17003938 RID: 14648
		// (get) Token: 0x060114A0 RID: 70816 RVA: 0x00288788 File Offset: 0x00286988
		// (set) Token: 0x060114A1 RID: 70817 RVA: 0x002887A0 File Offset: 0x002869A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleCardSelectEffectCtx NpcPhantomBattleCardSelectEffectCtx
		{
			get
			{
				if (this.phantomBattleResultCtxCase_ != PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.NpcPhantomBattleCardSelectEffectCtx)
				{
					return null;
				}
				return (NpcPhantomBattleCardSelectEffectCtx)this.phantomBattleResultCtx_;
			}
			set
			{
				this.phantomBattleResultCtx_ = value;
				this.phantomBattleResultCtxCase_ = ((value == null) ? PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.None : PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.NpcPhantomBattleCardSelectEffectCtx);
			}
		}

		// Token: 0x17003939 RID: 14649
		// (get) Token: 0x060114A2 RID: 70818 RVA: 0x002887B6 File Offset: 0x002869B6
		// (set) Token: 0x060114A3 RID: 70819 RVA: 0x002887CE File Offset: 0x002869CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleAreaLockEffectCtx NpcPhantomBattleAreaLockEffectCtx
		{
			get
			{
				if (this.phantomBattleResultCtxCase_ != PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.NpcPhantomBattleAreaLockEffectCtx)
				{
					return null;
				}
				return (NpcPhantomBattleAreaLockEffectCtx)this.phantomBattleResultCtx_;
			}
			set
			{
				this.phantomBattleResultCtx_ = value;
				this.phantomBattleResultCtxCase_ = ((value == null) ? PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.None : PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.NpcPhantomBattleAreaLockEffectCtx);
			}
		}

		// Token: 0x1700393A RID: 14650
		// (get) Token: 0x060114A4 RID: 70820 RVA: 0x002887E4 File Offset: 0x002869E4
		// (set) Token: 0x060114A5 RID: 70821 RVA: 0x002887FD File Offset: 0x002869FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCopyCardEffectCtx PhantomBattleCopyCardEffectCtx
		{
			get
			{
				if (this.phantomBattleResultCtxCase_ != PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleCopyCardEffectCtx)
				{
					return null;
				}
				return (PhantomBattleCopyCardEffectCtx)this.phantomBattleResultCtx_;
			}
			set
			{
				this.phantomBattleResultCtx_ = value;
				this.phantomBattleResultCtxCase_ = ((value == null) ? PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.None : PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleCopyCardEffectCtx);
			}
		}

		// Token: 0x1700393B RID: 14651
		// (get) Token: 0x060114A6 RID: 70822 RVA: 0x00288814 File Offset: 0x00286A14
		// (set) Token: 0x060114A7 RID: 70823 RVA: 0x0028882D File Offset: 0x00286A2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDestroyCardEffectCtx PhantomBattleDestroyCardEffectCtx
		{
			get
			{
				if (this.phantomBattleResultCtxCase_ != PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleDestroyCardEffectCtx)
				{
					return null;
				}
				return (PhantomBattleDestroyCardEffectCtx)this.phantomBattleResultCtx_;
			}
			set
			{
				this.phantomBattleResultCtx_ = value;
				this.phantomBattleResultCtxCase_ = ((value == null) ? PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.None : PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleDestroyCardEffectCtx);
			}
		}

		// Token: 0x1700393C RID: 14652
		// (get) Token: 0x060114A8 RID: 70824 RVA: 0x00288844 File Offset: 0x00286A44
		// (set) Token: 0x060114A9 RID: 70825 RVA: 0x0028885D File Offset: 0x00286A5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleTakeTargetAttrEffectCtx PhantomBattleTakeTargetAttrEffectCtx
		{
			get
			{
				if (this.phantomBattleResultCtxCase_ != PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleTakeTargetAttrEffectCtx)
				{
					return null;
				}
				return (PhantomBattleTakeTargetAttrEffectCtx)this.phantomBattleResultCtx_;
			}
			set
			{
				this.phantomBattleResultCtx_ = value;
				this.phantomBattleResultCtxCase_ = ((value == null) ? PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.None : PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleTakeTargetAttrEffectCtx);
			}
		}

		// Token: 0x1700393D RID: 14653
		// (get) Token: 0x060114AA RID: 70826 RVA: 0x00288874 File Offset: 0x00286A74
		// (set) Token: 0x060114AB RID: 70827 RVA: 0x0028888D File Offset: 0x00286A8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleFactorsEffectCtx PhantomBattleFactorsEffectCtx
		{
			get
			{
				if (this.phantomBattleResultCtxCase_ != PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleFactorsEffectCtx)
				{
					return null;
				}
				return (PhantomBattleFactorsEffectCtx)this.phantomBattleResultCtx_;
			}
			set
			{
				this.phantomBattleResultCtx_ = value;
				this.phantomBattleResultCtxCase_ = ((value == null) ? PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.None : PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleFactorsEffectCtx);
			}
		}

		// Token: 0x1700393E RID: 14654
		// (get) Token: 0x060114AC RID: 70828 RVA: 0x002888A4 File Offset: 0x00286AA4
		// (set) Token: 0x060114AD RID: 70829 RVA: 0x002888BD File Offset: 0x00286ABD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCallCardEffectCtx PhantomBattleCallCardEffectCtx
		{
			get
			{
				if (this.phantomBattleResultCtxCase_ != PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleCallCardEffectCtx)
				{
					return null;
				}
				return (PhantomBattleCallCardEffectCtx)this.phantomBattleResultCtx_;
			}
			set
			{
				this.phantomBattleResultCtx_ = value;
				this.phantomBattleResultCtxCase_ = ((value == null) ? PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.None : PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleCallCardEffectCtx);
			}
		}

		// Token: 0x1700393F RID: 14655
		// (get) Token: 0x060114AE RID: 70830 RVA: 0x002888D4 File Offset: 0x00286AD4
		// (set) Token: 0x060114AF RID: 70831 RVA: 0x002888ED File Offset: 0x00286AED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDirectDamage PhantomBattleDirectDamage
		{
			get
			{
				if (this.phantomBattleResultCtxCase_ != PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleDirectDamage)
				{
					return null;
				}
				return (PhantomBattleDirectDamage)this.phantomBattleResultCtx_;
			}
			set
			{
				this.phantomBattleResultCtx_ = value;
				this.phantomBattleResultCtxCase_ = ((value == null) ? PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.None : PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleDirectDamage);
			}
		}

		// Token: 0x17003940 RID: 14656
		// (get) Token: 0x060114B0 RID: 70832 RVA: 0x00288904 File Offset: 0x00286B04
		// (set) Token: 0x060114B1 RID: 70833 RVA: 0x0028891D File Offset: 0x00286B1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleReconstruct PhantomBattleReconstruct
		{
			get
			{
				if (this.phantomBattleResultCtxCase_ != PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleReconstruct)
				{
					return null;
				}
				return (PhantomBattleReconstruct)this.phantomBattleResultCtx_;
			}
			set
			{
				this.phantomBattleResultCtx_ = value;
				this.phantomBattleResultCtxCase_ = ((value == null) ? PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.None : PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleReconstruct);
			}
		}

		// Token: 0x17003941 RID: 14657
		// (get) Token: 0x060114B2 RID: 70834 RVA: 0x00288934 File Offset: 0x00286B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase PhantomBattleResultCtxCase
		{
			get
			{
				return this.phantomBattleResultCtxCase_;
			}
		}

		// Token: 0x060114B3 RID: 70835 RVA: 0x0028893C File Offset: 0x00286B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearPhantomBattleResultCtx()
		{
			this.phantomBattleResultCtxCase_ = PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.None;
			this.phantomBattleResultCtx_ = null;
		}

		// Token: 0x060114B4 RID: 70836 RVA: 0x0028894C File Offset: 0x00286B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleEffectResultInfo);
		}

		// Token: 0x060114B5 RID: 70837 RVA: 0x0028895C File Offset: 0x00286B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleEffectResultInfo other)
		{
			return other != null && (other == this || (this.Result == other.Result && object.Equals(this.PhantomBattleDealEffectCtx, other.PhantomBattleDealEffectCtx) && object.Equals(this.NpcPhantomBattleDealEffectCtx, other.NpcPhantomBattleDealEffectCtx) && object.Equals(this.PhantomBattleAddBuffEffectCtx, other.PhantomBattleAddBuffEffectCtx) && object.Equals(this.PhantomBattleCardSelectEffectCtx, other.PhantomBattleCardSelectEffectCtx) && object.Equals(this.NpcPhantomBattleCardSelectEffectCtx, other.NpcPhantomBattleCardSelectEffectCtx) && object.Equals(this.NpcPhantomBattleAreaLockEffectCtx, other.NpcPhantomBattleAreaLockEffectCtx) && object.Equals(this.PhantomBattleCopyCardEffectCtx, other.PhantomBattleCopyCardEffectCtx) && object.Equals(this.PhantomBattleDestroyCardEffectCtx, other.PhantomBattleDestroyCardEffectCtx) && object.Equals(this.PhantomBattleTakeTargetAttrEffectCtx, other.PhantomBattleTakeTargetAttrEffectCtx) && object.Equals(this.PhantomBattleFactorsEffectCtx, other.PhantomBattleFactorsEffectCtx) && object.Equals(this.PhantomBattleCallCardEffectCtx, other.PhantomBattleCallCardEffectCtx) && object.Equals(this.PhantomBattleDirectDamage, other.PhantomBattleDirectDamage) && object.Equals(this.PhantomBattleReconstruct, other.PhantomBattleReconstruct) && this.PhantomBattleResultCtxCase == other.PhantomBattleResultCtxCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060114B6 RID: 70838 RVA: 0x00288AB8 File Offset: 0x00286CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Result != ErrorCode.Success)
			{
				num ^= this.Result.GetHashCode();
			}
			if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleDealEffectCtx)
			{
				num ^= this.PhantomBattleDealEffectCtx.GetHashCode();
			}
			if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.NpcPhantomBattleDealEffectCtx)
			{
				num ^= this.NpcPhantomBattleDealEffectCtx.GetHashCode();
			}
			if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleAddBuffEffectCtx)
			{
				num ^= this.PhantomBattleAddBuffEffectCtx.GetHashCode();
			}
			if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleCardSelectEffectCtx)
			{
				num ^= this.PhantomBattleCardSelectEffectCtx.GetHashCode();
			}
			if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.NpcPhantomBattleCardSelectEffectCtx)
			{
				num ^= this.NpcPhantomBattleCardSelectEffectCtx.GetHashCode();
			}
			if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.NpcPhantomBattleAreaLockEffectCtx)
			{
				num ^= this.NpcPhantomBattleAreaLockEffectCtx.GetHashCode();
			}
			if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleCopyCardEffectCtx)
			{
				num ^= this.PhantomBattleCopyCardEffectCtx.GetHashCode();
			}
			if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleDestroyCardEffectCtx)
			{
				num ^= this.PhantomBattleDestroyCardEffectCtx.GetHashCode();
			}
			if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleTakeTargetAttrEffectCtx)
			{
				num ^= this.PhantomBattleTakeTargetAttrEffectCtx.GetHashCode();
			}
			if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleFactorsEffectCtx)
			{
				num ^= this.PhantomBattleFactorsEffectCtx.GetHashCode();
			}
			if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleCallCardEffectCtx)
			{
				num ^= this.PhantomBattleCallCardEffectCtx.GetHashCode();
			}
			if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleDirectDamage)
			{
				num ^= this.PhantomBattleDirectDamage.GetHashCode();
			}
			if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleReconstruct)
			{
				num ^= this.PhantomBattleReconstruct.GetHashCode();
			}
			num ^= (int)this.phantomBattleResultCtxCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060114B7 RID: 70839 RVA: 0x00288C38 File Offset: 0x00286E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060114B8 RID: 70840 RVA: 0x00288C45 File Offset: 0x00286E45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060114B9 RID: 70841 RVA: 0x00288C50 File Offset: 0x00286E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleDealEffectCtx)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.PhantomBattleDealEffectCtx);
			}
			if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.NpcPhantomBattleDealEffectCtx)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.NpcPhantomBattleDealEffectCtx);
			}
			if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleAddBuffEffectCtx)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.PhantomBattleAddBuffEffectCtx);
			}
			if (this.Result != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Result);
			}
			if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleCardSelectEffectCtx)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.PhantomBattleCardSelectEffectCtx);
			}
			if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.NpcPhantomBattleCardSelectEffectCtx)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.NpcPhantomBattleCardSelectEffectCtx);
			}
			if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.NpcPhantomBattleAreaLockEffectCtx)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.NpcPhantomBattleAreaLockEffectCtx);
			}
			if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleCopyCardEffectCtx)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.PhantomBattleCopyCardEffectCtx);
			}
			if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleDestroyCardEffectCtx)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.PhantomBattleDestroyCardEffectCtx);
			}
			if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleTakeTargetAttrEffectCtx)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.PhantomBattleTakeTargetAttrEffectCtx);
			}
			if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleFactorsEffectCtx)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.PhantomBattleFactorsEffectCtx);
			}
			if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleCallCardEffectCtx)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.PhantomBattleCallCardEffectCtx);
			}
			if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleDirectDamage)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.PhantomBattleDirectDamage);
			}
			if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleReconstruct)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.PhantomBattleReconstruct);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060114BA RID: 70842 RVA: 0x00288E10 File Offset: 0x00287010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Result != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Result);
			}
			if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleDealEffectCtx)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleDealEffectCtx);
			}
			if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.NpcPhantomBattleDealEffectCtx)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NpcPhantomBattleDealEffectCtx);
			}
			if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleAddBuffEffectCtx)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleAddBuffEffectCtx);
			}
			if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleCardSelectEffectCtx)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleCardSelectEffectCtx);
			}
			if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.NpcPhantomBattleCardSelectEffectCtx)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NpcPhantomBattleCardSelectEffectCtx);
			}
			if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.NpcPhantomBattleAreaLockEffectCtx)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NpcPhantomBattleAreaLockEffectCtx);
			}
			if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleCopyCardEffectCtx)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleCopyCardEffectCtx);
			}
			if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleDestroyCardEffectCtx)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleDestroyCardEffectCtx);
			}
			if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleTakeTargetAttrEffectCtx)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleTakeTargetAttrEffectCtx);
			}
			if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleFactorsEffectCtx)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleFactorsEffectCtx);
			}
			if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleCallCardEffectCtx)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleCallCardEffectCtx);
			}
			if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleDirectDamage)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleDirectDamage);
			}
			if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleReconstruct)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleReconstruct);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060114BB RID: 70843 RVA: 0x00288F9C File Offset: 0x0028719C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleEffectResultInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Result != ErrorCode.Success)
			{
				this.Result = other.Result;
			}
			switch (other.PhantomBattleResultCtxCase)
			{
			case PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleDealEffectCtx:
				if (this.PhantomBattleDealEffectCtx == null)
				{
					this.PhantomBattleDealEffectCtx = new PhantomBattleDealEffectCtx();
				}
				this.PhantomBattleDealEffectCtx.MergeFrom(other.PhantomBattleDealEffectCtx);
				break;
			case PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.NpcPhantomBattleDealEffectCtx:
				if (this.NpcPhantomBattleDealEffectCtx == null)
				{
					this.NpcPhantomBattleDealEffectCtx = new NpcPhantomBattleDealEffectCtx();
				}
				this.NpcPhantomBattleDealEffectCtx.MergeFrom(other.NpcPhantomBattleDealEffectCtx);
				break;
			case PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleAddBuffEffectCtx:
				if (this.PhantomBattleAddBuffEffectCtx == null)
				{
					this.PhantomBattleAddBuffEffectCtx = new PhantomBattleAddBuffEffectCtx();
				}
				this.PhantomBattleAddBuffEffectCtx.MergeFrom(other.PhantomBattleAddBuffEffectCtx);
				break;
			case PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleCardSelectEffectCtx:
				if (this.PhantomBattleCardSelectEffectCtx == null)
				{
					this.PhantomBattleCardSelectEffectCtx = new PhantomBattleCardSelectEffectCtx();
				}
				this.PhantomBattleCardSelectEffectCtx.MergeFrom(other.PhantomBattleCardSelectEffectCtx);
				break;
			case PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.NpcPhantomBattleCardSelectEffectCtx:
				if (this.NpcPhantomBattleCardSelectEffectCtx == null)
				{
					this.NpcPhantomBattleCardSelectEffectCtx = new NpcPhantomBattleCardSelectEffectCtx();
				}
				this.NpcPhantomBattleCardSelectEffectCtx.MergeFrom(other.NpcPhantomBattleCardSelectEffectCtx);
				break;
			case PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.NpcPhantomBattleAreaLockEffectCtx:
				if (this.NpcPhantomBattleAreaLockEffectCtx == null)
				{
					this.NpcPhantomBattleAreaLockEffectCtx = new NpcPhantomBattleAreaLockEffectCtx();
				}
				this.NpcPhantomBattleAreaLockEffectCtx.MergeFrom(other.NpcPhantomBattleAreaLockEffectCtx);
				break;
			case PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleCopyCardEffectCtx:
				if (this.PhantomBattleCopyCardEffectCtx == null)
				{
					this.PhantomBattleCopyCardEffectCtx = new PhantomBattleCopyCardEffectCtx();
				}
				this.PhantomBattleCopyCardEffectCtx.MergeFrom(other.PhantomBattleCopyCardEffectCtx);
				break;
			case PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleDestroyCardEffectCtx:
				if (this.PhantomBattleDestroyCardEffectCtx == null)
				{
					this.PhantomBattleDestroyCardEffectCtx = new PhantomBattleDestroyCardEffectCtx();
				}
				this.PhantomBattleDestroyCardEffectCtx.MergeFrom(other.PhantomBattleDestroyCardEffectCtx);
				break;
			case PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleTakeTargetAttrEffectCtx:
				if (this.PhantomBattleTakeTargetAttrEffectCtx == null)
				{
					this.PhantomBattleTakeTargetAttrEffectCtx = new PhantomBattleTakeTargetAttrEffectCtx();
				}
				this.PhantomBattleTakeTargetAttrEffectCtx.MergeFrom(other.PhantomBattleTakeTargetAttrEffectCtx);
				break;
			case PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleFactorsEffectCtx:
				if (this.PhantomBattleFactorsEffectCtx == null)
				{
					this.PhantomBattleFactorsEffectCtx = new PhantomBattleFactorsEffectCtx();
				}
				this.PhantomBattleFactorsEffectCtx.MergeFrom(other.PhantomBattleFactorsEffectCtx);
				break;
			case PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleCallCardEffectCtx:
				if (this.PhantomBattleCallCardEffectCtx == null)
				{
					this.PhantomBattleCallCardEffectCtx = new PhantomBattleCallCardEffectCtx();
				}
				this.PhantomBattleCallCardEffectCtx.MergeFrom(other.PhantomBattleCallCardEffectCtx);
				break;
			case PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleDirectDamage:
				if (this.PhantomBattleDirectDamage == null)
				{
					this.PhantomBattleDirectDamage = new PhantomBattleDirectDamage();
				}
				this.PhantomBattleDirectDamage.MergeFrom(other.PhantomBattleDirectDamage);
				break;
			case PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleReconstruct:
				if (this.PhantomBattleReconstruct == null)
				{
					this.PhantomBattleReconstruct = new PhantomBattleReconstruct();
				}
				this.PhantomBattleReconstruct.MergeFrom(other.PhantomBattleReconstruct);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060114BC RID: 70844 RVA: 0x0028922F File Offset: 0x0028742F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060114BD RID: 70845 RVA: 0x00289238 File Offset: 0x00287438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num <= 58U)
				{
					if (num <= 26U)
					{
						if (num == 10U)
						{
							PhantomBattleDealEffectCtx phantomBattleDealEffectCtx = new PhantomBattleDealEffectCtx();
							if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleDealEffectCtx)
							{
								phantomBattleDealEffectCtx.MergeFrom(this.PhantomBattleDealEffectCtx);
							}
							input.ReadMessage(phantomBattleDealEffectCtx);
							this.PhantomBattleDealEffectCtx = phantomBattleDealEffectCtx;
							continue;
						}
						if (num == 18U)
						{
							NpcPhantomBattleDealEffectCtx npcPhantomBattleDealEffectCtx = new NpcPhantomBattleDealEffectCtx();
							if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.NpcPhantomBattleDealEffectCtx)
							{
								npcPhantomBattleDealEffectCtx.MergeFrom(this.NpcPhantomBattleDealEffectCtx);
							}
							input.ReadMessage(npcPhantomBattleDealEffectCtx);
							this.NpcPhantomBattleDealEffectCtx = npcPhantomBattleDealEffectCtx;
							continue;
						}
						if (num == 26U)
						{
							PhantomBattleAddBuffEffectCtx phantomBattleAddBuffEffectCtx = new PhantomBattleAddBuffEffectCtx();
							if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleAddBuffEffectCtx)
							{
								phantomBattleAddBuffEffectCtx.MergeFrom(this.PhantomBattleAddBuffEffectCtx);
							}
							input.ReadMessage(phantomBattleAddBuffEffectCtx);
							this.PhantomBattleAddBuffEffectCtx = phantomBattleAddBuffEffectCtx;
							continue;
						}
					}
					else if (num <= 42U)
					{
						if (num == 32U)
						{
							this.Result = (ErrorCode)input.ReadEnum();
							continue;
						}
						if (num == 42U)
						{
							PhantomBattleCardSelectEffectCtx phantomBattleCardSelectEffectCtx = new PhantomBattleCardSelectEffectCtx();
							if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleCardSelectEffectCtx)
							{
								phantomBattleCardSelectEffectCtx.MergeFrom(this.PhantomBattleCardSelectEffectCtx);
							}
							input.ReadMessage(phantomBattleCardSelectEffectCtx);
							this.PhantomBattleCardSelectEffectCtx = phantomBattleCardSelectEffectCtx;
							continue;
						}
					}
					else
					{
						if (num == 50U)
						{
							NpcPhantomBattleCardSelectEffectCtx npcPhantomBattleCardSelectEffectCtx = new NpcPhantomBattleCardSelectEffectCtx();
							if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.NpcPhantomBattleCardSelectEffectCtx)
							{
								npcPhantomBattleCardSelectEffectCtx.MergeFrom(this.NpcPhantomBattleCardSelectEffectCtx);
							}
							input.ReadMessage(npcPhantomBattleCardSelectEffectCtx);
							this.NpcPhantomBattleCardSelectEffectCtx = npcPhantomBattleCardSelectEffectCtx;
							continue;
						}
						if (num == 58U)
						{
							NpcPhantomBattleAreaLockEffectCtx npcPhantomBattleAreaLockEffectCtx = new NpcPhantomBattleAreaLockEffectCtx();
							if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.NpcPhantomBattleAreaLockEffectCtx)
							{
								npcPhantomBattleAreaLockEffectCtx.MergeFrom(this.NpcPhantomBattleAreaLockEffectCtx);
							}
							input.ReadMessage(npcPhantomBattleAreaLockEffectCtx);
							this.NpcPhantomBattleAreaLockEffectCtx = npcPhantomBattleAreaLockEffectCtx;
							continue;
						}
					}
				}
				else if (num <= 90U)
				{
					if (num == 74U)
					{
						PhantomBattleCopyCardEffectCtx phantomBattleCopyCardEffectCtx = new PhantomBattleCopyCardEffectCtx();
						if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleCopyCardEffectCtx)
						{
							phantomBattleCopyCardEffectCtx.MergeFrom(this.PhantomBattleCopyCardEffectCtx);
						}
						input.ReadMessage(phantomBattleCopyCardEffectCtx);
						this.PhantomBattleCopyCardEffectCtx = phantomBattleCopyCardEffectCtx;
						continue;
					}
					if (num == 82U)
					{
						PhantomBattleDestroyCardEffectCtx phantomBattleDestroyCardEffectCtx = new PhantomBattleDestroyCardEffectCtx();
						if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleDestroyCardEffectCtx)
						{
							phantomBattleDestroyCardEffectCtx.MergeFrom(this.PhantomBattleDestroyCardEffectCtx);
						}
						input.ReadMessage(phantomBattleDestroyCardEffectCtx);
						this.PhantomBattleDestroyCardEffectCtx = phantomBattleDestroyCardEffectCtx;
						continue;
					}
					if (num == 90U)
					{
						PhantomBattleTakeTargetAttrEffectCtx phantomBattleTakeTargetAttrEffectCtx = new PhantomBattleTakeTargetAttrEffectCtx();
						if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleTakeTargetAttrEffectCtx)
						{
							phantomBattleTakeTargetAttrEffectCtx.MergeFrom(this.PhantomBattleTakeTargetAttrEffectCtx);
						}
						input.ReadMessage(phantomBattleTakeTargetAttrEffectCtx);
						this.PhantomBattleTakeTargetAttrEffectCtx = phantomBattleTakeTargetAttrEffectCtx;
						continue;
					}
				}
				else if (num <= 106U)
				{
					if (num == 98U)
					{
						PhantomBattleFactorsEffectCtx phantomBattleFactorsEffectCtx = new PhantomBattleFactorsEffectCtx();
						if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleFactorsEffectCtx)
						{
							phantomBattleFactorsEffectCtx.MergeFrom(this.PhantomBattleFactorsEffectCtx);
						}
						input.ReadMessage(phantomBattleFactorsEffectCtx);
						this.PhantomBattleFactorsEffectCtx = phantomBattleFactorsEffectCtx;
						continue;
					}
					if (num == 106U)
					{
						PhantomBattleCallCardEffectCtx phantomBattleCallCardEffectCtx = new PhantomBattleCallCardEffectCtx();
						if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleCallCardEffectCtx)
						{
							phantomBattleCallCardEffectCtx.MergeFrom(this.PhantomBattleCallCardEffectCtx);
						}
						input.ReadMessage(phantomBattleCallCardEffectCtx);
						this.PhantomBattleCallCardEffectCtx = phantomBattleCallCardEffectCtx;
						continue;
					}
				}
				else
				{
					if (num == 114U)
					{
						PhantomBattleDirectDamage phantomBattleDirectDamage = new PhantomBattleDirectDamage();
						if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleDirectDamage)
						{
							phantomBattleDirectDamage.MergeFrom(this.PhantomBattleDirectDamage);
						}
						input.ReadMessage(phantomBattleDirectDamage);
						this.PhantomBattleDirectDamage = phantomBattleDirectDamage;
						continue;
					}
					if (num == 122U)
					{
						PhantomBattleReconstruct phantomBattleReconstruct = new PhantomBattleReconstruct();
						if (this.phantomBattleResultCtxCase_ == PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.PhantomBattleReconstruct)
						{
							phantomBattleReconstruct.MergeFrom(this.PhantomBattleReconstruct);
						}
						input.ReadMessage(phantomBattleReconstruct);
						this.PhantomBattleReconstruct = phantomBattleReconstruct;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006DB4 RID: 28084
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006DB5 RID: 28085
		public const int ResultFieldNumber = 4;

		// Token: 0x04006DB6 RID: 28086
		private ErrorCode result_;

		// Token: 0x04006DB7 RID: 28087
		public const int PhantomBattleDealEffectCtxFieldNumber = 1;

		// Token: 0x04006DB8 RID: 28088
		public const int NpcPhantomBattleDealEffectCtxFieldNumber = 2;

		// Token: 0x04006DB9 RID: 28089
		public const int PhantomBattleAddBuffEffectCtxFieldNumber = 3;

		// Token: 0x04006DBA RID: 28090
		public const int PhantomBattleCardSelectEffectCtxFieldNumber = 5;

		// Token: 0x04006DBB RID: 28091
		public const int NpcPhantomBattleCardSelectEffectCtxFieldNumber = 6;

		// Token: 0x04006DBC RID: 28092
		public const int NpcPhantomBattleAreaLockEffectCtxFieldNumber = 7;

		// Token: 0x04006DBD RID: 28093
		public const int PhantomBattleCopyCardEffectCtxFieldNumber = 9;

		// Token: 0x04006DBE RID: 28094
		public const int PhantomBattleDestroyCardEffectCtxFieldNumber = 10;

		// Token: 0x04006DBF RID: 28095
		public const int PhantomBattleTakeTargetAttrEffectCtxFieldNumber = 11;

		// Token: 0x04006DC0 RID: 28096
		public const int PhantomBattleFactorsEffectCtxFieldNumber = 12;

		// Token: 0x04006DC1 RID: 28097
		public const int PhantomBattleCallCardEffectCtxFieldNumber = 13;

		// Token: 0x04006DC2 RID: 28098
		public const int PhantomBattleDirectDamageFieldNumber = 14;

		// Token: 0x04006DC3 RID: 28099
		public const int PhantomBattleReconstructFieldNumber = 15;

		// Token: 0x04006DC4 RID: 28100
		private object phantomBattleResultCtx_;

		// Token: 0x04006DC5 RID: 28101
		private PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase phantomBattleResultCtxCase_;

		// Token: 0x02001927 RID: 6439
		public enum PhantomBattleResultCtxOneofCase
		{
			// Token: 0x0400CDCC RID: 52684
			None,
			// Token: 0x0400CDCD RID: 52685
			PhantomBattleDealEffectCtx,
			// Token: 0x0400CDCE RID: 52686
			NpcPhantomBattleDealEffectCtx,
			// Token: 0x0400CDCF RID: 52687
			PhantomBattleAddBuffEffectCtx,
			// Token: 0x0400CDD0 RID: 52688
			PhantomBattleCardSelectEffectCtx = 5,
			// Token: 0x0400CDD1 RID: 52689
			NpcPhantomBattleCardSelectEffectCtx,
			// Token: 0x0400CDD2 RID: 52690
			NpcPhantomBattleAreaLockEffectCtx,
			// Token: 0x0400CDD3 RID: 52691
			PhantomBattleCopyCardEffectCtx = 9,
			// Token: 0x0400CDD4 RID: 52692
			PhantomBattleDestroyCardEffectCtx,
			// Token: 0x0400CDD5 RID: 52693
			PhantomBattleTakeTargetAttrEffectCtx,
			// Token: 0x0400CDD6 RID: 52694
			PhantomBattleFactorsEffectCtx,
			// Token: 0x0400CDD7 RID: 52695
			PhantomBattleCallCardEffectCtx,
			// Token: 0x0400CDD8 RID: 52696
			PhantomBattleDirectDamage,
			// Token: 0x0400CDD9 RID: 52697
			PhantomBattleReconstruct
		}
	}
}
