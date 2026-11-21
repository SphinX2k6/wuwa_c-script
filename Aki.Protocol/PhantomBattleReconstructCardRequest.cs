using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C93 RID: 3219
	[NetMessage(EMessageId.PhantomBattleReconstructCardRequest)]
	public sealed class PhantomBattleReconstructCardRequest : IMessage<PhantomBattleReconstructCardRequest>, IMessage, IEquatable<PhantomBattleReconstructCardRequest>, IDeepCloneable<PhantomBattleReconstructCardRequest>, IBufferMessage
	{
		// Token: 0x06011781 RID: 71553 RVA: 0x0028FC1A File Offset: 0x0028DE1A
		[NullableContext(1)]
		public static PhantomBattleReconstructCardRequest Create()
		{
			return new PhantomBattleReconstructCardRequest();
		}

		// Token: 0x170039DF RID: 14815
		// (get) Token: 0x06011782 RID: 71554 RVA: 0x0028FC21 File Offset: 0x0028DE21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170039E0 RID: 14816
		// (get) Token: 0x06011783 RID: 71555 RVA: 0x0028FC24 File Offset: 0x0028DE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleReconstructCardRequest.Descriptor;
			}
		}

		// Token: 0x06011784 RID: 71556 RVA: 0x0028FC2B File Offset: 0x0028DE2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleReconstructCardRequest()
		{
		}

		// Token: 0x06011785 RID: 71557 RVA: 0x0028FC3E File Offset: 0x0028DE3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleReconstructCardRequest(PhantomBattleReconstructCardRequest other) : this()
		{
			this.effectUid_ = other.effectUid_;
			this.selectedCardUid_ = other.selectedCardUid_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011786 RID: 71558 RVA: 0x0028FC74 File Offset: 0x0028DE74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleReconstructCardRequest Clone()
		{
			return new PhantomBattleReconstructCardRequest(this);
		}

		// Token: 0x170039E1 RID: 14817
		// (get) Token: 0x06011787 RID: 71559 RVA: 0x0028FC7C File Offset: 0x0028DE7C
		// (set) Token: 0x06011788 RID: 71560 RVA: 0x0028FC84 File Offset: 0x0028DE84
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

		// Token: 0x170039E2 RID: 14818
		// (get) Token: 0x06011789 RID: 71561 RVA: 0x0028FC8D File Offset: 0x0028DE8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SelectedCardUid
		{
			get
			{
				return this.selectedCardUid_;
			}
		}

		// Token: 0x0601178A RID: 71562 RVA: 0x0028FC95 File Offset: 0x0028DE95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleReconstructCardRequest);
		}

		// Token: 0x0601178B RID: 71563 RVA: 0x0028FCA4 File Offset: 0x0028DEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleReconstructCardRequest other)
		{
			return other != null && (other == this || (this.EffectUid == other.EffectUid && this.selectedCardUid_.Equals(other.selectedCardUid_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601178C RID: 71564 RVA: 0x0028FCF4 File Offset: 0x0028DEF4
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

		// Token: 0x0601178D RID: 71565 RVA: 0x0028FD41 File Offset: 0x0028DF41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601178E RID: 71566 RVA: 0x0028FD4E File Offset: 0x0028DF4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601178F RID: 71567 RVA: 0x0028FD58 File Offset: 0x0028DF58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.selectedCardUid_.WriteTo(ref output, PhantomBattleReconstructCardRequest._repeated_selectedCardUid_codec);
			if (this.EffectUid != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.EffectUid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011790 RID: 71568 RVA: 0x0028FDA8 File Offset: 0x0028DFA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EffectUid != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EffectUid);
			}
			num += this.selectedCardUid_.CalculateSize(PhantomBattleReconstructCardRequest._repeated_selectedCardUid_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011791 RID: 71569 RVA: 0x0028FDFC File Offset: 0x0028DFFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleReconstructCardRequest other)
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

		// Token: 0x06011792 RID: 71570 RVA: 0x0028FE49 File Offset: 0x0028E049
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011793 RID: 71571 RVA: 0x0028FE54 File Offset: 0x0028E054
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
				if (num != 40U && num != 42U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EffectUid = input.ReadInt32();
					}
				}
				else
				{
					this.selectedCardUid_.AddEntriesFrom(ref input, PhantomBattleReconstructCardRequest._repeated_selectedCardUid_codec);
				}
			}
		}

		// Token: 0x04006EA3 RID: 28323
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006EA4 RID: 28324
		public const int EffectUidFieldNumber = 7;

		// Token: 0x04006EA5 RID: 28325
		private int effectUid_;

		// Token: 0x04006EA6 RID: 28326
		public const int SelectedCardUidFieldNumber = 5;

		// Token: 0x04006EA7 RID: 28327
		private static readonly FieldCodec<int> _repeated_selectedCardUid_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04006EA8 RID: 28328
		private readonly RepeatedField<int> selectedCardUid_ = new RepeatedField<int>();
	}
}
