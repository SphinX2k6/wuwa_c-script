using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200136F RID: 4975
	[NetMessage(EMessageId.TimelineTraceControlRequest)]
	public sealed class TimelineTraceControlRequest : IMessage<TimelineTraceControlRequest>, IMessage, IEquatable<TimelineTraceControlRequest>, IDeepCloneable<TimelineTraceControlRequest>, IBufferMessage
	{
		// Token: 0x0601A6B2 RID: 108210 RVA: 0x003D5FC0 File Offset: 0x003D41C0
		[NullableContext(1)]
		public static TimelineTraceControlRequest Create()
		{
			return new TimelineTraceControlRequest();
		}

		// Token: 0x1700591D RID: 22813
		// (get) Token: 0x0601A6B3 RID: 108211 RVA: 0x003D5FC7 File Offset: 0x003D41C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700591E RID: 22814
		// (get) Token: 0x0601A6B4 RID: 108212 RVA: 0x003D5FCA File Offset: 0x003D41CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimelineTraceControlRequest.Descriptor;
			}
		}

		// Token: 0x0601A6B5 RID: 108213 RVA: 0x003D5FD1 File Offset: 0x003D41D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTraceControlRequest()
		{
		}

		// Token: 0x0601A6B6 RID: 108214 RVA: 0x003D5FD9 File Offset: 0x003D41D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTraceControlRequest(TimelineTraceControlRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.forward_ = other.forward_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A6B7 RID: 108215 RVA: 0x003D600A File Offset: 0x003D420A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTraceControlRequest Clone()
		{
			return new TimelineTraceControlRequest(this);
		}

		// Token: 0x1700591F RID: 22815
		// (get) Token: 0x0601A6B8 RID: 108216 RVA: 0x003D6012 File Offset: 0x003D4212
		// (set) Token: 0x0601A6B9 RID: 108217 RVA: 0x003D601A File Offset: 0x003D421A
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

		// Token: 0x17005920 RID: 22816
		// (get) Token: 0x0601A6BA RID: 108218 RVA: 0x003D6023 File Offset: 0x003D4223
		// (set) Token: 0x0601A6BB RID: 108219 RVA: 0x003D602B File Offset: 0x003D422B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Forward
		{
			get
			{
				return this.forward_;
			}
			set
			{
				this.forward_ = value;
			}
		}

		// Token: 0x0601A6BC RID: 108220 RVA: 0x003D6034 File Offset: 0x003D4234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimelineTraceControlRequest);
		}

		// Token: 0x0601A6BD RID: 108221 RVA: 0x003D6042 File Offset: 0x003D4242
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimelineTraceControlRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.Forward == other.Forward && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A6BE RID: 108222 RVA: 0x003D6080 File Offset: 0x003D4280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.Forward)
			{
				num ^= this.Forward.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A6BF RID: 108223 RVA: 0x003D60D8 File Offset: 0x003D42D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A6C0 RID: 108224 RVA: 0x003D60E5 File Offset: 0x003D42E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A6C1 RID: 108225 RVA: 0x003D60F0 File Offset: 0x003D42F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.EntityId);
			}
			if (this.Forward)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.Forward);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A6C2 RID: 108226 RVA: 0x003D614C File Offset: 0x003D434C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.Forward)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A6C3 RID: 108227 RVA: 0x003D6198 File Offset: 0x003D4398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TimelineTraceControlRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.Forward)
			{
				this.Forward = other.Forward;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A6C4 RID: 108228 RVA: 0x003D61E8 File Offset: 0x003D43E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A6C5 RID: 108229 RVA: 0x003D61F4 File Offset: 0x003D43F4
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
				if (num != 104U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Forward = input.ReadBool();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040099D9 RID: 39385
		private UnknownFieldSet _unknownFields;

		// Token: 0x040099DA RID: 39386
		public const int EntityIdFieldNumber = 13;

		// Token: 0x040099DB RID: 39387
		private long entityId_;

		// Token: 0x040099DC RID: 39388
		public const int ForwardFieldNumber = 14;

		// Token: 0x040099DD RID: 39389
		private bool forward_;
	}
}
