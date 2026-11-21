using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014E4 RID: 5348
	[NetMessage(EMessageId.TurntableCompleteResponse)]
	public sealed class TurntableCompleteResponse : IMessage<TurntableCompleteResponse>, IMessage, IEquatable<TurntableCompleteResponse>, IDeepCloneable<TurntableCompleteResponse>, IBufferMessage
	{
		// Token: 0x0601C5CB RID: 116171 RVA: 0x0041D845 File Offset: 0x0041BA45
		[NullableContext(1)]
		public static TurntableCompleteResponse Create()
		{
			return new TurntableCompleteResponse();
		}

		// Token: 0x17006001 RID: 24577
		// (get) Token: 0x0601C5CC RID: 116172 RVA: 0x0041D84C File Offset: 0x0041BA4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006002 RID: 24578
		// (get) Token: 0x0601C5CD RID: 116173 RVA: 0x0041D84F File Offset: 0x0041BA4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TurntableCompleteResponse.Descriptor;
			}
		}

		// Token: 0x0601C5CE RID: 116174 RVA: 0x0041D856 File Offset: 0x0041BA56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TurntableCompleteResponse()
		{
		}

		// Token: 0x0601C5CF RID: 116175 RVA: 0x0041D85E File Offset: 0x0041BA5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TurntableCompleteResponse(TurntableCompleteResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C5D0 RID: 116176 RVA: 0x0041D88F File Offset: 0x0041BA8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TurntableCompleteResponse Clone()
		{
			return new TurntableCompleteResponse(this);
		}

		// Token: 0x17006003 RID: 24579
		// (get) Token: 0x0601C5D1 RID: 116177 RVA: 0x0041D897 File Offset: 0x0041BA97
		// (set) Token: 0x0601C5D2 RID: 116178 RVA: 0x0041D89F File Offset: 0x0041BA9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x17006004 RID: 24580
		// (get) Token: 0x0601C5D3 RID: 116179 RVA: 0x0041D8A8 File Offset: 0x0041BAA8
		// (set) Token: 0x0601C5D4 RID: 116180 RVA: 0x0041D8B0 File Offset: 0x0041BAB0
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

		// Token: 0x0601C5D5 RID: 116181 RVA: 0x0041D8B9 File Offset: 0x0041BAB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TurntableCompleteResponse);
		}

		// Token: 0x0601C5D6 RID: 116182 RVA: 0x0041D8C7 File Offset: 0x0041BAC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TurntableCompleteResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C5D7 RID: 116183 RVA: 0x0041D908 File Offset: 0x0041BB08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
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

		// Token: 0x0601C5D8 RID: 116184 RVA: 0x0041D966 File Offset: 0x0041BB66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C5D9 RID: 116185 RVA: 0x0041D973 File Offset: 0x0041BB73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C5DA RID: 116186 RVA: 0x0041D97C File Offset: 0x0041BB7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrCode);
			}
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

		// Token: 0x0601C5DB RID: 116187 RVA: 0x0041D9D8 File Offset: 0x0041BBD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
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

		// Token: 0x0601C5DC RID: 116188 RVA: 0x0041DA30 File Offset: 0x0041BC30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TurntableCompleteResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C5DD RID: 116189 RVA: 0x0041DA80 File Offset: 0x0041BC80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C5DE RID: 116190 RVA: 0x0041DA8C File Offset: 0x0041BC8C
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
				if (num != 96U)
				{
					if (num != 104U)
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
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A3DE RID: 41950
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A3DF RID: 41951
		public const int ErrCodeFieldNumber = 12;

		// Token: 0x0400A3E0 RID: 41952
		private ErrorCode errCode_;

		// Token: 0x0400A3E1 RID: 41953
		public const int EntityIdFieldNumber = 13;

		// Token: 0x0400A3E2 RID: 41954
		private long entityId_;
	}
}
