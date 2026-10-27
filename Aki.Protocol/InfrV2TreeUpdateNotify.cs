using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200080D RID: 2061
	[NetMessage(EMessageId.InfrV2TreeUpdateNotify)]
	public sealed class InfrV2TreeUpdateNotify : IMessage<InfrV2TreeUpdateNotify>, IMessage, IEquatable<InfrV2TreeUpdateNotify>, IDeepCloneable<InfrV2TreeUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600B85A RID: 47194 RVA: 0x001B7244 File Offset: 0x001B5444
		[NullableContext(1)]
		public static InfrV2TreeUpdateNotify Create()
		{
			return new InfrV2TreeUpdateNotify();
		}

		// Token: 0x17002524 RID: 9508
		// (get) Token: 0x0600B85B RID: 47195 RVA: 0x001B724B File Offset: 0x001B544B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002525 RID: 9509
		// (get) Token: 0x0600B85C RID: 47196 RVA: 0x001B724E File Offset: 0x001B544E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2TreeUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600B85D RID: 47197 RVA: 0x001B7255 File Offset: 0x001B5455
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TreeUpdateNotify()
		{
		}

		// Token: 0x0600B85E RID: 47198 RVA: 0x001B725D File Offset: 0x001B545D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TreeUpdateNotify(InfrV2TreeUpdateNotify other) : this()
		{
			this.treeInfo_ = ((other.treeInfo_ != null) ? other.treeInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B85F RID: 47199 RVA: 0x001B7292 File Offset: 0x001B5492
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TreeUpdateNotify Clone()
		{
			return new InfrV2TreeUpdateNotify(this);
		}

		// Token: 0x17002526 RID: 9510
		// (get) Token: 0x0600B860 RID: 47200 RVA: 0x001B729A File Offset: 0x001B549A
		// (set) Token: 0x0600B861 RID: 47201 RVA: 0x001B72A2 File Offset: 0x001B54A2
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

		// Token: 0x0600B862 RID: 47202 RVA: 0x001B72AB File Offset: 0x001B54AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2TreeUpdateNotify);
		}

		// Token: 0x0600B863 RID: 47203 RVA: 0x001B72B9 File Offset: 0x001B54B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2TreeUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.TreeInfo, other.TreeInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B864 RID: 47204 RVA: 0x001B72EC File Offset: 0x001B54EC
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

		// Token: 0x0600B865 RID: 47205 RVA: 0x001B7328 File Offset: 0x001B5528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B866 RID: 47206 RVA: 0x001B7335 File Offset: 0x001B5535
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B867 RID: 47207 RVA: 0x001B733E File Offset: 0x001B553E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.treeInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.TreeInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B868 RID: 47208 RVA: 0x001B7370 File Offset: 0x001B5570
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

		// Token: 0x0600B869 RID: 47209 RVA: 0x001B73B0 File Offset: 0x001B55B0
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

		// Token: 0x0600B86A RID: 47210 RVA: 0x001B7404 File Offset: 0x001B5604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B86B RID: 47211 RVA: 0x001B7410 File Offset: 0x001B5610
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
				if (num != 90U)
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

		// Token: 0x04005138 RID: 20792
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005139 RID: 20793
		public const int TreeInfoFieldNumber = 11;

		// Token: 0x0400513A RID: 20794
		private InfrV2TreePb treeInfo_;
	}
}
