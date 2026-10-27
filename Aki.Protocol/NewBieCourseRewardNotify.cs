using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B08 RID: 2824
	[NetMessage(EMessageId.NewBieCourseRewardNotify)]
	public sealed class NewBieCourseRewardNotify : IMessage<NewBieCourseRewardNotify>, IMessage, IEquatable<NewBieCourseRewardNotify>, IDeepCloneable<NewBieCourseRewardNotify>, IBufferMessage
	{
		// Token: 0x0600F562 RID: 62818 RVA: 0x0023CEA4 File Offset: 0x0023B0A4
		[NullableContext(1)]
		public static NewBieCourseRewardNotify Create()
		{
			return new NewBieCourseRewardNotify();
		}

		// Token: 0x170031FB RID: 12795
		// (get) Token: 0x0600F563 RID: 62819 RVA: 0x0023CEAB File Offset: 0x0023B0AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031FC RID: 12796
		// (get) Token: 0x0600F564 RID: 62820 RVA: 0x0023CEAE File Offset: 0x0023B0AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewBieCourseRewardNotify.Descriptor;
			}
		}

		// Token: 0x0600F565 RID: 62821 RVA: 0x0023CEB5 File Offset: 0x0023B0B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewBieCourseRewardNotify()
		{
		}

		// Token: 0x0600F566 RID: 62822 RVA: 0x0023CEC8 File Offset: 0x0023B0C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewBieCourseRewardNotify(NewBieCourseRewardNotify other) : this()
		{
			this.hadTakeReward_ = other.hadTakeReward_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F567 RID: 62823 RVA: 0x0023CEF2 File Offset: 0x0023B0F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewBieCourseRewardNotify Clone()
		{
			return new NewBieCourseRewardNotify(this);
		}

		// Token: 0x170031FD RID: 12797
		// (get) Token: 0x0600F568 RID: 62824 RVA: 0x0023CEFA File Offset: 0x0023B0FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> HadTakeReward
		{
			get
			{
				return this.hadTakeReward_;
			}
		}

		// Token: 0x0600F569 RID: 62825 RVA: 0x0023CF02 File Offset: 0x0023B102
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewBieCourseRewardNotify);
		}

		// Token: 0x0600F56A RID: 62826 RVA: 0x0023CF10 File Offset: 0x0023B110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewBieCourseRewardNotify other)
		{
			return other != null && (other == this || (this.hadTakeReward_.Equals(other.hadTakeReward_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F56B RID: 62827 RVA: 0x0023CF44 File Offset: 0x0023B144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.hadTakeReward_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F56C RID: 62828 RVA: 0x0023CF78 File Offset: 0x0023B178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F56D RID: 62829 RVA: 0x0023CF85 File Offset: 0x0023B185
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F56E RID: 62830 RVA: 0x0023CF8E File Offset: 0x0023B18E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.hadTakeReward_.WriteTo(ref output, NewBieCourseRewardNotify._repeated_hadTakeReward_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F56F RID: 62831 RVA: 0x0023CFB8 File Offset: 0x0023B1B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.hadTakeReward_.CalculateSize(NewBieCourseRewardNotify._repeated_hadTakeReward_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F570 RID: 62832 RVA: 0x0023CFF1 File Offset: 0x0023B1F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewBieCourseRewardNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.hadTakeReward_.Add(other.hadTakeReward_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F571 RID: 62833 RVA: 0x0023D01F File Offset: 0x0023B21F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F572 RID: 62834 RVA: 0x0023D028 File Offset: 0x0023B228
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
				if (num != 24U && num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.hadTakeReward_.AddEntriesFrom(ref input, NewBieCourseRewardNotify._repeated_hadTakeReward_codec);
				}
			}
		}

		// Token: 0x040062B0 RID: 25264
		private UnknownFieldSet _unknownFields;

		// Token: 0x040062B1 RID: 25265
		public const int HadTakeRewardFieldNumber = 3;

		// Token: 0x040062B2 RID: 25266
		private static readonly FieldCodec<int> _repeated_hadTakeReward_codec = FieldCodec.ForInt32(26U);

		// Token: 0x040062B3 RID: 25267
		private readonly RepeatedField<int> hadTakeReward_ = new RepeatedField<int>();
	}
}
