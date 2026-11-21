using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200031E RID: 798
	[NetMessage(EMessageId.CreatStoryCharacterResponse)]
	public sealed class CreatStoryCharacterResponse : IMessage<CreatStoryCharacterResponse>, IMessage, IEquatable<CreatStoryCharacterResponse>, IDeepCloneable<CreatStoryCharacterResponse>, IBufferMessage
	{
		// Token: 0x0600509E RID: 20638 RVA: 0x000C4DA6 File Offset: 0x000C2FA6
		[NullableContext(1)]
		public static CreatStoryCharacterResponse Create()
		{
			return new CreatStoryCharacterResponse();
		}

		// Token: 0x17000E74 RID: 3700
		// (get) Token: 0x0600509F RID: 20639 RVA: 0x000C4DAD File Offset: 0x000C2FAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E75 RID: 3701
		// (get) Token: 0x060050A0 RID: 20640 RVA: 0x000C4DB0 File Offset: 0x000C2FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreatStoryCharacterResponse.Descriptor;
			}
		}

		// Token: 0x060050A1 RID: 20641 RVA: 0x000C4DB7 File Offset: 0x000C2FB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreatStoryCharacterResponse()
		{
		}

		// Token: 0x060050A2 RID: 20642 RVA: 0x000C4DBF File Offset: 0x000C2FBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreatStoryCharacterResponse(CreatStoryCharacterResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060050A3 RID: 20643 RVA: 0x000C4DF0 File Offset: 0x000C2FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreatStoryCharacterResponse Clone()
		{
			return new CreatStoryCharacterResponse(this);
		}

		// Token: 0x17000E76 RID: 3702
		// (get) Token: 0x060050A4 RID: 20644 RVA: 0x000C4DF8 File Offset: 0x000C2FF8
		// (set) Token: 0x060050A5 RID: 20645 RVA: 0x000C4E00 File Offset: 0x000C3000
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

		// Token: 0x17000E77 RID: 3703
		// (get) Token: 0x060050A6 RID: 20646 RVA: 0x000C4E09 File Offset: 0x000C3009
		// (set) Token: 0x060050A7 RID: 20647 RVA: 0x000C4E11 File Offset: 0x000C3011
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

		// Token: 0x060050A8 RID: 20648 RVA: 0x000C4E1A File Offset: 0x000C301A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreatStoryCharacterResponse);
		}

		// Token: 0x060050A9 RID: 20649 RVA: 0x000C4E28 File Offset: 0x000C3028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CreatStoryCharacterResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060050AA RID: 20650 RVA: 0x000C4E68 File Offset: 0x000C3068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
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

		// Token: 0x060050AB RID: 20651 RVA: 0x000C4EC6 File Offset: 0x000C30C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060050AC RID: 20652 RVA: 0x000C4ED3 File Offset: 0x000C30D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060050AD RID: 20653 RVA: 0x000C4EDC File Offset: 0x000C30DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.EntityId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060050AE RID: 20654 RVA: 0x000C4F38 File Offset: 0x000C3138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
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

		// Token: 0x060050AF RID: 20655 RVA: 0x000C4F90 File Offset: 0x000C3190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CreatStoryCharacterResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060050B0 RID: 20656 RVA: 0x000C4FE0 File Offset: 0x000C31E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060050B1 RID: 20657 RVA: 0x000C4FEC File Offset: 0x000C31EC
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
				if (num != 40U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040032C3 RID: 12995
		private UnknownFieldSet _unknownFields;

		// Token: 0x040032C4 RID: 12996
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x040032C5 RID: 12997
		private ErrorCode errorCode_;

		// Token: 0x040032C6 RID: 12998
		public const int EntityIdFieldNumber = 5;

		// Token: 0x040032C7 RID: 12999
		private long entityId_;
	}
}
