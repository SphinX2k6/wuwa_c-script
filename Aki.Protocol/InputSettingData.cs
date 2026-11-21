using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007FE RID: 2046
	public sealed class InputSettingData : IMessage<InputSettingData>, IMessage, IEquatable<InputSettingData>, IDeepCloneable<InputSettingData>, IBufferMessage
	{
		// Token: 0x0600B776 RID: 46966 RVA: 0x001B5A66 File Offset: 0x001B3C66
		[NullableContext(1)]
		public static InputSettingData Create()
		{
			return new InputSettingData();
		}

		// Token: 0x170024F6 RID: 9462
		// (get) Token: 0x0600B777 RID: 46967 RVA: 0x001B5A6D File Offset: 0x001B3C6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024F7 RID: 9463
		// (get) Token: 0x0600B778 RID: 46968 RVA: 0x001B5A70 File Offset: 0x001B3C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InputSettingData.Descriptor;
			}
		}

		// Token: 0x0600B779 RID: 46969 RVA: 0x001B5A77 File Offset: 0x001B3C77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputSettingData()
		{
		}

		// Token: 0x0600B77A RID: 46970 RVA: 0x001B5A8A File Offset: 0x001B3C8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputSettingData(InputSettingData other) : this()
		{
			this.inputSettings_ = other.inputSettings_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B77B RID: 46971 RVA: 0x001B5AB4 File Offset: 0x001B3CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputSettingData Clone()
		{
			return new InputSettingData(this);
		}

		// Token: 0x170024F8 RID: 9464
		// (get) Token: 0x0600B77C RID: 46972 RVA: 0x001B5ABC File Offset: 0x001B3CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneDeviceInputSetting> InputSettings
		{
			get
			{
				return this.inputSettings_;
			}
		}

		// Token: 0x0600B77D RID: 46973 RVA: 0x001B5AC4 File Offset: 0x001B3CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InputSettingData);
		}

		// Token: 0x0600B77E RID: 46974 RVA: 0x001B5AD2 File Offset: 0x001B3CD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InputSettingData other)
		{
			return other != null && (other == this || (this.inputSettings_.Equals(other.inputSettings_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B77F RID: 46975 RVA: 0x001B5B08 File Offset: 0x001B3D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.inputSettings_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B780 RID: 46976 RVA: 0x001B5B3C File Offset: 0x001B3D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B781 RID: 46977 RVA: 0x001B5B49 File Offset: 0x001B3D49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B782 RID: 46978 RVA: 0x001B5B52 File Offset: 0x001B3D52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.inputSettings_.WriteTo(ref output, InputSettingData._repeated_inputSettings_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B783 RID: 46979 RVA: 0x001B5B7C File Offset: 0x001B3D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.inputSettings_.CalculateSize(InputSettingData._repeated_inputSettings_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B784 RID: 46980 RVA: 0x001B5BB5 File Offset: 0x001B3DB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InputSettingData other)
		{
			if (other == null)
			{
				return;
			}
			this.inputSettings_.Add(other.inputSettings_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B785 RID: 46981 RVA: 0x001B5BE3 File Offset: 0x001B3DE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B786 RID: 46982 RVA: 0x001B5BEC File Offset: 0x001B3DEC
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.inputSettings_.AddEntriesFrom(ref input, InputSettingData._repeated_inputSettings_codec);
				}
			}
		}

		// Token: 0x0400515C RID: 20828
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400515D RID: 20829
		public const int InputSettingsFieldNumber = 1;

		// Token: 0x0400515E RID: 20830
		private static readonly FieldCodec<OneDeviceInputSetting> _repeated_inputSettings_codec = FieldCodec.ForMessage<OneDeviceInputSetting>(10U, OneDeviceInputSetting.Parser);

		// Token: 0x0400515F RID: 20831
		private readonly RepeatedField<OneDeviceInputSetting> inputSettings_ = new RepeatedField<OneDeviceInputSetting>();
	}
}
