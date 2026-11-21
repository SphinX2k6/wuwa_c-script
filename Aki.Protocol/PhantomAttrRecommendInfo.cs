using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C07 RID: 3079
	public sealed class PhantomAttrRecommendInfo : IMessage<PhantomAttrRecommendInfo>, IMessage, IEquatable<PhantomAttrRecommendInfo>, IDeepCloneable<PhantomAttrRecommendInfo>, IBufferMessage
	{
		// Token: 0x06010BD1 RID: 68561 RVA: 0x002741B8 File Offset: 0x002723B8
		[NullableContext(1)]
		public static PhantomAttrRecommendInfo Create()
		{
			return new PhantomAttrRecommendInfo();
		}

		// Token: 0x1700373E RID: 14142
		// (get) Token: 0x06010BD2 RID: 68562 RVA: 0x002741BF File Offset: 0x002723BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomAttrRecommendInfo> Parser
		{
			get
			{
				return PhantomAttrRecommendInfo._parser;
			}
		}

		// Token: 0x1700373F RID: 14143
		// (get) Token: 0x06010BD3 RID: 68563 RVA: 0x002741C6 File Offset: 0x002723C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003740 RID: 14144
		// (get) Token: 0x06010BD4 RID: 68564 RVA: 0x002741C9 File Offset: 0x002723C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomAttrRecommendInfo.Descriptor;
			}
		}

		// Token: 0x06010BD5 RID: 68565 RVA: 0x002741D0 File Offset: 0x002723D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomAttrRecommendInfo()
		{
		}

		// Token: 0x06010BD6 RID: 68566 RVA: 0x002741D8 File Offset: 0x002723D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomAttrRecommendInfo(PhantomAttrRecommendInfo other) : this()
		{
			this.attrType_ = other.attrType_;
			this.addType_ = other.addType_;
			this.usage_ = other.usage_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010BD7 RID: 68567 RVA: 0x00274215 File Offset: 0x00272415
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomAttrRecommendInfo Clone()
		{
			return new PhantomAttrRecommendInfo(this);
		}

		// Token: 0x17003741 RID: 14145
		// (get) Token: 0x06010BD8 RID: 68568 RVA: 0x0027421D File Offset: 0x0027241D
		// (set) Token: 0x06010BD9 RID: 68569 RVA: 0x00274225 File Offset: 0x00272425
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

		// Token: 0x17003742 RID: 14146
		// (get) Token: 0x06010BDA RID: 68570 RVA: 0x0027422E File Offset: 0x0027242E
		// (set) Token: 0x06010BDB RID: 68571 RVA: 0x00274236 File Offset: 0x00272436
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

		// Token: 0x17003743 RID: 14147
		// (get) Token: 0x06010BDC RID: 68572 RVA: 0x0027423F File Offset: 0x0027243F
		// (set) Token: 0x06010BDD RID: 68573 RVA: 0x00274247 File Offset: 0x00272447
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

		// Token: 0x06010BDE RID: 68574 RVA: 0x00274250 File Offset: 0x00272450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomAttrRecommendInfo);
		}

		// Token: 0x06010BDF RID: 68575 RVA: 0x00274260 File Offset: 0x00272460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomAttrRecommendInfo other)
		{
			return other != null && (other == this || (this.AttrType == other.AttrType && this.AddType == other.AddType && this.Usage == other.Usage && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010BE0 RID: 68576 RVA: 0x002742BC File Offset: 0x002724BC
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

		// Token: 0x06010BE1 RID: 68577 RVA: 0x0027432D File Offset: 0x0027252D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010BE2 RID: 68578 RVA: 0x0027433A File Offset: 0x0027253A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010BE3 RID: 68579 RVA: 0x00274344 File Offset: 0x00272544
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

		// Token: 0x06010BE4 RID: 68580 RVA: 0x002743B8 File Offset: 0x002725B8
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

		// Token: 0x06010BE5 RID: 68581 RVA: 0x00274428 File Offset: 0x00272628
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

		// Token: 0x06010BE6 RID: 68582 RVA: 0x0027448C File Offset: 0x0027268C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010BE7 RID: 68583 RVA: 0x00274498 File Offset: 0x00272698
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

		// Token: 0x04006AC6 RID: 27334
		private static readonly MessageParser<PhantomAttrRecommendInfo> _parser = new MessageParser<PhantomAttrRecommendInfo>(() => new PhantomAttrRecommendInfo());

		// Token: 0x04006AC7 RID: 27335
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006AC8 RID: 27336
		public const int AttrTypeFieldNumber = 1;

		// Token: 0x04006AC9 RID: 27337
		private int attrType_;

		// Token: 0x04006ACA RID: 27338
		public const int AddTypeFieldNumber = 2;

		// Token: 0x04006ACB RID: 27339
		private int addType_;

		// Token: 0x04006ACC RID: 27340
		public const int UsageFieldNumber = 3;

		// Token: 0x04006ACD RID: 27341
		private int usage_;
	}
}
