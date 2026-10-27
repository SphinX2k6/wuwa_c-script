using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001373 RID: 4979
	[NetMessage(EMessageId.TimelineTraceStartRequest)]
	public sealed class TimelineTraceStartRequest : IMessage<TimelineTraceStartRequest>, IMessage, IEquatable<TimelineTraceStartRequest>, IDeepCloneable<TimelineTraceStartRequest>, IBufferMessage
	{
		// Token: 0x0601A6FE RID: 108286 RVA: 0x003D68A1 File Offset: 0x003D4AA1
		[NullableContext(1)]
		public static TimelineTraceStartRequest Create()
		{
			return new TimelineTraceStartRequest();
		}

		// Token: 0x1700592B RID: 22827
		// (get) Token: 0x0601A6FF RID: 108287 RVA: 0x003D68A8 File Offset: 0x003D4AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700592C RID: 22828
		// (get) Token: 0x0601A700 RID: 108288 RVA: 0x003D68AB File Offset: 0x003D4AAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimelineTraceStartRequest.Descriptor;
			}
		}

		// Token: 0x0601A701 RID: 108289 RVA: 0x003D68B2 File Offset: 0x003D4AB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTraceStartRequest()
		{
		}

		// Token: 0x0601A702 RID: 108290 RVA: 0x003D68BA File Offset: 0x003D4ABA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTraceStartRequest(TimelineTraceStartRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A703 RID: 108291 RVA: 0x003D68EB File Offset: 0x003D4AEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTraceStartRequest Clone()
		{
			return new TimelineTraceStartRequest(this);
		}

		// Token: 0x1700592D RID: 22829
		// (get) Token: 0x0601A704 RID: 108292 RVA: 0x003D68F3 File Offset: 0x003D4AF3
		// (set) Token: 0x0601A705 RID: 108293 RVA: 0x003D68FB File Offset: 0x003D4AFB
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

		// Token: 0x1700592E RID: 22830
		// (get) Token: 0x0601A706 RID: 108294 RVA: 0x003D6904 File Offset: 0x003D4B04
		// (set) Token: 0x0601A707 RID: 108295 RVA: 0x003D690C File Offset: 0x003D4B0C
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

		// Token: 0x0601A708 RID: 108296 RVA: 0x003D6915 File Offset: 0x003D4B15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimelineTraceStartRequest);
		}

		// Token: 0x0601A709 RID: 108297 RVA: 0x003D6923 File Offset: 0x003D4B23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimelineTraceStartRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A70A RID: 108298 RVA: 0x003D6964 File Offset: 0x003D4B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A70B RID: 108299 RVA: 0x003D69BC File Offset: 0x003D4BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A70C RID: 108300 RVA: 0x003D69C9 File Offset: 0x003D4BC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A70D RID: 108301 RVA: 0x003D69D4 File Offset: 0x003D4BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Index);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A70E RID: 108302 RVA: 0x003D6A2C File Offset: 0x003D4C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A70F RID: 108303 RVA: 0x003D6A84 File Offset: 0x003D4C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TimelineTraceStartRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A710 RID: 108304 RVA: 0x003D6AD4 File Offset: 0x003D4CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A711 RID: 108305 RVA: 0x003D6AE0 File Offset: 0x003D4CE0
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
					if (num != 32U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					this.Index = input.ReadInt32();
				}
			}
		}

		// Token: 0x040099E9 RID: 39401
		private UnknownFieldSet _unknownFields;

		// Token: 0x040099EA RID: 39402
		public const int EntityIdFieldNumber = 4;

		// Token: 0x040099EB RID: 39403
		private long entityId_;

		// Token: 0x040099EC RID: 39404
		public const int IndexFieldNumber = 1;

		// Token: 0x040099ED RID: 39405
		private int index_;
	}
}
