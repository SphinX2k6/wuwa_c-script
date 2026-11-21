using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FC7 RID: 4039
	[NetMessage(EMessageId.RogueResEndingRewardRequest)]
	public sealed class RogueResEndingRewardRequest : IMessage<RogueResEndingRewardRequest>, IMessage, IEquatable<RogueResEndingRewardRequest>, IDeepCloneable<RogueResEndingRewardRequest>, IBufferMessage
	{
		// Token: 0x060159DF RID: 88543 RVA: 0x00323C55 File Offset: 0x00321E55
		[NullableContext(1)]
		public static RogueResEndingRewardRequest Create()
		{
			return new RogueResEndingRewardRequest();
		}

		// Token: 0x1700481C RID: 18460
		// (get) Token: 0x060159E0 RID: 88544 RVA: 0x00323C5C File Offset: 0x00321E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700481D RID: 18461
		// (get) Token: 0x060159E1 RID: 88545 RVA: 0x00323C5F File Offset: 0x00321E5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResEndingRewardRequest.Descriptor;
			}
		}

		// Token: 0x060159E2 RID: 88546 RVA: 0x00323C66 File Offset: 0x00321E66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResEndingRewardRequest()
		{
		}

		// Token: 0x060159E3 RID: 88547 RVA: 0x00323C6E File Offset: 0x00321E6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResEndingRewardRequest(RogueResEndingRewardRequest other) : this()
		{
			this.seasonId_ = other.seasonId_;
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060159E4 RID: 88548 RVA: 0x00323C9F File Offset: 0x00321E9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResEndingRewardRequest Clone()
		{
			return new RogueResEndingRewardRequest(this);
		}

		// Token: 0x1700481E RID: 18462
		// (get) Token: 0x060159E5 RID: 88549 RVA: 0x00323CA7 File Offset: 0x00321EA7
		// (set) Token: 0x060159E6 RID: 88550 RVA: 0x00323CAF File Offset: 0x00321EAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SeasonId
		{
			get
			{
				return this.seasonId_;
			}
			set
			{
				this.seasonId_ = value;
			}
		}

		// Token: 0x1700481F RID: 18463
		// (get) Token: 0x060159E7 RID: 88551 RVA: 0x00323CB8 File Offset: 0x00321EB8
		// (set) Token: 0x060159E8 RID: 88552 RVA: 0x00323CC0 File Offset: 0x00321EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x060159E9 RID: 88553 RVA: 0x00323CC9 File Offset: 0x00321EC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResEndingRewardRequest);
		}

		// Token: 0x060159EA RID: 88554 RVA: 0x00323CD7 File Offset: 0x00321ED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResEndingRewardRequest other)
		{
			return other != null && (other == this || (this.SeasonId == other.SeasonId && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060159EB RID: 88555 RVA: 0x00323D18 File Offset: 0x00321F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SeasonId != 0)
			{
				num ^= this.SeasonId.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060159EC RID: 88556 RVA: 0x00323D70 File Offset: 0x00321F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060159ED RID: 88557 RVA: 0x00323D7D File Offset: 0x00321F7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060159EE RID: 88558 RVA: 0x00323D88 File Offset: 0x00321F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SeasonId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SeasonId);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060159EF RID: 88559 RVA: 0x00323DE4 File Offset: 0x00321FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SeasonId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SeasonId);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060159F0 RID: 88560 RVA: 0x00323E3C File Offset: 0x0032203C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResEndingRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SeasonId != 0)
			{
				this.SeasonId = other.SeasonId;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060159F1 RID: 88561 RVA: 0x00323E8C File Offset: 0x0032208C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060159F2 RID: 88562 RVA: 0x00323E98 File Offset: 0x00322098
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
				if (num != 24U)
				{
					if (num != 32U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Index = input.ReadInt32();
					}
				}
				else
				{
					this.SeasonId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400823F RID: 33343
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008240 RID: 33344
		public const int SeasonIdFieldNumber = 3;

		// Token: 0x04008241 RID: 33345
		private int seasonId_;

		// Token: 0x04008242 RID: 33346
		public const int IndexFieldNumber = 4;

		// Token: 0x04008243 RID: 33347
		private int index_;
	}
}
