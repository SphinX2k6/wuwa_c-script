using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000D0 RID: 208
	[NetMessage(EMessageId.AdviceSetRequest)]
	public sealed class AdviceSetRequest : IMessage<AdviceSetRequest>, IMessage, IEquatable<AdviceSetRequest>, IDeepCloneable<AdviceSetRequest>, IBufferMessage
	{
		// Token: 0x06002035 RID: 8245 RVA: 0x00057483 File Offset: 0x00055683
		[NullableContext(1)]
		public static AdviceSetRequest Create()
		{
			return new AdviceSetRequest();
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06002036 RID: 8246 RVA: 0x0005748A File Offset: 0x0005568A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06002037 RID: 8247 RVA: 0x0005748D File Offset: 0x0005568D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdviceSetRequest.Descriptor;
			}
		}

		// Token: 0x06002038 RID: 8248 RVA: 0x00057494 File Offset: 0x00055694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceSetRequest()
		{
		}

		// Token: 0x06002039 RID: 8249 RVA: 0x0005749C File Offset: 0x0005569C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceSetRequest(AdviceSetRequest other) : this()
		{
			this.isShow_ = other.isShow_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600203A RID: 8250 RVA: 0x000574C1 File Offset: 0x000556C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceSetRequest Clone()
		{
			return new AdviceSetRequest(this);
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x0600203B RID: 8251 RVA: 0x000574C9 File Offset: 0x000556C9
		// (set) Token: 0x0600203C RID: 8252 RVA: 0x000574D1 File Offset: 0x000556D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsShow
		{
			get
			{
				return this.isShow_;
			}
			set
			{
				this.isShow_ = value;
			}
		}

		// Token: 0x0600203D RID: 8253 RVA: 0x000574DA File Offset: 0x000556DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdviceSetRequest);
		}

		// Token: 0x0600203E RID: 8254 RVA: 0x000574E8 File Offset: 0x000556E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdviceSetRequest other)
		{
			return other != null && (other == this || (this.IsShow == other.IsShow && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600203F RID: 8255 RVA: 0x00057518 File Offset: 0x00055718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsShow)
			{
				num ^= this.IsShow.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002040 RID: 8256 RVA: 0x00057557 File Offset: 0x00055757
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002041 RID: 8257 RVA: 0x00057564 File Offset: 0x00055764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002042 RID: 8258 RVA: 0x0005756D File Offset: 0x0005576D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsShow)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.IsShow);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002043 RID: 8259 RVA: 0x000575A0 File Offset: 0x000557A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsShow)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002044 RID: 8260 RVA: 0x000575D2 File Offset: 0x000557D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AdviceSetRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsShow)
			{
				this.IsShow = other.IsShow;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002045 RID: 8261 RVA: 0x00057603 File Offset: 0x00055803
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002046 RID: 8262 RVA: 0x0005760C File Offset: 0x0005580C
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.IsShow = input.ReadBool();
				}
			}
		}

		// Token: 0x0400243C RID: 9276
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400243D RID: 9277
		public const int IsShowFieldNumber = 10;

		// Token: 0x0400243E RID: 9278
		private bool isShow_;
	}
}
