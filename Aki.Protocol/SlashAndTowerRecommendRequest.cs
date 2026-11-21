using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001289 RID: 4745
	[NetMessage(EMessageId.SlashAndTowerRecommendRequest)]
	public sealed class SlashAndTowerRecommendRequest : IMessage<SlashAndTowerRecommendRequest>, IMessage, IEquatable<SlashAndTowerRecommendRequest>, IDeepCloneable<SlashAndTowerRecommendRequest>, IBufferMessage
	{
		// Token: 0x0601953F RID: 103743 RVA: 0x003B1AB6 File Offset: 0x003AFCB6
		[NullableContext(1)]
		public static SlashAndTowerRecommendRequest Create()
		{
			return new SlashAndTowerRecommendRequest();
		}

		// Token: 0x170055AA RID: 21930
		// (get) Token: 0x06019540 RID: 103744 RVA: 0x003B1ABD File Offset: 0x003AFCBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170055AB RID: 21931
		// (get) Token: 0x06019541 RID: 103745 RVA: 0x003B1AC0 File Offset: 0x003AFCC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SlashAndTowerRecommendRequest.Descriptor;
			}
		}

		// Token: 0x06019542 RID: 103746 RVA: 0x003B1AC7 File Offset: 0x003AFCC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerRecommendRequest()
		{
		}

		// Token: 0x06019543 RID: 103747 RVA: 0x003B1ACF File Offset: 0x003AFCCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerRecommendRequest(SlashAndTowerRecommendRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019544 RID: 103748 RVA: 0x003B1AF4 File Offset: 0x003AFCF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerRecommendRequest Clone()
		{
			return new SlashAndTowerRecommendRequest(this);
		}

		// Token: 0x170055AC RID: 21932
		// (get) Token: 0x06019545 RID: 103749 RVA: 0x003B1AFC File Offset: 0x003AFCFC
		// (set) Token: 0x06019546 RID: 103750 RVA: 0x003B1B04 File Offset: 0x003AFD04
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

		// Token: 0x06019547 RID: 103751 RVA: 0x003B1B0D File Offset: 0x003AFD0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SlashAndTowerRecommendRequest);
		}

		// Token: 0x06019548 RID: 103752 RVA: 0x003B1B1B File Offset: 0x003AFD1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SlashAndTowerRecommendRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019549 RID: 103753 RVA: 0x003B1B4C File Offset: 0x003AFD4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601954A RID: 103754 RVA: 0x003B1B8B File Offset: 0x003AFD8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601954B RID: 103755 RVA: 0x003B1B98 File Offset: 0x003AFD98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601954C RID: 103756 RVA: 0x003B1BA1 File Offset: 0x003AFDA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601954D RID: 103757 RVA: 0x003B1BD4 File Offset: 0x003AFDD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601954E RID: 103758 RVA: 0x003B1C12 File Offset: 0x003AFE12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SlashAndTowerRecommendRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601954F RID: 103759 RVA: 0x003B1C43 File Offset: 0x003AFE43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019550 RID: 103760 RVA: 0x003B1C4C File Offset: 0x003AFE4C
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040095D7 RID: 38359
		private UnknownFieldSet _unknownFields;

		// Token: 0x040095D8 RID: 38360
		public const int IdFieldNumber = 13;

		// Token: 0x040095D9 RID: 38361
		private int id_;
	}
}
