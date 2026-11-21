using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200057D RID: 1405
	[NetMessage(EMessageId.FixToolResponse)]
	public sealed class FixToolResponse : IMessage<FixToolResponse>, IMessage, IEquatable<FixToolResponse>, IDeepCloneable<FixToolResponse>, IBufferMessage
	{
		// Token: 0x060082B6 RID: 33462 RVA: 0x0013B250 File Offset: 0x00139450
		[NullableContext(1)]
		public static FixToolResponse Create()
		{
			return new FixToolResponse();
		}

		// Token: 0x1700196F RID: 6511
		// (get) Token: 0x060082B7 RID: 33463 RVA: 0x0013B257 File Offset: 0x00139457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001970 RID: 6512
		// (get) Token: 0x060082B8 RID: 33464 RVA: 0x0013B25A File Offset: 0x0013945A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FixToolResponse.Descriptor;
			}
		}

		// Token: 0x060082B9 RID: 33465 RVA: 0x0013B261 File Offset: 0x00139461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FixToolResponse()
		{
		}

		// Token: 0x060082BA RID: 33466 RVA: 0x0013B269 File Offset: 0x00139469
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FixToolResponse(FixToolResponse other) : this()
		{
			this.code_ = other.code_;
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060082BB RID: 33467 RVA: 0x0013B29A File Offset: 0x0013949A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FixToolResponse Clone()
		{
			return new FixToolResponse(this);
		}

		// Token: 0x17001971 RID: 6513
		// (get) Token: 0x060082BC RID: 33468 RVA: 0x0013B2A2 File Offset: 0x001394A2
		// (set) Token: 0x060082BD RID: 33469 RVA: 0x0013B2AA File Offset: 0x001394AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x17001972 RID: 6514
		// (get) Token: 0x060082BE RID: 33470 RVA: 0x0013B2B3 File Offset: 0x001394B3
		// (set) Token: 0x060082BF RID: 33471 RVA: 0x0013B2BB File Offset: 0x001394BB
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

		// Token: 0x060082C0 RID: 33472 RVA: 0x0013B2C4 File Offset: 0x001394C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FixToolResponse);
		}

		// Token: 0x060082C1 RID: 33473 RVA: 0x0013B2D2 File Offset: 0x001394D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FixToolResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060082C2 RID: 33474 RVA: 0x0013B310 File Offset: 0x00139510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
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

		// Token: 0x060082C3 RID: 33475 RVA: 0x0013B36E File Offset: 0x0013956E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060082C4 RID: 33476 RVA: 0x0013B37B File Offset: 0x0013957B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060082C5 RID: 33477 RVA: 0x0013B384 File Offset: 0x00139584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.Code);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060082C6 RID: 33478 RVA: 0x0013B3E0 File Offset: 0x001395E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
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

		// Token: 0x060082C7 RID: 33479 RVA: 0x0013B438 File Offset: 0x00139638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FixToolResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060082C8 RID: 33480 RVA: 0x0013B488 File Offset: 0x00139688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060082C9 RID: 33481 RVA: 0x0013B494 File Offset: 0x00139694
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
				if (num != 72U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004192 RID: 16786
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004193 RID: 16787
		public const int CodeFieldNumber = 9;

		// Token: 0x04004194 RID: 16788
		private ErrorCode code_;

		// Token: 0x04004195 RID: 16789
		public const int EntityIdFieldNumber = 15;

		// Token: 0x04004196 RID: 16790
		private long entityId_;
	}
}
