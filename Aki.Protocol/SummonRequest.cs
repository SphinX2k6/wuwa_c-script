using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001322 RID: 4898
	[NetMessage(EMessageId.SummonRequest)]
	public sealed class SummonRequest : IMessage<SummonRequest>, IMessage, IEquatable<SummonRequest>, IDeepCloneable<SummonRequest>, IBufferMessage
	{
		// Token: 0x0601A1C4 RID: 106948 RVA: 0x003CE171 File Offset: 0x003CC371
		[NullableContext(1)]
		public static SummonRequest Create()
		{
			return new SummonRequest();
		}

		// Token: 0x17005865 RID: 22629
		// (get) Token: 0x0601A1C5 RID: 106949 RVA: 0x003CE178 File Offset: 0x003CC378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005866 RID: 22630
		// (get) Token: 0x0601A1C6 RID: 106950 RVA: 0x003CE17B File Offset: 0x003CC37B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SummonRequest.Descriptor;
			}
		}

		// Token: 0x0601A1C7 RID: 106951 RVA: 0x003CE182 File Offset: 0x003CC382
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonRequest()
		{
		}

		// Token: 0x0601A1C8 RID: 106952 RVA: 0x003CE18C File Offset: 0x003CC38C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonRequest(SummonRequest other) : this()
		{
			this.summonerEntityId_ = other.summonerEntityId_;
			this.summonInfo_ = ((other.summonInfo_ != null) ? other.summonInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A1C9 RID: 106953 RVA: 0x003CE1D8 File Offset: 0x003CC3D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonRequest Clone()
		{
			return new SummonRequest(this);
		}

		// Token: 0x17005867 RID: 22631
		// (get) Token: 0x0601A1CA RID: 106954 RVA: 0x003CE1E0 File Offset: 0x003CC3E0
		// (set) Token: 0x0601A1CB RID: 106955 RVA: 0x003CE1E8 File Offset: 0x003CC3E8
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

		// Token: 0x17005868 RID: 22632
		// (get) Token: 0x0601A1CC RID: 106956 RVA: 0x003CE1F1 File Offset: 0x003CC3F1
		// (set) Token: 0x0601A1CD RID: 106957 RVA: 0x003CE1F9 File Offset: 0x003CC3F9
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

		// Token: 0x0601A1CE RID: 106958 RVA: 0x003CE202 File Offset: 0x003CC402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SummonRequest);
		}

		// Token: 0x0601A1CF RID: 106959 RVA: 0x003CE210 File Offset: 0x003CC410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SummonRequest other)
		{
			return other != null && (other == this || (this.SummonerEntityId == other.SummonerEntityId && object.Equals(this.SummonInfo, other.SummonInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A1D0 RID: 106960 RVA: 0x003CE260 File Offset: 0x003CC460
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

		// Token: 0x0601A1D1 RID: 106961 RVA: 0x003CE2B5 File Offset: 0x003CC4B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A1D2 RID: 106962 RVA: 0x003CE2C2 File Offset: 0x003CC4C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A1D3 RID: 106963 RVA: 0x003CE2CC File Offset: 0x003CC4CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.summonInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.SummonInfo);
			}
			if (this.SummonerEntityId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.SummonerEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A1D4 RID: 106964 RVA: 0x003CE328 File Offset: 0x003CC528
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

		// Token: 0x0601A1D5 RID: 106965 RVA: 0x003CE380 File Offset: 0x003CC580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SummonRequest other)
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

		// Token: 0x0601A1D6 RID: 106966 RVA: 0x003CE3E8 File Offset: 0x003CC5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A1D7 RID: 106967 RVA: 0x003CE3F4 File Offset: 0x003CC5F4
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
				if (num != 58U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SummonerEntityId = input.ReadInt64();
					}
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
		}

		// Token: 0x040099A0 RID: 39328
		private UnknownFieldSet _unknownFields;

		// Token: 0x040099A1 RID: 39329
		public const int SummonerEntityIdFieldNumber = 9;

		// Token: 0x040099A2 RID: 39330
		private long summonerEntityId_;

		// Token: 0x040099A3 RID: 39331
		public const int SummonInfoFieldNumber = 7;

		// Token: 0x040099A4 RID: 39332
		private SummonRequestInfo summonInfo_;
	}
}
