using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007FF RID: 2047
	[NetMessage(EMessageId.InputSettingRequest)]
	public sealed class InputSettingRequest : IMessage<InputSettingRequest>, IMessage, IEquatable<InputSettingRequest>, IDeepCloneable<InputSettingRequest>, IBufferMessage
	{
		// Token: 0x0600B788 RID: 46984 RVA: 0x001B5C49 File Offset: 0x001B3E49
		[NullableContext(1)]
		public static InputSettingRequest Create()
		{
			return new InputSettingRequest();
		}

		// Token: 0x170024F9 RID: 9465
		// (get) Token: 0x0600B789 RID: 46985 RVA: 0x001B5C50 File Offset: 0x001B3E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024FA RID: 9466
		// (get) Token: 0x0600B78A RID: 46986 RVA: 0x001B5C53 File Offset: 0x001B3E53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InputSettingRequest.Descriptor;
			}
		}

		// Token: 0x0600B78B RID: 46987 RVA: 0x001B5C5A File Offset: 0x001B3E5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputSettingRequest()
		{
		}

		// Token: 0x0600B78C RID: 46988 RVA: 0x001B5C62 File Offset: 0x001B3E62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputSettingRequest(InputSettingRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B78D RID: 46989 RVA: 0x001B5C7B File Offset: 0x001B3E7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputSettingRequest Clone()
		{
			return new InputSettingRequest(this);
		}

		// Token: 0x0600B78E RID: 46990 RVA: 0x001B5C83 File Offset: 0x001B3E83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InputSettingRequest);
		}

		// Token: 0x0600B78F RID: 46991 RVA: 0x001B5C91 File Offset: 0x001B3E91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InputSettingRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600B790 RID: 46992 RVA: 0x001B5CB0 File Offset: 0x001B3EB0
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

		// Token: 0x0600B791 RID: 46993 RVA: 0x001B5CD6 File Offset: 0x001B3ED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B792 RID: 46994 RVA: 0x001B5CE3 File Offset: 0x001B3EE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B793 RID: 46995 RVA: 0x001B5CEC File Offset: 0x001B3EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B794 RID: 46996 RVA: 0x001B5D04 File Offset: 0x001B3F04
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

		// Token: 0x0600B795 RID: 46997 RVA: 0x001B5D2A File Offset: 0x001B3F2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InputSettingRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B796 RID: 46998 RVA: 0x001B5D47 File Offset: 0x001B3F47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B797 RID: 46999 RVA: 0x001B5D50 File Offset: 0x001B3F50
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

		// Token: 0x04005160 RID: 20832
		private UnknownFieldSet _unknownFields;
	}
}
