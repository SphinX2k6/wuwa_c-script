using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000457 RID: 1111
	public sealed class EntityBattleTagInfo : IMessage<EntityBattleTagInfo>, IMessage, IEquatable<EntityBattleTagInfo>, IDeepCloneable<EntityBattleTagInfo>, IBufferMessage
	{
		// Token: 0x06006AA2 RID: 27298 RVA: 0x00102472 File Offset: 0x00100672
		[NullableContext(1)]
		public static EntityBattleTagInfo Create()
		{
			return new EntityBattleTagInfo();
		}

		// Token: 0x17001439 RID: 5177
		// (get) Token: 0x06006AA3 RID: 27299 RVA: 0x00102479 File Offset: 0x00100679
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EntityBattleTagInfo> Parser
		{
			get
			{
				return EntityBattleTagInfo._parser;
			}
		}

		// Token: 0x1700143A RID: 5178
		// (get) Token: 0x06006AA4 RID: 27300 RVA: 0x00102480 File Offset: 0x00100680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700143B RID: 5179
		// (get) Token: 0x06006AA5 RID: 27301 RVA: 0x00102483 File Offset: 0x00100683
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityBattleTagInfo.Descriptor;
			}
		}

		// Token: 0x06006AA6 RID: 27302 RVA: 0x0010248A File Offset: 0x0010068A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBattleTagInfo()
		{
		}

		// Token: 0x06006AA7 RID: 27303 RVA: 0x00102492 File Offset: 0x00100692
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBattleTagInfo(EntityBattleTagInfo other) : this()
		{
			this.tagId_ = other.tagId_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006AA8 RID: 27304 RVA: 0x001024C3 File Offset: 0x001006C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBattleTagInfo Clone()
		{
			return new EntityBattleTagInfo(this);
		}

		// Token: 0x1700143C RID: 5180
		// (get) Token: 0x06006AA9 RID: 27305 RVA: 0x001024CB File Offset: 0x001006CB
		// (set) Token: 0x06006AAA RID: 27306 RVA: 0x001024D3 File Offset: 0x001006D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TagId
		{
			get
			{
				return this.tagId_;
			}
			set
			{
				this.tagId_ = value;
			}
		}

		// Token: 0x1700143D RID: 5181
		// (get) Token: 0x06006AAB RID: 27307 RVA: 0x001024DC File Offset: 0x001006DC
		// (set) Token: 0x06006AAC RID: 27308 RVA: 0x001024E4 File Offset: 0x001006E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x06006AAD RID: 27309 RVA: 0x001024ED File Offset: 0x001006ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityBattleTagInfo);
		}

		// Token: 0x06006AAE RID: 27310 RVA: 0x001024FB File Offset: 0x001006FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityBattleTagInfo other)
		{
			return other != null && (other == this || (this.TagId == other.TagId && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006AAF RID: 27311 RVA: 0x0010253C File Offset: 0x0010073C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TagId != 0)
			{
				num ^= this.TagId.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006AB0 RID: 27312 RVA: 0x00102594 File Offset: 0x00100794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006AB1 RID: 27313 RVA: 0x001025A1 File Offset: 0x001007A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006AB2 RID: 27314 RVA: 0x001025AC File Offset: 0x001007AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TagId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TagId);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Count);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006AB3 RID: 27315 RVA: 0x00102604 File Offset: 0x00100804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TagId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TagId);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006AB4 RID: 27316 RVA: 0x0010265C File Offset: 0x0010085C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityBattleTagInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TagId != 0)
			{
				this.TagId = other.TagId;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006AB5 RID: 27317 RVA: 0x001026AC File Offset: 0x001008AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006AB6 RID: 27318 RVA: 0x001026B8 File Offset: 0x001008B8
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
						this.Count = input.ReadInt32();
					}
				}
				else
				{
					this.TagId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003ACF RID: 15055
		private static readonly MessageParser<EntityBattleTagInfo> _parser = new MessageParser<EntityBattleTagInfo>(() => new EntityBattleTagInfo());

		// Token: 0x04003AD0 RID: 15056
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003AD1 RID: 15057
		public const int TagIdFieldNumber = 1;

		// Token: 0x04003AD2 RID: 15058
		private int tagId_;

		// Token: 0x04003AD3 RID: 15059
		public const int CountFieldNumber = 2;

		// Token: 0x04003AD4 RID: 15060
		private int count_;
	}
}
