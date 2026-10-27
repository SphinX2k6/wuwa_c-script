using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002CF RID: 719
	public sealed class ConditionTaskData : IMessage<ConditionTaskData>, IMessage, IEquatable<ConditionTaskData>, IDeepCloneable<ConditionTaskData>, IBufferMessage
	{
		// Token: 0x060049B6 RID: 18870 RVA: 0x000B44EC File Offset: 0x000B26EC
		[NullableContext(1)]
		public static ConditionTaskData Create()
		{
			return new ConditionTaskData();
		}

		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x060049B7 RID: 18871 RVA: 0x000B44F3 File Offset: 0x000B26F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ConditionTaskData> Parser
		{
			get
			{
				return ConditionTaskData._parser;
			}
		}

		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x060049B8 RID: 18872 RVA: 0x000B44FA File Offset: 0x000B26FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x060049B9 RID: 18873 RVA: 0x000B44FD File Offset: 0x000B26FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConditionTaskData.Descriptor;
			}
		}

		// Token: 0x060049BA RID: 18874 RVA: 0x000B4504 File Offset: 0x000B2704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionTaskData()
		{
		}

		// Token: 0x060049BB RID: 18875 RVA: 0x000B450C File Offset: 0x000B270C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionTaskData(ConditionTaskData other) : this()
		{
			this.id_ = other.id_;
			this.status_ = other.status_;
			this.rate_ = other.rate_;
			this.target_ = other.target_;
			this.isConditionUnlock_ = other.isConditionUnlock_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060049BC RID: 18876 RVA: 0x000B456C File Offset: 0x000B276C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionTaskData Clone()
		{
			return new ConditionTaskData(this);
		}

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x060049BD RID: 18877 RVA: 0x000B4574 File Offset: 0x000B2774
		// (set) Token: 0x060049BE RID: 18878 RVA: 0x000B457C File Offset: 0x000B277C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x060049BF RID: 18879 RVA: 0x000B4585 File Offset: 0x000B2785
		// (set) Token: 0x060049C0 RID: 18880 RVA: 0x000B458D File Offset: 0x000B278D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionTaskStatus Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x060049C1 RID: 18881 RVA: 0x000B4596 File Offset: 0x000B2796
		// (set) Token: 0x060049C2 RID: 18882 RVA: 0x000B459E File Offset: 0x000B279E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Rate
		{
			get
			{
				return this.rate_;
			}
			set
			{
				this.rate_ = value;
			}
		}

		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x060049C3 RID: 18883 RVA: 0x000B45A7 File Offset: 0x000B27A7
		// (set) Token: 0x060049C4 RID: 18884 RVA: 0x000B45AF File Offset: 0x000B27AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Target
		{
			get
			{
				return this.target_;
			}
			set
			{
				this.target_ = value;
			}
		}

		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x060049C5 RID: 18885 RVA: 0x000B45B8 File Offset: 0x000B27B8
		// (set) Token: 0x060049C6 RID: 18886 RVA: 0x000B45C0 File Offset: 0x000B27C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsConditionUnlock
		{
			get
			{
				return this.isConditionUnlock_;
			}
			set
			{
				this.isConditionUnlock_ = value;
			}
		}

		// Token: 0x060049C7 RID: 18887 RVA: 0x000B45C9 File Offset: 0x000B27C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConditionTaskData);
		}

		// Token: 0x060049C8 RID: 18888 RVA: 0x000B45D8 File Offset: 0x000B27D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConditionTaskData other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Status == other.Status && this.Rate == other.Rate && this.Target == other.Target && this.IsConditionUnlock == other.IsConditionUnlock && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060049C9 RID: 18889 RVA: 0x000B4654 File Offset: 0x000B2854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Status != ConditionTaskStatus.Undone)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this.Rate != 0)
			{
				num ^= this.Rate.GetHashCode();
			}
			if (this.Target != 0)
			{
				num ^= this.Target.GetHashCode();
			}
			if (this.IsConditionUnlock)
			{
				num ^= this.IsConditionUnlock.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060049CA RID: 18890 RVA: 0x000B46FD File Offset: 0x000B28FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060049CB RID: 18891 RVA: 0x000B470A File Offset: 0x000B290A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060049CC RID: 18892 RVA: 0x000B4714 File Offset: 0x000B2914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Status != ConditionTaskStatus.Undone)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Status);
			}
			if (this.Rate != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Rate);
			}
			if (this.Target != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Target);
			}
			if (this.IsConditionUnlock)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsConditionUnlock);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060049CD RID: 18893 RVA: 0x000B47C0 File Offset: 0x000B29C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Status != ConditionTaskStatus.Undone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this.Rate != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Rate);
			}
			if (this.Target != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Target);
			}
			if (this.IsConditionUnlock)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060049CE RID: 18894 RVA: 0x000B4854 File Offset: 0x000B2A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConditionTaskData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Status != ConditionTaskStatus.Undone)
			{
				this.Status = other.Status;
			}
			if (other.Rate != 0)
			{
				this.Rate = other.Rate;
			}
			if (other.Target != 0)
			{
				this.Target = other.Target;
			}
			if (other.IsConditionUnlock)
			{
				this.IsConditionUnlock = other.IsConditionUnlock;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060049CF RID: 18895 RVA: 0x000B48E0 File Offset: 0x000B2AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060049D0 RID: 18896 RVA: 0x000B48EC File Offset: 0x000B2AEC
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Status = (ConditionTaskStatus)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Rate = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.Target = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.IsConditionUnlock = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003044 RID: 12356
		private static readonly MessageParser<ConditionTaskData> _parser = new MessageParser<ConditionTaskData>(() => new ConditionTaskData());

		// Token: 0x04003045 RID: 12357
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003046 RID: 12358
		public const int IdFieldNumber = 1;

		// Token: 0x04003047 RID: 12359
		private int id_;

		// Token: 0x04003048 RID: 12360
		public const int StatusFieldNumber = 2;

		// Token: 0x04003049 RID: 12361
		private ConditionTaskStatus status_;

		// Token: 0x0400304A RID: 12362
		public const int RateFieldNumber = 3;

		// Token: 0x0400304B RID: 12363
		private int rate_;

		// Token: 0x0400304C RID: 12364
		public const int TargetFieldNumber = 4;

		// Token: 0x0400304D RID: 12365
		private int target_;

		// Token: 0x0400304E RID: 12366
		public const int IsConditionUnlockFieldNumber = 6;

		// Token: 0x0400304F RID: 12367
		private bool isConditionUnlock_;
	}
}
