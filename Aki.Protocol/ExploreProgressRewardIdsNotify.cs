using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004E4 RID: 1252
	[NetMessage(EMessageId.ExploreProgressRewardIdsNotify)]
	public sealed class ExploreProgressRewardIdsNotify : IMessage<ExploreProgressRewardIdsNotify>, IMessage, IEquatable<ExploreProgressRewardIdsNotify>, IDeepCloneable<ExploreProgressRewardIdsNotify>, IBufferMessage
	{
		// Token: 0x060076BE RID: 30398 RVA: 0x00121F49 File Offset: 0x00120149
		[NullableContext(1)]
		public static ExploreProgressRewardIdsNotify Create()
		{
			return new ExploreProgressRewardIdsNotify();
		}

		// Token: 0x170016FC RID: 5884
		// (get) Token: 0x060076BF RID: 30399 RVA: 0x00121F50 File Offset: 0x00120150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016FD RID: 5885
		// (get) Token: 0x060076C0 RID: 30400 RVA: 0x00121F53 File Offset: 0x00120153
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreProgressRewardIdsNotify.Descriptor;
			}
		}

		// Token: 0x060076C1 RID: 30401 RVA: 0x00121F5A File Offset: 0x0012015A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreProgressRewardIdsNotify()
		{
		}

		// Token: 0x060076C2 RID: 30402 RVA: 0x00121F6D File Offset: 0x0012016D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreProgressRewardIdsNotify(ExploreProgressRewardIdsNotify other) : this()
		{
			this.rewardIds_ = other.rewardIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060076C3 RID: 30403 RVA: 0x00121F97 File Offset: 0x00120197
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreProgressRewardIdsNotify Clone()
		{
			return new ExploreProgressRewardIdsNotify(this);
		}

		// Token: 0x170016FE RID: 5886
		// (get) Token: 0x060076C4 RID: 30404 RVA: 0x00121F9F File Offset: 0x0012019F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardIds
		{
			get
			{
				return this.rewardIds_;
			}
		}

		// Token: 0x060076C5 RID: 30405 RVA: 0x00121FA7 File Offset: 0x001201A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreProgressRewardIdsNotify);
		}

		// Token: 0x060076C6 RID: 30406 RVA: 0x00121FB5 File Offset: 0x001201B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreProgressRewardIdsNotify other)
		{
			return other != null && (other == this || (this.rewardIds_.Equals(other.rewardIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060076C7 RID: 30407 RVA: 0x00121FE8 File Offset: 0x001201E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.rewardIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060076C8 RID: 30408 RVA: 0x0012201C File Offset: 0x0012021C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060076C9 RID: 30409 RVA: 0x00122029 File Offset: 0x00120229
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060076CA RID: 30410 RVA: 0x00122032 File Offset: 0x00120232
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rewardIds_.WriteTo(ref output, ExploreProgressRewardIdsNotify._repeated_rewardIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060076CB RID: 30411 RVA: 0x0012205C File Offset: 0x0012025C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rewardIds_.CalculateSize(ExploreProgressRewardIdsNotify._repeated_rewardIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060076CC RID: 30412 RVA: 0x00122095 File Offset: 0x00120295
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExploreProgressRewardIdsNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.rewardIds_.Add(other.rewardIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060076CD RID: 30413 RVA: 0x001220C3 File Offset: 0x001202C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060076CE RID: 30414 RVA: 0x001220CC File Offset: 0x001202CC
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
				if (num != 32U && num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.rewardIds_.AddEntriesFrom(ref input, ExploreProgressRewardIdsNotify._repeated_rewardIds_codec);
				}
			}
		}

		// Token: 0x04003E4D RID: 15949
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E4E RID: 15950
		public const int RewardIdsFieldNumber = 4;

		// Token: 0x04003E4F RID: 15951
		private static readonly FieldCodec<int> _repeated_rewardIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04003E50 RID: 15952
		private readonly RepeatedField<int> rewardIds_ = new RepeatedField<int>();
	}
}
