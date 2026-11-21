using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FAA RID: 4010
	[NetMessage(EMessageId.RoguelikeSeasonRewardReceiveResponse)]
	public sealed class RoguelikeSeasonRewardReceiveResponse : IMessage<RoguelikeSeasonRewardReceiveResponse>, IMessage, IEquatable<RoguelikeSeasonRewardReceiveResponse>, IDeepCloneable<RoguelikeSeasonRewardReceiveResponse>, IBufferMessage
	{
		// Token: 0x06015782 RID: 87938 RVA: 0x0031E6D7 File Offset: 0x0031C8D7
		[NullableContext(1)]
		public static RoguelikeSeasonRewardReceiveResponse Create()
		{
			return new RoguelikeSeasonRewardReceiveResponse();
		}

		// Token: 0x1700479A RID: 18330
		// (get) Token: 0x06015783 RID: 87939 RVA: 0x0031E6DE File Offset: 0x0031C8DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700479B RID: 18331
		// (get) Token: 0x06015784 RID: 87940 RVA: 0x0031E6E1 File Offset: 0x0031C8E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeSeasonRewardReceiveResponse.Descriptor;
			}
		}

		// Token: 0x06015785 RID: 87941 RVA: 0x0031E6E8 File Offset: 0x0031C8E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeSeasonRewardReceiveResponse()
		{
		}

		// Token: 0x06015786 RID: 87942 RVA: 0x0031E6FB File Offset: 0x0031C8FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeSeasonRewardReceiveResponse(RoguelikeSeasonRewardReceiveResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.itemMap_ = other.itemMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015787 RID: 87943 RVA: 0x0031E731 File Offset: 0x0031C931
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeSeasonRewardReceiveResponse Clone()
		{
			return new RoguelikeSeasonRewardReceiveResponse(this);
		}

		// Token: 0x1700479C RID: 18332
		// (get) Token: 0x06015788 RID: 87944 RVA: 0x0031E739 File Offset: 0x0031C939
		// (set) Token: 0x06015789 RID: 87945 RVA: 0x0031E741 File Offset: 0x0031C941
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x1700479D RID: 18333
		// (get) Token: 0x0601578A RID: 87946 RVA: 0x0031E74A File Offset: 0x0031C94A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ItemMap
		{
			get
			{
				return this.itemMap_;
			}
		}

		// Token: 0x0601578B RID: 87947 RVA: 0x0031E752 File Offset: 0x0031C952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeSeasonRewardReceiveResponse);
		}

		// Token: 0x0601578C RID: 87948 RVA: 0x0031E760 File Offset: 0x0031C960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeSeasonRewardReceiveResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ItemMap.Equals(other.ItemMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601578D RID: 87949 RVA: 0x0031E7B0 File Offset: 0x0031C9B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.ItemMap.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601578E RID: 87950 RVA: 0x0031E803 File Offset: 0x0031CA03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601578F RID: 87951 RVA: 0x0031E810 File Offset: 0x0031CA10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015790 RID: 87952 RVA: 0x0031E81C File Offset: 0x0031CA1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemMap_.WriteTo(ref output, RoguelikeSeasonRewardReceiveResponse._map_itemMap_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015791 RID: 87953 RVA: 0x0031E86C File Offset: 0x0031CA6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.itemMap_.CalculateSize(RoguelikeSeasonRewardReceiveResponse._map_itemMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015792 RID: 87954 RVA: 0x0031E8C0 File Offset: 0x0031CAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeSeasonRewardReceiveResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.itemMap_.MergeFrom(other.itemMap_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015793 RID: 87955 RVA: 0x0031E90D File Offset: 0x0031CB0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015794 RID: 87956 RVA: 0x0031E918 File Offset: 0x0031CB18
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
				if (num != 10U)
				{
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.itemMap_.AddEntriesFrom(ref input, RoguelikeSeasonRewardReceiveResponse._map_itemMap_codec);
				}
			}
		}

		// Token: 0x04008185 RID: 33157
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008186 RID: 33158
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04008187 RID: 33159
		private ErrorCode errorCode_;

		// Token: 0x04008188 RID: 33160
		public const int ItemMapFieldNumber = 1;

		// Token: 0x04008189 RID: 33161
		private static readonly MapField<int, int>.Codec _map_itemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 10U);

		// Token: 0x0400818A RID: 33162
		private readonly MapField<int, int> itemMap_ = new MapField<int, int>();
	}
}
