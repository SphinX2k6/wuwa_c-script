using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200025D RID: 605
	[NetMessage(EMessageId.ChangePlayerTitleRequest)]
	public sealed class ChangePlayerTitleRequest : IMessage<ChangePlayerTitleRequest>, IMessage, IEquatable<ChangePlayerTitleRequest>, IDeepCloneable<ChangePlayerTitleRequest>, IBufferMessage
	{
		// Token: 0x06004066 RID: 16486 RVA: 0x0009E913 File Offset: 0x0009CB13
		[NullableContext(1)]
		public static ChangePlayerTitleRequest Create()
		{
			return new ChangePlayerTitleRequest();
		}

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x06004067 RID: 16487 RVA: 0x0009E91A File Offset: 0x0009CB1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x06004068 RID: 16488 RVA: 0x0009E91D File Offset: 0x0009CB1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangePlayerTitleRequest.Descriptor;
			}
		}

		// Token: 0x06004069 RID: 16489 RVA: 0x0009E924 File Offset: 0x0009CB24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangePlayerTitleRequest()
		{
		}

		// Token: 0x0600406A RID: 16490 RVA: 0x0009E92C File Offset: 0x0009CB2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangePlayerTitleRequest(ChangePlayerTitleRequest other) : this()
		{
			this.playerTitleId_ = other.playerTitleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600406B RID: 16491 RVA: 0x0009E951 File Offset: 0x0009CB51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangePlayerTitleRequest Clone()
		{
			return new ChangePlayerTitleRequest(this);
		}

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x0600406C RID: 16492 RVA: 0x0009E959 File Offset: 0x0009CB59
		// (set) Token: 0x0600406D RID: 16493 RVA: 0x0009E961 File Offset: 0x0009CB61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerTitleId
		{
			get
			{
				return this.playerTitleId_;
			}
			set
			{
				this.playerTitleId_ = value;
			}
		}

		// Token: 0x0600406E RID: 16494 RVA: 0x0009E96A File Offset: 0x0009CB6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangePlayerTitleRequest);
		}

		// Token: 0x0600406F RID: 16495 RVA: 0x0009E978 File Offset: 0x0009CB78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangePlayerTitleRequest other)
		{
			return other != null && (other == this || (this.PlayerTitleId == other.PlayerTitleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004070 RID: 16496 RVA: 0x0009E9A8 File Offset: 0x0009CBA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerTitleId != 0)
			{
				num ^= this.PlayerTitleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004071 RID: 16497 RVA: 0x0009E9E7 File Offset: 0x0009CBE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004072 RID: 16498 RVA: 0x0009E9F4 File Offset: 0x0009CBF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004073 RID: 16499 RVA: 0x0009E9FD File Offset: 0x0009CBFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerTitleId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.PlayerTitleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004074 RID: 16500 RVA: 0x0009EA30 File Offset: 0x0009CC30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerTitleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerTitleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004075 RID: 16501 RVA: 0x0009EA6E File Offset: 0x0009CC6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangePlayerTitleRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerTitleId != 0)
			{
				this.PlayerTitleId = other.PlayerTitleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004076 RID: 16502 RVA: 0x0009EA9F File Offset: 0x0009CC9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004077 RID: 16503 RVA: 0x0009EAA8 File Offset: 0x0009CCA8
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PlayerTitleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002DBA RID: 11706
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DBB RID: 11707
		public const int PlayerTitleIdFieldNumber = 3;

		// Token: 0x04002DBC RID: 11708
		private int playerTitleId_;
	}
}
