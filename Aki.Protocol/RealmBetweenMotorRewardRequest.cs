using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E91 RID: 3729
	[NetMessage(EMessageId.RealmBetweenMotorRewardRequest)]
	public sealed class RealmBetweenMotorRewardRequest : IMessage<RealmBetweenMotorRewardRequest>, IMessage, IEquatable<RealmBetweenMotorRewardRequest>, IDeepCloneable<RealmBetweenMotorRewardRequest>, IBufferMessage
	{
		// Token: 0x060140C3 RID: 82115 RVA: 0x002EBB87 File Offset: 0x002E9D87
		[NullableContext(1)]
		public static RealmBetweenMotorRewardRequest Create()
		{
			return new RealmBetweenMotorRewardRequest();
		}

		// Token: 0x170042B6 RID: 17078
		// (get) Token: 0x060140C4 RID: 82116 RVA: 0x002EBB8E File Offset: 0x002E9D8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042B7 RID: 17079
		// (get) Token: 0x060140C5 RID: 82117 RVA: 0x002EBB91 File Offset: 0x002E9D91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RealmBetweenMotorRewardRequest.Descriptor;
			}
		}

		// Token: 0x060140C6 RID: 82118 RVA: 0x002EBB98 File Offset: 0x002E9D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenMotorRewardRequest()
		{
		}

		// Token: 0x060140C7 RID: 82119 RVA: 0x002EBBAB File Offset: 0x002E9DAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenMotorRewardRequest(RealmBetweenMotorRewardRequest other) : this()
		{
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060140C8 RID: 82120 RVA: 0x002EBBD5 File Offset: 0x002E9DD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenMotorRewardRequest Clone()
		{
			return new RealmBetweenMotorRewardRequest(this);
		}

		// Token: 0x170042B8 RID: 17080
		// (get) Token: 0x060140C9 RID: 82121 RVA: 0x002EBBDD File Offset: 0x002E9DDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x060140CA RID: 82122 RVA: 0x002EBBE5 File Offset: 0x002E9DE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RealmBetweenMotorRewardRequest);
		}

		// Token: 0x060140CB RID: 82123 RVA: 0x002EBBF3 File Offset: 0x002E9DF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RealmBetweenMotorRewardRequest other)
		{
			return other != null && (other == this || (this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060140CC RID: 82124 RVA: 0x002EBC28 File Offset: 0x002E9E28
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

		// Token: 0x060140CD RID: 82125 RVA: 0x002EBC5C File Offset: 0x002E9E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060140CE RID: 82126 RVA: 0x002EBC69 File Offset: 0x002E9E69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060140CF RID: 82127 RVA: 0x002EBC72 File Offset: 0x002E9E72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskIds_.WriteTo(ref output, RealmBetweenMotorRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060140D0 RID: 82128 RVA: 0x002EBC9C File Offset: 0x002E9E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.taskIds_.CalculateSize(RealmBetweenMotorRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060140D1 RID: 82129 RVA: 0x002EBCD5 File Offset: 0x002E9ED5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RealmBetweenMotorRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.taskIds_.Add(other.taskIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060140D2 RID: 82130 RVA: 0x002EBD03 File Offset: 0x002E9F03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060140D3 RID: 82131 RVA: 0x002EBD0C File Offset: 0x002E9F0C
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
					this.taskIds_.AddEntriesFrom(ref input, RealmBetweenMotorRewardRequest._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x04007AB4 RID: 31412
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007AB5 RID: 31413
		public const int TaskIdsFieldNumber = 6;

		// Token: 0x04007AB6 RID: 31414
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04007AB7 RID: 31415
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
