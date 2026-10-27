using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200119F RID: 4511
	public sealed class ScratchCardRewardData : IMessage<ScratchCardRewardData>, IMessage, IEquatable<ScratchCardRewardData>, IDeepCloneable<ScratchCardRewardData>, IBufferMessage
	{
		// Token: 0x06018090 RID: 98448 RVA: 0x0037D5DD File Offset: 0x0037B7DD
		[NullableContext(1)]
		public static ScratchCardRewardData Create()
		{
			return new ScratchCardRewardData();
		}

		// Token: 0x170050C2 RID: 20674
		// (get) Token: 0x06018091 RID: 98449 RVA: 0x0037D5E4 File Offset: 0x0037B7E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ScratchCardRewardData> Parser
		{
			get
			{
				return ScratchCardRewardData._parser;
			}
		}

		// Token: 0x170050C3 RID: 20675
		// (get) Token: 0x06018092 RID: 98450 RVA: 0x0037D5EB File Offset: 0x0037B7EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170050C4 RID: 20676
		// (get) Token: 0x06018093 RID: 98451 RVA: 0x0037D5EE File Offset: 0x0037B7EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ScratchCardRewardData.Descriptor;
			}
		}

		// Token: 0x06018094 RID: 98452 RVA: 0x0037D5F5 File Offset: 0x0037B7F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardRewardData()
		{
		}

		// Token: 0x06018095 RID: 98453 RVA: 0x0037D5FD File Offset: 0x0037B7FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardRewardData(ScratchCardRewardData other) : this()
		{
			this.itemId_ = other.itemId_;
			this.num_ = other.num_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018096 RID: 98454 RVA: 0x0037D62E File Offset: 0x0037B82E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardRewardData Clone()
		{
			return new ScratchCardRewardData(this);
		}

		// Token: 0x170050C5 RID: 20677
		// (get) Token: 0x06018097 RID: 98455 RVA: 0x0037D636 File Offset: 0x0037B836
		// (set) Token: 0x06018098 RID: 98456 RVA: 0x0037D63E File Offset: 0x0037B83E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x170050C6 RID: 20678
		// (get) Token: 0x06018099 RID: 98457 RVA: 0x0037D647 File Offset: 0x0037B847
		// (set) Token: 0x0601809A RID: 98458 RVA: 0x0037D64F File Offset: 0x0037B84F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Num
		{
			get
			{
				return this.num_;
			}
			set
			{
				this.num_ = value;
			}
		}

		// Token: 0x0601809B RID: 98459 RVA: 0x0037D658 File Offset: 0x0037B858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ScratchCardRewardData);
		}

		// Token: 0x0601809C RID: 98460 RVA: 0x0037D666 File Offset: 0x0037B866
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ScratchCardRewardData other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.Num == other.Num && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601809D RID: 98461 RVA: 0x0037D6A4 File Offset: 0x0037B8A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.Num != 0)
			{
				num ^= this.Num.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601809E RID: 98462 RVA: 0x0037D6FC File Offset: 0x0037B8FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601809F RID: 98463 RVA: 0x0037D709 File Offset: 0x0037B909
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060180A0 RID: 98464 RVA: 0x0037D714 File Offset: 0x0037B914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.Num != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Num);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060180A1 RID: 98465 RVA: 0x0037D76C File Offset: 0x0037B96C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.Num != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Num);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060180A2 RID: 98466 RVA: 0x0037D7C4 File Offset: 0x0037B9C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ScratchCardRewardData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.Num != 0)
			{
				this.Num = other.Num;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060180A3 RID: 98467 RVA: 0x0037D814 File Offset: 0x0037BA14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060180A4 RID: 98468 RVA: 0x0037D820 File Offset: 0x0037BA20
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
						this.Num = input.ReadInt32();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008E47 RID: 36423
		private static readonly MessageParser<ScratchCardRewardData> _parser = new MessageParser<ScratchCardRewardData>(() => new ScratchCardRewardData());

		// Token: 0x04008E48 RID: 36424
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E49 RID: 36425
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04008E4A RID: 36426
		private int itemId_;

		// Token: 0x04008E4B RID: 36427
		public const int NumFieldNumber = 2;

		// Token: 0x04008E4C RID: 36428
		private int num_;
	}
}
