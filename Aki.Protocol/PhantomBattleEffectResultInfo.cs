using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C81 RID: 3201
	public sealed class PhantomBattleEffectResultInfo : IMessage<PhantomBattleEffectResultInfo>, IMessage, IEquatable<PhantomBattleEffectResultInfo>, IDeepCloneable<PhantomBattleEffectResultInfo>, IBufferMessage
	{
		// Token: 0x06011590 RID: 71056 RVA: 0x0028A285 File Offset: 0x00288485
		[NullableContext(1)]
		public static PhantomBattleEffectResultInfo Create()
		{
			return new PhantomBattleEffectResultInfo();
		}

		// Token: 0x17003968 RID: 14696
		// (get) Token: 0x06011591 RID: 71057 RVA: 0x0028A28C File Offset: 0x0028848C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003969 RID: 14697
		// (get) Token: 0x06011592 RID: 71058 RVA: 0x0028A28F File Offset: 0x0028848F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleEffectResultInfo.Descriptor;
			}
		}

		// Token: 0x06011593 RID: 71059 RVA: 0x0028A296 File Offset: 0x00288496
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleEffectResultInfo()
		{
		}

		// Token: 0x06011594 RID: 71060 RVA: 0x0028A2A0 File Offset: 0x002884A0
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

		// Token: 0x06011595 RID: 71061 RVA: 0x0028A427 File Offset: 0x00288627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleEffectResultInfo Clone()
		{
			return new PhantomBattleEffectResultInfo(this);
		}

		// Token: 0x1700396A RID: 14698
		// (get) Token: 0x06011596 RID: 71062 RVA: 0x0028A42F File Offset: 0x0028862F
		// (set) Token: 0x06011597 RID: 71063 RVA: 0x0028A437 File Offset: 0x00288637
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

		// Token: 0x1700396B RID: 14699
		// (get) Token: 0x06011598 RID: 71064 RVA: 0x0028A440 File Offset: 0x00288640
		// (set) Token: 0x06011599 RID: 71065 RVA: 0x0028A458 File Offset: 0x00288658
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

		// Token: 0x1700396C RID: 14700
		// (get) Token: 0x0601159A RID: 71066 RVA: 0x0028A46E File Offset: 0x0028866E
		// (set) Token: 0x0601159B RID: 71067 RVA: 0x0028A486 File Offset: 0x00288686
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

		// Token: 0x1700396D RID: 14701
		// (get) Token: 0x0601159C RID: 71068 RVA: 0x0028A49C File Offset: 0x0028869C
		// (set) Token: 0x0601159D RID: 71069 RVA: 0x0028A4B4 File Offset: 0x002886B4
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

		// Token: 0x1700396E RID: 14702
		// (get) Token: 0x0601159E RID: 71070 RVA: 0x0028A4CA File Offset: 0x002886CA
		// (set) Token: 0x0601159F RID: 71071 RVA: 0x0028A4E2 File Offset: 0x002886E2
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

		// Token: 0x1700396F RID: 14703
		// (get) Token: 0x060115A0 RID: 71072 RVA: 0x0028A4F8 File Offset: 0x002886F8
		// (set) Token: 0x060115A1 RID: 71073 RVA: 0x0028A510 File Offset: 0x00288710
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

		// Token: 0x17003970 RID: 14704
		// (get) Token: 0x060115A2 RID: 71074 RVA: 0x0028A526 File Offset: 0x00288726
		// (set) Token: 0x060115A3 RID: 71075 RVA: 0x0028A53E File Offset: 0x0028873E
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

		// Token: 0x17003971 RID: 14705
		// (get) Token: 0x060115A4 RID: 71076 RVA: 0x0028A554 File Offset: 0x00288754
		// (set) Token: 0x060115A5 RID: 71077 RVA: 0x0028A56D File Offset: 0x0028876D
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

		// Token: 0x17003972 RID: 14706
		// (get) Token: 0x060115A6 RID: 71078 RVA: 0x0028A584 File Offset: 0x00288784
		// (set) Token: 0x060115A7 RID: 71079 RVA: 0x0028A59D File Offset: 0x0028879D
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

		// Token: 0x17003973 RID: 14707
		// (get) Token: 0x060115A8 RID: 71080 RVA: 0x0028A5B4 File Offset: 0x002887B4
		// (set) Token: 0x060115A9 RID: 71081 RVA: 0x0028A5CD File Offset: 0x002887CD
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

		// Token: 0x17003974 RID: 14708
		// (get) Token: 0x060115AA RID: 71082 RVA: 0x0028A5E4 File Offset: 0x002887E4
		// (set) Token: 0x060115AB RID: 71083 RVA: 0x0028A5FD File Offset: 0x002887FD
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

		// Token: 0x17003975 RID: 14709
		// (get) Token: 0x060115AC RID: 71084 RVA: 0x0028A614 File Offset: 0x00288814
		// (set) Token: 0x060115AD RID: 71085 RVA: 0x0028A62D File Offset: 0x0028882D
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

		// Token: 0x17003976 RID: 14710
		// (get) Token: 0x060115AE RID: 71086 RVA: 0x0028A644 File Offset: 0x00288844
		// (set) Token: 0x060115AF RID: 71087 RVA: 0x0028A65D File Offset: 0x0028885D
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

		// Token: 0x17003977 RID: 14711
		// (get) Token: 0x060115B0 RID: 71088 RVA: 0x0028A674 File Offset: 0x00288874
		// (set) Token: 0x060115B1 RID: 71089 RVA: 0x0028A68D File Offset: 0x0028888D
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

		// Token: 0x17003978 RID: 14712
		// (get) Token: 0x060115B2 RID: 71090 RVA: 0x0028A6A4 File Offset: 0x002888A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase PhantomBattleResultCtxCase
		{
			get
			{
				return this.phantomBattleResultCtxCase_;
			}
		}

		// Token: 0x060115B3 RID: 71091 RVA: 0x0028A6AC File Offset: 0x002888AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearPhantomBattleResultCtx()
		{
			this.phantomBattleResultCtxCase_ = PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase.None;
			this.phantomBattleResultCtx_ = null;
		}

		// Token: 0x060115B4 RID: 71092 RVA: 0x0028A6BC File Offset: 0x002888BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleEffectResultInfo);
		}

		// Token: 0x060115B5 RID: 71093 RVA: 0x0028A6CC File Offset: 0x002888CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleEffectResultInfo other)
		{
			return other != null && (other == this || (this.Result == other.Result && object.Equals(this.PhantomBattleDealEffectCtx, other.PhantomBattleDealEffectCtx) && object.Equals(this.NpcPhantomBattleDealEffectCtx, other.NpcPhantomBattleDealEffectCtx) && object.Equals(this.PhantomBattleAddBuffEffectCtx, other.PhantomBattleAddBuffEffectCtx) && object.Equals(this.PhantomBattleCardSelectEffectCtx, other.PhantomBattleCardSelectEffectCtx) && object.Equals(this.NpcPhantomBattleCardSelectEffectCtx, other.NpcPhantomBattleCardSelectEffectCtx) && object.Equals(this.NpcPhantomBattleAreaLockEffectCtx, other.NpcPhantomBattleAreaLockEffectCtx) && object.Equals(this.PhantomBattleCopyCardEffectCtx, other.PhantomBattleCopyCardEffectCtx) && object.Equals(this.PhantomBattleDestroyCardEffectCtx, other.PhantomBattleDestroyCardEffectCtx) && object.Equals(this.PhantomBattleTakeTargetAttrEffectCtx, other.PhantomBattleTakeTargetAttrEffectCtx) && object.Equals(this.PhantomBattleFactorsEffectCtx, other.PhantomBattleFactorsEffectCtx) && object.Equals(this.PhantomBattleCallCardEffectCtx, other.PhantomBattleCallCardEffectCtx) && object.Equals(this.PhantomBattleDirectDamage, other.PhantomBattleDirectDamage) && object.Equals(this.PhantomBattleReconstruct, other.PhantomBattleReconstruct) && this.PhantomBattleResultCtxCase == other.PhantomBattleResultCtxCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060115B6 RID: 71094 RVA: 0x0028A828 File Offset: 0x00288A28
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

		// Token: 0x060115B7 RID: 71095 RVA: 0x0028A9A8 File Offset: 0x00288BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060115B8 RID: 71096 RVA: 0x0028A9B5 File Offset: 0x00288BB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060115B9 RID: 71097 RVA: 0x0028A9C0 File Offset: 0x00288BC0
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

		// Token: 0x060115BA RID: 71098 RVA: 0x0028AB80 File Offset: 0x00288D80
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

		// Token: 0x060115BB RID: 71099 RVA: 0x0028AD0C File Offset: 0x00288F0C
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

		// Token: 0x060115BC RID: 71100 RVA: 0x0028AF9F File Offset: 0x0028919F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060115BD RID: 71101 RVA: 0x0028AFA8 File Offset: 0x002891A8
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

		// Token: 0x04006DA0 RID: 28064
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006DA1 RID: 28065
		public const int ResultFieldNumber = 4;

		// Token: 0x04006DA2 RID: 28066
		private ErrorCode result_;

		// Token: 0x04006DA3 RID: 28067
		public const int PhantomBattleDealEffectCtxFieldNumber = 1;

		// Token: 0x04006DA4 RID: 28068
		public const int NpcPhantomBattleDealEffectCtxFieldNumber = 2;

		// Token: 0x04006DA5 RID: 28069
		public const int PhantomBattleAddBuffEffectCtxFieldNumber = 3;

		// Token: 0x04006DA6 RID: 28070
		public const int PhantomBattleCardSelectEffectCtxFieldNumber = 5;

		// Token: 0x04006DA7 RID: 28071
		public const int NpcPhantomBattleCardSelectEffectCtxFieldNumber = 6;

		// Token: 0x04006DA8 RID: 28072
		public const int NpcPhantomBattleAreaLockEffectCtxFieldNumber = 7;

		// Token: 0x04006DA9 RID: 28073
		public const int PhantomBattleCopyCardEffectCtxFieldNumber = 9;

		// Token: 0x04006DAA RID: 28074
		public const int PhantomBattleDestroyCardEffectCtxFieldNumber = 10;

		// Token: 0x04006DAB RID: 28075
		public const int PhantomBattleTakeTargetAttrEffectCtxFieldNumber = 11;

		// Token: 0x04006DAC RID: 28076
		public const int PhantomBattleFactorsEffectCtxFieldNumber = 12;

		// Token: 0x04006DAD RID: 28077
		public const int PhantomBattleCallCardEffectCtxFieldNumber = 13;

		// Token: 0x04006DAE RID: 28078
		public const int PhantomBattleDirectDamageFieldNumber = 14;

		// Token: 0x04006DAF RID: 28079
		public const int PhantomBattleReconstructFieldNumber = 15;

		// Token: 0x04006DB0 RID: 28080
		private object phantomBattleResultCtx_;

		// Token: 0x04006DB1 RID: 28081
		private PhantomBattleEffectResultInfo.PhantomBattleResultCtxOneofCase phantomBattleResultCtxCase_;

		// Token: 0x020018AF RID: 6319
		public enum PhantomBattleResultCtxOneofCase
		{
			// Token: 0x0400C8A1 RID: 51361
			None,
			// Token: 0x0400C8A2 RID: 51362
			PhantomBattleDealEffectCtx,
			// Token: 0x0400C8A3 RID: 51363
			NpcPhantomBattleDealEffectCtx,
			// Token: 0x0400C8A4 RID: 51364
			PhantomBattleAddBuffEffectCtx,
			// Token: 0x0400C8A5 RID: 51365
			PhantomBattleCardSelectEffectCtx = 5,
			// Token: 0x0400C8A6 RID: 51366
			NpcPhantomBattleCardSelectEffectCtx,
			// Token: 0x0400C8A7 RID: 51367
			NpcPhantomBattleAreaLockEffectCtx,
			// Token: 0x0400C8A8 RID: 51368
			PhantomBattleCopyCardEffectCtx = 9,
			// Token: 0x0400C8A9 RID: 51369
			PhantomBattleDestroyCardEffectCtx,
			// Token: 0x0400C8AA RID: 51370
			PhantomBattleTakeTargetAttrEffectCtx,
			// Token: 0x0400C8AB RID: 51371
			PhantomBattleFactorsEffectCtx,
			// Token: 0x0400C8AC RID: 51372
			PhantomBattleCallCardEffectCtx,
			// Token: 0x0400C8AD RID: 51373
			PhantomBattleDirectDamage,
			// Token: 0x0400C8AE RID: 51374
			PhantomBattleReconstruct
		}
	}
}
