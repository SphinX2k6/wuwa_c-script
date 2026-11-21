using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E93 RID: 3731
	[NetMessage(EMessageId.RealmBetweenTaskRewardRequest)]
	public sealed class RealmBetweenTaskRewardRequest : IMessage<RealmBetweenTaskRewardRequest>, IMessage, IEquatable<RealmBetweenTaskRewardRequest>, IDeepCloneable<RealmBetweenTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x060140E9 RID: 82153 RVA: 0x002EC01C File Offset: 0x002EA21C
		[NullableContext(1)]
		public static RealmBetweenTaskRewardRequest Create()
		{
			return new RealmBetweenTaskRewardRequest();
		}

		// Token: 0x170042BD RID: 17085
		// (get) Token: 0x060140EA RID: 82154 RVA: 0x002EC023 File Offset: 0x002EA223
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042BE RID: 17086
		// (get) Token: 0x060140EB RID: 82155 RVA: 0x002EC026 File Offset: 0x002EA226
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RealmBetweenTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x060140EC RID: 82156 RVA: 0x002EC02D File Offset: 0x002EA22D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenTaskRewardRequest()
		{
		}

		// Token: 0x060140ED RID: 82157 RVA: 0x002EC040 File Offset: 0x002EA240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenTaskRewardRequest(RealmBetweenTaskRewardRequest other) : this()
		{
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060140EE RID: 82158 RVA: 0x002EC06A File Offset: 0x002EA26A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenTaskRewardRequest Clone()
		{
			return new RealmBetweenTaskRewardRequest(this);
		}

		// Token: 0x170042BF RID: 17087
		// (get) Token: 0x060140EF RID: 82159 RVA: 0x002EC072 File Offset: 0x002EA272
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x060140F0 RID: 82160 RVA: 0x002EC07A File Offset: 0x002EA27A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RealmBetweenTaskRewardRequest);
		}

		// Token: 0x060140F1 RID: 82161 RVA: 0x002EC088 File Offset: 0x002EA288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RealmBetweenTaskRewardRequest other)
		{
			return other != null && (other == this || (this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060140F2 RID: 82162 RVA: 0x002EC0BC File Offset: 0x002EA2BC
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

		// Token: 0x060140F3 RID: 82163 RVA: 0x002EC0F0 File Offset: 0x002EA2F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060140F4 RID: 82164 RVA: 0x002EC0FD File Offset: 0x002EA2FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060140F5 RID: 82165 RVA: 0x002EC106 File Offset: 0x002EA306
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskIds_.WriteTo(ref output, RealmBetweenTaskRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060140F6 RID: 82166 RVA: 0x002EC130 File Offset: 0x002EA330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.taskIds_.CalculateSize(RealmBetweenTaskRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060140F7 RID: 82167 RVA: 0x002EC169 File Offset: 0x002EA369
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RealmBetweenTaskRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.taskIds_.Add(other.taskIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060140F8 RID: 82168 RVA: 0x002EC197 File Offset: 0x002EA397
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060140F9 RID: 82169 RVA: 0x002EC1A0 File Offset: 0x002EA3A0
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.taskIds_.AddEntriesFrom(ref input, RealmBetweenTaskRewardRequest._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x04007ABE RID: 31422
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007ABF RID: 31423
		public const int TaskIdsFieldNumber = 1;

		// Token: 0x04007AC0 RID: 31424
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04007AC1 RID: 31425
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
