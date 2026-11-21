using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FCF RID: 4047
	[NetMessage(EMessageId.RogueResGainDataTotalNotify)]
	public sealed class RogueResGainDataTotalNotify : IMessage<RogueResGainDataTotalNotify>, IMessage, IEquatable<RogueResGainDataTotalNotify>, IDeepCloneable<RogueResGainDataTotalNotify>, IBufferMessage
	{
		// Token: 0x06015A90 RID: 88720 RVA: 0x0032599E File Offset: 0x00323B9E
		[NullableContext(1)]
		public static RogueResGainDataTotalNotify Create()
		{
			return new RogueResGainDataTotalNotify();
		}

		// Token: 0x17004846 RID: 18502
		// (get) Token: 0x06015A91 RID: 88721 RVA: 0x003259A5 File Offset: 0x00323BA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004847 RID: 18503
		// (get) Token: 0x06015A92 RID: 88722 RVA: 0x003259A8 File Offset: 0x00323BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResGainDataTotalNotify.Descriptor;
			}
		}

		// Token: 0x06015A93 RID: 88723 RVA: 0x003259AF File Offset: 0x00323BAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGainDataTotalNotify()
		{
		}

		// Token: 0x06015A94 RID: 88724 RVA: 0x003259D8 File Offset: 0x00323BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGainDataTotalNotify(RogueResGainDataTotalNotify other) : this()
		{
			this.rogueResGainDatas_ = other.rogueResGainDatas_.Clone();
			this.elementUnits_ = other.elementUnits_.Clone();
			this.roleBondInfos_ = other.roleBondInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015A95 RID: 88725 RVA: 0x00325A2F File Offset: 0x00323C2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGainDataTotalNotify Clone()
		{
			return new RogueResGainDataTotalNotify(this);
		}

		// Token: 0x17004848 RID: 18504
		// (get) Token: 0x06015A96 RID: 88726 RVA: 0x00325A37 File Offset: 0x00323C37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueResGainData> RogueResGainDatas
		{
			get
			{
				return this.rogueResGainDatas_;
			}
		}

		// Token: 0x17004849 RID: 18505
		// (get) Token: 0x06015A97 RID: 88727 RVA: 0x00325A3F File Offset: 0x00323C3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ElementUnit> ElementUnits
		{
			get
			{
				return this.elementUnits_;
			}
		}

		// Token: 0x1700484A RID: 18506
		// (get) Token: 0x06015A98 RID: 88728 RVA: 0x00325A47 File Offset: 0x00323C47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleBondInfo> RoleBondInfos
		{
			get
			{
				return this.roleBondInfos_;
			}
		}

		// Token: 0x06015A99 RID: 88729 RVA: 0x00325A4F File Offset: 0x00323C4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResGainDataTotalNotify);
		}

		// Token: 0x06015A9A RID: 88730 RVA: 0x00325A60 File Offset: 0x00323C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResGainDataTotalNotify other)
		{
			return other != null && (other == this || (this.rogueResGainDatas_.Equals(other.rogueResGainDatas_) && this.elementUnits_.Equals(other.elementUnits_) && this.roleBondInfos_.Equals(other.roleBondInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015A9B RID: 88731 RVA: 0x00325AC8 File Offset: 0x00323CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.rogueResGainDatas_.GetHashCode();
			num ^= this.elementUnits_.GetHashCode();
			num ^= this.roleBondInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015A9C RID: 88732 RVA: 0x00325B18 File Offset: 0x00323D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015A9D RID: 88733 RVA: 0x00325B25 File Offset: 0x00323D25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015A9E RID: 88734 RVA: 0x00325B30 File Offset: 0x00323D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.elementUnits_.WriteTo(ref output, RogueResGainDataTotalNotify._repeated_elementUnits_codec);
			this.roleBondInfos_.WriteTo(ref output, RogueResGainDataTotalNotify._repeated_roleBondInfos_codec);
			this.rogueResGainDatas_.WriteTo(ref output, RogueResGainDataTotalNotify._repeated_rogueResGainDatas_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015A9F RID: 88735 RVA: 0x00325B84 File Offset: 0x00323D84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rogueResGainDatas_.CalculateSize(RogueResGainDataTotalNotify._repeated_rogueResGainDatas_codec);
			num += this.elementUnits_.CalculateSize(RogueResGainDataTotalNotify._repeated_elementUnits_codec);
			num += this.roleBondInfos_.CalculateSize(RogueResGainDataTotalNotify._repeated_roleBondInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015AA0 RID: 88736 RVA: 0x00325BE4 File Offset: 0x00323DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResGainDataTotalNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.rogueResGainDatas_.Add(other.rogueResGainDatas_);
			this.elementUnits_.Add(other.elementUnits_);
			this.roleBondInfos_.Add(other.roleBondInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015AA1 RID: 88737 RVA: 0x00325C3F File Offset: 0x00323E3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015AA2 RID: 88738 RVA: 0x00325C48 File Offset: 0x00323E48
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
				if (num != 42U)
				{
					if (num != 50U)
					{
						if (num != 122U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.rogueResGainDatas_.AddEntriesFrom(ref input, RogueResGainDataTotalNotify._repeated_rogueResGainDatas_codec);
						}
					}
					else
					{
						this.roleBondInfos_.AddEntriesFrom(ref input, RogueResGainDataTotalNotify._repeated_roleBondInfos_codec);
					}
				}
				else
				{
					this.elementUnits_.AddEntriesFrom(ref input, RogueResGainDataTotalNotify._repeated_elementUnits_codec);
				}
			}
		}

		// Token: 0x04008277 RID: 33399
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008278 RID: 33400
		public const int RogueResGainDatasFieldNumber = 15;

		// Token: 0x04008279 RID: 33401
		private static readonly FieldCodec<RogueResGainData> _repeated_rogueResGainDatas_codec = FieldCodec.ForMessage<RogueResGainData>(122U, RogueResGainData.Parser);

		// Token: 0x0400827A RID: 33402
		private readonly RepeatedField<RogueResGainData> rogueResGainDatas_ = new RepeatedField<RogueResGainData>();

		// Token: 0x0400827B RID: 33403
		public const int ElementUnitsFieldNumber = 5;

		// Token: 0x0400827C RID: 33404
		private static readonly FieldCodec<ElementUnit> _repeated_elementUnits_codec = FieldCodec.ForMessage<ElementUnit>(42U, ElementUnit.Parser);

		// Token: 0x0400827D RID: 33405
		private readonly RepeatedField<ElementUnit> elementUnits_ = new RepeatedField<ElementUnit>();

		// Token: 0x0400827E RID: 33406
		public const int RoleBondInfosFieldNumber = 6;

		// Token: 0x0400827F RID: 33407
		private static readonly FieldCodec<RoleBondInfo> _repeated_roleBondInfos_codec = FieldCodec.ForMessage<RoleBondInfo>(50U, RoleBondInfo.Parser);

		// Token: 0x04008280 RID: 33408
		private readonly RepeatedField<RoleBondInfo> roleBondInfos_ = new RepeatedField<RoleBondInfo>();
	}
}
