using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000816 RID: 2070
	[NetMessage(EMessageId.InputSettingUpdateRequest)]
	public sealed class InputSettingUpdateRequest : IMessage<InputSettingUpdateRequest>, IMessage, IEquatable<InputSettingUpdateRequest>, IDeepCloneable<InputSettingUpdateRequest>, IBufferMessage
	{
		// Token: 0x0600B912 RID: 47378 RVA: 0x001B8C0C File Offset: 0x001B6E0C
		[NullableContext(1)]
		public static InputSettingUpdateRequest Create()
		{
			return new InputSettingUpdateRequest();
		}

		// Token: 0x1700254B RID: 9547
		// (get) Token: 0x0600B913 RID: 47379 RVA: 0x001B8C13 File Offset: 0x001B6E13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700254C RID: 9548
		// (get) Token: 0x0600B914 RID: 47380 RVA: 0x001B8C16 File Offset: 0x001B6E16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InputSettingUpdateRequest.Descriptor;
			}
		}

		// Token: 0x0600B915 RID: 47381 RVA: 0x001B8C1D File Offset: 0x001B6E1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputSettingUpdateRequest()
		{
		}

		// Token: 0x0600B916 RID: 47382 RVA: 0x001B8C25 File Offset: 0x001B6E25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputSettingUpdateRequest(InputSettingUpdateRequest other) : this()
		{
			this.inputSettingData_ = ((other.inputSettingData_ != null) ? other.inputSettingData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B917 RID: 47383 RVA: 0x001B8C5A File Offset: 0x001B6E5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputSettingUpdateRequest Clone()
		{
			return new InputSettingUpdateRequest(this);
		}

		// Token: 0x1700254D RID: 9549
		// (get) Token: 0x0600B918 RID: 47384 RVA: 0x001B8C62 File Offset: 0x001B6E62
		// (set) Token: 0x0600B919 RID: 47385 RVA: 0x001B8C6A File Offset: 0x001B6E6A
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

		// Token: 0x0600B91A RID: 47386 RVA: 0x001B8C73 File Offset: 0x001B6E73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InputSettingUpdateRequest);
		}

		// Token: 0x0600B91B RID: 47387 RVA: 0x001B8C81 File Offset: 0x001B6E81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InputSettingUpdateRequest other)
		{
			return other != null && (other == this || (object.Equals(this.InputSettingData, other.InputSettingData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B91C RID: 47388 RVA: 0x001B8CB4 File Offset: 0x001B6EB4
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

		// Token: 0x0600B91D RID: 47389 RVA: 0x001B8CF0 File Offset: 0x001B6EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B91E RID: 47390 RVA: 0x001B8CFD File Offset: 0x001B6EFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B91F RID: 47391 RVA: 0x001B8D06 File Offset: 0x001B6F06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.inputSettingData_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.InputSettingData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B920 RID: 47392 RVA: 0x001B8D38 File Offset: 0x001B6F38
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

		// Token: 0x0600B921 RID: 47393 RVA: 0x001B8D78 File Offset: 0x001B6F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InputSettingUpdateRequest other)
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

		// Token: 0x0600B922 RID: 47394 RVA: 0x001B8DCC File Offset: 0x001B6FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B923 RID: 47395 RVA: 0x001B8DD8 File Offset: 0x001B6FD8
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
				if (num != 74U)
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

		// Token: 0x0400516E RID: 20846
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400516F RID: 20847
		public const int InputSettingDataFieldNumber = 9;

		// Token: 0x04005170 RID: 20848
		private InputSettingData inputSettingData_;
	}
}
