using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001DF RID: 479
	[NetMessage(EMessageId.BossRushLevelScoreRewardResponse)]
	public sealed class BossRushLevelScoreRewardResponse : IMessage<BossRushLevelScoreRewardResponse>, IMessage, IEquatable<BossRushLevelScoreRewardResponse>, IDeepCloneable<BossRushLevelScoreRewardResponse>, IBufferMessage
	{
		// Token: 0x06003644 RID: 13892 RVA: 0x0008897C File Offset: 0x00086B7C
		[NullableContext(1)]
		public static BossRushLevelScoreRewardResponse Create()
		{
			return new BossRushLevelScoreRewardResponse();
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x06003645 RID: 13893 RVA: 0x00088983 File Offset: 0x00086B83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x06003646 RID: 13894 RVA: 0x00088986 File Offset: 0x00086B86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossRushLevelScoreRewardResponse.Descriptor;
			}
		}

		// Token: 0x06003647 RID: 13895 RVA: 0x0008898D File Offset: 0x00086B8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushLevelScoreRewardResponse()
		{
		}

		// Token: 0x06003648 RID: 13896 RVA: 0x00088995 File Offset: 0x00086B95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushLevelScoreRewardResponse(BossRushLevelScoreRewardResponse other) : this()
		{
			this.error_ = other.error_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003649 RID: 13897 RVA: 0x000889BA File Offset: 0x00086BBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushLevelScoreRewardResponse Clone()
		{
			return new BossRushLevelScoreRewardResponse(this);
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x0600364A RID: 13898 RVA: 0x000889C2 File Offset: 0x00086BC2
		// (set) Token: 0x0600364B RID: 13899 RVA: 0x000889CA File Offset: 0x00086BCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Error
		{
			get
			{
				return this.error_;
			}
			set
			{
				this.error_ = value;
			}
		}

		// Token: 0x0600364C RID: 13900 RVA: 0x000889D3 File Offset: 0x00086BD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossRushLevelScoreRewardResponse);
		}

		// Token: 0x0600364D RID: 13901 RVA: 0x000889E1 File Offset: 0x00086BE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossRushLevelScoreRewardResponse other)
		{
			return other != null && (other == this || (this.Error == other.Error && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600364E RID: 13902 RVA: 0x00088A10 File Offset: 0x00086C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Error != ErrorCode.Success)
			{
				num ^= this.Error.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600364F RID: 13903 RVA: 0x00088A55 File Offset: 0x00086C55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003650 RID: 13904 RVA: 0x00088A62 File Offset: 0x00086C62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003651 RID: 13905 RVA: 0x00088A6B File Offset: 0x00086C6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Error != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.Error);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003652 RID: 13906 RVA: 0x00088AA0 File Offset: 0x00086CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Error != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Error);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003653 RID: 13907 RVA: 0x00088ADE File Offset: 0x00086CDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossRushLevelScoreRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Error != ErrorCode.Success)
			{
				this.Error = other.Error;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003654 RID: 13908 RVA: 0x00088B0F File Offset: 0x00086D0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003655 RID: 13909 RVA: 0x00088B18 File Offset: 0x00086D18
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
					this.Error = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002AEC RID: 10988
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002AED RID: 10989
		public const int ErrorFieldNumber = 7;

		// Token: 0x04002AEE RID: 10990
		private ErrorCode error_;
	}
}
