using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000439 RID: 1081
	[NetMessage(EMessageId.EnterBigWorldInstRequest)]
	public sealed class EnterBigWorldInstRequest : IMessage<EnterBigWorldInstRequest>, IMessage, IEquatable<EnterBigWorldInstRequest>, IDeepCloneable<EnterBigWorldInstRequest>, IBufferMessage
	{
		// Token: 0x060067DB RID: 26587 RVA: 0x000F9C12 File Offset: 0x000F7E12
		[NullableContext(1)]
		public static EnterBigWorldInstRequest Create()
		{
			return new EnterBigWorldInstRequest();
		}

		// Token: 0x17001387 RID: 4999
		// (get) Token: 0x060067DC RID: 26588 RVA: 0x000F9C19 File Offset: 0x000F7E19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001388 RID: 5000
		// (get) Token: 0x060067DD RID: 26589 RVA: 0x000F9C1C File Offset: 0x000F7E1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterBigWorldInstRequest.Descriptor;
			}
		}

		// Token: 0x060067DE RID: 26590 RVA: 0x000F9C23 File Offset: 0x000F7E23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterBigWorldInstRequest()
		{
		}

		// Token: 0x060067DF RID: 26591 RVA: 0x000F9C2B File Offset: 0x000F7E2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterBigWorldInstRequest(EnterBigWorldInstRequest other) : this()
		{
			this.enterBigWorldInstContext_ = ((other.enterBigWorldInstContext_ != null) ? other.enterBigWorldInstContext_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060067E0 RID: 26592 RVA: 0x000F9C60 File Offset: 0x000F7E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterBigWorldInstRequest Clone()
		{
			return new EnterBigWorldInstRequest(this);
		}

		// Token: 0x17001389 RID: 5001
		// (get) Token: 0x060067E1 RID: 26593 RVA: 0x000F9C68 File Offset: 0x000F7E68
		// (set) Token: 0x060067E2 RID: 26594 RVA: 0x000F9C70 File Offset: 0x000F7E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterBigWorldInstContext EnterBigWorldInstContext
		{
			get
			{
				return this.enterBigWorldInstContext_;
			}
			set
			{
				this.enterBigWorldInstContext_ = value;
			}
		}

		// Token: 0x060067E3 RID: 26595 RVA: 0x000F9C79 File Offset: 0x000F7E79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterBigWorldInstRequest);
		}

		// Token: 0x060067E4 RID: 26596 RVA: 0x000F9C87 File Offset: 0x000F7E87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterBigWorldInstRequest other)
		{
			return other != null && (other == this || (object.Equals(this.EnterBigWorldInstContext, other.EnterBigWorldInstContext) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060067E5 RID: 26597 RVA: 0x000F9CBC File Offset: 0x000F7EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.enterBigWorldInstContext_ != null)
			{
				num ^= this.EnterBigWorldInstContext.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060067E6 RID: 26598 RVA: 0x000F9CF8 File Offset: 0x000F7EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060067E7 RID: 26599 RVA: 0x000F9D05 File Offset: 0x000F7F05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060067E8 RID: 26600 RVA: 0x000F9D0E File Offset: 0x000F7F0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.enterBigWorldInstContext_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.EnterBigWorldInstContext);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060067E9 RID: 26601 RVA: 0x000F9D40 File Offset: 0x000F7F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.enterBigWorldInstContext_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EnterBigWorldInstContext);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060067EA RID: 26602 RVA: 0x000F9D80 File Offset: 0x000F7F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterBigWorldInstRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.enterBigWorldInstContext_ != null)
			{
				if (this.enterBigWorldInstContext_ == null)
				{
					this.EnterBigWorldInstContext = new EnterBigWorldInstContext();
				}
				this.EnterBigWorldInstContext.MergeFrom(other.EnterBigWorldInstContext);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060067EB RID: 26603 RVA: 0x000F9DD4 File Offset: 0x000F7FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060067EC RID: 26604 RVA: 0x000F9DE0 File Offset: 0x000F7FE0
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
					if (this.enterBigWorldInstContext_ == null)
					{
						this.EnterBigWorldInstContext = new EnterBigWorldInstContext();
					}
					input.ReadMessage(this.EnterBigWorldInstContext);
				}
			}
		}

		// Token: 0x040039E0 RID: 14816
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039E1 RID: 14817
		public const int EnterBigWorldInstContextFieldNumber = 10;

		// Token: 0x040039E2 RID: 14818
		private EnterBigWorldInstContext enterBigWorldInstContext_;
	}
}
