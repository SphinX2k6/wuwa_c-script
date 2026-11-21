using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001C2 RID: 450
	public sealed class BoneVisibleData : IMessage<BoneVisibleData>, IMessage, IEquatable<BoneVisibleData>, IDeepCloneable<BoneVisibleData>, IBufferMessage
	{
		// Token: 0x060033FB RID: 13307 RVA: 0x0008398D File Offset: 0x00081B8D
		[NullableContext(1)]
		public static BoneVisibleData Create()
		{
			return new BoneVisibleData();
		}

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x060033FC RID: 13308 RVA: 0x00083994 File Offset: 0x00081B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BoneVisibleData> Parser
		{
			get
			{
				return BoneVisibleData._parser;
			}
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x060033FD RID: 13309 RVA: 0x0008399B File Offset: 0x00081B9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x060033FE RID: 13310 RVA: 0x0008399E File Offset: 0x00081B9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BoneVisibleData.Descriptor;
			}
		}

		// Token: 0x060033FF RID: 13311 RVA: 0x000839A5 File Offset: 0x00081BA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoneVisibleData()
		{
		}

		// Token: 0x06003400 RID: 13312 RVA: 0x000839B8 File Offset: 0x00081BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoneVisibleData(BoneVisibleData other) : this()
		{
			this.boneName_ = other.boneName_;
			this.visible_ = other.visible_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003401 RID: 13313 RVA: 0x000839E9 File Offset: 0x00081BE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoneVisibleData Clone()
		{
			return new BoneVisibleData(this);
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06003402 RID: 13314 RVA: 0x000839F1 File Offset: 0x00081BF1
		// (set) Token: 0x06003403 RID: 13315 RVA: 0x000839F9 File Offset: 0x00081BF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string BoneName
		{
			get
			{
				return this.boneName_;
			}
			set
			{
				this.boneName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06003404 RID: 13316 RVA: 0x00083A0C File Offset: 0x00081C0C
		// (set) Token: 0x06003405 RID: 13317 RVA: 0x00083A14 File Offset: 0x00081C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Visible
		{
			get
			{
				return this.visible_;
			}
			set
			{
				this.visible_ = value;
			}
		}

		// Token: 0x06003406 RID: 13318 RVA: 0x00083A1D File Offset: 0x00081C1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BoneVisibleData);
		}

		// Token: 0x06003407 RID: 13319 RVA: 0x00083A2C File Offset: 0x00081C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BoneVisibleData other)
		{
			return other != null && (other == this || (!(this.BoneName != other.BoneName) && this.Visible == other.Visible && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003408 RID: 13320 RVA: 0x00083A7C File Offset: 0x00081C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BoneName.Length != 0)
			{
				num ^= this.BoneName.GetHashCode();
			}
			if (this.Visible)
			{
				num ^= this.Visible.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003409 RID: 13321 RVA: 0x00083AD6 File Offset: 0x00081CD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600340A RID: 13322 RVA: 0x00083AE3 File Offset: 0x00081CE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600340B RID: 13323 RVA: 0x00083AEC File Offset: 0x00081CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BoneName.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.BoneName);
			}
			if (this.Visible)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Visible);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600340C RID: 13324 RVA: 0x00083B4C File Offset: 0x00081D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BoneName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.BoneName);
			}
			if (this.Visible)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600340D RID: 13325 RVA: 0x00083B9C File Offset: 0x00081D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BoneVisibleData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BoneName.Length != 0)
			{
				this.BoneName = other.BoneName;
			}
			if (other.Visible)
			{
				this.Visible = other.Visible;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600340E RID: 13326 RVA: 0x00083BF1 File Offset: 0x00081DF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600340F RID: 13327 RVA: 0x00083BFC File Offset: 0x00081DFC
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
				if (num != 10U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Visible = input.ReadBool();
					}
				}
				else
				{
					this.BoneName = input.ReadString();
				}
			}
		}

		// Token: 0x04002A33 RID: 10803
		private static readonly MessageParser<BoneVisibleData> _parser = new MessageParser<BoneVisibleData>(() => new BoneVisibleData());

		// Token: 0x04002A34 RID: 10804
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A35 RID: 10805
		public const int BoneNameFieldNumber = 1;

		// Token: 0x04002A36 RID: 10806
		private string boneName_ = "";

		// Token: 0x04002A37 RID: 10807
		public const int VisibleFieldNumber = 2;

		// Token: 0x04002A38 RID: 10808
		private bool visible_;
	}
}
