using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C53 RID: 3155
	[NetMessage(EMessageId.PhantomBattleCardOutLookUpRequest)]
	public sealed class PhantomBattleCardOutLookUpRequest : IMessage<PhantomBattleCardOutLookUpRequest>, IMessage, IEquatable<PhantomBattleCardOutLookUpRequest>, IDeepCloneable<PhantomBattleCardOutLookUpRequest>, IBufferMessage
	{
		// Token: 0x060111BE RID: 70078 RVA: 0x00281761 File Offset: 0x0027F961
		[NullableContext(1)]
		public static PhantomBattleCardOutLookUpRequest Create()
		{
			return new PhantomBattleCardOutLookUpRequest();
		}

		// Token: 0x1700388F RID: 14479
		// (get) Token: 0x060111BF RID: 70079 RVA: 0x00281768 File Offset: 0x0027F968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003890 RID: 14480
		// (get) Token: 0x060111C0 RID: 70080 RVA: 0x0028176B File Offset: 0x0027F96B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardOutLookUpRequest.Descriptor;
			}
		}

		// Token: 0x060111C1 RID: 70081 RVA: 0x00281772 File Offset: 0x0027F972
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardOutLookUpRequest()
		{
		}

		// Token: 0x060111C2 RID: 70082 RVA: 0x0028177A File Offset: 0x0027F97A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardOutLookUpRequest(PhantomBattleCardOutLookUpRequest other) : this()
		{
			this.cardId_ = other.cardId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060111C3 RID: 70083 RVA: 0x0028179F File Offset: 0x0027F99F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardOutLookUpRequest Clone()
		{
			return new PhantomBattleCardOutLookUpRequest(this);
		}

		// Token: 0x17003891 RID: 14481
		// (get) Token: 0x060111C4 RID: 70084 RVA: 0x002817A7 File Offset: 0x0027F9A7
		// (set) Token: 0x060111C5 RID: 70085 RVA: 0x002817AF File Offset: 0x0027F9AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardId
		{
			get
			{
				return this.cardId_;
			}
			set
			{
				this.cardId_ = value;
			}
		}

		// Token: 0x060111C6 RID: 70086 RVA: 0x002817B8 File Offset: 0x0027F9B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardOutLookUpRequest);
		}

		// Token: 0x060111C7 RID: 70087 RVA: 0x002817C6 File Offset: 0x0027F9C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardOutLookUpRequest other)
		{
			return other != null && (other == this || (this.CardId == other.CardId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060111C8 RID: 70088 RVA: 0x002817F4 File Offset: 0x0027F9F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CardId != 0)
			{
				num ^= this.CardId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060111C9 RID: 70089 RVA: 0x00281833 File Offset: 0x0027FA33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060111CA RID: 70090 RVA: 0x00281840 File Offset: 0x0027FA40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060111CB RID: 70091 RVA: 0x00281849 File Offset: 0x0027FA49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CardId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.CardId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060111CC RID: 70092 RVA: 0x0028187C File Offset: 0x0027FA7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060111CD RID: 70093 RVA: 0x002818BA File Offset: 0x0027FABA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardOutLookUpRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CardId != 0)
			{
				this.CardId = other.CardId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060111CE RID: 70094 RVA: 0x002818EB File Offset: 0x0027FAEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060111CF RID: 70095 RVA: 0x002818F4 File Offset: 0x0027FAF4
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CardId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006C5F RID: 27743
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006C60 RID: 27744
		public const int CardIdFieldNumber = 14;

		// Token: 0x04006C61 RID: 27745
		private int cardId_;
	}
}
