using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200111D RID: 4381
	[NetMessage(EMessageId.RoverRogueResultRequest)]
	public sealed class RoverRogueResultRequest : IMessage<RoverRogueResultRequest>, IMessage, IEquatable<RoverRogueResultRequest>, IDeepCloneable<RoverRogueResultRequest>, IBufferMessage
	{
		// Token: 0x060175EE RID: 95726 RVA: 0x003650C4 File Offset: 0x003632C4
		[NullableContext(1)]
		public static RoverRogueResultRequest Create()
		{
			return new RoverRogueResultRequest();
		}

		// Token: 0x17004E6D RID: 20077
		// (get) Token: 0x060175EF RID: 95727 RVA: 0x003650CB File Offset: 0x003632CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E6E RID: 20078
		// (get) Token: 0x060175F0 RID: 95728 RVA: 0x003650CE File Offset: 0x003632CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueResultRequest.Descriptor;
			}
		}

		// Token: 0x060175F1 RID: 95729 RVA: 0x003650D5 File Offset: 0x003632D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueResultRequest()
		{
		}

		// Token: 0x060175F2 RID: 95730 RVA: 0x003650DD File Offset: 0x003632DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueResultRequest(RoverRogueResultRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.instId_ = other.instId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060175F3 RID: 95731 RVA: 0x0036510E File Offset: 0x0036330E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueResultRequest Clone()
		{
			return new RoverRogueResultRequest(this);
		}

		// Token: 0x17004E6F RID: 20079
		// (get) Token: 0x060175F4 RID: 95732 RVA: 0x00365116 File Offset: 0x00363316
		// (set) Token: 0x060175F5 RID: 95733 RVA: 0x0036511E File Offset: 0x0036331E
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

		// Token: 0x17004E70 RID: 20080
		// (get) Token: 0x060175F6 RID: 95734 RVA: 0x00365127 File Offset: 0x00363327
		// (set) Token: 0x060175F7 RID: 95735 RVA: 0x0036512F File Offset: 0x0036332F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x060175F8 RID: 95736 RVA: 0x00365138 File Offset: 0x00363338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueResultRequest);
		}

		// Token: 0x060175F9 RID: 95737 RVA: 0x00365146 File Offset: 0x00363346
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueResultRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.InstId == other.InstId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060175FA RID: 95738 RVA: 0x00365184 File Offset: 0x00363384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060175FB RID: 95739 RVA: 0x003651DC File Offset: 0x003633DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060175FC RID: 95740 RVA: 0x003651E9 File Offset: 0x003633E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060175FD RID: 95741 RVA: 0x003651F4 File Offset: 0x003633F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActivityId);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060175FE RID: 95742 RVA: 0x00365250 File Offset: 0x00363450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060175FF RID: 95743 RVA: 0x003652A8 File Offset: 0x003634A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueResultRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017600 RID: 95744 RVA: 0x003652F8 File Offset: 0x003634F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017601 RID: 95745 RVA: 0x00365304 File Offset: 0x00363504
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
				if (num != 24U)
				{
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.InstId = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008B0B RID: 35595
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008B0C RID: 35596
		public const int ActivityIdFieldNumber = 3;

		// Token: 0x04008B0D RID: 35597
		private int activityId_;

		// Token: 0x04008B0E RID: 35598
		public const int InstIdFieldNumber = 5;

		// Token: 0x04008B0F RID: 35599
		private int instId_;
	}
}
