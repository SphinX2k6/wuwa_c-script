using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009B8 RID: 2488
	[NetMessage(EMessageId.MatchConfirmRequest)]
	public sealed class MatchConfirmRequest : IMessage<MatchConfirmRequest>, IMessage, IEquatable<MatchConfirmRequest>, IDeepCloneable<MatchConfirmRequest>, IBufferMessage
	{
		// Token: 0x0600DA4B RID: 55883 RVA: 0x00200CDD File Offset: 0x001FEEDD
		[NullableContext(1)]
		public static MatchConfirmRequest Create()
		{
			return new MatchConfirmRequest();
		}

		// Token: 0x17002C35 RID: 11317
		// (get) Token: 0x0600DA4C RID: 55884 RVA: 0x00200CE4 File Offset: 0x001FEEE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C36 RID: 11318
		// (get) Token: 0x0600DA4D RID: 55885 RVA: 0x00200CE7 File Offset: 0x001FEEE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchConfirmRequest.Descriptor;
			}
		}

		// Token: 0x0600DA4E RID: 55886 RVA: 0x00200CEE File Offset: 0x001FEEEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchConfirmRequest()
		{
		}

		// Token: 0x0600DA4F RID: 55887 RVA: 0x00200CF6 File Offset: 0x001FEEF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchConfirmRequest(MatchConfirmRequest other) : this()
		{
			this.isAccept_ = other.isAccept_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DA50 RID: 55888 RVA: 0x00200D1B File Offset: 0x001FEF1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchConfirmRequest Clone()
		{
			return new MatchConfirmRequest(this);
		}

		// Token: 0x17002C37 RID: 11319
		// (get) Token: 0x0600DA51 RID: 55889 RVA: 0x00200D23 File Offset: 0x001FEF23
		// (set) Token: 0x0600DA52 RID: 55890 RVA: 0x00200D2B File Offset: 0x001FEF2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsAccept
		{
			get
			{
				return this.isAccept_;
			}
			set
			{
				this.isAccept_ = value;
			}
		}

		// Token: 0x0600DA53 RID: 55891 RVA: 0x00200D34 File Offset: 0x001FEF34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchConfirmRequest);
		}

		// Token: 0x0600DA54 RID: 55892 RVA: 0x00200D42 File Offset: 0x001FEF42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchConfirmRequest other)
		{
			return other != null && (other == this || (this.IsAccept == other.IsAccept && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DA55 RID: 55893 RVA: 0x00200D70 File Offset: 0x001FEF70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsAccept)
			{
				num ^= this.IsAccept.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DA56 RID: 55894 RVA: 0x00200DAF File Offset: 0x001FEFAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DA57 RID: 55895 RVA: 0x00200DBC File Offset: 0x001FEFBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DA58 RID: 55896 RVA: 0x00200DC5 File Offset: 0x001FEFC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsAccept)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsAccept);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DA59 RID: 55897 RVA: 0x00200DF8 File Offset: 0x001FEFF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsAccept)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DA5A RID: 55898 RVA: 0x00200E2A File Offset: 0x001FF02A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchConfirmRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsAccept)
			{
				this.IsAccept = other.IsAccept;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DA5B RID: 55899 RVA: 0x00200E5B File Offset: 0x001FF05B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DA5C RID: 55900 RVA: 0x00200E64 File Offset: 0x001FF064
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.IsAccept = input.ReadBool();
				}
			}
		}

		// Token: 0x04005AAC RID: 23212
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005AAD RID: 23213
		public const int IsAcceptFieldNumber = 5;

		// Token: 0x04005AAE RID: 23214
		private bool isAccept_;
	}
}
