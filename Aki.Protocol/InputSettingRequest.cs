using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000813 RID: 2067
	[NetMessage(EMessageId.InputSettingRequest)]
	public sealed class InputSettingRequest : IMessage<InputSettingRequest>, IMessage, IEquatable<InputSettingRequest>, IDeepCloneable<InputSettingRequest>, IBufferMessage
	{
		// Token: 0x0600B8DE RID: 47326 RVA: 0x001B8689 File Offset: 0x001B6889
		[NullableContext(1)]
		public static InputSettingRequest Create()
		{
			return new InputSettingRequest();
		}

		// Token: 0x17002543 RID: 9539
		// (get) Token: 0x0600B8DF RID: 47327 RVA: 0x001B8690 File Offset: 0x001B6890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002544 RID: 9540
		// (get) Token: 0x0600B8E0 RID: 47328 RVA: 0x001B8693 File Offset: 0x001B6893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InputSettingRequest.Descriptor;
			}
		}

		// Token: 0x0600B8E1 RID: 47329 RVA: 0x001B869A File Offset: 0x001B689A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputSettingRequest()
		{
		}

		// Token: 0x0600B8E2 RID: 47330 RVA: 0x001B86A2 File Offset: 0x001B68A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputSettingRequest(InputSettingRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B8E3 RID: 47331 RVA: 0x001B86BB File Offset: 0x001B68BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputSettingRequest Clone()
		{
			return new InputSettingRequest(this);
		}

		// Token: 0x0600B8E4 RID: 47332 RVA: 0x001B86C3 File Offset: 0x001B68C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InputSettingRequest);
		}

		// Token: 0x0600B8E5 RID: 47333 RVA: 0x001B86D1 File Offset: 0x001B68D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InputSettingRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600B8E6 RID: 47334 RVA: 0x001B86F0 File Offset: 0x001B68F0
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

		// Token: 0x0600B8E7 RID: 47335 RVA: 0x001B8716 File Offset: 0x001B6916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B8E8 RID: 47336 RVA: 0x001B8723 File Offset: 0x001B6923
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B8E9 RID: 47337 RVA: 0x001B872C File Offset: 0x001B692C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B8EA RID: 47338 RVA: 0x001B8744 File Offset: 0x001B6944
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

		// Token: 0x0600B8EB RID: 47339 RVA: 0x001B876A File Offset: 0x001B696A
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

		// Token: 0x0600B8EC RID: 47340 RVA: 0x001B8787 File Offset: 0x001B6987
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B8ED RID: 47341 RVA: 0x001B8790 File Offset: 0x001B6990
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

		// Token: 0x04005167 RID: 20839
		private UnknownFieldSet _unknownFields;
	}
}
