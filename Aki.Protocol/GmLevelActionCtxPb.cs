using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006EB RID: 1771
	public sealed class GmLevelActionCtxPb : IMessage<GmLevelActionCtxPb>, IMessage, IEquatable<GmLevelActionCtxPb>, IDeepCloneable<GmLevelActionCtxPb>, IBufferMessage
	{
		// Token: 0x0600A1BE RID: 41406 RVA: 0x001877C9 File Offset: 0x001859C9
		[NullableContext(1)]
		public static GmLevelActionCtxPb Create()
		{
			return new GmLevelActionCtxPb();
		}

		// Token: 0x1700207E RID: 8318
		// (get) Token: 0x0600A1BF RID: 41407 RVA: 0x001877D0 File Offset: 0x001859D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700207F RID: 8319
		// (get) Token: 0x0600A1C0 RID: 41408 RVA: 0x001877D3 File Offset: 0x001859D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GmLevelActionCtxPb.Descriptor;
			}
		}

		// Token: 0x0600A1C1 RID: 41409 RVA: 0x001877DA File Offset: 0x001859DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmLevelActionCtxPb()
		{
		}

		// Token: 0x0600A1C2 RID: 41410 RVA: 0x001877ED File Offset: 0x001859ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmLevelActionCtxPb(GmLevelActionCtxPb other) : this()
		{
			this.jsonStr_ = other.jsonStr_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A1C3 RID: 41411 RVA: 0x00187812 File Offset: 0x00185A12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmLevelActionCtxPb Clone()
		{
			return new GmLevelActionCtxPb(this);
		}

		// Token: 0x17002080 RID: 8320
		// (get) Token: 0x0600A1C4 RID: 41412 RVA: 0x0018781A File Offset: 0x00185A1A
		// (set) Token: 0x0600A1C5 RID: 41413 RVA: 0x00187822 File Offset: 0x00185A22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string JsonStr
		{
			get
			{
				return this.jsonStr_;
			}
			set
			{
				this.jsonStr_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0600A1C6 RID: 41414 RVA: 0x00187835 File Offset: 0x00185A35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GmLevelActionCtxPb);
		}

		// Token: 0x0600A1C7 RID: 41415 RVA: 0x00187843 File Offset: 0x00185A43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GmLevelActionCtxPb other)
		{
			return other != null && (other == this || (!(this.JsonStr != other.JsonStr) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A1C8 RID: 41416 RVA: 0x00187878 File Offset: 0x00185A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.JsonStr.Length != 0)
			{
				num ^= this.JsonStr.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A1C9 RID: 41417 RVA: 0x001878B9 File Offset: 0x00185AB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A1CA RID: 41418 RVA: 0x001878C6 File Offset: 0x00185AC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A1CB RID: 41419 RVA: 0x001878CF File Offset: 0x00185ACF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.JsonStr.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.JsonStr);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A1CC RID: 41420 RVA: 0x00187908 File Offset: 0x00185B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.JsonStr.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.JsonStr);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A1CD RID: 41421 RVA: 0x0018794B File Offset: 0x00185B4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GmLevelActionCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.JsonStr.Length != 0)
			{
				this.JsonStr = other.JsonStr;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A1CE RID: 41422 RVA: 0x00187981 File Offset: 0x00185B81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A1CF RID: 41423 RVA: 0x0018798C File Offset: 0x00185B8C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.JsonStr = input.ReadString();
				}
			}
		}

		// Token: 0x04004B6C RID: 19308
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B6D RID: 19309
		public const int JsonStrFieldNumber = 1;

		// Token: 0x04004B6E RID: 19310
		private string jsonStr_ = "";
	}
}
