using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000812 RID: 2066
	public sealed class InputSettingData : IMessage<InputSettingData>, IMessage, IEquatable<InputSettingData>, IDeepCloneable<InputSettingData>, IBufferMessage
	{
		// Token: 0x0600B8CC RID: 47308 RVA: 0x001B84A6 File Offset: 0x001B66A6
		[NullableContext(1)]
		public static InputSettingData Create()
		{
			return new InputSettingData();
		}

		// Token: 0x17002540 RID: 9536
		// (get) Token: 0x0600B8CD RID: 47309 RVA: 0x001B84AD File Offset: 0x001B66AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002541 RID: 9537
		// (get) Token: 0x0600B8CE RID: 47310 RVA: 0x001B84B0 File Offset: 0x001B66B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InputSettingData.Descriptor;
			}
		}

		// Token: 0x0600B8CF RID: 47311 RVA: 0x001B84B7 File Offset: 0x001B66B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputSettingData()
		{
		}

		// Token: 0x0600B8D0 RID: 47312 RVA: 0x001B84CA File Offset: 0x001B66CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputSettingData(InputSettingData other) : this()
		{
			this.inputSettings_ = other.inputSettings_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B8D1 RID: 47313 RVA: 0x001B84F4 File Offset: 0x001B66F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputSettingData Clone()
		{
			return new InputSettingData(this);
		}

		// Token: 0x17002542 RID: 9538
		// (get) Token: 0x0600B8D2 RID: 47314 RVA: 0x001B84FC File Offset: 0x001B66FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneDeviceInputSetting> InputSettings
		{
			get
			{
				return this.inputSettings_;
			}
		}

		// Token: 0x0600B8D3 RID: 47315 RVA: 0x001B8504 File Offset: 0x001B6704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InputSettingData);
		}

		// Token: 0x0600B8D4 RID: 47316 RVA: 0x001B8512 File Offset: 0x001B6712
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InputSettingData other)
		{
			return other != null && (other == this || (this.inputSettings_.Equals(other.inputSettings_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B8D5 RID: 47317 RVA: 0x001B8548 File Offset: 0x001B6748
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

		// Token: 0x0600B8D6 RID: 47318 RVA: 0x001B857C File Offset: 0x001B677C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B8D7 RID: 47319 RVA: 0x001B8589 File Offset: 0x001B6789
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B8D8 RID: 47320 RVA: 0x001B8592 File Offset: 0x001B6792
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

		// Token: 0x0600B8D9 RID: 47321 RVA: 0x001B85BC File Offset: 0x001B67BC
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

		// Token: 0x0600B8DA RID: 47322 RVA: 0x001B85F5 File Offset: 0x001B67F5
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

		// Token: 0x0600B8DB RID: 47323 RVA: 0x001B8623 File Offset: 0x001B6823
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B8DC RID: 47324 RVA: 0x001B862C File Offset: 0x001B682C
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

		// Token: 0x04005163 RID: 20835
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005164 RID: 20836
		public const int InputSettingsFieldNumber = 1;

		// Token: 0x04005165 RID: 20837
		private static readonly FieldCodec<OneDeviceInputSetting> _repeated_inputSettings_codec = FieldCodec.ForMessage<OneDeviceInputSetting>(10U, OneDeviceInputSetting.Parser);

		// Token: 0x04005166 RID: 20838
		private readonly RepeatedField<OneDeviceInputSetting> inputSettings_ = new RepeatedField<OneDeviceInputSetting>();
	}
}
