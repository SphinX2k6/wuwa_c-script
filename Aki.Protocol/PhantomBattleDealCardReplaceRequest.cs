using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C62 RID: 3170
	[NetMessage(EMessageId.PhantomBattleDealCardReplaceRequest)]
	public sealed class PhantomBattleDealCardReplaceRequest : IMessage<PhantomBattleDealCardReplaceRequest>, IMessage, IEquatable<PhantomBattleDealCardReplaceRequest>, IDeepCloneable<PhantomBattleDealCardReplaceRequest>, IBufferMessage
	{
		// Token: 0x06011358 RID: 70488 RVA: 0x002858DC File Offset: 0x00283ADC
		[NullableContext(1)]
		public static PhantomBattleDealCardReplaceRequest Create()
		{
			return new PhantomBattleDealCardReplaceRequest();
		}

		// Token: 0x170038EC RID: 14572
		// (get) Token: 0x06011359 RID: 70489 RVA: 0x002858E3 File Offset: 0x00283AE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170038ED RID: 14573
		// (get) Token: 0x0601135A RID: 70490 RVA: 0x002858E6 File Offset: 0x00283AE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleDealCardReplaceRequest.Descriptor;
			}
		}

		// Token: 0x0601135B RID: 70491 RVA: 0x002858ED File Offset: 0x00283AED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDealCardReplaceRequest()
		{
		}

		// Token: 0x0601135C RID: 70492 RVA: 0x00285900 File Offset: 0x00283B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDealCardReplaceRequest(PhantomBattleDealCardReplaceRequest other) : this()
		{
			this.replaceCardUid_ = other.replaceCardUid_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601135D RID: 70493 RVA: 0x0028592A File Offset: 0x00283B2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDealCardReplaceRequest Clone()
		{
			return new PhantomBattleDealCardReplaceRequest(this);
		}

		// Token: 0x170038EE RID: 14574
		// (get) Token: 0x0601135E RID: 70494 RVA: 0x00285932 File Offset: 0x00283B32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ReplaceCardUid
		{
			get
			{
				return this.replaceCardUid_;
			}
		}

		// Token: 0x0601135F RID: 70495 RVA: 0x0028593A File Offset: 0x00283B3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleDealCardReplaceRequest);
		}

		// Token: 0x06011360 RID: 70496 RVA: 0x00285948 File Offset: 0x00283B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleDealCardReplaceRequest other)
		{
			return other != null && (other == this || (this.replaceCardUid_.Equals(other.replaceCardUid_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011361 RID: 70497 RVA: 0x0028597C File Offset: 0x00283B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.replaceCardUid_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011362 RID: 70498 RVA: 0x002859B0 File Offset: 0x00283BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011363 RID: 70499 RVA: 0x002859BD File Offset: 0x00283BBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011364 RID: 70500 RVA: 0x002859C6 File Offset: 0x00283BC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.replaceCardUid_.WriteTo(ref output, PhantomBattleDealCardReplaceRequest._repeated_replaceCardUid_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011365 RID: 70501 RVA: 0x002859F0 File Offset: 0x00283BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.replaceCardUid_.CalculateSize(PhantomBattleDealCardReplaceRequest._repeated_replaceCardUid_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011366 RID: 70502 RVA: 0x00285A29 File Offset: 0x00283C29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleDealCardReplaceRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.replaceCardUid_.Add(other.replaceCardUid_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011367 RID: 70503 RVA: 0x00285A57 File Offset: 0x00283C57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011368 RID: 70504 RVA: 0x00285A60 File Offset: 0x00283C60
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
				if (num != 24U && num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.replaceCardUid_.AddEntriesFrom(ref input, PhantomBattleDealCardReplaceRequest._repeated_replaceCardUid_codec);
				}
			}
		}

		// Token: 0x04006D4E RID: 27982
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006D4F RID: 27983
		public const int ReplaceCardUidFieldNumber = 3;

		// Token: 0x04006D50 RID: 27984
		private static readonly FieldCodec<int> _repeated_replaceCardUid_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04006D51 RID: 27985
		private readonly RepeatedField<int> replaceCardUid_ = new RepeatedField<int>();
	}
}
