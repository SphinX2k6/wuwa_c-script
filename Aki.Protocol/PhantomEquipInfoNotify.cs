using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CCF RID: 3279
	[NetMessage(EMessageId.PhantomEquipInfoNotify)]
	public sealed class PhantomEquipInfoNotify : IMessage<PhantomEquipInfoNotify>, IMessage, IEquatable<PhantomEquipInfoNotify>, IDeepCloneable<PhantomEquipInfoNotify>, IBufferMessage
	{
		// Token: 0x06011BFC RID: 72700 RVA: 0x00298E80 File Offset: 0x00297080
		[NullableContext(1)]
		public static PhantomEquipInfoNotify Create()
		{
			return new PhantomEquipInfoNotify();
		}

		// Token: 0x17003ACD RID: 15053
		// (get) Token: 0x06011BFD RID: 72701 RVA: 0x00298E87 File Offset: 0x00297087
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003ACE RID: 15054
		// (get) Token: 0x06011BFE RID: 72702 RVA: 0x00298E8A File Offset: 0x0029708A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomEquipInfoNotify.Descriptor;
			}
		}

		// Token: 0x06011BFF RID: 72703 RVA: 0x00298E91 File Offset: 0x00297091
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomEquipInfoNotify()
		{
		}

		// Token: 0x06011C00 RID: 72704 RVA: 0x00298EA4 File Offset: 0x002970A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomEquipInfoNotify(PhantomEquipInfoNotify other) : this()
		{
			this.equipInfo_ = other.equipInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011C01 RID: 72705 RVA: 0x00298ECE File Offset: 0x002970CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomEquipInfoNotify Clone()
		{
			return new PhantomEquipInfoNotify(this);
		}

		// Token: 0x17003ACF RID: 15055
		// (get) Token: 0x06011C02 RID: 72706 RVA: 0x00298ED6 File Offset: 0x002970D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RolePhantomEquipInfo> EquipInfo
		{
			get
			{
				return this.equipInfo_;
			}
		}

		// Token: 0x06011C03 RID: 72707 RVA: 0x00298EDE File Offset: 0x002970DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomEquipInfoNotify);
		}

		// Token: 0x06011C04 RID: 72708 RVA: 0x00298EEC File Offset: 0x002970EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomEquipInfoNotify other)
		{
			return other != null && (other == this || (this.equipInfo_.Equals(other.equipInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011C05 RID: 72709 RVA: 0x00298F20 File Offset: 0x00297120
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

		// Token: 0x06011C06 RID: 72710 RVA: 0x00298F54 File Offset: 0x00297154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011C07 RID: 72711 RVA: 0x00298F61 File Offset: 0x00297161
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011C08 RID: 72712 RVA: 0x00298F6A File Offset: 0x0029716A
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

		// Token: 0x06011C09 RID: 72713 RVA: 0x00298F94 File Offset: 0x00297194
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

		// Token: 0x06011C0A RID: 72714 RVA: 0x00298FCD File Offset: 0x002971CD
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

		// Token: 0x06011C0B RID: 72715 RVA: 0x00298FFB File Offset: 0x002971FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011C0C RID: 72716 RVA: 0x00299004 File Offset: 0x00297204
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.equipInfo_.AddEntriesFrom(ref input, PhantomEquipInfoNotify._repeated_equipInfo_codec);
				}
			}
		}

		// Token: 0x04006F88 RID: 28552
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F89 RID: 28553
		public const int EquipInfoFieldNumber = 2;

		// Token: 0x04006F8A RID: 28554
		private static readonly FieldCodec<RolePhantomEquipInfo> _repeated_equipInfo_codec = FieldCodec.ForMessage<RolePhantomEquipInfo>(18U, RolePhantomEquipInfo.Parser);

		// Token: 0x04006F8B RID: 28555
		private readonly RepeatedField<RolePhantomEquipInfo> equipInfo_ = new RepeatedField<RolePhantomEquipInfo>();
	}
}
