using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000068 RID: 104
	[NetMessage(EMessageId.AchievementUpdateResponse)]
	public sealed class AchievementUpdateResponse : IMessage<AchievementUpdateResponse>, IMessage, IEquatable<AchievementUpdateResponse>, IDeepCloneable<AchievementUpdateResponse>, IBufferMessage
	{
		// Token: 0x060016AE RID: 5806 RVA: 0x0003B6DA File Offset: 0x000398DA
		[NullableContext(1)]
		public static AchievementUpdateResponse Create()
		{
			return new AchievementUpdateResponse();
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060016AF RID: 5807 RVA: 0x0003B6E1 File Offset: 0x000398E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060016B0 RID: 5808 RVA: 0x0003B6E4 File Offset: 0x000398E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AchievementUpdateResponse.Descriptor;
			}
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x0003B6EB File Offset: 0x000398EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementUpdateResponse()
		{
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x0003B6FE File Offset: 0x000398FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementUpdateResponse(AchievementUpdateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.achievementEntryList_ = other.achievementEntryList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x0003B734 File Offset: 0x00039934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementUpdateResponse Clone()
		{
			return new AchievementUpdateResponse(this);
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060016B4 RID: 5812 RVA: 0x0003B73C File Offset: 0x0003993C
		// (set) Token: 0x060016B5 RID: 5813 RVA: 0x0003B744 File Offset: 0x00039944
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

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060016B6 RID: 5814 RVA: 0x0003B74D File Offset: 0x0003994D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AchievementEntry> AchievementEntryList
		{
			get
			{
				return this.achievementEntryList_;
			}
		}

		// Token: 0x060016B7 RID: 5815 RVA: 0x0003B755 File Offset: 0x00039955
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AchievementUpdateResponse);
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x0003B764 File Offset: 0x00039964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AchievementUpdateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.achievementEntryList_.Equals(other.achievementEntryList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060016B9 RID: 5817 RVA: 0x0003B7B4 File Offset: 0x000399B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.achievementEntryList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060016BA RID: 5818 RVA: 0x0003B807 File Offset: 0x00039A07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060016BB RID: 5819 RVA: 0x0003B814 File Offset: 0x00039A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x0003B820 File Offset: 0x00039A20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.achievementEntryList_.WriteTo(ref output, AchievementUpdateResponse._repeated_achievementEntryList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060016BD RID: 5821 RVA: 0x0003B870 File Offset: 0x00039A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.achievementEntryList_.CalculateSize(AchievementUpdateResponse._repeated_achievementEntryList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060016BE RID: 5822 RVA: 0x0003B8C4 File Offset: 0x00039AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AchievementUpdateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.achievementEntryList_.Add(other.achievementEntryList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060016BF RID: 5823 RVA: 0x0003B911 File Offset: 0x00039B11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x0003B91C File Offset: 0x00039B1C
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
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.achievementEntryList_.AddEntriesFrom(ref input, AchievementUpdateResponse._repeated_achievementEntryList_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040020F0 RID: 8432
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020F1 RID: 8433
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x040020F2 RID: 8434
		private ErrorCode errorCode_;

		// Token: 0x040020F3 RID: 8435
		public const int AchievementEntryListFieldNumber = 12;

		// Token: 0x040020F4 RID: 8436
		private static readonly FieldCodec<AchievementEntry> _repeated_achievementEntryList_codec = FieldCodec.ForMessage<AchievementEntry>(98U, AchievementEntry.Parser);

		// Token: 0x040020F5 RID: 8437
		private readonly RepeatedField<AchievementEntry> achievementEntryList_ = new RepeatedField<AchievementEntry>();
	}
}
