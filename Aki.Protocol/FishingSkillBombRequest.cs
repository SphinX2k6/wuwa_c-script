using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000571 RID: 1393
	[NetMessage(EMessageId.FishingSkillBombRequest)]
	public sealed class FishingSkillBombRequest : IMessage<FishingSkillBombRequest>, IMessage, IEquatable<FishingSkillBombRequest>, IDeepCloneable<FishingSkillBombRequest>, IBufferMessage
	{
		// Token: 0x060081D6 RID: 33238 RVA: 0x001398C1 File Offset: 0x00137AC1
		[NullableContext(1)]
		public static FishingSkillBombRequest Create()
		{
			return new FishingSkillBombRequest();
		}

		// Token: 0x17001947 RID: 6471
		// (get) Token: 0x060081D7 RID: 33239 RVA: 0x001398C8 File Offset: 0x00137AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001948 RID: 6472
		// (get) Token: 0x060081D8 RID: 33240 RVA: 0x001398CB File Offset: 0x00137ACB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingSkillBombRequest.Descriptor;
			}
		}

		// Token: 0x060081D9 RID: 33241 RVA: 0x001398D2 File Offset: 0x00137AD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSkillBombRequest()
		{
		}

		// Token: 0x060081DA RID: 33242 RVA: 0x001398DA File Offset: 0x00137ADA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSkillBombRequest(FishingSkillBombRequest other) : this()
		{
			this.itemId_ = other.itemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060081DB RID: 33243 RVA: 0x001398FF File Offset: 0x00137AFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSkillBombRequest Clone()
		{
			return new FishingSkillBombRequest(this);
		}

		// Token: 0x17001949 RID: 6473
		// (get) Token: 0x060081DC RID: 33244 RVA: 0x00139907 File Offset: 0x00137B07
		// (set) Token: 0x060081DD RID: 33245 RVA: 0x0013990F File Offset: 0x00137B0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x060081DE RID: 33246 RVA: 0x00139918 File Offset: 0x00137B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingSkillBombRequest);
		}

		// Token: 0x060081DF RID: 33247 RVA: 0x00139926 File Offset: 0x00137B26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingSkillBombRequest other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060081E0 RID: 33248 RVA: 0x00139954 File Offset: 0x00137B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060081E1 RID: 33249 RVA: 0x00139993 File Offset: 0x00137B93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060081E2 RID: 33250 RVA: 0x001399A0 File Offset: 0x00137BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060081E3 RID: 33251 RVA: 0x001399A9 File Offset: 0x00137BA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060081E4 RID: 33252 RVA: 0x001399DC File Offset: 0x00137BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060081E5 RID: 33253 RVA: 0x00139A1A File Offset: 0x00137C1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingSkillBombRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060081E6 RID: 33254 RVA: 0x00139A4B File Offset: 0x00137C4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060081E7 RID: 33255 RVA: 0x00139A54 File Offset: 0x00137C54
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004165 RID: 16741
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004166 RID: 16742
		public const int ItemIdFieldNumber = 5;

		// Token: 0x04004167 RID: 16743
		private int itemId_;
	}
}
