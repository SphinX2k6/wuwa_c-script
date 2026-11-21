using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200131B RID: 4891
	[NetMessage(EMessageId.Summon3Request)]
	public sealed class Summon3Request : IMessage<Summon3Request>, IMessage, IEquatable<Summon3Request>, IDeepCloneable<Summon3Request>, IBufferMessage
	{
		// Token: 0x0601A13A RID: 106810 RVA: 0x003CCF38 File Offset: 0x003CB138
		[NullableContext(1)]
		public static Summon3Request Create()
		{
			return new Summon3Request();
		}

		// Token: 0x1700584A RID: 22602
		// (get) Token: 0x0601A13B RID: 106811 RVA: 0x003CCF3F File Offset: 0x003CB13F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700584B RID: 22603
		// (get) Token: 0x0601A13C RID: 106812 RVA: 0x003CCF42 File Offset: 0x003CB142
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Summon3Request.Descriptor;
			}
		}

		// Token: 0x0601A13D RID: 106813 RVA: 0x003CCF49 File Offset: 0x003CB149
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Summon3Request()
		{
		}

		// Token: 0x0601A13E RID: 106814 RVA: 0x003CCF54 File Offset: 0x003CB154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Summon3Request(Summon3Request other) : this()
		{
			this.summonerEntityId_ = other.summonerEntityId_;
			this.summonInfo_ = ((other.summonInfo_ != null) ? other.summonInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A13F RID: 106815 RVA: 0x003CCFA0 File Offset: 0x003CB1A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Summon3Request Clone()
		{
			return new Summon3Request(this);
		}

		// Token: 0x1700584C RID: 22604
		// (get) Token: 0x0601A140 RID: 106816 RVA: 0x003CCFA8 File Offset: 0x003CB1A8
		// (set) Token: 0x0601A141 RID: 106817 RVA: 0x003CCFB0 File Offset: 0x003CB1B0
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

		// Token: 0x1700584D RID: 22605
		// (get) Token: 0x0601A142 RID: 106818 RVA: 0x003CCFB9 File Offset: 0x003CB1B9
		// (set) Token: 0x0601A143 RID: 106819 RVA: 0x003CCFC1 File Offset: 0x003CB1C1
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

		// Token: 0x0601A144 RID: 106820 RVA: 0x003CCFCA File Offset: 0x003CB1CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as Summon3Request);
		}

		// Token: 0x0601A145 RID: 106821 RVA: 0x003CCFD8 File Offset: 0x003CB1D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Summon3Request other)
		{
			return other != null && (other == this || (this.SummonerEntityId == other.SummonerEntityId && object.Equals(this.SummonInfo, other.SummonInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A146 RID: 106822 RVA: 0x003CD028 File Offset: 0x003CB228
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A147 RID: 106823 RVA: 0x003CD07D File Offset: 0x003CB27D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A148 RID: 106824 RVA: 0x003CD08A File Offset: 0x003CB28A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A149 RID: 106825 RVA: 0x003CD094 File Offset: 0x003CB294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SummonerEntityId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.SummonerEntityId);
			}
			if (this.summonInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.SummonInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A14A RID: 106826 RVA: 0x003CD0F0 File Offset: 0x003CB2F0
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A14B RID: 106827 RVA: 0x003CD148 File Offset: 0x003CB348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Summon3Request other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A14C RID: 106828 RVA: 0x003CD1B0 File Offset: 0x003CB3B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A14D RID: 106829 RVA: 0x003CD1BC File Offset: 0x003CB3BC
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
					if (num != 82U)
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
					this.SummonerEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400997D RID: 39293
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400997E RID: 39294
		public const int SummonerEntityIdFieldNumber = 6;

		// Token: 0x0400997F RID: 39295
		private long summonerEntityId_;

		// Token: 0x04009980 RID: 39296
		public const int SummonInfoFieldNumber = 10;

		// Token: 0x04009981 RID: 39297
		private SummonRequestInfo summonInfo_;
	}
}
