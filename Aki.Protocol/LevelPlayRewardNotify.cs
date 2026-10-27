using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000906 RID: 2310
	[NetMessage(EMessageId.LevelPlayRewardNotify)]
	public sealed class LevelPlayRewardNotify : IMessage<LevelPlayRewardNotify>, IMessage, IEquatable<LevelPlayRewardNotify>, IDeepCloneable<LevelPlayRewardNotify>, IBufferMessage
	{
		// Token: 0x0600CBFE RID: 52222 RVA: 0x001E1367 File Offset: 0x001DF567
		[NullableContext(1)]
		public static LevelPlayRewardNotify Create()
		{
			return new LevelPlayRewardNotify();
		}

		// Token: 0x17002930 RID: 10544
		// (get) Token: 0x0600CBFF RID: 52223 RVA: 0x001E136E File Offset: 0x001DF56E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002931 RID: 10545
		// (get) Token: 0x0600CC00 RID: 52224 RVA: 0x001E1371 File Offset: 0x001DF571
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayRewardNotify.Descriptor;
			}
		}

		// Token: 0x0600CC01 RID: 52225 RVA: 0x001E1378 File Offset: 0x001DF578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayRewardNotify()
		{
		}

		// Token: 0x0600CC02 RID: 52226 RVA: 0x001E138B File Offset: 0x001DF58B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayRewardNotify(LevelPlayRewardNotify other) : this()
		{
			this.levelPlayRewards_ = other.levelPlayRewards_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CC03 RID: 52227 RVA: 0x001E13B5 File Offset: 0x001DF5B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayRewardNotify Clone()
		{
			return new LevelPlayRewardNotify(this);
		}

		// Token: 0x17002932 RID: 10546
		// (get) Token: 0x0600CC04 RID: 52228 RVA: 0x001E13BD File Offset: 0x001DF5BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LevelPlayRewardInfo> LevelPlayRewards
		{
			get
			{
				return this.levelPlayRewards_;
			}
		}

		// Token: 0x0600CC05 RID: 52229 RVA: 0x001E13C5 File Offset: 0x001DF5C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayRewardNotify);
		}

		// Token: 0x0600CC06 RID: 52230 RVA: 0x001E13D3 File Offset: 0x001DF5D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayRewardNotify other)
		{
			return other != null && (other == this || (this.levelPlayRewards_.Equals(other.levelPlayRewards_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CC07 RID: 52231 RVA: 0x001E1408 File Offset: 0x001DF608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.levelPlayRewards_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CC08 RID: 52232 RVA: 0x001E143C File Offset: 0x001DF63C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CC09 RID: 52233 RVA: 0x001E1449 File Offset: 0x001DF649
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CC0A RID: 52234 RVA: 0x001E1452 File Offset: 0x001DF652
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.levelPlayRewards_.WriteTo(ref output, LevelPlayRewardNotify._repeated_levelPlayRewards_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CC0B RID: 52235 RVA: 0x001E147C File Offset: 0x001DF67C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.levelPlayRewards_.CalculateSize(LevelPlayRewardNotify._repeated_levelPlayRewards_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CC0C RID: 52236 RVA: 0x001E14B5 File Offset: 0x001DF6B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlayRewardNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.levelPlayRewards_.Add(other.levelPlayRewards_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CC0D RID: 52237 RVA: 0x001E14E3 File Offset: 0x001DF6E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CC0E RID: 52238 RVA: 0x001E14EC File Offset: 0x001DF6EC
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
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.levelPlayRewards_.AddEntriesFrom(ref input, LevelPlayRewardNotify._repeated_levelPlayRewards_codec);
				}
			}
		}

		// Token: 0x0400568C RID: 22156
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400568D RID: 22157
		public const int LevelPlayRewardsFieldNumber = 15;

		// Token: 0x0400568E RID: 22158
		private static readonly FieldCodec<LevelPlayRewardInfo> _repeated_levelPlayRewards_codec = FieldCodec.ForMessage<LevelPlayRewardInfo>(122U, LevelPlayRewardInfo.Parser);

		// Token: 0x0400568F RID: 22159
		private readonly RepeatedField<LevelPlayRewardInfo> levelPlayRewards_ = new RepeatedField<LevelPlayRewardInfo>();
	}
}
