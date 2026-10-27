using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200033B RID: 827
	public sealed class DangoBrawlChallengeInfo : IMessage<DangoBrawlChallengeInfo>, IMessage, IEquatable<DangoBrawlChallengeInfo>, IDeepCloneable<DangoBrawlChallengeInfo>, IBufferMessage
	{
		// Token: 0x060052F5 RID: 21237 RVA: 0x000CA6EC File Offset: 0x000C88EC
		[NullableContext(1)]
		public static DangoBrawlChallengeInfo Create()
		{
			return new DangoBrawlChallengeInfo();
		}

		// Token: 0x17000F0C RID: 3852
		// (get) Token: 0x060052F6 RID: 21238 RVA: 0x000CA6F3 File Offset: 0x000C88F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DangoBrawlChallengeInfo> Parser
		{
			get
			{
				return DangoBrawlChallengeInfo._parser;
			}
		}

		// Token: 0x17000F0D RID: 3853
		// (get) Token: 0x060052F7 RID: 21239 RVA: 0x000CA6FA File Offset: 0x000C88FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F0E RID: 3854
		// (get) Token: 0x060052F8 RID: 21240 RVA: 0x000CA6FD File Offset: 0x000C88FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlChallengeInfo.Descriptor;
			}
		}

		// Token: 0x060052F9 RID: 21241 RVA: 0x000CA704 File Offset: 0x000C8904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlChallengeInfo()
		{
		}

		// Token: 0x060052FA RID: 21242 RVA: 0x000CA70C File Offset: 0x000C890C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlChallengeInfo(DangoBrawlChallengeInfo other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.state_ = other.state_;
			this.retryCount_ = other.retryCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060052FB RID: 21243 RVA: 0x000CA749 File Offset: 0x000C8949
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlChallengeInfo Clone()
		{
			return new DangoBrawlChallengeInfo(this);
		}

		// Token: 0x17000F0F RID: 3855
		// (get) Token: 0x060052FC RID: 21244 RVA: 0x000CA751 File Offset: 0x000C8951
		// (set) Token: 0x060052FD RID: 21245 RVA: 0x000CA759 File Offset: 0x000C8959
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChallengeId
		{
			get
			{
				return this.challengeId_;
			}
			set
			{
				this.challengeId_ = value;
			}
		}

		// Token: 0x17000F10 RID: 3856
		// (get) Token: 0x060052FE RID: 21246 RVA: 0x000CA762 File Offset: 0x000C8962
		// (set) Token: 0x060052FF RID: 21247 RVA: 0x000CA76A File Offset: 0x000C896A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlChallengeState State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x17000F11 RID: 3857
		// (get) Token: 0x06005300 RID: 21248 RVA: 0x000CA773 File Offset: 0x000C8973
		// (set) Token: 0x06005301 RID: 21249 RVA: 0x000CA77B File Offset: 0x000C897B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RetryCount
		{
			get
			{
				return this.retryCount_;
			}
			set
			{
				this.retryCount_ = value;
			}
		}

		// Token: 0x06005302 RID: 21250 RVA: 0x000CA784 File Offset: 0x000C8984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlChallengeInfo);
		}

		// Token: 0x06005303 RID: 21251 RVA: 0x000CA794 File Offset: 0x000C8994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlChallengeInfo other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.State == other.State && this.RetryCount == other.RetryCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005304 RID: 21252 RVA: 0x000CA7F0 File Offset: 0x000C89F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.State != DangoBrawlChallengeState.Locked)
			{
				num ^= this.State.GetHashCode();
			}
			if (this.RetryCount != 0)
			{
				num ^= this.RetryCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005305 RID: 21253 RVA: 0x000CA867 File Offset: 0x000C8A67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005306 RID: 21254 RVA: 0x000CA874 File Offset: 0x000C8A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005307 RID: 21255 RVA: 0x000CA880 File Offset: 0x000C8A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ChallengeId);
			}
			if (this.State != DangoBrawlChallengeState.Locked)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.State);
			}
			if (this.RetryCount != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RetryCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005308 RID: 21256 RVA: 0x000CA8F4 File Offset: 0x000C8AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			if (this.State != DangoBrawlChallengeState.Locked)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.State);
			}
			if (this.RetryCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RetryCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005309 RID: 21257 RVA: 0x000CA964 File Offset: 0x000C8B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlChallengeInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.State != DangoBrawlChallengeState.Locked)
			{
				this.State = other.State;
			}
			if (other.RetryCount != 0)
			{
				this.RetryCount = other.RetryCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600530A RID: 21258 RVA: 0x000CA9C8 File Offset: 0x000C8BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600530B RID: 21259 RVA: 0x000CA9D4 File Offset: 0x000C8BD4
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
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.RetryCount = input.ReadInt32();
						}
					}
					else
					{
						this.State = (DangoBrawlChallengeState)input.ReadEnum();
					}
				}
				else
				{
					this.ChallengeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003357 RID: 13143
		private static readonly MessageParser<DangoBrawlChallengeInfo> _parser = new MessageParser<DangoBrawlChallengeInfo>(() => new DangoBrawlChallengeInfo());

		// Token: 0x04003358 RID: 13144
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003359 RID: 13145
		public const int ChallengeIdFieldNumber = 1;

		// Token: 0x0400335A RID: 13146
		private int challengeId_;

		// Token: 0x0400335B RID: 13147
		public const int StateFieldNumber = 2;

		// Token: 0x0400335C RID: 13148
		private DangoBrawlChallengeState state_;

		// Token: 0x0400335D RID: 13149
		public const int RetryCountFieldNumber = 3;

		// Token: 0x0400335E RID: 13150
		private int retryCount_;
	}
}
