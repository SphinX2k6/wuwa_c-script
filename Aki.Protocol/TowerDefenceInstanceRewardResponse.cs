using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001416 RID: 5142
	[NetMessage(EMessageId.TowerDefenceInstanceRewardResponse)]
	public sealed class TowerDefenceInstanceRewardResponse : IMessage<TowerDefenceInstanceRewardResponse>, IMessage, IEquatable<TowerDefenceInstanceRewardResponse>, IDeepCloneable<TowerDefenceInstanceRewardResponse>, IBufferMessage
	{
		// Token: 0x0601B551 RID: 111953 RVA: 0x003F995D File Offset: 0x003F7B5D
		[NullableContext(1)]
		public static TowerDefenceInstanceRewardResponse Create()
		{
			return new TowerDefenceInstanceRewardResponse();
		}

		// Token: 0x17005C86 RID: 23686
		// (get) Token: 0x0601B552 RID: 111954 RVA: 0x003F9964 File Offset: 0x003F7B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C87 RID: 23687
		// (get) Token: 0x0601B553 RID: 111955 RVA: 0x003F9967 File Offset: 0x003F7B67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefenceInstanceRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601B554 RID: 111956 RVA: 0x003F996E File Offset: 0x003F7B6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceInstanceRewardResponse()
		{
		}

		// Token: 0x0601B555 RID: 111957 RVA: 0x003F9976 File Offset: 0x003F7B76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceInstanceRewardResponse(TowerDefenceInstanceRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B556 RID: 111958 RVA: 0x003F999B File Offset: 0x003F7B9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceInstanceRewardResponse Clone()
		{
			return new TowerDefenceInstanceRewardResponse(this);
		}

		// Token: 0x17005C88 RID: 23688
		// (get) Token: 0x0601B557 RID: 111959 RVA: 0x003F99A3 File Offset: 0x003F7BA3
		// (set) Token: 0x0601B558 RID: 111960 RVA: 0x003F99AB File Offset: 0x003F7BAB
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

		// Token: 0x0601B559 RID: 111961 RVA: 0x003F99B4 File Offset: 0x003F7BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefenceInstanceRewardResponse);
		}

		// Token: 0x0601B55A RID: 111962 RVA: 0x003F99C2 File Offset: 0x003F7BC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefenceInstanceRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B55B RID: 111963 RVA: 0x003F99F0 File Offset: 0x003F7BF0
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

		// Token: 0x0601B55C RID: 111964 RVA: 0x003F9A35 File Offset: 0x003F7C35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B55D RID: 111965 RVA: 0x003F9A42 File Offset: 0x003F7C42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B55E RID: 111966 RVA: 0x003F9A4B File Offset: 0x003F7C4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B55F RID: 111967 RVA: 0x003F9A7C File Offset: 0x003F7C7C
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

		// Token: 0x0601B560 RID: 111968 RVA: 0x003F9ABA File Offset: 0x003F7CBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerDefenceInstanceRewardResponse other)
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

		// Token: 0x0601B561 RID: 111969 RVA: 0x003F9AEB File Offset: 0x003F7CEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B562 RID: 111970 RVA: 0x003F9AF4 File Offset: 0x003F7CF4
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009F39 RID: 40761
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F3A RID: 40762
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04009F3B RID: 40763
		private ErrorCode errorCode_;
	}
}
