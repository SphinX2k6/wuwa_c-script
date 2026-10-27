using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000688 RID: 1672
	[NetMessage(EMessageId.GachaAccumulateInfoNotify)]
	public sealed class GachaAccumulateInfoNotify : IMessage<GachaAccumulateInfoNotify>, IMessage, IEquatable<GachaAccumulateInfoNotify>, IDeepCloneable<GachaAccumulateInfoNotify>, IBufferMessage
	{
		// Token: 0x0600990F RID: 39183 RVA: 0x00170B16 File Offset: 0x0016ED16
		[NullableContext(1)]
		public static GachaAccumulateInfoNotify Create()
		{
			return new GachaAccumulateInfoNotify();
		}

		// Token: 0x17001E82 RID: 7810
		// (get) Token: 0x06009910 RID: 39184 RVA: 0x00170B1D File Offset: 0x0016ED1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E83 RID: 7811
		// (get) Token: 0x06009911 RID: 39185 RVA: 0x00170B20 File Offset: 0x0016ED20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaAccumulateInfoNotify.Descriptor;
			}
		}

		// Token: 0x06009912 RID: 39186 RVA: 0x00170B27 File Offset: 0x0016ED27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateInfoNotify()
		{
		}

		// Token: 0x06009913 RID: 39187 RVA: 0x00170B2F File Offset: 0x0016ED2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateInfoNotify(GachaAccumulateInfoNotify other) : this()
		{
			this.gachaAccumulateInfo_ = ((other.gachaAccumulateInfo_ != null) ? other.gachaAccumulateInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009914 RID: 39188 RVA: 0x00170B64 File Offset: 0x0016ED64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateInfoNotify Clone()
		{
			return new GachaAccumulateInfoNotify(this);
		}

		// Token: 0x17001E84 RID: 7812
		// (get) Token: 0x06009915 RID: 39189 RVA: 0x00170B6C File Offset: 0x0016ED6C
		// (set) Token: 0x06009916 RID: 39190 RVA: 0x00170B74 File Offset: 0x0016ED74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateInfo GachaAccumulateInfo
		{
			get
			{
				return this.gachaAccumulateInfo_;
			}
			set
			{
				this.gachaAccumulateInfo_ = value;
			}
		}

		// Token: 0x06009917 RID: 39191 RVA: 0x00170B7D File Offset: 0x0016ED7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaAccumulateInfoNotify);
		}

		// Token: 0x06009918 RID: 39192 RVA: 0x00170B8B File Offset: 0x0016ED8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaAccumulateInfoNotify other)
		{
			return other != null && (other == this || (object.Equals(this.GachaAccumulateInfo, other.GachaAccumulateInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009919 RID: 39193 RVA: 0x00170BC0 File Offset: 0x0016EDC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.gachaAccumulateInfo_ != null)
			{
				num ^= this.GachaAccumulateInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600991A RID: 39194 RVA: 0x00170BFC File Offset: 0x0016EDFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600991B RID: 39195 RVA: 0x00170C09 File Offset: 0x0016EE09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600991C RID: 39196 RVA: 0x00170C12 File Offset: 0x0016EE12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.gachaAccumulateInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.GachaAccumulateInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600991D RID: 39197 RVA: 0x00170C44 File Offset: 0x0016EE44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.gachaAccumulateInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GachaAccumulateInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600991E RID: 39198 RVA: 0x00170C84 File Offset: 0x0016EE84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaAccumulateInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.gachaAccumulateInfo_ != null)
			{
				if (this.gachaAccumulateInfo_ == null)
				{
					this.GachaAccumulateInfo = new GachaAccumulateInfo();
				}
				this.GachaAccumulateInfo.MergeFrom(other.GachaAccumulateInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600991F RID: 39199 RVA: 0x00170CD8 File Offset: 0x0016EED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009920 RID: 39200 RVA: 0x00170CE4 File Offset: 0x0016EEE4
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.gachaAccumulateInfo_ == null)
					{
						this.GachaAccumulateInfo = new GachaAccumulateInfo();
					}
					input.ReadMessage(this.GachaAccumulateInfo);
				}
			}
		}

		// Token: 0x04004874 RID: 18548
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004875 RID: 18549
		public const int GachaAccumulateInfoFieldNumber = 10;

		// Token: 0x04004876 RID: 18550
		private GachaAccumulateInfo gachaAccumulateInfo_;
	}
}
