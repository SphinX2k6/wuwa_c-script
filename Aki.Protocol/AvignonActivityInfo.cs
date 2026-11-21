using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000131 RID: 305
	public sealed class AvignonActivityInfo : IMessage<AvignonActivityInfo>, IMessage, IEquatable<AvignonActivityInfo>, IDeepCloneable<AvignonActivityInfo>, IBufferMessage
	{
		// Token: 0x06002876 RID: 10358 RVA: 0x0006AC35 File Offset: 0x00068E35
		[NullableContext(1)]
		public static AvignonActivityInfo Create()
		{
			return new AvignonActivityInfo();
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06002877 RID: 10359 RVA: 0x0006AC3C File Offset: 0x00068E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06002878 RID: 10360 RVA: 0x0006AC3F File Offset: 0x00068E3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AvignonActivityInfo.Descriptor;
			}
		}

		// Token: 0x06002879 RID: 10361 RVA: 0x0006AC46 File Offset: 0x00068E46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvignonActivityInfo()
		{
		}

		// Token: 0x0600287A RID: 10362 RVA: 0x0006AC5C File Offset: 0x00068E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvignonActivityInfo(AvignonActivityInfo other) : this()
		{
			this.activityTaskDatas_ = ((other.activityTaskDatas_ != null) ? other.activityTaskDatas_.Clone() : null);
			this.unLockStepId_ = other.unLockStepId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600287B RID: 10363 RVA: 0x0006ACAD File Offset: 0x00068EAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvignonActivityInfo Clone()
		{
			return new AvignonActivityInfo(this);
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x0600287C RID: 10364 RVA: 0x0006ACB5 File Offset: 0x00068EB5
		// (set) Token: 0x0600287D RID: 10365 RVA: 0x0006ACBD File Offset: 0x00068EBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityTaskData ActivityTaskDatas
		{
			get
			{
				return this.activityTaskDatas_;
			}
			set
			{
				this.activityTaskDatas_ = value;
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x0600287E RID: 10366 RVA: 0x0006ACC6 File Offset: 0x00068EC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnLockStepId
		{
			get
			{
				return this.unLockStepId_;
			}
		}

		// Token: 0x0600287F RID: 10367 RVA: 0x0006ACCE File Offset: 0x00068ECE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AvignonActivityInfo);
		}

		// Token: 0x06002880 RID: 10368 RVA: 0x0006ACDC File Offset: 0x00068EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AvignonActivityInfo other)
		{
			return other != null && (other == this || (object.Equals(this.ActivityTaskDatas, other.ActivityTaskDatas) && this.unLockStepId_.Equals(other.unLockStepId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002881 RID: 10369 RVA: 0x0006AD30 File Offset: 0x00068F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.activityTaskDatas_ != null)
			{
				num ^= this.ActivityTaskDatas.GetHashCode();
			}
			num ^= this.unLockStepId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002882 RID: 10370 RVA: 0x0006AD7A File Offset: 0x00068F7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002883 RID: 10371 RVA: 0x0006AD87 File Offset: 0x00068F87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002884 RID: 10372 RVA: 0x0006AD90 File Offset: 0x00068F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.activityTaskDatas_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.ActivityTaskDatas);
			}
			this.unLockStepId_.WriteTo(ref output, AvignonActivityInfo._repeated_unLockStepId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002885 RID: 10373 RVA: 0x0006ADE0 File Offset: 0x00068FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.activityTaskDatas_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ActivityTaskDatas);
			}
			num += this.unLockStepId_.CalculateSize(AvignonActivityInfo._repeated_unLockStepId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002886 RID: 10374 RVA: 0x0006AE34 File Offset: 0x00069034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AvignonActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.activityTaskDatas_ != null)
			{
				if (this.activityTaskDatas_ == null)
				{
					this.ActivityTaskDatas = new ActivityTaskData();
				}
				this.ActivityTaskDatas.MergeFrom(other.ActivityTaskDatas);
			}
			this.unLockStepId_.Add(other.unLockStepId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002887 RID: 10375 RVA: 0x0006AE99 File Offset: 0x00069099
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002888 RID: 10376 RVA: 0x0006AEA4 File Offset: 0x000690A4
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
					if (num != 16U && num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.unLockStepId_.AddEntriesFrom(ref input, AvignonActivityInfo._repeated_unLockStepId_codec);
					}
				}
				else
				{
					if (this.activityTaskDatas_ == null)
					{
						this.ActivityTaskDatas = new ActivityTaskData();
					}
					input.ReadMessage(this.ActivityTaskDatas);
				}
			}
		}

		// Token: 0x040026FB RID: 9979
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026FC RID: 9980
		public const int ActivityTaskDatasFieldNumber = 1;

		// Token: 0x040026FD RID: 9981
		private ActivityTaskData activityTaskDatas_;

		// Token: 0x040026FE RID: 9982
		public const int UnLockStepIdFieldNumber = 2;

		// Token: 0x040026FF RID: 9983
		private static readonly FieldCodec<int> _repeated_unLockStepId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04002700 RID: 9984
		private readonly RepeatedField<int> unLockStepId_ = new RepeatedField<int>();
	}
}
