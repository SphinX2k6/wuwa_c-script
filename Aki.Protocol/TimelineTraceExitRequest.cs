using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001371 RID: 4977
	[NetMessage(EMessageId.TimelineTraceExitRequest)]
	public sealed class TimelineTraceExitRequest : IMessage<TimelineTraceExitRequest>, IMessage, IEquatable<TimelineTraceExitRequest>, IDeepCloneable<TimelineTraceExitRequest>, IBufferMessage
	{
		// Token: 0x0601A6DA RID: 108250 RVA: 0x003D64E8 File Offset: 0x003D46E8
		[NullableContext(1)]
		public static TimelineTraceExitRequest Create()
		{
			return new TimelineTraceExitRequest();
		}

		// Token: 0x17005925 RID: 22821
		// (get) Token: 0x0601A6DB RID: 108251 RVA: 0x003D64EF File Offset: 0x003D46EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005926 RID: 22822
		// (get) Token: 0x0601A6DC RID: 108252 RVA: 0x003D64F2 File Offset: 0x003D46F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimelineTraceExitRequest.Descriptor;
			}
		}

		// Token: 0x0601A6DD RID: 108253 RVA: 0x003D64F9 File Offset: 0x003D46F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTraceExitRequest()
		{
		}

		// Token: 0x0601A6DE RID: 108254 RVA: 0x003D6501 File Offset: 0x003D4701
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTraceExitRequest(TimelineTraceExitRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A6DF RID: 108255 RVA: 0x003D6526 File Offset: 0x003D4726
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTraceExitRequest Clone()
		{
			return new TimelineTraceExitRequest(this);
		}

		// Token: 0x17005927 RID: 22823
		// (get) Token: 0x0601A6E0 RID: 108256 RVA: 0x003D652E File Offset: 0x003D472E
		// (set) Token: 0x0601A6E1 RID: 108257 RVA: 0x003D6536 File Offset: 0x003D4736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x0601A6E2 RID: 108258 RVA: 0x003D653F File Offset: 0x003D473F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimelineTraceExitRequest);
		}

		// Token: 0x0601A6E3 RID: 108259 RVA: 0x003D654D File Offset: 0x003D474D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimelineTraceExitRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A6E4 RID: 108260 RVA: 0x003D657C File Offset: 0x003D477C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A6E5 RID: 108261 RVA: 0x003D65BB File Offset: 0x003D47BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A6E6 RID: 108262 RVA: 0x003D65C8 File Offset: 0x003D47C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A6E7 RID: 108263 RVA: 0x003D65D1 File Offset: 0x003D47D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A6E8 RID: 108264 RVA: 0x003D6604 File Offset: 0x003D4804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A6E9 RID: 108265 RVA: 0x003D6642 File Offset: 0x003D4842
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TimelineTraceExitRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A6EA RID: 108266 RVA: 0x003D6673 File Offset: 0x003D4873
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A6EB RID: 108267 RVA: 0x003D667C File Offset: 0x003D487C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040099E3 RID: 39395
		private UnknownFieldSet _unknownFields;

		// Token: 0x040099E4 RID: 39396
		public const int EntityIdFieldNumber = 1;

		// Token: 0x040099E5 RID: 39397
		private long entityId_;
	}
}
