using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200090A RID: 2314
	public sealed class LiftMoveTypeCustomSpeedPb : IMessage<LiftMoveTypeCustomSpeedPb>, IMessage, IEquatable<LiftMoveTypeCustomSpeedPb>, IDeepCloneable<LiftMoveTypeCustomSpeedPb>, IBufferMessage
	{
		// Token: 0x0600CC8E RID: 52366 RVA: 0x001E28AC File Offset: 0x001E0AAC
		[NullableContext(1)]
		public static LiftMoveTypeCustomSpeedPb Create()
		{
			return new LiftMoveTypeCustomSpeedPb();
		}

		// Token: 0x17002949 RID: 10569
		// (get) Token: 0x0600CC8F RID: 52367 RVA: 0x001E28B3 File Offset: 0x001E0AB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700294A RID: 10570
		// (get) Token: 0x0600CC90 RID: 52368 RVA: 0x001E28B6 File Offset: 0x001E0AB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LiftMoveTypeCustomSpeedPb.Descriptor;
			}
		}

		// Token: 0x0600CC91 RID: 52369 RVA: 0x001E28BD File Offset: 0x001E0ABD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LiftMoveTypeCustomSpeedPb()
		{
		}

		// Token: 0x0600CC92 RID: 52370 RVA: 0x001E28D0 File Offset: 0x001E0AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LiftMoveTypeCustomSpeedPb(LiftMoveTypeCustomSpeedPb other) : this()
		{
			this.totalTime_ = other.totalTime_;
			this.timePathCurve_ = other.timePathCurve_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CC93 RID: 52371 RVA: 0x001E2901 File Offset: 0x001E0B01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LiftMoveTypeCustomSpeedPb Clone()
		{
			return new LiftMoveTypeCustomSpeedPb(this);
		}

		// Token: 0x1700294B RID: 10571
		// (get) Token: 0x0600CC94 RID: 52372 RVA: 0x001E2909 File Offset: 0x001E0B09
		// (set) Token: 0x0600CC95 RID: 52373 RVA: 0x001E2911 File Offset: 0x001E0B11
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

		// Token: 0x1700294C RID: 10572
		// (get) Token: 0x0600CC96 RID: 52374 RVA: 0x001E291A File Offset: 0x001E0B1A
		// (set) Token: 0x0600CC97 RID: 52375 RVA: 0x001E2922 File Offset: 0x001E0B22
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

		// Token: 0x0600CC98 RID: 52376 RVA: 0x001E2935 File Offset: 0x001E0B35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LiftMoveTypeCustomSpeedPb);
		}

		// Token: 0x0600CC99 RID: 52377 RVA: 0x001E2944 File Offset: 0x001E0B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LiftMoveTypeCustomSpeedPb other)
		{
			return other != null && (other == this || (ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.TotalTime, other.TotalTime) && !(this.TimePathCurve != other.TimePathCurve) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CC9A RID: 52378 RVA: 0x001E299C File Offset: 0x001E0B9C
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

		// Token: 0x0600CC9B RID: 52379 RVA: 0x001E29FD File Offset: 0x001E0BFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CC9C RID: 52380 RVA: 0x001E2A0A File Offset: 0x001E0C0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CC9D RID: 52381 RVA: 0x001E2A14 File Offset: 0x001E0C14
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

		// Token: 0x0600CC9E RID: 52382 RVA: 0x001E2A78 File Offset: 0x001E0C78
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

		// Token: 0x0600CC9F RID: 52383 RVA: 0x001E2ACC File Offset: 0x001E0CCC
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

		// Token: 0x0600CCA0 RID: 52384 RVA: 0x001E2B26 File Offset: 0x001E0D26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CCA1 RID: 52385 RVA: 0x001E2B30 File Offset: 0x001E0D30
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

		// Token: 0x04005709 RID: 22281
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400570A RID: 22282
		public const int TotalTimeFieldNumber = 1;

		// Token: 0x0400570B RID: 22283
		private float totalTime_;

		// Token: 0x0400570C RID: 22284
		public const int TimePathCurveFieldNumber = 2;

		// Token: 0x0400570D RID: 22285
		private string timePathCurve_ = "";
	}
}
