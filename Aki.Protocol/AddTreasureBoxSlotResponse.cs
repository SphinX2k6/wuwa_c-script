using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000B5 RID: 181
	[NetMessage(EMessageId.AddTreasureBoxSlotResponse)]
	public sealed class AddTreasureBoxSlotResponse : IMessage<AddTreasureBoxSlotResponse>, IMessage, IEquatable<AddTreasureBoxSlotResponse>, IDeepCloneable<AddTreasureBoxSlotResponse>, IBufferMessage
	{
		// Token: 0x06001DDB RID: 7643 RVA: 0x00051D62 File Offset: 0x0004FF62
		[NullableContext(1)]
		public static AddTreasureBoxSlotResponse Create()
		{
			return new AddTreasureBoxSlotResponse();
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06001DDC RID: 7644 RVA: 0x00051D69 File Offset: 0x0004FF69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06001DDD RID: 7645 RVA: 0x00051D6C File Offset: 0x0004FF6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddTreasureBoxSlotResponse.Descriptor;
			}
		}

		// Token: 0x06001DDE RID: 7646 RVA: 0x00051D73 File Offset: 0x0004FF73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddTreasureBoxSlotResponse()
		{
		}

		// Token: 0x06001DDF RID: 7647 RVA: 0x00051D7C File Offset: 0x0004FF7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddTreasureBoxSlotResponse(AddTreasureBoxSlotResponse other) : this()
		{
			this.code_ = other.code_;
			this.treasureBoxSlotInfo_ = ((other.treasureBoxSlotInfo_ != null) ? other.treasureBoxSlotInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001DE0 RID: 7648 RVA: 0x00051DC8 File Offset: 0x0004FFC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddTreasureBoxSlotResponse Clone()
		{
			return new AddTreasureBoxSlotResponse(this);
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06001DE1 RID: 7649 RVA: 0x00051DD0 File Offset: 0x0004FFD0
		// (set) Token: 0x06001DE2 RID: 7650 RVA: 0x00051DD8 File Offset: 0x0004FFD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06001DE3 RID: 7651 RVA: 0x00051DE1 File Offset: 0x0004FFE1
		// (set) Token: 0x06001DE4 RID: 7652 RVA: 0x00051DE9 File Offset: 0x0004FFE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureBoxSlotInfo TreasureBoxSlotInfo
		{
			get
			{
				return this.treasureBoxSlotInfo_;
			}
			set
			{
				this.treasureBoxSlotInfo_ = value;
			}
		}

		// Token: 0x06001DE5 RID: 7653 RVA: 0x00051DF2 File Offset: 0x0004FFF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddTreasureBoxSlotResponse);
		}

		// Token: 0x06001DE6 RID: 7654 RVA: 0x00051E00 File Offset: 0x00050000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddTreasureBoxSlotResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this.TreasureBoxSlotInfo, other.TreasureBoxSlotInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001DE7 RID: 7655 RVA: 0x00051E50 File Offset: 0x00050050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this.treasureBoxSlotInfo_ != null)
			{
				num ^= this.TreasureBoxSlotInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001DE8 RID: 7656 RVA: 0x00051EAB File Offset: 0x000500AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001DE9 RID: 7657 RVA: 0x00051EB8 File Offset: 0x000500B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001DEA RID: 7658 RVA: 0x00051EC4 File Offset: 0x000500C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.treasureBoxSlotInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.TreasureBoxSlotInfo);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001DEB RID: 7659 RVA: 0x00051F20 File Offset: 0x00050120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this.treasureBoxSlotInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TreasureBoxSlotInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001DEC RID: 7660 RVA: 0x00051F78 File Offset: 0x00050178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AddTreasureBoxSlotResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.treasureBoxSlotInfo_ != null)
			{
				if (this.treasureBoxSlotInfo_ == null)
				{
					this.TreasureBoxSlotInfo = new TreasureBoxSlotInfo();
				}
				this.TreasureBoxSlotInfo.MergeFrom(other.TreasureBoxSlotInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001DED RID: 7661 RVA: 0x00051FE0 File Offset: 0x000501E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001DEE RID: 7662 RVA: 0x00051FEC File Offset: 0x000501EC
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
				if (num != 58U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Code = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					if (this.treasureBoxSlotInfo_ == null)
					{
						this.TreasureBoxSlotInfo = new TreasureBoxSlotInfo();
					}
					input.ReadMessage(this.TreasureBoxSlotInfo);
				}
			}
		}

		// Token: 0x04002335 RID: 9013
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002336 RID: 9014
		public const int CodeFieldNumber = 15;

		// Token: 0x04002337 RID: 9015
		private ErrorCode code_;

		// Token: 0x04002338 RID: 9016
		public const int TreasureBoxSlotInfoFieldNumber = 7;

		// Token: 0x04002339 RID: 9017
		private TreasureBoxSlotInfo treasureBoxSlotInfo_;
	}
}
