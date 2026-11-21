using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000366 RID: 870
	[NetMessage(EMessageId.DangoBrawlItemEffectShowNotify)]
	public sealed class DangoBrawlItemEffectShowNotify : IMessage<DangoBrawlItemEffectShowNotify>, IMessage, IEquatable<DangoBrawlItemEffectShowNotify>, IDeepCloneable<DangoBrawlItemEffectShowNotify>, IBufferMessage
	{
		// Token: 0x060056FB RID: 22267 RVA: 0x000D4CF2 File Offset: 0x000D2EF2
		[NullableContext(1)]
		public static DangoBrawlItemEffectShowNotify Create()
		{
			return new DangoBrawlItemEffectShowNotify();
		}

		// Token: 0x17000FF9 RID: 4089
		// (get) Token: 0x060056FC RID: 22268 RVA: 0x000D4CF9 File Offset: 0x000D2EF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000FFA RID: 4090
		// (get) Token: 0x060056FD RID: 22269 RVA: 0x000D4CFC File Offset: 0x000D2EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlItemEffectShowNotify.Descriptor;
			}
		}

		// Token: 0x060056FE RID: 22270 RVA: 0x000D4D03 File Offset: 0x000D2F03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlItemEffectShowNotify()
		{
		}

		// Token: 0x060056FF RID: 22271 RVA: 0x000D4D0B File Offset: 0x000D2F0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlItemEffectShowNotify(DangoBrawlItemEffectShowNotify other) : this()
		{
			this.itemUId_ = other.itemUId_;
			this.effectId_ = other.effectId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005700 RID: 22272 RVA: 0x000D4D3C File Offset: 0x000D2F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlItemEffectShowNotify Clone()
		{
			return new DangoBrawlItemEffectShowNotify(this);
		}

		// Token: 0x17000FFB RID: 4091
		// (get) Token: 0x06005701 RID: 22273 RVA: 0x000D4D44 File Offset: 0x000D2F44
		// (set) Token: 0x06005702 RID: 22274 RVA: 0x000D4D4C File Offset: 0x000D2F4C
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

		// Token: 0x17000FFC RID: 4092
		// (get) Token: 0x06005703 RID: 22275 RVA: 0x000D4D55 File Offset: 0x000D2F55
		// (set) Token: 0x06005704 RID: 22276 RVA: 0x000D4D5D File Offset: 0x000D2F5D
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

		// Token: 0x06005705 RID: 22277 RVA: 0x000D4D66 File Offset: 0x000D2F66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlItemEffectShowNotify);
		}

		// Token: 0x06005706 RID: 22278 RVA: 0x000D4D74 File Offset: 0x000D2F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlItemEffectShowNotify other)
		{
			return other != null && (other == this || (this.ItemUId == other.ItemUId && this.EffectId == other.EffectId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005707 RID: 22279 RVA: 0x000D4DB4 File Offset: 0x000D2FB4
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

		// Token: 0x06005708 RID: 22280 RVA: 0x000D4E0C File Offset: 0x000D300C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005709 RID: 22281 RVA: 0x000D4E19 File Offset: 0x000D3019
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600570A RID: 22282 RVA: 0x000D4E24 File Offset: 0x000D3024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemUId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemUId);
			}
			if (this.EffectId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.EffectId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600570B RID: 22283 RVA: 0x000D4E7C File Offset: 0x000D307C
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

		// Token: 0x0600570C RID: 22284 RVA: 0x000D4ED4 File Offset: 0x000D30D4
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

		// Token: 0x0600570D RID: 22285 RVA: 0x000D4F24 File Offset: 0x000D3124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600570E RID: 22286 RVA: 0x000D4F30 File Offset: 0x000D3130
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
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EffectId = input.ReadInt32();
					}
				}
				else
				{
					this.ItemUId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040034FE RID: 13566
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034FF RID: 13567
		public const int ItemUIdFieldNumber = 1;

		// Token: 0x04003500 RID: 13568
		private int itemUId_;

		// Token: 0x04003501 RID: 13569
		public const int EffectIdFieldNumber = 15;

		// Token: 0x04003502 RID: 13570
		private int effectId_;
	}
}
