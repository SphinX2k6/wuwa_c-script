using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001E6 RID: 486
	[NetMessage(EMessageId.BtCancelRangeFailWarningNotify)]
	public sealed class BtCancelRangeFailWarningNotify : IMessage<BtCancelRangeFailWarningNotify>, IMessage, IEquatable<BtCancelRangeFailWarningNotify>, IDeepCloneable<BtCancelRangeFailWarningNotify>, IBufferMessage
	{
		// Token: 0x06003693 RID: 13971 RVA: 0x00088DE5 File Offset: 0x00086FE5
		[NullableContext(1)]
		public static BtCancelRangeFailWarningNotify Create()
		{
			return new BtCancelRangeFailWarningNotify();
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x06003694 RID: 13972 RVA: 0x00088DEC File Offset: 0x00086FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x06003695 RID: 13973 RVA: 0x00088DEF File Offset: 0x00086FEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BtCancelRangeFailWarningNotify.Descriptor;
			}
		}

		// Token: 0x06003696 RID: 13974 RVA: 0x00088DF6 File Offset: 0x00086FF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtCancelRangeFailWarningNotify()
		{
		}

		// Token: 0x06003697 RID: 13975 RVA: 0x00088DFE File Offset: 0x00086FFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtCancelRangeFailWarningNotify(BtCancelRangeFailWarningNotify other) : this()
		{
			this.treeIncId_ = other.treeIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003698 RID: 13976 RVA: 0x00088E23 File Offset: 0x00087023
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtCancelRangeFailWarningNotify Clone()
		{
			return new BtCancelRangeFailWarningNotify(this);
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x06003699 RID: 13977 RVA: 0x00088E2B File Offset: 0x0008702B
		// (set) Token: 0x0600369A RID: 13978 RVA: 0x00088E33 File Offset: 0x00087033
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

		// Token: 0x0600369B RID: 13979 RVA: 0x00088E3C File Offset: 0x0008703C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BtCancelRangeFailWarningNotify);
		}

		// Token: 0x0600369C RID: 13980 RVA: 0x00088E4A File Offset: 0x0008704A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BtCancelRangeFailWarningNotify other)
		{
			return other != null && (other == this || (this.TreeIncId == other.TreeIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600369D RID: 13981 RVA: 0x00088E78 File Offset: 0x00087078
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

		// Token: 0x0600369E RID: 13982 RVA: 0x00088EB7 File Offset: 0x000870B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600369F RID: 13983 RVA: 0x00088EC4 File Offset: 0x000870C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060036A0 RID: 13984 RVA: 0x00088ECD File Offset: 0x000870CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.TreeIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060036A1 RID: 13985 RVA: 0x00088F00 File Offset: 0x00087100
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

		// Token: 0x060036A2 RID: 13986 RVA: 0x00088F3E File Offset: 0x0008713E
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

		// Token: 0x060036A3 RID: 13987 RVA: 0x00088F6F File Offset: 0x0008716F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060036A4 RID: 13988 RVA: 0x00088F78 File Offset: 0x00087178
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TreeIncId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04002AAA RID: 10922
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002AAB RID: 10923
		public const int TreeIncIdFieldNumber = 10;

		// Token: 0x04002AAC RID: 10924
		private long treeIncId_;
	}
}
