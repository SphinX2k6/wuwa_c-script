using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D6D RID: 3437
	[NetMessage(EMessageId.PlayerAccessRangeResponse)]
	public sealed class PlayerAccessRangeResponse : IMessage<PlayerAccessRangeResponse>, IMessage, IEquatable<PlayerAccessRangeResponse>, IDeepCloneable<PlayerAccessRangeResponse>, IBufferMessage
	{
		// Token: 0x060128D2 RID: 75986 RVA: 0x002B544C File Offset: 0x002B364C
		[NullableContext(1)]
		public static PlayerAccessRangeResponse Create()
		{
			return new PlayerAccessRangeResponse();
		}

		// Token: 0x17003D7F RID: 15743
		// (get) Token: 0x060128D3 RID: 75987 RVA: 0x002B5453 File Offset: 0x002B3653
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D80 RID: 15744
		// (get) Token: 0x060128D4 RID: 75988 RVA: 0x002B5456 File Offset: 0x002B3656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerAccessRangeResponse.Descriptor;
			}
		}

		// Token: 0x060128D5 RID: 75989 RVA: 0x002B545D File Offset: 0x002B365D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAccessRangeResponse()
		{
		}

		// Token: 0x060128D6 RID: 75990 RVA: 0x002B5468 File Offset: 0x002B3668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAccessRangeResponse(PlayerAccessRangeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.rangeEntityId_ = other.rangeEntityId_;
			this.accessRangeResult_ = ((other.accessRangeResult_ != null) ? other.accessRangeResult_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060128D7 RID: 75991 RVA: 0x002B54C0 File Offset: 0x002B36C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAccessRangeResponse Clone()
		{
			return new PlayerAccessRangeResponse(this);
		}

		// Token: 0x17003D81 RID: 15745
		// (get) Token: 0x060128D8 RID: 75992 RVA: 0x002B54C8 File Offset: 0x002B36C8
		// (set) Token: 0x060128D9 RID: 75993 RVA: 0x002B54D0 File Offset: 0x002B36D0
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

		// Token: 0x17003D82 RID: 15746
		// (get) Token: 0x060128DA RID: 75994 RVA: 0x002B54D9 File Offset: 0x002B36D9
		// (set) Token: 0x060128DB RID: 75995 RVA: 0x002B54E1 File Offset: 0x002B36E1
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

		// Token: 0x17003D83 RID: 15747
		// (get) Token: 0x060128DC RID: 75996 RVA: 0x002B54EA File Offset: 0x002B36EA
		// (set) Token: 0x060128DD RID: 75997 RVA: 0x002B54F2 File Offset: 0x002B36F2
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

		// Token: 0x060128DE RID: 75998 RVA: 0x002B54FB File Offset: 0x002B36FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerAccessRangeResponse);
		}

		// Token: 0x060128DF RID: 75999 RVA: 0x002B550C File Offset: 0x002B370C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerAccessRangeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.RangeEntityId == other.RangeEntityId && object.Equals(this.AccessRangeResult, other.AccessRangeResult) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060128E0 RID: 76000 RVA: 0x002B556C File Offset: 0x002B376C
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

		// Token: 0x060128E1 RID: 76001 RVA: 0x002B55E0 File Offset: 0x002B37E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060128E2 RID: 76002 RVA: 0x002B55ED File Offset: 0x002B37ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060128E3 RID: 76003 RVA: 0x002B55F8 File Offset: 0x002B37F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.accessRangeResult_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AccessRangeResult);
			}
			if (this.RangeEntityId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.RangeEntityId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060128E4 RID: 76004 RVA: 0x002B5670 File Offset: 0x002B3870
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

		// Token: 0x060128E5 RID: 76005 RVA: 0x002B56E0 File Offset: 0x002B38E0
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

		// Token: 0x060128E6 RID: 76006 RVA: 0x002B575C File Offset: 0x002B395C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060128E7 RID: 76007 RVA: 0x002B5768 File Offset: 0x002B3968
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
				if (num != 10U)
				{
					if (num != 56U)
					{
						if (num != 120U)
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
						this.RangeEntityId = input.ReadInt64();
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
		}

		// Token: 0x0400739A RID: 29594
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400739B RID: 29595
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x0400739C RID: 29596
		private ErrorCode errorCode_;

		// Token: 0x0400739D RID: 29597
		public const int RangeEntityIdFieldNumber = 7;

		// Token: 0x0400739E RID: 29598
		private long rangeEntityId_;

		// Token: 0x0400739F RID: 29599
		public const int AccessRangeResultFieldNumber = 1;

		// Token: 0x040073A0 RID: 29600
		private AccessRangeResultMessage accessRangeResult_;
	}
}
