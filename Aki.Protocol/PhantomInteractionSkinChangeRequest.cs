using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CDA RID: 3290
	[NetMessage(EMessageId.PhantomInteractionSkinChangeRequest)]
	public sealed class PhantomInteractionSkinChangeRequest : IMessage<PhantomInteractionSkinChangeRequest>, IMessage, IEquatable<PhantomInteractionSkinChangeRequest>, IDeepCloneable<PhantomInteractionSkinChangeRequest>, IBufferMessage
	{
		// Token: 0x06011CD7 RID: 72919 RVA: 0x0029AB44 File Offset: 0x00298D44
		[NullableContext(1)]
		public static PhantomInteractionSkinChangeRequest Create()
		{
			return new PhantomInteractionSkinChangeRequest();
		}

		// Token: 0x17003AFA RID: 15098
		// (get) Token: 0x06011CD8 RID: 72920 RVA: 0x0029AB4B File Offset: 0x00298D4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003AFB RID: 15099
		// (get) Token: 0x06011CD9 RID: 72921 RVA: 0x0029AB4E File Offset: 0x00298D4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomInteractionSkinChangeRequest.Descriptor;
			}
		}

		// Token: 0x06011CDA RID: 72922 RVA: 0x0029AB55 File Offset: 0x00298D55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomInteractionSkinChangeRequest()
		{
		}

		// Token: 0x06011CDB RID: 72923 RVA: 0x0029AB68 File Offset: 0x00298D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomInteractionSkinChangeRequest(PhantomInteractionSkinChangeRequest other) : this()
		{
			this.skinChangeInfos_ = other.skinChangeInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011CDC RID: 72924 RVA: 0x0029AB92 File Offset: 0x00298D92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomInteractionSkinChangeRequest Clone()
		{
			return new PhantomInteractionSkinChangeRequest(this);
		}

		// Token: 0x17003AFC RID: 15100
		// (get) Token: 0x06011CDD RID: 72925 RVA: 0x0029AB9A File Offset: 0x00298D9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SkinChangeInfo> SkinChangeInfos
		{
			get
			{
				return this.skinChangeInfos_;
			}
		}

		// Token: 0x06011CDE RID: 72926 RVA: 0x0029ABA2 File Offset: 0x00298DA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomInteractionSkinChangeRequest);
		}

		// Token: 0x06011CDF RID: 72927 RVA: 0x0029ABB0 File Offset: 0x00298DB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomInteractionSkinChangeRequest other)
		{
			return other != null && (other == this || (this.skinChangeInfos_.Equals(other.skinChangeInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011CE0 RID: 72928 RVA: 0x0029ABE4 File Offset: 0x00298DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.skinChangeInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011CE1 RID: 72929 RVA: 0x0029AC18 File Offset: 0x00298E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011CE2 RID: 72930 RVA: 0x0029AC25 File Offset: 0x00298E25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011CE3 RID: 72931 RVA: 0x0029AC2E File Offset: 0x00298E2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.skinChangeInfos_.WriteTo(ref output, PhantomInteractionSkinChangeRequest._repeated_skinChangeInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011CE4 RID: 72932 RVA: 0x0029AC58 File Offset: 0x00298E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.skinChangeInfos_.CalculateSize(PhantomInteractionSkinChangeRequest._repeated_skinChangeInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011CE5 RID: 72933 RVA: 0x0029AC91 File Offset: 0x00298E91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomInteractionSkinChangeRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.skinChangeInfos_.Add(other.skinChangeInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011CE6 RID: 72934 RVA: 0x0029ACBF File Offset: 0x00298EBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011CE7 RID: 72935 RVA: 0x0029ACC8 File Offset: 0x00298EC8
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
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.skinChangeInfos_.AddEntriesFrom(ref input, PhantomInteractionSkinChangeRequest._repeated_skinChangeInfos_codec);
				}
			}
		}

		// Token: 0x04006FC6 RID: 28614
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006FC7 RID: 28615
		public const int SkinChangeInfosFieldNumber = 12;

		// Token: 0x04006FC8 RID: 28616
		private static readonly FieldCodec<SkinChangeInfo> _repeated_skinChangeInfos_codec = FieldCodec.ForMessage<SkinChangeInfo>(98U, SkinChangeInfo.Parser);

		// Token: 0x04006FC9 RID: 28617
		private readonly RepeatedField<SkinChangeInfo> skinChangeInfos_ = new RepeatedField<SkinChangeInfo>();
	}
}
