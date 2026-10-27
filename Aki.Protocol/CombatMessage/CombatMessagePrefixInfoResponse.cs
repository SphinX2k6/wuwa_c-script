using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.CombatMessage
{
	// Token: 0x02001686 RID: 5766
	[NetMessage(EMessageId.CombatMessagePrefixInfoResponse)]
	public sealed class CombatMessagePrefixInfoResponse : IMessage<CombatMessagePrefixInfoResponse>, IMessage, IEquatable<CombatMessagePrefixInfoResponse>, IDeepCloneable<CombatMessagePrefixInfoResponse>, IBufferMessage
	{
		// Token: 0x0601CC05 RID: 117765 RVA: 0x004262A5 File Offset: 0x004244A5
		[NullableContext(1)]
		public static CombatMessagePrefixInfoResponse Create()
		{
			return new CombatMessagePrefixInfoResponse();
		}

		// Token: 0x170060E1 RID: 24801
		// (get) Token: 0x0601CC06 RID: 117766 RVA: 0x004262AC File Offset: 0x004244AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170060E2 RID: 24802
		// (get) Token: 0x0601CC07 RID: 117767 RVA: 0x004262AF File Offset: 0x004244AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombatMessagePrefixInfoResponse.Descriptor;
			}
		}

		// Token: 0x0601CC08 RID: 117768 RVA: 0x004262B6 File Offset: 0x004244B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatMessagePrefixInfoResponse()
		{
		}

		// Token: 0x0601CC09 RID: 117769 RVA: 0x004262C9 File Offset: 0x004244C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatMessagePrefixInfoResponse(CombatMessagePrefixInfoResponse other) : this()
		{
			this.prefixInfo_ = other.prefixInfo_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CC0A RID: 117770 RVA: 0x004262EE File Offset: 0x004244EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatMessagePrefixInfoResponse Clone()
		{
			return new CombatMessagePrefixInfoResponse(this);
		}

		// Token: 0x170060E3 RID: 24803
		// (get) Token: 0x0601CC0B RID: 117771 RVA: 0x004262F6 File Offset: 0x004244F6
		// (set) Token: 0x0601CC0C RID: 117772 RVA: 0x004262FE File Offset: 0x004244FE
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

		// Token: 0x0601CC0D RID: 117773 RVA: 0x00426311 File Offset: 0x00424511
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombatMessagePrefixInfoResponse);
		}

		// Token: 0x0601CC0E RID: 117774 RVA: 0x0042631F File Offset: 0x0042451F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombatMessagePrefixInfoResponse other)
		{
			return other != null && (other == this || (!(this.PrefixInfo != other.PrefixInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CC0F RID: 117775 RVA: 0x00426354 File Offset: 0x00424554
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

		// Token: 0x0601CC10 RID: 117776 RVA: 0x00426395 File Offset: 0x00424595
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CC11 RID: 117777 RVA: 0x004263A2 File Offset: 0x004245A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CC12 RID: 117778 RVA: 0x004263AB File Offset: 0x004245AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PrefixInfo.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteBytes(this.PrefixInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CC13 RID: 117779 RVA: 0x004263E4 File Offset: 0x004245E4
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

		// Token: 0x0601CC14 RID: 117780 RVA: 0x00426427 File Offset: 0x00424627
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

		// Token: 0x0601CC15 RID: 117781 RVA: 0x0042645D File Offset: 0x0042465D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CC16 RID: 117782 RVA: 0x00426468 File Offset: 0x00424668
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PrefixInfo = input.ReadBytes();
				}
			}
		}

		// Token: 0x0400C214 RID: 49684
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C215 RID: 49685
		public const int PrefixInfoFieldNumber = 10;

		// Token: 0x0400C216 RID: 49686
		private ByteString prefixInfo_ = ByteString.Empty;
	}
}
