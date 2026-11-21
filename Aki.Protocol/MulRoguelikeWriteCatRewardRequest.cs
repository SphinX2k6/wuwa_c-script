using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AD5 RID: 2773
	[NetMessage(EMessageId.MulRoguelikeWriteCatRewardRequest)]
	public sealed class MulRoguelikeWriteCatRewardRequest : IMessage<MulRoguelikeWriteCatRewardRequest>, IMessage, IEquatable<MulRoguelikeWriteCatRewardRequest>, IDeepCloneable<MulRoguelikeWriteCatRewardRequest>, IBufferMessage
	{
		// Token: 0x0600F18B RID: 61835 RVA: 0x002349A4 File Offset: 0x00232BA4
		[NullableContext(1)]
		public static MulRoguelikeWriteCatRewardRequest Create()
		{
			return new MulRoguelikeWriteCatRewardRequest();
		}

		// Token: 0x17003128 RID: 12584
		// (get) Token: 0x0600F18C RID: 61836 RVA: 0x002349AB File Offset: 0x00232BAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003129 RID: 12585
		// (get) Token: 0x0600F18D RID: 61837 RVA: 0x002349AE File Offset: 0x00232BAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MulRoguelikeWriteCatRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600F18E RID: 61838 RVA: 0x002349B5 File Offset: 0x00232BB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulRoguelikeWriteCatRewardRequest()
		{
		}

		// Token: 0x0600F18F RID: 61839 RVA: 0x002349C8 File Offset: 0x00232BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulRoguelikeWriteCatRewardRequest(MulRoguelikeWriteCatRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.index_ = other.index_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F190 RID: 61840 RVA: 0x002349FE File Offset: 0x00232BFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulRoguelikeWriteCatRewardRequest Clone()
		{
			return new MulRoguelikeWriteCatRewardRequest(this);
		}

		// Token: 0x1700312A RID: 12586
		// (get) Token: 0x0600F191 RID: 61841 RVA: 0x00234A06 File Offset: 0x00232C06
		// (set) Token: 0x0600F192 RID: 61842 RVA: 0x00234A0E File Offset: 0x00232C0E
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

		// Token: 0x1700312B RID: 12587
		// (get) Token: 0x0600F193 RID: 61843 RVA: 0x00234A17 File Offset: 0x00232C17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Index
		{
			get
			{
				return this.index_;
			}
		}

		// Token: 0x0600F194 RID: 61844 RVA: 0x00234A1F File Offset: 0x00232C1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MulRoguelikeWriteCatRewardRequest);
		}

		// Token: 0x0600F195 RID: 61845 RVA: 0x00234A30 File Offset: 0x00232C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MulRoguelikeWriteCatRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.index_.Equals(other.index_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F196 RID: 61846 RVA: 0x00234A80 File Offset: 0x00232C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.index_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F197 RID: 61847 RVA: 0x00234ACD File Offset: 0x00232CCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F198 RID: 61848 RVA: 0x00234ADA File Offset: 0x00232CDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F199 RID: 61849 RVA: 0x00234AE4 File Offset: 0x00232CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.index_.WriteTo(ref output, MulRoguelikeWriteCatRewardRequest._repeated_index_codec);
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

		// Token: 0x0600F19A RID: 61850 RVA: 0x00234B34 File Offset: 0x00232D34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.index_.CalculateSize(MulRoguelikeWriteCatRewardRequest._repeated_index_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F19B RID: 61851 RVA: 0x00234B88 File Offset: 0x00232D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MulRoguelikeWriteCatRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.index_.Add(other.index_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F19C RID: 61852 RVA: 0x00234BD5 File Offset: 0x00232DD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F19D RID: 61853 RVA: 0x00234BE0 File Offset: 0x00232DE0
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
				if (num != 8U && num != 10U)
				{
					if (num != 32U)
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
					this.index_.AddEntriesFrom(ref input, MulRoguelikeWriteCatRewardRequest._repeated_index_codec);
				}
			}
		}

		// Token: 0x040061E5 RID: 25061
		private UnknownFieldSet _unknownFields;

		// Token: 0x040061E6 RID: 25062
		public const int ActivityIdFieldNumber = 4;

		// Token: 0x040061E7 RID: 25063
		private int activityId_;

		// Token: 0x040061E8 RID: 25064
		public const int IndexFieldNumber = 1;

		// Token: 0x040061E9 RID: 25065
		private static readonly FieldCodec<int> _repeated_index_codec = FieldCodec.ForInt32(10U);

		// Token: 0x040061EA RID: 25066
		private readonly RepeatedField<int> index_ = new RepeatedField<int>();
	}
}
