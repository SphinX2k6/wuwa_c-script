using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BE6 RID: 3046
	public sealed class PayShopRecommendConfigInfo : IMessage<PayShopRecommendConfigInfo>, IMessage, IEquatable<PayShopRecommendConfigInfo>, IDeepCloneable<PayShopRecommendConfigInfo>, IBufferMessage
	{
		// Token: 0x060108CF RID: 67791 RVA: 0x0026C7E6 File Offset: 0x0026A9E6
		[NullableContext(1)]
		public static PayShopRecommendConfigInfo Create()
		{
			return new PayShopRecommendConfigInfo();
		}

		// Token: 0x1700367F RID: 13951
		// (get) Token: 0x060108D0 RID: 67792 RVA: 0x0026C7ED File Offset: 0x0026A9ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PayShopRecommendConfigInfo> Parser
		{
			get
			{
				return PayShopRecommendConfigInfo._parser;
			}
		}

		// Token: 0x17003680 RID: 13952
		// (get) Token: 0x060108D1 RID: 67793 RVA: 0x0026C7F4 File Offset: 0x0026A9F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003681 RID: 13953
		// (get) Token: 0x060108D2 RID: 67794 RVA: 0x0026C7F7 File Offset: 0x0026A9F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayShopRecommendConfigInfo.Descriptor;
			}
		}

		// Token: 0x060108D3 RID: 67795 RVA: 0x0026C7FE File Offset: 0x0026A9FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopRecommendConfigInfo()
		{
		}

		// Token: 0x060108D4 RID: 67796 RVA: 0x0026C828 File Offset: 0x0026AA28
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

		// Token: 0x060108D5 RID: 67797 RVA: 0x0026C8AC File Offset: 0x0026AAAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopRecommendConfigInfo Clone()
		{
			return new PayShopRecommendConfigInfo(this);
		}

		// Token: 0x17003682 RID: 13954
		// (get) Token: 0x060108D6 RID: 67798 RVA: 0x0026C8B4 File Offset: 0x0026AAB4
		// (set) Token: 0x060108D7 RID: 67799 RVA: 0x0026C8BC File Offset: 0x0026AABC
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

		// Token: 0x17003683 RID: 13955
		// (get) Token: 0x060108D8 RID: 67800 RVA: 0x0026C8C5 File Offset: 0x0026AAC5
		// (set) Token: 0x060108D9 RID: 67801 RVA: 0x0026C8CD File Offset: 0x0026AACD
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

		// Token: 0x17003684 RID: 13956
		// (get) Token: 0x060108DA RID: 67802 RVA: 0x0026C8D6 File Offset: 0x0026AAD6
		// (set) Token: 0x060108DB RID: 67803 RVA: 0x0026C8DE File Offset: 0x0026AADE
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

		// Token: 0x17003685 RID: 13957
		// (get) Token: 0x060108DC RID: 67804 RVA: 0x0026C8E7 File Offset: 0x0026AAE7
		// (set) Token: 0x060108DD RID: 67805 RVA: 0x0026C8EF File Offset: 0x0026AAEF
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

		// Token: 0x17003686 RID: 13958
		// (get) Token: 0x060108DE RID: 67806 RVA: 0x0026C902 File Offset: 0x0026AB02
		// (set) Token: 0x060108DF RID: 67807 RVA: 0x0026C90A File Offset: 0x0026AB0A
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

		// Token: 0x17003687 RID: 13959
		// (get) Token: 0x060108E0 RID: 67808 RVA: 0x0026C91D File Offset: 0x0026AB1D
		// (set) Token: 0x060108E1 RID: 67809 RVA: 0x0026C925 File Offset: 0x0026AB25
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

		// Token: 0x17003688 RID: 13960
		// (get) Token: 0x060108E2 RID: 67810 RVA: 0x0026C92E File Offset: 0x0026AB2E
		// (set) Token: 0x060108E3 RID: 67811 RVA: 0x0026C936 File Offset: 0x0026AB36
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

		// Token: 0x17003689 RID: 13961
		// (get) Token: 0x060108E4 RID: 67812 RVA: 0x0026C93F File Offset: 0x0026AB3F
		// (set) Token: 0x060108E5 RID: 67813 RVA: 0x0026C947 File Offset: 0x0026AB47
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

		// Token: 0x060108E6 RID: 67814 RVA: 0x0026C95A File Offset: 0x0026AB5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayShopRecommendConfigInfo);
		}

		// Token: 0x060108E7 RID: 67815 RVA: 0x0026C968 File Offset: 0x0026AB68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayShopRecommendConfigInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.RecommendType == other.RecommendType && this.RecommendId == other.RecommendId && !(this.TabName != other.TabName) && !(this.PrefabPath != other.PrefabPath) && this.Sort == other.Sort && this.Show == other.Show && !(this.TabImage != other.TabImage) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060108E8 RID: 67816 RVA: 0x0026CA20 File Offset: 0x0026AC20
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

		// Token: 0x060108E9 RID: 67817 RVA: 0x0026CB14 File Offset: 0x0026AD14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060108EA RID: 67818 RVA: 0x0026CB21 File Offset: 0x0026AD21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060108EB RID: 67819 RVA: 0x0026CB2C File Offset: 0x0026AD2C
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

		// Token: 0x060108EC RID: 67820 RVA: 0x0026CC3C File Offset: 0x0026AE3C
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

		// Token: 0x060108ED RID: 67821 RVA: 0x0026CD28 File Offset: 0x0026AF28
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

		// Token: 0x060108EE RID: 67822 RVA: 0x0026CDFF File Offset: 0x0026AFFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060108EF RID: 67823 RVA: 0x0026CE08 File Offset: 0x0026B008
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

		// Token: 0x040069A6 RID: 27046
		private static readonly MessageParser<PayShopRecommendConfigInfo> _parser = new MessageParser<PayShopRecommendConfigInfo>(() => new PayShopRecommendConfigInfo());

		// Token: 0x040069A7 RID: 27047
		private UnknownFieldSet _unknownFields;

		// Token: 0x040069A8 RID: 27048
		public const int IdFieldNumber = 1;

		// Token: 0x040069A9 RID: 27049
		private int id_;

		// Token: 0x040069AA RID: 27050
		public const int RecommendTypeFieldNumber = 2;

		// Token: 0x040069AB RID: 27051
		private int recommendType_;

		// Token: 0x040069AC RID: 27052
		public const int RecommendIdFieldNumber = 3;

		// Token: 0x040069AD RID: 27053
		private int recommendId_;

		// Token: 0x040069AE RID: 27054
		public const int TabNameFieldNumber = 4;

		// Token: 0x040069AF RID: 27055
		private string tabName_ = "";

		// Token: 0x040069B0 RID: 27056
		public const int PrefabPathFieldNumber = 5;

		// Token: 0x040069B1 RID: 27057
		private string prefabPath_ = "";

		// Token: 0x040069B2 RID: 27058
		public const int SortFieldNumber = 6;

		// Token: 0x040069B3 RID: 27059
		private int sort_;

		// Token: 0x040069B4 RID: 27060
		public const int ShowFieldNumber = 7;

		// Token: 0x040069B5 RID: 27061
		private bool show_;

		// Token: 0x040069B6 RID: 27062
		public const int TabImageFieldNumber = 8;

		// Token: 0x040069B7 RID: 27063
		private string tabImage_ = "";
	}
}
