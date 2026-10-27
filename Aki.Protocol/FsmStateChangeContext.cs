using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000673 RID: 1651
	public sealed class FsmStateChangeContext : IMessage<FsmStateChangeContext>, IMessage, IEquatable<FsmStateChangeContext>, IDeepCloneable<FsmStateChangeContext>, IBufferMessage
	{
		// Token: 0x06009763 RID: 38755 RVA: 0x0016D2A3 File Offset: 0x0016B4A3
		[NullableContext(1)]
		public static FsmStateChangeContext Create()
		{
			return new FsmStateChangeContext();
		}

		// Token: 0x17001E29 RID: 7721
		// (get) Token: 0x06009764 RID: 38756 RVA: 0x0016D2AA File Offset: 0x0016B4AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E2A RID: 7722
		// (get) Token: 0x06009765 RID: 38757 RVA: 0x0016D2AD File Offset: 0x0016B4AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FsmStateChangeContext.Descriptor;
			}
		}

		// Token: 0x06009766 RID: 38758 RVA: 0x0016D2B4 File Offset: 0x0016B4B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmStateChangeContext()
		{
		}

		// Token: 0x06009767 RID: 38759 RVA: 0x0016D2BC File Offset: 0x0016B4BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmStateChangeContext(FsmStateChangeContext other) : this()
		{
			this.fsmId_ = other.fsmId_;
			this.state_ = other.state_;
			this.changeType_ = other.changeType_;
			this.index_ = other.index_;
			this.contextId_ = other.contextId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009768 RID: 38760 RVA: 0x0016D31C File Offset: 0x0016B51C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmStateChangeContext Clone()
		{
			return new FsmStateChangeContext(this);
		}

		// Token: 0x17001E2B RID: 7723
		// (get) Token: 0x06009769 RID: 38761 RVA: 0x0016D324 File Offset: 0x0016B524
		// (set) Token: 0x0600976A RID: 38762 RVA: 0x0016D32C File Offset: 0x0016B52C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FsmId
		{
			get
			{
				return this.fsmId_;
			}
			set
			{
				this.fsmId_ = value;
			}
		}

		// Token: 0x17001E2C RID: 7724
		// (get) Token: 0x0600976B RID: 38763 RVA: 0x0016D335 File Offset: 0x0016B535
		// (set) Token: 0x0600976C RID: 38764 RVA: 0x0016D33D File Offset: 0x0016B53D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x17001E2D RID: 7725
		// (get) Token: 0x0600976D RID: 38765 RVA: 0x0016D346 File Offset: 0x0016B546
		// (set) Token: 0x0600976E RID: 38766 RVA: 0x0016D34E File Offset: 0x0016B54E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EEntityFsmChangeType ChangeType
		{
			get
			{
				return this.changeType_;
			}
			set
			{
				this.changeType_ = value;
			}
		}

		// Token: 0x17001E2E RID: 7726
		// (get) Token: 0x0600976F RID: 38767 RVA: 0x0016D357 File Offset: 0x0016B557
		// (set) Token: 0x06009770 RID: 38768 RVA: 0x0016D35F File Offset: 0x0016B55F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x17001E2F RID: 7727
		// (get) Token: 0x06009771 RID: 38769 RVA: 0x0016D368 File Offset: 0x0016B568
		// (set) Token: 0x06009772 RID: 38770 RVA: 0x0016D370 File Offset: 0x0016B570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ContextId
		{
			get
			{
				return this.contextId_;
			}
			set
			{
				this.contextId_ = value;
			}
		}

		// Token: 0x06009773 RID: 38771 RVA: 0x0016D379 File Offset: 0x0016B579
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FsmStateChangeContext);
		}

		// Token: 0x06009774 RID: 38772 RVA: 0x0016D388 File Offset: 0x0016B588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FsmStateChangeContext other)
		{
			return other != null && (other == this || (this.FsmId == other.FsmId && this.State == other.State && this.ChangeType == other.ChangeType && this.Index == other.Index && this.ContextId == other.ContextId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009775 RID: 38773 RVA: 0x0016D404 File Offset: 0x0016B604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FsmId != 0)
			{
				num ^= this.FsmId.GetHashCode();
			}
			if (this.State != 0)
			{
				num ^= this.State.GetHashCode();
			}
			if (this.ChangeType != EEntityFsmChangeType.Enter)
			{
				num ^= this.ChangeType.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.ContextId != 0L)
			{
				num ^= this.ContextId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009776 RID: 38774 RVA: 0x0016D4AD File Offset: 0x0016B6AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009777 RID: 38775 RVA: 0x0016D4BA File Offset: 0x0016B6BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009778 RID: 38776 RVA: 0x0016D4C4 File Offset: 0x0016B6C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FsmId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.FsmId);
			}
			if (this.State != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.State);
			}
			if (this.ChangeType != EEntityFsmChangeType.Enter)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ChangeType);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Index);
			}
			if (this.ContextId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.ContextId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009779 RID: 38777 RVA: 0x0016D570 File Offset: 0x0016B770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FsmId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FsmId);
			}
			if (this.State != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.State);
			}
			if (this.ChangeType != EEntityFsmChangeType.Enter)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ChangeType);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this.ContextId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ContextId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600977A RID: 38778 RVA: 0x0016D610 File Offset: 0x0016B810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FsmStateChangeContext other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FsmId != 0)
			{
				this.FsmId = other.FsmId;
			}
			if (other.State != 0)
			{
				this.State = other.State;
			}
			if (other.ChangeType != EEntityFsmChangeType.Enter)
			{
				this.ChangeType = other.ChangeType;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			if (other.ContextId != 0L)
			{
				this.ContextId = other.ContextId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600977B RID: 38779 RVA: 0x0016D69C File Offset: 0x0016B89C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600977C RID: 38780 RVA: 0x0016D6A8 File Offset: 0x0016B8A8
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.FsmId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.State = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.ChangeType = (EEntityFsmChangeType)input.ReadEnum();
						continue;
					}
					if (num == 32U)
					{
						this.Index = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.ContextId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040047FA RID: 18426
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047FB RID: 18427
		public const int FsmIdFieldNumber = 1;

		// Token: 0x040047FC RID: 18428
		private int fsmId_;

		// Token: 0x040047FD RID: 18429
		public const int StateFieldNumber = 2;

		// Token: 0x040047FE RID: 18430
		private int state_;

		// Token: 0x040047FF RID: 18431
		public const int ChangeTypeFieldNumber = 3;

		// Token: 0x04004800 RID: 18432
		private EEntityFsmChangeType changeType_;

		// Token: 0x04004801 RID: 18433
		public const int IndexFieldNumber = 4;

		// Token: 0x04004802 RID: 18434
		private int index_;

		// Token: 0x04004803 RID: 18435
		public const int ContextIdFieldNumber = 5;

		// Token: 0x04004804 RID: 18436
		private long contextId_;
	}
}
