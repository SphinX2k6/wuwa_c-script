using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001320 RID: 4896
	[NetMessage(EMessageId.SummonRandomRequest)]
	public sealed class SummonRandomRequest : IMessage<SummonRandomRequest>, IMessage, IEquatable<SummonRandomRequest>, IDeepCloneable<SummonRandomRequest>, IBufferMessage
	{
		// Token: 0x0601A19E RID: 106910 RVA: 0x003CDCA0 File Offset: 0x003CBEA0
		[NullableContext(1)]
		public static SummonRandomRequest Create()
		{
			return new SummonRandomRequest();
		}

		// Token: 0x1700585E RID: 22622
		// (get) Token: 0x0601A19F RID: 106911 RVA: 0x003CDCA7 File Offset: 0x003CBEA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700585F RID: 22623
		// (get) Token: 0x0601A1A0 RID: 106912 RVA: 0x003CDCAA File Offset: 0x003CBEAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SummonRandomRequest.Descriptor;
			}
		}

		// Token: 0x0601A1A1 RID: 106913 RVA: 0x003CDCB1 File Offset: 0x003CBEB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonRandomRequest()
		{
		}

		// Token: 0x0601A1A2 RID: 106914 RVA: 0x003CDCBC File Offset: 0x003CBEBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonRandomRequest(SummonRandomRequest other) : this()
		{
			this.summonerId_ = other.summonerId_;
			this.summonInfo_ = ((other.summonInfo_ != null) ? other.summonInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A1A3 RID: 106915 RVA: 0x003CDD08 File Offset: 0x003CBF08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonRandomRequest Clone()
		{
			return new SummonRandomRequest(this);
		}

		// Token: 0x17005860 RID: 22624
		// (get) Token: 0x0601A1A4 RID: 106916 RVA: 0x003CDD10 File Offset: 0x003CBF10
		// (set) Token: 0x0601A1A5 RID: 106917 RVA: 0x003CDD18 File Offset: 0x003CBF18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SummonerId
		{
			get
			{
				return this.summonerId_;
			}
			set
			{
				this.summonerId_ = value;
			}
		}

		// Token: 0x17005861 RID: 22625
		// (get) Token: 0x0601A1A6 RID: 106918 RVA: 0x003CDD21 File Offset: 0x003CBF21
		// (set) Token: 0x0601A1A7 RID: 106919 RVA: 0x003CDD29 File Offset: 0x003CBF29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RandomSummonRequestInfo SummonInfo
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

		// Token: 0x0601A1A8 RID: 106920 RVA: 0x003CDD32 File Offset: 0x003CBF32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SummonRandomRequest);
		}

		// Token: 0x0601A1A9 RID: 106921 RVA: 0x003CDD40 File Offset: 0x003CBF40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SummonRandomRequest other)
		{
			return other != null && (other == this || (this.SummonerId == other.SummonerId && object.Equals(this.SummonInfo, other.SummonInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A1AA RID: 106922 RVA: 0x003CDD90 File Offset: 0x003CBF90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SummonerId != 0L)
			{
				num ^= this.SummonerId.GetHashCode();
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

		// Token: 0x0601A1AB RID: 106923 RVA: 0x003CDDE5 File Offset: 0x003CBFE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A1AC RID: 106924 RVA: 0x003CDDF2 File Offset: 0x003CBFF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A1AD RID: 106925 RVA: 0x003CDDFC File Offset: 0x003CBFFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.summonInfo_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.SummonInfo);
			}
			if (this.SummonerId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.SummonerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A1AE RID: 106926 RVA: 0x003CDE58 File Offset: 0x003CC058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SummonerId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SummonerId);
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

		// Token: 0x0601A1AF RID: 106927 RVA: 0x003CDEB0 File Offset: 0x003CC0B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SummonRandomRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SummonerId != 0L)
			{
				this.SummonerId = other.SummonerId;
			}
			if (other.summonInfo_ != null)
			{
				if (this.summonInfo_ == null)
				{
					this.SummonInfo = new RandomSummonRequestInfo();
				}
				this.SummonInfo.MergeFrom(other.SummonInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A1B0 RID: 106928 RVA: 0x003CDF18 File Offset: 0x003CC118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A1B1 RID: 106929 RVA: 0x003CDF24 File Offset: 0x003CC124
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
				if (num != 66U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SummonerId = input.ReadInt64();
					}
				}
				else
				{
					if (this.summonInfo_ == null)
					{
						this.SummonInfo = new RandomSummonRequestInfo();
					}
					input.ReadMessage(this.SummonInfo);
				}
			}
		}

		// Token: 0x04009998 RID: 39320
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009999 RID: 39321
		public const int SummonerIdFieldNumber = 15;

		// Token: 0x0400999A RID: 39322
		private long summonerId_;

		// Token: 0x0400999B RID: 39323
		public const int SummonInfoFieldNumber = 8;

		// Token: 0x0400999C RID: 39324
		private RandomSummonRequestInfo summonInfo_;
	}
}
