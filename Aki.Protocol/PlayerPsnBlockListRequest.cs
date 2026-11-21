using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D90 RID: 3472
	[NetMessage(EMessageId.PlayerPsnBlockListRequest)]
	public sealed class PlayerPsnBlockListRequest : IMessage<PlayerPsnBlockListRequest>, IMessage, IEquatable<PlayerPsnBlockListRequest>, IDeepCloneable<PlayerPsnBlockListRequest>, IBufferMessage
	{
		// Token: 0x06012BC8 RID: 76744 RVA: 0x002BC3A9 File Offset: 0x002BA5A9
		[NullableContext(1)]
		public static PlayerPsnBlockListRequest Create()
		{
			return new PlayerPsnBlockListRequest();
		}

		// Token: 0x17003E2A RID: 15914
		// (get) Token: 0x06012BC9 RID: 76745 RVA: 0x002BC3B0 File Offset: 0x002BA5B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E2B RID: 15915
		// (get) Token: 0x06012BCA RID: 76746 RVA: 0x002BC3B3 File Offset: 0x002BA5B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerPsnBlockListRequest.Descriptor;
			}
		}

		// Token: 0x06012BCB RID: 76747 RVA: 0x002BC3BA File Offset: 0x002BA5BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerPsnBlockListRequest()
		{
		}

		// Token: 0x06012BCC RID: 76748 RVA: 0x002BC3CD File Offset: 0x002BA5CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerPsnBlockListRequest(PlayerPsnBlockListRequest other) : this()
		{
			this.psnAccountIds_ = other.psnAccountIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012BCD RID: 76749 RVA: 0x002BC3F7 File Offset: 0x002BA5F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerPsnBlockListRequest Clone()
		{
			return new PlayerPsnBlockListRequest(this);
		}

		// Token: 0x17003E2C RID: 15916
		// (get) Token: 0x06012BCE RID: 76750 RVA: 0x002BC3FF File Offset: 0x002BA5FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> PsnAccountIds
		{
			get
			{
				return this.psnAccountIds_;
			}
		}

		// Token: 0x06012BCF RID: 76751 RVA: 0x002BC407 File Offset: 0x002BA607
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerPsnBlockListRequest);
		}

		// Token: 0x06012BD0 RID: 76752 RVA: 0x002BC415 File Offset: 0x002BA615
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerPsnBlockListRequest other)
		{
			return other != null && (other == this || (this.psnAccountIds_.Equals(other.psnAccountIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012BD1 RID: 76753 RVA: 0x002BC448 File Offset: 0x002BA648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.psnAccountIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012BD2 RID: 76754 RVA: 0x002BC47C File Offset: 0x002BA67C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012BD3 RID: 76755 RVA: 0x002BC489 File Offset: 0x002BA689
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012BD4 RID: 76756 RVA: 0x002BC492 File Offset: 0x002BA692
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.psnAccountIds_.WriteTo(ref output, PlayerPsnBlockListRequest._repeated_psnAccountIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012BD5 RID: 76757 RVA: 0x002BC4BC File Offset: 0x002BA6BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.psnAccountIds_.CalculateSize(PlayerPsnBlockListRequest._repeated_psnAccountIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012BD6 RID: 76758 RVA: 0x002BC4F5 File Offset: 0x002BA6F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerPsnBlockListRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.psnAccountIds_.Add(other.psnAccountIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012BD7 RID: 76759 RVA: 0x002BC523 File Offset: 0x002BA723
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012BD8 RID: 76760 RVA: 0x002BC52C File Offset: 0x002BA72C
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
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.psnAccountIds_.AddEntriesFrom(ref input, PlayerPsnBlockListRequest._repeated_psnAccountIds_codec);
				}
			}
		}

		// Token: 0x04007486 RID: 29830
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007487 RID: 29831
		public const int PsnAccountIdsFieldNumber = 15;

		// Token: 0x04007488 RID: 29832
		private static readonly FieldCodec<string> _repeated_psnAccountIds_codec = FieldCodec.ForString(122U);

		// Token: 0x04007489 RID: 29833
		private readonly RepeatedField<string> psnAccountIds_ = new RepeatedField<string>();
	}
}
