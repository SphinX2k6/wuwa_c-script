using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001471 RID: 5233
	[NetMessage(EMessageId.TurntableCompleteResponse)]
	public sealed class TurntableCompleteResponse : IMessage<TurntableCompleteResponse>, IMessage, IEquatable<TurntableCompleteResponse>, IDeepCloneable<TurntableCompleteResponse>, IBufferMessage
	{
		// Token: 0x0601BB40 RID: 113472 RVA: 0x0040257D File Offset: 0x0040077D
		[NullableContext(1)]
		public static TurntableCompleteResponse Create()
		{
			return new TurntableCompleteResponse();
		}

		// Token: 0x17005D6C RID: 23916
		// (get) Token: 0x0601BB41 RID: 113473 RVA: 0x00402584 File Offset: 0x00400784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D6D RID: 23917
		// (get) Token: 0x0601BB42 RID: 113474 RVA: 0x00402587 File Offset: 0x00400787
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TurntableCompleteResponse.Descriptor;
			}
		}

		// Token: 0x0601BB43 RID: 113475 RVA: 0x0040258E File Offset: 0x0040078E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TurntableCompleteResponse()
		{
		}

		// Token: 0x0601BB44 RID: 113476 RVA: 0x00402596 File Offset: 0x00400796
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TurntableCompleteResponse(TurntableCompleteResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BB45 RID: 113477 RVA: 0x004025C7 File Offset: 0x004007C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TurntableCompleteResponse Clone()
		{
			return new TurntableCompleteResponse(this);
		}

		// Token: 0x17005D6E RID: 23918
		// (get) Token: 0x0601BB46 RID: 113478 RVA: 0x004025CF File Offset: 0x004007CF
		// (set) Token: 0x0601BB47 RID: 113479 RVA: 0x004025D7 File Offset: 0x004007D7
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

		// Token: 0x17005D6F RID: 23919
		// (get) Token: 0x0601BB48 RID: 113480 RVA: 0x004025E0 File Offset: 0x004007E0
		// (set) Token: 0x0601BB49 RID: 113481 RVA: 0x004025E8 File Offset: 0x004007E8
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

		// Token: 0x0601BB4A RID: 113482 RVA: 0x004025F1 File Offset: 0x004007F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TurntableCompleteResponse);
		}

		// Token: 0x0601BB4B RID: 113483 RVA: 0x004025FF File Offset: 0x004007FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TurntableCompleteResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BB4C RID: 113484 RVA: 0x00402640 File Offset: 0x00400840
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

		// Token: 0x0601BB4D RID: 113485 RVA: 0x0040269E File Offset: 0x0040089E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BB4E RID: 113486 RVA: 0x004026AB File Offset: 0x004008AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BB4F RID: 113487 RVA: 0x004026B4 File Offset: 0x004008B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.EntityId);
			}
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BB50 RID: 113488 RVA: 0x00402710 File Offset: 0x00400910
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

		// Token: 0x0601BB51 RID: 113489 RVA: 0x00402768 File Offset: 0x00400968
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

		// Token: 0x0601BB52 RID: 113490 RVA: 0x004027B8 File Offset: 0x004009B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BB53 RID: 113491 RVA: 0x004027C4 File Offset: 0x004009C4
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
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04009F97 RID: 40855
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F98 RID: 40856
		public const int ErrCodeFieldNumber = 14;

		// Token: 0x04009F99 RID: 40857
		private ErrorCode errCode_;

		// Token: 0x04009F9A RID: 40858
		public const int EntityIdFieldNumber = 5;

		// Token: 0x04009F9B RID: 40859
		private long entityId_;
	}
}
