using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.CombatMessage
{
	// Token: 0x02001702 RID: 5890
	[NetMessage(EMessageId.CombatMessagePrefixInfoResponse)]
	public sealed class CombatMessagePrefixInfoResponse : IMessage<CombatMessagePrefixInfoResponse>, IMessage, IEquatable<CombatMessagePrefixInfoResponse>, IDeepCloneable<CombatMessagePrefixInfoResponse>, IBufferMessage
	{
		// Token: 0x0601D6D2 RID: 120530 RVA: 0x00441F65 File Offset: 0x00440165
		[NullableContext(1)]
		public static CombatMessagePrefixInfoResponse Create()
		{
			return new CombatMessagePrefixInfoResponse();
		}

		// Token: 0x17006385 RID: 25477
		// (get) Token: 0x0601D6D3 RID: 120531 RVA: 0x00441F6C File Offset: 0x0044016C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006386 RID: 25478
		// (get) Token: 0x0601D6D4 RID: 120532 RVA: 0x00441F6F File Offset: 0x0044016F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombatMessagePrefixInfoResponse.Descriptor;
			}
		}

		// Token: 0x0601D6D5 RID: 120533 RVA: 0x00441F76 File Offset: 0x00440176
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatMessagePrefixInfoResponse()
		{
		}

		// Token: 0x0601D6D6 RID: 120534 RVA: 0x00441F89 File Offset: 0x00440189
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatMessagePrefixInfoResponse(CombatMessagePrefixInfoResponse other) : this()
		{
			this.prefixInfo_ = other.prefixInfo_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D6D7 RID: 120535 RVA: 0x00441FAE File Offset: 0x004401AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatMessagePrefixInfoResponse Clone()
		{
			return new CombatMessagePrefixInfoResponse(this);
		}

		// Token: 0x17006387 RID: 25479
		// (get) Token: 0x0601D6D8 RID: 120536 RVA: 0x00441FB6 File Offset: 0x004401B6
		// (set) Token: 0x0601D6D9 RID: 120537 RVA: 0x00441FBE File Offset: 0x004401BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ByteString PrefixInfo
		{
			get
			{
				return this.prefixInfo_;
			}
			set
			{
				this.prefixInfo_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x0601D6DA RID: 120538 RVA: 0x00441FD1 File Offset: 0x004401D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombatMessagePrefixInfoResponse);
		}

		// Token: 0x0601D6DB RID: 120539 RVA: 0x00441FDF File Offset: 0x004401DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombatMessagePrefixInfoResponse other)
		{
			return other != null && (other == this || (!(this.PrefixInfo != other.PrefixInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D6DC RID: 120540 RVA: 0x00442014 File Offset: 0x00440214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PrefixInfo.Length != 0)
			{
				num ^= this.PrefixInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D6DD RID: 120541 RVA: 0x00442055 File Offset: 0x00440255
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D6DE RID: 120542 RVA: 0x00442062 File Offset: 0x00440262
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D6DF RID: 120543 RVA: 0x0044206B File Offset: 0x0044026B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PrefixInfo.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteBytes(this.PrefixInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D6E0 RID: 120544 RVA: 0x004420A4 File Offset: 0x004402A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PrefixInfo.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.PrefixInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D6E1 RID: 120545 RVA: 0x004420E7 File Offset: 0x004402E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CombatMessagePrefixInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PrefixInfo.Length != 0)
			{
				this.PrefixInfo = other.PrefixInfo;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D6E2 RID: 120546 RVA: 0x0044211D File Offset: 0x0044031D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D6E3 RID: 120547 RVA: 0x00442128 File Offset: 0x00440328
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
					this.PrefixInfo = input.ReadBytes();
				}
			}
		}

		// Token: 0x0400C740 RID: 51008
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C741 RID: 51009
		public const int PrefixInfoFieldNumber = 4;

		// Token: 0x0400C742 RID: 51010
		private ByteString prefixInfo_ = ByteString.Empty;
	}
}
