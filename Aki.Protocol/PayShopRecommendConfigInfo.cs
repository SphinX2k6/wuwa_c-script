using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BF6 RID: 3062
	public sealed class PayShopRecommendConfigInfo : IMessage<PayShopRecommendConfigInfo>, IMessage, IEquatable<PayShopRecommendConfigInfo>, IDeepCloneable<PayShopRecommendConfigInfo>, IBufferMessage
	{
		// Token: 0x060109CF RID: 68047 RVA: 0x0026E54E File Offset: 0x0026C74E
		[NullableContext(1)]
		public static PayShopRecommendConfigInfo Create()
		{
			return new PayShopRecommendConfigInfo();
		}

		// Token: 0x170036B6 RID: 14006
		// (get) Token: 0x060109D0 RID: 68048 RVA: 0x0026E555 File Offset: 0x0026C755
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PayShopRecommendConfigInfo> Parser
		{
			get
			{
				return PayShopRecommendConfigInfo._parser;
			}
		}

		// Token: 0x170036B7 RID: 14007
		// (get) Token: 0x060109D1 RID: 68049 RVA: 0x0026E55C File Offset: 0x0026C75C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170036B8 RID: 14008
		// (get) Token: 0x060109D2 RID: 68050 RVA: 0x0026E55F File Offset: 0x0026C75F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayShopRecommendConfigInfo.Descriptor;
			}
		}

		// Token: 0x060109D3 RID: 68051 RVA: 0x0026E566 File Offset: 0x0026C766
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopRecommendConfigInfo()
		{
		}

		// Token: 0x060109D4 RID: 68052 RVA: 0x0026E590 File Offset: 0x0026C790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopRecommendConfigInfo(PayShopRecommendConfigInfo other) : this()
		{
			this.id_ = other.id_;
			this.recommendType_ = other.recommendType_;
			this.recommendId_ = other.recommendId_;
			this.tabName_ = other.tabName_;
			this.prefabPath_ = other.prefabPath_;
			this.sort_ = other.sort_;
			this.show_ = other.show_;
			this.tabImage_ = other.tabImage_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060109D5 RID: 68053 RVA: 0x0026E614 File Offset: 0x0026C814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopRecommendConfigInfo Clone()
		{
			return new PayShopRecommendConfigInfo(this);
		}

		// Token: 0x170036B9 RID: 14009
		// (get) Token: 0x060109D6 RID: 68054 RVA: 0x0026E61C File Offset: 0x0026C81C
		// (set) Token: 0x060109D7 RID: 68055 RVA: 0x0026E624 File Offset: 0x0026C824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170036BA RID: 14010
		// (get) Token: 0x060109D8 RID: 68056 RVA: 0x0026E62D File Offset: 0x0026C82D
		// (set) Token: 0x060109D9 RID: 68057 RVA: 0x0026E635 File Offset: 0x0026C835
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RecommendType
		{
			get
			{
				return this.recommendType_;
			}
			set
			{
				this.recommendType_ = value;
			}
		}

		// Token: 0x170036BB RID: 14011
		// (get) Token: 0x060109DA RID: 68058 RVA: 0x0026E63E File Offset: 0x0026C83E
		// (set) Token: 0x060109DB RID: 68059 RVA: 0x0026E646 File Offset: 0x0026C846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RecommendId
		{
			get
			{
				return this.recommendId_;
			}
			set
			{
				this.recommendId_ = value;
			}
		}

		// Token: 0x170036BC RID: 14012
		// (get) Token: 0x060109DC RID: 68060 RVA: 0x0026E64F File Offset: 0x0026C84F
		// (set) Token: 0x060109DD RID: 68061 RVA: 0x0026E657 File Offset: 0x0026C857
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string TabName
		{
			get
			{
				return this.tabName_;
			}
			set
			{
				this.tabName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170036BD RID: 14013
		// (get) Token: 0x060109DE RID: 68062 RVA: 0x0026E66A File Offset: 0x0026C86A
		// (set) Token: 0x060109DF RID: 68063 RVA: 0x0026E672 File Offset: 0x0026C872
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PrefabPath
		{
			get
			{
				return this.prefabPath_;
			}
			set
			{
				this.prefabPath_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170036BE RID: 14014
		// (get) Token: 0x060109E0 RID: 68064 RVA: 0x0026E685 File Offset: 0x0026C885
		// (set) Token: 0x060109E1 RID: 68065 RVA: 0x0026E68D File Offset: 0x0026C88D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Sort
		{
			get
			{
				return this.sort_;
			}
			set
			{
				this.sort_ = value;
			}
		}

		// Token: 0x170036BF RID: 14015
		// (get) Token: 0x060109E2 RID: 68066 RVA: 0x0026E696 File Offset: 0x0026C896
		// (set) Token: 0x060109E3 RID: 68067 RVA: 0x0026E69E File Offset: 0x0026C89E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Show
		{
			get
			{
				return this.show_;
			}
			set
			{
				this.show_ = value;
			}
		}

		// Token: 0x170036C0 RID: 14016
		// (get) Token: 0x060109E4 RID: 68068 RVA: 0x0026E6A7 File Offset: 0x0026C8A7
		// (set) Token: 0x060109E5 RID: 68069 RVA: 0x0026E6AF File Offset: 0x0026C8AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string TabImage
		{
			get
			{
				return this.tabImage_;
			}
			set
			{
				this.tabImage_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x060109E6 RID: 68070 RVA: 0x0026E6C2 File Offset: 0x0026C8C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayShopRecommendConfigInfo);
		}

		// Token: 0x060109E7 RID: 68071 RVA: 0x0026E6D0 File Offset: 0x0026C8D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayShopRecommendConfigInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.RecommendType == other.RecommendType && this.RecommendId == other.RecommendId && !(this.TabName != other.TabName) && !(this.PrefabPath != other.PrefabPath) && this.Sort == other.Sort && this.Show == other.Show && !(this.TabImage != other.TabImage) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060109E8 RID: 68072 RVA: 0x0026E788 File Offset: 0x0026C988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.RecommendType != 0)
			{
				num ^= this.RecommendType.GetHashCode();
			}
			if (this.RecommendId != 0)
			{
				num ^= this.RecommendId.GetHashCode();
			}
			if (this.TabName.Length != 0)
			{
				num ^= this.TabName.GetHashCode();
			}
			if (this.PrefabPath.Length != 0)
			{
				num ^= this.PrefabPath.GetHashCode();
			}
			if (this.Sort != 0)
			{
				num ^= this.Sort.GetHashCode();
			}
			if (this.Show)
			{
				num ^= this.Show.GetHashCode();
			}
			if (this.TabImage.Length != 0)
			{
				num ^= this.TabImage.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060109E9 RID: 68073 RVA: 0x0026E87C File Offset: 0x0026CA7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060109EA RID: 68074 RVA: 0x0026E889 File Offset: 0x0026CA89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060109EB RID: 68075 RVA: 0x0026E894 File Offset: 0x0026CA94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.RecommendType != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RecommendType);
			}
			if (this.RecommendId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RecommendId);
			}
			if (this.TabName.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.TabName);
			}
			if (this.PrefabPath.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.PrefabPath);
			}
			if (this.Sort != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Sort);
			}
			if (this.Show)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.Show);
			}
			if (this.TabImage.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteString(this.TabImage);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060109EC RID: 68076 RVA: 0x0026E9A4 File Offset: 0x0026CBA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.RecommendType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RecommendType);
			}
			if (this.RecommendId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RecommendId);
			}
			if (this.TabName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.TabName);
			}
			if (this.PrefabPath.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PrefabPath);
			}
			if (this.Sort != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Sort);
			}
			if (this.Show)
			{
				num += 2;
			}
			if (this.TabImage.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.TabImage);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060109ED RID: 68077 RVA: 0x0026EA90 File Offset: 0x0026CC90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PayShopRecommendConfigInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.RecommendType != 0)
			{
				this.RecommendType = other.RecommendType;
			}
			if (other.RecommendId != 0)
			{
				this.RecommendId = other.RecommendId;
			}
			if (other.TabName.Length != 0)
			{
				this.TabName = other.TabName;
			}
			if (other.PrefabPath.Length != 0)
			{
				this.PrefabPath = other.PrefabPath;
			}
			if (other.Sort != 0)
			{
				this.Sort = other.Sort;
			}
			if (other.Show)
			{
				this.Show = other.Show;
			}
			if (other.TabImage.Length != 0)
			{
				this.TabImage = other.TabImage;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060109EE RID: 68078 RVA: 0x0026EB67 File Offset: 0x0026CD67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060109EF RID: 68079 RVA: 0x0026EB70 File Offset: 0x0026CD70
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
				if (num <= 34U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.Id = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.RecommendType = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.RecommendId = input.ReadInt32();
							continue;
						}
						if (num == 34U)
						{
							this.TabName = input.ReadString();
							continue;
						}
					}
				}
				else if (num <= 48U)
				{
					if (num == 42U)
					{
						this.PrefabPath = input.ReadString();
						continue;
					}
					if (num == 48U)
					{
						this.Sort = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.Show = input.ReadBool();
						continue;
					}
					if (num == 66U)
					{
						this.TabImage = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006992 RID: 27026
		private static readonly MessageParser<PayShopRecommendConfigInfo> _parser = new MessageParser<PayShopRecommendConfigInfo>(() => new PayShopRecommendConfigInfo());

		// Token: 0x04006993 RID: 27027
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006994 RID: 27028
		public const int IdFieldNumber = 1;

		// Token: 0x04006995 RID: 27029
		private int id_;

		// Token: 0x04006996 RID: 27030
		public const int RecommendTypeFieldNumber = 2;

		// Token: 0x04006997 RID: 27031
		private int recommendType_;

		// Token: 0x04006998 RID: 27032
		public const int RecommendIdFieldNumber = 3;

		// Token: 0x04006999 RID: 27033
		private int recommendId_;

		// Token: 0x0400699A RID: 27034
		public const int TabNameFieldNumber = 4;

		// Token: 0x0400699B RID: 27035
		private string tabName_ = "";

		// Token: 0x0400699C RID: 27036
		public const int PrefabPathFieldNumber = 5;

		// Token: 0x0400699D RID: 27037
		private string prefabPath_ = "";

		// Token: 0x0400699E RID: 27038
		public const int SortFieldNumber = 6;

		// Token: 0x0400699F RID: 27039
		private int sort_;

		// Token: 0x040069A0 RID: 27040
		public const int ShowFieldNumber = 7;

		// Token: 0x040069A1 RID: 27041
		private bool show_;

		// Token: 0x040069A2 RID: 27042
		public const int TabImageFieldNumber = 8;

		// Token: 0x040069A3 RID: 27043
		private string tabImage_ = "";
	}
}
