using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002F7 RID: 759
	public sealed class ControlPointData : IMessage<ControlPointData>, IMessage, IEquatable<ControlPointData>, IDeepCloneable<ControlPointData>, IBufferMessage
	{
		// Token: 0x06004D20 RID: 19744 RVA: 0x000BBD98 File Offset: 0x000B9F98
		[NullableContext(1)]
		public static ControlPointData Create()
		{
			return new ControlPointData();
		}

		// Token: 0x17000D9B RID: 3483
		// (get) Token: 0x06004D21 RID: 19745 RVA: 0x000BBD9F File Offset: 0x000B9F9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ControlPointData> Parser
		{
			get
			{
				return ControlPointData._parser;
			}
		}

		// Token: 0x17000D9C RID: 3484
		// (get) Token: 0x06004D22 RID: 19746 RVA: 0x000BBDA6 File Offset: 0x000B9FA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D9D RID: 3485
		// (get) Token: 0x06004D23 RID: 19747 RVA: 0x000BBDA9 File Offset: 0x000B9FA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ControlPointData.Descriptor;
			}
		}

		// Token: 0x06004D24 RID: 19748 RVA: 0x000BBDB0 File Offset: 0x000B9FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ControlPointData()
		{
		}

		// Token: 0x06004D25 RID: 19749 RVA: 0x000BBDB8 File Offset: 0x000B9FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ControlPointData(ControlPointData other) : this()
		{
			this.controlPointIndex_ = other.controlPointIndex_;
			this.leftEnable_ = other.leftEnable_;
			this.rightEnable_ = other.rightEnable_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004D26 RID: 19750 RVA: 0x000BBDF5 File Offset: 0x000B9FF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ControlPointData Clone()
		{
			return new ControlPointData(this);
		}

		// Token: 0x17000D9E RID: 3486
		// (get) Token: 0x06004D27 RID: 19751 RVA: 0x000BBDFD File Offset: 0x000B9FFD
		// (set) Token: 0x06004D28 RID: 19752 RVA: 0x000BBE05 File Offset: 0x000BA005
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ControlPointIndex
		{
			get
			{
				return this.controlPointIndex_;
			}
			set
			{
				this.controlPointIndex_ = value;
			}
		}

		// Token: 0x17000D9F RID: 3487
		// (get) Token: 0x06004D29 RID: 19753 RVA: 0x000BBE0E File Offset: 0x000BA00E
		// (set) Token: 0x06004D2A RID: 19754 RVA: 0x000BBE16 File Offset: 0x000BA016
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool LeftEnable
		{
			get
			{
				return this.leftEnable_;
			}
			set
			{
				this.leftEnable_ = value;
			}
		}

		// Token: 0x17000DA0 RID: 3488
		// (get) Token: 0x06004D2B RID: 19755 RVA: 0x000BBE1F File Offset: 0x000BA01F
		// (set) Token: 0x06004D2C RID: 19756 RVA: 0x000BBE27 File Offset: 0x000BA027
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool RightEnable
		{
			get
			{
				return this.rightEnable_;
			}
			set
			{
				this.rightEnable_ = value;
			}
		}

		// Token: 0x06004D2D RID: 19757 RVA: 0x000BBE30 File Offset: 0x000BA030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ControlPointData);
		}

		// Token: 0x06004D2E RID: 19758 RVA: 0x000BBE40 File Offset: 0x000BA040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ControlPointData other)
		{
			return other != null && (other == this || (this.ControlPointIndex == other.ControlPointIndex && this.LeftEnable == other.LeftEnable && this.RightEnable == other.RightEnable && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004D2F RID: 19759 RVA: 0x000BBE9C File Offset: 0x000BA09C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ControlPointIndex != 0)
			{
				num ^= this.ControlPointIndex.GetHashCode();
			}
			if (this.LeftEnable)
			{
				num ^= this.LeftEnable.GetHashCode();
			}
			if (this.RightEnable)
			{
				num ^= this.RightEnable.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004D30 RID: 19760 RVA: 0x000BBF0D File Offset: 0x000BA10D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004D31 RID: 19761 RVA: 0x000BBF1A File Offset: 0x000BA11A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004D32 RID: 19762 RVA: 0x000BBF24 File Offset: 0x000BA124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ControlPointIndex != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ControlPointIndex);
			}
			if (this.LeftEnable)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.LeftEnable);
			}
			if (this.RightEnable)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.RightEnable);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004D33 RID: 19763 RVA: 0x000BBF98 File Offset: 0x000BA198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ControlPointIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ControlPointIndex);
			}
			if (this.LeftEnable)
			{
				num += 2;
			}
			if (this.RightEnable)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004D34 RID: 19764 RVA: 0x000BBFF0 File Offset: 0x000BA1F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ControlPointData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ControlPointIndex != 0)
			{
				this.ControlPointIndex = other.ControlPointIndex;
			}
			if (other.LeftEnable)
			{
				this.LeftEnable = other.LeftEnable;
			}
			if (other.RightEnable)
			{
				this.RightEnable = other.RightEnable;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004D35 RID: 19765 RVA: 0x000BC054 File Offset: 0x000BA254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004D36 RID: 19766 RVA: 0x000BC060 File Offset: 0x000BA260
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.RightEnable = input.ReadBool();
						}
					}
					else
					{
						this.LeftEnable = input.ReadBool();
					}
				}
				else
				{
					this.ControlPointIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003184 RID: 12676
		private static readonly MessageParser<ControlPointData> _parser = new MessageParser<ControlPointData>(() => new ControlPointData());

		// Token: 0x04003185 RID: 12677
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003186 RID: 12678
		public const int ControlPointIndexFieldNumber = 1;

		// Token: 0x04003187 RID: 12679
		private int controlPointIndex_;

		// Token: 0x04003188 RID: 12680
		public const int LeftEnableFieldNumber = 2;

		// Token: 0x04003189 RID: 12681
		private bool leftEnable_;

		// Token: 0x0400318A RID: 12682
		public const int RightEnableFieldNumber = 3;

		// Token: 0x0400318B RID: 12683
		private bool rightEnable_;
	}
}
