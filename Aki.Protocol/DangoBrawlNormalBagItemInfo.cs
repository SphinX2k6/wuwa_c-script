using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000363 RID: 867
	public sealed class DangoBrawlNormalBagItemInfo : IMessage<DangoBrawlNormalBagItemInfo>, IMessage, IEquatable<DangoBrawlNormalBagItemInfo>, IDeepCloneable<DangoBrawlNormalBagItemInfo>, IBufferMessage
	{
		// Token: 0x06005670 RID: 22128 RVA: 0x000D3219 File Offset: 0x000D1419
		[NullableContext(1)]
		public static DangoBrawlNormalBagItemInfo Create()
		{
			return new DangoBrawlNormalBagItemInfo();
		}

		// Token: 0x17000FDB RID: 4059
		// (get) Token: 0x06005671 RID: 22129 RVA: 0x000D3220 File Offset: 0x000D1420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DangoBrawlNormalBagItemInfo> Parser
		{
			get
			{
				return DangoBrawlNormalBagItemInfo._parser;
			}
		}

		// Token: 0x17000FDC RID: 4060
		// (get) Token: 0x06005672 RID: 22130 RVA: 0x000D3227 File Offset: 0x000D1427
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000FDD RID: 4061
		// (get) Token: 0x06005673 RID: 22131 RVA: 0x000D322A File Offset: 0x000D142A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlNormalBagItemInfo.Descriptor;
			}
		}

		// Token: 0x06005674 RID: 22132 RVA: 0x000D3231 File Offset: 0x000D1431
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlNormalBagItemInfo()
		{
		}

		// Token: 0x06005675 RID: 22133 RVA: 0x000D323C File Offset: 0x000D143C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlNormalBagItemInfo(DangoBrawlNormalBagItemInfo other) : this()
		{
			this.inst_ = ((other.inst_ != null) ? other.inst_.Clone() : null);
			this.x_ = other.x_;
			this.y_ = other.y_;
			this.rotation_ = other.rotation_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005676 RID: 22134 RVA: 0x000D32A0 File Offset: 0x000D14A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlNormalBagItemInfo Clone()
		{
			return new DangoBrawlNormalBagItemInfo(this);
		}

		// Token: 0x17000FDE RID: 4062
		// (get) Token: 0x06005677 RID: 22135 RVA: 0x000D32A8 File Offset: 0x000D14A8
		// (set) Token: 0x06005678 RID: 22136 RVA: 0x000D32B0 File Offset: 0x000D14B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBaseItemInfo Inst
		{
			get
			{
				return this.inst_;
			}
			set
			{
				this.inst_ = value;
			}
		}

		// Token: 0x17000FDF RID: 4063
		// (get) Token: 0x06005679 RID: 22137 RVA: 0x000D32B9 File Offset: 0x000D14B9
		// (set) Token: 0x0600567A RID: 22138 RVA: 0x000D32C1 File Offset: 0x000D14C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int X
		{
			get
			{
				return this.x_;
			}
			set
			{
				this.x_ = value;
			}
		}

		// Token: 0x17000FE0 RID: 4064
		// (get) Token: 0x0600567B RID: 22139 RVA: 0x000D32CA File Offset: 0x000D14CA
		// (set) Token: 0x0600567C RID: 22140 RVA: 0x000D32D2 File Offset: 0x000D14D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Y
		{
			get
			{
				return this.y_;
			}
			set
			{
				this.y_ = value;
			}
		}

		// Token: 0x17000FE1 RID: 4065
		// (get) Token: 0x0600567D RID: 22141 RVA: 0x000D32DB File Offset: 0x000D14DB
		// (set) Token: 0x0600567E RID: 22142 RVA: 0x000D32E3 File Offset: 0x000D14E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Rotation
		{
			get
			{
				return this.rotation_;
			}
			set
			{
				this.rotation_ = value;
			}
		}

		// Token: 0x0600567F RID: 22143 RVA: 0x000D32EC File Offset: 0x000D14EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlNormalBagItemInfo);
		}

		// Token: 0x06005680 RID: 22144 RVA: 0x000D32FC File Offset: 0x000D14FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlNormalBagItemInfo other)
		{
			return other != null && (other == this || (object.Equals(this.Inst, other.Inst) && this.X == other.X && this.Y == other.Y && this.Rotation == other.Rotation && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005681 RID: 22145 RVA: 0x000D336C File Offset: 0x000D156C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.inst_ != null)
			{
				num ^= this.Inst.GetHashCode();
			}
			if (this.X != 0)
			{
				num ^= this.X.GetHashCode();
			}
			if (this.Y != 0)
			{
				num ^= this.Y.GetHashCode();
			}
			if (this.Rotation != 0)
			{
				num ^= this.Rotation.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005682 RID: 22146 RVA: 0x000D33F3 File Offset: 0x000D15F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005683 RID: 22147 RVA: 0x000D3400 File Offset: 0x000D1600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005684 RID: 22148 RVA: 0x000D340C File Offset: 0x000D160C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.inst_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Inst);
			}
			if (this.X != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.X);
			}
			if (this.Y != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Y);
			}
			if (this.Rotation != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Rotation);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005685 RID: 22149 RVA: 0x000D34A0 File Offset: 0x000D16A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.inst_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Inst);
			}
			if (this.X != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.X);
			}
			if (this.Y != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Y);
			}
			if (this.Rotation != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Rotation);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005686 RID: 22150 RVA: 0x000D3528 File Offset: 0x000D1728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlNormalBagItemInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.inst_ != null)
			{
				if (this.inst_ == null)
				{
					this.Inst = new DangoBrawlBaseItemInfo();
				}
				this.Inst.MergeFrom(other.Inst);
			}
			if (other.X != 0)
			{
				this.X = other.X;
			}
			if (other.Y != 0)
			{
				this.Y = other.Y;
			}
			if (other.Rotation != 0)
			{
				this.Rotation = other.Rotation;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005687 RID: 22151 RVA: 0x000D35B8 File Offset: 0x000D17B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005688 RID: 22152 RVA: 0x000D35C4 File Offset: 0x000D17C4
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
					if (num == 10U)
					{
						if (this.inst_ == null)
						{
							this.Inst = new DangoBrawlBaseItemInfo();
						}
						input.ReadMessage(this.Inst);
						continue;
					}
					if (num == 16U)
					{
						this.X = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Y = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.Rotation = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400347A RID: 13434
		private static readonly MessageParser<DangoBrawlNormalBagItemInfo> _parser = new MessageParser<DangoBrawlNormalBagItemInfo>(() => new DangoBrawlNormalBagItemInfo());

		// Token: 0x0400347B RID: 13435
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400347C RID: 13436
		public const int InstFieldNumber = 1;

		// Token: 0x0400347D RID: 13437
		private DangoBrawlBaseItemInfo inst_;

		// Token: 0x0400347E RID: 13438
		public const int XFieldNumber = 2;

		// Token: 0x0400347F RID: 13439
		private int x_;

		// Token: 0x04003480 RID: 13440
		public const int YFieldNumber = 3;

		// Token: 0x04003481 RID: 13441
		private int y_;

		// Token: 0x04003482 RID: 13442
		public const int RotationFieldNumber = 4;

		// Token: 0x04003483 RID: 13443
		private int rotation_;
	}
}
