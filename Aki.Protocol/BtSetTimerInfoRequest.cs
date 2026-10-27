using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001F2 RID: 498
	[NetMessage(EMessageId.BtSetTimerInfoRequest)]
	public sealed class BtSetTimerInfoRequest : IMessage<BtSetTimerInfoRequest>, IMessage, IEquatable<BtSetTimerInfoRequest>, IDeepCloneable<BtSetTimerInfoRequest>, IBufferMessage
	{
		// Token: 0x06003789 RID: 14217 RVA: 0x0008AE71 File Offset: 0x00089071
		[NullableContext(1)]
		public static BtSetTimerInfoRequest Create()
		{
			return new BtSetTimerInfoRequest();
		}

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x0600378A RID: 14218 RVA: 0x0008AE78 File Offset: 0x00089078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x0600378B RID: 14219 RVA: 0x0008AE7B File Offset: 0x0008907B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BtSetTimerInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600378C RID: 14220 RVA: 0x0008AE82 File Offset: 0x00089082
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtSetTimerInfoRequest()
		{
		}

		// Token: 0x0600378D RID: 14221 RVA: 0x0008AE98 File Offset: 0x00089098
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

		// Token: 0x0600378E RID: 14222 RVA: 0x0008AF04 File Offset: 0x00089104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtSetTimerInfoRequest Clone()
		{
			return new BtSetTimerInfoRequest(this);
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x0600378F RID: 14223 RVA: 0x0008AF0C File Offset: 0x0008910C
		// (set) Token: 0x06003790 RID: 14224 RVA: 0x0008AF14 File Offset: 0x00089114
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

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x06003791 RID: 14225 RVA: 0x0008AF1D File Offset: 0x0008911D
		// (set) Token: 0x06003792 RID: 14226 RVA: 0x0008AF25 File Offset: 0x00089125
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

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x06003793 RID: 14227 RVA: 0x0008AF2E File Offset: 0x0008912E
		// (set) Token: 0x06003794 RID: 14228 RVA: 0x0008AF36 File Offset: 0x00089136
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

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x06003795 RID: 14229 RVA: 0x0008AF49 File Offset: 0x00089149
		// (set) Token: 0x06003796 RID: 14230 RVA: 0x0008AF51 File Offset: 0x00089151
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

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x06003797 RID: 14231 RVA: 0x0008AF5A File Offset: 0x0008915A
		// (set) Token: 0x06003798 RID: 14232 RVA: 0x0008AF62 File Offset: 0x00089162
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

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x06003799 RID: 14233 RVA: 0x0008AF6B File Offset: 0x0008916B
		// (set) Token: 0x0600379A RID: 14234 RVA: 0x0008AF73 File Offset: 0x00089173
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

		// Token: 0x0600379B RID: 14235 RVA: 0x0008AF7C File Offset: 0x0008917C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BtSetTimerInfoRequest);
		}

		// Token: 0x0600379C RID: 14236 RVA: 0x0008AF8C File Offset: 0x0008918C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BtSetTimerInfoRequest other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && !(this.TimerType != other.TimerType) && this.SetType == other.SetType && this.Second == other.Second && this.NodeId == other.NodeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600379D RID: 14237 RVA: 0x0008B01C File Offset: 0x0008921C
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

		// Token: 0x0600379E RID: 14238 RVA: 0x0008B0E0 File Offset: 0x000892E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600379F RID: 14239 RVA: 0x0008B0ED File Offset: 0x000892ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060037A0 RID: 14240 RVA: 0x0008B0F8 File Offset: 0x000892F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this.NodeId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.NodeId);
			}
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.TreeIncId);
			}
			if (this.SetType != TimerSetType.Add)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.SetType);
			}
			if (this.Second != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Second);
			}
			if (this.TimerType.Length != 0)
			{
				output.WriteRawTag(122);
				output.WriteString(this.TimerType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060037A1 RID: 14241 RVA: 0x0008B1C8 File Offset: 0x000893C8
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

		// Token: 0x060037A2 RID: 14242 RVA: 0x0008B284 File Offset: 0x00089484
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

		// Token: 0x060037A3 RID: 14243 RVA: 0x0008B329 File Offset: 0x00089529
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060037A4 RID: 14244 RVA: 0x0008B334 File Offset: 0x00089534
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
				if (num <= 32U)
				{
					if (num == 8U)
					{
						this.TreeOwnerId = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.NodeId = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.TreeIncId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.SetType = (TimerSetType)input.ReadEnum();
						continue;
					}
					if (num == 96U)
					{
						this.Second = input.ReadInt32();
						continue;
					}
					if (num == 122U)
					{
						this.TimerType = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002AEB RID: 10987
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002AEC RID: 10988
		public const int TreeOwnerIdFieldNumber = 1;

		// Token: 0x04002AED RID: 10989
		private int treeOwnerId_;

		// Token: 0x04002AEE RID: 10990
		public const int TreeIncIdFieldNumber = 4;

		// Token: 0x04002AEF RID: 10991
		private long treeIncId_;

		// Token: 0x04002AF0 RID: 10992
		public const int TimerTypeFieldNumber = 15;

		// Token: 0x04002AF1 RID: 10993
		private string timerType_ = "";

		// Token: 0x04002AF2 RID: 10994
		public const int SetTypeFieldNumber = 9;

		// Token: 0x04002AF3 RID: 10995
		private TimerSetType setType_;

		// Token: 0x04002AF4 RID: 10996
		public const int SecondFieldNumber = 12;

		// Token: 0x04002AF5 RID: 10997
		private int second_;

		// Token: 0x04002AF6 RID: 10998
		public const int NodeIdFieldNumber = 3;

		// Token: 0x04002AF7 RID: 10999
		private int nodeId_;
	}
}
