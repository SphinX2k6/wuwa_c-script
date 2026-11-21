using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002FF RID: 767
	[NetMessage(EMessageId.CookingFormulaUpdateNotify)]
	public sealed class CookingFormulaUpdateNotify : IMessage<CookingFormulaUpdateNotify>, IMessage, IEquatable<CookingFormulaUpdateNotify>, IDeepCloneable<CookingFormulaUpdateNotify>, IBufferMessage
	{
		// Token: 0x06004DCD RID: 19917 RVA: 0x000BD74C File Offset: 0x000BB94C
		[NullableContext(1)]
		public static CookingFormulaUpdateNotify Create()
		{
			return new CookingFormulaUpdateNotify();
		}

		// Token: 0x17000DC3 RID: 3523
		// (get) Token: 0x06004DCE RID: 19918 RVA: 0x000BD753 File Offset: 0x000BB953
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000DC4 RID: 3524
		// (get) Token: 0x06004DCF RID: 19919 RVA: 0x000BD756 File Offset: 0x000BB956
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CookingFormulaUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06004DD0 RID: 19920 RVA: 0x000BD75D File Offset: 0x000BB95D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookingFormulaUpdateNotify()
		{
		}

		// Token: 0x06004DD1 RID: 19921 RVA: 0x000BD77B File Offset: 0x000BB97B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookingFormulaUpdateNotify(CookingFormulaUpdateNotify other) : this()
		{
			this.foodFormulaInfos_ = other.foodFormulaInfos_.Clone();
			this.processedFoodFormulaInfos_ = other.processedFoodFormulaInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004DD2 RID: 19922 RVA: 0x000BD7B6 File Offset: 0x000BB9B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookingFormulaUpdateNotify Clone()
		{
			return new CookingFormulaUpdateNotify(this);
		}

		// Token: 0x17000DC5 RID: 3525
		// (get) Token: 0x06004DD3 RID: 19923 RVA: 0x000BD7BE File Offset: 0x000BB9BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SingleFoodFormulaInfo> FoodFormulaInfos
		{
			get
			{
				return this.foodFormulaInfos_;
			}
		}

		// Token: 0x17000DC6 RID: 3526
		// (get) Token: 0x06004DD4 RID: 19924 RVA: 0x000BD7C6 File Offset: 0x000BB9C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SingleProcessedFoodFormulaInfo> ProcessedFoodFormulaInfos
		{
			get
			{
				return this.processedFoodFormulaInfos_;
			}
		}

		// Token: 0x06004DD5 RID: 19925 RVA: 0x000BD7CE File Offset: 0x000BB9CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CookingFormulaUpdateNotify);
		}

		// Token: 0x06004DD6 RID: 19926 RVA: 0x000BD7DC File Offset: 0x000BB9DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CookingFormulaUpdateNotify other)
		{
			return other != null && (other == this || (this.foodFormulaInfos_.Equals(other.foodFormulaInfos_) && this.processedFoodFormulaInfos_.Equals(other.processedFoodFormulaInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004DD7 RID: 19927 RVA: 0x000BD830 File Offset: 0x000BBA30
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

		// Token: 0x06004DD8 RID: 19928 RVA: 0x000BD872 File Offset: 0x000BBA72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004DD9 RID: 19929 RVA: 0x000BD87F File Offset: 0x000BBA7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004DDA RID: 19930 RVA: 0x000BD888 File Offset: 0x000BBA88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.processedFoodFormulaInfos_.WriteTo(ref output, CookingFormulaUpdateNotify._repeated_processedFoodFormulaInfos_codec);
			this.foodFormulaInfos_.WriteTo(ref output, CookingFormulaUpdateNotify._repeated_foodFormulaInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004DDB RID: 19931 RVA: 0x000BD8C0 File Offset: 0x000BBAC0
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

		// Token: 0x06004DDC RID: 19932 RVA: 0x000BD90C File Offset: 0x000BBB0C
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

		// Token: 0x06004DDD RID: 19933 RVA: 0x000BD94B File Offset: 0x000BBB4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004DDE RID: 19934 RVA: 0x000BD954 File Offset: 0x000BBB54
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
				if (num != 18U)
				{
					if (num != 66U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.foodFormulaInfos_.AddEntriesFrom(ref input, CookingFormulaUpdateNotify._repeated_foodFormulaInfos_codec);
					}
				}
				else
				{
					this.processedFoodFormulaInfos_.AddEntriesFrom(ref input, CookingFormulaUpdateNotify._repeated_processedFoodFormulaInfos_codec);
				}
			}
		}

		// Token: 0x040031C1 RID: 12737
		private UnknownFieldSet _unknownFields;

		// Token: 0x040031C2 RID: 12738
		public const int FoodFormulaInfosFieldNumber = 8;

		// Token: 0x040031C3 RID: 12739
		private static readonly FieldCodec<SingleFoodFormulaInfo> _repeated_foodFormulaInfos_codec = FieldCodec.ForMessage<SingleFoodFormulaInfo>(66U, SingleFoodFormulaInfo.Parser);

		// Token: 0x040031C4 RID: 12740
		private readonly RepeatedField<SingleFoodFormulaInfo> foodFormulaInfos_ = new RepeatedField<SingleFoodFormulaInfo>();

		// Token: 0x040031C5 RID: 12741
		public const int ProcessedFoodFormulaInfosFieldNumber = 2;

		// Token: 0x040031C6 RID: 12742
		private static readonly FieldCodec<SingleProcessedFoodFormulaInfo> _repeated_processedFoodFormulaInfos_codec = FieldCodec.ForMessage<SingleProcessedFoodFormulaInfo>(18U, SingleProcessedFoodFormulaInfo.Parser);

		// Token: 0x040031C7 RID: 12743
		private readonly RepeatedField<SingleProcessedFoodFormulaInfo> processedFoodFormulaInfos_ = new RepeatedField<SingleProcessedFoodFormulaInfo>();
	}
}
