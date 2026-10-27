using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CEE RID: 3310
	[NetMessage(EMessageId.PhantomMusicUnlockRequest)]
	public sealed class PhantomMusicUnlockRequest : IMessage<PhantomMusicUnlockRequest>, IMessage, IEquatable<PhantomMusicUnlockRequest>, IDeepCloneable<PhantomMusicUnlockRequest>, IBufferMessage
	{
		// Token: 0x06011E6A RID: 73322 RVA: 0x0029E310 File Offset: 0x0029C510
		[NullableContext(1)]
		public static PhantomMusicUnlockRequest Create()
		{
			return new PhantomMusicUnlockRequest();
		}

		// Token: 0x17003B50 RID: 15184
		// (get) Token: 0x06011E6B RID: 73323 RVA: 0x0029E317 File Offset: 0x0029C517
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B51 RID: 15185
		// (get) Token: 0x06011E6C RID: 73324 RVA: 0x0029E31A File Offset: 0x0029C51A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomMusicUnlockRequest.Descriptor;
			}
		}

		// Token: 0x06011E6D RID: 73325 RVA: 0x0029E321 File Offset: 0x0029C521
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicUnlockRequest()
		{
		}

		// Token: 0x06011E6E RID: 73326 RVA: 0x0029E334 File Offset: 0x0029C534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicUnlockRequest(PhantomMusicUnlockRequest other) : this()
		{
			this.items_ = other.items_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011E6F RID: 73327 RVA: 0x0029E35E File Offset: 0x0029C55E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicUnlockRequest Clone()
		{
			return new PhantomMusicUnlockRequest(this);
		}

		// Token: 0x17003B52 RID: 15186
		// (get) Token: 0x06011E70 RID: 73328 RVA: 0x0029E366 File Offset: 0x0029C566
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Items
		{
			get
			{
				return this.items_;
			}
		}

		// Token: 0x06011E71 RID: 73329 RVA: 0x0029E36E File Offset: 0x0029C56E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomMusicUnlockRequest);
		}

		// Token: 0x06011E72 RID: 73330 RVA: 0x0029E37C File Offset: 0x0029C57C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomMusicUnlockRequest other)
		{
			return other != null && (other == this || (this.items_.Equals(other.items_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011E73 RID: 73331 RVA: 0x0029E3B0 File Offset: 0x0029C5B0
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

		// Token: 0x06011E74 RID: 73332 RVA: 0x0029E3E4 File Offset: 0x0029C5E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011E75 RID: 73333 RVA: 0x0029E3F1 File Offset: 0x0029C5F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011E76 RID: 73334 RVA: 0x0029E3FA File Offset: 0x0029C5FA
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

		// Token: 0x06011E77 RID: 73335 RVA: 0x0029E424 File Offset: 0x0029C624
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

		// Token: 0x06011E78 RID: 73336 RVA: 0x0029E45D File Offset: 0x0029C65D
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

		// Token: 0x06011E79 RID: 73337 RVA: 0x0029E48B File Offset: 0x0029C68B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011E7A RID: 73338 RVA: 0x0029E494 File Offset: 0x0029C694
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

		// Token: 0x04007048 RID: 28744
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007049 RID: 28745
		public const int ItemsFieldNumber = 3;

		// Token: 0x0400704A RID: 28746
		private static readonly FieldCodec<int> _repeated_items_codec = FieldCodec.ForInt32(26U);

		// Token: 0x0400704B RID: 28747
		private readonly RepeatedField<int> items_ = new RepeatedField<int>();
	}
}
