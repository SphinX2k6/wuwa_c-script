using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000565 RID: 1381
	[NetMessage(EMessageId.FishingSellPreviewResponse)]
	public sealed class FishingSellPreviewResponse : IMessage<FishingSellPreviewResponse>, IMessage, IEquatable<FishingSellPreviewResponse>, IDeepCloneable<FishingSellPreviewResponse>, IBufferMessage
	{
		// Token: 0x060080EE RID: 33006 RVA: 0x00137BED File Offset: 0x00135DED
		[NullableContext(1)]
		public static FishingSellPreviewResponse Create()
		{
			return new FishingSellPreviewResponse();
		}

		// Token: 0x1700191B RID: 6427
		// (get) Token: 0x060080EF RID: 33007 RVA: 0x00137BF4 File Offset: 0x00135DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700191C RID: 6428
		// (get) Token: 0x060080F0 RID: 33008 RVA: 0x00137BF7 File Offset: 0x00135DF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingSellPreviewResponse.Descriptor;
			}
		}

		// Token: 0x060080F1 RID: 33009 RVA: 0x00137BFE File Offset: 0x00135DFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSellPreviewResponse()
		{
		}

		// Token: 0x060080F2 RID: 33010 RVA: 0x00137C11 File Offset: 0x00135E11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSellPreviewResponse(FishingSellPreviewResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.rewardItems_ = other.rewardItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060080F3 RID: 33011 RVA: 0x00137C47 File Offset: 0x00135E47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSellPreviewResponse Clone()
		{
			return new FishingSellPreviewResponse(this);
		}

		// Token: 0x1700191D RID: 6429
		// (get) Token: 0x060080F4 RID: 33012 RVA: 0x00137C4F File Offset: 0x00135E4F
		// (set) Token: 0x060080F5 RID: 33013 RVA: 0x00137C57 File Offset: 0x00135E57
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

		// Token: 0x1700191E RID: 6430
		// (get) Token: 0x060080F6 RID: 33014 RVA: 0x00137C60 File Offset: 0x00135E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> RewardItems
		{
			get
			{
				return this.rewardItems_;
			}
		}

		// Token: 0x060080F7 RID: 33015 RVA: 0x00137C68 File Offset: 0x00135E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingSellPreviewResponse);
		}

		// Token: 0x060080F8 RID: 33016 RVA: 0x00137C78 File Offset: 0x00135E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingSellPreviewResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.RewardItems.Equals(other.RewardItems) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060080F9 RID: 33017 RVA: 0x00137CC8 File Offset: 0x00135EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.RewardItems.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060080FA RID: 33018 RVA: 0x00137D1B File Offset: 0x00135F1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060080FB RID: 33019 RVA: 0x00137D28 File Offset: 0x00135F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060080FC RID: 33020 RVA: 0x00137D34 File Offset: 0x00135F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.rewardItems_.WriteTo(ref output, FishingSellPreviewResponse._map_rewardItems_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060080FD RID: 33021 RVA: 0x00137D84 File Offset: 0x00135F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.rewardItems_.CalculateSize(FishingSellPreviewResponse._map_rewardItems_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060080FE RID: 33022 RVA: 0x00137DD8 File Offset: 0x00135FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingSellPreviewResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.rewardItems_.MergeFrom(other.rewardItems_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060080FF RID: 33023 RVA: 0x00137E25 File Offset: 0x00136025
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008100 RID: 33024 RVA: 0x00137E30 File Offset: 0x00136030
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
				if (num != 40U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.rewardItems_.AddEntriesFrom(ref input, FishingSellPreviewResponse._map_rewardItems_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400412F RID: 16687
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004130 RID: 16688
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04004131 RID: 16689
		private ErrorCode errorCode_;

		// Token: 0x04004132 RID: 16690
		public const int RewardItemsFieldNumber = 15;

		// Token: 0x04004133 RID: 16691
		private static readonly MapField<int, int>.Codec _map_rewardItems_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 122U);

		// Token: 0x04004134 RID: 16692
		private readonly MapField<int, int> rewardItems_ = new MapField<int, int>();
	}
}
