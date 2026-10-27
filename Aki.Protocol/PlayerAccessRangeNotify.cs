using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D7B RID: 3451
	[NetMessage(EMessageId.PlayerAccessRangeNotify)]
	public sealed class PlayerAccessRangeNotify : IMessage<PlayerAccessRangeNotify>, IMessage, IEquatable<PlayerAccessRangeNotify>, IDeepCloneable<PlayerAccessRangeNotify>, IBufferMessage
	{
		// Token: 0x060129A4 RID: 76196 RVA: 0x002B6A80 File Offset: 0x002B4C80
		[NullableContext(1)]
		public static PlayerAccessRangeNotify Create()
		{
			return new PlayerAccessRangeNotify();
		}

		// Token: 0x17003DAB RID: 15787
		// (get) Token: 0x060129A5 RID: 76197 RVA: 0x002B6A87 File Offset: 0x002B4C87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003DAC RID: 15788
		// (get) Token: 0x060129A6 RID: 76198 RVA: 0x002B6A8A File Offset: 0x002B4C8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerAccessRangeNotify.Descriptor;
			}
		}

		// Token: 0x060129A7 RID: 76199 RVA: 0x002B6A91 File Offset: 0x002B4C91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAccessRangeNotify()
		{
		}

		// Token: 0x060129A8 RID: 76200 RVA: 0x002B6A99 File Offset: 0x002B4C99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAccessRangeNotify(PlayerAccessRangeNotify other) : this()
		{
			this.rangeEntiyId_ = other.rangeEntiyId_;
			this.accessPlayerId_ = other.accessPlayerId_;
			this.accessRangeType_ = other.accessRangeType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060129A9 RID: 76201 RVA: 0x002B6AD6 File Offset: 0x002B4CD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAccessRangeNotify Clone()
		{
			return new PlayerAccessRangeNotify(this);
		}

		// Token: 0x17003DAD RID: 15789
		// (get) Token: 0x060129AA RID: 76202 RVA: 0x002B6ADE File Offset: 0x002B4CDE
		// (set) Token: 0x060129AB RID: 76203 RVA: 0x002B6AE6 File Offset: 0x002B4CE6
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

		// Token: 0x17003DAE RID: 15790
		// (get) Token: 0x060129AC RID: 76204 RVA: 0x002B6AEF File Offset: 0x002B4CEF
		// (set) Token: 0x060129AD RID: 76205 RVA: 0x002B6AF7 File Offset: 0x002B4CF7
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

		// Token: 0x17003DAF RID: 15791
		// (get) Token: 0x060129AE RID: 76206 RVA: 0x002B6B00 File Offset: 0x002B4D00
		// (set) Token: 0x060129AF RID: 76207 RVA: 0x002B6B08 File Offset: 0x002B4D08
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

		// Token: 0x060129B0 RID: 76208 RVA: 0x002B6B11 File Offset: 0x002B4D11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerAccessRangeNotify);
		}

		// Token: 0x060129B1 RID: 76209 RVA: 0x002B6B20 File Offset: 0x002B4D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerAccessRangeNotify other)
		{
			return other != null && (other == this || (this.RangeEntiyId == other.RangeEntiyId && this.AccessPlayerId == other.AccessPlayerId && this.AccessRangeType == other.AccessRangeType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060129B2 RID: 76210 RVA: 0x002B6B7C File Offset: 0x002B4D7C
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

		// Token: 0x060129B3 RID: 76211 RVA: 0x002B6BF3 File Offset: 0x002B4DF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060129B4 RID: 76212 RVA: 0x002B6C00 File Offset: 0x002B4E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060129B5 RID: 76213 RVA: 0x002B6C0C File Offset: 0x002B4E0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AccessRangeType != AccessRangeType.RangeEnter)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.AccessRangeType);
			}
			if (this.RangeEntiyId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.RangeEntiyId);
			}
			if (this.AccessPlayerId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.AccessPlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060129B6 RID: 76214 RVA: 0x002B6C84 File Offset: 0x002B4E84
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

		// Token: 0x060129B7 RID: 76215 RVA: 0x002B6CF4 File Offset: 0x002B4EF4
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

		// Token: 0x060129B8 RID: 76216 RVA: 0x002B6D58 File Offset: 0x002B4F58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060129B9 RID: 76217 RVA: 0x002B6D64 File Offset: 0x002B4F64
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
					if (num != 48U)
					{
						if (num != 56U)
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
						this.RangeEntiyId = input.ReadInt64();
					}
				}
				else
				{
					this.AccessRangeType = (AccessRangeType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007376 RID: 29558
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007377 RID: 29559
		public const int RangeEntiyIdFieldNumber = 6;

		// Token: 0x04007378 RID: 29560
		private long rangeEntiyId_;

		// Token: 0x04007379 RID: 29561
		public const int AccessPlayerIdFieldNumber = 7;

		// Token: 0x0400737A RID: 29562
		private int accessPlayerId_;

		// Token: 0x0400737B RID: 29563
		public const int AccessRangeTypeFieldNumber = 5;

		// Token: 0x0400737C RID: 29564
		private AccessRangeType accessRangeType_;
	}
}
