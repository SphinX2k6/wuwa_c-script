using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001319 RID: 4889
	[NetMessage(EMessageId.Summon2Request)]
	public sealed class Summon2Request : IMessage<Summon2Request>, IMessage, IEquatable<Summon2Request>, IDeepCloneable<Summon2Request>, IBufferMessage
	{
		// Token: 0x0601A110 RID: 106768 RVA: 0x003CC908 File Offset: 0x003CAB08
		[NullableContext(1)]
		public static Summon2Request Create()
		{
			return new Summon2Request();
		}

		// Token: 0x17005841 RID: 22593
		// (get) Token: 0x0601A111 RID: 106769 RVA: 0x003CC90F File Offset: 0x003CAB0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005842 RID: 22594
		// (get) Token: 0x0601A112 RID: 106770 RVA: 0x003CC912 File Offset: 0x003CAB12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Summon2Request.Descriptor;
			}
		}

		// Token: 0x0601A113 RID: 106771 RVA: 0x003CC919 File Offset: 0x003CAB19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Summon2Request()
		{
		}

		// Token: 0x0601A114 RID: 106772 RVA: 0x003CC924 File Offset: 0x003CAB24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Summon2Request(Summon2Request other) : this()
		{
			this.summonerEntityId_ = other.summonerEntityId_;
			this.summonInfo_ = ((other.summonInfo_ != null) ? other.summonInfo_.Clone() : null);
			this.version_ = other.version_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A115 RID: 106773 RVA: 0x003CC97C File Offset: 0x003CAB7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Summon2Request Clone()
		{
			return new Summon2Request(this);
		}

		// Token: 0x17005843 RID: 22595
		// (get) Token: 0x0601A116 RID: 106774 RVA: 0x003CC984 File Offset: 0x003CAB84
		// (set) Token: 0x0601A117 RID: 106775 RVA: 0x003CC98C File Offset: 0x003CAB8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SummonerEntityId
		{
			get
			{
				return this.summonerEntityId_;
			}
			set
			{
				this.summonerEntityId_ = value;
			}
		}

		// Token: 0x17005844 RID: 22596
		// (get) Token: 0x0601A118 RID: 106776 RVA: 0x003CC995 File Offset: 0x003CAB95
		// (set) Token: 0x0601A119 RID: 106777 RVA: 0x003CC99D File Offset: 0x003CAB9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonRequestInfo SummonInfo
		{
			get
			{
				return this.summonInfo_;
			}
			set
			{
				this.summonInfo_ = value;
			}
		}

		// Token: 0x17005845 RID: 22597
		// (get) Token: 0x0601A11A RID: 106778 RVA: 0x003CC9A6 File Offset: 0x003CABA6
		// (set) Token: 0x0601A11B RID: 106779 RVA: 0x003CC9AE File Offset: 0x003CABAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Version
		{
			get
			{
				return this.version_;
			}
			set
			{
				this.version_ = value;
			}
		}

		// Token: 0x0601A11C RID: 106780 RVA: 0x003CC9B7 File Offset: 0x003CABB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as Summon2Request);
		}

		// Token: 0x0601A11D RID: 106781 RVA: 0x003CC9C8 File Offset: 0x003CABC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Summon2Request other)
		{
			return other != null && (other == this || (this.SummonerEntityId == other.SummonerEntityId && object.Equals(this.SummonInfo, other.SummonInfo) && this.Version == other.Version && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A11E RID: 106782 RVA: 0x003CCA28 File Offset: 0x003CAC28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SummonerEntityId != 0L)
			{
				num ^= this.SummonerEntityId.GetHashCode();
			}
			if (this.summonInfo_ != null)
			{
				num ^= this.SummonInfo.GetHashCode();
			}
			if (this.Version != 0)
			{
				num ^= this.Version.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A11F RID: 106783 RVA: 0x003CCA96 File Offset: 0x003CAC96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A120 RID: 106784 RVA: 0x003CCAA3 File Offset: 0x003CACA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A121 RID: 106785 RVA: 0x003CCAAC File Offset: 0x003CACAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SummonerEntityId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.SummonerEntityId);
			}
			if (this.Version != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Version);
			}
			if (this.summonInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.SummonInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A122 RID: 106786 RVA: 0x003CCB24 File Offset: 0x003CAD24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SummonerEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SummonerEntityId);
			}
			if (this.summonInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SummonInfo);
			}
			if (this.Version != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Version);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A123 RID: 106787 RVA: 0x003CCB94 File Offset: 0x003CAD94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Summon2Request other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SummonerEntityId != 0L)
			{
				this.SummonerEntityId = other.SummonerEntityId;
			}
			if (other.summonInfo_ != null)
			{
				if (this.summonInfo_ == null)
				{
					this.SummonInfo = new SummonRequestInfo();
				}
				this.SummonInfo.MergeFrom(other.SummonInfo);
			}
			if (other.Version != 0)
			{
				this.Version = other.Version;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A124 RID: 106788 RVA: 0x003CCC10 File Offset: 0x003CAE10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A125 RID: 106789 RVA: 0x003CCC1C File Offset: 0x003CAE1C
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
				if (num != 32U)
				{
					if (num != 56U)
					{
						if (num != 114U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.summonInfo_ == null)
							{
								this.SummonInfo = new SummonRequestInfo();
							}
							input.ReadMessage(this.SummonInfo);
						}
					}
					else
					{
						this.Version = input.ReadInt32();
					}
				}
				else
				{
					this.SummonerEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04009971 RID: 39281
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009972 RID: 39282
		public const int SummonerEntityIdFieldNumber = 4;

		// Token: 0x04009973 RID: 39283
		private long summonerEntityId_;

		// Token: 0x04009974 RID: 39284
		public const int SummonInfoFieldNumber = 14;

		// Token: 0x04009975 RID: 39285
		private SummonRequestInfo summonInfo_;

		// Token: 0x04009976 RID: 39286
		public const int VersionFieldNumber = 7;

		// Token: 0x04009977 RID: 39287
		private int version_;
	}
}
