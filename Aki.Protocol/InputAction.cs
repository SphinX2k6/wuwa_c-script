using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000810 RID: 2064
	public sealed class InputAction : IMessage<InputAction>, IMessage, IEquatable<InputAction>, IDeepCloneable<InputAction>, IBufferMessage
	{
		// Token: 0x0600B89A RID: 47258 RVA: 0x001B7C02 File Offset: 0x001B5E02
		[NullableContext(1)]
		public static InputAction Create()
		{
			return new InputAction();
		}

		// Token: 0x17002532 RID: 9522
		// (get) Token: 0x0600B89B RID: 47259 RVA: 0x001B7C09 File Offset: 0x001B5E09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<InputAction> Parser
		{
			get
			{
				return InputAction._parser;
			}
		}

		// Token: 0x17002533 RID: 9523
		// (get) Token: 0x0600B89C RID: 47260 RVA: 0x001B7C10 File Offset: 0x001B5E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002534 RID: 9524
		// (get) Token: 0x0600B89D RID: 47261 RVA: 0x001B7C13 File Offset: 0x001B5E13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InputAction.Descriptor;
			}
		}

		// Token: 0x0600B89E RID: 47262 RVA: 0x001B7C1A File Offset: 0x001B5E1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputAction()
		{
		}

		// Token: 0x0600B89F RID: 47263 RVA: 0x001B7C38 File Offset: 0x001B5E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputAction(InputAction other) : this()
		{
			this.actionName_ = other.actionName_;
			this.keyNameList_ = other.keyNameList_.Clone();
			this.version_ = other.version_;
			this.inputType_ = other.inputType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B8A0 RID: 47264 RVA: 0x001B7C91 File Offset: 0x001B5E91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputAction Clone()
		{
			return new InputAction(this);
		}

		// Token: 0x17002535 RID: 9525
		// (get) Token: 0x0600B8A1 RID: 47265 RVA: 0x001B7C99 File Offset: 0x001B5E99
		// (set) Token: 0x0600B8A2 RID: 47266 RVA: 0x001B7CA1 File Offset: 0x001B5EA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ActionName
		{
			get
			{
				return this.actionName_;
			}
			set
			{
				this.actionName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002536 RID: 9526
		// (get) Token: 0x0600B8A3 RID: 47267 RVA: 0x001B7CB4 File Offset: 0x001B5EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> KeyNameList
		{
			get
			{
				return this.keyNameList_;
			}
		}

		// Token: 0x17002537 RID: 9527
		// (get) Token: 0x0600B8A4 RID: 47268 RVA: 0x001B7CBC File Offset: 0x001B5EBC
		// (set) Token: 0x0600B8A5 RID: 47269 RVA: 0x001B7CC4 File Offset: 0x001B5EC4
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

		// Token: 0x17002538 RID: 9528
		// (get) Token: 0x0600B8A6 RID: 47270 RVA: 0x001B7CCD File Offset: 0x001B5ECD
		// (set) Token: 0x0600B8A7 RID: 47271 RVA: 0x001B7CD5 File Offset: 0x001B5ED5
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

		// Token: 0x0600B8A8 RID: 47272 RVA: 0x001B7CDE File Offset: 0x001B5EDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InputAction);
		}

		// Token: 0x0600B8A9 RID: 47273 RVA: 0x001B7CEC File Offset: 0x001B5EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InputAction other)
		{
			return other != null && (other == this || (!(this.ActionName != other.ActionName) && this.keyNameList_.Equals(other.keyNameList_) && this.Version == other.Version && this.InputType == other.InputType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B8AA RID: 47274 RVA: 0x001B7D60 File Offset: 0x001B5F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActionName.Length != 0)
			{
				num ^= this.ActionName.GetHashCode();
			}
			num ^= this.keyNameList_.GetHashCode();
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

		// Token: 0x0600B8AB RID: 47275 RVA: 0x001B7DE7 File Offset: 0x001B5FE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B8AC RID: 47276 RVA: 0x001B7DF4 File Offset: 0x001B5FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B8AD RID: 47277 RVA: 0x001B7E00 File Offset: 0x001B6000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActionName.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ActionName);
			}
			this.keyNameList_.WriteTo(ref output, InputAction._repeated_keyNameList_codec);
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

		// Token: 0x0600B8AE RID: 47278 RVA: 0x001B7E8C File Offset: 0x001B608C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActionName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ActionName);
			}
			num += this.keyNameList_.CalculateSize(InputAction._repeated_keyNameList_codec);
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

		// Token: 0x0600B8AF RID: 47279 RVA: 0x001B7F14 File Offset: 0x001B6114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InputAction other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActionName.Length != 0)
			{
				this.ActionName = other.ActionName;
			}
			this.keyNameList_.Add(other.keyNameList_);
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

		// Token: 0x0600B8B0 RID: 47280 RVA: 0x001B7F8E File Offset: 0x001B618E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B8B1 RID: 47281 RVA: 0x001B7F98 File Offset: 0x001B6198
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
						this.ActionName = input.ReadString();
						continue;
					}
					if (num == 18U)
					{
						this.keyNameList_.AddEntriesFrom(ref input, InputAction._repeated_keyNameList_codec);
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

		// Token: 0x0400514D RID: 20813
		private static readonly MessageParser<InputAction> _parser = new MessageParser<InputAction>(() => new InputAction());

		// Token: 0x0400514E RID: 20814
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400514F RID: 20815
		public const int ActionNameFieldNumber = 1;

		// Token: 0x04005150 RID: 20816
		private string actionName_ = "";

		// Token: 0x04005151 RID: 20817
		public const int KeyNameListFieldNumber = 2;

		// Token: 0x04005152 RID: 20818
		private static readonly FieldCodec<string> _repeated_keyNameList_codec = FieldCodec.ForString(18U);

		// Token: 0x04005153 RID: 20819
		private readonly RepeatedField<string> keyNameList_ = new RepeatedField<string>();

		// Token: 0x04005154 RID: 20820
		public const int VersionFieldNumber = 3;

		// Token: 0x04005155 RID: 20821
		private int version_;

		// Token: 0x04005156 RID: 20822
		public const int InputTypeFieldNumber = 4;

		// Token: 0x04005157 RID: 20823
		private SettingInputType inputType_;
	}
}
