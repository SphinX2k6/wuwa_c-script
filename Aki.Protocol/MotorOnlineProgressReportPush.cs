using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A69 RID: 2665
	[NetMessage(EMessageId.MotorOnlineProgressReportPush)]
	public sealed class MotorOnlineProgressReportPush : IMessage<MotorOnlineProgressReportPush>, IMessage, IEquatable<MotorOnlineProgressReportPush>, IDeepCloneable<MotorOnlineProgressReportPush>, IBufferMessage
	{
		// Token: 0x0600E8A8 RID: 59560 RVA: 0x0021FE79 File Offset: 0x0021E079
		[NullableContext(1)]
		public static MotorOnlineProgressReportPush Create()
		{
			return new MotorOnlineProgressReportPush();
		}

		// Token: 0x17002F31 RID: 12081
		// (get) Token: 0x0600E8A9 RID: 59561 RVA: 0x0021FE80 File Offset: 0x0021E080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F32 RID: 12082
		// (get) Token: 0x0600E8AA RID: 59562 RVA: 0x0021FE83 File Offset: 0x0021E083
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOnlineProgressReportPush.Descriptor;
			}
		}

		// Token: 0x0600E8AB RID: 59563 RVA: 0x0021FE8A File Offset: 0x0021E08A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOnlineProgressReportPush()
		{
		}

		// Token: 0x0600E8AC RID: 59564 RVA: 0x0021FE92 File Offset: 0x0021E092
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOnlineProgressReportPush(MotorOnlineProgressReportPush other) : this()
		{
			this.instId_ = other.instId_;
			this.progress_ = other.progress_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E8AD RID: 59565 RVA: 0x0021FEC3 File Offset: 0x0021E0C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOnlineProgressReportPush Clone()
		{
			return new MotorOnlineProgressReportPush(this);
		}

		// Token: 0x17002F33 RID: 12083
		// (get) Token: 0x0600E8AE RID: 59566 RVA: 0x0021FECB File Offset: 0x0021E0CB
		// (set) Token: 0x0600E8AF RID: 59567 RVA: 0x0021FED3 File Offset: 0x0021E0D3
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

		// Token: 0x17002F34 RID: 12084
		// (get) Token: 0x0600E8B0 RID: 59568 RVA: 0x0021FEDC File Offset: 0x0021E0DC
		// (set) Token: 0x0600E8B1 RID: 59569 RVA: 0x0021FEE4 File Offset: 0x0021E0E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Progress
		{
			get
			{
				return this.progress_;
			}
			set
			{
				this.progress_ = value;
			}
		}

		// Token: 0x0600E8B2 RID: 59570 RVA: 0x0021FEED File Offset: 0x0021E0ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOnlineProgressReportPush);
		}

		// Token: 0x0600E8B3 RID: 59571 RVA: 0x0021FEFB File Offset: 0x0021E0FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOnlineProgressReportPush other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.Progress == other.Progress && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E8B4 RID: 59572 RVA: 0x0021FF3C File Offset: 0x0021E13C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.Progress != 0)
			{
				num ^= this.Progress.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E8B5 RID: 59573 RVA: 0x0021FF94 File Offset: 0x0021E194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E8B6 RID: 59574 RVA: 0x0021FFA1 File Offset: 0x0021E1A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E8B7 RID: 59575 RVA: 0x0021FFAC File Offset: 0x0021E1AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Progress != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Progress);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E8B8 RID: 59576 RVA: 0x00220004 File Offset: 0x0021E204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.Progress != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Progress);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E8B9 RID: 59577 RVA: 0x0022005C File Offset: 0x0021E25C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorOnlineProgressReportPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.Progress != 0)
			{
				this.Progress = other.Progress;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E8BA RID: 59578 RVA: 0x002200AC File Offset: 0x0021E2AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E8BB RID: 59579 RVA: 0x002200B8 File Offset: 0x0021E2B8
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
					if (num != 88U)
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
					this.Progress = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005F0A RID: 24330
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F0B RID: 24331
		public const int InstIdFieldNumber = 11;

		// Token: 0x04005F0C RID: 24332
		private int instId_;

		// Token: 0x04005F0D RID: 24333
		public const int ProgressFieldNumber = 1;

		// Token: 0x04005F0E RID: 24334
		private int progress_;
	}
}
