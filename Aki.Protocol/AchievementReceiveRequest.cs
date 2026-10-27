using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000065 RID: 101
	[NetMessage(EMessageId.AchievementReceiveRequest)]
	public sealed class AchievementReceiveRequest : IMessage<AchievementReceiveRequest>, IMessage, IEquatable<AchievementReceiveRequest>, IDeepCloneable<AchievementReceiveRequest>, IBufferMessage
	{
		// Token: 0x06001675 RID: 5749 RVA: 0x0003AFB4 File Offset: 0x000391B4
		[NullableContext(1)]
		public static AchievementReceiveRequest Create()
		{
			return new AchievementReceiveRequest();
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06001676 RID: 5750 RVA: 0x0003AFBB File Offset: 0x000391BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06001677 RID: 5751 RVA: 0x0003AFBE File Offset: 0x000391BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AchievementReceiveRequest.Descriptor;
			}
		}

		// Token: 0x06001678 RID: 5752 RVA: 0x0003AFC5 File Offset: 0x000391C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementReceiveRequest()
		{
		}

		// Token: 0x06001679 RID: 5753 RVA: 0x0003AFCD File Offset: 0x000391CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementReceiveRequest(AchievementReceiveRequest other) : this()
		{
			this.isGroupId_ = other.isGroupId_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600167A RID: 5754 RVA: 0x0003AFFE File Offset: 0x000391FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementReceiveRequest Clone()
		{
			return new AchievementReceiveRequest(this);
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x0600167B RID: 5755 RVA: 0x0003B006 File Offset: 0x00039206
		// (set) Token: 0x0600167C RID: 5756 RVA: 0x0003B00E File Offset: 0x0003920E
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

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x0600167D RID: 5757 RVA: 0x0003B017 File Offset: 0x00039217
		// (set) Token: 0x0600167E RID: 5758 RVA: 0x0003B01F File Offset: 0x0003921F
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

		// Token: 0x0600167F RID: 5759 RVA: 0x0003B028 File Offset: 0x00039228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AchievementReceiveRequest);
		}

		// Token: 0x06001680 RID: 5760 RVA: 0x0003B036 File Offset: 0x00039236
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AchievementReceiveRequest other)
		{
			return other != null && (other == this || (this.IsGroupId == other.IsGroupId && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001681 RID: 5761 RVA: 0x0003B074 File Offset: 0x00039274
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

		// Token: 0x06001682 RID: 5762 RVA: 0x0003B0CC File Offset: 0x000392CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x0003B0D9 File Offset: 0x000392D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001684 RID: 5764 RVA: 0x0003B0E4 File Offset: 0x000392E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Id);
			}
			if (this.IsGroupId)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.IsGroupId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x0003B140 File Offset: 0x00039340
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

		// Token: 0x06001686 RID: 5766 RVA: 0x0003B18C File Offset: 0x0003938C
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

		// Token: 0x06001687 RID: 5767 RVA: 0x0003B1DC File Offset: 0x000393DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001688 RID: 5768 RVA: 0x0003B1E8 File Offset: 0x000393E8
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
				if (num != 32U)
				{
					if (num != 72U)
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

		// Token: 0x040020E1 RID: 8417
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020E2 RID: 8418
		public const int IsGroupIdFieldNumber = 9;

		// Token: 0x040020E3 RID: 8419
		private bool isGroupId_;

		// Token: 0x040020E4 RID: 8420
		public const int IdFieldNumber = 4;

		// Token: 0x040020E5 RID: 8421
		private int id_;
	}
}
