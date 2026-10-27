using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D7C RID: 3452
	[NetMessage(EMessageId.PlayerAccessRangeRequest)]
	public sealed class PlayerAccessRangeRequest : IMessage<PlayerAccessRangeRequest>, IMessage, IEquatable<PlayerAccessRangeRequest>, IDeepCloneable<PlayerAccessRangeRequest>, IBufferMessage
	{
		// Token: 0x060129BA RID: 76218 RVA: 0x002B6DCF File Offset: 0x002B4FCF
		[NullableContext(1)]
		public static PlayerAccessRangeRequest Create()
		{
			return new PlayerAccessRangeRequest();
		}

		// Token: 0x17003DB0 RID: 15792
		// (get) Token: 0x060129BB RID: 76219 RVA: 0x002B6DD6 File Offset: 0x002B4FD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003DB1 RID: 15793
		// (get) Token: 0x060129BC RID: 76220 RVA: 0x002B6DD9 File Offset: 0x002B4FD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerAccessRangeRequest.Descriptor;
			}
		}

		// Token: 0x060129BD RID: 76221 RVA: 0x002B6DE0 File Offset: 0x002B4FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAccessRangeRequest()
		{
		}

		// Token: 0x060129BE RID: 76222 RVA: 0x002B6DE8 File Offset: 0x002B4FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAccessRangeRequest(PlayerAccessRangeRequest other) : this()
		{
			this.rangeEntityId_ = other.rangeEntityId_;
			this.accessRangeType_ = other.accessRangeType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060129BF RID: 76223 RVA: 0x002B6E19 File Offset: 0x002B5019
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAccessRangeRequest Clone()
		{
			return new PlayerAccessRangeRequest(this);
		}

		// Token: 0x17003DB2 RID: 15794
		// (get) Token: 0x060129C0 RID: 76224 RVA: 0x002B6E21 File Offset: 0x002B5021
		// (set) Token: 0x060129C1 RID: 76225 RVA: 0x002B6E29 File Offset: 0x002B5029
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

		// Token: 0x17003DB3 RID: 15795
		// (get) Token: 0x060129C2 RID: 76226 RVA: 0x002B6E32 File Offset: 0x002B5032
		// (set) Token: 0x060129C3 RID: 76227 RVA: 0x002B6E3A File Offset: 0x002B503A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccessRangeType AccessRangeType
		{
			get
			{
				return this.accessRangeType_;
			}
			set
			{
				this.accessRangeType_ = value;
			}
		}

		// Token: 0x060129C4 RID: 76228 RVA: 0x002B6E43 File Offset: 0x002B5043
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerAccessRangeRequest);
		}

		// Token: 0x060129C5 RID: 76229 RVA: 0x002B6E51 File Offset: 0x002B5051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerAccessRangeRequest other)
		{
			return other != null && (other == this || (this.RangeEntityId == other.RangeEntityId && this.AccessRangeType == other.AccessRangeType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060129C6 RID: 76230 RVA: 0x002B6E90 File Offset: 0x002B5090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RangeEntityId != 0L)
			{
				num ^= this.RangeEntityId.GetHashCode();
			}
			if (this.AccessRangeType != AccessRangeType.RangeEnter)
			{
				num ^= this.AccessRangeType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060129C7 RID: 76231 RVA: 0x002B6EEE File Offset: 0x002B50EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060129C8 RID: 76232 RVA: 0x002B6EFB File Offset: 0x002B50FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060129C9 RID: 76233 RVA: 0x002B6F04 File Offset: 0x002B5104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AccessRangeType != AccessRangeType.RangeEnter)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.AccessRangeType);
			}
			if (this.RangeEntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.RangeEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060129CA RID: 76234 RVA: 0x002B6F60 File Offset: 0x002B5160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RangeEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.RangeEntityId);
			}
			if (this.AccessRangeType != AccessRangeType.RangeEnter)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.AccessRangeType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060129CB RID: 76235 RVA: 0x002B6FB8 File Offset: 0x002B51B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerAccessRangeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RangeEntityId != 0L)
			{
				this.RangeEntityId = other.RangeEntityId;
			}
			if (other.AccessRangeType != AccessRangeType.RangeEnter)
			{
				this.AccessRangeType = other.AccessRangeType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060129CC RID: 76236 RVA: 0x002B7008 File Offset: 0x002B5208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060129CD RID: 76237 RVA: 0x002B7014 File Offset: 0x002B5214
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
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RangeEntityId = input.ReadInt64();
					}
				}
				else
				{
					this.AccessRangeType = (AccessRangeType)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400737D RID: 29565
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400737E RID: 29566
		public const int RangeEntityIdFieldNumber = 8;

		// Token: 0x0400737F RID: 29567
		private long rangeEntityId_;

		// Token: 0x04007380 RID: 29568
		public const int AccessRangeTypeFieldNumber = 6;

		// Token: 0x04007381 RID: 29569
		private AccessRangeType accessRangeType_;
	}
}
