using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D7D RID: 3453
	[NetMessage(EMessageId.PlayerAccessRangeResponse)]
	public sealed class PlayerAccessRangeResponse : IMessage<PlayerAccessRangeResponse>, IMessage, IEquatable<PlayerAccessRangeResponse>, IDeepCloneable<PlayerAccessRangeResponse>, IBufferMessage
	{
		// Token: 0x060129CE RID: 76238 RVA: 0x002B706C File Offset: 0x002B526C
		[NullableContext(1)]
		public static PlayerAccessRangeResponse Create()
		{
			return new PlayerAccessRangeResponse();
		}

		// Token: 0x17003DB4 RID: 15796
		// (get) Token: 0x060129CF RID: 76239 RVA: 0x002B7073 File Offset: 0x002B5273
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003DB5 RID: 15797
		// (get) Token: 0x060129D0 RID: 76240 RVA: 0x002B7076 File Offset: 0x002B5276
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerAccessRangeResponse.Descriptor;
			}
		}

		// Token: 0x060129D1 RID: 76241 RVA: 0x002B707D File Offset: 0x002B527D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAccessRangeResponse()
		{
		}

		// Token: 0x060129D2 RID: 76242 RVA: 0x002B7088 File Offset: 0x002B5288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAccessRangeResponse(PlayerAccessRangeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.rangeEntityId_ = other.rangeEntityId_;
			this.accessRangeResult_ = ((other.accessRangeResult_ != null) ? other.accessRangeResult_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060129D3 RID: 76243 RVA: 0x002B70E0 File Offset: 0x002B52E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAccessRangeResponse Clone()
		{
			return new PlayerAccessRangeResponse(this);
		}

		// Token: 0x17003DB6 RID: 15798
		// (get) Token: 0x060129D4 RID: 76244 RVA: 0x002B70E8 File Offset: 0x002B52E8
		// (set) Token: 0x060129D5 RID: 76245 RVA: 0x002B70F0 File Offset: 0x002B52F0
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

		// Token: 0x17003DB7 RID: 15799
		// (get) Token: 0x060129D6 RID: 76246 RVA: 0x002B70F9 File Offset: 0x002B52F9
		// (set) Token: 0x060129D7 RID: 76247 RVA: 0x002B7101 File Offset: 0x002B5301
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long RangeEntityId
		{
			get
			{
				return this.rangeEntityId_;
			}
			set
			{
				this.rangeEntityId_ = value;
			}
		}

		// Token: 0x17003DB8 RID: 15800
		// (get) Token: 0x060129D8 RID: 76248 RVA: 0x002B710A File Offset: 0x002B530A
		// (set) Token: 0x060129D9 RID: 76249 RVA: 0x002B7112 File Offset: 0x002B5312
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccessRangeResultMessage AccessRangeResult
		{
			get
			{
				return this.accessRangeResult_;
			}
			set
			{
				this.accessRangeResult_ = value;
			}
		}

		// Token: 0x060129DA RID: 76250 RVA: 0x002B711B File Offset: 0x002B531B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerAccessRangeResponse);
		}

		// Token: 0x060129DB RID: 76251 RVA: 0x002B712C File Offset: 0x002B532C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerAccessRangeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.RangeEntityId == other.RangeEntityId && object.Equals(this.AccessRangeResult, other.AccessRangeResult) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060129DC RID: 76252 RVA: 0x002B718C File Offset: 0x002B538C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.RangeEntityId != 0L)
			{
				num ^= this.RangeEntityId.GetHashCode();
			}
			if (this.accessRangeResult_ != null)
			{
				num ^= this.AccessRangeResult.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060129DD RID: 76253 RVA: 0x002B7200 File Offset: 0x002B5400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060129DE RID: 76254 RVA: 0x002B720D File Offset: 0x002B540D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060129DF RID: 76255 RVA: 0x002B7218 File Offset: 0x002B5418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RangeEntityId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.RangeEntityId);
			}
			if (this.accessRangeResult_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.AccessRangeResult);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060129E0 RID: 76256 RVA: 0x002B7290 File Offset: 0x002B5490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.RangeEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.RangeEntityId);
			}
			if (this.accessRangeResult_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AccessRangeResult);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060129E1 RID: 76257 RVA: 0x002B7300 File Offset: 0x002B5500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerAccessRangeResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.RangeEntityId != 0L)
			{
				this.RangeEntityId = other.RangeEntityId;
			}
			if (other.accessRangeResult_ != null)
			{
				if (this.accessRangeResult_ == null)
				{
					this.AccessRangeResult = new AccessRangeResultMessage();
				}
				this.AccessRangeResult.MergeFrom(other.AccessRangeResult);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060129E2 RID: 76258 RVA: 0x002B737C File Offset: 0x002B557C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060129E3 RID: 76259 RVA: 0x002B7388 File Offset: 0x002B5588
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
				if (num != 32U)
				{
					if (num != 50U)
					{
						if (num != 112U)
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
						if (this.accessRangeResult_ == null)
						{
							this.AccessRangeResult = new AccessRangeResultMessage();
						}
						input.ReadMessage(this.AccessRangeResult);
					}
				}
				else
				{
					this.RangeEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04007382 RID: 29570
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007383 RID: 29571
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04007384 RID: 29572
		private ErrorCode errorCode_;

		// Token: 0x04007385 RID: 29573
		public const int RangeEntityIdFieldNumber = 4;

		// Token: 0x04007386 RID: 29574
		private long rangeEntityId_;

		// Token: 0x04007387 RID: 29575
		public const int AccessRangeResultFieldNumber = 6;

		// Token: 0x04007388 RID: 29576
		private AccessRangeResultMessage accessRangeResult_;
	}
}
