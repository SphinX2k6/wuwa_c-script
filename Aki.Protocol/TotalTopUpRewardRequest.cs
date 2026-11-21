using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001401 RID: 5121
	[NetMessage(EMessageId.TotalTopUpRewardRequest)]
	public sealed class TotalTopUpRewardRequest : IMessage<TotalTopUpRewardRequest>, IMessage, IEquatable<TotalTopUpRewardRequest>, IDeepCloneable<TotalTopUpRewardRequest>, IBufferMessage
	{
		// Token: 0x0601B39D RID: 111517 RVA: 0x003F5F25 File Offset: 0x003F4125
		[NullableContext(1)]
		public static TotalTopUpRewardRequest Create()
		{
			return new TotalTopUpRewardRequest();
		}

		// Token: 0x17005C29 RID: 23593
		// (get) Token: 0x0601B39E RID: 111518 RVA: 0x003F5F2C File Offset: 0x003F412C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C2A RID: 23594
		// (get) Token: 0x0601B39F RID: 111519 RVA: 0x003F5F2F File Offset: 0x003F412F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TotalTopUpRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601B3A0 RID: 111520 RVA: 0x003F5F36 File Offset: 0x003F4136
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpRewardRequest()
		{
		}

		// Token: 0x0601B3A1 RID: 111521 RVA: 0x003F5F49 File Offset: 0x003F4149
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpRewardRequest(TotalTopUpRewardRequest other) : this()
		{
			this.totalTopUpRewardId_ = other.totalTopUpRewardId_;
			this.selectedId_ = other.selectedId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B3A2 RID: 111522 RVA: 0x003F5F7F File Offset: 0x003F417F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpRewardRequest Clone()
		{
			return new TotalTopUpRewardRequest(this);
		}

		// Token: 0x17005C2B RID: 23595
		// (get) Token: 0x0601B3A3 RID: 111523 RVA: 0x003F5F87 File Offset: 0x003F4187
		// (set) Token: 0x0601B3A4 RID: 111524 RVA: 0x003F5F8F File Offset: 0x003F418F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalTopUpRewardId
		{
			get
			{
				return this.totalTopUpRewardId_;
			}
			set
			{
				this.totalTopUpRewardId_ = value;
			}
		}

		// Token: 0x17005C2C RID: 23596
		// (get) Token: 0x0601B3A5 RID: 111525 RVA: 0x003F5F98 File Offset: 0x003F4198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SelectedId
		{
			get
			{
				return this.selectedId_;
			}
		}

		// Token: 0x0601B3A6 RID: 111526 RVA: 0x003F5FA0 File Offset: 0x003F41A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TotalTopUpRewardRequest);
		}

		// Token: 0x0601B3A7 RID: 111527 RVA: 0x003F5FB0 File Offset: 0x003F41B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TotalTopUpRewardRequest other)
		{
			return other != null && (other == this || (this.TotalTopUpRewardId == other.TotalTopUpRewardId && this.selectedId_.Equals(other.selectedId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B3A8 RID: 111528 RVA: 0x003F6000 File Offset: 0x003F4200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TotalTopUpRewardId != 0)
			{
				num ^= this.TotalTopUpRewardId.GetHashCode();
			}
			num ^= this.selectedId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B3A9 RID: 111529 RVA: 0x003F604D File Offset: 0x003F424D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B3AA RID: 111530 RVA: 0x003F605A File Offset: 0x003F425A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B3AB RID: 111531 RVA: 0x003F6064 File Offset: 0x003F4264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TotalTopUpRewardId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.TotalTopUpRewardId);
			}
			this.selectedId_.WriteTo(ref output, TotalTopUpRewardRequest._repeated_selectedId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B3AC RID: 111532 RVA: 0x003F60B4 File Offset: 0x003F42B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TotalTopUpRewardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalTopUpRewardId);
			}
			num += this.selectedId_.CalculateSize(TotalTopUpRewardRequest._repeated_selectedId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B3AD RID: 111533 RVA: 0x003F6108 File Offset: 0x003F4308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TotalTopUpRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TotalTopUpRewardId != 0)
			{
				this.TotalTopUpRewardId = other.TotalTopUpRewardId;
			}
			this.selectedId_.Add(other.selectedId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B3AE RID: 111534 RVA: 0x003F6155 File Offset: 0x003F4355
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B3AF RID: 111535 RVA: 0x003F6160 File Offset: 0x003F4360
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
				if (num != 64U)
				{
					if (num != 104U && num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.selectedId_.AddEntriesFrom(ref input, TotalTopUpRewardRequest._repeated_selectedId_codec);
					}
				}
				else
				{
					this.TotalTopUpRewardId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009EB9 RID: 40633
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009EBA RID: 40634
		public const int TotalTopUpRewardIdFieldNumber = 8;

		// Token: 0x04009EBB RID: 40635
		private int totalTopUpRewardId_;

		// Token: 0x04009EBC RID: 40636
		public const int SelectedIdFieldNumber = 13;

		// Token: 0x04009EBD RID: 40637
		private static readonly FieldCodec<int> _repeated_selectedId_codec = FieldCodec.ForInt32(106U);

		// Token: 0x04009EBE RID: 40638
		private readonly RepeatedField<int> selectedId_ = new RepeatedField<int>();
	}
}
