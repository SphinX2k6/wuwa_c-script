using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000220 RID: 544
	[NetMessage(EMessageId.CalabashLevelsRewardNotify)]
	public sealed class CalabashLevelsRewardNotify : IMessage<CalabashLevelsRewardNotify>, IMessage, IEquatable<CalabashLevelsRewardNotify>, IDeepCloneable<CalabashLevelsRewardNotify>, IBufferMessage
	{
		// Token: 0x06003B6E RID: 15214 RVA: 0x00093DF1 File Offset: 0x00091FF1
		[NullableContext(1)]
		public static CalabashLevelsRewardNotify Create()
		{
			return new CalabashLevelsRewardNotify();
		}

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x06003B6F RID: 15215 RVA: 0x00093DF8 File Offset: 0x00091FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x06003B70 RID: 15216 RVA: 0x00093DFB File Offset: 0x00091FFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CalabashLevelsRewardNotify.Descriptor;
			}
		}

		// Token: 0x06003B71 RID: 15217 RVA: 0x00093E02 File Offset: 0x00092002
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashLevelsRewardNotify()
		{
		}

		// Token: 0x06003B72 RID: 15218 RVA: 0x00093E15 File Offset: 0x00092015
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashLevelsRewardNotify(CalabashLevelsRewardNotify other) : this()
		{
			this.rewardedLevels_ = other.rewardedLevels_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003B73 RID: 15219 RVA: 0x00093E3F File Offset: 0x0009203F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashLevelsRewardNotify Clone()
		{
			return new CalabashLevelsRewardNotify(this);
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x06003B74 RID: 15220 RVA: 0x00093E47 File Offset: 0x00092047
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardedLevels
		{
			get
			{
				return this.rewardedLevels_;
			}
		}

		// Token: 0x06003B75 RID: 15221 RVA: 0x00093E4F File Offset: 0x0009204F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CalabashLevelsRewardNotify);
		}

		// Token: 0x06003B76 RID: 15222 RVA: 0x00093E5D File Offset: 0x0009205D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CalabashLevelsRewardNotify other)
		{
			return other != null && (other == this || (this.rewardedLevels_.Equals(other.rewardedLevels_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003B77 RID: 15223 RVA: 0x00093E90 File Offset: 0x00092090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.rewardedLevels_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003B78 RID: 15224 RVA: 0x00093EC4 File Offset: 0x000920C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003B79 RID: 15225 RVA: 0x00093ED1 File Offset: 0x000920D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003B7A RID: 15226 RVA: 0x00093EDA File Offset: 0x000920DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rewardedLevels_.WriteTo(ref output, CalabashLevelsRewardNotify._repeated_rewardedLevels_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003B7B RID: 15227 RVA: 0x00093F04 File Offset: 0x00092104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rewardedLevels_.CalculateSize(CalabashLevelsRewardNotify._repeated_rewardedLevels_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003B7C RID: 15228 RVA: 0x00093F3D File Offset: 0x0009213D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CalabashLevelsRewardNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.rewardedLevels_.Add(other.rewardedLevels_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003B7D RID: 15229 RVA: 0x00093F6B File Offset: 0x0009216B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003B7E RID: 15230 RVA: 0x00093F74 File Offset: 0x00092174
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
				if (num != 96U && num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.rewardedLevels_.AddEntriesFrom(ref input, CalabashLevelsRewardNotify._repeated_rewardedLevels_codec);
				}
			}
		}

		// Token: 0x04002C25 RID: 11301
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C26 RID: 11302
		public const int RewardedLevelsFieldNumber = 12;

		// Token: 0x04002C27 RID: 11303
		private static readonly FieldCodec<int> _repeated_rewardedLevels_codec = FieldCodec.ForInt32(98U);

		// Token: 0x04002C28 RID: 11304
		private readonly RepeatedField<int> rewardedLevels_ = new RepeatedField<int>();
	}
}
