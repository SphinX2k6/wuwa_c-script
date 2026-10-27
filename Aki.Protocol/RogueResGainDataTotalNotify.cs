using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FDF RID: 4063
	[NetMessage(EMessageId.RogueResGainDataTotalNotify)]
	public sealed class RogueResGainDataTotalNotify : IMessage<RogueResGainDataTotalNotify>, IMessage, IEquatable<RogueResGainDataTotalNotify>, IDeepCloneable<RogueResGainDataTotalNotify>, IBufferMessage
	{
		// Token: 0x06015B75 RID: 88949 RVA: 0x00327052 File Offset: 0x00325252
		[NullableContext(1)]
		public static RogueResGainDataTotalNotify Create()
		{
			return new RogueResGainDataTotalNotify();
		}

		// Token: 0x17004870 RID: 18544
		// (get) Token: 0x06015B76 RID: 88950 RVA: 0x00327059 File Offset: 0x00325259
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004871 RID: 18545
		// (get) Token: 0x06015B77 RID: 88951 RVA: 0x0032705C File Offset: 0x0032525C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResGainDataTotalNotify.Descriptor;
			}
		}

		// Token: 0x06015B78 RID: 88952 RVA: 0x00327063 File Offset: 0x00325263
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGainDataTotalNotify()
		{
		}

		// Token: 0x06015B79 RID: 88953 RVA: 0x0032708C File Offset: 0x0032528C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGainDataTotalNotify(RogueResGainDataTotalNotify other) : this()
		{
			this.rogueResGainDatas_ = other.rogueResGainDatas_.Clone();
			this.elementUnits_ = other.elementUnits_.Clone();
			this.roleBondInfos_ = other.roleBondInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015B7A RID: 88954 RVA: 0x003270E3 File Offset: 0x003252E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGainDataTotalNotify Clone()
		{
			return new RogueResGainDataTotalNotify(this);
		}

		// Token: 0x17004872 RID: 18546
		// (get) Token: 0x06015B7B RID: 88955 RVA: 0x003270EB File Offset: 0x003252EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueResGainData> RogueResGainDatas
		{
			get
			{
				return this.rogueResGainDatas_;
			}
		}

		// Token: 0x17004873 RID: 18547
		// (get) Token: 0x06015B7C RID: 88956 RVA: 0x003270F3 File Offset: 0x003252F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ElementUnit> ElementUnits
		{
			get
			{
				return this.elementUnits_;
			}
		}

		// Token: 0x17004874 RID: 18548
		// (get) Token: 0x06015B7D RID: 88957 RVA: 0x003270FB File Offset: 0x003252FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleBondInfo> RoleBondInfos
		{
			get
			{
				return this.roleBondInfos_;
			}
		}

		// Token: 0x06015B7E RID: 88958 RVA: 0x00327103 File Offset: 0x00325303
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResGainDataTotalNotify);
		}

		// Token: 0x06015B7F RID: 88959 RVA: 0x00327114 File Offset: 0x00325314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResGainDataTotalNotify other)
		{
			return other != null && (other == this || (this.rogueResGainDatas_.Equals(other.rogueResGainDatas_) && this.elementUnits_.Equals(other.elementUnits_) && this.roleBondInfos_.Equals(other.roleBondInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015B80 RID: 88960 RVA: 0x0032717C File Offset: 0x0032537C
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

		// Token: 0x06015B81 RID: 88961 RVA: 0x003271CC File Offset: 0x003253CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015B82 RID: 88962 RVA: 0x003271D9 File Offset: 0x003253D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015B83 RID: 88963 RVA: 0x003271E4 File Offset: 0x003253E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleBondInfos_.WriteTo(ref output, RogueResGainDataTotalNotify._repeated_roleBondInfos_codec);
			this.elementUnits_.WriteTo(ref output, RogueResGainDataTotalNotify._repeated_elementUnits_codec);
			this.rogueResGainDatas_.WriteTo(ref output, RogueResGainDataTotalNotify._repeated_rogueResGainDatas_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015B84 RID: 88964 RVA: 0x00327238 File Offset: 0x00325438
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

		// Token: 0x06015B85 RID: 88965 RVA: 0x00327298 File Offset: 0x00325498
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

		// Token: 0x06015B86 RID: 88966 RVA: 0x003272F3 File Offset: 0x003254F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015B87 RID: 88967 RVA: 0x003272FC File Offset: 0x003254FC
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
				if (num != 26U)
				{
					if (num != 98U)
					{
						if (num != 114U)
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
						this.elementUnits_.AddEntriesFrom(ref input, RogueResGainDataTotalNotify._repeated_elementUnits_codec);
					}
				}
				else
				{
					this.roleBondInfos_.AddEntriesFrom(ref input, RogueResGainDataTotalNotify._repeated_roleBondInfos_codec);
				}
			}
		}

		// Token: 0x0400824D RID: 33357
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400824E RID: 33358
		public const int RogueResGainDatasFieldNumber = 14;

		// Token: 0x0400824F RID: 33359
		private static readonly FieldCodec<RogueResGainData> _repeated_rogueResGainDatas_codec = FieldCodec.ForMessage<RogueResGainData>(114U, RogueResGainData.Parser);

		// Token: 0x04008250 RID: 33360
		private readonly RepeatedField<RogueResGainData> rogueResGainDatas_ = new RepeatedField<RogueResGainData>();

		// Token: 0x04008251 RID: 33361
		public const int ElementUnitsFieldNumber = 12;

		// Token: 0x04008252 RID: 33362
		private static readonly FieldCodec<ElementUnit> _repeated_elementUnits_codec = FieldCodec.ForMessage<ElementUnit>(98U, ElementUnit.Parser);

		// Token: 0x04008253 RID: 33363
		private readonly RepeatedField<ElementUnit> elementUnits_ = new RepeatedField<ElementUnit>();

		// Token: 0x04008254 RID: 33364
		public const int RoleBondInfosFieldNumber = 3;

		// Token: 0x04008255 RID: 33365
		private static readonly FieldCodec<RoleBondInfo> _repeated_roleBondInfos_codec = FieldCodec.ForMessage<RoleBondInfo>(26U, RoleBondInfo.Parser);

		// Token: 0x04008256 RID: 33366
		private readonly RepeatedField<RoleBondInfo> roleBondInfos_ = new RepeatedField<RoleBondInfo>();
	}
}
