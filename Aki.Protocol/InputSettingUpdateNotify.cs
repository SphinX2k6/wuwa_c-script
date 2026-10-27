using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000815 RID: 2069
	[NetMessage(EMessageId.InputSettingUpdateNotify)]
	public sealed class InputSettingUpdateNotify : IMessage<InputSettingUpdateNotify>, IMessage, IEquatable<InputSettingUpdateNotify>, IDeepCloneable<InputSettingUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600B900 RID: 47360 RVA: 0x001B89E8 File Offset: 0x001B6BE8
		[NullableContext(1)]
		public static InputSettingUpdateNotify Create()
		{
			return new InputSettingUpdateNotify();
		}

		// Token: 0x17002548 RID: 9544
		// (get) Token: 0x0600B901 RID: 47361 RVA: 0x001B89EF File Offset: 0x001B6BEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002549 RID: 9545
		// (get) Token: 0x0600B902 RID: 47362 RVA: 0x001B89F2 File Offset: 0x001B6BF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InputSettingUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600B903 RID: 47363 RVA: 0x001B89F9 File Offset: 0x001B6BF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputSettingUpdateNotify()
		{
		}

		// Token: 0x0600B904 RID: 47364 RVA: 0x001B8A01 File Offset: 0x001B6C01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputSettingUpdateNotify(InputSettingUpdateNotify other) : this()
		{
			this.inputSettingData_ = ((other.inputSettingData_ != null) ? other.inputSettingData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B905 RID: 47365 RVA: 0x001B8A36 File Offset: 0x001B6C36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InputSettingUpdateNotify Clone()
		{
			return new InputSettingUpdateNotify(this);
		}

		// Token: 0x1700254A RID: 9546
		// (get) Token: 0x0600B906 RID: 47366 RVA: 0x001B8A3E File Offset: 0x001B6C3E
		// (set) Token: 0x0600B907 RID: 47367 RVA: 0x001B8A46 File Offset: 0x001B6C46
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

		// Token: 0x0600B908 RID: 47368 RVA: 0x001B8A4F File Offset: 0x001B6C4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InputSettingUpdateNotify);
		}

		// Token: 0x0600B909 RID: 47369 RVA: 0x001B8A5D File Offset: 0x001B6C5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InputSettingUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.InputSettingData, other.InputSettingData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B90A RID: 47370 RVA: 0x001B8A90 File Offset: 0x001B6C90
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

		// Token: 0x0600B90B RID: 47371 RVA: 0x001B8ACC File Offset: 0x001B6CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B90C RID: 47372 RVA: 0x001B8AD9 File Offset: 0x001B6CD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B90D RID: 47373 RVA: 0x001B8AE2 File Offset: 0x001B6CE2
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

		// Token: 0x0600B90E RID: 47374 RVA: 0x001B8B14 File Offset: 0x001B6D14
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

		// Token: 0x0600B90F RID: 47375 RVA: 0x001B8B54 File Offset: 0x001B6D54
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

		// Token: 0x0600B910 RID: 47376 RVA: 0x001B8BA8 File Offset: 0x001B6DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B911 RID: 47377 RVA: 0x001B8BB4 File Offset: 0x001B6DB4
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

		// Token: 0x0400516B RID: 20843
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400516C RID: 20844
		public const int InputSettingDataFieldNumber = 9;

		// Token: 0x0400516D RID: 20845
		private InputSettingData inputSettingData_;
	}
}
