using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001F0 RID: 496
	[NetMessage(EMessageId.BtRangeFailWarningNotify)]
	public sealed class BtRangeFailWarningNotify : IMessage<BtRangeFailWarningNotify>, IMessage, IEquatable<BtRangeFailWarningNotify>, IDeepCloneable<BtRangeFailWarningNotify>, IBufferMessage
	{
		// Token: 0x06003796 RID: 14230 RVA: 0x0008B37E File Offset: 0x0008957E
		[NullableContext(1)]
		public static BtRangeFailWarningNotify Create()
		{
			return new BtRangeFailWarningNotify();
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x06003797 RID: 14231 RVA: 0x0008B385 File Offset: 0x00089585
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x06003798 RID: 14232 RVA: 0x0008B388 File Offset: 0x00089588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BtRangeFailWarningNotify.Descriptor;
			}
		}

		// Token: 0x06003799 RID: 14233 RVA: 0x0008B38F File Offset: 0x0008958F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtRangeFailWarningNotify()
		{
		}

		// Token: 0x0600379A RID: 14234 RVA: 0x0008B397 File Offset: 0x00089597
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtRangeFailWarningNotify(BtRangeFailWarningNotify other) : this()
		{
			this.treeIncId_ = other.treeIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600379B RID: 14235 RVA: 0x0008B3BC File Offset: 0x000895BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtRangeFailWarningNotify Clone()
		{
			return new BtRangeFailWarningNotify(this);
		}

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x0600379C RID: 14236 RVA: 0x0008B3C4 File Offset: 0x000895C4
		// (set) Token: 0x0600379D RID: 14237 RVA: 0x0008B3CC File Offset: 0x000895CC
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

		// Token: 0x0600379E RID: 14238 RVA: 0x0008B3D5 File Offset: 0x000895D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BtRangeFailWarningNotify);
		}

		// Token: 0x0600379F RID: 14239 RVA: 0x0008B3E3 File Offset: 0x000895E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BtRangeFailWarningNotify other)
		{
			return other != null && (other == this || (this.TreeIncId == other.TreeIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060037A0 RID: 14240 RVA: 0x0008B414 File Offset: 0x00089614
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

		// Token: 0x060037A1 RID: 14241 RVA: 0x0008B453 File Offset: 0x00089653
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060037A2 RID: 14242 RVA: 0x0008B460 File Offset: 0x00089660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060037A3 RID: 14243 RVA: 0x0008B469 File Offset: 0x00089669
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.TreeIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060037A4 RID: 14244 RVA: 0x0008B49C File Offset: 0x0008969C
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

		// Token: 0x060037A5 RID: 14245 RVA: 0x0008B4DA File Offset: 0x000896DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BtRangeFailWarningNotify other)
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

		// Token: 0x060037A6 RID: 14246 RVA: 0x0008B50B File Offset: 0x0008970B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060037A7 RID: 14247 RVA: 0x0008B514 File Offset: 0x00089714
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TreeIncId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04002B40 RID: 11072
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B41 RID: 11073
		public const int TreeIncIdFieldNumber = 14;

		// Token: 0x04002B42 RID: 11074
		private long treeIncId_;
	}
}
