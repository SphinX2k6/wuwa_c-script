using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C42 RID: 3138
	[NetMessage(EMessageId.PhantomBattleCallCardRequest)]
	public sealed class PhantomBattleCallCardRequest : IMessage<PhantomBattleCallCardRequest>, IMessage, IEquatable<PhantomBattleCallCardRequest>, IDeepCloneable<PhantomBattleCallCardRequest>, IBufferMessage
	{
		// Token: 0x06011045 RID: 69701 RVA: 0x0027DBD5 File Offset: 0x0027BDD5
		[NullableContext(1)]
		public static PhantomBattleCallCardRequest Create()
		{
			return new PhantomBattleCallCardRequest();
		}

		// Token: 0x17003836 RID: 14390
		// (get) Token: 0x06011046 RID: 69702 RVA: 0x0027DBDC File Offset: 0x0027BDDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003837 RID: 14391
		// (get) Token: 0x06011047 RID: 69703 RVA: 0x0027DBDF File Offset: 0x0027BDDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCallCardRequest.Descriptor;
			}
		}

		// Token: 0x06011048 RID: 69704 RVA: 0x0027DBE6 File Offset: 0x0027BDE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCallCardRequest()
		{
		}

		// Token: 0x06011049 RID: 69705 RVA: 0x0027DBF9 File Offset: 0x0027BDF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCallCardRequest(PhantomBattleCallCardRequest other) : this()
		{
			this.effectUid_ = other.effectUid_;
			this.selectedCardUid_ = other.selectedCardUid_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601104A RID: 69706 RVA: 0x0027DC2F File Offset: 0x0027BE2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCallCardRequest Clone()
		{
			return new PhantomBattleCallCardRequest(this);
		}

		// Token: 0x17003838 RID: 14392
		// (get) Token: 0x0601104B RID: 69707 RVA: 0x0027DC37 File Offset: 0x0027BE37
		// (set) Token: 0x0601104C RID: 69708 RVA: 0x0027DC3F File Offset: 0x0027BE3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EffectUid
		{
			get
			{
				return this.effectUid_;
			}
			set
			{
				this.effectUid_ = value;
			}
		}

		// Token: 0x17003839 RID: 14393
		// (get) Token: 0x0601104D RID: 69709 RVA: 0x0027DC48 File Offset: 0x0027BE48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SelectedCardUid
		{
			get
			{
				return this.selectedCardUid_;
			}
		}

		// Token: 0x0601104E RID: 69710 RVA: 0x0027DC50 File Offset: 0x0027BE50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCallCardRequest);
		}

		// Token: 0x0601104F RID: 69711 RVA: 0x0027DC60 File Offset: 0x0027BE60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCallCardRequest other)
		{
			return other != null && (other == this || (this.EffectUid == other.EffectUid && this.selectedCardUid_.Equals(other.selectedCardUid_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011050 RID: 69712 RVA: 0x0027DCB0 File Offset: 0x0027BEB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EffectUid != 0)
			{
				num ^= this.EffectUid.GetHashCode();
			}
			num ^= this.selectedCardUid_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011051 RID: 69713 RVA: 0x0027DCFD File Offset: 0x0027BEFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011052 RID: 69714 RVA: 0x0027DD0A File Offset: 0x0027BF0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011053 RID: 69715 RVA: 0x0027DD14 File Offset: 0x0027BF14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EffectUid != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.EffectUid);
			}
			this.selectedCardUid_.WriteTo(ref output, PhantomBattleCallCardRequest._repeated_selectedCardUid_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011054 RID: 69716 RVA: 0x0027DD64 File Offset: 0x0027BF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EffectUid != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EffectUid);
			}
			num += this.selectedCardUid_.CalculateSize(PhantomBattleCallCardRequest._repeated_selectedCardUid_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011055 RID: 69717 RVA: 0x0027DDB8 File Offset: 0x0027BFB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCallCardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EffectUid != 0)
			{
				this.EffectUid = other.EffectUid;
			}
			this.selectedCardUid_.Add(other.selectedCardUid_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011056 RID: 69718 RVA: 0x0027DE05 File Offset: 0x0027C005
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011057 RID: 69719 RVA: 0x0027DE10 File Offset: 0x0027C010
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
				if (num != 24U)
				{
					if (num != 48U && num != 50U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.selectedCardUid_.AddEntriesFrom(ref input, PhantomBattleCallCardRequest._repeated_selectedCardUid_codec);
					}
				}
				else
				{
					this.EffectUid = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006BD4 RID: 27604
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006BD5 RID: 27605
		public const int EffectUidFieldNumber = 3;

		// Token: 0x04006BD6 RID: 27606
		private int effectUid_;

		// Token: 0x04006BD7 RID: 27607
		public const int SelectedCardUidFieldNumber = 6;

		// Token: 0x04006BD8 RID: 27608
		private static readonly FieldCodec<int> _repeated_selectedCardUid_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04006BD9 RID: 27609
		private readonly RepeatedField<int> selectedCardUid_ = new RepeatedField<int>();
	}
}
