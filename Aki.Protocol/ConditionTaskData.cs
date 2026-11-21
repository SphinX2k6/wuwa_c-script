using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002D6 RID: 726
	public sealed class ConditionTaskData : IMessage<ConditionTaskData>, IMessage, IEquatable<ConditionTaskData>, IDeepCloneable<ConditionTaskData>, IBufferMessage
	{
		// Token: 0x06004A8F RID: 19087 RVA: 0x000B68D4 File Offset: 0x000B4AD4
		[NullableContext(1)]
		public static ConditionTaskData Create()
		{
			return new ConditionTaskData();
		}

		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x06004A90 RID: 19088 RVA: 0x000B68DB File Offset: 0x000B4ADB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ConditionTaskData> Parser
		{
			get
			{
				return ConditionTaskData._parser;
			}
		}

		// Token: 0x17000D18 RID: 3352
		// (get) Token: 0x06004A91 RID: 19089 RVA: 0x000B68E2 File Offset: 0x000B4AE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D19 RID: 3353
		// (get) Token: 0x06004A92 RID: 19090 RVA: 0x000B68E5 File Offset: 0x000B4AE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConditionTaskData.Descriptor;
			}
		}

		// Token: 0x06004A93 RID: 19091 RVA: 0x000B68EC File Offset: 0x000B4AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionTaskData()
		{
		}

		// Token: 0x06004A94 RID: 19092 RVA: 0x000B68F4 File Offset: 0x000B4AF4
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

		// Token: 0x06004A95 RID: 19093 RVA: 0x000B6954 File Offset: 0x000B4B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionTaskData Clone()
		{
			return new ConditionTaskData(this);
		}

		// Token: 0x17000D1A RID: 3354
		// (get) Token: 0x06004A96 RID: 19094 RVA: 0x000B695C File Offset: 0x000B4B5C
		// (set) Token: 0x06004A97 RID: 19095 RVA: 0x000B6964 File Offset: 0x000B4B64
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

		// Token: 0x17000D1B RID: 3355
		// (get) Token: 0x06004A98 RID: 19096 RVA: 0x000B696D File Offset: 0x000B4B6D
		// (set) Token: 0x06004A99 RID: 19097 RVA: 0x000B6975 File Offset: 0x000B4B75
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

		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x06004A9A RID: 19098 RVA: 0x000B697E File Offset: 0x000B4B7E
		// (set) Token: 0x06004A9B RID: 19099 RVA: 0x000B6986 File Offset: 0x000B4B86
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

		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x06004A9C RID: 19100 RVA: 0x000B698F File Offset: 0x000B4B8F
		// (set) Token: 0x06004A9D RID: 19101 RVA: 0x000B6997 File Offset: 0x000B4B97
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

		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x06004A9E RID: 19102 RVA: 0x000B69A0 File Offset: 0x000B4BA0
		// (set) Token: 0x06004A9F RID: 19103 RVA: 0x000B69A8 File Offset: 0x000B4BA8
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

		// Token: 0x06004AA0 RID: 19104 RVA: 0x000B69B1 File Offset: 0x000B4BB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConditionTaskData);
		}

		// Token: 0x06004AA1 RID: 19105 RVA: 0x000B69C0 File Offset: 0x000B4BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConditionTaskData other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Status == other.Status && this.Rate == other.Rate && this.Target == other.Target && this.IsConditionUnlock == other.IsConditionUnlock && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004AA2 RID: 19106 RVA: 0x000B6A3C File Offset: 0x000B4C3C
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

		// Token: 0x06004AA3 RID: 19107 RVA: 0x000B6AE5 File Offset: 0x000B4CE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004AA4 RID: 19108 RVA: 0x000B6AF2 File Offset: 0x000B4CF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004AA5 RID: 19109 RVA: 0x000B6AFC File Offset: 0x000B4CFC
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

		// Token: 0x06004AA6 RID: 19110 RVA: 0x000B6BA8 File Offset: 0x000B4DA8
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

		// Token: 0x06004AA7 RID: 19111 RVA: 0x000B6C3C File Offset: 0x000B4E3C
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

		// Token: 0x06004AA8 RID: 19112 RVA: 0x000B6CC8 File Offset: 0x000B4EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004AA9 RID: 19113 RVA: 0x000B6CD4 File Offset: 0x000B4ED4
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

		// Token: 0x040030DB RID: 12507
		private static readonly MessageParser<ConditionTaskData> _parser = new MessageParser<ConditionTaskData>(() => new ConditionTaskData());

		// Token: 0x040030DC RID: 12508
		private UnknownFieldSet _unknownFields;

		// Token: 0x040030DD RID: 12509
		public const int IdFieldNumber = 1;

		// Token: 0x040030DE RID: 12510
		private int id_;

		// Token: 0x040030DF RID: 12511
		public const int StatusFieldNumber = 2;

		// Token: 0x040030E0 RID: 12512
		private ConditionTaskStatus status_;

		// Token: 0x040030E1 RID: 12513
		public const int RateFieldNumber = 3;

		// Token: 0x040030E2 RID: 12514
		private int rate_;

		// Token: 0x040030E3 RID: 12515
		public const int TargetFieldNumber = 4;

		// Token: 0x040030E4 RID: 12516
		private int target_;

		// Token: 0x040030E5 RID: 12517
		public const int IsConditionUnlockFieldNumber = 6;

		// Token: 0x040030E6 RID: 12518
		private bool isConditionUnlock_;
	}
}
