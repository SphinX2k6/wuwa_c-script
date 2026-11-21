using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005AD RID: 1453
	[NetMessage(EMessageId.FloroRanchPlayNextDayRequest)]
	public sealed class FloroRanchPlayNextDayRequest : IMessage<FloroRanchPlayNextDayRequest>, IMessage, IEquatable<FloroRanchPlayNextDayRequest>, IDeepCloneable<FloroRanchPlayNextDayRequest>, IBufferMessage
	{
		// Token: 0x060086DA RID: 34522 RVA: 0x0014590B File Offset: 0x00143B0B
		[NullableContext(1)]
		public static FloroRanchPlayNextDayRequest Create()
		{
			return new FloroRanchPlayNextDayRequest();
		}

		// Token: 0x17001A6A RID: 6762
		// (get) Token: 0x060086DB RID: 34523 RVA: 0x00145912 File Offset: 0x00143B12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A6B RID: 6763
		// (get) Token: 0x060086DC RID: 34524 RVA: 0x00145915 File Offset: 0x00143B15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayNextDayRequest.Descriptor;
			}
		}

		// Token: 0x060086DD RID: 34525 RVA: 0x0014591C File Offset: 0x00143B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayNextDayRequest()
		{
		}

		// Token: 0x060086DE RID: 34526 RVA: 0x00145924 File Offset: 0x00143B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayNextDayRequest(FloroRanchPlayNextDayRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.subInsId_ = other.subInsId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060086DF RID: 34527 RVA: 0x00145955 File Offset: 0x00143B55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayNextDayRequest Clone()
		{
			return new FloroRanchPlayNextDayRequest(this);
		}

		// Token: 0x17001A6C RID: 6764
		// (get) Token: 0x060086E0 RID: 34528 RVA: 0x0014595D File Offset: 0x00143B5D
		// (set) Token: 0x060086E1 RID: 34529 RVA: 0x00145965 File Offset: 0x00143B65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17001A6D RID: 6765
		// (get) Token: 0x060086E2 RID: 34530 RVA: 0x0014596E File Offset: 0x00143B6E
		// (set) Token: 0x060086E3 RID: 34531 RVA: 0x00145976 File Offset: 0x00143B76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SubInsId
		{
			get
			{
				return this.subInsId_;
			}
			set
			{
				this.subInsId_ = value;
			}
		}

		// Token: 0x060086E4 RID: 34532 RVA: 0x0014597F File Offset: 0x00143B7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayNextDayRequest);
		}

		// Token: 0x060086E5 RID: 34533 RVA: 0x0014598D File Offset: 0x00143B8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayNextDayRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.SubInsId == other.SubInsId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060086E6 RID: 34534 RVA: 0x001459CC File Offset: 0x00143BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.SubInsId != 0)
			{
				num ^= this.SubInsId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060086E7 RID: 34535 RVA: 0x00145A24 File Offset: 0x00143C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060086E8 RID: 34536 RVA: 0x00145A31 File Offset: 0x00143C31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060086E9 RID: 34537 RVA: 0x00145A3C File Offset: 0x00143C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ActivityId);
			}
			if (this.SubInsId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.SubInsId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060086EA RID: 34538 RVA: 0x00145A98 File Offset: 0x00143C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.SubInsId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubInsId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060086EB RID: 34539 RVA: 0x00145AF0 File Offset: 0x00143CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayNextDayRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.SubInsId != 0)
			{
				this.SubInsId = other.SubInsId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060086EC RID: 34540 RVA: 0x00145B40 File Offset: 0x00143D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060086ED RID: 34541 RVA: 0x00145B4C File Offset: 0x00143D4C
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
				if (num != 16U)
				{
					if (num != 32U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SubInsId = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004318 RID: 17176
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004319 RID: 17177
		public const int ActivityIdFieldNumber = 2;

		// Token: 0x0400431A RID: 17178
		private int activityId_;

		// Token: 0x0400431B RID: 17179
		public const int SubInsIdFieldNumber = 4;

		// Token: 0x0400431C RID: 17180
		private int subInsId_;
	}
}
