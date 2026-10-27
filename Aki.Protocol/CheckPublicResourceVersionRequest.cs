using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000284 RID: 644
	[NetMessage(EMessageId.CheckPublicResourceVersionRequest)]
	public sealed class CheckPublicResourceVersionRequest : IMessage<CheckPublicResourceVersionRequest>, IMessage, IEquatable<CheckPublicResourceVersionRequest>, IDeepCloneable<CheckPublicResourceVersionRequest>, IBufferMessage
	{
		// Token: 0x06004368 RID: 17256 RVA: 0x000A544D File Offset: 0x000A364D
		[NullableContext(1)]
		public static CheckPublicResourceVersionRequest Create()
		{
			return new CheckPublicResourceVersionRequest();
		}

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x06004369 RID: 17257 RVA: 0x000A5454 File Offset: 0x000A3654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x0600436A RID: 17258 RVA: 0x000A5457 File Offset: 0x000A3657
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CheckPublicResourceVersionRequest.Descriptor;
			}
		}

		// Token: 0x0600436B RID: 17259 RVA: 0x000A545E File Offset: 0x000A365E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheckPublicResourceVersionRequest()
		{
		}

		// Token: 0x0600436C RID: 17260 RVA: 0x000A5466 File Offset: 0x000A3666
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheckPublicResourceVersionRequest(CheckPublicResourceVersionRequest other) : this()
		{
			this.publicResourceVersionInfo_ = ((other.publicResourceVersionInfo_ != null) ? other.publicResourceVersionInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600436D RID: 17261 RVA: 0x000A549B File Offset: 0x000A369B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheckPublicResourceVersionRequest Clone()
		{
			return new CheckPublicResourceVersionRequest(this);
		}

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x0600436E RID: 17262 RVA: 0x000A54A3 File Offset: 0x000A36A3
		// (set) Token: 0x0600436F RID: 17263 RVA: 0x000A54AB File Offset: 0x000A36AB
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

		// Token: 0x06004370 RID: 17264 RVA: 0x000A54B4 File Offset: 0x000A36B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CheckPublicResourceVersionRequest);
		}

		// Token: 0x06004371 RID: 17265 RVA: 0x000A54C2 File Offset: 0x000A36C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CheckPublicResourceVersionRequest other)
		{
			return other != null && (other == this || (object.Equals(this.PublicResourceVersionInfo, other.PublicResourceVersionInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004372 RID: 17266 RVA: 0x000A54F8 File Offset: 0x000A36F8
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

		// Token: 0x06004373 RID: 17267 RVA: 0x000A5534 File Offset: 0x000A3734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004374 RID: 17268 RVA: 0x000A5541 File Offset: 0x000A3741
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004375 RID: 17269 RVA: 0x000A554A File Offset: 0x000A374A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.publicResourceVersionInfo_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.PublicResourceVersionInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004376 RID: 17270 RVA: 0x000A557C File Offset: 0x000A377C
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

		// Token: 0x06004377 RID: 17271 RVA: 0x000A55BC File Offset: 0x000A37BC
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

		// Token: 0x06004378 RID: 17272 RVA: 0x000A5610 File Offset: 0x000A3810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004379 RID: 17273 RVA: 0x000A561C File Offset: 0x000A381C
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
				if (num != 74U)
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

		// Token: 0x04002E53 RID: 11859
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E54 RID: 11860
		public const int PublicResourceVersionInfoFieldNumber = 9;

		// Token: 0x04002E55 RID: 11861
		private PublicResourceVersionInfo publicResourceVersionInfo_;
	}
}
