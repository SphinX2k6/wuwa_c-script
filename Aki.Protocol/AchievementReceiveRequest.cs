using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000066 RID: 102
	[NetMessage(EMessageId.AchievementReceiveRequest)]
	public sealed class AchievementReceiveRequest : IMessage<AchievementReceiveRequest>, IMessage, IEquatable<AchievementReceiveRequest>, IDeepCloneable<AchievementReceiveRequest>, IBufferMessage
	{
		// Token: 0x060016B8 RID: 5816 RVA: 0x0003B958 File Offset: 0x00039B58
		[NullableContext(1)]
		public static AchievementReceiveRequest Create()
		{
			return new AchievementReceiveRequest();
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060016B9 RID: 5817 RVA: 0x0003B95F File Offset: 0x00039B5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060016BA RID: 5818 RVA: 0x0003B962 File Offset: 0x00039B62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AchievementReceiveRequest.Descriptor;
			}
		}

		// Token: 0x060016BB RID: 5819 RVA: 0x0003B969 File Offset: 0x00039B69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementReceiveRequest()
		{
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x0003B971 File Offset: 0x00039B71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementReceiveRequest(AchievementReceiveRequest other) : this()
		{
			this.isGroupId_ = other.isGroupId_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060016BD RID: 5821 RVA: 0x0003B9A2 File Offset: 0x00039BA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementReceiveRequest Clone()
		{
			return new AchievementReceiveRequest(this);
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060016BE RID: 5822 RVA: 0x0003B9AA File Offset: 0x00039BAA
		// (set) Token: 0x060016BF RID: 5823 RVA: 0x0003B9B2 File Offset: 0x00039BB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsGroupId
		{
			get
			{
				return this.isGroupId_;
			}
			set
			{
				this.isGroupId_ = value;
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060016C0 RID: 5824 RVA: 0x0003B9BB File Offset: 0x00039BBB
		// (set) Token: 0x060016C1 RID: 5825 RVA: 0x0003B9C3 File Offset: 0x00039BC3
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

		// Token: 0x060016C2 RID: 5826 RVA: 0x0003B9CC File Offset: 0x00039BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AchievementReceiveRequest);
		}

		// Token: 0x060016C3 RID: 5827 RVA: 0x0003B9DA File Offset: 0x00039BDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AchievementReceiveRequest other)
		{
			return other != null && (other == this || (this.IsGroupId == other.IsGroupId && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x0003BA18 File Offset: 0x00039C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsGroupId)
			{
				num ^= this.IsGroupId.GetHashCode();
			}
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

		// Token: 0x060016C5 RID: 5829 RVA: 0x0003BA70 File Offset: 0x00039C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060016C6 RID: 5830 RVA: 0x0003BA7D File Offset: 0x00039C7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x0003BA88 File Offset: 0x00039C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Id);
			}
			if (this.IsGroupId)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.IsGroupId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x0003BAE4 File Offset: 0x00039CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsGroupId)
			{
				num += 2;
			}
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

		// Token: 0x060016C9 RID: 5833 RVA: 0x0003BB30 File Offset: 0x00039D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AchievementReceiveRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsGroupId)
			{
				this.IsGroupId = other.IsGroupId;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060016CA RID: 5834 RVA: 0x0003BB80 File Offset: 0x00039D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060016CB RID: 5835 RVA: 0x0003BB8C File Offset: 0x00039D8C
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
				if (num != 72U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsGroupId = input.ReadBool();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002140 RID: 8512
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002141 RID: 8513
		public const int IsGroupIdFieldNumber = 15;

		// Token: 0x04002142 RID: 8514
		private bool isGroupId_;

		// Token: 0x04002143 RID: 8515
		public const int IdFieldNumber = 9;

		// Token: 0x04002144 RID: 8516
		private int id_;
	}
}
