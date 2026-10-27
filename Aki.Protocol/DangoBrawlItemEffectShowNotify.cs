using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200035E RID: 862
	[NetMessage(EMessageId.DangoBrawlItemEffectShowNotify)]
	public sealed class DangoBrawlItemEffectShowNotify : IMessage<DangoBrawlItemEffectShowNotify>, IMessage, IEquatable<DangoBrawlItemEffectShowNotify>, IDeepCloneable<DangoBrawlItemEffectShowNotify>, IBufferMessage
	{
		// Token: 0x0600560E RID: 22030 RVA: 0x000D2666 File Offset: 0x000D0866
		[NullableContext(1)]
		public static DangoBrawlItemEffectShowNotify Create()
		{
			return new DangoBrawlItemEffectShowNotify();
		}

		// Token: 0x17000FC8 RID: 4040
		// (get) Token: 0x0600560F RID: 22031 RVA: 0x000D266D File Offset: 0x000D086D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000FC9 RID: 4041
		// (get) Token: 0x06005610 RID: 22032 RVA: 0x000D2670 File Offset: 0x000D0870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlItemEffectShowNotify.Descriptor;
			}
		}

		// Token: 0x06005611 RID: 22033 RVA: 0x000D2677 File Offset: 0x000D0877
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlItemEffectShowNotify()
		{
		}

		// Token: 0x06005612 RID: 22034 RVA: 0x000D267F File Offset: 0x000D087F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlItemEffectShowNotify(DangoBrawlItemEffectShowNotify other) : this()
		{
			this.itemUId_ = other.itemUId_;
			this.effectId_ = other.effectId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005613 RID: 22035 RVA: 0x000D26B0 File Offset: 0x000D08B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlItemEffectShowNotify Clone()
		{
			return new DangoBrawlItemEffectShowNotify(this);
		}

		// Token: 0x17000FCA RID: 4042
		// (get) Token: 0x06005614 RID: 22036 RVA: 0x000D26B8 File Offset: 0x000D08B8
		// (set) Token: 0x06005615 RID: 22037 RVA: 0x000D26C0 File Offset: 0x000D08C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemUId
		{
			get
			{
				return this.itemUId_;
			}
			set
			{
				this.itemUId_ = value;
			}
		}

		// Token: 0x17000FCB RID: 4043
		// (get) Token: 0x06005616 RID: 22038 RVA: 0x000D26C9 File Offset: 0x000D08C9
		// (set) Token: 0x06005617 RID: 22039 RVA: 0x000D26D1 File Offset: 0x000D08D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EffectId
		{
			get
			{
				return this.effectId_;
			}
			set
			{
				this.effectId_ = value;
			}
		}

		// Token: 0x06005618 RID: 22040 RVA: 0x000D26DA File Offset: 0x000D08DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlItemEffectShowNotify);
		}

		// Token: 0x06005619 RID: 22041 RVA: 0x000D26E8 File Offset: 0x000D08E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlItemEffectShowNotify other)
		{
			return other != null && (other == this || (this.ItemUId == other.ItemUId && this.EffectId == other.EffectId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600561A RID: 22042 RVA: 0x000D2728 File Offset: 0x000D0928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemUId != 0)
			{
				num ^= this.ItemUId.GetHashCode();
			}
			if (this.EffectId != 0)
			{
				num ^= this.EffectId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600561B RID: 22043 RVA: 0x000D2780 File Offset: 0x000D0980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600561C RID: 22044 RVA: 0x000D278D File Offset: 0x000D098D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600561D RID: 22045 RVA: 0x000D2798 File Offset: 0x000D0998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EffectId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.EffectId);
			}
			if (this.ItemUId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ItemUId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600561E RID: 22046 RVA: 0x000D27F4 File Offset: 0x000D09F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemUId);
			}
			if (this.EffectId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EffectId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600561F RID: 22047 RVA: 0x000D284C File Offset: 0x000D0A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlItemEffectShowNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemUId != 0)
			{
				this.ItemUId = other.ItemUId;
			}
			if (other.EffectId != 0)
			{
				this.EffectId = other.EffectId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005620 RID: 22048 RVA: 0x000D289C File Offset: 0x000D0A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005621 RID: 22049 RVA: 0x000D28A8 File Offset: 0x000D0AA8
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
				if (num != 16U)
				{
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ItemUId = input.ReadInt32();
					}
				}
				else
				{
					this.EffectId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003462 RID: 13410
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003463 RID: 13411
		public const int ItemUIdFieldNumber = 8;

		// Token: 0x04003464 RID: 13412
		private int itemUId_;

		// Token: 0x04003465 RID: 13413
		public const int EffectIdFieldNumber = 2;

		// Token: 0x04003466 RID: 13414
		private int effectId_;
	}
}
