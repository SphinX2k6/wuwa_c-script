using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000665 RID: 1637
	public sealed class FRUnitResourcesChangeAction : IMessage<FRUnitResourcesChangeAction>, IMessage, IEquatable<FRUnitResourcesChangeAction>, IDeepCloneable<FRUnitResourcesChangeAction>, IBufferMessage
	{
		// Token: 0x06009633 RID: 38451 RVA: 0x0016A50D File Offset: 0x0016870D
		[NullableContext(1)]
		public static FRUnitResourcesChangeAction Create()
		{
			return new FRUnitResourcesChangeAction();
		}

		// Token: 0x17001DE5 RID: 7653
		// (get) Token: 0x06009634 RID: 38452 RVA: 0x0016A514 File Offset: 0x00168714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FRUnitResourcesChangeAction> Parser
		{
			get
			{
				return FRUnitResourcesChangeAction._parser;
			}
		}

		// Token: 0x17001DE6 RID: 7654
		// (get) Token: 0x06009635 RID: 38453 RVA: 0x0016A51B File Offset: 0x0016871B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001DE7 RID: 7655
		// (get) Token: 0x06009636 RID: 38454 RVA: 0x0016A51E File Offset: 0x0016871E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FRUnitResourcesChangeAction.Descriptor;
			}
		}

		// Token: 0x06009637 RID: 38455 RVA: 0x0016A525 File Offset: 0x00168725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitResourcesChangeAction()
		{
		}

		// Token: 0x06009638 RID: 38456 RVA: 0x0016A52D File Offset: 0x0016872D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitResourcesChangeAction(FRUnitResourcesChangeAction other) : this()
		{
			this.type_ = other.type_;
			this.changeCount_ = other.changeCount_;
			this.targetUnitIncId_ = other.targetUnitIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009639 RID: 38457 RVA: 0x0016A56A File Offset: 0x0016876A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitResourcesChangeAction Clone()
		{
			return new FRUnitResourcesChangeAction(this);
		}

		// Token: 0x17001DE8 RID: 7656
		// (get) Token: 0x0600963A RID: 38458 RVA: 0x0016A572 File Offset: 0x00168772
		// (set) Token: 0x0600963B RID: 38459 RVA: 0x0016A57A File Offset: 0x0016877A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitResourcesChangeType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17001DE9 RID: 7657
		// (get) Token: 0x0600963C RID: 38460 RVA: 0x0016A583 File Offset: 0x00168783
		// (set) Token: 0x0600963D RID: 38461 RVA: 0x0016A58B File Offset: 0x0016878B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ChangeCount
		{
			get
			{
				return this.changeCount_;
			}
			set
			{
				this.changeCount_ = value;
			}
		}

		// Token: 0x17001DEA RID: 7658
		// (get) Token: 0x0600963E RID: 38462 RVA: 0x0016A594 File Offset: 0x00168794
		// (set) Token: 0x0600963F RID: 38463 RVA: 0x0016A59C File Offset: 0x0016879C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetUnitIncId
		{
			get
			{
				return this.targetUnitIncId_;
			}
			set
			{
				this.targetUnitIncId_ = value;
			}
		}

		// Token: 0x06009640 RID: 38464 RVA: 0x0016A5A5 File Offset: 0x001687A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FRUnitResourcesChangeAction);
		}

		// Token: 0x06009641 RID: 38465 RVA: 0x0016A5B4 File Offset: 0x001687B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FRUnitResourcesChangeAction other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.ChangeCount == other.ChangeCount && this.TargetUnitIncId == other.TargetUnitIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009642 RID: 38466 RVA: 0x0016A610 File Offset: 0x00168810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != FRUnitResourcesChangeType.UnitBaseSalary)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.ChangeCount != 0L)
			{
				num ^= this.ChangeCount.GetHashCode();
			}
			if (this.TargetUnitIncId != 0)
			{
				num ^= this.TargetUnitIncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009643 RID: 38467 RVA: 0x0016A687 File Offset: 0x00168887
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009644 RID: 38468 RVA: 0x0016A694 File Offset: 0x00168894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009645 RID: 38469 RVA: 0x0016A6A0 File Offset: 0x001688A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != FRUnitResourcesChangeType.UnitBaseSalary)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Type);
			}
			if (this.ChangeCount != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.ChangeCount);
			}
			if (this.TargetUnitIncId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TargetUnitIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009646 RID: 38470 RVA: 0x0016A714 File Offset: 0x00168914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != FRUnitResourcesChangeType.UnitBaseSalary)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.ChangeCount != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ChangeCount);
			}
			if (this.TargetUnitIncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetUnitIncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009647 RID: 38471 RVA: 0x0016A784 File Offset: 0x00168984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FRUnitResourcesChangeAction other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != FRUnitResourcesChangeType.UnitBaseSalary)
			{
				this.Type = other.Type;
			}
			if (other.ChangeCount != 0L)
			{
				this.ChangeCount = other.ChangeCount;
			}
			if (other.TargetUnitIncId != 0)
			{
				this.TargetUnitIncId = other.TargetUnitIncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009648 RID: 38472 RVA: 0x0016A7E8 File Offset: 0x001689E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009649 RID: 38473 RVA: 0x0016A7F4 File Offset: 0x001689F4
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.TargetUnitIncId = input.ReadInt32();
						}
					}
					else
					{
						this.ChangeCount = input.ReadInt64();
					}
				}
				else
				{
					this.Type = (FRUnitResourcesChangeType)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400479B RID: 18331
		private static readonly MessageParser<FRUnitResourcesChangeAction> _parser = new MessageParser<FRUnitResourcesChangeAction>(() => new FRUnitResourcesChangeAction());

		// Token: 0x0400479C RID: 18332
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400479D RID: 18333
		public const int TypeFieldNumber = 1;

		// Token: 0x0400479E RID: 18334
		private FRUnitResourcesChangeType type_;

		// Token: 0x0400479F RID: 18335
		public const int ChangeCountFieldNumber = 2;

		// Token: 0x040047A0 RID: 18336
		private long changeCount_;

		// Token: 0x040047A1 RID: 18337
		public const int TargetUnitIncIdFieldNumber = 3;

		// Token: 0x040047A2 RID: 18338
		private int targetUnitIncId_;
	}
}
