using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012A1 RID: 4769
	public sealed class SolarSchoolAttrPb : IMessage<SolarSchoolAttrPb>, IMessage, IEquatable<SolarSchoolAttrPb>, IDeepCloneable<SolarSchoolAttrPb>, IBufferMessage
	{
		// Token: 0x06019740 RID: 104256 RVA: 0x003B64DE File Offset: 0x003B46DE
		[NullableContext(1)]
		public static SolarSchoolAttrPb Create()
		{
			return new SolarSchoolAttrPb();
		}

		// Token: 0x1700561C RID: 22044
		// (get) Token: 0x06019741 RID: 104257 RVA: 0x003B64E5 File Offset: 0x003B46E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SolarSchoolAttrPb> Parser
		{
			get
			{
				return SolarSchoolAttrPb._parser;
			}
		}

		// Token: 0x1700561D RID: 22045
		// (get) Token: 0x06019742 RID: 104258 RVA: 0x003B64EC File Offset: 0x003B46EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700561E RID: 22046
		// (get) Token: 0x06019743 RID: 104259 RVA: 0x003B64EF File Offset: 0x003B46EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolAttrPb.Descriptor;
			}
		}

		// Token: 0x06019744 RID: 104260 RVA: 0x003B64F6 File Offset: 0x003B46F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolAttrPb()
		{
		}

		// Token: 0x06019745 RID: 104261 RVA: 0x003B64FE File Offset: 0x003B46FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolAttrPb(SolarSchoolAttrPb other) : this()
		{
			this.attrType_ = other.attrType_;
			this.value_ = other.value_;
			this.important_ = other.important_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019746 RID: 104262 RVA: 0x003B653B File Offset: 0x003B473B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolAttrPb Clone()
		{
			return new SolarSchoolAttrPb(this);
		}

		// Token: 0x1700561F RID: 22047
		// (get) Token: 0x06019747 RID: 104263 RVA: 0x003B6543 File Offset: 0x003B4743
		// (set) Token: 0x06019748 RID: 104264 RVA: 0x003B654B File Offset: 0x003B474B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolAttrType AttrType
		{
			get
			{
				return this.attrType_;
			}
			set
			{
				this.attrType_ = value;
			}
		}

		// Token: 0x17005620 RID: 22048
		// (get) Token: 0x06019749 RID: 104265 RVA: 0x003B6554 File Offset: 0x003B4754
		// (set) Token: 0x0601974A RID: 104266 RVA: 0x003B655C File Offset: 0x003B475C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Value
		{
			get
			{
				return this.value_;
			}
			set
			{
				this.value_ = value;
			}
		}

		// Token: 0x17005621 RID: 22049
		// (get) Token: 0x0601974B RID: 104267 RVA: 0x003B6565 File Offset: 0x003B4765
		// (set) Token: 0x0601974C RID: 104268 RVA: 0x003B656D File Offset: 0x003B476D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Important
		{
			get
			{
				return this.important_;
			}
			set
			{
				this.important_ = value;
			}
		}

		// Token: 0x0601974D RID: 104269 RVA: 0x003B6576 File Offset: 0x003B4776
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolAttrPb);
		}

		// Token: 0x0601974E RID: 104270 RVA: 0x003B6584 File Offset: 0x003B4784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolAttrPb other)
		{
			return other != null && (other == this || (this.AttrType == other.AttrType && this.Value == other.Value && this.Important == other.Important && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601974F RID: 104271 RVA: 0x003B65E0 File Offset: 0x003B47E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AttrType != SolarSchoolAttrType.SolarSchoolAttrUnknown)
			{
				num ^= this.AttrType.GetHashCode();
			}
			if (this.Value != 0)
			{
				num ^= this.Value.GetHashCode();
			}
			if (this.Important)
			{
				num ^= this.Important.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019750 RID: 104272 RVA: 0x003B6657 File Offset: 0x003B4857
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019751 RID: 104273 RVA: 0x003B6664 File Offset: 0x003B4864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019752 RID: 104274 RVA: 0x003B6670 File Offset: 0x003B4870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AttrType != SolarSchoolAttrType.SolarSchoolAttrUnknown)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.AttrType);
			}
			if (this.Value != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Value);
			}
			if (this.Important)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.Important);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019753 RID: 104275 RVA: 0x003B66E4 File Offset: 0x003B48E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AttrType != SolarSchoolAttrType.SolarSchoolAttrUnknown)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.AttrType);
			}
			if (this.Value != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Value);
			}
			if (this.Important)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019754 RID: 104276 RVA: 0x003B6748 File Offset: 0x003B4948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolAttrPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AttrType != SolarSchoolAttrType.SolarSchoolAttrUnknown)
			{
				this.AttrType = other.AttrType;
			}
			if (other.Value != 0)
			{
				this.Value = other.Value;
			}
			if (other.Important)
			{
				this.Important = other.Important;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019755 RID: 104277 RVA: 0x003B67AC File Offset: 0x003B49AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019756 RID: 104278 RVA: 0x003B67B8 File Offset: 0x003B49B8
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Important = input.ReadBool();
						}
					}
					else
					{
						this.Value = input.ReadInt32();
					}
				}
				else
				{
					this.AttrType = (SolarSchoolAttrType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009678 RID: 38520
		private static readonly MessageParser<SolarSchoolAttrPb> _parser = new MessageParser<SolarSchoolAttrPb>(() => new SolarSchoolAttrPb());

		// Token: 0x04009679 RID: 38521
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400967A RID: 38522
		public const int AttrTypeFieldNumber = 1;

		// Token: 0x0400967B RID: 38523
		private SolarSchoolAttrType attrType_;

		// Token: 0x0400967C RID: 38524
		public const int ValueFieldNumber = 2;

		// Token: 0x0400967D RID: 38525
		private int value_;

		// Token: 0x0400967E RID: 38526
		public const int ImportantFieldNumber = 3;

		// Token: 0x0400967F RID: 38527
		private bool important_;
	}
}
