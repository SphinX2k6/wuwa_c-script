using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014D4 RID: 5332
	public sealed class TreasureBoxSlotInfo : IMessage<TreasureBoxSlotInfo>, IMessage, IEquatable<TreasureBoxSlotInfo>, IDeepCloneable<TreasureBoxSlotInfo>, IBufferMessage
	{
		// Token: 0x0601C475 RID: 115829 RVA: 0x0041A6D1 File Offset: 0x004188D1
		[NullableContext(1)]
		public static TreasureBoxSlotInfo Create()
		{
			return new TreasureBoxSlotInfo();
		}

		// Token: 0x17005FB2 RID: 24498
		// (get) Token: 0x0601C476 RID: 115830 RVA: 0x0041A6D8 File Offset: 0x004188D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TreasureBoxSlotInfo> Parser
		{
			get
			{
				return TreasureBoxSlotInfo._parser;
			}
		}

		// Token: 0x17005FB3 RID: 24499
		// (get) Token: 0x0601C477 RID: 115831 RVA: 0x0041A6DF File Offset: 0x004188DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005FB4 RID: 24500
		// (get) Token: 0x0601C478 RID: 115832 RVA: 0x0041A6E2 File Offset: 0x004188E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TreasureBoxSlotInfo.Descriptor;
			}
		}

		// Token: 0x0601C479 RID: 115833 RVA: 0x0041A6E9 File Offset: 0x004188E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureBoxSlotInfo()
		{
		}

		// Token: 0x0601C47A RID: 115834 RVA: 0x0041A6F1 File Offset: 0x004188F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureBoxSlotInfo(TreasureBoxSlotInfo other) : this()
		{
			this.detectionSlotId_ = other.detectionSlotId_;
			this.markId_ = other.markId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C47B RID: 115835 RVA: 0x0041A722 File Offset: 0x00418922
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureBoxSlotInfo Clone()
		{
			return new TreasureBoxSlotInfo(this);
		}

		// Token: 0x17005FB5 RID: 24501
		// (get) Token: 0x0601C47C RID: 115836 RVA: 0x0041A72A File Offset: 0x0041892A
		// (set) Token: 0x0601C47D RID: 115837 RVA: 0x0041A732 File Offset: 0x00418932
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long DetectionSlotId
		{
			get
			{
				return this.detectionSlotId_;
			}
			set
			{
				this.detectionSlotId_ = value;
			}
		}

		// Token: 0x17005FB6 RID: 24502
		// (get) Token: 0x0601C47E RID: 115838 RVA: 0x0041A73B File Offset: 0x0041893B
		// (set) Token: 0x0601C47F RID: 115839 RVA: 0x0041A743 File Offset: 0x00418943
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MarkId
		{
			get
			{
				return this.markId_;
			}
			set
			{
				this.markId_ = value;
			}
		}

		// Token: 0x0601C480 RID: 115840 RVA: 0x0041A74C File Offset: 0x0041894C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TreasureBoxSlotInfo);
		}

		// Token: 0x0601C481 RID: 115841 RVA: 0x0041A75A File Offset: 0x0041895A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TreasureBoxSlotInfo other)
		{
			return other != null && (other == this || (this.DetectionSlotId == other.DetectionSlotId && this.MarkId == other.MarkId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C482 RID: 115842 RVA: 0x0041A798 File Offset: 0x00418998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DetectionSlotId != 0L)
			{
				num ^= this.DetectionSlotId.GetHashCode();
			}
			if (this.MarkId != 0)
			{
				num ^= this.MarkId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C483 RID: 115843 RVA: 0x0041A7F0 File Offset: 0x004189F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C484 RID: 115844 RVA: 0x0041A7FD File Offset: 0x004189FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C485 RID: 115845 RVA: 0x0041A808 File Offset: 0x00418A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DetectionSlotId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.DetectionSlotId);
			}
			if (this.MarkId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.MarkId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C486 RID: 115846 RVA: 0x0041A860 File Offset: 0x00418A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DetectionSlotId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.DetectionSlotId);
			}
			if (this.MarkId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MarkId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C487 RID: 115847 RVA: 0x0041A8B8 File Offset: 0x00418AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TreasureBoxSlotInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DetectionSlotId != 0L)
			{
				this.DetectionSlotId = other.DetectionSlotId;
			}
			if (other.MarkId != 0)
			{
				this.MarkId = other.MarkId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C488 RID: 115848 RVA: 0x0041A908 File Offset: 0x00418B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C489 RID: 115849 RVA: 0x0041A914 File Offset: 0x00418B14
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.MarkId = input.ReadInt32();
					}
				}
				else
				{
					this.DetectionSlotId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400A369 RID: 41833
		private static readonly MessageParser<TreasureBoxSlotInfo> _parser = new MessageParser<TreasureBoxSlotInfo>(() => new TreasureBoxSlotInfo());

		// Token: 0x0400A36A RID: 41834
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A36B RID: 41835
		public const int DetectionSlotIdFieldNumber = 1;

		// Token: 0x0400A36C RID: 41836
		private long detectionSlotId_;

		// Token: 0x0400A36D RID: 41837
		public const int MarkIdFieldNumber = 2;

		// Token: 0x0400A36E RID: 41838
		private int markId_;
	}
}
