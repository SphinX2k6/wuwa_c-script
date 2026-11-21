using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000800 RID: 2048
	[NetMessage(EMessageId.InputSettingResponse)]
	public sealed class InputSettingResponse : IMessage<InputSettingResponse>, IMessage, IEquatable<InputSettingResponse>, IDeepCloneable<InputSettingResponse>, IBufferMessage
	{
		// Token: 0x0600B798 RID: 47000 RVA: 0x001B5D82 File Offset: 0x001B3F82
		[NullableContext(1)]
		public static InputSettingResponse Create()
		{
			return new InputSettingResponse();
		}

		// Token: 0x170024FB RID: 9467
		// (get) Token: 0x0600B799 RID: 47001 RVA: 0x001B5D89 File Offset: 0x001B3F89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024FC RID: 9468
		// (get) Token: 0x0600B79A RID: 47002 RVA: 0x001B5D8C File Offset: 0x001B3F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InputSettingResponse.Descriptor;
			}
		}

		// Token: 0x0600B79B RID: 47003 RVA: 0x001B5D93 File Offset: 0x001B3F93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputSettingResponse()
		{
		}

		// Token: 0x0600B79C RID: 47004 RVA: 0x001B5D9B File Offset: 0x001B3F9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputSettingResponse(InputSettingResponse other) : this()
		{
			this.inputSettingData_ = ((other.inputSettingData_ != null) ? other.inputSettingData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B79D RID: 47005 RVA: 0x001B5DD0 File Offset: 0x001B3FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputSettingResponse Clone()
		{
			return new InputSettingResponse(this);
		}

		// Token: 0x170024FD RID: 9469
		// (get) Token: 0x0600B79E RID: 47006 RVA: 0x001B5DD8 File Offset: 0x001B3FD8
		// (set) Token: 0x0600B79F RID: 47007 RVA: 0x001B5DE0 File Offset: 0x001B3FE0
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

		// Token: 0x0600B7A0 RID: 47008 RVA: 0x001B5DE9 File Offset: 0x001B3FE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InputSettingResponse);
		}

		// Token: 0x0600B7A1 RID: 47009 RVA: 0x001B5DF7 File Offset: 0x001B3FF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InputSettingResponse other)
		{
			return other != null && (other == this || (object.Equals(this.InputSettingData, other.InputSettingData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B7A2 RID: 47010 RVA: 0x001B5E2C File Offset: 0x001B402C
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

		// Token: 0x0600B7A3 RID: 47011 RVA: 0x001B5E68 File Offset: 0x001B4068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B7A4 RID: 47012 RVA: 0x001B5E75 File Offset: 0x001B4075
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B7A5 RID: 47013 RVA: 0x001B5E7E File Offset: 0x001B407E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.inputSettingData_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.InputSettingData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B7A6 RID: 47014 RVA: 0x001B5EB0 File Offset: 0x001B40B0
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

		// Token: 0x0600B7A7 RID: 47015 RVA: 0x001B5EF0 File Offset: 0x001B40F0
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

		// Token: 0x0600B7A8 RID: 47016 RVA: 0x001B5F44 File Offset: 0x001B4144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B7A9 RID: 47017 RVA: 0x001B5F50 File Offset: 0x001B4150
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
				if (num != 106U)
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

		// Token: 0x04005161 RID: 20833
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005162 RID: 20834
		public const int InputSettingDataFieldNumber = 13;

		// Token: 0x04005163 RID: 20835
		private InputSettingData inputSettingData_;
	}
}
