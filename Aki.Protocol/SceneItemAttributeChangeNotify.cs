using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001199 RID: 4505
	[NetMessage(EMessageId.SceneItemAttributeChangeNotify)]
	public sealed class SceneItemAttributeChangeNotify : IMessage<SceneItemAttributeChangeNotify>, IMessage, IEquatable<SceneItemAttributeChangeNotify>, IDeepCloneable<SceneItemAttributeChangeNotify>, IBufferMessage
	{
		// Token: 0x060180F2 RID: 98546 RVA: 0x00380AC8 File Offset: 0x0037ECC8
		[NullableContext(1)]
		public static SceneItemAttributeChangeNotify Create()
		{
			return new SceneItemAttributeChangeNotify();
		}

		// Token: 0x17005109 RID: 20745
		// (get) Token: 0x060180F3 RID: 98547 RVA: 0x00380ACF File Offset: 0x0037ECCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700510A RID: 20746
		// (get) Token: 0x060180F4 RID: 98548 RVA: 0x00380AD2 File Offset: 0x0037ECD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemAttributeChangeNotify.Descriptor;
			}
		}

		// Token: 0x060180F5 RID: 98549 RVA: 0x00380AD9 File Offset: 0x0037ECD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAttributeChangeNotify()
		{
		}

		// Token: 0x060180F6 RID: 98550 RVA: 0x00380AE1 File Offset: 0x0037ECE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAttributeChangeNotify(SceneItemAttributeChangeNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.attributeId_ = other.attributeId_;
			this.isAdd_ = other.isAdd_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060180F7 RID: 98551 RVA: 0x00380B1E File Offset: 0x0037ED1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAttributeChangeNotify Clone()
		{
			return new SceneItemAttributeChangeNotify(this);
		}

		// Token: 0x1700510B RID: 20747
		// (get) Token: 0x060180F8 RID: 98552 RVA: 0x00380B26 File Offset: 0x0037ED26
		// (set) Token: 0x060180F9 RID: 98553 RVA: 0x00380B2E File Offset: 0x0037ED2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x1700510C RID: 20748
		// (get) Token: 0x060180FA RID: 98554 RVA: 0x00380B37 File Offset: 0x0037ED37
		// (set) Token: 0x060180FB RID: 98555 RVA: 0x00380B3F File Offset: 0x0037ED3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AttributeId
		{
			get
			{
				return this.attributeId_;
			}
			set
			{
				this.attributeId_ = value;
			}
		}

		// Token: 0x1700510D RID: 20749
		// (get) Token: 0x060180FC RID: 98556 RVA: 0x00380B48 File Offset: 0x0037ED48
		// (set) Token: 0x060180FD RID: 98557 RVA: 0x00380B50 File Offset: 0x0037ED50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsAdd
		{
			get
			{
				return this.isAdd_;
			}
			set
			{
				this.isAdd_ = value;
			}
		}

		// Token: 0x060180FE RID: 98558 RVA: 0x00380B59 File Offset: 0x0037ED59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemAttributeChangeNotify);
		}

		// Token: 0x060180FF RID: 98559 RVA: 0x00380B68 File Offset: 0x0037ED68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemAttributeChangeNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.AttributeId == other.AttributeId && this.IsAdd == other.IsAdd && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018100 RID: 98560 RVA: 0x00380BC4 File Offset: 0x0037EDC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.AttributeId != 0)
			{
				num ^= this.AttributeId.GetHashCode();
			}
			if (this.IsAdd)
			{
				num ^= this.IsAdd.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018101 RID: 98561 RVA: 0x00380C35 File Offset: 0x0037EE35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018102 RID: 98562 RVA: 0x00380C42 File Offset: 0x0037EE42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018103 RID: 98563 RVA: 0x00380C4C File Offset: 0x0037EE4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.EntityId);
			}
			if (this.IsAdd)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsAdd);
			}
			if (this.AttributeId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.AttributeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018104 RID: 98564 RVA: 0x00380CC4 File Offset: 0x0037EEC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.AttributeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AttributeId);
			}
			if (this.IsAdd)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018105 RID: 98565 RVA: 0x00380D28 File Offset: 0x0037EF28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemAttributeChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.AttributeId != 0)
			{
				this.AttributeId = other.AttributeId;
			}
			if (other.IsAdd)
			{
				this.IsAdd = other.IsAdd;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018106 RID: 98566 RVA: 0x00380D8C File Offset: 0x0037EF8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018107 RID: 98567 RVA: 0x00380D98 File Offset: 0x0037EF98
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
					if (num != 48U)
					{
						if (num != 72U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.AttributeId = input.ReadInt32();
						}
					}
					else
					{
						this.IsAdd = input.ReadBool();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04008F57 RID: 36695
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008F58 RID: 36696
		public const int EntityIdFieldNumber = 4;

		// Token: 0x04008F59 RID: 36697
		private long entityId_;

		// Token: 0x04008F5A RID: 36698
		public const int AttributeIdFieldNumber = 9;

		// Token: 0x04008F5B RID: 36699
		private int attributeId_;

		// Token: 0x04008F5C RID: 36700
		public const int IsAddFieldNumber = 6;

		// Token: 0x04008F5D RID: 36701
		private bool isAdd_;
	}
}
