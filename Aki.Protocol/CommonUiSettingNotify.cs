using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002C7 RID: 711
	[NetMessage(EMessageId.CommonUiSettingNotify)]
	public sealed class CommonUiSettingNotify : IMessage<CommonUiSettingNotify>, IMessage, IEquatable<CommonUiSettingNotify>, IDeepCloneable<CommonUiSettingNotify>, IBufferMessage
	{
		// Token: 0x06004959 RID: 18777 RVA: 0x000B3E21 File Offset: 0x000B2021
		[NullableContext(1)]
		public static CommonUiSettingNotify Create()
		{
			return new CommonUiSettingNotify();
		}

		// Token: 0x17000CD4 RID: 3284
		// (get) Token: 0x0600495A RID: 18778 RVA: 0x000B3E28 File Offset: 0x000B2028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x0600495B RID: 18779 RVA: 0x000B3E2B File Offset: 0x000B202B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CommonUiSettingNotify.Descriptor;
			}
		}

		// Token: 0x0600495C RID: 18780 RVA: 0x000B3E32 File Offset: 0x000B2032
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonUiSettingNotify()
		{
		}

		// Token: 0x0600495D RID: 18781 RVA: 0x000B3E45 File Offset: 0x000B2045
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonUiSettingNotify(CommonUiSettingNotify other) : this()
		{
			this.commonUiButtonSetting_ = other.commonUiButtonSetting_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600495E RID: 18782 RVA: 0x000B3E6F File Offset: 0x000B206F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonUiSettingNotify Clone()
		{
			return new CommonUiSettingNotify(this);
		}

		// Token: 0x17000CD6 RID: 3286
		// (get) Token: 0x0600495F RID: 18783 RVA: 0x000B3E77 File Offset: 0x000B2077
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MobileButtonSetting> CommonUiButtonSetting
		{
			get
			{
				return this.commonUiButtonSetting_;
			}
		}

		// Token: 0x06004960 RID: 18784 RVA: 0x000B3E7F File Offset: 0x000B207F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CommonUiSettingNotify);
		}

		// Token: 0x06004961 RID: 18785 RVA: 0x000B3E8D File Offset: 0x000B208D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CommonUiSettingNotify other)
		{
			return other != null && (other == this || (this.commonUiButtonSetting_.Equals(other.commonUiButtonSetting_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004962 RID: 18786 RVA: 0x000B3EC0 File Offset: 0x000B20C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.commonUiButtonSetting_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004963 RID: 18787 RVA: 0x000B3EF4 File Offset: 0x000B20F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004964 RID: 18788 RVA: 0x000B3F01 File Offset: 0x000B2101
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004965 RID: 18789 RVA: 0x000B3F0A File Offset: 0x000B210A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.commonUiButtonSetting_.WriteTo(ref output, CommonUiSettingNotify._repeated_commonUiButtonSetting_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004966 RID: 18790 RVA: 0x000B3F34 File Offset: 0x000B2134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.commonUiButtonSetting_.CalculateSize(CommonUiSettingNotify._repeated_commonUiButtonSetting_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004967 RID: 18791 RVA: 0x000B3F6D File Offset: 0x000B216D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CommonUiSettingNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.commonUiButtonSetting_.Add(other.commonUiButtonSetting_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004968 RID: 18792 RVA: 0x000B3F9B File Offset: 0x000B219B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004969 RID: 18793 RVA: 0x000B3FA4 File Offset: 0x000B21A4
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
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.commonUiButtonSetting_.AddEntriesFrom(ref input, CommonUiSettingNotify._repeated_commonUiButtonSetting_codec);
				}
			}
		}

		// Token: 0x0400307C RID: 12412
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400307D RID: 12413
		public const int CommonUiButtonSettingFieldNumber = 7;

		// Token: 0x0400307E RID: 12414
		private static readonly FieldCodec<MobileButtonSetting> _repeated_commonUiButtonSetting_codec = FieldCodec.ForMessage<MobileButtonSetting>(58U, MobileButtonSetting.Parser);

		// Token: 0x0400307F RID: 12415
		private readonly RepeatedField<MobileButtonSetting> commonUiButtonSetting_ = new RepeatedField<MobileButtonSetting>();
	}
}
