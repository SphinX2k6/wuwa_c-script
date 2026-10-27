using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004DC RID: 1244
	public sealed class EventInfo : IMessage<EventInfo>, IMessage, IEquatable<EventInfo>, IDeepCloneable<EventInfo>, IBufferMessage
	{
		// Token: 0x060075F6 RID: 30198 RVA: 0x00120824 File Offset: 0x0011EA24
		[NullableContext(1)]
		public static EventInfo Create()
		{
			return new EventInfo();
		}

		// Token: 0x170016DE RID: 5854
		// (get) Token: 0x060075F7 RID: 30199 RVA: 0x0012082B File Offset: 0x0011EA2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EventInfo> Parser
		{
			get
			{
				return EventInfo._parser;
			}
		}

		// Token: 0x170016DF RID: 5855
		// (get) Token: 0x060075F8 RID: 30200 RVA: 0x00120832 File Offset: 0x0011EA32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016E0 RID: 5856
		// (get) Token: 0x060075F9 RID: 30201 RVA: 0x00120835 File Offset: 0x0011EA35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EventInfo.Descriptor;
			}
		}

		// Token: 0x060075FA RID: 30202 RVA: 0x0012083C File Offset: 0x0011EA3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EventInfo()
		{
		}

		// Token: 0x060075FB RID: 30203 RVA: 0x00120844 File Offset: 0x0011EA44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EventInfo(EventInfo other) : this()
		{
			this.eventType_ = other.eventType_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060075FC RID: 30204 RVA: 0x00120875 File Offset: 0x0011EA75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EventInfo Clone()
		{
			return new EventInfo(this);
		}

		// Token: 0x170016E1 RID: 5857
		// (get) Token: 0x060075FD RID: 30205 RVA: 0x0012087D File Offset: 0x0011EA7D
		// (set) Token: 0x060075FE RID: 30206 RVA: 0x00120885 File Offset: 0x0011EA85
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

		// Token: 0x170016E2 RID: 5858
		// (get) Token: 0x060075FF RID: 30207 RVA: 0x0012088E File Offset: 0x0011EA8E
		// (set) Token: 0x06007600 RID: 30208 RVA: 0x00120896 File Offset: 0x0011EA96
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

		// Token: 0x06007601 RID: 30209 RVA: 0x0012089F File Offset: 0x0011EA9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EventInfo);
		}

		// Token: 0x06007602 RID: 30210 RVA: 0x001208AD File Offset: 0x0011EAAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EventInfo other)
		{
			return other != null && (other == this || (this.EventType == other.EventType && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007603 RID: 30211 RVA: 0x001208EC File Offset: 0x0011EAEC
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

		// Token: 0x06007604 RID: 30212 RVA: 0x00120944 File Offset: 0x0011EB44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007605 RID: 30213 RVA: 0x00120951 File Offset: 0x0011EB51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007606 RID: 30214 RVA: 0x0012095C File Offset: 0x0011EB5C
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

		// Token: 0x06007607 RID: 30215 RVA: 0x001209B4 File Offset: 0x0011EBB4
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

		// Token: 0x06007608 RID: 30216 RVA: 0x00120A0C File Offset: 0x0011EC0C
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

		// Token: 0x06007609 RID: 30217 RVA: 0x00120A5C File Offset: 0x0011EC5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600760A RID: 30218 RVA: 0x00120A68 File Offset: 0x0011EC68
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

		// Token: 0x04003DCF RID: 15823
		private static readonly MessageParser<EventInfo> _parser = new MessageParser<EventInfo>(() => new EventInfo());

		// Token: 0x04003DD0 RID: 15824
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DD1 RID: 15825
		public const int EventTypeFieldNumber = 1;

		// Token: 0x04003DD2 RID: 15826
		private int eventType_;

		// Token: 0x04003DD3 RID: 15827
		public const int CountFieldNumber = 2;

		// Token: 0x04003DD4 RID: 15828
		private int count_;
	}
}
