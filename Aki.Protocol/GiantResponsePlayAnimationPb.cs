using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006D0 RID: 1744
	public sealed class GiantResponsePlayAnimationPb : IMessage<GiantResponsePlayAnimationPb>, IMessage, IEquatable<GiantResponsePlayAnimationPb>, IDeepCloneable<GiantResponsePlayAnimationPb>, IBufferMessage
	{
		// Token: 0x06009FA0 RID: 40864 RVA: 0x001830EA File Offset: 0x001812EA
		[NullableContext(1)]
		public static GiantResponsePlayAnimationPb Create()
		{
			return new GiantResponsePlayAnimationPb();
		}

		// Token: 0x1700200D RID: 8205
		// (get) Token: 0x06009FA1 RID: 40865 RVA: 0x001830F1 File Offset: 0x001812F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700200E RID: 8206
		// (get) Token: 0x06009FA2 RID: 40866 RVA: 0x001830F4 File Offset: 0x001812F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiantResponsePlayAnimationPb.Descriptor;
			}
		}

		// Token: 0x06009FA3 RID: 40867 RVA: 0x001830FB File Offset: 0x001812FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantResponsePlayAnimationPb()
		{
		}

		// Token: 0x06009FA4 RID: 40868 RVA: 0x00183103 File Offset: 0x00181303
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantResponsePlayAnimationPb(GiantResponsePlayAnimationPb other) : this()
		{
			this.giantAnimationId_ = other.giantAnimationId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009FA5 RID: 40869 RVA: 0x00183128 File Offset: 0x00181328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantResponsePlayAnimationPb Clone()
		{
			return new GiantResponsePlayAnimationPb(this);
		}

		// Token: 0x1700200F RID: 8207
		// (get) Token: 0x06009FA6 RID: 40870 RVA: 0x00183130 File Offset: 0x00181330
		// (set) Token: 0x06009FA7 RID: 40871 RVA: 0x00183138 File Offset: 0x00181338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GiantAnimationId
		{
			get
			{
				return this.giantAnimationId_;
			}
			set
			{
				this.giantAnimationId_ = value;
			}
		}

		// Token: 0x06009FA8 RID: 40872 RVA: 0x00183141 File Offset: 0x00181341
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiantResponsePlayAnimationPb);
		}

		// Token: 0x06009FA9 RID: 40873 RVA: 0x0018314F File Offset: 0x0018134F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiantResponsePlayAnimationPb other)
		{
			return other != null && (other == this || (this.GiantAnimationId == other.GiantAnimationId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009FAA RID: 40874 RVA: 0x00183180 File Offset: 0x00181380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GiantAnimationId != 0)
			{
				num ^= this.GiantAnimationId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009FAB RID: 40875 RVA: 0x001831BF File Offset: 0x001813BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009FAC RID: 40876 RVA: 0x001831CC File Offset: 0x001813CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009FAD RID: 40877 RVA: 0x001831D5 File Offset: 0x001813D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GiantAnimationId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.GiantAnimationId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009FAE RID: 40878 RVA: 0x00183208 File Offset: 0x00181408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GiantAnimationId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GiantAnimationId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009FAF RID: 40879 RVA: 0x00183246 File Offset: 0x00181446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GiantResponsePlayAnimationPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GiantAnimationId != 0)
			{
				this.GiantAnimationId = other.GiantAnimationId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009FB0 RID: 40880 RVA: 0x00183277 File Offset: 0x00181477
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009FB1 RID: 40881 RVA: 0x00183280 File Offset: 0x00181480
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.GiantAnimationId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004AD1 RID: 19153
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AD2 RID: 19154
		public const int GiantAnimationIdFieldNumber = 1;

		// Token: 0x04004AD3 RID: 19155
		private int giantAnimationId_;
	}
}
