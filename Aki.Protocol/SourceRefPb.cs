using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001263 RID: 4707
	public sealed class SourceRefPb : IMessage<SourceRefPb>, IMessage, IEquatable<SourceRefPb>, IDeepCloneable<SourceRefPb>, IBufferMessage
	{
		// Token: 0x0601913E RID: 102718 RVA: 0x003A60F7 File Offset: 0x003A42F7
		[NullableContext(1)]
		public static SourceRefPb Create()
		{
			return new SourceRefPb();
		}

		// Token: 0x17005496 RID: 21654
		// (get) Token: 0x0601913F RID: 102719 RVA: 0x003A60FE File Offset: 0x003A42FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005497 RID: 21655
		// (get) Token: 0x06019140 RID: 102720 RVA: 0x003A6101 File Offset: 0x003A4301
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SourceRefPb.Descriptor;
			}
		}

		// Token: 0x06019141 RID: 102721 RVA: 0x003A6108 File Offset: 0x003A4308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SourceRefPb()
		{
		}

		// Token: 0x06019142 RID: 102722 RVA: 0x003A611B File Offset: 0x003A431B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SourceRefPb(SourceRefPb other) : this()
		{
			this.type_ = other.type_;
			this.typeId_ = other.typeId_;
			this.name_ = other.name_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019143 RID: 102723 RVA: 0x003A6158 File Offset: 0x003A4358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SourceRefPb Clone()
		{
			return new SourceRefPb(this);
		}

		// Token: 0x17005498 RID: 21656
		// (get) Token: 0x06019144 RID: 102724 RVA: 0x003A6160 File Offset: 0x003A4360
		// (set) Token: 0x06019145 RID: 102725 RVA: 0x003A6168 File Offset: 0x003A4368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SourceType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17005499 RID: 21657
		// (get) Token: 0x06019146 RID: 102726 RVA: 0x003A6171 File Offset: 0x003A4371
		// (set) Token: 0x06019147 RID: 102727 RVA: 0x003A6179 File Offset: 0x003A4379
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TypeId
		{
			get
			{
				return this.typeId_;
			}
			set
			{
				this.typeId_ = value;
			}
		}

		// Token: 0x1700549A RID: 21658
		// (get) Token: 0x06019148 RID: 102728 RVA: 0x003A6182 File Offset: 0x003A4382
		// (set) Token: 0x06019149 RID: 102729 RVA: 0x003A618A File Offset: 0x003A438A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0601914A RID: 102730 RVA: 0x003A619D File Offset: 0x003A439D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SourceRefPb);
		}

		// Token: 0x0601914B RID: 102731 RVA: 0x003A61AC File Offset: 0x003A43AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SourceRefPb other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.TypeId == other.TypeId && !(this.Name != other.Name) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601914C RID: 102732 RVA: 0x003A620C File Offset: 0x003A440C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != SourceType.UnDefine)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.TypeId != 0)
			{
				num ^= this.TypeId.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601914D RID: 102733 RVA: 0x003A6285 File Offset: 0x003A4485
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601914E RID: 102734 RVA: 0x003A6292 File Offset: 0x003A4492
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601914F RID: 102735 RVA: 0x003A629C File Offset: 0x003A449C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != SourceType.UnDefine)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Type);
			}
			if (this.TypeId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.TypeId);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Name);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019150 RID: 102736 RVA: 0x003A6318 File Offset: 0x003A4518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != SourceType.UnDefine)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.TypeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TypeId);
			}
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019151 RID: 102737 RVA: 0x003A638C File Offset: 0x003A458C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SourceRefPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != SourceType.UnDefine)
			{
				this.Type = other.Type;
			}
			if (other.TypeId != 0)
			{
				this.TypeId = other.TypeId;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019152 RID: 102738 RVA: 0x003A63F5 File Offset: 0x003A45F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019153 RID: 102739 RVA: 0x003A6400 File Offset: 0x003A4600
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
							this.Name = input.ReadString();
						}
					}
					else
					{
						this.TypeId = input.ReadInt32();
					}
				}
				else
				{
					this.Type = (SourceType)input.ReadEnum();
				}
			}
		}

		// Token: 0x040093B8 RID: 37816
		private UnknownFieldSet _unknownFields;

		// Token: 0x040093B9 RID: 37817
		public const int TypeFieldNumber = 1;

		// Token: 0x040093BA RID: 37818
		private SourceType type_;

		// Token: 0x040093BB RID: 37819
		public const int TypeIdFieldNumber = 2;

		// Token: 0x040093BC RID: 37820
		private int typeId_;

		// Token: 0x040093BD RID: 37821
		public const int NameFieldNumber = 3;

		// Token: 0x040093BE RID: 37822
		private string name_ = "";
	}
}
