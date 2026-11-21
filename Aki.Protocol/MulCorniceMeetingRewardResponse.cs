using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AC8 RID: 2760
	[NetMessage(EMessageId.MulCorniceMeetingRewardResponse)]
	public sealed class MulCorniceMeetingRewardResponse : IMessage<MulCorniceMeetingRewardResponse>, IMessage, IEquatable<MulCorniceMeetingRewardResponse>, IDeepCloneable<MulCorniceMeetingRewardResponse>, IBufferMessage
	{
		// Token: 0x0600F093 RID: 61587 RVA: 0x00232B6A File Offset: 0x00230D6A
		[NullableContext(1)]
		public static MulCorniceMeetingRewardResponse Create()
		{
			return new MulCorniceMeetingRewardResponse();
		}

		// Token: 0x170030FA RID: 12538
		// (get) Token: 0x0600F094 RID: 61588 RVA: 0x00232B71 File Offset: 0x00230D71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170030FB RID: 12539
		// (get) Token: 0x0600F095 RID: 61589 RVA: 0x00232B74 File Offset: 0x00230D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MulCorniceMeetingRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600F096 RID: 61590 RVA: 0x00232B7B File Offset: 0x00230D7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulCorniceMeetingRewardResponse()
		{
		}

		// Token: 0x0600F097 RID: 61591 RVA: 0x00232B8E File Offset: 0x00230D8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulCorniceMeetingRewardResponse(MulCorniceMeetingRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.corniceMeetingRewardScoreLists_ = other.corniceMeetingRewardScoreLists_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F098 RID: 61592 RVA: 0x00232BC4 File Offset: 0x00230DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulCorniceMeetingRewardResponse Clone()
		{
			return new MulCorniceMeetingRewardResponse(this);
		}

		// Token: 0x170030FC RID: 12540
		// (get) Token: 0x0600F099 RID: 61593 RVA: 0x00232BCC File Offset: 0x00230DCC
		// (set) Token: 0x0600F09A RID: 61594 RVA: 0x00232BD4 File Offset: 0x00230DD4
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

		// Token: 0x170030FD RID: 12541
		// (get) Token: 0x0600F09B RID: 61595 RVA: 0x00232BDD File Offset: 0x00230DDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, CorniceMeetingRewardScoreList> CorniceMeetingRewardScoreLists
		{
			get
			{
				return this.corniceMeetingRewardScoreLists_;
			}
		}

		// Token: 0x0600F09C RID: 61596 RVA: 0x00232BE5 File Offset: 0x00230DE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MulCorniceMeetingRewardResponse);
		}

		// Token: 0x0600F09D RID: 61597 RVA: 0x00232BF4 File Offset: 0x00230DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MulCorniceMeetingRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.CorniceMeetingRewardScoreLists.Equals(other.CorniceMeetingRewardScoreLists) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F09E RID: 61598 RVA: 0x00232C44 File Offset: 0x00230E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.CorniceMeetingRewardScoreLists.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F09F RID: 61599 RVA: 0x00232C97 File Offset: 0x00230E97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F0A0 RID: 61600 RVA: 0x00232CA4 File Offset: 0x00230EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F0A1 RID: 61601 RVA: 0x00232CB0 File Offset: 0x00230EB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.corniceMeetingRewardScoreLists_.WriteTo(ref output, MulCorniceMeetingRewardResponse._map_corniceMeetingRewardScoreLists_codec);
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

		// Token: 0x0600F0A2 RID: 61602 RVA: 0x00232D00 File Offset: 0x00230F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.corniceMeetingRewardScoreLists_.CalculateSize(MulCorniceMeetingRewardResponse._map_corniceMeetingRewardScoreLists_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F0A3 RID: 61603 RVA: 0x00232D54 File Offset: 0x00230F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MulCorniceMeetingRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.corniceMeetingRewardScoreLists_.MergeFrom(other.corniceMeetingRewardScoreLists_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F0A4 RID: 61604 RVA: 0x00232DA1 File Offset: 0x00230FA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F0A5 RID: 61605 RVA: 0x00232DAC File Offset: 0x00230FAC
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
				if (num != 90U)
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
					this.corniceMeetingRewardScoreLists_.AddEntriesFrom(ref input, MulCorniceMeetingRewardResponse._map_corniceMeetingRewardScoreLists_codec);
				}
			}
		}

		// Token: 0x040061A4 RID: 24996
		private UnknownFieldSet _unknownFields;

		// Token: 0x040061A5 RID: 24997
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x040061A6 RID: 24998
		private ErrorCode errorCode_;

		// Token: 0x040061A7 RID: 24999
		public const int CorniceMeetingRewardScoreListsFieldNumber = 11;

		// Token: 0x040061A8 RID: 25000
		private static readonly MapField<int, CorniceMeetingRewardScoreList>.Codec _map_corniceMeetingRewardScoreLists_codec = new MapField<int, CorniceMeetingRewardScoreList>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<CorniceMeetingRewardScoreList>(18U, CorniceMeetingRewardScoreList.Parser), 90U);

		// Token: 0x040061A9 RID: 25001
		private readonly MapField<int, CorniceMeetingRewardScoreList> corniceMeetingRewardScoreLists_ = new MapField<int, CorniceMeetingRewardScoreList>();
	}
}
