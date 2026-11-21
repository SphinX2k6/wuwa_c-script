using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012D2 RID: 4818
	public sealed class SourceRefPb : IMessage<SourceRefPb>, IMessage, IEquatable<SourceRefPb>, IDeepCloneable<SourceRefPb>, IBufferMessage
	{
		// Token: 0x06019B74 RID: 105332 RVA: 0x003C083C File Offset: 0x003BEA3C
		[NullableContext(1)]
		public static SourceRefPb Create()
		{
			return new SourceRefPb();
		}

		// Token: 0x17005717 RID: 22295
		// (get) Token: 0x06019B75 RID: 105333 RVA: 0x003C0843 File Offset: 0x003BEA43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005718 RID: 22296
		// (get) Token: 0x06019B76 RID: 105334 RVA: 0x003C0846 File Offset: 0x003BEA46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SourceRefPb.Descriptor;
			}
		}

		// Token: 0x06019B77 RID: 105335 RVA: 0x003C084D File Offset: 0x003BEA4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SourceRefPb()
		{
		}

		// Token: 0x06019B78 RID: 105336 RVA: 0x003C0860 File Offset: 0x003BEA60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SourceRefPb(SourceRefPb other) : this()
		{
			this.type_ = other.type_;
			this.typeId_ = other.typeId_;
			this.name_ = other.name_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019B79 RID: 105337 RVA: 0x003C089D File Offset: 0x003BEA9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SourceRefPb Clone()
		{
			return new SourceRefPb(this);
		}

		// Token: 0x17005719 RID: 22297
		// (get) Token: 0x06019B7A RID: 105338 RVA: 0x003C08A5 File Offset: 0x003BEAA5
		// (set) Token: 0x06019B7B RID: 105339 RVA: 0x003C08AD File Offset: 0x003BEAAD
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

		// Token: 0x1700571A RID: 22298
		// (get) Token: 0x06019B7C RID: 105340 RVA: 0x003C08B6 File Offset: 0x003BEAB6
		// (set) Token: 0x06019B7D RID: 105341 RVA: 0x003C08BE File Offset: 0x003BEABE
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

		// Token: 0x1700571B RID: 22299
		// (get) Token: 0x06019B7E RID: 105342 RVA: 0x003C08C7 File Offset: 0x003BEAC7
		// (set) Token: 0x06019B7F RID: 105343 RVA: 0x003C08CF File Offset: 0x003BEACF
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

		// Token: 0x06019B80 RID: 105344 RVA: 0x003C08E2 File Offset: 0x003BEAE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SourceRefPb);
		}

		// Token: 0x06019B81 RID: 105345 RVA: 0x003C08F0 File Offset: 0x003BEAF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SourceRefPb other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.TypeId == other.TypeId && !(this.Name != other.Name) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019B82 RID: 105346 RVA: 0x003C0950 File Offset: 0x003BEB50
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

		// Token: 0x06019B83 RID: 105347 RVA: 0x003C09C9 File Offset: 0x003BEBC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019B84 RID: 105348 RVA: 0x003C09D6 File Offset: 0x003BEBD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019B85 RID: 105349 RVA: 0x003C09E0 File Offset: 0x003BEBE0
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

		// Token: 0x06019B86 RID: 105350 RVA: 0x003C0A5C File Offset: 0x003BEC5C
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

		// Token: 0x06019B87 RID: 105351 RVA: 0x003C0AD0 File Offset: 0x003BECD0
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

		// Token: 0x06019B88 RID: 105352 RVA: 0x003C0B39 File Offset: 0x003BED39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019B89 RID: 105353 RVA: 0x003C0B44 File Offset: 0x003BED44
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

		// Token: 0x040097E2 RID: 38882
		private UnknownFieldSet _unknownFields;

		// Token: 0x040097E3 RID: 38883
		public const int TypeFieldNumber = 1;

		// Token: 0x040097E4 RID: 38884
		private SourceType type_;

		// Token: 0x040097E5 RID: 38885
		public const int TypeIdFieldNumber = 2;

		// Token: 0x040097E6 RID: 38886
		private int typeId_;

		// Token: 0x040097E7 RID: 38887
		public const int NameFieldNumber = 3;

		// Token: 0x040097E8 RID: 38888
		private string name_ = "";
	}
}
