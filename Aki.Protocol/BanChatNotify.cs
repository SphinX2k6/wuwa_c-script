using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200015A RID: 346
	[NetMessage(EMessageId.BanChatNotify)]
	public sealed class BanChatNotify : IMessage<BanChatNotify>, IMessage, IEquatable<BanChatNotify>, IDeepCloneable<BanChatNotify>, IBufferMessage
	{
		// Token: 0x06002BCC RID: 11212 RVA: 0x000724B9 File Offset: 0x000706B9
		[NullableContext(1)]
		public static BanChatNotify Create()
		{
			return new BanChatNotify();
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06002BCD RID: 11213 RVA: 0x000724C0 File Offset: 0x000706C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06002BCE RID: 11214 RVA: 0x000724C3 File Offset: 0x000706C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BanChatNotify.Descriptor;
			}
		}

		// Token: 0x06002BCF RID: 11215 RVA: 0x000724CA File Offset: 0x000706CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BanChatNotify()
		{
		}

		// Token: 0x06002BD0 RID: 11216 RVA: 0x000724D2 File Offset: 0x000706D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BanChatNotify(BanChatNotify other) : this()
		{
			this.banEndTime_ = other.banEndTime_;
			this.banChatType_ = other.banChatType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002BD1 RID: 11217 RVA: 0x00072503 File Offset: 0x00070703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BanChatNotify Clone()
		{
			return new BanChatNotify(this);
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06002BD2 RID: 11218 RVA: 0x0007250B File Offset: 0x0007070B
		// (set) Token: 0x06002BD3 RID: 11219 RVA: 0x00072513 File Offset: 0x00070713
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BanEndTime
		{
			get
			{
				return this.banEndTime_;
			}
			set
			{
				this.banEndTime_ = value;
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06002BD4 RID: 11220 RVA: 0x0007251C File Offset: 0x0007071C
		// (set) Token: 0x06002BD5 RID: 11221 RVA: 0x00072524 File Offset: 0x00070724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BanChatType BanChatType
		{
			get
			{
				return this.banChatType_;
			}
			set
			{
				this.banChatType_ = value;
			}
		}

		// Token: 0x06002BD6 RID: 11222 RVA: 0x0007252D File Offset: 0x0007072D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BanChatNotify);
		}

		// Token: 0x06002BD7 RID: 11223 RVA: 0x0007253B File Offset: 0x0007073B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BanChatNotify other)
		{
			return other != null && (other == this || (this.BanEndTime == other.BanEndTime && this.BanChatType == other.BanChatType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002BD8 RID: 11224 RVA: 0x0007257C File Offset: 0x0007077C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BanEndTime != 0L)
			{
				num ^= this.BanEndTime.GetHashCode();
			}
			if (this.BanChatType != BanChatType.None)
			{
				num ^= this.BanChatType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002BD9 RID: 11225 RVA: 0x000725DA File Offset: 0x000707DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002BDA RID: 11226 RVA: 0x000725E7 File Offset: 0x000707E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002BDB RID: 11227 RVA: 0x000725F0 File Offset: 0x000707F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BanEndTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.BanEndTime);
			}
			if (this.BanChatType != BanChatType.None)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.BanChatType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002BDC RID: 11228 RVA: 0x0007264C File Offset: 0x0007084C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BanEndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BanEndTime);
			}
			if (this.BanChatType != BanChatType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.BanChatType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002BDD RID: 11229 RVA: 0x000726A4 File Offset: 0x000708A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BanChatNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BanEndTime != 0L)
			{
				this.BanEndTime = other.BanEndTime;
			}
			if (other.BanChatType != BanChatType.None)
			{
				this.BanChatType = other.BanChatType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002BDE RID: 11230 RVA: 0x000726F4 File Offset: 0x000708F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002BDF RID: 11231 RVA: 0x00072700 File Offset: 0x00070900
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
				if (num != 24U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.BanChatType = (BanChatType)input.ReadEnum();
					}
				}
				else
				{
					this.BanEndTime = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400280C RID: 10252
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400280D RID: 10253
		public const int BanEndTimeFieldNumber = 3;

		// Token: 0x0400280E RID: 10254
		private long banEndTime_;

		// Token: 0x0400280F RID: 10255
		public const int BanChatTypeFieldNumber = 15;

		// Token: 0x04002810 RID: 10256
		private BanChatType banChatType_;
	}
}
