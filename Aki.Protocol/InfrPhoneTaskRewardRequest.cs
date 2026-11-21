using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007D7 RID: 2007
	[NetMessage(EMessageId.InfrPhoneTaskRewardRequest)]
	public sealed class InfrPhoneTaskRewardRequest : IMessage<InfrPhoneTaskRewardRequest>, IMessage, IEquatable<InfrPhoneTaskRewardRequest>, IDeepCloneable<InfrPhoneTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x0600B47F RID: 46207 RVA: 0x001AFA16 File Offset: 0x001ADC16
		[NullableContext(1)]
		public static InfrPhoneTaskRewardRequest Create()
		{
			return new InfrPhoneTaskRewardRequest();
		}

		// Token: 0x17002462 RID: 9314
		// (get) Token: 0x0600B480 RID: 46208 RVA: 0x001AFA1D File Offset: 0x001ADC1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002463 RID: 9315
		// (get) Token: 0x0600B481 RID: 46209 RVA: 0x001AFA20 File Offset: 0x001ADC20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrPhoneTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600B482 RID: 46210 RVA: 0x001AFA27 File Offset: 0x001ADC27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrPhoneTaskRewardRequest()
		{
		}

		// Token: 0x0600B483 RID: 46211 RVA: 0x001AFA3A File Offset: 0x001ADC3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrPhoneTaskRewardRequest(InfrPhoneTaskRewardRequest other) : this()
		{
			this.targetIds_ = other.targetIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B484 RID: 46212 RVA: 0x001AFA64 File Offset: 0x001ADC64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrPhoneTaskRewardRequest Clone()
		{
			return new InfrPhoneTaskRewardRequest(this);
		}

		// Token: 0x17002464 RID: 9316
		// (get) Token: 0x0600B485 RID: 46213 RVA: 0x001AFA6C File Offset: 0x001ADC6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TargetIds
		{
			get
			{
				return this.targetIds_;
			}
		}

		// Token: 0x0600B486 RID: 46214 RVA: 0x001AFA74 File Offset: 0x001ADC74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrPhoneTaskRewardRequest);
		}

		// Token: 0x0600B487 RID: 46215 RVA: 0x001AFA82 File Offset: 0x001ADC82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrPhoneTaskRewardRequest other)
		{
			return other != null && (other == this || (this.targetIds_.Equals(other.targetIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B488 RID: 46216 RVA: 0x001AFAB8 File Offset: 0x001ADCB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.targetIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B489 RID: 46217 RVA: 0x001AFAEC File Offset: 0x001ADCEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B48A RID: 46218 RVA: 0x001AFAF9 File Offset: 0x001ADCF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B48B RID: 46219 RVA: 0x001AFB02 File Offset: 0x001ADD02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.targetIds_.WriteTo(ref output, InfrPhoneTaskRewardRequest._repeated_targetIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B48C RID: 46220 RVA: 0x001AFB2C File Offset: 0x001ADD2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.targetIds_.CalculateSize(InfrPhoneTaskRewardRequest._repeated_targetIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B48D RID: 46221 RVA: 0x001AFB65 File Offset: 0x001ADD65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrPhoneTaskRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.targetIds_.Add(other.targetIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B48E RID: 46222 RVA: 0x001AFB93 File Offset: 0x001ADD93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B48F RID: 46223 RVA: 0x001AFB9C File Offset: 0x001ADD9C
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
				if (num != 32U && num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.targetIds_.AddEntriesFrom(ref input, InfrPhoneTaskRewardRequest._repeated_targetIds_codec);
				}
			}
		}

		// Token: 0x0400509E RID: 20638
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400509F RID: 20639
		public const int TargetIdsFieldNumber = 4;

		// Token: 0x040050A0 RID: 20640
		private static readonly FieldCodec<int> _repeated_targetIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x040050A1 RID: 20641
		private readonly RepeatedField<int> targetIds_ = new RepeatedField<int>();
	}
}
