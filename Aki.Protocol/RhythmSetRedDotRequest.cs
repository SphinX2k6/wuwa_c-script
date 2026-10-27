using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F46 RID: 3910
	[NetMessage(EMessageId.RhythmSetRedDotRequest)]
	public sealed class RhythmSetRedDotRequest : IMessage<RhythmSetRedDotRequest>, IMessage, IEquatable<RhythmSetRedDotRequest>, IDeepCloneable<RhythmSetRedDotRequest>, IBufferMessage
	{
		// Token: 0x06014EB7 RID: 85687 RVA: 0x00308F90 File Offset: 0x00307190
		[NullableContext(1)]
		public static RhythmSetRedDotRequest Create()
		{
			return new RhythmSetRedDotRequest();
		}

		// Token: 0x17004592 RID: 17810
		// (get) Token: 0x06014EB8 RID: 85688 RVA: 0x00308F97 File Offset: 0x00307197
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004593 RID: 17811
		// (get) Token: 0x06014EB9 RID: 85689 RVA: 0x00308F9A File Offset: 0x0030719A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmSetRedDotRequest.Descriptor;
			}
		}

		// Token: 0x06014EBA RID: 85690 RVA: 0x00308FA1 File Offset: 0x003071A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmSetRedDotRequest()
		{
		}

		// Token: 0x06014EBB RID: 85691 RVA: 0x00308FAC File Offset: 0x003071AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmSetRedDotRequest(RhythmSetRedDotRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.redDot_ = ((other.redDot_ != null) ? other.redDot_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014EBC RID: 85692 RVA: 0x00308FF8 File Offset: 0x003071F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmSetRedDotRequest Clone()
		{
			return new RhythmSetRedDotRequest(this);
		}

		// Token: 0x17004594 RID: 17812
		// (get) Token: 0x06014EBD RID: 85693 RVA: 0x00309000 File Offset: 0x00307200
		// (set) Token: 0x06014EBE RID: 85694 RVA: 0x00309008 File Offset: 0x00307208
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

		// Token: 0x17004595 RID: 17813
		// (get) Token: 0x06014EBF RID: 85695 RVA: 0x00309011 File Offset: 0x00307211
		// (set) Token: 0x06014EC0 RID: 85696 RVA: 0x00309019 File Offset: 0x00307219
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

		// Token: 0x06014EC1 RID: 85697 RVA: 0x00309022 File Offset: 0x00307222
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmSetRedDotRequest);
		}

		// Token: 0x06014EC2 RID: 85698 RVA: 0x00309030 File Offset: 0x00307230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmSetRedDotRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this.RedDot, other.RedDot) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014EC3 RID: 85699 RVA: 0x00309080 File Offset: 0x00307280
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

		// Token: 0x06014EC4 RID: 85700 RVA: 0x003090D5 File Offset: 0x003072D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014EC5 RID: 85701 RVA: 0x003090E2 File Offset: 0x003072E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014EC6 RID: 85702 RVA: 0x003090EC File Offset: 0x003072EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.redDot_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.RedDot);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014EC7 RID: 85703 RVA: 0x00309148 File Offset: 0x00307348
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

		// Token: 0x06014EC8 RID: 85704 RVA: 0x003091A0 File Offset: 0x003073A0
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

		// Token: 0x06014EC9 RID: 85705 RVA: 0x00309208 File Offset: 0x00307408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014ECA RID: 85706 RVA: 0x00309214 File Offset: 0x00307414
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
				if (num != 10U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
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
		}

		// Token: 0x04007E2A RID: 32298
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E2B RID: 32299
		public const int ActivityIdFieldNumber = 10;

		// Token: 0x04007E2C RID: 32300
		private int activityId_;

		// Token: 0x04007E2D RID: 32301
		public const int RedDotFieldNumber = 1;

		// Token: 0x04007E2E RID: 32302
		private RhythmRedDotPb redDot_;
	}
}
