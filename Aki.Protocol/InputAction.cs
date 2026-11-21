using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007FC RID: 2044
	public sealed class InputAction : IMessage<InputAction>, IMessage, IEquatable<InputAction>, IDeepCloneable<InputAction>, IBufferMessage
	{
		// Token: 0x0600B744 RID: 46916 RVA: 0x001B51C2 File Offset: 0x001B33C2
		[NullableContext(1)]
		public static InputAction Create()
		{
			return new InputAction();
		}

		// Token: 0x170024E8 RID: 9448
		// (get) Token: 0x0600B745 RID: 46917 RVA: 0x001B51C9 File Offset: 0x001B33C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<InputAction> Parser
		{
			get
			{
				return InputAction._parser;
			}
		}

		// Token: 0x170024E9 RID: 9449
		// (get) Token: 0x0600B746 RID: 46918 RVA: 0x001B51D0 File Offset: 0x001B33D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024EA RID: 9450
		// (get) Token: 0x0600B747 RID: 46919 RVA: 0x001B51D3 File Offset: 0x001B33D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InputAction.Descriptor;
			}
		}

		// Token: 0x0600B748 RID: 46920 RVA: 0x001B51DA File Offset: 0x001B33DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputAction()
		{
		}

		// Token: 0x0600B749 RID: 46921 RVA: 0x001B51F8 File Offset: 0x001B33F8
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

		// Token: 0x0600B74A RID: 46922 RVA: 0x001B5251 File Offset: 0x001B3451
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputAction Clone()
		{
			return new InputAction(this);
		}

		// Token: 0x170024EB RID: 9451
		// (get) Token: 0x0600B74B RID: 46923 RVA: 0x001B5259 File Offset: 0x001B3459
		// (set) Token: 0x0600B74C RID: 46924 RVA: 0x001B5261 File Offset: 0x001B3461
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

		// Token: 0x170024EC RID: 9452
		// (get) Token: 0x0600B74D RID: 46925 RVA: 0x001B5274 File Offset: 0x001B3474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> KeyNameList
		{
			get
			{
				return this.keyNameList_;
			}
		}

		// Token: 0x170024ED RID: 9453
		// (get) Token: 0x0600B74E RID: 46926 RVA: 0x001B527C File Offset: 0x001B347C
		// (set) Token: 0x0600B74F RID: 46927 RVA: 0x001B5284 File Offset: 0x001B3484
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

		// Token: 0x170024EE RID: 9454
		// (get) Token: 0x0600B750 RID: 46928 RVA: 0x001B528D File Offset: 0x001B348D
		// (set) Token: 0x0600B751 RID: 46929 RVA: 0x001B5295 File Offset: 0x001B3495
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

		// Token: 0x0600B752 RID: 46930 RVA: 0x001B529E File Offset: 0x001B349E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InputAction);
		}

		// Token: 0x0600B753 RID: 46931 RVA: 0x001B52AC File Offset: 0x001B34AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InputAction other)
		{
			return other != null && (other == this || (!(this.ActionName != other.ActionName) && this.keyNameList_.Equals(other.keyNameList_) && this.Version == other.Version && this.InputType == other.InputType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B754 RID: 46932 RVA: 0x001B5320 File Offset: 0x001B3520
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

		// Token: 0x0600B755 RID: 46933 RVA: 0x001B53A7 File Offset: 0x001B35A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B756 RID: 46934 RVA: 0x001B53B4 File Offset: 0x001B35B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B757 RID: 46935 RVA: 0x001B53C0 File Offset: 0x001B35C0
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

		// Token: 0x0600B758 RID: 46936 RVA: 0x001B544C File Offset: 0x001B364C
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

		// Token: 0x0600B759 RID: 46937 RVA: 0x001B54D4 File Offset: 0x001B36D4
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

		// Token: 0x0600B75A RID: 46938 RVA: 0x001B554E File Offset: 0x001B374E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B75B RID: 46939 RVA: 0x001B5558 File Offset: 0x001B3758
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

		// Token: 0x04005146 RID: 20806
		private static readonly MessageParser<InputAction> _parser = new MessageParser<InputAction>(() => new InputAction());

		// Token: 0x04005147 RID: 20807
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005148 RID: 20808
		public const int ActionNameFieldNumber = 1;

		// Token: 0x04005149 RID: 20809
		private string actionName_ = "";

		// Token: 0x0400514A RID: 20810
		public const int KeyNameListFieldNumber = 2;

		// Token: 0x0400514B RID: 20811
		private static readonly FieldCodec<string> _repeated_keyNameList_codec = FieldCodec.ForString(18U);

		// Token: 0x0400514C RID: 20812
		private readonly RepeatedField<string> keyNameList_ = new RepeatedField<string>();

		// Token: 0x0400514D RID: 20813
		public const int VersionFieldNumber = 3;

		// Token: 0x0400514E RID: 20814
		private int version_;

		// Token: 0x0400514F RID: 20815
		public const int InputTypeFieldNumber = 4;

		// Token: 0x04005150 RID: 20816
		private SettingInputType inputType_;
	}
}
