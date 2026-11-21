using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003F9 RID: 1017
	[NetMessage(EMessageId.DropInBagNotify)]
	public sealed class DropInBagNotify : IMessage<DropInBagNotify>, IMessage, IEquatable<DropInBagNotify>, IDeepCloneable<DropInBagNotify>, IBufferMessage
	{
		// Token: 0x0600629C RID: 25244 RVA: 0x000ED980 File Offset: 0x000EBB80
		[NullableContext(1)]
		public static DropInBagNotify Create()
		{
			return new DropInBagNotify();
		}

		// Token: 0x17001260 RID: 4704
		// (get) Token: 0x0600629D RID: 25245 RVA: 0x000ED987 File Offset: 0x000EBB87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001261 RID: 4705
		// (get) Token: 0x0600629E RID: 25246 RVA: 0x000ED98A File Offset: 0x000EBB8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DropInBagNotify.Descriptor;
			}
		}

		// Token: 0x0600629F RID: 25247 RVA: 0x000ED991 File Offset: 0x000EBB91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropInBagNotify()
		{
		}

		// Token: 0x060062A0 RID: 25248 RVA: 0x000ED9A4 File Offset: 0x000EBBA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropInBagNotify(DropInBagNotify other) : this()
		{
			this.dropId_ = other.dropId_;
			this.dropItemInfos_ = other.dropItemInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060062A1 RID: 25249 RVA: 0x000ED9DA File Offset: 0x000EBBDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropInBagNotify Clone()
		{
			return new DropInBagNotify(this);
		}

		// Token: 0x17001262 RID: 4706
		// (get) Token: 0x060062A2 RID: 25250 RVA: 0x000ED9E2 File Offset: 0x000EBBE2
		// (set) Token: 0x060062A3 RID: 25251 RVA: 0x000ED9EA File Offset: 0x000EBBEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DropId
		{
			get
			{
				return this.dropId_;
			}
			set
			{
				this.dropId_ = value;
			}
		}

		// Token: 0x17001263 RID: 4707
		// (get) Token: 0x060062A4 RID: 25252 RVA: 0x000ED9F3 File Offset: 0x000EBBF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DropBagItemInfo> DropItemInfos
		{
			get
			{
				return this.dropItemInfos_;
			}
		}

		// Token: 0x060062A5 RID: 25253 RVA: 0x000ED9FB File Offset: 0x000EBBFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DropInBagNotify);
		}

		// Token: 0x060062A6 RID: 25254 RVA: 0x000EDA0C File Offset: 0x000EBC0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DropInBagNotify other)
		{
			return other != null && (other == this || (this.DropId == other.DropId && this.dropItemInfos_.Equals(other.dropItemInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060062A7 RID: 25255 RVA: 0x000EDA5C File Offset: 0x000EBC5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DropId != 0)
			{
				num ^= this.DropId.GetHashCode();
			}
			num ^= this.dropItemInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060062A8 RID: 25256 RVA: 0x000EDAA9 File Offset: 0x000EBCA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060062A9 RID: 25257 RVA: 0x000EDAB6 File Offset: 0x000EBCB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060062AA RID: 25258 RVA: 0x000EDAC0 File Offset: 0x000EBCC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.dropItemInfos_.WriteTo(ref output, DropInBagNotify._repeated_dropItemInfos_codec);
			if (this.DropId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.DropId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060062AB RID: 25259 RVA: 0x000EDB10 File Offset: 0x000EBD10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DropId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DropId);
			}
			num += this.dropItemInfos_.CalculateSize(DropInBagNotify._repeated_dropItemInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060062AC RID: 25260 RVA: 0x000EDB64 File Offset: 0x000EBD64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DropInBagNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DropId != 0)
			{
				this.DropId = other.DropId;
			}
			this.dropItemInfos_.Add(other.dropItemInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060062AD RID: 25261 RVA: 0x000EDBB1 File Offset: 0x000EBDB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060062AE RID: 25262 RVA: 0x000EDBBC File Offset: 0x000EBDBC
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
				if (num != 10U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.DropId = input.ReadInt32();
					}
				}
				else
				{
					this.dropItemInfos_.AddEntriesFrom(ref input, DropInBagNotify._repeated_dropItemInfos_codec);
				}
			}
		}

		// Token: 0x04003844 RID: 14404
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003845 RID: 14405
		public const int DropIdFieldNumber = 12;

		// Token: 0x04003846 RID: 14406
		private int dropId_;

		// Token: 0x04003847 RID: 14407
		public const int DropItemInfosFieldNumber = 1;

		// Token: 0x04003848 RID: 14408
		private static readonly FieldCodec<DropBagItemInfo> _repeated_dropItemInfos_codec = FieldCodec.ForMessage<DropBagItemInfo>(10U, DropBagItemInfo.Parser);

		// Token: 0x04003849 RID: 14409
		private readonly RepeatedField<DropBagItemInfo> dropItemInfos_ = new RepeatedField<DropBagItemInfo>();
	}
}
