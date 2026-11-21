using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004C5 RID: 1221
	public sealed class EventInfo : IMessage<EventInfo>, IMessage, IEquatable<EventInfo>, IDeepCloneable<EventInfo>, IBufferMessage
	{
		// Token: 0x06007466 RID: 29798 RVA: 0x0011D70C File Offset: 0x0011B90C
		[NullableContext(1)]
		public static EventInfo Create()
		{
			return new EventInfo();
		}

		// Token: 0x17001689 RID: 5769
		// (get) Token: 0x06007467 RID: 29799 RVA: 0x0011D713 File Offset: 0x0011B913
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EventInfo> Parser
		{
			get
			{
				return EventInfo._parser;
			}
		}

		// Token: 0x1700168A RID: 5770
		// (get) Token: 0x06007468 RID: 29800 RVA: 0x0011D71A File Offset: 0x0011B91A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700168B RID: 5771
		// (get) Token: 0x06007469 RID: 29801 RVA: 0x0011D71D File Offset: 0x0011B91D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EventInfo.Descriptor;
			}
		}

		// Token: 0x0600746A RID: 29802 RVA: 0x0011D724 File Offset: 0x0011B924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EventInfo()
		{
		}

		// Token: 0x0600746B RID: 29803 RVA: 0x0011D72C File Offset: 0x0011B92C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EventInfo(EventInfo other) : this()
		{
			this.eventType_ = other.eventType_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600746C RID: 29804 RVA: 0x0011D75D File Offset: 0x0011B95D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EventInfo Clone()
		{
			return new EventInfo(this);
		}

		// Token: 0x1700168C RID: 5772
		// (get) Token: 0x0600746D RID: 29805 RVA: 0x0011D765 File Offset: 0x0011B965
		// (set) Token: 0x0600746E RID: 29806 RVA: 0x0011D76D File Offset: 0x0011B96D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EventType
		{
			get
			{
				return this.eventType_;
			}
			set
			{
				this.eventType_ = value;
			}
		}

		// Token: 0x1700168D RID: 5773
		// (get) Token: 0x0600746F RID: 29807 RVA: 0x0011D776 File Offset: 0x0011B976
		// (set) Token: 0x06007470 RID: 29808 RVA: 0x0011D77E File Offset: 0x0011B97E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x06007471 RID: 29809 RVA: 0x0011D787 File Offset: 0x0011B987
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EventInfo);
		}

		// Token: 0x06007472 RID: 29810 RVA: 0x0011D795 File Offset: 0x0011B995
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EventInfo other)
		{
			return other != null && (other == this || (this.EventType == other.EventType && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007473 RID: 29811 RVA: 0x0011D7D4 File Offset: 0x0011B9D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EventType != 0)
			{
				num ^= this.EventType.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007474 RID: 29812 RVA: 0x0011D82C File Offset: 0x0011BA2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007475 RID: 29813 RVA: 0x0011D839 File Offset: 0x0011BA39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007476 RID: 29814 RVA: 0x0011D844 File Offset: 0x0011BA44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EventType != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.EventType);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Count);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007477 RID: 29815 RVA: 0x0011D89C File Offset: 0x0011BA9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EventType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EventType);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007478 RID: 29816 RVA: 0x0011D8F4 File Offset: 0x0011BAF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EventInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EventType != 0)
			{
				this.EventType = other.EventType;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007479 RID: 29817 RVA: 0x0011D944 File Offset: 0x0011BB44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600747A RID: 29818 RVA: 0x0011D950 File Offset: 0x0011BB50
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Count = input.ReadInt32();
					}
				}
				else
				{
					this.EventType = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003DBB RID: 15803
		private static readonly MessageParser<EventInfo> _parser = new MessageParser<EventInfo>(() => new EventInfo());

		// Token: 0x04003DBC RID: 15804
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DBD RID: 15805
		public const int EventTypeFieldNumber = 1;

		// Token: 0x04003DBE RID: 15806
		private int eventType_;

		// Token: 0x04003DBF RID: 15807
		public const int CountFieldNumber = 2;

		// Token: 0x04003DC0 RID: 15808
		private int count_;
	}
}
