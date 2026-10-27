using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C06 RID: 3078
	public sealed class PbHandInItemInfo : IMessage<PbHandInItemInfo>, IMessage, IEquatable<PbHandInItemInfo>, IDeepCloneable<PbHandInItemInfo>, IBufferMessage
	{
		// Token: 0x06010B53 RID: 68435 RVA: 0x002723ED File Offset: 0x002705ED
		[NullableContext(1)]
		public static PbHandInItemInfo Create()
		{
			return new PbHandInItemInfo();
		}

		// Token: 0x1700371A RID: 14106
		// (get) Token: 0x06010B54 RID: 68436 RVA: 0x002723F4 File Offset: 0x002705F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PbHandInItemInfo> Parser
		{
			get
			{
				return PbHandInItemInfo._parser;
			}
		}

		// Token: 0x1700371B RID: 14107
		// (get) Token: 0x06010B55 RID: 68437 RVA: 0x002723FB File Offset: 0x002705FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700371C RID: 14108
		// (get) Token: 0x06010B56 RID: 68438 RVA: 0x002723FE File Offset: 0x002705FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbHandInItemInfo.Descriptor;
			}
		}

		// Token: 0x06010B57 RID: 68439 RVA: 0x00272405 File Offset: 0x00270605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbHandInItemInfo()
		{
		}

		// Token: 0x06010B58 RID: 68440 RVA: 0x0027240D File Offset: 0x0027060D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbHandInItemInfo(PbHandInItemInfo other) : this()
		{
			this.incId_ = other.incId_;
			this.num_ = other.num_;
			this.itemId_ = other.itemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010B59 RID: 68441 RVA: 0x0027244A File Offset: 0x0027064A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbHandInItemInfo Clone()
		{
			return new PbHandInItemInfo(this);
		}

		// Token: 0x1700371D RID: 14109
		// (get) Token: 0x06010B5A RID: 68442 RVA: 0x00272452 File Offset: 0x00270652
		// (set) Token: 0x06010B5B RID: 68443 RVA: 0x0027245A File Offset: 0x0027065A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x1700371E RID: 14110
		// (get) Token: 0x06010B5C RID: 68444 RVA: 0x00272463 File Offset: 0x00270663
		// (set) Token: 0x06010B5D RID: 68445 RVA: 0x0027246B File Offset: 0x0027066B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Num
		{
			get
			{
				return this.num_;
			}
			set
			{
				this.num_ = value;
			}
		}

		// Token: 0x1700371F RID: 14111
		// (get) Token: 0x06010B5E RID: 68446 RVA: 0x00272474 File Offset: 0x00270674
		// (set) Token: 0x06010B5F RID: 68447 RVA: 0x0027247C File Offset: 0x0027067C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x06010B60 RID: 68448 RVA: 0x00272485 File Offset: 0x00270685
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbHandInItemInfo);
		}

		// Token: 0x06010B61 RID: 68449 RVA: 0x00272494 File Offset: 0x00270694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbHandInItemInfo other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && this.Num == other.Num && this.ItemId == other.ItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010B62 RID: 68450 RVA: 0x002724F0 File Offset: 0x002706F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.Num != 0)
			{
				num ^= this.Num.GetHashCode();
			}
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010B63 RID: 68451 RVA: 0x00272561 File Offset: 0x00270761
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010B64 RID: 68452 RVA: 0x0027256E File Offset: 0x0027076E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010B65 RID: 68453 RVA: 0x00272578 File Offset: 0x00270778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.IncId);
			}
			if (this.Num != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Num);
			}
			if (this.ItemId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010B66 RID: 68454 RVA: 0x002725EC File Offset: 0x002707EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this.Num != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Num);
			}
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010B67 RID: 68455 RVA: 0x0027265C File Offset: 0x0027085C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PbHandInItemInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			if (other.Num != 0)
			{
				this.Num = other.Num;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010B68 RID: 68456 RVA: 0x002726C0 File Offset: 0x002708C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010B69 RID: 68457 RVA: 0x002726CC File Offset: 0x002708CC
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
							this.ItemId = input.ReadInt32();
						}
					}
					else
					{
						this.Num = input.ReadInt32();
					}
				}
				else
				{
					this.IncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006A2B RID: 27179
		private static readonly MessageParser<PbHandInItemInfo> _parser = new MessageParser<PbHandInItemInfo>(() => new PbHandInItemInfo());

		// Token: 0x04006A2C RID: 27180
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006A2D RID: 27181
		public const int IncIdFieldNumber = 1;

		// Token: 0x04006A2E RID: 27182
		private int incId_;

		// Token: 0x04006A2F RID: 27183
		public const int NumFieldNumber = 2;

		// Token: 0x04006A30 RID: 27184
		private int num_;

		// Token: 0x04006A31 RID: 27185
		public const int ItemIdFieldNumber = 3;

		// Token: 0x04006A32 RID: 27186
		private int itemId_;
	}
}
