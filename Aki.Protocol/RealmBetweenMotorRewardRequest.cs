using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EA1 RID: 3745
	[NetMessage(EMessageId.RealmBetweenMotorRewardRequest)]
	public sealed class RealmBetweenMotorRewardRequest : IMessage<RealmBetweenMotorRewardRequest>, IMessage, IEquatable<RealmBetweenMotorRewardRequest>, IDeepCloneable<RealmBetweenMotorRewardRequest>, IBufferMessage
	{
		// Token: 0x060141A8 RID: 82344 RVA: 0x002ED233 File Offset: 0x002EB433
		[NullableContext(1)]
		public static RealmBetweenMotorRewardRequest Create()
		{
			return new RealmBetweenMotorRewardRequest();
		}

		// Token: 0x170042E0 RID: 17120
		// (get) Token: 0x060141A9 RID: 82345 RVA: 0x002ED23A File Offset: 0x002EB43A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042E1 RID: 17121
		// (get) Token: 0x060141AA RID: 82346 RVA: 0x002ED23D File Offset: 0x002EB43D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RealmBetweenMotorRewardRequest.Descriptor;
			}
		}

		// Token: 0x060141AB RID: 82347 RVA: 0x002ED244 File Offset: 0x002EB444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenMotorRewardRequest()
		{
		}

		// Token: 0x060141AC RID: 82348 RVA: 0x002ED257 File Offset: 0x002EB457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenMotorRewardRequest(RealmBetweenMotorRewardRequest other) : this()
		{
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060141AD RID: 82349 RVA: 0x002ED281 File Offset: 0x002EB481
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenMotorRewardRequest Clone()
		{
			return new RealmBetweenMotorRewardRequest(this);
		}

		// Token: 0x170042E2 RID: 17122
		// (get) Token: 0x060141AE RID: 82350 RVA: 0x002ED289 File Offset: 0x002EB489
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x060141AF RID: 82351 RVA: 0x002ED291 File Offset: 0x002EB491
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RealmBetweenMotorRewardRequest);
		}

		// Token: 0x060141B0 RID: 82352 RVA: 0x002ED29F File Offset: 0x002EB49F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RealmBetweenMotorRewardRequest other)
		{
			return other != null && (other == this || (this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060141B1 RID: 82353 RVA: 0x002ED2D4 File Offset: 0x002EB4D4
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

		// Token: 0x060141B2 RID: 82354 RVA: 0x002ED308 File Offset: 0x002EB508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060141B3 RID: 82355 RVA: 0x002ED315 File Offset: 0x002EB515
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060141B4 RID: 82356 RVA: 0x002ED31E File Offset: 0x002EB51E
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

		// Token: 0x060141B5 RID: 82357 RVA: 0x002ED348 File Offset: 0x002EB548
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

		// Token: 0x060141B6 RID: 82358 RVA: 0x002ED381 File Offset: 0x002EB581
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

		// Token: 0x060141B7 RID: 82359 RVA: 0x002ED3AF File Offset: 0x002EB5AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060141B8 RID: 82360 RVA: 0x002ED3B8 File Offset: 0x002EB5B8
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
					this.taskIds_.AddEntriesFrom(ref input, RealmBetweenMotorRewardRequest._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x04007A8A RID: 31370
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A8B RID: 31371
		public const int TaskIdsFieldNumber = 4;

		// Token: 0x04007A8C RID: 31372
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04007A8D RID: 31373
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
