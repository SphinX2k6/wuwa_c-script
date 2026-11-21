using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000326 RID: 806
	[NetMessage(EMessageId.DailyAdventurePtRewardResponse)]
	public sealed class DailyAdventurePtRewardResponse : IMessage<DailyAdventurePtRewardResponse>, IMessage, IEquatable<DailyAdventurePtRewardResponse>, IDeepCloneable<DailyAdventurePtRewardResponse>, IBufferMessage
	{
		// Token: 0x0600514D RID: 20813 RVA: 0x000C66B9 File Offset: 0x000C48B9
		[NullableContext(1)]
		public static DailyAdventurePtRewardResponse Create()
		{
			return new DailyAdventurePtRewardResponse();
		}

		// Token: 0x17000E9D RID: 3741
		// (get) Token: 0x0600514E RID: 20814 RVA: 0x000C66C0 File Offset: 0x000C48C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E9E RID: 3742
		// (get) Token: 0x0600514F RID: 20815 RVA: 0x000C66C3 File Offset: 0x000C48C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DailyAdventurePtRewardResponse.Descriptor;
			}
		}

		// Token: 0x06005150 RID: 20816 RVA: 0x000C66CA File Offset: 0x000C48CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyAdventurePtRewardResponse()
		{
		}

		// Token: 0x06005151 RID: 20817 RVA: 0x000C66D2 File Offset: 0x000C48D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyAdventurePtRewardResponse(DailyAdventurePtRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005152 RID: 20818 RVA: 0x000C66F7 File Offset: 0x000C48F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyAdventurePtRewardResponse Clone()
		{
			return new DailyAdventurePtRewardResponse(this);
		}

		// Token: 0x17000E9F RID: 3743
		// (get) Token: 0x06005153 RID: 20819 RVA: 0x000C66FF File Offset: 0x000C48FF
		// (set) Token: 0x06005154 RID: 20820 RVA: 0x000C6707 File Offset: 0x000C4907
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

		// Token: 0x06005155 RID: 20821 RVA: 0x000C6710 File Offset: 0x000C4910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DailyAdventurePtRewardResponse);
		}

		// Token: 0x06005156 RID: 20822 RVA: 0x000C671E File Offset: 0x000C491E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DailyAdventurePtRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005157 RID: 20823 RVA: 0x000C674C File Offset: 0x000C494C
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

		// Token: 0x06005158 RID: 20824 RVA: 0x000C6791 File Offset: 0x000C4991
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005159 RID: 20825 RVA: 0x000C679E File Offset: 0x000C499E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600515A RID: 20826 RVA: 0x000C67A7 File Offset: 0x000C49A7
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

		// Token: 0x0600515B RID: 20827 RVA: 0x000C67DC File Offset: 0x000C49DC
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

		// Token: 0x0600515C RID: 20828 RVA: 0x000C681A File Offset: 0x000C4A1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DailyAdventurePtRewardResponse other)
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

		// Token: 0x0600515D RID: 20829 RVA: 0x000C684B File Offset: 0x000C4A4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600515E RID: 20830 RVA: 0x000C6854 File Offset: 0x000C4A54
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

		// Token: 0x040032FF RID: 13055
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003300 RID: 13056
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04003301 RID: 13057
		private ErrorCode errorCode_;
	}
}
