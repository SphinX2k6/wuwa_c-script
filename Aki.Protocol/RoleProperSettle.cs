using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200108B RID: 4235
	public sealed class RoleProperSettle : IMessage<RoleProperSettle>, IMessage, IEquatable<RoleProperSettle>, IDeepCloneable<RoleProperSettle>, IBufferMessage
	{
		// Token: 0x06016A65 RID: 92773 RVA: 0x0034B6F8 File Offset: 0x003498F8
		[NullableContext(1)]
		public static RoleProperSettle Create()
		{
			return new RoleProperSettle();
		}

		// Token: 0x17004BE9 RID: 19433
		// (get) Token: 0x06016A66 RID: 92774 RVA: 0x0034B6FF File Offset: 0x003498FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleProperSettle> Parser
		{
			get
			{
				return RoleProperSettle._parser;
			}
		}

		// Token: 0x17004BEA RID: 19434
		// (get) Token: 0x06016A67 RID: 92775 RVA: 0x0034B706 File Offset: 0x00349906
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004BEB RID: 19435
		// (get) Token: 0x06016A68 RID: 92776 RVA: 0x0034B709 File Offset: 0x00349909
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleProperSettle.Descriptor;
			}
		}

		// Token: 0x06016A69 RID: 92777 RVA: 0x0034B710 File Offset: 0x00349910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleProperSettle()
		{
		}

		// Token: 0x06016A6A RID: 92778 RVA: 0x0034B718 File Offset: 0x00349918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleProperSettle(RoleProperSettle other) : this()
		{
			this.roleId_ = other.roleId_;
			this.propertyA_ = other.propertyA_;
			this.propertyB_ = other.propertyB_;
			this.propertyC_ = other.propertyC_;
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016A6B RID: 92779 RVA: 0x0034B778 File Offset: 0x00349978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleProperSettle Clone()
		{
			return new RoleProperSettle(this);
		}

		// Token: 0x17004BEC RID: 19436
		// (get) Token: 0x06016A6C RID: 92780 RVA: 0x0034B780 File Offset: 0x00349980
		// (set) Token: 0x06016A6D RID: 92781 RVA: 0x0034B788 File Offset: 0x00349988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x17004BED RID: 19437
		// (get) Token: 0x06016A6E RID: 92782 RVA: 0x0034B791 File Offset: 0x00349991
		// (set) Token: 0x06016A6F RID: 92783 RVA: 0x0034B799 File Offset: 0x00349999
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PropertyA
		{
			get
			{
				return this.propertyA_;
			}
			set
			{
				this.propertyA_ = value;
			}
		}

		// Token: 0x17004BEE RID: 19438
		// (get) Token: 0x06016A70 RID: 92784 RVA: 0x0034B7A2 File Offset: 0x003499A2
		// (set) Token: 0x06016A71 RID: 92785 RVA: 0x0034B7AA File Offset: 0x003499AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PropertyB
		{
			get
			{
				return this.propertyB_;
			}
			set
			{
				this.propertyB_ = value;
			}
		}

		// Token: 0x17004BEF RID: 19439
		// (get) Token: 0x06016A72 RID: 92786 RVA: 0x0034B7B3 File Offset: 0x003499B3
		// (set) Token: 0x06016A73 RID: 92787 RVA: 0x0034B7BB File Offset: 0x003499BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PropertyC
		{
			get
			{
				return this.propertyC_;
			}
			set
			{
				this.propertyC_ = value;
			}
		}

		// Token: 0x17004BF0 RID: 19440
		// (get) Token: 0x06016A74 RID: 92788 RVA: 0x0034B7C4 File Offset: 0x003499C4
		// (set) Token: 0x06016A75 RID: 92789 RVA: 0x0034B7CC File Offset: 0x003499CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x06016A76 RID: 92790 RVA: 0x0034B7D5 File Offset: 0x003499D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleProperSettle);
		}

		// Token: 0x06016A77 RID: 92791 RVA: 0x0034B7E4 File Offset: 0x003499E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleProperSettle other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.PropertyA == other.PropertyA && this.PropertyB == other.PropertyB && this.PropertyC == other.PropertyC && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016A78 RID: 92792 RVA: 0x0034B860 File Offset: 0x00349A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.PropertyA != 0)
			{
				num ^= this.PropertyA.GetHashCode();
			}
			if (this.PropertyB != 0)
			{
				num ^= this.PropertyB.GetHashCode();
			}
			if (this.PropertyC != 0)
			{
				num ^= this.PropertyC.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016A79 RID: 92793 RVA: 0x0034B903 File Offset: 0x00349B03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016A7A RID: 92794 RVA: 0x0034B910 File Offset: 0x00349B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016A7B RID: 92795 RVA: 0x0034B91C File Offset: 0x00349B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.PropertyA != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.PropertyA);
			}
			if (this.PropertyB != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.PropertyB);
			}
			if (this.PropertyC != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.PropertyC);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016A7C RID: 92796 RVA: 0x0034B9C8 File Offset: 0x00349BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.PropertyA != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PropertyA);
			}
			if (this.PropertyB != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PropertyB);
			}
			if (this.PropertyC != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PropertyC);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016A7D RID: 92797 RVA: 0x0034BA68 File Offset: 0x00349C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleProperSettle other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.PropertyA != 0)
			{
				this.PropertyA = other.PropertyA;
			}
			if (other.PropertyB != 0)
			{
				this.PropertyB = other.PropertyB;
			}
			if (other.PropertyC != 0)
			{
				this.PropertyC = other.PropertyC;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016A7E RID: 92798 RVA: 0x0034BAF4 File Offset: 0x00349CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016A7F RID: 92799 RVA: 0x0034BB00 File Offset: 0x00349D00
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.PropertyA = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.PropertyB = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.PropertyC = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.Level = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040087D1 RID: 34769
		private static readonly MessageParser<RoleProperSettle> _parser = new MessageParser<RoleProperSettle>(() => new RoleProperSettle());

		// Token: 0x040087D2 RID: 34770
		private UnknownFieldSet _unknownFields;

		// Token: 0x040087D3 RID: 34771
		public const int RoleIdFieldNumber = 1;

		// Token: 0x040087D4 RID: 34772
		private int roleId_;

		// Token: 0x040087D5 RID: 34773
		public const int PropertyAFieldNumber = 2;

		// Token: 0x040087D6 RID: 34774
		private int propertyA_;

		// Token: 0x040087D7 RID: 34775
		public const int PropertyBFieldNumber = 3;

		// Token: 0x040087D8 RID: 34776
		private int propertyB_;

		// Token: 0x040087D9 RID: 34777
		public const int PropertyCFieldNumber = 4;

		// Token: 0x040087DA RID: 34778
		private int propertyC_;

		// Token: 0x040087DB RID: 34779
		public const int LevelFieldNumber = 5;

		// Token: 0x040087DC RID: 34780
		private int level_;
	}
}
