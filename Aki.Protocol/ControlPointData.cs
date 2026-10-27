using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002F0 RID: 752
	public sealed class ControlPointData : IMessage<ControlPointData>, IMessage, IEquatable<ControlPointData>, IDeepCloneable<ControlPointData>, IBufferMessage
	{
		// Token: 0x06004C47 RID: 19527 RVA: 0x000B99B0 File Offset: 0x000B7BB0
		[NullableContext(1)]
		public static ControlPointData Create()
		{
			return new ControlPointData();
		}

		// Token: 0x17000D6E RID: 3438
		// (get) Token: 0x06004C48 RID: 19528 RVA: 0x000B99B7 File Offset: 0x000B7BB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ControlPointData> Parser
		{
			get
			{
				return ControlPointData._parser;
			}
		}

		// Token: 0x17000D6F RID: 3439
		// (get) Token: 0x06004C49 RID: 19529 RVA: 0x000B99BE File Offset: 0x000B7BBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D70 RID: 3440
		// (get) Token: 0x06004C4A RID: 19530 RVA: 0x000B99C1 File Offset: 0x000B7BC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ControlPointData.Descriptor;
			}
		}

		// Token: 0x06004C4B RID: 19531 RVA: 0x000B99C8 File Offset: 0x000B7BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ControlPointData()
		{
		}

		// Token: 0x06004C4C RID: 19532 RVA: 0x000B99D0 File Offset: 0x000B7BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ControlPointData(ControlPointData other) : this()
		{
			this.controlPointIndex_ = other.controlPointIndex_;
			this.leftEnable_ = other.leftEnable_;
			this.rightEnable_ = other.rightEnable_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004C4D RID: 19533 RVA: 0x000B9A0D File Offset: 0x000B7C0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ControlPointData Clone()
		{
			return new ControlPointData(this);
		}

		// Token: 0x17000D71 RID: 3441
		// (get) Token: 0x06004C4E RID: 19534 RVA: 0x000B9A15 File Offset: 0x000B7C15
		// (set) Token: 0x06004C4F RID: 19535 RVA: 0x000B9A1D File Offset: 0x000B7C1D
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

		// Token: 0x17000D72 RID: 3442
		// (get) Token: 0x06004C50 RID: 19536 RVA: 0x000B9A26 File Offset: 0x000B7C26
		// (set) Token: 0x06004C51 RID: 19537 RVA: 0x000B9A2E File Offset: 0x000B7C2E
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

		// Token: 0x17000D73 RID: 3443
		// (get) Token: 0x06004C52 RID: 19538 RVA: 0x000B9A37 File Offset: 0x000B7C37
		// (set) Token: 0x06004C53 RID: 19539 RVA: 0x000B9A3F File Offset: 0x000B7C3F
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

		// Token: 0x06004C54 RID: 19540 RVA: 0x000B9A48 File Offset: 0x000B7C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ControlPointData);
		}

		// Token: 0x06004C55 RID: 19541 RVA: 0x000B9A58 File Offset: 0x000B7C58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ControlPointData other)
		{
			return other != null && (other == this || (this.ControlPointIndex == other.ControlPointIndex && this.LeftEnable == other.LeftEnable && this.RightEnable == other.RightEnable && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004C56 RID: 19542 RVA: 0x000B9AB4 File Offset: 0x000B7CB4
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

		// Token: 0x06004C57 RID: 19543 RVA: 0x000B9B25 File Offset: 0x000B7D25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004C58 RID: 19544 RVA: 0x000B9B32 File Offset: 0x000B7D32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004C59 RID: 19545 RVA: 0x000B9B3C File Offset: 0x000B7D3C
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

		// Token: 0x06004C5A RID: 19546 RVA: 0x000B9BB0 File Offset: 0x000B7DB0
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

		// Token: 0x06004C5B RID: 19547 RVA: 0x000B9C08 File Offset: 0x000B7E08
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

		// Token: 0x06004C5C RID: 19548 RVA: 0x000B9C6C File Offset: 0x000B7E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004C5D RID: 19549 RVA: 0x000B9C78 File Offset: 0x000B7E78
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

		// Token: 0x040030ED RID: 12525
		private static readonly MessageParser<ControlPointData> _parser = new MessageParser<ControlPointData>(() => new ControlPointData());

		// Token: 0x040030EE RID: 12526
		private UnknownFieldSet _unknownFields;

		// Token: 0x040030EF RID: 12527
		public const int ControlPointIndexFieldNumber = 1;

		// Token: 0x040030F0 RID: 12528
		private int controlPointIndex_;

		// Token: 0x040030F1 RID: 12529
		public const int LeftEnableFieldNumber = 2;

		// Token: 0x040030F2 RID: 12530
		private bool leftEnable_;

		// Token: 0x040030F3 RID: 12531
		public const int RightEnableFieldNumber = 3;

		// Token: 0x040030F4 RID: 12532
		private bool rightEnable_;
	}
}
