using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CBF RID: 3263
	[NetMessage(EMessageId.PhantomEquipInfoNotify)]
	public sealed class PhantomEquipInfoNotify : IMessage<PhantomEquipInfoNotify>, IMessage, IEquatable<PhantomEquipInfoNotify>, IDeepCloneable<PhantomEquipInfoNotify>, IBufferMessage
	{
		// Token: 0x06011B00 RID: 72448 RVA: 0x00297263 File Offset: 0x00295463
		[NullableContext(1)]
		public static PhantomEquipInfoNotify Create()
		{
			return new PhantomEquipInfoNotify();
		}

		// Token: 0x17003A98 RID: 15000
		// (get) Token: 0x06011B01 RID: 72449 RVA: 0x0029726A File Offset: 0x0029546A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A99 RID: 15001
		// (get) Token: 0x06011B02 RID: 72450 RVA: 0x0029726D File Offset: 0x0029546D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomEquipInfoNotify.Descriptor;
			}
		}

		// Token: 0x06011B03 RID: 72451 RVA: 0x00297274 File Offset: 0x00295474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomEquipInfoNotify()
		{
		}

		// Token: 0x06011B04 RID: 72452 RVA: 0x00297287 File Offset: 0x00295487
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomEquipInfoNotify(PhantomEquipInfoNotify other) : this()
		{
			this.equipInfo_ = other.equipInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011B05 RID: 72453 RVA: 0x002972B1 File Offset: 0x002954B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomEquipInfoNotify Clone()
		{
			return new PhantomEquipInfoNotify(this);
		}

		// Token: 0x17003A9A RID: 15002
		// (get) Token: 0x06011B06 RID: 72454 RVA: 0x002972B9 File Offset: 0x002954B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RolePhantomEquipInfo> EquipInfo
		{
			get
			{
				return this.equipInfo_;
			}
		}

		// Token: 0x06011B07 RID: 72455 RVA: 0x002972C1 File Offset: 0x002954C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomEquipInfoNotify);
		}

		// Token: 0x06011B08 RID: 72456 RVA: 0x002972CF File Offset: 0x002954CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomEquipInfoNotify other)
		{
			return other != null && (other == this || (this.equipInfo_.Equals(other.equipInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011B09 RID: 72457 RVA: 0x00297304 File Offset: 0x00295504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.equipInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011B0A RID: 72458 RVA: 0x00297338 File Offset: 0x00295538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011B0B RID: 72459 RVA: 0x00297345 File Offset: 0x00295545
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011B0C RID: 72460 RVA: 0x0029734E File Offset: 0x0029554E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.equipInfo_.WriteTo(ref output, PhantomEquipInfoNotify._repeated_equipInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011B0D RID: 72461 RVA: 0x00297378 File Offset: 0x00295578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.equipInfo_.CalculateSize(PhantomEquipInfoNotify._repeated_equipInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011B0E RID: 72462 RVA: 0x002973B1 File Offset: 0x002955B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomEquipInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.equipInfo_.Add(other.equipInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011B0F RID: 72463 RVA: 0x002973DF File Offset: 0x002955DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011B10 RID: 72464 RVA: 0x002973E8 File Offset: 0x002955E8
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.equipInfo_.AddEntriesFrom(ref input, PhantomEquipInfoNotify._repeated_equipInfo_codec);
				}
			}
		}

		// Token: 0x04006FA0 RID: 28576
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006FA1 RID: 28577
		public const int EquipInfoFieldNumber = 6;

		// Token: 0x04006FA2 RID: 28578
		private static readonly FieldCodec<RolePhantomEquipInfo> _repeated_equipInfo_codec = FieldCodec.ForMessage<RolePhantomEquipInfo>(50U, RolePhantomEquipInfo.Parser);

		// Token: 0x04006FA3 RID: 28579
		private readonly RepeatedField<RolePhantomEquipInfo> equipInfo_ = new RepeatedField<RolePhantomEquipInfo>();
	}
}
