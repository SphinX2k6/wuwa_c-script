using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200015B RID: 347
	[NetMessage(EMessageId.BanItemUseNotify)]
	public sealed class BanItemUseNotify : IMessage<BanItemUseNotify>, IMessage, IEquatable<BanItemUseNotify>, IDeepCloneable<BanItemUseNotify>, IBufferMessage
	{
		// Token: 0x06002BE0 RID: 11232 RVA: 0x00072758 File Offset: 0x00070958
		[NullableContext(1)]
		public static BanItemUseNotify Create()
		{
			return new BanItemUseNotify();
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06002BE1 RID: 11233 RVA: 0x0007275F File Offset: 0x0007095F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06002BE2 RID: 11234 RVA: 0x00072762 File Offset: 0x00070962
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BanItemUseNotify.Descriptor;
			}
		}

		// Token: 0x06002BE3 RID: 11235 RVA: 0x00072769 File Offset: 0x00070969
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BanItemUseNotify()
		{
		}

		// Token: 0x06002BE4 RID: 11236 RVA: 0x00072771 File Offset: 0x00070971
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BanItemUseNotify(BanItemUseNotify other) : this()
		{
			this.banEndTime_ = other.banEndTime_;
			this.banItemUseType_ = other.banItemUseType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002BE5 RID: 11237 RVA: 0x000727A2 File Offset: 0x000709A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BanItemUseNotify Clone()
		{
			return new BanItemUseNotify(this);
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06002BE6 RID: 11238 RVA: 0x000727AA File Offset: 0x000709AA
		// (set) Token: 0x06002BE7 RID: 11239 RVA: 0x000727B2 File Offset: 0x000709B2
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

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06002BE8 RID: 11240 RVA: 0x000727BB File Offset: 0x000709BB
		// (set) Token: 0x06002BE9 RID: 11241 RVA: 0x000727C3 File Offset: 0x000709C3
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

		// Token: 0x06002BEA RID: 11242 RVA: 0x000727CC File Offset: 0x000709CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BanItemUseNotify);
		}

		// Token: 0x06002BEB RID: 11243 RVA: 0x000727DA File Offset: 0x000709DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BanItemUseNotify other)
		{
			return other != null && (other == this || (this.BanEndTime == other.BanEndTime && this.BanItemUseType == other.BanItemUseType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002BEC RID: 11244 RVA: 0x00072818 File Offset: 0x00070A18
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

		// Token: 0x06002BED RID: 11245 RVA: 0x00072876 File Offset: 0x00070A76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002BEE RID: 11246 RVA: 0x00072883 File Offset: 0x00070A83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002BEF RID: 11247 RVA: 0x0007288C File Offset: 0x00070A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BanEndTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.BanEndTime);
			}
			if (this.BanItemUseType != BanItemUseType.BanItemUseNone)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.BanItemUseType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002BF0 RID: 11248 RVA: 0x000728E8 File Offset: 0x00070AE8
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

		// Token: 0x06002BF1 RID: 11249 RVA: 0x00072940 File Offset: 0x00070B40
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

		// Token: 0x06002BF2 RID: 11250 RVA: 0x00072990 File Offset: 0x00070B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002BF3 RID: 11251 RVA: 0x0007299C File Offset: 0x00070B9C
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
				if (num != 16U)
				{
					if (num != 64U)
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

		// Token: 0x04002811 RID: 10257
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002812 RID: 10258
		public const int BanEndTimeFieldNumber = 2;

		// Token: 0x04002813 RID: 10259
		private long banEndTime_;

		// Token: 0x04002814 RID: 10260
		public const int BanItemUseTypeFieldNumber = 8;

		// Token: 0x04002815 RID: 10261
		private BanItemUseType banItemUseType_;
	}
}
