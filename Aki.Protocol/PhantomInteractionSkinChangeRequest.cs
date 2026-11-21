using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CCA RID: 3274
	[NetMessage(EMessageId.PhantomInteractionSkinChangeRequest)]
	public sealed class PhantomInteractionSkinChangeRequest : IMessage<PhantomInteractionSkinChangeRequest>, IMessage, IEquatable<PhantomInteractionSkinChangeRequest>, IDeepCloneable<PhantomInteractionSkinChangeRequest>, IBufferMessage
	{
		// Token: 0x06011BDB RID: 72667 RVA: 0x00298F28 File Offset: 0x00297128
		[NullableContext(1)]
		public static PhantomInteractionSkinChangeRequest Create()
		{
			return new PhantomInteractionSkinChangeRequest();
		}

		// Token: 0x17003AC5 RID: 15045
		// (get) Token: 0x06011BDC RID: 72668 RVA: 0x00298F2F File Offset: 0x0029712F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003AC6 RID: 15046
		// (get) Token: 0x06011BDD RID: 72669 RVA: 0x00298F32 File Offset: 0x00297132
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomInteractionSkinChangeRequest.Descriptor;
			}
		}

		// Token: 0x06011BDE RID: 72670 RVA: 0x00298F39 File Offset: 0x00297139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomInteractionSkinChangeRequest()
		{
		}

		// Token: 0x06011BDF RID: 72671 RVA: 0x00298F4C File Offset: 0x0029714C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomInteractionSkinChangeRequest(PhantomInteractionSkinChangeRequest other) : this()
		{
			this.skinChangeInfos_ = other.skinChangeInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011BE0 RID: 72672 RVA: 0x00298F76 File Offset: 0x00297176
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomInteractionSkinChangeRequest Clone()
		{
			return new PhantomInteractionSkinChangeRequest(this);
		}

		// Token: 0x17003AC7 RID: 15047
		// (get) Token: 0x06011BE1 RID: 72673 RVA: 0x00298F7E File Offset: 0x0029717E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SkinChangeInfo> SkinChangeInfos
		{
			get
			{
				return this.skinChangeInfos_;
			}
		}

		// Token: 0x06011BE2 RID: 72674 RVA: 0x00298F86 File Offset: 0x00297186
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomInteractionSkinChangeRequest);
		}

		// Token: 0x06011BE3 RID: 72675 RVA: 0x00298F94 File Offset: 0x00297194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomInteractionSkinChangeRequest other)
		{
			return other != null && (other == this || (this.skinChangeInfos_.Equals(other.skinChangeInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011BE4 RID: 72676 RVA: 0x00298FC8 File Offset: 0x002971C8
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

		// Token: 0x06011BE5 RID: 72677 RVA: 0x00298FFC File Offset: 0x002971FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011BE6 RID: 72678 RVA: 0x00299009 File Offset: 0x00297209
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011BE7 RID: 72679 RVA: 0x00299012 File Offset: 0x00297212
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

		// Token: 0x06011BE8 RID: 72680 RVA: 0x0029903C File Offset: 0x0029723C
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

		// Token: 0x06011BE9 RID: 72681 RVA: 0x00299075 File Offset: 0x00297275
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

		// Token: 0x06011BEA RID: 72682 RVA: 0x002990A3 File Offset: 0x002972A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011BEB RID: 72683 RVA: 0x002990AC File Offset: 0x002972AC
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.skinChangeInfos_.AddEntriesFrom(ref input, PhantomInteractionSkinChangeRequest._repeated_skinChangeInfos_codec);
				}
			}
		}

		// Token: 0x04006FDE RID: 28638
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006FDF RID: 28639
		public const int SkinChangeInfosFieldNumber = 4;

		// Token: 0x04006FE0 RID: 28640
		private static readonly FieldCodec<SkinChangeInfo> _repeated_skinChangeInfos_codec = FieldCodec.ForMessage<SkinChangeInfo>(34U, SkinChangeInfo.Parser);

		// Token: 0x04006FE1 RID: 28641
		private readonly RepeatedField<SkinChangeInfo> skinChangeInfos_ = new RepeatedField<SkinChangeInfo>();
	}
}
