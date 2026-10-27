using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C17 RID: 3095
	public sealed class PhantomAttrRecommendInfo : IMessage<PhantomAttrRecommendInfo>, IMessage, IEquatable<PhantomAttrRecommendInfo>, IDeepCloneable<PhantomAttrRecommendInfo>, IBufferMessage
	{
		// Token: 0x06010CD1 RID: 68817 RVA: 0x00275F1C File Offset: 0x0027411C
		[NullableContext(1)]
		public static PhantomAttrRecommendInfo Create()
		{
			return new PhantomAttrRecommendInfo();
		}

		// Token: 0x17003775 RID: 14197
		// (get) Token: 0x06010CD2 RID: 68818 RVA: 0x00275F23 File Offset: 0x00274123
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomAttrRecommendInfo> Parser
		{
			get
			{
				return PhantomAttrRecommendInfo._parser;
			}
		}

		// Token: 0x17003776 RID: 14198
		// (get) Token: 0x06010CD3 RID: 68819 RVA: 0x00275F2A File Offset: 0x0027412A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003777 RID: 14199
		// (get) Token: 0x06010CD4 RID: 68820 RVA: 0x00275F2D File Offset: 0x0027412D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomAttrRecommendInfo.Descriptor;
			}
		}

		// Token: 0x06010CD5 RID: 68821 RVA: 0x00275F34 File Offset: 0x00274134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomAttrRecommendInfo()
		{
		}

		// Token: 0x06010CD6 RID: 68822 RVA: 0x00275F3C File Offset: 0x0027413C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomAttrRecommendInfo(PhantomAttrRecommendInfo other) : this()
		{
			this.attrType_ = other.attrType_;
			this.addType_ = other.addType_;
			this.usage_ = other.usage_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010CD7 RID: 68823 RVA: 0x00275F79 File Offset: 0x00274179
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomAttrRecommendInfo Clone()
		{
			return new PhantomAttrRecommendInfo(this);
		}

		// Token: 0x17003778 RID: 14200
		// (get) Token: 0x06010CD8 RID: 68824 RVA: 0x00275F81 File Offset: 0x00274181
		// (set) Token: 0x06010CD9 RID: 68825 RVA: 0x00275F89 File Offset: 0x00274189
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AttrType
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

		// Token: 0x17003779 RID: 14201
		// (get) Token: 0x06010CDA RID: 68826 RVA: 0x00275F92 File Offset: 0x00274192
		// (set) Token: 0x06010CDB RID: 68827 RVA: 0x00275F9A File Offset: 0x0027419A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AddType
		{
			get
			{
				return this.addType_;
			}
			set
			{
				this.addType_ = value;
			}
		}

		// Token: 0x1700377A RID: 14202
		// (get) Token: 0x06010CDC RID: 68828 RVA: 0x00275FA3 File Offset: 0x002741A3
		// (set) Token: 0x06010CDD RID: 68829 RVA: 0x00275FAB File Offset: 0x002741AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Usage
		{
			get
			{
				return this.usage_;
			}
			set
			{
				this.usage_ = value;
			}
		}

		// Token: 0x06010CDE RID: 68830 RVA: 0x00275FB4 File Offset: 0x002741B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomAttrRecommendInfo);
		}

		// Token: 0x06010CDF RID: 68831 RVA: 0x00275FC4 File Offset: 0x002741C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomAttrRecommendInfo other)
		{
			return other != null && (other == this || (this.AttrType == other.AttrType && this.AddType == other.AddType && this.Usage == other.Usage && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010CE0 RID: 68832 RVA: 0x00276020 File Offset: 0x00274220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AttrType != 0)
			{
				num ^= this.AttrType.GetHashCode();
			}
			if (this.AddType != 0)
			{
				num ^= this.AddType.GetHashCode();
			}
			if (this.Usage != 0)
			{
				num ^= this.Usage.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010CE1 RID: 68833 RVA: 0x00276091 File Offset: 0x00274291
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010CE2 RID: 68834 RVA: 0x0027609E File Offset: 0x0027429E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010CE3 RID: 68835 RVA: 0x002760A8 File Offset: 0x002742A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AttrType != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.AttrType);
			}
			if (this.AddType != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.AddType);
			}
			if (this.Usage != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Usage);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010CE4 RID: 68836 RVA: 0x0027611C File Offset: 0x0027431C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AttrType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AttrType);
			}
			if (this.AddType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AddType);
			}
			if (this.Usage != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Usage);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010CE5 RID: 68837 RVA: 0x0027618C File Offset: 0x0027438C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomAttrRecommendInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AttrType != 0)
			{
				this.AttrType = other.AttrType;
			}
			if (other.AddType != 0)
			{
				this.AddType = other.AddType;
			}
			if (other.Usage != 0)
			{
				this.Usage = other.Usage;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010CE6 RID: 68838 RVA: 0x002761F0 File Offset: 0x002743F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010CE7 RID: 68839 RVA: 0x002761FC File Offset: 0x002743FC
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
							this.Usage = input.ReadInt32();
						}
					}
					else
					{
						this.AddType = input.ReadInt32();
					}
				}
				else
				{
					this.AttrType = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006AB2 RID: 27314
		private static readonly MessageParser<PhantomAttrRecommendInfo> _parser = new MessageParser<PhantomAttrRecommendInfo>(() => new PhantomAttrRecommendInfo());

		// Token: 0x04006AB3 RID: 27315
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006AB4 RID: 27316
		public const int AttrTypeFieldNumber = 1;

		// Token: 0x04006AB5 RID: 27317
		private int attrType_;

		// Token: 0x04006AB6 RID: 27318
		public const int AddTypeFieldNumber = 2;

		// Token: 0x04006AB7 RID: 27319
		private int addType_;

		// Token: 0x04006AB8 RID: 27320
		public const int UsageFieldNumber = 3;

		// Token: 0x04006AB9 RID: 27321
		private int usage_;
	}
}
