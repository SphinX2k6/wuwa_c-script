using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200121F RID: 4639
	public sealed class SheriffCriminalInfo : IMessage<SheriffCriminalInfo>, IMessage, IEquatable<SheriffCriminalInfo>, IDeepCloneable<SheriffCriminalInfo>, IBufferMessage
	{
		// Token: 0x06018C64 RID: 101476 RVA: 0x0039C795 File Offset: 0x0039A995
		[NullableContext(1)]
		public static SheriffCriminalInfo Create()
		{
			return new SheriffCriminalInfo();
		}

		// Token: 0x170053A8 RID: 21416
		// (get) Token: 0x06018C65 RID: 101477 RVA: 0x0039C79C File Offset: 0x0039A99C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SheriffCriminalInfo> Parser
		{
			get
			{
				return SheriffCriminalInfo._parser;
			}
		}

		// Token: 0x170053A9 RID: 21417
		// (get) Token: 0x06018C66 RID: 101478 RVA: 0x0039C7A3 File Offset: 0x0039A9A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170053AA RID: 21418
		// (get) Token: 0x06018C67 RID: 101479 RVA: 0x0039C7A6 File Offset: 0x0039A9A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SheriffCriminalInfo.Descriptor;
			}
		}

		// Token: 0x06018C68 RID: 101480 RVA: 0x0039C7AD File Offset: 0x0039A9AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffCriminalInfo()
		{
		}

		// Token: 0x06018C69 RID: 101481 RVA: 0x0039C7B5 File Offset: 0x0039A9B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffCriminalInfo(SheriffCriminalInfo other) : this()
		{
			this.criminalId_ = other.criminalId_;
			this.state_ = other.state_;
			this.identityId_ = other.identityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018C6A RID: 101482 RVA: 0x0039C7F2 File Offset: 0x0039A9F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffCriminalInfo Clone()
		{
			return new SheriffCriminalInfo(this);
		}

		// Token: 0x170053AB RID: 21419
		// (get) Token: 0x06018C6B RID: 101483 RVA: 0x0039C7FA File Offset: 0x0039A9FA
		// (set) Token: 0x06018C6C RID: 101484 RVA: 0x0039C802 File Offset: 0x0039AA02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CriminalId
		{
			get
			{
				return this.criminalId_;
			}
			set
			{
				this.criminalId_ = value;
			}
		}

		// Token: 0x170053AC RID: 21420
		// (get) Token: 0x06018C6D RID: 101485 RVA: 0x0039C80B File Offset: 0x0039AA0B
		// (set) Token: 0x06018C6E RID: 101486 RVA: 0x0039C813 File Offset: 0x0039AA13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x170053AD RID: 21421
		// (get) Token: 0x06018C6F RID: 101487 RVA: 0x0039C81C File Offset: 0x0039AA1C
		// (set) Token: 0x06018C70 RID: 101488 RVA: 0x0039C824 File Offset: 0x0039AA24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IdentityId
		{
			get
			{
				return this.identityId_;
			}
			set
			{
				this.identityId_ = value;
			}
		}

		// Token: 0x06018C71 RID: 101489 RVA: 0x0039C82D File Offset: 0x0039AA2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SheriffCriminalInfo);
		}

		// Token: 0x06018C72 RID: 101490 RVA: 0x0039C83C File Offset: 0x0039AA3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SheriffCriminalInfo other)
		{
			return other != null && (other == this || (this.CriminalId == other.CriminalId && this.State == other.State && this.IdentityId == other.IdentityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018C73 RID: 101491 RVA: 0x0039C898 File Offset: 0x0039AA98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CriminalId != 0)
			{
				num ^= this.CriminalId.GetHashCode();
			}
			if (this.State != 0)
			{
				num ^= this.State.GetHashCode();
			}
			if (this.IdentityId != 0)
			{
				num ^= this.IdentityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018C74 RID: 101492 RVA: 0x0039C909 File Offset: 0x0039AB09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018C75 RID: 101493 RVA: 0x0039C916 File Offset: 0x0039AB16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018C76 RID: 101494 RVA: 0x0039C920 File Offset: 0x0039AB20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CriminalId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CriminalId);
			}
			if (this.State != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.State);
			}
			if (this.IdentityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.IdentityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018C77 RID: 101495 RVA: 0x0039C994 File Offset: 0x0039AB94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CriminalId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CriminalId);
			}
			if (this.State != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.State);
			}
			if (this.IdentityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IdentityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018C78 RID: 101496 RVA: 0x0039CA04 File Offset: 0x0039AC04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SheriffCriminalInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CriminalId != 0)
			{
				this.CriminalId = other.CriminalId;
			}
			if (other.State != 0)
			{
				this.State = other.State;
			}
			if (other.IdentityId != 0)
			{
				this.IdentityId = other.IdentityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018C79 RID: 101497 RVA: 0x0039CA68 File Offset: 0x0039AC68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018C7A RID: 101498 RVA: 0x0039CA74 File Offset: 0x0039AC74
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IdentityId = input.ReadInt32();
						}
					}
					else
					{
						this.State = input.ReadInt32();
					}
				}
				else
				{
					this.CriminalId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009303 RID: 37635
		private static readonly MessageParser<SheriffCriminalInfo> _parser = new MessageParser<SheriffCriminalInfo>(() => new SheriffCriminalInfo());

		// Token: 0x04009304 RID: 37636
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009305 RID: 37637
		public const int CriminalIdFieldNumber = 1;

		// Token: 0x04009306 RID: 37638
		private int criminalId_;

		// Token: 0x04009307 RID: 37639
		public const int StateFieldNumber = 2;

		// Token: 0x04009308 RID: 37640
		private int state_;

		// Token: 0x04009309 RID: 37641
		public const int IdentityIdFieldNumber = 3;

		// Token: 0x0400930A RID: 37642
		private int identityId_;
	}
}
