using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C06 RID: 3078
	public sealed class PhantomAffixInfo : IMessage<PhantomAffixInfo>, IMessage, IEquatable<PhantomAffixInfo>, IDeepCloneable<PhantomAffixInfo>, IBufferMessage
	{
		// Token: 0x06010BBA RID: 68538 RVA: 0x00273E4A File Offset: 0x0027204A
		[NullableContext(1)]
		public static PhantomAffixInfo Create()
		{
			return new PhantomAffixInfo();
		}

		// Token: 0x17003738 RID: 14136
		// (get) Token: 0x06010BBB RID: 68539 RVA: 0x00273E51 File Offset: 0x00272051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomAffixInfo> Parser
		{
			get
			{
				return PhantomAffixInfo._parser;
			}
		}

		// Token: 0x17003739 RID: 14137
		// (get) Token: 0x06010BBC RID: 68540 RVA: 0x00273E58 File Offset: 0x00272058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700373A RID: 14138
		// (get) Token: 0x06010BBD RID: 68541 RVA: 0x00273E5B File Offset: 0x0027205B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomAffixInfo.Descriptor;
			}
		}

		// Token: 0x06010BBE RID: 68542 RVA: 0x00273E62 File Offset: 0x00272062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomAffixInfo()
		{
		}

		// Token: 0x06010BBF RID: 68543 RVA: 0x00273E78 File Offset: 0x00272078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomAffixInfo(PhantomAffixInfo other) : this()
		{
			this.configId_ = other.configId_;
			this.isunlock_ = other.isunlock_;
			this.elementUnits_ = other.elementUnits_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010BC0 RID: 68544 RVA: 0x00273EC5 File Offset: 0x002720C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomAffixInfo Clone()
		{
			return new PhantomAffixInfo(this);
		}

		// Token: 0x1700373B RID: 14139
		// (get) Token: 0x06010BC1 RID: 68545 RVA: 0x00273ECD File Offset: 0x002720CD
		// (set) Token: 0x06010BC2 RID: 68546 RVA: 0x00273ED5 File Offset: 0x002720D5
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

		// Token: 0x1700373C RID: 14140
		// (get) Token: 0x06010BC3 RID: 68547 RVA: 0x00273EDE File Offset: 0x002720DE
		// (set) Token: 0x06010BC4 RID: 68548 RVA: 0x00273EE6 File Offset: 0x002720E6
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

		// Token: 0x1700373D RID: 14141
		// (get) Token: 0x06010BC5 RID: 68549 RVA: 0x00273EEF File Offset: 0x002720EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ElementUnit> ElementUnits
		{
			get
			{
				return this.elementUnits_;
			}
		}

		// Token: 0x06010BC6 RID: 68550 RVA: 0x00273EF7 File Offset: 0x002720F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomAffixInfo);
		}

		// Token: 0x06010BC7 RID: 68551 RVA: 0x00273F08 File Offset: 0x00272108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomAffixInfo other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.Isunlock == other.Isunlock && this.elementUnits_.Equals(other.elementUnits_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010BC8 RID: 68552 RVA: 0x00273F68 File Offset: 0x00272168
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

		// Token: 0x06010BC9 RID: 68553 RVA: 0x00273FCE File Offset: 0x002721CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010BCA RID: 68554 RVA: 0x00273FDB File Offset: 0x002721DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010BCB RID: 68555 RVA: 0x00273FE4 File Offset: 0x002721E4
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

		// Token: 0x06010BCC RID: 68556 RVA: 0x00274050 File Offset: 0x00272250
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

		// Token: 0x06010BCD RID: 68557 RVA: 0x002740B0 File Offset: 0x002722B0
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

		// Token: 0x06010BCE RID: 68558 RVA: 0x00274111 File Offset: 0x00272311
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010BCF RID: 68559 RVA: 0x0027411C File Offset: 0x0027231C
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

		// Token: 0x04006ABD RID: 27325
		private static readonly MessageParser<PhantomAffixInfo> _parser = new MessageParser<PhantomAffixInfo>(() => new PhantomAffixInfo());

		// Token: 0x04006ABE RID: 27326
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006ABF RID: 27327
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x04006AC0 RID: 27328
		private int configId_;

		// Token: 0x04006AC1 RID: 27329
		public const int IsunlockFieldNumber = 2;

		// Token: 0x04006AC2 RID: 27330
		private bool isunlock_;

		// Token: 0x04006AC3 RID: 27331
		public const int ElementUnitsFieldNumber = 3;

		// Token: 0x04006AC4 RID: 27332
		private static readonly FieldCodec<ElementUnit> _repeated_elementUnits_codec = FieldCodec.ForMessage<ElementUnit>(26U, ElementUnit.Parser);

		// Token: 0x04006AC5 RID: 27333
		private readonly RepeatedField<ElementUnit> elementUnits_ = new RepeatedField<ElementUnit>();
	}
}
