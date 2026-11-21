using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200127E RID: 4734
	public sealed class SkinChangeInfo : IMessage<SkinChangeInfo>, IMessage, IEquatable<SkinChangeInfo>, IDeepCloneable<SkinChangeInfo>, IBufferMessage
	{
		// Token: 0x06019465 RID: 103525 RVA: 0x003AFEA9 File Offset: 0x003AE0A9
		[NullableContext(1)]
		public static SkinChangeInfo Create()
		{
			return new SkinChangeInfo();
		}

		// Token: 0x1700557D RID: 21885
		// (get) Token: 0x06019466 RID: 103526 RVA: 0x003AFEB0 File Offset: 0x003AE0B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SkinChangeInfo> Parser
		{
			get
			{
				return SkinChangeInfo._parser;
			}
		}

		// Token: 0x1700557E RID: 21886
		// (get) Token: 0x06019467 RID: 103527 RVA: 0x003AFEB7 File Offset: 0x003AE0B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700557F RID: 21887
		// (get) Token: 0x06019468 RID: 103528 RVA: 0x003AFEBA File Offset: 0x003AE0BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SkinChangeInfo.Descriptor;
			}
		}

		// Token: 0x06019469 RID: 103529 RVA: 0x003AFEC1 File Offset: 0x003AE0C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkinChangeInfo()
		{
		}

		// Token: 0x0601946A RID: 103530 RVA: 0x003AFEC9 File Offset: 0x003AE0C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkinChangeInfo(SkinChangeInfo other) : this()
		{
			this.monsterId_ = other.monsterId_;
			this.skinId_ = other.skinId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601946B RID: 103531 RVA: 0x003AFEFA File Offset: 0x003AE0FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkinChangeInfo Clone()
		{
			return new SkinChangeInfo(this);
		}

		// Token: 0x17005580 RID: 21888
		// (get) Token: 0x0601946C RID: 103532 RVA: 0x003AFF02 File Offset: 0x003AE102
		// (set) Token: 0x0601946D RID: 103533 RVA: 0x003AFF0A File Offset: 0x003AE10A
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

		// Token: 0x17005581 RID: 21889
		// (get) Token: 0x0601946E RID: 103534 RVA: 0x003AFF13 File Offset: 0x003AE113
		// (set) Token: 0x0601946F RID: 103535 RVA: 0x003AFF1B File Offset: 0x003AE11B
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

		// Token: 0x06019470 RID: 103536 RVA: 0x003AFF24 File Offset: 0x003AE124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SkinChangeInfo);
		}

		// Token: 0x06019471 RID: 103537 RVA: 0x003AFF32 File Offset: 0x003AE132
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SkinChangeInfo other)
		{
			return other != null && (other == this || (this.MonsterId == other.MonsterId && this.SkinId == other.SkinId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019472 RID: 103538 RVA: 0x003AFF70 File Offset: 0x003AE170
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

		// Token: 0x06019473 RID: 103539 RVA: 0x003AFFC8 File Offset: 0x003AE1C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019474 RID: 103540 RVA: 0x003AFFD5 File Offset: 0x003AE1D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019475 RID: 103541 RVA: 0x003AFFE0 File Offset: 0x003AE1E0
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

		// Token: 0x06019476 RID: 103542 RVA: 0x003B0038 File Offset: 0x003AE238
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

		// Token: 0x06019477 RID: 103543 RVA: 0x003B0090 File Offset: 0x003AE290
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

		// Token: 0x06019478 RID: 103544 RVA: 0x003B00E0 File Offset: 0x003AE2E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019479 RID: 103545 RVA: 0x003B00EC File Offset: 0x003AE2EC
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

		// Token: 0x04009598 RID: 38296
		private static readonly MessageParser<SkinChangeInfo> _parser = new MessageParser<SkinChangeInfo>(() => new SkinChangeInfo());

		// Token: 0x04009599 RID: 38297
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400959A RID: 38298
		public const int MonsterIdFieldNumber = 1;

		// Token: 0x0400959B RID: 38299
		private int monsterId_;

		// Token: 0x0400959C RID: 38300
		public const int SkinIdFieldNumber = 2;

		// Token: 0x0400959D RID: 38301
		private int skinId_;
	}
}
