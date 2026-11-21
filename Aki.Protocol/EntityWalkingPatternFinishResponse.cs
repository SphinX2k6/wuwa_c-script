using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004B7 RID: 1207
	[NetMessage(EMessageId.EntityWalkingPatternFinishResponse)]
	public sealed class EntityWalkingPatternFinishResponse : IMessage<EntityWalkingPatternFinishResponse>, IMessage, IEquatable<EntityWalkingPatternFinishResponse>, IDeepCloneable<EntityWalkingPatternFinishResponse>, IBufferMessage
	{
		// Token: 0x06007354 RID: 29524 RVA: 0x0011B5BF File Offset: 0x001197BF
		[NullableContext(1)]
		public static EntityWalkingPatternFinishResponse Create()
		{
			return new EntityWalkingPatternFinishResponse();
		}

		// Token: 0x17001654 RID: 5716
		// (get) Token: 0x06007355 RID: 29525 RVA: 0x0011B5C6 File Offset: 0x001197C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001655 RID: 5717
		// (get) Token: 0x06007356 RID: 29526 RVA: 0x0011B5C9 File Offset: 0x001197C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityWalkingPatternFinishResponse.Descriptor;
			}
		}

		// Token: 0x06007357 RID: 29527 RVA: 0x0011B5D0 File Offset: 0x001197D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityWalkingPatternFinishResponse()
		{
		}

		// Token: 0x06007358 RID: 29528 RVA: 0x0011B5D8 File Offset: 0x001197D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityWalkingPatternFinishResponse(EntityWalkingPatternFinishResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007359 RID: 29529 RVA: 0x0011B5FD File Offset: 0x001197FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityWalkingPatternFinishResponse Clone()
		{
			return new EntityWalkingPatternFinishResponse(this);
		}

		// Token: 0x17001656 RID: 5718
		// (get) Token: 0x0600735A RID: 29530 RVA: 0x0011B605 File Offset: 0x00119805
		// (set) Token: 0x0600735B RID: 29531 RVA: 0x0011B60D File Offset: 0x0011980D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x0600735C RID: 29532 RVA: 0x0011B616 File Offset: 0x00119816
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityWalkingPatternFinishResponse);
		}

		// Token: 0x0600735D RID: 29533 RVA: 0x0011B624 File Offset: 0x00119824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityWalkingPatternFinishResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600735E RID: 29534 RVA: 0x0011B654 File Offset: 0x00119854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600735F RID: 29535 RVA: 0x0011B699 File Offset: 0x00119899
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007360 RID: 29536 RVA: 0x0011B6A6 File Offset: 0x001198A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007361 RID: 29537 RVA: 0x0011B6AF File Offset: 0x001198AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007362 RID: 29538 RVA: 0x0011B6E4 File Offset: 0x001198E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007363 RID: 29539 RVA: 0x0011B722 File Offset: 0x00119922
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityWalkingPatternFinishResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007364 RID: 29540 RVA: 0x0011B753 File Offset: 0x00119953
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007365 RID: 29541 RVA: 0x0011B75C File Offset: 0x0011995C
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003D7B RID: 15739
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D7C RID: 15740
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04003D7D RID: 15741
		private ErrorCode errorCode_;
	}
}
