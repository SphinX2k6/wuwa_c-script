using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007F9 RID: 2041
	[NetMessage(EMessageId.InfrV2TreeUpdateNotify)]
	public sealed class InfrV2TreeUpdateNotify : IMessage<InfrV2TreeUpdateNotify>, IMessage, IEquatable<InfrV2TreeUpdateNotify>, IDeepCloneable<InfrV2TreeUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600B704 RID: 46852 RVA: 0x001B4804 File Offset: 0x001B2A04
		[NullableContext(1)]
		public static InfrV2TreeUpdateNotify Create()
		{
			return new InfrV2TreeUpdateNotify();
		}

		// Token: 0x170024DA RID: 9434
		// (get) Token: 0x0600B705 RID: 46853 RVA: 0x001B480B File Offset: 0x001B2A0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024DB RID: 9435
		// (get) Token: 0x0600B706 RID: 46854 RVA: 0x001B480E File Offset: 0x001B2A0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2TreeUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600B707 RID: 46855 RVA: 0x001B4815 File Offset: 0x001B2A15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TreeUpdateNotify()
		{
		}

		// Token: 0x0600B708 RID: 46856 RVA: 0x001B481D File Offset: 0x001B2A1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TreeUpdateNotify(InfrV2TreeUpdateNotify other) : this()
		{
			this.treeInfo_ = ((other.treeInfo_ != null) ? other.treeInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B709 RID: 46857 RVA: 0x001B4852 File Offset: 0x001B2A52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TreeUpdateNotify Clone()
		{
			return new InfrV2TreeUpdateNotify(this);
		}

		// Token: 0x170024DC RID: 9436
		// (get) Token: 0x0600B70A RID: 46858 RVA: 0x001B485A File Offset: 0x001B2A5A
		// (set) Token: 0x0600B70B RID: 46859 RVA: 0x001B4862 File Offset: 0x001B2A62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TreePb TreeInfo
		{
			get
			{
				return this.treeInfo_;
			}
			set
			{
				this.treeInfo_ = value;
			}
		}

		// Token: 0x0600B70C RID: 46860 RVA: 0x001B486B File Offset: 0x001B2A6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2TreeUpdateNotify);
		}

		// Token: 0x0600B70D RID: 46861 RVA: 0x001B4879 File Offset: 0x001B2A79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2TreeUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.TreeInfo, other.TreeInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B70E RID: 46862 RVA: 0x001B48AC File Offset: 0x001B2AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.treeInfo_ != null)
			{
				num ^= this.TreeInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B70F RID: 46863 RVA: 0x001B48E8 File Offset: 0x001B2AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B710 RID: 46864 RVA: 0x001B48F5 File Offset: 0x001B2AF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B711 RID: 46865 RVA: 0x001B48FE File Offset: 0x001B2AFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.treeInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.TreeInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B712 RID: 46866 RVA: 0x001B4930 File Offset: 0x001B2B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.treeInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TreeInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B713 RID: 46867 RVA: 0x001B4970 File Offset: 0x001B2B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrV2TreeUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.treeInfo_ != null)
			{
				if (this.treeInfo_ == null)
				{
					this.TreeInfo = new InfrV2TreePb();
				}
				this.TreeInfo.MergeFrom(other.TreeInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B714 RID: 46868 RVA: 0x001B49C4 File Offset: 0x001B2BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B715 RID: 46869 RVA: 0x001B49D0 File Offset: 0x001B2BD0
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.treeInfo_ == null)
					{
						this.TreeInfo = new InfrV2TreePb();
					}
					input.ReadMessage(this.TreeInfo);
				}
			}
		}

		// Token: 0x04005131 RID: 20785
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005132 RID: 20786
		public const int TreeInfoFieldNumber = 1;

		// Token: 0x04005133 RID: 20787
		private InfrV2TreePb treeInfo_;
	}
}
