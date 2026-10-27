using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001BB RID: 443
	[NetMessage(EMessageId.BoneVisibleChangePush)]
	public sealed class BoneVisibleChangePush : IMessage<BoneVisibleChangePush>, IMessage, IEquatable<BoneVisibleChangePush>, IDeepCloneable<BoneVisibleChangePush>, IBufferMessage
	{
		// Token: 0x06003338 RID: 13112 RVA: 0x00081BF4 File Offset: 0x0007FDF4
		[NullableContext(1)]
		public static BoneVisibleChangePush Create()
		{
			return new BoneVisibleChangePush();
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x06003339 RID: 13113 RVA: 0x00081BFB File Offset: 0x0007FDFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x0600333A RID: 13114 RVA: 0x00081BFE File Offset: 0x0007FDFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BoneVisibleChangePush.Descriptor;
			}
		}

		// Token: 0x0600333B RID: 13115 RVA: 0x00081C05 File Offset: 0x0007FE05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoneVisibleChangePush()
		{
		}

		// Token: 0x0600333C RID: 13116 RVA: 0x00081C0D File Offset: 0x0007FE0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoneVisibleChangePush(BoneVisibleChangePush other) : this()
		{
			this.boneVisibleData_ = ((other.boneVisibleData_ != null) ? other.boneVisibleData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600333D RID: 13117 RVA: 0x00081C42 File Offset: 0x0007FE42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoneVisibleChangePush Clone()
		{
			return new BoneVisibleChangePush(this);
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x0600333E RID: 13118 RVA: 0x00081C4A File Offset: 0x0007FE4A
		// (set) Token: 0x0600333F RID: 13119 RVA: 0x00081C52 File Offset: 0x0007FE52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoneVisibleData BoneVisibleData
		{
			get
			{
				return this.boneVisibleData_;
			}
			set
			{
				this.boneVisibleData_ = value;
			}
		}

		// Token: 0x06003340 RID: 13120 RVA: 0x00081C5B File Offset: 0x0007FE5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BoneVisibleChangePush);
		}

		// Token: 0x06003341 RID: 13121 RVA: 0x00081C69 File Offset: 0x0007FE69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BoneVisibleChangePush other)
		{
			return other != null && (other == this || (object.Equals(this.BoneVisibleData, other.BoneVisibleData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003342 RID: 13122 RVA: 0x00081C9C File Offset: 0x0007FE9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.boneVisibleData_ != null)
			{
				num ^= this.BoneVisibleData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003343 RID: 13123 RVA: 0x00081CD8 File Offset: 0x0007FED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003344 RID: 13124 RVA: 0x00081CE5 File Offset: 0x0007FEE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003345 RID: 13125 RVA: 0x00081CEE File Offset: 0x0007FEEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.boneVisibleData_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.BoneVisibleData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003346 RID: 13126 RVA: 0x00081D20 File Offset: 0x0007FF20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.boneVisibleData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BoneVisibleData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003347 RID: 13127 RVA: 0x00081D60 File Offset: 0x0007FF60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BoneVisibleChangePush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.boneVisibleData_ != null)
			{
				if (this.boneVisibleData_ == null)
				{
					this.BoneVisibleData = new BoneVisibleData();
				}
				this.BoneVisibleData.MergeFrom(other.BoneVisibleData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003348 RID: 13128 RVA: 0x00081DB4 File Offset: 0x0007FFB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003349 RID: 13129 RVA: 0x00081DC0 File Offset: 0x0007FFC0
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.boneVisibleData_ == null)
					{
						this.BoneVisibleData = new BoneVisibleData();
					}
					input.ReadMessage(this.BoneVisibleData);
				}
			}
		}

		// Token: 0x040029AF RID: 10671
		private UnknownFieldSet _unknownFields;

		// Token: 0x040029B0 RID: 10672
		public const int BoneVisibleDataFieldNumber = 13;

		// Token: 0x040029B1 RID: 10673
		private BoneVisibleData boneVisibleData_;
	}
}
