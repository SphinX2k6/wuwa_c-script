using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200060E RID: 1550
	public sealed class FlySkinInfo : IMessage<FlySkinInfo>, IMessage, IEquatable<FlySkinInfo>, IDeepCloneable<FlySkinInfo>, IBufferMessage
	{
		// Token: 0x06008F40 RID: 36672 RVA: 0x0015B19C File Offset: 0x0015939C
		[NullableContext(1)]
		public static FlySkinInfo Create()
		{
			return new FlySkinInfo();
		}

		// Token: 0x17001C70 RID: 7280
		// (get) Token: 0x06008F41 RID: 36673 RVA: 0x0015B1A3 File Offset: 0x001593A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FlySkinInfo> Parser
		{
			get
			{
				return FlySkinInfo._parser;
			}
		}

		// Token: 0x17001C71 RID: 7281
		// (get) Token: 0x06008F42 RID: 36674 RVA: 0x0015B1AA File Offset: 0x001593AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C72 RID: 7282
		// (get) Token: 0x06008F43 RID: 36675 RVA: 0x0015B1AD File Offset: 0x001593AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlySkinInfo.Descriptor;
			}
		}

		// Token: 0x06008F44 RID: 36676 RVA: 0x0015B1B4 File Offset: 0x001593B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinInfo()
		{
		}

		// Token: 0x06008F45 RID: 36677 RVA: 0x0015B1BC File Offset: 0x001593BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinInfo(FlySkinInfo other) : this()
		{
			this.skinId_ = other.skinId_;
			this.skinType_ = other.skinType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008F46 RID: 36678 RVA: 0x0015B1ED File Offset: 0x001593ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinInfo Clone()
		{
			return new FlySkinInfo(this);
		}

		// Token: 0x17001C73 RID: 7283
		// (get) Token: 0x06008F47 RID: 36679 RVA: 0x0015B1F5 File Offset: 0x001593F5
		// (set) Token: 0x06008F48 RID: 36680 RVA: 0x0015B1FD File Offset: 0x001593FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkinId
		{
			get
			{
				return this.skinId_;
			}
			set
			{
				this.skinId_ = value;
			}
		}

		// Token: 0x17001C74 RID: 7284
		// (get) Token: 0x06008F49 RID: 36681 RVA: 0x0015B206 File Offset: 0x00159406
		// (set) Token: 0x06008F4A RID: 36682 RVA: 0x0015B20E File Offset: 0x0015940E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkinType
		{
			get
			{
				return this.skinType_;
			}
			set
			{
				this.skinType_ = value;
			}
		}

		// Token: 0x06008F4B RID: 36683 RVA: 0x0015B217 File Offset: 0x00159417
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlySkinInfo);
		}

		// Token: 0x06008F4C RID: 36684 RVA: 0x0015B225 File Offset: 0x00159425
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlySkinInfo other)
		{
			return other != null && (other == this || (this.SkinId == other.SkinId && this.SkinType == other.SkinType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008F4D RID: 36685 RVA: 0x0015B264 File Offset: 0x00159464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkinId != 0)
			{
				num ^= this.SkinId.GetHashCode();
			}
			if (this.SkinType != 0)
			{
				num ^= this.SkinType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008F4E RID: 36686 RVA: 0x0015B2BC File Offset: 0x001594BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008F4F RID: 36687 RVA: 0x0015B2C9 File Offset: 0x001594C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008F50 RID: 36688 RVA: 0x0015B2D4 File Offset: 0x001594D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkinId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SkinId);
			}
			if (this.SkinType != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SkinType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008F51 RID: 36689 RVA: 0x0015B32C File Offset: 0x0015952C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkinId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkinId);
			}
			if (this.SkinType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkinType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008F52 RID: 36690 RVA: 0x0015B384 File Offset: 0x00159584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlySkinInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkinId != 0)
			{
				this.SkinId = other.SkinId;
			}
			if (other.SkinType != 0)
			{
				this.SkinType = other.SkinType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008F53 RID: 36691 RVA: 0x0015B3D4 File Offset: 0x001595D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008F54 RID: 36692 RVA: 0x0015B3E0 File Offset: 0x001595E0
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
						this.SkinType = input.ReadInt32();
					}
				}
				else
				{
					this.SkinId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004599 RID: 17817
		private static readonly MessageParser<FlySkinInfo> _parser = new MessageParser<FlySkinInfo>(() => new FlySkinInfo());

		// Token: 0x0400459A RID: 17818
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400459B RID: 17819
		public const int SkinIdFieldNumber = 1;

		// Token: 0x0400459C RID: 17820
		private int skinId_;

		// Token: 0x0400459D RID: 17821
		public const int SkinTypeFieldNumber = 2;

		// Token: 0x0400459E RID: 17822
		private int skinType_;
	}
}
