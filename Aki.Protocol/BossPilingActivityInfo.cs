using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001C5 RID: 453
	public sealed class BossPilingActivityInfo : IMessage<BossPilingActivityInfo>, IMessage, IEquatable<BossPilingActivityInfo>, IDeepCloneable<BossPilingActivityInfo>, IBufferMessage
	{
		// Token: 0x0600343D RID: 13373 RVA: 0x00084283 File Offset: 0x00082483
		[NullableContext(1)]
		public static BossPilingActivityInfo Create()
		{
			return new BossPilingActivityInfo();
		}

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x0600343E RID: 13374 RVA: 0x0008428A File Offset: 0x0008248A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x0600343F RID: 13375 RVA: 0x0008428D File Offset: 0x0008248D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossPilingActivityInfo.Descriptor;
			}
		}

		// Token: 0x06003440 RID: 13376 RVA: 0x00084294 File Offset: 0x00082494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingActivityInfo()
		{
		}

		// Token: 0x06003441 RID: 13377 RVA: 0x000842B2 File Offset: 0x000824B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingActivityInfo(BossPilingActivityInfo other) : this()
		{
			this.conditionTasks_ = other.conditionTasks_.Clone();
			this.bossPilingLevelInfos_ = other.bossPilingLevelInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003442 RID: 13378 RVA: 0x000842ED File Offset: 0x000824ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingActivityInfo Clone()
		{
			return new BossPilingActivityInfo(this);
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06003443 RID: 13379 RVA: 0x000842F5 File Offset: 0x000824F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ConditionTasks
		{
			get
			{
				return this.conditionTasks_;
			}
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x06003444 RID: 13380 RVA: 0x000842FD File Offset: 0x000824FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BossPilingLevelInfo> BossPilingLevelInfos
		{
			get
			{
				return this.bossPilingLevelInfos_;
			}
		}

		// Token: 0x06003445 RID: 13381 RVA: 0x00084305 File Offset: 0x00082505
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossPilingActivityInfo);
		}

		// Token: 0x06003446 RID: 13382 RVA: 0x00084314 File Offset: 0x00082514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossPilingActivityInfo other)
		{
			return other != null && (other == this || (this.conditionTasks_.Equals(other.conditionTasks_) && this.bossPilingLevelInfos_.Equals(other.bossPilingLevelInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003447 RID: 13383 RVA: 0x00084368 File Offset: 0x00082568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.conditionTasks_.GetHashCode();
			num ^= this.bossPilingLevelInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003448 RID: 13384 RVA: 0x000843AA File Offset: 0x000825AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003449 RID: 13385 RVA: 0x000843B7 File Offset: 0x000825B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600344A RID: 13386 RVA: 0x000843C0 File Offset: 0x000825C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.conditionTasks_.WriteTo(ref output, BossPilingActivityInfo._repeated_conditionTasks_codec);
			this.bossPilingLevelInfos_.WriteTo(ref output, BossPilingActivityInfo._repeated_bossPilingLevelInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600344B RID: 13387 RVA: 0x000843F8 File Offset: 0x000825F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.conditionTasks_.CalculateSize(BossPilingActivityInfo._repeated_conditionTasks_codec);
			num += this.bossPilingLevelInfos_.CalculateSize(BossPilingActivityInfo._repeated_bossPilingLevelInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600344C RID: 13388 RVA: 0x00084444 File Offset: 0x00082644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossPilingActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.conditionTasks_.Add(other.conditionTasks_);
			this.bossPilingLevelInfos_.Add(other.bossPilingLevelInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600344D RID: 13389 RVA: 0x00084483 File Offset: 0x00082683
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600344E RID: 13390 RVA: 0x0008448C File Offset: 0x0008268C
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
				if (num != 10U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.bossPilingLevelInfos_.AddEntriesFrom(ref input, BossPilingActivityInfo._repeated_bossPilingLevelInfos_codec);
					}
				}
				else
				{
					this.conditionTasks_.AddEntriesFrom(ref input, BossPilingActivityInfo._repeated_conditionTasks_codec);
				}
			}
		}

		// Token: 0x04002A47 RID: 10823
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A48 RID: 10824
		public const int ConditionTasksFieldNumber = 1;

		// Token: 0x04002A49 RID: 10825
		private static readonly FieldCodec<ConditionTask> _repeated_conditionTasks_codec = FieldCodec.ForMessage<ConditionTask>(10U, ConditionTask.Parser);

		// Token: 0x04002A4A RID: 10826
		private readonly RepeatedField<ConditionTask> conditionTasks_ = new RepeatedField<ConditionTask>();

		// Token: 0x04002A4B RID: 10827
		public const int BossPilingLevelInfosFieldNumber = 2;

		// Token: 0x04002A4C RID: 10828
		private static readonly FieldCodec<BossPilingLevelInfo> _repeated_bossPilingLevelInfos_codec = FieldCodec.ForMessage<BossPilingLevelInfo>(18U, BossPilingLevelInfo.Parser);

		// Token: 0x04002A4D RID: 10829
		private readonly RepeatedField<BossPilingLevelInfo> bossPilingLevelInfos_ = new RepeatedField<BossPilingLevelInfo>();
	}
}
