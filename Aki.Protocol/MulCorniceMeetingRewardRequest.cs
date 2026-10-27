using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AD8 RID: 2776
	[NetMessage(EMessageId.MulCorniceMeetingRewardRequest)]
	public sealed class MulCorniceMeetingRewardRequest : IMessage<MulCorniceMeetingRewardRequest>, IMessage, IEquatable<MulCorniceMeetingRewardRequest>, IDeepCloneable<MulCorniceMeetingRewardRequest>, IBufferMessage
	{
		// Token: 0x0600F199 RID: 61849 RVA: 0x00234ABC File Offset: 0x00232CBC
		[NullableContext(1)]
		public static MulCorniceMeetingRewardRequest Create()
		{
			return new MulCorniceMeetingRewardRequest();
		}

		// Token: 0x17003134 RID: 12596
		// (get) Token: 0x0600F19A RID: 61850 RVA: 0x00234AC3 File Offset: 0x00232CC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003135 RID: 12597
		// (get) Token: 0x0600F19B RID: 61851 RVA: 0x00234AC6 File Offset: 0x00232CC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MulCorniceMeetingRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600F19C RID: 61852 RVA: 0x00234ACD File Offset: 0x00232CCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulCorniceMeetingRewardRequest()
		{
		}

		// Token: 0x0600F19D RID: 61853 RVA: 0x00234AE0 File Offset: 0x00232CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulCorniceMeetingRewardRequest(MulCorniceMeetingRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.corniceMeetingRewardScoreLists_ = other.corniceMeetingRewardScoreLists_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F19E RID: 61854 RVA: 0x00234B16 File Offset: 0x00232D16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulCorniceMeetingRewardRequest Clone()
		{
			return new MulCorniceMeetingRewardRequest(this);
		}

		// Token: 0x17003136 RID: 12598
		// (get) Token: 0x0600F19F RID: 61855 RVA: 0x00234B1E File Offset: 0x00232D1E
		// (set) Token: 0x0600F1A0 RID: 61856 RVA: 0x00234B26 File Offset: 0x00232D26
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

		// Token: 0x17003137 RID: 12599
		// (get) Token: 0x0600F1A1 RID: 61857 RVA: 0x00234B2F File Offset: 0x00232D2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, CorniceMeetingRewardScoreList> CorniceMeetingRewardScoreLists
		{
			get
			{
				return this.corniceMeetingRewardScoreLists_;
			}
		}

		// Token: 0x0600F1A2 RID: 61858 RVA: 0x00234B37 File Offset: 0x00232D37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MulCorniceMeetingRewardRequest);
		}

		// Token: 0x0600F1A3 RID: 61859 RVA: 0x00234B48 File Offset: 0x00232D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MulCorniceMeetingRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.CorniceMeetingRewardScoreLists.Equals(other.CorniceMeetingRewardScoreLists) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F1A4 RID: 61860 RVA: 0x00234B98 File Offset: 0x00232D98
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

		// Token: 0x0600F1A5 RID: 61861 RVA: 0x00234BE5 File Offset: 0x00232DE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F1A6 RID: 61862 RVA: 0x00234BF2 File Offset: 0x00232DF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F1A7 RID: 61863 RVA: 0x00234BFC File Offset: 0x00232DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.corniceMeetingRewardScoreLists_.WriteTo(ref output, MulCorniceMeetingRewardRequest._map_corniceMeetingRewardScoreLists_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F1A8 RID: 61864 RVA: 0x00234C4C File Offset: 0x00232E4C
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

		// Token: 0x0600F1A9 RID: 61865 RVA: 0x00234CA0 File Offset: 0x00232EA0
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

		// Token: 0x0600F1AA RID: 61866 RVA: 0x00234CED File Offset: 0x00232EED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F1AB RID: 61867 RVA: 0x00234CF8 File Offset: 0x00232EF8
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
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.corniceMeetingRewardScoreLists_.AddEntriesFrom(ref input, MulCorniceMeetingRewardRequest._map_corniceMeetingRewardScoreLists_codec);
				}
			}
		}

		// Token: 0x04006195 RID: 24981
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006196 RID: 24982
		public const int ActivityIdFieldNumber = 15;

		// Token: 0x04006197 RID: 24983
		private int activityId_;

		// Token: 0x04006198 RID: 24984
		public const int CorniceMeetingRewardScoreListsFieldNumber = 3;

		// Token: 0x04006199 RID: 24985
		private static readonly MapField<int, CorniceMeetingRewardScoreList>.Codec _map_corniceMeetingRewardScoreLists_codec = new MapField<int, CorniceMeetingRewardScoreList>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<CorniceMeetingRewardScoreList>(18U, CorniceMeetingRewardScoreList.Parser), 26U);

		// Token: 0x0400619A RID: 24986
		private readonly MapField<int, CorniceMeetingRewardScoreList> corniceMeetingRewardScoreLists_ = new MapField<int, CorniceMeetingRewardScoreList>();
	}
}
