using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200063D RID: 1597
	public sealed class FRActionChangeTag : IMessage<FRActionChangeTag>, IMessage, IEquatable<FRActionChangeTag>, IDeepCloneable<FRActionChangeTag>, IBufferMessage
	{
		// Token: 0x06009323 RID: 37667 RVA: 0x001640A8 File Offset: 0x001622A8
		[NullableContext(1)]
		public static FRActionChangeTag Create()
		{
			return new FRActionChangeTag();
		}

		// Token: 0x17001D4B RID: 7499
		// (get) Token: 0x06009324 RID: 37668 RVA: 0x001640AF File Offset: 0x001622AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D4C RID: 7500
		// (get) Token: 0x06009325 RID: 37669 RVA: 0x001640B2 File Offset: 0x001622B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FRActionChangeTag.Descriptor;
			}
		}

		// Token: 0x06009326 RID: 37670 RVA: 0x001640B9 File Offset: 0x001622B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRActionChangeTag()
		{
		}

		// Token: 0x06009327 RID: 37671 RVA: 0x001640C1 File Offset: 0x001622C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRActionChangeTag(FRActionChangeTag other) : this()
		{
			this.unitIncId_ = other.unitIncId_;
			this.tagId_ = other.tagId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009328 RID: 37672 RVA: 0x001640F2 File Offset: 0x001622F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRActionChangeTag Clone()
		{
			return new FRActionChangeTag(this);
		}

		// Token: 0x17001D4D RID: 7501
		// (get) Token: 0x06009329 RID: 37673 RVA: 0x001640FA File Offset: 0x001622FA
		// (set) Token: 0x0600932A RID: 37674 RVA: 0x00164102 File Offset: 0x00162302
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UnitIncId
		{
			get
			{
				return this.unitIncId_;
			}
			set
			{
				this.unitIncId_ = value;
			}
		}

		// Token: 0x17001D4E RID: 7502
		// (get) Token: 0x0600932B RID: 37675 RVA: 0x0016410B File Offset: 0x0016230B
		// (set) Token: 0x0600932C RID: 37676 RVA: 0x00164113 File Offset: 0x00162313
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TagId
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

		// Token: 0x0600932D RID: 37677 RVA: 0x0016411C File Offset: 0x0016231C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FRActionChangeTag);
		}

		// Token: 0x0600932E RID: 37678 RVA: 0x0016412A File Offset: 0x0016232A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FRActionChangeTag other)
		{
			return other != null && (other == this || (this.UnitIncId == other.UnitIncId && this.TagId == other.TagId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600932F RID: 37679 RVA: 0x00164168 File Offset: 0x00162368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.UnitIncId != 0)
			{
				num ^= this.UnitIncId.GetHashCode();
			}
			if (this.TagId != 0L)
			{
				num ^= this.TagId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009330 RID: 37680 RVA: 0x001641C0 File Offset: 0x001623C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009331 RID: 37681 RVA: 0x001641CD File Offset: 0x001623CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009332 RID: 37682 RVA: 0x001641D8 File Offset: 0x001623D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.UnitIncId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.UnitIncId);
			}
			if (this.TagId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.TagId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009333 RID: 37683 RVA: 0x00164230 File Offset: 0x00162430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.UnitIncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UnitIncId);
			}
			if (this.TagId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TagId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009334 RID: 37684 RVA: 0x00164288 File Offset: 0x00162488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FRActionChangeTag other)
		{
			if (other == null)
			{
				return;
			}
			if (other.UnitIncId != 0)
			{
				this.UnitIncId = other.UnitIncId;
			}
			if (other.TagId != 0L)
			{
				this.TagId = other.TagId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009335 RID: 37685 RVA: 0x001642D8 File Offset: 0x001624D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009336 RID: 37686 RVA: 0x001642E4 File Offset: 0x001624E4
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
						this.TagId = input.ReadInt64();
					}
				}
				else
				{
					this.UnitIncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040046D3 RID: 18131
		private UnknownFieldSet _unknownFields;

		// Token: 0x040046D4 RID: 18132
		public const int UnitIncIdFieldNumber = 1;

		// Token: 0x040046D5 RID: 18133
		private int unitIncId_;

		// Token: 0x040046D6 RID: 18134
		public const int TagIdFieldNumber = 2;

		// Token: 0x040046D7 RID: 18135
		private long tagId_;
	}
}
