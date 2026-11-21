using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000B6 RID: 182
	[NetMessage(EMessageId.AddTreasureBoxSlotResponse)]
	public sealed class AddTreasureBoxSlotResponse : IMessage<AddTreasureBoxSlotResponse>, IMessage, IEquatable<AddTreasureBoxSlotResponse>, IDeepCloneable<AddTreasureBoxSlotResponse>, IBufferMessage
	{
		// Token: 0x06001E24 RID: 7716 RVA: 0x00052A16 File Offset: 0x00050C16
		[NullableContext(1)]
		public static AddTreasureBoxSlotResponse Create()
		{
			return new AddTreasureBoxSlotResponse();
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06001E25 RID: 7717 RVA: 0x00052A1D File Offset: 0x00050C1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06001E26 RID: 7718 RVA: 0x00052A20 File Offset: 0x00050C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddTreasureBoxSlotResponse.Descriptor;
			}
		}

		// Token: 0x06001E27 RID: 7719 RVA: 0x00052A27 File Offset: 0x00050C27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddTreasureBoxSlotResponse()
		{
		}

		// Token: 0x06001E28 RID: 7720 RVA: 0x00052A30 File Offset: 0x00050C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddTreasureBoxSlotResponse(AddTreasureBoxSlotResponse other) : this()
		{
			this.code_ = other.code_;
			this.treasureBoxSlotInfo_ = ((other.treasureBoxSlotInfo_ != null) ? other.treasureBoxSlotInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001E29 RID: 7721 RVA: 0x00052A7C File Offset: 0x00050C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddTreasureBoxSlotResponse Clone()
		{
			return new AddTreasureBoxSlotResponse(this);
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06001E2A RID: 7722 RVA: 0x00052A84 File Offset: 0x00050C84
		// (set) Token: 0x06001E2B RID: 7723 RVA: 0x00052A8C File Offset: 0x00050C8C
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

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06001E2C RID: 7724 RVA: 0x00052A95 File Offset: 0x00050C95
		// (set) Token: 0x06001E2D RID: 7725 RVA: 0x00052A9D File Offset: 0x00050C9D
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

		// Token: 0x06001E2E RID: 7726 RVA: 0x00052AA6 File Offset: 0x00050CA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddTreasureBoxSlotResponse);
		}

		// Token: 0x06001E2F RID: 7727 RVA: 0x00052AB4 File Offset: 0x00050CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddTreasureBoxSlotResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this.TreasureBoxSlotInfo, other.TreasureBoxSlotInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001E30 RID: 7728 RVA: 0x00052B04 File Offset: 0x00050D04
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

		// Token: 0x06001E31 RID: 7729 RVA: 0x00052B5F File Offset: 0x00050D5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x00052B6C File Offset: 0x00050D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001E33 RID: 7731 RVA: 0x00052B78 File Offset: 0x00050D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.Code);
			}
			if (this.treasureBoxSlotInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.TreasureBoxSlotInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001E34 RID: 7732 RVA: 0x00052BD4 File Offset: 0x00050DD4
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

		// Token: 0x06001E35 RID: 7733 RVA: 0x00052C2C File Offset: 0x00050E2C
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

		// Token: 0x06001E36 RID: 7734 RVA: 0x00052C94 File Offset: 0x00050E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001E37 RID: 7735 RVA: 0x00052CA0 File Offset: 0x00050EA0
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
				if (num != 40U)
				{
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002398 RID: 9112
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002399 RID: 9113
		public const int CodeFieldNumber = 5;

		// Token: 0x0400239A RID: 9114
		private ErrorCode code_;

		// Token: 0x0400239B RID: 9115
		public const int TreasureBoxSlotInfoFieldNumber = 12;

		// Token: 0x0400239C RID: 9116
		private TreasureBoxSlotInfo treasureBoxSlotInfo_;
	}
}
