using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000069 RID: 105
	[NetMessage(EMessageId.AchievementUpdateResponse)]
	public sealed class AchievementUpdateResponse : IMessage<AchievementUpdateResponse>, IMessage, IEquatable<AchievementUpdateResponse>, IDeepCloneable<AchievementUpdateResponse>, IBufferMessage
	{
		// Token: 0x060016F1 RID: 5873 RVA: 0x0003C07E File Offset: 0x0003A27E
		[NullableContext(1)]
		public static AchievementUpdateResponse Create()
		{
			return new AchievementUpdateResponse();
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060016F2 RID: 5874 RVA: 0x0003C085 File Offset: 0x0003A285
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060016F3 RID: 5875 RVA: 0x0003C088 File Offset: 0x0003A288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AchievementUpdateResponse.Descriptor;
			}
		}

		// Token: 0x060016F4 RID: 5876 RVA: 0x0003C08F File Offset: 0x0003A28F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementUpdateResponse()
		{
		}

		// Token: 0x060016F5 RID: 5877 RVA: 0x0003C0A2 File Offset: 0x0003A2A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementUpdateResponse(AchievementUpdateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.achievementEntryList_ = other.achievementEntryList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060016F6 RID: 5878 RVA: 0x0003C0D8 File Offset: 0x0003A2D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementUpdateResponse Clone()
		{
			return new AchievementUpdateResponse(this);
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060016F7 RID: 5879 RVA: 0x0003C0E0 File Offset: 0x0003A2E0
		// (set) Token: 0x060016F8 RID: 5880 RVA: 0x0003C0E8 File Offset: 0x0003A2E8
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

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060016F9 RID: 5881 RVA: 0x0003C0F1 File Offset: 0x0003A2F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AchievementEntry> AchievementEntryList
		{
			get
			{
				return this.achievementEntryList_;
			}
		}

		// Token: 0x060016FA RID: 5882 RVA: 0x0003C0F9 File Offset: 0x0003A2F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AchievementUpdateResponse);
		}

		// Token: 0x060016FB RID: 5883 RVA: 0x0003C108 File Offset: 0x0003A308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AchievementUpdateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.achievementEntryList_.Equals(other.achievementEntryList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060016FC RID: 5884 RVA: 0x0003C158 File Offset: 0x0003A358
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

		// Token: 0x060016FD RID: 5885 RVA: 0x0003C1AB File Offset: 0x0003A3AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060016FE RID: 5886 RVA: 0x0003C1B8 File Offset: 0x0003A3B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060016FF RID: 5887 RVA: 0x0003C1C4 File Offset: 0x0003A3C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.achievementEntryList_.WriteTo(ref output, AchievementUpdateResponse._repeated_achievementEntryList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001700 RID: 5888 RVA: 0x0003C214 File Offset: 0x0003A414
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

		// Token: 0x06001701 RID: 5889 RVA: 0x0003C268 File Offset: 0x0003A468
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

		// Token: 0x06001702 RID: 5890 RVA: 0x0003C2B5 File Offset: 0x0003A4B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001703 RID: 5891 RVA: 0x0003C2C0 File Offset: 0x0003A4C0
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
				if (num != 16U)
				{
					if (num != 90U)
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

		// Token: 0x0400214F RID: 8527
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002150 RID: 8528
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04002151 RID: 8529
		private ErrorCode errorCode_;

		// Token: 0x04002152 RID: 8530
		public const int AchievementEntryListFieldNumber = 11;

		// Token: 0x04002153 RID: 8531
		private static readonly FieldCodec<AchievementEntry> _repeated_achievementEntryList_codec = FieldCodec.ForMessage<AchievementEntry>(90U, AchievementEntry.Parser);

		// Token: 0x04002154 RID: 8532
		private readonly RepeatedField<AchievementEntry> achievementEntryList_ = new RepeatedField<AchievementEntry>();
	}
}
