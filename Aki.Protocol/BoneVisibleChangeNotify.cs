using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001BE RID: 446
	[NetMessage(EMessageId.BoneVisibleChangeNotify)]
	public sealed class BoneVisibleChangeNotify : IMessage<BoneVisibleChangeNotify>, IMessage, IEquatable<BoneVisibleChangeNotify>, IDeepCloneable<BoneVisibleChangeNotify>, IBufferMessage
	{
		// Token: 0x060033B3 RID: 13235 RVA: 0x0008313D File Offset: 0x0008133D
		[NullableContext(1)]
		public static BoneVisibleChangeNotify Create()
		{
			return new BoneVisibleChangeNotify();
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x060033B4 RID: 13236 RVA: 0x00083144 File Offset: 0x00081344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x060033B5 RID: 13237 RVA: 0x00083147 File Offset: 0x00081347
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BoneVisibleChangeNotify.Descriptor;
			}
		}

		// Token: 0x060033B6 RID: 13238 RVA: 0x0008314E File Offset: 0x0008134E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoneVisibleChangeNotify()
		{
		}

		// Token: 0x060033B7 RID: 13239 RVA: 0x00083156 File Offset: 0x00081356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoneVisibleChangeNotify(BoneVisibleChangeNotify other) : this()
		{
			this.boneVisibleData_ = ((other.boneVisibleData_ != null) ? other.boneVisibleData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060033B8 RID: 13240 RVA: 0x0008318B File Offset: 0x0008138B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoneVisibleChangeNotify Clone()
		{
			return new BoneVisibleChangeNotify(this);
		}

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x060033B9 RID: 13241 RVA: 0x00083193 File Offset: 0x00081393
		// (set) Token: 0x060033BA RID: 13242 RVA: 0x0008319B File Offset: 0x0008139B
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

		// Token: 0x060033BB RID: 13243 RVA: 0x000831A4 File Offset: 0x000813A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BoneVisibleChangeNotify);
		}

		// Token: 0x060033BC RID: 13244 RVA: 0x000831B2 File Offset: 0x000813B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BoneVisibleChangeNotify other)
		{
			return other != null && (other == this || (object.Equals(this.BoneVisibleData, other.BoneVisibleData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060033BD RID: 13245 RVA: 0x000831E8 File Offset: 0x000813E8
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

		// Token: 0x060033BE RID: 13246 RVA: 0x00083224 File Offset: 0x00081424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060033BF RID: 13247 RVA: 0x00083231 File Offset: 0x00081431
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060033C0 RID: 13248 RVA: 0x0008323A File Offset: 0x0008143A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.boneVisibleData_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.BoneVisibleData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060033C1 RID: 13249 RVA: 0x0008326C File Offset: 0x0008146C
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

		// Token: 0x060033C2 RID: 13250 RVA: 0x000832AC File Offset: 0x000814AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BoneVisibleChangeNotify other)
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

		// Token: 0x060033C3 RID: 13251 RVA: 0x00083300 File Offset: 0x00081500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060033C4 RID: 13252 RVA: 0x0008330C File Offset: 0x0008150C
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
				if (num != 34U)
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

		// Token: 0x04002A27 RID: 10791
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A28 RID: 10792
		public const int BoneVisibleDataFieldNumber = 4;

		// Token: 0x04002A29 RID: 10793
		private BoneVisibleData boneVisibleData_;
	}
}
