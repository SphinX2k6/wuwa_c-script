using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000300 RID: 768
	public sealed class CookingInfo : IMessage<CookingInfo>, IMessage, IEquatable<CookingInfo>, IDeepCloneable<CookingInfo>, IBufferMessage
	{
		// Token: 0x06004DE0 RID: 19936 RVA: 0x000BD9DA File Offset: 0x000BBBDA
		[NullableContext(1)]
		public static CookingInfo Create()
		{
			return new CookingInfo();
		}

		// Token: 0x17000DC7 RID: 3527
		// (get) Token: 0x06004DE1 RID: 19937 RVA: 0x000BD9E1 File Offset: 0x000BBBE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000DC8 RID: 3528
		// (get) Token: 0x06004DE2 RID: 19938 RVA: 0x000BD9E4 File Offset: 0x000BBBE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CookingInfo.Descriptor;
			}
		}

		// Token: 0x06004DE3 RID: 19939 RVA: 0x000BD9EB File Offset: 0x000BBBEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookingInfo()
		{
		}

		// Token: 0x06004DE4 RID: 19940 RVA: 0x000BD9F3 File Offset: 0x000BBBF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookingInfo(CookingInfo other) : this()
		{
			this.cookingLevel_ = other.cookingLevel_;
			this.totalProficiencys_ = other.totalProficiencys_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004DE5 RID: 19941 RVA: 0x000BDA24 File Offset: 0x000BBC24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookingInfo Clone()
		{
			return new CookingInfo(this);
		}

		// Token: 0x17000DC9 RID: 3529
		// (get) Token: 0x06004DE6 RID: 19942 RVA: 0x000BDA2C File Offset: 0x000BBC2C
		// (set) Token: 0x06004DE7 RID: 19943 RVA: 0x000BDA34 File Offset: 0x000BBC34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CookingLevel
		{
			get
			{
				return this.cookingLevel_;
			}
			set
			{
				this.cookingLevel_ = value;
			}
		}

		// Token: 0x17000DCA RID: 3530
		// (get) Token: 0x06004DE8 RID: 19944 RVA: 0x000BDA3D File Offset: 0x000BBC3D
		// (set) Token: 0x06004DE9 RID: 19945 RVA: 0x000BDA45 File Offset: 0x000BBC45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalProficiencys
		{
			get
			{
				return this.totalProficiencys_;
			}
			set
			{
				this.totalProficiencys_ = value;
			}
		}

		// Token: 0x06004DEA RID: 19946 RVA: 0x000BDA4E File Offset: 0x000BBC4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CookingInfo);
		}

		// Token: 0x06004DEB RID: 19947 RVA: 0x000BDA5C File Offset: 0x000BBC5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CookingInfo other)
		{
			return other != null && (other == this || (this.CookingLevel == other.CookingLevel && this.TotalProficiencys == other.TotalProficiencys && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004DEC RID: 19948 RVA: 0x000BDA9C File Offset: 0x000BBC9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CookingLevel != 0)
			{
				num ^= this.CookingLevel.GetHashCode();
			}
			if (this.TotalProficiencys != 0)
			{
				num ^= this.TotalProficiencys.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004DED RID: 19949 RVA: 0x000BDAF4 File Offset: 0x000BBCF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004DEE RID: 19950 RVA: 0x000BDB01 File Offset: 0x000BBD01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004DEF RID: 19951 RVA: 0x000BDB0C File Offset: 0x000BBD0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CookingLevel != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CookingLevel);
			}
			if (this.TotalProficiencys != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.TotalProficiencys);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004DF0 RID: 19952 RVA: 0x000BDB64 File Offset: 0x000BBD64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CookingLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CookingLevel);
			}
			if (this.TotalProficiencys != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalProficiencys);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004DF1 RID: 19953 RVA: 0x000BDBBC File Offset: 0x000BBDBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CookingInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CookingLevel != 0)
			{
				this.CookingLevel = other.CookingLevel;
			}
			if (other.TotalProficiencys != 0)
			{
				this.TotalProficiencys = other.TotalProficiencys;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004DF2 RID: 19954 RVA: 0x000BDC0C File Offset: 0x000BBE0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004DF3 RID: 19955 RVA: 0x000BDC18 File Offset: 0x000BBE18
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TotalProficiencys = input.ReadInt32();
					}
				}
				else
				{
					this.CookingLevel = input.ReadInt32();
				}
			}
		}

		// Token: 0x040031C8 RID: 12744
		private UnknownFieldSet _unknownFields;

		// Token: 0x040031C9 RID: 12745
		public const int CookingLevelFieldNumber = 1;

		// Token: 0x040031CA RID: 12746
		private int cookingLevel_;

		// Token: 0x040031CB RID: 12747
		public const int TotalProficiencysFieldNumber = 2;

		// Token: 0x040031CC RID: 12748
		private int totalProficiencys_;
	}
}
