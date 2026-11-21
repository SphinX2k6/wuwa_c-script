using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000241 RID: 577
	[NetMessage(EMessageId.CaughtNotify)]
	public sealed class CaughtNotify : IMessage<CaughtNotify>, IMessage, IEquatable<CaughtNotify>, IDeepCloneable<CaughtNotify>, IBufferMessage
	{
		// Token: 0x06003E46 RID: 15942 RVA: 0x0009A578 File Offset: 0x00098778
		[NullableContext(1)]
		public static CaughtNotify Create()
		{
			return new CaughtNotify();
		}

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x06003E47 RID: 15943 RVA: 0x0009A57F File Offset: 0x0009877F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x06003E48 RID: 15944 RVA: 0x0009A582 File Offset: 0x00098782
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CaughtNotify.Descriptor;
			}
		}

		// Token: 0x06003E49 RID: 15945 RVA: 0x0009A589 File Offset: 0x00098789
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaughtNotify()
		{
		}

		// Token: 0x06003E4A RID: 15946 RVA: 0x0009A591 File Offset: 0x00098791
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaughtNotify(CaughtNotify other) : this()
		{
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003E4B RID: 15947 RVA: 0x0009A5C6 File Offset: 0x000987C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaughtNotify Clone()
		{
			return new CaughtNotify(this);
		}

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x06003E4C RID: 15948 RVA: 0x0009A5CE File Offset: 0x000987CE
		// (set) Token: 0x06003E4D RID: 15949 RVA: 0x0009A5D6 File Offset: 0x000987D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaughtInfo Info
		{
			get
			{
				return this.info_;
			}
			set
			{
				this.info_ = value;
			}
		}

		// Token: 0x06003E4E RID: 15950 RVA: 0x0009A5DF File Offset: 0x000987DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CaughtNotify);
		}

		// Token: 0x06003E4F RID: 15951 RVA: 0x0009A5ED File Offset: 0x000987ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CaughtNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Info, other.Info) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003E50 RID: 15952 RVA: 0x0009A620 File Offset: 0x00098820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.info_ != null)
			{
				num ^= this.Info.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003E51 RID: 15953 RVA: 0x0009A65C File Offset: 0x0009885C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003E52 RID: 15954 RVA: 0x0009A669 File Offset: 0x00098869
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003E53 RID: 15955 RVA: 0x0009A672 File Offset: 0x00098872
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.info_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.Info);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003E54 RID: 15956 RVA: 0x0009A6A4 File Offset: 0x000988A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.info_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Info);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003E55 RID: 15957 RVA: 0x0009A6E4 File Offset: 0x000988E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CaughtNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.info_ != null)
			{
				if (this.info_ == null)
				{
					this.Info = new CaughtInfo();
				}
				this.Info.MergeFrom(other.Info);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003E56 RID: 15958 RVA: 0x0009A738 File Offset: 0x00098938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003E57 RID: 15959 RVA: 0x0009A744 File Offset: 0x00098944
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
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.info_ == null)
					{
						this.Info = new CaughtInfo();
					}
					input.ReadMessage(this.Info);
				}
			}
		}

		// Token: 0x04002D3C RID: 11580
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D3D RID: 11581
		public const int InfoFieldNumber = 9;

		// Token: 0x04002D3E RID: 11582
		private CaughtInfo info_;
	}
}
