using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001EC RID: 492
	[NetMessage(EMessageId.BtRangeFailWarningNotify)]
	public sealed class BtRangeFailWarningNotify : IMessage<BtRangeFailWarningNotify>, IMessage, IEquatable<BtRangeFailWarningNotify>, IDeepCloneable<BtRangeFailWarningNotify>, IBufferMessage
	{
		// Token: 0x06003709 RID: 14089 RVA: 0x00089C06 File Offset: 0x00087E06
		[NullableContext(1)]
		public static BtRangeFailWarningNotify Create()
		{
			return new BtRangeFailWarningNotify();
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x0600370A RID: 14090 RVA: 0x00089C0D File Offset: 0x00087E0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x0600370B RID: 14091 RVA: 0x00089C10 File Offset: 0x00087E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BtRangeFailWarningNotify.Descriptor;
			}
		}

		// Token: 0x0600370C RID: 14092 RVA: 0x00089C17 File Offset: 0x00087E17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtRangeFailWarningNotify()
		{
		}

		// Token: 0x0600370D RID: 14093 RVA: 0x00089C1F File Offset: 0x00087E1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtRangeFailWarningNotify(BtRangeFailWarningNotify other) : this()
		{
			this.treeIncId_ = other.treeIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600370E RID: 14094 RVA: 0x00089C44 File Offset: 0x00087E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtRangeFailWarningNotify Clone()
		{
			return new BtRangeFailWarningNotify(this);
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x0600370F RID: 14095 RVA: 0x00089C4C File Offset: 0x00087E4C
		// (set) Token: 0x06003710 RID: 14096 RVA: 0x00089C54 File Offset: 0x00087E54
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

		// Token: 0x06003711 RID: 14097 RVA: 0x00089C5D File Offset: 0x00087E5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BtRangeFailWarningNotify);
		}

		// Token: 0x06003712 RID: 14098 RVA: 0x00089C6B File Offset: 0x00087E6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BtRangeFailWarningNotify other)
		{
			return other != null && (other == this || (this.TreeIncId == other.TreeIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003713 RID: 14099 RVA: 0x00089C9C File Offset: 0x00087E9C
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

		// Token: 0x06003714 RID: 14100 RVA: 0x00089CDB File Offset: 0x00087EDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003715 RID: 14101 RVA: 0x00089CE8 File Offset: 0x00087EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003716 RID: 14102 RVA: 0x00089CF1 File Offset: 0x00087EF1
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

		// Token: 0x06003717 RID: 14103 RVA: 0x00089D24 File Offset: 0x00087F24
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

		// Token: 0x06003718 RID: 14104 RVA: 0x00089D62 File Offset: 0x00087F62
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

		// Token: 0x06003719 RID: 14105 RVA: 0x00089D93 File Offset: 0x00087F93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600371A RID: 14106 RVA: 0x00089D9C File Offset: 0x00087F9C
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

		// Token: 0x04002AC5 RID: 10949
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002AC6 RID: 10950
		public const int TreeIncIdFieldNumber = 14;

		// Token: 0x04002AC7 RID: 10951
		private long treeIncId_;
	}
}
