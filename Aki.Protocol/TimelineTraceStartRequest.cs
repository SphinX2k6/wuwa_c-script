using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013E6 RID: 5094
	[NetMessage(EMessageId.TimelineTraceStartRequest)]
	public sealed class TimelineTraceStartRequest : IMessage<TimelineTraceStartRequest>, IMessage, IEquatable<TimelineTraceStartRequest>, IDeepCloneable<TimelineTraceStartRequest>, IBufferMessage
	{
		// Token: 0x0601B187 RID: 110983 RVA: 0x003F1AB1 File Offset: 0x003EFCB1
		[NullableContext(1)]
		public static TimelineTraceStartRequest Create()
		{
			return new TimelineTraceStartRequest();
		}

		// Token: 0x17005BBF RID: 23487
		// (get) Token: 0x0601B188 RID: 110984 RVA: 0x003F1AB8 File Offset: 0x003EFCB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005BC0 RID: 23488
		// (get) Token: 0x0601B189 RID: 110985 RVA: 0x003F1ABB File Offset: 0x003EFCBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimelineTraceStartRequest.Descriptor;
			}
		}

		// Token: 0x0601B18A RID: 110986 RVA: 0x003F1AC2 File Offset: 0x003EFCC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTraceStartRequest()
		{
		}

		// Token: 0x0601B18B RID: 110987 RVA: 0x003F1ACA File Offset: 0x003EFCCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTraceStartRequest(TimelineTraceStartRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B18C RID: 110988 RVA: 0x003F1AFB File Offset: 0x003EFCFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTraceStartRequest Clone()
		{
			return new TimelineTraceStartRequest(this);
		}

		// Token: 0x17005BC1 RID: 23489
		// (get) Token: 0x0601B18D RID: 110989 RVA: 0x003F1B03 File Offset: 0x003EFD03
		// (set) Token: 0x0601B18E RID: 110990 RVA: 0x003F1B0B File Offset: 0x003EFD0B
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

		// Token: 0x17005BC2 RID: 23490
		// (get) Token: 0x0601B18F RID: 110991 RVA: 0x003F1B14 File Offset: 0x003EFD14
		// (set) Token: 0x0601B190 RID: 110992 RVA: 0x003F1B1C File Offset: 0x003EFD1C
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

		// Token: 0x0601B191 RID: 110993 RVA: 0x003F1B25 File Offset: 0x003EFD25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimelineTraceStartRequest);
		}

		// Token: 0x0601B192 RID: 110994 RVA: 0x003F1B33 File Offset: 0x003EFD33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimelineTraceStartRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B193 RID: 110995 RVA: 0x003F1B74 File Offset: 0x003EFD74
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

		// Token: 0x0601B194 RID: 110996 RVA: 0x003F1BCC File Offset: 0x003EFDCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B195 RID: 110997 RVA: 0x003F1BD9 File Offset: 0x003EFDD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B196 RID: 110998 RVA: 0x003F1BE4 File Offset: 0x003EFDE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.EntityId);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B197 RID: 110999 RVA: 0x003F1C40 File Offset: 0x003EFE40
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

		// Token: 0x0601B198 RID: 111000 RVA: 0x003F1C98 File Offset: 0x003EFE98
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

		// Token: 0x0601B199 RID: 111001 RVA: 0x003F1CE8 File Offset: 0x003EFEE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B19A RID: 111002 RVA: 0x003F1CF4 File Offset: 0x003EFEF4
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
				if (num != 40U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Index = input.ReadInt32();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04009E2E RID: 40494
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E2F RID: 40495
		public const int EntityIdFieldNumber = 5;

		// Token: 0x04009E30 RID: 40496
		private long entityId_;

		// Token: 0x04009E31 RID: 40497
		public const int IndexFieldNumber = 13;

		// Token: 0x04009E32 RID: 40498
		private int index_;
	}
}
