using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000289 RID: 649
	[NetMessage(EMessageId.CheckPublicResourceVersionRequest)]
	public sealed class CheckPublicResourceVersionRequest : IMessage<CheckPublicResourceVersionRequest>, IMessage, IEquatable<CheckPublicResourceVersionRequest>, IDeepCloneable<CheckPublicResourceVersionRequest>, IBufferMessage
	{
		// Token: 0x0600440F RID: 17423 RVA: 0x000A7115 File Offset: 0x000A5315
		[NullableContext(1)]
		public static CheckPublicResourceVersionRequest Create()
		{
			return new CheckPublicResourceVersionRequest();
		}

		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x06004410 RID: 17424 RVA: 0x000A711C File Offset: 0x000A531C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x06004411 RID: 17425 RVA: 0x000A711F File Offset: 0x000A531F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CheckPublicResourceVersionRequest.Descriptor;
			}
		}

		// Token: 0x06004412 RID: 17426 RVA: 0x000A7126 File Offset: 0x000A5326
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheckPublicResourceVersionRequest()
		{
		}

		// Token: 0x06004413 RID: 17427 RVA: 0x000A712E File Offset: 0x000A532E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheckPublicResourceVersionRequest(CheckPublicResourceVersionRequest other) : this()
		{
			this.publicResourceVersionInfo_ = ((other.publicResourceVersionInfo_ != null) ? other.publicResourceVersionInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004414 RID: 17428 RVA: 0x000A7163 File Offset: 0x000A5363
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheckPublicResourceVersionRequest Clone()
		{
			return new CheckPublicResourceVersionRequest(this);
		}

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x06004415 RID: 17429 RVA: 0x000A716B File Offset: 0x000A536B
		// (set) Token: 0x06004416 RID: 17430 RVA: 0x000A7173 File Offset: 0x000A5373
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PublicResourceVersionInfo PublicResourceVersionInfo
		{
			get
			{
				return this.publicResourceVersionInfo_;
			}
			set
			{
				this.publicResourceVersionInfo_ = value;
			}
		}

		// Token: 0x06004417 RID: 17431 RVA: 0x000A717C File Offset: 0x000A537C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CheckPublicResourceVersionRequest);
		}

		// Token: 0x06004418 RID: 17432 RVA: 0x000A718A File Offset: 0x000A538A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CheckPublicResourceVersionRequest other)
		{
			return other != null && (other == this || (object.Equals(this.PublicResourceVersionInfo, other.PublicResourceVersionInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004419 RID: 17433 RVA: 0x000A71C0 File Offset: 0x000A53C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.publicResourceVersionInfo_ != null)
			{
				num ^= this.PublicResourceVersionInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600441A RID: 17434 RVA: 0x000A71FC File Offset: 0x000A53FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600441B RID: 17435 RVA: 0x000A7209 File Offset: 0x000A5409
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600441C RID: 17436 RVA: 0x000A7212 File Offset: 0x000A5412
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.publicResourceVersionInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.PublicResourceVersionInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600441D RID: 17437 RVA: 0x000A7244 File Offset: 0x000A5444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.publicResourceVersionInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PublicResourceVersionInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600441E RID: 17438 RVA: 0x000A7284 File Offset: 0x000A5484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CheckPublicResourceVersionRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.publicResourceVersionInfo_ != null)
			{
				if (this.publicResourceVersionInfo_ == null)
				{
					this.PublicResourceVersionInfo = new PublicResourceVersionInfo();
				}
				this.PublicResourceVersionInfo.MergeFrom(other.PublicResourceVersionInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600441F RID: 17439 RVA: 0x000A72D8 File Offset: 0x000A54D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004420 RID: 17440 RVA: 0x000A72E4 File Offset: 0x000A54E4
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
					if (this.publicResourceVersionInfo_ == null)
					{
						this.PublicResourceVersionInfo = new PublicResourceVersionInfo();
					}
					input.ReadMessage(this.PublicResourceVersionInfo);
				}
			}
		}

		// Token: 0x04002ED7 RID: 11991
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002ED8 RID: 11992
		public const int PublicResourceVersionInfoFieldNumber = 12;

		// Token: 0x04002ED9 RID: 11993
		private PublicResourceVersionInfo publicResourceVersionInfo_;
	}
}
