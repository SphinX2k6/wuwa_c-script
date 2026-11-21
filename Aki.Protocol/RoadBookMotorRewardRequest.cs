using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F61 RID: 3937
	[NetMessage(EMessageId.RoadBookMotorRewardRequest)]
	public sealed class RoadBookMotorRewardRequest : IMessage<RoadBookMotorRewardRequest>, IMessage, IEquatable<RoadBookMotorRewardRequest>, IDeepCloneable<RoadBookMotorRewardRequest>, IBufferMessage
	{
		// Token: 0x06015141 RID: 86337 RVA: 0x0030EFAB File Offset: 0x0030D1AB
		[NullableContext(1)]
		public static RoadBookMotorRewardRequest Create()
		{
			return new RoadBookMotorRewardRequest();
		}

		// Token: 0x17004624 RID: 17956
		// (get) Token: 0x06015142 RID: 86338 RVA: 0x0030EFB2 File Offset: 0x0030D1B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004625 RID: 17957
		// (get) Token: 0x06015143 RID: 86339 RVA: 0x0030EFB5 File Offset: 0x0030D1B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoadBookMotorRewardRequest.Descriptor;
			}
		}

		// Token: 0x06015144 RID: 86340 RVA: 0x0030EFBC File Offset: 0x0030D1BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookMotorRewardRequest()
		{
		}

		// Token: 0x06015145 RID: 86341 RVA: 0x0030EFCF File Offset: 0x0030D1CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookMotorRewardRequest(RoadBookMotorRewardRequest other) : this()
		{
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015146 RID: 86342 RVA: 0x0030EFF9 File Offset: 0x0030D1F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookMotorRewardRequest Clone()
		{
			return new RoadBookMotorRewardRequest(this);
		}

		// Token: 0x17004626 RID: 17958
		// (get) Token: 0x06015147 RID: 86343 RVA: 0x0030F001 File Offset: 0x0030D201
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x06015148 RID: 86344 RVA: 0x0030F009 File Offset: 0x0030D209
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoadBookMotorRewardRequest);
		}

		// Token: 0x06015149 RID: 86345 RVA: 0x0030F017 File Offset: 0x0030D217
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoadBookMotorRewardRequest other)
		{
			return other != null && (other == this || (this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601514A RID: 86346 RVA: 0x0030F04C File Offset: 0x0030D24C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.taskIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601514B RID: 86347 RVA: 0x0030F080 File Offset: 0x0030D280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601514C RID: 86348 RVA: 0x0030F08D File Offset: 0x0030D28D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601514D RID: 86349 RVA: 0x0030F096 File Offset: 0x0030D296
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskIds_.WriteTo(ref output, RoadBookMotorRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601514E RID: 86350 RVA: 0x0030F0C0 File Offset: 0x0030D2C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.taskIds_.CalculateSize(RoadBookMotorRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601514F RID: 86351 RVA: 0x0030F0F9 File Offset: 0x0030D2F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoadBookMotorRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.taskIds_.Add(other.taskIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015150 RID: 86352 RVA: 0x0030F127 File Offset: 0x0030D327
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015151 RID: 86353 RVA: 0x0030F130 File Offset: 0x0030D330
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
				if (num != 48U && num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.taskIds_.AddEntriesFrom(ref input, RoadBookMotorRewardRequest._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x04007F4E RID: 32590
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F4F RID: 32591
		public const int TaskIdsFieldNumber = 6;

		// Token: 0x04007F50 RID: 32592
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04007F51 RID: 32593
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
