using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000904 RID: 2308
	[NetMessage(EMessageId.LevelPlayRewardCountResetNotify)]
	public sealed class LevelPlayRewardCountResetNotify : IMessage<LevelPlayRewardCountResetNotify>, IMessage, IEquatable<LevelPlayRewardCountResetNotify>, IDeepCloneable<LevelPlayRewardCountResetNotify>, IBufferMessage
	{
		// Token: 0x0600CBD6 RID: 52182 RVA: 0x001E0EDC File Offset: 0x001DF0DC
		[NullableContext(1)]
		public static LevelPlayRewardCountResetNotify Create()
		{
			return new LevelPlayRewardCountResetNotify();
		}

		// Token: 0x17002928 RID: 10536
		// (get) Token: 0x0600CBD7 RID: 52183 RVA: 0x001E0EE3 File Offset: 0x001DF0E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002929 RID: 10537
		// (get) Token: 0x0600CBD8 RID: 52184 RVA: 0x001E0EE6 File Offset: 0x001DF0E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayRewardCountResetNotify.Descriptor;
			}
		}

		// Token: 0x0600CBD9 RID: 52185 RVA: 0x001E0EED File Offset: 0x001DF0ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayRewardCountResetNotify()
		{
		}

		// Token: 0x0600CBDA RID: 52186 RVA: 0x001E0F00 File Offset: 0x001DF100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayRewardCountResetNotify(LevelPlayRewardCountResetNotify other) : this()
		{
			this.levelPlayIds_ = other.levelPlayIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CBDB RID: 52187 RVA: 0x001E0F2A File Offset: 0x001DF12A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayRewardCountResetNotify Clone()
		{
			return new LevelPlayRewardCountResetNotify(this);
		}

		// Token: 0x1700292A RID: 10538
		// (get) Token: 0x0600CBDC RID: 52188 RVA: 0x001E0F32 File Offset: 0x001DF132
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> LevelPlayIds
		{
			get
			{
				return this.levelPlayIds_;
			}
		}

		// Token: 0x0600CBDD RID: 52189 RVA: 0x001E0F3A File Offset: 0x001DF13A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayRewardCountResetNotify);
		}

		// Token: 0x0600CBDE RID: 52190 RVA: 0x001E0F48 File Offset: 0x001DF148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayRewardCountResetNotify other)
		{
			return other != null && (other == this || (this.levelPlayIds_.Equals(other.levelPlayIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CBDF RID: 52191 RVA: 0x001E0F7C File Offset: 0x001DF17C
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

		// Token: 0x0600CBE0 RID: 52192 RVA: 0x001E0FB0 File Offset: 0x001DF1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CBE1 RID: 52193 RVA: 0x001E0FBD File Offset: 0x001DF1BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CBE2 RID: 52194 RVA: 0x001E0FC6 File Offset: 0x001DF1C6
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

		// Token: 0x0600CBE3 RID: 52195 RVA: 0x001E0FF0 File Offset: 0x001DF1F0
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

		// Token: 0x0600CBE4 RID: 52196 RVA: 0x001E1029 File Offset: 0x001DF229
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

		// Token: 0x0600CBE5 RID: 52197 RVA: 0x001E1057 File Offset: 0x001DF257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CBE6 RID: 52198 RVA: 0x001E1060 File Offset: 0x001DF260
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
				if (num != 48U && num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.levelPlayIds_.AddEntriesFrom(ref input, LevelPlayRewardCountResetNotify._repeated_levelPlayIds_codec);
				}
			}
		}

		// Token: 0x04005682 RID: 22146
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005683 RID: 22147
		public const int LevelPlayIdsFieldNumber = 6;

		// Token: 0x04005684 RID: 22148
		private static readonly FieldCodec<int> _repeated_levelPlayIds_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04005685 RID: 22149
		private readonly RepeatedField<int> levelPlayIds_ = new RepeatedField<int>();
	}
}
