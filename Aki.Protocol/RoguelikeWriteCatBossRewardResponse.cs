using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FB9 RID: 4025
	[NetMessage(EMessageId.RoguelikeWriteCatBossRewardResponse)]
	public sealed class RoguelikeWriteCatBossRewardResponse : IMessage<RoguelikeWriteCatBossRewardResponse>, IMessage, IEquatable<RoguelikeWriteCatBossRewardResponse>, IDeepCloneable<RoguelikeWriteCatBossRewardResponse>, IBufferMessage
	{
		// Token: 0x060158C3 RID: 88259 RVA: 0x0032162C File Offset: 0x0031F82C
		[NullableContext(1)]
		public static RoguelikeWriteCatBossRewardResponse Create()
		{
			return new RoguelikeWriteCatBossRewardResponse();
		}

		// Token: 0x170047E2 RID: 18402
		// (get) Token: 0x060158C4 RID: 88260 RVA: 0x00321633 File Offset: 0x0031F833
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170047E3 RID: 18403
		// (get) Token: 0x060158C5 RID: 88261 RVA: 0x00321636 File Offset: 0x0031F836
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeWriteCatBossRewardResponse.Descriptor;
			}
		}

		// Token: 0x060158C6 RID: 88262 RVA: 0x0032163D File Offset: 0x0031F83D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeWriteCatBossRewardResponse()
		{
		}

		// Token: 0x060158C7 RID: 88263 RVA: 0x00321645 File Offset: 0x0031F845
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeWriteCatBossRewardResponse(RoguelikeWriteCatBossRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060158C8 RID: 88264 RVA: 0x0032166A File Offset: 0x0031F86A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeWriteCatBossRewardResponse Clone()
		{
			return new RoguelikeWriteCatBossRewardResponse(this);
		}

		// Token: 0x170047E4 RID: 18404
		// (get) Token: 0x060158C9 RID: 88265 RVA: 0x00321672 File Offset: 0x0031F872
		// (set) Token: 0x060158CA RID: 88266 RVA: 0x0032167A File Offset: 0x0031F87A
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

		// Token: 0x060158CB RID: 88267 RVA: 0x00321683 File Offset: 0x0031F883
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeWriteCatBossRewardResponse);
		}

		// Token: 0x060158CC RID: 88268 RVA: 0x00321691 File Offset: 0x0031F891
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeWriteCatBossRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060158CD RID: 88269 RVA: 0x003216C0 File Offset: 0x0031F8C0
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

		// Token: 0x060158CE RID: 88270 RVA: 0x00321705 File Offset: 0x0031F905
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060158CF RID: 88271 RVA: 0x00321712 File Offset: 0x0031F912
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060158D0 RID: 88272 RVA: 0x0032171B File Offset: 0x0031F91B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060158D1 RID: 88273 RVA: 0x00321750 File Offset: 0x0031F950
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

		// Token: 0x060158D2 RID: 88274 RVA: 0x0032178E File Offset: 0x0031F98E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeWriteCatBossRewardResponse other)
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

		// Token: 0x060158D3 RID: 88275 RVA: 0x003217BF File Offset: 0x0031F9BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060158D4 RID: 88276 RVA: 0x003217C8 File Offset: 0x0031F9C8
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040081F1 RID: 33265
		private UnknownFieldSet _unknownFields;

		// Token: 0x040081F2 RID: 33266
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x040081F3 RID: 33267
		private ErrorCode errorCode_;
	}
}
