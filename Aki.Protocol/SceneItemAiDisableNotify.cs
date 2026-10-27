using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200115B RID: 4443
	[NetMessage(EMessageId.SceneItemAiDisableNotify)]
	public sealed class SceneItemAiDisableNotify : IMessage<SceneItemAiDisableNotify>, IMessage, IEquatable<SceneItemAiDisableNotify>, IDeepCloneable<SceneItemAiDisableNotify>, IBufferMessage
	{
		// Token: 0x06017B03 RID: 97027 RVA: 0x00370D8A File Offset: 0x0036EF8A
		[NullableContext(1)]
		public static SceneItemAiDisableNotify Create()
		{
			return new SceneItemAiDisableNotify();
		}

		// Token: 0x17004F8E RID: 20366
		// (get) Token: 0x06017B04 RID: 97028 RVA: 0x00370D91 File Offset: 0x0036EF91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F8F RID: 20367
		// (get) Token: 0x06017B05 RID: 97029 RVA: 0x00370D94 File Offset: 0x0036EF94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemAiDisableNotify.Descriptor;
			}
		}

		// Token: 0x06017B06 RID: 97030 RVA: 0x00370D9B File Offset: 0x0036EF9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAiDisableNotify()
		{
		}

		// Token: 0x06017B07 RID: 97031 RVA: 0x00370DA3 File Offset: 0x0036EFA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAiDisableNotify(SceneItemAiDisableNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017B08 RID: 97032 RVA: 0x00370DC8 File Offset: 0x0036EFC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAiDisableNotify Clone()
		{
			return new SceneItemAiDisableNotify(this);
		}

		// Token: 0x17004F90 RID: 20368
		// (get) Token: 0x06017B09 RID: 97033 RVA: 0x00370DD0 File Offset: 0x0036EFD0
		// (set) Token: 0x06017B0A RID: 97034 RVA: 0x00370DD8 File Offset: 0x0036EFD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
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

		// Token: 0x06017B0B RID: 97035 RVA: 0x00370DE1 File Offset: 0x0036EFE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemAiDisableNotify);
		}

		// Token: 0x06017B0C RID: 97036 RVA: 0x00370DEF File Offset: 0x0036EFEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemAiDisableNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017B0D RID: 97037 RVA: 0x00370E20 File Offset: 0x0036F020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017B0E RID: 97038 RVA: 0x00370E5F File Offset: 0x0036F05F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017B0F RID: 97039 RVA: 0x00370E6C File Offset: 0x0036F06C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017B10 RID: 97040 RVA: 0x00370E75 File Offset: 0x0036F075
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017B11 RID: 97041 RVA: 0x00370EA8 File Offset: 0x0036F0A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017B12 RID: 97042 RVA: 0x00370EE6 File Offset: 0x0036F0E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemAiDisableNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017B13 RID: 97043 RVA: 0x00370F17 File Offset: 0x0036F117
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017B14 RID: 97044 RVA: 0x00370F20 File Offset: 0x0036F120
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04008CB3 RID: 36019
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008CB4 RID: 36020
		public const int EntityIdFieldNumber = 13;

		// Token: 0x04008CB5 RID: 36021
		private long entityId_;
	}
}
