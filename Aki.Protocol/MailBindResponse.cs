using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000962 RID: 2402
	[NetMessage(EMessageId.MailBindResponse)]
	public sealed class MailBindResponse : IMessage<MailBindResponse>, IMessage, IEquatable<MailBindResponse>, IDeepCloneable<MailBindResponse>, IBufferMessage
	{
		// Token: 0x0600D3CE RID: 54222 RVA: 0x001F34D2 File Offset: 0x001F16D2
		[NullableContext(1)]
		public static MailBindResponse Create()
		{
			return new MailBindResponse();
		}

		// Token: 0x17002ADE RID: 10974
		// (get) Token: 0x0600D3CF RID: 54223 RVA: 0x001F34D9 File Offset: 0x001F16D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002ADF RID: 10975
		// (get) Token: 0x0600D3D0 RID: 54224 RVA: 0x001F34DC File Offset: 0x001F16DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MailBindResponse.Descriptor;
			}
		}

		// Token: 0x0600D3D1 RID: 54225 RVA: 0x001F34E3 File Offset: 0x001F16E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindResponse()
		{
		}

		// Token: 0x0600D3D2 RID: 54226 RVA: 0x001F34EB File Offset: 0x001F16EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindResponse(MailBindResponse other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D3D3 RID: 54227 RVA: 0x001F3504 File Offset: 0x001F1704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindResponse Clone()
		{
			return new MailBindResponse(this);
		}

		// Token: 0x0600D3D4 RID: 54228 RVA: 0x001F350C File Offset: 0x001F170C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MailBindResponse);
		}

		// Token: 0x0600D3D5 RID: 54229 RVA: 0x001F351A File Offset: 0x001F171A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MailBindResponse other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600D3D6 RID: 54230 RVA: 0x001F3538 File Offset: 0x001F1738
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

		// Token: 0x0600D3D7 RID: 54231 RVA: 0x001F355E File Offset: 0x001F175E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D3D8 RID: 54232 RVA: 0x001F356B File Offset: 0x001F176B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D3D9 RID: 54233 RVA: 0x001F3574 File Offset: 0x001F1774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D3DA RID: 54234 RVA: 0x001F358C File Offset: 0x001F178C
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

		// Token: 0x0600D3DB RID: 54235 RVA: 0x001F35B2 File Offset: 0x001F17B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MailBindResponse other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D3DC RID: 54236 RVA: 0x001F35CF File Offset: 0x001F17CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D3DD RID: 54237 RVA: 0x001F35D8 File Offset: 0x001F17D8
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

		// Token: 0x04005944 RID: 22852
		private UnknownFieldSet _unknownFields;
	}
}
