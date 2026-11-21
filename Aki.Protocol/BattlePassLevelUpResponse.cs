using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200016F RID: 367
	[NetMessage(EMessageId.BattlePassLevelUpResponse)]
	public sealed class BattlePassLevelUpResponse : IMessage<BattlePassLevelUpResponse>, IMessage, IEquatable<BattlePassLevelUpResponse>, IDeepCloneable<BattlePassLevelUpResponse>, IBufferMessage
	{
		// Token: 0x06002D7D RID: 11645 RVA: 0x0007612D File Offset: 0x0007432D
		[NullableContext(1)]
		public static BattlePassLevelUpResponse Create()
		{
			return new BattlePassLevelUpResponse();
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x06002D7E RID: 11646 RVA: 0x00076134 File Offset: 0x00074334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06002D7F RID: 11647 RVA: 0x00076137 File Offset: 0x00074337
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattlePassLevelUpResponse.Descriptor;
			}
		}

		// Token: 0x06002D80 RID: 11648 RVA: 0x0007613E File Offset: 0x0007433E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassLevelUpResponse()
		{
		}

		// Token: 0x06002D81 RID: 11649 RVA: 0x00076146 File Offset: 0x00074346
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassLevelUpResponse(BattlePassLevelUpResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002D82 RID: 11650 RVA: 0x0007616B File Offset: 0x0007436B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassLevelUpResponse Clone()
		{
			return new BattlePassLevelUpResponse(this);
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x06002D83 RID: 11651 RVA: 0x00076173 File Offset: 0x00074373
		// (set) Token: 0x06002D84 RID: 11652 RVA: 0x0007617B File Offset: 0x0007437B
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

		// Token: 0x06002D85 RID: 11653 RVA: 0x00076184 File Offset: 0x00074384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattlePassLevelUpResponse);
		}

		// Token: 0x06002D86 RID: 11654 RVA: 0x00076192 File Offset: 0x00074392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattlePassLevelUpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002D87 RID: 11655 RVA: 0x000761C0 File Offset: 0x000743C0
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

		// Token: 0x06002D88 RID: 11656 RVA: 0x00076205 File Offset: 0x00074405
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002D89 RID: 11657 RVA: 0x00076212 File Offset: 0x00074412
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002D8A RID: 11658 RVA: 0x0007621B File Offset: 0x0007441B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002D8B RID: 11659 RVA: 0x00076250 File Offset: 0x00074450
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

		// Token: 0x06002D8C RID: 11660 RVA: 0x0007628E File Offset: 0x0007448E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattlePassLevelUpResponse other)
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

		// Token: 0x06002D8D RID: 11661 RVA: 0x000762BF File Offset: 0x000744BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002D8E RID: 11662 RVA: 0x000762C8 File Offset: 0x000744C8
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002894 RID: 10388
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002895 RID: 10389
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04002896 RID: 10390
		private ErrorCode errorCode_;
	}
}
