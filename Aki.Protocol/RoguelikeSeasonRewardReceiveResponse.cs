using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FBA RID: 4026
	[NetMessage(EMessageId.RoguelikeSeasonRewardReceiveResponse)]
	public sealed class RoguelikeSeasonRewardReceiveResponse : IMessage<RoguelikeSeasonRewardReceiveResponse>, IMessage, IEquatable<RoguelikeSeasonRewardReceiveResponse>, IDeepCloneable<RoguelikeSeasonRewardReceiveResponse>, IBufferMessage
	{
		// Token: 0x06015867 RID: 88167 RVA: 0x0031FD84 File Offset: 0x0031DF84
		[NullableContext(1)]
		public static RoguelikeSeasonRewardReceiveResponse Create()
		{
			return new RoguelikeSeasonRewardReceiveResponse();
		}

		// Token: 0x170047C4 RID: 18372
		// (get) Token: 0x06015868 RID: 88168 RVA: 0x0031FD8B File Offset: 0x0031DF8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170047C5 RID: 18373
		// (get) Token: 0x06015869 RID: 88169 RVA: 0x0031FD8E File Offset: 0x0031DF8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeSeasonRewardReceiveResponse.Descriptor;
			}
		}

		// Token: 0x0601586A RID: 88170 RVA: 0x0031FD95 File Offset: 0x0031DF95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeSeasonRewardReceiveResponse()
		{
		}

		// Token: 0x0601586B RID: 88171 RVA: 0x0031FDA8 File Offset: 0x0031DFA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeSeasonRewardReceiveResponse(RoguelikeSeasonRewardReceiveResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.itemMap_ = other.itemMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601586C RID: 88172 RVA: 0x0031FDDE File Offset: 0x0031DFDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeSeasonRewardReceiveResponse Clone()
		{
			return new RoguelikeSeasonRewardReceiveResponse(this);
		}

		// Token: 0x170047C6 RID: 18374
		// (get) Token: 0x0601586D RID: 88173 RVA: 0x0031FDE6 File Offset: 0x0031DFE6
		// (set) Token: 0x0601586E RID: 88174 RVA: 0x0031FDEE File Offset: 0x0031DFEE
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

		// Token: 0x170047C7 RID: 18375
		// (get) Token: 0x0601586F RID: 88175 RVA: 0x0031FDF7 File Offset: 0x0031DFF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ItemMap
		{
			get
			{
				return this.itemMap_;
			}
		}

		// Token: 0x06015870 RID: 88176 RVA: 0x0031FDFF File Offset: 0x0031DFFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeSeasonRewardReceiveResponse);
		}

		// Token: 0x06015871 RID: 88177 RVA: 0x0031FE10 File Offset: 0x0031E010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeSeasonRewardReceiveResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ItemMap.Equals(other.ItemMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015872 RID: 88178 RVA: 0x0031FE60 File Offset: 0x0031E060
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

		// Token: 0x06015873 RID: 88179 RVA: 0x0031FEB3 File Offset: 0x0031E0B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015874 RID: 88180 RVA: 0x0031FEC0 File Offset: 0x0031E0C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015875 RID: 88181 RVA: 0x0031FECC File Offset: 0x0031E0CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemMap_.WriteTo(ref output, RoguelikeSeasonRewardReceiveResponse._map_itemMap_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015876 RID: 88182 RVA: 0x0031FF1C File Offset: 0x0031E11C
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

		// Token: 0x06015877 RID: 88183 RVA: 0x0031FF70 File Offset: 0x0031E170
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

		// Token: 0x06015878 RID: 88184 RVA: 0x0031FFBD File Offset: 0x0031E1BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015879 RID: 88185 RVA: 0x0031FFC8 File Offset: 0x0031E1C8
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
				if (num != 74U)
				{
					if (num != 112U)
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

		// Token: 0x0400815B RID: 33115
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400815C RID: 33116
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x0400815D RID: 33117
		private ErrorCode errorCode_;

		// Token: 0x0400815E RID: 33118
		public const int ItemMapFieldNumber = 9;

		// Token: 0x0400815F RID: 33119
		private static readonly MapField<int, int>.Codec _map_itemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 74U);

		// Token: 0x04008160 RID: 33120
		private readonly MapField<int, int> itemMap_ = new MapField<int, int>();
	}
}
