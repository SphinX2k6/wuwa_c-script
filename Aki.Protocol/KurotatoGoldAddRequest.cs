using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000897 RID: 2199
	[NetMessage(EMessageId.KurotatoGoldAddRequest)]
	public sealed class KurotatoGoldAddRequest : IMessage<KurotatoGoldAddRequest>, IMessage, IEquatable<KurotatoGoldAddRequest>, IDeepCloneable<KurotatoGoldAddRequest>, IBufferMessage
	{
		// Token: 0x0600C36B RID: 50027 RVA: 0x001CF7DE File Offset: 0x001CD9DE
		[NullableContext(1)]
		public static KurotatoGoldAddRequest Create()
		{
			return new KurotatoGoldAddRequest();
		}

		// Token: 0x1700277C RID: 10108
		// (get) Token: 0x0600C36C RID: 50028 RVA: 0x001CF7E5 File Offset: 0x001CD9E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700277D RID: 10109
		// (get) Token: 0x0600C36D RID: 50029 RVA: 0x001CF7E8 File Offset: 0x001CD9E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoGoldAddRequest.Descriptor;
			}
		}

		// Token: 0x0600C36E RID: 50030 RVA: 0x001CF7EF File Offset: 0x001CD9EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoGoldAddRequest()
		{
		}

		// Token: 0x0600C36F RID: 50031 RVA: 0x001CF7F7 File Offset: 0x001CD9F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoGoldAddRequest(KurotatoGoldAddRequest other) : this()
		{
			this.goldCount_ = other.goldCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C370 RID: 50032 RVA: 0x001CF81C File Offset: 0x001CDA1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoGoldAddRequest Clone()
		{
			return new KurotatoGoldAddRequest(this);
		}

		// Token: 0x1700277E RID: 10110
		// (get) Token: 0x0600C371 RID: 50033 RVA: 0x001CF824 File Offset: 0x001CDA24
		// (set) Token: 0x0600C372 RID: 50034 RVA: 0x001CF82C File Offset: 0x001CDA2C
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

		// Token: 0x0600C373 RID: 50035 RVA: 0x001CF835 File Offset: 0x001CDA35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoGoldAddRequest);
		}

		// Token: 0x0600C374 RID: 50036 RVA: 0x001CF843 File Offset: 0x001CDA43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoGoldAddRequest other)
		{
			return other != null && (other == this || (this.GoldCount == other.GoldCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C375 RID: 50037 RVA: 0x001CF874 File Offset: 0x001CDA74
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

		// Token: 0x0600C376 RID: 50038 RVA: 0x001CF8B3 File Offset: 0x001CDAB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C377 RID: 50039 RVA: 0x001CF8C0 File Offset: 0x001CDAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C378 RID: 50040 RVA: 0x001CF8C9 File Offset: 0x001CDAC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GoldCount != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.GoldCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C379 RID: 50041 RVA: 0x001CF8FC File Offset: 0x001CDAFC
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

		// Token: 0x0600C37A RID: 50042 RVA: 0x001CF93A File Offset: 0x001CDB3A
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

		// Token: 0x0600C37B RID: 50043 RVA: 0x001CF96B File Offset: 0x001CDB6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C37C RID: 50044 RVA: 0x001CF974 File Offset: 0x001CDB74
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.GoldCount = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005467 RID: 21607
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005468 RID: 21608
		public const int GoldCountFieldNumber = 14;

		// Token: 0x04005469 RID: 21609
		private int goldCount_;
	}
}
