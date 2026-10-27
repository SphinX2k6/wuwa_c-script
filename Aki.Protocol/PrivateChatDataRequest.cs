using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DDC RID: 3548
	[NetMessage(EMessageId.PrivateChatDataRequest)]
	public sealed class PrivateChatDataRequest : IMessage<PrivateChatDataRequest>, IMessage, IEquatable<PrivateChatDataRequest>, IDeepCloneable<PrivateChatDataRequest>, IBufferMessage
	{
		// Token: 0x0601317D RID: 78205 RVA: 0x002C8275 File Offset: 0x002C6475
		[NullableContext(1)]
		public static PrivateChatDataRequest Create()
		{
			return new PrivateChatDataRequest();
		}

		// Token: 0x17003F58 RID: 16216
		// (get) Token: 0x0601317E RID: 78206 RVA: 0x002C827C File Offset: 0x002C647C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F59 RID: 16217
		// (get) Token: 0x0601317F RID: 78207 RVA: 0x002C827F File Offset: 0x002C647F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PrivateChatDataRequest.Descriptor;
			}
		}

		// Token: 0x06013180 RID: 78208 RVA: 0x002C8286 File Offset: 0x002C6486
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatDataRequest()
		{
		}

		// Token: 0x06013181 RID: 78209 RVA: 0x002C828E File Offset: 0x002C648E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatDataRequest(PrivateChatDataRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013182 RID: 78210 RVA: 0x002C82A7 File Offset: 0x002C64A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatDataRequest Clone()
		{
			return new PrivateChatDataRequest(this);
		}

		// Token: 0x06013183 RID: 78211 RVA: 0x002C82AF File Offset: 0x002C64AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PrivateChatDataRequest);
		}

		// Token: 0x06013184 RID: 78212 RVA: 0x002C82BD File Offset: 0x002C64BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PrivateChatDataRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06013185 RID: 78213 RVA: 0x002C82DC File Offset: 0x002C64DC
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

		// Token: 0x06013186 RID: 78214 RVA: 0x002C8302 File Offset: 0x002C6502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013187 RID: 78215 RVA: 0x002C830F File Offset: 0x002C650F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013188 RID: 78216 RVA: 0x002C8318 File Offset: 0x002C6518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013189 RID: 78217 RVA: 0x002C8330 File Offset: 0x002C6530
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

		// Token: 0x0601318A RID: 78218 RVA: 0x002C8356 File Offset: 0x002C6556
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PrivateChatDataRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601318B RID: 78219 RVA: 0x002C8373 File Offset: 0x002C6573
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601318C RID: 78220 RVA: 0x002C837C File Offset: 0x002C657C
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

		// Token: 0x040075BC RID: 30140
		private UnknownFieldSet _unknownFields;
	}
}
