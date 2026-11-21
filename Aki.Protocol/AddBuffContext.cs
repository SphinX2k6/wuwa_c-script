using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200009D RID: 157
	public sealed class AddBuffContext : IMessage<AddBuffContext>, IMessage, IEquatable<AddBuffContext>, IDeepCloneable<AddBuffContext>, IBufferMessage
	{
		// Token: 0x06001C36 RID: 7222 RVA: 0x0004E86D File Offset: 0x0004CA6D
		[NullableContext(1)]
		public static AddBuffContext Create()
		{
			return new AddBuffContext();
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06001C37 RID: 7223 RVA: 0x0004E874 File Offset: 0x0004CA74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06001C38 RID: 7224 RVA: 0x0004E877 File Offset: 0x0004CA77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddBuffContext.Descriptor;
			}
		}

		// Token: 0x06001C39 RID: 7225 RVA: 0x0004E87E File Offset: 0x0004CA7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddBuffContext()
		{
		}

		// Token: 0x06001C3A RID: 7226 RVA: 0x0004E886 File Offset: 0x0004CA86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddBuffContext(AddBuffContext other) : this()
		{
			this.buffHandle_ = other.buffHandle_;
			this.contextId_ = other.contextId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001C3B RID: 7227 RVA: 0x0004E8B7 File Offset: 0x0004CAB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddBuffContext Clone()
		{
			return new AddBuffContext(this);
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06001C3C RID: 7228 RVA: 0x0004E8BF File Offset: 0x0004CABF
		// (set) Token: 0x06001C3D RID: 7229 RVA: 0x0004E8C7 File Offset: 0x0004CAC7
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

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06001C3E RID: 7230 RVA: 0x0004E8D0 File Offset: 0x0004CAD0
		// (set) Token: 0x06001C3F RID: 7231 RVA: 0x0004E8D8 File Offset: 0x0004CAD8
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

		// Token: 0x06001C40 RID: 7232 RVA: 0x0004E8E1 File Offset: 0x0004CAE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddBuffContext);
		}

		// Token: 0x06001C41 RID: 7233 RVA: 0x0004E8EF File Offset: 0x0004CAEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddBuffContext other)
		{
			return other != null && (other == this || (this.BuffHandle == other.BuffHandle && this.ContextId == other.ContextId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001C42 RID: 7234 RVA: 0x0004E930 File Offset: 0x0004CB30
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

		// Token: 0x06001C43 RID: 7235 RVA: 0x0004E988 File Offset: 0x0004CB88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001C44 RID: 7236 RVA: 0x0004E995 File Offset: 0x0004CB95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001C45 RID: 7237 RVA: 0x0004E9A0 File Offset: 0x0004CBA0
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

		// Token: 0x06001C46 RID: 7238 RVA: 0x0004E9F8 File Offset: 0x0004CBF8
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

		// Token: 0x06001C47 RID: 7239 RVA: 0x0004EA50 File Offset: 0x0004CC50
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

		// Token: 0x06001C48 RID: 7240 RVA: 0x0004EAA0 File Offset: 0x0004CCA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001C49 RID: 7241 RVA: 0x0004EAAC File Offset: 0x0004CCAC
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

		// Token: 0x0400231C RID: 8988
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400231D RID: 8989
		public const int BuffHandleFieldNumber = 1;

		// Token: 0x0400231E RID: 8990
		private int buffHandle_;

		// Token: 0x0400231F RID: 8991
		public const int ContextIdFieldNumber = 2;

		// Token: 0x04002320 RID: 8992
		private long contextId_;
	}
}
