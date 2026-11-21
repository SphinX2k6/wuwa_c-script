using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C6F RID: 3183
	[NetMessage(EMessageId.PhantomBattleDiscardCardRequest)]
	public sealed class PhantomBattleDiscardCardRequest : IMessage<PhantomBattleDiscardCardRequest>, IMessage, IEquatable<PhantomBattleDiscardCardRequest>, IDeepCloneable<PhantomBattleDiscardCardRequest>, IBufferMessage
	{
		// Token: 0x06011466 RID: 70758 RVA: 0x00287F2C File Offset: 0x0028612C
		[NullableContext(1)]
		public static PhantomBattleDiscardCardRequest Create()
		{
			return new PhantomBattleDiscardCardRequest();
		}

		// Token: 0x17003928 RID: 14632
		// (get) Token: 0x06011467 RID: 70759 RVA: 0x00287F33 File Offset: 0x00286133
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003929 RID: 14633
		// (get) Token: 0x06011468 RID: 70760 RVA: 0x00287F36 File Offset: 0x00286136
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleDiscardCardRequest.Descriptor;
			}
		}

		// Token: 0x06011469 RID: 70761 RVA: 0x00287F3D File Offset: 0x0028613D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDiscardCardRequest()
		{
		}

		// Token: 0x0601146A RID: 70762 RVA: 0x00287F50 File Offset: 0x00286150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDiscardCardRequest(PhantomBattleDiscardCardRequest other) : this()
		{
			this.discardCardIds_ = other.discardCardIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601146B RID: 70763 RVA: 0x00287F7A File Offset: 0x0028617A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDiscardCardRequest Clone()
		{
			return new PhantomBattleDiscardCardRequest(this);
		}

		// Token: 0x1700392A RID: 14634
		// (get) Token: 0x0601146C RID: 70764 RVA: 0x00287F82 File Offset: 0x00286182
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DiscardCardIds
		{
			get
			{
				return this.discardCardIds_;
			}
		}

		// Token: 0x0601146D RID: 70765 RVA: 0x00287F8A File Offset: 0x0028618A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleDiscardCardRequest);
		}

		// Token: 0x0601146E RID: 70766 RVA: 0x00287F98 File Offset: 0x00286198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleDiscardCardRequest other)
		{
			return other != null && (other == this || (this.discardCardIds_.Equals(other.discardCardIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601146F RID: 70767 RVA: 0x00287FCC File Offset: 0x002861CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.discardCardIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011470 RID: 70768 RVA: 0x00288000 File Offset: 0x00286200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011471 RID: 70769 RVA: 0x0028800D File Offset: 0x0028620D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011472 RID: 70770 RVA: 0x00288016 File Offset: 0x00286216
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.discardCardIds_.WriteTo(ref output, PhantomBattleDiscardCardRequest._repeated_discardCardIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011473 RID: 70771 RVA: 0x00288040 File Offset: 0x00286240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.discardCardIds_.CalculateSize(PhantomBattleDiscardCardRequest._repeated_discardCardIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011474 RID: 70772 RVA: 0x00288079 File Offset: 0x00286279
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleDiscardCardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.discardCardIds_.Add(other.discardCardIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011475 RID: 70773 RVA: 0x002880A7 File Offset: 0x002862A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011476 RID: 70774 RVA: 0x002880B0 File Offset: 0x002862B0
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
				if (num != 104U && num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.discardCardIds_.AddEntriesFrom(ref input, PhantomBattleDiscardCardRequest._repeated_discardCardIds_codec);
				}
			}
		}

		// Token: 0x04006DA6 RID: 28070
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006DA7 RID: 28071
		public const int DiscardCardIdsFieldNumber = 13;

		// Token: 0x04006DA8 RID: 28072
		private static readonly FieldCodec<int> _repeated_discardCardIds_codec = FieldCodec.ForInt32(106U);

		// Token: 0x04006DA9 RID: 28073
		private readonly RepeatedField<int> discardCardIds_ = new RepeatedField<int>();
	}
}
