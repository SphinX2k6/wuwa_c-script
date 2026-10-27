using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200009C RID: 156
	public sealed class AddBuffContext : IMessage<AddBuffContext>, IMessage, IEquatable<AddBuffContext>, IDeepCloneable<AddBuffContext>, IBufferMessage
	{
		// Token: 0x06001BEF RID: 7151 RVA: 0x0004DC5D File Offset: 0x0004BE5D
		[NullableContext(1)]
		public static AddBuffContext Create()
		{
			return new AddBuffContext();
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06001BF0 RID: 7152 RVA: 0x0004DC64 File Offset: 0x0004BE64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06001BF1 RID: 7153 RVA: 0x0004DC67 File Offset: 0x0004BE67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddBuffContext.Descriptor;
			}
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x0004DC6E File Offset: 0x0004BE6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddBuffContext()
		{
		}

		// Token: 0x06001BF3 RID: 7155 RVA: 0x0004DC76 File Offset: 0x0004BE76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddBuffContext(AddBuffContext other) : this()
		{
			this.buffHandle_ = other.buffHandle_;
			this.contextId_ = other.contextId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001BF4 RID: 7156 RVA: 0x0004DCA7 File Offset: 0x0004BEA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddBuffContext Clone()
		{
			return new AddBuffContext(this);
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06001BF5 RID: 7157 RVA: 0x0004DCAF File Offset: 0x0004BEAF
		// (set) Token: 0x06001BF6 RID: 7158 RVA: 0x0004DCB7 File Offset: 0x0004BEB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BuffHandle
		{
			get
			{
				return this.buffHandle_;
			}
			set
			{
				this.buffHandle_ = value;
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06001BF7 RID: 7159 RVA: 0x0004DCC0 File Offset: 0x0004BEC0
		// (set) Token: 0x06001BF8 RID: 7160 RVA: 0x0004DCC8 File Offset: 0x0004BEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ContextId
		{
			get
			{
				return this.contextId_;
			}
			set
			{
				this.contextId_ = value;
			}
		}

		// Token: 0x06001BF9 RID: 7161 RVA: 0x0004DCD1 File Offset: 0x0004BED1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddBuffContext);
		}

		// Token: 0x06001BFA RID: 7162 RVA: 0x0004DCDF File Offset: 0x0004BEDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddBuffContext other)
		{
			return other != null && (other == this || (this.BuffHandle == other.BuffHandle && this.ContextId == other.ContextId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001BFB RID: 7163 RVA: 0x0004DD20 File Offset: 0x0004BF20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BuffHandle != 0)
			{
				num ^= this.BuffHandle.GetHashCode();
			}
			if (this.ContextId != 0L)
			{
				num ^= this.ContextId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001BFC RID: 7164 RVA: 0x0004DD78 File Offset: 0x0004BF78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x0004DD85 File Offset: 0x0004BF85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001BFE RID: 7166 RVA: 0x0004DD90 File Offset: 0x0004BF90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuffHandle != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BuffHandle);
			}
			if (this.ContextId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.ContextId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001BFF RID: 7167 RVA: 0x0004DDE8 File Offset: 0x0004BFE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BuffHandle != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BuffHandle);
			}
			if (this.ContextId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ContextId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001C00 RID: 7168 RVA: 0x0004DE40 File Offset: 0x0004C040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AddBuffContext other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BuffHandle != 0)
			{
				this.BuffHandle = other.BuffHandle;
			}
			if (other.ContextId != 0L)
			{
				this.ContextId = other.ContextId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x0004DE90 File Offset: 0x0004C090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001C02 RID: 7170 RVA: 0x0004DE9C File Offset: 0x0004C09C
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ContextId = input.ReadInt64();
					}
				}
				else
				{
					this.BuffHandle = input.ReadInt32();
				}
			}
		}

		// Token: 0x040022BB RID: 8891
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022BC RID: 8892
		public const int BuffHandleFieldNumber = 1;

		// Token: 0x040022BD RID: 8893
		private int buffHandle_;

		// Token: 0x040022BE RID: 8894
		public const int ContextIdFieldNumber = 2;

		// Token: 0x040022BF RID: 8895
		private long contextId_;
	}
}
