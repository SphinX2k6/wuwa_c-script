using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004E8 RID: 1256
	[NetMessage(EMessageId.ExploreScoreRewardRequest)]
	public sealed class ExploreScoreRewardRequest : IMessage<ExploreScoreRewardRequest>, IMessage, IEquatable<ExploreScoreRewardRequest>, IDeepCloneable<ExploreScoreRewardRequest>, IBufferMessage
	{
		// Token: 0x06007709 RID: 30473 RVA: 0x001227B1 File Offset: 0x001209B1
		[NullableContext(1)]
		public static ExploreScoreRewardRequest Create()
		{
			return new ExploreScoreRewardRequest();
		}

		// Token: 0x1700170A RID: 5898
		// (get) Token: 0x0600770A RID: 30474 RVA: 0x001227B8 File Offset: 0x001209B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700170B RID: 5899
		// (get) Token: 0x0600770B RID: 30475 RVA: 0x001227BB File Offset: 0x001209BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreScoreRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600770C RID: 30476 RVA: 0x001227C2 File Offset: 0x001209C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreScoreRewardRequest()
		{
		}

		// Token: 0x0600770D RID: 30477 RVA: 0x001227CA File Offset: 0x001209CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreScoreRewardRequest(ExploreScoreRewardRequest other) : this()
		{
			this.areaId_ = other.areaId_;
			this.exploreProgress_ = other.exploreProgress_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600770E RID: 30478 RVA: 0x001227FB File Offset: 0x001209FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreScoreRewardRequest Clone()
		{
			return new ExploreScoreRewardRequest(this);
		}

		// Token: 0x1700170C RID: 5900
		// (get) Token: 0x0600770F RID: 30479 RVA: 0x00122803 File Offset: 0x00120A03
		// (set) Token: 0x06007710 RID: 30480 RVA: 0x0012280B File Offset: 0x00120A0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AreaId
		{
			get
			{
				return this.areaId_;
			}
			set
			{
				this.areaId_ = value;
			}
		}

		// Token: 0x1700170D RID: 5901
		// (get) Token: 0x06007711 RID: 30481 RVA: 0x00122814 File Offset: 0x00120A14
		// (set) Token: 0x06007712 RID: 30482 RVA: 0x0012281C File Offset: 0x00120A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ExploreProgress
		{
			get
			{
				return this.exploreProgress_;
			}
			set
			{
				this.exploreProgress_ = value;
			}
		}

		// Token: 0x06007713 RID: 30483 RVA: 0x00122825 File Offset: 0x00120A25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreScoreRewardRequest);
		}

		// Token: 0x06007714 RID: 30484 RVA: 0x00122833 File Offset: 0x00120A33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreScoreRewardRequest other)
		{
			return other != null && (other == this || (this.AreaId == other.AreaId && this.ExploreProgress == other.ExploreProgress && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007715 RID: 30485 RVA: 0x00122874 File Offset: 0x00120A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AreaId != 0)
			{
				num ^= this.AreaId.GetHashCode();
			}
			if (this.ExploreProgress != 0)
			{
				num ^= this.ExploreProgress.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007716 RID: 30486 RVA: 0x001228CC File Offset: 0x00120ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007717 RID: 30487 RVA: 0x001228D9 File Offset: 0x00120AD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007718 RID: 30488 RVA: 0x001228E4 File Offset: 0x00120AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AreaId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.AreaId);
			}
			if (this.ExploreProgress != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ExploreProgress);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007719 RID: 30489 RVA: 0x00122940 File Offset: 0x00120B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AreaId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AreaId);
			}
			if (this.ExploreProgress != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ExploreProgress);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600771A RID: 30490 RVA: 0x00122998 File Offset: 0x00120B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExploreScoreRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AreaId != 0)
			{
				this.AreaId = other.AreaId;
			}
			if (other.ExploreProgress != 0)
			{
				this.ExploreProgress = other.ExploreProgress;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600771B RID: 30491 RVA: 0x001229E8 File Offset: 0x00120BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600771C RID: 30492 RVA: 0x001229F4 File Offset: 0x00120BF4
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
				if (num != 104U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ExploreProgress = input.ReadInt32();
					}
				}
				else
				{
					this.AreaId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003E60 RID: 15968
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E61 RID: 15969
		public const int AreaIdFieldNumber = 13;

		// Token: 0x04003E62 RID: 15970
		private int areaId_;

		// Token: 0x04003E63 RID: 15971
		public const int ExploreProgressFieldNumber = 15;

		// Token: 0x04003E64 RID: 15972
		private int exploreProgress_;
	}
}
