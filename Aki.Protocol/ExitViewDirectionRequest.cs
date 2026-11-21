using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004D7 RID: 1239
	[NetMessage(EMessageId.ExitViewDirectionRequest)]
	public sealed class ExitViewDirectionRequest : IMessage<ExitViewDirectionRequest>, IMessage, IEquatable<ExitViewDirectionRequest>, IDeepCloneable<ExitViewDirectionRequest>, IBufferMessage
	{
		// Token: 0x060075C9 RID: 30153 RVA: 0x00120346 File Offset: 0x0011E546
		[NullableContext(1)]
		public static ExitViewDirectionRequest Create()
		{
			return new ExitViewDirectionRequest();
		}

		// Token: 0x170016CF RID: 5839
		// (get) Token: 0x060075CA RID: 30154 RVA: 0x0012034D File Offset: 0x0011E54D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016D0 RID: 5840
		// (get) Token: 0x060075CB RID: 30155 RVA: 0x00120350 File Offset: 0x0011E550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExitViewDirectionRequest.Descriptor;
			}
		}

		// Token: 0x060075CC RID: 30156 RVA: 0x00120357 File Offset: 0x0011E557
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExitViewDirectionRequest()
		{
		}

		// Token: 0x060075CD RID: 30157 RVA: 0x0012035F File Offset: 0x0011E55F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExitViewDirectionRequest(ExitViewDirectionRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060075CE RID: 30158 RVA: 0x00120378 File Offset: 0x0011E578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExitViewDirectionRequest Clone()
		{
			return new ExitViewDirectionRequest(this);
		}

		// Token: 0x060075CF RID: 30159 RVA: 0x00120380 File Offset: 0x0011E580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExitViewDirectionRequest);
		}

		// Token: 0x060075D0 RID: 30160 RVA: 0x0012038E File Offset: 0x0011E58E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExitViewDirectionRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060075D1 RID: 30161 RVA: 0x001203AC File Offset: 0x0011E5AC
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

		// Token: 0x060075D2 RID: 30162 RVA: 0x001203D2 File Offset: 0x0011E5D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060075D3 RID: 30163 RVA: 0x001203DF File Offset: 0x0011E5DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060075D4 RID: 30164 RVA: 0x001203E8 File Offset: 0x0011E5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060075D5 RID: 30165 RVA: 0x00120400 File Offset: 0x0011E600
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

		// Token: 0x060075D6 RID: 30166 RVA: 0x00120426 File Offset: 0x0011E626
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExitViewDirectionRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060075D7 RID: 30167 RVA: 0x00120443 File Offset: 0x0011E643
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060075D8 RID: 30168 RVA: 0x0012044C File Offset: 0x0011E64C
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

		// Token: 0x04003E15 RID: 15893
		private UnknownFieldSet _unknownFields;
	}
}
