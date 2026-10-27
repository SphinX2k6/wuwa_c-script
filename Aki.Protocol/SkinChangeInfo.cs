using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001241 RID: 4673
	public sealed class SkinChangeInfo : IMessage<SkinChangeInfo>, IMessage, IEquatable<SkinChangeInfo>, IDeepCloneable<SkinChangeInfo>, IBufferMessage
	{
		// Token: 0x06018E7B RID: 102011 RVA: 0x0039FF49 File Offset: 0x0039E149
		[NullableContext(1)]
		public static SkinChangeInfo Create()
		{
			return new SkinChangeInfo();
		}

		// Token: 0x170053FE RID: 21502
		// (get) Token: 0x06018E7C RID: 102012 RVA: 0x0039FF50 File Offset: 0x0039E150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SkinChangeInfo> Parser
		{
			get
			{
				return SkinChangeInfo._parser;
			}
		}

		// Token: 0x170053FF RID: 21503
		// (get) Token: 0x06018E7D RID: 102013 RVA: 0x0039FF57 File Offset: 0x0039E157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005400 RID: 21504
		// (get) Token: 0x06018E7E RID: 102014 RVA: 0x0039FF5A File Offset: 0x0039E15A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SkinChangeInfo.Descriptor;
			}
		}

		// Token: 0x06018E7F RID: 102015 RVA: 0x0039FF61 File Offset: 0x0039E161
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkinChangeInfo()
		{
		}

		// Token: 0x06018E80 RID: 102016 RVA: 0x0039FF69 File Offset: 0x0039E169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkinChangeInfo(SkinChangeInfo other) : this()
		{
			this.monsterId_ = other.monsterId_;
			this.skinId_ = other.skinId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018E81 RID: 102017 RVA: 0x0039FF9A File Offset: 0x0039E19A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkinChangeInfo Clone()
		{
			return new SkinChangeInfo(this);
		}

		// Token: 0x17005401 RID: 21505
		// (get) Token: 0x06018E82 RID: 102018 RVA: 0x0039FFA2 File Offset: 0x0039E1A2
		// (set) Token: 0x06018E83 RID: 102019 RVA: 0x0039FFAA File Offset: 0x0039E1AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MonsterId
		{
			get
			{
				return this.monsterId_;
			}
			set
			{
				this.monsterId_ = value;
			}
		}

		// Token: 0x17005402 RID: 21506
		// (get) Token: 0x06018E84 RID: 102020 RVA: 0x0039FFB3 File Offset: 0x0039E1B3
		// (set) Token: 0x06018E85 RID: 102021 RVA: 0x0039FFBB File Offset: 0x0039E1BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkinId
		{
			get
			{
				return this.skinId_;
			}
			set
			{
				this.skinId_ = value;
			}
		}

		// Token: 0x06018E86 RID: 102022 RVA: 0x0039FFC4 File Offset: 0x0039E1C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SkinChangeInfo);
		}

		// Token: 0x06018E87 RID: 102023 RVA: 0x0039FFD2 File Offset: 0x0039E1D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SkinChangeInfo other)
		{
			return other != null && (other == this || (this.MonsterId == other.MonsterId && this.SkinId == other.SkinId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018E88 RID: 102024 RVA: 0x003A0010 File Offset: 0x0039E210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MonsterId != 0)
			{
				num ^= this.MonsterId.GetHashCode();
			}
			if (this.SkinId != 0)
			{
				num ^= this.SkinId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018E89 RID: 102025 RVA: 0x003A0068 File Offset: 0x0039E268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018E8A RID: 102026 RVA: 0x003A0075 File Offset: 0x0039E275
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018E8B RID: 102027 RVA: 0x003A0080 File Offset: 0x0039E280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MonsterId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MonsterId);
			}
			if (this.SkinId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SkinId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018E8C RID: 102028 RVA: 0x003A00D8 File Offset: 0x0039E2D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MonsterId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MonsterId);
			}
			if (this.SkinId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkinId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018E8D RID: 102029 RVA: 0x003A0130 File Offset: 0x0039E330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SkinChangeInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MonsterId != 0)
			{
				this.MonsterId = other.MonsterId;
			}
			if (other.SkinId != 0)
			{
				this.SkinId = other.SkinId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018E8E RID: 102030 RVA: 0x003A0180 File Offset: 0x0039E380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018E8F RID: 102031 RVA: 0x003A018C File Offset: 0x0039E38C
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SkinId = input.ReadInt32();
					}
				}
				else
				{
					this.MonsterId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040092E6 RID: 37606
		private static readonly MessageParser<SkinChangeInfo> _parser = new MessageParser<SkinChangeInfo>(() => new SkinChangeInfo());

		// Token: 0x040092E7 RID: 37607
		private UnknownFieldSet _unknownFields;

		// Token: 0x040092E8 RID: 37608
		public const int MonsterIdFieldNumber = 1;

		// Token: 0x040092E9 RID: 37609
		private int monsterId_;

		// Token: 0x040092EA RID: 37610
		public const int SkinIdFieldNumber = 2;

		// Token: 0x040092EB RID: 37611
		private int skinId_;
	}
}
