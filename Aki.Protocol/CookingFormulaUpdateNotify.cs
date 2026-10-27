using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002F8 RID: 760
	[NetMessage(EMessageId.CookingFormulaUpdateNotify)]
	public sealed class CookingFormulaUpdateNotify : IMessage<CookingFormulaUpdateNotify>, IMessage, IEquatable<CookingFormulaUpdateNotify>, IDeepCloneable<CookingFormulaUpdateNotify>, IBufferMessage
	{
		// Token: 0x06004CF4 RID: 19700 RVA: 0x000BB360 File Offset: 0x000B9560
		[NullableContext(1)]
		public static CookingFormulaUpdateNotify Create()
		{
			return new CookingFormulaUpdateNotify();
		}

		// Token: 0x17000D96 RID: 3478
		// (get) Token: 0x06004CF5 RID: 19701 RVA: 0x000BB367 File Offset: 0x000B9567
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D97 RID: 3479
		// (get) Token: 0x06004CF6 RID: 19702 RVA: 0x000BB36A File Offset: 0x000B956A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CookingFormulaUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06004CF7 RID: 19703 RVA: 0x000BB371 File Offset: 0x000B9571
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookingFormulaUpdateNotify()
		{
		}

		// Token: 0x06004CF8 RID: 19704 RVA: 0x000BB38F File Offset: 0x000B958F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookingFormulaUpdateNotify(CookingFormulaUpdateNotify other) : this()
		{
			this.foodFormulaInfos_ = other.foodFormulaInfos_.Clone();
			this.processedFoodFormulaInfos_ = other.processedFoodFormulaInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004CF9 RID: 19705 RVA: 0x000BB3CA File Offset: 0x000B95CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookingFormulaUpdateNotify Clone()
		{
			return new CookingFormulaUpdateNotify(this);
		}

		// Token: 0x17000D98 RID: 3480
		// (get) Token: 0x06004CFA RID: 19706 RVA: 0x000BB3D2 File Offset: 0x000B95D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SingleFoodFormulaInfo> FoodFormulaInfos
		{
			get
			{
				return this.foodFormulaInfos_;
			}
		}

		// Token: 0x17000D99 RID: 3481
		// (get) Token: 0x06004CFB RID: 19707 RVA: 0x000BB3DA File Offset: 0x000B95DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SingleProcessedFoodFormulaInfo> ProcessedFoodFormulaInfos
		{
			get
			{
				return this.processedFoodFormulaInfos_;
			}
		}

		// Token: 0x06004CFC RID: 19708 RVA: 0x000BB3E2 File Offset: 0x000B95E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CookingFormulaUpdateNotify);
		}

		// Token: 0x06004CFD RID: 19709 RVA: 0x000BB3F0 File Offset: 0x000B95F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CookingFormulaUpdateNotify other)
		{
			return other != null && (other == this || (this.foodFormulaInfos_.Equals(other.foodFormulaInfos_) && this.processedFoodFormulaInfos_.Equals(other.processedFoodFormulaInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004CFE RID: 19710 RVA: 0x000BB444 File Offset: 0x000B9644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.foodFormulaInfos_.GetHashCode();
			num ^= this.processedFoodFormulaInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004CFF RID: 19711 RVA: 0x000BB486 File Offset: 0x000B9686
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004D00 RID: 19712 RVA: 0x000BB493 File Offset: 0x000B9693
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004D01 RID: 19713 RVA: 0x000BB49C File Offset: 0x000B969C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.foodFormulaInfos_.WriteTo(ref output, CookingFormulaUpdateNotify._repeated_foodFormulaInfos_codec);
			this.processedFoodFormulaInfos_.WriteTo(ref output, CookingFormulaUpdateNotify._repeated_processedFoodFormulaInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004D02 RID: 19714 RVA: 0x000BB4D4 File Offset: 0x000B96D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.foodFormulaInfos_.CalculateSize(CookingFormulaUpdateNotify._repeated_foodFormulaInfos_codec);
			num += this.processedFoodFormulaInfos_.CalculateSize(CookingFormulaUpdateNotify._repeated_processedFoodFormulaInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004D03 RID: 19715 RVA: 0x000BB520 File Offset: 0x000B9720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CookingFormulaUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.foodFormulaInfos_.Add(other.foodFormulaInfos_);
			this.processedFoodFormulaInfos_.Add(other.processedFoodFormulaInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004D04 RID: 19716 RVA: 0x000BB55F File Offset: 0x000B975F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004D05 RID: 19717 RVA: 0x000BB568 File Offset: 0x000B9768
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
				if (num != 74U)
				{
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.processedFoodFormulaInfos_.AddEntriesFrom(ref input, CookingFormulaUpdateNotify._repeated_processedFoodFormulaInfos_codec);
					}
				}
				else
				{
					this.foodFormulaInfos_.AddEntriesFrom(ref input, CookingFormulaUpdateNotify._repeated_foodFormulaInfos_codec);
				}
			}
		}

		// Token: 0x0400312A RID: 12586
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400312B RID: 12587
		public const int FoodFormulaInfosFieldNumber = 9;

		// Token: 0x0400312C RID: 12588
		private static readonly FieldCodec<SingleFoodFormulaInfo> _repeated_foodFormulaInfos_codec = FieldCodec.ForMessage<SingleFoodFormulaInfo>(74U, SingleFoodFormulaInfo.Parser);

		// Token: 0x0400312D RID: 12589
		private readonly RepeatedField<SingleFoodFormulaInfo> foodFormulaInfos_ = new RepeatedField<SingleFoodFormulaInfo>();

		// Token: 0x0400312E RID: 12590
		public const int ProcessedFoodFormulaInfosFieldNumber = 12;

		// Token: 0x0400312F RID: 12591
		private static readonly FieldCodec<SingleProcessedFoodFormulaInfo> _repeated_processedFoodFormulaInfos_codec = FieldCodec.ForMessage<SingleProcessedFoodFormulaInfo>(98U, SingleProcessedFoodFormulaInfo.Parser);

		// Token: 0x04003130 RID: 12592
		private readonly RepeatedField<SingleProcessedFoodFormulaInfo> processedFoodFormulaInfos_ = new RepeatedField<SingleProcessedFoodFormulaInfo>();
	}
}
