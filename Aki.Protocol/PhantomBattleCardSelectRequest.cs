using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C50 RID: 3152
	[NetMessage(EMessageId.PhantomBattleCardSelectRequest)]
	public sealed class PhantomBattleCardSelectRequest : IMessage<PhantomBattleCardSelectRequest>, IMessage, IEquatable<PhantomBattleCardSelectRequest>, IDeepCloneable<PhantomBattleCardSelectRequest>, IBufferMessage
	{
		// Token: 0x060111C4 RID: 70084 RVA: 0x00281BA4 File Offset: 0x0027FDA4
		[NullableContext(1)]
		public static PhantomBattleCardSelectRequest Create()
		{
			return new PhantomBattleCardSelectRequest();
		}

		// Token: 0x1700388D RID: 14477
		// (get) Token: 0x060111C5 RID: 70085 RVA: 0x00281BAB File Offset: 0x0027FDAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700388E RID: 14478
		// (get) Token: 0x060111C6 RID: 70086 RVA: 0x00281BAE File Offset: 0x0027FDAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardSelectRequest.Descriptor;
			}
		}

		// Token: 0x060111C7 RID: 70087 RVA: 0x00281BB5 File Offset: 0x0027FDB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardSelectRequest()
		{
		}

		// Token: 0x060111C8 RID: 70088 RVA: 0x00281BC8 File Offset: 0x0027FDC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardSelectRequest(PhantomBattleCardSelectRequest other) : this()
		{
			this.cardUid_ = other.cardUid_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060111C9 RID: 70089 RVA: 0x00281BF2 File Offset: 0x0027FDF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardSelectRequest Clone()
		{
			return new PhantomBattleCardSelectRequest(this);
		}

		// Token: 0x1700388F RID: 14479
		// (get) Token: 0x060111CA RID: 70090 RVA: 0x00281BFA File Offset: 0x0027FDFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CardUid
		{
			get
			{
				return this.cardUid_;
			}
		}

		// Token: 0x060111CB RID: 70091 RVA: 0x00281C02 File Offset: 0x0027FE02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardSelectRequest);
		}

		// Token: 0x060111CC RID: 70092 RVA: 0x00281C10 File Offset: 0x0027FE10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardSelectRequest other)
		{
			return other != null && (other == this || (this.cardUid_.Equals(other.cardUid_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060111CD RID: 70093 RVA: 0x00281C44 File Offset: 0x0027FE44
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

		// Token: 0x060111CE RID: 70094 RVA: 0x00281C78 File Offset: 0x0027FE78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060111CF RID: 70095 RVA: 0x00281C85 File Offset: 0x0027FE85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060111D0 RID: 70096 RVA: 0x00281C8E File Offset: 0x0027FE8E
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

		// Token: 0x060111D1 RID: 70097 RVA: 0x00281CB8 File Offset: 0x0027FEB8
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

		// Token: 0x060111D2 RID: 70098 RVA: 0x00281CF1 File Offset: 0x0027FEF1
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

		// Token: 0x060111D3 RID: 70099 RVA: 0x00281D1F File Offset: 0x0027FF1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060111D4 RID: 70100 RVA: 0x00281D28 File Offset: 0x0027FF28
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
				if (num != 88U && num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.cardUid_.AddEntriesFrom(ref input, PhantomBattleCardSelectRequest._repeated_cardUid_codec);
				}
			}
		}

		// Token: 0x04006CBA RID: 27834
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006CBB RID: 27835
		public const int CardUidFieldNumber = 11;

		// Token: 0x04006CBC RID: 27836
		private static readonly FieldCodec<int> _repeated_cardUid_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04006CBD RID: 27837
		private readonly RepeatedField<int> cardUid_ = new RepeatedField<int>();
	}
}
