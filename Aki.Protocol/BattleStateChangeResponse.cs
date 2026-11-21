using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000183 RID: 387
	[NetMessage(EMessageId.BattleStateChangeResponse)]
	public sealed class BattleStateChangeResponse : IMessage<BattleStateChangeResponse>, IMessage, IEquatable<BattleStateChangeResponse>, IDeepCloneable<BattleStateChangeResponse>, IBufferMessage
	{
		// Token: 0x06002EFC RID: 12028 RVA: 0x00078FDC File Offset: 0x000771DC
		[NullableContext(1)]
		public static BattleStateChangeResponse Create()
		{
			return new BattleStateChangeResponse();
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x06002EFD RID: 12029 RVA: 0x00078FE3 File Offset: 0x000771E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x06002EFE RID: 12030 RVA: 0x00078FE6 File Offset: 0x000771E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattleStateChangeResponse.Descriptor;
			}
		}

		// Token: 0x06002EFF RID: 12031 RVA: 0x00078FED File Offset: 0x000771ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleStateChangeResponse()
		{
		}

		// Token: 0x06002F00 RID: 12032 RVA: 0x00078FF5 File Offset: 0x000771F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleStateChangeResponse(BattleStateChangeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002F01 RID: 12033 RVA: 0x0007901A File Offset: 0x0007721A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleStateChangeResponse Clone()
		{
			return new BattleStateChangeResponse(this);
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06002F02 RID: 12034 RVA: 0x00079022 File Offset: 0x00077222
		// (set) Token: 0x06002F03 RID: 12035 RVA: 0x0007902A File Offset: 0x0007722A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x06002F04 RID: 12036 RVA: 0x00079033 File Offset: 0x00077233
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattleStateChangeResponse);
		}

		// Token: 0x06002F05 RID: 12037 RVA: 0x00079041 File Offset: 0x00077241
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattleStateChangeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002F06 RID: 12038 RVA: 0x00079070 File Offset: 0x00077270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002F07 RID: 12039 RVA: 0x000790B5 File Offset: 0x000772B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002F08 RID: 12040 RVA: 0x000790C2 File Offset: 0x000772C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002F09 RID: 12041 RVA: 0x000790CB File Offset: 0x000772CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002F0A RID: 12042 RVA: 0x00079100 File Offset: 0x00077300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002F0B RID: 12043 RVA: 0x0007913E File Offset: 0x0007733E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattleStateChangeResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002F0C RID: 12044 RVA: 0x0007916F File Offset: 0x0007736F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002F0D RID: 12045 RVA: 0x00079178 File Offset: 0x00077378
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040028EE RID: 10478
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028EF RID: 10479
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x040028F0 RID: 10480
		private ErrorCode errorCode_;
	}
}
