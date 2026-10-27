using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200109B RID: 4251
	public sealed class RoleProperSettle : IMessage<RoleProperSettle>, IMessage, IEquatable<RoleProperSettle>, IDeepCloneable<RoleProperSettle>, IBufferMessage
	{
		// Token: 0x06016B4A RID: 93002 RVA: 0x0034CDD4 File Offset: 0x0034AFD4
		[NullableContext(1)]
		public static RoleProperSettle Create()
		{
			return new RoleProperSettle();
		}

		// Token: 0x17004C13 RID: 19475
		// (get) Token: 0x06016B4B RID: 93003 RVA: 0x0034CDDB File Offset: 0x0034AFDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleProperSettle> Parser
		{
			get
			{
				return RoleProperSettle._parser;
			}
		}

		// Token: 0x17004C14 RID: 19476
		// (get) Token: 0x06016B4C RID: 93004 RVA: 0x0034CDE2 File Offset: 0x0034AFE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C15 RID: 19477
		// (get) Token: 0x06016B4D RID: 93005 RVA: 0x0034CDE5 File Offset: 0x0034AFE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleProperSettle.Descriptor;
			}
		}

		// Token: 0x06016B4E RID: 93006 RVA: 0x0034CDEC File Offset: 0x0034AFEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleProperSettle()
		{
		}

		// Token: 0x06016B4F RID: 93007 RVA: 0x0034CDF4 File Offset: 0x0034AFF4
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

		// Token: 0x06016B50 RID: 93008 RVA: 0x0034CE54 File Offset: 0x0034B054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleProperSettle Clone()
		{
			return new RoleProperSettle(this);
		}

		// Token: 0x17004C16 RID: 19478
		// (get) Token: 0x06016B51 RID: 93009 RVA: 0x0034CE5C File Offset: 0x0034B05C
		// (set) Token: 0x06016B52 RID: 93010 RVA: 0x0034CE64 File Offset: 0x0034B064
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

		// Token: 0x17004C17 RID: 19479
		// (get) Token: 0x06016B53 RID: 93011 RVA: 0x0034CE6D File Offset: 0x0034B06D
		// (set) Token: 0x06016B54 RID: 93012 RVA: 0x0034CE75 File Offset: 0x0034B075
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

		// Token: 0x17004C18 RID: 19480
		// (get) Token: 0x06016B55 RID: 93013 RVA: 0x0034CE7E File Offset: 0x0034B07E
		// (set) Token: 0x06016B56 RID: 93014 RVA: 0x0034CE86 File Offset: 0x0034B086
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

		// Token: 0x17004C19 RID: 19481
		// (get) Token: 0x06016B57 RID: 93015 RVA: 0x0034CE8F File Offset: 0x0034B08F
		// (set) Token: 0x06016B58 RID: 93016 RVA: 0x0034CE97 File Offset: 0x0034B097
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

		// Token: 0x17004C1A RID: 19482
		// (get) Token: 0x06016B59 RID: 93017 RVA: 0x0034CEA0 File Offset: 0x0034B0A0
		// (set) Token: 0x06016B5A RID: 93018 RVA: 0x0034CEA8 File Offset: 0x0034B0A8
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

		// Token: 0x06016B5B RID: 93019 RVA: 0x0034CEB1 File Offset: 0x0034B0B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleProperSettle);
		}

		// Token: 0x06016B5C RID: 93020 RVA: 0x0034CEC0 File Offset: 0x0034B0C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleProperSettle other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.PropertyA == other.PropertyA && this.PropertyB == other.PropertyB && this.PropertyC == other.PropertyC && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016B5D RID: 93021 RVA: 0x0034CF3C File Offset: 0x0034B13C
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

		// Token: 0x06016B5E RID: 93022 RVA: 0x0034CFDF File Offset: 0x0034B1DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016B5F RID: 93023 RVA: 0x0034CFEC File Offset: 0x0034B1EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016B60 RID: 93024 RVA: 0x0034CFF8 File Offset: 0x0034B1F8
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

		// Token: 0x06016B61 RID: 93025 RVA: 0x0034D0A4 File Offset: 0x0034B2A4
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

		// Token: 0x06016B62 RID: 93026 RVA: 0x0034D144 File Offset: 0x0034B344
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

		// Token: 0x06016B63 RID: 93027 RVA: 0x0034D1D0 File Offset: 0x0034B3D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016B64 RID: 93028 RVA: 0x0034D1DC File Offset: 0x0034B3DC
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

		// Token: 0x040087A7 RID: 34727
		private static readonly MessageParser<RoleProperSettle> _parser = new MessageParser<RoleProperSettle>(() => new RoleProperSettle());

		// Token: 0x040087A8 RID: 34728
		private UnknownFieldSet _unknownFields;

		// Token: 0x040087A9 RID: 34729
		public const int RoleIdFieldNumber = 1;

		// Token: 0x040087AA RID: 34730
		private int roleId_;

		// Token: 0x040087AB RID: 34731
		public const int PropertyAFieldNumber = 2;

		// Token: 0x040087AC RID: 34732
		private int propertyA_;

		// Token: 0x040087AD RID: 34733
		public const int PropertyBFieldNumber = 3;

		// Token: 0x040087AE RID: 34734
		private int propertyB_;

		// Token: 0x040087AF RID: 34735
		public const int PropertyCFieldNumber = 4;

		// Token: 0x040087B0 RID: 34736
		private int propertyC_;

		// Token: 0x040087B1 RID: 34737
		public const int LevelFieldNumber = 5;

		// Token: 0x040087B2 RID: 34738
		private int level_;
	}
}
