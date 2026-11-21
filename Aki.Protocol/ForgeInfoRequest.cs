using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200060B RID: 1547
	[NetMessage(EMessageId.ForgeInfoRequest)]
	public sealed class ForgeInfoRequest : IMessage<ForgeInfoRequest>, IMessage, IEquatable<ForgeInfoRequest>, IDeepCloneable<ForgeInfoRequest>, IBufferMessage
	{
		// Token: 0x06008F43 RID: 36675 RVA: 0x0015B5A4 File Offset: 0x001597A4
		[NullableContext(1)]
		public static ForgeInfoRequest Create()
		{
			return new ForgeInfoRequest();
		}

		// Token: 0x17001C6D RID: 7277
		// (get) Token: 0x06008F44 RID: 36676 RVA: 0x0015B5AB File Offset: 0x001597AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C6E RID: 7278
		// (get) Token: 0x06008F45 RID: 36677 RVA: 0x0015B5AE File Offset: 0x001597AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ForgeInfoRequest.Descriptor;
			}
		}

		// Token: 0x06008F46 RID: 36678 RVA: 0x0015B5B5 File Offset: 0x001597B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForgeInfoRequest()
		{
		}

		// Token: 0x06008F47 RID: 36679 RVA: 0x0015B5BD File Offset: 0x001597BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForgeInfoRequest(ForgeInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008F48 RID: 36680 RVA: 0x0015B5D6 File Offset: 0x001597D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForgeInfoRequest Clone()
		{
			return new ForgeInfoRequest(this);
		}

		// Token: 0x06008F49 RID: 36681 RVA: 0x0015B5DE File Offset: 0x001597DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ForgeInfoRequest);
		}

		// Token: 0x06008F4A RID: 36682 RVA: 0x0015B5EC File Offset: 0x001597EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ForgeInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06008F4B RID: 36683 RVA: 0x0015B60C File Offset: 0x0015980C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008F4C RID: 36684 RVA: 0x0015B632 File Offset: 0x00159832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008F4D RID: 36685 RVA: 0x0015B63F File Offset: 0x0015983F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008F4E RID: 36686 RVA: 0x0015B648 File Offset: 0x00159848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008F4F RID: 36687 RVA: 0x0015B660 File Offset: 0x00159860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008F50 RID: 36688 RVA: 0x0015B686 File Offset: 0x00159886
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ForgeInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008F51 RID: 36689 RVA: 0x0015B6A3 File Offset: 0x001598A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008F52 RID: 36690 RVA: 0x0015B6AC File Offset: 0x001598AC
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040045F1 RID: 17905
		private UnknownFieldSet _unknownFields;
	}
}
