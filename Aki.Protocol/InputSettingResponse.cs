using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000814 RID: 2068
	[NetMessage(EMessageId.InputSettingResponse)]
	public sealed class InputSettingResponse : IMessage<InputSettingResponse>, IMessage, IEquatable<InputSettingResponse>, IDeepCloneable<InputSettingResponse>, IBufferMessage
	{
		// Token: 0x0600B8EE RID: 47342 RVA: 0x001B87C2 File Offset: 0x001B69C2
		[NullableContext(1)]
		public static InputSettingResponse Create()
		{
			return new InputSettingResponse();
		}

		// Token: 0x17002545 RID: 9541
		// (get) Token: 0x0600B8EF RID: 47343 RVA: 0x001B87C9 File Offset: 0x001B69C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002546 RID: 9542
		// (get) Token: 0x0600B8F0 RID: 47344 RVA: 0x001B87CC File Offset: 0x001B69CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InputSettingResponse.Descriptor;
			}
		}

		// Token: 0x0600B8F1 RID: 47345 RVA: 0x001B87D3 File Offset: 0x001B69D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputSettingResponse()
		{
		}

		// Token: 0x0600B8F2 RID: 47346 RVA: 0x001B87DB File Offset: 0x001B69DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputSettingResponse(InputSettingResponse other) : this()
		{
			this.inputSettingData_ = ((other.inputSettingData_ != null) ? other.inputSettingData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B8F3 RID: 47347 RVA: 0x001B8810 File Offset: 0x001B6A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputSettingResponse Clone()
		{
			return new InputSettingResponse(this);
		}

		// Token: 0x17002547 RID: 9543
		// (get) Token: 0x0600B8F4 RID: 47348 RVA: 0x001B8818 File Offset: 0x001B6A18
		// (set) Token: 0x0600B8F5 RID: 47349 RVA: 0x001B8820 File Offset: 0x001B6A20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputSettingData InputSettingData
		{
			get
			{
				return this.inputSettingData_;
			}
			set
			{
				this.inputSettingData_ = value;
			}
		}

		// Token: 0x0600B8F6 RID: 47350 RVA: 0x001B8829 File Offset: 0x001B6A29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InputSettingResponse);
		}

		// Token: 0x0600B8F7 RID: 47351 RVA: 0x001B8837 File Offset: 0x001B6A37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InputSettingResponse other)
		{
			return other != null && (other == this || (object.Equals(this.InputSettingData, other.InputSettingData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B8F8 RID: 47352 RVA: 0x001B886C File Offset: 0x001B6A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.inputSettingData_ != null)
			{
				num ^= this.InputSettingData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B8F9 RID: 47353 RVA: 0x001B88A8 File Offset: 0x001B6AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B8FA RID: 47354 RVA: 0x001B88B5 File Offset: 0x001B6AB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B8FB RID: 47355 RVA: 0x001B88BE File Offset: 0x001B6ABE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.inputSettingData_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.InputSettingData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B8FC RID: 47356 RVA: 0x001B88F0 File Offset: 0x001B6AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.inputSettingData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.InputSettingData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B8FD RID: 47357 RVA: 0x001B8930 File Offset: 0x001B6B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InputSettingResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.inputSettingData_ != null)
			{
				if (this.inputSettingData_ == null)
				{
					this.InputSettingData = new InputSettingData();
				}
				this.InputSettingData.MergeFrom(other.InputSettingData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B8FE RID: 47358 RVA: 0x001B8984 File Offset: 0x001B6B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B8FF RID: 47359 RVA: 0x001B8990 File Offset: 0x001B6B90
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
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.inputSettingData_ == null)
					{
						this.InputSettingData = new InputSettingData();
					}
					input.ReadMessage(this.InputSettingData);
				}
			}
		}

		// Token: 0x04005168 RID: 20840
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005169 RID: 20841
		public const int InputSettingDataFieldNumber = 3;

		// Token: 0x0400516A RID: 20842
		private InputSettingData inputSettingData_;
	}
}
