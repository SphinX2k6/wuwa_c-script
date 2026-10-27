using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200091B RID: 2331
	public sealed class LiftMoveTypeCustomSpeedPb : IMessage<LiftMoveTypeCustomSpeedPb>, IMessage, IEquatable<LiftMoveTypeCustomSpeedPb>, IDeepCloneable<LiftMoveTypeCustomSpeedPb>, IBufferMessage
	{
		// Token: 0x0600CDAA RID: 52650 RVA: 0x001E4B7C File Offset: 0x001E2D7C
		[NullableContext(1)]
		public static LiftMoveTypeCustomSpeedPb Create()
		{
			return new LiftMoveTypeCustomSpeedPb();
		}

		// Token: 0x17002988 RID: 10632
		// (get) Token: 0x0600CDAB RID: 52651 RVA: 0x001E4B83 File Offset: 0x001E2D83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002989 RID: 10633
		// (get) Token: 0x0600CDAC RID: 52652 RVA: 0x001E4B86 File Offset: 0x001E2D86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LiftMoveTypeCustomSpeedPb.Descriptor;
			}
		}

		// Token: 0x0600CDAD RID: 52653 RVA: 0x001E4B8D File Offset: 0x001E2D8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LiftMoveTypeCustomSpeedPb()
		{
		}

		// Token: 0x0600CDAE RID: 52654 RVA: 0x001E4BA0 File Offset: 0x001E2DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LiftMoveTypeCustomSpeedPb(LiftMoveTypeCustomSpeedPb other) : this()
		{
			this.totalTime_ = other.totalTime_;
			this.timePathCurve_ = other.timePathCurve_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CDAF RID: 52655 RVA: 0x001E4BD1 File Offset: 0x001E2DD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LiftMoveTypeCustomSpeedPb Clone()
		{
			return new LiftMoveTypeCustomSpeedPb(this);
		}

		// Token: 0x1700298A RID: 10634
		// (get) Token: 0x0600CDB0 RID: 52656 RVA: 0x001E4BD9 File Offset: 0x001E2DD9
		// (set) Token: 0x0600CDB1 RID: 52657 RVA: 0x001E4BE1 File Offset: 0x001E2DE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float TotalTime
		{
			get
			{
				return this.totalTime_;
			}
			set
			{
				this.totalTime_ = value;
			}
		}

		// Token: 0x1700298B RID: 10635
		// (get) Token: 0x0600CDB2 RID: 52658 RVA: 0x001E4BEA File Offset: 0x001E2DEA
		// (set) Token: 0x0600CDB3 RID: 52659 RVA: 0x001E4BF2 File Offset: 0x001E2DF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string TimePathCurve
		{
			get
			{
				return this.timePathCurve_;
			}
			set
			{
				this.timePathCurve_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0600CDB4 RID: 52660 RVA: 0x001E4C05 File Offset: 0x001E2E05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LiftMoveTypeCustomSpeedPb);
		}

		// Token: 0x0600CDB5 RID: 52661 RVA: 0x001E4C14 File Offset: 0x001E2E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LiftMoveTypeCustomSpeedPb other)
		{
			return other != null && (other == this || (ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.TotalTime, other.TotalTime) && !(this.TimePathCurve != other.TimePathCurve) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CDB6 RID: 52662 RVA: 0x001E4C6C File Offset: 0x001E2E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TotalTime != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.TotalTime);
			}
			if (this.TimePathCurve.Length != 0)
			{
				num ^= this.TimePathCurve.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CDB7 RID: 52663 RVA: 0x001E4CCD File Offset: 0x001E2ECD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CDB8 RID: 52664 RVA: 0x001E4CDA File Offset: 0x001E2EDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CDB9 RID: 52665 RVA: 0x001E4CE4 File Offset: 0x001E2EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TotalTime != 0f)
			{
				output.WriteRawTag(13);
				output.WriteFloat(this.TotalTime);
			}
			if (this.TimePathCurve.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.TimePathCurve);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CDBA RID: 52666 RVA: 0x001E4D48 File Offset: 0x001E2F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TotalTime != 0f)
			{
				num += 5;
			}
			if (this.TimePathCurve.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.TimePathCurve);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CDBB RID: 52667 RVA: 0x001E4D9C File Offset: 0x001E2F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LiftMoveTypeCustomSpeedPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TotalTime != 0f)
			{
				this.TotalTime = other.TotalTime;
			}
			if (other.TimePathCurve.Length != 0)
			{
				this.TimePathCurve = other.TimePathCurve;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CDBC RID: 52668 RVA: 0x001E4DF6 File Offset: 0x001E2FF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CDBD RID: 52669 RVA: 0x001E4E00 File Offset: 0x001E3000
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
				if (num != 13U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TimePathCurve = input.ReadString();
					}
				}
				else
				{
					this.TotalTime = input.ReadFloat();
				}
			}
		}

		// Token: 0x04005702 RID: 22274
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005703 RID: 22275
		public const int TotalTimeFieldNumber = 1;

		// Token: 0x04005704 RID: 22276
		private float totalTime_;

		// Token: 0x04005705 RID: 22277
		public const int TimePathCurveFieldNumber = 2;

		// Token: 0x04005706 RID: 22278
		private string timePathCurve_ = "";
	}
}
