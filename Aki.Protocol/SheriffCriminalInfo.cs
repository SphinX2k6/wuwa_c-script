using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011E4 RID: 4580
	public sealed class SheriffCriminalInfo : IMessage<SheriffCriminalInfo>, IMessage, IEquatable<SheriffCriminalInfo>, IDeepCloneable<SheriffCriminalInfo>, IBufferMessage
	{
		// Token: 0x060186A0 RID: 100000 RVA: 0x0038CC29 File Offset: 0x0038AE29
		[NullableContext(1)]
		public static SheriffCriminalInfo Create()
		{
			return new SheriffCriminalInfo();
		}

		// Token: 0x17005230 RID: 21040
		// (get) Token: 0x060186A1 RID: 100001 RVA: 0x0038CC30 File Offset: 0x0038AE30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SheriffCriminalInfo> Parser
		{
			get
			{
				return SheriffCriminalInfo._parser;
			}
		}

		// Token: 0x17005231 RID: 21041
		// (get) Token: 0x060186A2 RID: 100002 RVA: 0x0038CC37 File Offset: 0x0038AE37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005232 RID: 21042
		// (get) Token: 0x060186A3 RID: 100003 RVA: 0x0038CC3A File Offset: 0x0038AE3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SheriffCriminalInfo.Descriptor;
			}
		}

		// Token: 0x060186A4 RID: 100004 RVA: 0x0038CC41 File Offset: 0x0038AE41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffCriminalInfo()
		{
		}

		// Token: 0x060186A5 RID: 100005 RVA: 0x0038CC49 File Offset: 0x0038AE49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffCriminalInfo(SheriffCriminalInfo other) : this()
		{
			this.criminalId_ = other.criminalId_;
			this.state_ = other.state_;
			this.identityId_ = other.identityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060186A6 RID: 100006 RVA: 0x0038CC86 File Offset: 0x0038AE86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffCriminalInfo Clone()
		{
			return new SheriffCriminalInfo(this);
		}

		// Token: 0x17005233 RID: 21043
		// (get) Token: 0x060186A7 RID: 100007 RVA: 0x0038CC8E File Offset: 0x0038AE8E
		// (set) Token: 0x060186A8 RID: 100008 RVA: 0x0038CC96 File Offset: 0x0038AE96
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

		// Token: 0x17005234 RID: 21044
		// (get) Token: 0x060186A9 RID: 100009 RVA: 0x0038CC9F File Offset: 0x0038AE9F
		// (set) Token: 0x060186AA RID: 100010 RVA: 0x0038CCA7 File Offset: 0x0038AEA7
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

		// Token: 0x17005235 RID: 21045
		// (get) Token: 0x060186AB RID: 100011 RVA: 0x0038CCB0 File Offset: 0x0038AEB0
		// (set) Token: 0x060186AC RID: 100012 RVA: 0x0038CCB8 File Offset: 0x0038AEB8
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

		// Token: 0x060186AD RID: 100013 RVA: 0x0038CCC1 File Offset: 0x0038AEC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SheriffCriminalInfo);
		}

		// Token: 0x060186AE RID: 100014 RVA: 0x0038CCD0 File Offset: 0x0038AED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SheriffCriminalInfo other)
		{
			return other != null && (other == this || (this.CriminalId == other.CriminalId && this.State == other.State && this.IdentityId == other.IdentityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060186AF RID: 100015 RVA: 0x0038CD2C File Offset: 0x0038AF2C
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

		// Token: 0x060186B0 RID: 100016 RVA: 0x0038CD9D File Offset: 0x0038AF9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060186B1 RID: 100017 RVA: 0x0038CDAA File Offset: 0x0038AFAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060186B2 RID: 100018 RVA: 0x0038CDB4 File Offset: 0x0038AFB4
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

		// Token: 0x060186B3 RID: 100019 RVA: 0x0038CE28 File Offset: 0x0038B028
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

		// Token: 0x060186B4 RID: 100020 RVA: 0x0038CE98 File Offset: 0x0038B098
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

		// Token: 0x060186B5 RID: 100021 RVA: 0x0038CEFC File Offset: 0x0038B0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060186B6 RID: 100022 RVA: 0x0038CF08 File Offset: 0x0038B108
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

		// Token: 0x04009059 RID: 36953
		private static readonly MessageParser<SheriffCriminalInfo> _parser = new MessageParser<SheriffCriminalInfo>(() => new SheriffCriminalInfo());

		// Token: 0x0400905A RID: 36954
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400905B RID: 36955
		public const int CriminalIdFieldNumber = 1;

		// Token: 0x0400905C RID: 36956
		private int criminalId_;

		// Token: 0x0400905D RID: 36957
		public const int StateFieldNumber = 2;

		// Token: 0x0400905E RID: 36958
		private int state_;

		// Token: 0x0400905F RID: 36959
		public const int IdentityIdFieldNumber = 3;

		// Token: 0x04009060 RID: 36960
		private int identityId_;
	}
}
