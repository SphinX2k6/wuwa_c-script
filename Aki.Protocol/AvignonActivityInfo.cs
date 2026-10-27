using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200012E RID: 302
	public sealed class AvignonActivityInfo : IMessage<AvignonActivityInfo>, IMessage, IEquatable<AvignonActivityInfo>, IDeepCloneable<AvignonActivityInfo>, IBufferMessage
	{
		// Token: 0x060027FF RID: 10239 RVA: 0x0006980D File Offset: 0x00067A0D
		[NullableContext(1)]
		public static AvignonActivityInfo Create()
		{
			return new AvignonActivityInfo();
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06002800 RID: 10240 RVA: 0x00069814 File Offset: 0x00067A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06002801 RID: 10241 RVA: 0x00069817 File Offset: 0x00067A17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AvignonActivityInfo.Descriptor;
			}
		}

		// Token: 0x06002802 RID: 10242 RVA: 0x0006981E File Offset: 0x00067A1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvignonActivityInfo()
		{
		}

		// Token: 0x06002803 RID: 10243 RVA: 0x00069834 File Offset: 0x00067A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvignonActivityInfo(AvignonActivityInfo other) : this()
		{
			this.activityTaskDatas_ = ((other.activityTaskDatas_ != null) ? other.activityTaskDatas_.Clone() : null);
			this.unLockStepId_ = other.unLockStepId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002804 RID: 10244 RVA: 0x00069885 File Offset: 0x00067A85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvignonActivityInfo Clone()
		{
			return new AvignonActivityInfo(this);
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06002805 RID: 10245 RVA: 0x0006988D File Offset: 0x00067A8D
		// (set) Token: 0x06002806 RID: 10246 RVA: 0x00069895 File Offset: 0x00067A95
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

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06002807 RID: 10247 RVA: 0x0006989E File Offset: 0x00067A9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnLockStepId
		{
			get
			{
				return this.unLockStepId_;
			}
		}

		// Token: 0x06002808 RID: 10248 RVA: 0x000698A6 File Offset: 0x00067AA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AvignonActivityInfo);
		}

		// Token: 0x06002809 RID: 10249 RVA: 0x000698B4 File Offset: 0x00067AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AvignonActivityInfo other)
		{
			return other != null && (other == this || (object.Equals(this.ActivityTaskDatas, other.ActivityTaskDatas) && this.unLockStepId_.Equals(other.unLockStepId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600280A RID: 10250 RVA: 0x00069908 File Offset: 0x00067B08
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

		// Token: 0x0600280B RID: 10251 RVA: 0x00069952 File Offset: 0x00067B52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600280C RID: 10252 RVA: 0x0006995F File Offset: 0x00067B5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600280D RID: 10253 RVA: 0x00069968 File Offset: 0x00067B68
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

		// Token: 0x0600280E RID: 10254 RVA: 0x000699B8 File Offset: 0x00067BB8
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

		// Token: 0x0600280F RID: 10255 RVA: 0x00069A0C File Offset: 0x00067C0C
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

		// Token: 0x06002810 RID: 10256 RVA: 0x00069A71 File Offset: 0x00067C71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002811 RID: 10257 RVA: 0x00069A7C File Offset: 0x00067C7C
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

		// Token: 0x04002687 RID: 9863
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002688 RID: 9864
		public const int ActivityTaskDatasFieldNumber = 1;

		// Token: 0x04002689 RID: 9865
		private ActivityTaskData activityTaskDatas_;

		// Token: 0x0400268A RID: 9866
		public const int UnLockStepIdFieldNumber = 2;

		// Token: 0x0400268B RID: 9867
		private static readonly FieldCodec<int> _repeated_unLockStepId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x0400268C RID: 9868
		private readonly RepeatedField<int> unLockStepId_ = new RepeatedField<int>();
	}
}
