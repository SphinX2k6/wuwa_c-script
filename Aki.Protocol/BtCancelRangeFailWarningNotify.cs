using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001EA RID: 490
	[NetMessage(EMessageId.BtCancelRangeFailWarningNotify)]
	public sealed class BtCancelRangeFailWarningNotify : IMessage<BtCancelRangeFailWarningNotify>, IMessage, IEquatable<BtCancelRangeFailWarningNotify>, IDeepCloneable<BtCancelRangeFailWarningNotify>, IBufferMessage
	{
		// Token: 0x06003720 RID: 14112 RVA: 0x0008A559 File Offset: 0x00088759
		[NullableContext(1)]
		public static BtCancelRangeFailWarningNotify Create()
		{
			return new BtCancelRangeFailWarningNotify();
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x06003721 RID: 14113 RVA: 0x0008A560 File Offset: 0x00088760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x06003722 RID: 14114 RVA: 0x0008A563 File Offset: 0x00088763
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BtCancelRangeFailWarningNotify.Descriptor;
			}
		}

		// Token: 0x06003723 RID: 14115 RVA: 0x0008A56A File Offset: 0x0008876A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtCancelRangeFailWarningNotify()
		{
		}

		// Token: 0x06003724 RID: 14116 RVA: 0x0008A572 File Offset: 0x00088772
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtCancelRangeFailWarningNotify(BtCancelRangeFailWarningNotify other) : this()
		{
			this.treeIncId_ = other.treeIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003725 RID: 14117 RVA: 0x0008A597 File Offset: 0x00088797
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtCancelRangeFailWarningNotify Clone()
		{
			return new BtCancelRangeFailWarningNotify(this);
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x06003726 RID: 14118 RVA: 0x0008A59F File Offset: 0x0008879F
		// (set) Token: 0x06003727 RID: 14119 RVA: 0x0008A5A7 File Offset: 0x000887A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TreeIncId
		{
			get
			{
				return this.treeIncId_;
			}
			set
			{
				this.treeIncId_ = value;
			}
		}

		// Token: 0x06003728 RID: 14120 RVA: 0x0008A5B0 File Offset: 0x000887B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BtCancelRangeFailWarningNotify);
		}

		// Token: 0x06003729 RID: 14121 RVA: 0x0008A5BE File Offset: 0x000887BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BtCancelRangeFailWarningNotify other)
		{
			return other != null && (other == this || (this.TreeIncId == other.TreeIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600372A RID: 14122 RVA: 0x0008A5EC File Offset: 0x000887EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TreeIncId != 0L)
			{
				num ^= this.TreeIncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600372B RID: 14123 RVA: 0x0008A62B File Offset: 0x0008882B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600372C RID: 14124 RVA: 0x0008A638 File Offset: 0x00088838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600372D RID: 14125 RVA: 0x0008A641 File Offset: 0x00088841
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.TreeIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600372E RID: 14126 RVA: 0x0008A674 File Offset: 0x00088874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TreeIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TreeIncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600372F RID: 14127 RVA: 0x0008A6B2 File Offset: 0x000888B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BtCancelRangeFailWarningNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TreeIncId != 0L)
			{
				this.TreeIncId = other.TreeIncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003730 RID: 14128 RVA: 0x0008A6E3 File Offset: 0x000888E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003731 RID: 14129 RVA: 0x0008A6EC File Offset: 0x000888EC
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TreeIncId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04002B25 RID: 11045
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B26 RID: 11046
		public const int TreeIncIdFieldNumber = 12;

		// Token: 0x04002B27 RID: 11047
		private long treeIncId_;
	}
}
