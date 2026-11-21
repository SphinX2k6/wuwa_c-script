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
		// Token: 0x060023DB RID: 9179 RVA: 0x0005F99B File Offset: 0x0005DB9B
		[NullableContext(1)]
		public static ApplyBuffFailedNotify Create()
		{
			return new ApplyBuffFailedNotify();
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x060023DC RID: 9180 RVA: 0x0005F9A2 File Offset: 0x0005DBA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x060023DD RID: 9181 RVA: 0x0005F9A5 File Offset: 0x0005DBA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ApplyBuffFailedNotify.Descriptor;
			}
		}

		// Token: 0x060023DE RID: 9182 RVA: 0x0005F9AC File Offset: 0x0005DBAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyBuffFailedNotify()
		{
		}

		// Token: 0x060023DF RID: 9183 RVA: 0x0005F9B4 File Offset: 0x0005DBB4
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

		// Token: 0x060023E0 RID: 9184 RVA: 0x0005FA18 File Offset: 0x0005DC18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyBuffFailedNotify Clone()
		{
			return new ApplyBuffFailedNotify(this);
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x060023E1 RID: 9185 RVA: 0x0005FA20 File Offset: 0x0005DC20
		// (set) Token: 0x060023E2 RID: 9186 RVA: 0x0005FA28 File Offset: 0x0005DC28
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

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x060023E3 RID: 9187 RVA: 0x0005FA31 File Offset: 0x0005DC31
		// (set) Token: 0x060023E4 RID: 9188 RVA: 0x0005FA39 File Offset: 0x0005DC39
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

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x060023E5 RID: 9189 RVA: 0x0005FA42 File Offset: 0x0005DC42
		// (set) Token: 0x060023E6 RID: 9190 RVA: 0x0005FA4A File Offset: 0x0005DC4A
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

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x060023E7 RID: 9191 RVA: 0x0005FA53 File Offset: 0x0005DC53
		// (set) Token: 0x060023E8 RID: 9192 RVA: 0x0005FA5B File Offset: 0x0005DC5B
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

		// Token: 0x060023E9 RID: 9193 RVA: 0x0005FA64 File Offset: 0x0005DC64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ApplyBuffFailedNotify);
		}

		// Token: 0x060023EA RID: 9194 RVA: 0x0005FA74 File Offset: 0x0005DC74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ApplyBuffFailedNotify other)
		{
			return other != null && (other == this || (this.BuffId == other.BuffId && this.StackCount == other.StackCount && this.InstigatorId == other.InstigatorId && object.Equals(this.TransferContextId, other.TransferContextId) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060023EB RID: 9195 RVA: 0x0005FAE4 File Offset: 0x0005DCE4
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

		// Token: 0x060023EC RID: 9196 RVA: 0x0005FB6B File Offset: 0x0005DD6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060023ED RID: 9197 RVA: 0x0005FB78 File Offset: 0x0005DD78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060023EE RID: 9198 RVA: 0x0005FB84 File Offset: 0x0005DD84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuffId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.BuffId);
			}
			if (this.InstigatorId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.InstigatorId);
			}
			if (this.transferContextId_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.TransferContextId);
			}
			if (this.StackCount != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.StackCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060023EF RID: 9199 RVA: 0x0005FC14 File Offset: 0x0005DE14
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

		// Token: 0x060023F0 RID: 9200 RVA: 0x0005FC9C File Offset: 0x0005DE9C
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

		// Token: 0x060023F1 RID: 9201 RVA: 0x0005FD2C File Offset: 0x0005DF2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060023F2 RID: 9202 RVA: 0x0005FD38 File Offset: 0x0005DF38
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
					if (num == 8U)
					{
						this.BuffId = input.ReadInt64();
						continue;
					}
					if (num == 24U)
					{
						this.InstigatorId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 42U)
					{
						if (this.transferContextId_ == null)
						{
							this.TransferContextId = new TransferContextId();
						}
						input.ReadMessage(this.TransferContextId);
						continue;
					}
					if (num == 112U)
					{
						this.StackCount = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002562 RID: 9570
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002563 RID: 9571
		public const int BuffIdFieldNumber = 1;

		// Token: 0x04002564 RID: 9572
		private long buffId_;

		// Token: 0x04002565 RID: 9573
		public const int StackCountFieldNumber = 14;

		// Token: 0x04002566 RID: 9574
		private int stackCount_;

		// Token: 0x04002567 RID: 9575
		public const int InstigatorIdFieldNumber = 3;

		// Token: 0x04002568 RID: 9576
		private long instigatorId_;

		// Token: 0x04002569 RID: 9577
		public const int TransferContextIdFieldNumber = 5;

		// Token: 0x0400256A RID: 9578
		private TransferContextId transferContextId_;
	}
}
