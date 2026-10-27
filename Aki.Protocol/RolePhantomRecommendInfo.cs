using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200109A RID: 4250
	public sealed class RolePhantomRecommendInfo : IMessage<RolePhantomRecommendInfo>, IMessage, IEquatable<RolePhantomRecommendInfo>, IDeepCloneable<RolePhantomRecommendInfo>, IBufferMessage
	{
		// Token: 0x06016B36 RID: 92982 RVA: 0x0034CB25 File Offset: 0x0034AD25
		[NullableContext(1)]
		public static RolePhantomRecommendInfo Create()
		{
			return new RolePhantomRecommendInfo();
		}

		// Token: 0x17004C0E RID: 19470
		// (get) Token: 0x06016B37 RID: 92983 RVA: 0x0034CB2C File Offset: 0x0034AD2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RolePhantomRecommendInfo> Parser
		{
			get
			{
				return RolePhantomRecommendInfo._parser;
			}
		}

		// Token: 0x17004C0F RID: 19471
		// (get) Token: 0x06016B38 RID: 92984 RVA: 0x0034CB33 File Offset: 0x0034AD33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C10 RID: 19472
		// (get) Token: 0x06016B39 RID: 92985 RVA: 0x0034CB36 File Offset: 0x0034AD36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RolePhantomRecommendInfo.Descriptor;
			}
		}

		// Token: 0x06016B3A RID: 92986 RVA: 0x0034CB3D File Offset: 0x0034AD3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePhantomRecommendInfo()
		{
		}

		// Token: 0x06016B3B RID: 92987 RVA: 0x0034CB5B File Offset: 0x0034AD5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePhantomRecommendInfo(RolePhantomRecommendInfo other) : this()
		{
			this.phantomFetterRecommendInfos_ = other.phantomFetterRecommendInfos_.Clone();
			this.costPhantomAttrRecommendInfos_ = other.costPhantomAttrRecommendInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016B3C RID: 92988 RVA: 0x0034CB96 File Offset: 0x0034AD96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePhantomRecommendInfo Clone()
		{
			return new RolePhantomRecommendInfo(this);
		}

		// Token: 0x17004C11 RID: 19473
		// (get) Token: 0x06016B3D RID: 92989 RVA: 0x0034CB9E File Offset: 0x0034AD9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomFetterRecommendInfo> PhantomFetterRecommendInfos
		{
			get
			{
				return this.phantomFetterRecommendInfos_;
			}
		}

		// Token: 0x17004C12 RID: 19474
		// (get) Token: 0x06016B3E RID: 92990 RVA: 0x0034CBA6 File Offset: 0x0034ADA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CostPhantomAttrRecommendInfo> CostPhantomAttrRecommendInfos
		{
			get
			{
				return this.costPhantomAttrRecommendInfos_;
			}
		}

		// Token: 0x06016B3F RID: 92991 RVA: 0x0034CBAE File Offset: 0x0034ADAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RolePhantomRecommendInfo);
		}

		// Token: 0x06016B40 RID: 92992 RVA: 0x0034CBBC File Offset: 0x0034ADBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RolePhantomRecommendInfo other)
		{
			return other != null && (other == this || (this.phantomFetterRecommendInfos_.Equals(other.phantomFetterRecommendInfos_) && this.costPhantomAttrRecommendInfos_.Equals(other.costPhantomAttrRecommendInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016B41 RID: 92993 RVA: 0x0034CC10 File Offset: 0x0034AE10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.phantomFetterRecommendInfos_.GetHashCode();
			num ^= this.costPhantomAttrRecommendInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016B42 RID: 92994 RVA: 0x0034CC52 File Offset: 0x0034AE52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016B43 RID: 92995 RVA: 0x0034CC5F File Offset: 0x0034AE5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016B44 RID: 92996 RVA: 0x0034CC68 File Offset: 0x0034AE68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomFetterRecommendInfos_.WriteTo(ref output, RolePhantomRecommendInfo._repeated_phantomFetterRecommendInfos_codec);
			this.costPhantomAttrRecommendInfos_.WriteTo(ref output, RolePhantomRecommendInfo._repeated_costPhantomAttrRecommendInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016B45 RID: 92997 RVA: 0x0034CCA0 File Offset: 0x0034AEA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.phantomFetterRecommendInfos_.CalculateSize(RolePhantomRecommendInfo._repeated_phantomFetterRecommendInfos_codec);
			num += this.costPhantomAttrRecommendInfos_.CalculateSize(RolePhantomRecommendInfo._repeated_costPhantomAttrRecommendInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016B46 RID: 92998 RVA: 0x0034CCEC File Offset: 0x0034AEEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RolePhantomRecommendInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.phantomFetterRecommendInfos_.Add(other.phantomFetterRecommendInfos_);
			this.costPhantomAttrRecommendInfos_.Add(other.costPhantomAttrRecommendInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016B47 RID: 92999 RVA: 0x0034CD2B File Offset: 0x0034AF2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016B48 RID: 93000 RVA: 0x0034CD34 File Offset: 0x0034AF34
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
				if (num != 10U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.costPhantomAttrRecommendInfos_.AddEntriesFrom(ref input, RolePhantomRecommendInfo._repeated_costPhantomAttrRecommendInfos_codec);
					}
				}
				else
				{
					this.phantomFetterRecommendInfos_.AddEntriesFrom(ref input, RolePhantomRecommendInfo._repeated_phantomFetterRecommendInfos_codec);
				}
			}
		}

		// Token: 0x0400879F RID: 34719
		private static readonly MessageParser<RolePhantomRecommendInfo> _parser = new MessageParser<RolePhantomRecommendInfo>(() => new RolePhantomRecommendInfo());

		// Token: 0x040087A0 RID: 34720
		private UnknownFieldSet _unknownFields;

		// Token: 0x040087A1 RID: 34721
		public const int PhantomFetterRecommendInfosFieldNumber = 1;

		// Token: 0x040087A2 RID: 34722
		private static readonly FieldCodec<PhantomFetterRecommendInfo> _repeated_phantomFetterRecommendInfos_codec = FieldCodec.ForMessage<PhantomFetterRecommendInfo>(10U, PhantomFetterRecommendInfo.Parser);

		// Token: 0x040087A3 RID: 34723
		private readonly RepeatedField<PhantomFetterRecommendInfo> phantomFetterRecommendInfos_ = new RepeatedField<PhantomFetterRecommendInfo>();

		// Token: 0x040087A4 RID: 34724
		public const int CostPhantomAttrRecommendInfosFieldNumber = 2;

		// Token: 0x040087A5 RID: 34725
		private static readonly FieldCodec<CostPhantomAttrRecommendInfo> _repeated_costPhantomAttrRecommendInfos_codec = FieldCodec.ForMessage<CostPhantomAttrRecommendInfo>(18U, CostPhantomAttrRecommendInfo.Parser);

		// Token: 0x040087A6 RID: 34726
		private readonly RepeatedField<CostPhantomAttrRecommendInfo> costPhantomAttrRecommendInfos_ = new RepeatedField<CostPhantomAttrRecommendInfo>();
	}
}
