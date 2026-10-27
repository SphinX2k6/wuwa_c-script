using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000383 RID: 899
	[NetMessage(EMessageId.DangoMonopolyBoardRewardResponse)]
	public sealed class DangoMonopolyBoardRewardResponse : IMessage<DangoMonopolyBoardRewardResponse>, IMessage, IEquatable<DangoMonopolyBoardRewardResponse>, IDeepCloneable<DangoMonopolyBoardRewardResponse>, IBufferMessage
	{
		// Token: 0x0600590B RID: 22795 RVA: 0x000D90D0 File Offset: 0x000D72D0
		[NullableContext(1)]
		public static DangoMonopolyBoardRewardResponse Create()
		{
			return new DangoMonopolyBoardRewardResponse();
		}

		// Token: 0x1700106C RID: 4204
		// (get) Token: 0x0600590C RID: 22796 RVA: 0x000D90D7 File Offset: 0x000D72D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700106D RID: 4205
		// (get) Token: 0x0600590D RID: 22797 RVA: 0x000D90DA File Offset: 0x000D72DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoMonopolyBoardRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600590E RID: 22798 RVA: 0x000D90E1 File Offset: 0x000D72E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyBoardRewardResponse()
		{
		}

		// Token: 0x0600590F RID: 22799 RVA: 0x000D90E9 File Offset: 0x000D72E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyBoardRewardResponse(DangoMonopolyBoardRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005910 RID: 22800 RVA: 0x000D910E File Offset: 0x000D730E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyBoardRewardResponse Clone()
		{
			return new DangoMonopolyBoardRewardResponse(this);
		}

		// Token: 0x1700106E RID: 4206
		// (get) Token: 0x06005911 RID: 22801 RVA: 0x000D9116 File Offset: 0x000D7316
		// (set) Token: 0x06005912 RID: 22802 RVA: 0x000D911E File Offset: 0x000D731E
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

		// Token: 0x06005913 RID: 22803 RVA: 0x000D9127 File Offset: 0x000D7327
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoMonopolyBoardRewardResponse);
		}

		// Token: 0x06005914 RID: 22804 RVA: 0x000D9135 File Offset: 0x000D7335
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoMonopolyBoardRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005915 RID: 22805 RVA: 0x000D9164 File Offset: 0x000D7364
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

		// Token: 0x06005916 RID: 22806 RVA: 0x000D91A9 File Offset: 0x000D73A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005917 RID: 22807 RVA: 0x000D91B6 File Offset: 0x000D73B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005918 RID: 22808 RVA: 0x000D91BF File Offset: 0x000D73BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005919 RID: 22809 RVA: 0x000D91F4 File Offset: 0x000D73F4
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

		// Token: 0x0600591A RID: 22810 RVA: 0x000D9232 File Offset: 0x000D7432
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoMonopolyBoardRewardResponse other)
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

		// Token: 0x0600591B RID: 22811 RVA: 0x000D9263 File Offset: 0x000D7463
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600591C RID: 22812 RVA: 0x000D926C File Offset: 0x000D746C
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400354C RID: 13644
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400354D RID: 13645
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x0400354E RID: 13646
		private ErrorCode errorCode_;
	}
}
