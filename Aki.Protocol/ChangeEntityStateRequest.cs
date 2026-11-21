using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000251 RID: 593
	[NetMessage(EMessageId.ChangeEntityStateRequest)]
	public sealed class ChangeEntityStateRequest : IMessage<ChangeEntityStateRequest>, IMessage, IEquatable<ChangeEntityStateRequest>, IDeepCloneable<ChangeEntityStateRequest>, IBufferMessage
	{
		// Token: 0x06003F76 RID: 16246 RVA: 0x0009CA0F File Offset: 0x0009AC0F
		[NullableContext(1)]
		public static ChangeEntityStateRequest Create()
		{
			return new ChangeEntityStateRequest();
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x06003F77 RID: 16247 RVA: 0x0009CA16 File Offset: 0x0009AC16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x06003F78 RID: 16248 RVA: 0x0009CA19 File Offset: 0x0009AC19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeEntityStateRequest.Descriptor;
			}
		}

		// Token: 0x06003F79 RID: 16249 RVA: 0x0009CA20 File Offset: 0x0009AC20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeEntityStateRequest()
		{
		}

		// Token: 0x06003F7A RID: 16250 RVA: 0x0009CA28 File Offset: 0x0009AC28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeEntityStateRequest(ChangeEntityStateRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.stateTagId_ = other.stateTagId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003F7B RID: 16251 RVA: 0x0009CA59 File Offset: 0x0009AC59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeEntityStateRequest Clone()
		{
			return new ChangeEntityStateRequest(this);
		}

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x06003F7C RID: 16252 RVA: 0x0009CA61 File Offset: 0x0009AC61
		// (set) Token: 0x06003F7D RID: 16253 RVA: 0x0009CA69 File Offset: 0x0009AC69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x06003F7E RID: 16254 RVA: 0x0009CA72 File Offset: 0x0009AC72
		// (set) Token: 0x06003F7F RID: 16255 RVA: 0x0009CA7A File Offset: 0x0009AC7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StateTagId
		{
			get
			{
				return this.stateTagId_;
			}
			set
			{
				this.stateTagId_ = value;
			}
		}

		// Token: 0x06003F80 RID: 16256 RVA: 0x0009CA83 File Offset: 0x0009AC83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeEntityStateRequest);
		}

		// Token: 0x06003F81 RID: 16257 RVA: 0x0009CA91 File Offset: 0x0009AC91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeEntityStateRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.StateTagId == other.StateTagId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003F82 RID: 16258 RVA: 0x0009CAD0 File Offset: 0x0009ACD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.StateTagId != 0)
			{
				num ^= this.StateTagId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003F83 RID: 16259 RVA: 0x0009CB28 File Offset: 0x0009AD28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003F84 RID: 16260 RVA: 0x0009CB35 File Offset: 0x0009AD35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003F85 RID: 16261 RVA: 0x0009CB40 File Offset: 0x0009AD40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StateTagId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.StateTagId);
			}
			if (this.EntityId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003F86 RID: 16262 RVA: 0x0009CB9C File Offset: 0x0009AD9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityId);
			}
			if (this.StateTagId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StateTagId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003F87 RID: 16263 RVA: 0x0009CBF4 File Offset: 0x0009ADF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeEntityStateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0)
			{
				this.EntityId = other.EntityId;
			}
			if (other.StateTagId != 0)
			{
				this.StateTagId = other.StateTagId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003F88 RID: 16264 RVA: 0x0009CC44 File Offset: 0x0009AE44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003F89 RID: 16265 RVA: 0x0009CC50 File Offset: 0x0009AE50
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
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityId = input.ReadInt32();
					}
				}
				else
				{
					this.StateTagId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002D7C RID: 11644
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D7D RID: 11645
		public const int EntityIdFieldNumber = 15;

		// Token: 0x04002D7E RID: 11646
		private int entityId_;

		// Token: 0x04002D7F RID: 11647
		public const int StateTagIdFieldNumber = 10;

		// Token: 0x04002D80 RID: 11648
		private int stateTagId_;
	}
}
