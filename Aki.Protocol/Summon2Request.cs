using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012AA RID: 4778
	[NetMessage(EMessageId.Summon2Request)]
	public sealed class Summon2Request : IMessage<Summon2Request>, IMessage, IEquatable<Summon2Request>, IDeepCloneable<Summon2Request>, IBufferMessage
	{
		// Token: 0x060196DA RID: 104154 RVA: 0x003B21D4 File Offset: 0x003B03D4
		[NullableContext(1)]
		public static Summon2Request Create()
		{
			return new Summon2Request();
		}

		// Token: 0x170055C0 RID: 21952
		// (get) Token: 0x060196DB RID: 104155 RVA: 0x003B21DB File Offset: 0x003B03DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170055C1 RID: 21953
		// (get) Token: 0x060196DC RID: 104156 RVA: 0x003B21DE File Offset: 0x003B03DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Summon2Request.Descriptor;
			}
		}

		// Token: 0x060196DD RID: 104157 RVA: 0x003B21E5 File Offset: 0x003B03E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Summon2Request()
		{
		}

		// Token: 0x060196DE RID: 104158 RVA: 0x003B21F0 File Offset: 0x003B03F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Summon2Request(Summon2Request other) : this()
		{
			this.summonerEntityId_ = other.summonerEntityId_;
			this.summonInfo_ = ((other.summonInfo_ != null) ? other.summonInfo_.Clone() : null);
			this.version_ = other.version_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060196DF RID: 104159 RVA: 0x003B2248 File Offset: 0x003B0448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Summon2Request Clone()
		{
			return new Summon2Request(this);
		}

		// Token: 0x170055C2 RID: 21954
		// (get) Token: 0x060196E0 RID: 104160 RVA: 0x003B2250 File Offset: 0x003B0450
		// (set) Token: 0x060196E1 RID: 104161 RVA: 0x003B2258 File Offset: 0x003B0458
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

		// Token: 0x170055C3 RID: 21955
		// (get) Token: 0x060196E2 RID: 104162 RVA: 0x003B2261 File Offset: 0x003B0461
		// (set) Token: 0x060196E3 RID: 104163 RVA: 0x003B2269 File Offset: 0x003B0469
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

		// Token: 0x170055C4 RID: 21956
		// (get) Token: 0x060196E4 RID: 104164 RVA: 0x003B2272 File Offset: 0x003B0472
		// (set) Token: 0x060196E5 RID: 104165 RVA: 0x003B227A File Offset: 0x003B047A
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

		// Token: 0x060196E6 RID: 104166 RVA: 0x003B2283 File Offset: 0x003B0483
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as Summon2Request);
		}

		// Token: 0x060196E7 RID: 104167 RVA: 0x003B2294 File Offset: 0x003B0494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Summon2Request other)
		{
			return other != null && (other == this || (this.SummonerEntityId == other.SummonerEntityId && object.Equals(this.SummonInfo, other.SummonInfo) && this.Version == other.Version && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060196E8 RID: 104168 RVA: 0x003B22F4 File Offset: 0x003B04F4
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

		// Token: 0x060196E9 RID: 104169 RVA: 0x003B2362 File Offset: 0x003B0562
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060196EA RID: 104170 RVA: 0x003B236F File Offset: 0x003B056F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060196EB RID: 104171 RVA: 0x003B2378 File Offset: 0x003B0578
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
				output.WriteRawTag(122);
				output.WriteMessage(this.SummonInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060196EC RID: 104172 RVA: 0x003B23F0 File Offset: 0x003B05F0
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

		// Token: 0x060196ED RID: 104173 RVA: 0x003B2460 File Offset: 0x003B0660
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

		// Token: 0x060196EE RID: 104174 RVA: 0x003B24DC File Offset: 0x003B06DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060196EF RID: 104175 RVA: 0x003B24E8 File Offset: 0x003B06E8
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
						if (num != 122U)
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

		// Token: 0x04009547 RID: 38215
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009548 RID: 38216
		public const int SummonerEntityIdFieldNumber = 4;

		// Token: 0x04009549 RID: 38217
		private long summonerEntityId_;

		// Token: 0x0400954A RID: 38218
		public const int SummonInfoFieldNumber = 15;

		// Token: 0x0400954B RID: 38219
		private SummonRequestInfo summonInfo_;

		// Token: 0x0400954C RID: 38220
		public const int VersionFieldNumber = 7;

		// Token: 0x0400954D RID: 38221
		private int version_;
	}
}
