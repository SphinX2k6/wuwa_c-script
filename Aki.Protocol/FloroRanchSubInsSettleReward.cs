using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005D5 RID: 1493
	public sealed class FloroRanchSubInsSettleReward : IMessage<FloroRanchSubInsSettleReward>, IMessage, IEquatable<FloroRanchSubInsSettleReward>, IDeepCloneable<FloroRanchSubInsSettleReward>, IBufferMessage
	{
		// Token: 0x06008AB0 RID: 35504 RVA: 0x0015036E File Offset: 0x0014E56E
		[NullableContext(1)]
		public static FloroRanchSubInsSettleReward Create()
		{
			return new FloroRanchSubInsSettleReward();
		}

		// Token: 0x17001B66 RID: 7014
		// (get) Token: 0x06008AB1 RID: 35505 RVA: 0x00150375 File Offset: 0x0014E575
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FloroRanchSubInsSettleReward> Parser
		{
			get
			{
				return FloroRanchSubInsSettleReward._parser;
			}
		}

		// Token: 0x17001B67 RID: 7015
		// (get) Token: 0x06008AB2 RID: 35506 RVA: 0x0015037C File Offset: 0x0014E57C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B68 RID: 7016
		// (get) Token: 0x06008AB3 RID: 35507 RVA: 0x0015037F File Offset: 0x0014E57F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchSubInsSettleReward.Descriptor;
			}
		}

		// Token: 0x06008AB4 RID: 35508 RVA: 0x00150386 File Offset: 0x0014E586
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchSubInsSettleReward()
		{
		}

		// Token: 0x06008AB5 RID: 35509 RVA: 0x0015038E File Offset: 0x0014E58E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchSubInsSettleReward(FloroRanchSubInsSettleReward other) : this()
		{
			this.type_ = other.type_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008AB6 RID: 35510 RVA: 0x001503BF File Offset: 0x0014E5BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchSubInsSettleReward Clone()
		{
			return new FloroRanchSubInsSettleReward(this);
		}

		// Token: 0x17001B69 RID: 7017
		// (get) Token: 0x06008AB7 RID: 35511 RVA: 0x001503C7 File Offset: 0x0014E5C7
		// (set) Token: 0x06008AB8 RID: 35512 RVA: 0x001503CF File Offset: 0x0014E5CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubInsSettleRewardType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17001B6A RID: 7018
		// (get) Token: 0x06008AB9 RID: 35513 RVA: 0x001503D8 File Offset: 0x0014E5D8
		// (set) Token: 0x06008ABA RID: 35514 RVA: 0x001503E0 File Offset: 0x0014E5E0
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

		// Token: 0x06008ABB RID: 35515 RVA: 0x001503E9 File Offset: 0x0014E5E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchSubInsSettleReward);
		}

		// Token: 0x06008ABC RID: 35516 RVA: 0x001503F7 File Offset: 0x0014E5F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchSubInsSettleReward other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008ABD RID: 35517 RVA: 0x00150438 File Offset: 0x0014E638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != SubInsSettleRewardType.FloroRanchSkill)
			{
				num ^= this.Type.GetHashCode();
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

		// Token: 0x06008ABE RID: 35518 RVA: 0x00150496 File Offset: 0x0014E696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008ABF RID: 35519 RVA: 0x001504A3 File Offset: 0x0014E6A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008AC0 RID: 35520 RVA: 0x001504AC File Offset: 0x0014E6AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != SubInsSettleRewardType.FloroRanchSkill)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Type);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008AC1 RID: 35521 RVA: 0x00150504 File Offset: 0x0014E704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != SubInsSettleRewardType.FloroRanchSkill)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
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

		// Token: 0x06008AC2 RID: 35522 RVA: 0x0015055C File Offset: 0x0014E75C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchSubInsSettleReward other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != SubInsSettleRewardType.FloroRanchSkill)
			{
				this.Type = other.Type;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008AC3 RID: 35523 RVA: 0x001505AC File Offset: 0x0014E7AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008AC4 RID: 35524 RVA: 0x001505B8 File Offset: 0x0014E7B8
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadInt32();
					}
				}
				else
				{
					this.Type = (SubInsSettleRewardType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004497 RID: 17559
		private static readonly MessageParser<FloroRanchSubInsSettleReward> _parser = new MessageParser<FloroRanchSubInsSettleReward>(() => new FloroRanchSubInsSettleReward());

		// Token: 0x04004498 RID: 17560
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004499 RID: 17561
		public const int TypeFieldNumber = 1;

		// Token: 0x0400449A RID: 17562
		private SubInsSettleRewardType type_;

		// Token: 0x0400449B RID: 17563
		public const int IdFieldNumber = 2;

		// Token: 0x0400449C RID: 17564
		private int id_;
	}
}
