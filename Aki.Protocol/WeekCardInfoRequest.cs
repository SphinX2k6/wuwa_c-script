using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001506 RID: 5382
	[NetMessage(EMessageId.WeekCardInfoRequest)]
	public sealed class WeekCardInfoRequest : IMessage<WeekCardInfoRequest>, IMessage, IEquatable<WeekCardInfoRequest>, IDeepCloneable<WeekCardInfoRequest>, IBufferMessage
	{
		// Token: 0x0601C72A RID: 116522 RVA: 0x0041BE77 File Offset: 0x0041A077
		[NullableContext(1)]
		public static WeekCardInfoRequest Create()
		{
			return new WeekCardInfoRequest();
		}

		// Token: 0x17005FE7 RID: 24551
		// (get) Token: 0x0601C72B RID: 116523 RVA: 0x0041BE7E File Offset: 0x0041A07E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005FE8 RID: 24552
		// (get) Token: 0x0601C72C RID: 116524 RVA: 0x0041BE81 File Offset: 0x0041A081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeekCardInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601C72D RID: 116525 RVA: 0x0041BE88 File Offset: 0x0041A088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeekCardInfoRequest()
		{
		}

		// Token: 0x0601C72E RID: 116526 RVA: 0x0041BE9B File Offset: 0x0041A09B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeekCardInfoRequest(WeekCardInfoRequest other) : this()
		{
			this.weekCardId_ = other.weekCardId_;
			this.weekCardIds_ = other.weekCardIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C72F RID: 116527 RVA: 0x0041BED1 File Offset: 0x0041A0D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeekCardInfoRequest Clone()
		{
			return new WeekCardInfoRequest(this);
		}

		// Token: 0x17005FE9 RID: 24553
		// (get) Token: 0x0601C730 RID: 116528 RVA: 0x0041BED9 File Offset: 0x0041A0D9
		// (set) Token: 0x0601C731 RID: 116529 RVA: 0x0041BEE1 File Offset: 0x0041A0E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeekCardId
		{
			get
			{
				return this.weekCardId_;
			}
			set
			{
				this.weekCardId_ = value;
			}
		}

		// Token: 0x17005FEA RID: 24554
		// (get) Token: 0x0601C732 RID: 116530 RVA: 0x0041BEEA File Offset: 0x0041A0EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> WeekCardIds
		{
			get
			{
				return this.weekCardIds_;
			}
		}

		// Token: 0x0601C733 RID: 116531 RVA: 0x0041BEF2 File Offset: 0x0041A0F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeekCardInfoRequest);
		}

		// Token: 0x0601C734 RID: 116532 RVA: 0x0041BF00 File Offset: 0x0041A100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeekCardInfoRequest other)
		{
			return other != null && (other == this || (this.WeekCardId == other.WeekCardId && this.weekCardIds_.Equals(other.weekCardIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C735 RID: 116533 RVA: 0x0041BF50 File Offset: 0x0041A150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WeekCardId != 0)
			{
				num ^= this.WeekCardId.GetHashCode();
			}
			num ^= this.weekCardIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C736 RID: 116534 RVA: 0x0041BF9D File Offset: 0x0041A19D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C737 RID: 116535 RVA: 0x0041BFAA File Offset: 0x0041A1AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C738 RID: 116536 RVA: 0x0041BFB4 File Offset: 0x0041A1B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.weekCardIds_.WriteTo(ref output, WeekCardInfoRequest._repeated_weekCardIds_codec);
			if (this.WeekCardId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.WeekCardId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C739 RID: 116537 RVA: 0x0041C004 File Offset: 0x0041A204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WeekCardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeekCardId);
			}
			num += this.weekCardIds_.CalculateSize(WeekCardInfoRequest._repeated_weekCardIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C73A RID: 116538 RVA: 0x0041C058 File Offset: 0x0041A258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeekCardInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WeekCardId != 0)
			{
				this.WeekCardId = other.WeekCardId;
			}
			this.weekCardIds_.Add(other.weekCardIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C73B RID: 116539 RVA: 0x0041C0A5 File Offset: 0x0041A2A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C73C RID: 116540 RVA: 0x0041C0B0 File Offset: 0x0041A2B0
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
				if (num != 48U && num != 50U)
				{
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.WeekCardId = input.ReadInt32();
					}
				}
				else
				{
					this.weekCardIds_.AddEntriesFrom(ref input, WeekCardInfoRequest._repeated_weekCardIds_codec);
				}
			}
		}

		// Token: 0x0400A2DC RID: 41692
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A2DD RID: 41693
		public const int WeekCardIdFieldNumber = 8;

		// Token: 0x0400A2DE RID: 41694
		private int weekCardId_;

		// Token: 0x0400A2DF RID: 41695
		public const int WeekCardIdsFieldNumber = 6;

		// Token: 0x0400A2E0 RID: 41696
		private static readonly FieldCodec<int> _repeated_weekCardIds_codec = FieldCodec.ForInt32(50U);

		// Token: 0x0400A2E1 RID: 41697
		private readonly RepeatedField<int> weekCardIds_ = new RepeatedField<int>();
	}
}
