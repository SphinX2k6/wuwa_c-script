using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001BF RID: 447
	[NetMessage(EMessageId.BoneVisibleChangePush)]
	public sealed class BoneVisibleChangePush : IMessage<BoneVisibleChangePush>, IMessage, IEquatable<BoneVisibleChangePush>, IDeepCloneable<BoneVisibleChangePush>, IBufferMessage
	{
		// Token: 0x060033C5 RID: 13253 RVA: 0x00083364 File Offset: 0x00081564
		[NullableContext(1)]
		public static BoneVisibleChangePush Create()
		{
			return new BoneVisibleChangePush();
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x060033C6 RID: 13254 RVA: 0x0008336B File Offset: 0x0008156B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x060033C7 RID: 13255 RVA: 0x0008336E File Offset: 0x0008156E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BoneVisibleChangePush.Descriptor;
			}
		}

		// Token: 0x060033C8 RID: 13256 RVA: 0x00083375 File Offset: 0x00081575
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoneVisibleChangePush()
		{
		}

		// Token: 0x060033C9 RID: 13257 RVA: 0x0008337D File Offset: 0x0008157D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoneVisibleChangePush(BoneVisibleChangePush other) : this()
		{
			this.boneVisibleData_ = ((other.boneVisibleData_ != null) ? other.boneVisibleData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060033CA RID: 13258 RVA: 0x000833B2 File Offset: 0x000815B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoneVisibleChangePush Clone()
		{
			return new BoneVisibleChangePush(this);
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x060033CB RID: 13259 RVA: 0x000833BA File Offset: 0x000815BA
		// (set) Token: 0x060033CC RID: 13260 RVA: 0x000833C2 File Offset: 0x000815C2
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

		// Token: 0x060033CD RID: 13261 RVA: 0x000833CB File Offset: 0x000815CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BoneVisibleChangePush);
		}

		// Token: 0x060033CE RID: 13262 RVA: 0x000833D9 File Offset: 0x000815D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BoneVisibleChangePush other)
		{
			return other != null && (other == this || (object.Equals(this.BoneVisibleData, other.BoneVisibleData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060033CF RID: 13263 RVA: 0x0008340C File Offset: 0x0008160C
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

		// Token: 0x060033D0 RID: 13264 RVA: 0x00083448 File Offset: 0x00081648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060033D1 RID: 13265 RVA: 0x00083455 File Offset: 0x00081655
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060033D2 RID: 13266 RVA: 0x0008345E File Offset: 0x0008165E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.boneVisibleData_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.BoneVisibleData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060033D3 RID: 13267 RVA: 0x00083490 File Offset: 0x00081690
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

		// Token: 0x060033D4 RID: 13268 RVA: 0x000834D0 File Offset: 0x000816D0
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

		// Token: 0x060033D5 RID: 13269 RVA: 0x00083524 File Offset: 0x00081724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060033D6 RID: 13270 RVA: 0x00083530 File Offset: 0x00081730
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
				if (num != 26U)
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

		// Token: 0x04002A2A RID: 10794
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A2B RID: 10795
		public const int BoneVisibleDataFieldNumber = 3;

		// Token: 0x04002A2C RID: 10796
		private BoneVisibleData boneVisibleData_;
	}
}
