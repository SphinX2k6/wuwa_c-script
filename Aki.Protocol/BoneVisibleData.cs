using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001BE RID: 446
	public sealed class BoneVisibleData : IMessage<BoneVisibleData>, IMessage, IEquatable<BoneVisibleData>, IDeepCloneable<BoneVisibleData>, IBufferMessage
	{
		// Token: 0x0600336E RID: 13166 RVA: 0x0008221D File Offset: 0x0008041D
		[NullableContext(1)]
		public static BoneVisibleData Create()
		{
			return new BoneVisibleData();
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x0600336F RID: 13167 RVA: 0x00082224 File Offset: 0x00080424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BoneVisibleData> Parser
		{
			get
			{
				return BoneVisibleData._parser;
			}
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x06003370 RID: 13168 RVA: 0x0008222B File Offset: 0x0008042B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x06003371 RID: 13169 RVA: 0x0008222E File Offset: 0x0008042E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BoneVisibleData.Descriptor;
			}
		}

		// Token: 0x06003372 RID: 13170 RVA: 0x00082235 File Offset: 0x00080435
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoneVisibleData()
		{
		}

		// Token: 0x06003373 RID: 13171 RVA: 0x00082248 File Offset: 0x00080448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoneVisibleData(BoneVisibleData other) : this()
		{
			this.boneName_ = other.boneName_;
			this.visible_ = other.visible_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003374 RID: 13172 RVA: 0x00082279 File Offset: 0x00080479
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoneVisibleData Clone()
		{
			return new BoneVisibleData(this);
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x06003375 RID: 13173 RVA: 0x00082281 File Offset: 0x00080481
		// (set) Token: 0x06003376 RID: 13174 RVA: 0x00082289 File Offset: 0x00080489
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

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x06003377 RID: 13175 RVA: 0x0008229C File Offset: 0x0008049C
		// (set) Token: 0x06003378 RID: 13176 RVA: 0x000822A4 File Offset: 0x000804A4
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

		// Token: 0x06003379 RID: 13177 RVA: 0x000822AD File Offset: 0x000804AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BoneVisibleData);
		}

		// Token: 0x0600337A RID: 13178 RVA: 0x000822BC File Offset: 0x000804BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BoneVisibleData other)
		{
			return other != null && (other == this || (!(this.BoneName != other.BoneName) && this.Visible == other.Visible && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600337B RID: 13179 RVA: 0x0008230C File Offset: 0x0008050C
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

		// Token: 0x0600337C RID: 13180 RVA: 0x00082366 File Offset: 0x00080566
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600337D RID: 13181 RVA: 0x00082373 File Offset: 0x00080573
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600337E RID: 13182 RVA: 0x0008237C File Offset: 0x0008057C
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

		// Token: 0x0600337F RID: 13183 RVA: 0x000823DC File Offset: 0x000805DC
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

		// Token: 0x06003380 RID: 13184 RVA: 0x0008242C File Offset: 0x0008062C
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

		// Token: 0x06003381 RID: 13185 RVA: 0x00082481 File Offset: 0x00080681
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003382 RID: 13186 RVA: 0x0008248C File Offset: 0x0008068C
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

		// Token: 0x040029B8 RID: 10680
		private static readonly MessageParser<BoneVisibleData> _parser = new MessageParser<BoneVisibleData>(() => new BoneVisibleData());

		// Token: 0x040029B9 RID: 10681
		private UnknownFieldSet _unknownFields;

		// Token: 0x040029BA RID: 10682
		public const int BoneNameFieldNumber = 1;

		// Token: 0x040029BB RID: 10683
		private string boneName_ = "";

		// Token: 0x040029BC RID: 10684
		public const int VisibleFieldNumber = 2;

		// Token: 0x040029BD RID: 10685
		private bool visible_;
	}
}
