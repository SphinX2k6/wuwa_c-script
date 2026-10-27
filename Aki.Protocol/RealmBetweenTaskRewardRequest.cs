using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EA3 RID: 3747
	[NetMessage(EMessageId.RealmBetweenTaskRewardRequest)]
	public sealed class RealmBetweenTaskRewardRequest : IMessage<RealmBetweenTaskRewardRequest>, IMessage, IEquatable<RealmBetweenTaskRewardRequest>, IDeepCloneable<RealmBetweenTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x060141CE RID: 82382 RVA: 0x002ED6C8 File Offset: 0x002EB8C8
		[NullableContext(1)]
		public static RealmBetweenTaskRewardRequest Create()
		{
			return new RealmBetweenTaskRewardRequest();
		}

		// Token: 0x170042E7 RID: 17127
		// (get) Token: 0x060141CF RID: 82383 RVA: 0x002ED6CF File Offset: 0x002EB8CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042E8 RID: 17128
		// (get) Token: 0x060141D0 RID: 82384 RVA: 0x002ED6D2 File Offset: 0x002EB8D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RealmBetweenTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x060141D1 RID: 82385 RVA: 0x002ED6D9 File Offset: 0x002EB8D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenTaskRewardRequest()
		{
		}

		// Token: 0x060141D2 RID: 82386 RVA: 0x002ED6EC File Offset: 0x002EB8EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenTaskRewardRequest(RealmBetweenTaskRewardRequest other) : this()
		{
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060141D3 RID: 82387 RVA: 0x002ED716 File Offset: 0x002EB916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenTaskRewardRequest Clone()
		{
			return new RealmBetweenTaskRewardRequest(this);
		}

		// Token: 0x170042E9 RID: 17129
		// (get) Token: 0x060141D4 RID: 82388 RVA: 0x002ED71E File Offset: 0x002EB91E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x060141D5 RID: 82389 RVA: 0x002ED726 File Offset: 0x002EB926
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RealmBetweenTaskRewardRequest);
		}

		// Token: 0x060141D6 RID: 82390 RVA: 0x002ED734 File Offset: 0x002EB934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RealmBetweenTaskRewardRequest other)
		{
			return other != null && (other == this || (this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060141D7 RID: 82391 RVA: 0x002ED768 File Offset: 0x002EB968
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

		// Token: 0x060141D8 RID: 82392 RVA: 0x002ED79C File Offset: 0x002EB99C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060141D9 RID: 82393 RVA: 0x002ED7A9 File Offset: 0x002EB9A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060141DA RID: 82394 RVA: 0x002ED7B2 File Offset: 0x002EB9B2
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

		// Token: 0x060141DB RID: 82395 RVA: 0x002ED7DC File Offset: 0x002EB9DC
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

		// Token: 0x060141DC RID: 82396 RVA: 0x002ED815 File Offset: 0x002EBA15
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

		// Token: 0x060141DD RID: 82397 RVA: 0x002ED843 File Offset: 0x002EBA43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060141DE RID: 82398 RVA: 0x002ED84C File Offset: 0x002EBA4C
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
				if (num != 56U && num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.taskIds_.AddEntriesFrom(ref input, RealmBetweenTaskRewardRequest._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x04007A94 RID: 31380
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A95 RID: 31381
		public const int TaskIdsFieldNumber = 7;

		// Token: 0x04007A96 RID: 31382
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04007A97 RID: 31383
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
