using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200060A RID: 1546
	[NetMessage(EMessageId.FlyEquipAddNotify)]
	public sealed class FlyEquipAddNotify : IMessage<FlyEquipAddNotify>, IMessage, IEquatable<FlyEquipAddNotify>, IDeepCloneable<FlyEquipAddNotify>, IBufferMessage
	{
		// Token: 0x06008EF3 RID: 36595 RVA: 0x0015A865 File Offset: 0x00158A65
		[NullableContext(1)]
		public static FlyEquipAddNotify Create()
		{
			return new FlyEquipAddNotify();
		}

		// Token: 0x17001C61 RID: 7265
		// (get) Token: 0x06008EF4 RID: 36596 RVA: 0x0015A86C File Offset: 0x00158A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C62 RID: 7266
		// (get) Token: 0x06008EF5 RID: 36597 RVA: 0x0015A86F File Offset: 0x00158A6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlyEquipAddNotify.Descriptor;
			}
		}

		// Token: 0x06008EF6 RID: 36598 RVA: 0x0015A876 File Offset: 0x00158A76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlyEquipAddNotify()
		{
		}

		// Token: 0x06008EF7 RID: 36599 RVA: 0x0015A889 File Offset: 0x00158A89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlyEquipAddNotify(FlyEquipAddNotify other) : this()
		{
			this.flySkins_ = other.flySkins_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008EF8 RID: 36600 RVA: 0x0015A8B3 File Offset: 0x00158AB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlyEquipAddNotify Clone()
		{
			return new FlyEquipAddNotify(this);
		}

		// Token: 0x17001C63 RID: 7267
		// (get) Token: 0x06008EF9 RID: 36601 RVA: 0x0015A8BB File Offset: 0x00158ABB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> FlySkins
		{
			get
			{
				return this.flySkins_;
			}
		}

		// Token: 0x06008EFA RID: 36602 RVA: 0x0015A8C3 File Offset: 0x00158AC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlyEquipAddNotify);
		}

		// Token: 0x06008EFB RID: 36603 RVA: 0x0015A8D1 File Offset: 0x00158AD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlyEquipAddNotify other)
		{
			return other != null && (other == this || (this.flySkins_.Equals(other.flySkins_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008EFC RID: 36604 RVA: 0x0015A904 File Offset: 0x00158B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.flySkins_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008EFD RID: 36605 RVA: 0x0015A938 File Offset: 0x00158B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008EFE RID: 36606 RVA: 0x0015A945 File Offset: 0x00158B45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008EFF RID: 36607 RVA: 0x0015A94E File Offset: 0x00158B4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.flySkins_.WriteTo(ref output, FlyEquipAddNotify._repeated_flySkins_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008F00 RID: 36608 RVA: 0x0015A978 File Offset: 0x00158B78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.flySkins_.CalculateSize(FlyEquipAddNotify._repeated_flySkins_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008F01 RID: 36609 RVA: 0x0015A9B1 File Offset: 0x00158BB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlyEquipAddNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.flySkins_.Add(other.flySkins_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008F02 RID: 36610 RVA: 0x0015A9DF File Offset: 0x00158BDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008F03 RID: 36611 RVA: 0x0015A9E8 File Offset: 0x00158BE8
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
				if (num != 40U && num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.flySkins_.AddEntriesFrom(ref input, FlyEquipAddNotify._repeated_flySkins_codec);
				}
			}
		}

		// Token: 0x04004585 RID: 17797
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004586 RID: 17798
		public const int FlySkinsFieldNumber = 5;

		// Token: 0x04004587 RID: 17799
		private static readonly FieldCodec<int> _repeated_flySkins_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04004588 RID: 17800
		private readonly RepeatedField<int> flySkins_ = new RepeatedField<int>();
	}
}
