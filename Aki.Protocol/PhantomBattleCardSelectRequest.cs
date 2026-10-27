using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C60 RID: 3168
	[NetMessage(EMessageId.PhantomBattleCardSelectRequest)]
	public sealed class PhantomBattleCardSelectRequest : IMessage<PhantomBattleCardSelectRequest>, IMessage, IEquatable<PhantomBattleCardSelectRequest>, IDeepCloneable<PhantomBattleCardSelectRequest>, IBufferMessage
	{
		// Token: 0x060112C4 RID: 70340 RVA: 0x00283914 File Offset: 0x00281B14
		[NullableContext(1)]
		public static PhantomBattleCardSelectRequest Create()
		{
			return new PhantomBattleCardSelectRequest();
		}

		// Token: 0x170038C4 RID: 14532
		// (get) Token: 0x060112C5 RID: 70341 RVA: 0x0028391B File Offset: 0x00281B1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170038C5 RID: 14533
		// (get) Token: 0x060112C6 RID: 70342 RVA: 0x0028391E File Offset: 0x00281B1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardSelectRequest.Descriptor;
			}
		}

		// Token: 0x060112C7 RID: 70343 RVA: 0x00283925 File Offset: 0x00281B25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardSelectRequest()
		{
		}

		// Token: 0x060112C8 RID: 70344 RVA: 0x00283938 File Offset: 0x00281B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardSelectRequest(PhantomBattleCardSelectRequest other) : this()
		{
			this.cardUid_ = other.cardUid_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060112C9 RID: 70345 RVA: 0x00283962 File Offset: 0x00281B62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardSelectRequest Clone()
		{
			return new PhantomBattleCardSelectRequest(this);
		}

		// Token: 0x170038C6 RID: 14534
		// (get) Token: 0x060112CA RID: 70346 RVA: 0x0028396A File Offset: 0x00281B6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CardUid
		{
			get
			{
				return this.cardUid_;
			}
		}

		// Token: 0x060112CB RID: 70347 RVA: 0x00283972 File Offset: 0x00281B72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardSelectRequest);
		}

		// Token: 0x060112CC RID: 70348 RVA: 0x00283980 File Offset: 0x00281B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardSelectRequest other)
		{
			return other != null && (other == this || (this.cardUid_.Equals(other.cardUid_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060112CD RID: 70349 RVA: 0x002839B4 File Offset: 0x00281BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.cardUid_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060112CE RID: 70350 RVA: 0x002839E8 File Offset: 0x00281BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060112CF RID: 70351 RVA: 0x002839F5 File Offset: 0x00281BF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060112D0 RID: 70352 RVA: 0x002839FE File Offset: 0x00281BFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.cardUid_.WriteTo(ref output, PhantomBattleCardSelectRequest._repeated_cardUid_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060112D1 RID: 70353 RVA: 0x00283A28 File Offset: 0x00281C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.cardUid_.CalculateSize(PhantomBattleCardSelectRequest._repeated_cardUid_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060112D2 RID: 70354 RVA: 0x00283A61 File Offset: 0x00281C61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardSelectRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.cardUid_.Add(other.cardUid_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060112D3 RID: 70355 RVA: 0x00283A8F File Offset: 0x00281C8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060112D4 RID: 70356 RVA: 0x00283A98 File Offset: 0x00281C98
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
					this.cardUid_.AddEntriesFrom(ref input, PhantomBattleCardSelectRequest._repeated_cardUid_codec);
				}
			}
		}

		// Token: 0x04006CA6 RID: 27814
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006CA7 RID: 27815
		public const int CardUidFieldNumber = 1;

		// Token: 0x04006CA8 RID: 27816
		private static readonly FieldCodec<int> _repeated_cardUid_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04006CA9 RID: 27817
		private readonly RepeatedField<int> cardUid_ = new RepeatedField<int>();
	}
}
