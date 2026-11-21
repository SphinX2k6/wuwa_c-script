using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AC7 RID: 2759
	[NetMessage(EMessageId.MulCorniceMeetingRewardRequest)]
	public sealed class MulCorniceMeetingRewardRequest : IMessage<MulCorniceMeetingRewardRequest>, IMessage, IEquatable<MulCorniceMeetingRewardRequest>, IDeepCloneable<MulCorniceMeetingRewardRequest>, IBufferMessage
	{
		// Token: 0x0600F07F RID: 61567 RVA: 0x002328B0 File Offset: 0x00230AB0
		[NullableContext(1)]
		public static MulCorniceMeetingRewardRequest Create()
		{
			return new MulCorniceMeetingRewardRequest();
		}

		// Token: 0x170030F6 RID: 12534
		// (get) Token: 0x0600F080 RID: 61568 RVA: 0x002328B7 File Offset: 0x00230AB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170030F7 RID: 12535
		// (get) Token: 0x0600F081 RID: 61569 RVA: 0x002328BA File Offset: 0x00230ABA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MulCorniceMeetingRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600F082 RID: 61570 RVA: 0x002328C1 File Offset: 0x00230AC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulCorniceMeetingRewardRequest()
		{
		}

		// Token: 0x0600F083 RID: 61571 RVA: 0x002328D4 File Offset: 0x00230AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulCorniceMeetingRewardRequest(MulCorniceMeetingRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.corniceMeetingRewardScoreLists_ = other.corniceMeetingRewardScoreLists_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F084 RID: 61572 RVA: 0x0023290A File Offset: 0x00230B0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulCorniceMeetingRewardRequest Clone()
		{
			return new MulCorniceMeetingRewardRequest(this);
		}

		// Token: 0x170030F8 RID: 12536
		// (get) Token: 0x0600F085 RID: 61573 RVA: 0x00232912 File Offset: 0x00230B12
		// (set) Token: 0x0600F086 RID: 61574 RVA: 0x0023291A File Offset: 0x00230B1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x170030F9 RID: 12537
		// (get) Token: 0x0600F087 RID: 61575 RVA: 0x00232923 File Offset: 0x00230B23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, CorniceMeetingRewardScoreList> CorniceMeetingRewardScoreLists
		{
			get
			{
				return this.corniceMeetingRewardScoreLists_;
			}
		}

		// Token: 0x0600F088 RID: 61576 RVA: 0x0023292B File Offset: 0x00230B2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MulCorniceMeetingRewardRequest);
		}

		// Token: 0x0600F089 RID: 61577 RVA: 0x0023293C File Offset: 0x00230B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MulCorniceMeetingRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.CorniceMeetingRewardScoreLists.Equals(other.CorniceMeetingRewardScoreLists) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F08A RID: 61578 RVA: 0x0023298C File Offset: 0x00230B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.CorniceMeetingRewardScoreLists.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F08B RID: 61579 RVA: 0x002329D9 File Offset: 0x00230BD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F08C RID: 61580 RVA: 0x002329E6 File Offset: 0x00230BE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F08D RID: 61581 RVA: 0x002329F0 File Offset: 0x00230BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ActivityId);
			}
			this.corniceMeetingRewardScoreLists_.WriteTo(ref output, MulCorniceMeetingRewardRequest._map_corniceMeetingRewardScoreLists_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F08E RID: 61582 RVA: 0x00232A40 File Offset: 0x00230C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.corniceMeetingRewardScoreLists_.CalculateSize(MulCorniceMeetingRewardRequest._map_corniceMeetingRewardScoreLists_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F08F RID: 61583 RVA: 0x00232A94 File Offset: 0x00230C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MulCorniceMeetingRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.corniceMeetingRewardScoreLists_.MergeFrom(other.corniceMeetingRewardScoreLists_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F090 RID: 61584 RVA: 0x00232AE1 File Offset: 0x00230CE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F091 RID: 61585 RVA: 0x00232AEC File Offset: 0x00230CEC
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
				if (num != 80U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.corniceMeetingRewardScoreLists_.AddEntriesFrom(ref input, MulCorniceMeetingRewardRequest._map_corniceMeetingRewardScoreLists_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400619E RID: 24990
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400619F RID: 24991
		public const int ActivityIdFieldNumber = 10;

		// Token: 0x040061A0 RID: 24992
		private int activityId_;

		// Token: 0x040061A1 RID: 24993
		public const int CorniceMeetingRewardScoreListsFieldNumber = 13;

		// Token: 0x040061A2 RID: 24994
		private static readonly MapField<int, CorniceMeetingRewardScoreList>.Codec _map_corniceMeetingRewardScoreLists_codec = new MapField<int, CorniceMeetingRewardScoreList>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<CorniceMeetingRewardScoreList>(18U, CorniceMeetingRewardScoreList.Parser), 106U);

		// Token: 0x040061A3 RID: 24995
		private readonly MapField<int, CorniceMeetingRewardScoreList> corniceMeetingRewardScoreLists_ = new MapField<int, CorniceMeetingRewardScoreList>();
	}
}
