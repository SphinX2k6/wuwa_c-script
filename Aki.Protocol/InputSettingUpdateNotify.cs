using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000801 RID: 2049
	[NetMessage(EMessageId.InputSettingUpdateNotify)]
	public sealed class InputSettingUpdateNotify : IMessage<InputSettingUpdateNotify>, IMessage, IEquatable<InputSettingUpdateNotify>, IDeepCloneable<InputSettingUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600B7AA RID: 47018 RVA: 0x001B5FA8 File Offset: 0x001B41A8
		[NullableContext(1)]
		public static InputSettingUpdateNotify Create()
		{
			return new InputSettingUpdateNotify();
		}

		// Token: 0x170024FE RID: 9470
		// (get) Token: 0x0600B7AB RID: 47019 RVA: 0x001B5FAF File Offset: 0x001B41AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024FF RID: 9471
		// (get) Token: 0x0600B7AC RID: 47020 RVA: 0x001B5FB2 File Offset: 0x001B41B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InputSettingUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600B7AD RID: 47021 RVA: 0x001B5FB9 File Offset: 0x001B41B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputSettingUpdateNotify()
		{
		}

		// Token: 0x0600B7AE RID: 47022 RVA: 0x001B5FC1 File Offset: 0x001B41C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputSettingUpdateNotify(InputSettingUpdateNotify other) : this()
		{
			this.inputSettingData_ = ((other.inputSettingData_ != null) ? other.inputSettingData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B7AF RID: 47023 RVA: 0x001B5FF6 File Offset: 0x001B41F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputSettingUpdateNotify Clone()
		{
			return new InputSettingUpdateNotify(this);
		}

		// Token: 0x17002500 RID: 9472
		// (get) Token: 0x0600B7B0 RID: 47024 RVA: 0x001B5FFE File Offset: 0x001B41FE
		// (set) Token: 0x0600B7B1 RID: 47025 RVA: 0x001B6006 File Offset: 0x001B4206
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

		// Token: 0x0600B7B2 RID: 47026 RVA: 0x001B600F File Offset: 0x001B420F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InputSettingUpdateNotify);
		}

		// Token: 0x0600B7B3 RID: 47027 RVA: 0x001B601D File Offset: 0x001B421D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InputSettingUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.InputSettingData, other.InputSettingData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B7B4 RID: 47028 RVA: 0x001B6050 File Offset: 0x001B4250
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

		// Token: 0x0600B7B5 RID: 47029 RVA: 0x001B608C File Offset: 0x001B428C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B7B6 RID: 47030 RVA: 0x001B6099 File Offset: 0x001B4299
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B7B7 RID: 47031 RVA: 0x001B60A2 File Offset: 0x001B42A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.inputSettingData_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.InputSettingData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B7B8 RID: 47032 RVA: 0x001B60D4 File Offset: 0x001B42D4
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

		// Token: 0x0600B7B9 RID: 47033 RVA: 0x001B6114 File Offset: 0x001B4314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InputSettingUpdateNotify other)
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

		// Token: 0x0600B7BA RID: 47034 RVA: 0x001B6168 File Offset: 0x001B4368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B7BB RID: 47035 RVA: 0x001B6174 File Offset: 0x001B4374
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
				if (num != 66U)
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

		// Token: 0x04005164 RID: 20836
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005165 RID: 20837
		public const int InputSettingDataFieldNumber = 8;

		// Token: 0x04005166 RID: 20838
		private InputSettingData inputSettingData_;
	}
}
