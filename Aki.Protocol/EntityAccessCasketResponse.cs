using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200045F RID: 1119
	[NetMessage(EMessageId.EntityAccessCasketResponse)]
	public sealed class EntityAccessCasketResponse : IMessage<EntityAccessCasketResponse>, IMessage, IEquatable<EntityAccessCasketResponse>, IDeepCloneable<EntityAccessCasketResponse>, IBufferMessage
	{
		// Token: 0x06006ADC RID: 27356 RVA: 0x00101C65 File Offset: 0x000FFE65
		[NullableContext(1)]
		public static EntityAccessCasketResponse Create()
		{
			return new EntityAccessCasketResponse();
		}

		// Token: 0x1700143B RID: 5179
		// (get) Token: 0x06006ADD RID: 27357 RVA: 0x00101C6C File Offset: 0x000FFE6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700143C RID: 5180
		// (get) Token: 0x06006ADE RID: 27358 RVA: 0x00101C6F File Offset: 0x000FFE6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityAccessCasketResponse.Descriptor;
			}
		}

		// Token: 0x06006ADF RID: 27359 RVA: 0x00101C76 File Offset: 0x000FFE76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAccessCasketResponse()
		{
		}

		// Token: 0x06006AE0 RID: 27360 RVA: 0x00101C7E File Offset: 0x000FFE7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAccessCasketResponse(EntityAccessCasketResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.casketEntityIncId_ = other.casketEntityIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006AE1 RID: 27361 RVA: 0x00101CAF File Offset: 0x000FFEAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAccessCasketResponse Clone()
		{
			return new EntityAccessCasketResponse(this);
		}

		// Token: 0x1700143D RID: 5181
		// (get) Token: 0x06006AE2 RID: 27362 RVA: 0x00101CB7 File Offset: 0x000FFEB7
		// (set) Token: 0x06006AE3 RID: 27363 RVA: 0x00101CBF File Offset: 0x000FFEBF
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

		// Token: 0x1700143E RID: 5182
		// (get) Token: 0x06006AE4 RID: 27364 RVA: 0x00101CC8 File Offset: 0x000FFEC8
		// (set) Token: 0x06006AE5 RID: 27365 RVA: 0x00101CD0 File Offset: 0x000FFED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CasketEntityIncId
		{
			get
			{
				return this.casketEntityIncId_;
			}
			set
			{
				this.casketEntityIncId_ = value;
			}
		}

		// Token: 0x06006AE6 RID: 27366 RVA: 0x00101CD9 File Offset: 0x000FFED9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityAccessCasketResponse);
		}

		// Token: 0x06006AE7 RID: 27367 RVA: 0x00101CE7 File Offset: 0x000FFEE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityAccessCasketResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.CasketEntityIncId == other.CasketEntityIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006AE8 RID: 27368 RVA: 0x00101D28 File Offset: 0x000FFF28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.CasketEntityIncId != 0L)
			{
				num ^= this.CasketEntityIncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006AE9 RID: 27369 RVA: 0x00101D86 File Offset: 0x000FFF86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006AEA RID: 27370 RVA: 0x00101D93 File Offset: 0x000FFF93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006AEB RID: 27371 RVA: 0x00101D9C File Offset: 0x000FFF9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.CasketEntityIncId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.CasketEntityIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006AEC RID: 27372 RVA: 0x00101DF8 File Offset: 0x000FFFF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.CasketEntityIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CasketEntityIncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006AED RID: 27373 RVA: 0x00101E50 File Offset: 0x00100050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityAccessCasketResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.CasketEntityIncId != 0L)
			{
				this.CasketEntityIncId = other.CasketEntityIncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006AEE RID: 27374 RVA: 0x00101EA0 File Offset: 0x001000A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006AEF RID: 27375 RVA: 0x00101EAC File Offset: 0x001000AC
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
				if (num != 48U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CasketEntityIncId = input.ReadInt64();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003A64 RID: 14948
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A65 RID: 14949
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04003A66 RID: 14950
		private ErrorCode errorCode_;

		// Token: 0x04003A67 RID: 14951
		public const int CasketEntityIncIdFieldNumber = 7;

		// Token: 0x04003A68 RID: 14952
		private long casketEntityIncId_;
	}
}
