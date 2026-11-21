using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001F7 RID: 503
	[NetMessage(EMessageId.BtSetTimerInfoRequest)]
	public sealed class BtSetTimerInfoRequest : IMessage<BtSetTimerInfoRequest>, IMessage, IEquatable<BtSetTimerInfoRequest>, IDeepCloneable<BtSetTimerInfoRequest>, IBufferMessage
	{
		// Token: 0x0600382E RID: 14382 RVA: 0x0008CA81 File Offset: 0x0008AC81
		[NullableContext(1)]
		public static BtSetTimerInfoRequest Create()
		{
			return new BtSetTimerInfoRequest();
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x0600382F RID: 14383 RVA: 0x0008CA88 File Offset: 0x0008AC88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x06003830 RID: 14384 RVA: 0x0008CA8B File Offset: 0x0008AC8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BtSetTimerInfoRequest.Descriptor;
			}
		}

		// Token: 0x06003831 RID: 14385 RVA: 0x0008CA92 File Offset: 0x0008AC92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtSetTimerInfoRequest()
		{
		}

		// Token: 0x06003832 RID: 14386 RVA: 0x0008CAA8 File Offset: 0x0008ACA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtSetTimerInfoRequest(BtSetTimerInfoRequest other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.timerType_ = other.timerType_;
			this.setType_ = other.setType_;
			this.second_ = other.second_;
			this.nodeId_ = other.nodeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003833 RID: 14387 RVA: 0x0008CB14 File Offset: 0x0008AD14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtSetTimerInfoRequest Clone()
		{
			return new BtSetTimerInfoRequest(this);
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x06003834 RID: 14388 RVA: 0x0008CB1C File Offset: 0x0008AD1C
		// (set) Token: 0x06003835 RID: 14389 RVA: 0x0008CB24 File Offset: 0x0008AD24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TreeOwnerId
		{
			get
			{
				return this.treeOwnerId_;
			}
			set
			{
				this.treeOwnerId_ = value;
			}
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x06003836 RID: 14390 RVA: 0x0008CB2D File Offset: 0x0008AD2D
		// (set) Token: 0x06003837 RID: 14391 RVA: 0x0008CB35 File Offset: 0x0008AD35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TreeIncId
		{
			get
			{
				return this.treeIncId_;
			}
			set
			{
				this.treeIncId_ = value;
			}
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x06003838 RID: 14392 RVA: 0x0008CB3E File Offset: 0x0008AD3E
		// (set) Token: 0x06003839 RID: 14393 RVA: 0x0008CB46 File Offset: 0x0008AD46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string TimerType
		{
			get
			{
				return this.timerType_;
			}
			set
			{
				this.timerType_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x0600383A RID: 14394 RVA: 0x0008CB59 File Offset: 0x0008AD59
		// (set) Token: 0x0600383B RID: 14395 RVA: 0x0008CB61 File Offset: 0x0008AD61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimerSetType SetType
		{
			get
			{
				return this.setType_;
			}
			set
			{
				this.setType_ = value;
			}
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x0600383C RID: 14396 RVA: 0x0008CB6A File Offset: 0x0008AD6A
		// (set) Token: 0x0600383D RID: 14397 RVA: 0x0008CB72 File Offset: 0x0008AD72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Second
		{
			get
			{
				return this.second_;
			}
			set
			{
				this.second_ = value;
			}
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x0600383E RID: 14398 RVA: 0x0008CB7B File Offset: 0x0008AD7B
		// (set) Token: 0x0600383F RID: 14399 RVA: 0x0008CB83 File Offset: 0x0008AD83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NodeId
		{
			get
			{
				return this.nodeId_;
			}
			set
			{
				this.nodeId_ = value;
			}
		}

		// Token: 0x06003840 RID: 14400 RVA: 0x0008CB8C File Offset: 0x0008AD8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BtSetTimerInfoRequest);
		}

		// Token: 0x06003841 RID: 14401 RVA: 0x0008CB9C File Offset: 0x0008AD9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BtSetTimerInfoRequest other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && !(this.TimerType != other.TimerType) && this.SetType == other.SetType && this.Second == other.Second && this.NodeId == other.NodeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003842 RID: 14402 RVA: 0x0008CC2C File Offset: 0x0008AE2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TreeOwnerId != 0)
			{
				num ^= this.TreeOwnerId.GetHashCode();
			}
			if (this.TreeIncId != 0L)
			{
				num ^= this.TreeIncId.GetHashCode();
			}
			if (this.TimerType.Length != 0)
			{
				num ^= this.TimerType.GetHashCode();
			}
			if (this.SetType != TimerSetType.Add)
			{
				num ^= this.SetType.GetHashCode();
			}
			if (this.Second != 0)
			{
				num ^= this.Second.GetHashCode();
			}
			if (this.NodeId != 0)
			{
				num ^= this.NodeId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003843 RID: 14403 RVA: 0x0008CCF0 File Offset: 0x0008AEF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003844 RID: 14404 RVA: 0x0008CCFD File Offset: 0x0008AEFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003845 RID: 14405 RVA: 0x0008CD08 File Offset: 0x0008AF08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this.TimerType.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.TimerType);
			}
			if (this.Second != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Second);
			}
			if (this.NodeId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.NodeId);
			}
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.TreeIncId);
			}
			if (this.SetType != TimerSetType.Add)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.SetType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003846 RID: 14406 RVA: 0x0008CDD8 File Offset: 0x0008AFD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TreeOwnerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TreeOwnerId);
			}
			if (this.TreeIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TreeIncId);
			}
			if (this.TimerType.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.TimerType);
			}
			if (this.SetType != TimerSetType.Add)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.SetType);
			}
			if (this.Second != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Second);
			}
			if (this.NodeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NodeId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003847 RID: 14407 RVA: 0x0008CE94 File Offset: 0x0008B094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BtSetTimerInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TreeOwnerId != 0)
			{
				this.TreeOwnerId = other.TreeOwnerId;
			}
			if (other.TreeIncId != 0L)
			{
				this.TreeIncId = other.TreeIncId;
			}
			if (other.TimerType.Length != 0)
			{
				this.TimerType = other.TimerType;
			}
			if (other.SetType != TimerSetType.Add)
			{
				this.SetType = other.SetType;
			}
			if (other.Second != 0)
			{
				this.Second = other.Second;
			}
			if (other.NodeId != 0)
			{
				this.NodeId = other.NodeId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003848 RID: 14408 RVA: 0x0008CF39 File Offset: 0x0008B139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003849 RID: 14409 RVA: 0x0008CF44 File Offset: 0x0008B144
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
				if (num <= 48U)
				{
					if (num == 8U)
					{
						this.TreeOwnerId = input.ReadInt32();
						continue;
					}
					if (num == 18U)
					{
						this.TimerType = input.ReadString();
						continue;
					}
					if (num == 48U)
					{
						this.Second = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.NodeId = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.TreeIncId = input.ReadInt64();
						continue;
					}
					if (num == 96U)
					{
						this.SetType = (TimerSetType)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002B6D RID: 11117
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B6E RID: 11118
		public const int TreeOwnerIdFieldNumber = 1;

		// Token: 0x04002B6F RID: 11119
		private int treeOwnerId_;

		// Token: 0x04002B70 RID: 11120
		public const int TreeIncIdFieldNumber = 11;

		// Token: 0x04002B71 RID: 11121
		private long treeIncId_;

		// Token: 0x04002B72 RID: 11122
		public const int TimerTypeFieldNumber = 2;

		// Token: 0x04002B73 RID: 11123
		private string timerType_ = "";

		// Token: 0x04002B74 RID: 11124
		public const int SetTypeFieldNumber = 12;

		// Token: 0x04002B75 RID: 11125
		private TimerSetType setType_;

		// Token: 0x04002B76 RID: 11126
		public const int SecondFieldNumber = 6;

		// Token: 0x04002B77 RID: 11127
		private int second_;

		// Token: 0x04002B78 RID: 11128
		public const int NodeIdFieldNumber = 10;

		// Token: 0x04002B79 RID: 11129
		private int nodeId_;
	}
}
