using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008F3 RID: 2291
	[NetMessage(EMessageId.LevelPlayRewardCountResetNotify)]
	public sealed class LevelPlayRewardCountResetNotify : IMessage<LevelPlayRewardCountResetNotify>, IMessage, IEquatable<LevelPlayRewardCountResetNotify>, IDeepCloneable<LevelPlayRewardCountResetNotify>, IBufferMessage
	{
		// Token: 0x0600CABA RID: 51898 RVA: 0x001DEC04 File Offset: 0x001DCE04
		[NullableContext(1)]
		public static LevelPlayRewardCountResetNotify Create()
		{
			return new LevelPlayRewardCountResetNotify();
		}

		// Token: 0x170028E9 RID: 10473
		// (get) Token: 0x0600CABB RID: 51899 RVA: 0x001DEC0B File Offset: 0x001DCE0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028EA RID: 10474
		// (get) Token: 0x0600CABC RID: 51900 RVA: 0x001DEC0E File Offset: 0x001DCE0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayRewardCountResetNotify.Descriptor;
			}
		}

		// Token: 0x0600CABD RID: 51901 RVA: 0x001DEC15 File Offset: 0x001DCE15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayRewardCountResetNotify()
		{
		}

		// Token: 0x0600CABE RID: 51902 RVA: 0x001DEC28 File Offset: 0x001DCE28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayRewardCountResetNotify(LevelPlayRewardCountResetNotify other) : this()
		{
			this.levelPlayIds_ = other.levelPlayIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CABF RID: 51903 RVA: 0x001DEC52 File Offset: 0x001DCE52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayRewardCountResetNotify Clone()
		{
			return new LevelPlayRewardCountResetNotify(this);
		}

		// Token: 0x170028EB RID: 10475
		// (get) Token: 0x0600CAC0 RID: 51904 RVA: 0x001DEC5A File Offset: 0x001DCE5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> LevelPlayIds
		{
			get
			{
				return this.levelPlayIds_;
			}
		}

		// Token: 0x0600CAC1 RID: 51905 RVA: 0x001DEC62 File Offset: 0x001DCE62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayRewardCountResetNotify);
		}

		// Token: 0x0600CAC2 RID: 51906 RVA: 0x001DEC70 File Offset: 0x001DCE70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayRewardCountResetNotify other)
		{
			return other != null && (other == this || (this.levelPlayIds_.Equals(other.levelPlayIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CAC3 RID: 51907 RVA: 0x001DECA4 File Offset: 0x001DCEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.levelPlayIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CAC4 RID: 51908 RVA: 0x001DECD8 File Offset: 0x001DCED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CAC5 RID: 51909 RVA: 0x001DECE5 File Offset: 0x001DCEE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CAC6 RID: 51910 RVA: 0x001DECEE File Offset: 0x001DCEEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.levelPlayIds_.WriteTo(ref output, LevelPlayRewardCountResetNotify._repeated_levelPlayIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CAC7 RID: 51911 RVA: 0x001DED18 File Offset: 0x001DCF18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.levelPlayIds_.CalculateSize(LevelPlayRewardCountResetNotify._repeated_levelPlayIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CAC8 RID: 51912 RVA: 0x001DED51 File Offset: 0x001DCF51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlayRewardCountResetNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.levelPlayIds_.Add(other.levelPlayIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CAC9 RID: 51913 RVA: 0x001DED7F File Offset: 0x001DCF7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CACA RID: 51914 RVA: 0x001DED88 File Offset: 0x001DCF88
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
				if (num != 16U && num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.levelPlayIds_.AddEntriesFrom(ref input, LevelPlayRewardCountResetNotify._repeated_levelPlayIds_codec);
				}
			}
		}

		// Token: 0x04005689 RID: 22153
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400568A RID: 22154
		public const int LevelPlayIdsFieldNumber = 2;

		// Token: 0x0400568B RID: 22155
		private static readonly FieldCodec<int> _repeated_levelPlayIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x0400568C RID: 22156
		private readonly RepeatedField<int> levelPlayIds_ = new RepeatedField<int>();
	}
}
