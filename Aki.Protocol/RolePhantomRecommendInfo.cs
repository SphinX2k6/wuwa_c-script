using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200108A RID: 4234
	public sealed class RolePhantomRecommendInfo : IMessage<RolePhantomRecommendInfo>, IMessage, IEquatable<RolePhantomRecommendInfo>, IDeepCloneable<RolePhantomRecommendInfo>, IBufferMessage
	{
		// Token: 0x06016A51 RID: 92753 RVA: 0x0034B449 File Offset: 0x00349649
		[NullableContext(1)]
		public static RolePhantomRecommendInfo Create()
		{
			return new RolePhantomRecommendInfo();
		}

		// Token: 0x17004BE4 RID: 19428
		// (get) Token: 0x06016A52 RID: 92754 RVA: 0x0034B450 File Offset: 0x00349650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RolePhantomRecommendInfo> Parser
		{
			get
			{
				return RolePhantomRecommendInfo._parser;
			}
		}

		// Token: 0x17004BE5 RID: 19429
		// (get) Token: 0x06016A53 RID: 92755 RVA: 0x0034B457 File Offset: 0x00349657
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004BE6 RID: 19430
		// (get) Token: 0x06016A54 RID: 92756 RVA: 0x0034B45A File Offset: 0x0034965A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RolePhantomRecommendInfo.Descriptor;
			}
		}

		// Token: 0x06016A55 RID: 92757 RVA: 0x0034B461 File Offset: 0x00349661
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePhantomRecommendInfo()
		{
		}

		// Token: 0x06016A56 RID: 92758 RVA: 0x0034B47F File Offset: 0x0034967F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePhantomRecommendInfo(RolePhantomRecommendInfo other) : this()
		{
			this.phantomFetterRecommendInfos_ = other.phantomFetterRecommendInfos_.Clone();
			this.costPhantomAttrRecommendInfos_ = other.costPhantomAttrRecommendInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016A57 RID: 92759 RVA: 0x0034B4BA File Offset: 0x003496BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePhantomRecommendInfo Clone()
		{
			return new RolePhantomRecommendInfo(this);
		}

		// Token: 0x17004BE7 RID: 19431
		// (get) Token: 0x06016A58 RID: 92760 RVA: 0x0034B4C2 File Offset: 0x003496C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomFetterRecommendInfo> PhantomFetterRecommendInfos
		{
			get
			{
				return this.phantomFetterRecommendInfos_;
			}
		}

		// Token: 0x17004BE8 RID: 19432
		// (get) Token: 0x06016A59 RID: 92761 RVA: 0x0034B4CA File Offset: 0x003496CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CostPhantomAttrRecommendInfo> CostPhantomAttrRecommendInfos
		{
			get
			{
				return this.costPhantomAttrRecommendInfos_;
			}
		}

		// Token: 0x06016A5A RID: 92762 RVA: 0x0034B4D2 File Offset: 0x003496D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RolePhantomRecommendInfo);
		}

		// Token: 0x06016A5B RID: 92763 RVA: 0x0034B4E0 File Offset: 0x003496E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RolePhantomRecommendInfo other)
		{
			return other != null && (other == this || (this.phantomFetterRecommendInfos_.Equals(other.phantomFetterRecommendInfos_) && this.costPhantomAttrRecommendInfos_.Equals(other.costPhantomAttrRecommendInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016A5C RID: 92764 RVA: 0x0034B534 File Offset: 0x00349734
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

		// Token: 0x06016A5D RID: 92765 RVA: 0x0034B576 File Offset: 0x00349776
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016A5E RID: 92766 RVA: 0x0034B583 File Offset: 0x00349783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016A5F RID: 92767 RVA: 0x0034B58C File Offset: 0x0034978C
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

		// Token: 0x06016A60 RID: 92768 RVA: 0x0034B5C4 File Offset: 0x003497C4
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

		// Token: 0x06016A61 RID: 92769 RVA: 0x0034B610 File Offset: 0x00349810
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

		// Token: 0x06016A62 RID: 92770 RVA: 0x0034B64F File Offset: 0x0034984F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016A63 RID: 92771 RVA: 0x0034B658 File Offset: 0x00349858
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

		// Token: 0x040087C9 RID: 34761
		private static readonly MessageParser<RolePhantomRecommendInfo> _parser = new MessageParser<RolePhantomRecommendInfo>(() => new RolePhantomRecommendInfo());

		// Token: 0x040087CA RID: 34762
		private UnknownFieldSet _unknownFields;

		// Token: 0x040087CB RID: 34763
		public const int PhantomFetterRecommendInfosFieldNumber = 1;

		// Token: 0x040087CC RID: 34764
		private static readonly FieldCodec<PhantomFetterRecommendInfo> _repeated_phantomFetterRecommendInfos_codec = FieldCodec.ForMessage<PhantomFetterRecommendInfo>(10U, PhantomFetterRecommendInfo.Parser);

		// Token: 0x040087CD RID: 34765
		private readonly RepeatedField<PhantomFetterRecommendInfo> phantomFetterRecommendInfos_ = new RepeatedField<PhantomFetterRecommendInfo>();

		// Token: 0x040087CE RID: 34766
		public const int CostPhantomAttrRecommendInfosFieldNumber = 2;

		// Token: 0x040087CF RID: 34767
		private static readonly FieldCodec<CostPhantomAttrRecommendInfo> _repeated_costPhantomAttrRecommendInfos_codec = FieldCodec.ForMessage<CostPhantomAttrRecommendInfo>(18U, CostPhantomAttrRecommendInfo.Parser);

		// Token: 0x040087D0 RID: 34768
		private readonly RepeatedField<CostPhantomAttrRecommendInfo> costPhantomAttrRecommendInfos_ = new RepeatedField<CostPhantomAttrRecommendInfo>();
	}
}
