using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200119E RID: 4510
	public sealed class SceneItemEventListenerComponentPb : IMessage<SceneItemEventListenerComponentPb>, IMessage, IEquatable<SceneItemEventListenerComponentPb>, IDeepCloneable<SceneItemEventListenerComponentPb>, IBufferMessage
	{
		// Token: 0x06018178 RID: 98680 RVA: 0x0038223B File Offset: 0x0038043B
		[NullableContext(1)]
		public static SceneItemEventListenerComponentPb Create()
		{
			return new SceneItemEventListenerComponentPb();
		}

		// Token: 0x1700512E RID: 20782
		// (get) Token: 0x06018179 RID: 98681 RVA: 0x00382242 File Offset: 0x00380442
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700512F RID: 20783
		// (get) Token: 0x0601817A RID: 98682 RVA: 0x00382245 File Offset: 0x00380445
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemEventListenerComponentPb.Descriptor;
			}
		}

		// Token: 0x0601817B RID: 98683 RVA: 0x0038224C File Offset: 0x0038044C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemEventListenerComponentPb()
		{
		}

		// Token: 0x0601817C RID: 98684 RVA: 0x00382254 File Offset: 0x00380454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemEventListenerComponentPb(SceneItemEventListenerComponentPb other) : this()
		{
			this.contextId_ = other.contextId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601817D RID: 98685 RVA: 0x00382279 File Offset: 0x00380479
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemEventListenerComponentPb Clone()
		{
			return new SceneItemEventListenerComponentPb(this);
		}

		// Token: 0x17005130 RID: 20784
		// (get) Token: 0x0601817E RID: 98686 RVA: 0x00382281 File Offset: 0x00380481
		// (set) Token: 0x0601817F RID: 98687 RVA: 0x00382289 File Offset: 0x00380489
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

		// Token: 0x06018180 RID: 98688 RVA: 0x00382292 File Offset: 0x00380492
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemEventListenerComponentPb);
		}

		// Token: 0x06018181 RID: 98689 RVA: 0x003822A0 File Offset: 0x003804A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemEventListenerComponentPb other)
		{
			return other != null && (other == this || (this.ContextId == other.ContextId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018182 RID: 98690 RVA: 0x003822D0 File Offset: 0x003804D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x06018183 RID: 98691 RVA: 0x0038230F File Offset: 0x0038050F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018184 RID: 98692 RVA: 0x0038231C File Offset: 0x0038051C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018185 RID: 98693 RVA: 0x00382325 File Offset: 0x00380525
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ContextId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.ContextId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018186 RID: 98694 RVA: 0x00382358 File Offset: 0x00380558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x06018187 RID: 98695 RVA: 0x00382396 File Offset: 0x00380596
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemEventListenerComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ContextId != 0L)
			{
				this.ContextId = other.ContextId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018188 RID: 98696 RVA: 0x003823C7 File Offset: 0x003805C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018189 RID: 98697 RVA: 0x003823D0 File Offset: 0x003805D0
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ContextId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04008F80 RID: 36736
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008F81 RID: 36737
		public const int ContextIdFieldNumber = 1;

		// Token: 0x04008F82 RID: 36738
		private long contextId_;
	}
}
