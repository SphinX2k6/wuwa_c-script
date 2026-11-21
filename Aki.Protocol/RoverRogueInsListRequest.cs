using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001143 RID: 4419
	[NetMessage(EMessageId.RoverRogueInsListRequest)]
	public sealed class RoverRogueInsListRequest : IMessage<RoverRogueInsListRequest>, IMessage, IEquatable<RoverRogueInsListRequest>, IDeepCloneable<RoverRogueInsListRequest>, IBufferMessage
	{
		// Token: 0x060179D1 RID: 96721 RVA: 0x00370016 File Offset: 0x0036E216
		[NullableContext(1)]
		public static RoverRogueInsListRequest Create()
		{
			return new RoverRogueInsListRequest();
		}

		// Token: 0x17004F6F RID: 20335
		// (get) Token: 0x060179D2 RID: 96722 RVA: 0x0037001D File Offset: 0x0036E21D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F70 RID: 20336
		// (get) Token: 0x060179D3 RID: 96723 RVA: 0x00370020 File Offset: 0x0036E220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueInsListRequest.Descriptor;
			}
		}

		// Token: 0x060179D4 RID: 96724 RVA: 0x00370027 File Offset: 0x0036E227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueInsListRequest()
		{
		}

		// Token: 0x060179D5 RID: 96725 RVA: 0x0037002F File Offset: 0x0036E22F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueInsListRequest(RoverRogueInsListRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060179D6 RID: 96726 RVA: 0x00370054 File Offset: 0x0036E254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueInsListRequest Clone()
		{
			return new RoverRogueInsListRequest(this);
		}

		// Token: 0x17004F71 RID: 20337
		// (get) Token: 0x060179D7 RID: 96727 RVA: 0x0037005C File Offset: 0x0036E25C
		// (set) Token: 0x060179D8 RID: 96728 RVA: 0x00370064 File Offset: 0x0036E264
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

		// Token: 0x060179D9 RID: 96729 RVA: 0x0037006D File Offset: 0x0036E26D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueInsListRequest);
		}

		// Token: 0x060179DA RID: 96730 RVA: 0x0037007B File Offset: 0x0036E27B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueInsListRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060179DB RID: 96731 RVA: 0x003700AC File Offset: 0x0036E2AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060179DC RID: 96732 RVA: 0x003700EB File Offset: 0x0036E2EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060179DD RID: 96733 RVA: 0x003700F8 File Offset: 0x0036E2F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060179DE RID: 96734 RVA: 0x00370101 File Offset: 0x0036E301
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060179DF RID: 96735 RVA: 0x00370134 File Offset: 0x0036E334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060179E0 RID: 96736 RVA: 0x00370172 File Offset: 0x0036E372
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueInsListRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060179E1 RID: 96737 RVA: 0x003701A3 File Offset: 0x0036E3A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060179E2 RID: 96738 RVA: 0x003701AC File Offset: 0x0036E3AC
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008CFF RID: 36095
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008D00 RID: 36096
		public const int ActivityIdFieldNumber = 4;

		// Token: 0x04008D01 RID: 36097
		private int activityId_;
	}
}
