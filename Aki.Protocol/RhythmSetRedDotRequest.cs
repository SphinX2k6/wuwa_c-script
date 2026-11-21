using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F36 RID: 3894
	[NetMessage(EMessageId.RhythmSetRedDotRequest)]
	public sealed class RhythmSetRedDotRequest : IMessage<RhythmSetRedDotRequest>, IMessage, IEquatable<RhythmSetRedDotRequest>, IDeepCloneable<RhythmSetRedDotRequest>, IBufferMessage
	{
		// Token: 0x06014DD2 RID: 85458 RVA: 0x003078D4 File Offset: 0x00305AD4
		[NullableContext(1)]
		public static RhythmSetRedDotRequest Create()
		{
			return new RhythmSetRedDotRequest();
		}

		// Token: 0x17004568 RID: 17768
		// (get) Token: 0x06014DD3 RID: 85459 RVA: 0x003078DB File Offset: 0x00305ADB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004569 RID: 17769
		// (get) Token: 0x06014DD4 RID: 85460 RVA: 0x003078DE File Offset: 0x00305ADE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmSetRedDotRequest.Descriptor;
			}
		}

		// Token: 0x06014DD5 RID: 85461 RVA: 0x003078E5 File Offset: 0x00305AE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmSetRedDotRequest()
		{
		}

		// Token: 0x06014DD6 RID: 85462 RVA: 0x003078F0 File Offset: 0x00305AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmSetRedDotRequest(RhythmSetRedDotRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.redDot_ = ((other.redDot_ != null) ? other.redDot_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014DD7 RID: 85463 RVA: 0x0030793C File Offset: 0x00305B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmSetRedDotRequest Clone()
		{
			return new RhythmSetRedDotRequest(this);
		}

		// Token: 0x1700456A RID: 17770
		// (get) Token: 0x06014DD8 RID: 85464 RVA: 0x00307944 File Offset: 0x00305B44
		// (set) Token: 0x06014DD9 RID: 85465 RVA: 0x0030794C File Offset: 0x00305B4C
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

		// Token: 0x1700456B RID: 17771
		// (get) Token: 0x06014DDA RID: 85466 RVA: 0x00307955 File Offset: 0x00305B55
		// (set) Token: 0x06014DDB RID: 85467 RVA: 0x0030795D File Offset: 0x00305B5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmRedDotPb RedDot
		{
			get
			{
				return this.redDot_;
			}
			set
			{
				this.redDot_ = value;
			}
		}

		// Token: 0x06014DDC RID: 85468 RVA: 0x00307966 File Offset: 0x00305B66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmSetRedDotRequest);
		}

		// Token: 0x06014DDD RID: 85469 RVA: 0x00307974 File Offset: 0x00305B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmSetRedDotRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this.RedDot, other.RedDot) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014DDE RID: 85470 RVA: 0x003079C4 File Offset: 0x00305BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.redDot_ != null)
			{
				num ^= this.RedDot.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014DDF RID: 85471 RVA: 0x00307A19 File Offset: 0x00305C19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014DE0 RID: 85472 RVA: 0x00307A26 File Offset: 0x00305C26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014DE1 RID: 85473 RVA: 0x00307A30 File Offset: 0x00305C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ActivityId);
			}
			if (this.redDot_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.RedDot);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014DE2 RID: 85474 RVA: 0x00307A8C File Offset: 0x00305C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.redDot_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RedDot);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014DE3 RID: 85475 RVA: 0x00307AE4 File Offset: 0x00305CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RhythmSetRedDotRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.redDot_ != null)
			{
				if (this.redDot_ == null)
				{
					this.RedDot = new RhythmRedDotPb();
				}
				this.RedDot.MergeFrom(other.RedDot);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014DE4 RID: 85476 RVA: 0x00307B4C File Offset: 0x00305D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014DE5 RID: 85477 RVA: 0x00307B58 File Offset: 0x00305D58
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
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.redDot_ == null)
						{
							this.RedDot = new RhythmRedDotPb();
						}
						input.ReadMessage(this.RedDot);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007E54 RID: 32340
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E55 RID: 32341
		public const int ActivityIdFieldNumber = 5;

		// Token: 0x04007E56 RID: 32342
		private int activityId_;

		// Token: 0x04007E57 RID: 32343
		public const int RedDotFieldNumber = 12;

		// Token: 0x04007E58 RID: 32344
		private RhythmRedDotPb redDot_;
	}
}
