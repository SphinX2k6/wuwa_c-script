using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D6B RID: 3435
	[NetMessage(EMessageId.PlayerAccessRangeNotify)]
	public sealed class PlayerAccessRangeNotify : IMessage<PlayerAccessRangeNotify>, IMessage, IEquatable<PlayerAccessRangeNotify>, IDeepCloneable<PlayerAccessRangeNotify>, IBufferMessage
	{
		// Token: 0x060128A8 RID: 75944 RVA: 0x002B4E5F File Offset: 0x002B305F
		[NullableContext(1)]
		public static PlayerAccessRangeNotify Create()
		{
			return new PlayerAccessRangeNotify();
		}

		// Token: 0x17003D76 RID: 15734
		// (get) Token: 0x060128A9 RID: 75945 RVA: 0x002B4E66 File Offset: 0x002B3066
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D77 RID: 15735
		// (get) Token: 0x060128AA RID: 75946 RVA: 0x002B4E69 File Offset: 0x002B3069
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerAccessRangeNotify.Descriptor;
			}
		}

		// Token: 0x060128AB RID: 75947 RVA: 0x002B4E70 File Offset: 0x002B3070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAccessRangeNotify()
		{
		}

		// Token: 0x060128AC RID: 75948 RVA: 0x002B4E78 File Offset: 0x002B3078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAccessRangeNotify(PlayerAccessRangeNotify other) : this()
		{
			this.rangeEntiyId_ = other.rangeEntiyId_;
			this.accessPlayerId_ = other.accessPlayerId_;
			this.accessRangeType_ = other.accessRangeType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060128AD RID: 75949 RVA: 0x002B4EB5 File Offset: 0x002B30B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAccessRangeNotify Clone()
		{
			return new PlayerAccessRangeNotify(this);
		}

		// Token: 0x17003D78 RID: 15736
		// (get) Token: 0x060128AE RID: 75950 RVA: 0x002B4EBD File Offset: 0x002B30BD
		// (set) Token: 0x060128AF RID: 75951 RVA: 0x002B4EC5 File Offset: 0x002B30C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long RangeEntiyId
		{
			get
			{
				return this.rangeEntiyId_;
			}
			set
			{
				this.rangeEntiyId_ = value;
			}
		}

		// Token: 0x17003D79 RID: 15737
		// (get) Token: 0x060128B0 RID: 75952 RVA: 0x002B4ECE File Offset: 0x002B30CE
		// (set) Token: 0x060128B1 RID: 75953 RVA: 0x002B4ED6 File Offset: 0x002B30D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AccessPlayerId
		{
			get
			{
				return this.accessPlayerId_;
			}
			set
			{
				this.accessPlayerId_ = value;
			}
		}

		// Token: 0x17003D7A RID: 15738
		// (get) Token: 0x060128B2 RID: 75954 RVA: 0x002B4EDF File Offset: 0x002B30DF
		// (set) Token: 0x060128B3 RID: 75955 RVA: 0x002B4EE7 File Offset: 0x002B30E7
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

		// Token: 0x060128B4 RID: 75956 RVA: 0x002B4EF0 File Offset: 0x002B30F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerAccessRangeNotify);
		}

		// Token: 0x060128B5 RID: 75957 RVA: 0x002B4F00 File Offset: 0x002B3100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerAccessRangeNotify other)
		{
			return other != null && (other == this || (this.RangeEntiyId == other.RangeEntiyId && this.AccessPlayerId == other.AccessPlayerId && this.AccessRangeType == other.AccessRangeType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060128B6 RID: 75958 RVA: 0x002B4F5C File Offset: 0x002B315C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RangeEntiyId != 0L)
			{
				num ^= this.RangeEntiyId.GetHashCode();
			}
			if (this.AccessPlayerId != 0)
			{
				num ^= this.AccessPlayerId.GetHashCode();
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

		// Token: 0x060128B7 RID: 75959 RVA: 0x002B4FD3 File Offset: 0x002B31D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060128B8 RID: 75960 RVA: 0x002B4FE0 File Offset: 0x002B31E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060128B9 RID: 75961 RVA: 0x002B4FEC File Offset: 0x002B31EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RangeEntiyId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.RangeEntiyId);
			}
			if (this.AccessRangeType != AccessRangeType.RangeEnter)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.AccessRangeType);
			}
			if (this.AccessPlayerId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.AccessPlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060128BA RID: 75962 RVA: 0x002B5064 File Offset: 0x002B3264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RangeEntiyId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.RangeEntiyId);
			}
			if (this.AccessPlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AccessPlayerId);
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

		// Token: 0x060128BB RID: 75963 RVA: 0x002B50D4 File Offset: 0x002B32D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerAccessRangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RangeEntiyId != 0L)
			{
				this.RangeEntiyId = other.RangeEntiyId;
			}
			if (other.AccessPlayerId != 0)
			{
				this.AccessPlayerId = other.AccessPlayerId;
			}
			if (other.AccessRangeType != AccessRangeType.RangeEnter)
			{
				this.AccessRangeType = other.AccessRangeType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060128BC RID: 75964 RVA: 0x002B5138 File Offset: 0x002B3338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060128BD RID: 75965 RVA: 0x002B5144 File Offset: 0x002B3344
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
					if (num != 88U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.AccessPlayerId = input.ReadInt32();
						}
					}
					else
					{
						this.AccessRangeType = (AccessRangeType)input.ReadEnum();
					}
				}
				else
				{
					this.RangeEntiyId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400738E RID: 29582
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400738F RID: 29583
		public const int RangeEntiyIdFieldNumber = 6;

		// Token: 0x04007390 RID: 29584
		private long rangeEntiyId_;

		// Token: 0x04007391 RID: 29585
		public const int AccessPlayerIdFieldNumber = 12;

		// Token: 0x04007392 RID: 29586
		private int accessPlayerId_;

		// Token: 0x04007393 RID: 29587
		public const int AccessRangeTypeFieldNumber = 11;

		// Token: 0x04007394 RID: 29588
		private AccessRangeType accessRangeType_;
	}
}
