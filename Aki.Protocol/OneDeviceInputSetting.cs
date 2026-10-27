using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B83 RID: 2947
	public sealed class OneDeviceInputSetting : IMessage<OneDeviceInputSetting>, IMessage, IEquatable<OneDeviceInputSetting>, IDeepCloneable<OneDeviceInputSetting>, IBufferMessage
	{
		// Token: 0x0600FF65 RID: 65381 RVA: 0x00253DD5 File Offset: 0x00251FD5
		[NullableContext(1)]
		public static OneDeviceInputSetting Create()
		{
			return new OneDeviceInputSetting();
		}

		// Token: 0x17003426 RID: 13350
		// (get) Token: 0x0600FF66 RID: 65382 RVA: 0x00253DDC File Offset: 0x00251FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OneDeviceInputSetting> Parser
		{
			get
			{
				return OneDeviceInputSetting._parser;
			}
		}

		// Token: 0x17003427 RID: 13351
		// (get) Token: 0x0600FF67 RID: 65383 RVA: 0x00253DE3 File Offset: 0x00251FE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003428 RID: 13352
		// (get) Token: 0x0600FF68 RID: 65384 RVA: 0x00253DE6 File Offset: 0x00251FE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OneDeviceInputSetting.Descriptor;
			}
		}

		// Token: 0x0600FF69 RID: 65385 RVA: 0x00253DED File Offset: 0x00251FED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneDeviceInputSetting()
		{
		}

		// Token: 0x0600FF6A RID: 65386 RVA: 0x00253E2C File Offset: 0x0025202C
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

		// Token: 0x0600FF6B RID: 65387 RVA: 0x00253EAC File Offset: 0x002520AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneDeviceInputSetting Clone()
		{
			return new OneDeviceInputSetting(this);
		}

		// Token: 0x17003429 RID: 13353
		// (get) Token: 0x0600FF6C RID: 65388 RVA: 0x00253EB4 File Offset: 0x002520B4
		// (set) Token: 0x0600FF6D RID: 65389 RVA: 0x00253EBC File Offset: 0x002520BC
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

		// Token: 0x1700342A RID: 13354
		// (get) Token: 0x0600FF6E RID: 65390 RVA: 0x00253EC5 File Offset: 0x002520C5
		// (set) Token: 0x0600FF6F RID: 65391 RVA: 0x00253ECD File Offset: 0x002520CD
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

		// Token: 0x1700342B RID: 13355
		// (get) Token: 0x0600FF70 RID: 65392 RVA: 0x00253EE0 File Offset: 0x002520E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<InputAction> InputAction
		{
			get
			{
				return this.inputAction_;
			}
		}

		// Token: 0x1700342C RID: 13356
		// (get) Token: 0x0600FF71 RID: 65393 RVA: 0x00253EE8 File Offset: 0x002520E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<InputAxis> InputAxis
		{
			get
			{
				return this.inputAxis_;
			}
		}

		// Token: 0x1700342D RID: 13357
		// (get) Token: 0x0600FF72 RID: 65394 RVA: 0x00253EF0 File Offset: 0x002520F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CombinationAction> InputCombinationAction
		{
			get
			{
				return this.inputCombinationAction_;
			}
		}

		// Token: 0x1700342E RID: 13358
		// (get) Token: 0x0600FF73 RID: 65395 RVA: 0x00253EF8 File Offset: 0x002520F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CombinationAxis> InputCombinationAxis
		{
			get
			{
				return this.inputCombinationAxis_;
			}
		}

		// Token: 0x0600FF74 RID: 65396 RVA: 0x00253F00 File Offset: 0x00252100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OneDeviceInputSetting);
		}

		// Token: 0x0600FF75 RID: 65397 RVA: 0x00253F10 File Offset: 0x00252110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OneDeviceInputSetting other)
		{
			return other != null && (other == this || (this.Device == other.Device && !(this.DeviceSubType != other.DeviceSubType) && this.inputAction_.Equals(other.inputAction_) && this.inputAxis_.Equals(other.inputAxis_) && this.inputCombinationAction_.Equals(other.inputCombinationAction_) && this.inputCombinationAxis_.Equals(other.inputCombinationAxis_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FF76 RID: 65398 RVA: 0x00253FB4 File Offset: 0x002521B4
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

		// Token: 0x0600FF77 RID: 65399 RVA: 0x0025404C File Offset: 0x0025224C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FF78 RID: 65400 RVA: 0x00254059 File Offset: 0x00252259
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FF79 RID: 65401 RVA: 0x00254064 File Offset: 0x00252264
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

		// Token: 0x0600FF7A RID: 65402 RVA: 0x00254108 File Offset: 0x00252308
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

		// Token: 0x0600FF7B RID: 65403 RVA: 0x002541B0 File Offset: 0x002523B0
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

		// Token: 0x0600FF7C RID: 65404 RVA: 0x00254249 File Offset: 0x00252449
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FF7D RID: 65405 RVA: 0x00254254 File Offset: 0x00252454
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

		// Token: 0x040065B5 RID: 26037
		private static readonly MessageParser<OneDeviceInputSetting> _parser = new MessageParser<OneDeviceInputSetting>(() => new OneDeviceInputSetting());

		// Token: 0x040065B6 RID: 26038
		private UnknownFieldSet _unknownFields;

		// Token: 0x040065B7 RID: 26039
		public const int DeviceFieldNumber = 5;

		// Token: 0x040065B8 RID: 26040
		private InputSettingDevice device_;

		// Token: 0x040065B9 RID: 26041
		public const int DeviceSubTypeFieldNumber = 6;

		// Token: 0x040065BA RID: 26042
		private string deviceSubType_ = "";

		// Token: 0x040065BB RID: 26043
		public const int InputActionFieldNumber = 7;

		// Token: 0x040065BC RID: 26044
		private static readonly FieldCodec<InputAction> _repeated_inputAction_codec = FieldCodec.ForMessage<InputAction>(58U, Aki.Protocol.InputAction.Parser);

		// Token: 0x040065BD RID: 26045
		private readonly RepeatedField<InputAction> inputAction_ = new RepeatedField<InputAction>();

		// Token: 0x040065BE RID: 26046
		public const int InputAxisFieldNumber = 8;

		// Token: 0x040065BF RID: 26047
		private static readonly FieldCodec<InputAxis> _repeated_inputAxis_codec = FieldCodec.ForMessage<InputAxis>(66U, Aki.Protocol.InputAxis.Parser);

		// Token: 0x040065C0 RID: 26048
		private readonly RepeatedField<InputAxis> inputAxis_ = new RepeatedField<InputAxis>();

		// Token: 0x040065C1 RID: 26049
		public const int InputCombinationActionFieldNumber = 9;

		// Token: 0x040065C2 RID: 26050
		private static readonly FieldCodec<CombinationAction> _repeated_inputCombinationAction_codec = FieldCodec.ForMessage<CombinationAction>(74U, CombinationAction.Parser);

		// Token: 0x040065C3 RID: 26051
		private readonly RepeatedField<CombinationAction> inputCombinationAction_ = new RepeatedField<CombinationAction>();

		// Token: 0x040065C4 RID: 26052
		public const int InputCombinationAxisFieldNumber = 10;

		// Token: 0x040065C5 RID: 26053
		private static readonly FieldCodec<CombinationAxis> _repeated_inputCombinationAxis_codec = FieldCodec.ForMessage<CombinationAxis>(82U, CombinationAxis.Parser);

		// Token: 0x040065C6 RID: 26054
		private readonly RepeatedField<CombinationAxis> inputCombinationAxis_ = new RepeatedField<CombinationAxis>();
	}
}
