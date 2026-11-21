using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007FD RID: 2045
	public sealed class InputAxis : IMessage<InputAxis>, IMessage, IEquatable<InputAxis>, IDeepCloneable<InputAxis>, IBufferMessage
	{
		// Token: 0x0600B75D RID: 46941 RVA: 0x001B560A File Offset: 0x001B380A
		[NullableContext(1)]
		public static InputAxis Create()
		{
			return new InputAxis();
		}

		// Token: 0x170024EF RID: 9455
		// (get) Token: 0x0600B75E RID: 46942 RVA: 0x001B5611 File Offset: 0x001B3811
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<InputAxis> Parser
		{
			get
			{
				return InputAxis._parser;
			}
		}

		// Token: 0x170024F0 RID: 9456
		// (get) Token: 0x0600B75F RID: 46943 RVA: 0x001B5618 File Offset: 0x001B3818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024F1 RID: 9457
		// (get) Token: 0x0600B760 RID: 46944 RVA: 0x001B561B File Offset: 0x001B381B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InputAxis.Descriptor;
			}
		}

		// Token: 0x0600B761 RID: 46945 RVA: 0x001B5622 File Offset: 0x001B3822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputAxis()
		{
		}

		// Token: 0x0600B762 RID: 46946 RVA: 0x001B5640 File Offset: 0x001B3840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputAxis(InputAxis other) : this()
		{
			this.axisName_ = other.axisName_;
			this.keyScaleMap_ = other.keyScaleMap_.Clone();
			this.version_ = other.version_;
			this.inputType_ = other.inputType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B763 RID: 46947 RVA: 0x001B5699 File Offset: 0x001B3899
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputAxis Clone()
		{
			return new InputAxis(this);
		}

		// Token: 0x170024F2 RID: 9458
		// (get) Token: 0x0600B764 RID: 46948 RVA: 0x001B56A1 File Offset: 0x001B38A1
		// (set) Token: 0x0600B765 RID: 46949 RVA: 0x001B56A9 File Offset: 0x001B38A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string AxisName
		{
			get
			{
				return this.axisName_;
			}
			set
			{
				this.axisName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170024F3 RID: 9459
		// (get) Token: 0x0600B766 RID: 46950 RVA: 0x001B56BC File Offset: 0x001B38BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<string, int> KeyScaleMap
		{
			get
			{
				return this.keyScaleMap_;
			}
		}

		// Token: 0x170024F4 RID: 9460
		// (get) Token: 0x0600B767 RID: 46951 RVA: 0x001B56C4 File Offset: 0x001B38C4
		// (set) Token: 0x0600B768 RID: 46952 RVA: 0x001B56CC File Offset: 0x001B38CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Version
		{
			get
			{
				return this.version_;
			}
			set
			{
				this.version_ = value;
			}
		}

		// Token: 0x170024F5 RID: 9461
		// (get) Token: 0x0600B769 RID: 46953 RVA: 0x001B56D5 File Offset: 0x001B38D5
		// (set) Token: 0x0600B76A RID: 46954 RVA: 0x001B56DD File Offset: 0x001B38DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SettingInputType InputType
		{
			get
			{
				return this.inputType_;
			}
			set
			{
				this.inputType_ = value;
			}
		}

		// Token: 0x0600B76B RID: 46955 RVA: 0x001B56E6 File Offset: 0x001B38E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InputAxis);
		}

		// Token: 0x0600B76C RID: 46956 RVA: 0x001B56F4 File Offset: 0x001B38F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InputAxis other)
		{
			return other != null && (other == this || (!(this.AxisName != other.AxisName) && this.KeyScaleMap.Equals(other.KeyScaleMap) && this.Version == other.Version && this.InputType == other.InputType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B76D RID: 46957 RVA: 0x001B5768 File Offset: 0x001B3968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AxisName.Length != 0)
			{
				num ^= this.AxisName.GetHashCode();
			}
			num ^= this.KeyScaleMap.GetHashCode();
			if (this.Version != 0)
			{
				num ^= this.Version.GetHashCode();
			}
			if (this.InputType != SettingInputType.Normal)
			{
				num ^= this.InputType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B76E RID: 46958 RVA: 0x001B57EF File Offset: 0x001B39EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B76F RID: 46959 RVA: 0x001B57FC File Offset: 0x001B39FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B770 RID: 46960 RVA: 0x001B5808 File Offset: 0x001B3A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AxisName.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.AxisName);
			}
			this.keyScaleMap_.WriteTo(ref output, InputAxis._map_keyScaleMap_codec);
			if (this.Version != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Version);
			}
			if (this.InputType != SettingInputType.Normal)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.InputType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B771 RID: 46961 RVA: 0x001B5894 File Offset: 0x001B3A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AxisName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.AxisName);
			}
			num += this.keyScaleMap_.CalculateSize(InputAxis._map_keyScaleMap_codec);
			if (this.Version != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Version);
			}
			if (this.InputType != SettingInputType.Normal)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.InputType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B772 RID: 46962 RVA: 0x001B591C File Offset: 0x001B3B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InputAxis other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AxisName.Length != 0)
			{
				this.AxisName = other.AxisName;
			}
			this.keyScaleMap_.MergeFrom(other.keyScaleMap_);
			if (other.Version != 0)
			{
				this.Version = other.Version;
			}
			if (other.InputType != SettingInputType.Normal)
			{
				this.InputType = other.InputType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B773 RID: 46963 RVA: 0x001B5996 File Offset: 0x001B3B96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B774 RID: 46964 RVA: 0x001B59A0 File Offset: 0x001B3BA0
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
				if (num <= 18U)
				{
					if (num == 10U)
					{
						this.AxisName = input.ReadString();
						continue;
					}
					if (num == 18U)
					{
						this.keyScaleMap_.AddEntriesFrom(ref input, InputAxis._map_keyScaleMap_codec);
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Version = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.InputType = (SettingInputType)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005151 RID: 20817
		private static readonly MessageParser<InputAxis> _parser = new MessageParser<InputAxis>(() => new InputAxis());

		// Token: 0x04005152 RID: 20818
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005153 RID: 20819
		public const int AxisNameFieldNumber = 1;

		// Token: 0x04005154 RID: 20820
		private string axisName_ = "";

		// Token: 0x04005155 RID: 20821
		public const int KeyScaleMapFieldNumber = 2;

		// Token: 0x04005156 RID: 20822
		private static readonly MapField<string, int>.Codec _map_keyScaleMap_codec = new MapField<string, int>.Codec(FieldCodec.ForString(10U, ""), FieldCodec.ForInt32(16U, 0), 18U);

		// Token: 0x04005157 RID: 20823
		private readonly MapField<string, int> keyScaleMap_ = new MapField<string, int>();

		// Token: 0x04005158 RID: 20824
		public const int VersionFieldNumber = 3;

		// Token: 0x04005159 RID: 20825
		private int version_;

		// Token: 0x0400515A RID: 20826
		public const int InputTypeFieldNumber = 4;

		// Token: 0x0400515B RID: 20827
		private SettingInputType inputType_;
	}
}
