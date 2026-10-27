using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012B3 RID: 4787
	[NetMessage(EMessageId.SummonRequest)]
	public sealed class SummonRequest : IMessage<SummonRequest>, IMessage, IEquatable<SummonRequest>, IDeepCloneable<SummonRequest>, IBufferMessage
	{
		// Token: 0x0601978E RID: 104334 RVA: 0x003B3A35 File Offset: 0x003B1C35
		[NullableContext(1)]
		public static SummonRequest Create()
		{
			return new SummonRequest();
		}

		// Token: 0x170055E4 RID: 21988
		// (get) Token: 0x0601978F RID: 104335 RVA: 0x003B3A3C File Offset: 0x003B1C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170055E5 RID: 21989
		// (get) Token: 0x06019790 RID: 104336 RVA: 0x003B3A3F File Offset: 0x003B1C3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SummonRequest.Descriptor;
			}
		}

		// Token: 0x06019791 RID: 104337 RVA: 0x003B3A46 File Offset: 0x003B1C46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonRequest()
		{
		}

		// Token: 0x06019792 RID: 104338 RVA: 0x003B3A50 File Offset: 0x003B1C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonRequest(SummonRequest other) : this()
		{
			this.summonerEntityId_ = other.summonerEntityId_;
			this.summonInfo_ = ((other.summonInfo_ != null) ? other.summonInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019793 RID: 104339 RVA: 0x003B3A9C File Offset: 0x003B1C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonRequest Clone()
		{
			return new SummonRequest(this);
		}

		// Token: 0x170055E6 RID: 21990
		// (get) Token: 0x06019794 RID: 104340 RVA: 0x003B3AA4 File Offset: 0x003B1CA4
		// (set) Token: 0x06019795 RID: 104341 RVA: 0x003B3AAC File Offset: 0x003B1CAC
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

		// Token: 0x170055E7 RID: 21991
		// (get) Token: 0x06019796 RID: 104342 RVA: 0x003B3AB5 File Offset: 0x003B1CB5
		// (set) Token: 0x06019797 RID: 104343 RVA: 0x003B3ABD File Offset: 0x003B1CBD
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

		// Token: 0x06019798 RID: 104344 RVA: 0x003B3AC6 File Offset: 0x003B1CC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SummonRequest);
		}

		// Token: 0x06019799 RID: 104345 RVA: 0x003B3AD4 File Offset: 0x003B1CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SummonRequest other)
		{
			return other != null && (other == this || (this.SummonerEntityId == other.SummonerEntityId && object.Equals(this.SummonInfo, other.SummonInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601979A RID: 104346 RVA: 0x003B3B24 File Offset: 0x003B1D24
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

		// Token: 0x0601979B RID: 104347 RVA: 0x003B3B79 File Offset: 0x003B1D79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601979C RID: 104348 RVA: 0x003B3B86 File Offset: 0x003B1D86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601979D RID: 104349 RVA: 0x003B3B90 File Offset: 0x003B1D90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SummonerEntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.SummonerEntityId);
			}
			if (this.summonInfo_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.SummonInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601979E RID: 104350 RVA: 0x003B3BE8 File Offset: 0x003B1DE8
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

		// Token: 0x0601979F RID: 104351 RVA: 0x003B3C40 File Offset: 0x003B1E40
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

		// Token: 0x060197A0 RID: 104352 RVA: 0x003B3CA8 File Offset: 0x003B1EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060197A1 RID: 104353 RVA: 0x003B3CB4 File Offset: 0x003B1EB4
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
					if (num != 66U)
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

		// Token: 0x04009576 RID: 38262
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009577 RID: 38263
		public const int SummonerEntityIdFieldNumber = 1;

		// Token: 0x04009578 RID: 38264
		private long summonerEntityId_;

		// Token: 0x04009579 RID: 38265
		public const int SummonInfoFieldNumber = 8;

		// Token: 0x0400957A RID: 38266
		private SummonRequestInfo summonInfo_;
	}
}
