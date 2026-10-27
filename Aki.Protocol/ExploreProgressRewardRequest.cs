using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004FB RID: 1275
	[NetMessage(EMessageId.ExploreProgressRewardRequest)]
	public sealed class ExploreProgressRewardRequest : IMessage<ExploreProgressRewardRequest>, IMessage, IEquatable<ExploreProgressRewardRequest>, IDeepCloneable<ExploreProgressRewardRequest>, IBufferMessage
	{
		// Token: 0x0600784C RID: 30796 RVA: 0x00124FBD File Offset: 0x001231BD
		[NullableContext(1)]
		public static ExploreProgressRewardRequest Create()
		{
			return new ExploreProgressRewardRequest();
		}

		// Token: 0x17001750 RID: 5968
		// (get) Token: 0x0600784D RID: 30797 RVA: 0x00124FC4 File Offset: 0x001231C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001751 RID: 5969
		// (get) Token: 0x0600784E RID: 30798 RVA: 0x00124FC7 File Offset: 0x001231C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreProgressRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600784F RID: 30799 RVA: 0x00124FCE File Offset: 0x001231CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreProgressRewardRequest()
		{
		}

		// Token: 0x06007850 RID: 30800 RVA: 0x00124FE1 File Offset: 0x001231E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreProgressRewardRequest(ExploreProgressRewardRequest other) : this()
		{
			this.rewardIds_ = other.rewardIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007851 RID: 30801 RVA: 0x0012500B File Offset: 0x0012320B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreProgressRewardRequest Clone()
		{
			return new ExploreProgressRewardRequest(this);
		}

		// Token: 0x17001752 RID: 5970
		// (get) Token: 0x06007852 RID: 30802 RVA: 0x00125013 File Offset: 0x00123213
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardIds
		{
			get
			{
				return this.rewardIds_;
			}
		}

		// Token: 0x06007853 RID: 30803 RVA: 0x0012501B File Offset: 0x0012321B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreProgressRewardRequest);
		}

		// Token: 0x06007854 RID: 30804 RVA: 0x00125029 File Offset: 0x00123229
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreProgressRewardRequest other)
		{
			return other != null && (other == this || (this.rewardIds_.Equals(other.rewardIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007855 RID: 30805 RVA: 0x0012505C File Offset: 0x0012325C
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

		// Token: 0x06007856 RID: 30806 RVA: 0x00125090 File Offset: 0x00123290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007857 RID: 30807 RVA: 0x0012509D File Offset: 0x0012329D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007858 RID: 30808 RVA: 0x001250A6 File Offset: 0x001232A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rewardIds_.WriteTo(ref output, ExploreProgressRewardRequest._repeated_rewardIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007859 RID: 30809 RVA: 0x001250D0 File Offset: 0x001232D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rewardIds_.CalculateSize(ExploreProgressRewardRequest._repeated_rewardIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600785A RID: 30810 RVA: 0x00125109 File Offset: 0x00123309
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExploreProgressRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.rewardIds_.Add(other.rewardIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600785B RID: 30811 RVA: 0x00125137 File Offset: 0x00123337
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600785C RID: 30812 RVA: 0x00125140 File Offset: 0x00123340
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
				if (num != 112U && num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.rewardIds_.AddEntriesFrom(ref input, ExploreProgressRewardRequest._repeated_rewardIds_codec);
				}
			}
		}

		// Token: 0x04003E60 RID: 15968
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E61 RID: 15969
		public const int RewardIdsFieldNumber = 14;

		// Token: 0x04003E62 RID: 15970
		private static readonly FieldCodec<int> _repeated_rewardIds_codec = FieldCodec.ForInt32(114U);

		// Token: 0x04003E63 RID: 15971
		private readonly RepeatedField<int> rewardIds_ = new RepeatedField<int>();
	}
}
