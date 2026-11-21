using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CDE RID: 3294
	[NetMessage(EMessageId.PhantomMusicUnlockRequest)]
	public sealed class PhantomMusicUnlockRequest : IMessage<PhantomMusicUnlockRequest>, IMessage, IEquatable<PhantomMusicUnlockRequest>, IDeepCloneable<PhantomMusicUnlockRequest>, IBufferMessage
	{
		// Token: 0x06011D6E RID: 73070 RVA: 0x0029C6F8 File Offset: 0x0029A8F8
		[NullableContext(1)]
		public static PhantomMusicUnlockRequest Create()
		{
			return new PhantomMusicUnlockRequest();
		}

		// Token: 0x17003B1B RID: 15131
		// (get) Token: 0x06011D6F RID: 73071 RVA: 0x0029C6FF File Offset: 0x0029A8FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B1C RID: 15132
		// (get) Token: 0x06011D70 RID: 73072 RVA: 0x0029C702 File Offset: 0x0029A902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomMusicUnlockRequest.Descriptor;
			}
		}

		// Token: 0x06011D71 RID: 73073 RVA: 0x0029C709 File Offset: 0x0029A909
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicUnlockRequest()
		{
		}

		// Token: 0x06011D72 RID: 73074 RVA: 0x0029C71C File Offset: 0x0029A91C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicUnlockRequest(PhantomMusicUnlockRequest other) : this()
		{
			this.items_ = other.items_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011D73 RID: 73075 RVA: 0x0029C746 File Offset: 0x0029A946
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicUnlockRequest Clone()
		{
			return new PhantomMusicUnlockRequest(this);
		}

		// Token: 0x17003B1D RID: 15133
		// (get) Token: 0x06011D74 RID: 73076 RVA: 0x0029C74E File Offset: 0x0029A94E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Items
		{
			get
			{
				return this.items_;
			}
		}

		// Token: 0x06011D75 RID: 73077 RVA: 0x0029C756 File Offset: 0x0029A956
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomMusicUnlockRequest);
		}

		// Token: 0x06011D76 RID: 73078 RVA: 0x0029C764 File Offset: 0x0029A964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomMusicUnlockRequest other)
		{
			return other != null && (other == this || (this.items_.Equals(other.items_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011D77 RID: 73079 RVA: 0x0029C798 File Offset: 0x0029A998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.items_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011D78 RID: 73080 RVA: 0x0029C7CC File Offset: 0x0029A9CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011D79 RID: 73081 RVA: 0x0029C7D9 File Offset: 0x0029A9D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011D7A RID: 73082 RVA: 0x0029C7E2 File Offset: 0x0029A9E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.items_.WriteTo(ref output, PhantomMusicUnlockRequest._repeated_items_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011D7B RID: 73083 RVA: 0x0029C80C File Offset: 0x0029AA0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.items_.CalculateSize(PhantomMusicUnlockRequest._repeated_items_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011D7C RID: 73084 RVA: 0x0029C845 File Offset: 0x0029AA45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomMusicUnlockRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.items_.Add(other.items_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011D7D RID: 73085 RVA: 0x0029C873 File Offset: 0x0029AA73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011D7E RID: 73086 RVA: 0x0029C87C File Offset: 0x0029AA7C
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
				if (num != 24U && num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.items_.AddEntriesFrom(ref input, PhantomMusicUnlockRequest._repeated_items_codec);
				}
			}
		}

		// Token: 0x04007060 RID: 28768
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007061 RID: 28769
		public const int ItemsFieldNumber = 3;

		// Token: 0x04007062 RID: 28770
		private static readonly FieldCodec<int> _repeated_items_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04007063 RID: 28771
		private readonly RepeatedField<int> items_ = new RepeatedField<int>();
	}
}
