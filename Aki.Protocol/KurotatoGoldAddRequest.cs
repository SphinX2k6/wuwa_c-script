using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000886 RID: 2182
	[NetMessage(EMessageId.KurotatoGoldAddRequest)]
	public sealed class KurotatoGoldAddRequest : IMessage<KurotatoGoldAddRequest>, IMessage, IEquatable<KurotatoGoldAddRequest>, IDeepCloneable<KurotatoGoldAddRequest>, IBufferMessage
	{
		// Token: 0x0600C24F RID: 49743 RVA: 0x001CD4F6 File Offset: 0x001CB6F6
		[NullableContext(1)]
		public static KurotatoGoldAddRequest Create()
		{
			return new KurotatoGoldAddRequest();
		}

		// Token: 0x1700273D RID: 10045
		// (get) Token: 0x0600C250 RID: 49744 RVA: 0x001CD4FD File Offset: 0x001CB6FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700273E RID: 10046
		// (get) Token: 0x0600C251 RID: 49745 RVA: 0x001CD500 File Offset: 0x001CB700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoGoldAddRequest.Descriptor;
			}
		}

		// Token: 0x0600C252 RID: 49746 RVA: 0x001CD507 File Offset: 0x001CB707
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoGoldAddRequest()
		{
		}

		// Token: 0x0600C253 RID: 49747 RVA: 0x001CD50F File Offset: 0x001CB70F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoGoldAddRequest(KurotatoGoldAddRequest other) : this()
		{
			this.goldCount_ = other.goldCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C254 RID: 49748 RVA: 0x001CD534 File Offset: 0x001CB734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoGoldAddRequest Clone()
		{
			return new KurotatoGoldAddRequest(this);
		}

		// Token: 0x1700273F RID: 10047
		// (get) Token: 0x0600C255 RID: 49749 RVA: 0x001CD53C File Offset: 0x001CB73C
		// (set) Token: 0x0600C256 RID: 49750 RVA: 0x001CD544 File Offset: 0x001CB744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GoldCount
		{
			get
			{
				return this.goldCount_;
			}
			set
			{
				this.goldCount_ = value;
			}
		}

		// Token: 0x0600C257 RID: 49751 RVA: 0x001CD54D File Offset: 0x001CB74D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoGoldAddRequest);
		}

		// Token: 0x0600C258 RID: 49752 RVA: 0x001CD55B File Offset: 0x001CB75B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoGoldAddRequest other)
		{
			return other != null && (other == this || (this.GoldCount == other.GoldCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C259 RID: 49753 RVA: 0x001CD58C File Offset: 0x001CB78C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GoldCount != 0)
			{
				num ^= this.GoldCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C25A RID: 49754 RVA: 0x001CD5CB File Offset: 0x001CB7CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C25B RID: 49755 RVA: 0x001CD5D8 File Offset: 0x001CB7D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C25C RID: 49756 RVA: 0x001CD5E1 File Offset: 0x001CB7E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GoldCount != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.GoldCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C25D RID: 49757 RVA: 0x001CD614 File Offset: 0x001CB814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GoldCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GoldCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C25E RID: 49758 RVA: 0x001CD652 File Offset: 0x001CB852
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoGoldAddRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GoldCount != 0)
			{
				this.GoldCount = other.GoldCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C25F RID: 49759 RVA: 0x001CD683 File Offset: 0x001CB883
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C260 RID: 49760 RVA: 0x001CD68C File Offset: 0x001CB88C
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.GoldCount = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400546E RID: 21614
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400546F RID: 21615
		public const int GoldCountFieldNumber = 11;

		// Token: 0x04005470 RID: 21616
		private int goldCount_;
	}
}
