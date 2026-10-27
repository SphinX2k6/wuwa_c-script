using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CA3 RID: 3235
	[NetMessage(EMessageId.PhantomBattleReconstructCardRequest)]
	public sealed class PhantomBattleReconstructCardRequest : IMessage<PhantomBattleReconstructCardRequest>, IMessage, IEquatable<PhantomBattleReconstructCardRequest>, IDeepCloneable<PhantomBattleReconstructCardRequest>, IBufferMessage
	{
		// Token: 0x06011881 RID: 71809 RVA: 0x00291986 File Offset: 0x0028FB86
		[NullableContext(1)]
		public static PhantomBattleReconstructCardRequest Create()
		{
			return new PhantomBattleReconstructCardRequest();
		}

		// Token: 0x17003A16 RID: 14870
		// (get) Token: 0x06011882 RID: 71810 RVA: 0x0029198D File Offset: 0x0028FB8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A17 RID: 14871
		// (get) Token: 0x06011883 RID: 71811 RVA: 0x00291990 File Offset: 0x0028FB90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleReconstructCardRequest.Descriptor;
			}
		}

		// Token: 0x06011884 RID: 71812 RVA: 0x00291997 File Offset: 0x0028FB97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleReconstructCardRequest()
		{
		}

		// Token: 0x06011885 RID: 71813 RVA: 0x002919AA File Offset: 0x0028FBAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleReconstructCardRequest(PhantomBattleReconstructCardRequest other) : this()
		{
			this.effectUid_ = other.effectUid_;
			this.selectedCardUid_ = other.selectedCardUid_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011886 RID: 71814 RVA: 0x002919E0 File Offset: 0x0028FBE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleReconstructCardRequest Clone()
		{
			return new PhantomBattleReconstructCardRequest(this);
		}

		// Token: 0x17003A18 RID: 14872
		// (get) Token: 0x06011887 RID: 71815 RVA: 0x002919E8 File Offset: 0x0028FBE8
		// (set) Token: 0x06011888 RID: 71816 RVA: 0x002919F0 File Offset: 0x0028FBF0
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

		// Token: 0x17003A19 RID: 14873
		// (get) Token: 0x06011889 RID: 71817 RVA: 0x002919F9 File Offset: 0x0028FBF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SelectedCardUid
		{
			get
			{
				return this.selectedCardUid_;
			}
		}

		// Token: 0x0601188A RID: 71818 RVA: 0x00291A01 File Offset: 0x0028FC01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleReconstructCardRequest);
		}

		// Token: 0x0601188B RID: 71819 RVA: 0x00291A10 File Offset: 0x0028FC10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleReconstructCardRequest other)
		{
			return other != null && (other == this || (this.EffectUid == other.EffectUid && this.selectedCardUid_.Equals(other.selectedCardUid_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601188C RID: 71820 RVA: 0x00291A60 File Offset: 0x0028FC60
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

		// Token: 0x0601188D RID: 71821 RVA: 0x00291AAD File Offset: 0x0028FCAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601188E RID: 71822 RVA: 0x00291ABA File Offset: 0x0028FCBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601188F RID: 71823 RVA: 0x00291AC4 File Offset: 0x0028FCC4
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

		// Token: 0x06011890 RID: 71824 RVA: 0x00291B14 File Offset: 0x0028FD14
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

		// Token: 0x06011891 RID: 71825 RVA: 0x00291B68 File Offset: 0x0028FD68
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

		// Token: 0x06011892 RID: 71826 RVA: 0x00291BB5 File Offset: 0x0028FDB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011893 RID: 71827 RVA: 0x00291BC0 File Offset: 0x0028FDC0
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

		// Token: 0x04006E8F RID: 28303
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006E90 RID: 28304
		public const int EffectUidFieldNumber = 7;

		// Token: 0x04006E91 RID: 28305
		private int effectUid_;

		// Token: 0x04006E92 RID: 28306
		public const int SelectedCardUidFieldNumber = 1;

		// Token: 0x04006E93 RID: 28307
		private static readonly FieldCodec<int> _repeated_selectedCardUid_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04006E94 RID: 28308
		private readonly RepeatedField<int> selectedCardUid_ = new RepeatedField<int>();
	}
}
