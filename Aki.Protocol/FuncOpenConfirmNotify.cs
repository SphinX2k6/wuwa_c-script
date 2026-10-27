using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000674 RID: 1652
	[NetMessage(EMessageId.FuncOpenConfirmNotify)]
	public sealed class FuncOpenConfirmNotify : IMessage<FuncOpenConfirmNotify>, IMessage, IEquatable<FuncOpenConfirmNotify>, IDeepCloneable<FuncOpenConfirmNotify>, IBufferMessage
	{
		// Token: 0x0600977D RID: 38781 RVA: 0x0016D742 File Offset: 0x0016B942
		[NullableContext(1)]
		public static FuncOpenConfirmNotify Create()
		{
			return new FuncOpenConfirmNotify();
		}

		// Token: 0x17001E30 RID: 7728
		// (get) Token: 0x0600977E RID: 38782 RVA: 0x0016D749 File Offset: 0x0016B949
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E31 RID: 7729
		// (get) Token: 0x0600977F RID: 38783 RVA: 0x0016D74C File Offset: 0x0016B94C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FuncOpenConfirmNotify.Descriptor;
			}
		}

		// Token: 0x06009780 RID: 38784 RVA: 0x0016D753 File Offset: 0x0016B953
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FuncOpenConfirmNotify()
		{
		}

		// Token: 0x06009781 RID: 38785 RVA: 0x0016D766 File Offset: 0x0016B966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FuncOpenConfirmNotify(FuncOpenConfirmNotify other) : this()
		{
			this.funcInfo_ = other.funcInfo_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009782 RID: 38786 RVA: 0x0016D78B File Offset: 0x0016B98B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FuncOpenConfirmNotify Clone()
		{
			return new FuncOpenConfirmNotify(this);
		}

		// Token: 0x17001E32 RID: 7730
		// (get) Token: 0x06009783 RID: 38787 RVA: 0x0016D793 File Offset: 0x0016B993
		// (set) Token: 0x06009784 RID: 38788 RVA: 0x0016D79B File Offset: 0x0016B99B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ByteString FuncInfo
		{
			get
			{
				return this.funcInfo_;
			}
			set
			{
				this.funcInfo_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x06009785 RID: 38789 RVA: 0x0016D7AE File Offset: 0x0016B9AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FuncOpenConfirmNotify);
		}

		// Token: 0x06009786 RID: 38790 RVA: 0x0016D7BC File Offset: 0x0016B9BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FuncOpenConfirmNotify other)
		{
			return other != null && (other == this || (!(this.FuncInfo != other.FuncInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009787 RID: 38791 RVA: 0x0016D7F0 File Offset: 0x0016B9F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FuncInfo.Length != 0)
			{
				num ^= this.FuncInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009788 RID: 38792 RVA: 0x0016D831 File Offset: 0x0016BA31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009789 RID: 38793 RVA: 0x0016D83E File Offset: 0x0016BA3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600978A RID: 38794 RVA: 0x0016D847 File Offset: 0x0016BA47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FuncInfo.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteBytes(this.FuncInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600978B RID: 38795 RVA: 0x0016D880 File Offset: 0x0016BA80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FuncInfo.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.FuncInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600978C RID: 38796 RVA: 0x0016D8C3 File Offset: 0x0016BAC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FuncOpenConfirmNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FuncInfo.Length != 0)
			{
				this.FuncInfo = other.FuncInfo;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600978D RID: 38797 RVA: 0x0016D8F9 File Offset: 0x0016BAF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600978E RID: 38798 RVA: 0x0016D904 File Offset: 0x0016BB04
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.FuncInfo = input.ReadBytes();
				}
			}
		}

		// Token: 0x04004805 RID: 18437
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004806 RID: 18438
		public const int FuncInfoFieldNumber = 2;

		// Token: 0x04004807 RID: 18439
		private ByteString funcInfo_ = ByteString.Empty;
	}
}
