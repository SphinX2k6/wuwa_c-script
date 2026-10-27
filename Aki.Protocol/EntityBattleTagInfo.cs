using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200046E RID: 1134
	public sealed class EntityBattleTagInfo : IMessage<EntityBattleTagInfo>, IMessage, IEquatable<EntityBattleTagInfo>, IDeepCloneable<EntityBattleTagInfo>, IBufferMessage
	{
		// Token: 0x06006C30 RID: 27696 RVA: 0x001054E6 File Offset: 0x001036E6
		[NullableContext(1)]
		public static EntityBattleTagInfo Create()
		{
			return new EntityBattleTagInfo();
		}

		// Token: 0x1700148D RID: 5261
		// (get) Token: 0x06006C31 RID: 27697 RVA: 0x001054ED File Offset: 0x001036ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EntityBattleTagInfo> Parser
		{
			get
			{
				return EntityBattleTagInfo._parser;
			}
		}

		// Token: 0x1700148E RID: 5262
		// (get) Token: 0x06006C32 RID: 27698 RVA: 0x001054F4 File Offset: 0x001036F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700148F RID: 5263
		// (get) Token: 0x06006C33 RID: 27699 RVA: 0x001054F7 File Offset: 0x001036F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityBattleTagInfo.Descriptor;
			}
		}

		// Token: 0x06006C34 RID: 27700 RVA: 0x001054FE File Offset: 0x001036FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBattleTagInfo()
		{
		}

		// Token: 0x06006C35 RID: 27701 RVA: 0x00105506 File Offset: 0x00103706
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBattleTagInfo(EntityBattleTagInfo other) : this()
		{
			this.tagId_ = other.tagId_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006C36 RID: 27702 RVA: 0x00105537 File Offset: 0x00103737
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBattleTagInfo Clone()
		{
			return new EntityBattleTagInfo(this);
		}

		// Token: 0x17001490 RID: 5264
		// (get) Token: 0x06006C37 RID: 27703 RVA: 0x0010553F File Offset: 0x0010373F
		// (set) Token: 0x06006C38 RID: 27704 RVA: 0x00105547 File Offset: 0x00103747
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

		// Token: 0x17001491 RID: 5265
		// (get) Token: 0x06006C39 RID: 27705 RVA: 0x00105550 File Offset: 0x00103750
		// (set) Token: 0x06006C3A RID: 27706 RVA: 0x00105558 File Offset: 0x00103758
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

		// Token: 0x06006C3B RID: 27707 RVA: 0x00105561 File Offset: 0x00103761
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityBattleTagInfo);
		}

		// Token: 0x06006C3C RID: 27708 RVA: 0x0010556F File Offset: 0x0010376F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityBattleTagInfo other)
		{
			return other != null && (other == this || (this.TagId == other.TagId && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006C3D RID: 27709 RVA: 0x001055B0 File Offset: 0x001037B0
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

		// Token: 0x06006C3E RID: 27710 RVA: 0x00105608 File Offset: 0x00103808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006C3F RID: 27711 RVA: 0x00105615 File Offset: 0x00103815
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006C40 RID: 27712 RVA: 0x00105620 File Offset: 0x00103820
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

		// Token: 0x06006C41 RID: 27713 RVA: 0x00105678 File Offset: 0x00103878
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

		// Token: 0x06006C42 RID: 27714 RVA: 0x001056D0 File Offset: 0x001038D0
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

		// Token: 0x06006C43 RID: 27715 RVA: 0x00105720 File Offset: 0x00103920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006C44 RID: 27716 RVA: 0x0010572C File Offset: 0x0010392C
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

		// Token: 0x04003AE1 RID: 15073
		private static readonly MessageParser<EntityBattleTagInfo> _parser = new MessageParser<EntityBattleTagInfo>(() => new EntityBattleTagInfo());

		// Token: 0x04003AE2 RID: 15074
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003AE3 RID: 15075
		public const int TagIdFieldNumber = 1;

		// Token: 0x04003AE4 RID: 15076
		private int tagId_;

		// Token: 0x04003AE5 RID: 15077
		public const int CountFieldNumber = 2;

		// Token: 0x04003AE6 RID: 15078
		private int count_;
	}
}
