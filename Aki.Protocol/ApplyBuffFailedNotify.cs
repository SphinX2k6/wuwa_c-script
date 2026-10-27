using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aki.Protocol.BattleDefine;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000FD RID: 253
	[NetMessage(EMessageId.ApplyBuffFailedNotify)]
	public sealed class ApplyBuffFailedNotify : IMessage<ApplyBuffFailedNotify>, IMessage, IEquatable<ApplyBuffFailedNotify>, IDeepCloneable<ApplyBuffFailedNotify>, IBufferMessage
	{
		// Token: 0x060023A4 RID: 9124 RVA: 0x0005EEC6 File Offset: 0x0005D0C6
		[NullableContext(1)]
		public static ApplyBuffFailedNotify Create()
		{
			return new ApplyBuffFailedNotify();
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x060023A5 RID: 9125 RVA: 0x0005EECD File Offset: 0x0005D0CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x060023A6 RID: 9126 RVA: 0x0005EED0 File Offset: 0x0005D0D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ApplyBuffFailedNotify.Descriptor;
			}
		}

		// Token: 0x060023A7 RID: 9127 RVA: 0x0005EED7 File Offset: 0x0005D0D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyBuffFailedNotify()
		{
		}

		// Token: 0x060023A8 RID: 9128 RVA: 0x0005EEE0 File Offset: 0x0005D0E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyBuffFailedNotify(ApplyBuffFailedNotify other) : this()
		{
			this.buffId_ = other.buffId_;
			this.stackCount_ = other.stackCount_;
			this.instigatorId_ = other.instigatorId_;
			this.transferContextId_ = ((other.transferContextId_ != null) ? other.transferContextId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060023A9 RID: 9129 RVA: 0x0005EF44 File Offset: 0x0005D144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyBuffFailedNotify Clone()
		{
			return new ApplyBuffFailedNotify(this);
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x060023AA RID: 9130 RVA: 0x0005EF4C File Offset: 0x0005D14C
		// (set) Token: 0x060023AB RID: 9131 RVA: 0x0005EF54 File Offset: 0x0005D154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BuffId
		{
			get
			{
				return this.buffId_;
			}
			set
			{
				this.buffId_ = value;
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x060023AC RID: 9132 RVA: 0x0005EF5D File Offset: 0x0005D15D
		// (set) Token: 0x060023AD RID: 9133 RVA: 0x0005EF65 File Offset: 0x0005D165
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StackCount
		{
			get
			{
				return this.stackCount_;
			}
			set
			{
				this.stackCount_ = value;
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x060023AE RID: 9134 RVA: 0x0005EF6E File Offset: 0x0005D16E
		// (set) Token: 0x060023AF RID: 9135 RVA: 0x0005EF76 File Offset: 0x0005D176
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long InstigatorId
		{
			get
			{
				return this.instigatorId_;
			}
			set
			{
				this.instigatorId_ = value;
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x060023B0 RID: 9136 RVA: 0x0005EF7F File Offset: 0x0005D17F
		// (set) Token: 0x060023B1 RID: 9137 RVA: 0x0005EF87 File Offset: 0x0005D187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransferContextId TransferContextId
		{
			get
			{
				return this.transferContextId_;
			}
			set
			{
				this.transferContextId_ = value;
			}
		}

		// Token: 0x060023B2 RID: 9138 RVA: 0x0005EF90 File Offset: 0x0005D190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ApplyBuffFailedNotify);
		}

		// Token: 0x060023B3 RID: 9139 RVA: 0x0005EFA0 File Offset: 0x0005D1A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ApplyBuffFailedNotify other)
		{
			return other != null && (other == this || (this.BuffId == other.BuffId && this.StackCount == other.StackCount && this.InstigatorId == other.InstigatorId && object.Equals(this.TransferContextId, other.TransferContextId) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060023B4 RID: 9140 RVA: 0x0005F010 File Offset: 0x0005D210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BuffId != 0L)
			{
				num ^= this.BuffId.GetHashCode();
			}
			if (this.StackCount != 0)
			{
				num ^= this.StackCount.GetHashCode();
			}
			if (this.InstigatorId != 0L)
			{
				num ^= this.InstigatorId.GetHashCode();
			}
			if (this.transferContextId_ != null)
			{
				num ^= this.TransferContextId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060023B5 RID: 9141 RVA: 0x0005F097 File Offset: 0x0005D297
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060023B6 RID: 9142 RVA: 0x0005F0A4 File Offset: 0x0005D2A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060023B7 RID: 9143 RVA: 0x0005F0B0 File Offset: 0x0005D2B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstigatorId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.InstigatorId);
			}
			if (this.BuffId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.BuffId);
			}
			if (this.StackCount != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.StackCount);
			}
			if (this.transferContextId_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.TransferContextId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060023B8 RID: 9144 RVA: 0x0005F144 File Offset: 0x0005D344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BuffId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BuffId);
			}
			if (this.StackCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StackCount);
			}
			if (this.InstigatorId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.InstigatorId);
			}
			if (this.transferContextId_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TransferContextId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060023B9 RID: 9145 RVA: 0x0005F1CC File Offset: 0x0005D3CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ApplyBuffFailedNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BuffId != 0L)
			{
				this.BuffId = other.BuffId;
			}
			if (other.StackCount != 0)
			{
				this.StackCount = other.StackCount;
			}
			if (other.InstigatorId != 0L)
			{
				this.InstigatorId = other.InstigatorId;
			}
			if (other.transferContextId_ != null)
			{
				if (this.transferContextId_ == null)
				{
					this.TransferContextId = new TransferContextId();
				}
				this.TransferContextId.MergeFrom(other.TransferContextId);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060023BA RID: 9146 RVA: 0x0005F25C File Offset: 0x0005D45C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060023BB RID: 9147 RVA: 0x0005F268 File Offset: 0x0005D468
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
				if (num <= 24U)
				{
					if (num == 16U)
					{
						this.InstigatorId = input.ReadInt64();
						continue;
					}
					if (num == 24U)
					{
						this.BuffId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.StackCount = input.ReadInt32();
						continue;
					}
					if (num == 122U)
					{
						if (this.transferContextId_ == null)
						{
							this.TransferContextId = new TransferContextId();
						}
						input.ReadMessage(this.TransferContextId);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002503 RID: 9475
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002504 RID: 9476
		public const int BuffIdFieldNumber = 3;

		// Token: 0x04002505 RID: 9477
		private long buffId_;

		// Token: 0x04002506 RID: 9478
		public const int StackCountFieldNumber = 7;

		// Token: 0x04002507 RID: 9479
		private int stackCount_;

		// Token: 0x04002508 RID: 9480
		public const int InstigatorIdFieldNumber = 2;

		// Token: 0x04002509 RID: 9481
		private long instigatorId_;

		// Token: 0x0400250A RID: 9482
		public const int TransferContextIdFieldNumber = 15;

		// Token: 0x0400250B RID: 9483
		private TransferContextId transferContextId_;
	}
}
