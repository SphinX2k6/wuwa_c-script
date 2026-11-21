using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001584 RID: 5508
	[NetMessage(EMessageId.WeeklyFrameworkScoreRewardRequest)]
	public sealed class WeeklyFrameworkScoreRewardRequest : IMessage<WeeklyFrameworkScoreRewardRequest>, IMessage, IEquatable<WeeklyFrameworkScoreRewardRequest>, IDeepCloneable<WeeklyFrameworkScoreRewardRequest>, IBufferMessage
	{
		// Token: 0x0601D290 RID: 119440 RVA: 0x00438ED0 File Offset: 0x004370D0
		[NullableContext(1)]
		public static WeeklyFrameworkScoreRewardRequest Create()
		{
			return new WeeklyFrameworkScoreRewardRequest();
		}

		// Token: 0x170062A8 RID: 25256
		// (get) Token: 0x0601D291 RID: 119441 RVA: 0x00438ED7 File Offset: 0x004370D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170062A9 RID: 25257
		// (get) Token: 0x0601D292 RID: 119442 RVA: 0x00438EDA File Offset: 0x004370DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeeklyFrameworkScoreRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601D293 RID: 119443 RVA: 0x00438EE1 File Offset: 0x004370E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyFrameworkScoreRewardRequest()
		{
		}

		// Token: 0x0601D294 RID: 119444 RVA: 0x00438EF4 File Offset: 0x004370F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyFrameworkScoreRewardRequest(WeeklyFrameworkScoreRewardRequest other) : this()
		{
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D295 RID: 119445 RVA: 0x00438F1E File Offset: 0x0043711E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyFrameworkScoreRewardRequest Clone()
		{
			return new WeeklyFrameworkScoreRewardRequest(this);
		}

		// Token: 0x170062AA RID: 25258
		// (get) Token: 0x0601D296 RID: 119446 RVA: 0x00438F26 File Offset: 0x00437126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x0601D297 RID: 119447 RVA: 0x00438F2E File Offset: 0x0043712E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeeklyFrameworkScoreRewardRequest);
		}

		// Token: 0x0601D298 RID: 119448 RVA: 0x00438F3C File Offset: 0x0043713C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeeklyFrameworkScoreRewardRequest other)
		{
			return other != null && (other == this || (this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D299 RID: 119449 RVA: 0x00438F70 File Offset: 0x00437170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.taskIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D29A RID: 119450 RVA: 0x00438FA4 File Offset: 0x004371A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D29B RID: 119451 RVA: 0x00438FB1 File Offset: 0x004371B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D29C RID: 119452 RVA: 0x00438FBA File Offset: 0x004371BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskIds_.WriteTo(ref output, WeeklyFrameworkScoreRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D29D RID: 119453 RVA: 0x00438FE4 File Offset: 0x004371E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.taskIds_.CalculateSize(WeeklyFrameworkScoreRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D29E RID: 119454 RVA: 0x0043901D File Offset: 0x0043721D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeeklyFrameworkScoreRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.taskIds_.Add(other.taskIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D29F RID: 119455 RVA: 0x0043904B File Offset: 0x0043724B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D2A0 RID: 119456 RVA: 0x00439054 File Offset: 0x00437254
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
					this.taskIds_.AddEntriesFrom(ref input, WeeklyFrameworkScoreRewardRequest._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x0400A761 RID: 42849
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A762 RID: 42850
		public const int TaskIdsFieldNumber = 14;

		// Token: 0x0400A763 RID: 42851
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(114U);

		// Token: 0x0400A764 RID: 42852
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
