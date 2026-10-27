using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200112D RID: 4397
	[NetMessage(EMessageId.RoverRogueTalentUnlockNotify)]
	public sealed class RoverRogueTalentUnlockNotify : IMessage<RoverRogueTalentUnlockNotify>, IMessage, IEquatable<RoverRogueTalentUnlockNotify>, IDeepCloneable<RoverRogueTalentUnlockNotify>, IBufferMessage
	{
		// Token: 0x06017750 RID: 96080 RVA: 0x00368696 File Offset: 0x00366896
		[NullableContext(1)]
		public static RoverRogueTalentUnlockNotify Create()
		{
			return new RoverRogueTalentUnlockNotify();
		}

		// Token: 0x17004EBF RID: 20159
		// (get) Token: 0x06017751 RID: 96081 RVA: 0x0036869D File Offset: 0x0036689D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004EC0 RID: 20160
		// (get) Token: 0x06017752 RID: 96082 RVA: 0x003686A0 File Offset: 0x003668A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueTalentUnlockNotify.Descriptor;
			}
		}

		// Token: 0x06017753 RID: 96083 RVA: 0x003686A7 File Offset: 0x003668A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTalentUnlockNotify()
		{
		}

		// Token: 0x06017754 RID: 96084 RVA: 0x003686BA File Offset: 0x003668BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTalentUnlockNotify(RoverRogueTalentUnlockNotify other) : this()
		{
			this.talentIds_ = other.talentIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017755 RID: 96085 RVA: 0x003686E4 File Offset: 0x003668E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTalentUnlockNotify Clone()
		{
			return new RoverRogueTalentUnlockNotify(this);
		}

		// Token: 0x17004EC1 RID: 20161
		// (get) Token: 0x06017756 RID: 96086 RVA: 0x003686EC File Offset: 0x003668EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TalentIds
		{
			get
			{
				return this.talentIds_;
			}
		}

		// Token: 0x06017757 RID: 96087 RVA: 0x003686F4 File Offset: 0x003668F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueTalentUnlockNotify);
		}

		// Token: 0x06017758 RID: 96088 RVA: 0x00368702 File Offset: 0x00366902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueTalentUnlockNotify other)
		{
			return other != null && (other == this || (this.talentIds_.Equals(other.talentIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017759 RID: 96089 RVA: 0x00368738 File Offset: 0x00366938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.talentIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601775A RID: 96090 RVA: 0x0036876C File Offset: 0x0036696C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601775B RID: 96091 RVA: 0x00368779 File Offset: 0x00366979
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601775C RID: 96092 RVA: 0x00368782 File Offset: 0x00366982
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.talentIds_.WriteTo(ref output, RoverRogueTalentUnlockNotify._repeated_talentIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601775D RID: 96093 RVA: 0x003687AC File Offset: 0x003669AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.talentIds_.CalculateSize(RoverRogueTalentUnlockNotify._repeated_talentIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601775E RID: 96094 RVA: 0x003687E5 File Offset: 0x003669E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueTalentUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.talentIds_.Add(other.talentIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601775F RID: 96095 RVA: 0x00368813 File Offset: 0x00366A13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017760 RID: 96096 RVA: 0x0036881C File Offset: 0x00366A1C
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
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.talentIds_.AddEntriesFrom(ref input, RoverRogueTalentUnlockNotify._repeated_talentIds_codec);
				}
			}
		}

		// Token: 0x04008B83 RID: 35715
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008B84 RID: 35716
		public const int TalentIdsFieldNumber = 1;

		// Token: 0x04008B85 RID: 35717
		private static readonly FieldCodec<int> _repeated_talentIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04008B86 RID: 35718
		private readonly RepeatedField<int> talentIds_ = new RepeatedField<int>();
	}
}
