using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AD4 RID: 2772
	[NetMessage(EMessageId.MulAchievementReceiveRequest)]
	public sealed class MulAchievementReceiveRequest : IMessage<MulAchievementReceiveRequest>, IMessage, IEquatable<MulAchievementReceiveRequest>, IDeepCloneable<MulAchievementReceiveRequest>, IBufferMessage
	{
		// Token: 0x0600F14B RID: 61771 RVA: 0x0023402F File Offset: 0x0023222F
		[NullableContext(1)]
		public static MulAchievementReceiveRequest Create()
		{
			return new MulAchievementReceiveRequest();
		}

		// Token: 0x17003124 RID: 12580
		// (get) Token: 0x0600F14C RID: 61772 RVA: 0x00234036 File Offset: 0x00232236
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003125 RID: 12581
		// (get) Token: 0x0600F14D RID: 61773 RVA: 0x00234039 File Offset: 0x00232239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MulAchievementReceiveRequest.Descriptor;
			}
		}

		// Token: 0x0600F14E RID: 61774 RVA: 0x00234040 File Offset: 0x00232240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulAchievementReceiveRequest()
		{
		}

		// Token: 0x0600F14F RID: 61775 RVA: 0x0023405E File Offset: 0x0023225E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulAchievementReceiveRequest(MulAchievementReceiveRequest other) : this()
		{
			this.achievementIds_ = other.achievementIds_.Clone();
			this.achievementGroupIds_ = other.achievementGroupIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F150 RID: 61776 RVA: 0x00234099 File Offset: 0x00232299
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulAchievementReceiveRequest Clone()
		{
			return new MulAchievementReceiveRequest(this);
		}

		// Token: 0x17003126 RID: 12582
		// (get) Token: 0x0600F151 RID: 61777 RVA: 0x002340A1 File Offset: 0x002322A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> AchievementIds
		{
			get
			{
				return this.achievementIds_;
			}
		}

		// Token: 0x17003127 RID: 12583
		// (get) Token: 0x0600F152 RID: 61778 RVA: 0x002340A9 File Offset: 0x002322A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> AchievementGroupIds
		{
			get
			{
				return this.achievementGroupIds_;
			}
		}

		// Token: 0x0600F153 RID: 61779 RVA: 0x002340B1 File Offset: 0x002322B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MulAchievementReceiveRequest);
		}

		// Token: 0x0600F154 RID: 61780 RVA: 0x002340C0 File Offset: 0x002322C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MulAchievementReceiveRequest other)
		{
			return other != null && (other == this || (this.achievementIds_.Equals(other.achievementIds_) && this.achievementGroupIds_.Equals(other.achievementGroupIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F155 RID: 61781 RVA: 0x00234114 File Offset: 0x00232314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.achievementIds_.GetHashCode();
			num ^= this.achievementGroupIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F156 RID: 61782 RVA: 0x00234156 File Offset: 0x00232356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F157 RID: 61783 RVA: 0x00234163 File Offset: 0x00232363
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F158 RID: 61784 RVA: 0x0023416C File Offset: 0x0023236C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.achievementIds_.WriteTo(ref output, MulAchievementReceiveRequest._repeated_achievementIds_codec);
			this.achievementGroupIds_.WriteTo(ref output, MulAchievementReceiveRequest._repeated_achievementGroupIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F159 RID: 61785 RVA: 0x002341A4 File Offset: 0x002323A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.achievementIds_.CalculateSize(MulAchievementReceiveRequest._repeated_achievementIds_codec);
			num += this.achievementGroupIds_.CalculateSize(MulAchievementReceiveRequest._repeated_achievementGroupIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F15A RID: 61786 RVA: 0x002341F0 File Offset: 0x002323F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MulAchievementReceiveRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.achievementIds_.Add(other.achievementIds_);
			this.achievementGroupIds_.Add(other.achievementGroupIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F15B RID: 61787 RVA: 0x0023422F File Offset: 0x0023242F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F15C RID: 61788 RVA: 0x00234238 File Offset: 0x00232438
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
				if (num <= 10U)
				{
					if (num == 8U || num == 10U)
					{
						this.achievementIds_.AddEntriesFrom(ref input, MulAchievementReceiveRequest._repeated_achievementIds_codec);
						continue;
					}
				}
				else if (num == 16U || num == 18U)
				{
					this.achievementGroupIds_.AddEntriesFrom(ref input, MulAchievementReceiveRequest._repeated_achievementGroupIds_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400617B RID: 24955
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400617C RID: 24956
		public const int AchievementIdsFieldNumber = 1;

		// Token: 0x0400617D RID: 24957
		private static readonly FieldCodec<int> _repeated_achievementIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x0400617E RID: 24958
		private readonly RepeatedField<int> achievementIds_ = new RepeatedField<int>();

		// Token: 0x0400617F RID: 24959
		public const int AchievementGroupIdsFieldNumber = 2;

		// Token: 0x04006180 RID: 24960
		private static readonly FieldCodec<int> _repeated_achievementGroupIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04006181 RID: 24961
		private readonly RepeatedField<int> achievementGroupIds_ = new RepeatedField<int>();
	}
}
