using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B73 RID: 2931
	public sealed class OneDeviceInputSetting : IMessage<OneDeviceInputSetting>, IMessage, IEquatable<OneDeviceInputSetting>, IDeepCloneable<OneDeviceInputSetting>, IBufferMessage
	{
		// Token: 0x0600FE61 RID: 65121 RVA: 0x00251F05 File Offset: 0x00250105
		[NullableContext(1)]
		public static OneDeviceInputSetting Create()
		{
			return new OneDeviceInputSetting();
		}

		// Token: 0x170033ED RID: 13293
		// (get) Token: 0x0600FE62 RID: 65122 RVA: 0x00251F0C File Offset: 0x0025010C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OneDeviceInputSetting> Parser
		{
			get
			{
				return OneDeviceInputSetting._parser;
			}
		}

		// Token: 0x170033EE RID: 13294
		// (get) Token: 0x0600FE63 RID: 65123 RVA: 0x00251F13 File Offset: 0x00250113
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170033EF RID: 13295
		// (get) Token: 0x0600FE64 RID: 65124 RVA: 0x00251F16 File Offset: 0x00250116
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OneDeviceInputSetting.Descriptor;
			}
		}

		// Token: 0x0600FE65 RID: 65125 RVA: 0x00251F1D File Offset: 0x0025011D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneDeviceInputSetting()
		{
		}

		// Token: 0x0600FE66 RID: 65126 RVA: 0x00251F5C File Offset: 0x0025015C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneDeviceInputSetting(OneDeviceInputSetting other) : this()
		{
			this.device_ = other.device_;
			this.deviceSubType_ = other.deviceSubType_;
			this.inputAction_ = other.inputAction_.Clone();
			this.inputAxis_ = other.inputAxis_.Clone();
			this.inputCombinationAction_ = other.inputCombinationAction_.Clone();
			this.inputCombinationAxis_ = other.inputCombinationAxis_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FE67 RID: 65127 RVA: 0x00251FDC File Offset: 0x002501DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneDeviceInputSetting Clone()
		{
			return new OneDeviceInputSetting(this);
		}

		// Token: 0x170033F0 RID: 13296
		// (get) Token: 0x0600FE68 RID: 65128 RVA: 0x00251FE4 File Offset: 0x002501E4
		// (set) Token: 0x0600FE69 RID: 65129 RVA: 0x00251FEC File Offset: 0x002501EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputSettingDevice Device
		{
			get
			{
				return this.device_;
			}
			set
			{
				this.device_ = value;
			}
		}

		// Token: 0x170033F1 RID: 13297
		// (get) Token: 0x0600FE6A RID: 65130 RVA: 0x00251FF5 File Offset: 0x002501F5
		// (set) Token: 0x0600FE6B RID: 65131 RVA: 0x00251FFD File Offset: 0x002501FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string DeviceSubType
		{
			get
			{
				return this.deviceSubType_;
			}
			set
			{
				this.deviceSubType_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170033F2 RID: 13298
		// (get) Token: 0x0600FE6C RID: 65132 RVA: 0x00252010 File Offset: 0x00250210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<InputAction> InputAction
		{
			get
			{
				return this.inputAction_;
			}
		}

		// Token: 0x170033F3 RID: 13299
		// (get) Token: 0x0600FE6D RID: 65133 RVA: 0x00252018 File Offset: 0x00250218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<InputAxis> InputAxis
		{
			get
			{
				return this.inputAxis_;
			}
		}

		// Token: 0x170033F4 RID: 13300
		// (get) Token: 0x0600FE6E RID: 65134 RVA: 0x00252020 File Offset: 0x00250220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CombinationAction> InputCombinationAction
		{
			get
			{
				return this.inputCombinationAction_;
			}
		}

		// Token: 0x170033F5 RID: 13301
		// (get) Token: 0x0600FE6F RID: 65135 RVA: 0x00252028 File Offset: 0x00250228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CombinationAxis> InputCombinationAxis
		{
			get
			{
				return this.inputCombinationAxis_;
			}
		}

		// Token: 0x0600FE70 RID: 65136 RVA: 0x00252030 File Offset: 0x00250230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OneDeviceInputSetting);
		}

		// Token: 0x0600FE71 RID: 65137 RVA: 0x00252040 File Offset: 0x00250240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OneDeviceInputSetting other)
		{
			return other != null && (other == this || (this.Device == other.Device && !(this.DeviceSubType != other.DeviceSubType) && this.inputAction_.Equals(other.inputAction_) && this.inputAxis_.Equals(other.inputAxis_) && this.inputCombinationAction_.Equals(other.inputCombinationAction_) && this.inputCombinationAxis_.Equals(other.inputCombinationAxis_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FE72 RID: 65138 RVA: 0x002520E4 File Offset: 0x002502E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Device != InputSettingDevice.Mouse)
			{
				num ^= this.Device.GetHashCode();
			}
			if (this.DeviceSubType.Length != 0)
			{
				num ^= this.DeviceSubType.GetHashCode();
			}
			num ^= this.inputAction_.GetHashCode();
			num ^= this.inputAxis_.GetHashCode();
			num ^= this.inputCombinationAction_.GetHashCode();
			num ^= this.inputCombinationAxis_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FE73 RID: 65139 RVA: 0x0025217C File Offset: 0x0025037C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FE74 RID: 65140 RVA: 0x00252189 File Offset: 0x00250389
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FE75 RID: 65141 RVA: 0x00252194 File Offset: 0x00250394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Device != InputSettingDevice.Mouse)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.Device);
			}
			if (this.DeviceSubType.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.DeviceSubType);
			}
			this.inputAction_.WriteTo(ref output, OneDeviceInputSetting._repeated_inputAction_codec);
			this.inputAxis_.WriteTo(ref output, OneDeviceInputSetting._repeated_inputAxis_codec);
			this.inputCombinationAction_.WriteTo(ref output, OneDeviceInputSetting._repeated_inputCombinationAction_codec);
			this.inputCombinationAxis_.WriteTo(ref output, OneDeviceInputSetting._repeated_inputCombinationAxis_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FE76 RID: 65142 RVA: 0x00252238 File Offset: 0x00250438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Device != InputSettingDevice.Mouse)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Device);
			}
			if (this.DeviceSubType.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.DeviceSubType);
			}
			num += this.inputAction_.CalculateSize(OneDeviceInputSetting._repeated_inputAction_codec);
			num += this.inputAxis_.CalculateSize(OneDeviceInputSetting._repeated_inputAxis_codec);
			num += this.inputCombinationAction_.CalculateSize(OneDeviceInputSetting._repeated_inputCombinationAction_codec);
			num += this.inputCombinationAxis_.CalculateSize(OneDeviceInputSetting._repeated_inputCombinationAxis_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FE77 RID: 65143 RVA: 0x002522E0 File Offset: 0x002504E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OneDeviceInputSetting other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Device != InputSettingDevice.Mouse)
			{
				this.Device = other.Device;
			}
			if (other.DeviceSubType.Length != 0)
			{
				this.DeviceSubType = other.DeviceSubType;
			}
			this.inputAction_.Add(other.inputAction_);
			this.inputAxis_.Add(other.inputAxis_);
			this.inputCombinationAction_.Add(other.inputCombinationAction_);
			this.inputCombinationAxis_.Add(other.inputCombinationAxis_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FE78 RID: 65144 RVA: 0x00252379 File Offset: 0x00250579
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FE79 RID: 65145 RVA: 0x00252384 File Offset: 0x00250584
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
				if (num <= 58U)
				{
					if (num == 40U)
					{
						this.Device = (InputSettingDevice)input.ReadEnum();
						continue;
					}
					if (num == 50U)
					{
						this.DeviceSubType = input.ReadString();
						continue;
					}
					if (num == 58U)
					{
						this.inputAction_.AddEntriesFrom(ref input, OneDeviceInputSetting._repeated_inputAction_codec);
						continue;
					}
				}
				else
				{
					if (num == 66U)
					{
						this.inputAxis_.AddEntriesFrom(ref input, OneDeviceInputSetting._repeated_inputAxis_codec);
						continue;
					}
					if (num == 74U)
					{
						this.inputCombinationAction_.AddEntriesFrom(ref input, OneDeviceInputSetting._repeated_inputCombinationAction_codec);
						continue;
					}
					if (num == 82U)
					{
						this.inputCombinationAxis_.AddEntriesFrom(ref input, OneDeviceInputSetting._repeated_inputCombinationAxis_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040065C5 RID: 26053
		private static readonly MessageParser<OneDeviceInputSetting> _parser = new MessageParser<OneDeviceInputSetting>(() => new OneDeviceInputSetting());

		// Token: 0x040065C6 RID: 26054
		private UnknownFieldSet _unknownFields;

		// Token: 0x040065C7 RID: 26055
		public const int DeviceFieldNumber = 5;

		// Token: 0x040065C8 RID: 26056
		private InputSettingDevice device_;

		// Token: 0x040065C9 RID: 26057
		public const int DeviceSubTypeFieldNumber = 6;

		// Token: 0x040065CA RID: 26058
		private string deviceSubType_ = "";

		// Token: 0x040065CB RID: 26059
		public const int InputActionFieldNumber = 7;

		// Token: 0x040065CC RID: 26060
		private static readonly FieldCodec<InputAction> _repeated_inputAction_codec = FieldCodec.ForMessage<InputAction>(58U, Aki.Protocol.InputAction.Parser);

		// Token: 0x040065CD RID: 26061
		private readonly RepeatedField<InputAction> inputAction_ = new RepeatedField<InputAction>();

		// Token: 0x040065CE RID: 26062
		public const int InputAxisFieldNumber = 8;

		// Token: 0x040065CF RID: 26063
		private static readonly FieldCodec<InputAxis> _repeated_inputAxis_codec = FieldCodec.ForMessage<InputAxis>(66U, Aki.Protocol.InputAxis.Parser);

		// Token: 0x040065D0 RID: 26064
		private readonly RepeatedField<InputAxis> inputAxis_ = new RepeatedField<InputAxis>();

		// Token: 0x040065D1 RID: 26065
		public const int InputCombinationActionFieldNumber = 9;

		// Token: 0x040065D2 RID: 26066
		private static readonly FieldCodec<CombinationAction> _repeated_inputCombinationAction_codec = FieldCodec.ForMessage<CombinationAction>(74U, CombinationAction.Parser);

		// Token: 0x040065D3 RID: 26067
		private readonly RepeatedField<CombinationAction> inputCombinationAction_ = new RepeatedField<CombinationAction>();

		// Token: 0x040065D4 RID: 26068
		public const int InputCombinationAxisFieldNumber = 10;

		// Token: 0x040065D5 RID: 26069
		private static readonly FieldCodec<CombinationAxis> _repeated_inputCombinationAxis_codec = FieldCodec.ForMessage<CombinationAxis>(82U, CombinationAxis.Parser);

		// Token: 0x040065D6 RID: 26070
		private readonly RepeatedField<CombinationAxis> inputCombinationAxis_ = new RepeatedField<CombinationAxis>();
	}
}
