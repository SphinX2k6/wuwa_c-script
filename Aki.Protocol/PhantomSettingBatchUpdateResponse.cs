using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D00 RID: 3328
	[NetMessage(EMessageId.PhantomSettingBatchUpdateResponse)]
	public sealed class PhantomSettingBatchUpdateResponse : IMessage<PhantomSettingBatchUpdateResponse>, IMessage, IEquatable<PhantomSettingBatchUpdateResponse>, IDeepCloneable<PhantomSettingBatchUpdateResponse>, IBufferMessage
	{
		// Token: 0x06011FD6 RID: 73686 RVA: 0x002A1535 File Offset: 0x0029F735
		[NullableContext(1)]
		public static PhantomSettingBatchUpdateResponse Create()
		{
			return new PhantomSettingBatchUpdateResponse();
		}

		// Token: 0x17003B9C RID: 15260
		// (get) Token: 0x06011FD7 RID: 73687 RVA: 0x002A153C File Offset: 0x0029F73C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B9D RID: 15261
		// (get) Token: 0x06011FD8 RID: 73688 RVA: 0x002A153F File Offset: 0x0029F73F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomSettingBatchUpdateResponse.Descriptor;
			}
		}

		// Token: 0x06011FD9 RID: 73689 RVA: 0x002A1546 File Offset: 0x0029F746
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSettingBatchUpdateResponse()
		{
		}

		// Token: 0x06011FDA RID: 73690 RVA: 0x002A1559 File Offset: 0x0029F759
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSettingBatchUpdateResponse(PhantomSettingBatchUpdateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.settings_ = other.settings_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011FDB RID: 73691 RVA: 0x002A158F File Offset: 0x0029F78F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSettingBatchUpdateResponse Clone()
		{
			return new PhantomSettingBatchUpdateResponse(this);
		}

		// Token: 0x17003B9E RID: 15262
		// (get) Token: 0x06011FDC RID: 73692 RVA: 0x002A1597 File Offset: 0x0029F797
		// (set) Token: 0x06011FDD RID: 73693 RVA: 0x002A159F File Offset: 0x0029F79F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17003B9F RID: 15263
		// (get) Token: 0x06011FDE RID: 73694 RVA: 0x002A15A8 File Offset: 0x0029F7A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomSettingInfo> Settings
		{
			get
			{
				return this.settings_;
			}
		}

		// Token: 0x06011FDF RID: 73695 RVA: 0x002A15B0 File Offset: 0x0029F7B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomSettingBatchUpdateResponse);
		}

		// Token: 0x06011FE0 RID: 73696 RVA: 0x002A15C0 File Offset: 0x0029F7C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomSettingBatchUpdateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.settings_.Equals(other.settings_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011FE1 RID: 73697 RVA: 0x002A1610 File Offset: 0x0029F810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.settings_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011FE2 RID: 73698 RVA: 0x002A1663 File Offset: 0x0029F863
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011FE3 RID: 73699 RVA: 0x002A1670 File Offset: 0x0029F870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011FE4 RID: 73700 RVA: 0x002A167C File Offset: 0x0029F87C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.settings_.WriteTo(ref output, PhantomSettingBatchUpdateResponse._repeated_settings_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011FE5 RID: 73701 RVA: 0x002A16CC File Offset: 0x0029F8CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.settings_.CalculateSize(PhantomSettingBatchUpdateResponse._repeated_settings_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011FE6 RID: 73702 RVA: 0x002A1720 File Offset: 0x0029F920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomSettingBatchUpdateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.settings_.Add(other.settings_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011FE7 RID: 73703 RVA: 0x002A176D File Offset: 0x0029F96D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011FE8 RID: 73704 RVA: 0x002A1778 File Offset: 0x0029F978
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
				if (num != 8U)
				{
					if (num != 66U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.settings_.AddEntriesFrom(ref input, PhantomSettingBatchUpdateResponse._repeated_settings_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040070BA RID: 28858
		private UnknownFieldSet _unknownFields;

		// Token: 0x040070BB RID: 28859
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x040070BC RID: 28860
		private ErrorCode errorCode_;

		// Token: 0x040070BD RID: 28861
		public const int SettingsFieldNumber = 8;

		// Token: 0x040070BE RID: 28862
		private static readonly FieldCodec<PhantomSettingInfo> _repeated_settings_codec = FieldCodec.ForMessage<PhantomSettingInfo>(66U, PhantomSettingInfo.Parser);

		// Token: 0x040070BF RID: 28863
		private readonly RepeatedField<PhantomSettingInfo> settings_ = new RepeatedField<PhantomSettingInfo>();
	}
}
