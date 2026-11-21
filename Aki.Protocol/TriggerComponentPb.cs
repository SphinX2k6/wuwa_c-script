using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014DE RID: 5342
	public sealed class TriggerComponentPb : IMessage<TriggerComponentPb>, IMessage, IEquatable<TriggerComponentPb>, IDeepCloneable<TriggerComponentPb>, IBufferMessage
	{
		// Token: 0x0601C552 RID: 116050 RVA: 0x0041C829 File Offset: 0x0041AA29
		[NullableContext(1)]
		public static TriggerComponentPb Create()
		{
			return new TriggerComponentPb();
		}

		// Token: 0x17005FE8 RID: 24552
		// (get) Token: 0x0601C553 RID: 116051 RVA: 0x0041C830 File Offset: 0x0041AA30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005FE9 RID: 24553
		// (get) Token: 0x0601C554 RID: 116052 RVA: 0x0041C833 File Offset: 0x0041AA33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TriggerComponentPb.Descriptor;
			}
		}

		// Token: 0x0601C555 RID: 116053 RVA: 0x0041C83A File Offset: 0x0041AA3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TriggerComponentPb()
		{
		}

		// Token: 0x0601C556 RID: 116054 RVA: 0x0041C842 File Offset: 0x0041AA42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TriggerComponentPb(TriggerComponentPb other) : this()
		{
			this.triggerCount_ = other.triggerCount_;
			this.exitTriggerCount_ = other.exitTriggerCount_;
			this.contextId_ = other.contextId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C557 RID: 116055 RVA: 0x0041C87F File Offset: 0x0041AA7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TriggerComponentPb Clone()
		{
			return new TriggerComponentPb(this);
		}

		// Token: 0x17005FEA RID: 24554
		// (get) Token: 0x0601C558 RID: 116056 RVA: 0x0041C887 File Offset: 0x0041AA87
		// (set) Token: 0x0601C559 RID: 116057 RVA: 0x0041C88F File Offset: 0x0041AA8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TriggerCount
		{
			get
			{
				return this.triggerCount_;
			}
			set
			{
				this.triggerCount_ = value;
			}
		}

		// Token: 0x17005FEB RID: 24555
		// (get) Token: 0x0601C55A RID: 116058 RVA: 0x0041C898 File Offset: 0x0041AA98
		// (set) Token: 0x0601C55B RID: 116059 RVA: 0x0041C8A0 File Offset: 0x0041AAA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ExitTriggerCount
		{
			get
			{
				return this.exitTriggerCount_;
			}
			set
			{
				this.exitTriggerCount_ = value;
			}
		}

		// Token: 0x17005FEC RID: 24556
		// (get) Token: 0x0601C55C RID: 116060 RVA: 0x0041C8A9 File Offset: 0x0041AAA9
		// (set) Token: 0x0601C55D RID: 116061 RVA: 0x0041C8B1 File Offset: 0x0041AAB1
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

		// Token: 0x0601C55E RID: 116062 RVA: 0x0041C8BA File Offset: 0x0041AABA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TriggerComponentPb);
		}

		// Token: 0x0601C55F RID: 116063 RVA: 0x0041C8C8 File Offset: 0x0041AAC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TriggerComponentPb other)
		{
			return other != null && (other == this || (this.TriggerCount == other.TriggerCount && this.ExitTriggerCount == other.ExitTriggerCount && this.ContextId == other.ContextId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C560 RID: 116064 RVA: 0x0041C924 File Offset: 0x0041AB24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TriggerCount != 0)
			{
				num ^= this.TriggerCount.GetHashCode();
			}
			if (this.ExitTriggerCount != 0)
			{
				num ^= this.ExitTriggerCount.GetHashCode();
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

		// Token: 0x0601C561 RID: 116065 RVA: 0x0041C995 File Offset: 0x0041AB95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C562 RID: 116066 RVA: 0x0041C9A2 File Offset: 0x0041ABA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C563 RID: 116067 RVA: 0x0041C9AC File Offset: 0x0041ABAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TriggerCount != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TriggerCount);
			}
			if (this.ExitTriggerCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ExitTriggerCount);
			}
			if (this.ContextId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.ContextId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C564 RID: 116068 RVA: 0x0041CA20 File Offset: 0x0041AC20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TriggerCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TriggerCount);
			}
			if (this.ExitTriggerCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ExitTriggerCount);
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

		// Token: 0x0601C565 RID: 116069 RVA: 0x0041CA90 File Offset: 0x0041AC90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TriggerComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TriggerCount != 0)
			{
				this.TriggerCount = other.TriggerCount;
			}
			if (other.ExitTriggerCount != 0)
			{
				this.ExitTriggerCount = other.ExitTriggerCount;
			}
			if (other.ContextId != 0L)
			{
				this.ContextId = other.ContextId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C566 RID: 116070 RVA: 0x0041CAF4 File Offset: 0x0041ACF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C567 RID: 116071 RVA: 0x0041CB00 File Offset: 0x0041AD00
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
							this.ContextId = input.ReadInt64();
						}
					}
					else
					{
						this.ExitTriggerCount = input.ReadInt32();
					}
				}
				else
				{
					this.TriggerCount = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A3BC RID: 41916
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A3BD RID: 41917
		public const int TriggerCountFieldNumber = 1;

		// Token: 0x0400A3BE RID: 41918
		private int triggerCount_;

		// Token: 0x0400A3BF RID: 41919
		public const int ExitTriggerCountFieldNumber = 2;

		// Token: 0x0400A3C0 RID: 41920
		private int exitTriggerCount_;

		// Token: 0x0400A3C1 RID: 41921
		public const int ContextIdFieldNumber = 3;

		// Token: 0x0400A3C2 RID: 41922
		private long contextId_;
	}
}
