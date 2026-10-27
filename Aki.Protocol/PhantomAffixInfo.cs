using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C16 RID: 3094
	public sealed class PhantomAffixInfo : IMessage<PhantomAffixInfo>, IMessage, IEquatable<PhantomAffixInfo>, IDeepCloneable<PhantomAffixInfo>, IBufferMessage
	{
		// Token: 0x06010CBA RID: 68794 RVA: 0x00275BB1 File Offset: 0x00273DB1
		[NullableContext(1)]
		public static PhantomAffixInfo Create()
		{
			return new PhantomAffixInfo();
		}

		// Token: 0x1700376F RID: 14191
		// (get) Token: 0x06010CBB RID: 68795 RVA: 0x00275BB8 File Offset: 0x00273DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomAffixInfo> Parser
		{
			get
			{
				return PhantomAffixInfo._parser;
			}
		}

		// Token: 0x17003770 RID: 14192
		// (get) Token: 0x06010CBC RID: 68796 RVA: 0x00275BBF File Offset: 0x00273DBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003771 RID: 14193
		// (get) Token: 0x06010CBD RID: 68797 RVA: 0x00275BC2 File Offset: 0x00273DC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomAffixInfo.Descriptor;
			}
		}

		// Token: 0x06010CBE RID: 68798 RVA: 0x00275BC9 File Offset: 0x00273DC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomAffixInfo()
		{
		}

		// Token: 0x06010CBF RID: 68799 RVA: 0x00275BDC File Offset: 0x00273DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomAffixInfo(PhantomAffixInfo other) : this()
		{
			this.configId_ = other.configId_;
			this.isunlock_ = other.isunlock_;
			this.elementUnits_ = other.elementUnits_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010CC0 RID: 68800 RVA: 0x00275C29 File Offset: 0x00273E29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomAffixInfo Clone()
		{
			return new PhantomAffixInfo(this);
		}

		// Token: 0x17003772 RID: 14194
		// (get) Token: 0x06010CC1 RID: 68801 RVA: 0x00275C31 File Offset: 0x00273E31
		// (set) Token: 0x06010CC2 RID: 68802 RVA: 0x00275C39 File Offset: 0x00273E39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x17003773 RID: 14195
		// (get) Token: 0x06010CC3 RID: 68803 RVA: 0x00275C42 File Offset: 0x00273E42
		// (set) Token: 0x06010CC4 RID: 68804 RVA: 0x00275C4A File Offset: 0x00273E4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Isunlock
		{
			get
			{
				return this.isunlock_;
			}
			set
			{
				this.isunlock_ = value;
			}
		}

		// Token: 0x17003774 RID: 14196
		// (get) Token: 0x06010CC5 RID: 68805 RVA: 0x00275C53 File Offset: 0x00273E53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ElementUnit> ElementUnits
		{
			get
			{
				return this.elementUnits_;
			}
		}

		// Token: 0x06010CC6 RID: 68806 RVA: 0x00275C5B File Offset: 0x00273E5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomAffixInfo);
		}

		// Token: 0x06010CC7 RID: 68807 RVA: 0x00275C6C File Offset: 0x00273E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomAffixInfo other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.Isunlock == other.Isunlock && this.elementUnits_.Equals(other.elementUnits_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010CC8 RID: 68808 RVA: 0x00275CCC File Offset: 0x00273ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.Isunlock)
			{
				num ^= this.Isunlock.GetHashCode();
			}
			num ^= this.elementUnits_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010CC9 RID: 68809 RVA: 0x00275D32 File Offset: 0x00273F32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010CCA RID: 68810 RVA: 0x00275D3F File Offset: 0x00273F3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010CCB RID: 68811 RVA: 0x00275D48 File Offset: 0x00273F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConfigId);
			}
			if (this.Isunlock)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Isunlock);
			}
			this.elementUnits_.WriteTo(ref output, PhantomAffixInfo._repeated_elementUnits_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010CCC RID: 68812 RVA: 0x00275DB4 File Offset: 0x00273FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.Isunlock)
			{
				num += 2;
			}
			num += this.elementUnits_.CalculateSize(PhantomAffixInfo._repeated_elementUnits_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010CCD RID: 68813 RVA: 0x00275E14 File Offset: 0x00274014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomAffixInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.Isunlock)
			{
				this.Isunlock = other.Isunlock;
			}
			this.elementUnits_.Add(other.elementUnits_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010CCE RID: 68814 RVA: 0x00275E75 File Offset: 0x00274075
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010CCF RID: 68815 RVA: 0x00275E80 File Offset: 0x00274080
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
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.elementUnits_.AddEntriesFrom(ref input, PhantomAffixInfo._repeated_elementUnits_codec);
						}
					}
					else
					{
						this.Isunlock = input.ReadBool();
					}
				}
				else
				{
					this.ConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006AA9 RID: 27305
		private static readonly MessageParser<PhantomAffixInfo> _parser = new MessageParser<PhantomAffixInfo>(() => new PhantomAffixInfo());

		// Token: 0x04006AAA RID: 27306
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006AAB RID: 27307
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x04006AAC RID: 27308
		private int configId_;

		// Token: 0x04006AAD RID: 27309
		public const int IsunlockFieldNumber = 2;

		// Token: 0x04006AAE RID: 27310
		private bool isunlock_;

		// Token: 0x04006AAF RID: 27311
		public const int ElementUnitsFieldNumber = 3;

		// Token: 0x04006AB0 RID: 27312
		private static readonly FieldCodec<ElementUnit> _repeated_elementUnits_codec = FieldCodec.ForMessage<ElementUnit>(26U, ElementUnit.Parser);

		// Token: 0x04006AB1 RID: 27313
		private readonly RepeatedField<ElementUnit> elementUnits_ = new RepeatedField<ElementUnit>();
	}
}
