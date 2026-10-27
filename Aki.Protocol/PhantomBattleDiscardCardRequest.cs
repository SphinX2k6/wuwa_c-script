using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C7F RID: 3199
	[NetMessage(EMessageId.PhantomBattleDiscardCardRequest)]
	public sealed class PhantomBattleDiscardCardRequest : IMessage<PhantomBattleDiscardCardRequest>, IMessage, IEquatable<PhantomBattleDiscardCardRequest>, IDeepCloneable<PhantomBattleDiscardCardRequest>, IBufferMessage
	{
		// Token: 0x06011566 RID: 71014 RVA: 0x00289C9C File Offset: 0x00287E9C
		[NullableContext(1)]
		public static PhantomBattleDiscardCardRequest Create()
		{
			return new PhantomBattleDiscardCardRequest();
		}

		// Token: 0x1700395F RID: 14687
		// (get) Token: 0x06011567 RID: 71015 RVA: 0x00289CA3 File Offset: 0x00287EA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003960 RID: 14688
		// (get) Token: 0x06011568 RID: 71016 RVA: 0x00289CA6 File Offset: 0x00287EA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleDiscardCardRequest.Descriptor;
			}
		}

		// Token: 0x06011569 RID: 71017 RVA: 0x00289CAD File Offset: 0x00287EAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDiscardCardRequest()
		{
		}

		// Token: 0x0601156A RID: 71018 RVA: 0x00289CC0 File Offset: 0x00287EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDiscardCardRequest(PhantomBattleDiscardCardRequest other) : this()
		{
			this.discardCardIds_ = other.discardCardIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601156B RID: 71019 RVA: 0x00289CEA File Offset: 0x00287EEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDiscardCardRequest Clone()
		{
			return new PhantomBattleDiscardCardRequest(this);
		}

		// Token: 0x17003961 RID: 14689
		// (get) Token: 0x0601156C RID: 71020 RVA: 0x00289CF2 File Offset: 0x00287EF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DiscardCardIds
		{
			get
			{
				return this.discardCardIds_;
			}
		}

		// Token: 0x0601156D RID: 71021 RVA: 0x00289CFA File Offset: 0x00287EFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleDiscardCardRequest);
		}

		// Token: 0x0601156E RID: 71022 RVA: 0x00289D08 File Offset: 0x00287F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleDiscardCardRequest other)
		{
			return other != null && (other == this || (this.discardCardIds_.Equals(other.discardCardIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601156F RID: 71023 RVA: 0x00289D3C File Offset: 0x00287F3C
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

		// Token: 0x06011570 RID: 71024 RVA: 0x00289D70 File Offset: 0x00287F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011571 RID: 71025 RVA: 0x00289D7D File Offset: 0x00287F7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011572 RID: 71026 RVA: 0x00289D86 File Offset: 0x00287F86
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

		// Token: 0x06011573 RID: 71027 RVA: 0x00289DB0 File Offset: 0x00287FB0
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

		// Token: 0x06011574 RID: 71028 RVA: 0x00289DE9 File Offset: 0x00287FE9
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

		// Token: 0x06011575 RID: 71029 RVA: 0x00289E17 File Offset: 0x00288017
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011576 RID: 71030 RVA: 0x00289E20 File Offset: 0x00288020
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
					this.discardCardIds_.AddEntriesFrom(ref input, PhantomBattleDiscardCardRequest._repeated_discardCardIds_codec);
				}
			}
		}

		// Token: 0x04006D92 RID: 28050
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006D93 RID: 28051
		public const int DiscardCardIdsFieldNumber = 7;

		// Token: 0x04006D94 RID: 28052
		private static readonly FieldCodec<int> _repeated_discardCardIds_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04006D95 RID: 28053
		private readonly RepeatedField<int> discardCardIds_ = new RepeatedField<int>();
	}
}
