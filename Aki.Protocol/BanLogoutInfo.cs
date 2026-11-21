using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200015C RID: 348
	public sealed class BanLogoutInfo : IMessage<BanLogoutInfo>, IMessage, IEquatable<BanLogoutInfo>, IDeepCloneable<BanLogoutInfo>, IBufferMessage
	{
		// Token: 0x06002BF4 RID: 11252 RVA: 0x000729F4 File Offset: 0x00070BF4
		[NullableContext(1)]
		public static BanLogoutInfo Create()
		{
			return new BanLogoutInfo();
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06002BF5 RID: 11253 RVA: 0x000729FB File Offset: 0x00070BFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06002BF6 RID: 11254 RVA: 0x000729FE File Offset: 0x00070BFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BanLogoutInfo.Descriptor;
			}
		}

		// Token: 0x06002BF7 RID: 11255 RVA: 0x00072A05 File Offset: 0x00070C05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BanLogoutInfo()
		{
		}

		// Token: 0x06002BF8 RID: 11256 RVA: 0x00072A0D File Offset: 0x00070C0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BanLogoutInfo(BanLogoutInfo other) : this()
		{
			this.reason_ = other.reason_;
			this.banEndTime_ = other.banEndTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002BF9 RID: 11257 RVA: 0x00072A3E File Offset: 0x00070C3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BanLogoutInfo Clone()
		{
			return new BanLogoutInfo(this);
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06002BFA RID: 11258 RVA: 0x00072A46 File Offset: 0x00070C46
		// (set) Token: 0x06002BFB RID: 11259 RVA: 0x00072A4E File Offset: 0x00070C4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06002BFC RID: 11260 RVA: 0x00072A57 File Offset: 0x00070C57
		// (set) Token: 0x06002BFD RID: 11261 RVA: 0x00072A5F File Offset: 0x00070C5F
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

		// Token: 0x06002BFE RID: 11262 RVA: 0x00072A68 File Offset: 0x00070C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BanLogoutInfo);
		}

		// Token: 0x06002BFF RID: 11263 RVA: 0x00072A76 File Offset: 0x00070C76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BanLogoutInfo other)
		{
			return other != null && (other == this || (this.Reason == other.Reason && this.BanEndTime == other.BanEndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002C00 RID: 11264 RVA: 0x00072AB4 File Offset: 0x00070CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Reason != 0)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this.BanEndTime != 0L)
			{
				num ^= this.BanEndTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002C01 RID: 11265 RVA: 0x00072B0C File Offset: 0x00070D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002C02 RID: 11266 RVA: 0x00072B19 File Offset: 0x00070D19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002C03 RID: 11267 RVA: 0x00072B24 File Offset: 0x00070D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Reason != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Reason);
			}
			if (this.BanEndTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.BanEndTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002C04 RID: 11268 RVA: 0x00072B7C File Offset: 0x00070D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Reason != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Reason);
			}
			if (this.BanEndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BanEndTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002C05 RID: 11269 RVA: 0x00072BD4 File Offset: 0x00070DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BanLogoutInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Reason != 0)
			{
				this.Reason = other.Reason;
			}
			if (other.BanEndTime != 0L)
			{
				this.BanEndTime = other.BanEndTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002C06 RID: 11270 RVA: 0x00072C24 File Offset: 0x00070E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002C07 RID: 11271 RVA: 0x00072C30 File Offset: 0x00070E30
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.BanEndTime = input.ReadInt64();
					}
				}
				else
				{
					this.Reason = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002816 RID: 10262
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002817 RID: 10263
		public const int ReasonFieldNumber = 1;

		// Token: 0x04002818 RID: 10264
		private int reason_;

		// Token: 0x04002819 RID: 10265
		public const int BanEndTimeFieldNumber = 2;

		// Token: 0x0400281A RID: 10266
		private long banEndTime_;
	}
}
