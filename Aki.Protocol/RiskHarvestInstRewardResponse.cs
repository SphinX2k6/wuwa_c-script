using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F51 RID: 3921
	[NetMessage(EMessageId.RiskHarvestInstRewardResponse)]
	public sealed class RiskHarvestInstRewardResponse : IMessage<RiskHarvestInstRewardResponse>, IMessage, IEquatable<RiskHarvestInstRewardResponse>, IDeepCloneable<RiskHarvestInstRewardResponse>, IBufferMessage
	{
		// Token: 0x06015005 RID: 86021 RVA: 0x0030C85D File Offset: 0x0030AA5D
		[NullableContext(1)]
		public static RiskHarvestInstRewardResponse Create()
		{
			return new RiskHarvestInstRewardResponse();
		}

		// Token: 0x170045E4 RID: 17892
		// (get) Token: 0x06015006 RID: 86022 RVA: 0x0030C864 File Offset: 0x0030AA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170045E5 RID: 17893
		// (get) Token: 0x06015007 RID: 86023 RVA: 0x0030C867 File Offset: 0x0030AA67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RiskHarvestInstRewardResponse.Descriptor;
			}
		}

		// Token: 0x06015008 RID: 86024 RVA: 0x0030C86E File Offset: 0x0030AA6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestInstRewardResponse()
		{
		}

		// Token: 0x06015009 RID: 86025 RVA: 0x0030C876 File Offset: 0x0030AA76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestInstRewardResponse(RiskHarvestInstRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601500A RID: 86026 RVA: 0x0030C89B File Offset: 0x0030AA9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestInstRewardResponse Clone()
		{
			return new RiskHarvestInstRewardResponse(this);
		}

		// Token: 0x170045E6 RID: 17894
		// (get) Token: 0x0601500B RID: 86027 RVA: 0x0030C8A3 File Offset: 0x0030AAA3
		// (set) Token: 0x0601500C RID: 86028 RVA: 0x0030C8AB File Offset: 0x0030AAAB
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

		// Token: 0x0601500D RID: 86029 RVA: 0x0030C8B4 File Offset: 0x0030AAB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RiskHarvestInstRewardResponse);
		}

		// Token: 0x0601500E RID: 86030 RVA: 0x0030C8C2 File Offset: 0x0030AAC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RiskHarvestInstRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601500F RID: 86031 RVA: 0x0030C8F0 File Offset: 0x0030AAF0
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

		// Token: 0x06015010 RID: 86032 RVA: 0x0030C935 File Offset: 0x0030AB35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015011 RID: 86033 RVA: 0x0030C942 File Offset: 0x0030AB42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015012 RID: 86034 RVA: 0x0030C94B File Offset: 0x0030AB4B
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

		// Token: 0x06015013 RID: 86035 RVA: 0x0030C980 File Offset: 0x0030AB80
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

		// Token: 0x06015014 RID: 86036 RVA: 0x0030C9BE File Offset: 0x0030ABBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RiskHarvestInstRewardResponse other)
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

		// Token: 0x06015015 RID: 86037 RVA: 0x0030C9EF File Offset: 0x0030ABEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015016 RID: 86038 RVA: 0x0030C9F8 File Offset: 0x0030ABF8
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

		// Token: 0x04007F05 RID: 32517
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F06 RID: 32518
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04007F07 RID: 32519
		private ErrorCode errorCode_;
	}
}
