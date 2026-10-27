using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A7A RID: 2682
	[NetMessage(EMessageId.MotorOnlineProgressReportPush)]
	public sealed class MotorOnlineProgressReportPush : IMessage<MotorOnlineProgressReportPush>, IMessage, IEquatable<MotorOnlineProgressReportPush>, IDeepCloneable<MotorOnlineProgressReportPush>, IBufferMessage
	{
		// Token: 0x0600E9C2 RID: 59842 RVA: 0x0022206D File Offset: 0x0022026D
		[NullableContext(1)]
		public static MotorOnlineProgressReportPush Create()
		{
			return new MotorOnlineProgressReportPush();
		}

		// Token: 0x17002F6F RID: 12143
		// (get) Token: 0x0600E9C3 RID: 59843 RVA: 0x00222074 File Offset: 0x00220274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F70 RID: 12144
		// (get) Token: 0x0600E9C4 RID: 59844 RVA: 0x00222077 File Offset: 0x00220277
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOnlineProgressReportPush.Descriptor;
			}
		}

		// Token: 0x0600E9C5 RID: 59845 RVA: 0x0022207E File Offset: 0x0022027E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOnlineProgressReportPush()
		{
		}

		// Token: 0x0600E9C6 RID: 59846 RVA: 0x00222086 File Offset: 0x00220286
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOnlineProgressReportPush(MotorOnlineProgressReportPush other) : this()
		{
			this.instId_ = other.instId_;
			this.progress_ = other.progress_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E9C7 RID: 59847 RVA: 0x002220B7 File Offset: 0x002202B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOnlineProgressReportPush Clone()
		{
			return new MotorOnlineProgressReportPush(this);
		}

		// Token: 0x17002F71 RID: 12145
		// (get) Token: 0x0600E9C8 RID: 59848 RVA: 0x002220BF File Offset: 0x002202BF
		// (set) Token: 0x0600E9C9 RID: 59849 RVA: 0x002220C7 File Offset: 0x002202C7
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

		// Token: 0x17002F72 RID: 12146
		// (get) Token: 0x0600E9CA RID: 59850 RVA: 0x002220D0 File Offset: 0x002202D0
		// (set) Token: 0x0600E9CB RID: 59851 RVA: 0x002220D8 File Offset: 0x002202D8
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

		// Token: 0x0600E9CC RID: 59852 RVA: 0x002220E1 File Offset: 0x002202E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOnlineProgressReportPush);
		}

		// Token: 0x0600E9CD RID: 59853 RVA: 0x002220EF File Offset: 0x002202EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOnlineProgressReportPush other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.Progress == other.Progress && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E9CE RID: 59854 RVA: 0x00222130 File Offset: 0x00220330
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

		// Token: 0x0600E9CF RID: 59855 RVA: 0x00222188 File Offset: 0x00220388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E9D0 RID: 59856 RVA: 0x00222195 File Offset: 0x00220395
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E9D1 RID: 59857 RVA: 0x002221A0 File Offset: 0x002203A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Progress != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Progress);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E9D2 RID: 59858 RVA: 0x002221FC File Offset: 0x002203FC
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

		// Token: 0x0600E9D3 RID: 59859 RVA: 0x00222254 File Offset: 0x00220454
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

		// Token: 0x0600E9D4 RID: 59860 RVA: 0x002222A4 File Offset: 0x002204A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E9D5 RID: 59861 RVA: 0x002222B0 File Offset: 0x002204B0
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
					if (num != 64U)
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

		// Token: 0x04005F01 RID: 24321
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F02 RID: 24322
		public const int InstIdFieldNumber = 8;

		// Token: 0x04005F03 RID: 24323
		private int instId_;

		// Token: 0x04005F04 RID: 24324
		public const int ProgressFieldNumber = 4;

		// Token: 0x04005F05 RID: 24325
		private int progress_;
	}
}
