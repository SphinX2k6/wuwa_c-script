using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000063 RID: 99
	[NetMessage(EMessageId.AchievementListProgressNotify)]
	public sealed class AchievementListProgressNotify : IMessage<AchievementListProgressNotify>, IMessage, IEquatable<AchievementListProgressNotify>, IDeepCloneable<AchievementListProgressNotify>, IBufferMessage
	{
		// Token: 0x06001680 RID: 5760 RVA: 0x0003B2BB File Offset: 0x000394BB
		[NullableContext(1)]
		public static AchievementListProgressNotify Create()
		{
			return new AchievementListProgressNotify();
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06001681 RID: 5761 RVA: 0x0003B2C2 File Offset: 0x000394C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06001682 RID: 5762 RVA: 0x0003B2C5 File Offset: 0x000394C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AchievementListProgressNotify.Descriptor;
			}
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x0003B2CC File Offset: 0x000394CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementListProgressNotify()
		{
		}

		// Token: 0x06001684 RID: 5764 RVA: 0x0003B2DF File Offset: 0x000394DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementListProgressNotify(AchievementListProgressNotify other) : this()
		{
			this.achievementEntryList_ = other.achievementEntryList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x0003B309 File Offset: 0x00039509
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementListProgressNotify Clone()
		{
			return new AchievementListProgressNotify(this);
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06001686 RID: 5766 RVA: 0x0003B311 File Offset: 0x00039511
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AchievementEntry> AchievementEntryList
		{
			get
			{
				return this.achievementEntryList_;
			}
		}

		// Token: 0x06001687 RID: 5767 RVA: 0x0003B319 File Offset: 0x00039519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AchievementListProgressNotify);
		}

		// Token: 0x06001688 RID: 5768 RVA: 0x0003B327 File Offset: 0x00039527
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AchievementListProgressNotify other)
		{
			return other != null && (other == this || (this.achievementEntryList_.Equals(other.achievementEntryList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001689 RID: 5769 RVA: 0x0003B35C File Offset: 0x0003955C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.achievementEntryList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600168A RID: 5770 RVA: 0x0003B390 File Offset: 0x00039590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600168B RID: 5771 RVA: 0x0003B39D File Offset: 0x0003959D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600168C RID: 5772 RVA: 0x0003B3A6 File Offset: 0x000395A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.achievementEntryList_.WriteTo(ref output, AchievementListProgressNotify._repeated_achievementEntryList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600168D RID: 5773 RVA: 0x0003B3D0 File Offset: 0x000395D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.achievementEntryList_.CalculateSize(AchievementListProgressNotify._repeated_achievementEntryList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x0003B409 File Offset: 0x00039609
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AchievementListProgressNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.achievementEntryList_.Add(other.achievementEntryList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600168F RID: 5775 RVA: 0x0003B437 File Offset: 0x00039637
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001690 RID: 5776 RVA: 0x0003B440 File Offset: 0x00039640
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.achievementEntryList_.AddEntriesFrom(ref input, AchievementListProgressNotify._repeated_achievementEntryList_codec);
				}
			}
		}

		// Token: 0x04002134 RID: 8500
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002135 RID: 8501
		public const int AchievementEntryListFieldNumber = 2;

		// Token: 0x04002136 RID: 8502
		private static readonly FieldCodec<AchievementEntry> _repeated_achievementEntryList_codec = FieldCodec.ForMessage<AchievementEntry>(18U, AchievementEntry.Parser);

		// Token: 0x04002137 RID: 8503
		private readonly RepeatedField<AchievementEntry> achievementEntryList_ = new RepeatedField<AchievementEntry>();
	}
}
