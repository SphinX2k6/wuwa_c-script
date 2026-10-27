using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012B1 RID: 4785
	[NetMessage(EMessageId.SummonRandomRequest)]
	public sealed class SummonRandomRequest : IMessage<SummonRandomRequest>, IMessage, IEquatable<SummonRandomRequest>, IDeepCloneable<SummonRandomRequest>, IBufferMessage
	{
		// Token: 0x06019768 RID: 104296 RVA: 0x003B3564 File Offset: 0x003B1764
		[NullableContext(1)]
		public static SummonRandomRequest Create()
		{
			return new SummonRandomRequest();
		}

		// Token: 0x170055DD RID: 21981
		// (get) Token: 0x06019769 RID: 104297 RVA: 0x003B356B File Offset: 0x003B176B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170055DE RID: 21982
		// (get) Token: 0x0601976A RID: 104298 RVA: 0x003B356E File Offset: 0x003B176E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SummonRandomRequest.Descriptor;
			}
		}

		// Token: 0x0601976B RID: 104299 RVA: 0x003B3575 File Offset: 0x003B1775
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonRandomRequest()
		{
		}

		// Token: 0x0601976C RID: 104300 RVA: 0x003B3580 File Offset: 0x003B1780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonRandomRequest(SummonRandomRequest other) : this()
		{
			this.summonerId_ = other.summonerId_;
			this.summonInfo_ = ((other.summonInfo_ != null) ? other.summonInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601976D RID: 104301 RVA: 0x003B35CC File Offset: 0x003B17CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonRandomRequest Clone()
		{
			return new SummonRandomRequest(this);
		}

		// Token: 0x170055DF RID: 21983
		// (get) Token: 0x0601976E RID: 104302 RVA: 0x003B35D4 File Offset: 0x003B17D4
		// (set) Token: 0x0601976F RID: 104303 RVA: 0x003B35DC File Offset: 0x003B17DC
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

		// Token: 0x170055E0 RID: 21984
		// (get) Token: 0x06019770 RID: 104304 RVA: 0x003B35E5 File Offset: 0x003B17E5
		// (set) Token: 0x06019771 RID: 104305 RVA: 0x003B35ED File Offset: 0x003B17ED
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

		// Token: 0x06019772 RID: 104306 RVA: 0x003B35F6 File Offset: 0x003B17F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SummonRandomRequest);
		}

		// Token: 0x06019773 RID: 104307 RVA: 0x003B3604 File Offset: 0x003B1804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SummonRandomRequest other)
		{
			return other != null && (other == this || (this.SummonerId == other.SummonerId && object.Equals(this.SummonInfo, other.SummonInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019774 RID: 104308 RVA: 0x003B3654 File Offset: 0x003B1854
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

		// Token: 0x06019775 RID: 104309 RVA: 0x003B36A9 File Offset: 0x003B18A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019776 RID: 104310 RVA: 0x003B36B6 File Offset: 0x003B18B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019777 RID: 104311 RVA: 0x003B36C0 File Offset: 0x003B18C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.summonInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.SummonInfo);
			}
			if (this.SummonerId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.SummonerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019778 RID: 104312 RVA: 0x003B371C File Offset: 0x003B191C
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

		// Token: 0x06019779 RID: 104313 RVA: 0x003B3774 File Offset: 0x003B1974
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

		// Token: 0x0601977A RID: 104314 RVA: 0x003B37DC File Offset: 0x003B19DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601977B RID: 104315 RVA: 0x003B37E8 File Offset: 0x003B19E8
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
				if (num != 26U)
				{
					if (num != 80U)
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

		// Token: 0x0400956E RID: 38254
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400956F RID: 38255
		public const int SummonerIdFieldNumber = 10;

		// Token: 0x04009570 RID: 38256
		private long summonerId_;

		// Token: 0x04009571 RID: 38257
		public const int SummonInfoFieldNumber = 3;

		// Token: 0x04009572 RID: 38258
		private RandomSummonRequestInfo summonInfo_;
	}
}
