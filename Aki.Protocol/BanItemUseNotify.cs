using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000158 RID: 344
	[NetMessage(EMessageId.BanItemUseNotify)]
	public sealed class BanItemUseNotify : IMessage<BanItemUseNotify>, IMessage, IEquatable<BanItemUseNotify>, IDeepCloneable<BanItemUseNotify>, IBufferMessage
	{
		// Token: 0x06002B69 RID: 11113 RVA: 0x00071327 File Offset: 0x0006F527
		[NullableContext(1)]
		public static BanItemUseNotify Create()
		{
			return new BanItemUseNotify();
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06002B6A RID: 11114 RVA: 0x0007132E File Offset: 0x0006F52E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06002B6B RID: 11115 RVA: 0x00071331 File Offset: 0x0006F531
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BanItemUseNotify.Descriptor;
			}
		}

		// Token: 0x06002B6C RID: 11116 RVA: 0x00071338 File Offset: 0x0006F538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BanItemUseNotify()
		{
		}

		// Token: 0x06002B6D RID: 11117 RVA: 0x00071340 File Offset: 0x0006F540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BanItemUseNotify(BanItemUseNotify other) : this()
		{
			this.banEndTime_ = other.banEndTime_;
			this.banItemUseType_ = other.banItemUseType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002B6E RID: 11118 RVA: 0x00071371 File Offset: 0x0006F571
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BanItemUseNotify Clone()
		{
			return new BanItemUseNotify(this);
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06002B6F RID: 11119 RVA: 0x00071379 File Offset: 0x0006F579
		// (set) Token: 0x06002B70 RID: 11120 RVA: 0x00071381 File Offset: 0x0006F581
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BanEndTime
		{
			get
			{
				return this.banEndTime_;
			}
			set
			{
				this.banEndTime_ = value;
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06002B71 RID: 11121 RVA: 0x0007138A File Offset: 0x0006F58A
		// (set) Token: 0x06002B72 RID: 11122 RVA: 0x00071392 File Offset: 0x0006F592
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BanItemUseType BanItemUseType
		{
			get
			{
				return this.banItemUseType_;
			}
			set
			{
				this.banItemUseType_ = value;
			}
		}

		// Token: 0x06002B73 RID: 11123 RVA: 0x0007139B File Offset: 0x0006F59B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BanItemUseNotify);
		}

		// Token: 0x06002B74 RID: 11124 RVA: 0x000713A9 File Offset: 0x0006F5A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BanItemUseNotify other)
		{
			return other != null && (other == this || (this.BanEndTime == other.BanEndTime && this.BanItemUseType == other.BanItemUseType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002B75 RID: 11125 RVA: 0x000713E8 File Offset: 0x0006F5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BanEndTime != 0L)
			{
				num ^= this.BanEndTime.GetHashCode();
			}
			if (this.BanItemUseType != BanItemUseType.BanItemUseNone)
			{
				num ^= this.BanItemUseType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002B76 RID: 11126 RVA: 0x00071446 File Offset: 0x0006F646
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002B77 RID: 11127 RVA: 0x00071453 File Offset: 0x0006F653
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002B78 RID: 11128 RVA: 0x0007145C File Offset: 0x0006F65C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BanEndTime != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.BanEndTime);
			}
			if (this.BanItemUseType != BanItemUseType.BanItemUseNone)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.BanItemUseType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002B79 RID: 11129 RVA: 0x000714B8 File Offset: 0x0006F6B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BanEndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BanEndTime);
			}
			if (this.BanItemUseType != BanItemUseType.BanItemUseNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.BanItemUseType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002B7A RID: 11130 RVA: 0x00071510 File Offset: 0x0006F710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BanItemUseNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BanEndTime != 0L)
			{
				this.BanEndTime = other.BanEndTime;
			}
			if (other.BanItemUseType != BanItemUseType.BanItemUseNone)
			{
				this.BanItemUseType = other.BanItemUseType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002B7B RID: 11131 RVA: 0x00071560 File Offset: 0x0006F760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002B7C RID: 11132 RVA: 0x0007156C File Offset: 0x0006F76C
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
				if (num != 64U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.BanItemUseType = (BanItemUseType)input.ReadEnum();
					}
				}
				else
				{
					this.BanEndTime = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400279D RID: 10141
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400279E RID: 10142
		public const int BanEndTimeFieldNumber = 8;

		// Token: 0x0400279F RID: 10143
		private long banEndTime_;

		// Token: 0x040027A0 RID: 10144
		public const int BanItemUseTypeFieldNumber = 10;

		// Token: 0x040027A1 RID: 10145
		private BanItemUseType banItemUseType_;
	}
}
