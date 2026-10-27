using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000811 RID: 2065
	public sealed class InputAxis : IMessage<InputAxis>, IMessage, IEquatable<InputAxis>, IDeepCloneable<InputAxis>, IBufferMessage
	{
		// Token: 0x0600B8B3 RID: 47283 RVA: 0x001B804A File Offset: 0x001B624A
		[NullableContext(1)]
		public static InputAxis Create()
		{
			return new InputAxis();
		}

		// Token: 0x17002539 RID: 9529
		// (get) Token: 0x0600B8B4 RID: 47284 RVA: 0x001B8051 File Offset: 0x001B6251
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<InputAxis> Parser
		{
			get
			{
				return InputAxis._parser;
			}
		}

		// Token: 0x1700253A RID: 9530
		// (get) Token: 0x0600B8B5 RID: 47285 RVA: 0x001B8058 File Offset: 0x001B6258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700253B RID: 9531
		// (get) Token: 0x0600B8B6 RID: 47286 RVA: 0x001B805B File Offset: 0x001B625B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InputAxis.Descriptor;
			}
		}

		// Token: 0x0600B8B7 RID: 47287 RVA: 0x001B8062 File Offset: 0x001B6262
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputAxis()
		{
		}

		// Token: 0x0600B8B8 RID: 47288 RVA: 0x001B8080 File Offset: 0x001B6280
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

		// Token: 0x0600B8B9 RID: 47289 RVA: 0x001B80D9 File Offset: 0x001B62D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputAxis Clone()
		{
			return new InputAxis(this);
		}

		// Token: 0x1700253C RID: 9532
		// (get) Token: 0x0600B8BA RID: 47290 RVA: 0x001B80E1 File Offset: 0x001B62E1
		// (set) Token: 0x0600B8BB RID: 47291 RVA: 0x001B80E9 File Offset: 0x001B62E9
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

		// Token: 0x1700253D RID: 9533
		// (get) Token: 0x0600B8BC RID: 47292 RVA: 0x001B80FC File Offset: 0x001B62FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<string, int> KeyScaleMap
		{
			get
			{
				return this.keyScaleMap_;
			}
		}

		// Token: 0x1700253E RID: 9534
		// (get) Token: 0x0600B8BD RID: 47293 RVA: 0x001B8104 File Offset: 0x001B6304
		// (set) Token: 0x0600B8BE RID: 47294 RVA: 0x001B810C File Offset: 0x001B630C
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

		// Token: 0x1700253F RID: 9535
		// (get) Token: 0x0600B8BF RID: 47295 RVA: 0x001B8115 File Offset: 0x001B6315
		// (set) Token: 0x0600B8C0 RID: 47296 RVA: 0x001B811D File Offset: 0x001B631D
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

		// Token: 0x0600B8C1 RID: 47297 RVA: 0x001B8126 File Offset: 0x001B6326
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InputAxis);
		}

		// Token: 0x0600B8C2 RID: 47298 RVA: 0x001B8134 File Offset: 0x001B6334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InputAxis other)
		{
			return other != null && (other == this || (!(this.AxisName != other.AxisName) && this.KeyScaleMap.Equals(other.KeyScaleMap) && this.Version == other.Version && this.InputType == other.InputType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B8C3 RID: 47299 RVA: 0x001B81A8 File Offset: 0x001B63A8
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

		// Token: 0x0600B8C4 RID: 47300 RVA: 0x001B822F File Offset: 0x001B642F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B8C5 RID: 47301 RVA: 0x001B823C File Offset: 0x001B643C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B8C6 RID: 47302 RVA: 0x001B8248 File Offset: 0x001B6448
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

		// Token: 0x0600B8C7 RID: 47303 RVA: 0x001B82D4 File Offset: 0x001B64D4
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

		// Token: 0x0600B8C8 RID: 47304 RVA: 0x001B835C File Offset: 0x001B655C
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

		// Token: 0x0600B8C9 RID: 47305 RVA: 0x001B83D6 File Offset: 0x001B65D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B8CA RID: 47306 RVA: 0x001B83E0 File Offset: 0x001B65E0
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

		// Token: 0x04005158 RID: 20824
		private static readonly MessageParser<InputAxis> _parser = new MessageParser<InputAxis>(() => new InputAxis());

		// Token: 0x04005159 RID: 20825
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400515A RID: 20826
		public const int AxisNameFieldNumber = 1;

		// Token: 0x0400515B RID: 20827
		private string axisName_ = "";

		// Token: 0x0400515C RID: 20828
		public const int KeyScaleMapFieldNumber = 2;

		// Token: 0x0400515D RID: 20829
		private static readonly MapField<string, int>.Codec _map_keyScaleMap_codec = new MapField<string, int>.Codec(FieldCodec.ForString(10U, ""), FieldCodec.ForInt32(16U, 0), 18U);

		// Token: 0x0400515E RID: 20830
		private readonly MapField<string, int> keyScaleMap_ = new MapField<string, int>();

		// Token: 0x0400515F RID: 20831
		public const int VersionFieldNumber = 3;

		// Token: 0x04005160 RID: 20832
		private int version_;

		// Token: 0x04005161 RID: 20833
		public const int InputTypeFieldNumber = 4;

		// Token: 0x04005162 RID: 20834
		private SettingInputType inputType_;
	}
}
